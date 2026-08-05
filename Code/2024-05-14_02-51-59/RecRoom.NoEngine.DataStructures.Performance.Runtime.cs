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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x63F3900", Offset = "0x63F2300", VA = "0x1863F3900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7ED890", Offset = "0x7EC290", VA = "0x1807ED890")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED8D0", Offset = "0x7EC2D0", VA = "0x1807ED8D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NPMECIIBPDE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2715B40", Offset = "0x2714540", VA = "0x182715B40")]
	public static DJDPODDBFAH<T> NJNEKCBPLFJ<T>(this T[] CMJEIEIDHIK) where T : notnull
	{
		return default(DJDPODDBFAH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class JJILEHMACKM<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private IBNIMOLHAKB<T> IGFGDBIIGID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IAGPAHCAHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E8C0", Offset = "0x3C7D2C0", VA = "0x183C7E8C0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E950", Offset = "0x3C7D350", VA = "0x183C7E950")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E9A0", Offset = "0x3C7D3A0", VA = "0x183C7E9A0")]
	public static JJILEHMACKM<T> OLCPJHCMOKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x397CE60", Offset = "0x397B860", VA = "0x18397CE60")]
	internal JJILEHMACKM([In] IBNIMOLHAKB<T> KGDPHHJJNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E8F0", Offset = "0x3C7D2F0", VA = "0x183C7E8F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E980", Offset = "0x3C7D380", VA = "0x183C7E980")]
	public void HJDKMOHFBCI(int GBACAOOHJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E910", Offset = "0x3C7D310", VA = "0x183C7E910", Slot = "8")]
	public IBNIMOLHAKB<T>.BAJMJKGLBBA GetEnumerator()
	{
		return default(IBNIMOLHAKB<T>.BAJMJKGLBBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C7EAB0", Offset = "0x3C7D4B0", VA = "0x183C7EAB0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C7EAB0", Offset = "0x3C7D4B0", VA = "0x183C7EAB0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BEJAEPGKCAL<T, U> : IEnumerable<T>, IEnumerable where U : EMFPOCEJAJI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U CFHBDKOHMOM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E463D0", Offset = "0x1E44DD0", VA = "0x181E463D0")]
	internal BEJAEPGKCAL([In] U GKPKKDMKOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6D40", Offset = "0x3AD5740", VA = "0x183AD6D40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6D40", Offset = "0x3AD5740", VA = "0x183AD6D40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HAOECIFMBHA<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2416940", Offset = "0x2415340", VA = "0x182416940")]
	public static BEJAEPGKCAL<T, U> OLCPJHCMOKI<U>([In] U CMJEIEIDHIK) where U : EMFPOCEJAJI<T>
	{
		return default(BEJAEPGKCAL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KCAPEONJHAG<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U CFHBDKOHMOM;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3D51B90", Offset = "0x3D50590", VA = "0x183D51B90")]
	internal KCAPEONJHAG([In] U GKPKKDMKOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3D519A0", Offset = "0x3D503A0", VA = "0x183D519A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D519A0", Offset = "0x3D503A0", VA = "0x183D519A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GOBKKNOGAMD<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x281CE20", Offset = "0x281B820", VA = "0x18281CE20")]
	public static KCAPEONJHAG<T, U> OLCPJHCMOKI<U>([In] U CMJEIEIDHIK) where U : IEnumerator<T>
	{
		return default(KCAPEONJHAG<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class BONFKHBLIGH
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2720AF0", Offset = "0x271F4F0", VA = "0x182720AF0")]
	public static string KPGPACAMGGB<T>(this IEnumerable<T> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2723DF0", Offset = "0x27227F0", VA = "0x182723DF0")]
	public static string NOILDGGKEGH<T>(this IEnumerable<T> CMJEIEIDHIK, string LKFNJMOLGMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PNOJPBPPBAO
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2AD7210", Offset = "0x2AD5C10", VA = "0x182AD7210")]
	public static bool NHCMBNPHPFP<TSourceEnumerator, TSource>(this TSourceEnumerator CMJEIEIDHIK, [In] TSource ODDGLLCBILG) where TSourceEnumerator : EMFPOCEJAJI<TSource> where TSource : MBHFAJKBHGN<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6FB0", Offset = "0x2AD59B0", VA = "0x182AD6FB0")]
	public static int HKEBIEBGCOK<TSourceEnumerator, TSource>(this TSourceEnumerator CMJEIEIDHIK, [In] TSource AEJBOLFACJC) where TSourceEnumerator : EMFPOCEJAJI<TSource> where TSource : MBHFAJKBHGN<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EMFPOCEJAJI<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T EIIOCLGDIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FOAGDBICPPN<T> : EMFPOCEJAJI<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct IOHBLCJHIBM<T, U> : IEnumerable<T>, IEnumerable where U : FOAGDBICPPN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U CFHBDKOHMOM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6DB0", Offset = "0x3AD57B0", VA = "0x183AD6DB0")]
	internal IOHBLCJHIBM([In] U GKPKKDMKOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x35BD140", Offset = "0x35BBB40", VA = "0x1835BD140", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6C80", Offset = "0x3AD5680", VA = "0x183AD6C80", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3AD6C80", Offset = "0x3AD5680", VA = "0x183AD6C80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BMGKKLCPKAM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2416970", Offset = "0x2415370", VA = "0x182416970")]
	public static IOHBLCJHIBM<T, U> OLCPJHCMOKI<U>([In] U CMJEIEIDHIK) where U : FOAGDBICPPN<T>
	{
		return default(IOHBLCJHIBM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct DJDPODDBFAH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FBNOFIMOAFN : EMFPOCEJAJI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] IGGMLEGFMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int DNKJMNEGGBH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x38708F0", Offset = "0x386F2F0", VA = "0x1838708F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3870420", Offset = "0x386EE20", VA = "0x183870420", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x38707A0", Offset = "0x386F1A0", VA = "0x1838707A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x192AE60", Offset = "0x1929860", VA = "0x18192AE60")]
		private FBNOFIMOAFN(T[] CMJEIEIDHIK, int ABBNIPHGMGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3870180", Offset = "0x386EB80", VA = "0x183870180")]
		public static FBNOFIMOAFN OLCPJHCMOKI(T[] CMJEIEIDHIK)
		{
			return default(FBNOFIMOAFN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E72F90", Offset = "0x1E71990", VA = "0x181E72F90", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E72FF0", Offset = "0x1E719F0", VA = "0x181E72FF0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] BGCDGJMOFIF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EEALFJDFGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3C28360", Offset = "0x3C26D60", VA = "0x183C28360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T MIEEOIIACLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x29F3040", Offset = "0x29F1A40", VA = "0x1829F3040")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x954A30", Offset = "0x953430", VA = "0x180954A30")]
	internal DJDPODDBFAH(T[] KKAKPOKBAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5251280", Offset = "0x524FC80", VA = "0x185251280")]
	public static DJDPODDBFAH<T> ENNIKGPCCFB()
	{
		return default(DJDPODDBFAH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
	public IEnumerable<T> HIFPLALEMBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x52513B0", Offset = "0x524FDB0", VA = "0x1852513B0")]
	public ReadOnlySpan<T> KJPOCBFGPAO()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5251170", Offset = "0x524FB70", VA = "0x185251170")]
	public BEJAEPGKCAL<T, DJDPODDBFAH<T>.FBNOFIMOAFN> BNGOJHFEDEI()
	{
		return default(BEJAEPGKCAL<T, FBNOFIMOAFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5251440", Offset = "0x524FE40", VA = "0x185251440")]
	public FBNOFIMOAFN PNNBPPBHLKN()
	{
		return default(FBNOFIMOAFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5251330", Offset = "0x524FD30", VA = "0x185251330")]
	public IEnumerator<T> HOEJGHKHDAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x52514D0", Offset = "0x524FED0", VA = "0x1852514D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NKOLJHNJLMG
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x28C6120", Offset = "0x28C4B20", VA = "0x1828C6120")]
	public static DJDPODDBFAH<T> FAFPLPGKMIN<T>(params T[] KKAKPOKBAHF) where T : notnull
	{
		return default(DJDPODDBFAH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x63F38A0", Offset = "0x63F22A0", VA = "0x1863F38A0")]
	public static Stream EJLKFAFIOIJ(this DJDPODDBFAH<byte> CMJEIEIDHIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(IBNIMOLHAKB<>.DBPOCLOGMJF))]
public struct IBNIMOLHAKB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct BAJMJKGLBBA : FOAGDBICPPN<T>, EMFPOCEJAJI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] NKIOKJGJJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int JPKAHOGMFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int DNKJMNEGGBH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4926900", Offset = "0x4925300", VA = "0x184926900", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T EFHAFJFKDFI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x49260B0", Offset = "0x4924AB0", VA = "0x1849260B0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x49262C0", Offset = "0x4924CC0", VA = "0x1849262C0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4926570", Offset = "0x4924F70", VA = "0x184926570", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4053140", Offset = "0x4051B40", VA = "0x184053140")]
		internal BAJMJKGLBBA(T[] APNNJDENMKO, int GBACAOOHJGH, int ABBNIPHGMGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x49261F0", Offset = "0x4924BF0", VA = "0x1849261F0")]
		public static BAJMJKGLBBA OLCPJHCMOKI(IBNIMOLHAKB<T> CMJEIEIDHIK)
		{
			return default(BAJMJKGLBBA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x357BFE0", Offset = "0x357A9E0", VA = "0x18357BFE0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3576600", Offset = "0x3575000", VA = "0x183576600", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct BNEHJDGMJED : EMFPOCEJAJI<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BAJMJKGLBBA CFHBDKOHMOM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x495DD60", Offset = "0x495C760", VA = "0x18495DD60", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x495DA50", Offset = "0x495C450", VA = "0x18495DA50", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x495DCC0", Offset = "0x495C6C0", VA = "0x18495DCC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1E463D0", Offset = "0x1E44DD0", VA = "0x181E463D0")]
		private BNEHJDGMJED([In] BAJMJKGLBBA GKPKKDMKOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x495D960", Offset = "0x495C360", VA = "0x18495D960")]
		public static BNEHJDGMJED OLCPJHCMOKI([In] IBNIMOLHAKB<T> CMJEIEIDHIK)
		{
			return default(BNEHJDGMJED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x495D920", Offset = "0x495C320", VA = "0x18495D920", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x495DA10", Offset = "0x495C410", VA = "0x18495DA10", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x495D8E0", Offset = "0x495C2E0", VA = "0x18495D8E0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class DBPOCLOGMJF
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] NKIOKJGJJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int JPKAHOGMFLM;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4560", Offset = "0x3AA2F60", VA = "0x183AA4560")]
	public static IBNIMOLHAKB<T> OLCPJHCMOKI()
	{
		return default(IBNIMOLHAKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3AA44B0", Offset = "0x3AA2EB0", VA = "0x183AA44B0")]
	public static IBNIMOLHAKB<T> OJKMGPBNCLA(int JDNEKMCCAKP)
	{
		return default(IBNIMOLHAKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x192AE60", Offset = "0x1929860", VA = "0x18192AE60")]
	internal IBNIMOLHAKB(T[] APNNJDENMKO, int GBACAOOHJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4600", Offset = "0x3AA3000", VA = "0x183AA4600", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class LPAFHDJCMIP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int FLECALPJDFG<TCtx, T>([In] TCtx GGMIPCKCOKA, T OOMAGBGJFDN, T CBOPOPHGBGK);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29F2620", Offset = "0x29F1020", VA = "0x1829F2620")]
	public static void KDNFCEDEOOI<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29F3BD0", Offset = "0x29F25D0", VA = "0x1829F3BD0")]
	public static string PDLNEOEBPII<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x88DB00", Offset = "0x88C500", VA = "0x18088DB00")]
	public static T[] GPLCFJODCNL<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x29F3040", Offset = "0x29F1A40", VA = "0x1829F3040")]
	public static T OIFPBAJNOAG<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK, int AJODNFJNJPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x29F3040", Offset = "0x29F1A40", VA = "0x1829F3040")]
	public static T NNCCCBBPBBP<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, int AJODNFJNJPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29F00B0", Offset = "0x29EEAB0", VA = "0x1829F00B0")]
	public static T GJAEFFJMDHC<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK, int AJODNFJNJPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29F32B0", Offset = "0x29F1CB0", VA = "0x1829F32B0")]
	public static void NPHNBOIFMNI<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, int AJODNFJNJPO, [In] T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29F2DD0", Offset = "0x29F17D0", VA = "0x1829F2DD0")]
	public static void LEKFGEGKCIJ<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, int AJODNFJNJPO, T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590")]
	public static int LABFIHOGEOB<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29F2680", Offset = "0x29F1080", VA = "0x1829F2680")]
	public static ReadOnlySpan<T> KJPOCBFGPAO<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x29EE110", Offset = "0x29ECB10", VA = "0x1829EE110")]
	public static T[] BJFPHNKALIC<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29EE2D0", Offset = "0x29ECCD0", VA = "0x1829EE2D0")]
	public static T CCEIFHGCMBL<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x29F2BA0", Offset = "0x29F15A0", VA = "0x1829F2BA0")]
	public static T[] KPGLKDOMDGL<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29F3880", Offset = "0x29F2280", VA = "0x1829F3880")]
	public static DJDPODDBFAH<T> OCEEJOKIAMB<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return default(DJDPODDBFAH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29EDD00", Offset = "0x29EC700", VA = "0x1829EDD00")]
	public static void BIPEDCDHLGG<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, [In] T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29EE360", Offset = "0x29ECD60", VA = "0x1829EE360")]
	public static void EFOOBICLOGF<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29F24C0", Offset = "0x29F0EC0", VA = "0x1829F24C0")]
	public static void JHKFJEAFEFB<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, int ABBNIPHGMGH, [In] T AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x29F21D0", Offset = "0x29F0BD0", VA = "0x1829F21D0")]
	public static void IJEHCCFPBEB<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, int ABBNIPHGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x29EE2F0", Offset = "0x29ECCF0", VA = "0x1829EE2F0")]
	public static T CIKNNBBKLNK<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29F0360", Offset = "0x29EED60", VA = "0x1829F0360")]
	public static void HJDKMOHFBCI<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, int GBACAOOHJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29EEA40", Offset = "0x29ED440", VA = "0x1829EEA40")]
	private static void FKLEDPDIGBI<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, int JDNEKMCCAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29F2C20", Offset = "0x29F1620", VA = "0x1829F2C20")]
	public static void LDCFGOINEDJ<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29F2210", Offset = "0x29F0C10", VA = "0x1829F2210")]
	public static IBNIMOLHAKB<T> JCNCJJKPAFA<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK, PODJBIOJGJG<T, T> FDCEGAPDBBN)
	{
		return default(IBNIMOLHAKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29F0140", Offset = "0x29EEB40", VA = "0x1829F0140")]
	public static bool GJPLCNFFHOP<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK, [In] T AEJBOLFACJC) where T : MBHFAJKBHGN<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x29EE350", Offset = "0x29ECD50", VA = "0x1829EE350")]
	public static bool DNNOPBKFOAJ<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x29EE550", Offset = "0x29ECF50", VA = "0x1829EE550")]
	public static bool FFMOLAOEFOE<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK, int AJODNFJNJPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x29F25F0", Offset = "0x29F0FF0", VA = "0x1829F25F0")]
	public static void JOLBIIGJKAP<T, TCtx>(this IBNIMOLHAKB<T> CMJEIEIDHIK, [In] TCtx GGMIPCKCOKA, FLECALPJDFG<TCtx, T> PPKFPLHIIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x29EDAB0", Offset = "0x29EC4B0", VA = "0x1829EDAB0")]
	private static void BGOAAOEPICJ<T, TCtx>(IBNIMOLHAKB<T> CMJEIEIDHIK, [In] TCtx GGMIPCKCOKA, FLECALPJDFG<TCtx, T> PPKFPLHIIOE, int LFPFKOOCFPO, int DAHENPJOLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x29F2750", Offset = "0x29F1150", VA = "0x1829F2750")]
	private static int KMPCPDCAHFJ<T, TCtx>(IBNIMOLHAKB<T> CMJEIEIDHIK, [In] TCtx GGMIPCKCOKA, FLECALPJDFG<TCtx, T> PPKFPLHIIOE, int LFPFKOOCFPO, int DAHENPJOLAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x293ACE0", Offset = "0x29396E0", VA = "0x18293ACE0")]
	public static IBNIMOLHAKB<T>.BNEHJDGMJED HOEJGHKHDAP<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return default(IBNIMOLHAKB<T>.BNEHJDGMJED);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x293ACE0", Offset = "0x29396E0", VA = "0x18293ACE0")]
	public static IBNIMOLHAKB<T>.BAJMJKGLBBA NJEECGONBJD<T>(this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return default(IBNIMOLHAKB<T>.BAJMJKGLBBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x293A0E0", Offset = "0x2938AE0", VA = "0x18293A0E0")]
	public static BEJAEPGKCAL<T, IBNIMOLHAKB<T>.BNEHJDGMJED> CIFPILBGCKN<T>([In] this IBNIMOLHAKB<T> CMJEIEIDHIK)
	{
		return default(BEJAEPGKCAL<T, IBNIMOLHAKB<T>.BNEHJDGMJED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class PMNPEHBEBDE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD6B60", Offset = "0x2AD5560", VA = "0x182AD6B60")]
	public static T[] MCOGPMHHNLM<T>(int CBAOPDHODHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0")]
	public static void CADFIDMPCOH<T>(T[] KKAKPOKBAHF)
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
