using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61F5080", Offset = "0x61F4280", VA = "0x1861F5080")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HMJHLHNNBCF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22AC130", Offset = "0x22AB330", VA = "0x1822AC130")]
	public static BJKCGAGNJIN<T> KILHCDMCFPE<T>(this T[] KPBGCHDNDLM) where T : notnull
	{
		return default(BJKCGAGNJIN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class AEBGOABJEAI<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DKMDKGGKAIH<T> JBGGBHLFPGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MNPNLHNEGFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x37A0370", Offset = "0x379F570", VA = "0x1837A0370", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x37A0510", Offset = "0x379F710", VA = "0x1837A0510")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37A03A0", Offset = "0x379F5A0", VA = "0x1837A03A0")]
	public static AEBGOABJEAI<T> GOMGEEBODDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37A05E0", Offset = "0x379F7E0", VA = "0x1837A05E0")]
	internal AEBGOABJEAI([In] DKMDKGGKAIH<T> BFLJLPICFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x37A0350", Offset = "0x379F550", VA = "0x1837A0350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37A0540", Offset = "0x379F740", VA = "0x1837A0540")]
	public void IFBCDILGPAC(int BNPJLEJJKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x37A04C0", Offset = "0x379F6C0", VA = "0x1837A04C0", Slot = "8")]
	public DKMDKGGKAIH<T>.CBJDDJIPDGC GetEnumerator()
	{
		return default(DKMDKGGKAIH<T>.CBJDDJIPDGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x37A0560", Offset = "0x379F760", VA = "0x1837A0560", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x37A0560", Offset = "0x379F760", VA = "0x1837A0560", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MNHHJHLBMPM<T, U> : IEnumerable<T>, IEnumerable where U : ICIGMLOGLJH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U EKDJJFOEANO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA28E0", Offset = "0x1DA1AE0", VA = "0x181DA28E0")]
	internal MNHHJHLBMPM([In] U MGBABHDOAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x32DA1A0", Offset = "0x32D93A0", VA = "0x1832DA1A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x32DA1A0", Offset = "0x32D93A0", VA = "0x1832DA1A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BOMFECGFODK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22B58F0", Offset = "0x22B4AF0", VA = "0x1822B58F0")]
	public static MNHHJHLBMPM<T, U> GOMGEEBODDD<U>([In] U KPBGCHDNDLM) where U : ICIGMLOGLJH<T>
	{
		return default(MNHHJHLBMPM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ENLIIOGEFKL<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U EKDJJFOEANO;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x32DA540", Offset = "0x32D9740", VA = "0x1832DA540")]
	internal ENLIIOGEFKL([In] U MGBABHDOAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32D9F30", Offset = "0x32D9130", VA = "0x1832D9F30", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x32DA0A0", Offset = "0x32D92A0", VA = "0x1832DA0A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x32DA0A0", Offset = "0x32D92A0", VA = "0x1832DA0A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PPFAGEAAHLA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x26B5850", Offset = "0x26B4A50", VA = "0x1826B5850")]
	public static ENLIIOGEFKL<T, U> GOMGEEBODDD<U>([In] U KPBGCHDNDLM) where U : IEnumerator<T>
	{
		return default(ENLIIOGEFKL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class IMFKMNGIGPN
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27D1CA0", Offset = "0x27D0EA0", VA = "0x1827D1CA0")]
	public static string PLKECALFIHB<T>(this IEnumerable<T> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27C0F10", Offset = "0x27C0110", VA = "0x1827C0F10")]
	public static string NHBOMLGICDF<T>(this IEnumerable<T> KPBGCHDNDLM, string DPKAHCCOGFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LDHIJDNLLEE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2828290", Offset = "0x2827490", VA = "0x182828290")]
	public static bool DJOFGCLNGAC<TSourceEnumerator, TSource>(this TSourceEnumerator KPBGCHDNDLM, [In] TSource BCCLIJMKECF) where TSourceEnumerator : ICIGMLOGLJH<TSource> where TSource : IOADHLEGEJM<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28284E0", Offset = "0x28276E0", VA = "0x1828284E0")]
	public static int MPDAAFDFOLE<TSourceEnumerator, TSource>(this TSourceEnumerator KPBGCHDNDLM, [In] TSource AFCGKMGKPEF) where TSourceEnumerator : ICIGMLOGLJH<TSource> where TSource : IOADHLEGEJM<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ICIGMLOGLJH<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DNINAAJGKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NHCPAMCECEG<T> : ICIGMLOGLJH<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct HIPCNEHIDBC<T, U> : IEnumerable<T>, IEnumerable where U : NHCPAMCECEG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U EKDJJFOEANO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3649150", Offset = "0x3648350", VA = "0x183649150")]
	internal HIPCNEHIDBC([In] U MGBABHDOAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x336D660", Offset = "0x336C860", VA = "0x18336D660", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37F4F90", Offset = "0x37F4190", VA = "0x1837F4F90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37F4F90", Offset = "0x37F4190", VA = "0x1837F4F90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HMNMAKIFOEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x22B5920", Offset = "0x22B4B20", VA = "0x1822B5920")]
	public static HIPCNEHIDBC<T, U> GOMGEEBODDD<U>([In] U KPBGCHDNDLM) where U : NHCPAMCECEG<T>
	{
		return default(HIPCNEHIDBC<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct BJKCGAGNJIN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct EGCNOHJPOGN : ICIGMLOGLJH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] DHPAIPGAALB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int EMGDCPIHNDE;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x32B1E80", Offset = "0x32B1080", VA = "0x1832B1E80", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x32B1730", Offset = "0x32B0930", VA = "0x1832B1730", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x32B1B10", Offset = "0x32B0D10", VA = "0x1832B1B10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1893910", Offset = "0x1892B10", VA = "0x181893910")]
		private EGCNOHJPOGN(T[] KPBGCHDNDLM, int ILNNGHKJMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x32B16E0", Offset = "0x32B08E0", VA = "0x1832B16E0")]
		public static EGCNOHJPOGN GOMGEEBODDD(T[] KPBGCHDNDLM)
		{
			return default(EGCNOHJPOGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DBD920", Offset = "0x1DBCB20", VA = "0x181DBD920", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1DBD950", Offset = "0x1DBCB50", VA = "0x181DBD950", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] NEIDJILBNHD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DOKCLGDELIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3A837E0", Offset = "0x3A829E0", VA = "0x183A837E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T ECAKAEFHALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2753140", Offset = "0x2752340", VA = "0x182753140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
	internal BJKCGAGNJIN(T[] NPPGGGEFJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x47ADCF0", Offset = "0x47ACEF0", VA = "0x1847ADCF0")]
	public static BJKCGAGNJIN<T> LNBIPJDBGMB()
	{
		return default(BJKCGAGNJIN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0")]
	public IEnumerable<T> KACJFNKCOCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x47ADF60", Offset = "0x47AD160", VA = "0x1847ADF60")]
	public ReadOnlyMemory<T> PEEEDAIAILH()
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x47ADBE0", Offset = "0x47ACDE0", VA = "0x1847ADBE0")]
	public ReadOnlySpan<T> CAIPLEDMDLB()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x47ADDB0", Offset = "0x47ACFB0", VA = "0x1847ADDB0")]
	public MNHHJHLBMPM<T, BJKCGAGNJIN<T>.EGCNOHJPOGN> OAPHANGBOPC()
	{
		return default(MNHHJHLBMPM<T, EGCNOHJPOGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x47ADED0", Offset = "0x47AD0D0", VA = "0x1847ADED0")]
	public EGCNOHJPOGN OFGNBHNINGB()
	{
		return default(EGCNOHJPOGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x47ADC70", Offset = "0x47ACE70", VA = "0x1847ADC70")]
	public IEnumerator<T> HPMIKEPMPON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x47ADFF0", Offset = "0x47AD1F0", VA = "0x1847ADFF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FGPMNELOECO
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x22D6EE0", Offset = "0x22D60E0", VA = "0x1822D6EE0")]
	public static BJKCGAGNJIN<T> JBMMICJJMMJ<T>(params T[] NPPGGGEFJIJ) where T : notnull
	{
		return default(BJKCGAGNJIN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61F5020", Offset = "0x61F4220", VA = "0x1861F5020")]
	public static Stream KNAJHNEMGPG(this BJKCGAGNJIN<byte> KPBGCHDNDLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(DKMDKGGKAIH<>.LGNDAFJECDF))]
public struct DKMDKGGKAIH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct CBJDDJIPDGC : NHCPAMCECEG<T>, ICIGMLOGLJH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] FLALDIJEAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int IOPFCDLFMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int EMGDCPIHNDE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x48E3FD0", Offset = "0x48E31D0", VA = "0x1848E3FD0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T FEMEMEPICLL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x48E3820", Offset = "0x48E2A20", VA = "0x1848E3820", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x48E3AE0", Offset = "0x48E2CE0", VA = "0x1848E3AE0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x48E3C80", Offset = "0x48E2E80", VA = "0x1848E3C80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x37C7B60", Offset = "0x37C6D60", VA = "0x1837C7B60")]
		internal CBJDDJIPDGC(T[] CDNFLDEAOKG, int BNPJLEJJKIB, int ILNNGHKJMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x48E3680", Offset = "0x48E2880", VA = "0x1848E3680")]
		public static CBJDDJIPDGC GOMGEEBODDD(DKMDKGGKAIH<T> KPBGCHDNDLM)
		{
			return default(CBJDDJIPDGC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x332BE20", Offset = "0x332B020", VA = "0x18332BE20", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3327C70", Offset = "0x3326E70", VA = "0x183327C70", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct KIBJOOMIKMJ : ICIGMLOGLJH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CBJDDJIPDGC EKDJJFOEANO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3B644C0", Offset = "0x3B636C0", VA = "0x183B644C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3B64090", Offset = "0x3B63290", VA = "0x183B64090", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3B64170", Offset = "0x3B63370", VA = "0x183B64170", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1DA28E0", Offset = "0x1DA1AE0", VA = "0x181DA28E0")]
		private KIBJOOMIKMJ([In] CBJDDJIPDGC MGBABHDOAIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B63E90", Offset = "0x3B63090", VA = "0x183B63E90")]
		public static KIBJOOMIKMJ GOMGEEBODDD([In] DKMDKGGKAIH<T> KPBGCHDNDLM)
		{
			return default(KIBJOOMIKMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3B63F40", Offset = "0x3B63140", VA = "0x183B63F40", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3B63F80", Offset = "0x3B63180", VA = "0x183B63F80", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3B63E50", Offset = "0x3B63050", VA = "0x183B63E50", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class LGNDAFJECDF
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] FLALDIJEAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int IOPFCDLFMEK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5080310", Offset = "0x507F510", VA = "0x185080310")]
	public static DKMDKGGKAIH<T> GOMGEEBODDD()
	{
		return default(DKMDKGGKAIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5080260", Offset = "0x507F460", VA = "0x185080260")]
	public static DKMDKGGKAIH<T> FFLBCBCKDGL(int EOPCNNFHDCM)
	{
		return default(DKMDKGGKAIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1893910", Offset = "0x1892B10", VA = "0x181893910")]
	internal DKMDKGGKAIH(T[] CDNFLDEAOKG, int BNPJLEJJKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x50803B0", Offset = "0x507F5B0", VA = "0x1850803B0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GANKBEEALMA
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x275A120", Offset = "0x2759320", VA = "0x18275A120")]
	public static void JNJLPFFCJBK<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2757D60", Offset = "0x2756F60", VA = "0x182757D60")]
	public static string IKGOGEFAAKP<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x88BDC0", Offset = "0x88AFC0", VA = "0x18088BDC0")]
	public static T[] MAJHGOCDEFI<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2753010", Offset = "0x2752210", VA = "0x182753010")]
	public static T EOIPIOCNLEH<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM, int ABHDANNAKPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2753010", Offset = "0x2752210", VA = "0x182753010")]
	public static T HJLJOCFPLOL<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, int ABHDANNAKPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x275A360", Offset = "0x2759560", VA = "0x18275A360")]
	public static T NLBDKDDHANI<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM, int ABHDANNAKPK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2753420", Offset = "0x2752620", VA = "0x182753420")]
	public static void FMPOAGCCLEO<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, int ABHDANNAKPK, [In] T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2755A60", Offset = "0x2754C60", VA = "0x182755A60")]
	public static void IBKILBDIFFF<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, int ABHDANNAKPK, T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DADE80", Offset = "0x1DAD080", VA = "0x181DADE80")]
	public static int AJHKOHDNJIC<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2752EC0", Offset = "0x27520C0", VA = "0x182752EC0")]
	public static ReadOnlySpan<T> CAIPLEDMDLB<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x275A5A0", Offset = "0x27597A0", VA = "0x18275A5A0")]
	public static T[] NPKLENFPFDN<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2752EA0", Offset = "0x27520A0", VA = "0x182752EA0")]
	public static T BPEGALEHLLF<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2755730", Offset = "0x2754930", VA = "0x182755730")]
	public static T[] HACAKMDFOAE<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27532A0", Offset = "0x27524A0", VA = "0x1827532A0")]
	public static BJKCGAGNJIN<T> FJFNHHFKMPL<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return default(BJKCGAGNJIN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x275A990", Offset = "0x2759B90", VA = "0x18275A990")]
	public static void OJOKKDMOJFN<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, [In] T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2752CC0", Offset = "0x2751EC0", VA = "0x182752CC0")]
	public static void AFEFGAGEGDD<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2755860", Offset = "0x2754A60", VA = "0x182755860")]
	public static void HDLHHHHLAJP<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, int ILNNGHKJMBD, [In] T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2752E50", Offset = "0x2752050", VA = "0x182752E50")]
	public static void ALBFEBKAMND<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, int ILNNGHKJMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2752DF0", Offset = "0x2751FF0", VA = "0x182752DF0")]
	public static T AFIKLKAEMFI<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2755D70", Offset = "0x2754F70", VA = "0x182755D70")]
	public static void IFBCDILGPAC<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, int BNPJLEJJKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2753DF0", Offset = "0x2752FF0", VA = "0x182753DF0")]
	private static void GFGFJHGOKHO<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, int EOPCNNFHDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2757BE0", Offset = "0x2756DE0", VA = "0x182757BE0")]
	public static void IICCKONGNNF<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x275A710", Offset = "0x2759910", VA = "0x18275A710")]
	public static DKMDKGGKAIH<T> OIJLLNDPLBD<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM, GDMFDBPAHPO<T, T> HNJLBPPCHNG)
	{
		return default(DKMDKGGKAIH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x275A1F0", Offset = "0x27593F0", VA = "0x18275A1F0")]
	public static bool NJLMADBIOHO<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM, [In] T AFCGKMGKPEF) where T : IOADHLEGEJM<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2752E90", Offset = "0x2752090", VA = "0x182752E90")]
	public static bool BINBACMBECC<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x275A6D0", Offset = "0x27598D0", VA = "0x18275A6D0")]
	public static bool ODCJDMIBLBG<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM, int ABHDANNAKPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x27559D0", Offset = "0x2754BD0", VA = "0x1827559D0")]
	public static DKMDKGGKAIH<T>.KIBJOOMIKMJ HPMIKEPMPON<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return default(DKMDKGGKAIH<T>.KIBJOOMIKMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x27559D0", Offset = "0x2754BD0", VA = "0x1827559D0")]
	public static DKMDKGGKAIH<T>.CBJDDJIPDGC ONJBKINKCPA<T>(this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return default(DKMDKGGKAIH<T>.CBJDDJIPDGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x275A180", Offset = "0x2759380", VA = "0x18275A180")]
	public static MNHHJHLBMPM<T, DKMDKGGKAIH<T>.KIBJOOMIKMJ> MHNHEPHKKGA<T>([In] this DKMDKGGKAIH<T> KPBGCHDNDLM)
	{
		return default(MNHHJHLBMPM<T, DKMDKGGKAIH<T>.KIBJOOMIKMJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class KPDHNFOPCLI
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x28263B0", Offset = "0x28255B0", VA = "0x1828263B0")]
	public static T[] PMOEMCEPFOI<T>(int DKMFLNHKFDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
	public static void OKDBONIHAGJ<T>(T[] NPPGGGEFJIJ)
	{
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
