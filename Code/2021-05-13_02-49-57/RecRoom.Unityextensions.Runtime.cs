using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Networking;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BCKPFAJAPEO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HPIEIOAGEGB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Func<T, string> elementToString;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public HPIEIOAGEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1700070", Offset = "0x16FF470", VA = "0x181700070")]
		internal string <ToFriendlyString>b__1(int index, T t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class IEKPHHLNIBA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public string sep;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public IEKPHHLNIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x17000B0", Offset = "0x16FF4B0", VA = "0x1817000B0")]
		internal string <ToFriendlyString>b__1(string s, string s1)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1A63A40", Offset = "0x1A62E40", VA = "0x181A63A40")]
	public static string JIIMHOLCECD<T>(this IEnumerable<T> NKLIOLCGIDM, [Optional] Func<T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1A63590", Offset = "0x1A62990", VA = "0x181A63590")]
	public static string JIIMHOLCECD<T>(this IList<T> DAAFDLFCOGO, [Optional] Func<int, T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xE457C0", Offset = "0xE44BC0", VA = "0x180E457C0")]
	[IteratorStateMachine(typeof(AEABJMALBDK))]
	public static IEnumerable<T> MJJDFHHAOPM<T>(T IOBEPGLJNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1469CB0", Offset = "0x14690B0", VA = "0x181469CB0")]
	public static (T[], U[]) HKJNIHLKENA<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x77190", Offset = "0x76590")] this IEnumerable<(T, U)> NMELNILPPKN)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14E5BE0", Offset = "0x14E4FE0", VA = "0x1814E5BE0")]
	public static IEnumerable<(T, int)> AKGEGLEMFGM<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x146A290", Offset = "0x1469690", VA = "0x18146A290")]
	public static void HOAGBPIIIGP<T>(this IEnumerable<T> NMELNILPPKN, Action<T> EDECJKLDKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x13AEA40", Offset = "0x13ADE40", VA = "0x1813AEA40")]
	public static HashSet<T> PBGCPCJGGOO<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x14E5DA0", Offset = "0x14E51A0", VA = "0x1814E5DA0")]
	public static IEnumerable<T> HDLDCPJDNDA<T>(this IEnumerable<T> NKLIOLCGIDM, int KKDPFGADCEK, int MADNOGDODFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x14E5DE0", Offset = "0x14E51E0", VA = "0x1814E5DE0")]
	public static IEnumerable<T> KPDAENONKPJ<T, TKey>(this IEnumerable<T> NKLIOLCGIDM, Func<T, TKey> HDLMHEHINBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CEEHAKJPFHM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x34C20B0", Offset = "0x34C14B0", VA = "0x1834C20B0")]
	public static void JFPFIMFLALC(Vector3 FKGCMPGAIAP, Vector3 KOFMGJJCPPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LEBNDOKLNEL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static float EKAKAHABHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x34CB3C0", Offset = "0x34CA7C0", VA = "0x1834CB3C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static float JHAFCFMBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x739930", Offset = "0x738D30", VA = "0x180739930")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static float DGEAEHEJCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x34CB350", Offset = "0x34CA750", VA = "0x1834CB350")]
		get
		{
			return default(float);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LHIJJLMMMHM
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x34CB510", Offset = "0x34CA910", VA = "0x1834CB510")]
	public static bool BKDAHHMFHMC(this DateTime? PBMJJOMBPAH, TimeSpan DOFKHNLEKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x34CB640", Offset = "0x34CAA40", VA = "0x1834CB640")]
	public static string PAKENNFHMEG(this TimeSpan DOFKHNLEKKP, string FEGAGLFEGEP = "minute", bool JKEPCLNFJHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34CB5B0", Offset = "0x34CA9B0", VA = "0x1834CB5B0")]
	private static string HIDOGKBNNLG(string IGCKACBLCON, double KEOKDMNJJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IEDIJNKECOL
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x34CA3A0", Offset = "0x34C97A0", VA = "0x1834CA3A0")]
	public static string MJHFHBGFJHF(this Type GEDCEIDOKJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LFDJHEDEGAJ
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x34CB3D0", Offset = "0x34CA7D0", VA = "0x1834CB3D0")]
	public static void DBCCNEMNLNI(this Animator LDOJFIEANFB, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x34CB450", Offset = "0x34CA850", VA = "0x1834CB450")]
	public static void DOMIGIEBFCF(this Animator LDOJFIEANFB, int ENJEOLBEALP, bool ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x34CB4B0", Offset = "0x34CA8B0", VA = "0x1834CB4B0")]
	public static void HDMGMCACGHG(this Animator LDOJFIEANFB, int ENJEOLBEALP, int ONGBFDACHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class MKCGPMKFCJH
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate int IGHKKHEGGBB<T>(in T LONDCJPNKKN, in T PCEJJILDLGD);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public sealed class MKNPILCJOAI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private struct JONDMKIDPLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public readonly int HKPHMBLKPFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int DJICGHFJJJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly bool GOJFBEJBPBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int DJKJBCMBFDL;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x231B5F0", Offset = "0x231A9F0", VA = "0x18231B5F0")]
			public JONDMKIDPLE(int startIndex, int endIndex, bool needsCopyToWorkBuffer)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly T[] GMOGECKNEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly T[] EPDKOCHMOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly IGHKKHEGGBB<T> BKHGMOKDLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly int DCFEFKGJDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly Func<bool> AEMDDGKHONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int EOOOOAJCPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly JONDMKIDPLE[] JPKGKHBFFJG;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2328FD0", Offset = "0x23283D0", VA = "0x182328FD0")]
		public MKNPILCJOAI(T[] arrayToSort, IGHKKHEGGBB<T> compare, int chunkSize, Func<bool> shouldSuspendHeuristic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2328C10", Offset = "0x2328010", VA = "0x182328C10")]
		public bool CDHNACEAFJL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1C29160", Offset = "0x1C28560", VA = "0x181C29160")]
	public static T[] APNIJAHEGLJ<T>(int OJJOHDIFMEG, T MCACHDBIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2BC78C0", Offset = "0x2BC6CC0", VA = "0x182BC78C0")]
	public static void KDEILFALGLM<T>(this T[] JABGABGMHPL, T MCACHDBIALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7380", Offset = "0x2BC6780", VA = "0x182BC7380")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7180", Offset = "0x2BC6580", VA = "0x182BC7180")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA, int OIDPFPMBCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7410", Offset = "0x2BC6810", VA = "0x182BC7410")]
	public static void CDLEKIKHHCD<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2BC74A0", Offset = "0x2BC68A0", VA = "0x182BC74A0")]
	private static void JIHBNKEBJDH<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int DJICGHFJJJP, T[] EPDKOCHMOLC, bool GOJFBEJBPBC, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7A30", Offset = "0x2BC6E30", VA = "0x182BC7A30")]
	private static void MNMAEDHAEFJ<T>(this T[] NMELNILPPKN, int ANDOICCNDLA, int GFKCDKBFBBN, T[] HPKICPNGMDJ, int MDIFJBFIGHL, int PPNMMGMDEJI, T[] GIAOBLMEMMI, int CAPPAKEKPLG, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7E60", Offset = "0x2BC7260", VA = "0x182BC7E60")]
	public static void OIEHNKDGJKK<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int MNIJHBJDPPA, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x13C3BC0", Offset = "0x13C2FC0", VA = "0x1813C3BC0")]
	public static MKNPILCJOAI<T> JKMCDDAPLHN<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO, int DCFEFKGJDOJ, Func<bool> AEMDDGKHONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1C29AE0", Offset = "0x1C28EE0", VA = "0x181C29AE0")]
	public static T[] NHGMLEGCCMP<T>(this T[] OPEBNMBKJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1C29B00", Offset = "0x1C28F00", VA = "0x181C29B00")]
	public static T[] PPMHFINCJNE<T>(this T[] IHFOIAODAJC, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1C29490", Offset = "0x1C28890", VA = "0x181C29490")]
	public static T[] DECCCEINGDI<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1C29A30", Offset = "0x1C28E30", VA = "0x181C29A30")]
	public static T[] HNNOENGPBPL<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1C29270", Offset = "0x1C28670", VA = "0x181C29270")]
	public static T[] BCDEMOBAJPO<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD, T FMDLBNOKCBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FJCMFIINFIO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum NCHPJLFOHGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Self,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Parent,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Children
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HKLGKBLGDMN : IEquatable<HKLGKBLGDMN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly GameObject DOJCFCINALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly bool AHOAECJDPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly NCHPJLFOHGM MPBIKBNEFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly bool CLAOPEDMPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly Type GEDCEIDOKJL;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x34C8E60", Offset = "0x34C8260", VA = "0x1834C8E60")]
		public HKLGKBLGDMN(GameObject gameObject, bool includeMultiple, NCHPJLFOHGM searchType, bool includeInactive, Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x34C87B0", Offset = "0x34C7BB0", VA = "0x1834C87B0", Slot = "4")]
		public bool Equals(HKLGKBLGDMN HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x34C8710", Offset = "0x34C7B10", VA = "0x1834C8710", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x34C88C0", Offset = "0x34C7CC0", VA = "0x1834C88C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x34C8980", Offset = "0x34C7D80", VA = "0x1834C8980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static readonly List<HKLGKBLGDMN> JBEMICAPBLE;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static Dictionary<HKLGKBLGDMN, ICollection> NIGMNGKEBEK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static int MCAFABAMOGC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x34C4AB0", Offset = "0x34C3EB0", VA = "0x1834C4AB0")]
	public static void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1307050", Offset = "0x1306450", VA = "0x181307050")]
	public static T FABKIOBNCHE<T>(this GameObject DOJCFCINALC, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1307320", Offset = "0x1306720", VA = "0x181307320")]
	public static T MHBNENBBNDJ<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x13AD440", Offset = "0x13AC840", VA = "0x1813AD440")]
	public static IReadOnlyList<T> HLCNADOGJFC<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x13AD940", Offset = "0x13ACD40", VA = "0x1813AD940")]
	public static IReadOnlyList<T> PHJEODMHDOK<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1307160", Offset = "0x1306560", VA = "0x181307160")]
	private static T JGCKGHNCPPC<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x13AD690", Offset = "0x13ACA90", VA = "0x1813AD690")]
	private static IReadOnlyList<T> OFLKKOAGMFK<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x34C4A10", Offset = "0x34C3E10", VA = "0x1834C4A10")]
	private static void KIPECKHDOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x34C4600", Offset = "0x34C3A00", VA = "0x1834C4600")]
	private static void JOMBFKGNCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x13AD840", Offset = "0x13ACC40", VA = "0x1813AD840")]
	private static IReadOnlyList<T> OIJCNPEICPD<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x13AD560", Offset = "0x13AC960", VA = "0x1813AD560")]
	private static IReadOnlyList<T> MAALAKFHBNE<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BOHNIEMGLMC
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x34C00E0", Offset = "0x34BF4E0", VA = "0x1834C00E0")]
	public static float ELCHENEAFFD(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34C0750", Offset = "0x34BFB50", VA = "0x1834C0750")]
	public static float OOIKMLIOLHN(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x34C0580", Offset = "0x34BF980", VA = "0x1834C0580")]
	public static float KCHIFOHABON(this Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x34BFEE0", Offset = "0x34BF2E0", VA = "0x1834BFEE0")]
	private static float DBBKCKNDNOJ(float PPLEDBHELNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x34BFF50", Offset = "0x34BF350", VA = "0x1834BFF50")]
	private static float DBBKCKNDNOJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x34C0380", Offset = "0x34BF780", VA = "0x1834C0380")]
	private static float FMJNGGHKBNJ(float PPLEDBHELNG, float EHDMLFDEBAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x34C0340", Offset = "0x34BF740", VA = "0x1834C0340")]
	private static float FMJNGGHKBNJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x34C0230", Offset = "0x34BF630", VA = "0x1834C0230")]
	public static float FGCPIGKOIHD(float PPLEDBHELNG, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x34C0110", Offset = "0x34BF510", VA = "0x1834C0110")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x34C0150", Offset = "0x34BF550", VA = "0x1834C0150")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, Vector2 IJHJIKGDNJH, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x34BFE30", Offset = "0x34BF230", VA = "0x1834BFE30")]
	private static float CIMKJKMKPGG(float DABFKGJPFDC, float IJHJIKGDNJH, float PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x34C0400", Offset = "0x34BF800", VA = "0x1834C0400")]
	public static float JKGBBKLIAMK(float GGJOIJAKDDC, float EHDMLFDEBAF, Vector2 IJHJIKGDNJH, float HGFAGBNEADJ, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x34C0690", Offset = "0x34BFA90", VA = "0x1834C0690")]
	private static float NEANFKGDFBM(float DABFKGJPFDC, float IJHJIKGDNJH, float HGFAGBNEADJ, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x34BFFD0", Offset = "0x34BF3D0", VA = "0x1834BFFD0")]
	public static void DBJKGNBKPDI(this Camera FOMHGMLPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x34C0630", Offset = "0x34BFA30", VA = "0x1834C0630")]
	public static bool LPBHGEJLJKD(this Camera FOMHGMLPOND, Renderer CHEJPOIMMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x34C0060", Offset = "0x34BF460", VA = "0x1834C0060")]
	public static bool DGMGLKLPMKE(this Camera FOMHGMLPOND, Vector3 KPLDEODOJID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CKGCNOLFMDC
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static RaycastHit[] IGOKEBHKLJM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x34C2E00", Offset = "0x34C2200", VA = "0x1834C2E00")]
	public static bool HAKOLMGKNPH(this Collider GLPOLGOBLAA, Vector3 KMIFDIBBCDI, Vector3 EDKKBNDGKAO, float OMLBPICLALA, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, out RaycastHit IIILNCEEBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x34C23D0", Offset = "0x34C17D0", VA = "0x1834C23D0")]
	public static int AMAOMIJGJBF(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, Collider[] GIJOIBPGGOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x34C2B60", Offset = "0x34C1F60", VA = "0x1834C2B60")]
	public static bool FKFGLHIBHJC(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x34C3350", Offset = "0x34C2750", VA = "0x1834C3350")]
	public static int NBOGLHFIMJA(this BoxCollider GLPOLGOBLAA, Collider[] PANOGCJFAOD, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x34C3160", Offset = "0x34C2560", VA = "0x1834C3160")]
	public static bool KCFPIEEMJON(this BoxCollider CEGIONPIIAO, Vector3 NAIDPMBKHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34C27A0", Offset = "0x34C1BA0", VA = "0x1834C27A0")]
	public static bool FKFGLHIBHJC(this CapsuleCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x34C30D0", Offset = "0x34C24D0", VA = "0x1834C30D0")]
	public static Vector3 HHNMMNMLAMF(this BoxCollider GLPOLGOBLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x34C2690", Offset = "0x34C1A90", VA = "0x1834C2690")]
	public static Vector3 BNOGHBABGHM(this BoxCollider GLPOLGOBLAA)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class LDGGILEEDOA
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly Color AAOJDFHMMOF;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x34CB260", Offset = "0x34CA660", VA = "0x1834CB260")]
	public static Color FKDFDGMNNLG(this Color GJAINANBOCB, float FBPFONBFPEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x34CB170", Offset = "0x34CA570", VA = "0x1834CB170")]
	public static Vector3 AHOMKMDCPOH(this Vector3 DKIELBAENOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x34CB070", Offset = "0x34CA470", VA = "0x1834CB070")]
	public static Color AHOMKMDCPOH(this Color DKIELBAENOL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x34CB2A0", Offset = "0x34CA6A0", VA = "0x1834CB2A0")]
	public static Color LGPCCFOGKGG(this Color GJAINANBOCB, float IOAMFOPBCMN)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BEBOIKCDHFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x34BF860", Offset = "0x34BEC60", VA = "0x1834BF860")]
	public static void OFKIHGPJHJI(this Component CKCMODJNCNF, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x13AA2D0", Offset = "0x13A96D0", VA = "0x1813AA2D0")]
	public static List<T> PFOKAFNFHHM<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1303360", Offset = "0x1302760", VA = "0x181303360")]
	public static T LNJIMABEJLG<T>(this Component CKCMODJNCNF, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EJFNMBLOPLC
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x14E6440", Offset = "0x14E5840", VA = "0x1814E6440")]
	[IteratorStateMachine(typeof(GPLOPLEHDLG))]
	public static IEnumerable<T> EPGGAFDGOJP<T>() where T : Component
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JOOLDJJHKPL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AFMAGHBPHLI : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float waitDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public AFMAGHBPHLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x34BEC30", Offset = "0x34BE030", VA = "0x1834BEC30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x34BECE0", Offset = "0x34BE0E0", VA = "0x1834BECE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EGJGCHCIGPJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3C0", Offset = "0x3DB7C0", VA = "0x1803DC3C0")]
		[DebuggerHidden]
		public EGJGCHCIGPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x34C3CB0", Offset = "0x34C30B0", VA = "0x1834C3CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x34C3D60", Offset = "0x34C3160", VA = "0x1834C3D60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static WaitForEndOfFrame NAKHMEPNJEL;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x34CA630", Offset = "0x34C9A30", VA = "0x1834CA630")]
	[IteratorStateMachine(typeof(AFMAGHBPHLI))]
	public static IEnumerator BCAKHIGACHG(float CAHAMMIHDFG, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x34CA6A0", Offset = "0x34C9AA0", VA = "0x1834CA6A0")]
	[IteratorStateMachine(typeof(EGJGCHCIGPJ))]
	public static IEnumerator CHAAKFJCLIH(Action JJGHIEJCCDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IGHCGCAGAFH : CustomYieldInstruction
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private float CMKOPHJFKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private float FNNJGLMMINK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override bool HECPAIJFMED
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x34CA590", Offset = "0x34C9990", VA = "0x1834CA590", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x34CA560", Offset = "0x34C9960", VA = "0x1834CA560")]
	public IGHCGCAGAFH(float seconds)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CDHKGKPIOLK
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1C111C0", Offset = "0x1C105C0", VA = "0x181C111C0")]
	public static TValue KGAPEMHMJHI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG) where TValue : new()
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1C11460", Offset = "0x1C10860", VA = "0x181C11460")]
	public static TValue PLOELFMPHEI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1C10ED0", Offset = "0x1C102D0", VA = "0x181C10ED0")]
	public static TValue GLPALAONCFG<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FKFGKDOBBOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x34C7580", Offset = "0x34C6980", VA = "0x1834C7580")]
	public static string CPIKLJJCBAB(this Guid COFLAJFOPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x34C74A0", Offset = "0x34C68A0", VA = "0x1834C74A0")]
	public static string CPIKLJJCBAB(this byte[] MGPDDEMABPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LBEHNMANHHL
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x34CA7F0", Offset = "0x34C9BF0", VA = "0x1834CA7F0")]
	public static string GKBCGFOAIJM(this FileInfo NOHHLFHPPDF, string IFKMFOPALAO, string EAEOAIMAJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x34CA9A0", Offset = "0x34C9DA0", VA = "0x1834CA9A0")]
	public static string GKBCGFOAIJM(this FileInfo NOHHLFHPPDF, int FEPFHBCDPNJ, int NAMHLCJNDPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class LBFOOLAIGBI
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BJBOHHCEKDF : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GameObject go;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GameObject <>3__go;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Transform <t>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x3DC350", Offset = "0x3DB750", VA = "0x1803DC350", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F7F50", Offset = "0x3F7350", VA = "0x1803F7F50")]
		[DebuggerHidden]
		public BJBOHHCEKDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x34BFC50", Offset = "0x34BF050", VA = "0x1834BFC50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x34BFDE0", Offset = "0x34BF1E0", VA = "0x1834BFDE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x34BFD40", Offset = "0x34BF140", VA = "0x1834BFD40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x34BFD40", Offset = "0x34BF140", VA = "0x1834BFD40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Dictionary<int, int> IKJIECFLKJL;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x130A130", Offset = "0x1309530", VA = "0x18130A130")]
	public static T LNJIMABEJLG<T>(this GameObject DOJCFCINALC, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x130A080", Offset = "0x1309480", VA = "0x18130A080")]
	public static T GLENGLDKGCK<T>(this GameObject DOJCFCINALC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x130A050", Offset = "0x1309450", VA = "0x18130A050")]
	public static T GLENGLDKGCK<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x147A060", Offset = "0x1479460", VA = "0x18147A060")]
	public static void IFFLOPMPLPN<T>(this GameObject DOJCFCINALC, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1479FB0", Offset = "0x14793B0", VA = "0x181479FB0")]
	public static void IFFLOPMPLPN<T>(this Component CKCMODJNCNF, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x147A110", Offset = "0x1479510", VA = "0x18147A110")]
	public static void OPKLCCBLMCM<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x34CAE30", Offset = "0x34CA230", VA = "0x1834CAE30")]
	public static void OLLDCMIMDLM(this GameObject DOJCFCINALC, string GHBNIGCAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x34CAB30", Offset = "0x34C9F30", VA = "0x1834CAB30")]
	public static string AOEFKLMCCGH(this GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x34CAC60", Offset = "0x34CA060", VA = "0x1834CAC60")]
	[IteratorStateMachine(typeof(BJBOHHCEKDF))]
	private static IEnumerable<string> CLDAIOKJMCC(GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x34CACD0", Offset = "0x34CA0D0", VA = "0x1834CACD0")]
	public static int MOOKPIOIGOD(this GameObject NLNHFEEMFBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LOJLAODGLLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2653450", Offset = "0x2652850", VA = "0x182653450")]
	public static V ODHHPEIEBCB<V, T>(this T LIMOILDIGKF, Func<T, V> PAFOMEECIMH, [Optional] V OANDOPIEEPO) where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x147A5B0", Offset = "0x14799B0", VA = "0x18147A5B0")]
	public static void CLELOGIOOCO<T>(this T LIMOILDIGKF, Action<T> PAFOMEECIMH) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ECNNGIFNNNM
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1688370", Offset = "0x1687770", VA = "0x181688370")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> OPEBNMBKJJA, T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x146BE00", Offset = "0x146B200", VA = "0x18146BE00")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x146BE90", Offset = "0x146B290", VA = "0x18146BE90")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO, int KIJHGBLLCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x13AA730", Offset = "0x13A9B30", VA = "0x1813AA730")]
	public static List<T> FHAOCJFENEF<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1688150", Offset = "0x1687550", VA = "0x181688150")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> DAAFDLFCOGO, Predicate<T> HBPBAJNLGCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x17A7680", Offset = "0x17A6A80", VA = "0x1817A7680")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x17A7240", Offset = "0x17A6640", VA = "0x1817A7240")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP, EqualityComparer<T> KFBHPCHEJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x16876A0", Offset = "0x1686AA0", VA = "0x1816876A0")]
	public static int IBKMBGJGECB<TElement, TKey>(this IList<TElement> LLOIOFKDLFP, TKey IFHDIPBMJOI, Func<TElement, TKey> IHHAGJMACDJ, [Optional] Func<TKey, TKey, int> BKHGMOKDLGO, int EFBDCIJMFGD = 0, [Optional] int? MNIJHBJDPPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x13062D0", Offset = "0x13056D0", VA = "0x1813062D0")]
	public static T NBMJEPIPHGC<T>(this IReadOnlyList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x17A77C0", Offset = "0x17A6BC0", VA = "0x1817A77C0")]
	public static bool KFDLNLFOGBN<T>(this List<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x146C690", Offset = "0x146BA90", VA = "0x18146C690")]
	public static void AINCGKKANMC<T>(this List<T> DAAFDLFCOGO, IEnumerable<T> CGBHMNCBAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1306210", Offset = "0x1305610", VA = "0x181306210")]
	public static T NBMJEPIPHGC<T>(this T[] DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1309E90", Offset = "0x1309290", VA = "0x181309E90")]
	public static void OHDOOOKOMNB<T>(this List<T> CGBHMNCBAGA) where T : UnityEngine.Object
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1306050", Offset = "0x1305450", VA = "0x181306050")]
	public static T LLFCJKLELNH<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1305AC0", Offset = "0x1304EC0", VA = "0x181305AC0")]
	public static T BMCEKIFDDJK<T>(this List<T> CGBHMNCBAGA, int EFBDCIJMFGD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x17A5E30", Offset = "0x17A5230", VA = "0x1817A5E30")]
	public static bool IDCGECLDIDG<T>(this List<T> LNFKAGBJHOA, List<T> ADFLPMKFAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1305ED0", Offset = "0x13052D0", VA = "0x181305ED0")]
	public static T GPEBLICLPML<T>(this IList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x17A7830", Offset = "0x17A6C30", VA = "0x1817A7830")]
	public static bool MGIGDPBNABL<T>(IReadOnlyList<T> DAAFDLFCOGO, int EFBDCIJMFGD, out T GIAOBLMEMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x17A6F50", Offset = "0x17A6350", VA = "0x1817A6F50")]
	public static bool JEACGAIICGO<T>(IReadOnlyList<T> DAAFDLFCOGO, ICollection CGBHMNCBAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x146C580", Offset = "0x146B980", VA = "0x18146C580")]
	public static void AEONHOJKJNI<T>(IReadOnlyList<T> DAAFDLFCOGO, ref ICollection CGBHMNCBAGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GEKPCDJEJAK
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF420", Offset = "0x1DCE820", VA = "0x181DCF420")]
	public static void BLPOBJABAMH(this Material ENKBCLEDIFA, string NKILHMDECHA, bool CBHMNNAINHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FJFHDHBBFKE
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly List<float> OIPOGHOKFJP;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<float> LHGBMOHCGGC;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x34C6690", Offset = "0x34C5A90", VA = "0x1834C6690")]
	public static bool MOHPPAOIEMG(int ONGBFDACHHG, int GOICNKGDJEC, int KEBJAIELILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x34C7140", Offset = "0x34C6540", VA = "0x1834C7140")]
	public static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x34C53B0", Offset = "0x34C47B0", VA = "0x1834C53B0")]
	public static float GDKJPBLEGLK(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x34C66B0", Offset = "0x34C5AB0", VA = "0x1834C66B0")]
	public static void NADMLFBBFJB(Vector3 JLCIKNNKEAD, out float LMMPJCFJDOL, out float NOFFCKDIOEP, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x34C6A40", Offset = "0x34C5E40", VA = "0x1834C6A40")]
	public static void NPCJFNAJALO(Vector3 JLCIKNNKEAD, out float LBJOIGNPPFB, out float CEOHNIOICHD, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x34C7300", Offset = "0x34C6700", VA = "0x1834C7300")]
	public static Vector3 PDLGILNJNGC(float LMMPJCFJDOL, float NOFFCKDIOEP, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x34C59E0", Offset = "0x34C4DE0", VA = "0x1834C59E0")]
	public static Vector3 JIABPBLKCKG(float LBJOIGNPPFB, float CEOHNIOICHD, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x34C5810", Offset = "0x34C4C10", VA = "0x1834C5810")]
	public static Vector3 HMGHBDPPJAG(Vector3 BBMDCKFFPCE, Vector3 JIOIOMDOAJA, Vector3 KHCCKHOEOKP, Vector3 IJGHHKBAIDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34C4FE0", Offset = "0x34C43E0", VA = "0x1834C4FE0")]
	public static bool CFKHNLPBCCE(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x34C6190", Offset = "0x34C5590", VA = "0x1834C6190")]
	public static float MBLIIPEMOGB(Ray FAACBOBPIKK, Ray HEGDAEMJLDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x34C6C80", Offset = "0x34C6080", VA = "0x1834C6C80")]
	private static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC, float BANKGLOHKOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x34C4BE0", Offset = "0x34C3FE0", VA = "0x1834C4BE0")]
	public static bool BAHBPFFNNJO(float IPHIIJNAEON, float FOJLJNMAJLC, float CIIMMENGOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x34C50B0", Offset = "0x34C44B0", VA = "0x1834C50B0")]
	public static Vector3 DBDLNMAONIL(Vector3 KPLDEODOJID, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x34C5210", Offset = "0x34C4610", VA = "0x1834C5210")]
	public static Vector3 EAEOKLNFADK(Vector3 DJBBMJBBNHB, Vector3 CKPHGEEPNDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x34C54A0", Offset = "0x34C48A0", VA = "0x1834C54A0")]
	public static void GEFDMDGMEBM(Transform OIFLDNBGJOH, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH, Vector3 AADLCEBLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x34C5B50", Offset = "0x34C4F50", VA = "0x1834C5B50")]
	public static Vector3 JPGHEAINBKJ(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float PIHLBMOKPFJ, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x34C6790", Offset = "0x34C5B90", VA = "0x1834C6790")]
	public static Vector3 NDEFIIAMEPM(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x34C4C70", Offset = "0x34C4070", VA = "0x1834C4C70")]
	private static float BNGIECEAJKA(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x34C6A20", Offset = "0x34C5E20", VA = "0x1834C6A20")]
	public static float NKBLAPMGFEN(float FLIEBIMFHEN, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x34C72E0", Offset = "0x34C66E0", VA = "0x1834C72E0")]
	public static float PCHIOIGDICJ(float JDFENOCNKAD, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x34C6B60", Offset = "0x34C5F60", VA = "0x1834C6B60")]
	public static float OMBOKJDOGMI(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x34C4F20", Offset = "0x34C4320", VA = "0x1834C4F20")]
	public static void BOIDIABHGLA(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI, out float AHCGFILIFFM, out float MEMDHFDMDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x34C59A0", Offset = "0x34C4DA0", VA = "0x1834C59A0")]
	public static float JBLAJMCFLIK(this float ONGBFDACHHG, Vector2 LMBJKPOFNJA, Vector2 LNMOFOCDKEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x34C6160", Offset = "0x34C5560", VA = "0x1834C6160")]
	public static float LAFFGDDLOFP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FD47F0", Offset = "0x1FD3BF0", VA = "0x181FD47F0")]
	public static float DGKGLMIIKNG(this float NIONDACONFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x34C6600", Offset = "0x34C5A00", VA = "0x1834C6600")]
	public static float MJKHBBDDDBL(int DBCLLCJFNJM = 30)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x34C5FA0", Offset = "0x34C53A0", VA = "0x1834C5FA0")]
	public static Vector3 KEFKCKMCCEG(Vector3 GEOFMLLGABC, Vector3 ILOMMBLNKMA, float GAIPDLMAPJP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FCDBKMOEJMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x349ED70", Offset = "0x349E170", VA = "0x18349ED70")]
	public static bool DFIECMNBGCO(this MonoBehaviour BKGIHIBDAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x34C4300", Offset = "0x34C3700", VA = "0x1834C4300")]
	public static void OMNDHPIFFEM(this MonoBehaviour BKGIHIBDAPA, Coroutine NEPMGGPMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x34C4270", Offset = "0x34C3670", VA = "0x1834C4270")]
	public static void GLFCOPMIKLH(this MonoBehaviour BKGIHIBDAPA, IDisposable KECNNGMBHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x34C40E0", Offset = "0x34C34E0", VA = "0x1834C40E0")]
	public static Coroutine BCAKHIGACHG(this MonoBehaviour BKGIHIBDAPA, float BJJEDIGOMGC, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x34C41B0", Offset = "0x34C35B0", VA = "0x1834C41B0")]
	public static Coroutine CHAAKFJCLIH(this MonoBehaviour BKGIHIBDAPA, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x34C42C0", Offset = "0x34C36C0", VA = "0x1834C42C0")]
	public static bool ILCBJMDIMJC(this MonoBehaviour BKGIHIBDAPA, int DGDDMBOMHPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KKAHDGDOALA
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x34CA760", Offset = "0x34C9B60", VA = "0x1834CA760")]
	public static string FHGHJHJNDFH(this UnityEngine.Object NLNHFEEMFBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ICMAPHMBBFM
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NEKCJLGOGKB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public Func<Collider, T> validateColliderFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public NEKCJLGOGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x22C01E0", Offset = "0x22BF5E0", VA = "0x1822C01E0")]
		internal bool <GetClosestRaycastHit>b__0(RaycastHit h)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JMJHJMKLADO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Func<Collider, float, T> validateColliderFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xF9EDD0", Offset = "0xF9E1D0", VA = "0x180F9EDD0")]
		public JMJHJMKLADO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x22BF650", Offset = "0x22BEA50", VA = "0x1822BF650")]
		internal bool <GetClosestSphereCastHit>b__0(RaycastHit h, float dSqr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly Collider[] DALFGEJDJMM;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly RaycastHit[] OEKJDIPLGML;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1308BA0", Offset = "0x1307FA0", VA = "0x181308BA0")]
	public static T LGLGLKGNLMN<T>(Vector3 CACFKFOOHID, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, T> JFJJCCHICDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x34C9D20", Offset = "0x34C9120", VA = "0x1834C9D20")]
	public static bool ILIFFJBJEIB(Ray OPMKFDNLHKI, float DJGCMOJICGK, out RaycastHit PAOKLBNMNFL, Func<RaycastHit, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x13087D0", Offset = "0x1307BD0", VA = "0x1813087D0")]
	public static T GDIGJECFAIH<T>(Vector3 CACFKFOOHID, float OMLBPICLALA, Vector3 DJBBMJBBNHB, int NNHBELIOIIM, float DJGCMOJICGK, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, float, T> JFJJCCHICDD, QueryTriggerInteraction CGAPEINEFPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x34C9700", Offset = "0x34C8B00", VA = "0x1834C9700")]
	public static Vector3 ABDJDBINPNA(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x34C9850", Offset = "0x34C8C50", VA = "0x1834C9850")]
	private static float HLJCBFHFBNC(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x34C99C0", Offset = "0x34C8DC0", VA = "0x1834C99C0")]
	public static bool HPMMIPJACPC(Ray OPMKFDNLHKI, float OMLBPICLALA, float DJGCMOJICGK, out RaycastHit HIFHEHIMEEM, Func<RaycastHit, float, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x34C97A0", Offset = "0x34C8BA0", VA = "0x1834C97A0")]
	public static void EOHKJJAHPKJ(this Rigidbody BECMPBBBFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x34C9F90", Offset = "0x34C9390", VA = "0x1834C9F90")]
	public static float JKFIAIEANPC(this PhysicMaterial OJLJGNPJMLL, PhysicMaterial KBKEIKNPLEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x34CA220", Offset = "0x34C9620", VA = "0x1834CA220")]
	private static float KPGODPAAHGJ(float LONDCJPNKKN, float PCEJJILDLGD, PhysicMaterialCombine DLNBOFMPEAO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class CEMMJOMPAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private Quaternion LDGGICNOHPP;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x950300", Offset = "0x94F700", VA = "0x180950300")]
	public CEMMJOMPAEL(Quaternion quaternion)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2ACFCE0", Offset = "0x2ACF0E0", VA = "0x182ACFCE0")]
	public static Quaternion FAJDMKOEFLH(CEMMJOMPAEL CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x34C2370", Offset = "0x34C1770", VA = "0x1834C2370")]
	public static CEMMJOMPAEL FAJDMKOEFLH(Quaternion CHBGHGPPLCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class AOGMKHCEPPO
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly float JJODNJHPABO;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly float DAJGEGINJHP;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x34BF630", Offset = "0x34BEA30", VA = "0x1834BF630")]
	public static Vector3 OBKNOLONKAG(this Quaternion IGPENJBJADK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x34BF530", Offset = "0x34BE930", VA = "0x1834BF530")]
	public static Quaternion LIGCJPMNEHL(this Quaternion CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x34BF000", Offset = "0x34BE400", VA = "0x1834BF000")]
	public static Quaternion FNBCAEAEPDN(this Quaternion GAAKKDLBBGK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x34BF1C0", Offset = "0x34BE5C0", VA = "0x1834BF1C0")]
	public static bool JNEMCKAMAMK(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x34BF170", Offset = "0x34BE570", VA = "0x1834BF170")]
	public static bool JCLKGFMMODE(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x34BF580", Offset = "0x34BE980", VA = "0x1834BF580")]
	public static Quaternion MHKNGOGEBNG(this Quaternion NPEOEMEENIK, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x34BEEB0", Offset = "0x34BE2B0", VA = "0x1834BEEB0")]
	public static Quaternion DKEHHDMGLPO(this Quaternion HICENEOPGOF, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x34BF760", Offset = "0x34BEB60", VA = "0x1834BF760")]
	public static Quaternion PHDAPBGIHIN(this Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x34BEF50", Offset = "0x34BE350", VA = "0x1834BEF50")]
	public static Quaternion FLNDPIEAFLK(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x34BF470", Offset = "0x34BE870", VA = "0x1834BF470")]
	public static Quaternion LBKFJAFFDJJ(Vector3 KHJFDILDLAD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x34BF210", Offset = "0x34BE610", VA = "0x1834BF210")]
	public static Vector3 KBILIJGGLPM(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x34BED30", Offset = "0x34BE130", VA = "0x1834BED30")]
	public static Quaternion DHBDEABFFIO(Quaternion JDJIGPDAIEA, Quaternion HEGDAEMJLDE, ref Vector3 FNBDKACNNFH, float MGKFFIBNPNF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EILMCJGGDJA
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x34C3E00", Offset = "0x34C3200", VA = "0x1834C3E00")]
	public static Rect INDNLPJJCNI(this Rect POMLCDIIKDM, Vector2 KPLDEODOJID)
	{
		return default(Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x34C3DB0", Offset = "0x34C31B0", VA = "0x1834C3DB0")]
	public static Vector2 EOPELBEEEID(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x34C3F70", Offset = "0x34C3370", VA = "0x1834C3F70")]
	public static Vector2 OCAPBHHPCHJ(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x34C3FC0", Offset = "0x34C33C0", VA = "0x1834C3FC0")]
	public static Vector2 OLLAHCIHKFM(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x34C3F20", Offset = "0x34C3320", VA = "0x1834C3F20")]
	public static Vector2 JANDCGIBIPJ(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x34C4010", Offset = "0x34C3410", VA = "0x1834C4010")]
	public static Rect OPCLGLPNBCN(this Rect POMLCDIIKDM)
	{
		return default(Rect);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GPEBDLJLJAJ
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly int GMFKHCBFDHO;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static readonly MaterialPropertyBlock PHLNNAPOEIP;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x34C8090", Offset = "0x34C7490", VA = "0x1834C8090")]
	public static Mesh ANIFOGABCAL(this Renderer CHEJPOIMMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x34C8240", Offset = "0x34C7640", VA = "0x1834C8240")]
	public static int JHIDBGOLCLD(this Renderer CHEJPOIMMCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x34C84D0", Offset = "0x34C78D0", VA = "0x1834C84D0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Color GJAINANBOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x34C85B0", Offset = "0x34C79B0", VA = "0x1834C85B0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, float ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x34C83F0", Offset = "0x34C77F0", VA = "0x1834C83F0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Vector4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x34C82F0", Offset = "0x34C76F0", VA = "0x1834C82F0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Matrix4x4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x34C8680", Offset = "0x34C7A80", VA = "0x1834C8680")]
	public static void NHHLALGBEPB(this Renderer CHEJPOIMMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x34C7EA0", Offset = "0x34C72A0", VA = "0x1834C7EA0")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x34C7D00", Offset = "0x34C7100", VA = "0x1834C7D00")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB, int NKJOCEKPCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class OMCHJHPFBDN
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x34CE190", Offset = "0x34CD590", VA = "0x1834CE190")]
	public static void KBFLHNONOHF(UnityEngine.Object BEKEOBJFIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x34CE250", Offset = "0x34CD650", VA = "0x1834CE250")]
	public static void KGFPNIMJHIC(GameObject DOJCFCINALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x34CE0D0", Offset = "0x34CD4D0", VA = "0x1834CE0D0")]
	public static void ANDJDDMACLM(Component CKCMODJNCNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class EBCHPKBHFLK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool ADEOMEKPMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x34C3700", Offset = "0x34C2B00", VA = "0x1834C3700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x34C3660", Offset = "0x34C2A60", VA = "0x1834C3660")]
	public static float KPCDDILAKBL()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FFENLNFBBPG
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x34C4390", Offset = "0x34C3790", VA = "0x1834C4390")]
	public static byte[] APEDNIKLMAA(string MEIIMAIGBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x34C44D0", Offset = "0x34C38D0", VA = "0x1834C44D0")]
	private static DownloadHandler LMDHNJOMGHJ(string MEIIMAIGBJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class HNMOAGNDOGF
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly Regex OOFCINNPFIB;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static readonly Regex MKNLKENNLJA;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x34C93A0", Offset = "0x34C87A0", VA = "0x1834C93A0")]
	public static string MMDNDBLHCEL(string BILLCLFKNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x34C9030", Offset = "0x34C8430", VA = "0x1834C9030")]
	public static string EMOFOGPOOLJ(string CKCGCFGOMAA, char JEEKALMPFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x34C90C0", Offset = "0x34C84C0", VA = "0x1834C90C0")]
	public static string FIJDNLILJFG(this string ONGBFDACHHG, int OMJLGGPHALE, string IEICOECHHLH = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x34C9600", Offset = "0x34C8A00", VA = "0x1834C9600")]
	public static int NPNNFCNGMID(this string ENMDDKHBHPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x34C9280", Offset = "0x34C8680", VA = "0x1834C9280")]
	public static bool LJGGMDGLNOO(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x34C9300", Offset = "0x34C8700", VA = "0x1834C9300")]
	public static bool MCOIBCNPNAP(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x34C9170", Offset = "0x34C8570", VA = "0x1834C9170")]
	public static bool IDLADJKDBBA(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x34C9270", Offset = "0x34C8670", VA = "0x1834C9270")]
	public static bool LJGBBKKGKOP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x34C9390", Offset = "0x34C8790", VA = "0x1834C9390")]
	public static bool MIABHAJOKBP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x34C8E80", Offset = "0x34C8280", VA = "0x1834C8E80")]
	public static bool AFNHOCAOHON(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x34C8F00", Offset = "0x34C8300", VA = "0x1834C8F00")]
	public static bool AFNHOCAOHON(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x34C9140", Offset = "0x34C8540", VA = "0x1834C9140")]
	public static bool FOKJGKHGHMG(this string CKCGCFGOMAA, string ONGBFDACHHG, out int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x34C9090", Offset = "0x34C8490", VA = "0x1834C9090")]
	public static bool FBFBJCMPOPJ(this string CKCGCFGOMAA, string ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x34C9210", Offset = "0x34C8610", VA = "0x1834C9210")]
	public static bool IIPIEIOOMCL(string IPHIIJNAEON, string FOJLJNMAJLC, StringComparison GAJDDOLCCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x34C95A0", Offset = "0x34C89A0", VA = "0x1834C95A0")]
	public static string NLGELJNDBLM(this string ENMDDKHBHPA, string GNJIBIELEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x34C8F90", Offset = "0x34C8390", VA = "0x1834C8F90")]
	public static string DNLAKCPLAPD(this string ENMDDKHBHPA, int MNIJHBJDPPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class EDBONCHIAND
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class POAHNJIPKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Color[] pixels;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC000", Offset = "0x3DB400", VA = "0x1803DC000")]
		public POAHNJIPKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x34CE310", Offset = "0x34CD710", VA = "0x1834CE310")]
		internal void <ConvertPixelsToGamma>b__0(int i)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x34C3BA0", Offset = "0x34C2FA0", VA = "0x1834C3BA0")]
	public static void MHKFJCHNJEE(this Texture2D CAKFKAGPMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x34C37B0", Offset = "0x34C2BB0", VA = "0x1834C37B0")]
	public static void FOFPEEMEIIC(this RenderTexture CNOGINOPPCH, ref Texture2D CAKFKAGPMBF, bool FKLJPOFDILI = false, bool LGJOOBAHIAC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CDCLKFOIBMC
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly Vector3[] ILMEMODIMEF;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x34C0AE0", Offset = "0x34BFEE0", VA = "0x1834C0AE0")]
	public static Vector3 CKMNPHLNJMA(this Transform OIFLDNBGJOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x34C0DD0", Offset = "0x34C01D0", VA = "0x1834C0DD0")]
	public static Vector3 CPLMAMCMLFN(this Transform OIFLDNBGJOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x34C1E80", Offset = "0x34C1280", VA = "0x1834C1E80")]
	public static Vector3 NFFAAMNNHGN(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x34C0970", Offset = "0x34BFD70", VA = "0x1834C0970")]
	public static Vector2 CJEBHAJDJMI(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x34C1330", Offset = "0x34C0730", VA = "0x1834C1330")]
	public static float ILCMBGMEPJE(this RectTransform AIOEKMHLKAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x34C1700", Offset = "0x34C0B00", VA = "0x1834C1700")]
	public static Vector3 JBLIBMEOLEB(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x34C1FD0", Offset = "0x34C13D0", VA = "0x1834C1FD0")]
	public static Vector3[] PHMOKHIOHDG(this RectTransform AIOEKMHLKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x34C1D70", Offset = "0x34C1170", VA = "0x1834C1D70")]
	public static Quaternion MHKNGOGEBNG(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x34C1050", Offset = "0x34C0450", VA = "0x1834C1050")]
	public static Quaternion DKEHHDMGLPO(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x34C1B30", Offset = "0x34C0F30", VA = "0x1834C1B30")]
	public static Vector3 MHEFIHAJMAD(this Transform OIFLDNBGJOH, Vector3 DDHPAFKBMON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x15AC0C0", Offset = "0x15AB4C0", VA = "0x1815AC0C0")]
	public static float LACCAFFAOIG(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x34C07A0", Offset = "0x34BFBA0", VA = "0x1834C07A0")]
	public static float ABDKFENDAKH(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x34C1880", Offset = "0x34C0C80", VA = "0x1834C1880")]
	public static void MCFLPFCGOOL(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x34C1530", Offset = "0x34C0930", VA = "0x1834C1530")]
	public static void IMCHPFPFLJJ(this Transform OIFLDNBGJOH, float MKDHFENOFDO, Vector3 KLNFHHBHGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x34C07D0", Offset = "0x34BFBD0", VA = "0x1834C07D0")]
	public static void CAIHJLKEPIF(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x34C0D00", Offset = "0x34C0100", VA = "0x1834C0D00")]
	public static float CPEJGKGFNJH(this Transform OIFLDNBGJOH, float PLIPOIMDGPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x34C1AB0", Offset = "0x34C0EB0", VA = "0x1834C1AB0")]
	public static float MDGALGDEFAK(this Transform OIFLDNBGJOH, float JIBDGOKLJOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x34C1110", Offset = "0x34C0510", VA = "0x1834C1110")]
	public static void FABLENJPHFB(this RectTransform AIOEKMHLKAL, Vector3[] NPPHHLLMGEM, [Optional] Canvas NKKFJKIMHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GDCPJCHDFJH
{
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x4C7BB0", Offset = "0x4C6FB0", VA = "0x1804C7BB0")]
	public static Vector2 KMEKBBFBKCA(Vector2 KDBHHDAJLNL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x34C7980", Offset = "0x34C6D80", VA = "0x1834C7980")]
	public static Vector2 KOLMGGDLPDK(this Vector2 PJEDBAONDPP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x34C7950", Offset = "0x34C6D50", VA = "0x1834C7950")]
	public static bool CDKDHNKFHFB(this Vector2 PDPPMFNOBMO, float ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x34C7A70", Offset = "0x34C6E70", VA = "0x1834C7A70")]
	public static float PAEBMOBFCGG(this Vector2 BANGBIKOBGO, Vector2 OALKOHJOHFO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OIJBIAMACNJ
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum KCNMMJEKPBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Up = 1,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Down = -1,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Right = 2,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Left = -2,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Forward = 3,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Back = -3
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly float ODOBHKFMCMK;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x34CC130", Offset = "0x34CB530", VA = "0x1834CC130")]
	public static Vector3 EMJNMOGIAKL(this IEnumerable<Vector3> COAEBIFOBNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x34CD1F0", Offset = "0x34CC5F0", VA = "0x1834CD1F0")]
	public static float NMDFDMBNFNA(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x34CDAC0", Offset = "0x34CCEC0", VA = "0x1834CDAC0")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Vector3 IDMBJGPOCAE, Vector3 MCEDKFKKOCM, Vector3 MJPDDCEFPIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x34CDCA0", Offset = "0x34CD0A0", VA = "0x1834CDCA0")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x34CD920", Offset = "0x34CCD20", VA = "0x1834CD920")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH, Vector3 EIHOAEHONBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x34CDDC0", Offset = "0x34CD1C0", VA = "0x1834CDDC0")]
	public static Vector3 PFLLEKCBAAL(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x34CD2B0", Offset = "0x34CC6B0", VA = "0x1834CD2B0")]
	public static bool OGIEHPPFJCB(this Vector3 BMOIJACGPLN, float LBLHBGPCEMF = 0.001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x34CCC20", Offset = "0x34CC020", VA = "0x1834CCC20")]
	public static bool ICGLFNNJKAC(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x34CC7F0", Offset = "0x34CBBF0", VA = "0x1834CC7F0")]
	public static bool HPKDFLEPPCG(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x34CC0A0", Offset = "0x34CB4A0", VA = "0x1834CC0A0")]
	public static float DGNGDMGOMAA(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x34CB900", Offset = "0x34CAD00", VA = "0x1834CB900")]
	public static float AHOKOGPDJNP(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x34CBFE0", Offset = "0x34CB3E0", VA = "0x1834CBFE0")]
	public static Vector3 DDGPCFJMGII(this Vector3 DINHOLEGEMB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x34CCE70", Offset = "0x34CC270", VA = "0x1834CCE70")]
	public static Vector3 JKGIHPNIJLK(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x34CBD80", Offset = "0x34CB180", VA = "0x1834CBD80")]
	public static Vector3 BNKOIHAECHN(this Vector3 PJEDBAONDPP, float NNNGNCNIJAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x34CBCA0", Offset = "0x34CB0A0", VA = "0x1834CBCA0")]
	public static bool BECDFHKOIGK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x34CD080", Offset = "0x34CC480", VA = "0x1834CD080")]
	public static bool JNEMCKAMAMK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x34CCDD0", Offset = "0x34CC1D0", VA = "0x1834CCDD0")]
	public static bool JCLKGFMMODE(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x34CBCF0", Offset = "0x34CB0F0", VA = "0x1834CBCF0")]
	public static Vector3 BMNFGJPMFBG(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x34CD3E0", Offset = "0x34CC7E0", VA = "0x1834CD3E0")]
	public static Vector3 OHHOPADHBAL(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x34CC410", Offset = "0x34CB810", VA = "0x1834CC410")]
	public static float FLEMBFIOFJA(this Vector3 BANGBIKOBGO, Vector3 OALKOHJOHFO, [Optional] Vector3? KNIKPKEBLNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x34CD1D0", Offset = "0x34CC5D0", VA = "0x1834CD1D0")]
	public static Vector3 NELNDENOBLC(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x34CC860", Offset = "0x34CBC60", VA = "0x1834CC860")]
	public static Vector3 IBPJJIDHFFL(Vector3 CHGNDIAMGLF, Quaternion IBCNKFBPCBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x34CD470", Offset = "0x34CC870", VA = "0x1834CD470")]
	public static KCNMMJEKPBC OJDKGBIHNJD(Transform OIFLDNBGJOH, Vector3 MAPAFOGPKLL, out Vector3 GLHHBDHELAO)
	{
		return default(KCNMMJEKPBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x34CC5D0", Offset = "0x34CB9D0", VA = "0x1834CC5D0")]
	public static Vector3 GKDMJPGOEHO(float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x34CC7C0", Offset = "0x34CBBC0", VA = "0x1834CC7C0")]
	public static Vector3 HOCFJJAOPDC(float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x34CBFB0", Offset = "0x34CB3B0", VA = "0x1834CBFB0")]
	public static Vector3 CLEFGACGMKH(float FOBCKBCBJHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x34CC6C0", Offset = "0x34CBAC0", VA = "0x1834CC6C0")]
	public static Vector3 GNOENAFKJIE(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x34CD0E0", Offset = "0x34CC4E0", VA = "0x1834CD0E0")]
	public static Vector3 KICDFOACKEL(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x34CCE30", Offset = "0x34CC230", VA = "0x1834CCE30")]
	public static Vector3 JJOELJJFBAE(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x34CBEF0", Offset = "0x34CB2F0", VA = "0x1834CBEF0")]
	public static Vector3 CIOKEDCFPJI(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x34CDEF0", Offset = "0x34CD2F0", VA = "0x1834CDEF0")]
	public static Vector3 PGCOBFHPJEA(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x34CDFB0", Offset = "0x34CD3B0", VA = "0x1834CDFB0")]
	public static Vector3 PLINJEJIIMO(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x34CBBE0", Offset = "0x34CAFE0", VA = "0x1834CBBE0")]
	public static Vector3 BCICENEBNCF(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x34CC600", Offset = "0x34CBA00", VA = "0x1834CC600")]
	public static Vector3 GMNHMHPHIJK(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x34CD120", Offset = "0x34CC520", VA = "0x1834CD120")]
	public static Vector3 KKANLJKPHJI(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x34CC700", Offset = "0x34CBB00", VA = "0x1834CC700")]
	public static Vector3 HCLHKJPLONK(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x34CCC90", Offset = "0x34CC090", VA = "0x1834CCC90")]
	public static Vector3 IKBIEPLCAKN(Vector3 HGEIABGCFOA, Vector3 IBHEKLCMMNH, Vector3 KNIKPKEBLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x34CB990", Offset = "0x34CAD90", VA = "0x1834CB990")]
	public static Vector3 AOGDEGACCAP(Vector3 PJEDBAONDPP, Vector3 OOEKLKBHAHK, Vector3 AIOJLAJOCEL, bool PNLBALPIOHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x34CCF30", Offset = "0x34CC330", VA = "0x1834CCF30")]
	public static float JMAEBJBJADJ(this Vector3 BANGBIKOBGO, Vector3 OALKOHJOHFO, Vector3 JKKKLNNDOCL, bool DBIKMABANKE = false)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FNHMBIFJJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x34C7660", Offset = "0x34C6A60", VA = "0x1834C7660")]
	public static Quaternion CHDHKJJADFE(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x15AC0F0", Offset = "0x15AB4F0", VA = "0x1815AC0F0")]
	public static Vector3 DOAOMJFMLLN(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x34C77A0", Offset = "0x34C6BA0", VA = "0x1834C77A0")]
	public static Vector3 OHAKMAOEKCG(this Matrix4x4 BKPMKIIFPKO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IJHPIMJMEIB
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1476470", Offset = "0x1475870", VA = "0x181476470")]
	public static void FKDAJGGOMOC<T>(ref NativeArray<T> JABGABGMHPL, int LNABDPGDHED, Allocator OOEBGBHDEOK) where T : struct
	{
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
