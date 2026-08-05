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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A270E0", Offset = "0x7A25AE0", VA = "0x187A270E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EBJNBBMMJFD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x33BB790", Offset = "0x33BA190", VA = "0x1833BB790")]
	public static MAHBDBKPKJC<T> JBECKGCLCIN<T>(this T[] IJPDNJELPLO) where T : notnull
	{
		return default(MAHBDBKPKJC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class ANJGPMICFCG<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CHFNJPOOAHD<T> PJGJHAFIKEM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x50BDA10", Offset = "0x50BC410", VA = "0x1850BDA10", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x50BDBC0", Offset = "0x50BC5C0", VA = "0x1850BDBC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x50BDA50", Offset = "0x50BC450", VA = "0x1850BDA50")]
	public static ANJGPMICFCG<T> DDDHPONDPCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x436E520", Offset = "0x436CF20", VA = "0x18436E520")]
	internal ANJGPMICFCG([In] CHFNJPOOAHD<T> GBDMJHAPPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x50BDB80", Offset = "0x50BC580", VA = "0x1850BDB80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x50BDC50", Offset = "0x50BC650", VA = "0x1850BDC50")]
	public void LPAGBEHOLKL(int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x50BDC00", Offset = "0x50BC600", VA = "0x1850BDC00", Slot = "8")]
	public CHFNJPOOAHD<T>.ODPLOGEIAMD GetEnumerator()
	{
		return default(CHFNJPOOAHD<T>.ODPLOGEIAMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x50BDC90", Offset = "0x50BC690", VA = "0x1850BDC90", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x50BDC90", Offset = "0x50BC690", VA = "0x1850BDC90", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GOENCHOCOMO<T, U> : IEnumerable<T>, IEnumerable where U : EJLICBIJGOP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U IHOPIEFFOMJ;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2649E00", Offset = "0x2648800", VA = "0x182649E00")]
	internal GOENCHOCOMO([In] U EEBIIAOHCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x48FB9D0", Offset = "0x48FA3D0", VA = "0x1848FB9D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x48FB9D0", Offset = "0x48FA3D0", VA = "0x1848FB9D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GEOAMLEMOLB<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3651F90", Offset = "0x3650990", VA = "0x183651F90")]
	public static GOENCHOCOMO<T, U> DDDHPONDPCL<U>([In] U IJPDNJELPLO) where U : EJLICBIJGOP<T>
	{
		return default(GOENCHOCOMO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct ANPIJCPJHJI<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U IHOPIEFFOMJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50C0A80", Offset = "0x50BF480", VA = "0x1850C0A80")]
	internal ANPIJCPJHJI([In] U EEBIIAOHCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x33AE570", Offset = "0x33ACF70", VA = "0x1833AE570", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x50C0830", Offset = "0x50BF230", VA = "0x1850C0830", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x50C0830", Offset = "0x50BF230", VA = "0x1850C0830", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CINDAGPPKIP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3651F00", Offset = "0x3650900", VA = "0x183651F00")]
	public static ANPIJCPJHJI<T, U> DDDHPONDPCL<U>([In] U IJPDNJELPLO) where U : IEnumerator<T>
	{
		return default(ANPIJCPJHJI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HIICJFOMHIA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3681C70", Offset = "0x3680670", VA = "0x183681C70")]
	public static string ALACDDFAMOL<T>(this IEnumerable<T> IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3687670", Offset = "0x3686070", VA = "0x183687670")]
	public static string LGBIMDDKDBM<T>(this IEnumerable<T> IJPDNJELPLO, string HHPMALNKLIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HOFGCMFBHPL
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x36A3C90", Offset = "0x36A2690", VA = "0x1836A3C90")]
	public static bool JAHEPJOOEHP<TSourceEnumerator, TSource>(this TSourceEnumerator IJPDNJELPLO, [In] TSource OIBJKKOCOBE) where TSourceEnumerator : EJLICBIJGOP<TSource> where TSource : MIOHJJIPPAJ<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x36A4150", Offset = "0x36A2B50", VA = "0x1836A4150")]
	public static int OLPLOODHDDG<TSourceEnumerator, TSource>(this TSourceEnumerator IJPDNJELPLO, [In] TSource PPJFMHBDGNA) where TSourceEnumerator : EJLICBIJGOP<TSource> where TSource : MIOHJJIPPAJ<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x36A3EE0", Offset = "0x36A28E0", VA = "0x1836A3EE0")]
	public static int MPHHMPIKKAC<TSourceEnumerator, TSource>(this TSourceEnumerator IJPDNJELPLO, [In] TSource PPJFMHBDGNA) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EJLICBIJGOP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T GNNLOKFDOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EEGJLBNPLLA<T> : EJLICBIJGOP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct HBOJEGAEKDH<T, U> : IEnumerable<T>, IEnumerable where U : EEGJLBNPLLA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U IHOPIEFFOMJ;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x435A0A0", Offset = "0x4358AA0", VA = "0x18435A0A0")]
	internal HBOJEGAEKDH([In] U EEBIIAOHCCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x443C710", Offset = "0x443B110", VA = "0x18443C710", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x48FBA70", Offset = "0x48FA470", VA = "0x1848FBA70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x48FBA70", Offset = "0x48FA470", VA = "0x1848FBA70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LJEOKHFHMKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x36520B0", Offset = "0x3650AB0", VA = "0x1836520B0")]
	public static HBOJEGAEKDH<T, U> DDDHPONDPCL<U>([In] U IJPDNJELPLO) where U : EEGJLBNPLLA<T>
	{
		return default(HBOJEGAEKDH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct MAHBDBKPKJC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct DKAIBPBCLEA : EJLICBIJGOP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] KLMEHFIGCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int NDLDDFHBOLN;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3F19270", Offset = "0x3F17C70", VA = "0x183F19270", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3F18CB0", Offset = "0x3F176B0", VA = "0x183F18CB0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3F18E20", Offset = "0x3F17820", VA = "0x183F18E20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xBB2110", Offset = "0xBB0B10", VA = "0x180BB2110")]
		private DKAIBPBCLEA(T[] IJPDNJELPLO, int DOAKEFBOPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F18B30", Offset = "0x3F17530", VA = "0x183F18B30")]
		public static DKAIBPBCLEA DDDHPONDPCL(T[] IJPDNJELPLO)
		{
			return default(DKAIBPBCLEA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x269C4A0", Offset = "0x269AEA0", VA = "0x18269C4A0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x269C4D0", Offset = "0x269AED0", VA = "0x18269C4D0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] EGEMPEPIAIB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5120070", Offset = "0x511EA70", VA = "0x185120070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T NKIDLMDDABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x33ACFC0", Offset = "0x33AB9C0", VA = "0x1833ACFC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
	internal MAHBDBKPKJC(T[] NAKGFAINKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5120110", Offset = "0x511EB10", VA = "0x185120110")]
	public static MAHBDBKPKJC<T> KPJGFDDMHFP()
	{
		return default(MAHBDBKPKJC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
	public IEnumerable<T> IBFPBHAGIBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x511FFD0", Offset = "0x511E9D0", VA = "0x18511FFD0")]
	public ReadOnlySpan<T> HKCNMEFCKLB()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x511FE00", Offset = "0x511E800", VA = "0x18511FE00")]
	public GOENCHOCOMO<T, MAHBDBKPKJC<T>.DKAIBPBCLEA> BPCCHIFAEFD()
	{
		return default(GOENCHOCOMO<T, DKAIBPBCLEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x511FF30", Offset = "0x511E930", VA = "0x18511FF30")]
	public DKAIBPBCLEA GGPPDHNJEBH()
	{
		return default(DKAIBPBCLEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5120090", Offset = "0x511EA90", VA = "0x185120090")]
	public IEnumerator<T> KCFKLFFNEEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x51201E0", Offset = "0x511EBE0", VA = "0x1851201E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KELHKPGIFMI
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x33BEB70", Offset = "0x33BD570", VA = "0x1833BEB70")]
	public static MAHBDBKPKJC<T> HJKGBIPDFOG<T>(params T[] NAKGFAINKPB) where T : notnull
	{
		return default(MAHBDBKPKJC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A27080", Offset = "0x7A25A80", VA = "0x187A27080")]
	public static Stream OJIFBOGNOFJ(this MAHBDBKPKJC<byte> IJPDNJELPLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(CHFNJPOOAHD<>.JGEGNHEEJCM))]
public struct CHFNJPOOAHD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct ODPLOGEIAMD : EEGJLBNPLLA<T>, EJLICBIJGOP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] BPKAEKMILPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int OFPCMILODDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int NDLDDFHBOLN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x52CED90", Offset = "0x52CD790", VA = "0x1852CED90", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T JNKMAMFCMCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x52CE340", Offset = "0x52CCD40", VA = "0x1852CE340")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T FMPLDOEMPPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x52CE4A0", Offset = "0x52CCEA0", VA = "0x1852CE4A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x52CE810", Offset = "0x52CD210", VA = "0x1852CE810", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x52CEB70", Offset = "0x52CD570", VA = "0x1852CEB70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x51777C0", Offset = "0x51761C0", VA = "0x1851777C0")]
		internal ODPLOGEIAMD(T[] NNLLAHLBLIH, int PGJKBFGEJNK, int DOAKEFBOPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x52CE440", Offset = "0x52CCE40", VA = "0x1852CE440")]
		public static ODPLOGEIAMD DDDHPONDPCL(CHFNJPOOAHD<T> IJPDNJELPLO)
		{
			return default(ODPLOGEIAMD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x43F89A0", Offset = "0x43F73A0", VA = "0x1843F89A0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x436BFD0", Offset = "0x436A9D0", VA = "0x18436BFD0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct PIICBFEICLF : EJLICBIJGOP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ODPLOGEIAMD IHOPIEFFOMJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x53D6C40", Offset = "0x53D5640", VA = "0x1853D6C40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x53D6840", Offset = "0x53D5240", VA = "0x1853D6840", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x53D6A00", Offset = "0x53D5400", VA = "0x1853D6A00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2649E00", Offset = "0x2648800", VA = "0x182649E00")]
		private PIICBFEICLF([In] ODPLOGEIAMD EEBIIAOHCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x53D66D0", Offset = "0x53D50D0", VA = "0x1853D66D0")]
		public static PIICBFEICLF DDDHPONDPCL([In] CHFNJPOOAHD<T> IJPDNJELPLO)
		{
			return default(PIICBFEICLF);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x53D67C0", Offset = "0x53D51C0", VA = "0x1853D67C0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x53D6800", Offset = "0x53D5200", VA = "0x1853D6800", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x53D6780", Offset = "0x53D5180", VA = "0x1853D6780", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class JGEGNHEEJCM
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] BPKAEKMILPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int OFPCMILODDP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6576B20", Offset = "0x6575520", VA = "0x186576B20")]
	public static CHFNJPOOAHD<T> DDDHPONDPCL()
	{
		return default(CHFNJPOOAHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6576A60", Offset = "0x6575460", VA = "0x186576A60")]
	public static CHFNJPOOAHD<T> DCDLBDKKDGL(int CIIHPLFOGKO)
	{
		return default(CHFNJPOOAHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xBB2110", Offset = "0xBB0B10", VA = "0x180BB2110")]
	internal CHFNJPOOAHD(T[] NNLLAHLBLIH, int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6576BD0", Offset = "0x65755D0", VA = "0x186576BD0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ECACJELMALI
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int KEIPNILDAHF<TCtx, T>([In] TCtx PJENKJOEENI, T HIHOACCANFP, T JJEIFHEKJKL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x34B1690", Offset = "0x34B0090", VA = "0x1834B1690")]
	public static void HEJCAAOAKNK<T>(this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x34AD9D0", Offset = "0x34AC3D0", VA = "0x1834AD9D0")]
	public static string FFPNHLDHICB<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
	public static T[] JFDPEAEHEJK<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x269C590", Offset = "0x269AF90", VA = "0x18269C590")]
	public static T BLCCCENAIKI<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO, int LGMJDKKAMNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x269C590", Offset = "0x269AF90", VA = "0x18269C590")]
	public static T PGHOBDGELNI<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, int LGMJDKKAMNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34AA0E0", Offset = "0x34A8AE0", VA = "0x1834AA0E0")]
	public static T CHNHNOBGFHH<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO, int LGMJDKKAMNE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x34AC900", Offset = "0x34AB300", VA = "0x1834AC900")]
	public static void PMHEFKOCJCJ<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, int LGMJDKKAMNE, [In] T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x34AC900", Offset = "0x34AB300", VA = "0x1834AC900")]
	public static void EGLKBHBMNCL<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, int LGMJDKKAMNE, T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xD409B0", Offset = "0xD3F3B0", VA = "0x180D409B0")]
	public static int ADAEJIBFAKD<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34B1710", Offset = "0x34B0110", VA = "0x1834B1710")]
	public static ReadOnlySpan<T> HKCNMEFCKLB<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x34B19B0", Offset = "0x34B03B0", VA = "0x1834B19B0")]
	public static T[] JPFBJLHIHHN<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x34ACF90", Offset = "0x34AB990", VA = "0x1834ACF90")]
	public static T EPNMHLBDALH<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x34AC230", Offset = "0x34AAC30", VA = "0x1834AC230")]
	public static T[] DDFIFCLFBDA<T>(this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x34B5220", Offset = "0x34B3C20", VA = "0x1834B5220")]
	public static MAHBDBKPKJC<T> POLOPEDOIBB<T>(this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return default(MAHBDBKPKJC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x34B1250", Offset = "0x34AFC50", VA = "0x1834B1250")]
	public static void HEHCILJMFIP<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, [In] T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x34AC3C0", Offset = "0x34AADC0", VA = "0x1834AC3C0")]
	public static void DLGIKJHLHIB<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x34AC520", Offset = "0x34AAF20", VA = "0x1834AC520")]
	public static void EECGMKNAFDF<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, int DOAKEFBOPIA, [In] T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x34A9520", Offset = "0x34A7F20", VA = "0x1834A9520")]
	public static void BEKDJAABILJ<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, int DOAKEFBOPIA, [In] CHFNJPOOAHD<T> IOMEFCNHNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x34ACE30", Offset = "0x34AB830", VA = "0x1834ACE30")]
	public static void ELAJEHMCHFG<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, int DOAKEFBOPIA, T PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x34B4790", Offset = "0x34B3190", VA = "0x1834B4790")]
	public static void MEANJLPEEFF<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, int DOAKEFBOPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x34AA180", Offset = "0x34A8B80", VA = "0x1834AA180")]
	public static T CLNDHNEIKMN<T>(this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x34B21A0", Offset = "0x34B0BA0", VA = "0x1834B21A0")]
	public static void LPAGBEHOLKL<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x34AAA30", Offset = "0x34A9430", VA = "0x1834AAA30")]
	private static void DCBGACJBEKO<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, int CIIHPLFOGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x34B49A0", Offset = "0x34B33A0", VA = "0x1834B49A0")]
	public static void OPINELCICKH<T>(this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x34B4670", Offset = "0x34B3070", VA = "0x1834B4670")]
	public static CHFNJPOOAHD<T> MBAELHOLOJC<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO, HHNKKJKJOPB<T, T> EBGKJHOIGLF)
	{
		return default(CHFNJPOOAHD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x34A9EB0", Offset = "0x34A88B0", VA = "0x1834A9EB0")]
	public static bool CBCJJMKDJJC<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, T PPJFMHBDGNA) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x34B47D0", Offset = "0x34B31D0", VA = "0x1834B47D0")]
	public static bool MPAFFAMHDNJ<T>(this CHFNJPOOAHD<T> IJPDNJELPLO, [In] T PPJFMHBDGNA) where T : MIOHJJIPPAJ<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x34B1860", Offset = "0x34B0260", VA = "0x1834B1860")]
	public static bool IFMEABDJOPG<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x34B1AE0", Offset = "0x34B04E0", VA = "0x1834B1AE0")]
	public static bool LNIKIKPGMAJ<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO, int LGMJDKKAMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34B1810", Offset = "0x34B0210", VA = "0x1834B1810")]
	public static void IECJDEFOMMK<T, TCtx>(this CHFNJPOOAHD<T> IJPDNJELPLO, [In] TCtx PJENKJOEENI, KEIPNILDAHF<TCtx, T> FDHDFEJHHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x34B48A0", Offset = "0x34B32A0", VA = "0x1834B48A0")]
	private static void NBKPLIGOEDA<T, TCtx>(CHFNJPOOAHD<T> IJPDNJELPLO, [In] TCtx PJENKJOEENI, KEIPNILDAHF<TCtx, T> FDHDFEJHHEE, int APBHGBOAPJJ, int DGMHONFJOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x34A95E0", Offset = "0x34A7FE0", VA = "0x1834A95E0")]
	private static int BGDOIKFOCJF<T, TCtx>(CHFNJPOOAHD<T> IJPDNJELPLO, [In] TCtx PJENKJOEENI, KEIPNILDAHF<TCtx, T> FDHDFEJHHEE, int APBHGBOAPJJ, int DGMHONFJOJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x341E960", Offset = "0x341D360", VA = "0x18341E960")]
	public static CHFNJPOOAHD<T>.PIICBFEICLF KCFKLFFNEEA<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return default(CHFNJPOOAHD<T>.PIICBFEICLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x341E960", Offset = "0x341D360", VA = "0x18341E960")]
	public static CHFNJPOOAHD<T>.ODPLOGEIAMD LPDOFLBFNOL<T>(this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return default(CHFNJPOOAHD<T>.ODPLOGEIAMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x341D210", Offset = "0x341BC10", VA = "0x18341D210")]
	public static GOENCHOCOMO<T, CHFNJPOOAHD<T>.PIICBFEICLF> PCAOLCCOLGF<T>([In] this CHFNJPOOAHD<T> IJPDNJELPLO)
	{
		return default(GOENCHOCOMO<T, CHFNJPOOAHD<T>.PIICBFEICLF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class LINPOIKFOCP
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x372AC70", Offset = "0x3729670", VA = "0x18372AC70")]
	public static T[] NDOODCDNKPG<T>(int PICLDLMFMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	public static void FIAAIELMBNB<T>(T[] NAKGFAINKPB)
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
