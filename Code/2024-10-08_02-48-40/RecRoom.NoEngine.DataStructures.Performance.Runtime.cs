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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D42A70", Offset = "0x6D41C70", VA = "0x186D42A70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FPIOAFGNMLF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C20990", Offset = "0x2C1FB90", VA = "0x182C20990")]
	public static NNFAGEAOIAM<T> HFIIDCFPBKP<T>(this T[] AEFKHDNCNFD) where T : notnull
	{
		return default(NNFAGEAOIAM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class MKPAJDNEMFH<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BCBMJGBJHDO<T> OIIJPIEPJOK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x47BD680", Offset = "0x47BC880", VA = "0x1847BD680", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x47BD6C0", Offset = "0x47BC8C0", VA = "0x1847BD6C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x47BD700", Offset = "0x47BC900", VA = "0x1847BD700")]
	public static MKPAJDNEMFH<T> MIFIOLMMIDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x47BD8B0", Offset = "0x47BCAB0", VA = "0x1847BD8B0")]
	internal MKPAJDNEMFH([In] BCBMJGBJHDO<T> JANAFGLBOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x47BD5B0", Offset = "0x47BC7B0", VA = "0x1847BD5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x47BD640", Offset = "0x47BC840", VA = "0x1847BD640")]
	public void KOBFIALCMID(int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x47BD5F0", Offset = "0x47BC7F0", VA = "0x1847BD5F0", Slot = "8")]
	public BCBMJGBJHDO<T>.IFNDLDIPFJP GetEnumerator()
	{
		return default(BCBMJGBJHDO<T>.IFNDLDIPFJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x47BD830", Offset = "0x47BCA30", VA = "0x1847BD830", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x47BD830", Offset = "0x47BCA30", VA = "0x1847BD830", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct INCKFOCJECF<T, U> : IEnumerable<T>, IEnumerable where U : EGJGFJMDMCF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U PKNGCEPHODD;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21AA6E0", Offset = "0x21A98E0", VA = "0x1821AA6E0")]
	internal INCKFOCJECF([In] U IMIFNCDPODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x41843B0", Offset = "0x41835B0", VA = "0x1841843B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x41843B0", Offset = "0x41835B0", VA = "0x1841843B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BGLCIOBHIBJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27FBAB0", Offset = "0x27FACB0", VA = "0x1827FBAB0")]
	public static INCKFOCJECF<T, U> MIFIOLMMIDE<U>([In] U AEFKHDNCNFD) where U : EGJGFJMDMCF<T>
	{
		return default(INCKFOCJECF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct MNCNKNGEPBJ<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U PKNGCEPHODD;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x44956D0", Offset = "0x44948D0", VA = "0x1844956D0")]
	internal MNCNKNGEPBJ([In] U IMIFNCDPODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xD2E380", Offset = "0xD2D580", VA = "0x180D2E380", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x47C3BC0", Offset = "0x47C2DC0", VA = "0x1847C3BC0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x47C3BC0", Offset = "0x47C2DC0", VA = "0x1847C3BC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class ACEJGGDPFMO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27FB970", Offset = "0x27FAB70", VA = "0x1827FB970")]
	public static MNCNKNGEPBJ<T, U> MIFIOLMMIDE<U>([In] U AEFKHDNCNFD) where U : IEnumerator<T>
	{
		return default(MNCNKNGEPBJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HGKLOEMFDPD
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2E15AB0", Offset = "0x2E14CB0", VA = "0x182E15AB0")]
	public static string BAMFADBNLAJ<T>(this IEnumerable<T> AEFKHDNCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E19980", Offset = "0x2E18B80", VA = "0x182E19980")]
	public static string NAJKOILBCAG<T>(this IEnumerable<T> AEFKHDNCNFD, string NOBDCNAKOJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NOOPPEDGPEH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2F905C0", Offset = "0x2F8F7C0", VA = "0x182F905C0")]
	public static bool KLIIIHNIKLA<TSourceEnumerator, TSource>(this TSourceEnumerator AEFKHDNCNFD, [In] TSource LFDONPLGGIG) where TSourceEnumerator : EGJGFJMDMCF<TSource> where TSource : OKLAGBJBBOM<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2F90430", Offset = "0x2F8F630", VA = "0x182F90430")]
	public static int KCCMCLBLEPO<TSourceEnumerator, TSource>(this TSourceEnumerator AEFKHDNCNFD, [In] TSource JECHHBGMFLN) where TSourceEnumerator : EGJGFJMDMCF<TSource> where TSource : OKLAGBJBBOM<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F901C0", Offset = "0x2F8F3C0", VA = "0x182F901C0")]
	public static int CKGEKKLLMHO<TSourceEnumerator, TSource>(this TSourceEnumerator AEFKHDNCNFD, [In] TSource JECHHBGMFLN) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EGJGFJMDMCF<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T HLBNAJGJPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OJFIKJJMFOE<T> : EGJGFJMDMCF<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct LCFGKKIDNBF<T, U> : IEnumerable<T>, IEnumerable where U : OJFIKJJMFOE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U PKNGCEPHODD;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x41844E0", Offset = "0x41836E0", VA = "0x1841844E0")]
	internal LCFGKKIDNBF([In] U IMIFNCDPODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D040", Offset = "0x3B8C240", VA = "0x183B8D040", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4184420", Offset = "0x4183620", VA = "0x184184420", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4184420", Offset = "0x4183620", VA = "0x184184420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class LOIPMIOKILM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x27FBA20", Offset = "0x27FAC20", VA = "0x1827FBA20")]
	public static LCFGKKIDNBF<T, U> MIFIOLMMIDE<U>([In] U AEFKHDNCNFD) where U : OJFIKJJMFOE<T>
	{
		return default(LCFGKKIDNBF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct NNFAGEAOIAM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct GIGGCHLBPPB : EGJGFJMDMCF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] KJDILBELLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int MPKEPCKHJGB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3F66DA0", Offset = "0x3F65FA0", VA = "0x183F66DA0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3F665E0", Offset = "0x3F657E0", VA = "0x183F665E0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3F66C40", Offset = "0x3F65E40", VA = "0x183F66C40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1F44CD0", Offset = "0x1F43ED0", VA = "0x181F44CD0")]
		private GIGGCHLBPPB(T[] AEFKHDNCNFD, int KINMHNEMPOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F66590", Offset = "0x3F65790", VA = "0x183F66590")]
		public static GIGGCHLBPPB MIFIOLMMIDE(T[] AEFKHDNCNFD)
		{
			return default(GIGGCHLBPPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21F98F0", Offset = "0x21F8AF0", VA = "0x1821F98F0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x21F9260", Offset = "0x21F8460", VA = "0x1821F9260", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] NKDGGIHEMNM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DIBMJIIAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x44BDA10", Offset = "0x44BCC10", VA = "0x1844BDA10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T MEOINHFNJFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2C11CD0", Offset = "0x2C10ED0", VA = "0x182C11CD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	internal NNFAGEAOIAM(T[] IEIBCNCHGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4864A70", Offset = "0x4863C70", VA = "0x184864A70")]
	public static NNFAGEAOIAM<T> NPJAAMJGCPB()
	{
		return default(NNFAGEAOIAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440")]
	public IEnumerable<T> BHIDMOGCKHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4864930", Offset = "0x4863B30", VA = "0x184864930")]
	public ReadOnlySpan<T> DJFGILAFFAD()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4864B40", Offset = "0x4863D40", VA = "0x184864B40")]
	public INCKFOCJECF<T, NNFAGEAOIAM<T>.GIGGCHLBPPB> OLCMDDAAGKE()
	{
		return default(INCKFOCJECF<T, GIGGCHLBPPB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x48649D0", Offset = "0x4863BD0", VA = "0x1848649D0")]
	public GIGGCHLBPPB LPMCIJCPLHH()
	{
		return default(GIGGCHLBPPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x48648B0", Offset = "0x4863AB0", VA = "0x1848648B0")]
	public IEnumerator<T> AKJNNDDNIOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4864C70", Offset = "0x4863E70", VA = "0x184864C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IKMBKHKGDKA
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C383F0", Offset = "0x2C375F0", VA = "0x182C383F0")]
	public static NNFAGEAOIAM<T> JJLLMBFNEGA<T>(params T[] IEIBCNCHGJN) where T : notnull
	{
		return default(NNFAGEAOIAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D42A10", Offset = "0x6D41C10", VA = "0x186D42A10")]
	public static Stream BIHOBEIDBAA(this NNFAGEAOIAM<byte> AEFKHDNCNFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(BCBMJGBJHDO<>.OMKNMIOKNPI))]
public struct BCBMJGBJHDO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct IFNDLDIPFJP : OJFIKJJMFOE<T>, EGJGFJMDMCF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] NPCOFFJGOKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int PFAFAAEJOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int MPKEPCKHJGB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4112340", Offset = "0x4111540", VA = "0x184112340", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T KFGCNJAJEMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4111B70", Offset = "0x4110D70", VA = "0x184111B70")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T KGJGDJLACDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4111980", Offset = "0x4110B80", VA = "0x184111980", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4111D50", Offset = "0x4110F50", VA = "0x184111D50", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4111F40", Offset = "0x4111140", VA = "0x184111F40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3F58AA0", Offset = "0x3F57CA0", VA = "0x183F58AA0")]
		internal IFNDLDIPFJP(T[] HJAFNJHIFIH, int NDEFEFEFLCE, int KINMHNEMPOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4111C70", Offset = "0x4110E70", VA = "0x184111C70")]
		public static IFNDLDIPFJP MIFIOLMMIDE(BCBMJGBJHDO<T> AEFKHDNCNFD)
		{
			return default(IFNDLDIPFJP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B4BFD0", Offset = "0x3B4B1D0", VA = "0x183B4BFD0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B46490", Offset = "0x3B45690", VA = "0x183B46490", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct AFCOHCGDPFO : EGJGFJMDMCF<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IFNDLDIPFJP PKNGCEPHODD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3F26080", Offset = "0x3F25280", VA = "0x183F26080", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3F25E60", Offset = "0x3F25060", VA = "0x183F25E60", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3F25FB0", Offset = "0x3F251B0", VA = "0x183F25FB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x21AA6E0", Offset = "0x21A98E0", VA = "0x1821AA6E0")]
		private AFCOHCGDPFO([In] IFNDLDIPFJP IMIFNCDPODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F25CB0", Offset = "0x3F24EB0", VA = "0x183F25CB0")]
		public static AFCOHCGDPFO MIFIOLMMIDE([In] BCBMJGBJHDO<T> AEFKHDNCNFD)
		{
			return default(AFCOHCGDPFO);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3F25D60", Offset = "0x3F24F60", VA = "0x183F25D60", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3F25DA0", Offset = "0x3F24FA0", VA = "0x183F25DA0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3F25C70", Offset = "0x3F24E70", VA = "0x183F25C70", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class OMKNMIOKNPI
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] NPCOFFJGOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int PFAFAAEJOCM;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x51C08C0", Offset = "0x51BFAC0", VA = "0x1851C08C0")]
	public static BCBMJGBJHDO<T> MIFIOLMMIDE()
	{
		return default(BCBMJGBJHDO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x51C0970", Offset = "0x51BFB70", VA = "0x1851C0970")]
	public static BCBMJGBJHDO<T> NHGHNDAAGOO(int LCNCMFGPICH)
	{
		return default(BCBMJGBJHDO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F44CD0", Offset = "0x1F43ED0", VA = "0x181F44CD0")]
	internal BCBMJGBJHDO(T[] HJAFNJHIFIH, int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51C0A30", Offset = "0x51BFC30", VA = "0x1851C0A30", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CCAJHPMIOBB
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int POBKKGNKCBL<TCtx, T>([In] TCtx GNOLEGBLDOK, T ICLLFDEBJIO, T JPMAPOMKNPF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2C16180", Offset = "0x2C15380", VA = "0x182C16180")]
	public static void GJKAEPPOOPE<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2C12020", Offset = "0x2C11220", VA = "0x182C12020")]
	public static string DEENGAPPDAM<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440")]
	public static T[] CLEHCEJAKKF<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x21F9340", Offset = "0x21F8540", VA = "0x1821F9340")]
	public static T PLOCNKMCLIO<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD, int ABKDFEIGMDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x21F9340", Offset = "0x21F8540", VA = "0x1821F9340")]
	public static T BPBOBJOCFDE<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, int ABKDFEIGMDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2C15F50", Offset = "0x2C15150", VA = "0x182C15F50")]
	public static T DELPJPPPGBG<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD, int ABKDFEIGMDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2C11300", Offset = "0x2C10500", VA = "0x182C11300")]
	public static void HPDIHAPBFNP<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, int ABKDFEIGMDF, [In] T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2C11300", Offset = "0x2C10500", VA = "0x182C11300")]
	public static void AKJPJAEEMGD<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, int ABKDFEIGMDF, T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x21F92F0", Offset = "0x21F84F0", VA = "0x1821F92F0")]
	public static int LACCJJBLCDC<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2C16080", Offset = "0x2C15280", VA = "0x182C16080")]
	public static ReadOnlySpan<T> DJFGILAFFAD<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C9F0", Offset = "0x2C1BBF0", VA = "0x182C1C9F0")]
	public static T[] MCJDHFECMGO<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2C16200", Offset = "0x2C15400", VA = "0x182C16200")]
	public static T GLOHFDCMEHB<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2C11EA0", Offset = "0x2C110A0", VA = "0x182C11EA0")]
	public static T[] BPGJONEHGIF<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C640", Offset = "0x2C1B840", VA = "0x182C1C640")]
	public static NNFAGEAOIAM<T> LJPDFCKODLB<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return default(NNFAGEAOIAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2C174A0", Offset = "0x2C166A0", VA = "0x182C174A0")]
	public static void JIJNOIKPNBF<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, [In] T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2C171D0", Offset = "0x2C163D0", VA = "0x182C171D0")]
	public static void HPMBIJFLGLA<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2C16C30", Offset = "0x2C15E30", VA = "0x182C16C30")]
	public static void HMLGAMMKNLN<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, int KINMHNEMPOD, [In] T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2C16A10", Offset = "0x2C15C10", VA = "0x182C16A10")]
	public static void HKHGIEACNGJ<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, int KINMHNEMPOD, T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2C169D0", Offset = "0x2C15BD0", VA = "0x182C169D0")]
	public static void HJGCKEGIOGD<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, int KINMHNEMPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2C16970", Offset = "0x2C15B70", VA = "0x182C16970")]
	public static T HHIDEBNBHGN<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2C19E10", Offset = "0x2C19010", VA = "0x182C19E10")]
	public static void KOBFIALCMID<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C17A60", Offset = "0x2C16C60", VA = "0x182C17A60")]
	private static void JKKHJFEDNFA<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, int LCNCMFGPICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C11A50", Offset = "0x2C10C50", VA = "0x182C11A50")]
	public static void AODHOHPPLKC<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2C19AD0", Offset = "0x2C18CD0", VA = "0x182C19AD0")]
	public static BCBMJGBJHDO<T> KIEKDHFGNJA<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD, BNOICIMLIBA<T, T> PEPPFNCGHED)
	{
		return default(BCBMJGBJHDO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C710", Offset = "0x2C1B910", VA = "0x182C1C710")]
	public static bool LOGGCHCCBFB<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, T JECHHBGMFLN) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2C11F50", Offset = "0x2C11150", VA = "0x182C11F50")]
	public static bool CACFPOLOJIB<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD, [In] T JECHHBGMFLN) where T : OKLAGBJBBOM<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CB20", Offset = "0x2C1BD20", VA = "0x182C1CB20")]
	public static bool NBBOOJLBJGO<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C590", Offset = "0x2C1B790", VA = "0x182C1C590")]
	public static bool LANNNLLJEPG<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD, int ABKDFEIGMDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C5F0", Offset = "0x2C1B7F0", VA = "0x182C1C5F0")]
	public static void LCPBLLDBPOB<T, TCtx>(this BCBMJGBJHDO<T> AEFKHDNCNFD, [In] TCtx GNOLEGBLDOK, POBKKGNKCBL<TCtx, T> POCGPFOENMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2C173A0", Offset = "0x2C165A0", VA = "0x182C173A0")]
	private static void JHNIPMKGIEH<T, TCtx>(BCBMJGBJHDO<T> AEFKHDNCNFD, [In] TCtx GNOLEGBLDOK, POBKKGNKCBL<TCtx, T> POCGPFOENMK, int BJNBGIPLLGH, int DGIHDOMPJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C162D0", Offset = "0x2C154D0", VA = "0x182C162D0")]
	private static int HGLEGEKIGPL<T, TCtx>(BCBMJGBJHDO<T> AEFKHDNCNFD, [In] TCtx GNOLEGBLDOK, POBKKGNKCBL<TCtx, T> POCGPFOENMK, int BJNBGIPLLGH, int DGIHDOMPJII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2C112B0", Offset = "0x2C104B0", VA = "0x182C112B0")]
	public static BCBMJGBJHDO<T>.AFCOHCGDPFO AKJNNDDNIOE<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return default(BCBMJGBJHDO<T>.AFCOHCGDPFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2C112B0", Offset = "0x2C104B0", VA = "0x182C112B0")]
	public static BCBMJGBJHDO<T>.IFNDLDIPFJP LBHKBELPDKK<T>(this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return default(BCBMJGBJHDO<T>.IFNDLDIPFJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2C16240", Offset = "0x2C15440", VA = "0x182C16240")]
	public static INCKFOCJECF<T, BCBMJGBJHDO<T>.AFCOHCGDPFO> HELOCFDMKIM<T>([In] this BCBMJGBJHDO<T> AEFKHDNCNFD)
	{
		return default(INCKFOCJECF<T, BCBMJGBJHDO<T>.AFCOHCGDPFO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class DHLAIIMKDMD
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2C66C40", Offset = "0x2C65E40", VA = "0x182C66C40")]
	public static T[] ENKPBCPPPNE<T>(int JAICOMOJIGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	public static void NHHKDKNNAGC<T>(T[] IEIBCNCHGJN)
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
