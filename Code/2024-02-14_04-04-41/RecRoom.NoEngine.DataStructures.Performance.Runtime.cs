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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FF1280", Offset = "0x5FF0680", VA = "0x185FF1280")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C8560", Offset = "0x7C7960", VA = "0x1807C8560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C85A0", Offset = "0x7C79A0", VA = "0x1807C85A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FCCLHJLCDOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x221CE20", Offset = "0x221C220", VA = "0x18221CE20")]
	public static ONCNDMJEMJA<T> KNHPGFMALPJ<T>(this T[] NHHBAHIFHJK) where T : notnull
	{
		return default(ONCNDMJEMJA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class EIIKCMJPBGC<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FHOAFJPGJCO<T> FADHFJMFNKI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OICIIFDIAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x31F3540", Offset = "0x31F2940", VA = "0x1831F3540", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x31F33A0", Offset = "0x31F27A0", VA = "0x1831F33A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x31F3420", Offset = "0x31F2820", VA = "0x1831F3420")]
	public static EIIKCMJPBGC<T> JKJFENIAMEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x31D5730", Offset = "0x31D4B30", VA = "0x1831D5730")]
	internal EIIKCMJPBGC([In] FHOAFJPGJCO<T> CEBGEIIIEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x31F3360", Offset = "0x31F2760", VA = "0x1831F3360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x31F3380", Offset = "0x31F2780", VA = "0x1831F3380")]
	public void FOJNBCEMFEA(int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x31F33D0", Offset = "0x31F27D0", VA = "0x1831F33D0", Slot = "8")]
	public FHOAFJPGJCO<T>.KGKNAJNHFGC GetEnumerator()
	{
		return default(FHOAFJPGJCO<T>.KGKNAJNHFGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x31F3570", Offset = "0x31F2970", VA = "0x1831F3570", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x31F3570", Offset = "0x31F2970", VA = "0x1831F3570", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DFLOAPBJNDM<T, U> : IEnumerable<T>, IEnumerable where U : IOIMIHGPHKI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U ECGFDGFLICA;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D3B070", Offset = "0x1D3A470", VA = "0x181D3B070")]
	internal DFLOAPBJNDM([In] U JPFOLDCFLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x80A7D0", Offset = "0x809BD0", VA = "0x18080A7D0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x39E0230", Offset = "0x39DF630", VA = "0x1839E0230", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x39E0230", Offset = "0x39DF630", VA = "0x1839E0230", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OJKAGDKNDLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x24D2B20", Offset = "0x24D1F20", VA = "0x1824D2B20")]
	public static DFLOAPBJNDM<T, U> JKJFENIAMEL<U>([In] U NHHBAHIFHJK) where U : IOIMIHGPHKI<T>
	{
		return default(DFLOAPBJNDM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct LNLBHKJAOAK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U ECGFDGFLICA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B72BC0", Offset = "0x3B71FC0", VA = "0x183B72BC0")]
	internal LNLBHKJAOAK([In] U JPFOLDCFLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3B72740", Offset = "0x3B71B40", VA = "0x183B72740", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B727D0", Offset = "0x3B71BD0", VA = "0x183B727D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B727D0", Offset = "0x3B71BD0", VA = "0x183B727D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BEIJLFLJHOO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2ECECD0", Offset = "0x2ECE0D0", VA = "0x182ECECD0")]
	public static LNLBHKJAOAK<T, U> JKJFENIAMEL<U>([In] U NHHBAHIFHJK) where U : IEnumerator<T>
	{
		return default(LNLBHKJAOAK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GHGDONKDCEL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2627850", Offset = "0x2626C50", VA = "0x182627850")]
	public static string IAAAKFAJNPE<T>(this IEnumerable<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2629F50", Offset = "0x2629350", VA = "0x182629F50")]
	public static string JAJGPNAEJJP<T>(this IEnumerable<T> NHHBAHIFHJK, string AEOFNAACPIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NANBODDKJLE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x275C630", Offset = "0x275BA30", VA = "0x18275C630")]
	public static bool KDPIADPLOKO<TSourceEnumerator, TSource>(this TSourceEnumerator NHHBAHIFHJK, [In] TSource ELCFHMHMPMJ) where TSourceEnumerator : IOIMIHGPHKI<TSource> where TSource : FONIOECJOBC<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x275C880", Offset = "0x275BC80", VA = "0x18275C880")]
	public static int MIPNAOOCELA<TSourceEnumerator, TSource>(this TSourceEnumerator NHHBAHIFHJK, [In] TSource FDFHGIHHGHO) where TSourceEnumerator : IOIMIHGPHKI<TSource> where TSource : FONIOECJOBC<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IOIMIHGPHKI<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FPOHGHGPMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PACMPLMJIKL<T> : IOIMIHGPHKI<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct JILJKPMMNDE<T, U> : IEnumerable<T>, IEnumerable where U : PACMPLMJIKL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U ECGFDGFLICA;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x39E02E0", Offset = "0x39DF6E0", VA = "0x1839E02E0")]
	internal JILJKPMMNDE([In] U JPFOLDCFLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32C63A0", Offset = "0x32C57A0", VA = "0x1832C63A0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x39E01A0", Offset = "0x39DF5A0", VA = "0x1839E01A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x39E01A0", Offset = "0x39DF5A0", VA = "0x1839E01A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GCKJIPFKBAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x24D2AF0", Offset = "0x24D1EF0", VA = "0x1824D2AF0")]
	public static JILJKPMMNDE<T, U> JKJFENIAMEL<U>([In] U NHHBAHIFHJK) where U : PACMPLMJIKL<T>
	{
		return default(JILJKPMMNDE<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct ONCNDMJEMJA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LHPLCGAMAJK : IOIMIHGPHKI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] NHEIMMAFAKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int GJJACCEHJNF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3B5A690", Offset = "0x3B59A90", VA = "0x183B5A690", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3B5A1C0", Offset = "0x3B595C0", VA = "0x183B5A1C0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3B5A400", Offset = "0x3B59800", VA = "0x183B5A400", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x179FBD0", Offset = "0x179EFD0", VA = "0x18179FBD0")]
		private LHPLCGAMAJK(T[] NHHBAHIFHJK, int OJANCMLFDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3B59F20", Offset = "0x3B59320", VA = "0x183B59F20")]
		public static LHPLCGAMAJK JKJFENIAMEL(T[] NHHBAHIFHJK)
		{
			return default(LHPLCGAMAJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D53170", Offset = "0x1D52570", VA = "0x181D53170", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1D531A0", Offset = "0x1D525A0", VA = "0x181D531A0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] DEIFLKMCEKB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NDHLDPJEOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x36358E0", Offset = "0x3634CE0", VA = "0x1836358E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x260CB30", Offset = "0x260BF30", VA = "0x18260CB30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF70", Offset = "0x8BB370", VA = "0x1808BBF70")]
	internal ONCNDMJEMJA(T[] NIKMHLBDDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDA20", Offset = "0x3EFCE20", VA = "0x183EFDA20")]
	public static ONCNDMJEMJA<T> FEAMHHDKACA()
	{
		return default(ONCNDMJEMJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0")]
	public IEnumerable<T> ENDHLNPDINA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDC00", Offset = "0x3EFD000", VA = "0x183EFDC00")]
	public ReadOnlyMemory<T> JGNPIFEOPBA()
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDB70", Offset = "0x3EFCF70", VA = "0x183EFDB70")]
	public ReadOnlySpan<T> IMJILBCFONO()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDD10", Offset = "0x3EFD110", VA = "0x183EFDD10")]
	public DFLOAPBJNDM<T, ONCNDMJEMJA<T>.LHPLCGAMAJK> MKDCOIDNOFM()
	{
		return default(DFLOAPBJNDM<T, LHPLCGAMAJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDAE0", Offset = "0x3EFCEE0", VA = "0x183EFDAE0")]
	public LHPLCGAMAJK FEFBICEIHOI()
	{
		return default(LHPLCGAMAJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDC90", Offset = "0x3EFD090", VA = "0x183EFDC90")]
	public IEnumerator<T> MFONJKCHJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3EFDE30", Offset = "0x3EFD230", VA = "0x183EFDE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HGNLBJGELLP
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x243E560", Offset = "0x243D960", VA = "0x18243E560")]
	public static ONCNDMJEMJA<T> CNKDNCHHAGJ<T>(params T[] NIKMHLBDDHG) where T : notnull
	{
		return default(ONCNDMJEMJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1220", Offset = "0x5FF0620", VA = "0x185FF1220")]
	public static Stream MGJIFDFMGMA(this ONCNDMJEMJA<byte> NHHBAHIFHJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(FHOAFJPGJCO<>.FNDCCFBJHON))]
public struct FHOAFJPGJCO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct KGKNAJNHFGC : PACMPLMJIKL<T>, IOIMIHGPHKI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] HDOPLOHHPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int GDBMICBKOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int GJJACCEHJNF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3A6AC60", Offset = "0x3A6A060", VA = "0x183A6AC60", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T HHNPKNHMPJG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A540", Offset = "0x3A69940", VA = "0x183A6A540", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A640", Offset = "0x3A69A40", VA = "0x183A6A640", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3A6A9A0", Offset = "0x3A69DA0", VA = "0x183A6A9A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6AB80", Offset = "0x3A69F80", VA = "0x183A6AB80")]
		internal KGKNAJNHFGC(T[] NBBGPGGFMPG, int DPBEIPGOMHN, int OJANCMLFDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A5E0", Offset = "0x3A699E0", VA = "0x183A6A5E0")]
		public static KGKNAJNHFGC JKJFENIAMEL(FHOAFJPGJCO<T> NHHBAHIFHJK)
		{
			return default(KGKNAJNHFGC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3286CB0", Offset = "0x32860B0", VA = "0x183286CB0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3280EC0", Offset = "0x32802C0", VA = "0x183280EC0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct NEMNPNIGEFJ : IOIMIHGPHKI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KGKNAJNHFGC ECGFDGFLICA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T FPOHGHGPMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC2A0", Offset = "0x3DFB6A0", VA = "0x183DFC2A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3DFBF80", Offset = "0x3DFB380", VA = "0x183DFBF80", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3DFC1B0", Offset = "0x3DFB5B0", VA = "0x183DFC1B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1D3B070", Offset = "0x1D3A470", VA = "0x181D3B070")]
		private NEMNPNIGEFJ([In] KGKNAJNHFGC JPFOLDCFLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBDF0", Offset = "0x3DFB1F0", VA = "0x183DFBDF0")]
		public static NEMNPNIGEFJ JKJFENIAMEL([In] FHOAFJPGJCO<T> NHHBAHIFHJK)
		{
			return default(NEMNPNIGEFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBEA0", Offset = "0x3DFB2A0", VA = "0x183DFBEA0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBEE0", Offset = "0x3DFB2E0", VA = "0x183DFBEE0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBDB0", Offset = "0x3DFB1B0", VA = "0x183DFBDB0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class FNDCCFBJHON
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] HDOPLOHHPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int GDBMICBKOFD;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x358A9E0", Offset = "0x3589DE0", VA = "0x18358A9E0")]
	public static FHOAFJPGJCO<T> JKJFENIAMEL()
	{
		return default(FHOAFJPGJCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x358A930", Offset = "0x3589D30", VA = "0x18358A930")]
	public static FHOAFJPGJCO<T> FDHJEKNANAL(int NOOJMJOLDPD)
	{
		return default(FHOAFJPGJCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x179FBD0", Offset = "0x179EFD0", VA = "0x18179FBD0")]
	internal FHOAFJPGJCO(T[] NBBGPGGFMPG, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x358AA80", Offset = "0x3589E80", VA = "0x18358AA80", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FCOFBOJBFAK
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x260D1F0", Offset = "0x260C5F0", VA = "0x18260D1F0")]
	public static void NNIMNMJHJOG<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x260A460", Offset = "0x2609860", VA = "0x18260A460")]
	public static string GNACIBHEBEK<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80A7E0", Offset = "0x809BE0", VA = "0x18080A7E0")]
	public static T[] JOJKBONGCPG<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x260CA70", Offset = "0x260BE70", VA = "0x18260CA70")]
	public static T JNDPLHMHPON<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x260CBA0", Offset = "0x260BFA0", VA = "0x18260CBA0")]
	public static T KLICMMJIFNF<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x260D440", Offset = "0x260C840", VA = "0x18260D440")]
	public static T OPIFOPNPOPD<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2607650", Offset = "0x2606A50", VA = "0x182607650")]
	public static void BDBEANEDBLI<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD, [In] T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x260CD70", Offset = "0x260C170", VA = "0x18260CD70")]
	public static void KFGGGPHFGGC<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D46F30", Offset = "0x1D46330", VA = "0x181D46F30")]
	public static int PJKAGMCAGEO<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x260C960", Offset = "0x260BD60", VA = "0x18260C960")]
	public static ReadOnlySpan<T> IMJILBCFONO<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x260C7D0", Offset = "0x260BBD0", VA = "0x18260C7D0")]
	public static T[] HOMOADHPCFC<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2607B80", Offset = "0x2606F80", VA = "0x182607B80")]
	public static T ECNFKKEJGPG<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2607BA0", Offset = "0x2606FA0", VA = "0x182607BA0")]
	public static T[] EIOEECGHMAE<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x260C400", Offset = "0x260B800", VA = "0x18260C400")]
	public static ONCNDMJEMJA<T> GNHENANNADA<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(ONCNDMJEMJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2607C90", Offset = "0x2607090", VA = "0x182607C90")]
	public static void FLOHBAGDPJC<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, [In] T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x260D250", Offset = "0x260C650", VA = "0x18260D250")]
	public static void NOBGFIBAKIF<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x260CF40", Offset = "0x260C340", VA = "0x18260CF40")]
	public static void MJCHOKMCNEG<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int OJANCMLFDOJ, [In] T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2607400", Offset = "0x2606800", VA = "0x182607400")]
	public static void AOJMJBFFPPF<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x260C900", Offset = "0x260BD00", VA = "0x18260C900")]
	public static T ILKLNJMEHPI<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x26087E0", Offset = "0x2607BE0", VA = "0x1826087E0")]
	public static void FOJNBCEMFEA<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x260D4B0", Offset = "0x260C8B0", VA = "0x18260D4B0")]
	private static void PGCGCAKFKBJ<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x260D0E0", Offset = "0x260C4E0", VA = "0x18260D0E0")]
	public static void NJLBNDAIMDB<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x260C490", Offset = "0x260B890", VA = "0x18260C490")]
	public static FHOAFJPGJCO<T> GOIMIPPOIPI<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK, AMKINIAEIGB<T, T> HKDHAHGDCED)
	{
		return default(FHOAFJPGJCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x260A1B0", Offset = "0x26095B0", VA = "0x18260A1B0")]
	public static bool GIAEFIHDDDF<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, [In] T FDFHGIHHGHO) where T : FONIOECJOBC<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2607B70", Offset = "0x2606F70", VA = "0x182607B70")]
	public static bool CAHFEKLEAFD<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x260CA30", Offset = "0x260BE30", VA = "0x18260CA30")]
	public static bool JALAAGAMHKF<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x26073D0", Offset = "0x26067D0", VA = "0x1826073D0")]
	public static FHOAFJPGJCO<T>.NEMNPNIGEFJ MFONJKCHJIL<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<T>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x26073D0", Offset = "0x26067D0", VA = "0x1826073D0")]
	public static FHOAFJPGJCO<T>.KGKNAJNHFGC AHEBNFNJFAH<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<T>.KGKNAJNHFGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2607C20", Offset = "0x2607020", VA = "0x182607C20")]
	public static DFLOAPBJNDM<T, FHOAFJPGJCO<T>.NEMNPNIGEFJ> EJEOAPIEEGP<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(DFLOAPBJNDM<T, FHOAFJPGJCO<T>.NEMNPNIGEFJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class CFFNOACELGG
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x248EFA0", Offset = "0x248E3A0", VA = "0x18248EFA0")]
	public static T[] ECJFKKECNLC<T>(int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370")]
	public static void LLEBPKOIBKO<T>(T[] NIKMHLBDDHG)
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
