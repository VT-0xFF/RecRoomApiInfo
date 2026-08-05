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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E2B1E0", Offset = "0x6E2A5E0", VA = "0x186E2B1E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OHNGGPOFBKC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9420", Offset = "0x2CA8820", VA = "0x182CA9420")]
	public static DPIKEFMCIBA<T> EOAGAKNNCNI<T>(this T[] EAFEIEDNLNL) where T : notnull
	{
		return default(DPIKEFMCIBA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class GOBMNFBCICL<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private AOEDEFLENLN<T> KNIELIDNDEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x407B660", Offset = "0x407AA60", VA = "0x18407B660", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x407B8A0", Offset = "0x407ACA0", VA = "0x18407B8A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x407B6E0", Offset = "0x407AAE0", VA = "0x18407B6E0")]
	public static GOBMNFBCICL<T> GIIIFAJNKEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F4F750", Offset = "0x3F4EB50", VA = "0x183F4F750")]
	internal GOBMNFBCICL([In] AOEDEFLENLN<T> KPECMEHKPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x407B6A0", Offset = "0x407AAA0", VA = "0x18407B6A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x407B860", Offset = "0x407AC60", VA = "0x18407B860")]
	public void IOGMMKLDMHN(int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x407B810", Offset = "0x407AC10", VA = "0x18407B810", Slot = "8")]
	public AOEDEFLENLN<T>.KMKGKILHHBF GetEnumerator()
	{
		return default(AOEDEFLENLN<T>.KMKGKILHHBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x407B8E0", Offset = "0x407ACE0", VA = "0x18407B8E0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x407B8E0", Offset = "0x407ACE0", VA = "0x18407B8E0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CFDFJEHPKII<T, U> : IEnumerable<T>, IEnumerable where U : DENMJDKJMPE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U PGOPFAONFOJ;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2238110", Offset = "0x2237510", VA = "0x182238110")]
	internal CFDFJEHPKII([In] U JDBDGAKCPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xD068B0", Offset = "0xD05CB0", VA = "0x180D068B0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x43DB130", Offset = "0x43DA530", VA = "0x1843DB130", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x43DB130", Offset = "0x43DA530", VA = "0x1843DB130", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JFAMMPLFDGA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3590", Offset = "0x2DD2990", VA = "0x182DD3590")]
	public static CFDFJEHPKII<T, U> GIIIFAJNKEL<U>([In] U EAFEIEDNLNL) where U : DENMJDKJMPE<T>
	{
		return default(CFDFJEHPKII<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JEAFLBAKGPB<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U PGOPFAONFOJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x43DB690", Offset = "0x43DAA90", VA = "0x1843DB690")]
	internal JEAFLBAKGPB([In] U JDBDGAKCPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x43DB0B0", Offset = "0x43DA4B0", VA = "0x1843DB0B0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x43DB470", Offset = "0x43DA870", VA = "0x1843DB470", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x43DB470", Offset = "0x43DA870", VA = "0x1843DB470", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KOGOHOIJAOJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3067FD0", Offset = "0x30673D0", VA = "0x183067FD0")]
	public static JEAFLBAKGPB<T, U> GIIIFAJNKEL<U>([In] U EAFEIEDNLNL) where U : IEnumerator<T>
	{
		return default(JEAFLBAKGPB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class EFMEGDCCCKD
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2D13440", Offset = "0x2D12840", VA = "0x182D13440")]
	public static string LKOHGOHPNPC<T>(this IEnumerable<T> EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2D17B80", Offset = "0x2D16F80", VA = "0x182D17B80")]
	public static string OBPODIPHLOL<T>(this IEnumerable<T> EAFEIEDNLNL, string GLEKNMMHKII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LFGMLMIHANE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AD00", Offset = "0x2F8A100", VA = "0x182F8AD00")]
	public static bool LPPOHJBLEMF<TSourceEnumerator, TSource>(this TSourceEnumerator EAFEIEDNLNL, [In] TSource DHLKAMHBBEP) where TSourceEnumerator : DENMJDKJMPE<TSource> where TSource : FADLILBKPAO<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2F8A900", Offset = "0x2F89D00", VA = "0x182F8A900")]
	public static int DAHJNJNACJO<TSourceEnumerator, TSource>(this TSourceEnumerator EAFEIEDNLNL, [In] TSource PFKKDHPJFEH) where TSourceEnumerator : DENMJDKJMPE<TSource> where TSource : FADLILBKPAO<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2F8AB60", Offset = "0x2F89F60", VA = "0x182F8AB60")]
	public static int EINCAMJDDFK<TSourceEnumerator, TSource>(this TSourceEnumerator EAFEIEDNLNL, [In] TSource PFKKDHPJFEH) where TSourceEnumerator : IEnumerator<TSource> where TSource : IEquatable<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DENMJDKJMPE<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T LDHKDFDFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface APHIFINOAOO<T> : DENMJDKJMPE<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct JICMEKNBHHI<T, U> : IEnumerable<T>, IEnumerable where U : APHIFINOAOO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U PGOPFAONFOJ;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x43DB660", Offset = "0x43DAA60", VA = "0x1843DB660")]
	internal JICMEKNBHHI([In] U JDBDGAKCPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C4BA10", Offset = "0x3C4AE10", VA = "0x183C4BA10", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x43DB210", Offset = "0x43DA610", VA = "0x1843DB210", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x43DB210", Offset = "0x43DA610", VA = "0x1843DB210", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EEOPOHEKKAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3560", Offset = "0x2DD2960", VA = "0x182DD3560")]
	public static JICMEKNBHHI<T, U> GIIIFAJNKEL<U>([In] U EAFEIEDNLNL) where U : APHIFINOAOO<T>
	{
		return default(JICMEKNBHHI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct DPIKEFMCIBA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct OKEEOINJHGE : DENMJDKJMPE<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] KJENJCHHJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int GPHFPNHIPEO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4A67830", Offset = "0x4A66C30", VA = "0x184A67830", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4A671A0", Offset = "0x4A665A0", VA = "0x184A671A0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4A67370", Offset = "0x4A66770", VA = "0x184A67370", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x92AE10", Offset = "0x92A210", VA = "0x18092AE10")]
		private OKEEOINJHGE(T[] EAFEIEDNLNL, int OBFJPFHENMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4A67080", Offset = "0x4A66480", VA = "0x184A67080")]
		public static OKEEOINJHGE GIIIFAJNKEL(T[] EAFEIEDNLNL)
		{
			return default(OKEEOINJHGE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2273030", Offset = "0x2272430", VA = "0x182273030", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2273060", Offset = "0x2272460", VA = "0x182273060", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] LLGDCJMIFBB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OCLEKHGCIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x44DEC20", Offset = "0x44DE020", VA = "0x1844DEC20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2D4EC10", Offset = "0x2D4E010", VA = "0x182D4EC10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	internal DPIKEFMCIBA(T[] EFKOIGFMOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C20010", Offset = "0x5C1F410", VA = "0x185C20010")]
	public static DPIKEFMCIBA<T> HABKGKOFNKB()
	{
		return default(DPIKEFMCIBA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270")]
	public IEnumerable<T> OANAPANIINO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5C200E0", Offset = "0x5C1F4E0", VA = "0x185C200E0")]
	public ReadOnlySpan<T> MAIKGDPKHMK()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FDC0", Offset = "0x5C1F1C0", VA = "0x185C1FDC0")]
	public CFDFJEHPKII<T, DPIKEFMCIBA<T>.OKEEOINJHGE> AMLKDDIDIAB()
	{
		return default(CFDFJEHPKII<T, OKEEOINJHGE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FEF0", Offset = "0x5C1F2F0", VA = "0x185C1FEF0")]
	public OKEEOINJHGE BGMLINAEHOA()
	{
		return default(OKEEOINJHGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5C1FF90", Offset = "0x5C1F390", VA = "0x185C1FF90")]
	public IEnumerator<T> EDIPCEILGGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5C20180", Offset = "0x5C1F580", VA = "0x185C20180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BJGLOLIPEEH
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C4B360", Offset = "0x2C4A760", VA = "0x182C4B360")]
	public static DPIKEFMCIBA<T> POBNAPMNILL<T>(params T[] EFKOIGFMOHD) where T : notnull
	{
		return default(DPIKEFMCIBA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E2B180", Offset = "0x6E2A580", VA = "0x186E2B180")]
	public static Stream IBHOLEEHJMH(this DPIKEFMCIBA<byte> EAFEIEDNLNL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(AOEDEFLENLN<>.ICPHJNFFCDK))]
public struct AOEDEFLENLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct KMKGKILHHBF : APHIFINOAOO<T>, DENMJDKJMPE<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] LHPAEDALKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int BKHJLALFEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int GPHFPNHIPEO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x452F100", Offset = "0x452E500", VA = "0x18452F100", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T HOJJBLHPEFE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x452EA50", Offset = "0x452DE50", VA = "0x18452EA50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T DLDIKALMAFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x452E740", Offset = "0x452DB40", VA = "0x18452E740", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x452EBD0", Offset = "0x452DFD0", VA = "0x18452EBD0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x452ED00", Offset = "0x452E100", VA = "0x18452ED00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x420D080", Offset = "0x420C480", VA = "0x18420D080")]
		internal KMKGKILHHBF(T[] AKAPKCMHDAP, int GMOPHNCDIJO, int OBFJPFHENMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x452E880", Offset = "0x452DC80", VA = "0x18452E880")]
		public static KMKGKILHHBF GIIIFAJNKEL(AOEDEFLENLN<T> EAFEIEDNLNL)
		{
			return default(KMKGKILHHBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3C09790", Offset = "0x3C08B90", VA = "0x183C09790", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3C043B0", Offset = "0x3C037B0", VA = "0x183C043B0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct FNCHNCHJCAM : DENMJDKJMPE<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KMKGKILHHBF PGOPFAONFOJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3F53830", Offset = "0x3F52C30", VA = "0x183F53830", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3F53590", Offset = "0x3F52990", VA = "0x183F53590", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3F53620", Offset = "0x3F52A20", VA = "0x183F53620", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2238110", Offset = "0x2237510", VA = "0x182238110")]
		private FNCHNCHJCAM([In] KMKGKILHHBF JDBDGAKCPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F53420", Offset = "0x3F52820", VA = "0x183F53420")]
		public static FNCHNCHJCAM GIIIFAJNKEL([In] AOEDEFLENLN<T> EAFEIEDNLNL)
		{
			return default(FNCHNCHJCAM);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3F534D0", Offset = "0x3F528D0", VA = "0x183F534D0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3F53510", Offset = "0x3F52910", VA = "0x183F53510", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3F533E0", Offset = "0x3F527E0", VA = "0x183F533E0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class ICPHJNFFCDK
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] LHPAEDALKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int BKHJLALFEMN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x41075C0", Offset = "0x41069C0", VA = "0x1841075C0")]
	public static AOEDEFLENLN<T> GIIIFAJNKEL()
	{
		return default(AOEDEFLENLN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4107670", Offset = "0x4106A70", VA = "0x184107670")]
	public static AOEDEFLENLN<T> PBJCFIIOLLO(int PCJIPONCEAG)
	{
		return default(AOEDEFLENLN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x92AE10", Offset = "0x92A210", VA = "0x18092AE10")]
	internal AOEDEFLENLN(T[] AKAPKCMHDAP, int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4107730", Offset = "0x4106B30", VA = "0x184107730", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EPDGECJIJJF
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int LFIDMMOABFL<TCtx, T>([In] TCtx BNMNAILDILO, T MMHCOKHACHF, T DEOGINMLLDP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2D4EDC0", Offset = "0x2D4E1C0", VA = "0x182D4EDC0")]
	public static void GGKFCAFBJMN<T>(this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2D4AF30", Offset = "0x2D4A330", VA = "0x182D4AF30")]
	public static string GBLODHEOCEO<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270")]
	public static T[] LCMOAJIOLAH<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2273160", Offset = "0x2272560", VA = "0x182273160")]
	public static T GEKLBPFDDHO<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL, int CLDPBDGHEDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2273160", Offset = "0x2272560", VA = "0x182273160")]
	public static T JGNBEBOFIEH<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, int CLDPBDGHEDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2D53EF0", Offset = "0x2D532F0", VA = "0x182D53EF0")]
	public static T IPMBFIJALAL<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL, int CLDPBDGHEDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2D4EF20", Offset = "0x2D4E320", VA = "0x182D4EF20")]
	public static void NBJJIKECOBK<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, int CLDPBDGHEDO, [In] T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2D4EF20", Offset = "0x2D4E320", VA = "0x182D4EF20")]
	public static void GJAOIPJFBLB<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, int CLDPBDGHEDO, T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2273940", Offset = "0x2272D40", VA = "0x182273940")]
	public static int JBDKHJHBHHP<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2D546A0", Offset = "0x2D53AA0", VA = "0x182D546A0")]
	public static ReadOnlySpan<T> MAIKGDPKHMK<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A110", Offset = "0x2D49510", VA = "0x182D4A110")]
	public static T[] FCIOIPCIJFD<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2D55180", Offset = "0x2D54580", VA = "0x182D55180")]
	public static T PLFBOMJKBMI<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2D49970", Offset = "0x2D48D70", VA = "0x182D49970")]
	public static T[] BDKINMMOOPK<T>(this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2D49BC0", Offset = "0x2D48FC0", VA = "0x182D49BC0")]
	public static DPIKEFMCIBA<T> CGKHNJOIPGN<T>(this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return default(DPIKEFMCIBA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A710", Offset = "0x2D49B10", VA = "0x182D4A710")]
	public static void FNBCENOGBNB<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, [In] T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2D496B0", Offset = "0x2D48AB0", VA = "0x182D496B0")]
	public static void ADONCACOEMA<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2D49E50", Offset = "0x2D49250", VA = "0x182D49E50")]
	public static void EHCBJGNIBMP<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, int OBFJPFHENMC, [In] T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2D49CA0", Offset = "0x2D490A0", VA = "0x182D49CA0")]
	public static void EAKLNFFKMJL<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, int OBFJPFHENMC, T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A530", Offset = "0x2D49930", VA = "0x182D4A530")]
	public static void FIDCICKLFAC<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, int OBFJPFHENMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A350", Offset = "0x2D49750", VA = "0x182D4A350")]
	public static T FEJCHDHHIAE<T>(this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2D51880", Offset = "0x2D50C80", VA = "0x182D51880")]
	public static void IOGMMKLDMHN<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2D4FA40", Offset = "0x2D4EE40", VA = "0x182D4FA40")]
	private static void GLLAGAGCNKM<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, int PCJIPONCEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A3B0", Offset = "0x2D497B0", VA = "0x182D4A3B0")]
	public static void FEPOBOIDOBF<T>(this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2D54F20", Offset = "0x2D54320", VA = "0x182D54F20")]
	public static AOEDEFLENLN<T> ODIIDDIDEDO<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL, OHFFKAOOHLB<T, T> NDPIKGBMKLD)
	{
		return default(AOEDEFLENLN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2D49A20", Offset = "0x2D48E20", VA = "0x182D49A20")]
	public static bool BIJNEFLCHFA<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, T PFKKDHPJFEH) where T : IEquatable<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2D498A0", Offset = "0x2D48CA0", VA = "0x182D498A0")]
	public static bool AONACPNDCCP<T>(this AOEDEFLENLN<T> EAFEIEDNLNL, [In] T PFKKDHPJFEH) where T : FADLILBKPAO<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2D49C90", Offset = "0x2D49090", VA = "0x182D49C90")]
	public static bool DCPGEINIIPA<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A2F0", Offset = "0x2D496F0", VA = "0x182D4A2F0")]
	public static bool FCOCDEKMLNP<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL, int CLDPBDGHEDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2D547A0", Offset = "0x2D53BA0", VA = "0x182D547A0")]
	public static void MJKBCENJPAE<T, TCtx>(this AOEDEFLENLN<T> EAFEIEDNLNL, [In] TCtx BNMNAILDILO, LFIDMMOABFL<TCtx, T> DPBGFGFGHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A570", Offset = "0x2D49970", VA = "0x182D4A570")]
	private static void FKGKJPMHDHK<T, TCtx>(AOEDEFLENLN<T> EAFEIEDNLNL, [In] TCtx BNMNAILDILO, LFIDMMOABFL<TCtx, T> DPBGFGFGHHF, int MAOEEDAOHCE, int AOJIDKKFLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2D54000", Offset = "0x2D53400", VA = "0x182D54000")]
	private static int LBGANEJIECI<T, TCtx>(AOEDEFLENLN<T> EAFEIEDNLNL, [In] TCtx BNMNAILDILO, LFIDMMOABFL<TCtx, T> DPBGFGFGHHF, int MAOEEDAOHCE, int AOJIDKKFLKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2D49E00", Offset = "0x2D49200", VA = "0x182D49E00")]
	public static AOEDEFLENLN<T>.FNCHNCHJCAM EDIPCEILGGF<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return default(AOEDEFLENLN<T>.FNCHNCHJCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2D49E00", Offset = "0x2D49200", VA = "0x182D49E00")]
	public static AOEDEFLENLN<T>.KMKGKILHHBF GDAEIDNNBFK<T>(this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return default(AOEDEFLENLN<T>.KMKGKILHHBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2D49810", Offset = "0x2D48C10", VA = "0x182D49810")]
	public static CFDFJEHPKII<T, AOEDEFLENLN<T>.FNCHNCHJCAM> AIAHNALCKDB<T>([In] this AOEDEFLENLN<T> EAFEIEDNLNL)
	{
		return default(CFDFJEHPKII<T, AOEDEFLENLN<T>.FNCHNCHJCAM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class IFBHAAAIKHG
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2820", Offset = "0x2EE1C20", VA = "0x182EE2820")]
	public static T[] AMEPHKEJFKA<T>(int JKIIGJDNBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	public static void NMGLLKFJCCA<T>(T[] EFKOIGFMOHD)
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
