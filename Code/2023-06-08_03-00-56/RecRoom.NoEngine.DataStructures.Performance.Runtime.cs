using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FPMMOOCIKMH<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	T CFKFFOLONBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class POOLEEMENOB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C1A090", Offset = "0x5C18E90", VA = "0x185C1A090")]
	public static string PPEMDMGOPKD<T>(this IEnumerable<T> FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3FC93B0", Offset = "0x3FC81B0", VA = "0x183FC93B0")]
	public static string AGLLECOHOJJ<T>(this IEnumerable<T> FEEMIHFJMDK, string AHBKGEHJLOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct LEBKDOLNCJK<T, U> : IEnumerable<T>, IEnumerable where U : BLADLALMFJE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal readonly U KPDOPLCEGKP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3D03780", Offset = "0x3D02580", VA = "0x183D03780")]
	internal LEBKDOLNCJK(in U HBEBKLDONPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2370C30", Offset = "0x236FA30", VA = "0x182370C30", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D036F0", Offset = "0x3D024F0", VA = "0x183D036F0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D036F0", Offset = "0x3D024F0", VA = "0x183D036F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DMCCPKFKJOF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3163320", Offset = "0x3162120", VA = "0x183163320")]
	public static LEBKDOLNCJK<T, U> PKJHFAGPFPD<U>(in U FEEMIHFJMDK) where U : BLADLALMFJE<T>
	{
		return default(LEBKDOLNCJK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IAPPPEDMHOC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x25DE6F0", Offset = "0x25DD4F0", VA = "0x1825DE6F0")]
	public static bool PNMCLNMINAM<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator FEEMIHFJMDK, in TArgs DCPGFNKOIOA, in DDJLEDMCPBO<TArgs, TSource, bool> MIMEEOMMODG) where TSourceEnumerator : FPMMOOCIKMH<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x25DE0E0", Offset = "0x25DCEE0", VA = "0x1825DE0E0")]
	public static int MEBLLOBPPDK<TSourceEnumerator, TSource, TArgs>(this TSourceEnumerator FEEMIHFJMDK, in TArgs DCPGFNKOIOA, DDJLEDMCPBO<TArgs, TSource, bool> MIMEEOMMODG) where TSourceEnumerator : FPMMOOCIKMH<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x25DE3A0", Offset = "0x25DD1A0", VA = "0x1825DE3A0")]
	public static bool NFKJLJIADIL<TSourceEnumerator, TSource>(this TSourceEnumerator FEEMIHFJMDK, in TSource IGAFFKCMBEK) where TSourceEnumerator : FPMMOOCIKMH<TSource> where TSource : INACGBJLEGA<TSource>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x25DDCF0", Offset = "0x25DCAF0", VA = "0x1825DDCF0")]
	public static int AAKNCFLAPHP<TSourceEnumerator, TSource>(this TSourceEnumerator FEEMIHFJMDK, in TSource KKLNCEHOHED) where TSourceEnumerator : FPMMOOCIKMH<TSource> where TSource : INACGBJLEGA<TSource>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x25DE050", Offset = "0x25DCE50", VA = "0x1825DE050")]
	public static ODAFCDNMOPB<TSourceEnumerator, TSource, TResult> LDDKDFFGHCB<TSourceEnumerator, TSource, TResult>(this TSourceEnumerator FEEMIHFJMDK, KKCBOCGCNFJ<TSource, TResult> OHINOBJEIOM) where TSourceEnumerator : DCLEJHHOCCK, FPMMOOCIKMH<TSource>
	{
		return default(ODAFCDNMOPB<TSourceEnumerator, TSource, TResult>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KAJFKHCKGLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC480", Offset = "0x2AAB280", VA = "0x182AAC480")]
	public static bool GCNJPCNKJFL<TSourceEnumerator>(TSourceEnumerator FEEMIHFJMDK) where TSourceEnumerator : IEnumerator<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FA80", Offset = "0x2A9E880", VA = "0x182A9FA80")]
	public static T FHBIGOADJGN<TSourceEnumerator>(TSourceEnumerator FEEMIHFJMDK) where TSourceEnumerator : FPMMOOCIKMH<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A9FD10", Offset = "0x2A9EB10", VA = "0x182A9FD10")]
	public static T[] FPLDMBIFGGL<TSourceEnumerator>(TSourceEnumerator FEEMIHFJMDK) where TSourceEnumerator : DCLEJHHOCCK, IEnumerator<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC5A0", Offset = "0x2AAB3A0", VA = "0x182AAC5A0")]
	public static T HOEIACFDFNF<TSourceEnumerator>(TSourceEnumerator FEEMIHFJMDK) where TSourceEnumerator : IEnumerator<T>
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HJKDIEMPFMD<T, U> : IEnumerable<T>, IEnumerable where U : FPMMOOCIKMH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly U KPDOPLCEGKP;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	internal HJKDIEMPFMD(in U HBEBKLDONPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3753620", Offset = "0x3752420", VA = "0x183753620", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3753620", Offset = "0x3752420", VA = "0x183753620", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DEHKGCHJJMP<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2AACF60", Offset = "0x2AABD60", VA = "0x182AACF60")]
	public static HJKDIEMPFMD<T, U> PKJHFAGPFPD<U>(in U FEEMIHFJMDK) where U : FPMMOOCIKMH<T>
	{
		return default(HJKDIEMPFMD<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct OGDBLEDINAD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct DFBKMFBABGF : DCLEJHHOCCK, FPMMOOCIKMH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly T[] EIDJMEMBAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private int LIDMOLHAOIO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public readonly int EFAPJKDFNLF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x175A050", Offset = "0x1758E50", VA = "0x18175A050", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public readonly T CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2ACD610", Offset = "0x2ACC410", VA = "0x182ACD610", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2ACD250", Offset = "0x2ACC050", VA = "0x182ACD250", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2ACD390", Offset = "0x2ACC190", VA = "0x182ACD390", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1DF20", Offset = "0xA1CD20", VA = "0x180A1DF20")]
		private DFBKMFBABGF(T[] FEEMIHFJMDK, int FHOMILACEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD1F0", Offset = "0x2ACBFF0", VA = "0x182ACD1F0")]
		public static DFBKMFBABGF PKJHFAGPFPD(T[] FEEMIHFJMDK)
		{
			return default(DFBKMFBABGF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD1C0", Offset = "0x2ACBFC0", VA = "0x182ACD1C0", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2ACD240", Offset = "0x2ACC040", VA = "0x182ACD240", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly T[] DMAAHPDIFDK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	internal OGDBLEDINAD(T[] PKPHLPFOPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x317F040", Offset = "0x317DE40", VA = "0x18317F040")]
	public static OGDBLEDINAD<T> GLDKKHCFJPK()
	{
		return default(OGDBLEDINAD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x317F100", Offset = "0x317DF00", VA = "0x18317F100")]
	public DFBKMFBABGF JOJADCJMMBH()
	{
		return default(DFBKMFBABGF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
	public T[] HOFIGAGGNKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x317F1A0", Offset = "0x317DFA0", VA = "0x18317F1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EJBKEBFHMCI
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3163350", Offset = "0x3162150", VA = "0x183163350")]
	public static OGDBLEDINAD<T> PKJHFAGPFPD<T>(params T[] PKPHLPFOPGM)
	{
		return default(OGDBLEDINAD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5913C60", Offset = "0x5912A60", VA = "0x185913C60")]
	public static ReadOnlySpan<T> AIPEIEHEKCM<T>(this in OGDBLEDINAD<T> FEEMIHFJMDK)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x175A050", Offset = "0x1758E50", VA = "0x18175A050")]
	public static int EIGCKEPKNAH<T>(this in OGDBLEDINAD<T> FEEMIHFJMDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x31495B0", Offset = "0x31483B0", VA = "0x1831495B0")]
	public static T KOLGIMOOKDG<T>(this in OGDBLEDINAD<T> FEEMIHFJMDK, int FHOMILACEHB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5913CA0", Offset = "0x5912AA0", VA = "0x185913CA0")]
	public static HJKDIEMPFMD<T, OGDBLEDINAD<T>.DFBKMFBABGF> EGKBDPDHJPE<T>(this in OGDBLEDINAD<T> FEEMIHFJMDK)
	{
		return default(HJKDIEMPFMD<T, OGDBLEDINAD<T>.DFBKMFBABGF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DCLEJHHOCCK
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2D4D1E889B5D8C", Offset = "0x0", VA = "0x2D4D20089B5D8C", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct HCJNBBNLMIK<T, U> : IEnumerable<T>, IEnumerable where U : IEnumerator<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly U KPDOPLCEGKP;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3B40C90", Offset = "0x3B3FA90", VA = "0x183B40C90")]
	internal HCJNBBNLMIK(in U HBEBKLDONPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2644460", Offset = "0x2643260", VA = "0x182644460", Slot = "6")]
	public U GetEnumerator()
	{
		return (U)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3B40820", Offset = "0x3B3F620", VA = "0x183B40820", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B40820", Offset = "0x3B3F620", VA = "0x183B40820", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KHHMGHDABPB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2AACEF0", Offset = "0x2AABCF0", VA = "0x182AACEF0")]
	public static HCJNBBNLMIK<T, U> PKJHFAGPFPD<U>(in U FEEMIHFJMDK) where U : IEnumerator<T>
	{
		return default(HCJNBBNLMIK<T, U>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
public sealed class ELOPCDPLCJA<T> : IDisposable, DCLEJHHOCCK, IEnumerable<T>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private EGJEDIAJCCN<T> FLBFHNNDJKK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x236DF30", Offset = "0x236CD30", VA = "0x18236DF30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public T MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x236DF70", Offset = "0x236CD70", VA = "0x18236DF70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x236E0A0", Offset = "0x236CEA0", VA = "0x18236E0A0")]
	public static ELOPCDPLCJA<T> PKJHFAGPFPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x236DF90", Offset = "0x236CD90", VA = "0x18236DF90")]
	public static ELOPCDPLCJA<T> ODFKLIDGPGO(int OFPPAGPDNCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x236E220", Offset = "0x236D020", VA = "0x18236E220")]
	internal ELOPCDPLCJA(in EGJEDIAJCCN<T> MLPNLAGGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x236DEB0", Offset = "0x236CCB0", VA = "0x18236DEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x236DF50", Offset = "0x236CD50", VA = "0x18236DF50")]
	public void IMFFJGIMDFG(in T KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x236DED0", Offset = "0x236CCD0", VA = "0x18236DED0")]
	public void FOAPBCJFEPJ(int FNLBOMKPGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x236DEF0", Offset = "0x236CCF0", VA = "0x18236DEF0", Slot = "8")]
	public EGJEDIAJCCN<T>.HONFPOKENKH GetEnumerator()
	{
		return default(EGJEDIAJCCN<T>.HONFPOKENKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x236E1B0", Offset = "0x236CFB0", VA = "0x18236E1B0", Slot = "6")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x236E1B0", Offset = "0x236CFB0", VA = "0x18236E1B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DebuggerTypeProxy(typeof(EGJEDIAJCCN<>.HICFCFFAGFN))]
public struct EGJEDIAJCCN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct HONFPOKENKH : DCLEJHHOCCK, BLADLALMFJE<T>, FPMMOOCIKMH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly T[] JGINDBEANLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly int CGMOEMJKJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int LIDMOLHAOIO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public readonly int EFAPJKDFNLF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA1DF50", Offset = "0xA1CD50", VA = "0x180A1DF50", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly T CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3B18190", Offset = "0x3B16F90", VA = "0x183B18190", Slot = "11")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private readonly T PAOPMMMCLOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3B17040", Offset = "0x3B15E40", VA = "0x183B17040", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3B17490", Offset = "0x3B16290", VA = "0x183B17490", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3B17970", Offset = "0x3B16770", VA = "0x183B17970", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x130C070", Offset = "0x130AE70", VA = "0x18130C070")]
		internal HONFPOKENKH(T[] KLBCGPELFKC, int FNLBOMKPGBB, int FHOMILACEHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B173E0", Offset = "0x3B161E0", VA = "0x183B173E0")]
		public static HONFPOKENKH PKJHFAGPFPD(ref EGJEDIAJCCN<T> FEEMIHFJMDK)
		{
			return default(HONFPOKENKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x36C4110", Offset = "0x36C2F10", VA = "0x1836C4110", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3492890", Offset = "0x3491690", VA = "0x183492890", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct FDGOBPGPNBM : DCLEJHHOCCK, FPMMOOCIKMH<T>, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private HONFPOKENKH KPDOPLCEGKP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int EFAPJKDFNLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x27DCF30", Offset = "0x27DBD30", VA = "0x1827DCF30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public readonly T CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x27DDDC0", Offset = "0x27DCBC0", VA = "0x1827DDDC0", Slot = "5")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		readonly T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x27DD0A0", Offset = "0x27DBEA0", VA = "0x1827DD0A0", Slot = "6")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		readonly object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x27DD670", Offset = "0x27DC470", VA = "0x1827DD670", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
		private FDGOBPGPNBM(in HONFPOKENKH HBEBKLDONPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x27DCFA0", Offset = "0x27DBDA0", VA = "0x1827DCFA0")]
		public static FDGOBPGPNBM PKJHFAGPFPD(in EGJEDIAJCCN<T> FEEMIHFJMDK)
		{
			return default(FDGOBPGPNBM);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x27DCF60", Offset = "0x27DBD60", VA = "0x1827DCF60", Slot = "8")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x27DD060", Offset = "0x27DBE60", VA = "0x1827DD060", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x27DCEF0", Offset = "0x27DBCF0", VA = "0x1827DCEF0", Slot = "7")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class HICFCFFAGFN
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal T[] JGINDBEANLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal int CGMOEMJKJFM;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x30D8150", Offset = "0x30D6F50", VA = "0x1830D8150")]
	public static EGJEDIAJCCN<T> PKJHFAGPFPD()
	{
		return default(EGJEDIAJCCN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x30D8070", Offset = "0x30D6E70", VA = "0x1830D8070")]
	public static EGJEDIAJCCN<T> ODFKLIDGPGO(int OFPPAGPDNCI)
	{
		return default(EGJEDIAJCCN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xA1DF20", Offset = "0xA1CD20", VA = "0x180A1DF20")]
	internal EGJEDIAJCCN(T[] KLBCGPELFKC, int FNLBOMKPGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x30D8220", Offset = "0x30D7020", VA = "0x1830D8220", Slot = "3")]
	public override readonly string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BAFNJHGKLBP
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x31499A0", Offset = "0x31487A0", VA = "0x1831499A0")]
	public static void MBKJDOLMADL<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x314B9B0", Offset = "0x314A7B0", VA = "0x18314B9B0")]
	public static string OCHEAELFHAA<T>(this in EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
	public static T[] OFLEHLOIHMM<T>(this in EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3149830", Offset = "0x3148630", VA = "0x183149830")]
	public static T KOLGIMOOKDG<T>(this in EGJEDIAJCCN<T> FEEMIHFJMDK, int EFGAFPEAGGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x31496B0", Offset = "0x31484B0", VA = "0x1831496B0")]
	public static T KJOBJMAHHJC<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK, int EFGAFPEAGGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA1DF50", Offset = "0xA1CD50", VA = "0x180A1DF50")]
	public static int HOPDHEFFIHD<T>(this in EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3144870", Offset = "0x3143670", VA = "0x183144870")]
	public static ReadOnlySpan<T> AIPEIEHEKCM<T>(this in EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3148EE0", Offset = "0x3147CE0", VA = "0x183148EE0")]
	public static void IMFFJGIMDFG<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK, in T KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3147B20", Offset = "0x3146920", VA = "0x183147B20")]
	public static void EBEEDMALMKL<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK, int FHOMILACEHB, in T KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3148E10", Offset = "0x3147C10", VA = "0x183148E10")]
	public static void FOPGPDPHJCG<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK, int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3147F10", Offset = "0x3146D10", VA = "0x183147F10")]
	public static void FOAPBCJFEPJ<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK, int FNLBOMKPGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3149C20", Offset = "0x3148A20", VA = "0x183149C20")]
	private static void OBMHNLMABBK<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK, int OFPPAGPDNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x31498B0", Offset = "0x31486B0", VA = "0x1831498B0")]
	public static void LEKENBMMMEI<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3149A10", Offset = "0x3148810", VA = "0x183149A10")]
	public static bool MEMOAEENCDN<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK, in T KKLNCEHOHED) where T : INACGBJLEGA<T>
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC60", Offset = "0xD29A60", VA = "0x180D2AC60")]
	public static bool CGHLOCINKNH<T>(this in EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3148E50", Offset = "0x3147C50", VA = "0x183148E50")]
	public static bool HPMLGAHDOPI<T>(this in EGJEDIAJCCN<T> FEEMIHFJMDK, int EFGAFPEAGGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F700", Offset = "0x2C5E500", VA = "0x182C5F700")]
	public static EGJEDIAJCCN<T>.FDGOBPGPNBM JOJADCJMMBH<T>(this in EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
		return default(EGJEDIAJCCN<T>.FDGOBPGPNBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F700", Offset = "0x2C5E500", VA = "0x182C5F700")]
	public static EGJEDIAJCCN<T>.HONFPOKENKH OKDNPANOGCF<T>(this ref EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
		return default(EGJEDIAJCCN<T>.HONFPOKENKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C5F630", Offset = "0x2C5E430", VA = "0x182C5F630")]
	public static HJKDIEMPFMD<T, EGJEDIAJCCN<T>.FDGOBPGPNBM> EGKBDPDHJPE<T>(this in EGJEDIAJCCN<T> FEEMIHFJMDK)
	{
		return default(HJKDIEMPFMD<T, EGJEDIAJCCN<T>.FDGOBPGPNBM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ODAFCDNMOPB<TSourceEnumerator, TSource, TResult> : DCLEJHHOCCK, IEnumerator<TResult>, IEnumerator, IDisposable where TSourceEnumerator : DCLEJHHOCCK, FPMMOOCIKMH<TSource>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private TSourceEnumerator EIDJMEMBAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KKCBOCGCNFJ<TSource, TResult> FDOLLJPECJI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public readonly int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3169720", Offset = "0x3168520", VA = "0x183169720", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public readonly TResult CFKFFOLONBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3169F50", Offset = "0x3168D50", VA = "0x183169F50", Slot = "5")]
		get
		{
			return (TResult)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	readonly object IEnumerator.Current
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3169D80", Offset = "0x3168B80", VA = "0x183169D80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x26438A0", Offset = "0x26426A0", VA = "0x1826438A0")]
	internal ODAFCDNMOPB(in TSourceEnumerator FEEMIHFJMDK, KKCBOCGCNFJ<TSource, TResult> OHINOBJEIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3169860", Offset = "0x3168660", VA = "0x183169860", Slot = "7")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3169A70", Offset = "0x3168870", VA = "0x183169A70", Slot = "9")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3169420", Offset = "0x3168220", VA = "0x183169420", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BLADLALMFJE<T> : FPMMOOCIKMH<T>, IEnumerator<T>, IEnumerator, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DKKLIFHFBGP
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2333040", Offset = "0x2331E40", VA = "0x182333040")]
	public static OGDBLEDINAD<T> DCHLCEJHDEK<T>(this T[] FEEMIHFJMDK)
	{
		return default(OGDBLEDINAD<T>);
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
