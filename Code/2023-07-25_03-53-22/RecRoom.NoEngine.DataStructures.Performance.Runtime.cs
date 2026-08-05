using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x730FCC0", Offset = "0x730ECC0", VA = "0x18730FCC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB40", Offset = "0xA3EB40", VA = "0x180A3FB40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCF9C40", Offset = "0xCF8C40", VA = "0x180CF9C40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MDJHFGKKGJP<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T LMEBIHANEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class JMEJKFOAEMI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x248A0A0", Offset = "0x24890A0", VA = "0x18248A0A0")]
	public static string OOGAAHNOAGN<T>(this IEnumerable<T> FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24815F0", Offset = "0x24805F0", VA = "0x1824815F0")]
	public static string CNFHBOMDBFK<T>(this IEnumerable<T> FKGCCPKFEDE, string MIKKAKKFEKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PLOLFEHDFIB<T, U> : IEnumerable<T>, IEnumerable where U : GDAHGIMPCEO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly U JLBLNNKDKDK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2063AA0", Offset = "0x2062AA0", VA = "0x182063AA0")]
	internal PLOLFEHDFIB(in U GMJKLGDIAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x12EC250", Offset = "0x12EB250", VA = "0x1812EC250", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2063970", Offset = "0x2062970", VA = "0x182063970", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2063970", Offset = "0x2062970", VA = "0x182063970", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IFPGINJOJJC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7140", Offset = "0x1FC6140", VA = "0x181FC7140")]
	public static PLOLFEHDFIB<T, U> DAABCIFNKOF<U>(in U FKGCCPKFEDE) where U : GDAHGIMPCEO<T>
	{
		return default(PLOLFEHDFIB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OGOIKGLKEFB
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2E1B6A0", Offset = "0x2E1A6A0", VA = "0x182E1B6A0")]
	public static bool AODIHEAACOB<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator FKGCCPKFEDE, in TArgs CIIMHINGMLG, in FPHDJGJHJAK<TArgs, TSource, bool> MMKCMBDLNID) where TSourceEnumerator : MDJHFGKKGJP<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x335D9F0", Offset = "0x335C9F0", VA = "0x18335D9F0")]
	public static int LNJKPJHCGII<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator FKGCCPKFEDE, in TArgs CIIMHINGMLG, FPHDJGJHJAK<TArgs, TSource, bool> MMKCMBDLNID) where TSourceEnumerator : MDJHFGKKGJP<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x335D6A0", Offset = "0x335C6A0", VA = "0x18335D6A0")]
	public static bool KEMABOLGKJK<TSourceEnumerator, TSource>(this TSourceEnumerator FKGCCPKFEDE, in TSource JFJFAONKKJC) where TSourceEnumerator : MDJHFGKKGJP<TSource> where TSource : EIDOCAAFNMH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x335D350", Offset = "0x335C350", VA = "0x18335D350")]
	public static int GBMMMJLAAPB<TSourceEnumerator, TSource>(this TSourceEnumerator FKGCCPKFEDE, in TSource CKDFGEALFAK) where TSourceEnumerator : MDJHFGKKGJP<TSource> where TSource : EIDOCAAFNMH<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x335DCA0", Offset = "0x335CCA0", VA = "0x18335DCA0")]
	public static KLHGIIIMFNM<TSourceEnumerator, TSource, TResult> NPGBPIPGAJN<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator FKGCCPKFEDE, LJGIIFLGMBL<TSource, TResult> EHOLPOGLFND) where TSourceEnumerator : FDOMKEHADMH, MDJHFGKKGJP<TSource>
	{
		return default(KLHGIIIMFNM<TSourceEnumerator, TSource, TResult>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x335DCA0", Offset = "0x335CCA0", VA = "0x18335DCA0")]
	public static LHPJLJGDIHO<TSourceEnumerator, TSource, TResult> MLPLLKHJPDP<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator FKGCCPKFEDE, Func<TSource, TResult> EHOLPOGLFND) where TSourceEnumerator : FDOMKEHADMH, IEnumerator<TSource>
	{
		return default(LHPJLJGDIHO<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OMHIIPHFCFP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x58B3170", Offset = "0x58B2170", VA = "0x1858B3170")]
	public static bool OENEIFGKAME<TSourceEnumerator>(TSourceEnumerator FKGCCPKFEDE) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x58A6250", Offset = "0x58A5250", VA = "0x1858A6250")]
	public static T GCHJDJFJNCF<TSourceEnumerator>(TSourceEnumerator FKGCCPKFEDE) where TSourceEnumerator : MDJHFGKKGJP<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x58AA140", Offset = "0x58A9140", VA = "0x1858AA140")]
	public static T[] KKJADKFEMHO<TSourceEnumerator>(TSourceEnumerator FKGCCPKFEDE) where TSourceEnumerator : FDOMKEHADMH, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x58B2F30", Offset = "0x58B1F30", VA = "0x1858B2F30")]
	public static T MGFMEHEELHL<TSourceEnumerator>(TSourceEnumerator FKGCCPKFEDE) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct GKEEONMOPPL<T, U> : IEnumerable<T>, IEnumerable where U : MDJHFGKKGJP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal readonly U JLBLNNKDKDK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	internal GKEEONMOPPL(in U GMJKLGDIAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x20639F0", Offset = "0x20629F0", VA = "0x1820639F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x20639F0", Offset = "0x20629F0", VA = "0x1820639F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OEPOBKHMGOF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC7070", Offset = "0x1FC6070", VA = "0x181FC7070")]
	public static GKEEONMOPPL<T, U> DAABCIFNKOF<U>(in U FKGCCPKFEDE) where U : MDJHFGKKGJP<T>
	{
		return default(GKEEONMOPPL<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DefaultMember("Item")]
public readonly struct FOJMHCPEJAO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AKFGJGPFAFN : FDOMKEHADMH, MDJHFGKKGJP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly T[] HGIJKCPCNBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int DKJDNAPIAGE;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly int NMOEOEAONON
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x326D5D0", Offset = "0x326C5D0", VA = "0x18326D5D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public readonly T LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x340CD60", Offset = "0x340BD60", VA = "0x18340CD60", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x340C8D0", Offset = "0x340B8D0", VA = "0x18340C8D0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		readonly object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x340CAF0", Offset = "0x340BAF0", VA = "0x18340CAF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAA0C70", Offset = "0xA9FC70", VA = "0x180AA0C70")]
		private AKFGJGPFAFN(T[] FKGCCPKFEDE, int CCELBNKPBGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x340C710", Offset = "0x340B710", VA = "0x18340C710")]
		public static AKFGJGPFAFN DAABCIFNKOF(T[] FKGCCPKFEDE)
		{
			return default(AKFGJGPFAFN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x340C760", Offset = "0x340B760", VA = "0x18340C760", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2872560", Offset = "0x2871560", VA = "0x182872560", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly T[] MCAELBCBPAG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NKLAFIEKONA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x326D5D0", Offset = "0x326C5D0", VA = "0x18326D5D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public T CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2477710", Offset = "0x2476710", VA = "0x182477710")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0xA2BF10", Offset = "0xA2AF10", VA = "0x180A2BF10")]
	internal FOJMHCPEJAO(T[] GJAKHOONFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3561540", Offset = "0x3560540", VA = "0x183561540")]
	public static FOJMHCPEJAO<T> OINHJLGKBEA()
	{
		return default(FOJMHCPEJAO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
	public IEnumerable<T> MPNIPFEAALI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3561280", Offset = "0x3560280", VA = "0x183561280")]
	public ReadOnlySpan<T> AHBLHLKPCAG()
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3561310", Offset = "0x3560310", VA = "0x183561310")]
	public GKEEONMOPPL<T, FOJMHCPEJAO<T>.AKFGJGPFAFN> BBPEIMGLDLB()
	{
		return default(GKEEONMOPPL<T, AKFGJGPFAFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x35614B0", Offset = "0x35604B0", VA = "0x1835614B0")]
	public AKFGJGPFAFN MLLICCPDLJM()
	{
		return default(AKFGJGPFAFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3561430", Offset = "0x3560430", VA = "0x183561430")]
	public IEnumerator<T> EFCEFGGNIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x35615F0", Offset = "0x35605F0", VA = "0x1835615F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HMBLPDOADHJ
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1076A60", Offset = "0x1075A60", VA = "0x181076A60")]
	public static FOJMHCPEJAO<T> EJOJEPHIGMJ<T>(params T[] GJAKHOONFBO) where T : notnull
	{
		return default(FOJMHCPEJAO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FDOMKEHADMH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LIKCBFIDFEB<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly U JLBLNNKDKDK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2501E30", Offset = "0x2500E30", VA = "0x182501E30")]
	internal LIKCBFIDFEB(in U GMJKLGDIAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x12EC200", Offset = "0x12EB200", VA = "0x1812EC200", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2501A40", Offset = "0x2500A40", VA = "0x182501A40", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2501A40", Offset = "0x2500A40", VA = "0x182501A40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class MOHJIGAOMKO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6FF0", Offset = "0x1FC5FF0", VA = "0x181FC6FF0")]
	public static LIKCBFIDFEB<T, U> DAABCIFNKOF<U>(in U FKGCCPKFEDE) where U : IEnumerator<T>
	{
		return default(LIKCBFIDFEB<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public sealed class JAKAGOLMCBI<T> : IDisposable, FDOMKEHADMH, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FPJAMJKOOAE<T> AIKPEDLMGAO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x36CF630", Offset = "0x36CE630", VA = "0x1836CF630", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x36CF920", Offset = "0x36CE920", VA = "0x1836CF920")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36CF790", Offset = "0x36CE790", VA = "0x1836CF790")]
	public static JAKAGOLMCBI<T> DAABCIFNKOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x36CF670", Offset = "0x36CE670", VA = "0x1836CF670")]
	public static JAKAGOLMCBI<T> CKILGDPKBPB(int OENKBEGLEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x36CF9B0", Offset = "0x36CE9B0", VA = "0x1836CF9B0")]
	internal JAKAGOLMCBI(in FPJAMJKOOAE<T> HBKAFCIHEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x36CF8A0", Offset = "0x36CE8A0", VA = "0x1836CF8A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x36CF650", Offset = "0x36CE650", VA = "0x1836CF650")]
	public void AMLBOIMHPGF(in T CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x36CF900", Offset = "0x36CE900", VA = "0x1836CF900")]
	public void ICOJIPJDIAM(int LEOAEOJMCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x36CF8C0", Offset = "0x36CE8C0", VA = "0x1836CF8C0", Slot = "8")]
	public FPJAMJKOOAE<T>.CHPFIPINOHO GetEnumerator()
	{
		return default(FPJAMJKOOAE<T>.CHPFIPINOHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x36CF940", Offset = "0x36CE940", VA = "0x1836CF940", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x36CF940", Offset = "0x36CE940", VA = "0x1836CF940", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DebuggerTypeProxy(typeof(FPJAMJKOOAE<>.HBEGBJKNLLN))]
public struct FPJAMJKOOAE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct CHPFIPINOHO : FDOMKEHADMH, GDAHGIMPCEO<T>, MDJHFGKKGJP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly T[] HJMPEFGLEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly int PPIOMJAHBKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int DKJDNAPIAGE;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly int NMOEOEAONON
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA2BF90", Offset = "0xA2AF90", VA = "0x180A2BF90", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public readonly T LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2185880", Offset = "0x2184880", VA = "0x182185880", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private readonly T OPPPHAEMEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2184730", Offset = "0x2183730", VA = "0x182184730", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2184AF0", Offset = "0x2183AF0", VA = "0x182184AF0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x21850C0", Offset = "0x21840C0", VA = "0x1821850C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1F65ED0", Offset = "0x1F64ED0", VA = "0x181F65ED0")]
		internal CHPFIPINOHO(T[] HACMILLGFCL, int LEOAEOJMCHD, int CCELBNKPBGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x21846D0", Offset = "0x21836D0", VA = "0x1821846D0")]
		public static CHPFIPINOHO DAABCIFNKOF(ref FPJAMJKOOAE<T> FKGCCPKFEDE)
		{
			return default(CHPFIPINOHO);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2184AD0", Offset = "0x2183AD0", VA = "0x182184AD0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2184AE0", Offset = "0x2183AE0", VA = "0x182184AE0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct IMNFKKLPEFL : FDOMKEHADMH, MDJHFGKKGJP<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CHPFIPINOHO JLBLNNKDKDK;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public int NMOEOEAONON
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xBFCDF0", Offset = "0xBFBDF0", VA = "0x180BFCDF0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public readonly T LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xBFDC40", Offset = "0xBFCC40", VA = "0x180BFDC40", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xBFCFA0", Offset = "0xBFBFA0", VA = "0x180BFCFA0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xBFD4A0", Offset = "0xBFC4A0", VA = "0x180BFD4A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
		private IMNFKKLPEFL(in CHPFIPINOHO GMJKLGDIAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xBFCE20", Offset = "0xBFBE20", VA = "0x180BFCE20")]
		public static IMNFKKLPEFL DAABCIFNKOF(in FPJAMJKOOAE<T> FKGCCPKFEDE)
		{
			return default(IMNFKKLPEFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xBFCF20", Offset = "0xBFBF20", VA = "0x180BFCF20", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xBFCF60", Offset = "0xBFBF60", VA = "0x180BFCF60", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xBFCEE0", Offset = "0xBFBEE0", VA = "0x180BFCEE0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class HBEGBJKNLLN
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal T[] HJMPEFGLEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal int PPIOMJAHBKJ;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x31B9CC0", Offset = "0x31B8CC0", VA = "0x1831B9CC0")]
	public static FPJAMJKOOAE<T> DAABCIFNKOF()
	{
		return default(FPJAMJKOOAE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x31B9BE0", Offset = "0x31B8BE0", VA = "0x1831B9BE0")]
	public static FPJAMJKOOAE<T> CKILGDPKBPB(int OENKBEGLEDJ)
	{
		return default(FPJAMJKOOAE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xAA0C70", Offset = "0xA9FC70", VA = "0x180AA0C70")]
	internal FPJAMJKOOAE(T[] HACMILLGFCL, int LEOAEOJMCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2040210", Offset = "0x203F210", VA = "0x182040210", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BNNEJOHLKHA
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x24FADF0", Offset = "0x24F9DF0", VA = "0x1824FADF0")]
	public static void PCLJFJKFDHP<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24F5E90", Offset = "0x24F4E90", VA = "0x1824F5E90")]
	public static string AMFAMHHBMFB<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
	public static T[] OCEPAKHLMCL<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24F94C0", Offset = "0x24F84C0", VA = "0x1824F94C0")]
	public static T FLFDNJDANPO<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE, int KJPGMJFNNHE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24F94C0", Offset = "0x24F84C0", VA = "0x1824F94C0")]
	public static T GAIMOCMLJNG<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE, int KJPGMJFNNHE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA2BF90", Offset = "0xA2AF90", VA = "0x180A2BF90")]
	public static int KPAEDHEHGJD<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24F2BF0", Offset = "0x24F1BF0", VA = "0x1824F2BF0")]
	public static ReadOnlySpan<T> AHBLHLKPCAG<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24F98C0", Offset = "0x24F88C0", VA = "0x1824F98C0")]
	public static ReadOnlyMemory<T> HLNLPEPPAOF<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24F7510", Offset = "0x24F6510", VA = "0x1824F7510")]
	public static void AMLBOIMHPGF<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE, in T CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x24F9640", Offset = "0x24F8640", VA = "0x1824F9640")]
	public static void FLPIEKKCHOC<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE, int CCELBNKPBGB, in T CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x24FAD20", Offset = "0x24F9D20", VA = "0x1824FAD20")]
	public static void KPMKGKJAOFN<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE, int CCELBNKPBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24FA1A0", Offset = "0x24F91A0", VA = "0x1824FA1A0")]
	public static void ICOJIPJDIAM<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE, int LEOAEOJMCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x24F8460", Offset = "0x24F7460", VA = "0x1824F8460")]
	private static void FJHJLPDJOMF<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE, int OENKBEGLEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24FAE60", Offset = "0x24F9E60", VA = "0x1824FAE60")]
	public static void PPNJFNMKMCA<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24FAD60", Offset = "0x24F9D60", VA = "0x1824FAD60")]
	public static bool NOOBEBIILLH<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE, in T CKDFGEALFAK) where T : EIDOCAAFNMH<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x24F7900", Offset = "0x24F6900", VA = "0x1824F7900")]
	public static bool EDGMLIFNIMM<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24FACF0", Offset = "0x24F9CF0", VA = "0x1824FACF0")]
	public static bool JMLOIBOBBGO<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE, int KJPGMJFNNHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x16E8C20", Offset = "0x16E7C20", VA = "0x1816E8C20")]
	public static FPJAMJKOOAE<T>.IMNFKKLPEFL EFCEFGGNIIL<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
		return default(FPJAMJKOOAE<T>.IMNFKKLPEFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x16E8C20", Offset = "0x16E7C20", VA = "0x1816E8C20")]
	public static FPJAMJKOOAE<T>.CHPFIPINOHO OGOLNADAIJI<T>(this ref FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
		return default(FPJAMJKOOAE<T>.CHPFIPINOHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x16E8B30", Offset = "0x16E7B30", VA = "0x1816E8B30")]
	public static GKEEONMOPPL<T, FPJAMJKOOAE<T>.IMNFKKLPEFL> IHHJGJAPJPG<T>(this in FPJAMJKOOAE<T> FKGCCPKFEDE)
	{
		return default(GKEEONMOPPL<T, FPJAMJKOOAE<T>.IMNFKKLPEFL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KLHGIIIMFNM<TSourceEnumerator, TSource, TResult> : FDOMKEHADMH, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : FDOMKEHADMH, MDJHFGKKGJP<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private TSourceEnumerator HGIJKCPCNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LJGIIFLGMBL<TSource, TResult> PLNDBLNDJID;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public readonly int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x30DA360", Offset = "0x30D9360", VA = "0x1830DA360", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public readonly TResult LMEBIHANEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x30DAAC0", Offset = "0x30D9AC0", VA = "0x1830DAAC0", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x30DAA40", Offset = "0x30D9A40", VA = "0x1830DAA40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x12EAE20", Offset = "0x12E9E20", VA = "0x1812EAE20")]
	internal KLHGIIIMFNM(in TSourceEnumerator FKGCCPKFEDE, LJGIIFLGMBL<TSource, TResult> EHOLPOGLFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x30DA710", Offset = "0x30D9710", VA = "0x1830DA710", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x30DA910", Offset = "0x30D9910", VA = "0x1830DA910", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x30DA570", Offset = "0x30D9570", VA = "0x1830DA570", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LHPJLJGDIHO<TSourceEnumerator, TSource, TResult> : FDOMKEHADMH, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : FDOMKEHADMH, IEnumerator<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private TSourceEnumerator HGIJKCPCNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Func<TSource, TResult> PLNDBLNDJID;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public readonly int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2500F70", Offset = "0x24FFF70", VA = "0x182500F70", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public readonly TResult LMEBIHANEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2501630", Offset = "0x2500630", VA = "0x182501630", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2501460", Offset = "0x2500460", VA = "0x182501460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x12EAE20", Offset = "0x12E9E20", VA = "0x1812EAE20")]
	internal LHPJLJGDIHO(in TSourceEnumerator FKGCCPKFEDE, Func<TSource, TResult> EHOLPOGLFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2501220", Offset = "0x2500220", VA = "0x182501220", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2501340", Offset = "0x2500340", VA = "0x182501340", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2501100", Offset = "0x2500100", VA = "0x182501100", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GDAHGIMPCEO<T> : MDJHFGKKGJP<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AAEEHEDHCEE
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xD02940", Offset = "0xD01940", VA = "0x180D02940")]
	public static FOJMHCPEJAO<T> JJAJCJFCIJK<T>(this T[] FKGCCPKFEDE)
	{
		return default(FOJMHCPEJAO<T>);
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
