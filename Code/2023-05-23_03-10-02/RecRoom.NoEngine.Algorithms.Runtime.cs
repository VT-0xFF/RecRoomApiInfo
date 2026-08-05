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
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
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
		[Cpp2IlInjected.Address(RVA = "0x16D4B20", Offset = "0x16D3F20", VA = "0x1816D4B20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x881BC0", Offset = "0x880FC0", VA = "0x180881BC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD72FB0", Offset = "0xD723B0", VA = "0x180D72FB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MCJDBGCCCCG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x30119D0", Offset = "0x3010DD0", VA = "0x1830119D0")]
	public static T LLPKLFBKNII<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4C90", Offset = "0x7A4090")] this in ReadOnlyMemory<T> LGKAJJKAMAG, int CJOLACIBAJH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3011A90", Offset = "0x3010E90", VA = "0x183011A90")]
	public static bool NHNOBFNLJOG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4D00", Offset = "0x7A4100")] this in ReadOnlyMemory<T> LGKAJJKAMAG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4D70", Offset = "0x7A4170")] in ReadOnlyMemory<T> CCJMBGJFGLH) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x30117F0", Offset = "0x3010BF0", VA = "0x1830117F0")]
	public static int LLOJNFECNFJ<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4DE0", Offset = "0x7A41E0")] this in ReadOnlyMemory<T?> LGKAJJKAMAG, int LFKHHHJNPNF = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3011750", Offset = "0x3010B50", VA = "0x183011750")]
	public static string KMMMKEBJAMG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4E50", Offset = "0x7A4250")] this in ReadOnlyMemory<T> LGKAJJKAMAG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HOMFCEIKFGF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29B19E0", Offset = "0x29B0DE0", VA = "0x1829B19E0")]
	public static void FDAAJPHOJAO<T>(this ICollection<T> LGKAJJKAMAG, IEnumerable<T> BOIGNFPOPGL) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MNCLKAHNJJG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POGLHOFCBFL LKBOIPMKMDK();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NALNMIGICMK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AMDLDIIKNBP<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public AMDLDIIKNBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x34183F0", Offset = "0x34177F0", VA = "0x1834183F0")]
		internal TElement DMJNBEJJOJE(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OOCCMPABNIF<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Random rng;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public OOCCMPABNIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xB7DD40", Offset = "0xB7D140", VA = "0x180B7DD40")]
		internal int AMDHALLEHEN(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x290FE00", Offset = "0x290F200", VA = "0x18290FE00")]
	public static int MPMKEDBBEJK<T>(this IReadOnlyList<T> BIBDBFOMNHM, T EOEKGHMNIDN) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2910B80", Offset = "0x290FF80", VA = "0x182910B80")]
	public static int OGEEKDPKGMG<T>(this IReadOnlyList<T> BIBDBFOMNHM, T EOEKGHMNIDN) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C94D80", Offset = "0x5C94180", VA = "0x185C94D80")]
	public static void FDAAJPHOJAO<T>(this HashSet<T> NKAIBFCCOOJ, IEnumerable<T> BOIGNFPOPGL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2910D40", Offset = "0x2910140", VA = "0x182910D40")]
	public static void OLMKGLJJCBM<T>(this IList<T> FGINDFDIDLG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2910DC0", Offset = "0x29101C0", VA = "0x182910DC0")]
	public static void OLMKGLJJCBM<T>(this IList<T> FGINDFDIDLG, int CCGPDLBBLMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5C96B40", Offset = "0x5C95F40", VA = "0x185C96B40")]
	public static List<T> JIIENPICGJH<T>(this List<T> NFFIKMCFHBI, Predicate<T> KFEPNPJEKON) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x29104F0", Offset = "0x290F8F0", VA = "0x1829104F0")]
	public static int MPMKEDBBEJK<T>(this IReadOnlyList<T> FGINDFDIDLG, Predicate<T> EBNIKPBJGHC) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C95950", Offset = "0x5C94D50", VA = "0x185C95950")]
	public static bool GEDJJHOCMEN<T>(this IReadOnlyList<T> FGINDFDIDLG, Predicate<T> EBNIKPBJGHC, [JGAMJCFKCDP(true)] out List<int>? JIBBGPJFEIE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5C98590", Offset = "0x5C97990", VA = "0x185C98590")]
	public static bool MEIKKLBJCPM<T>(this IReadOnlyList<T> FGINDFDIDLG, T NFFDNBMMLPN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C98450", Offset = "0x5C97850", VA = "0x185C98450")]
	public static bool MEIKKLBJCPM<T>(this IReadOnlyList<T> FGINDFDIDLG, T NFFDNBMMLPN, EqualityComparer<T> BNHAJHCFHEM) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C97280", Offset = "0x5C96680", VA = "0x185C97280")]
	public static int LAGDCLOPAKH<TElement, TKey>(this IList<TElement> BFMACBDJJCH, TKey EDGHLMLEDDP, Func<TElement, TKey> BKPCAENOFKF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4F00", Offset = "0x7A4300")] Func<TKey, TKey, int> AEBOKKFPBFJ, int CJOLACIBAJH = 0, [Optional] int? HHFCIFFLNGA) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C96F80", Offset = "0x5C96380", VA = "0x185C96F80")]
	public static int LAGDCLOPAKH<TElement, TKey>(Func<int, TElement> ALHMKCOHKIH, int ECFOMAABKKL, TKey EDGHLMLEDDP, Func<TElement, TKey> BKPCAENOFKF, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4F60", Offset = "0x7A4360")] Func<TKey, TKey, int> AEBOKKFPBFJ, int CJOLACIBAJH = 0, [Optional] int? HHFCIFFLNGA) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C962E0", Offset = "0x5C956E0", VA = "0x185C962E0")]
	public static List<T> IKKNGOAAKDB<T>(this IReadOnlyList<T> FGINDFDIDLG, int HHFCIFFLNGA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C96C30", Offset = "0x5C96030", VA = "0x185C96C30")]
	public static bool KICLIKCKNMG<T>(this List<T> FGINDFDIDLG, T NFFDNBMMLPN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C96980", Offset = "0x5C95D80", VA = "0x185C96980")]
	public static void JBFDGOCJNLM<T>(this List<T> FGINDFDIDLG, IEnumerable<T> NFFIKMCFHBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C94920", Offset = "0x5C93D20", VA = "0x185C94920")]
	public static void AJCNBIMBJPF<T>(this List<T> FGINDFDIDLG, IEnumerable<T> NFFIKMCFHBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x29114A0", Offset = "0x29108A0", VA = "0x1829114A0")]
	public static T PHHCEOHKLDG<T>(this List<T> NFFIKMCFHBI, Predicate<T> KFEPNPJEKON) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2910B10", Offset = "0x290FF10", VA = "0x182910B10")]
	public static T NCGNMPDNIFG<T>(this List<T> NFFIKMCFHBI, int CJOLACIBAJH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C968F0", Offset = "0x5C95CF0", VA = "0x185C968F0")]
	public static bool JACKIEEBJNE<T>(this List<T> HILANJCGMPG, List<T> BGEBPFMIEFH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C96850", Offset = "0x5C95C50", VA = "0x185C96850")]
	public static T IOGEEFNKOOB<T>(this IList<T> FGINDFDIDLG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C94CC0", Offset = "0x5C940C0", VA = "0x185C94CC0")]
	public static bool DOCBJEOMBMF<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4FC0", Offset = "0x7A43C0")] IReadOnlyList<T> FGINDFDIDLG, int CJOLACIBAJH, [NDHNGFOGLOL(false)][INHHDNKJHCF("This should be `T?` in C# 9.")] out T LGNNINPIMGJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C994C0", Offset = "0x5C988C0", VA = "0x185C994C0")]
	public static bool MNIEJKOIOOD<T>(IReadOnlyList<T> FGINDFDIDLG, ICollection NFFIKMCFHBI) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C96E50", Offset = "0x5C96250", VA = "0x185C96E50")]
	public static void KLCNAGLMCCD<T>(IReadOnlyList<T> FGINDFDIDLG, ref ICollection NFFIKMCFHBI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C95DD0", Offset = "0x5C951D0", VA = "0x185C95DD0")]
	public static bool GNHDBKNNGMA<T>(this IReadOnlyList<T> FGINDFDIDLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C96070", Offset = "0x5C95470", VA = "0x185C96070")]
	public static string HANIPBEBJJO<T>(this IEnumerable<T> FGINDFDIDLG, string CAMKFHDLPMK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C96610", Offset = "0x5C95A10", VA = "0x185C96610")]
	public static T ILJGCNAEGKO<T>(this IList<T> LGKAJJKAMAG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C95E30", Offset = "0x5C95230", VA = "0x185C95E30")]
	public static T GOEIBIMDGFB<T>(this IList<T> LGKAJJKAMAG) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C96250", Offset = "0x5C95650", VA = "0x185C96250")]
	public static void HFFOLEDDMDK<T>(this IList<T> LGKAJJKAMAG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C94AC0", Offset = "0x5C93EC0", VA = "0x185C94AC0")]
	public static void CHKANDLLIND<T>(this IList<T> LGKAJJKAMAG, in T EOEKGHMNIDN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C958B0", Offset = "0x5C94CB0", VA = "0x185C958B0")]
	public static T FEAHNJCFAGJ<T>(this IList<T> LGKAJJKAMAG) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PHLNKCFPKAG
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x24DA380", Offset = "0x24D9780", VA = "0x1824DA380")]
	public static void NKLNCNCIAJI<T>(this T GGHBBCGIKPJ, Action<T> PJOOGAHDHBA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x24DA3C0", Offset = "0x24D97C0", VA = "0x1824DA3C0")]
	public static V OACIONNCOGG<V, T>(this T GGHBBCGIKPJ, Func<T, V> PJOOGAHDHBA, [Optional][INHHDNKJHCF("`default!` shouldn't be necessary in C# 9")] V BICCJELLHLH) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x24DA540", Offset = "0x24D9940", VA = "0x1824DA540")]
	public static T? OOMHKBBACGN<T>(this T LGKAJJKAMAG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x24DA300", Offset = "0x24D9700", VA = "0x1824DA300")]
	[IteratorStateMachine(typeof(OMMDIGNFMFI))]
	public static IEnumerable<T> LAIPKKLEALG<T>(this T LGKAJJKAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x24DA460", Offset = "0x24D9860", VA = "0x1824DA460")]
	public static T[] OCJIEOHCAHO<T>(this T LGKAJJKAMAG) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GDIDKEPKLFC
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long APOBJJDLEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct DAGOIMBNKJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GDIDKEPKLFC MNOFAAJBMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly long LALJMDACAOK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x16D3300", Offset = "0x16D2700", VA = "0x1816D3300")]
	public DAGOIMBNKJF(GDIDKEPKLFC FPHLBBLLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x16D3150", Offset = "0x16D2550", VA = "0x1816D3150")]
	public long ALFPNLBDMLJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x16D31E0", Offset = "0x16D25E0", VA = "0x1816D31E0")]
	public double HOOGMJGNJJF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x16D3270", Offset = "0x16D2670", VA = "0x1816D3270")]
	public double NHAIBDDPDBJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FMCCFJLAAOK
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xD5BDB0", Offset = "0xD5B1B0", VA = "0x180D5BDB0")]
	public static bool OEHGACNFJAJ(this Type LGKAJJKAMAG, Type CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3240", Offset = "0x2FC2640", VA = "0x182FC3240")]
	public static bool OEHGACNFJAJ<T>(this Type LGKAJJKAMAG) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KNGIFMGBFLE
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GGMILLFJIAB(int ILMMOIJNOAA, int BJNDBBAIPAD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float KEPNEHECOMC(float KEJHINOKCCC, float PFILMHEEIKA);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OMMKALEDEAO
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x24CFBE0", Offset = "0x24CEFE0", VA = "0x1824CFBE0")]
	public static void PIEPGKNGNEP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5220", Offset = "0x7A4620")] this in KeyValuePair<TKey, TValue> LGKAJJKAMAG, out TKey LOLIOKKJLEH, out TValue EOEKGHMNIDN) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x24CF910", Offset = "0x24CED10", VA = "0x1824CF910")]
	public static (TKey?, TValue?) IMODBDNCNDD<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5290", Offset = "0x7A4690")] this in KeyValuePair<TKey?, TValue?> LGKAJJKAMAG)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x24CFB50", Offset = "0x24CEF50", VA = "0x1824CFB50")]
	public static KeyValuePair<TKey?, UValue?> JEOGGMKGCAD<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5300", Offset = "0x7A4700")] this KeyValuePair<TKey?, TValue?> LGKAJJKAMAG, UValue EOEKGHMNIDN)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KBBFBMHLEPG
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2CF88E0", Offset = "0x2CF7CE0", VA = "0x182CF88E0")]
	[NEHMDNJAMFB("This should be replaced with the `is not` operator in C# 9.")]
	public static bool IJFKPDDCDBN<T>(this object LGKAJJKAMAG, [JGAMJCFKCDP(true)] out T LGNNINPIMGJ) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MMPHBDFAJCM
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x16D4810", Offset = "0x16D3C10", VA = "0x1816D4810")]
	private static byte[] GGGKOHFHEFN(int KKEPKKLEMFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x16D4910", Offset = "0x16D3D10", VA = "0x1816D4910")]
	private static byte[] KNLDEPECGBP(long HICLMOGDNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x16D4890", Offset = "0x16D3C90", VA = "0x1816D4890")]
	private static byte[] KJAPPDOHLIP(ulong HICLMOGDNON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x16D4690", Offset = "0x16D3A90", VA = "0x1816D4690")]
	public static Guid EHOAEKOOPFA(params Guid[] OMMKDPCLLAH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x16D45C0", Offset = "0x16D39C0", VA = "0x1816D45C0")]
	public static Guid EDGHPEHNECD(in Guid EJGLDLGPCJH, int CJOLACIBAJH, int EGPHDEMHMDI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x16D40C0", Offset = "0x16D34C0", VA = "0x1816D40C0")]
	public static Guid EDGHPEHNECD(in Guid EJGLDLGPCJH, long CJOLACIBAJH, int EGPHDEMHMDI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x16D4200", Offset = "0x16D3600", VA = "0x1816D4200")]
	public static Guid EDGHPEHNECD(in Guid EJGLDLGPCJH, ulong CJOLACIBAJH, int EGPHDEMHMDI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x16D4190", Offset = "0x16D3590", VA = "0x1816D4190")]
	public static Guid EDGHPEHNECD(in Guid EJGLDLGPCJH, in Guid DLEBCAKNHEK, int EGPHDEMHMDI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x16D42D0", Offset = "0x16D36D0", VA = "0x1816D42D0")]
	private static Guid EDGHPEHNECD(in Guid EJGLDLGPCJH, byte[] GEBIELOCLFC, int EGPHDEMHMDI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x16D3FE0", Offset = "0x16D33E0", VA = "0x1816D3FE0")]
	private static void AEJAECBBJJH(byte[] LKDOBHNFOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x16D4990", Offset = "0x16D3D90", VA = "0x1816D4990")]
	private static void NKJKEACOMPE(byte[] LKDOBHNFOAM, int BJDJCEOCPLA, int LGGFOIJEFNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IPMHJLNCELF
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x14F84A0", Offset = "0x14F78A0", VA = "0x1814F84A0")]
	public static uint DDBEENFBOMG(this uint LGKAJJKAMAG, int HHFCIFFLNGA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xFC5370", Offset = "0xFC4770", VA = "0x180FC5370")]
	public static uint MIALECFPPCJ(this uint LGKAJJKAMAG, int HHFCIFFLNGA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MPJAHHLAKMP
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x16D4A50", Offset = "0x16D3E50", VA = "0x1816D4A50")]
	public static int LEFGMFBOKHD(this int LGKAJJKAMAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x16D4A10", Offset = "0x16D3E10", VA = "0x1816D4A10")]
	public static int EIHAGIHBPPA(this int LGKAJJKAMAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x16D4AC0", Offset = "0x16D3EC0", VA = "0x1816D4AC0")]
	public static int LLLMCONLDMC(this int LGKAJJKAMAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x16D4B10", Offset = "0x16D3F10", VA = "0x1816D4B10")]
	public static int LPNGHEKNPAG(this int LGKAJJKAMAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x14F84A0", Offset = "0x14F78A0", VA = "0x1814F84A0")]
	public static int DDBEENFBOMG(this int LGKAJJKAMAG, int HHFCIFFLNGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5370", Offset = "0xFC4770", VA = "0x180FC5370")]
	public static int MIALECFPPCJ(this int LGKAJJKAMAG, int HHFCIFFLNGA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OCJNKIDOHBM
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x327BF00", Offset = "0x327B300", VA = "0x18327BF00")]
	public static bool HMDOMJKOJEF<T, U>(this T LGKAJJKAMAG, in U GHHNOPFOGCC) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x327BE60", Offset = "0x327B260", VA = "0x18327BE60")]
	public static bool HJIFEKDNFIF<T>(ref T LGKAJJKAMAG, T CCJMBGJFGLH) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KNCDKPLKALE
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static float PADLCPPPDPC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static float KCGJCCFLCCL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static bool HFHAALMCJKL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly float PGGKDDCKMKL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x16D3BF0", Offset = "0x16D2FF0", VA = "0x1816D3BF0")]
	public static bool LJABGGHNJLE(float ELMEJGEELII, float EOKEPOJIFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x16D3BB0", Offset = "0x16D2FB0", VA = "0x1816D3BB0")]
	public static float FMIGECKLIIM(float EOEKGHMNIDN, float FIIBEGPHODD, float JBKJLHMLOKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x16D3BD0", Offset = "0x16D2FD0", VA = "0x1816D3BD0")]
	public static int FMIGECKLIIM(int EOEKGHMNIDN, int FIIBEGPHODD, int JBKJLHMLOKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x16D3B90", Offset = "0x16D2F90", VA = "0x1816D3B90")]
	public static float FFHONAGKAGK(float EOEKGHMNIDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x16D3DB0", Offset = "0x16D31B0", VA = "0x1816D3DB0")]
	public static float MOAFLPHKAKF(float ELMEJGEELII, float EOKEPOJIFJF, float GGHBBCGIKPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x16D3E50", Offset = "0x16D3250", VA = "0x1816D3E50")]
	public static float NCDHHGMPOAP(float ELMEJGEELII, float EOKEPOJIFJF, float GGHBBCGIKPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x16D3CF0", Offset = "0x16D30F0", VA = "0x1816D3CF0")]
	public static float MKADFKLDNBH(float ELMEJGEELII, float EOKEPOJIFJF, float EOEKGHMNIDN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x16D3E60", Offset = "0x16D3260", VA = "0x1816D3E60")]
	public static float NLEOCNGFPMB(float ELMEJGEELII, float EOKEPOJIFJF, float EOEKGHMNIDN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface POGLHOFCBFL : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ECCICFEDGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKOAPJOGJNF();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GAEPKKPOIDH
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private sealed class JACEKKAEFOO : KNGIFMGBFLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly Random EOFMMJGLHDD;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x16D3920", Offset = "0x16D2D20", VA = "0x1816D3920", Slot = "4")]
		public int GGMILLFJIAB(int KEJHINOKCCC, int OFEMCPHLECD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x16D3950", Offset = "0x16D2D50", VA = "0x1816D3950", Slot = "5")]
		public float KEPNEHECOMC(float KEJHINOKCCC, float PFILMHEEIKA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x16D39C0", Offset = "0x16D2DC0", VA = "0x1816D39C0")]
		private double PPBNOIDNMPB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x16D3A00", Offset = "0x16D2E00", VA = "0x1816D3A00")]
		public JACEKKAEFOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly KNGIFMGBFLE IKKNGOAAKDB;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x16D3370", Offset = "0x16D2770", VA = "0x1816D3370")]
	public static ulong AOOMCILOBAC()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JKBJKHGFONA
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate bool KGNJNBJGEPL<TArgs, T>(in TArgs KBOOOAILJFG, T NFFDNBMMLPN);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate U FMPGAIJKPJJ<TArg, U>(in TArg GNIDPCMALKM);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate U HBNDFEJMJKE<TArg, T, U>(in TArg GNIDPCMALKM, T DJBMAHFONBK);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate U AOFAOODOGOM<TArg, T, U>(in TArg GNIDPCMALKM, IEnumerable<T> FDOLNONHOJG);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate U MOOFGCGHDEN<TArg, T, U>(in TArg GNIDPCMALKM, T DJBMAHFONBK);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct FOGLEOKLGCH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x38A23F0", Offset = "0x38A17F0", VA = "0x1838A23F0")]
		[INHHDNKJHCF("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) MICGELHDJHD(T BGKEJILDJCO)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x38A2380", Offset = "0x38A1780", VA = "0x1838A2380")]
		[INHHDNKJHCF("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) BHANPKAIHKB(IEnumerable<T> FJLPHFPIBEO)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class GOAHKIPKBGH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public GOAHKIPKBGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x281DDB0", Offset = "0x281D1B0", VA = "0x18281DDB0")]
		internal bool KMPHDMCPICM(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5787550", Offset = "0x5786950", VA = "0x185787550")]
		internal bool FHLDFCGGKIJ(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x20D2E90", Offset = "0x20D2290", VA = "0x1820D2E90")]
	public static bool FNCFDDLJEEJ<T, TArgs>(this IEnumerable<T> LGKAJJKAMAG, in TArgs KBOOOAILJFG, KGNJNBJGEPL<TArgs, T> EBNIKPBJGHC) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x20D27A0", Offset = "0x20D1BA0", VA = "0x1820D27A0")]
	public static U DDBIGNPAJAJ<U, T>(this IEnumerable<T> LGKAJJKAMAG, Func<U> FJOFJLKPJPG, Func<T, U> BGKEJILDJCO, Func<IEnumerable<T>, U> FJLPHFPIBEO) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x20D4FC0", Offset = "0x20D43C0", VA = "0x1820D4FC0")]
	public static bool NDKIPKFNHLO<T, TArgs>(this IEnumerable<T> LGKAJJKAMAG, in TArgs KBOOOAILJFG, KGNJNBJGEPL<TArgs, T> EBNIKPBJGHC) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x20D2400", Offset = "0x20D1800", VA = "0x1820D2400")]
	public static U CPKEEIGIHAA<U, T, TArg>(this IEnumerable<T> LGKAJJKAMAG, in TArg GNIDPCMALKM, FMPGAIJKPJJ<TArg, U> FJOFJLKPJPG, HBNDFEJMJKE<TArg, T, U> BGKEJILDJCO, AOFAOODOGOM<TArg, T, U> FJLPHFPIBEO) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x20D38C0", Offset = "0x20D2CC0", VA = "0x1820D38C0")]
	public static IEnumerable<U> IPOGMLKNHJO<U, T, TArg>(this IEnumerable<T> LGKAJJKAMAG, in TArg GNIDPCMALKM, MOOFGCGHDEN<TArg, T, U> NOADCEBOFGC) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x20D2240", Offset = "0x20D1640", VA = "0x1820D2240")]
	public static IEnumerable<T> GNHLHNAAOCJ<T>(params IEnumerable<T>[] HFLLKPFAEKJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x20D4E00", Offset = "0x20D4200", VA = "0x1820D4E00")]
	public static bool MOJHMKOFEBL<T>(this IEnumerable<T> NNEEJCHOPPB, IEnumerable<T> CCJMBGJFGLH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x20D2240", Offset = "0x20D1640", VA = "0x1820D2240")]
	public static IEnumerable<(TKey?, TValue?)>? JKKMCIECGHD<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5460", Offset = "0x7A4860")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x20D45A0", Offset = "0x20D39A0", VA = "0x1820D45A0")]
	public static IEnumerable<T> LLFOMFFIBMH<T, TKey>(this IEnumerable<T> MBLOMLHOIEL, Func<T, TKey> ELCKINAGEHC) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C890", Offset = "0x1A4BC90", VA = "0x181A4C890")]
	[IteratorStateMachine(typeof(GBLAKHFENNO))]
	public static IEnumerable<T> HACPODJAHHH<T, U>(this IEnumerable<T> LGKAJJKAMAG, IEnumerable<U> CCJMBGJFGLH, [Optional][INHHDNKJHCF("`default!` shouldn't be necessary in C# 9")] T BLGFONACOFD) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x20D3F00", Offset = "0x20D3300", VA = "0x1820D3F00")]
	public static T JIJDJBGIOCJ<T>(this IEnumerable<T> NNEEJCHOPPB, T BICCJELLHLH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x20D3F30", Offset = "0x20D3330", VA = "0x1820D3F30")]
	public static T JIJDJBGIOCJ<T>(this IEnumerable<T> NNEEJCHOPPB, T BICCJELLHLH, Func<T, bool> EBNIKPBJGHC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x20D3D80", Offset = "0x20D3180", VA = "0x1820D3D80")]
	[IteratorStateMachine(typeof(PGCNLEEHCGK))]
	public static IEnumerable<(T, global::JIPMFFHDKLF<T>)> JHIGFHOJMBC<T>(this IEnumerable<T> LGKAJJKAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x20D37B0", Offset = "0x20D2BB0", VA = "0x1820D37B0")]
	public static bool IFGLOMCPOPN<T>(this IEnumerable<T> LGKAJJKAMAG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x20D2240", Offset = "0x20D1640", VA = "0x1820D2240")]
	public static IEnumerable<global::JIAHEONOOCJ<T>> BEOOPJIPEDJ<T>(this IEnumerable<T> LGKAJJKAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x20D38A0", Offset = "0x20D2CA0", VA = "0x1820D38A0")]
	public static bool IMMNJJKMOPK<T>(this IEnumerable<T> LGKAJJKAMAG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x20D5A30", Offset = "0x20D4E30", VA = "0x1820D5A30")]
	public static IEnumerable<T> PCKPEIBCJAB<T>(this IEnumerable<T> LGKAJJKAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C950", Offset = "0x1A4BD50", VA = "0x181A4C950")]
	[IteratorStateMachine(typeof(JONHBNEGCJA))]
	public static IEnumerable<U> EBBBBNAOMKN<U, T>(this IEnumerable<T> LGKAJJKAMAG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A55F0", Offset = "0x7A49F0")] Func<FOGLEOKLGCH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> FHDNPNCJOCA) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x20D4780", Offset = "0x20D3B80", VA = "0x1820D4780")]
	public static int LLOJNFECNFJ<T>(this IEnumerable<T> LGKAJJKAMAG, int LFKHHHJNPNF = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x20D2090", Offset = "0x20D1490", VA = "0x1820D2090")]
	public static bool AHHHDPPLFOF<T>(this IEnumerable<T> LGKAJJKAMAG, IEnumerable<T> CCJMBGJFGLH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x20D4B70", Offset = "0x20D3F70", VA = "0x1820D4B70")]
	public static (IEnumerable<T>, IEnumerable<T>) LOHGLKBBJJM<T>(this IEnumerable<T> LGKAJJKAMAG, Func<T, bool> DJPPMPIIFJK) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x20D4060", Offset = "0x20D3460", VA = "0x1820D4060")]
	public static string KMMMKEBJAMG<T>(this IEnumerable<T> LGKAJJKAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x20D3460", Offset = "0x20D2860", VA = "0x1820D3460")]
	public static Dictionary<TKey?, TValue?>? HCCPBAKPONP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A56E0", Offset = "0x7A4AE0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? NNEEJCHOPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x20D3460", Offset = "0x20D2860", VA = "0x1820D3460")]
	public static Dictionary<TKey?, TValue?>? HCCPBAKPONP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5740", Offset = "0x7A4B40")] this IEnumerable<(TKey? Key, TValue? Value)>? NNEEJCHOPPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C830", Offset = "0x1A4BC30", VA = "0x181A4C830")]
	public static HashSet<T> JIGLNIOCGDC<T>(this IEnumerable<T> LGKAJJKAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x20D2780", Offset = "0x20D1B80", VA = "0x1820D2780")]
	public static string DBKGMJEJDAH<T>(this IEnumerable<T> LGKAJJKAMAG, string KFHEJKIEBNK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x20D32F0", Offset = "0x20D26F0", VA = "0x1820D32F0")]
	[IteratorStateMachine(typeof(IMOAAMBEMGK))]
	public static IEnumerable<(T, U)> FOECCMPPLKH<T, U>(this IEnumerable<T> JMFOJDPECFB, IEnumerable<U> PHAPIDHPFME) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x20D57B0", Offset = "0x20D4BB0", VA = "0x1820D57B0")]
	public static IEnumerable<V> OMIIMNKEBAF<V, T, U>(this IEnumerable<T> LGKAJJKAMAG, IEnumerable<U> CCJMBGJFGLH, Func<T, U, V> DEGLJJAOPOD, [Optional][INHHDNKJHCF("`default!` shouldn't be necessary in C# 9")] T ILLPPFPNEPB, [Optional][INHHDNKJHCF("`default!` shouldn't be necessary in C# 9")] U GDBPFJBGMCE) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x20D5840", Offset = "0x20D4C40", VA = "0x1820D5840")]
	public static IEnumerable<(T, U)> OMIIMNKEBAF<T, U>(this IEnumerable<T> LGKAJJKAMAG, IEnumerable<U> CCJMBGJFGLH, [Optional][INHHDNKJHCF("`default!` shouldn't be necessary in C# 9")] T ILLPPFPNEPB, [Optional][INHHDNKJHCF("`default!` shouldn't be necessary in C# 9")] U GDBPFJBGMCE) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NGLKBMEBODB
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2918B80", Offset = "0x2917F80", VA = "0x182918B80")]
	public static bool KFALPPGOIFL<T>(this IReadOnlyCollection<T> LGKAJJKAMAG, int CJOLACIBAJH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class KJKFJPOLPHE : GDIDKEPKLFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Stopwatch MNOFAAJBMOD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long APOBJJDLEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x16D3A70", Offset = "0x16D2E70", VA = "0x1816D3A70", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
	private KJKFJPOLPHE(Stopwatch FPHLBBLLCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x16D3A90", Offset = "0x16D2E90", VA = "0x1816D3A90")]
	public static KJKFJPOLPHE EPPAKCHNELN(Stopwatch FPHLBBLLCJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x16D3AF0", Offset = "0x16D2EF0", VA = "0x1816D3AF0")]
	public static KJKFJPOLPHE IIELDPLNOHH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class ICLJCIDNHKB
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x16D36B0", Offset = "0x16D2AB0", VA = "0x1816D36B0")]
	public static RigidTransform IKIJKCBJKFF(RigidTransform GMHAEDMIEHM, RigidTransform MFDFGCKDMJL)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BOCDDGINBFM<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public readonly struct ICCKOMOPDBA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5495470", Offset = "0x5494870", VA = "0x185495470", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static int JENEEODACCE;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static DAGOIMBNKJF FEFIEGCIJMG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long APOBJJDLEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x303A540", Offset = "0x3039940", VA = "0x18303A540")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x37EC560", Offset = "0x37EB960", VA = "0x1837EC560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x37EC630", Offset = "0x37EBA30", VA = "0x1837EC630")]
	public static ICCKOMOPDBA PEMLIGOAGLO()
	{
		return default(ICCKOMOPDBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x37EC3D0", Offset = "0x37EB7D0", VA = "0x1837EC3D0")]
	private static void CFNFPINGNGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x37EC5C0", Offset = "0x37EB9C0", VA = "0x1837EC5C0")]
	public static void LLMEAOAJOJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class OKLHHMCCJIN
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x24CD690", Offset = "0x24CCA90", VA = "0x1824CD690")]
	public static bool NHNOBFNLJOG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A60B0", Offset = "0x7A54B0")] this in ReadOnlySpan<T?> LGKAJJKAMAG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6120", Offset = "0x7A5520")] in ReadOnlySpan<T?> CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x24CD570", Offset = "0x24CC970", VA = "0x1824CD570")]
	public static int LLOJNFECNFJ<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6190", Offset = "0x7A5590")] this in ReadOnlySpan<T?> LGKAJJKAMAG, int LFKHHHJNPNF = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x24CD3F0", Offset = "0x24CC7F0", VA = "0x1824CD3F0")]
	public static string KMMMKEBJAMG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6200", Offset = "0x7A5600")] this in ReadOnlySpan<T> LGKAJJKAMAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x24CCFE0", Offset = "0x24CC3E0", VA = "0x1824CCFE0")]
	public static string DBKGMJEJDAH<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6270", Offset = "0x7A5670")] this in ReadOnlySpan<T> LGKAJJKAMAG, string KFHEJKIEBNK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JJGGKHMEBNM
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x10FA8F0", Offset = "0x10F9CF0", VA = "0x1810FA8F0")]
	public static bool GNHDBKNNGMA(this string KBPNDAMNPEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class ALKHBBBNMBG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static GDIDKEPKLFC NCJPPOOHCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x16D3010", Offset = "0x16D2410", VA = "0x1816D3010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x16D2F80", Offset = "0x16D2380", VA = "0x1816D2F80")]
	public static double HOOGMJGNJJF(this GDIDKEPKLFC LGKAJJKAMAG, long JCLEAGDGFPA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OJKDPMBHMBE
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate int IKMOGNOLMOL<T>(in T JMFOJDPECFB, in T PHAPIDHPFME);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public sealed class GFCHMAHGECP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct EIFIGBMPOOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public readonly int CBDFEPEIFFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly int GNJDOFDCIFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly bool BDNGJHBBFGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int GKIEFKLFDCD;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3754190", Offset = "0x3753590", VA = "0x183754190")]
			public EIFIGBMPOOB(int CBDFEPEIFFE, int GNJDOFDCIFB, bool BDNGJHBBFGA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly T[] LLNLBNBKEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly T[] HIGCDAAHIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly IKMOGNOLMOL<T> AEBOKKFPBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly int EPDEDHNGFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Func<bool> OFJJLFELIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int ICBMEDLINMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6340", Offset = "0x7A5740")]
		private readonly GFCHMAHGECP<T>.EIFIGBMPOOB[] JEINBBHDJEF;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3500640", Offset = "0x34FFA40", VA = "0x183500640")]
		public GFCHMAHGECP(T[] LLNLBNBKEBA, IKMOGNOLMOL<T> AEBOKKFPBFJ, int EPDEDHNGFKL, Func<bool> OFJJLFELIAN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A63A0", Offset = "0x7A57A0")] T[] MMJAGKKPGGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x34FFF90", Offset = "0x34FF390", VA = "0x1834FFF90")]
		public bool CKGAPHLOHEN()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate U DMIHMCJFIJP<T, U>(int GNCFJNHAOAO, int CGJKDMEKHLC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6400", Offset = "0x7A5800")] in ReadOnlySpan<T> POFACPHIOJM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x258F8B0", Offset = "0x258ECB0", VA = "0x18258F8B0")]
	public static ReadOnlyMemory<T> CKBFFMHIHHE<T>(this T[] LGKAJJKAMAG) where T : notnull
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3282DB0", Offset = "0x32821B0", VA = "0x183282DB0")]
	public static T[] CNHNOFDCCJN<T>(int ABBKELIMEIN, T BLGFONACOFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3282F30", Offset = "0x3282330", VA = "0x183282F30")]
	public static void FPFBILKLLAM<T>(this T[] NGGBHKLHDKN, T BLGFONACOFD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x27B1AF0", Offset = "0x27B0EF0", VA = "0x1827B1AF0")]
	public static void PLJEHELONMP<T>(this T[] BIBDBFOMNHM, int GGGLLOBDBOL, int JIHCAKBKHFN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3283A60", Offset = "0x3282E60", VA = "0x183283A60")]
	private static void IHHCFBJNAPJ<T>(this T[] LGKAJJKAMAG, int PAHOCBBHAMA, int HBLIKAJCPED, T[] CCJMBGJFGLH, int GLGJJIPNIII, int BJHAIOJKAKP, T[] LGNNINPIMGJ, int LKKDCOLAHHF, IKMOGNOLMOL<T> AEBOKKFPBFJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x32840A0", Offset = "0x32834A0", VA = "0x1832840A0")]
	public static void ILCGLNANMKE<T>(this T[] LGKAJJKAMAG, int CBDFEPEIFFE, int HHFCIFFLNGA, IKMOGNOLMOL<T> AEBOKKFPBFJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x32830C0", Offset = "0x32824C0", VA = "0x1832830C0")]
	public static GFCHMAHGECP<T> GAIOOKGJEEP<T>(this T[] LGKAJJKAMAG, IKMOGNOLMOL<T> AEBOKKFPBFJ, int EPDEDHNGFKL, Func<bool> OFJJLFELIAN, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A62E0", Offset = "0x7A56E0")] T[] MMJAGKKPGGJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3284890", Offset = "0x3283C90", VA = "0x183284890")]
	public static T[] PFDOMCFIJGE<T>(this T[] BIBDBFOMNHM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3283160", Offset = "0x3282560", VA = "0x183283160")]
	public static T[] HGFMNBLEHEI<T>(this T[] JKCIBEBFPJJ, T LFAEJGOFAIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3283240", Offset = "0x3282640", VA = "0x183283240")]
	public static T[] HLOOOPHHPOO<T>(this T[] JKCIBEBFPJJ, int CJOLACIBAJH, T LFAEJGOFAIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x32847E0", Offset = "0x3283BE0", VA = "0x1832847E0")]
	public static T[] OPNADNKCMGE<T>(this T[] JKCIBEBFPJJ, int CJOLACIBAJH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3283C20", Offset = "0x3283020", VA = "0x183283C20")]
	public static T[] IKNMFOMFNPC<T>(this T[] JKCIBEBFPJJ, int CJOLACIBAJH, T LFAEJGOFAIP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x32842A0", Offset = "0x32836A0", VA = "0x1832842A0")]
	public static U[] OBMALAKAICB<U, T>(this T[] OGHMIAGGFBJ, int LGGLMEIDHCG, DMIHMCJFIJP<T, U> GGHGOEDCNLI) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x16D4BB0", Offset = "0x16D3FB0", VA = "0x1816D4BB0")]
	public static byte[] BFKCPFBPAFE(this byte[] LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x16D4D90", Offset = "0x16D4190", VA = "0x1816D4D90")]
	public static byte[] EFEANNENPHO(this byte[] LGKAJJKAMAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OHKFONLGIPA
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3281260", Offset = "0x3280660", VA = "0x183281260")]
	public static void OCECJENIAFB<K, V>(this IDictionary<K, V> LGKAJJKAMAG, in K LOLIOKKJLEH, in V EOEKGHMNIDN, Func<V, V, V> LLMDJEILEPO) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x327FDB0", Offset = "0x327F1B0", VA = "0x18327FDB0")]
	public static void GNIDMJIOAFP<K, V>(this IDictionary<K, List<V>> LGKAJJKAMAG, in K LOLIOKKJLEH, in V EOEKGHMNIDN) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x32808D0", Offset = "0x327FCD0", VA = "0x1832808D0")]
	public static TVal MIMBNNHKALI<TVal, TKey>(this IDictionary<TKey, TVal> MMGMKLGCLPP, in TKey LOLIOKKJLEH, [Optional][INHHDNKJHCF("`default!` shouldn't be necessary in C# 9")] TVal BICCJELLHLH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3280530", Offset = "0x327F930", VA = "0x183280530")]
	public static TVal MIMBNNHKALI<TVal, TKey>(this IDictionary<TKey, TVal> MMGMKLGCLPP, in TKey LOLIOKKJLEH, Func<TVal> OJBFHHJHKOO) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x327F280", Offset = "0x327E680", VA = "0x18327F280")]
	public static TValue EJNKBGFGIOK<TValue, TKey>(this IDictionary<TKey, TValue> MMGMKLGCLPP, in TKey LOLIOKKJLEH, [Optional][INHHDNKJHCF("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue BICCJELLHLH)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x327F7E0", Offset = "0x327EBE0", VA = "0x18327F7E0")]
	public static V FBMNHAIPEGJ<V, K>(this IDictionary<K, V> LGKAJJKAMAG, in K LOLIOKKJLEH) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x32811D0", Offset = "0x32805D0", VA = "0x1832811D0")]
	public static T2[] MOPALDLJLLC<T2, T1>(this Dictionary<T1, T2>.ValueCollection CMOOEBOCLFF) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x327EF20", Offset = "0x327E320", VA = "0x18327EF20")]
	public static bool ADFCMLEOCDN<TKey, TValue>(this IDictionary<TKey, TValue> LGKAJJKAMAG, TKey LOLIOKKJLEH, TValue EOEKGHMNIDN) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MBDFAKDNHHG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x16D3F80", Offset = "0x16D3380", VA = "0x1816D3F80")]
	public static RigidTransform LBIOAAJNLLM(this in RigidTransform LGKAJJKAMAG)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class AENAKBDLCNA
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C0C0", Offset = "0x1A4B4C0", VA = "0x181A4C0C0")]
	public static bool CIAJMCMLAHH<T>(this IReadOnlyList<T> LGKAJJKAMAG, int CJOLACIBAJH, [JGAMJCFKCDP(true)][INHHDNKJHCF("This should be `T?` in C# 9.")] out T LGNNINPIMGJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C150", Offset = "0x1A4B550", VA = "0x181A4C150")]
	public static bool LLIIMGFHLEI<T>(this IReadOnlyList<T> LGKAJJKAMAG, int CJOLACIBAJH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A65F0", Offset = "0x7A59F0")] out global::JIAHEONOOCJ<T> LGNNINPIMGJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C240", Offset = "0x1A4B640", VA = "0x181A4C240")]
	public static T PPNEPKHOGLG<T>(this IReadOnlyList<T> LGKAJJKAMAG, int CJOLACIBAJH, in T OIGHBCAHHAE) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C210", Offset = "0x1A4B610", VA = "0x181A4C210")]
	[INHHDNKJHCF("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T OGMCCLPDKIH<T>(this IReadOnlyList<T> LGKAJJKAMAG, int CJOLACIBAJH) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1A4BF80", Offset = "0x1A4B380", VA = "0x181A4BF80")]
	public static T? CFCADEFPJBJ<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6690", Offset = "0x7A5A90")] this IReadOnlyList<T> LGKAJJKAMAG, int CJOLACIBAJH) where T : struct
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
