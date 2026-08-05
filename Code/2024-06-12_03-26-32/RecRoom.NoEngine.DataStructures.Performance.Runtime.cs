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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A1A80", Offset = "0x69A0680", VA = "0x1869A1A80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OBHJJMGLPCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2570260", Offset = "0x256EE60", VA = "0x182570260")]
	public static DNNDMHLOCGD<T> LBNFDNAPAHM<T>(this T[] HNFMOHFACKF) where T : notnull
	{
		return default(DNNDMHLOCGD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class MFFELFBFJCB<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BDDFKGHGNDI<T> DFDBHJFKEDI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x43F1B60", Offset = "0x43F0760", VA = "0x1843F1B60", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x43F1B20", Offset = "0x43F0720", VA = "0x1843F1B20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43F1BA0", Offset = "0x43F07A0", VA = "0x1843F1BA0")]
	public static MFFELFBFJCB<T> PPOPBMPFEOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43F1D50", Offset = "0x43F0950", VA = "0x1843F1D50")]
	internal MFFELFBFJCB([In] BDDFKGHGNDI<T> NHLLCDFJMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x43F1A50", Offset = "0x43F0650", VA = "0x1843F1A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x43F1A90", Offset = "0x43F0690", VA = "0x1843F1A90")]
	public void FDBIPEPOIMF(int HDFABDCMCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x43F1AD0", Offset = "0x43F06D0", VA = "0x1843F1AD0", Slot = "8")]
	public BDDFKGHGNDI<T>.OJEKBIIGINF GetEnumerator()
	{
		return default(BDDFKGHGNDI<T>.OJEKBIIGINF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43F1CD0", Offset = "0x43F08D0", VA = "0x1843F1CD0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x43F1CD0", Offset = "0x43F08D0", VA = "0x1843F1CD0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BOAGKJKJNBH<T, U> : IEnumerable<T>, IEnumerable where U : PLJMPHNHGFI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U LGIEOGLECBO;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F459F0", Offset = "0x1F445F0", VA = "0x181F459F0")]
	internal BOAGKJKJNBH([In] U CACLGIIFKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9B8150", Offset = "0x9B6D50", VA = "0x1809B8150", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x447D3E0", Offset = "0x447BFE0", VA = "0x18447D3E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x447D3E0", Offset = "0x447BFE0", VA = "0x18447D3E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LHEODEIBHOG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2570BE0", Offset = "0x256F7E0", VA = "0x182570BE0")]
	public static BOAGKJKJNBH<T, U> PPOPBMPFEOP<U>([In] U HNFMOHFACKF) where U : PLJMPHNHGFI<T>
	{
		return default(BOAGKJKJNBH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct NBJLPHMBNMH<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U LGIEOGLECBO;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x447D9D0", Offset = "0x447C5D0", VA = "0x18447D9D0")]
	internal NBJLPHMBNMH([In] U CACLGIIFKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x447D4D0", Offset = "0x447C0D0", VA = "0x18447D4D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x447D4D0", Offset = "0x447C0D0", VA = "0x18447D4D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LKIEHFMFBDO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28164A0", Offset = "0x28150A0", VA = "0x1828164A0")]
	public static NBJLPHMBNMH<T, U> PPOPBMPFEOP<U>([In] U HNFMOHFACKF) where U : IEnumerator<T>
	{
		return default(NBJLPHMBNMH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class CILOIIBJAOO
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x28EA290", Offset = "0x28E8E90", VA = "0x1828EA290")]
	public static string FFDDHMINMMI<T>(this IEnumerable<T> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28EE410", Offset = "0x28ED010", VA = "0x1828EE410")]
	public static string OEEFMMJHGFP<T>(this IEnumerable<T> HNFMOHFACKF, string HFINIHGBELC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CPGMDJPAFFE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x29032E0", Offset = "0x2901EE0", VA = "0x1829032E0")]
	public static bool HEDOHOGMAOB<TSourceEnumerator, TSource>(this TSourceEnumerator HNFMOHFACKF, [In] TSource LBACBPHHKAE) where TSourceEnumerator : PLJMPHNHGFI<TSource> where TSource : AAKCPPDLFNK<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2903530", Offset = "0x2902130", VA = "0x182903530")]
	public static int MEGCNGEOAHG<TSourceEnumerator, TSource>(this TSourceEnumerator HNFMOHFACKF, [In] TSource GLMEMJNJKAN) where TSourceEnumerator : PLJMPHNHGFI<TSource> where TSource : AAKCPPDLFNK<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PLJMPHNHGFI<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T KDHPDJIABMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DDMADDEDLCL<T> : PLJMPHNHGFI<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct NLEDABMGJOL<T, U> : IEnumerable<T>, IEnumerable where U : DDMADDEDLCL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U LGIEOGLECBO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8810", Offset = "0x3CE7410", VA = "0x183CE8810")]
	internal NLEDABMGJOL([In] U CACLGIIFKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x38BAD10", Offset = "0x38B9910", VA = "0x1838BAD10", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x449BB50", Offset = "0x449A750", VA = "0x18449BB50", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x449BB50", Offset = "0x449A750", VA = "0x18449BB50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CBBMIBPGBBA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2570BB0", Offset = "0x256F7B0", VA = "0x182570BB0")]
	public static NLEDABMGJOL<T, U> PPOPBMPFEOP<U>([In] U HNFMOHFACKF) where U : DDMADDEDLCL<T>
	{
		return default(NLEDABMGJOL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct DNNDMHLOCGD<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct AGHMAKFHMIH : PLJMPHNHGFI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] GDJABHFILJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int JBOGEJBCKLG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3CD2810", Offset = "0x3CD1410", VA = "0x183CD2810", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3CD2240", Offset = "0x3CD0E40", VA = "0x183CD2240", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3CD24B0", Offset = "0x3CD10B0", VA = "0x183CD24B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1A95FF0", Offset = "0x1A94BF0", VA = "0x181A95FF0")]
		private AGHMAKFHMIH(T[] HNFMOHFACKF, int OPDMGNJCACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1FF0", Offset = "0x3CD0BF0", VA = "0x183CD1FF0")]
		public static AGHMAKFHMIH PPOPBMPFEOP(T[] HNFMOHFACKF)
		{
			return default(AGHMAKFHMIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E290", Offset = "0x1F8CE90", VA = "0x181F8E290", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1F8E2F0", Offset = "0x1F8CEF0", VA = "0x181F8E2F0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] DFLMPPMCNEI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CJOHGCFPKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3BDB8D0", Offset = "0x3BDA4D0", VA = "0x183BDB8D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2B36890", Offset = "0x2B35490", VA = "0x182B36890")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9295C0", Offset = "0x9281C0", VA = "0x1809295C0")]
	internal DNNDMHLOCGD(T[] CHPEIOMPEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x57F3FE0", Offset = "0x57F2BE0", VA = "0x1857F3FE0")]
	public static DNNDMHLOCGD<T> BBCAMDNMADI()
	{
		return default(DNNDMHLOCGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
	public IEnumerable<T> KNFOANKMHEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x57F3F40", Offset = "0x57F2B40", VA = "0x1857F3F40")]
	public ReadOnlySpan<T> ANKLADIHHEH()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x57F40B0", Offset = "0x57F2CB0", VA = "0x1857F40B0")]
	public BOAGKJKJNBH<T, DNNDMHLOCGD<T>.AGHMAKFHMIH> IAGCLCPJFGJ()
	{
		return default(BOAGKJKJNBH<T, AGHMAKFHMIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x57F41E0", Offset = "0x57F2DE0", VA = "0x1857F41E0")]
	public AGHMAKFHMIH KJMAKPDEJGL()
	{
		return default(AGHMAKFHMIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x57F4280", Offset = "0x57F2E80", VA = "0x1857F4280")]
	public IEnumerator<T> NDANHGBCNEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x57F4300", Offset = "0x57F2F00", VA = "0x1857F4300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LKHEHKKOPBK
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x255B2F0", Offset = "0x2559EF0", VA = "0x18255B2F0")]
	public static DNNDMHLOCGD<T> IJFLAILPHKJ<T>(params T[] CHPEIOMPEEH) where T : notnull
	{
		return default(DNNDMHLOCGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69A1A20", Offset = "0x69A0620", VA = "0x1869A1A20")]
	public static Stream MMCOFHNHNAA(this DNNDMHLOCGD<byte> HNFMOHFACKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(BDDFKGHGNDI<>.DAPHCAFIENO))]
public struct BDDFKGHGNDI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct OJEKBIIGINF : DDMADDEDLCL<T>, PLJMPHNHGFI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] LCCHGLFHPNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int OIBCOKJMJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int JBOGEJBCKLG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4589CA0", Offset = "0x45888A0", VA = "0x184589CA0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T HPDIPBOKPEN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x4589410", Offset = "0x4588010", VA = "0x184589410", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x4589680", Offset = "0x4588280", VA = "0x184589680", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4589AB0", Offset = "0x45886B0", VA = "0x184589AB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3D4ED60", Offset = "0x3D4D960", VA = "0x183D4ED60")]
		internal OJEKBIIGINF(T[] PLHBCCDAKBC, int HDFABDCMCAG, int OPDMGNJCACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4589550", Offset = "0x4588150", VA = "0x184589550")]
		public static OJEKBIIGINF PPOPBMPFEOP(BDDFKGHGNDI<T> HNFMOHFACKF)
		{
			return default(OJEKBIIGINF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3879080", Offset = "0x3877C80", VA = "0x183879080", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x38725F0", Offset = "0x38711F0", VA = "0x1838725F0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct PIFJCEFJMLD : PLJMPHNHGFI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OJEKBIIGINF LGIEOGLECBO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x47678D0", Offset = "0x47664D0", VA = "0x1847678D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4767580", Offset = "0x4766180", VA = "0x184767580", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4767750", Offset = "0x4766350", VA = "0x184767750", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1F459F0", Offset = "0x1F445F0", VA = "0x181F459F0")]
		private PIFJCEFJMLD([In] OJEKBIIGINF CACLGIIFKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4767490", Offset = "0x4766090", VA = "0x184767490")]
		public static PIFJCEFJMLD PPOPBMPFEOP([In] BDDFKGHGNDI<T> HNFMOHFACKF)
		{
			return default(PIFJCEFJMLD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4767450", Offset = "0x4766050", VA = "0x184767450", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4767540", Offset = "0x4766140", VA = "0x184767540", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4767410", Offset = "0x4766010", VA = "0x184767410", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class DAPHCAFIENO
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] LCCHGLFHPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int OIBCOKJMJPB;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E44100", Offset = "0x4E42D00", VA = "0x184E44100")]
	public static BDDFKGHGNDI<T> PPOPBMPFEOP()
	{
		return default(BDDFKGHGNDI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E44040", Offset = "0x4E42C40", VA = "0x184E44040")]
	public static BDDFKGHGNDI<T> OBKLBFCCOJG(int ECCOECALPKO)
	{
		return default(BDDFKGHGNDI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1A95FF0", Offset = "0x1A94BF0", VA = "0x181A95FF0")]
	internal BDDFKGHGNDI(T[] PLHBCCDAKBC, int HDFABDCMCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E441B0", Offset = "0x4E42DB0", VA = "0x184E441B0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class ICMOJMIAPMF
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int LIHEALAIMGP<TCtx, T>([In] TCtx CCHBOMPCDMN, T HLHDFJDLHFM, T GIHDHONABPM);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2B369C0", Offset = "0x2B355C0", VA = "0x182B369C0")]
	public static void IICIADDLCDE<T>(this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B306B0", Offset = "0x2B2F2B0", VA = "0x182B306B0")]
	public static string DDMPLALHBDM<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
	public static T[] HCILBJBLDGO<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E3B0", Offset = "0x1F8CFB0", VA = "0x181F8E3B0")]
	public static T HCNFCFFAFEI<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF, int EKELKKECGGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1F8E3B0", Offset = "0x1F8CFB0", VA = "0x181F8E3B0")]
	public static T NBJMBJNLNJI<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, int EKELKKECGGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2B37A10", Offset = "0x2B36610", VA = "0x182B37A10")]
	public static T PKELGLBMJOJ<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF, int EKELKKECGGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DCF0", Offset = "0x2B2C8F0", VA = "0x182B2DCF0")]
	public static void CBGDEMCKLAL<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, int EKELKKECGGF, [In] T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B378A0", Offset = "0x2B364A0", VA = "0x182B378A0")]
	public static void PAPPEPMPFIB<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, int EKELKKECGGF, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6EE0", Offset = "0x1FB5AE0", VA = "0x181FB6EE0")]
	public static int BHCLCDOCMNH<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DA90", Offset = "0x2B2C690", VA = "0x182B2DA90")]
	public static ReadOnlySpan<T> ANKLADIHHEH<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B36DA0", Offset = "0x2B359A0", VA = "0x182B36DA0")]
	public static T[] MANPPLFOAGP<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B33DB0", Offset = "0x2B329B0", VA = "0x182B33DB0")]
	public static T DEHIAKLPLOE<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D9E0", Offset = "0x2B2C5E0", VA = "0x182B2D9E0")]
	public static T[] ALOJGOGEJHM<T>(this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B33DF0", Offset = "0x2B329F0", VA = "0x182B33DF0")]
	public static DNNDMHLOCGD<T> DJAGLPPGJIF<T>(this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return default(DNNDMHLOCGD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B37100", Offset = "0x2B35D00", VA = "0x182B37100")]
	public static void MPFJKDGCCNN<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, [In] T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B34070", Offset = "0x2B32C70", VA = "0x182B34070")]
	public static void ELAHKJDPCNF<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2B37C30", Offset = "0x2B36830", VA = "0x182B37C30")]
	public static void POPNBBOIFCJ<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, int OPDMGNJCACB, [In] T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D9A0", Offset = "0x2B2C5A0", VA = "0x182B2D9A0")]
	public static void AJEGLFHDELH<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2B2DB90", Offset = "0x2B2C790", VA = "0x182B2DB90")]
	public static T CBDDNOPKPBC<T>(this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B341D0", Offset = "0x2B32DD0", VA = "0x182B341D0")]
	public static void FDBIPEPOIMF<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, int HDFABDCMCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B2E850", Offset = "0x2B2D450", VA = "0x182B2E850")]
	private static void CFJLBIBDBCN<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, int ECCOECALPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2B37680", Offset = "0x2B36280", VA = "0x182B37680")]
	public static void ONDHHAABKMO<T>(this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B36AB0", Offset = "0x2B356B0", VA = "0x182B36AB0")]
	public static BDDFKGHGNDI<T> KLPACBHCBJJ<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF, AOGFEAHIOKI<T, T> BJBOAKPBBHO)
	{
		return default(BDDFKGHGNDI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B33EC0", Offset = "0x2B32AC0", VA = "0x182B33EC0")]
	public static bool EFBLKFLHIJM<T>(this BDDFKGHGNDI<T> HNFMOHFACKF, [In] T GLMEMJNJKAN) where T : AAKCPPDLFNK<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B36A40", Offset = "0x2B35640", VA = "0x182B36A40")]
	public static bool INNHKJOMFBL<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B36A50", Offset = "0x2B35650", VA = "0x182B36A50")]
	public static bool JKNIDJBNNDG<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF, int EKELKKECGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B30160", Offset = "0x2B2ED60", VA = "0x182B30160")]
	public static void DBNBMNNIPIC<T, TCtx>(this BDDFKGHGNDI<T> HNFMOHFACKF, [In] TCtx CCHBOMPCDMN, LIHEALAIMGP<TCtx, T> MEDJNHKOBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2B37580", Offset = "0x2B36180", VA = "0x182B37580")]
	private static void NFLEIFMPBMM<T, TCtx>(BDDFKGHGNDI<T> HNFMOHFACKF, [In] TCtx CCHBOMPCDMN, LIHEALAIMGP<TCtx, T> MEDJNHKOBEG, int EIDEGAOCDPB, int HIPGKMHOANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D300", Offset = "0x2B2BF00", VA = "0x182B2D300")]
	private static int ADJJDBCENEA<T, TCtx>(BDDFKGHGNDI<T> HNFMOHFACKF, [In] TCtx CCHBOMPCDMN, LIHEALAIMGP<TCtx, T> MEDJNHKOBEG, int EIDEGAOCDPB, int HIPGKMHOANA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x295A6F0", Offset = "0x29592F0", VA = "0x18295A6F0")]
	public static BDDFKGHGNDI<T>.PIFJCEFJMLD NDANHGBCNEI<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return default(BDDFKGHGNDI<T>.PIFJCEFJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x295A6F0", Offset = "0x29592F0", VA = "0x18295A6F0")]
	public static BDDFKGHGNDI<T>.OJEKBIIGINF HILKENMOIGK<T>(this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return default(BDDFKGHGNDI<T>.OJEKBIIGINF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x295A440", Offset = "0x2959040", VA = "0x18295A440")]
	public static BOAGKJKJNBH<T, BDDFKGHGNDI<T>.PIFJCEFJMLD> EAFKCJKMECH<T>([In] this BDDFKGHGNDI<T> HNFMOHFACKF)
	{
		return default(BOAGKJKJNBH<T, BDDFKGHGNDI<T>.PIFJCEFJMLD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class OALALBKCJFE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5200", Offset = "0x2CD3E00", VA = "0x182CD5200")]
	public static T[] PBHFBHLAANF<T>(int AEOJMEBJNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	public static void EFCBDPPPDPF<T>(T[] CHPEIOMPEEH)
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
