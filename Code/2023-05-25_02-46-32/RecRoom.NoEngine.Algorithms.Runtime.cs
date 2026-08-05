using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
		[Cpp2IlInjected.Address(RVA = "0x80EA90", Offset = "0x80D290", VA = "0x18080EA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FB3400", Offset = "0x6FB1C00", VA = "0x186FB3400")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C8540", Offset = "0x8C6D40", VA = "0x1808C8540")]
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
		[Cpp2IlInjected.Address(RVA = "0xD79980", Offset = "0xD78180", VA = "0x180D79980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LPKIAGLKNEG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate string PCJLBNNPGAK();

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate TEx EFJFOKJPJBI<out TEx>(TimeSpan BBNJILIHPCN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x355A320", Offset = "0x3558B20", VA = "0x18355A320")]
	public static TaskCompletionSource<T> DFFCBBHLKBE<T>(this TaskCompletionSource<T> BFLDPIIJLEC, TimeSpan OJHABJHLHAL, [Optional] PCJLBNNPGAK? LPJDNLJCICI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3558720", Offset = "0x3556F20", VA = "0x183558720")]
	public static TaskCompletionSource<T> DFFCBBHLKBE<T, TEx>(this TaskCompletionSource<T> BFLDPIIJLEC, TimeSpan OJHABJHLHAL, EFJFOKJPJBI<TEx> ACHNIIFEGGK) where T : notnull where TEx : notnull, HIBDKLHBKLF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3110", Offset = "0x6FB1910", VA = "0x186FB3110")]
	private static void GPEAAMGGGEP(ref TimeSpan FMKOGHAFEMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HIBDKLHBKLF : TimeoutException
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly TimeSpan BGBJBIPOPKC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6FB13C0", Offset = "0x6FAFBC0", VA = "0x186FB13C0")]
	private static FormattableString BOIPEMPOHEI(TimeSpan FMKOGHAFEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1810", Offset = "0x6FB0010", VA = "0x186FB1810")]
	private static string HLGEOHGHMIN(TimeSpan OJHABJHLHAL, string DKIECHCHJFL, bool CGPMHCCEPIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1900", Offset = "0x6FB0100", VA = "0x186FB1900")]
	public HIBDKLHBKLF(TimeSpan OJHABJHLHAL, string DKIECHCHJFL, bool CGPMHCCEPIM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HOILNFAKEOP
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2DDDA40", Offset = "0x2DDC240", VA = "0x182DDDA40")]
	public static T PNBJHLBKMLC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4CA0", Offset = "0x7A40A0")] this in ReadOnlyMemory<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD6A0", Offset = "0x2DDBEA0", VA = "0x182DDD6A0")]
	public static bool HBCNIMJOHIE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4D10", Offset = "0x7A4110")] this in ReadOnlyMemory<T> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4D80", Offset = "0x7A4180")] in ReadOnlyMemory<T> MDHJAFNLPON) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD860", Offset = "0x2DDC060", VA = "0x182DDD860")]
	public static int LHEDPPNOEIM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4DF0", Offset = "0x7A41F0")] this in ReadOnlyMemory<T?> GPOCLJBKMHA, int COIKHAAMKGK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD7C0", Offset = "0x2DDBFC0", VA = "0x182DDD7C0")]
	public static string LFGBFEHHMOI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4E60", Offset = "0x7A4260")] this in ReadOnlyMemory<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DKOJIHDECMA
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B433E0", Offset = "0x3B41BE0", VA = "0x183B433E0")]
	public static void MIEPPGEFOLJ<T>(this ICollection<T> GPOCLJBKMHA, IEnumerable<T> OMCHMPJJNDE) where T : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GINBLAHFFIH
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKLNELNKDNK CIAALDMCOFJ();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DCJCGPDDHGB
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class KOKACOAODJC<TElement, TKey> where TElement : notnull where TKey : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IList<TElement> sortedList;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public KOKACOAODJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4648D70", Offset = "0x4647570", VA = "0x184648D70")]
		internal TElement OMEEPKDPLLH(int i)
		{
			return (TElement)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class KKAINNNEDBA<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public Random rng;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public KKAINNNEDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xB4A9C0", Offset = "0xB491C0", VA = "0x180B4A9C0")]
		internal int DILFJLLIIEG(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2E98DD0", Offset = "0x2E975D0", VA = "0x182E98DD0")]
	public static int EKGGAPJDMPI<T>(this IReadOnlyList<T> EABDNHJFDCB, T ECNGHFJBIJL) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D150", Offset = "0x2E9B950", VA = "0x182E9D150")]
	public static int LLLBPINPPHO<T>(this IReadOnlyList<T> EABDNHJFDCB, T ECNGHFJBIJL) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D700", Offset = "0x2E9BF00", VA = "0x182E9D700")]
	public static void MIEPPGEFOLJ<T>(this HashSet<T> JAEDJOIGJCA, IEnumerable<T> OMCHMPJJNDE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2E98400", Offset = "0x2E96C00", VA = "0x182E98400")]
	public static void CPBOKOOIDND<T>(this IList<T> IFADMANLNLG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2E980D0", Offset = "0x2E968D0", VA = "0x182E980D0")]
	public static void CPBOKOOIDND<T>(this IList<T> IFADMANLNLG, int AKJEJNFFNAA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2E98CE0", Offset = "0x2E974E0", VA = "0x182E98CE0")]
	public static List<T> DGPHIHHLIGK<T>(this List<T> MJPJIGOGOAP, Predicate<T> LDNIBEBMKBJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2E99660", Offset = "0x2E97E60", VA = "0x182E99660")]
	public static int EKGGAPJDMPI<T>(this IReadOnlyList<T> IFADMANLNLG, Predicate<T> GKMOGNDGOID) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2E9BCF0", Offset = "0x2E9A4F0", VA = "0x182E9BCF0")]
	public static bool IHKNDOHHJNG<T>(this IReadOnlyList<T> IFADMANLNLG, Predicate<T> GKMOGNDGOID, [NEFDIDCKCBL(true)] out List<int>? LPCDBCDPGDB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2E9EA80", Offset = "0x2E9D280", VA = "0x182E9EA80")]
	public static bool ODOLPHCGINH<T>(this IReadOnlyList<T> IFADMANLNLG, T FHJBBMIILLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2E9EAD0", Offset = "0x2E9D2D0", VA = "0x182E9EAD0")]
	public static bool ODOLPHCGINH<T>(this IReadOnlyList<T> IFADMANLNLG, T FHJBBMIILLG, EqualityComparer<T> MJKDLIIFPMD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C5A0", Offset = "0x2E9ADA0", VA = "0x182E9C5A0")]
	public static int KKMGALLACPF<TElement, TKey>(this IList<TElement> LMPIHKKJCOP, TKey NKPLBELFHAM, Func<TElement, TKey> IBGBJCJCCIJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4F50", Offset = "0x7A4350")] Func<TKey, TKey, int> IBMKHDGPJMJ, int NHHNPPKPBIA = 0, [Optional] int? FGHOJPFDCIA) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C2A0", Offset = "0x2E9AAA0", VA = "0x182E9C2A0")]
	public static int KKMGALLACPF<TElement, TKey>(Func<int, TElement> LBPCFCDCDPH, int GCOLLKEBKMP, TKey NKPLBELFHAM, Func<TElement, TKey> IBGBJCJCCIJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A4FB0", Offset = "0x7A43B0")] Func<TKey, TKey, int> IBMKHDGPJMJ, int NHHNPPKPBIA = 0, [Optional] int? FGHOJPFDCIA) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2E9EC10", Offset = "0x2E9D410", VA = "0x182E9EC10")]
	public static List<T> OMNBIOGNEGL<T>(this IReadOnlyList<T> IFADMANLNLG, int FGHOJPFDCIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2E999D0", Offset = "0x2E981D0", VA = "0x182E999D0")]
	public static bool GMBFAKMOAHN<T>(this List<T> IFADMANLNLG, T FHJBBMIILLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CF90", Offset = "0x2E9B790", VA = "0x182E9CF90")]
	public static void LFHJGNABIOA<T>(this List<T> IFADMANLNLG, IEnumerable<T> MJPJIGOGOAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2E98830", Offset = "0x2E97030", VA = "0x182E98830")]
	public static void CPPHPNNFPKL<T>(this List<T> IFADMANLNLG, IEnumerable<T> MJPJIGOGOAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2E9BC90", Offset = "0x2E9A490", VA = "0x182E9BC90")]
	public static T IABJPCMKPIF<T>(this List<T> MJPJIGOGOAP, Predicate<T> LDNIBEBMKBJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2E998C0", Offset = "0x2E980C0", VA = "0x182E998C0")]
	public static T GEIGIJFEAKF<T>(this List<T> MJPJIGOGOAP, int NHHNPPKPBIA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2E9F0B0", Offset = "0x2E9D8B0", VA = "0x182E9F0B0")]
	public static bool PMLALBOKOCH<T>(this List<T> LBOCLDIDPAI, List<T> AMILGMMNNLF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2E97FA0", Offset = "0x2E967A0", VA = "0x182E97FA0")]
	public static T ANINGBDNMFP<T>(this IList<T> IFADMANLNLG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CED0", Offset = "0x2E9B6D0", VA = "0x182E9CED0")]
	public static bool LFEEDCEMDFG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5010", Offset = "0x7A4410")] IReadOnlyList<T> IFADMANLNLG, int NHHNPPKPBIA, [PFABLHCCGAA("This should be `T?` in C# 9.")][KDNNMIKGJNK(false)] out T IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2E9B030", Offset = "0x2E99830", VA = "0x182E9B030")]
	public static bool HAAIJOMPHEI<T>(IReadOnlyList<T> IFADMANLNLG, ICollection MJPJIGOGOAP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C170", Offset = "0x2E9A970", VA = "0x182E9C170")]
	public static void JMIDLDFNKLF<T>(IReadOnlyList<T> IFADMANLNLG, ref ICollection MJPJIGOGOAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D6A0", Offset = "0x2E9BEA0", VA = "0x182E9D6A0")]
	public static bool MGPLEOACKMI<T>(this IReadOnlyList<T> IFADMANLNLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D310", Offset = "0x2E9BB10", VA = "0x182E9D310")]
	public static string LOCKPNJEEIM<T>(this IEnumerable<T> IFADMANLNLG, string OHDEOODOLIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2E98C30", Offset = "0x2E97430", VA = "0x182E98C30")]
	public static T DEENIEHBOEK<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2E9EE70", Offset = "0x2E9D670", VA = "0x182E9EE70")]
	public static T OPOHOEAKJCN<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2E98040", Offset = "0x2E96840", VA = "0x182E98040")]
	public static void BPIBEAGMILL<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2E9D4F0", Offset = "0x2E9BCF0", VA = "0x182E9D4F0")]
	public static void MCFKNPGGJPE<T>(this IList<T> GPOCLJBKMHA, in T ECNGHFJBIJL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E9BBF0", Offset = "0x2E9A3F0", VA = "0x182E9BBF0")]
	public static T HMIEFNEFPKE<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OJBCLCCPNBM
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x23CC390", Offset = "0x23CAB90", VA = "0x1823CC390")]
	public static void KGFEHDKIPGN<T>(this T NFOHJNABMAP, Action<T> CPKEIIHODAD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x23CC3D0", Offset = "0x23CABD0", VA = "0x1823CC3D0")]
	public static V PIGEFIDNMMF<V, T>(this T NFOHJNABMAP, Func<T, V> CPKEIIHODAD, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] V IGBKLJLDCLC) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x23CC180", Offset = "0x23CA980", VA = "0x1823CC180")]
	public static T? AJGLMFFHNGC<T>(this T GPOCLJBKMHA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1A17E50", Offset = "0x1A16650", VA = "0x181A17E50")]
	[IteratorStateMachine(typeof(LEBNCJDONJK))]
	public static IEnumerable<T> CLHOANNABOC<T>(this T GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x23CC2B0", Offset = "0x23CAAB0", VA = "0x1823CC2B0")]
	public static T[] GAFDDHBLLPP<T>(this T GPOCLJBKMHA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OEFMBCPLDCP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long JLABMGHGBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct BAEONBJNHCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly OEFMBCPLDCP FEOGNMNIBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly long JIJHAANDOPO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0440", Offset = "0x6FAEC40", VA = "0x186FB0440")]
	public BAEONBJNHCH(OEFMBCPLDCP NGBOPHHNHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6FB03B0", Offset = "0x6FAEBB0", VA = "0x186FB03B0")]
	public long NGPOCKMDBHI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0290", Offset = "0x6FAEA90", VA = "0x186FB0290")]
	public double AHFHIJOPNHD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0320", Offset = "0x6FAEB20", VA = "0x186FB0320")]
	public double IAHCLIABHCK()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MCMLJFAHLNH
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xD62780", Offset = "0xD60F80", VA = "0x180D62780")]
	public static bool BKFMPOMIDNM(this Type GPOCLJBKMHA, Type MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2BECAC0", Offset = "0x2BEB2C0", VA = "0x182BECAC0")]
	public static bool BKFMPOMIDNM<T>(this Type GPOCLJBKMHA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PELNJLOCJJB
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FGBCPLCCPFP(int NIEMFBGOMOD, int ILGKECLAAID);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float LMGIJHDAFIG(float EJGADLIIMFB, float PKDPPAIKIFG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CFAKOPBAOPO
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3159650", Offset = "0x3157E50", VA = "0x183159650")]
	public static void PLOLBHIBFDI<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5200", Offset = "0x7A4600")] this in KeyValuePair<TKey, TValue> GPOCLJBKMHA, out TKey BDFCACLHAFA, out TValue ECNGHFJBIJL) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3159380", Offset = "0x3157B80", VA = "0x183159380")]
	public static (TKey?, TValue?) IIPGDALAIHB<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5270", Offset = "0x7A4670")] this in KeyValuePair<TKey?, TValue?> GPOCLJBKMHA)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x31595C0", Offset = "0x3157DC0", VA = "0x1831595C0")]
	public static KeyValuePair<TKey?, UValue?> JOFGMBKBHDB<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A52E0", Offset = "0x7A46E0")] this KeyValuePair<TKey?, TValue?> GPOCLJBKMHA, UValue ECNGHFJBIJL)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class PKPGNIBCIDB
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x23D8F10", Offset = "0x23D7710", VA = "0x1823D8F10")]
	[KPFEFEMPEAJ("This should be replaced with the `is not` operator in C# 9.")]
	public static bool PHBEFFAIJCB<T>(this object GPOCLJBKMHA, [NEFDIDCKCBL(true)] out T IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HMGBKLJCAKC
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1D70", Offset = "0x6FB0570", VA = "0x186FB1D70")]
	private static byte[] JDINLNICCDP(int CPOCCBGJOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6FB23C0", Offset = "0x6FB0BC0", VA = "0x186FB23C0")]
	private static byte[] NJPPPEMKOCL(long AAACKIAOAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1CF0", Offset = "0x6FB04F0", VA = "0x186FB1CF0")]
	private static byte[] IJDMHELFDJK(ulong AAACKIAOAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1A10", Offset = "0x6FB0210", VA = "0x186FB1A10")]
	public static Guid AIJMOCDIFNB(params Guid[] KFCBFPPKJFD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2280", Offset = "0x6FB0A80", VA = "0x186FB2280")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, int NHHNPPKPBIA, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1DF0", Offset = "0x6FB05F0", VA = "0x186FB1DF0")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, long NHHNPPKPBIA, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1EC0", Offset = "0x6FB06C0", VA = "0x186FB1EC0")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, ulong NHHNPPKPBIA, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2350", Offset = "0x6FB0B50", VA = "0x186FB2350")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, in Guid MENMDNKLKHO, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1F90", Offset = "0x6FB0790", VA = "0x186FB1F90")]
	private static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, byte[] LDABDAEDGOP, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1C10", Offset = "0x6FB0410", VA = "0x186FB1C10")]
	private static void EBMICMPPCPB(byte[] PCFHAIHNKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1B90", Offset = "0x6FB0390", VA = "0x186FB1B90")]
	private static void DEMIBBHKODD(byte[] PCFHAIHNKAK, int FDMHBFLJJHC, int DNGDHCADJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MKJPMCEMIBC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x145BB90", Offset = "0x145A390", VA = "0x18145BB90")]
	public static uint NFPIDIALDPL(this uint GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xFA7750", Offset = "0xFA5F50", VA = "0x180FA7750")]
	public static uint FEDECAAPMCL(this uint GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KJEMLMHCKBD
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2920", Offset = "0x6FB1120", VA = "0x186FB2920")]
	public static int AMEMBHHOAHO(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB29F0", Offset = "0x6FB11F0", VA = "0x186FB29F0")]
	public static int NIAMKLBCFJF(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2990", Offset = "0x6FB1190", VA = "0x186FB2990")]
	public static int EFDFNMGCKLM(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6FB29E0", Offset = "0x6FB11E0", VA = "0x186FB29E0")]
	public static int FOHKLKDIEFL(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x145BB90", Offset = "0x145A390", VA = "0x18145BB90")]
	public static int NFPIDIALDPL(this int GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xFA7750", Offset = "0xFA5F50", VA = "0x180FA7750")]
	public static int FEDECAAPMCL(this int GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NKDCDIIFKGM
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCB90", Offset = "0x2FBB390", VA = "0x182FBCB90")]
	public static bool AOIMMBEHODN<T, U>(this T GPOCLJBKMHA, in U HHNPCHNMLMA) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2FBCD90", Offset = "0x2FBB590", VA = "0x182FBCD90")]
	public static bool FCIMIMCEDEF<T>(ref T GPOCLJBKMHA, T MDHJAFNLPON) where T : class, IEquatable<T>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ENMMOPHJIKC
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float DALDNIINMAG;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static float EPKMCCBCODI;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static bool KJDECCMCHKF;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly float OEDIJOIENIM;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0CE0", Offset = "0x6FAF4E0", VA = "0x186FB0CE0")]
	public static bool CGACCPBLGHL(float NBLDAOBEAEA, float PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4DBB2F0", Offset = "0x4DB9AF0", VA = "0x184DBB2F0")]
	public static float KCFCDPNCADC(float ECNGHFJBIJL, float FAFCDNENBCM, float LDBGNHOKNMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4DBB310", Offset = "0x4DB9B10", VA = "0x184DBB310")]
	public static int KCFCDPNCADC(int ECNGHFJBIJL, int FAFCDNENBCM, int LDBGNHOKNMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4DBB2D0", Offset = "0x4DB9AD0", VA = "0x184DBB2D0")]
	public static float HLKJFFNLECF(float ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0B70", Offset = "0x6FAF370", VA = "0x186FB0B70")]
	public static float AIGDJPHNLNK(float NBLDAOBEAEA, float PAJLLFKCBBD, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0CD0", Offset = "0x6FAF4D0", VA = "0x186FB0CD0")]
	public static float BGCPOCIBABB(float NBLDAOBEAEA, float PAJLLFKCBBD, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0C10", Offset = "0x6FAF410", VA = "0x186FB0C10")]
	public static float AKOHMAOJFLN(float NBLDAOBEAEA, float PAJLLFKCBBD, float ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0DE0", Offset = "0x6FAF5E0", VA = "0x186FB0DE0")]
	public static float MIPOADEAFCG(float NBLDAOBEAEA, float PAJLLFKCBBD, float ECNGHFJBIJL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BKLNELNKDNK : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BCIDLILPMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKEBEGBOMMH();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class CKFKJBJCGJE
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private sealed class CBAPNLFHMEL : PELNJLOCJJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Random DCGLMBOAPBA;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6FB04F0", Offset = "0x6FAECF0", VA = "0x186FB04F0", Slot = "4")]
		public int FGBCPLCCPFP(int EJGADLIIMFB, int DBLIHCGFONC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0520", Offset = "0x6FAED20", VA = "0x186FB0520", Slot = "5")]
		public float LMGIJHDAFIG(float EJGADLIIMFB, float PKDPPAIKIFG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FB04B0", Offset = "0x6FAECB0", VA = "0x186FB04B0")]
		private double EBCNBHODGGC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0590", Offset = "0x6FAED90", VA = "0x186FB0590")]
		public CBAPNLFHMEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly PELNJLOCJJB OMNBIOGNEGL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0600", Offset = "0x6FAEE00", VA = "0x186FB0600")]
	public static ulong JPIOIHOGNLM()
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DHLJMOIKMPI
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate bool OCDNLPMOLBD<TArgs, T>(in TArgs PFFFGKKOEPM, T FHJBBMIILLG);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate U MFPMLMAJEBK<TArg, U>(in TArg AIMHDAMIMIL);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate U PMGOLHHAFEE<TArg, T, U>(in TArg AIMHDAMIMIL, T JNADKFFEIOO);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate U JJMOIBOGHCE<TArg, T, U>(in TArg AIMHDAMIMIL, IEnumerable<T> CHCFPJJJGHE);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate U JAILCACHDFJ<TArg, T, U>(in TArg AIMHDAMIMIL, T JNADKFFEIOO);

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public readonly struct HLKBHHMBBLH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x35861B0", Offset = "0x35849B0", VA = "0x1835861B0")]
		[PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) IGGPMGLINFM(T HFJJKCHIIHE)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x3586140", Offset = "0x3584940", VA = "0x183586140")]
		[PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) CPAOPJIMLBK(IEnumerable<T> MALDFIPILGH)
		{
			return default((bool, T, IEnumerable<T>));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class ALCAKKCPHLI<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public HashSet<T> otherHash;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public HashSet<T> selfHash;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public ALCAKKCPHLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2315390", Offset = "0x2313B90", VA = "0x182315390")]
		internal bool MNNJBCNOGAI(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4639D90", Offset = "0x4638590", VA = "0x184639D90")]
		internal bool HLKMIIFKOLK(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B42710", Offset = "0x3B40F10", VA = "0x183B42710")]
	public static bool OOEHNELKHPL<T, TArgs>(this IEnumerable<T> GPOCLJBKMHA, in TArgs PFFFGKKOEPM, OCDNLPMOLBD<TArgs, T> GKMOGNDGOID) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2EAD390", Offset = "0x2EABB90", VA = "0x182EAD390")]
	public static U CNLHDKLHDDK<U, T>(this IEnumerable<T> GPOCLJBKMHA, Func<U> AEPABDGGILI, Func<T, U> HFJJKCHIIHE, Func<IEnumerable<T>, U> MALDFIPILGH) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2EACD50", Offset = "0x2EAB550", VA = "0x182EACD50")]
	public static bool CENKBDLFCPA<T, TArgs>(this IEnumerable<T> GPOCLJBKMHA, in TArgs PFFFGKKOEPM, OCDNLPMOLBD<TArgs, T> GKMOGNDGOID) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2EADB60", Offset = "0x2EAC360", VA = "0x182EADB60")]
	public static U FAJNMFLPOPC<U, T, TArg>(this IEnumerable<T> GPOCLJBKMHA, in TArg AIMHDAMIMIL, MFPMLMAJEBK<TArg, U> AEPABDGGILI, PMGOLHHAFEE<TArg, T, U> HFJJKCHIIHE, JJMOIBOGHCE<TArg, T, U> MALDFIPILGH) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2EAE7A0", Offset = "0x2EACFA0", VA = "0x182EAE7A0")]
	public static IEnumerable<U> KECMLOKFADN<U, T, TArg>(this IEnumerable<T> GPOCLJBKMHA, in TArg AIMHDAMIMIL, JAILCACHDFJ<TArg, T, U> PEBLDEGHPBH) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2BED7A0", Offset = "0x2BEBFA0", VA = "0x182BED7A0")]
	public static IEnumerable<T> FOLJHAIOCPK<T>(params IEnumerable<T>[] DDDPJMBCFKJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2EAE350", Offset = "0x2EACB50", VA = "0x182EAE350")]
	public static bool JFHAKHHOCCL<T>(this IEnumerable<T> PDHOFJLLEID, IEnumerable<T> MDHJAFNLPON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2BED7A0", Offset = "0x2BEBFA0", VA = "0x182BED7A0")]
	public static IEnumerable<(TKey?, TValue?)>? KHFPNJGADJA<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5440", Offset = "0x7A4840")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2EACB70", Offset = "0x2EAB370", VA = "0x182EACB70")]
	public static IEnumerable<T> BGKDFNDGCLH<T, TKey>(this IEnumerable<T> IHKODGEFCEF, Func<T, TKey> CCCCOHGNCHJ) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x26CCC00", Offset = "0x26CB400", VA = "0x1826CCC00")]
	[IteratorStateMachine(typeof(DLJHOFGNLMC))]
	public static IEnumerable<T> IKFFCPEKMGP<T, U>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<U> MDHJAFNLPON, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] T JJIHMENIGAO) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1A17B00", Offset = "0x1A16300", VA = "0x181A17B00")]
	public static T HAAEMDMDMLB<T>(this IEnumerable<T> PDHOFJLLEID, T IGBKLJLDCLC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2EADEE0", Offset = "0x2EAC6E0", VA = "0x182EADEE0")]
	public static T HAAEMDMDMLB<T>(this IEnumerable<T> PDHOFJLLEID, T IGBKLJLDCLC, Func<T, bool> GKMOGNDGOID) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1A183A0", Offset = "0x1A16BA0", VA = "0x181A183A0")]
	[IteratorStateMachine(typeof(EFCJHFPJJKI))]
	public static IEnumerable<(T, global::NBIGGEBJMFN<T>)> CLCNONKHKAO<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2EADA70", Offset = "0x2EAC270", VA = "0x182EADA70")]
	public static bool DODELLPEOPI<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2BED7A0", Offset = "0x2BEBFA0", VA = "0x182BED7A0")]
	public static IEnumerable<global::FDBENDDJJIN<T>> OJOINFOLDPA<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2EAF7F0", Offset = "0x2EADFF0", VA = "0x182EAF7F0")]
	public static bool OKHCPHKNICN<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2EAF7A0", Offset = "0x2EADFA0", VA = "0x182EAF7A0")]
	public static IEnumerable<T> NAODOGPDHDP<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2434800", Offset = "0x2433000", VA = "0x182434800")]
	[IteratorStateMachine(typeof(EOMHEAEEICJ))]
	public static IEnumerable<U> BOMHJKBKGAC<U, T>(this IEnumerable<T> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A55C0", Offset = "0x7A49C0")] Func<HLKBHHMBBLH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> MHPHLGPGCON) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2EAF3B0", Offset = "0x2EADBB0", VA = "0x182EAF3B0")]
	public static int LHEDPPNOEIM<T>(this IEnumerable<T> GPOCLJBKMHA, int COIKHAAMKGK = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2EAEBE0", Offset = "0x2EAD3E0", VA = "0x182EAEBE0")]
	public static bool KIMKKEOMLBA<T>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<T> MDHJAFNLPON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2EAE510", Offset = "0x2EACD10", VA = "0x182EAE510")]
	public static (IEnumerable<T>, IEnumerable<T>) JPLINNABNHO<T>(this IEnumerable<T> GPOCLJBKMHA, Func<T, bool> LIMHPPGEFGK) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2EAEE70", Offset = "0x2EAD670", VA = "0x182EAEE70")]
	public static string LFGBFEHHMOI<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2EADF30", Offset = "0x2EAC730", VA = "0x182EADF30")]
	public static Dictionary<TKey?, TValue?>? HNCFBENFMLP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A56B0", Offset = "0x7A4AB0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? PDHOFJLLEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2EADF30", Offset = "0x2EAC730", VA = "0x182EADF30")]
	public static Dictionary<TKey?, TValue?>? HNCFBENFMLP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A5710", Offset = "0x7A4B10")] this IEnumerable<(TKey? Key, TValue? Value)>? PDHOFJLLEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2325260", Offset = "0x2323A60", VA = "0x182325260")]
	public static HashSet<T> PGJFADIIINC<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2EAF7D0", Offset = "0x2EADFD0", VA = "0x182EAF7D0")]
	public static string OJBCKPNPIHC<T>(this IEnumerable<T> GPOCLJBKMHA, string BHBIFNNNNHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x26CCA20", Offset = "0x26CB220", VA = "0x1826CCA20")]
	[IteratorStateMachine(typeof(NIKEKOPFBIL))]
	public static IEnumerable<(T, U)> IIONLKHJGPM<T, U>(this IEnumerable<T> EOEOFNCKKHJ, IEnumerable<U> AOEAFBFCPPC) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2EAD7F0", Offset = "0x2EABFF0", VA = "0x182EAD7F0")]
	public static IEnumerable<V> CPEOJENKING<V, T, U>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<U> MDHJAFNLPON, Func<T, U, V> DBHAKFLALEC, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] T BGMHMGIDCIG, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] U JBBCNCIPJBI) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2EAD880", Offset = "0x2EAC080", VA = "0x182EAD880")]
	public static IEnumerable<(T, U)> CPEOJENKING<T, U>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<U> MDHJAFNLPON, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] T BGMHMGIDCIG, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] U JBBCNCIPJBI) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EJJAFKLGLOF
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2F51BC0", Offset = "0x2F503C0", VA = "0x182F51BC0")]
	public static bool DNPJDDECIKO<T>(this IReadOnlyCollection<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class IEGILFHOGFD : OEFMBCPLDCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Stopwatch FEOGNMNIBEI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long JLABMGHGBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2440", Offset = "0x6FB0C40", VA = "0x186FB2440", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8ACD20", Offset = "0x8AB520", VA = "0x1808ACD20")]
	private IEGILFHOGFD(Stopwatch NGBOPHHNHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2500", Offset = "0x6FB0D00", VA = "0x186FB2500")]
	public static IEGILFHOGFD PFNPLHBPFPH(Stopwatch NGBOPHHNHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2460", Offset = "0x6FB0C60", VA = "0x186FB2460")]
	public static IEGILFHOGFD NAPOIKCMMCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NMOKNMMPCNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3190", Offset = "0x6FB1990", VA = "0x186FB3190")]
	public static RigidTransform OGPCDCIDJEH(RigidTransform GPFAFMOEHGM, RigidTransform BAEIKDDHHKE)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class BONELACKBFD<T> where T : class
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct PEMPBHKMADO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x40A94B0", Offset = "0x40A7CB0", VA = "0x1840A94B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static int MKAKMHPOAHA;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static BAEONBJNHCH MBGIKMDPBOG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long JLABMGHGBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF3B0", Offset = "0x2EFDBB0", VA = "0x182EFF3B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2EFF1B0", Offset = "0x2EFD9B0", VA = "0x182EFF1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF210", Offset = "0x2EFDA10", VA = "0x182EFF210")]
	public static PEMPBHKMADO IJNDHEIFCIK()
	{
		return default(PEMPBHKMADO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF020", Offset = "0x2EFD820", VA = "0x182EFF020")]
	private static void CNDJDCFHOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2EFF400", Offset = "0x2EFDC00", VA = "0x182EFF400")]
	public static void NHGHFKAFNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class AHEMNGIOABF
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1C418E0", Offset = "0x1C400E0", VA = "0x181C418E0")]
	public static bool HBCNIMJOHIE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6040", Offset = "0x7A5440")] this in ReadOnlySpan<T?> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A60B0", Offset = "0x7A54B0")] in ReadOnlySpan<T?> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1C41BE0", Offset = "0x1C403E0", VA = "0x181C41BE0")]
	public static int LHEDPPNOEIM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6120", Offset = "0x7A5520")] this in ReadOnlySpan<T?> GPOCLJBKMHA, int COIKHAAMKGK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1C41A60", Offset = "0x1C40260", VA = "0x181C41A60")]
	public static string LFGBFEHHMOI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6190", Offset = "0x7A5590")] this in ReadOnlySpan<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1C41D00", Offset = "0x1C40500", VA = "0x181C41D00")]
	public static string OJBCKPNPIHC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6200", Offset = "0x7A5600")] this in ReadOnlySpan<T> GPOCLJBKMHA, string BHBIFNNNNHA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LCLBLFIAKPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x10A4D30", Offset = "0x10A3530", VA = "0x1810A4D30")]
	public static bool MGPLEOACKMI(this string IJAKCFMLLEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CNENNIFMDBC
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static OEFMBCPLDCP MPNEELDFHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB09D0", Offset = "0x6FAF1D0", VA = "0x186FB09D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0940", Offset = "0x6FAF140", VA = "0x186FB0940")]
	public static double AHFHIJOPNHD(this OEFMBCPLDCP GPOCLJBKMHA, long OBFPOLGFFMO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KALIDOAAEHE
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate int CNNAGKIBEOP<T>(in T EOEOFNCKKHJ, in T AOEAFBFCPPC);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class ADGJBCMIFMA<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private struct BMFANEIEKJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public readonly int GOGKDEGLBIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public readonly int JBOMFIHOBMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public readonly bool IHLNAFGBDCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public int DMBJKFHPBGF;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2EF9980", Offset = "0x2EF8180", VA = "0x182EF9980")]
			public BMFANEIEKJE(int GOGKDEGLBIL, int JBOMFIHOBMC, bool IHLNAFGBDCM)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly T[] DGLONHDJAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly T[] DKALJHNFONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly CNNAGKIBEOP<T> IBMKHDGPJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly int MMKFNEOHNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly Func<bool> FHOJOOFKKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int KOIIOPHDGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A62D0", Offset = "0x7A56D0")]
		private readonly ADGJBCMIFMA<T>.BMFANEIEKJE[] NBGDFKLHLOB;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3B9F060", Offset = "0x3B9D860", VA = "0x183B9F060")]
		public ADGJBCMIFMA(T[] DGLONHDJAEF, CNNAGKIBEOP<T> IBMKHDGPJMJ, int MMKFNEOHNED, Func<bool> FHOJOOFKKKB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6330", Offset = "0x7A5730")] T[] JMDIKJDFBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3B9E9B0", Offset = "0x3B9D1B0", VA = "0x183B9E9B0")]
		public bool HCNIFKMNBGL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public delegate U KOMAFILEBGG<T, U>(int MCFAKADLDHC, int MIEKHCNMCPL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6390", Offset = "0x7A5790")] in ReadOnlySpan<T> NHOIFPKFJIN);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1C3D220", Offset = "0x1C3BA20", VA = "0x181C3D220")]
	public static ReadOnlyMemory<T> JHBNLOBJEED<T>(this T[] GPOCLJBKMHA) where T : notnull
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x34057B0", Offset = "0x3403FB0", VA = "0x1834057B0")]
	public static T[] PCJPEOHDEHM<T>(int GEFPLPIBMGI, T JJIHMENIGAO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3405A10", Offset = "0x3404210", VA = "0x183405A10")]
	public static void PMIKGMCNBOI<T>(this T[] MENABBKMAHK, T JJIHMENIGAO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2A2D5F0", Offset = "0x2A2BDF0", VA = "0x182A2D5F0")]
	public static void ILJLNOOHGAI<T>(this T[] EABDNHJFDCB, int OCIFJAIBHIA, int BJBICJAGAJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3403FF0", Offset = "0x34027F0", VA = "0x183403FF0")]
	private static void CCOMOJAIDOD<T>(this T[] GPOCLJBKMHA, int INMPMPFNNIP, int CNKIFFMKMOE, T[] MDHJAFNLPON, int DGEJJBIIHKD, int GAPMHHJNHOF, T[] IIMBBHEIGGD, int BICKKGMIBKK, CNNAGKIBEOP<T> IBMKHDGPJMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x34049C0", Offset = "0x34031C0", VA = "0x1834049C0")]
	public static void GCAEEGBJGOH<T>(this T[] GPOCLJBKMHA, int GOGKDEGLBIL, int FGHOJPFDCIA, CNNAGKIBEOP<T> IBMKHDGPJMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34043E0", Offset = "0x3402BE0", VA = "0x1834043E0")]
	public static ADGJBCMIFMA<T> CMFFPNICJOE<T>(this T[] GPOCLJBKMHA, CNNAGKIBEOP<T> IBMKHDGPJMJ, int MMKFNEOHNED, Func<bool> FHOJOOFKKKB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6270", Offset = "0x7A5670")] T[] JMDIKJDFBMI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3404E10", Offset = "0x3403610", VA = "0x183404E10")]
	public static T[] HOIHKHFBLLG<T>(this T[] EABDNHJFDCB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3405930", Offset = "0x3404130", VA = "0x183405930")]
	public static T[] PGPGNDPIKGK<T>(this T[] FOBNDAKIFJN, T AHPBIIJAHLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x34051C0", Offset = "0x34039C0", VA = "0x1834051C0")]
	public static T[] OJKELHMDINN<T>(this T[] FOBNDAKIFJN, int NHHNPPKPBIA, T AHPBIIJAHLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3404EE0", Offset = "0x34036E0", VA = "0x183404EE0")]
	public static T[] INEMDPJECJE<T>(this T[] FOBNDAKIFJN, int NHHNPPKPBIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3404F90", Offset = "0x3403790", VA = "0x183404F90")]
	public static T[] JGKCBIJAJLL<T>(this T[] FOBNDAKIFJN, int NHHNPPKPBIA, T AHPBIIJAHLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3404480", Offset = "0x3402C80", VA = "0x183404480")]
	public static U[] EHFIOAPPLMI<U, T>(this T[] IHGFGANOELJ, int CCLMMIKOIAM, KOMAFILEBGG<T, U> EGDCLPPDABB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2740", Offset = "0x6FB0F40", VA = "0x186FB2740")]
	public static byte[] DEAELMLHGOG(this byte[] GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2560", Offset = "0x6FB0D60", VA = "0x186FB2560")]
	public static byte[] CPIJCFAMKJG(this byte[] GPOCLJBKMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BAGEHDPMPKN
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3477930", Offset = "0x3476130", VA = "0x183477930")]
	public static void JPIGKIGLPKD<K, V>(this IDictionary<K, V> GPOCLJBKMHA, in K BDFCACLHAFA, in V ECNGHFJBIJL, Func<V, V, V> BFBCIOLIGJH) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3475BC0", Offset = "0x34743C0", VA = "0x183475BC0")]
	public static void DAOKCNHAFLM<K, V>(this IDictionary<K, List<V>> GPOCLJBKMHA, in K BDFCACLHAFA, in V ECNGHFJBIJL) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x34775B0", Offset = "0x3475DB0", VA = "0x1834775B0")]
	public static TVal JLOACIOBEMO<TVal, TKey>(this IDictionary<TKey, TVal> BAOLHJKGDLB, in TKey BDFCACLHAFA, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] TVal IGBKLJLDCLC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3476C90", Offset = "0x3475490", VA = "0x183476C90")]
	public static TVal JLOACIOBEMO<TVal, TKey>(this IDictionary<TKey, TVal> BAOLHJKGDLB, in TKey BDFCACLHAFA, Func<TVal> AHBJKPMJFOH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3476A30", Offset = "0x3475230", VA = "0x183476A30")]
	public static TValue HHJBLJEFAKG<TValue, TKey>(this IDictionary<TKey, TValue> BAOLHJKGDLB, in TKey BDFCACLHAFA, [Optional][PFABLHCCGAA("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue IGBKLJLDCLC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x34755F0", Offset = "0x3473DF0", VA = "0x1834755F0")]
	public static V AJNGMBMFLEB<V, K>(this IDictionary<K, V> GPOCLJBKMHA, in K BDFCACLHAFA) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3476340", Offset = "0x3474B40", VA = "0x183476340")]
	public static T2[] GMJCFHAOGEP<T2, T1>(this Dictionary<T1, T2>.ValueCollection JOONHIOHMIH) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3476B10", Offset = "0x3475310", VA = "0x183476B10")]
	public static bool JCOHIHLGEAI<TKey, TValue>(this IDictionary<TKey, TValue> GPOCLJBKMHA, TKey BDFCACLHAFA, TValue ECNGHFJBIJL) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DBAKBCEBDCL
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0B10", Offset = "0x6FAF310", VA = "0x186FB0B10")]
	public static RigidTransform GNMIMHHEAJM(this in RigidTransform GPOCLJBKMHA)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class EFJMLAEGCCN
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2F4DA60", Offset = "0x2F4C260", VA = "0x182F4DA60")]
	public static bool KFBGNHHGLGM<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA, [NEFDIDCKCBL(true)][PFABLHCCGAA("This should be `T?` in C# 9.")] out T IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D910", Offset = "0x2F4C110", VA = "0x182F4D910")]
	public static bool JNAIJCLBAFB<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A65C0", Offset = "0x7A59C0")] out global::FDBENDDJJIN<T> IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D7E0", Offset = "0x2F4BFE0", VA = "0x182F4D7E0")]
	public static T ACGLFPEEOAF<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA, in T EOHICGFEFIM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1C3D550", Offset = "0x1C3BD50", VA = "0x181C3D550")]
	[PFABLHCCGAA("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T LFLDODNIOJL<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2F4D860", Offset = "0x2F4C060", VA = "0x182F4D860")]
	public static T? FABCCMJJBKI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A6660", Offset = "0x7A5A60")] this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct LJGOPKDOKIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly double JNDLJOLGNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly double DDJGPMKEACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public readonly double GIBLADJBOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public readonly double JEKPDHJPHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly double MMGBDCHIPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly int PLEPIEDOEAJ;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6FB30E0", Offset = "0x6FB18E0", VA = "0x186FB30E0")]
	public LJGOPKDOKIE(double AAMLBLEHNNC, double FAFCDNENBCM, double LDBGNHOKNMO, double OOPBAGDOICB, double JADGPLGNHCG, int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6FB30A0", Offset = "0x6FB18A0", VA = "0x186FB30A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2A30", Offset = "0x6FB1230", VA = "0x186FB2A30")]
	public string AHOIENBLHDM(string JIHLEMBEPHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FCGEIINHABG
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x240BC80", Offset = "0x240A480", VA = "0x18240BC80")]
	public static LJGOPKDOKIE KBCEDIPNDFP<T>(this IEnumerable<T> IHKODGEFCEF, Func<T, double> PEBLDEGHPBH, bool LLJAHONDFME = true) where T : notnull
	{
		return default(LJGOPKDOKIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0F00", Offset = "0x6FAF700", VA = "0x186FB0F00")]
	public static LJGOPKDOKIE KBCEDIPNDFP(this IEnumerable<double> IHKODGEFCEF, bool LLJAHONDFME = true)
	{
		return default(LJGOPKDOKIE);
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
