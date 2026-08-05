using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D684E0", Offset = "0x7D66AE0", VA = "0x187D684E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NoEngine_Algorithms_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D67B80", Offset = "0x7D66180", VA = "0x187D67B80", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FCOJPDHPIIM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly string[] HFHJKGOGHJP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D642D0", Offset = "0x7D628D0", VA = "0x187D642D0")]
	public static bool CFINIFFOCFB(string OBIPOAMJHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D644F0", Offset = "0x7D62AF0", VA = "0x187D644F0")]
	private static bool EAINJJJAFJG(string NAAMEAFIHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D643A0", Offset = "0x7D629A0", VA = "0x187D643A0")]
	public static bool EAINJJJAFJG(Exception FJADMGBFJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D645C0", Offset = "0x7D62BC0", VA = "0x187D645C0")]
	public static string IMBEJCHNHPI(string ANKDPLMACBD, string MJMGMHHAAHB = "", bool GMEMNKBLNIL = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CDFKDMFNMDN
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D63AD0", Offset = "0x7D620D0", VA = "0x187D63AD0")]
	public static string DGEOMIANIKE(this Guid DGNNPFFMIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D63B80", Offset = "0x7D62180", VA = "0x187D63B80")]
	public static string DGEOMIANIKE(this byte[] ACDPPDBEDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D63C20", Offset = "0x7D62220", VA = "0x187D63C20")]
	public static byte[] POJFICODLMH(string DOEMIDBJCAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EDCLAAAOIJL
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate int JIHHLOCLFIA<T>([In] T OBNCJFFHHLB, [In] T ODHPFGNCGDP);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public sealed class CLNODGLCDBP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct KJMGOHDBGHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public readonly int NGFMNKONPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public readonly int AHEINAHGGJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public readonly bool PCBCKMAIMHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public int KIDMEFMPKEC;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x50101C0", Offset = "0x500E7C0", VA = "0x1850101C0")]
			public KJMGOHDBGHJ(int NGFMNKONPKM, int AHEINAHGGJJ, bool PCBCKMAIMHC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] LHPLGFDHGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly T[] EFHJCEBDCFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly JIHHLOCLFIA<T> JHNKEIFPPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly int DJHCNPCENDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Func<bool> GFOJOFDEBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int JMBGPMOIOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly KJMGOHDBGHJ[] LAHNBANCNAP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67D6200", Offset = "0x67D4800", VA = "0x1867D6200")]
		public CLNODGLCDBP(T[] LHPLGFDHGKP, JIHHLOCLFIA<T> JHNKEIFPPCK, int DJHCNPCENDJ, Func<bool> GFOJOFDEBNN, T[]? PNJLFJNKJHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67D5BC0", Offset = "0x67D41C0", VA = "0x1867D5BC0")]
		public bool HMDAMCDPHEO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate U BIAJEFDDJGO<T, U>(int GKFAFPOONAO, int ODJADKFLNAD, [In] ReadOnlySpan<T> PAMAJIDJFOH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36F7B10", Offset = "0x36F6110", VA = "0x1836F7B10")]
	public static T[] DOEIAAOKJLA<T>(int CFNMLMNHCMF, T NHAHPGKEKEL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x36F8D20", Offset = "0x36F7320", VA = "0x1836F8D20")]
	public static void KKCIJPJFJEJ<T>(this T[] JFFFMJHLHJE, T NHAHPGKEKEL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x36F8690", Offset = "0x36F6C90", VA = "0x1836F8690")]
	public static T[] GNAALOCCJEL<T>(this T[] JFFFMJHLHJE, int OHHMJGCBCKD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x36F8CA0", Offset = "0x36F72A0", VA = "0x1836F8CA0")]
	public static void JGPGMEJJJJI<T>(this T[] NBBLCIBNPBK, int DEBKJNNAPAB, int LKEGOAPIEOG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x36F85D0", Offset = "0x36F6BD0", VA = "0x1836F85D0")]
	public static void GFFELNAINBE<T>(this T[] OCACDKEJIIB, JIHHLOCLFIA<T> JHNKEIFPPCK, [Optional] T[]? PNJLFJNKJHO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x36F87A0", Offset = "0x36F6DA0", VA = "0x1836F87A0")]
	private static void IJGFJEDLJEI<T>(this T[] OCACDKEJIIB, int NGFMNKONPKM, int AHEINAHGGJJ, T[] EFHJCEBDCFP, bool PCBCKMAIMHC, JIHHLOCLFIA<T> JHNKEIFPPCK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x36F95A0", Offset = "0x36F7BA0", VA = "0x1836F95A0")]
	private static void LOEPFCKANJI<T>(this T[] OCACDKEJIIB, int LCDFEFCNDPP, int ABIENCKFLJN, T[] MIJLJBIHDMP, int FCMJGMKEOFL, int ACLCCLBMOHB, T[] OBOOAPELMPF, int CMGNFDNDBAM, JIHHLOCLFIA<T> JHNKEIFPPCK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x36F8EF0", Offset = "0x36F74F0", VA = "0x1836F8EF0")]
	public static void KNHKOGMFFKN<T>(this T[] OCACDKEJIIB, int NGFMNKONPKM, int JAALIADHHOC, JIHHLOCLFIA<T> JHNKEIFPPCK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x36F9960", Offset = "0x36F7F60", VA = "0x1836F9960")]
	public static CLNODGLCDBP<T> MCFNEJFPDJB<T>(this T[] OCACDKEJIIB, JIHHLOCLFIA<T> JHNKEIFPPCK, int DJHCNPCENDJ, Func<bool> GFOJOFDEBNN, [Optional] T[]? PNJLFJNKJHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x36F8580", Offset = "0x36F6B80", VA = "0x1836F8580")]
	public static T[] EGGGPIHMFEO<T>(this T[] NBBLCIBNPBK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x36F9A20", Offset = "0x36F8020", VA = "0x1836F9A20")]
	public static T[] MNCLPEBDKEC<T>(this T[] FBIBIKIMGDJ, T AOEHCBDDGEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x36F7CB0", Offset = "0x36F62B0", VA = "0x1836F7CB0")]
	public static T[] EADODFEMPMA<T>(this T[] FBIBIKIMGDJ, int OHHMJGCBCKD, T AOEHCBDDGEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x36F9B70", Offset = "0x36F8170", VA = "0x1836F9B70")]
	public static T[] MPGFNBAHLJK<T>(this T[] FBIBIKIMGDJ, int OHHMJGCBCKD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x36F9300", Offset = "0x36F7900", VA = "0x1836F9300")]
	public static T[] LKHKGFEILJO<T>(this T[] FBIBIKIMGDJ, int OHHMJGCBCKD, T AOEHCBDDGEA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x36F7510", Offset = "0x36F5B10", VA = "0x1836F7510")]
	public static U[] CLONFKMCPMB<U, T>(this T[] OLCBBPLHPLC, int OGPDBOOKLGM, BIAJEFDDJGO<T, U> BHKJLDCLKMK) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D63F80", Offset = "0x7D62580", VA = "0x187D63F80")]
	public static byte[] PDFHIBGOKOF(this byte[] OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D63D00", Offset = "0x7D62300", VA = "0x187D63D00")]
	public static byte[] ADKDBGNPAGE(this byte[] OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DFEODPNHONO
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D63CF0", Offset = "0x7D622F0", VA = "0x187D63CF0")]
	public static byte BONNDCOLBCC(this bool OCACDKEJIIB)
	{
		return default(byte);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CPNKNPPBFAI
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D63CF0", Offset = "0x7D622F0", VA = "0x187D63CF0")]
	public static bool CADAHEAPCJC(this byte OCACDKEJIIB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HOLDNAKKANJ
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x388B6C0", Offset = "0x3889CC0", VA = "0x18388B6C0")]
	public static void FONMAMFNLDF<T>(this ICollection<T> OCACDKEJIIB, IEnumerable<T> OOGHBEFHNIB) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OFCPBJEMCBI
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x39EDB30", Offset = "0x39EC130", VA = "0x1839EDB30")]
	public static V LMPIMAPNIGI<V, K>(this IDictionary<K, V> OCACDKEJIIB, [In] K OEHHKNIGGMI, [In] V OHLIHBDBKCE, Func<V, V> KLGNJHMABLO) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x39ED870", Offset = "0x39EBE70", VA = "0x1839ED870")]
	public static V LMPIMAPNIGI<V, K>(this IDictionary<K, V> OCACDKEJIIB, [In] K OEHHKNIGGMI, [In] V OHLIHBDBKCE, Func<V, V, V> KLGNJHMABLO) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x39EB440", Offset = "0x39E9A40", VA = "0x1839EB440")]
	public static void AOMKHPDKGHK<K, V>(this IDictionary<K, List<V>> OCACDKEJIIB, [In] K OEHHKNIGGMI, [In] V OHLIHBDBKCE) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x39EC320", Offset = "0x39EA920", VA = "0x1839EC320")]
	public static TVal DJBJOAFCKAH<TVal, TKey>(this IDictionary<TKey, TVal> BCFIBNCLPAG, [In] TKey OEHHKNIGGMI, [Optional][MAKNJFCMNJF("`default!` shouldn't be necessary in C# 9")] TVal JMMNJNFGHEP) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x39EBC80", Offset = "0x39EA280", VA = "0x1839EBC80")]
	public static TVal DJBJOAFCKAH<TVal, TKey>(this IDictionary<TKey, TVal> BCFIBNCLPAG, [In] TKey OEHHKNIGGMI, Func<TVal> IALHFIIBJNF) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x39ECF10", Offset = "0x39EB510", VA = "0x1839ECF10")]
	public static TValue KOFPLAPLCIE<TValue, TKey>(this IDictionary<TKey, TValue> BCFIBNCLPAG, [In] TKey OEHHKNIGGMI, [Optional][In][MAKNJFCMNJF("`default!` and null-oblivious region shouldn't be necessary in C# 9")] TValue JMMNJNFGHEP)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x39EE240", Offset = "0x39EC840", VA = "0x1839EE240")]
	public static V NNMJDMAENCC<V, K>(this IDictionary<K, V> OCACDKEJIIB, [In] K OEHHKNIGGMI) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x39ECD70", Offset = "0x39EB370", VA = "0x1839ECD70")]
	public static T2[] HGAAFLBNLDD<T2, T1>(this Dictionary<T1, T2>.ValueCollection PECJGEGKENO) where T2 : notnull where T1 : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BHNFFGEGPPP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool MAPGGNKAJOH<TArgs, T>([In] TArgs ODJGLJIHJOP, T HOJKNIMMINF);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate U CCIEODIBFDJ<TArg, U>([In] TArg GIOLPIPFPPJ);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate U LHMIEEEGAIN<TArg, T, U>([In] TArg GIOLPIPFPPJ, T OHDGCHLKIKP);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate U DDDHAJCMKIN<TArg, T, U>([In] TArg GIOLPIPFPPJ, IEnumerable<T> PFOGKPFJJDP);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate U MMNKMECHBNL<TArg, T, U>([In] TArg GIOLPIPFPPJ, T OHDGCHLKIKP);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct MOBFAOKGCJA<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5376810", Offset = "0x5374E10", VA = "0x185376810")]
		[MAKNJFCMNJF("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) GHGNPKKDCFD(T AGJNFJHKKDM)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5376870", Offset = "0x5374E70", VA = "0x185376870")]
		[MAKNJFCMNJF("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) LPNECAPJNOO(IEnumerable<T> EAKIKIKPBJL)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HOGDIAKNNDG<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public HOGDIAKNNDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x49F97D0", Offset = "0x49F7DD0", VA = "0x1849F97D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4B79140", Offset = "0x4B77740", VA = "0x184B79140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4B78CD0", Offset = "0x4B772D0", VA = "0x184B78CD0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4B796C0", Offset = "0x4B77CC0", VA = "0x184B796C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4B795E0", Offset = "0x4B77BE0", VA = "0x184B795E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4995280", Offset = "0x4993880", VA = "0x184995280", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MDIKNFEBJBH<T, U> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x4591430", Offset = "0x458FA30", VA = "0x184591430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x4A03E60", Offset = "0x4A02460", VA = "0x184A03E60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4A03EF0", Offset = "0x4A024F0", VA = "0x184A03EF0")]
		[DebuggerHidden]
		public MDIKNFEBJBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5338F20", Offset = "0x5337520", VA = "0x185338F20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5338710", Offset = "0x5336D10", VA = "0x185338710", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5337FB0", Offset = "0x53365B0", VA = "0x185337FB0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5338B40", Offset = "0x5337140", VA = "0x185338B40")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5338E30", Offset = "0x5337430", VA = "0x185338E30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5338C40", Offset = "0x5337240", VA = "0x185338C40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x40AB2C0", Offset = "0x40A98C0", VA = "0x1840AB2C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class JKHNOLCPJPL<T> : IEnumerable<(T, HHIMBEIEIME<T>)>, IEnumerable, IEnumerator<(T, HHIMBEIEIME<T>)>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private (T Current, HHIMBEIEIME<T> Next) <>2__current;

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
		private (T, HHIMBEIEIME<T>) System.Collections.Generic.IEnumerator<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x218B600", Offset = "0x2189C00", VA = "0x18218B600", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, HHIMBEIEIME<T>));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4E85C70", Offset = "0x4E84270", VA = "0x184E85C70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x26445A0", Offset = "0x2642BA0", VA = "0x1826445A0")]
		[DebuggerHidden]
		public JKHNOLCPJPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x450AD50", Offset = "0x4509350", VA = "0x18450AD50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4E84ED0", Offset = "0x4E834D0", VA = "0x184E84ED0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4E843F0", Offset = "0x4E829F0", VA = "0x184E843F0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4E85BD0", Offset = "0x4E841D0", VA = "0x184E85BD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4E858C0", Offset = "0x4E83EC0", VA = "0x184E858C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, HHIMBEIEIME<T>)> System.Collections.Generic.IEnumerable<(TCurrent,RecRoom.NoEngine.Common.Option<T>Next)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x40AB2C0", Offset = "0x40A98C0", VA = "0x1840AB2C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IPKNHIKLJGK<T, U> : IEnumerable<U>, IEnumerable, IEnumerator<U>, IEnumerator, IDisposable where T : notnull where U : notnull
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
		private Func<MOBFAOKGCJA<U>, T, (bool Zero, U One, IEnumerable<U> Many)> pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Func<MOBFAOKGCJA<U>, T, (bool Zero, U One, IEnumerable<U> Many)> <>3__pick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IEnumerator<T> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private IEnumerator<U> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		U IEnumerator<UnityEngine.SpookyHash.U>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (U)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public IPKNHIKLJGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4C4C550", Offset = "0x4C4AB50", VA = "0x184C4C550", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4C4C030", Offset = "0x4C4A630", VA = "0x184C4C030", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4C4BFE0", Offset = "0x4C4A5E0", VA = "0x184C4BFE0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4C4C4B0", Offset = "0x4C4AAB0", VA = "0x184C4C4B0")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4C4C500", Offset = "0x4C4AB00", VA = "0x184C4C500", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4A3E030", Offset = "0x4A3C630", VA = "0x184A3E030", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<U> IEnumerable<UnityEngine.SpookyHash.U>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x49ACDC0", Offset = "0x49AB3C0", VA = "0x1849ACDC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class BJJDBMMHCNH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BJJDBMMHCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x553E5E0", Offset = "0x553CBE0", VA = "0x18553E5E0")]
		internal bool CAEKJGBDLBB(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x633B790", Offset = "0x6339D90", VA = "0x18633B790")]
		internal bool GKMDGGEPLMJ(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IPNLCEOMOEI<T, U> : IEnumerable<(T, U)>, IEnumerable, IEnumerator<(T, U)>, IEnumerator, IDisposable where T : notnull where U : notnull
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
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((T, U));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4A38E60", Offset = "0x4A37460", VA = "0x184A38E60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x26445A0", Offset = "0x2642BA0", VA = "0x1826445A0")]
		[DebuggerHidden]
		public IPNLCEOMOEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4C4C940", Offset = "0x4C4AF40", VA = "0x184C4C940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4C4CC40", Offset = "0x4C4B240", VA = "0x184C4CC40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4C4CB60", Offset = "0x4C4B160", VA = "0x184C4CB60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(T, U)> System.Collections.Generic.IEnumerable<(TLhs,URhs)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x40AB2C0", Offset = "0x40A98C0", VA = "0x1840AB2C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x35E8370", Offset = "0x35E6970", VA = "0x1835E8370")]
	public static bool JBMMPJAGPJN<T, TArgs>(this IEnumerable<T> OCACDKEJIIB, [In] TArgs ODJGLJIHJOP, MAPGGNKAJOH<TArgs, T> PMLBLGEPBDO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D639C0", Offset = "0x7D61FC0", VA = "0x187D639C0")]
	public static bool JBMMPJAGPJN(this IEnumerable<bool> OCACDKEJIIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x35EBB80", Offset = "0x35EA180", VA = "0x1835EBB80")]
	public static U PIFCCLMHNPF<U, T>(this IEnumerable<T> OCACDKEJIIB, Func<U> HPMGEDEDAHA, Func<T, U> AGJNFJHKKDM, Func<IEnumerable<T>, U> EAKIKIKPBJL) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x35E3740", Offset = "0x35E1D40", VA = "0x1835E3740")]
	public static bool AMMCPDCIEJN<T, TArgs>(this IEnumerable<T> OCACDKEJIIB, [In] TArgs ODJGLJIHJOP, MAPGGNKAJOH<TArgs, T> PMLBLGEPBDO) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x35E95C0", Offset = "0x35E7BC0", VA = "0x1835E95C0")]
	public static U JKIPOKIJFKP<U, T, TArg>(this IEnumerable<T> OCACDKEJIIB, [In] TArg GIOLPIPFPPJ, CCIEODIBFDJ<TArg, U> HPMGEDEDAHA, LHMIEEEGAIN<TArg, T, U> AGJNFJHKKDM, DDDHAJCMKIN<TArg, T, U> EAKIKIKPBJL) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x35E54B0", Offset = "0x35E3AB0", VA = "0x1835E54B0")]
	public static IEnumerable<U> DHFCHFMKOBM<U, T, TArg>(this IEnumerable<T> OCACDKEJIIB, [In] TArg GIOLPIPFPPJ, MMNKMECHBNL<TArg, T, U> DEFCAGCPBIB) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x35E3590", Offset = "0x35E1B90", VA = "0x1835E3590")]
	public static IEnumerable<T> IHJFEJLNNGP<T>(params IEnumerable<T>[] GEPGGOLPLGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x35E6160", Offset = "0x35E4760", VA = "0x1835E6160")]
	public static bool FLFADCHKGOH<T>(this IEnumerable<T> NEKLMLONNIM, IEnumerable<T> MIJLJBIHDMP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35E3590", Offset = "0x35E1B90", VA = "0x1835E3590")]
	public static IEnumerable<(TKey?, TValue?)>? AMAMHDLJBFK<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x35E7C50", Offset = "0x35E6250", VA = "0x1835E7C50")]
	public static IEnumerable<T> IGHAKINJFAC<T, TKey>(this IEnumerable<T> HIBAJBJLMJC, Func<T, TKey> PCIAMGPDGHG) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x35EBA00", Offset = "0x35EA000", VA = "0x1835EBA00")]
	[IteratorStateMachine(typeof(HOGDIAKNNDG<>))]
	public static IEnumerable<T> OACCBDLNELK<T>(this IEnumerable<T> NEKLMLONNIM, ISet<T> NJGJLJFIMHO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x35EB390", Offset = "0x35E9990", VA = "0x1835EB390")]
	[IteratorStateMachine(typeof(MDIKNFEBJBH<, >))]
	public static IEnumerable<T> MBMMGCNDFED<T, U>(this IEnumerable<T> OCACDKEJIIB, IEnumerable<U> MIJLJBIHDMP, [Optional][MAKNJFCMNJF("`default!` shouldn't be necessary in C# 9")] T NHAHPGKEKEL) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x34E4330", Offset = "0x34E2930", VA = "0x1834E4330")]
	public static T ANDENKMDIOK<T>(this IEnumerable<T> NEKLMLONNIM, T JMMNJNFGHEP) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x35E3C80", Offset = "0x35E2280", VA = "0x1835E3C80")]
	public static T ANDENKMDIOK<T>(this IEnumerable<T> NEKLMLONNIM, T JMMNJNFGHEP, Func<T, bool> PMLBLGEPBDO) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x35E8AA0", Offset = "0x35E70A0", VA = "0x1835E8AA0")]
	public static T? JBNPDMFLNMO<T>(this IEnumerable<T> OCACDKEJIIB, Func<T, bool> PMLBLGEPBDO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x35EA320", Offset = "0x35E8920", VA = "0x1835EA320")]
	public static void KKFNFICBAJF<T>(this IEnumerable<T> OCACDKEJIIB, Action<T> AIAOPAOOPLP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x35E9CA0", Offset = "0x35E82A0", VA = "0x1835E9CA0")]
	[IteratorStateMachine(typeof(JKHNOLCPJPL<>))]
	public static IEnumerable<(T, HHIMBEIEIME<T>)> KEBEHMAHGGK<T>(this IEnumerable<T> OCACDKEJIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35E5380", Offset = "0x35E3980", VA = "0x1835E5380")]
	public static bool CIDHBNAMOIL<T>(this IEnumerable<T> OCACDKEJIIB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x35E3590", Offset = "0x35E1B90", VA = "0x1835E3590")]
	public static IEnumerable<FKGDJNIBAEN<T>> CEBFMOBHAGD<T>(this IEnumerable<T> OCACDKEJIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x35EB690", Offset = "0x35E9C90", VA = "0x1835EB690")]
	public static bool NOJJAOAIMCB<T>(this IEnumerable<T> OCACDKEJIIB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35E9580", Offset = "0x35E7B80", VA = "0x1835E9580")]
	public static IEnumerable<T> JGMOKJMNJHG<T>(this IEnumerable<T>? OCACDKEJIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x35EB2D0", Offset = "0x35E98D0", VA = "0x1835EB2D0")]
	[IteratorStateMachine(typeof(IPKNHIKLJGK<, >))]
	public static IEnumerable<U> LIHLKHIDBON<U, T>(this IEnumerable<T> OCACDKEJIIB, Func<MOBFAOKGCJA<U>, T, (bool Zero, U One, IEnumerable<U> Many)> LFBPKLFJEEE) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x35E3590", Offset = "0x35E1B90", VA = "0x1835E3590")]
	public static IEnumerable<T> GOALLFLEOHM<T>(this IEnumerable<IEnumerable<T>> OCACDKEJIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x35E65C0", Offset = "0x35E4BC0", VA = "0x1835E65C0")]
	public static int GIPGGDINMPH<T>(this IEnumerable<T> OCACDKEJIIB, int BDFCJAGPKAI = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x35E6350", Offset = "0x35E4950", VA = "0x1835E6350")]
	public static bool FMBBGPDCINO<T>(this IEnumerable<T> OCACDKEJIIB, IEnumerable<T> MIJLJBIHDMP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x35EB550", Offset = "0x35E9B50", VA = "0x1835EB550")]
	public static IEnumerable<T> MECDMFCOFDL<T>(this IEnumerable<T> OCACDKEJIIB, int DPPIHALOBFK, int NCFJKOLMKKJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x35EB6D0", Offset = "0x35E9CD0", VA = "0x1835EB6D0")]
	public static (IEnumerable<T>, IEnumerable<T>) NPJPAOAANFC<T>(this IEnumerable<T> OCACDKEJIIB, Func<T, bool> PPIFLKLEKCF) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x35E5D20", Offset = "0x35E4320", VA = "0x1835E5D20")]
	public static string ENHGNPHEJLK<T>(this IEnumerable<T> OCACDKEJIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x35E9290", Offset = "0x35E7890", VA = "0x1835E9290")]
	public static Dictionary<TKey?, TValue?>? JFHKHDHCFJC<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> NEKLMLONNIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x35E9290", Offset = "0x35E7890", VA = "0x1835E9290")]
	public static Dictionary<TKey?, TValue?>? JFHKHDHCFJC<TKey, TValue>(this IEnumerable<(TKey Key, TValue Value)> NEKLMLONNIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x35EB5D0", Offset = "0x35E9BD0", VA = "0x1835EB5D0")]
	public static List<T> MLOOJOLJFJO<T>(this IEnumerable<T> OCACDKEJIIB, int GDBMBEIFFOO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x35E6A10", Offset = "0x35E5010", VA = "0x1835E6A10")]
	public static string GKFOICMLIGI<T>(this IEnumerable<T> OCACDKEJIIB, string OLDHPDOLGFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x35E2CB0", Offset = "0x35E12B0", VA = "0x1835E2CB0")]
	public static (IReadOnlyList<T?>?, IReadOnlyList<U?>?) AIMLKDHMOOO<T, U>(this IEnumerable<(T Lhs, U Rhs)> OCACDKEJIIB)
	{
		return default((IReadOnlyList<T>, IReadOnlyList<U>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x35E6A50", Offset = "0x35E5050", VA = "0x1835E6A50")]
	[IteratorStateMachine(typeof(IPNLCEOMOEI<, >))]
	public static IEnumerable<(T, U)> HKADCLOHPPO<T, U>(this IEnumerable<T> OBNCJFFHHLB, IEnumerable<U> ODHPFGNCGDP) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x35EAD60", Offset = "0x35E9360", VA = "0x1835EAD60")]
	public static IEnumerable<V> LEMJPHFLDIC<V, T, U>(this IEnumerable<T> OCACDKEJIIB, IEnumerable<U> MIJLJBIHDMP, Func<T, U, V> NIGFPJOPIAP, [Optional][MAKNJFCMNJF("`default!` shouldn't be necessary in C# 9")] T NKKGEMGJPKB, [Optional][MAKNJFCMNJF("`default!` shouldn't be necessary in C# 9")] U CLAMAGBAEPL) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x35EAE40", Offset = "0x35E9440", VA = "0x1835EAE40")]
	public static IEnumerable<(T, U)> LEMJPHFLDIC<T, U>(this IEnumerable<T> OCACDKEJIIB, IEnumerable<U> MIJLJBIHDMP, [Optional][MAKNJFCMNJF("`default!` shouldn't be necessary in C# 9")] T NKKGEMGJPKB, [Optional][MAKNJFCMNJF("`default!` shouldn't be necessary in C# 9")] U CLAMAGBAEPL) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x35E4E40", Offset = "0x35E3440", VA = "0x1835E4E40")]
	public static TOut[] BMCDJLIHKOD<TOut, TIn>(this IEnumerable<TIn> HIBAJBJLMJC, Func<TIn, TOut> DPIJFAJDBCL) where TOut : notnull where TIn : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x35E3D00", Offset = "0x35E2300", VA = "0x1835E3D00")]
	public static HHIMBEIEIME<U> BHJBICPLADM<U, T>(this IEnumerable<T> IKCGIPBAPFL, Func<T, U> LEEADKOIOFL) where U : notnull where T : notnull
	{
		return default(HHIMBEIEIME<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x35E6B10", Offset = "0x35E5110", VA = "0x1835E6B10")]
	public static IEnumerable<KeyValuePair<TKey, List<TItem>>> HNMPAOJJGFC<TKey, TItem>(this IEnumerable<IEnumerable<TItem>> DHLGAIMCINE, Func<TItem, TKey> KBGCFIDENLF) where TKey : notnull where TItem : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class EDHDGIAACOL
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x36F9C20", Offset = "0x36F8220", VA = "0x1836F9C20")]
	public static bool ADBPKKLEBLC<T, U>(this T OCACDKEJIIB, [In] U BOMDCGFKGKF) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x36F9E40", Offset = "0x36F8440", VA = "0x1836F9E40")]
	public static bool MKMALAMHOOE<T>(T OCACDKEJIIB, T MIJLJBIHDMP) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class FGOGCJIFCOD
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x14DFB70", Offset = "0x14DE170", VA = "0x1814DFB70")]
	public static bool AIAKMJOBFNE([In] this float3 FDJHCIBLFFB, float3 CNIMJCCKEDM, float CAMDCBEFAPJ = 1E-05f)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DAALDDIKMDM
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class KCPHLFAGMKN<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : notnull
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
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4A28AB0", Offset = "0x4A270B0", VA = "0x184A28AB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x26445A0", Offset = "0x2642BA0", VA = "0x1826445A0")]
		[DebuggerHidden]
		public KCPHLFAGMKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4F92AE0", Offset = "0x4F910E0", VA = "0x184F92AE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4F92EF0", Offset = "0x4F914F0", VA = "0x184F92EF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4F92CB0", Offset = "0x4F912B0", VA = "0x184F92CB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x45F38E0", Offset = "0x45F1EE0", VA = "0x1845F38E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x36AD840", Offset = "0x36ABE40", VA = "0x1836AD840")]
	public static void KKEOEFAOGFJ<T>(this T LEMBKBGMCDG, Action<T> EONHDKPCELB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x36AD890", Offset = "0x36ABE90", VA = "0x1836AD890")]
	public static V LHCHIKAALHB<V, T>(this T LEMBKBGMCDG, Func<T, V> EONHDKPCELB, [Optional][MAKNJFCMNJF("`default!` shouldn't be necessary in C# 9")] V JMMNJNFGHEP) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x36AD970", Offset = "0x36ABF70", VA = "0x1836AD970")]
	public static T? OFOPAGIPJGB<T>(this T OCACDKEJIIB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x36AD5E0", Offset = "0x36ABBE0", VA = "0x1836AD5E0")]
	[IteratorStateMachine(typeof(KCPHLFAGMKN<>))]
	public static IEnumerable<T> DMFICCFDCLF<T>(this T OCACDKEJIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x36AD720", Offset = "0x36ABD20", VA = "0x1836AD720")]
	public static T[] KCHDFMFLPBB<T>(this T OCACDKEJIIB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LIKIKKLMLED
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly MD5 EIAFKDJFOFG;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static readonly SHA1 GOPKJEEAOIK;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly byte[] BFEMCNKONAF;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static readonly byte[] PCLHHBOEPHK;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7D67610", Offset = "0x7D65C10", VA = "0x187D67610")]
	static LIKIKKLMLED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7D67470", Offset = "0x7D65A70", VA = "0x187D67470")]
	public static Guid NFDEIIAHBAC([In] Guid FDJHCIBLFFB, [In] Guid CNIMJCCKEDM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D67520", Offset = "0x7D65B20", VA = "0x187D67520")]
	public static Guid NFDEIIAHBAC([In] Guid FDJHCIBLFFB, [In] Guid CNIMJCCKEDM, [In] Guid JKIBOICMIDJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3916680", Offset = "0x3914C80", VA = "0x183916680")]
	public static Guid FLLMCNLHKNL<T>([In] Guid OMBGDAPNAGL, T OHLIHBDBKCE, int DJNGLBELENN = 5) where T : struct
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7D67350", Offset = "0x7D65950", VA = "0x187D67350")]
	public static Guid FLLMCNLHKNL([In] Guid OMBGDAPNAGL, string NFHOBPDKIPM, int DJNGLBELENN = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7D670D0", Offset = "0x7D656D0", VA = "0x187D670D0")]
	private static Guid FLLMCNLHKNL([In] Guid OMBGDAPNAGL, byte[] OHLIHBDBKCE, int DDGBDMFPMAI, int DJNGLBELENN = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3916560", Offset = "0x3914B60", VA = "0x183916560")]
	private static void DGGHLLHOJIE<T>([In] T KIDPOMGFMKB, Span<byte> ELDDEEODOKE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3916AC0", Offset = "0x39150C0", VA = "0x183916AC0")]
	private static T GNLHDGNEFED<T>(Span<byte> KIDPOMGFMKB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7D67010", Offset = "0x7D65610", VA = "0x187D67010")]
	private static void CFMHAJMBGDH(byte[] DGNNPFFMIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7D67420", Offset = "0x7D65A20", VA = "0x187D67420")]
	private static void HNDFKAEHDHM(byte[] DGNNPFFMIEE, int JOOBCOFNIAM, int MCIIEEEAOOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class MDPIOAHNEKB
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7D67C30", Offset = "0x7D66230", VA = "0x187D67C30")]
	public static int CHMLFCBNEFG(this int OCACDKEJIIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7D67DA0", Offset = "0x7D663A0", VA = "0x187D67DA0")]
	public static int MCKALPHCOPJ(this int OCACDKEJIIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7D67D50", Offset = "0x7D66350", VA = "0x187D67D50")]
	public static int MABFHGGKPKB(this int OCACDKEJIIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7D67DE0", Offset = "0x7D663E0", VA = "0x187D67DE0")]
	public static int MPBCHGJHFKL(this int OCACDKEJIIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6BD0", Offset = "0x6AE51D0", VA = "0x186AE6BD0")]
	public static int OHAFHKMDDGO(this int OCACDKEJIIB, int JAALIADHHOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E4F0", Offset = "0x6C1CAF0", VA = "0x186C1E4F0")]
	public static int JFCKHHDJPEH(this int OCACDKEJIIB, int JAALIADHHOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7D67C10", Offset = "0x7D66210", VA = "0x187D67C10")]
	public static float BABFPFIJPEE(this int OCACDKEJIIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7D67CA0", Offset = "0x7D662A0", VA = "0x187D67CA0")]
	public static (byte, byte, byte, byte) DFBJJLCNHLL(this int OCACDKEJIIB)
	{
		return default((byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7D67D20", Offset = "0x7D66320", VA = "0x187D67D20")]
	public static int IKPOKDMPCLN([In] this (byte Fourth, byte Third, byte Second, byte First) OCACDKEJIIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7D67D10", Offset = "0x7D66310", VA = "0x187D67D10")]
	public static int DKIFELIAFPO(this int OCACDKEJIIB, int BEKMMOGGKEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7D67D40", Offset = "0x7D66340", VA = "0x187D67D40")]
	public static int JJHOGEEEIHE(this int OCACDKEJIIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NEOIGGGNGDH
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7D68290", Offset = "0x7D66890", VA = "0x187D68290")]
	public static (byte, byte, byte, byte, byte, byte, byte, byte) DFBJJLCNHLL(this long OCACDKEJIIB)
	{
		return default((byte, byte, byte, byte, byte, byte, byte, byte));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7D68490", Offset = "0x7D66A90", VA = "0x187D68490")]
	public static long LEEHODLKNKP([In] this (byte Eighth, byte Seventh, byte Sixth, byte Fifth, byte Fourth, byte Third, byte Second, byte First) OCACDKEJIIB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7D68430", Offset = "0x7D66A30", VA = "0x187D68430")]
	public static string KBFBDNIFGCA(this long OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7D683C0", Offset = "0x7D669C0", VA = "0x187D683C0")]
	public static string JBBGPIABJPO(this long OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7D68350", Offset = "0x7D66950", VA = "0x187D68350")]
	public static string JABMCIHKDLE(this long OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7D68150", Offset = "0x7D66750", VA = "0x187D68150")]
	public static string AFGKPOOLBJN(this long OCACDKEJIIB, long LMGOAMMFPKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PJGBJAPPPDK
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int ACAGEKDEDPM(int HJPIPDBMEJE, int JNMDCGCOPJH);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float BLJAALIFCFK(float JINMCCPOIIM, float GHHGLLPEABO);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface EKCKPMGKAJH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	long GFMCICLJBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class BLMHHEEPHDP
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x35EC300", Offset = "0x35EA900", VA = "0x1835EC300")]
	public static (TKey?, TValue?) ADOIGPLMCAK<TKey, TValue>([In] this KeyValuePair<TKey, TValue> OCACDKEJIIB)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x35EC460", Offset = "0x35EAA60", VA = "0x1835EC460")]
	public static KeyValuePair<TKey?, UValue?> DPHCCKBIJBP<TKey, UValue, TValue>(this KeyValuePair<TKey, TValue> OCACDKEJIIB, UValue OHLIHBDBKCE)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class CAGCMNIBOMK
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class PJBPEGENELO<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PJBPEGENELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x561D9F0", Offset = "0x561BFF0", VA = "0x18561D9F0")]
		internal TElement JJIIHDCLBPI(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3646900", Offset = "0x3644F00", VA = "0x183646900")]
	public static int BJKEFMAAIEP<T>(this IReadOnlyList<T> NBBLCIBNPBK, T OHLIHBDBKCE) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x364A950", Offset = "0x3648F50", VA = "0x18364A950")]
	public static int HOPMPELFEGH<T>(this IReadOnlyList<T> NBBLCIBNPBK, T OHLIHBDBKCE) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x36492A0", Offset = "0x36478A0", VA = "0x1836492A0")]
	public static void FONMAMFNLDF<T>(this HashSet<T> IAPBGHPGJBH, IEnumerable<T> OOGHBEFHNIB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3646160", Offset = "0x3644760", VA = "0x183646160")]
	public static void BGOHLMFBFLE<T>(this IList<T> OLEDHEBBJPH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x36461F0", Offset = "0x36447F0", VA = "0x1836461F0")]
	public static void BGOHLMFBFLE<T>(this IList<T> OLEDHEBBJPH, int IFBCFBDMJEA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3647760", Offset = "0x3645D60", VA = "0x183647760")]
	public static void CKCFMJANIDO<T>(this List<T> OLEDHEBBJPH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3645A30", Offset = "0x3644030", VA = "0x183645A30")]
	public static bool BBJKAOMFIAA<T>(this IList<T> ENJOLJLINPM, Predicate<T> DGNJHMCAKGC, [Out][NotNullWhen(true)] List<T>? ODINJIHAIHI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3645FE0", Offset = "0x36445E0", VA = "0x183645FE0")]
	public static List<T> BBJKAOMFIAA<T>(this List<T> ENJOLJLINPM, Predicate<T> DGNJHMCAKGC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3646BA0", Offset = "0x36451A0", VA = "0x183646BA0")]
	public static int BJKEFMAAIEP<T>(this IReadOnlyList<T> OLEDHEBBJPH, Predicate<T> PMLBLGEPBDO) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x364DC00", Offset = "0x364C200", VA = "0x18364DC00")]
	public static bool LDOGMMKGMEO<T>(this IReadOnlyList<T> OLEDHEBBJPH, Predicate<T> PMLBLGEPBDO, [Out][NotNullWhen(true)] List<int>? HKHJDBHLOPP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3648880", Offset = "0x3646E80", VA = "0x183648880")]
	public static bool DGAEJOHLCDJ<T>(this IReadOnlyList<T> OLEDHEBBJPH, T HOJKNIMMINF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3648900", Offset = "0x3646F00", VA = "0x183648900")]
	public static bool DGAEJOHLCDJ<T>(this IReadOnlyList<T> OLEDHEBBJPH, T HOJKNIMMINF, EqualityComparer<T> EFGNCEEFOAD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x364D0D0", Offset = "0x364B6D0", VA = "0x18364D0D0")]
	public static int KMDBPDGLIJG<TElement, TKey>(this IList<TElement> MMODMCDBGPO, TKey ENOGAJHBFFO, Func<TElement, TKey> CBMFAEAKBBE, [Optional] Func<TKey, TKey, int>? JHNKEIFPPCK, int OHHMJGCBCKD = 0, [Optional] int? JAALIADHHOC) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x364CD30", Offset = "0x364B330", VA = "0x18364CD30")]
	public static int KMDBPDGLIJG<TElement, TKey>(Func<int, TElement> EMIOFONINDL, int KMEFINBGHNG, TKey ENOGAJHBFFO, Func<TElement, TKey> CBMFAEAKBBE, [Optional] Func<TKey, TKey, int>? JHNKEIFPPCK, int OHHMJGCBCKD = 0, [Optional] int? JAALIADHHOC) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3647C00", Offset = "0x3646200", VA = "0x183647C00")]
	public static bool DFDNNOAFGHJ<T>(this List<T> OLEDHEBBJPH, T HOJKNIMMINF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3648A60", Offset = "0x3647060", VA = "0x183648A60")]
	public static void DGFFJIMBGNG<T>(this List<T> OLEDHEBBJPH, IEnumerable<T> ENJOLJLINPM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x364A310", Offset = "0x3648910", VA = "0x18364A310")]
	public static void GNAALOCCJEL<T>(this List<T> OLEDHEBBJPH, IEnumerable<T> ENJOLJLINPM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3645850", Offset = "0x3643E50", VA = "0x183645850")]
	public static T AGLOKNHOADD<T>(this List<T> ENJOLJLINPM, Predicate<T> DGNJHMCAKGC) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x364E3C0", Offset = "0x364C9C0", VA = "0x18364E3C0")]
	public static T NLMGOCNHJLL<T>(this List<T> ENJOLJLINPM, int OHHMJGCBCKD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x36491A0", Offset = "0x36477A0", VA = "0x1836491A0")]
	public static void FMOLGLEKKMF<T>(this List<T> OLEDHEBBJPH, int OHHMJGCBCKD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3645990", Offset = "0x3643F90", VA = "0x183645990")]
	public static bool AIHKFGDGNGI<T>(this List<T> OLEDHEBBJPH, T HOJKNIMMINF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3648F90", Offset = "0x3647590", VA = "0x183648F90")]
	public static bool ENDIGBDPIGA<T>(this List<T> DJMLMJDBPKJ, List<T> PBEJJKLPBLP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x364E4B0", Offset = "0x364CAB0", VA = "0x18364E4B0")]
	public static T PBFGPLPPHKC<T>(this IList<T> OLEDHEBBJPH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x36458E0", Offset = "0x3643EE0", VA = "0x1836458E0")]
	public static bool AGOCGIANFMH<T>(IReadOnlyList<T>? OLEDHEBBJPH, int OHHMJGCBCKD, [Out][MAKNJFCMNJF("This should be `T?` in C# 9.")][MaybeNullWhen(false)] T OBOOAPELMPF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x364BE20", Offset = "0x364A420", VA = "0x18364BE20")]
	public static bool JBLFHHGNDKF<T>(IReadOnlyList<T> OLEDHEBBJPH, ICollection ENJOLJLINPM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x364A7A0", Offset = "0x3648DA0", VA = "0x18364A7A0")]
	public static void HNOFCAHFEID<T>(IReadOnlyList<T> OLEDHEBBJPH, ICollection ENJOLJLINPM) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x364E460", Offset = "0x364CA60", VA = "0x18364E460")]
	public static bool OFKFLDNMAEK<T>(this IReadOnlyList<T> OLEDHEBBJPH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x364E550", Offset = "0x364CB50", VA = "0x18364E550")]
	public static string POJKEJGLFME<T>(this IEnumerable<T> OLEDHEBBJPH, string NGGGJIEBHDG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3648EE0", Offset = "0x36474E0", VA = "0x183648EE0")]
	public static T EJPLFPMNJIC<T>(this IList<T> OCACDKEJIIB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x364E1A0", Offset = "0x364C7A0", VA = "0x18364E1A0")]
	public static T MHLIFNDKJHD<T>(this IList<T> OCACDKEJIIB) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x364A710", Offset = "0x3648D10", VA = "0x18364A710")]
	public static void HMJMDKIBAJC<T>(this IList<T> OCACDKEJIIB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x364CB90", Offset = "0x364B190", VA = "0x18364CB90")]
	public static void JCEFHNDNLHB<T>(this IList<T> OCACDKEJIIB, [In] T OHLIHBDBKCE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x364E0A0", Offset = "0x364C6A0", VA = "0x18364E0A0")]
	public static T LMPPBBKAIEL<T>(this IList<T> OCACDKEJIIB) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class KJPKKNICDEC
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static float MJDKGHAGDLP;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static float OBBKKLNIMEN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static bool PJGHBENOMDG;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly float PBMHBFMGBNI;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7D66DA0", Offset = "0x7D653A0", VA = "0x187D66DA0")]
	public static bool MNMMBLGAHPL(float FDJHCIBLFFB, float CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7D66910", Offset = "0x7D64F10", VA = "0x187D66910")]
	public static float BFLFIFNBAKE(float OHLIHBDBKCE, float COJGDIKBGKB, float JNIBMOMFMLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7D66930", Offset = "0x7D64F30", VA = "0x187D66930")]
	public static int BFLFIFNBAKE(int OHLIHBDBKCE, int COJGDIKBGKB, int JNIBMOMFMLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7D66C70", Offset = "0x7D65270", VA = "0x187D66C70")]
	public static float LPPHKNDPIBJ(float OHLIHBDBKCE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7D66870", Offset = "0x7D64E70", VA = "0x187D66870")]
	public static float BFDBBHGIMCE(float FDJHCIBLFFB, float CNIMJCCKEDM, float LEMBKBGMCDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7D66A80", Offset = "0x7D65080", VA = "0x187D66A80")]
	public static float HBDLMJPAHNP(float FDJHCIBLFFB, float CNIMJCCKEDM, float LEMBKBGMCDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7D66E90", Offset = "0x7D65490", VA = "0x187D66E90")]
	public static float NHGEFIMHJOM(float FDJHCIBLFFB, float CNIMJCCKEDM, float OHLIHBDBKCE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7D66A40", Offset = "0x7D65040", VA = "0x187D66A40")]
	public static float GLEDMHMICNP(float FDJHCIBLFFB, float CNIMJCCKEDM, float OHLIHBDBKCE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7D66A90", Offset = "0x7D65090", VA = "0x187D66A90")]
	public static float INMGPHGEKEC(float FDJHCIBLFFB, float CNIMJCCKEDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7D66AB0", Offset = "0x7D650B0", VA = "0x187D66AB0")]
	public static float JPAFIDIFAMJ(float HFINKANMECH, float FCPOJLOEIEO, float OJJJHCFGALA, float AOPGDILOKKK, float LNKOBALGGOE, float CJIPMCGKHCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7D66C90", Offset = "0x7D65290", VA = "0x187D66C90")]
	public static float MLDLJKGKOCE(float OHLIHBDBKCE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7D66950", Offset = "0x7D64F50", VA = "0x187D66950")]
	public static float BLJMHOPNAAD(float OHLIHBDBKCE, float COJGDIKBGKB, float JNIBMOMFMLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7D66D20", Offset = "0x7D65320", VA = "0x187D66D20")]
	public static float MMPEGAKFPBI(float IEPELDNMGLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67E17F0", Offset = "0x67DFDF0", VA = "0x1867E17F0")]
	public static int IFBNFPJCEDB(int DEBKJNNAPAB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class HCHGBNBPKHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private System.Random GLJGABEDGOK;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7D65350", Offset = "0x7D63950", VA = "0x187D65350")]
	public HCHGBNBPKHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7D653E0", Offset = "0x7D639E0", VA = "0x187D653E0")]
	public HCHGBNBPKHG(int IFBCFBDMJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7335540", Offset = "0x7333B40", VA = "0x187335540", Slot = "4")]
	public virtual int ACAGEKDEDPM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7D652F0", Offset = "0x7D638F0", VA = "0x187D652F0", Slot = "5")]
	public virtual int ACAGEKDEDPM(int JNMDCGCOPJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7D652C0", Offset = "0x7D638C0", VA = "0x187D652C0", Slot = "6")]
	public virtual int ACAGEKDEDPM(int HJPIPDBMEJE, int JNMDCGCOPJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7D65320", Offset = "0x7D63920", VA = "0x187D65320")]
	public double OKNGCLNKOMF()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PJMLJLIDHHO
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3A11500", Offset = "0x3A0FB00", VA = "0x183A11500")]
	[HCCKFFEHNEM("This should be replaced with the `is not` operator in C# 9.")]
	public static bool OLDKHPNIIIB<T>(this object OCACDKEJIIB, [Out][NotNullWhen(true)] T OBOOAPELMPF) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class OIAOBPPFIPH
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7D69520", Offset = "0x7D67B20", VA = "0x187D69520")]
	public static (float3, float3, float3) EHFFBADEJFE([In] this quaternion OCACDKEJIIB)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7D68900", Offset = "0x7D66F00", VA = "0x187D68900")]
	private static float3 AIHKADKOLBC(quaternion JENEMHABFIH, math.RotationOrder PFCGPNCOPEG = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7D69270", Offset = "0x7D67870", VA = "0x187D69270")]
	private static float3 BGCCAGPAMDP(float3 GLIEMCJCMML, math.RotationOrder PFCGPNCOPEG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7D69610", Offset = "0x7D67C10", VA = "0x187D69610")]
	public static float3 NCGHKGIIMKF(this quaternion JENEMHABFIH, math.RotationOrder PFCGPNCOPEG = math.RotationOrder.ZXY)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7D69340", Offset = "0x7D67940", VA = "0x187D69340")]
	public static float BJGCIKBFEMO(this quaternion OBNCJFFHHLB, quaternion ODHPFGNCGDP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7D68620", Offset = "0x7D66C20", VA = "0x187D68620")]
	public static quaternion AABKABPENHE(this quaternion OOBEGCNALKF, float3 FIFJOOIEEIG)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7D69490", Offset = "0x7D67A90", VA = "0x187D69490")]
	[CompilerGenerated]
	internal static float3 CGJFNHBNGEA(float3 GLIEMCJCMML)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class OKCICPNPEPE
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private sealed class OJFEHNCMFOB : PJGBJAPPPDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly System.Random CFMHKJBJMPI;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7D652C0", Offset = "0x7D638C0", VA = "0x187D652C0", Slot = "4")]
		public int ACAGEKDEDPM(int JINMCCPOIIM, int ELCDONKIKBN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7D696C0", Offset = "0x7D67CC0", VA = "0x187D696C0", Slot = "5")]
		public float BLJAALIFCFK(float JINMCCPOIIM, float GHHGLLPEABO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7D69730", Offset = "0x7D67D30", VA = "0x187D69730")]
		private double MJCHOJGLIOC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7D69770", Offset = "0x7D67D70", VA = "0x187D69770")]
		public OJFEHNCMFOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly PJGBJAPPPDK IBIALEMMIDH;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7D697F0", Offset = "0x7D67DF0", VA = "0x187D697F0")]
	public static ulong DODHEELKEHA()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class FEACLOFLNAE
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x385BAE0", Offset = "0x385A0E0", VA = "0x18385BAE0")]
	public static bool BJKAIHBBNOD<T>(this IReadOnlyCollection<T> OCACDKEJIIB, int OHHMJGCBCKD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HGEIPHAHFOD
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3886210", Offset = "0x3884810", VA = "0x183886210")]
	public static bool DJKPNGENBIE<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> OCACDKEJIIB, IReadOnlyDictionary<TKey, TValue> MIJLJBIHDMP) where TKey : notnull where TValue : notnull, IEquatable<TValue>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OPAJCGAEHDM
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3A02180", Offset = "0x3A00780", VA = "0x183A02180")]
	public static TValue? MAHFMPFGDHC<TValue, TKey>(this IReadOnlyDictionary<TKey, TValue> OCACDKEJIIB, TKey OEHHKNIGGMI) where TValue : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class AHFACBJNEHL
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct KJKHKNJLCHD<T> : IEnumerator<T>, IEnumerator, IDisposable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly IReadOnlyList<T> LHKCGKINFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int PHHGAGPDGEG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x500FF70", Offset = "0x500E570", VA = "0x18500FF70", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x500FF30", Offset = "0x500E530", VA = "0x18500FF30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xC18F80", Offset = "0xC17580", VA = "0x180C18F80")]
		private KJKHKNJLCHD(IReadOnlyList<T> OLEDHEBBJPH, int OHHMJGCBCKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4AC6340", Offset = "0x4AC4940", VA = "0x184AC6340")]
		public static KJKHKNJLCHD<T> ACADPGMDEBE(IReadOnlyList<T> OLEDHEBBJPH)
		{
			return default(KJKHKNJLCHD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public readonly void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x500FEC0", Offset = "0x500E4C0", VA = "0x18500FEC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x278F090", Offset = "0x278D690", VA = "0x18278F090", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public readonly struct LJNCHPBODFK<T> : IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly KJKHKNJLCHD<T> OKLIBDLOGKI;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x273F2B0", Offset = "0x273D8B0", VA = "0x18273F2B0")]
		private LJNCHPBODFK(KJKHKNJLCHD<T> FMKNFJBKBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x514FA00", Offset = "0x514E000", VA = "0x18514FA00")]
		public static LJNCHPBODFK<T> ACADPGMDEBE(IReadOnlyList<T> OLEDHEBBJPH)
		{
			return default(LJNCHPBODFK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public KJKHKNJLCHD<T> OMLAPONJPHN()
		{
			return default(KJKHKNJLCHD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x514FAC0", Offset = "0x514E0C0", VA = "0x18514FAC0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x514FAC0", Offset = "0x514E0C0", VA = "0x18514FAC0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7D63720", Offset = "0x7D61D20", VA = "0x187D63720")]
	public static void CIBKKMOJDEC(this IReadOnlyList<Action> OCACDKEJIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3FBF710", Offset = "0x3FBDD10", VA = "0x183FBF710")]
	public static bool LKMKPGKLGLC<T>(this IReadOnlyList<T> OCACDKEJIIB, int OHHMJGCBCKD, [Out][NotNullWhen(true)][MAKNJFCMNJF("This should be `T?` in C# 9.")] T OBOOAPELMPF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3FBF920", Offset = "0x3FBDF20", VA = "0x183FBF920")]
	public static bool NAGCMKJCEHF<T>(this IReadOnlyList<T> OCACDKEJIIB, int OHHMJGCBCKD, [Out] FKGDJNIBAEN<T> OBOOAPELMPF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3FBF570", Offset = "0x3FBDB70", VA = "0x183FBF570")]
	public static T IGGEOEILFGN<T>(this IReadOnlyList<T> OCACDKEJIIB, int OHHMJGCBCKD, [In] T AHOAHDEHKLA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3A08130", Offset = "0x3A06730", VA = "0x183A08130")]
	[MAKNJFCMNJF("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T FBDKKFIACIN<T>(this IReadOnlyList<T> OCACDKEJIIB, int OHHMJGCBCKD) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3FBF860", Offset = "0x3FBDE60", VA = "0x183FBF860")]
	public static T? MAHFMPFGDHC<T>(this IReadOnlyList<T> OCACDKEJIIB, int OHHMJGCBCKD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x386E7A0", Offset = "0x386CDA0", VA = "0x18386E7A0")]
	public static LJNCHPBODFK<T> IFIHEFNLFFC<T>(this IReadOnlyList<T> OCACDKEJIIB) where T : notnull
	{
		return default(LJNCHPBODFK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JJKHCEENIMO
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x38D0F50", Offset = "0x38CF550", VA = "0x1838D0F50")]
	public static int KBEMGMDGBFE<T>([In] this ReadOnlySequence<T> NFKNDNEHMAF, [In] T OHLIHBDBKCE) where T : IEquatable<T>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x38D1250", Offset = "0x38CF850", VA = "0x1838D1250")]
	public static bool OHEAJMECCHI<T>([In] this ReadOnlySequence<T> NFKNDNEHMAF, [In] ReadOnlySpan<T> MIJLJBIHDMP) where T : IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class FHMPBCDLBNK
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x38610F0", Offset = "0x385F6F0", VA = "0x1838610F0")]
	public static string ENHGNPHEJLK<T>([In] this ReadOnlySpan<T> OCACDKEJIIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x38619A0", Offset = "0x385FFA0", VA = "0x1838619A0")]
	public static string GKFOICMLIGI<T>([In] this ReadOnlySpan<T> OCACDKEJIIB, string OLDHPDOLGFD) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct JDNKLJHMIKH : EKCKPMGKAJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly EKCKPMGKAJH FDAAEPDHALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly long KJLIEDADINN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long GFMCICLJBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7D664F0", Offset = "0x7D64AF0", VA = "0x187D664F0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double AEEOFBLNDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7D66670", Offset = "0x7D64C70", VA = "0x187D66670")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public double GMGNIFNDIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7D665B0", Offset = "0x7D64BB0", VA = "0x187D665B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1A895E0", Offset = "0x1A87BE0", VA = "0x181A895E0")]
	public JDNKLJHMIKH(EKCKPMGKAJH DMDPGLMBCKJ, long JFGBCPNGOCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LIPHAFJGIKC
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static EKCKPMGKAJH HOMCOBAGOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7D678D0", Offset = "0x7D65ED0", VA = "0x187D678D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7D679B0", Offset = "0x7D65FB0", VA = "0x187D679B0")]
	public static long KHIJJNLFPMD(this EKCKPMGKAJH OCACDKEJIIB, long JFGBCPNGOCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7D67840", Offset = "0x7D65E40", VA = "0x187D67840")]
	public static double GEOONLPHPDL(this EKCKPMGKAJH OCACDKEJIIB, long JFGBCPNGOCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7D67920", Offset = "0x7D65F20", VA = "0x187D67920")]
	public static double KGHMEAFLDND(this EKCKPMGKAJH OCACDKEJIIB, long JFGBCPNGOCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7D677C0", Offset = "0x7D65DC0", VA = "0x187D677C0")]
	public static JDNKLJHMIKH FAANACAHEOK(this EKCKPMGKAJH OCACDKEJIIB)
	{
		return default(JDNKLJHMIKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class JNCCHOOFIMB : EKCKPMGKAJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly Stopwatch OCJDKMGENHG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public long GFMCICLJBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7D667E0", Offset = "0x7D64DE0", VA = "0x187D667E0", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	private JNCCHOOFIMB(Stopwatch GNFGHEJOPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7D66800", Offset = "0x7D64E00", VA = "0x187D66800")]
	public static JNCCHOOFIMB NEHNLLGONDO(Stopwatch GNFGHEJOPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7D66730", Offset = "0x7D64D30", VA = "0x187D66730")]
	public static JNCCHOOFIMB BBGMPJNCDFF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class LLKJPAOPHOH
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7C47B20", Offset = "0x7C46120", VA = "0x187C47B20")]
	public static float3 JDIDBFBLCOH([In] this RigidTransform OCACDKEJIIB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7C47C50", Offset = "0x7C46250", VA = "0x187C47C50")]
	public static float3 OFIDGHFDCCB([In] this RigidTransform OCACDKEJIIB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1198DB0", Offset = "0x11973B0", VA = "0x181198DB0")]
	public static (float3, float3, float3) ONFIFOPDDDD([In] this RigidTransform OCACDKEJIIB)
	{
		return default((float3, float3, float3));
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7D67B20", Offset = "0x7D66120", VA = "0x187D67B20")]
	public static RigidTransform GADDKEAOBGN([In] this RigidTransform OCACDKEJIIB)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class OHKKBKENNNE
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7D68560", Offset = "0x7D66B60", VA = "0x187D68560")]
	public static RigidTransform ACFBFGFPPGM(RigidTransform MJDABOIEKND, RigidTransform LGDLGKEEPCK)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class EPBEBLPOIEL
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7D64290", Offset = "0x7D62890", VA = "0x187D64290")]
	public static float OAEAPMFMBBI([In] this (byte Fourth, byte Third, byte Second, byte First) OCACDKEJIIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7D64210", Offset = "0x7D62810", VA = "0x187D64210")]
	public static int CBOCIIPBABF(this float OCACDKEJIIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7D64220", Offset = "0x7D62820", VA = "0x187D64220")]
	public static (byte, byte, byte, byte) DFBJJLCNHLL(this float OCACDKEJIIB)
	{
		return default((byte, byte, byte, byte));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class BBPEDJCKJNK
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x35BBE60", Offset = "0x35BA460", VA = "0x1835BBE60")]
	public static ReadOnlySpan<T?> FBBAPDPHGJN<T>([In] this Span<T> OCACDKEJIIB)
	{
		return default(ReadOnlySpan<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class MPLDJADFBOB
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7D680F0", Offset = "0x7D666F0", VA = "0x187D680F0")]
	public static StringBuilder HPHKHJMKOLE(this StringBuilder OCACDKEJIIB, int MJEIALFOHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7D68080", Offset = "0x7D66680", VA = "0x187D68080")]
	public static StringBuilder GBIOBIIGNEP(this StringBuilder OCACDKEJIIB, int MJEIALFOHOF, string ANKDPLMACBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7D68020", Offset = "0x7D66620", VA = "0x187D68020")]
	public static StringBuilder FHOCDGJHABO(this StringBuilder OCACDKEJIIB, char DMKCMGKGHLO, int MOIEDDOHJCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class IHENHOCBIHE
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static Regex IAADDELGOHG;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static Regex OPFGKOEMJMD;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly char[] JAOBDMHNMLG;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly string[] LLLGAIFCFDG;

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6F02560", Offset = "0x6F00B60", VA = "0x186F02560")]
	public static bool OFKFLDNMAEK(this string? AMDHAEEMHLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7D65610", Offset = "0x7D63C10", VA = "0x187D65610")]
	public static string? BPPGFFCJFNI(this string? OCACDKEJIIB, int HOMPFMAAAKM, string GPGHLHEIBAF = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7D65EF0", Offset = "0x7D644F0", VA = "0x187D65EF0")]
	public static string OCIMGOENJDE(this string OCACDKEJIIB, int HOMPFMAAAKM, string GPGHLHEIBAF = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7D66070", Offset = "0x7D64670", VA = "0x187D66070")]
	public static int OJNFLPMOLBJ(this string AMDHAEEMHLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7D656F0", Offset = "0x7D63CF0", VA = "0x187D656F0")]
	public static string DMGIKGOGMEG(this string ANKDPLMACBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7D65E40", Offset = "0x7D64440", VA = "0x187D65E40")]
	public static string LIAJGDCECKJ(this string AMDHAEEMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7D65F90", Offset = "0x7D64590", VA = "0x187D65F90")]
	public static string[] OHNIIBKNDJJ(this string AMDHAEEMHLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7D65D70", Offset = "0x7D64370", VA = "0x187D65D70")]
	private static bool LDLALCDJAAO(string HKOKFJFBOCK, int NGFMNKONPKM, [Out] int HHLEOAJJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7D65870", Offset = "0x7D63E70", VA = "0x187D65870")]
	private static bool FPPPLGGOMAF(string HKOKFJFBOCK, int NGFMNKONPKM, [Out] int HHLEOAJJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7D659E0", Offset = "0x7D63FE0", VA = "0x187D659E0")]
	public static int GBMAKGPOEFD(string HKOKFJFBOCK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class MPFLDBBACFK
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7D67FF0", Offset = "0x7D665F0", VA = "0x187D67FF0")]
	public static bool PEFLJFOLIIG(this Type OCACDKEJIIB, Type MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3948910", Offset = "0x3946F10", VA = "0x183948910")]
	public static bool PEFLJFOLIIG<T>(this Type OCACDKEJIIB) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BHMFNFNHOOI
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6BD0", Offset = "0x6AE51D0", VA = "0x186AE6BD0")]
	public static uint OHAFHKMDDGO(this uint OCACDKEJIIB, int JAALIADHHOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E4F0", Offset = "0x6C1CAF0", VA = "0x186C1E4F0")]
	public static uint JFCKHHDJPEH(this uint OCACDKEJIIB, int JAALIADHHOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7D639B0", Offset = "0x7D61FB0", VA = "0x187D639B0")]
	public static uint CMGNEMDOGBK(this uint OCACDKEJIIB, uint LBHCHCMCFJL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7D639A0", Offset = "0x7D61FA0", VA = "0x187D639A0")]
	public static int CBOCIIPBABF(this uint OCACDKEJIIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class HFDPDCDOMCG
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3884AD0", Offset = "0x38830D0", VA = "0x183884AD0")]
	public static T DINPFDJPGEM<T>(IEnumerable<string> GHDNHMECFFP, [Optional] T JMMNJNFGHEP) where T : struct, Enum, IConvertible
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3884D70", Offset = "0x3883370", VA = "0x183884D70")]
	public static T LJCNHJCEFII<T>(IEnumerable<string> GHDNHMECFFP, [Optional] T JMMNJNFGHEP) where T : struct, Enum, IConvertible
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x38846C0", Offset = "0x3882CC0", VA = "0x1838846C0")]
	public static T CEHPLJDHDPF<T>(IEnumerable<string> GHDNHMECFFP, [Optional] T JMMNJNFGHEP) where T : struct, Enum, IConvertible
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7D65460", Offset = "0x7D63A60", VA = "0x187D65460")]
	private static bool PKMLFCEKNAM(Type NNODEEMKOHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class APIMCGJBNDH
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3FCC740", Offset = "0x3FCAD40", VA = "0x183FCC740")]
	public static bool JMNJAMICAFJ<T>([In] this T? OCACDKEJIIB, [Out] T OHLIHBDBKCE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class PJENAPPAHGD
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7D69E80", Offset = "0x7D68480", VA = "0x187D69E80")]
	public static MKMGHMFACCC EGGBKIAGBOI(IReadOnlyList<float> APDBNIMCPID, int JCHDIAGFJEK = -1, float BADKMNGPEAK = -1f)
	{
		return default(MKMGHMFACCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7D69F90", Offset = "0x7D68590", VA = "0x187D69F90")]
	private static MKMGHMFACCC PFNNGGPMMKP(IReadOnlyList<float> APDBNIMCPID, int JCHDIAGFJEK, float BADKMNGPEAK = -1f)
	{
		return default(MKMGHMFACCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7D6A5E0", Offset = "0x7D68BE0", VA = "0x187D6A5E0")]
	private static float PJPAHJLEENI(IReadOnlyList<float> APDBNIMCPID, int JAALIADHHOC, float HBJLNKIPHHB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7D69B20", Offset = "0x7D68120", VA = "0x187D69B20")]
	public static float BJFCKDCAOEK(IReadOnlyList<float> APDBNIMCPID, int IPAELMFFKOA, int LLDMNGOPBOL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct HKCDABAKIHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly float IFHGOFMHGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly float NFKCIIADMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly float EAFKEHEOONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly float MLFIGAHGDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public readonly float KOPJCIFLONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly float CPABKLAMGBB;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7D655E0", Offset = "0x7D63BE0", VA = "0x187D655E0")]
	public HKCDABAKIHO(float KEGCOHFNLGE, float HAOFLBHCOBL, float IMAFHBPOKHO, float OCJCOCCGFCL, float GDCPDHADDBC, float BAOFMAKKMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[Flags]
public enum ECGBOIHGDJA
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	N = 2,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Min = 4,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Max = 8,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Mean = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Median = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	SVariance = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	PVariance = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Q1 = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Q3 = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	P25 = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	P50 = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	P75 = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	P90 = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	P95 = 0x4000,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	P99 = 0x8000,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	HitchN = 0x10000,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	HitchThres = 0x20000,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	HitchThresOff = 0x40000,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	PercentileFlags = 0xFC00,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	HitchFlags = 0x70000,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct MKMGHMFACCC
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HBALCIKOAOM : IEnumerable<(ECGBOIHGDJA, float)>, IEnumerable, IEnumerator<(ECGBOIHGDJA, float)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private (ECGBOIHGDJA flag, float result) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private ECGBOIHGDJA flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public ECGBOIHGDJA <>3__flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public MKMGHMFACCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public MKMGHMFACCC <>3__<>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private (ECGBOIHGDJA, float) System.Collections.Generic.IEnumerator<(RecRoom.NoEngine.Algorithms.Runtime.Stats.StatResultFlagsflag,System.Singleresult)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xED4C90", Offset = "0xED3290", VA = "0x180ED4C90", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((ECGBOIHGDJA, float));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7D65270", Offset = "0x7D63870", VA = "0x187D65270", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x49FB3E0", Offset = "0x49F99E0", VA = "0x1849FB3E0")]
		[DebuggerHidden]
		public HBALCIKOAOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7D64AF0", Offset = "0x7D630F0", VA = "0x187D64AF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7D65220", Offset = "0x7D63820", VA = "0x187D65220", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7D65130", Offset = "0x7D63730", VA = "0x187D65130", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(ECGBOIHGDJA, float)> System.Collections.Generic.IEnumerable<(RecRoom.NoEngine.Algorithms.Runtime.Stats.StatResultFlagsflag,System.Singleresult)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7D65130", Offset = "0x7D63730", VA = "0x187D65130", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly int NKLFDNJAILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly int IKDIAEHMFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public readonly float CLPFPJKCNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public readonly float IHNPHHOLAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly float OAKLBKNNIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly float INMGPHGEKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly float PIDJCBBHANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public readonly float FGKMMFKJMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly float DHLLPHGAHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public readonly float AKNOGLHFPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public readonly float BEAEJLHGCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly HKCDABAKIHO OKGBCEDPEEP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float JICOLGILEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7D67EC0", Offset = "0x7D664C0", VA = "0x187D67EC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float AAODPDFKGEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7D67EA0", Offset = "0x7D664A0", VA = "0x187D67EA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7D67EE0", Offset = "0x7D664E0", VA = "0x187D67EE0")]
	public MKMGHMFACCC(int KLJKHLHNLGP, int HEMNIJGEEBF, float HHCGOODLGHB, float BADKMNGPEAK, float COJGDIKBGKB, float JNIBMOMFMLL, float JPFECOHOJCG, float HFJNKPPDNFI, float DHLLPHGAHKO, float LJNICKNPKNF, float JOLKOFFBAEN, HKCDABAKIHO FOMBCNPBHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7D67DF0", Offset = "0x7D663F0", VA = "0x187D67DF0")]
	[IteratorStateMachine(typeof(HBALCIKOAOM))]
	public IEnumerable<(ECGBOIHGDJA, float)> CFEEDNCLHMF(ECGBOIHGDJA EIBMLBPPJAJ)
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
