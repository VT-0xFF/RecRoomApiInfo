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

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public HPIEIOAGEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D3F0", Offset = "0x1A8C1F0", VA = "0x181A8D3F0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public IEKPHHLNIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1A8D430", Offset = "0x1A8C230", VA = "0x181A8D430")]
		internal string <ToFriendlyString>b__1(string s, string s1)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C350", Offset = "0x1B4B150", VA = "0x181B4C350")]
	public static string JIIMHOLCECD<T>(this IEnumerable<T> NKLIOLCGIDM, [Optional] Func<T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BEA0", Offset = "0x1B4ACA0", VA = "0x181B4BEA0")]
	public static string JIIMHOLCECD<T>(this IList<T> DAAFDLFCOGO, [Optional] Func<int, T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x13E9D10", Offset = "0x13E8B10", VA = "0x1813E9D10")]
	[IteratorStateMachine(typeof(AEABJMALBDK))]
	public static IEnumerable<T> MJJDFHHAOPM<T>(T IOBEPGLJNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1B4B2C0", Offset = "0x1B4A0C0", VA = "0x181B4B2C0")]
	public static (T[], U[]) HKJNIHLKENA<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x137F60", Offset = "0x137360")] this IEnumerable<(T, U)> NMELNILPPKN)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x19581E0", Offset = "0x1956FE0", VA = "0x1819581E0")]
	public static IEnumerable<(T, int)> AKGEGLEMFGM<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BA50", Offset = "0x1B4A850", VA = "0x181B4BA50")]
	public static void HOAGBPIIIGP<T>(this IEnumerable<T> NMELNILPPKN, Action<T> EDECJKLDKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1771D50", Offset = "0x1770B50", VA = "0x181771D50")]
	public static HashSet<T> PBGCPCJGGOO<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x19583A0", Offset = "0x19571A0", VA = "0x1819583A0")]
	public static IEnumerable<T> HDLDCPJDNDA<T>(this IEnumerable<T> NKLIOLCGIDM, int KKDPFGADCEK, int MADNOGDODFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x19583E0", Offset = "0x19571E0", VA = "0x1819583E0")]
	public static IEnumerable<T> KPDAENONKPJ<T, TKey>(this IEnumerable<T> NKLIOLCGIDM, Func<T, TKey> HDLMHEHINBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1B4BC00", Offset = "0x1B4AA00", VA = "0x181B4BC00")]
	public static T? ILPGDGMLKDH<T>(this IEnumerable<T> NMELNILPPKN, Func<T, bool> HBPBAJNLGCP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CEEHAKJPFHM
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x381C5A0", Offset = "0x381B3A0", VA = "0x18381C5A0")]
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
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3825C90", Offset = "0x3824A90", VA = "0x183825C90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static float JHAFCFMBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x924780", Offset = "0x923580", VA = "0x180924780")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static float DGEAEHEJCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3825C20", Offset = "0x3824A20", VA = "0x183825C20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3825CA0", Offset = "0x3824AA0", VA = "0x183825CA0")]
	public static float HDHMLEOEOJP(float MOPKOPOKKEE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LHIJJLMMMHM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3825E60", Offset = "0x3824C60", VA = "0x183825E60")]
	public static bool BKDAHHMFHMC(this DateTime? PBMJJOMBPAH, TimeSpan DOFKHNLEKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3825F90", Offset = "0x3824D90", VA = "0x183825F90")]
	public static string PAKENNFHMEG(this TimeSpan DOFKHNLEKKP, string FEGAGLFEGEP = "minute", bool JKEPCLNFJHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3825F00", Offset = "0x3824D00", VA = "0x183825F00")]
	private static string HIDOGKBNNLG(string IGCKACBLCON, double KEOKDMNJJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IEDIJNKECOL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3824BC0", Offset = "0x38239C0", VA = "0x183824BC0")]
	public static string MJHFHBGFJHF(this Type GEDCEIDOKJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LFDJHEDEGAJ
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3825D20", Offset = "0x3824B20", VA = "0x183825D20")]
	public static void DBCCNEMNLNI(this Animator LDOJFIEANFB, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3825DA0", Offset = "0x3824BA0", VA = "0x183825DA0")]
	public static void DOMIGIEBFCF(this Animator LDOJFIEANFB, int ENJEOLBEALP, bool ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3825E00", Offset = "0x3824C00", VA = "0x183825E00")]
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

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2200A30", Offset = "0x21FF830", VA = "0x182200A30")]
			public JONDMKIDPLE(int HKPHMBLKPFI, int DJICGHFJJJP, bool GOJFBEJBPBC)
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

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2208A00", Offset = "0x2207800", VA = "0x182208A00")]
		public MKNPILCJOAI(T[] GMOGECKNEEN, IGHKKHEGGBB<T> BKHGMOKDLGO, int DCFEFKGJDOJ, Func<bool> AEMDDGKHONP, T[] CJDMEOAEMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2208640", Offset = "0x2207440", VA = "0x182208640")]
		public bool CDHNACEAFJL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x239C340", Offset = "0x239B140", VA = "0x18239C340")]
	public static T[] APNIJAHEGLJ<T>(int OJJOHDIFMEG, T MCACHDBIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1A501E0", Offset = "0x1A4EFE0", VA = "0x181A501E0")]
	public static void KDEILFALGLM<T>(this T[] JABGABGMHPL, T MCACHDBIALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1A4FC90", Offset = "0x1A4EA90", VA = "0x181A4FC90")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1A4FA90", Offset = "0x1A4E890", VA = "0x181A4FA90")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA, int OIDPFPMBCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1A4FD20", Offset = "0x1A4EB20", VA = "0x181A4FD20")]
	public static void CDLEKIKHHCD<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO, [Optional] T[] CJDMEOAEMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1A4FDC0", Offset = "0x1A4EBC0", VA = "0x181A4FDC0")]
	private static void JIHBNKEBJDH<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int DJICGHFJJJP, T[] EPDKOCHMOLC, bool GOJFBEJBPBC, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1A50350", Offset = "0x1A4F150", VA = "0x181A50350")]
	private static void MNMAEDHAEFJ<T>(this T[] NMELNILPPKN, int ANDOICCNDLA, int GFKCDKBFBBN, T[] HPKICPNGMDJ, int MDIFJBFIGHL, int PPNMMGMDEJI, T[] GIAOBLMEMMI, int CAPPAKEKPLG, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1A50780", Offset = "0x1A4F580", VA = "0x181A50780")]
	public static void OIEHNKDGJKK<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int MNIJHBJDPPA, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x177E710", Offset = "0x177D510", VA = "0x18177E710")]
	public static MKNPILCJOAI<T> JKMCDDAPLHN<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO, int DCFEFKGJDOJ, Func<bool> AEMDDGKHONP, [Optional] T[] CJDMEOAEMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x239CCC0", Offset = "0x239BAC0", VA = "0x18239CCC0")]
	public static T[] NHGMLEGCCMP<T>(this T[] OPEBNMBKJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x239CCE0", Offset = "0x239BAE0", VA = "0x18239CCE0")]
	public static T[] PPMHFINCJNE<T>(this T[] IHFOIAODAJC, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x239C670", Offset = "0x239B470", VA = "0x18239C670")]
	public static T[] DECCCEINGDI<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x239CC10", Offset = "0x239BA10", VA = "0x18239CC10")]
	public static T[] HNNOENGPBPL<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x239C450", Offset = "0x239B250", VA = "0x18239C450")]
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

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3823380", Offset = "0x3822180", VA = "0x183823380")]
		public HKLGKBLGDMN(GameObject DOJCFCINALC, bool AHOAECJDPGH, NCHPJLFOHGM MPBIKBNEFGP, bool CLAOPEDMPGL, Type GEDCEIDOKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3822CD0", Offset = "0x3821AD0", VA = "0x183822CD0", Slot = "4")]
		public bool Equals(HKLGKBLGDMN HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3822C30", Offset = "0x3821A30", VA = "0x183822C30", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3822DE0", Offset = "0x3821BE0", VA = "0x183822DE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3822EA0", Offset = "0x3821CA0", VA = "0x183822EA0", Slot = "3")]
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

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x381EEF0", Offset = "0x381DCF0", VA = "0x18381EEF0")]
	public static void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1B8A940", Offset = "0x1B89740", VA = "0x181B8A940")]
	public static T FABKIOBNCHE<T>(this GameObject DOJCFCINALC, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1B8AC10", Offset = "0x1B89A10", VA = "0x181B8AC10")]
	public static T JLOAAIEKGLO<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1B8AD30", Offset = "0x1B89B30", VA = "0x181B8AD30")]
	public static T MHBNENBBNDJ<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1934230", Offset = "0x1933030", VA = "0x181934230")]
	public static IReadOnlyList<T> HLCNADOGJFC<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1934730", Offset = "0x1933530", VA = "0x181934730")]
	public static IReadOnlyList<T> PHJEODMHDOK<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1B8AA50", Offset = "0x1B89850", VA = "0x181B8AA50")]
	private static T JGCKGHNCPPC<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1934480", Offset = "0x1933280", VA = "0x181934480")]
	private static IReadOnlyList<T> OFLKKOAGMFK<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x381EE50", Offset = "0x381DC50", VA = "0x18381EE50")]
	private static void KIPECKHDOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x381EA40", Offset = "0x381D840", VA = "0x18381EA40")]
	private static void JOMBFKGNCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1934630", Offset = "0x1933430", VA = "0x181934630")]
	private static IReadOnlyList<T> OIJCNPEICPD<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1934350", Offset = "0x1933150", VA = "0x181934350")]
	private static IReadOnlyList<T> MAALAKFHBNE<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BOHNIEMGLMC
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x381A300", Offset = "0x3819100", VA = "0x18381A300")]
	public static float ELCHENEAFFD(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x381A970", Offset = "0x3819770", VA = "0x18381A970")]
	public static float OOIKMLIOLHN(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x381A7A0", Offset = "0x38195A0", VA = "0x18381A7A0")]
	public static float KCHIFOHABON(this Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x381A100", Offset = "0x3818F00", VA = "0x18381A100")]
	private static float DBBKCKNDNOJ(float PPLEDBHELNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x381A170", Offset = "0x3818F70", VA = "0x18381A170")]
	private static float DBBKCKNDNOJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x381A5A0", Offset = "0x38193A0", VA = "0x18381A5A0")]
	private static float FMJNGGHKBNJ(float PPLEDBHELNG, float EHDMLFDEBAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x381A560", Offset = "0x3819360", VA = "0x18381A560")]
	private static float FMJNGGHKBNJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x381A450", Offset = "0x3819250", VA = "0x18381A450")]
	public static float FGCPIGKOIHD(float PPLEDBHELNG, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x381A330", Offset = "0x3819130", VA = "0x18381A330")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x381A370", Offset = "0x3819170", VA = "0x18381A370")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, Vector2 IJHJIKGDNJH, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x381A050", Offset = "0x3818E50", VA = "0x18381A050")]
	private static float CIMKJKMKPGG(float DABFKGJPFDC, float IJHJIKGDNJH, float PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x381A620", Offset = "0x3819420", VA = "0x18381A620")]
	public static float JKGBBKLIAMK(float GGJOIJAKDDC, float EHDMLFDEBAF, Vector2 IJHJIKGDNJH, float HGFAGBNEADJ, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x381A8B0", Offset = "0x38196B0", VA = "0x18381A8B0")]
	private static float NEANFKGDFBM(float DABFKGJPFDC, float IJHJIKGDNJH, float HGFAGBNEADJ, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x381A1F0", Offset = "0x3818FF0", VA = "0x18381A1F0")]
	public static void DBJKGNBKPDI(this Camera FOMHGMLPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x381A850", Offset = "0x3819650", VA = "0x18381A850")]
	public static bool LPBHGEJLJKD(this Camera FOMHGMLPOND, Renderer CHEJPOIMMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x381A280", Offset = "0x3819080", VA = "0x18381A280")]
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

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x381D310", Offset = "0x381C110", VA = "0x18381D310")]
	public static bool HAKOLMGKNPH(this Collider GLPOLGOBLAA, Vector3 KMIFDIBBCDI, Vector3 EDKKBNDGKAO, float OMLBPICLALA, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, out RaycastHit IIILNCEEBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x381C8E0", Offset = "0x381B6E0", VA = "0x18381C8E0")]
	public static int AMAOMIJGJBF(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, Collider[] GIJOIBPGGOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x381D070", Offset = "0x381BE70", VA = "0x18381D070")]
	public static bool FKFGLHIBHJC(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x381D860", Offset = "0x381C660", VA = "0x18381D860")]
	public static int NBOGLHFIMJA(this BoxCollider GLPOLGOBLAA, Collider[] PANOGCJFAOD, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x381D670", Offset = "0x381C470", VA = "0x18381D670")]
	public static bool KCFPIEEMJON(this BoxCollider CEGIONPIIAO, Vector3 NAIDPMBKHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x381CCB0", Offset = "0x381BAB0", VA = "0x18381CCB0")]
	public static bool FKFGLHIBHJC(this CapsuleCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x381D5E0", Offset = "0x381C3E0", VA = "0x18381D5E0")]
	public static Vector3 HHNMMNMLAMF(this BoxCollider GLPOLGOBLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x381CBA0", Offset = "0x381B9A0", VA = "0x18381CBA0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3825B30", Offset = "0x3824930", VA = "0x183825B30")]
	public static Color FKDFDGMNNLG(this Color GJAINANBOCB, float FBPFONBFPEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3825A40", Offset = "0x3824840", VA = "0x183825A40")]
	public static Vector3 AHOMKMDCPOH(this Vector3 DKIELBAENOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3825940", Offset = "0x3824740", VA = "0x183825940")]
	public static Color AHOMKMDCPOH(this Color DKIELBAENOL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3825B70", Offset = "0x3824970", VA = "0x183825B70")]
	public static Color LGPCCFOGKGG(this Color GJAINANBOCB, float IOAMFOPBCMN)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BEBOIKCDHFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3819A80", Offset = "0x3818880", VA = "0x183819A80")]
	public static void OFKIHGPJHJI(this Component CKCMODJNCNF, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x192FDF0", Offset = "0x192EBF0", VA = "0x18192FDF0")]
	public static List<T> PFOKAFNFHHM<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1B84DC0", Offset = "0x1B83BC0", VA = "0x181B84DC0")]
	public static T LNJIMABEJLG<T>(this Component CKCMODJNCNF, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EJFNMBLOPLC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1958C20", Offset = "0x1957A20", VA = "0x181958C20")]
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
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x445B90", Offset = "0x444990", VA = "0x180445B90")]
		[DebuggerHidden]
		public AFMAGHBPHLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3818E50", Offset = "0x3817C50", VA = "0x183818E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3818F00", Offset = "0x3817D00", VA = "0x183818F00", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x445B90", Offset = "0x444990", VA = "0x180445B90")]
		[DebuggerHidden]
		public EGJGCHCIGPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x381E1C0", Offset = "0x381CFC0", VA = "0x18381E1C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x381E270", Offset = "0x381D070", VA = "0x18381E270", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static WaitForEndOfFrame NAKHMEPNJEL;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3824E90", Offset = "0x3823C90", VA = "0x183824E90")]
	[IteratorStateMachine(typeof(AFMAGHBPHLI))]
	public static IEnumerator BCAKHIGACHG(float CAHAMMIHDFG, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3824F00", Offset = "0x3823D00", VA = "0x183824F00")]
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
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3824DB0", Offset = "0x3823BB0", VA = "0x183824DB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3824D80", Offset = "0x3823B80", VA = "0x183824D80")]
	public IGHCGCAGAFH(float HABFNPMBADP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CDHKGKPIOLK
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x23831F0", Offset = "0x2381FF0", VA = "0x1823831F0")]
	public static TValue KGAPEMHMJHI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG) where TValue : new()
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2383490", Offset = "0x2382290", VA = "0x182383490")]
	public static TValue PLOELFMPHEI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2382E30", Offset = "0x2381C30", VA = "0x182382E30")]
	public static TValue GLPALAONCFG<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FKFGKDOBBOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3821A30", Offset = "0x3820830", VA = "0x183821A30")]
	public static string CPIKLJJCBAB(this Guid COFLAJFOPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3821950", Offset = "0x3820750", VA = "0x183821950")]
	public static string CPIKLJJCBAB(this byte[] MGPDDEMABPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LBEHNMANHHL
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3825050", Offset = "0x3823E50", VA = "0x183825050")]
	public static string GKBCGFOAIJM(this FileInfo NOHHLFHPPDF, string IFKMFOPALAO, string EAEOAIMAJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3825200", Offset = "0x3824000", VA = "0x183825200")]
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
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x76B9E0", Offset = "0x76A7E0", VA = "0x18076B9E0")]
		[DebuggerHidden]
		public BJBOHHCEKDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3819E70", Offset = "0x3818C70", VA = "0x183819E70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x381A000", Offset = "0x3818E00", VA = "0x18381A000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3819F60", Offset = "0x3818D60", VA = "0x183819F60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3819F60", Offset = "0x3818D60", VA = "0x183819F60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IBABGMDJILM : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private GameObject <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private GameObject gameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public GameObject <>3__gameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform <parent>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		GameObject IEnumerator<GameObject>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x3F5F40", Offset = "0x3F4D40", VA = "0x1803F5F40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76B9E0", Offset = "0x76A7E0", VA = "0x18076B9E0")]
		[DebuggerHidden]
		public IBABGMDJILM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3823D50", Offset = "0x3822B50", VA = "0x183823D50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x3823ED0", Offset = "0x3822CD0", VA = "0x183823ED0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3823E30", Offset = "0x3822C30", VA = "0x183823E30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<GameObject> IEnumerable<GameObject>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3823E30", Offset = "0x3822C30", VA = "0x183823E30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Dictionary<int, int> IKJIECFLKJL;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1B90280", Offset = "0x1B8F080", VA = "0x181B90280")]
	public static T LNJIMABEJLG<T>(this GameObject DOJCFCINALC, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1B901D0", Offset = "0x1B8EFD0", VA = "0x181B901D0")]
	public static T GLENGLDKGCK<T>(this GameObject DOJCFCINALC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1B901A0", Offset = "0x1B8EFA0", VA = "0x181B901A0")]
	public static T GLENGLDKGCK<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D840", Offset = "0x1A4C640", VA = "0x181A4D840")]
	public static void IFFLOPMPLPN<T>(this GameObject DOJCFCINALC, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D790", Offset = "0x1A4C590", VA = "0x181A4D790")]
	public static void IFFLOPMPLPN<T>(this Component CKCMODJNCNF, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D8F0", Offset = "0x1A4C6F0", VA = "0x181A4D8F0")]
	public static void OPKLCCBLMCM<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3825700", Offset = "0x3824500", VA = "0x183825700")]
	public static void OLLDCMIMDLM(this GameObject DOJCFCINALC, string GHBNIGCAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3825390", Offset = "0x3824190", VA = "0x183825390")]
	public static string AOEFKLMCCGH(this GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x38254C0", Offset = "0x38242C0", VA = "0x1838254C0")]
	[IteratorStateMachine(typeof(BJBOHHCEKDF))]
	private static IEnumerable<string> CLDAIOKJMCC(GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x38255A0", Offset = "0x38243A0", VA = "0x1838255A0")]
	public static int MOOKPIOIGOD(this GameObject NLNHFEEMFBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3825530", Offset = "0x3824330", VA = "0x183825530")]
	[IteratorStateMachine(typeof(IBABGMDJILM))]
	public static IEnumerable<GameObject> FCLNGNIMAOG(this GameObject DOJCFCINALC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class LOJLAODGLLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1E67E50", Offset = "0x1E66C50", VA = "0x181E67E50")]
	public static V ODHHPEIEBCB<V, T>(this T LIMOILDIGKF, Func<T, V> PAFOMEECIMH, [Optional] V OANDOPIEEPO) where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1A4D9B0", Offset = "0x1A4C7B0", VA = "0x181A4D9B0")]
	public static void CLELOGIOOCO<T>(this T LIMOILDIGKF, Action<T> PAFOMEECIMH) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class ECNNGIFNNNM
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1861B90", Offset = "0x1860990", VA = "0x181861B90")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> OPEBNMBKJJA, T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1B4FE60", Offset = "0x1B4EC60", VA = "0x181B4FE60")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1B4FEF0", Offset = "0x1B4ECF0", VA = "0x181B4FEF0")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO, int KIJHGBLLCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1930C80", Offset = "0x192FA80", VA = "0x181930C80")]
	public static List<T> FHAOCJFENEF<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1861AC0", Offset = "0x18608C0", VA = "0x181861AC0")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> DAAFDLFCOGO, Predicate<T> HBPBAJNLGCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1860A50", Offset = "0x185F850", VA = "0x181860A50")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1D77030", Offset = "0x1D75E30", VA = "0x181D77030")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP, EqualityComparer<T> KFBHPCHEJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1860EB0", Offset = "0x185FCB0", VA = "0x181860EB0")]
	public static int IBKMBGJGECB<TElement, TKey>(this IList<TElement> LLOIOFKDLFP, TKey IFHDIPBMJOI, Func<TElement, TKey> IHHAGJMACDJ, [Optional] Func<TKey, TKey, int> BKHGMOKDLGO, int EFBDCIJMFGD = 0, [Optional] int? MNIJHBJDPPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1B89550", Offset = "0x1B88350", VA = "0x181B89550")]
	public static T NBMJEPIPHGC<T>(this IReadOnlyList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1D77560", Offset = "0x1D76360", VA = "0x181D77560")]
	public static bool KFDLNLFOGBN<T>(this List<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1B506F0", Offset = "0x1B4F4F0", VA = "0x181B506F0")]
	public static void AINCGKKANMC<T>(this List<T> DAAFDLFCOGO, IEnumerable<T> CGBHMNCBAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1B89490", Offset = "0x1B88290", VA = "0x181B89490")]
	public static T NBMJEPIPHGC<T>(this T[] DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1B508D0", Offset = "0x1B4F6D0", VA = "0x181B508D0")]
	public static void OHDOOOKOMNB<T>(this List<T> CGBHMNCBAGA) where T : UnityEngine.Object
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1B892D0", Offset = "0x1B880D0", VA = "0x181B892D0")]
	public static T LLFCJKLELNH<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1B88D40", Offset = "0x1B87B40", VA = "0x181B88D40")]
	public static T BMCEKIFDDJK<T>(this List<T> CGBHMNCBAGA, int EFBDCIJMFGD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D75950", Offset = "0x1D74750", VA = "0x181D75950")]
	public static bool IDCGECLDIDG<T>(this List<T> LNFKAGBJHOA, List<T> ADFLPMKFAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1B89150", Offset = "0x1B87F50", VA = "0x181B89150")]
	public static T GPEBLICLPML<T>(this IList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1D775D0", Offset = "0x1D763D0", VA = "0x181D775D0")]
	public static bool MGIGDPBNABL<T>(IReadOnlyList<T> DAAFDLFCOGO, int EFBDCIJMFGD, out T GIAOBLMEMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D76D40", Offset = "0x1D75B40", VA = "0x181D76D40")]
	public static bool JEACGAIICGO<T>(IReadOnlyList<T> DAAFDLFCOGO, ICollection CGBHMNCBAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1B505E0", Offset = "0x1B4F3E0", VA = "0x181B505E0")]
	public static void AEONHOJKJNI<T>(IReadOnlyList<T> DAAFDLFCOGO, ref ICollection CGBHMNCBAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1902A50", Offset = "0x1901850", VA = "0x181902A50")]
	public static bool LJGBBKKGKOP<T>(this IReadOnlyList<T> DAAFDLFCOGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class GEKPCDJEJAK
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2247990", Offset = "0x2246790", VA = "0x182247990")]
	public static void BLPOBJABAMH(this Material ENKBCLEDIFA, string NKILHMDECHA, bool CBHMNNAINHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FJFHDHBBFKE
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly List<float> OIPOGHOKFJP;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static readonly List<float> LHGBMOHCGGC;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3820B40", Offset = "0x381F940", VA = "0x183820B40")]
	public static bool MOHPPAOIEMG(int ONGBFDACHHG, int GOICNKGDJEC, int KEBJAIELILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x38215F0", Offset = "0x38203F0", VA = "0x1838215F0")]
	public static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x381F960", Offset = "0x381E760", VA = "0x18381F960")]
	public static float GDKJPBLEGLK(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3820B60", Offset = "0x381F960", VA = "0x183820B60")]
	public static void NADMLFBBFJB(Vector3 JLCIKNNKEAD, out float LMMPJCFJDOL, out float NOFFCKDIOEP, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3820EF0", Offset = "0x381FCF0", VA = "0x183820EF0")]
	public static void NPCJFNAJALO(Vector3 JLCIKNNKEAD, out float LBJOIGNPPFB, out float CEOHNIOICHD, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x38217B0", Offset = "0x38205B0", VA = "0x1838217B0")]
	public static Vector3 PDLGILNJNGC(float LMMPJCFJDOL, float NOFFCKDIOEP, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x381F7F0", Offset = "0x381E5F0", VA = "0x18381F7F0")]
	public static Vector3 FNKFOCAIBGE(float LBJOIGNPPFB, float CEOHNIOICHD, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x381FDC0", Offset = "0x381EBC0", VA = "0x18381FDC0")]
	public static Vector3 HMGHBDPPJAG(Vector3 BBMDCKFFPCE, Vector3 JIOIOMDOAJA, Vector3 KHCCKHOEOKP, Vector3 IJGHHKBAIDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x381F420", Offset = "0x381E220", VA = "0x18381F420")]
	public static bool CFKHNLPBCCE(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3820640", Offset = "0x381F440", VA = "0x183820640")]
	public static float MBLIIPEMOGB(Ray FAACBOBPIKK, Ray HEGDAEMJLDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3821130", Offset = "0x381FF30", VA = "0x183821130")]
	private static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC, float BANKGLOHKOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x381F020", Offset = "0x381DE20", VA = "0x18381F020")]
	public static bool BAHBPFFNNJO(float IPHIIJNAEON, float FOJLJNMAJLC, float CIIMMENGOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x381F4F0", Offset = "0x381E2F0", VA = "0x18381F4F0")]
	public static Vector3 DBDLNMAONIL(Vector3 KPLDEODOJID, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x381F650", Offset = "0x381E450", VA = "0x18381F650")]
	public static Vector3 EAEOKLNFADK(Vector3 DJBBMJBBNHB, Vector3 CKPHGEEPNDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x381FA50", Offset = "0x381E850", VA = "0x18381FA50")]
	public static void GEFDMDGMEBM(Transform OIFLDNBGJOH, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH, Vector3 AADLCEBLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x381FF90", Offset = "0x381ED90", VA = "0x18381FF90")]
	public static Vector3 JPGHEAINBKJ(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float PIHLBMOKPFJ, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3820C40", Offset = "0x381FA40", VA = "0x183820C40")]
	public static Vector3 NDEFIIAMEPM(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x381F0B0", Offset = "0x381DEB0", VA = "0x18381F0B0")]
	private static float BNGIECEAJKA(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3820ED0", Offset = "0x381FCD0", VA = "0x183820ED0")]
	public static float NKBLAPMGFEN(float FLIEBIMFHEN, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3821790", Offset = "0x3820590", VA = "0x183821790")]
	public static float PCHIOIGDICJ(float JDFENOCNKAD, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3821010", Offset = "0x381FE10", VA = "0x183821010")]
	public static float OMBOKJDOGMI(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x381F360", Offset = "0x381E160", VA = "0x18381F360")]
	public static void BOIDIABHGLA(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI, out float AHCGFILIFFM, out float MEMDHFDMDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x381FF50", Offset = "0x381ED50", VA = "0x18381FF50")]
	public static float JBLAJMCFLIK(this float ONGBFDACHHG, Vector2 LMBJKPOFNJA, Vector2 LNMOFOCDKEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3820610", Offset = "0x381F410", VA = "0x183820610")]
	public static float LAFFGDDLOFP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x24B1020", Offset = "0x24AFE20", VA = "0x1824B1020")]
	public static float DGKGLMIIKNG(this float NIONDACONFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3820AB0", Offset = "0x381F8B0", VA = "0x183820AB0")]
	public static float MJKHBBDDDBL(int DBCLLCJFNJM = 30)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x38203E0", Offset = "0x381F1E0", VA = "0x1838203E0")]
	public static Vector3 KEFKCKMCCEG(Vector3 GEOFMLLGABC, Vector3 ILOMMBLNKMA, float GAIPDLMAPJP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FCDBKMOEJMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x38123F0", Offset = "0x38111F0", VA = "0x1838123F0")]
	public static bool DFIECMNBGCO(this MonoBehaviour BKGIHIBDAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x381E740", Offset = "0x381D540", VA = "0x18381E740")]
	public static void OMNDHPIFFEM(this MonoBehaviour BKGIHIBDAPA, Coroutine NEPMGGPMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x381E6B0", Offset = "0x381D4B0", VA = "0x18381E6B0")]
	public static void GLFCOPMIKLH(this MonoBehaviour BKGIHIBDAPA, IDisposable KECNNGMBHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x381E520", Offset = "0x381D320", VA = "0x18381E520")]
	public static Coroutine BCAKHIGACHG(this MonoBehaviour BKGIHIBDAPA, float BJJEDIGOMGC, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x381E5F0", Offset = "0x381D3F0", VA = "0x18381E5F0")]
	public static Coroutine CHAAKFJCLIH(this MonoBehaviour BKGIHIBDAPA, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x381E700", Offset = "0x381D500", VA = "0x18381E700")]
	public static bool ILCBJMDIMJC(this MonoBehaviour BKGIHIBDAPA, int DGDDMBOMHPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class KKAHDGDOALA
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3824FC0", Offset = "0x3823DC0", VA = "0x183824FC0")]
	public static string FHGHJHJNDFH(this UnityEngine.Object NLNHFEEMFBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class ICMAPHMBBFM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NEKCJLGOGKB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Func<Collider, T> validateColliderFunc;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public NEKCJLGOGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2514BF0", Offset = "0x25139F0", VA = "0x182514BF0")]
		internal bool <GetClosestRaycastHit>b__0(RaycastHit h)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class JMJHJMKLADO<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Func<Collider, float, T> validateColliderFunc;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x118F5A0", Offset = "0x118E3A0", VA = "0x18118F5A0")]
		public JMJHJMKLADO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2514050", Offset = "0x2512E50", VA = "0x182514050")]
		internal bool <GetClosestSphereCastHit>b__0(RaycastHit h, float dSqr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly Collider[] DALFGEJDJMM;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly RaycastHit[] OEKJDIPLGML;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1B8DC90", Offset = "0x1B8CA90", VA = "0x181B8DC90")]
	public static T LGLGLKGNLMN<T>(Vector3 CACFKFOOHID, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, T> JFJJCCHICDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3824540", Offset = "0x3823340", VA = "0x183824540")]
	public static bool ILIFFJBJEIB(Ray OPMKFDNLHKI, float DJGCMOJICGK, out RaycastHit PAOKLBNMNFL, Func<RaycastHit, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1B8D8C0", Offset = "0x1B8C6C0", VA = "0x181B8D8C0")]
	public static T GDIGJECFAIH<T>(Vector3 CACFKFOOHID, float OMLBPICLALA, Vector3 DJBBMJBBNHB, int NNHBELIOIIM, float DJGCMOJICGK, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, float, T> JFJJCCHICDD, QueryTriggerInteraction CGAPEINEFPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3823F20", Offset = "0x3822D20", VA = "0x183823F20")]
	public static Vector3 ABDJDBINPNA(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3824070", Offset = "0x3822E70", VA = "0x183824070")]
	private static float HLJCBFHFBNC(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x38241E0", Offset = "0x3822FE0", VA = "0x1838241E0")]
	public static bool HPMMIPJACPC(Ray OPMKFDNLHKI, float OMLBPICLALA, float DJGCMOJICGK, out RaycastHit HIFHEHIMEEM, Func<RaycastHit, float, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3823FC0", Offset = "0x3822DC0", VA = "0x183823FC0")]
	public static void EOHKJJAHPKJ(this Rigidbody BECMPBBBFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x38247B0", Offset = "0x38235B0", VA = "0x1838247B0")]
	public static float JKFIAIEANPC(this PhysicMaterial OJLJGNPJMLL, PhysicMaterial KBKEIKNPLEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3824A40", Offset = "0x3823840", VA = "0x183824A40")]
	private static float KPGODPAAHGJ(float LONDCJPNKKN, float PCEJJILDLGD, PhysicMaterialCombine DLNBOFMPEAO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class CEMMJOMPAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Quaternion LDGGICNOHPP;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x680880", Offset = "0x67F680", VA = "0x180680880")]
	public CEMMJOMPAEL(Quaternion GAAKKDLBBGK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x381C8C0", Offset = "0x381B6C0", VA = "0x18381C8C0")]
	public static Quaternion FAJDMKOEFLH(CEMMJOMPAEL CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x381C860", Offset = "0x381B660", VA = "0x18381C860")]
	public static CEMMJOMPAEL FAJDMKOEFLH(Quaternion CHBGHGPPLCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class AOGMKHCEPPO
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly float JJODNJHPABO;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly float DAJGEGINJHP;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3819850", Offset = "0x3818650", VA = "0x183819850")]
	public static Vector3 OBKNOLONKAG(this Quaternion IGPENJBJADK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3819750", Offset = "0x3818550", VA = "0x183819750")]
	public static Quaternion LIGCJPMNEHL(this Quaternion CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3819220", Offset = "0x3818020", VA = "0x183819220")]
	public static Quaternion FNBCAEAEPDN(this Quaternion GAAKKDLBBGK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x38193E0", Offset = "0x38181E0", VA = "0x1838193E0")]
	public static bool JNEMCKAMAMK(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3819390", Offset = "0x3818190", VA = "0x183819390")]
	public static bool JCLKGFMMODE(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x38197A0", Offset = "0x38185A0", VA = "0x1838197A0")]
	public static Quaternion MHKNGOGEBNG(this Quaternion NPEOEMEENIK, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x38190D0", Offset = "0x3817ED0", VA = "0x1838190D0")]
	public static Quaternion DKEHHDMGLPO(this Quaternion HICENEOPGOF, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3819980", Offset = "0x3818780", VA = "0x183819980")]
	public static Quaternion PHDAPBGIHIN(this Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3819170", Offset = "0x3817F70", VA = "0x183819170")]
	public static Quaternion FLNDPIEAFLK(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3819690", Offset = "0x3818490", VA = "0x183819690")]
	public static Quaternion LBKFJAFFDJJ(Vector3 KHJFDILDLAD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3819430", Offset = "0x3818230", VA = "0x183819430")]
	public static Vector3 KBILIJGGLPM(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3818F50", Offset = "0x3817D50", VA = "0x183818F50")]
	public static Quaternion DHBDEABFFIO(Quaternion JDJIGPDAIEA, Quaternion HEGDAEMJLDE, ref Vector3 FNBDKACNNFH, float MGKFFIBNPNF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EILMCJGGDJA
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x381E310", Offset = "0x381D110", VA = "0x18381E310")]
	public static Rect INDNLPJJCNI(this Rect POMLCDIIKDM, Vector2 KPLDEODOJID)
	{
		return default(Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x381E2C0", Offset = "0x381D0C0", VA = "0x18381E2C0")]
	public static Vector2 EOPELBEEEID(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x381E480", Offset = "0x381D280", VA = "0x18381E480")]
	public static Vector2 OCAPBHHPCHJ(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x381E4D0", Offset = "0x381D2D0", VA = "0x18381E4D0")]
	public static Vector2 OLLAHCIHKFM(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x381E430", Offset = "0x381D230", VA = "0x18381E430")]
	public static Vector2 JANDCGIBIPJ(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class GPEBDLJLJAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly int GMFKHCBFDHO;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private static readonly MaterialPropertyBlock PHLNNAPOEIP;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x38225B0", Offset = "0x38213B0", VA = "0x1838225B0")]
	public static Mesh ANIFOGABCAL(this Renderer CHEJPOIMMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3822760", Offset = "0x3821560", VA = "0x183822760")]
	public static int JHIDBGOLCLD(this Renderer CHEJPOIMMCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x38229F0", Offset = "0x38217F0", VA = "0x1838229F0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Color GJAINANBOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3822AD0", Offset = "0x38218D0", VA = "0x183822AD0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, float ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3822910", Offset = "0x3821710", VA = "0x183822910")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Vector4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3822810", Offset = "0x3821610", VA = "0x183822810")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Matrix4x4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3822BA0", Offset = "0x38219A0", VA = "0x183822BA0")]
	public static void NHHLALGBEPB(this Renderer CHEJPOIMMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x38223C0", Offset = "0x38211C0", VA = "0x1838223C0")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3822220", Offset = "0x3821020", VA = "0x183822220")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB, int NKJOCEKPCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OMCHJHPFBDN
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3828AE0", Offset = "0x38278E0", VA = "0x183828AE0")]
	public static void KBFLHNONOHF(UnityEngine.Object BEKEOBJFIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3828BA0", Offset = "0x38279A0", VA = "0x183828BA0")]
	public static void KGFPNIMJHIC(GameObject DOJCFCINALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3828A20", Offset = "0x3827820", VA = "0x183828A20")]
	public static void ANDJDDMACLM(Component CKCMODJNCNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class EBCHPKBHFLK
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool ADEOMEKPMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x381DC10", Offset = "0x381CA10", VA = "0x18381DC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x381DB70", Offset = "0x381C970", VA = "0x18381DB70")]
	public static float KPCDDILAKBL()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FFENLNFBBPG
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x381E7D0", Offset = "0x381D5D0", VA = "0x18381E7D0")]
	public static byte[] APEDNIKLMAA(string MEIIMAIGBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x381E910", Offset = "0x381D710", VA = "0x18381E910")]
	private static DownloadHandler LMDHNJOMGHJ(string MEIIMAIGBJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class HNMOAGNDOGF
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private static readonly Regex OOFCINNPFIB;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly Regex MKNLKENNLJA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x38239F0", Offset = "0x38227F0", VA = "0x1838239F0")]
	public static string MMDNDBLHCEL(string BILLCLFKNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3823550", Offset = "0x3822350", VA = "0x183823550")]
	public static string EMOFOGPOOLJ(string CKCGCFGOMAA, char JEEKALMPFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x38235E0", Offset = "0x38223E0", VA = "0x1838235E0")]
	public static string FIJDNLILJFG(this string ONGBFDACHHG, int OMJLGGPHALE, string IEICOECHHLH = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3823C50", Offset = "0x3822A50", VA = "0x183823C50")]
	public static int NPNNFCNGMID(this string ENMDDKHBHPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x38238D0", Offset = "0x38226D0", VA = "0x1838238D0")]
	public static bool LJGGMDGLNOO(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3823950", Offset = "0x3822750", VA = "0x183823950")]
	public static bool MCOIBCNPNAP(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3823690", Offset = "0x3822490", VA = "0x183823690")]
	public static bool IDLADJKDBBA(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x38238C0", Offset = "0x38226C0", VA = "0x1838238C0")]
	public static bool LJGBBKKGKOP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x38239E0", Offset = "0x38227E0", VA = "0x1838239E0")]
	public static bool MIABHAJOKBP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x38233A0", Offset = "0x38221A0", VA = "0x1838233A0")]
	public static bool AFNHOCAOHON(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3823420", Offset = "0x3822220", VA = "0x183823420")]
	public static bool AFNHOCAOHON(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3823660", Offset = "0x3822460", VA = "0x183823660")]
	public static bool FOKJGKHGHMG(this string CKCGCFGOMAA, string ONGBFDACHHG, out int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x38235B0", Offset = "0x38223B0", VA = "0x1838235B0")]
	public static bool FBFBJCMPOPJ(this string CKCGCFGOMAA, string ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3823730", Offset = "0x3822530", VA = "0x183823730")]
	public static bool IIPIEIOOMCL(string IPHIIJNAEON, string FOJLJNMAJLC, StringComparison GAJDDOLCCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3823BF0", Offset = "0x38229F0", VA = "0x183823BF0")]
	public static string NLGELJNDBLM(this string ENMDDKHBHPA, string GNJIBIELEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x38234B0", Offset = "0x38222B0", VA = "0x1838234B0")]
	public static string DNLAKCPLAPD(this string ENMDDKHBHPA, int MNIJHBJDPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3823790", Offset = "0x3822590", VA = "0x183823790")]
	public static string KEJAABKOPJP(this string NMELNILPPKN, int PKNNNIDIOGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class EDBONCHIAND
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class POAHNJIPKDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color[] pixels;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3F5100", Offset = "0x3F3F00", VA = "0x1803F5100")]
		public POAHNJIPKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3828C60", Offset = "0x3827A60", VA = "0x183828C60")]
		internal void <ConvertPixelsToGamma>b__0(int i)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x381E0B0", Offset = "0x381CEB0", VA = "0x18381E0B0")]
	public static void MHKFJCHNJEE(this Texture2D CAKFKAGPMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x381DCC0", Offset = "0x381CAC0", VA = "0x18381DCC0")]
	public static void FOFPEEMEIIC(this RenderTexture CNOGINOPPCH, ref Texture2D CAKFKAGPMBF, bool FKLJPOFDILI = false, bool LGJOOBAHIAC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class CDCLKFOIBMC
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static readonly Vector3[] ILMEMODIMEF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x381AD00", Offset = "0x3819B00", VA = "0x18381AD00")]
	public static Vector3 CKMNPHLNJMA(this Transform OIFLDNBGJOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x381B210", Offset = "0x381A010", VA = "0x18381B210")]
	public static Vector3 CPLMAMCMLFN(this Transform OIFLDNBGJOH, Vector3 KNIKPKEBLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x381AFF0", Offset = "0x3819DF0", VA = "0x18381AFF0")]
	public static Vector3 CPLMAMCMLFN(Vector3 DEPGOBCBCAB, Vector3 FFGMLBJDGFM, Vector3 MGCJCNFHMEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x381C370", Offset = "0x381B170", VA = "0x18381C370")]
	public static Vector3 NFFAAMNNHGN(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x381AB90", Offset = "0x3819990", VA = "0x18381AB90")]
	public static Vector2 CJEBHAJDJMI(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x381B790", Offset = "0x381A590", VA = "0x18381B790")]
	public static float ILCMBGMEPJE(this RectTransform AIOEKMHLKAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x381BBF0", Offset = "0x381A9F0", VA = "0x18381BBF0")]
	public static Vector3 JBLIBMEOLEB(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x381C4C0", Offset = "0x381B2C0", VA = "0x18381C4C0")]
	public static Vector3[] PHMOKHIOHDG(this RectTransform AIOEKMHLKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x381C260", Offset = "0x381B060", VA = "0x18381C260")]
	public static Quaternion MHKNGOGEBNG(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x381B4B0", Offset = "0x381A2B0", VA = "0x18381B4B0")]
	public static Quaternion DKEHHDMGLPO(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x381C020", Offset = "0x381AE20", VA = "0x18381C020")]
	public static Vector3 MHEFIHAJMAD(this Transform OIFLDNBGJOH, Vector3 DDHPAFKBMON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x381BB60", Offset = "0x381A960", VA = "0x18381BB60")]
	public static int IMCOAPLOEPD(this Transform OIFLDNBGJOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x199CF30", Offset = "0x199BD30", VA = "0x18199CF30")]
	public static float LACCAFFAOIG(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x381A9C0", Offset = "0x38197C0", VA = "0x18381A9C0")]
	public static float ABDKFENDAKH(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x381BD70", Offset = "0x381AB70", VA = "0x18381BD70")]
	public static void MCFLPFCGOOL(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x381B990", Offset = "0x381A790", VA = "0x18381B990")]
	public static void IMCHPFPFLJJ(this Transform OIFLDNBGJOH, float MKDHFENOFDO, Vector3 KLNFHHBHGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x381A9F0", Offset = "0x38197F0", VA = "0x18381A9F0")]
	public static void CAIHJLKEPIF(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x381AF20", Offset = "0x3819D20", VA = "0x18381AF20")]
	public static float CPEJGKGFNJH(this Transform OIFLDNBGJOH, float PLIPOIMDGPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x381BFA0", Offset = "0x381ADA0", VA = "0x18381BFA0")]
	public static float MDGALGDEFAK(this Transform OIFLDNBGJOH, float JIBDGOKLJOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x381B570", Offset = "0x381A370", VA = "0x18381B570")]
	public static void FABLENJPHFB(this RectTransform AIOEKMHLKAL, Vector3[] NPPHHLLMGEM, [Optional] Canvas NKKFJKIMHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GDCPJCHDFJH
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly Vector2 KPLGKEDLKLM;

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8F5320", Offset = "0x8F4120", VA = "0x1808F5320")]
	public static Vector2 KMEKBBFBKCA(Vector2 KDBHHDAJLNL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3821E30", Offset = "0x3820C30", VA = "0x183821E30")]
	public static Vector2 KOLMGGDLPDK(this Vector2 PJEDBAONDPP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x3821E00", Offset = "0x3820C00", VA = "0x183821E00")]
	public static bool CDKDHNKFHFB(this Vector2 PDPPMFNOBMO, float ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3821F20", Offset = "0x3820D20", VA = "0x183821F20")]
	public static float PAEBMOBFCGG(this Vector2 BANGBIKOBGO, Vector2 OALKOHJOHFO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OIJBIAMACNJ
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum KCNMMJEKPBC
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Up = 1,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Down = -1,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Right = 2,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Left = -2,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Forward = 3,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Back = -3
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly float ODOBHKFMCMK;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3826A80", Offset = "0x3825880", VA = "0x183826A80")]
	public static Vector3 EMJNMOGIAKL(this IEnumerable<Vector3> COAEBIFOBNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3827B40", Offset = "0x3826940", VA = "0x183827B40")]
	public static float NMDFDMBNFNA(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3828410", Offset = "0x3827210", VA = "0x183828410")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Vector3 IDMBJGPOCAE, Vector3 MCEDKFKKOCM, Vector3 MJPDDCEFPIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x38285F0", Offset = "0x38273F0", VA = "0x1838285F0")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3828270", Offset = "0x3827070", VA = "0x183828270")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH, Vector3 EIHOAEHONBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3828710", Offset = "0x3827510", VA = "0x183828710")]
	public static Vector3 PFLLEKCBAAL(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3827C00", Offset = "0x3826A00", VA = "0x183827C00")]
	public static bool OGIEHPPFJCB(this Vector3 BMOIJACGPLN, float LBLHBGPCEMF = 0.001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3827570", Offset = "0x3826370", VA = "0x183827570")]
	public static bool ICGLFNNJKAC(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3827140", Offset = "0x3825F40", VA = "0x183827140")]
	public static bool HPKDFLEPPCG(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x38269F0", Offset = "0x38257F0", VA = "0x1838269F0")]
	public static float DGNGDMGOMAA(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3826250", Offset = "0x3825050", VA = "0x183826250")]
	public static float AHOKOGPDJNP(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3826930", Offset = "0x3825730", VA = "0x183826930")]
	public static Vector3 DDGPCFJMGII(this Vector3 DINHOLEGEMB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x38277C0", Offset = "0x38265C0", VA = "0x1838277C0")]
	public static Vector3 JKGIHPNIJLK(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x38266D0", Offset = "0x38254D0", VA = "0x1838266D0")]
	public static Vector3 BNKOIHAECHN(this Vector3 PJEDBAONDPP, float NNNGNCNIJAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x38265F0", Offset = "0x38253F0", VA = "0x1838265F0")]
	public static bool BECDFHKOIGK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x38279D0", Offset = "0x38267D0", VA = "0x1838279D0")]
	public static bool JNEMCKAMAMK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3827720", Offset = "0x3826520", VA = "0x183827720")]
	public static bool JCLKGFMMODE(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3826640", Offset = "0x3825440", VA = "0x183826640")]
	public static Vector3 BMNFGJPMFBG(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3827D30", Offset = "0x3826B30", VA = "0x183827D30")]
	public static Vector3 OHHOPADHBAL(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3826D60", Offset = "0x3825B60", VA = "0x183826D60")]
	public static float FLEMBFIOFJA(this Vector3 BANGBIKOBGO, Vector3 OALKOHJOHFO, [Optional] Vector3? KNIKPKEBLNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3827B20", Offset = "0x3826920", VA = "0x183827B20")]
	public static Vector3 NELNDENOBLC(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x38271B0", Offset = "0x3825FB0", VA = "0x1838271B0")]
	public static Vector3 IBPJJIDHFFL(Vector3 CHGNDIAMGLF, Quaternion IBCNKFBPCBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3827DC0", Offset = "0x3826BC0", VA = "0x183827DC0")]
	public static KCNMMJEKPBC OJDKGBIHNJD(Transform OIFLDNBGJOH, Vector3 MAPAFOGPKLL, out Vector3 GLHHBDHELAO)
	{
		return default(KCNMMJEKPBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3826F20", Offset = "0x3825D20", VA = "0x183826F20")]
	public static Vector3 GKDMJPGOEHO(float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3827110", Offset = "0x3825F10", VA = "0x183827110")]
	public static Vector3 HOCFJJAOPDC(float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3826900", Offset = "0x3825700", VA = "0x183826900")]
	public static Vector3 CLEFGACGMKH(float FOBCKBCBJHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3827010", Offset = "0x3825E10", VA = "0x183827010")]
	public static Vector3 GNOENAFKJIE(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3827A30", Offset = "0x3826830", VA = "0x183827A30")]
	public static Vector3 KICDFOACKEL(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3827780", Offset = "0x3826580", VA = "0x183827780")]
	public static Vector3 JJOELJJFBAE(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3826840", Offset = "0x3825640", VA = "0x183826840")]
	public static Vector3 CIOKEDCFPJI(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3828840", Offset = "0x3827640", VA = "0x183828840")]
	public static Vector3 PGCOBFHPJEA(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3828900", Offset = "0x3827700", VA = "0x183828900")]
	public static Vector3 PLINJEJIIMO(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3826530", Offset = "0x3825330", VA = "0x183826530")]
	public static Vector3 BCICENEBNCF(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3826F50", Offset = "0x3825D50", VA = "0x183826F50")]
	public static Vector3 GMNHMHPHIJK(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3827A70", Offset = "0x3826870", VA = "0x183827A70")]
	public static Vector3 KKANLJKPHJI(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3827050", Offset = "0x3825E50", VA = "0x183827050")]
	public static Vector3 HCLHKJPLONK(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x38275E0", Offset = "0x38263E0", VA = "0x1838275E0")]
	public static Vector3 IKBIEPLCAKN(Vector3 HGEIABGCFOA, Vector3 IBHEKLCMMNH, Vector3 KNIKPKEBLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x38262E0", Offset = "0x38250E0", VA = "0x1838262E0")]
	public static Vector3 AOGDEGACCAP(Vector3 PJEDBAONDPP, Vector3 OOEKLKBHAHK, Vector3 AIOJLAJOCEL, bool PNLBALPIOHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3827880", Offset = "0x3826680", VA = "0x183827880")]
	public static float JMAEBJBJADJ(this Vector3 BANGBIKOBGO, Vector3 OALKOHJOHFO, Vector3 JKKKLNNDOCL, bool DBIKMABANKE = false)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct JFCMGKMLBMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly RenderTexture LCJOPCGBDFO;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3824E60", Offset = "0x3823C60", VA = "0x183824E60")]
	public JFCMGKMLBMN(RenderTexture BGFEHOIGLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3824E50", Offset = "0x3823C50", VA = "0x183824E50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FNHMBIFJJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3821B10", Offset = "0x3820910", VA = "0x183821B10")]
	public static Quaternion CHDHKJJADFE(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x199CF60", Offset = "0x199BD60", VA = "0x18199CF60")]
	public static Vector3 DOAOMJFMLLN(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3821C50", Offset = "0x3820A50", VA = "0x183821C50")]
	public static Vector3 OHAKMAOEKCG(this Matrix4x4 BKPMKIIFPKO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IJHPIMJMEIB
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x1A4A310", Offset = "0x1A49110", VA = "0x181A4A310")]
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
