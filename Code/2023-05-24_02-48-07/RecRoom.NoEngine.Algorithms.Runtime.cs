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
		[Cpp2IlInjected.Address(RVA = "0x7F0020", Offset = "0x7EEC20", VA = "0x1807F0020")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F99340", Offset = "0x6F97F40", VA = "0x186F99340")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x852750", Offset = "0x851350", VA = "0x180852750")]
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
		[Cpp2IlInjected.Address(RVA = "0xC81930", Offset = "0xC80530", VA = "0x180C81930")]
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
	[Cpp2IlInjected.Address(RVA = "0x32D17C0", Offset = "0x32D03C0", VA = "0x1832D17C0")]
	public static TaskCompletionSource<T> DFFCBBHLKBE<T>(this TaskCompletionSource<T> BFLDPIIJLEC, TimeSpan OJHABJHLHAL, [Optional] PCJLBNNPGAK? LPJDNLJCICI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32CFBC0", Offset = "0x32CE7C0", VA = "0x1832CFBC0")]
	public static TaskCompletionSource<T> DFFCBBHLKBE<T, TEx>(this TaskCompletionSource<T> BFLDPIIJLEC, TimeSpan OJHABJHLHAL, EFJFOKJPJBI<TEx> ACHNIIFEGGK) where T : notnull where TEx : notnull, HIBDKLHBKLF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F99050", Offset = "0x6F97C50", VA = "0x186F99050")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F979E0", Offset = "0x6F965E0", VA = "0x186F979E0")]
	private static FormattableString BOIPEMPOHEI(TimeSpan FMKOGHAFEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F97E30", Offset = "0x6F96A30", VA = "0x186F97E30")]
	private static string HLGEOHGHMIN(TimeSpan OJHABJHLHAL, string DKIECHCHJFL, bool CGPMHCCEPIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F97F20", Offset = "0x6F96B20", VA = "0x186F97F20")]
	public HIBDKLHBKLF(TimeSpan OJHABJHLHAL, string DKIECHCHJFL, bool CGPMHCCEPIM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HOILNFAKEOP
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E020", Offset = "0x2B7CC20", VA = "0x182B7E020")]
	public static T PNBJHLBKMLC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x794A70", Offset = "0x793E70")] this in ReadOnlyMemory<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DC80", Offset = "0x2B7C880", VA = "0x182B7DC80")]
	public static bool HBCNIMJOHIE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x794AE0", Offset = "0x793EE0")] this in ReadOnlyMemory<T> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x794B50", Offset = "0x793F50")] in ReadOnlyMemory<T> MDHJAFNLPON) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DE40", Offset = "0x2B7CA40", VA = "0x182B7DE40")]
	public static int LHEDPPNOEIM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x794BC0", Offset = "0x793FC0")] this in ReadOnlyMemory<T?> GPOCLJBKMHA, int COIKHAAMKGK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DDA0", Offset = "0x2B7C9A0", VA = "0x182B7DDA0")]
	public static string LFGBFEHHMOI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x794C30", Offset = "0x794030")] this in ReadOnlyMemory<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DKOJIHDECMA
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39A6AA0", Offset = "0x39A56A0", VA = "0x1839A6AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public KOKACOAODJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4367C90", Offset = "0x4366890", VA = "0x184367C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public KKAINNNEDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAAC940", Offset = "0xAAB540", VA = "0x180AAC940")]
		internal int DILFJLLIIEG(T r)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2D75140", Offset = "0x2D73D40", VA = "0x182D75140")]
	public static int EKGGAPJDMPI<T>(this IReadOnlyList<T> EABDNHJFDCB, T ECNGHFJBIJL) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2D794C0", Offset = "0x2D780C0", VA = "0x182D794C0")]
	public static int LLLBPINPPHO<T>(this IReadOnlyList<T> EABDNHJFDCB, T ECNGHFJBIJL) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
	public static void MIEPPGEFOLJ<T>(this HashSet<T> JAEDJOIGJCA, IEnumerable<T> OMCHMPJJNDE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2D74770", Offset = "0x2D73370", VA = "0x182D74770")]
	public static void CPBOKOOIDND<T>(this IList<T> IFADMANLNLG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2D74440", Offset = "0x2D73040", VA = "0x182D74440")]
	public static void CPBOKOOIDND<T>(this IList<T> IFADMANLNLG, int AKJEJNFFNAA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2D75050", Offset = "0x2D73C50", VA = "0x182D75050")]
	public static List<T> DGPHIHHLIGK<T>(this List<T> MJPJIGOGOAP, Predicate<T> LDNIBEBMKBJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2D759D0", Offset = "0x2D745D0", VA = "0x182D759D0")]
	public static int EKGGAPJDMPI<T>(this IReadOnlyList<T> IFADMANLNLG, Predicate<T> GKMOGNDGOID) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2D78060", Offset = "0x2D76C60", VA = "0x182D78060")]
	public static bool IHKNDOHHJNG<T>(this IReadOnlyList<T> IFADMANLNLG, Predicate<T> GKMOGNDGOID, [NEFDIDCKCBL(true)] out List<int>? LPCDBCDPGDB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2D7ADF0", Offset = "0x2D799F0", VA = "0x182D7ADF0")]
	public static bool ODOLPHCGINH<T>(this IReadOnlyList<T> IFADMANLNLG, T FHJBBMIILLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2D7AE40", Offset = "0x2D79A40", VA = "0x182D7AE40")]
	public static bool ODOLPHCGINH<T>(this IReadOnlyList<T> IFADMANLNLG, T FHJBBMIILLG, EqualityComparer<T> MJKDLIIFPMD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2D78910", Offset = "0x2D77510", VA = "0x182D78910")]
	public static int KKMGALLACPF<TElement, TKey>(this IList<TElement> LMPIHKKJCOP, TKey NKPLBELFHAM, Func<TElement, TKey> IBGBJCJCCIJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x794D60", Offset = "0x794160")] Func<TKey, TKey, int> IBMKHDGPJMJ, int NHHNPPKPBIA = 0, [Optional] int? FGHOJPFDCIA) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2D78610", Offset = "0x2D77210", VA = "0x182D78610")]
	public static int KKMGALLACPF<TElement, TKey>(Func<int, TElement> LBPCFCDCDPH, int GCOLLKEBKMP, TKey NKPLBELFHAM, Func<TElement, TKey> IBGBJCJCCIJ, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x794DC0", Offset = "0x7941C0")] Func<TKey, TKey, int> IBMKHDGPJMJ, int NHHNPPKPBIA = 0, [Optional] int? FGHOJPFDCIA) where TElement : notnull where TKey : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2D7AF80", Offset = "0x2D79B80", VA = "0x182D7AF80")]
	public static List<T> OMNBIOGNEGL<T>(this IReadOnlyList<T> IFADMANLNLG, int FGHOJPFDCIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2D75D40", Offset = "0x2D74940", VA = "0x182D75D40")]
	public static bool GMBFAKMOAHN<T>(this List<T> IFADMANLNLG, T FHJBBMIILLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2D79300", Offset = "0x2D77F00", VA = "0x182D79300")]
	public static void LFHJGNABIOA<T>(this List<T> IFADMANLNLG, IEnumerable<T> MJPJIGOGOAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2D74BA0", Offset = "0x2D737A0", VA = "0x182D74BA0")]
	public static void CPPHPNNFPKL<T>(this List<T> IFADMANLNLG, IEnumerable<T> MJPJIGOGOAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2D78000", Offset = "0x2D76C00", VA = "0x182D78000")]
	public static T IABJPCMKPIF<T>(this List<T> MJPJIGOGOAP, Predicate<T> LDNIBEBMKBJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2D75C30", Offset = "0x2D74830", VA = "0x182D75C30")]
	public static T GEIGIJFEAKF<T>(this List<T> MJPJIGOGOAP, int NHHNPPKPBIA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B420", Offset = "0x2D7A020", VA = "0x182D7B420")]
	public static bool PMLALBOKOCH<T>(this List<T> LBOCLDIDPAI, List<T> AMILGMMNNLF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2D74310", Offset = "0x2D72F10", VA = "0x182D74310")]
	public static T ANINGBDNMFP<T>(this IList<T> IFADMANLNLG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D79240", Offset = "0x2D77E40", VA = "0x182D79240")]
	public static bool LFEEDCEMDFG<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x794E20", Offset = "0x794220")] IReadOnlyList<T> IFADMANLNLG, int NHHNPPKPBIA, [PFABLHCCGAA("This should be `T?` in C# 9.")][KDNNMIKGJNK(false)] out T IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D773A0", Offset = "0x2D75FA0", VA = "0x182D773A0")]
	public static bool HAAIJOMPHEI<T>(IReadOnlyList<T> IFADMANLNLG, ICollection MJPJIGOGOAP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2D784E0", Offset = "0x2D770E0", VA = "0x182D784E0")]
	public static void JMIDLDFNKLF<T>(IReadOnlyList<T> IFADMANLNLG, ref ICollection MJPJIGOGOAP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2D79A10", Offset = "0x2D78610", VA = "0x182D79A10")]
	public static bool MGPLEOACKMI<T>(this IReadOnlyList<T> IFADMANLNLG) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2D79680", Offset = "0x2D78280", VA = "0x182D79680")]
	public static string LOCKPNJEEIM<T>(this IEnumerable<T> IFADMANLNLG, string OHDEOODOLIJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2D74FA0", Offset = "0x2D73BA0", VA = "0x182D74FA0")]
	public static T DEENIEHBOEK<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B1E0", Offset = "0x2D79DE0", VA = "0x182D7B1E0")]
	public static T OPOHOEAKJCN<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2D743B0", Offset = "0x2D72FB0", VA = "0x182D743B0")]
	public static void BPIBEAGMILL<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2D79860", Offset = "0x2D78460", VA = "0x182D79860")]
	public static void MCFKNPGGJPE<T>(this IList<T> GPOCLJBKMHA, in T ECNGHFJBIJL) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2D77F60", Offset = "0x2D76B60", VA = "0x182D77F60")]
	public static T HMIEFNEFPKE<T>(this IList<T> GPOCLJBKMHA) where T : notnull
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OJBCLCCPNBM
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x20FF380", Offset = "0x20FDF80", VA = "0x1820FF380")]
	public static void KGFEHDKIPGN<T>(this T NFOHJNABMAP, Action<T> CPKEIIHODAD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x20FF3C0", Offset = "0x20FDFC0", VA = "0x1820FF3C0")]
	public static V PIGEFIDNMMF<V, T>(this T NFOHJNABMAP, Func<T, V> CPKEIIHODAD, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] V IGBKLJLDCLC) where V : notnull where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x20FF170", Offset = "0x20FDD70", VA = "0x1820FF170")]
	public static T? AJGLMFFHNGC<T>(this T GPOCLJBKMHA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x16D3E90", Offset = "0x16D2A90", VA = "0x1816D3E90")]
	[IteratorStateMachine(typeof(LEBNCJDONJK))]
	public static IEnumerable<T> CLHOANNABOC<T>(this T GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x20FF2A0", Offset = "0x20FDEA0", VA = "0x1820FF2A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F96F20", Offset = "0x6F95B20", VA = "0x186F96F20")]
	public BAEONBJNHCH(OEFMBCPLDCP NGBOPHHNHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F96E90", Offset = "0x6F95A90", VA = "0x186F96E90")]
	public long NGPOCKMDBHI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F96D70", Offset = "0x6F95970", VA = "0x186F96D70")]
	public double AHFHIJOPNHD()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F96E00", Offset = "0x6F95A00", VA = "0x186F96E00")]
	public double IAHCLIABHCK()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MCMLJFAHLNH
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xC6A730", Offset = "0xC69330", VA = "0x180C6A730")]
	public static bool BKFMPOMIDNM(this Type GPOCLJBKMHA, Type MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2346D30", Offset = "0x2345930", VA = "0x182346D30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E5A300", Offset = "0x2E58F00", VA = "0x182E5A300")]
	public static void PLOLBHIBFDI<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x794FC0", Offset = "0x7943C0")] this in KeyValuePair<TKey, TValue> GPOCLJBKMHA, out TKey BDFCACLHAFA, out TValue ECNGHFJBIJL) where TKey : notnull where TValue : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A030", Offset = "0x2E58C30", VA = "0x182E5A030")]
	public static (TKey?, TValue?) IIPGDALAIHB<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x795030", Offset = "0x794430")] this in KeyValuePair<TKey?, TValue?> GPOCLJBKMHA)
	{
		return default((TKey, TValue));
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E5A270", Offset = "0x2E58E70", VA = "0x182E5A270")]
	public static KeyValuePair<TKey?, UValue?> JOFGMBKBHDB<TKey, UValue, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7950A0", Offset = "0x7944A0")] this KeyValuePair<TKey?, TValue?> GPOCLJBKMHA, UValue ECNGHFJBIJL)
	{
		return default(KeyValuePair<TKey, UValue>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class PKPGNIBCIDB
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x210BEE0", Offset = "0x210AAE0", VA = "0x18210BEE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F98390", Offset = "0x6F96F90", VA = "0x186F98390")]
	private static byte[] JDINLNICCDP(int CPOCCBGJOLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F989E0", Offset = "0x6F975E0", VA = "0x186F989E0")]
	private static byte[] NJPPPEMKOCL(long AAACKIAOAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F98310", Offset = "0x6F96F10", VA = "0x186F98310")]
	private static byte[] IJDMHELFDJK(ulong AAACKIAOAIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F98030", Offset = "0x6F96C30", VA = "0x186F98030")]
	public static Guid AIJMOCDIFNB(params Guid[] KFCBFPPKJFD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F988A0", Offset = "0x6F974A0", VA = "0x186F988A0")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, int NHHNPPKPBIA, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F98410", Offset = "0x6F97010", VA = "0x186F98410")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, long NHHNPPKPBIA, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F984E0", Offset = "0x6F970E0", VA = "0x186F984E0")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, ulong NHHNPPKPBIA, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6F98970", Offset = "0x6F97570", VA = "0x186F98970")]
	public static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, in Guid MENMDNKLKHO, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F985B0", Offset = "0x6F971B0", VA = "0x186F985B0")]
	private static Guid JLAKJAPJOGA(in Guid APGNPJNPIFB, byte[] LDABDAEDGOP, int FPBNFBFIPHI = 5)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F98230", Offset = "0x6F96E30", VA = "0x186F98230")]
	private static void EBMICMPPCPB(byte[] PCFHAIHNKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F981B0", Offset = "0x6F96DB0", VA = "0x186F981B0")]
	private static void DEMIBBHKODD(byte[] PCFHAIHNKAK, int FDMHBFLJJHC, int DNGDHCADJJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MKJPMCEMIBC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x11EE4D0", Offset = "0x11ED0D0", VA = "0x1811EE4D0")]
	public static uint NFPIDIALDPL(this uint GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xE77440", Offset = "0xE76040", VA = "0x180E77440")]
	public static uint FEDECAAPMCL(this uint GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KJEMLMHCKBD
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F98F40", Offset = "0x6F97B40", VA = "0x186F98F40")]
	public static int AMEMBHHOAHO(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F99010", Offset = "0x6F97C10", VA = "0x186F99010")]
	public static int NIAMKLBCFJF(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6F98FB0", Offset = "0x6F97BB0", VA = "0x186F98FB0")]
	public static int EFDFNMGCKLM(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F99000", Offset = "0x6F97C00", VA = "0x186F99000")]
	public static int FOHKLKDIEFL(this int GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x11EE4D0", Offset = "0x11ED0D0", VA = "0x1811EE4D0")]
	public static int NFPIDIALDPL(this int GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xE77440", Offset = "0xE76040", VA = "0x180E77440")]
	public static int FEDECAAPMCL(this int GPOCLJBKMHA, int FGHOJPFDCIA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NKDCDIIFKGM
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2CE89D0", Offset = "0x2CE75D0", VA = "0x182CE89D0")]
	public static bool AOIMMBEHODN<T, U>(this T GPOCLJBKMHA, in U HHNPCHNMLMA) where T : notnull, IEquatable<T> where U : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8BD0", Offset = "0x2CE77D0", VA = "0x182CE8BD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6F977C0", Offset = "0x6F963C0", VA = "0x186F977C0")]
	public static bool CGACCPBLGHL(float NBLDAOBEAEA, float PAJLLFKCBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4C49550", Offset = "0x4C48150", VA = "0x184C49550")]
	public static float KCFCDPNCADC(float ECNGHFJBIJL, float FAFCDNENBCM, float LDBGNHOKNMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4C49570", Offset = "0x4C48170", VA = "0x184C49570")]
	public static int KCFCDPNCADC(int ECNGHFJBIJL, int FAFCDNENBCM, int LDBGNHOKNMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4C49530", Offset = "0x4C48130", VA = "0x184C49530")]
	public static float HLKJFFNLECF(float ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F97650", Offset = "0x6F96250", VA = "0x186F97650")]
	public static float AIGDJPHNLNK(float NBLDAOBEAEA, float PAJLLFKCBBD, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F977B0", Offset = "0x6F963B0", VA = "0x186F977B0")]
	public static float BGCPOCIBABB(float NBLDAOBEAEA, float PAJLLFKCBBD, float NFOHJNABMAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F976F0", Offset = "0x6F962F0", VA = "0x186F976F0")]
	public static float AKOHMAOJFLN(float NBLDAOBEAEA, float PAJLLFKCBBD, float ECNGHFJBIJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F978C0", Offset = "0x6F964C0", VA = "0x186F978C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F96FD0", Offset = "0x6F95BD0", VA = "0x186F96FD0", Slot = "4")]
		public int FGBCPLCCPFP(int EJGADLIIMFB, int DBLIHCGFONC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6F97000", Offset = "0x6F95C00", VA = "0x186F97000", Slot = "5")]
		public float LMGIJHDAFIG(float EJGADLIIMFB, float PKDPPAIKIFG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6F96F90", Offset = "0x6F95B90", VA = "0x186F96F90")]
		private double EBCNBHODGGC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6F97070", Offset = "0x6F95C70", VA = "0x186F97070")]
		public CBAPNLFHMEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly PELNJLOCJJB OMNBIOGNEGL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F970E0", Offset = "0x6F95CE0", VA = "0x186F970E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EC2DC0", Offset = "0x2EC19C0", VA = "0x182EC2DC0")]
		[PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")]
		public (bool, T, IEnumerable<T>) IGGPMGLINFM(T HFJJKCHIIHE)
		{
			return default((bool, T, IEnumerable<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2D50", Offset = "0x2EC1950", VA = "0x182EC2D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public ALCAKKCPHLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x347BE40", Offset = "0x347AA40", VA = "0x18347BE40")]
		internal bool MNNJBCNOGAI(T i)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4394820", Offset = "0x4393420", VA = "0x184394820")]
		internal bool HLKMIIFKOLK(T i)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2D8C0C0", Offset = "0x2D8ACC0", VA = "0x182D8C0C0")]
	public static bool OOEHNELKHPL<T, TArgs>(this IEnumerable<T> GPOCLJBKMHA, in TArgs PFFFGKKOEPM, OCDNLPMOLBD<TArgs, T> GKMOGNDGOID) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2D89700", Offset = "0x2D88300", VA = "0x182D89700")]
	public static U CNLHDKLHDDK<U, T>(this IEnumerable<T> GPOCLJBKMHA, Func<U> AEPABDGGILI, Func<T, U> HFJJKCHIIHE, Func<IEnumerable<T>, U> MALDFIPILGH) where U : notnull where T : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2D890C0", Offset = "0x2D87CC0", VA = "0x182D890C0")]
	public static bool CENKBDLFCPA<T, TArgs>(this IEnumerable<T> GPOCLJBKMHA, in TArgs PFFFGKKOEPM, OCDNLPMOLBD<TArgs, T> GKMOGNDGOID) where T : notnull where TArgs : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2D89ED0", Offset = "0x2D88AD0", VA = "0x182D89ED0")]
	public static U FAJNMFLPOPC<U, T, TArg>(this IEnumerable<T> GPOCLJBKMHA, in TArg AIMHDAMIMIL, MFPMLMAJEBK<TArg, U> AEPABDGGILI, PMGOLHHAFEE<TArg, T, U> HFJJKCHIIHE, JJMOIBOGHCE<TArg, T, U> MALDFIPILGH) where U : notnull where T : notnull where TArg : notnull
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2D8AB10", Offset = "0x2D89710", VA = "0x182D8AB10")]
	public static IEnumerable<U> KECMLOKFADN<U, T, TArg>(this IEnumerable<T> GPOCLJBKMHA, in TArg AIMHDAMIMIL, JAILCACHDFJ<TArg, T, U> PEBLDEGHPBH) where U : notnull where T : notnull where TArg : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2347A10", Offset = "0x2346610", VA = "0x182347A10")]
	public static IEnumerable<T> FOLJHAIOCPK<T>(params IEnumerable<T>[] DDDPJMBCFKJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A6C0", Offset = "0x2D892C0", VA = "0x182D8A6C0")]
	public static bool JFHAKHHOCCL<T>(this IEnumerable<T> PDHOFJLLEID, IEnumerable<T> MDHJAFNLPON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2347A10", Offset = "0x2346610", VA = "0x182347A10")]
	public static IEnumerable<(TKey?, TValue?)>? KHFPNJGADJA<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7951F0", Offset = "0x7945F0")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2D88EE0", Offset = "0x2D87AE0", VA = "0x182D88EE0")]
	public static IEnumerable<T> BGKDFNDGCLH<T, TKey>(this IEnumerable<T> IHKODGEFCEF, Func<T, TKey> CCCCOHGNCHJ) where T : notnull where TKey : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x252CDC0", Offset = "0x252B9C0", VA = "0x18252CDC0")]
	[IteratorStateMachine(typeof(DLJHOFGNLMC))]
	public static IEnumerable<T> IKFFCPEKMGP<T, U>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<U> MDHJAFNLPON, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] T JJIHMENIGAO) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x16D3B40", Offset = "0x16D2740", VA = "0x1816D3B40")]
	public static T HAAEMDMDMLB<T>(this IEnumerable<T> PDHOFJLLEID, T IGBKLJLDCLC) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A250", Offset = "0x2D88E50", VA = "0x182D8A250")]
	public static T HAAEMDMDMLB<T>(this IEnumerable<T> PDHOFJLLEID, T IGBKLJLDCLC, Func<T, bool> GKMOGNDGOID) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x16D43E0", Offset = "0x16D2FE0", VA = "0x1816D43E0")]
	[IteratorStateMachine(typeof(EFCJHFPJJKI))]
	public static IEnumerable<(T, global::NBIGGEBJMFN<T>)> CLCNONKHKAO<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2D89DE0", Offset = "0x2D889E0", VA = "0x182D89DE0")]
	public static bool DODELLPEOPI<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2347A10", Offset = "0x2346610", VA = "0x182347A10")]
	public static IEnumerable<global::FDBENDDJJIN<T>> OJOINFOLDPA<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2D8BB60", Offset = "0x2D8A760", VA = "0x182D8BB60")]
	public static bool OKHCPHKNICN<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D8BB10", Offset = "0x2D8A710", VA = "0x182D8BB10")]
	public static IEnumerable<T> NAODOGPDHDP<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x214EF10", Offset = "0x214DB10", VA = "0x18214EF10")]
	[IteratorStateMachine(typeof(EOMHEAEEICJ))]
	public static IEnumerable<U> BOMHJKBKGAC<U, T>(this IEnumerable<T> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x795380", Offset = "0x794780")] Func<HLKBHHMBBLH<U>, T, (bool Zero, U One, IEnumerable<U> Many)> MHPHLGPGCON) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2D8B720", Offset = "0x2D8A320", VA = "0x182D8B720")]
	public static int LHEDPPNOEIM<T>(this IEnumerable<T> GPOCLJBKMHA, int COIKHAAMKGK = 0) where T : notnull
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2D8AF50", Offset = "0x2D89B50", VA = "0x182D8AF50")]
	public static bool KIMKKEOMLBA<T>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<T> MDHJAFNLPON) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A880", Offset = "0x2D89480", VA = "0x182D8A880")]
	public static (IEnumerable<T>, IEnumerable<T>) JPLINNABNHO<T>(this IEnumerable<T> GPOCLJBKMHA, Func<T, bool> LIMHPPGEFGK) where T : notnull
	{
		return default((IEnumerable<T>, IEnumerable<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D8B1E0", Offset = "0x2D89DE0", VA = "0x182D8B1E0")]
	public static string LFGBFEHHMOI<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A2A0", Offset = "0x2D88EA0", VA = "0x182D8A2A0")]
	public static Dictionary<TKey?, TValue?>? HNCFBENFMLP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x795470", Offset = "0x794870")] this IEnumerable<KeyValuePair<TKey?, TValue?>>? PDHOFJLLEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A2A0", Offset = "0x2D88EA0", VA = "0x182D8A2A0")]
	public static Dictionary<TKey?, TValue?>? HNCFBENFMLP<TKey, TValue>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7954D0", Offset = "0x7948D0")] this IEnumerable<(TKey? Key, TValue? Value)>? PDHOFJLLEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2058240", Offset = "0x2056E40", VA = "0x182058240")]
	public static HashSet<T> PGJFADIIINC<T>(this IEnumerable<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D8BB40", Offset = "0x2D8A740", VA = "0x182D8BB40")]
	public static string OJBCKPNPIHC<T>(this IEnumerable<T> GPOCLJBKMHA, string BHBIFNNNNHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x252CBE0", Offset = "0x252B7E0", VA = "0x18252CBE0")]
	[IteratorStateMachine(typeof(NIKEKOPFBIL))]
	public static IEnumerable<(T, U)> IIONLKHJGPM<T, U>(this IEnumerable<T> EOEOFNCKKHJ, IEnumerable<U> AOEAFBFCPPC) where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D89B60", Offset = "0x2D88760", VA = "0x182D89B60")]
	public static IEnumerable<V> CPEOJENKING<V, T, U>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<U> MDHJAFNLPON, Func<T, U, V> DBHAKFLALEC, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] T BGMHMGIDCIG, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] U JBBCNCIPJBI) where V : notnull where T : notnull where U : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D89BF0", Offset = "0x2D887F0", VA = "0x182D89BF0")]
	public static IEnumerable<(T, U)> CPEOJENKING<T, U>(this IEnumerable<T> GPOCLJBKMHA, IEnumerable<U> MDHJAFNLPON, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] T BGMHMGIDCIG, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] U JBBCNCIPJBI) where T : notnull where U : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EJJAFKLGLOF
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C911B0", Offset = "0x2C8FDB0", VA = "0x182C911B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F98A60", Offset = "0x6F97660", VA = "0x186F98A60", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x836EE0", Offset = "0x835AE0", VA = "0x180836EE0")]
	private IEGILFHOGFD(Stopwatch NGBOPHHNHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6F98B20", Offset = "0x6F97720", VA = "0x186F98B20")]
	public static IEGILFHOGFD PFNPLHBPFPH(Stopwatch NGBOPHHNHAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F98A80", Offset = "0x6F97680", VA = "0x186F98A80")]
	public static IEGILFHOGFD NAPOIKCMMCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NMOKNMMPCNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F990D0", Offset = "0x6F97CD0", VA = "0x186F990D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E06080", Offset = "0x3E04C80", VA = "0x183E06080", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29A47D0", Offset = "0x29A33D0", VA = "0x1829A47D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2CAFBB0", Offset = "0x2CAE7B0", VA = "0x182CAFBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2CAFC10", Offset = "0x2CAE810", VA = "0x182CAFC10")]
	public static PEMPBHKMADO IJNDHEIFCIK()
	{
		return default(PEMPBHKMADO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2CAFA20", Offset = "0x2CAE620", VA = "0x182CAFA20")]
	private static void CNDJDCFHOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2CAFDB0", Offset = "0x2CAE9B0", VA = "0x182CAFDB0")]
	public static void NHGHFKAFNCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class AHEMNGIOABF
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x19597D0", Offset = "0x19583D0", VA = "0x1819597D0")]
	public static bool HBCNIMJOHIE<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x795E00", Offset = "0x795200")] this in ReadOnlySpan<T?> GPOCLJBKMHA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x795E70", Offset = "0x795270")] in ReadOnlySpan<T?> MDHJAFNLPON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1959AD0", Offset = "0x19586D0", VA = "0x181959AD0")]
	public static int LHEDPPNOEIM<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x795EE0", Offset = "0x7952E0")] this in ReadOnlySpan<T?> GPOCLJBKMHA, int COIKHAAMKGK = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1959950", Offset = "0x1958550", VA = "0x181959950")]
	public static string LFGBFEHHMOI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x795F50", Offset = "0x795350")] this in ReadOnlySpan<T> GPOCLJBKMHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1959BF0", Offset = "0x19587F0", VA = "0x181959BF0")]
	public static string OJBCKPNPIHC<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x795FC0", Offset = "0x7953C0")] this in ReadOnlySpan<T> GPOCLJBKMHA, string BHBIFNNNNHA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LCLBLFIAKPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xF62C10", Offset = "0xF61810", VA = "0x180F62C10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F974B0", Offset = "0x6F960B0", VA = "0x186F974B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F97420", Offset = "0x6F96020", VA = "0x186F97420")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CAA3B0", Offset = "0x2CA8FB0", VA = "0x182CAA3B0")]
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x796090", Offset = "0x795490")]
		private readonly ADGJBCMIFMA<T>.BMFANEIEKJE[] NBGDFKLHLOB;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3910EC0", Offset = "0x390FAC0", VA = "0x183910EC0")]
		public ADGJBCMIFMA(T[] DGLONHDJAEF, CNNAGKIBEOP<T> IBMKHDGPJMJ, int MMKFNEOHNED, Func<bool> FHOJOOFKKKB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7960F0", Offset = "0x7954F0")] T[] JMDIKJDFBMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3910810", Offset = "0x390F410", VA = "0x183910810")]
		public bool HCNIFKMNBGL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public delegate U KOMAFILEBGG<T, U>(int MCFAKADLDHC, int MIEKHCNMCPL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x796150", Offset = "0x795550")] in ReadOnlySpan<T> NHOIFPKFJIN);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1955110", Offset = "0x1953D10", VA = "0x181955110")]
	public static ReadOnlyMemory<T> JHBNLOBJEED<T>(this T[] GPOCLJBKMHA) where T : notnull
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2F6C240", Offset = "0x2F6AE40", VA = "0x182F6C240")]
	public static T[] PCJPEOHDEHM<T>(int GEFPLPIBMGI, T JJIHMENIGAO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2F6C4A0", Offset = "0x2F6B0A0", VA = "0x182F6C4A0")]
	public static void PMIKGMCNBOI<T>(this T[] MENABBKMAHK, T JJIHMENIGAO) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2728340", Offset = "0x2726F40", VA = "0x182728340")]
	public static void ILJLNOOHGAI<T>(this T[] EABDNHJFDCB, int OCIFJAIBHIA, int BJBICJAGAJI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2F6AA80", Offset = "0x2F69680", VA = "0x182F6AA80")]
	private static void CCOMOJAIDOD<T>(this T[] GPOCLJBKMHA, int INMPMPFNNIP, int CNKIFFMKMOE, T[] MDHJAFNLPON, int DGEJJBIIHKD, int GAPMHHJNHOF, T[] IIMBBHEIGGD, int BICKKGMIBKK, CNNAGKIBEOP<T> IBMKHDGPJMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2F6B450", Offset = "0x2F6A050", VA = "0x182F6B450")]
	public static void GCAEEGBJGOH<T>(this T[] GPOCLJBKMHA, int GOGKDEGLBIL, int FGHOJPFDCIA, CNNAGKIBEOP<T> IBMKHDGPJMJ) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2F6AE70", Offset = "0x2F69A70", VA = "0x182F6AE70")]
	public static ADGJBCMIFMA<T> CMFFPNICJOE<T>(this T[] GPOCLJBKMHA, CNNAGKIBEOP<T> IBMKHDGPJMJ, int MMKFNEOHNED, Func<bool> FHOJOOFKKKB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x796030", Offset = "0x795430")] T[] JMDIKJDFBMI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2F6B8A0", Offset = "0x2F6A4A0", VA = "0x182F6B8A0")]
	public static T[] HOIHKHFBLLG<T>(this T[] EABDNHJFDCB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2F6C3C0", Offset = "0x2F6AFC0", VA = "0x182F6C3C0")]
	public static T[] PGPGNDPIKGK<T>(this T[] FOBNDAKIFJN, T AHPBIIJAHLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2F6BC50", Offset = "0x2F6A850", VA = "0x182F6BC50")]
	public static T[] OJKELHMDINN<T>(this T[] FOBNDAKIFJN, int NHHNPPKPBIA, T AHPBIIJAHLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2F6B970", Offset = "0x2F6A570", VA = "0x182F6B970")]
	public static T[] INEMDPJECJE<T>(this T[] FOBNDAKIFJN, int NHHNPPKPBIA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2F6BA20", Offset = "0x2F6A620", VA = "0x182F6BA20")]
	public static T[] JGKCBIJAJLL<T>(this T[] FOBNDAKIFJN, int NHHNPPKPBIA, T AHPBIIJAHLL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2F6AF10", Offset = "0x2F69B10", VA = "0x182F6AF10")]
	public static U[] EHFIOAPPLMI<U, T>(this T[] IHGFGANOELJ, int CCLMMIKOIAM, KOMAFILEBGG<T, U> EGDCLPPDABB) where U : notnull where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6F98D60", Offset = "0x6F97960", VA = "0x186F98D60")]
	public static byte[] DEAELMLHGOG(this byte[] GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6F98B80", Offset = "0x6F97780", VA = "0x186F98B80")]
	public static byte[] CPIJCFAMKJG(this byte[] GPOCLJBKMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BAGEHDPMPKN
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3203FD0", Offset = "0x3202BD0", VA = "0x183203FD0")]
	public static void JPIGKIGLPKD<K, V>(this IDictionary<K, V> GPOCLJBKMHA, in K BDFCACLHAFA, in V ECNGHFJBIJL, Func<V, V, V> BFBCIOLIGJH) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3202260", Offset = "0x3200E60", VA = "0x183202260")]
	public static void DAOKCNHAFLM<K, V>(this IDictionary<K, List<V>> GPOCLJBKMHA, in K BDFCACLHAFA, in V ECNGHFJBIJL) where K : notnull where V : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3203C50", Offset = "0x3202850", VA = "0x183203C50")]
	public static TVal JLOACIOBEMO<TVal, TKey>(this IDictionary<TKey, TVal> BAOLHJKGDLB, in TKey BDFCACLHAFA, [Optional][PFABLHCCGAA("`default!` shouldn't be necessary in C# 9")] TVal IGBKLJLDCLC) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3203330", Offset = "0x3201F30", VA = "0x183203330")]
	public static TVal JLOACIOBEMO<TVal, TKey>(this IDictionary<TKey, TVal> BAOLHJKGDLB, in TKey BDFCACLHAFA, Func<TVal> AHBJKPMJFOH) where TVal : notnull where TKey : notnull
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x32030D0", Offset = "0x3201CD0", VA = "0x1832030D0")]
	public static TValue HHJBLJEFAKG<TValue, TKey>(this IDictionary<TKey, TValue> BAOLHJKGDLB, in TKey BDFCACLHAFA, [Optional][PFABLHCCGAA("`default!` and null-oblivious region shouldn't be necessary in C# 9")] in TValue IGBKLJLDCLC)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3201C90", Offset = "0x3200890", VA = "0x183201C90")]
	public static V AJNGMBMFLEB<V, K>(this IDictionary<K, V> GPOCLJBKMHA, in K BDFCACLHAFA) where V : notnull where K : notnull
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x32029E0", Offset = "0x32015E0", VA = "0x1832029E0")]
	public static T2[] GMJCFHAOGEP<T2, T1>(this Dictionary<T1, T2>.ValueCollection JOONHIOHMIH) where T2 : notnull where T1 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x32031B0", Offset = "0x3201DB0", VA = "0x1832031B0")]
	public static bool JCOHIHLGEAI<TKey, TValue>(this IDictionary<TKey, TValue> GPOCLJBKMHA, TKey BDFCACLHAFA, TValue ECNGHFJBIJL) where TKey : notnull where TValue : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DBAKBCEBDCL
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6F975F0", Offset = "0x6F961F0", VA = "0x186F975F0")]
	public static RigidTransform GNMIMHHEAJM(this in RigidTransform GPOCLJBKMHA)
	{
		return default(RigidTransform);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class EFJMLAEGCCN
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2C8D050", Offset = "0x2C8BC50", VA = "0x182C8D050")]
	public static bool KFBGNHHGLGM<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA, [PFABLHCCGAA("This should be `T?` in C# 9.")][NEFDIDCKCBL(true)] out T IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2C8CF00", Offset = "0x2C8BB00", VA = "0x182C8CF00")]
	public static bool JNAIJCLBAFB<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x796340", Offset = "0x795740")] out global::FDBENDDJJIN<T> IIMBBHEIGGD) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2C8CDD0", Offset = "0x2C8B9D0", VA = "0x182C8CDD0")]
	public static T ACGLFPEEOAF<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA, in T EOHICGFEFIM) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1955440", Offset = "0x1954040", VA = "0x181955440")]
	[PFABLHCCGAA("This should return `T?` in C# 9. `default! isn't necessary.")]
	public static T LFLDODNIOJL<T>(this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : notnull
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2C8CE50", Offset = "0x2C8BA50", VA = "0x182C8CE50")]
	public static T? FABCCMJJBKI<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7963E0", Offset = "0x7957E0")] this IReadOnlyList<T> GPOCLJBKMHA, int NHHNPPKPBIA) where T : struct
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
