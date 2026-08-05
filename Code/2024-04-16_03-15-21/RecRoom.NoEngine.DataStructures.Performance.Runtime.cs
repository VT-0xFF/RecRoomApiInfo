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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x61E8520", Offset = "0x61E7720", VA = "0x1861E8520")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DED90", Offset = "0x7DDF90", VA = "0x1807DED90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEDD0", Offset = "0x7DDFD0", VA = "0x1807DEDD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MHFIDMNFGOM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2724420", Offset = "0x2723620", VA = "0x182724420")]
	public static ADNAHEJLLKN<T> IEGHMMKKFKE<T>(this T[] AOFIGDLFNLH) where T : notnull
	{
		return default(ADNAHEJLLKN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DefaultMember("Item")]
public sealed class KGBBLPEKBNF<T> : IDisposable, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HKBGLAIKAIG<T> LELKBKGFBNC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GIHIJMKOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2380", Offset = "0x3CB1580", VA = "0x183CB2380", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2410", Offset = "0x3CB1610", VA = "0x183CB2410")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2250", Offset = "0x3CB1450", VA = "0x183CB2250")]
	public static KGBBLPEKBNF<T> DHBNKMCPKNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C050", Offset = "0x3C4B250", VA = "0x183C4C050")]
	internal KGBBLPEKBNF([In] HKBGLAIKAIG<T> HMEKKAINJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2360", Offset = "0x3CB1560", VA = "0x183CB2360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB23F0", Offset = "0x3CB15F0", VA = "0x183CB23F0")]
	public void LINDBCMNKPH(int KMJOEPJMADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB23B0", Offset = "0x3CB15B0", VA = "0x183CB23B0", Slot = "8")]
	public HKBGLAIKAIG<T>.ADNAAIDKIKE GetEnumerator()
	{
		return default(HKBGLAIKAIG<T>.ADNAAIDKIKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2440", Offset = "0x3CB1640", VA = "0x183CB2440", Slot = "5")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2440", Offset = "0x3CB1640", VA = "0x183CB2440", Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NBMKDLCHCHO<T, U> : IEnumerable<T>, IEnumerable where U : JDKJGODELFL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U PFHNBIPOOLG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DDF2A0", Offset = "0x1DDE4A0", VA = "0x181DDF2A0")]
	internal NBMKDLCHCHO([In] U BJFMPKFKBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x37BF550", Offset = "0x37BE750", VA = "0x1837BF550", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x37BF550", Offset = "0x37BE750", VA = "0x1837BF550", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NFMBMBIHMOM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27AD6A0", Offset = "0x27AC8A0", VA = "0x1827AD6A0")]
	public static NBMKDLCHCHO<T, U> DHBNKMCPKNO<U>([In] U AOFIGDLFNLH) where U : JDKJGODELFL<T>
	{
		return default(NBMKDLCHCHO<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct FKOGJKIBHGK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal readonly U PFHNBIPOOLG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x37BF830", Offset = "0x37BEA30", VA = "0x1837BF830")]
	internal FKOGJKIBHGK([In] U BJFMPKFKBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37BF740", Offset = "0x37BE940", VA = "0x1837BF740", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37BF740", Offset = "0x37BE940", VA = "0x1837BF740", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JPJKEJLOKCM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x27AD6D0", Offset = "0x27AC8D0", VA = "0x1827AD6D0")]
	public static FKOGJKIBHGK<T, U> DHBNKMCPKNO<U>([In] U AOFIGDLFNLH) where U : IEnumerator<T>
	{
		return default(FKOGJKIBHGK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class MILFNGICOIM
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x293C760", Offset = "0x293B960", VA = "0x18293C760")]
	public static string JKFODKILDCK<T>(this IEnumerable<T> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x293F760", Offset = "0x293E960", VA = "0x18293F760")]
	public static string PADGNGKGOBH<T>(this IEnumerable<T> AOFIGDLFNLH, string NKACAMLFICE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class ANHJIBKJOMH
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2EADBD0", Offset = "0x2EACDD0", VA = "0x182EADBD0")]
	public static bool COJODDHOEJF<TSourceEnumerator, TSource>(this TSourceEnumerator AOFIGDLFNLH, [In] TSource KBNEJAIFICP) where TSourceEnumerator : JDKJGODELFL<TSource> where TSource : JHLFGBMKOFP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2EADE20", Offset = "0x2EAD020", VA = "0x182EADE20")]
	public static int MFFBEGJOFDL<TSourceEnumerator, TSource>(this TSourceEnumerator AOFIGDLFNLH, [In] TSource EKDDCPALANJ) where TSourceEnumerator : JDKJGODELFL<TSource> where TSource : JHLFGBMKOFP<TSource>
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JDKJGODELFL<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T KOOHOOFHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EKGPNEDBGOC<T> : JDKJGODELFL<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FNBIOHGHBBJ<T, U> : IEnumerable<T>, IEnumerable where U : EKGPNEDBGOC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U PFHNBIPOOLG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x37C2DF0", Offset = "0x37C1FF0", VA = "0x1837C2DF0")]
	internal FNBIOHGHBBJ([In] U BJFMPKFKBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x34C82D0", Offset = "0x34C74D0", VA = "0x1834C82D0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x37C2D60", Offset = "0x37C1F60", VA = "0x1837C2D60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x37C2D60", Offset = "0x37C1F60", VA = "0x1837C2D60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OJBECMFAEIF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27D5A30", Offset = "0x27D4C30", VA = "0x1827D5A30")]
	public static FNBIOHGHBBJ<T, U> DHBNKMCPKNO<U>([In] U AOFIGDLFNLH) where U : EKGPNEDBGOC<T>
	{
		return default(FNBIOHGHBBJ<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public readonly struct ADNAHEJLLKN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PDGLNKLNAJF : JDKJGODELFL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly T[] GJODOFBLNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int LAEFOIONEKA;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly T KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x419CAC0", Offset = "0x419BCC0", VA = "0x18419CAC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x419C400", Offset = "0x419B600", VA = "0x18419C400", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x419C830", Offset = "0x419BA30", VA = "0x18419C830", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x18D3A40", Offset = "0x18D2C40", VA = "0x1818D3A40")]
		private PDGLNKLNAJF(T[] AOFIGDLFNLH, int MBGANDEDPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x419C350", Offset = "0x419B550", VA = "0x18419C350")]
		public static PDGLNKLNAJF DHBNKMCPKNO(T[] AOFIGDLFNLH)
		{
			return default(PDGLNKLNAJF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E08EA0", Offset = "0x1E080A0", VA = "0x181E08EA0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E08ED0", Offset = "0x1E080D0", VA = "0x181E08ED0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly T[] GGCDMHJNLBF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OECJFLODMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3760460", Offset = "0x375F660", VA = "0x183760460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public T KFIAMJJGJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x287D810", Offset = "0x287CA10", VA = "0x18287D810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x93E850", Offset = "0x93DA50", VA = "0x18093E850")]
	internal ADNAHEJLLKN(T[] BLGDAGLONDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3838C30", Offset = "0x3837E30", VA = "0x183838C30")]
	public static ADNAHEJLLKN<T> NONABGLHMDJ()
	{
		return default(ADNAHEJLLKN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
	public IEnumerable<T> AENDONKDNMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3838A10", Offset = "0x3837C10", VA = "0x183838A10")]
	public ReadOnlySpan<T> HGBNKHFEIJO()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3838AA0", Offset = "0x3837CA0", VA = "0x183838AA0")]
	public NBMKDLCHCHO<T, ADNAHEJLLKN<T>.PDGLNKLNAJF> KOHNKMNJOFI()
	{
		return default(NBMKDLCHCHO<T, PDGLNKLNAJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3838980", Offset = "0x3837B80", VA = "0x183838980")]
	public PDGLNKLNAJF BNGPLCGGADA()
	{
		return default(PDGLNKLNAJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3838BB0", Offset = "0x3837DB0", VA = "0x183838BB0")]
	public IEnumerator<T> LEPKJMNOIOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3838CE0", Offset = "0x3837EE0", VA = "0x183838CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NFEDDJBIHBC
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x273B010", Offset = "0x273A210", VA = "0x18273B010")]
	public static ADNAHEJLLKN<T> PAKBPMHCJLJ<T>(params T[] BLGDAGLONDD) where T : notnull
	{
		return default(ADNAHEJLLKN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61E84C0", Offset = "0x61E76C0", VA = "0x1861E84C0")]
	public static Stream PKELCKNEIHI(this ADNAHEJLLKN<byte> AOFIGDLFNLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(HKBGLAIKAIG<>.NCHBNNKCOJP))]
public struct HKBGLAIKAIG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct ADNAAIDKIKE : EKGPNEDBGOC<T>, JDKJGODELFL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] ELNGFLOCHFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int PGHMDBACKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int LAEFOIONEKA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly T KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x3838860", Offset = "0x3837A60", VA = "0x183838860", Slot = "10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private readonly T CHPBLIBLOHG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x38380C0", Offset = "0x38372C0", VA = "0x1838380C0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x38381B0", Offset = "0x38373B0", VA = "0x1838381B0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3838420", Offset = "0x3837620", VA = "0x183838420", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x38387F0", Offset = "0x38379F0", VA = "0x1838387F0")]
		internal ADNAAIDKIKE(T[] CNMJLBIMKJD, int KMJOEPJMADC, int MBGANDEDPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3837F70", Offset = "0x3837170", VA = "0x183837F70")]
		public static ADNAAIDKIKE DHBNKMCPKNO(HKBGLAIKAIG<T> AOFIGDLFNLH)
		{
			return default(ADNAAIDKIKE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3486D70", Offset = "0x3485F70", VA = "0x183486D70", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x33FE260", Offset = "0x33FD460", VA = "0x1833FE260", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct COPJIAJAIMG : JDKJGODELFL<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ADNAAIDKIKE PFHNBIPOOLG;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public readonly T KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4BE7B60", Offset = "0x4BE6D60", VA = "0x184BE7B60", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4BE7910", Offset = "0x4BE6B10", VA = "0x184BE7910", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4BE7A20", Offset = "0x4BE6C20", VA = "0x184BE7A20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1DDF2A0", Offset = "0x1DDE4A0", VA = "0x181DDF2A0")]
		private COPJIAJAIMG([In] ADNAAIDKIKE BJFMPKFKBNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4BE76E0", Offset = "0x4BE68E0", VA = "0x184BE76E0")]
		public static COPJIAJAIMG DHBNKMCPKNO([In] HKBGLAIKAIG<T> AOFIGDLFNLH)
		{
			return default(COPJIAJAIMG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4BE77D0", Offset = "0x4BE69D0", VA = "0x184BE77D0", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4BE7810", Offset = "0x4BE6A10", VA = "0x184BE7810", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4BE7790", Offset = "0x4BE6990", VA = "0x184BE7790", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class NCHBNNKCOJP
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] ELNGFLOCHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int PGHMDBACKAF;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3974C60", Offset = "0x3973E60", VA = "0x183974C60")]
	public static HKBGLAIKAIG<T> DHBNKMCPKNO()
	{
		return default(HKBGLAIKAIG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3974D00", Offset = "0x3973F00", VA = "0x183974D00")]
	public static HKBGLAIKAIG<T> FDBAOPMDCCO(int ONEEJBCNCKG)
	{
		return default(HKBGLAIKAIG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x18D3A40", Offset = "0x18D2C40", VA = "0x1818D3A40")]
	internal HKBGLAIKAIG(T[] CNMJLBIMKJD, int KMJOEPJMADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3974DB0", Offset = "0x3973FB0", VA = "0x183974DB0", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NKEJEFNIKGA
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public delegate int KJAJCIGDAKK<TCtx, T>([In] TCtx GHJMNPMPIHD, T DEHAFGPDPHM, T FAFKEFEMLFH);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29D5350", Offset = "0x29D4550", VA = "0x1829D5350")]
	public static void CJPKHGMGMMP<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29D6A40", Offset = "0x29D5C40", VA = "0x1829D6A40")]
	public static string HFOBPPJGAGK<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x885BC0", VA = "0x1808869C0")]
	public static T[] CEGNNHCJKMO<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E095C0", Offset = "0x1E087C0", VA = "0x181E095C0")]
	public static T CEIMJGKDJPN<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH, int IBNKLDKLAGI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x29D5250", Offset = "0x29D4450", VA = "0x1829D5250")]
	public static T CGNFDLLANLP<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, int IBNKLDKLAGI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x29D57E0", Offset = "0x29D49E0", VA = "0x1829D57E0")]
	public static T EMEKKNKNNAC<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH, int IBNKLDKLAGI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29D8930", Offset = "0x29D7B30", VA = "0x1829D8930")]
	public static void HPPDEOLAJNB<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, int IBNKLDKLAGI, [In] T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29DAC70", Offset = "0x29D9E70", VA = "0x1829DAC70")]
	public static void LGCKMFCHFFE<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, int IBNKLDKLAGI, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20")]
	public static int NAJFOKPMGAH<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29D85C0", Offset = "0x29D77C0", VA = "0x1829D85C0")]
	public static ReadOnlySpan<T> HGBNKHFEIJO<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x29DCE30", Offset = "0x29DC030", VA = "0x1829DCE30")]
	public static T[] ODKPKGEPEME<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29D4FD0", Offset = "0x29D41D0", VA = "0x1829D4FD0")]
	public static T ADPEPDAGFDJ<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x29D8690", Offset = "0x29D7890", VA = "0x1829D8690")]
	public static T[] HKFEFOKMNHC<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29D5050", Offset = "0x29D4250", VA = "0x1829D5050")]
	public static ADNAHEJLLKN<T> CBBEBGLAGLP<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return default(ADNAHEJLLKN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29D5B30", Offset = "0x29D4D30", VA = "0x1829D5B30")]
	public static void GHBEENLPKLN<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, [In] T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29DCFC0", Offset = "0x29DC1C0", VA = "0x1829DCFC0")]
	public static void PMKKKGEOAKL<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x29D5460", Offset = "0x29D4660", VA = "0x1829D5460")]
	public static void CPGDDCDOCPB<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, int MBGANDEDPDN, [In] T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x29D58B0", Offset = "0x29D4AB0", VA = "0x1829D58B0")]
	public static void GEIHOAAAGMP<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, int MBGANDEDPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x29D4FF0", Offset = "0x29D41F0", VA = "0x1829D4FF0")]
	public static T APKOINPAKCA<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x29DB740", Offset = "0x29DA940", VA = "0x1829DB740")]
	public static void LINDBCMNKPH<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, int KMJOEPJMADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x29D9A60", Offset = "0x29D8C60", VA = "0x1829D9A60")]
	private static void KEBPPKLCJLB<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, int ONEEJBCNCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x29D5600", Offset = "0x29D4800", VA = "0x1829D5600")]
	public static void DBHKOJLPIHJ<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x29DCAF0", Offset = "0x29DBCF0", VA = "0x1829DCAF0")]
	public static HKBGLAIKAIG<T> OALMEMACFAC<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH, PBAGKGCCFNL<T, T> INKEMIKMKCD)
	{
		return default(HKBGLAIKAIG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29DCA50", Offset = "0x29DBC50", VA = "0x1829DCA50")]
	public static bool LLOCFJHBFKJ<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH, [In] T EKDDCPALANJ) where T : JHLFGBMKOFP<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x286E130", Offset = "0x286D330", VA = "0x18286E130")]
	public static bool OIOOJDHLJDP<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x29D5740", Offset = "0x29D4940", VA = "0x1829D5740")]
	public static bool EKFEDMDJLPM<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH, int IBNKLDKLAGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x29D5710", Offset = "0x29D4910", VA = "0x1829D5710")]
	public static void DOEIPDDHCOH<T, TCtx>(this HKBGLAIKAIG<T> AOFIGDLFNLH, [In] TCtx GHJMNPMPIHD, KJAJCIGDAKK<TCtx, T> HEMEOLGKLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x29DD150", Offset = "0x29DC350", VA = "0x1829DD150")]
	private static void PNDNOHKDBMH<T, TCtx>(HKBGLAIKAIG<T> AOFIGDLFNLH, [In] TCtx GHJMNPMPIHD, KJAJCIGDAKK<TCtx, T> HEMEOLGKLFC, int EIKHAJLPDLB, int DFFAKDFLBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x29DA7C0", Offset = "0x29D99C0", VA = "0x1829DA7C0")]
	private static int KIPLKMKCHPC<T, TCtx>(HKBGLAIKAIG<T> AOFIGDLFNLH, [In] TCtx GHJMNPMPIHD, KJAJCIGDAKK<TCtx, T> HEMEOLGKLFC, int EIKHAJLPDLB, int DFFAKDFLBDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2646690", Offset = "0x2645890", VA = "0x182646690")]
	public static HKBGLAIKAIG<T>.COPJIAJAIMG LEPKJMNOIOO<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return default(HKBGLAIKAIG<T>.COPJIAJAIMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2646690", Offset = "0x2645890", VA = "0x182646690")]
	public static HKBGLAIKAIG<T>.ADNAAIDKIKE OAMKJMELJIL<T>(this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return default(HKBGLAIKAIG<T>.ADNAAIDKIKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x28E81B0", Offset = "0x28E73B0", VA = "0x1828E81B0")]
	public static NBMKDLCHCHO<T, HKBGLAIKAIG<T>.COPJIAJAIMG> BGLPBHHGBFD<T>([In] this HKBGLAIKAIG<T> AOFIGDLFNLH)
	{
		return default(NBMKDLCHCHO<T, HKBGLAIKAIG<T>.COPJIAJAIMG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal static class LAAEMOADGJM
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2906980", Offset = "0x2905B80", VA = "0x182906980")]
	public static T[] HLMOGEBCCMD<T>(int ANCJPCFOHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620")]
	public static void HKDCIEJDFNB<T>(T[] BLGDAGLONDD)
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
