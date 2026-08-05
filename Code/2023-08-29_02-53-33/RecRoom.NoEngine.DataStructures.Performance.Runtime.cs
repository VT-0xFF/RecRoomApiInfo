using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FB0AD0", Offset = "0x6FAFED0", VA = "0x186FB0AD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CFOMAHIOLJF<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T NEGPJPJCKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class JFAHEKPCKON
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xBD6D30", Offset = "0xBD6130", VA = "0x180BD6D30")]
	public static string MIODNCJHDNI<T>(this IEnumerable<T> JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2008C80", Offset = "0x2008080", VA = "0x182008C80")]
	public static string OAEMPOJJBJC<T>(this IEnumerable<T> JCOLBAAGCGE, string IHLOOOPEBIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct AMADFHGBOBL<T, U> : IEnumerable<T>, IEnumerable where U : EOEFNBMAMEF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly U ONIJIKIHDPH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x30F3690", Offset = "0x30F2A90", VA = "0x1830F3690")]
	internal AMADFHGBOBL(in U EOIJHGCOGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x16CFBA0", Offset = "0x16CEFA0", VA = "0x1816CFBA0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x30F3600", Offset = "0x30F2A00", VA = "0x1830F3600", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x30F3600", Offset = "0x30F2A00", VA = "0x1830F3600", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OKBGOMMKCGH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3651BF0", Offset = "0x3650FF0", VA = "0x183651BF0")]
	public static AMADFHGBOBL<T, U> OHIOHLNJBHE<U>(in U JCOLBAAGCGE) where U : EOEFNBMAMEF<T>
	{
		return default(AMADFHGBOBL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FBAPEBCOCJA
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5FE0", Offset = "0x1DA53E0", VA = "0x181DA5FE0")]
	public static bool OFGADNGECFJ<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator JCOLBAAGCGE, in TArgs KLEPOOAJLPJ, in OCIJKPEILLD<TArgs, TSource, bool> ONPNCHGDFJP) where TSourceEnumerator : CFOMAHIOLJF<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6290", Offset = "0x1DA5690", VA = "0x181DA6290")]
	public static int OMOFLPNFMIH<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator JCOLBAAGCGE, in TArgs KLEPOOAJLPJ, OCIJKPEILLD<TArgs, TSource, bool> ONPNCHGDFJP) where TSourceEnumerator : CFOMAHIOLJF<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5750", Offset = "0x1DA4B50", VA = "0x181DA5750")]
	public static bool ECPDGNEKPBM<TSourceEnumerator, TSource>(this TSourceEnumerator JCOLBAAGCGE, in TSource ADJFAODNAMI) where TSourceEnumerator : CFOMAHIOLJF<TSource> where TSource : EIMBCPMDPDA<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5C90", Offset = "0x1DA5090", VA = "0x181DA5C90")]
	public static int GHECGOLDLKL<TSourceEnumerator, TSource>(this TSourceEnumerator JCOLBAAGCGE, in TSource KKIAKNLLHIO) where TSourceEnumerator : CFOMAHIOLJF<TSource> where TSource : EIMBCPMDPDA<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DA56C0", Offset = "0x1DA4AC0", VA = "0x181DA56C0")]
	public static PPLMNBMLAGI<TSourceEnumerator, TSource, TResult> DDJKBKNHJNH<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator JCOLBAAGCGE, LFCJGAHCEEI<TSource, TResult> DCBDGEGEAOB) where TSourceEnumerator : PGAKNOKPLGF, CFOMAHIOLJF<TSource>
	{
		return default(PPLMNBMLAGI<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DA56C0", Offset = "0x1DA4AC0", VA = "0x181DA56C0")]
	public static MICCDJCOGCJ<TSourceEnumerator, TSource, TResult> FBDIBGGHMND<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator JCOLBAAGCGE, Func<TSource, TResult> DCBDGEGEAOB) where TSourceEnumerator : PGAKNOKPLGF, IEnumerator<TSource>
	{
		return default(MICCDJCOGCJ<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FIFHJLENAAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21D5440", Offset = "0x21D4840", VA = "0x1821D5440")]
	public static bool JDGPFIDBLNI<TSourceEnumerator>(TSourceEnumerator JCOLBAAGCGE) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x21D5550", Offset = "0x21D4950", VA = "0x1821D5550")]
	public static T LIBIPJEKIMF<TSourceEnumerator>(TSourceEnumerator JCOLBAAGCGE) where TSourceEnumerator : CFOMAHIOLJF<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x21CC6B0", Offset = "0x21CBAB0", VA = "0x1821CC6B0")]
	public static T[] FJDFFJPNIKH<TSourceEnumerator>(TSourceEnumerator JCOLBAAGCGE) where TSourceEnumerator : PGAKNOKPLGF, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21C8800", Offset = "0x21C7C00", VA = "0x1821C8800")]
	public static T CIDLLPGFBPJ<TSourceEnumerator>(TSourceEnumerator JCOLBAAGCGE) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LKFHIEOLPDI<T, U> : IEnumerable<T>, IEnumerable where U : CFOMAHIOLJF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U ONIJIKIHDPH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x204C200", Offset = "0x204B600", VA = "0x18204C200")]
	internal LKFHIEOLPDI(in U EOIJHGCOGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x12E63E0", Offset = "0x12E57E0", VA = "0x1812E63E0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x204C180", Offset = "0x204B580", VA = "0x18204C180", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x204C180", Offset = "0x204B580", VA = "0x18204C180", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AHFKOAPDFGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2430690", Offset = "0x242FA90", VA = "0x182430690")]
	public static LKFHIEOLPDI<T, U> OHIOHLNJBHE<U>(in U JCOLBAAGCGE) where U : CFOMAHIOLJF<T>
	{
		return default(LKFHIEOLPDI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public readonly struct ONLPENJAHGA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct FGPGKBCPDBE : PGAKNOKPLGF, CFOMAHIOLJF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] CDALMBEJFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int BNMFLMNDDFM;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int NPBPHODFKMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x194C1E0", Offset = "0x194B5E0", VA = "0x18194C1E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly T NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x194C5E0", Offset = "0x194B9E0", VA = "0x18194C5E0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x194C290", Offset = "0x194B690", VA = "0x18194C290", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x194C4F0", Offset = "0x194B8F0", VA = "0x18194C4F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD834F0", Offset = "0xD828F0", VA = "0x180D834F0")]
		private FGPGKBCPDBE(T[] JCOLBAAGCGE, int NANJAGEOPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x194C230", Offset = "0x194B630", VA = "0x18194C230")]
		public static FGPGKBCPDBE OHIOHLNJBHE(T[] JCOLBAAGCGE)
		{
			return default(FGPGKBCPDBE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x194C200", Offset = "0x194B600", VA = "0x18194C200", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x194C280", Offset = "0x194B680", VA = "0x18194C280", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly T[] CPCKIFIGLBC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KPHJAIPOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x194C1E0", Offset = "0x194B5E0", VA = "0x18194C1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x24B4C30", Offset = "0x24B4030", VA = "0x1824B4C30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9EA8F0", Offset = "0x9E9CF0", VA = "0x1809EA8F0")]
	internal ONLPENJAHGA(T[] KGHLGBOMEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x37ACF00", Offset = "0x37AC300", VA = "0x1837ACF00")]
	public static ONLPENJAHGA<T> OJIJINABCLB()
	{
		return default(ONLPENJAHGA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0")]
	public IEnumerable<T> PFLKBIEMNPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37ACD60", Offset = "0x37AC160", VA = "0x1837ACD60")]
	public ReadOnlySpan<T> CLAPCACCBPN()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x37ACFB0", Offset = "0x37AC3B0", VA = "0x1837ACFB0")]
	public LKFHIEOLPDI<T, ONLPENJAHGA<T>.FGPGKBCPDBE> PPHCMABDFLD()
	{
		return default(LKFHIEOLPDI<T, FGPGKBCPDBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x37ACE70", Offset = "0x37AC270", VA = "0x1837ACE70")]
	public FGPGKBCPDBE KLGJPHNAPGB()
	{
		return default(FGPGKBCPDBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x37ACDF0", Offset = "0x37AC1F0", VA = "0x1837ACDF0")]
	public IEnumerator<T> FNKOJPGNHJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x37AD0D0", Offset = "0x37AC4D0", VA = "0x1837AD0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AMABNDMKMHM
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2138DA0", Offset = "0x21381A0", VA = "0x182138DA0")]
	public static ONLPENJAHGA<T> PGCJPAGAACD<T>(params T[] KGHLGBOMEFA) where T : notnull
	{
		return default(ONLPENJAHGA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0A70", Offset = "0x6FAFE70", VA = "0x186FB0A70")]
	public static Stream BJJCCDHEPGA(this ONLPENJAHGA<byte> JCOLBAAGCGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PGAKNOKPLGF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LHIEBHBOHGD<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly U ONIJIKIHDPH;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2046170", Offset = "0x2045570", VA = "0x182046170")]
	internal LHIEBHBOHGD(in U EOIJHGCOGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x16CFAD0", Offset = "0x16CEED0", VA = "0x1816CFAD0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2045EC0", Offset = "0x20452C0", VA = "0x182045EC0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2045EC0", Offset = "0x20452C0", VA = "0x182045EC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KJEBBNNLJMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x21DE710", Offset = "0x21DDB10", VA = "0x1821DE710")]
	public static LHIEBHBOHGD<T, U> OHIOHLNJBHE<U>(in U JCOLBAAGCGE) where U : IEnumerator<T>
	{
		return default(LHIEBHBOHGD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class AINIDHIKADH<T> : IDisposable, PGAKNOKPLGF, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private ADLFKDGAJMB<T> NHAMIPIPAMK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2A365E0", Offset = "0x2A359E0", VA = "0x182A365E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2A36540", Offset = "0x2A35940", VA = "0x182A36540")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A36740", Offset = "0x2A35B40", VA = "0x182A36740")]
	public static AINIDHIKADH<T> OHIOHLNJBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A36620", Offset = "0x2A35A20", VA = "0x182A36620")]
	public static AINIDHIKADH<T> LECFGCPCMDB(int EPMEDFGLJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x24BB2E0", Offset = "0x24BA6E0", VA = "0x1824BB2E0")]
	internal AINIDHIKADH(in ADLFKDGAJMB<T> LCKHNIKLMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A36560", Offset = "0x2A35960", VA = "0x182A36560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A36580", Offset = "0x2A35980", VA = "0x182A36580")]
	public void EBOHBLNDMAL(in T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A36600", Offset = "0x2A35A00", VA = "0x182A36600")]
	public void KPBBMAKHNOC(int ECOAGJBCGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A365A0", Offset = "0x2A359A0", VA = "0x182A365A0", Slot = "8")]
	public ADLFKDGAJMB<T>.KOJJBBFIKCN GetEnumerator()
	{
		return default(ADLFKDGAJMB<T>.KOJJBBFIKCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A36850", Offset = "0x2A35C50", VA = "0x182A36850", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A36850", Offset = "0x2A35C50", VA = "0x182A36850", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(ADLFKDGAJMB<>.LEIPHJGDOND))]
public struct ADLFKDGAJMB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct KOJJBBFIKCN : PGAKNOKPLGF, EOEFNBMAMEF<T>, CFOMAHIOLJF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] EHLDIBOECIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int IDMDPPENDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int BNMFLMNDDFM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int NPBPHODFKMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x16CFBC0", Offset = "0x16CEFC0", VA = "0x1816CFBC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly T NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x240B4A0", Offset = "0x240A8A0", VA = "0x18240B4A0", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private readonly T OOJMAEICEPC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x240A1E0", Offset = "0x24095E0", VA = "0x18240A1E0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x240A650", Offset = "0x2409A50", VA = "0x18240A650", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x240ACD0", Offset = "0x240A0D0", VA = "0x18240ACD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1F5C5E0", Offset = "0x1F5B9E0", VA = "0x181F5C5E0")]
		internal KOJJBBFIKCN(T[] CJPIHDACEJM, int ECOAGJBCGAI, int NANJAGEOPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x240A590", Offset = "0x2409990", VA = "0x18240A590")]
		public static KOJJBBFIKCN OHIOHLNJBHE(ref ADLFKDGAJMB<T> JCOLBAAGCGE)
		{
			return default(KOJJBBFIKCN);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x240A580", Offset = "0x2409980", VA = "0x18240A580", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x240A5F0", Offset = "0x24099F0", VA = "0x18240A5F0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct GGDGAJAIHKJ : PGAKNOKPLGF, CFOMAHIOLJF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KOJJBBFIKCN ONIJIKIHDPH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int NPBPHODFKMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x212AA70", Offset = "0x2129E70", VA = "0x18212AA70", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly T NEGPJPJCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x212BA80", Offset = "0x212AE80", VA = "0x18212BA80", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x212ACE0", Offset = "0x212A0E0", VA = "0x18212ACE0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x212B1E0", Offset = "0x212A5E0", VA = "0x18212B1E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x204C200", Offset = "0x204B600", VA = "0x18204C200")]
		private GGDGAJAIHKJ(in KOJJBBFIKCN EOIJHGCOGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x212AAE0", Offset = "0x2129EE0", VA = "0x18212AAE0")]
		public static GGDGAJAIHKJ OHIOHLNJBHE(in ADLFKDGAJMB<T> JCOLBAAGCGE)
		{
			return default(GGDGAJAIHKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x212AAA0", Offset = "0x2129EA0", VA = "0x18212AAA0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x212ABA0", Offset = "0x2129FA0", VA = "0x18212ABA0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x212AA30", Offset = "0x2129E30", VA = "0x18212AA30", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class LEIPHJGDOND
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] EHLDIBOECIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int IDMDPPENDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x354C7C0", Offset = "0x354BBC0", VA = "0x18354C7C0")]
	public static ADLFKDGAJMB<T> OHIOHLNJBHE()
	{
		return default(ADLFKDGAJMB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x354C6E0", Offset = "0x354BAE0", VA = "0x18354C6E0")]
	public static ADLFKDGAJMB<T> LECFGCPCMDB(int EPMEDFGLJOE)
	{
		return default(ADLFKDGAJMB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xD834F0", Offset = "0xD828F0", VA = "0x180D834F0")]
	internal ADLFKDGAJMB(T[] CJPIHDACEJM, int ECOAGJBCGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2574A70", Offset = "0x2573E70", VA = "0x182574A70", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MMBLEEHLHBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24B4650", Offset = "0x24B3A50", VA = "0x1824B4650")]
	public static void FBDDBFFKADI<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24B5FB0", Offset = "0x24B53B0", VA = "0x1824B5FB0")]
	public static string NGEKNEGMEKB<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0")]
	public static T[] LIMLJOIDPDP<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24B46C0", Offset = "0x24B3AC0", VA = "0x1824B46C0")]
	public static T IKHPLCCBENN<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE, int GNPGECNAJNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24B46C0", Offset = "0x24B3AC0", VA = "0x1824B46C0")]
	public static T FFIMABMBDKP<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE, int GNPGECNAJNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24B7A80", Offset = "0x24B6E80", VA = "0x1824B7A80")]
	public static T NIMBHIMIMPE<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE, int GNPGECNAJNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24B1B90", Offset = "0x24B0F90", VA = "0x1824B1B90")]
	public static void DADPJLGDIHI<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE, int GNPGECNAJNK, in T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24B45C0", Offset = "0x24B39C0", VA = "0x1824B45C0")]
	public static void EJAHCILDFFF<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE, int GNPGECNAJNK, T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x16CFBC0", Offset = "0x16CEFC0", VA = "0x1816CFBC0")]
	public static int EHKADFGAFIM<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24ADEA0", Offset = "0x24AD2A0", VA = "0x1824ADEA0")]
	public static ReadOnlySpan<T> CLAPCACCBPN<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24B3DE0", Offset = "0x24B31E0", VA = "0x1824B3DE0")]
	public static void EBOHBLNDMAL<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE, in T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x24B4A00", Offset = "0x24B3E00", VA = "0x1824B4A00")]
	public static void GJNOKPIPNHE<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE, int NANJAGEOPJI, in T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24ADE60", Offset = "0x24AD260", VA = "0x1824ADE60")]
	public static void BGDKBCNNAHK<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE, int NANJAGEOPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24B4980", Offset = "0x24B3D80", VA = "0x1824B4980")]
	public static T GBAKGMCIBBD<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24B4C70", Offset = "0x24B4070", VA = "0x1824B4C70")]
	public static void KPBBMAKHNOC<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE, int ECOAGJBCGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24B2100", Offset = "0x24B1500", VA = "0x1824B2100")]
	private static void DBEJAJBBBIP<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE, int EPMEDFGLJOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24B7B00", Offset = "0x24B6F00", VA = "0x1824B7B00")]
	public static void PEHJALIONDD<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24B3D50", Offset = "0x24B3150", VA = "0x1824B3D50")]
	public static bool DLCMOJLBLEC<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE, in T KKIAKNLLHIO) where T : EIMBCPMDPDA<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xBD1A20", Offset = "0xBD0E20", VA = "0x180BD1A20")]
	public static bool MPIAMCJMFLB<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24B4C00", Offset = "0x24B4000", VA = "0x1824B4C00")]
	public static bool IDNCEGGGNNL<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE, int GNPGECNAJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E4F0", Offset = "0x1F8D8F0", VA = "0x181F8E4F0")]
	public static ADLFKDGAJMB<T>.GGDGAJAIHKJ FNKOJPGNHJL<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
		return default(ADLFKDGAJMB<T>.GGDGAJAIHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E4F0", Offset = "0x1F8D8F0", VA = "0x181F8E4F0")]
	public static ADLFKDGAJMB<T>.KOJJBBFIKCN KCLHGNHEGAB<T>(this ref ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
		return default(ADLFKDGAJMB<T>.KOJJBBFIKCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x24B5F50", Offset = "0x24B5350", VA = "0x1824B5F50")]
	public static LKFHIEOLPDI<T, ADLFKDGAJMB<T>.GGDGAJAIHKJ> NEHIAGHDPLO<T>(this in ADLFKDGAJMB<T> JCOLBAAGCGE)
	{
		return default(LKFHIEOLPDI<T, ADLFKDGAJMB<T>.GGDGAJAIHKJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PPLMNBMLAGI<TSourceEnumerator, TSource, TResult> : PGAKNOKPLGF, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : PGAKNOKPLGF, CFOMAHIOLJF<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private TSourceEnumerator CDALMBEJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LFCJGAHCEEI<TSource, TResult> EACGBEMAFKD;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x255D7D0", Offset = "0x255CBD0", VA = "0x18255D7D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public readonly TResult NEGPJPJCKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x255E130", Offset = "0x255D530", VA = "0x18255E130", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x255DDC0", Offset = "0x255D1C0", VA = "0x18255DDC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x16CEE30", Offset = "0x16CE230", VA = "0x1816CEE30")]
	internal PPLMNBMLAGI(in TSourceEnumerator JCOLBAAGCGE, LFCJGAHCEEI<TSource, TResult> DCBDGEGEAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x255D910", Offset = "0x255CD10", VA = "0x18255D910", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x255DB90", Offset = "0x255CF90", VA = "0x18255DB90", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x255D4A0", Offset = "0x255C8A0", VA = "0x18255D4A0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MICCDJCOGCJ<TSourceEnumerator, TSource, TResult> : PGAKNOKPLGF, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : PGAKNOKPLGF, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private TSourceEnumerator CDALMBEJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TSource, TResult> EACGBEMAFKD;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public readonly int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x30C1750", Offset = "0x30C0B50", VA = "0x1830C1750", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public readonly TResult NEGPJPJCKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x255DF80", Offset = "0x255D380", VA = "0x18255DF80", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x255DCC0", Offset = "0x255D0C0", VA = "0x18255DCC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x16CEE30", Offset = "0x16CE230", VA = "0x1816CEE30")]
	internal MICCDJCOGCJ(in TSourceEnumerator JCOLBAAGCGE, Func<TSource, TResult> DCBDGEGEAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x30C1890", Offset = "0x30C0C90", VA = "0x1830C1890", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x30C1A00", Offset = "0x30C0E00", VA = "0x1830C1A00", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x30C1630", Offset = "0x30C0A30", VA = "0x1830C1630", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface EOEFNBMAMEF<T> : CFOMAHIOLJF<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GJNBLIGKFHA
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x12CA6D0", Offset = "0x12C9AD0", VA = "0x1812CA6D0")]
	public static ONLPENJAHGA<T> ILJEJGOPDPI<T>(this T[] JCOLBAAGCGE) where T : notnull
	{
		return default(ONLPENJAHGA<T>);
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
