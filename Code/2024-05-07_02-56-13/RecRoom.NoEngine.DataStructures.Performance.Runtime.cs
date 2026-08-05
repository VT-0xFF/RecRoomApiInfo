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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x62A4510", Offset = "0x62A3710", VA = "0x1862A4510")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NPOCACLKLCK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2579160", Offset = "0x2578360", VA = "0x182579160")]
	public static NNPMDHNJLOE<T> KEOBFMPFCEK<T>(this T[] KNKOEEEKHDK) where T : notnull
	{
		return default(NNPMDHNJLOE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class MMBHBFCICHN<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FNBPBCOGKJO<T> PIPHLMIAIEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F96DA0", Offset = "0x3F95FA0", VA = "0x183F96DA0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3F96D10", Offset = "0x3F95F10", VA = "0x183F96D10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3F96DD0", Offset = "0x3F95FD0", VA = "0x183F96DD0")]
	public static MMBHBFCICHN<T> MIJABIECKKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F5FCC0", Offset = "0x3F5EEC0", VA = "0x183F5FCC0")]
	internal MMBHBFCICHN([In] FNBPBCOGKJO<T> PFGBPGKFOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F96CF0", Offset = "0x3F95EF0", VA = "0x183F96CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F96D80", Offset = "0x3F95F80", VA = "0x183F96D80")]
	public void IBCFOAEBNHM(int KIGJDGACGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F96D40", Offset = "0x3F95F40", VA = "0x183F96D40", Slot = "8")]
	public FNBPBCOGKJO<T>.JJJJHMCDAJI GetEnumerator()
	{
		return default(FNBPBCOGKJO<T>.JJJJHMCDAJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F96EE0", Offset = "0x3F960E0", VA = "0x183F96EE0", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F96EE0", Offset = "0x3F960E0", VA = "0x183F96EE0", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct KHINJKLEGHI<T, U> : IEnumerable<T>, IEnumerable where U : ANBLMLAFHBK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U GCCAFNGAFPH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E23E10", Offset = "0x1E23010", VA = "0x181E23E10")]
	internal KHINJKLEGHI([In] U JEGBGBMOBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C69CA0", Offset = "0x3C68EA0", VA = "0x183C69CA0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C69CA0", Offset = "0x3C68EA0", VA = "0x183C69CA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PPBEJANHGMK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x23CA6B0", Offset = "0x23C98B0", VA = "0x1823CA6B0")]
	public static KHINJKLEGHI<T, U> MIJABIECKKD<U>([In] U KNKOEEEKHDK) where U : ANBLMLAFHBK<T>
	{
		return default(KHINJKLEGHI<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct KDEJKKKPGJL<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U GCCAFNGAFPH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FE2ED0", Offset = "0x1FE20D0", VA = "0x181FE2ED0")]
	internal KDEJKKKPGJL([In] U JEGBGBMOBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FE60F0", Offset = "0x1FE52F0", VA = "0x181FE60F0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C69D10", Offset = "0x3C68F10", VA = "0x183C69D10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C69D10", Offset = "0x3C68F10", VA = "0x183C69D10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class KANCGAFNBBK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2580AA0", Offset = "0x257FCA0", VA = "0x182580AA0")]
	public static KDEJKKKPGJL<T, U> MIJABIECKKD<U>([In] U KNKOEEEKHDK) where U : IEnumerator<T>
	{
		return default(KDEJKKKPGJL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class PBDCJKMFBGA
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A53290", Offset = "0x2A52490", VA = "0x182A53290")]
	public static string HDDGAPBCEOB<T>(this IEnumerable<T> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A56570", Offset = "0x2A55770", VA = "0x182A56570")]
	public static string KHNDIOLIEJC<T>(this IEnumerable<T> KNKOEEEKHDK, string ICJCEBJEKFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IKNIAOLODCC
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x292ED00", Offset = "0x292DF00", VA = "0x18292ED00")]
	public static bool DDMNIHEHBJH<TSourceEnumerator, TSource>(this TSourceEnumerator KNKOEEEKHDK, [In] TSource DMLEKJCHBDC) where TSourceEnumerator : ANBLMLAFHBK<TSource> where TSource : BLODAJINHJK<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x292EE80", Offset = "0x292E080", VA = "0x18292EE80")]
	public static int JEAPBGDAANP<TSourceEnumerator, TSource>(this TSourceEnumerator KNKOEEEKHDK, [In] TSource NICEPFIEJED) where TSourceEnumerator : ANBLMLAFHBK<TSource> where TSource : BLODAJINHJK<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ANBLMLAFHBK<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T DCJELCPGFEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AIMLNHHHNKP<T> : ANBLMLAFHBK<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct KNNOCNMCDIF<T, U> : IEnumerable<T>, IEnumerable where U : AIMLNHHHNKP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U GCCAFNGAFPH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C93310", Offset = "0x3C92510", VA = "0x183C93310")]
	internal KNNOCNMCDIF([In] U JEGBGBMOBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x353CA60", Offset = "0x353BC60", VA = "0x18353CA60", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C93280", Offset = "0x3C92480", VA = "0x183C93280", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C93280", Offset = "0x3C92480", VA = "0x183C93280", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AAGGEABEOBL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23CA6E0", Offset = "0x23C98E0", VA = "0x1823CA6E0")]
	public static KNNOCNMCDIF<T, U> MIJABIECKKD<U>([In] U KNKOEEEKHDK) where U : AIMLNHHHNKP<T>
	{
		return default(KNNOCNMCDIF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct NNPMDHNJLOE<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PHNMJBDKIEM : ANBLMLAFHBK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] MPMKEMBLFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int FCMMIHDKLPI;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x426CDF0", Offset = "0x426BFF0", VA = "0x18426CDF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x426C6E0", Offset = "0x426B8E0", VA = "0x18426C6E0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x426C8C0", Offset = "0x426BAC0", VA = "0x18426C8C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1902280", Offset = "0x1901480", VA = "0x181902280")]
		private PHNMJBDKIEM(T[] KNKOEEEKHDK, int HMFNCGHECPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x426C5D0", Offset = "0x426B7D0", VA = "0x18426C5D0")]
		public static PHNMJBDKIEM MIJABIECKKD(T[] KNKOEEEKHDK)
		{
			return default(PHNMJBDKIEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E42890", Offset = "0x1E41A90", VA = "0x181E42890", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E428C0", Offset = "0x1E41AC0", VA = "0x181E428C0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] DILGOALHGBG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FPAACNPAGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x387D9E0", Offset = "0x387CBE0", VA = "0x18387D9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28E1150", Offset = "0x28E0350", VA = "0x1828E1150")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	internal NNPMDHNJLOE(T[] GEHAOEPMDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x407FD20", Offset = "0x407EF20", VA = "0x18407FD20")]
	public static NNPMDHNJLOE<T> CLJCIKPCCEE()
	{
		return default(NNPMDHNJLOE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
	public IEnumerable<T> EMMEICPDMGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x407FDD0", Offset = "0x407EFD0", VA = "0x18407FDD0")]
	public ReadOnlySpan<T> DNLMIAPCDIB()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x407FEF0", Offset = "0x407F0F0", VA = "0x18407FEF0")]
	public KHINJKLEGHI<T, NNPMDHNJLOE<T>.PHNMJBDKIEM> MDJACJJEGCF()
	{
		return default(KHINJKLEGHI<T, PHNMJBDKIEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x407FE60", Offset = "0x407F060", VA = "0x18407FE60")]
	public PHNMJBDKIEM KAKLDEPODDK()
	{
		return default(PHNMJBDKIEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4080000", Offset = "0x407F200", VA = "0x184080000")]
	public IEnumerator<T> ODDJKKOCOEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4080080", Offset = "0x407F280", VA = "0x184080080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IBLKLNNDMGF
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x257C0D0", Offset = "0x257B2D0", VA = "0x18257C0D0")]
	public static NNPMDHNJLOE<T> CKEAIEKFLIG<T>(params T[] GEHAOEPMDJB) where T : notnull
	{
		return default(NNPMDHNJLOE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62A44B0", Offset = "0x62A36B0", VA = "0x1862A44B0")]
	public static Stream GHJCOLLDOEE(this NNPMDHNJLOE<byte> KNKOEEEKHDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(FNBPBCOGKJO<>.CLFIJHALEIA))]
public struct FNBPBCOGKJO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JJJJHMCDAJI : AIMLNHHHNKP<T>, ANBLMLAFHBK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] EDLOHBKNHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int NHHGGKJNCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int FCMMIHDKLPI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3C22750", Offset = "0x3C21950", VA = "0x183C22750", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T KBCEHAEKFEG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x3C21F30", Offset = "0x3C21130", VA = "0x183C21F30", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x3C22240", Offset = "0x3C21440", VA = "0x183C22240", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3C226C0", Offset = "0x3C218C0", VA = "0x183C226C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x37D35A0", Offset = "0x37D27A0", VA = "0x1837D35A0")]
		internal JJJJHMCDAJI(T[] NOIICBHICIJ, int KIGJDGACGDD, int HMFNCGHECPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C21ED0", Offset = "0x3C210D0", VA = "0x183C21ED0")]
		public static JJJJHMCDAJI MIJABIECKKD(FNBPBCOGKJO<T> KNKOEEEKHDK)
		{
			return default(JJJJHMCDAJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x34FAB30", Offset = "0x34F9D30", VA = "0x1834FAB30", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x34F4F80", Offset = "0x34F4180", VA = "0x1834F4F80", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct BAFEGDGPEGK : ANBLMLAFHBK<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JJJJHMCDAJI GCCAFNGAFPH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4890400", Offset = "0x488F600", VA = "0x184890400", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x48900B0", Offset = "0x488F2B0", VA = "0x1848900B0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x48901E0", Offset = "0x488F3E0", VA = "0x1848901E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1E23E10", Offset = "0x1E23010", VA = "0x181E23E10")]
		private BAFEGDGPEGK([In] JJJJHMCDAJI JEGBGBMOBCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x488FF80", Offset = "0x488F180", VA = "0x18488FF80")]
		public static BAFEGDGPEGK MIJABIECKKD([In] FNBPBCOGKJO<T> KNKOEEEKHDK)
		{
			return default(BAFEGDGPEGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4890030", Offset = "0x488F230", VA = "0x184890030", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4890070", Offset = "0x488F270", VA = "0x184890070", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x488FF40", Offset = "0x488F140", VA = "0x18488FF40", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class CLFIJHALEIA
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] EDLOHBKNHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int NHHGGKJNCFI;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3815C30", Offset = "0x3814E30", VA = "0x183815C30")]
	public static FNBPBCOGKJO<T> MIJABIECKKD()
	{
		return default(FNBPBCOGKJO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3815B80", Offset = "0x3814D80", VA = "0x183815B80")]
	public static FNBPBCOGKJO<T> HBFMDKAHCJJ(int DIHLAEIGMPG)
	{
		return default(FNBPBCOGKJO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1902280", Offset = "0x1901480", VA = "0x181902280")]
	internal FNBPBCOGKJO(T[] NOIICBHICIJ, int KIGJDGACGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3815CD0", Offset = "0x3814ED0", VA = "0x183815CD0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class GCBJJGLJOCO
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int ADPFLHCONLK<TCtx, T>([In] TCtx EPAEKHCAPHF, T EFLJLNCMHDD, T DJDKOLONKNI);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x28DC360", Offset = "0x28DB560", VA = "0x1828DC360")]
	public static void HDPILJBHDHI<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x28DE8D0", Offset = "0x28DDAD0", VA = "0x1828DE8D0")]
	public static string JOMKNIEHJDN<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
	public static T[] FJFMOOPNENP<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E432E0", Offset = "0x1E424E0", VA = "0x181E432E0")]
	public static T OLBNKGLEPPK<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK, int GJIHJJPNBNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x28E1150", Offset = "0x28E0350", VA = "0x1828E1150")]
	public static T MAFFOJBPLII<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, int GJIHJJPNBNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x28DC200", Offset = "0x28DB400", VA = "0x1828DC200")]
	public static T HABJKDJBIIA<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK, int GJIHJJPNBNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x28D96C0", Offset = "0x28D88C0", VA = "0x1828D96C0")]
	public static void BHMONLIGLCO<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, int GJIHJJPNBNJ, [In] T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x28D9E10", Offset = "0x28D9010", VA = "0x1828D9E10")]
	public static void BILEFBAOGMO<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, int GJIHJJPNBNJ, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40")]
	public static int DMNDCOCNPMP<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x28DA420", Offset = "0x28D9620", VA = "0x1828DA420")]
	public static ReadOnlySpan<T> DNLMIAPCDIB<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x28D9470", Offset = "0x28D8670", VA = "0x1828D9470")]
	public static T[] ALDMJMCJEDK<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x28D9650", Offset = "0x28D8850", VA = "0x1828D9650")]
	public static T BGHMCPHDMOE<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x28E0F50", Offset = "0x28E0150", VA = "0x1828E0F50")]
	public static T[] KIEMLGAHABJ<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x28DE450", Offset = "0x28DD650", VA = "0x1828DE450")]
	public static NNPMDHNJLOE<T> ILPBEFJCBEJ<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return default(NNPMDHNJLOE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x28E16B0", Offset = "0x28E08B0", VA = "0x1828E16B0")]
	public static void OEOPOJPHCNL<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, [In] T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x28E13A0", Offset = "0x28E05A0", VA = "0x1828E13A0")]
	public static void MFCECGLEKFM<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x28DE4E0", Offset = "0x28DD6E0", VA = "0x1828DE4E0")]
	public static void JALAHJILOMO<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, int HMFNCGHECPG, [In] T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x28D9EE0", Offset = "0x28D90E0", VA = "0x1828D9EE0")]
	public static void BJKKLHHIGJO<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x28DC3C0", Offset = "0x28DB5C0", VA = "0x1828DC3C0")]
	public static T HLDJDGNJMLJ<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28DC600", Offset = "0x28DB800", VA = "0x1828DC600")]
	public static void IBCFOAEBNHM<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, int KIGJDGACGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x28DA610", Offset = "0x28D9810", VA = "0x1828DA610")]
	private static void EPBJJNCPEEH<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, int DIHLAEIGMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x28E1530", Offset = "0x28E0730", VA = "0x1828E1530")]
	public static void NDGKPACNNFE<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28DC000", Offset = "0x28DB200", VA = "0x1828DC000")]
	public static FNBPBCOGKJO<T> GJIFFJEBAAL<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK, LFANHHJKOEG<T, T> DKBHJCDCMOA)
	{
		return default(FNBPBCOGKJO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28D9F30", Offset = "0x28D9130", VA = "0x1828D9F30")]
	public static bool DFHLJHJOECJ<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK, [In] T NICEPFIEJED) where T : BLODAJINHJK<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x28D9F20", Offset = "0x28D9120", VA = "0x1828D9F20")]
	public static bool CBEJMOMNALI<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x28DC420", Offset = "0x28DB620", VA = "0x1828DC420")]
	public static bool HPJJPELJIGE<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK, int GJIHJJPNBNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28E1040", Offset = "0x28E0240", VA = "0x1828E1040")]
	public static void LPCJNMKBBKI<T, TCtx>(this FNBPBCOGKJO<T> KNKOEEEKHDK, [In] TCtx EPAEKHCAPHF, ADPFLHCONLK<TCtx, T> DOHELFGHDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x28DBF40", Offset = "0x28DB140", VA = "0x1828DBF40")]
	private static void FOBKJHICNGM<T, TCtx>(FNBPBCOGKJO<T> KNKOEEEKHDK, [In] TCtx EPAEKHCAPHF, ADPFLHCONLK<TCtx, T> DOHELFGHDNB, int INKFOGIINFH, int IGPBLMBNPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x28D9FD0", Offset = "0x28D91D0", VA = "0x1828D9FD0")]
	private static int DMKPPHDDPBL<T, TCtx>(FNBPBCOGKJO<T> KNKOEEEKHDK, [In] TCtx EPAEKHCAPHF, ADPFLHCONLK<TCtx, T> DOHELFGHDNB, int INKFOGIINFH, int IGPBLMBNPMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x28D93B0", Offset = "0x28D85B0", VA = "0x1828D93B0")]
	public static FNBPBCOGKJO<T>.BAFEGDGPEGK ODDJKKOCOEI<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return default(FNBPBCOGKJO<T>.BAFEGDGPEGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x28D93B0", Offset = "0x28D85B0", VA = "0x1828D93B0")]
	public static FNBPBCOGKJO<T>.JJJJHMCDAJI AJAJKGAJGPD<T>(this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return default(FNBPBCOGKJO<T>.JJJJHMCDAJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x28E0FD0", Offset = "0x28E01D0", VA = "0x1828E0FD0")]
	public static KHINJKLEGHI<T, FNBPBCOGKJO<T>.BAFEGDGPEGK> LKDIAEGFMFF<T>([In] this FNBPBCOGKJO<T> KNKOEEEKHDK)
	{
		return default(KHINJKLEGHI<T, FNBPBCOGKJO<T>.BAFEGDGPEGK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class LGOMMOPAGNA
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2983B00", Offset = "0x2982D00", VA = "0x182983B00")]
	public static T[] CAOBBIDGGKD<T>(int MKJBDDDPMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	public static void IHBKOICJNEP<T>(T[] GEHAOEPMDJB)
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
