using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IIPJHKKACOH<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T NIBFGHDNPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class JPMHLNOPBBB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2E45E90", Offset = "0x2E44A90", VA = "0x182E45E90")]
	public static string LFGBFEHHMOI<T>(this IEnumerable<T> GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x238E870", Offset = "0x238D470", VA = "0x18238E870")]
	public static string KDAOIFBEKHL<T>(this IEnumerable<T> GPOCLJBKMHA, string BHBIFNNNNHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct JANGGDAFHFH<T, U> : IEnumerable<T>, IEnumerable where U : FHJADMMHNIM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly U HANEONFHFAJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3523AE0", Offset = "0x35226E0", VA = "0x183523AE0")]
	internal JANGGDAFHFH(in U ILKMAKIEBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2905170", Offset = "0x2903D70", VA = "0x182905170", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35236D0", Offset = "0x35222D0", VA = "0x1835236D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x35236D0", Offset = "0x35222D0", VA = "0x1835236D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FIKCEAOIPMP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2469A30", Offset = "0x2468630", VA = "0x182469A30")]
	public static JANGGDAFHFH<T, U> DOBPLOGGNLM<U>(in U GPOCLJBKMHA) where U : FHJADMMHNIM<T>
	{
		return default(JANGGDAFHFH<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NIEILNLDBIN
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B42440", Offset = "0x2B41040", VA = "0x182B42440")]
	public static bool KAJDJHOEJCN<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator GPOCLJBKMHA, in TArgs PFFFGKKOEPM, in CLGHNELLHKC<TArgs, TSource, bool> GKMOGNDGOID) where TSourceEnumerator : IIPJHKKACOH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2B41850", Offset = "0x2B40450", VA = "0x182B41850")]
	public static int AECMCFGEGIP<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator GPOCLJBKMHA, in TArgs PFFFGKKOEPM, CLGHNELLHKC<TArgs, TSource, bool> GKMOGNDGOID) where TSourceEnumerator : IIPJHKKACOH<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B420F0", Offset = "0x2B40CF0", VA = "0x182B420F0")]
	public static bool IGFPFMDBKDG<TSourceEnumerator, TSource>(this TSourceEnumerator GPOCLJBKMHA, in TSource FHJBBMIILLG) where TSourceEnumerator : IIPJHKKACOH<TSource> where TSource : KELNLDHHLCN<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2B41D00", Offset = "0x2B40900", VA = "0x182B41D00")]
	public static int CEKIKANBECN<TSourceEnumerator, TSource>(this TSourceEnumerator GPOCLJBKMHA, in TSource ECNGHFJBIJL) where TSourceEnumerator : IIPJHKKACOH<TSource> where TSource : KELNLDHHLCN<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B42060", Offset = "0x2B40C60", VA = "0x182B42060")]
	public static IIKOGEMMEMD<TSourceEnumerator, TSource, TResult> GMMOOLAGELK<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator GPOCLJBKMHA, MLBPKFAHLJI<TSource, TResult> PEBLDEGHPBH) where TSourceEnumerator : IOPFDFMJPAA, IIPJHKKACOH<TSource>
	{
		return default(IIKOGEMMEMD<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class LMMBPENCMPC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2DC7070", Offset = "0x2DC5C70", VA = "0x182DC7070")]
	public static bool CENKBDLFCPA<TSourceEnumerator>(TSourceEnumerator GPOCLJBKMHA) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3B50", Offset = "0x2DD2750", VA = "0x182DD3B50")]
	public static T JDDKPBGOBII<TSourceEnumerator>(TSourceEnumerator GPOCLJBKMHA) where TSourceEnumerator : IIPJHKKACOH<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2DCAC30", Offset = "0x2DC9830", VA = "0x182DCAC30")]
	public static T[] HPGILJCEJMI<TSourceEnumerator>(TSourceEnumerator GPOCLJBKMHA) where TSourceEnumerator : IOPFDFMJPAA, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2DC7190", Offset = "0x2DC5D90", VA = "0x182DC7190")]
	public static T DOJDJBAJAIJ<TSourceEnumerator>(TSourceEnumerator GPOCLJBKMHA) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct PPJALHMGNEF<T, U> : IEnumerable<T>, IEnumerable where U : IIPJHKKACOH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly U HANEONFHFAJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EEC0", Offset = "0x1D5DAC0", VA = "0x181D5EEC0")]
	internal PPJALHMGNEF(in U ILKMAKIEBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xE90DB0", Offset = "0xE8F9B0", VA = "0x180E90DB0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2D478B0", Offset = "0x2D464B0", VA = "0x182D478B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2D478B0", Offset = "0x2D464B0", VA = "0x182D478B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PBJLCFKGJEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2469A60", Offset = "0x2468660", VA = "0x182469A60")]
	public static PPJALHMGNEF<T, U> DOBPLOGGNLM<U>(in U GPOCLJBKMHA) where U : IIPJHKKACOH<T>
	{
		return default(PPJALHMGNEF<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct KOAFLFAMJNA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct COOLBPMHJCK : IOPFDFMJPAA, IIPJHKKACOH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] EEHMMFOELDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private int PCBJJFMOCKL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public readonly int PLEPIEDOEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1037C50", Offset = "0x1036850", VA = "0x181037C50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public readonly T NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x30BD950", Offset = "0x30BC550", VA = "0x1830BD950", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x30BD900", Offset = "0x30BC500", VA = "0x1830BD900", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x30BD900", Offset = "0x30BC500", VA = "0x1830BD900", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC233B0", Offset = "0xC21FB0", VA = "0x180C233B0")]
		private COOLBPMHJCK(T[] GPOCLJBKMHA, int NHHNPPKPBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x30BD880", Offset = "0x30BC480", VA = "0x1830BD880")]
		public static COOLBPMHJCK DOBPLOGGNLM(T[] GPOCLJBKMHA)
		{
			return default(COOLBPMHJCK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x30BD8D0", Offset = "0x30BC4D0", VA = "0x1830BD8D0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2E6B230", Offset = "0x2E69E30", VA = "0x182E6B230", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly T[] CCLNFBILFMJ;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xB1CC20", Offset = "0xB1B820", VA = "0x180B1CC20")]
	internal KOAFLFAMJNA(T[] EABDNHJFDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4034000", Offset = "0x4032C00", VA = "0x184034000")]
	public COOLBPMHJCK MEOEHOBEEMI()
	{
		return default(COOLBPMHJCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x40340A0", Offset = "0x4032CA0", VA = "0x1840340A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HANHOEDCIGP
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1750BB0", Offset = "0x174F7B0", VA = "0x181750BB0")]
	public static KOAFLFAMJNA<T> DOBPLOGGNLM<T>(params T[] EABDNHJFDCB)
	{
		return default(KOAFLFAMJNA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1037C50", Offset = "0x1036850", VA = "0x181037C50")]
	public static int GDMIMHEELLK<T>(this in KOAFLFAMJNA<T> GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2917A30", Offset = "0x2916630", VA = "0x182917A30")]
	public static T PNBJHLBKMLC<T>(this in KOAFLFAMJNA<T> GPOCLJBKMHA, int NHHNPPKPBIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29179D0", Offset = "0x29165D0", VA = "0x1829179D0")]
	public static PPJALHMGNEF<T, KOAFLFAMJNA<T>.COOLBPMHJCK> GFDBFEBJIGA<T>(this in KOAFLFAMJNA<T> GPOCLJBKMHA)
	{
		return default(PPJALHMGNEF<T, KOAFLFAMJNA<T>.COOLBPMHJCK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IOPFDFMJPAA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2E5E2B802E5D90", Offset = "0x0", VA = "0x2E5E2D002E5D90", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct PAGIIOFCIGM<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U HANEONFHFAJ;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3523AE0", Offset = "0x35226E0", VA = "0x183523AE0")]
	internal PAGIIOFCIGM(in U ILKMAKIEBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2905170", Offset = "0x2903D70", VA = "0x182905170", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x35236D0", Offset = "0x35222D0", VA = "0x1835236D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x35236D0", Offset = "0x35222D0", VA = "0x1835236D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DDCPEHDAMKH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2469A30", Offset = "0x2468630", VA = "0x182469A30")]
	public static PAGIIOFCIGM<T, U> DOBPLOGGNLM<U>(in U GPOCLJBKMHA) where U : IEnumerator<T>
	{
		return default(PAGIIOFCIGM<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
public sealed class ICFCCKCCBJO<T> : IDisposable, IOPFDFMJPAA, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private CAIIANFGHKN<T> GFPGLPPHLKB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4757630", Offset = "0x4756230", VA = "0x184757630", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public T OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x47574C0", Offset = "0x47560C0", VA = "0x1847574C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4757390", Offset = "0x4755F90", VA = "0x184757390")]
	public static ICFCCKCCBJO<T> DOBPLOGGNLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x47574E0", Offset = "0x47560E0", VA = "0x1847574E0")]
	public static ICFCCKCCBJO<T> FDPJGLGFDBC(int CABFJBCMJEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47576E0", Offset = "0x47562E0", VA = "0x1847576E0")]
	internal ICFCCKCCBJO(in CAIIANFGHKN<T> NHIFGJKHMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x47574A0", Offset = "0x47560A0", VA = "0x1847574A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4757370", Offset = "0x4755F70", VA = "0x184757370")]
	public void CAILCKFFJIK(in T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4757650", Offset = "0x4756250", VA = "0x184757650")]
	public void PHLJIKJKNFC(int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x47575F0", Offset = "0x47561F0", VA = "0x1847575F0", Slot = "8")]
	public CAIIANFGHKN<T>.EIDPLIPCLGL GetEnumerator()
	{
		return default(CAIIANFGHKN<T>.EIDPLIPCLGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4757670", Offset = "0x4756270", VA = "0x184757670", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4757670", Offset = "0x4756270", VA = "0x184757670", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DebuggerTypeProxy(typeof(CAIIANFGHKN<>.CLPPDOAENIK))]
public struct CAIIANFGHKN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct EIDPLIPCLGL : IOPFDFMJPAA, FHJADMMHNIM<T>, IIPJHKKACOH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly T[] MDOGAHBBCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int LFLKNDBOEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int PCBJJFMOCKL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly int PLEPIEDOEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA81DA0", Offset = "0xA809A0", VA = "0x180A81DA0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x328D450", Offset = "0x328C050", VA = "0x18328D450", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T PKJHOKPLODF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x328C3A0", Offset = "0x328AFA0", VA = "0x18328C3A0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x328CA30", Offset = "0x328B630", VA = "0x18328CA30", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x328CD10", Offset = "0x328B910", VA = "0x18328CD10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xE5EA50", Offset = "0xE5D650", VA = "0x180E5EA50")]
		internal EIDPLIPCLGL(T[] IHGFGANOELJ, int FGHOJPFDCIA, int NHHNPPKPBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x328C340", Offset = "0x328AF40", VA = "0x18328C340")]
		public static EIDPLIPCLGL DOBPLOGGNLM(ref CAIIANFGHKN<T> GPOCLJBKMHA)
		{
			return default(EIDPLIPCLGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2E69170", Offset = "0x2E67D70", VA = "0x182E69170", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2E688B0", Offset = "0x2E674B0", VA = "0x182E688B0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct HEBKGEELNGF : IOPFDFMJPAA, IIPJHKKACOH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private EIDPLIPCLGL HANEONFHFAJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int PLEPIEDOEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3331650", Offset = "0x3330250", VA = "0x183331650", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public readonly T NIBFGHDNPCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3332410", Offset = "0x3331010", VA = "0x183332410", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3331700", Offset = "0x3330300", VA = "0x183331700", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3331CC0", Offset = "0x33308C0", VA = "0x183331CC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EEC0", Offset = "0x1D5DAC0", VA = "0x181D5EEC0")]
		private HEBKGEELNGF(in EIDPLIPCLGL ILKMAKIEBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3331550", Offset = "0x3330150", VA = "0x183331550")]
		public static HEBKGEELNGF DOBPLOGGNLM(in CAIIANFGHKN<T> GPOCLJBKMHA)
		{
			return default(HEBKGEELNGF);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3331680", Offset = "0x3330280", VA = "0x183331680", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x33316C0", Offset = "0x33302C0", VA = "0x1833316C0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3331610", Offset = "0x3330210", VA = "0x183331610", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class CLPPDOAENIK
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal T[] MDOGAHBBCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal int LFLKNDBOEHB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2959970", Offset = "0x2958570", VA = "0x182959970")]
	public static CAIIANFGHKN<T> DOBPLOGGNLM()
	{
		return default(CAIIANFGHKN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2959A40", Offset = "0x2958640", VA = "0x182959A40")]
	public static CAIIANFGHKN<T> FDPJGLGFDBC(int CABFJBCMJEP)
	{
		return default(CAIIANFGHKN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xC233B0", Offset = "0xC21FB0", VA = "0x180C233B0")]
	internal CAIIANFGHKN(T[] IHGFGANOELJ, int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EE40", Offset = "0x1D5DA40", VA = "0x181D5EE40", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LJGKAMDDHNB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x30876A0", Offset = "0x30862A0", VA = "0x1830876A0")]
	public static void ENFMBIKBCAA<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3087B30", Offset = "0x3086730", VA = "0x183087B30")]
	public static string JJEALMMFPOM<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8638C0", Offset = "0x8624C0", VA = "0x1808638C0")]
	public static T[] KLPBCCOCLBI<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3087270", Offset = "0x3085E70", VA = "0x183087270")]
	public static T PNBJHLBKMLC<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA, int OCIFJAIBHIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3087270", Offset = "0x3085E70", VA = "0x183087270")]
	public static T DLEPHHLGMBA<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA, int OCIFJAIBHIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA81DA0", Offset = "0xA809A0", VA = "0x180A81DA0")]
	public static int OLCBCPFMDCE<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3089710", Offset = "0x3088310", VA = "0x183089710")]
	public static ReadOnlySpan<T> KANGOJEFOOP<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3087750", Offset = "0x3086350", VA = "0x183087750")]
	public static ReadOnlyMemory<T> JHBNLOBJEED<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA)
	{
		return default(ReadOnlyMemory<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3086B40", Offset = "0x3085740", VA = "0x183086B40")]
	public static void CAILCKFFJIK<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA, in T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x308CF50", Offset = "0x308BB50", VA = "0x18308CF50")]
	public static void MMNMFEDDBCK<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA, int NHHNPPKPBIA, in T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3087710", Offset = "0x3086310", VA = "0x183087710")]
	public static void FLLDAADPLON<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA, int NHHNPPKPBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x308EC40", Offset = "0x308D840", VA = "0x18308EC40")]
	public static void PHLJIKJKNFC<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA, int FGHOJPFDCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x308D150", Offset = "0x308BD50", VA = "0x18308D150")]
	private static void OGGOAIAJEPA<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA, int CABFJBCMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x30875B0", Offset = "0x30861B0", VA = "0x1830875B0")]
	public static void ELJLHOEKJGC<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3087520", Offset = "0x3086120", VA = "0x183087520")]
	public static bool ELDMMOCPOHL<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA, in T ECNGHFJBIJL) where T : KELNLDHHLCN<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCE8920", Offset = "0xCE7520", VA = "0x180CE8920")]
	public static bool JHFNJCFMCPC<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x30874F0", Offset = "0x30860F0", VA = "0x1830874F0")]
	public static bool DNPJDDECIKO<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA, int OCIFJAIBHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x174B500", Offset = "0x174A100", VA = "0x18174B500")]
	public static CAIIANFGHKN<T>.HEBKGEELNGF MEOEHOBEEMI<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA)
	{
		return default(CAIIANFGHKN<T>.HEBKGEELNGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x174B500", Offset = "0x174A100", VA = "0x18174B500")]
	public static CAIIANFGHKN<T>.EIDPLIPCLGL JLCMIBFBNIO<T>(this ref CAIIANFGHKN<T> GPOCLJBKMHA)
	{
		return default(CAIIANFGHKN<T>.EIDPLIPCLGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x174B330", Offset = "0x1749F30", VA = "0x18174B330")]
	public static PPJALHMGNEF<T, CAIIANFGHKN<T>.HEBKGEELNGF> GFDBFEBJIGA<T>(this in CAIIANFGHKN<T> GPOCLJBKMHA)
	{
		return default(PPJALHMGNEF<T, CAIIANFGHKN<T>.HEBKGEELNGF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct IIKOGEMMEMD<TSourceEnumerator, TSource, TResult> : IOPFDFMJPAA, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : IOPFDFMJPAA, IIPJHKKACOH<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private TSourceEnumerator EEHMMFOELDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly MLBPKFAHLJI<TSource, TResult> EIEMINOBJKJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public readonly int PLEPIEDOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1C863E0", Offset = "0x1C84FE0", VA = "0x181C863E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public readonly TResult NIBFGHDNPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1C86C50", Offset = "0x1C85850", VA = "0x181C86C50", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1C868F0", Offset = "0x1C854F0", VA = "0x181C868F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1C86A30", Offset = "0x1C85630", VA = "0x181C86A30")]
	internal IIKOGEMMEMD(in TSourceEnumerator GPOCLJBKMHA, MLBPKFAHLJI<TSource, TResult> PEBLDEGHPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C86600", Offset = "0x1C85200", VA = "0x181C86600", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1C867C0", Offset = "0x1C853C0", VA = "0x181C867C0", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1C860E0", Offset = "0x1C84CE0", VA = "0x181C860E0", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FHJADMMHNIM<T> : IIPJHKKACOH<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MOGLDDMNFBH
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1E02610", Offset = "0x1E01210", VA = "0x181E02610")]
	public static KOAFLFAMJNA<T> JIEIGEAJNNH<T>(this T[] GPOCLJBKMHA)
	{
		return default(KOAFLFAMJNA<T>);
	}
}
namespace Cpp2IlInjected;

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
