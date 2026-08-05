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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x606ACC0", Offset = "0x60696C0", VA = "0x18606ACC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D2560", Offset = "0x7D0F60", VA = "0x1807D2560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D25A0", Offset = "0x7D0FA0", VA = "0x1807D25A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FCCLHJLCDOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2240480", Offset = "0x223EE80", VA = "0x182240480")]
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
		[Cpp2IlInjected.Address(RVA = "0x3222DA0", Offset = "0x32217A0", VA = "0x183222DA0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3222C00", Offset = "0x3221600", VA = "0x183222C00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3222C80", Offset = "0x3221680", VA = "0x183222C80")]
	public static EIIKCMJPBGC<T> JKJFENIAMEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3204F90", Offset = "0x3203990", VA = "0x183204F90")]
	internal EIIKCMJPBGC([In] FHOAFJPGJCO<T> CEBGEIIIEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3222BC0", Offset = "0x32215C0", VA = "0x183222BC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3222BE0", Offset = "0x32215E0", VA = "0x183222BE0")]
	public void FOJNBCEMFEA(int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3222C30", Offset = "0x3221630", VA = "0x183222C30", Slot = "8")]
	public FHOAFJPGJCO<T>.KGKNAJNHFGC GetEnumerator()
	{
		return default(FHOAFJPGJCO<T>.KGKNAJNHFGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3222DD0", Offset = "0x32217D0", VA = "0x183222DD0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3222DD0", Offset = "0x32217D0", VA = "0x183222DD0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x1D542E0", Offset = "0x1D52CE0", VA = "0x181D542E0")]
	internal DFLOAPBJNDM([In] U JPFOLDCFLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x814580", Offset = "0x812F80", VA = "0x180814580", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A29150", Offset = "0x3A27B50", VA = "0x183A29150", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A29150", Offset = "0x3A27B50", VA = "0x183A29150", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OJKAGDKNDLD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2500E40", Offset = "0x24FF840", VA = "0x182500E40")]
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
	[Cpp2IlInjected.Address(RVA = "0x3BA2810", Offset = "0x3BA1210", VA = "0x183BA2810")]
	internal LNLBHKJAOAK([In] U JPFOLDCFLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2390", Offset = "0x3BA0D90", VA = "0x183BA2390", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2420", Offset = "0x3BA0E20", VA = "0x183BA2420", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2420", Offset = "0x3BA0E20", VA = "0x183BA2420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BEIJLFLJHOO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2F0AC00", Offset = "0x2F09600", VA = "0x182F0AC00")]
	public static LNLBHKJAOAK<T, U> JKJFENIAMEL<U>([In] U NHHBAHIFHJK) where U : IEnumerator<T>
	{
		return default(LNLBHKJAOAK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GHGDONKDCEL
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x267C960", Offset = "0x267B360", VA = "0x18267C960")]
	public static string IAAAKFAJNPE<T>(this IEnumerable<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x267F9F0", Offset = "0x267E3F0", VA = "0x18267F9F0")]
	public static string JAJGPNAEJJP<T>(this IEnumerable<T> NHHBAHIFHJK, string AEOFNAACPIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NANBODDKJLE
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27B2CF0", Offset = "0x27B16F0", VA = "0x1827B2CF0")]
	public static bool KDPIADPLOKO<TSourceEnumerator, TSource>(this TSourceEnumerator NHHBAHIFHJK, [In] TSource ELCFHMHMPMJ) where TSourceEnumerator : IOIMIHGPHKI<TSource> where TSource : FONIOECJOBC<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x27B2F40", Offset = "0x27B1940", VA = "0x1827B2F40")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A29200", Offset = "0x3A27C00", VA = "0x183A29200")]
	internal JILJKPMMNDE([In] U JPFOLDCFLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32FA050", Offset = "0x32F8A50", VA = "0x1832FA050", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A290C0", Offset = "0x3A27AC0", VA = "0x183A290C0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3A290C0", Offset = "0x3A27AC0", VA = "0x183A290C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GCKJIPFKBAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2500E10", Offset = "0x24FF810", VA = "0x182500E10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B8A340", Offset = "0x3B88D40", VA = "0x183B8A340", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3B89E70", Offset = "0x3B88870", VA = "0x183B89E70", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3B8A0B0", Offset = "0x3B88AB0", VA = "0x183B8A0B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x17B6E20", Offset = "0x17B5820", VA = "0x1817B6E20")]
		private LHPLCGAMAJK(T[] NHHBAHIFHJK, int OJANCMLFDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3B89BD0", Offset = "0x3B885D0", VA = "0x183B89BD0")]
		public static LHPLCGAMAJK JKJFENIAMEL(T[] NHHBAHIFHJK)
		{
			return default(LHPLCGAMAJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D6DD70", Offset = "0x1D6C770", VA = "0x181D6DD70", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1D6DDA0", Offset = "0x1D6C7A0", VA = "0x181D6DDA0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x367A720", Offset = "0x3679120", VA = "0x18367A720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T BFKPGKFLJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2661930", Offset = "0x2660330", VA = "0x182661930")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
	internal ONCNDMJEMJA(T[] NIKMHLBDDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3F327F0", Offset = "0x3F311F0", VA = "0x183F327F0")]
	public static ONCNDMJEMJA<T> FEAMHHDKACA()
	{
		return default(ONCNDMJEMJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x814590", Offset = "0x812F90", VA = "0x180814590")]
	public IEnumerable<T> ENDHLNPDINA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3F329D0", Offset = "0x3F313D0", VA = "0x183F329D0")]
	public ReadOnlyMemory<T> JGNPIFEOPBA()
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3F32940", Offset = "0x3F31340", VA = "0x183F32940")]
	public ReadOnlySpan<T> IMJILBCFONO()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F32AE0", Offset = "0x3F314E0", VA = "0x183F32AE0")]
	public DFLOAPBJNDM<T, ONCNDMJEMJA<T>.LHPLCGAMAJK> MKDCOIDNOFM()
	{
		return default(DFLOAPBJNDM<T, LHPLCGAMAJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3F328B0", Offset = "0x3F312B0", VA = "0x183F328B0")]
	public LHPLCGAMAJK FEFBICEIHOI()
	{
		return default(LHPLCGAMAJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F32A60", Offset = "0x3F31460", VA = "0x183F32A60")]
	public IEnumerator<T> MFONJKCHJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F32C00", Offset = "0x3F31600", VA = "0x183F32C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HGNLBJGELLP
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x248FF70", Offset = "0x248E970", VA = "0x18248FF70")]
	public static ONCNDMJEMJA<T> CNKDNCHHAGJ<T>(params T[] NIKMHLBDDHG) where T : notnull
	{
		return default(ONCNDMJEMJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x606AC60", Offset = "0x6069660", VA = "0x18606AC60")]
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
			[Cpp2IlInjected.Address(RVA = "0x3A95CD0", Offset = "0x3A946D0", VA = "0x183A95CD0", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T HHNPKNHMPJG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3A955B0", Offset = "0x3A93FB0", VA = "0x183A955B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3A956B0", Offset = "0x3A940B0", VA = "0x183A956B0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3A95970", Offset = "0x3A94370", VA = "0x183A95970", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3A95BF0", Offset = "0x3A945F0", VA = "0x183A95BF0")]
		internal KGKNAJNHFGC(T[] NBBGPGGFMPG, int DPBEIPGOMHN, int OJANCMLFDOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3A95650", Offset = "0x3A94050", VA = "0x183A95650")]
		public static KGKNAJNHFGC JKJFENIAMEL(FHOAFJPGJCO<T> NHHBAHIFHJK)
		{
			return default(KGKNAJNHFGC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x32B6810", Offset = "0x32B5210", VA = "0x1832B6810", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x32B08C0", Offset = "0x32AF2C0", VA = "0x1832B08C0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E328B0", Offset = "0x3E312B0", VA = "0x183E328B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3E32590", Offset = "0x3E30F90", VA = "0x183E32590", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3E327C0", Offset = "0x3E311C0", VA = "0x183E327C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1D542E0", Offset = "0x1D52CE0", VA = "0x181D542E0")]
		private NEMNPNIGEFJ([In] KGKNAJNHFGC JPFOLDCFLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E32400", Offset = "0x3E30E00", VA = "0x183E32400")]
		public static NEMNPNIGEFJ JKJFENIAMEL([In] FHOAFJPGJCO<T> NHHBAHIFHJK)
		{
			return default(NEMNPNIGEFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3E324B0", Offset = "0x3E30EB0", VA = "0x183E324B0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3E324F0", Offset = "0x3E30EF0", VA = "0x183E324F0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3E323C0", Offset = "0x3E30DC0", VA = "0x183E323C0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x35B5AE0", Offset = "0x35B44E0", VA = "0x1835B5AE0")]
	public static FHOAFJPGJCO<T> JKJFENIAMEL()
	{
		return default(FHOAFJPGJCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x35B5A30", Offset = "0x35B4430", VA = "0x1835B5A30")]
	public static FHOAFJPGJCO<T> FDHJEKNANAL(int NOOJMJOLDPD)
	{
		return default(FHOAFJPGJCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x17B6E20", Offset = "0x17B5820", VA = "0x1817B6E20")]
	internal FHOAFJPGJCO(T[] NBBGPGGFMPG, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35B5B80", Offset = "0x35B4580", VA = "0x1835B5B80", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FCOFBOJBFAK
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2661FF0", Offset = "0x26609F0", VA = "0x182661FF0")]
	public static void NNIMNMJHJOG<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x265F260", Offset = "0x265DC60", VA = "0x18265F260")]
	public static string GNACIBHEBEK<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x814590", Offset = "0x812F90", VA = "0x180814590")]
	public static T[] JOJKBONGCPG<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2661870", Offset = "0x2660270", VA = "0x182661870")]
	public static T JNDPLHMHPON<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26619A0", Offset = "0x26603A0", VA = "0x1826619A0")]
	public static T KLICMMJIFNF<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2662240", Offset = "0x2660C40", VA = "0x182662240")]
	public static T OPIFOPNPOPD<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x265C450", Offset = "0x265AE50", VA = "0x18265C450")]
	public static void BDBEANEDBLI<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD, [In] T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2661B70", Offset = "0x2660570", VA = "0x182661B70")]
	public static void KFGGGPHFGGC<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D60D30", Offset = "0x1D5F730", VA = "0x181D60D30")]
	public static int PJKAGMCAGEO<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2661760", Offset = "0x2660160", VA = "0x182661760")]
	public static ReadOnlySpan<T> IMJILBCFONO<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26615D0", Offset = "0x265FFD0", VA = "0x1826615D0")]
	public static T[] HOMOADHPCFC<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x265C980", Offset = "0x265B380", VA = "0x18265C980")]
	public static T ECNFKKEJGPG<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x265C9A0", Offset = "0x265B3A0", VA = "0x18265C9A0")]
	public static T[] EIOEECGHMAE<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2661200", Offset = "0x265FC00", VA = "0x182661200")]
	public static ONCNDMJEMJA<T> GNHENANNADA<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(ONCNDMJEMJA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x265CA90", Offset = "0x265B490", VA = "0x18265CA90")]
	public static void FLOHBAGDPJC<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, [In] T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2662050", Offset = "0x2660A50", VA = "0x182662050")]
	public static void NOBGFIBAKIF<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2661D40", Offset = "0x2660740", VA = "0x182661D40")]
	public static void MJCHOKMCNEG<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int OJANCMLFDOJ, [In] T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x265C200", Offset = "0x265AC00", VA = "0x18265C200")]
	public static void AOJMJBFFPPF<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int OJANCMLFDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2661700", Offset = "0x2660100", VA = "0x182661700")]
	public static T ILKLNJMEHPI<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x265D5E0", Offset = "0x265BFE0", VA = "0x18265D5E0")]
	public static void FOJNBCEMFEA<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int DPBEIPGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x26622B0", Offset = "0x2660CB0", VA = "0x1826622B0")]
	private static void PGCGCAKFKBJ<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, int NOOJMJOLDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2661EE0", Offset = "0x26608E0", VA = "0x182661EE0")]
	public static void NJLBNDAIMDB<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2661290", Offset = "0x265FC90", VA = "0x182661290")]
	public static FHOAFJPGJCO<T> GOIMIPPOIPI<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK, AMKINIAEIGB<T, T> HKDHAHGDCED)
	{
		return default(FHOAFJPGJCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x265EFB0", Offset = "0x265D9B0", VA = "0x18265EFB0")]
	public static bool GIAEFIHDDDF<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK, [In] T FDFHGIHHGHO) where T : FONIOECJOBC<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x265C970", Offset = "0x265B370", VA = "0x18265C970")]
	public static bool CAHFEKLEAFD<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2661830", Offset = "0x2660230", VA = "0x182661830")]
	public static bool JALAAGAMHKF<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK, int CCNHOKJIGCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x265C1D0", Offset = "0x265ABD0", VA = "0x18265C1D0")]
	public static FHOAFJPGJCO<T>.NEMNPNIGEFJ MFONJKCHJIL<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<T>.NEMNPNIGEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x265C1D0", Offset = "0x265ABD0", VA = "0x18265C1D0")]
	public static FHOAFJPGJCO<T>.KGKNAJNHFGC AHEBNFNJFAH<T>(this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(FHOAFJPGJCO<T>.KGKNAJNHFGC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x265CA20", Offset = "0x265B420", VA = "0x18265CA20")]
	public static DFLOAPBJNDM<T, FHOAFJPGJCO<T>.NEMNPNIGEFJ> EJEOAPIEEGP<T>([In] this FHOAFJPGJCO<T> NHHBAHIFHJK)
	{
		return default(DFLOAPBJNDM<T, FHOAFJPGJCO<T>.NEMNPNIGEFJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal static class CFFNOACELGG
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24E1760", Offset = "0x24E0160", VA = "0x1824E1760")]
	public static T[] ECJFKKECNLC<T>(int BFFGCOIILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370")]
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
