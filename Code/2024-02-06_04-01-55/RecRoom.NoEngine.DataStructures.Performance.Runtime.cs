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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x610D960", Offset = "0x610CD60", VA = "0x18610D960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA360", Offset = "0x7C9760", VA = "0x1807CA360")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3A0", Offset = "0x7C97A0", VA = "0x1807CA3A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BLBLCNJLPKD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23A3250", Offset = "0x23A2650", VA = "0x1823A3250")]
	public static MEIAKDLKHNA<T> AEANLKFEIHO<T>(this T[] LOMPFKEACIP) where T : notnull
	{
		return default(MEIAKDLKHNA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class ONJFPOMOGFM<T> : IDisposable, MMPEHANMEKC, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DLJGBCHBPKA<T> FHNNDHGHDBF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2650", Offset = "0x3FE1A50", VA = "0x183FE2650", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3FE2470", Offset = "0x3FE1870", VA = "0x183FE2470")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3FE24C0", Offset = "0x3FE18C0", VA = "0x183FE24C0")]
	public static ONJFPOMOGFM<T> CPLKLKACALP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3A63E70", Offset = "0x3A63270", VA = "0x183A63E70")]
	internal ONJFPOMOGFM([In] DLJGBCHBPKA<T> FBIBFNALIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3FE25E0", Offset = "0x3FE19E0", VA = "0x183FE25E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3FE24A0", Offset = "0x3FE18A0", VA = "0x183FE24A0")]
	public void APKBIJFBIND(int CBPPKGAPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2600", Offset = "0x3FE1A00", VA = "0x183FE2600", Slot = "8")]
	public DLJGBCHBPKA<T>.LNIHNBFBIJO GetEnumerator()
	{
		return default(DLJGBCHBPKA<T>.LNIHNBFBIJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2680", Offset = "0x3FE1A80", VA = "0x183FE2680", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2680", Offset = "0x3FE1A80", VA = "0x183FE2680", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BNHKMAPMMAI<T, U> : IEnumerable<T>, IEnumerable where U : EICKEBICPOE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U KOCNHIMDPNE;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D2EBB0", Offset = "0x1D2DFB0", VA = "0x181D2EBB0")]
	internal BNHKMAPMMAI([In] U CPMPLPGKMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x80C700", Offset = "0x80BB00", VA = "0x18080C700", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3765270", Offset = "0x3764670", VA = "0x183765270", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3765270", Offset = "0x3764670", VA = "0x183765270", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FIEIJHBDBLE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22164E0", Offset = "0x22158E0", VA = "0x1822164E0")]
	public static BNHKMAPMMAI<T, U> CPLKLKACALP<U>([In] U LOMPFKEACIP) where U : EICKEBICPOE<T>
	{
		return default(BNHKMAPMMAI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NEMJACCMBHM<TSourceEnumerator, TSource, TResult> : MMPEHANMEKC, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : MMPEHANMEKC, EICKEBICPOE<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private TSourceEnumerator OFLLJIENEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HOPOLELGJNG<TSource, TResult> BMJOINICIFD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3EBCE30", Offset = "0x3EBC230", VA = "0x183EBCE30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public readonly TResult PPPEJOJKNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD070", Offset = "0x3EBC470", VA = "0x183EBD070", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3EBCFF0", Offset = "0x3EBC3F0", VA = "0x183EBCFF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B48790", Offset = "0x3B47B90", VA = "0x183B48790")]
	internal NEMJACCMBHM([In] TSourceEnumerator LOMPFKEACIP, HOPOLELGJNG<TSource, TResult> NJAEFHOOELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3EBCD50", Offset = "0x3EBC150", VA = "0x183EBCD50", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3EBCEC0", Offset = "0x3EBC2C0", VA = "0x183EBCEC0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3EBCCC0", Offset = "0x3EBC0C0", VA = "0x183EBCCC0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PHIPIOALAPA<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly U KOCNHIMDPNE;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4097810", Offset = "0x4096C10", VA = "0x184097810")]
	internal PHIPIOALAPA([In] U CPMPLPGKMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4097330", Offset = "0x4096730", VA = "0x184097330", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4097680", Offset = "0x4096A80", VA = "0x184097680", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4097680", Offset = "0x4096A80", VA = "0x184097680", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MKJAIDIPMNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x25C5B30", Offset = "0x25C4F30", VA = "0x1825C5B30")]
	public static PHIPIOALAPA<T, U> CPLKLKACALP<U>([In] U LOMPFKEACIP) where U : IEnumerator<T>
	{
		return default(PHIPIOALAPA<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OFPKBOPEMGA<TSourceEnumerator, TSource, TResult> : MMPEHANMEKC, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : MMPEHANMEKC, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private TSourceEnumerator OFLLJIENEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<TSource, TResult> BMJOINICIFD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public readonly int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3EBCE30", Offset = "0x3EBC230", VA = "0x183EBCE30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly TResult PPPEJOJKNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1700", Offset = "0x3FD0B00", VA = "0x183FD1700", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3FD1650", Offset = "0x3FD0A50", VA = "0x183FD1650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3B48790", Offset = "0x3B47B90", VA = "0x183B48790")]
	internal OFPKBOPEMGA([In] TSourceEnumerator LOMPFKEACIP, Func<TSource, TResult> NJAEFHOOELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EBCD50", Offset = "0x3EBC150", VA = "0x183EBCD50", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EBCEC0", Offset = "0x3EBC2C0", VA = "0x183EBCEC0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EBCCC0", Offset = "0x3EBC0C0", VA = "0x183EBCCC0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal static class KJCCOAFNNJL
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x271CD00", Offset = "0x271C100", VA = "0x18271CD00")]
	public static string HDHMJEJOFMO<T>(this IEnumerable<T> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x270CF40", Offset = "0x270C340", VA = "0x18270CF40")]
	public static string DKINKDAMOAI<T>(this IEnumerable<T> LOMPFKEACIP, string HMOJCEECHOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FCBDJIONJHB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2656420", Offset = "0x2655820", VA = "0x182656420")]
	public static bool CKFEJMBCHAL<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LOMPFKEACIP, [In] TArgs EALPNGKPAMO, [In] OMOGKMCPPCK<TArgs, TSource, bool> DGACHEFIKJI) where TSourceEnumerator : EICKEBICPOE<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x26565B0", Offset = "0x26559B0", VA = "0x1826565B0")]
	public static int EFGFOKLIBDE<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator LOMPFKEACIP, [In] TArgs EALPNGKPAMO, OMOGKMCPPCK<TArgs, TSource, bool> DGACHEFIKJI) where TSourceEnumerator : EICKEBICPOE<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x26567B0", Offset = "0x2655BB0", VA = "0x1826567B0")]
	public static bool KGCNNLKPGLH<TSourceEnumerator, TSource>(this TSourceEnumerator LOMPFKEACIP, [In] TSource IEEBNOOJIPC) where TSourceEnumerator : EICKEBICPOE<TSource> where TSource : OOCNEMALIND<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2656A00", Offset = "0x2655E00", VA = "0x182656A00")]
	public static int PJEDNGIPDPK<TSourceEnumerator, TSource>(this TSourceEnumerator LOMPFKEACIP, [In] TSource ANJCCKHBJJO) where TSourceEnumerator : EICKEBICPOE<TSource> where TSource : OOCNEMALIND<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2656750", Offset = "0x2655B50", VA = "0x182656750")]
	public static NEMJACCMBHM<TSourceEnumerator, TSource, TResult> LGGAAAFCPFN<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LOMPFKEACIP, HOPOLELGJNG<TSource, TResult> NJAEFHOOELG) where TSourceEnumerator : MMPEHANMEKC, EICKEBICPOE<TSource>
	{
		return default(NEMJACCMBHM<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2656750", Offset = "0x2655B50", VA = "0x182656750")]
	public static OFPKBOPEMGA<TSourceEnumerator, TSource, TResult> FKOFCLBFGLE<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator LOMPFKEACIP, Func<TSource, TResult> NJAEFHOOELG) where TSourceEnumerator : MMPEHANMEKC, IEnumerator<TSource>
	{
		return default(OFPKBOPEMGA<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GEBBFNJNOIP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2217670", Offset = "0x2216A70", VA = "0x182217670")]
	public static bool FJDMPEILEKB<TSourceEnumerator>(TSourceEnumerator LOMPFKEACIP) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x22177E0", Offset = "0x2216BE0", VA = "0x1822177E0")]
	public static T LLBOJILPAON<TSourceEnumerator>(TSourceEnumerator LOMPFKEACIP) where TSourceEnumerator : EICKEBICPOE<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2218610", Offset = "0x2217A10", VA = "0x182218610")]
	public static T[] OOFOCAPKKNP<TSourceEnumerator>(TSourceEnumerator LOMPFKEACIP) where TSourceEnumerator : MMPEHANMEKC, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x22176E0", Offset = "0x2216AE0", VA = "0x1822176E0")]
	public static T FLCAHMNLPAM<TSourceEnumerator>(TSourceEnumerator LOMPFKEACIP) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EICKEBICPOE<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T PPPEJOJKNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MMPEHANMEKC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int EKCLJKKLOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NKENFCBEFFN<T> : EICKEBICPOE<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct HKCMNKDFOFG<T, U> : IEnumerable<T>, IEnumerable where U : NKENFCBEFFN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly U KOCNHIMDPNE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3765320", Offset = "0x3764720", VA = "0x183765320")]
	internal HKCMNKDFOFG([In] U CPMPLPGKMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x337B450", Offset = "0x337A850", VA = "0x18337B450", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x37651E0", Offset = "0x37645E0", VA = "0x1837651E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x37651E0", Offset = "0x37645E0", VA = "0x1837651E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NMAKLLLHHDE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x22164B0", Offset = "0x22158B0", VA = "0x1822164B0")]
	public static HKCMNKDFOFG<T, U> CPLKLKACALP<U>([In] U LOMPFKEACIP) where U : NKENFCBEFFN<T>
	{
		return default(HKCMNKDFOFG<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public readonly struct MEIAKDLKHNA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct PIECGHAGLMF : MMPEHANMEKC, EICKEBICPOE<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] OFLLJIENEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int EEMOEFHBFJA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly int EKCLJKKLOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x1D40DA0", Offset = "0x1D401A0", VA = "0x181D40DA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public readonly T PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x409D120", Offset = "0x409C520", VA = "0x18409D120", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x409C9F0", Offset = "0x409BDF0", VA = "0x18409C9F0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x409CCE0", Offset = "0x409C0E0", VA = "0x18409CCE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1791620", Offset = "0x1790A20", VA = "0x181791620")]
		private PIECGHAGLMF(T[] LOMPFKEACIP, int AHDNEIKOMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x409C950", Offset = "0x409BD50", VA = "0x18409C950")]
		public static PIECGHAGLMF CPLKLKACALP(T[] LOMPFKEACIP)
		{
			return default(PIECGHAGLMF);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1D40D70", Offset = "0x1D40170", VA = "0x181D40D70", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1D40E00", Offset = "0x1D40200", VA = "0x181D40E00", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly T[] AMELPPEHNKM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BGGPFCEBPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D40DA0", Offset = "0x1D401A0", VA = "0x181D40DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T LANLGIDAOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEEC70", Offset = "0x2CEE070", VA = "0x182CEEC70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA370", Offset = "0x8B9770", VA = "0x1808BA370")]
	internal MEIAKDLKHNA(T[] MGNOJHKHDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE17E0", Offset = "0x3DE0BE0", VA = "0x183DE17E0")]
	public static MEIAKDLKHNA<T> IEOIBINPDHE()
	{
		return default(MEIAKDLKHNA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
	public IEnumerable<T> KAOMNLFEDIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1A40", Offset = "0x3DE0E40", VA = "0x183DE1A40")]
	public ReadOnlyMemory<T> KNFFBBPLAGA()
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1AD0", Offset = "0x3DE0ED0", VA = "0x183DE1AD0")]
	public ReadOnlySpan<T> MBMJLLHIBLO()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1920", Offset = "0x3DE0D20", VA = "0x183DE1920")]
	public BNHKMAPMMAI<T, MEIAKDLKHNA<T>.PIECGHAGLMF> KLPDDJDPEIH()
	{
		return default(BNHKMAPMMAI<T, PIECGHAGLMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1B60", Offset = "0x3DE0F60", VA = "0x183DE1B60")]
	public PIECGHAGLMF NOEKFJHFNEL()
	{
		return default(PIECGHAGLMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DE18A0", Offset = "0x3DE0CA0", VA = "0x183DE18A0")]
	public IEnumerator<T> JLFJDPHFECC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1BF0", Offset = "0x3DE0FF0", VA = "0x183DE1BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class FAHECIGNNHN
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x23A2EE0", Offset = "0x23A22E0", VA = "0x1823A2EE0")]
	public static MEIAKDLKHNA<T> IBHFALDPFHB<T>(params T[] MGNOJHKHDPK) where T : notnull
	{
		return default(MEIAKDLKHNA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x610D900", Offset = "0x610CD00", VA = "0x18610D900")]
	public static Stream OGDGMLCLJAP(this MEIAKDLKHNA<byte> LOMPFKEACIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DebuggerTypeProxy(typeof(DLJGBCHBPKA<>.JJLKDLDLGPL))]
public struct DLJGBCHBPKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct LNIHNBFBIJO : MMPEHANMEKC, NKENFCBEFFN<T>, EICKEBICPOE<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly T[] CGGBBKIIMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly int AJFHBGKOEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int EEMOEFHBFJA;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly int EKCLJKKLOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1D39FD0", Offset = "0x1D393D0", VA = "0x181D39FD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public readonly T PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3BDF3E0", Offset = "0x3BDE7E0", VA = "0x183BDF3E0", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private readonly T GBINJOONCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3BDF290", Offset = "0x3BDE690", VA = "0x183BDF290", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3BDF2E0", Offset = "0x3BDE6E0", VA = "0x183BDF2E0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3BDF340", Offset = "0x3BDE740", VA = "0x183BDF340", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3642FB0", Offset = "0x36423B0", VA = "0x183642FB0")]
		internal LNIHNBFBIJO(T[] PGGCOHKMABC, int CBPPKGAPPDD, int AHDNEIKOMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3BDF230", Offset = "0x3BDE630", VA = "0x183BDF230")]
		public static LNIHNBFBIJO CPLKLKACALP(DLJGBCHBPKA<T> LOMPFKEACIP)
		{
			return default(LNIHNBFBIJO);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3334380", Offset = "0x3333780", VA = "0x183334380", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3333980", Offset = "0x3332D80", VA = "0x183333980", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct NEMOJDLALBJ : MMPEHANMEKC, EICKEBICPOE<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LNIHNBFBIJO KOCNHIMDPNE;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int EKCLJKKLOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3EBD4A0", Offset = "0x3EBC8A0", VA = "0x183EBD4A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public readonly T PPPEJOJKNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3EBD8D0", Offset = "0x3EBCCD0", VA = "0x183EBD8D0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3EBD570", Offset = "0x3EBC970", VA = "0x183EBD570", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3EBD6F0", Offset = "0x3EBCAF0", VA = "0x183EBD6F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1D2EBB0", Offset = "0x1D2DFB0", VA = "0x181D2EBB0")]
		private NEMOJDLALBJ([In] LNIHNBFBIJO CPMPLPGKMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD370", Offset = "0x3EBC770", VA = "0x183EBD370")]
		public static NEMOJDLALBJ CPLKLKACALP([In] DLJGBCHBPKA<T> LOMPFKEACIP)
		{
			return default(NEMOJDLALBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD460", Offset = "0x3EBC860", VA = "0x183EBD460", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD4D0", Offset = "0x3EBC8D0", VA = "0x183EBD4D0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD420", Offset = "0x3EBC820", VA = "0x183EBD420", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class JJLKDLDLGPL
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	internal T[] CGGBBKIIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal int AJFHBGKOEMB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5015830", Offset = "0x5014C30", VA = "0x185015830")]
	public static DLJGBCHBPKA<T> CPLKLKACALP()
	{
		return default(DLJGBCHBPKA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5015A50", Offset = "0x5014E50", VA = "0x185015A50")]
	public static DLJGBCHBPKA<T> NNHCPLBHFCF(int LNJIGPAGCFO)
	{
		return default(DLJGBCHBPKA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5015940", Offset = "0x5014D40", VA = "0x185015940")]
	public static DLJGBCHBPKA<T> FGIPFDLLMAN(int CBPPKGAPPDD)
	{
		return default(DLJGBCHBPKA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1791620", Offset = "0x1790A20", VA = "0x181791620")]
	internal DLJGBCHBPKA(T[] PGGCOHKMABC, int CBPPKGAPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B5FA80", Offset = "0x3B5EE80", VA = "0x183B5FA80", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AGAJGMIBCJI
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE690", Offset = "0x2CEDA90", VA = "0x182CEE690")]
	public static void HJKKNDHGMPB<T>(this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBE60", Offset = "0x2CEB260", VA = "0x182CEBE60")]
	public static string BKNFBCAJLGI<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
	public static T[] MPJHPIBJECC<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2749C00", Offset = "0x2749000", VA = "0x182749C00")]
	public static T JJNOBLLAEFC<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP, int FPJGJJLGENP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D40CC0", Offset = "0x1D400C0", VA = "0x181D40CC0")]
	public static T MHFPMEBDPLG<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, int FPJGJJLGENP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB780", Offset = "0x2CEAB80", VA = "0x182CEB780")]
	public static T BBCEOHNPBPL<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP, int FPJGJJLGENP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDF20", Offset = "0x2CED320", VA = "0x182CEDF20")]
	public static void ENHGLNPEFHG<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, int FPJGJJLGENP, [In] T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE5B0", Offset = "0x2CED9B0", VA = "0x182CEE5B0")]
	public static void GNKOADJKGOK<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, int FPJGJJLGENP, T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1D39FD0", Offset = "0x1D393D0", VA = "0x181D39FD0")]
	public static int IDODILDAIEM<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1E80", Offset = "0x2CF1280", VA = "0x182CF1E80")]
	public static ReadOnlySpan<T> MBMJLLHIBLO<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2CF22A0", Offset = "0x2CF16A0", VA = "0x182CF22A0")]
	public static T[] PHBCOJBJBJE<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2CEEBB0", Offset = "0x2CEDFB0", VA = "0x182CEEBB0")]
	public static T[] ILMELLFAGCI<T>(this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE4F0", Offset = "0x2CED8F0", VA = "0x182CEE4F0")]
	public static MEIAKDLKHNA<T> GHNMGBFEPCO<T>(this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return default(MEIAKDLKHNA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9260", Offset = "0x2CE8660", VA = "0x182CE9260")]
	public static void AFPNFDHLNMK<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, [In] T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2CF1F90", Offset = "0x2CF1390", VA = "0x182CF1F90")]
	public static void NAINIKBFBKJ<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE7E0", Offset = "0x2CEDBE0", VA = "0x182CEE7E0")]
	public static void HMFLAEKIEJM<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, int AHDNEIKOMIB, [In] T ANJCCKHBJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2CEEC30", Offset = "0x2CEE030", VA = "0x182CEEC30")]
	public static void INHKIJFMENC<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, int AHDNEIKOMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2CF2100", Offset = "0x2CF1500", VA = "0x182CF2100")]
	public static T PFDLAAEPGLA<T>(this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9B60", Offset = "0x2CE8F60", VA = "0x182CE9B60")]
	public static void APKBIJFBIND<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, int CBPPKGAPPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF2F0", Offset = "0x2CEE6F0", VA = "0x182CEF2F0")]
	private static void JPFNNGJFBNM<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, int LNJIGPAGCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBA90", Offset = "0x2CEAE90", VA = "0x182CEBA90")]
	public static void BILLODBOEME<T>(this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE910", Offset = "0x2CEDD10", VA = "0x182CEE910")]
	public static DLJGBCHBPKA<T> IDKMHHLNFJD<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP, HOPOLELGJNG<T, T> NKDCCACDEDD)
	{
		return default(DLJGBCHBPKA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB980", Offset = "0x2CEAD80", VA = "0x182CEB980")]
	public static bool BDFBAGGMCMD<T>(this DLJGBCHBPKA<T> LOMPFKEACIP, [In] T ANJCCKHBJJO) where T : OOCNEMALIND<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2820560", Offset = "0x281F960", VA = "0x182820560")]
	public static bool FMCKFONPAAG<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2CF20C0", Offset = "0x2CF14C0", VA = "0x182CF20C0")]
	public static bool ODDGNKPBLHK<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP, int FPJGJJLGENP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2541170", Offset = "0x2540570", VA = "0x182541170")]
	public static DLJGBCHBPKA<T>.NEMOJDLALBJ JLFJDPHFECC<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return default(DLJGBCHBPKA<T>.NEMOJDLALBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2541170", Offset = "0x2540570", VA = "0x182541170")]
	public static DLJGBCHBPKA<T>.LNIHNBFBIJO BAHHLLNNEBA<T>(this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return default(DLJGBCHBPKA<T>.LNIHNBFBIJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x26CDDD0", Offset = "0x26CD1D0", VA = "0x1826CDDD0")]
	public static BNHKMAPMMAI<T, DLJGBCHBPKA<T>.NEMOJDLALBJ> GPFMAJJBKOB<T>([In] this DLJGBCHBPKA<T> LOMPFKEACIP)
	{
		return default(BNHKMAPMMAI<T, DLJGBCHBPKA<T>.NEMOJDLALBJ>);
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
