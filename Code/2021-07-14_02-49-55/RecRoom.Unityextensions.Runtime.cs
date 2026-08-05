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
		[Cpp2IlInjected.Address(RVA = "0x15568E0", Offset = "0x1555AE0", VA = "0x1815568E0")]
		public HPIEIOAGEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1BDE1F0", Offset = "0x1BDD3F0", VA = "0x181BDE1F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15568E0", Offset = "0x1555AE0", VA = "0x1815568E0")]
		public IEKPHHLNIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1BDE230", Offset = "0x1BDD430", VA = "0x181BDE230")]
		internal string <ToFriendlyString>b__1(string s, string s1)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DDE0", Offset = "0x1F2CFE0", VA = "0x181F2DDE0")]
	public static string JIIMHOLCECD<T>(this IEnumerable<T> NKLIOLCGIDM, [Optional] Func<T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D930", Offset = "0x1F2CB30", VA = "0x181F2D930")]
	public static string JIIMHOLCECD<T>(this IList<T> DAAFDLFCOGO, [Optional] Func<int, T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x12F4540", Offset = "0x12F3740", VA = "0x1812F4540")]
	[IteratorStateMachine(typeof(AEABJMALBDK))]
	public static IEnumerable<T> MJJDFHHAOPM<T>(T IOBEPGLJNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1941380", Offset = "0x1940580", VA = "0x181941380")]
	public static (T[], U[]) HKJNIHLKENA<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x13DDB0", Offset = "0x13D1B0")] this IEnumerable<(T, U)> NMELNILPPKN)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A42BB0", Offset = "0x1A41DB0", VA = "0x181A42BB0")]
	public static IEnumerable<(T, int)> AKGEGLEMFGM<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1941B10", Offset = "0x1940D10", VA = "0x181941B10")]
	public static void HOAGBPIIIGP<T>(this IEnumerable<T> NMELNILPPKN, Action<T> EDECJKLDKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1519890", Offset = "0x1518A90", VA = "0x181519890")]
	public static HashSet<T> PBGCPCJGGOO<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1A42D70", Offset = "0x1A41F70", VA = "0x181A42D70")]
	public static IEnumerable<T> HDLDCPJDNDA<T>(this IEnumerable<T> NKLIOLCGIDM, int KKDPFGADCEK, int MADNOGDODFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1A42DB0", Offset = "0x1A41FB0", VA = "0x181A42DB0")]
	public static IEnumerable<T> KPDAENONKPJ<T, TKey>(this IEnumerable<T> NKLIOLCGIDM, Func<T, TKey> HDLMHEHINBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D690", Offset = "0x1F2C890", VA = "0x181F2D690")]
	public static T? ILPGDGMLKDH<T>(this IEnumerable<T> NMELNILPPKN, Func<T, bool> HBPBAJNLGCP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CEEHAKJPFHM
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x378A7C0", Offset = "0x37899C0", VA = "0x18378A7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3793C00", Offset = "0x3792E00", VA = "0x183793C00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static float JHAFCFMBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9E1E20", Offset = "0x9E1020", VA = "0x1809E1E20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static float DGEAEHEJCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3793B90", Offset = "0x3792D90", VA = "0x183793B90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3793C10", Offset = "0x3792E10", VA = "0x183793C10")]
	public static float HDHMLEOEOJP(float MOPKOPOKKEE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LHIJJLMMMHM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3793DD0", Offset = "0x3792FD0", VA = "0x183793DD0")]
	public static bool BKDAHHMFHMC(this DateTime? PBMJJOMBPAH, TimeSpan DOFKHNLEKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3793F00", Offset = "0x3793100", VA = "0x183793F00")]
	public static string PAKENNFHMEG(this TimeSpan DOFKHNLEKKP, string FEGAGLFEGEP = "minute", bool JKEPCLNFJHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3793E70", Offset = "0x3793070", VA = "0x183793E70")]
	private static string HIDOGKBNNLG(string IGCKACBLCON, double KEOKDMNJJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IEDIJNKECOL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3792BA0", Offset = "0x3791DA0", VA = "0x183792BA0")]
	public static string MJHFHBGFJHF(this Type GEDCEIDOKJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LFDJHEDEGAJ
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3793C90", Offset = "0x3792E90", VA = "0x183793C90")]
	public static void DBCCNEMNLNI(this Animator LDOJFIEANFB, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3793D10", Offset = "0x3792F10", VA = "0x183793D10")]
	public static void DOMIGIEBFCF(this Animator LDOJFIEANFB, int ENJEOLBEALP, bool ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3793D70", Offset = "0x3792F70", VA = "0x183793D70")]
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
			[Cpp2IlInjected.Address(RVA = "0x212AAE0", Offset = "0x2129CE0", VA = "0x18212AAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x21301C0", Offset = "0x212F3C0", VA = "0x1821301C0")]
		public MKNPILCJOAI(T[] GMOGECKNEEN, IGHKKHEGGBB<T> BKHGMOKDLGO, int DCFEFKGJDOJ, Func<bool> AEMDDGKHONP, T[] CJDMEOAEMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x212FE00", Offset = "0x212F000", VA = "0x18212FE00")]
		public bool CDHNACEAFJL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1E1DE10", Offset = "0x1E1D010", VA = "0x181E1DE10")]
	public static T[] APNIJAHEGLJ<T>(int OJJOHDIFMEG, T MCACHDBIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2ED52D0", Offset = "0x2ED44D0", VA = "0x182ED52D0")]
	public static void KDEILFALGLM<T>(this T[] JABGABGMHPL, T MCACHDBIALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4D80", Offset = "0x2ED3F80", VA = "0x182ED4D80")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4B80", Offset = "0x2ED3D80", VA = "0x182ED4B80")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA, int OIDPFPMBCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4E10", Offset = "0x2ED4010", VA = "0x182ED4E10")]
	public static void CDLEKIKHHCD<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO, [Optional] T[] CJDMEOAEMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2ED4EB0", Offset = "0x2ED40B0", VA = "0x182ED4EB0")]
	private static void JIHBNKEBJDH<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int DJICGHFJJJP, T[] EPDKOCHMOLC, bool GOJFBEJBPBC, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2ED5440", Offset = "0x2ED4640", VA = "0x182ED5440")]
	private static void MNMAEDHAEFJ<T>(this T[] NMELNILPPKN, int ANDOICCNDLA, int GFKCDKBFBBN, T[] HPKICPNGMDJ, int MDIFJBFIGHL, int PPNMMGMDEJI, T[] GIAOBLMEMMI, int CAPPAKEKPLG, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2ED5870", Offset = "0x2ED4A70", VA = "0x182ED5870")]
	public static void OIEHNKDGJKK<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int MNIJHBJDPPA, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1856DE0", Offset = "0x1855FE0", VA = "0x181856DE0")]
	public static MKNPILCJOAI<T> JKMCDDAPLHN<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO, int DCFEFKGJDOJ, Func<bool> AEMDDGKHONP, [Optional] T[] CJDMEOAEMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E790", Offset = "0x1E1D990", VA = "0x181E1E790")]
	public static T[] NHGMLEGCCMP<T>(this T[] OPEBNMBKJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E7B0", Offset = "0x1E1D9B0", VA = "0x181E1E7B0")]
	public static T[] PPMHFINCJNE<T>(this T[] IHFOIAODAJC, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E140", Offset = "0x1E1D340", VA = "0x181E1E140")]
	public static T[] DECCCEINGDI<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E6E0", Offset = "0x1E1D8E0", VA = "0x181E1E6E0")]
	public static T[] HNNOENGPBPL<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E1DF20", Offset = "0x1E1D120", VA = "0x181E1DF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x3791530", Offset = "0x3790730", VA = "0x183791530")]
		public HKLGKBLGDMN(GameObject DOJCFCINALC, bool AHOAECJDPGH, NCHPJLFOHGM MPBIKBNEFGP, bool CLAOPEDMPGL, Type GEDCEIDOKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3790E80", Offset = "0x3790080", VA = "0x183790E80", Slot = "4")]
		public bool Equals(HKLGKBLGDMN HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3790DE0", Offset = "0x378FFE0", VA = "0x183790DE0", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3790F90", Offset = "0x3790190", VA = "0x183790F90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3791050", Offset = "0x3790250", VA = "0x183791050", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x378D110", Offset = "0x378C310", VA = "0x18378D110")]
	public static void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x167DC70", Offset = "0x167CE70", VA = "0x18167DC70")]
	public static T FABKIOBNCHE<T>(this GameObject DOJCFCINALC, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x167DF40", Offset = "0x167D140", VA = "0x18167DF40")]
	public static T JLOAAIEKGLO<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x167E060", Offset = "0x167D260", VA = "0x18167E060")]
	public static T MHBNENBBNDJ<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x151B970", Offset = "0x151AB70", VA = "0x18151B970")]
	public static IReadOnlyList<T> HLCNADOGJFC<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x151BE70", Offset = "0x151B070", VA = "0x18151BE70")]
	public static IReadOnlyList<T> PHJEODMHDOK<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x167DD80", Offset = "0x167CF80", VA = "0x18167DD80")]
	private static T JGCKGHNCPPC<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x151BBC0", Offset = "0x151ADC0", VA = "0x18151BBC0")]
	private static IReadOnlyList<T> OFLKKOAGMFK<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x378D070", Offset = "0x378C270", VA = "0x18378D070")]
	private static void KIPECKHDOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x378CC60", Offset = "0x378BE60", VA = "0x18378CC60")]
	private static void JOMBFKGNCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x151BD70", Offset = "0x151AF70", VA = "0x18151BD70")]
	private static IReadOnlyList<T> OIJCNPEICPD<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x151BA90", Offset = "0x151AC90", VA = "0x18151BA90")]
	private static IReadOnlyList<T> MAALAKFHBNE<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BOHNIEMGLMC
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37885B0", Offset = "0x37877B0", VA = "0x1837885B0")]
	public static float ELCHENEAFFD(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3788C20", Offset = "0x3787E20", VA = "0x183788C20")]
	public static float OOIKMLIOLHN(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3788A50", Offset = "0x3787C50", VA = "0x183788A50")]
	public static float KCHIFOHABON(this Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x37883B0", Offset = "0x37875B0", VA = "0x1837883B0")]
	private static float DBBKCKNDNOJ(float PPLEDBHELNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3788420", Offset = "0x3787620", VA = "0x183788420")]
	private static float DBBKCKNDNOJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3788850", Offset = "0x3787A50", VA = "0x183788850")]
	private static float FMJNGGHKBNJ(float PPLEDBHELNG, float EHDMLFDEBAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3788810", Offset = "0x3787A10", VA = "0x183788810")]
	private static float FMJNGGHKBNJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3788700", Offset = "0x3787900", VA = "0x183788700")]
	public static float FGCPIGKOIHD(float PPLEDBHELNG, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x37885E0", Offset = "0x37877E0", VA = "0x1837885E0")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3788620", Offset = "0x3787820", VA = "0x183788620")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, Vector2 IJHJIKGDNJH, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3788300", Offset = "0x3787500", VA = "0x183788300")]
	private static float CIMKJKMKPGG(float DABFKGJPFDC, float IJHJIKGDNJH, float PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x37888D0", Offset = "0x3787AD0", VA = "0x1837888D0")]
	public static float JKGBBKLIAMK(float GGJOIJAKDDC, float EHDMLFDEBAF, Vector2 IJHJIKGDNJH, float HGFAGBNEADJ, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3788B60", Offset = "0x3787D60", VA = "0x183788B60")]
	private static float NEANFKGDFBM(float DABFKGJPFDC, float IJHJIKGDNJH, float HGFAGBNEADJ, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x37884A0", Offset = "0x37876A0", VA = "0x1837884A0")]
	public static void DBJKGNBKPDI(this Camera FOMHGMLPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3788B00", Offset = "0x3787D00", VA = "0x183788B00")]
	public static bool LPBHGEJLJKD(this Camera FOMHGMLPOND, Renderer CHEJPOIMMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3788530", Offset = "0x3787730", VA = "0x183788530")]
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
	[Cpp2IlInjected.Address(RVA = "0x378B530", Offset = "0x378A730", VA = "0x18378B530")]
	public static bool HAKOLMGKNPH(this Collider GLPOLGOBLAA, Vector3 KMIFDIBBCDI, Vector3 EDKKBNDGKAO, float OMLBPICLALA, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, out RaycastHit IIILNCEEBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x378AB00", Offset = "0x3789D00", VA = "0x18378AB00")]
	public static int AMAOMIJGJBF(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, Collider[] GIJOIBPGGOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x378B290", Offset = "0x378A490", VA = "0x18378B290")]
	public static bool FKFGLHIBHJC(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x378BA80", Offset = "0x378AC80", VA = "0x18378BA80")]
	public static int NBOGLHFIMJA(this BoxCollider GLPOLGOBLAA, Collider[] PANOGCJFAOD, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x378B890", Offset = "0x378AA90", VA = "0x18378B890")]
	public static bool KCFPIEEMJON(this BoxCollider CEGIONPIIAO, Vector3 NAIDPMBKHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x378AED0", Offset = "0x378A0D0", VA = "0x18378AED0")]
	public static bool FKFGLHIBHJC(this CapsuleCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x378B800", Offset = "0x378AA00", VA = "0x18378B800")]
	public static Vector3 HHNMMNMLAMF(this BoxCollider GLPOLGOBLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x378ADC0", Offset = "0x3789FC0", VA = "0x18378ADC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3793AA0", Offset = "0x3792CA0", VA = "0x183793AA0")]
	public static Color FKDFDGMNNLG(this Color GJAINANBOCB, float FBPFONBFPEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x37939B0", Offset = "0x3792BB0", VA = "0x1837939B0")]
	public static Vector3 AHOMKMDCPOH(this Vector3 DKIELBAENOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37938B0", Offset = "0x3792AB0", VA = "0x1837938B0")]
	public static Color AHOMKMDCPOH(this Color DKIELBAENOL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3793AE0", Offset = "0x3792CE0", VA = "0x183793AE0")]
	public static Color LGPCCFOGKGG(this Color GJAINANBOCB, float IOAMFOPBCMN)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BEBOIKCDHFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3787D30", Offset = "0x3786F30", VA = "0x183787D30")]
	public static void OFKIHGPJHJI(this Component CKCMODJNCNF, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1519790", Offset = "0x1518990", VA = "0x181519790")]
	public static List<T> PFOKAFNFHHM<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1679A30", Offset = "0x1678C30", VA = "0x181679A30")]
	public static T LNJIMABEJLG<T>(this Component CKCMODJNCNF, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EJFNMBLOPLC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1A435F0", Offset = "0x1A427F0", VA = "0x181A435F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public AFMAGHBPHLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3787100", Offset = "0x3786300", VA = "0x183787100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x37871B0", Offset = "0x37863B0", VA = "0x1837871B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x480470", Offset = "0x47F670", VA = "0x180480470")]
		[DebuggerHidden]
		public EGJGCHCIGPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x378C3E0", Offset = "0x378B5E0", VA = "0x18378C3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x378C490", Offset = "0x378B690", VA = "0x18378C490", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static WaitForEndOfFrame NAKHMEPNJEL;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3792E70", Offset = "0x3792070", VA = "0x183792E70")]
	[IteratorStateMachine(typeof(AFMAGHBPHLI))]
	public static IEnumerator BCAKHIGACHG(float CAHAMMIHDFG, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3792EE0", Offset = "0x37920E0", VA = "0x183792EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3792D90", Offset = "0x3791F90", VA = "0x183792D90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3792D60", Offset = "0x3791F60", VA = "0x183792D60")]
	public IGHCGCAGAFH(float HABFNPMBADP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CDHKGKPIOLK
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1E05B00", Offset = "0x1E04D00", VA = "0x181E05B00")]
	public static TValue KGAPEMHMJHI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG) where TValue : new()
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1E05DA0", Offset = "0x1E04FA0", VA = "0x181E05DA0")]
	public static TValue PLOELFMPHEI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1E05730", Offset = "0x1E04930", VA = "0x181E05730")]
	public static TValue GLPALAONCFG<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FKFGKDOBBOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x378FBE0", Offset = "0x378EDE0", VA = "0x18378FBE0")]
	public static string CPIKLJJCBAB(this Guid COFLAJFOPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x378FB00", Offset = "0x378ED00", VA = "0x18378FB00")]
	public static string CPIKLJJCBAB(this byte[] MGPDDEMABPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LBEHNMANHHL
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3793030", Offset = "0x3792230", VA = "0x183793030")]
	public static string GKBCGFOAIJM(this FileInfo NOHHLFHPPDF, string IFKMFOPALAO, string EAEOAIMAJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x37931E0", Offset = "0x37923E0", VA = "0x1837931E0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x3F6A10", Offset = "0x3F5C10", VA = "0x1803F6A10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xB79CC0", Offset = "0xB78EC0", VA = "0x180B79CC0")]
		[DebuggerHidden]
		public BJBOHHCEKDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F5C00", Offset = "0x3F4E00", VA = "0x1803F5C00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3788120", Offset = "0x3787320", VA = "0x183788120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x37882B0", Offset = "0x37874B0", VA = "0x1837882B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3788210", Offset = "0x3787410", VA = "0x183788210", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3788210", Offset = "0x3787410", VA = "0x183788210", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Dictionary<int, int> IKJIECFLKJL;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1875CF0", Offset = "0x1874EF0", VA = "0x181875CF0")]
	public static T LNJIMABEJLG<T>(this GameObject DOJCFCINALC, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1875C40", Offset = "0x1874E40", VA = "0x181875C40")]
	public static T GLENGLDKGCK<T>(this GameObject DOJCFCINALC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1875C10", Offset = "0x1874E10", VA = "0x181875C10")]
	public static T GLENGLDKGCK<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x19515F0", Offset = "0x19507F0", VA = "0x1819515F0")]
	public static void IFFLOPMPLPN<T>(this GameObject DOJCFCINALC, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1951540", Offset = "0x1950740", VA = "0x181951540")]
	public static void IFFLOPMPLPN<T>(this Component CKCMODJNCNF, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x19516A0", Offset = "0x19508A0", VA = "0x1819516A0")]
	public static void OPKLCCBLMCM<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3793670", Offset = "0x3792870", VA = "0x183793670")]
	public static void OLLDCMIMDLM(this GameObject DOJCFCINALC, string GHBNIGCAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3793370", Offset = "0x3792570", VA = "0x183793370")]
	public static string AOEFKLMCCGH(this GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x37934A0", Offset = "0x37926A0", VA = "0x1837934A0")]
	[IteratorStateMachine(typeof(BJBOHHCEKDF))]
	private static IEnumerable<string> CLDAIOKJMCC(GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3793510", Offset = "0x3792710", VA = "0x183793510")]
	public static int MOOKPIOIGOD(this GameObject NLNHFEEMFBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LOJLAODGLLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1C41CE0", Offset = "0x1C40EE0", VA = "0x181C41CE0")]
	public static V ODHHPEIEBCB<V, T>(this T LIMOILDIGKF, Func<T, V> PAFOMEECIMH, [Optional] V OANDOPIEEPO) where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1951A00", Offset = "0x1950C00", VA = "0x181951A00")]
	public static void CLELOGIOOCO<T>(this T LIMOILDIGKF, Action<T> PAFOMEECIMH) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ECNNGIFNNNM
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1BE3B50", Offset = "0x1BE2D50", VA = "0x181BE3B50")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> OPEBNMBKJJA, T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1943740", Offset = "0x1942940", VA = "0x181943740")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x19437D0", Offset = "0x19429D0", VA = "0x1819437D0")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO, int KIJHGBLLCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x151A500", Offset = "0x1519700", VA = "0x18151A500")]
	public static List<T> FHAOCJFENEF<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1BE3A80", Offset = "0x1BE2C80", VA = "0x181BE3A80")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> DAAFDLFCOGO, Predicate<T> HBPBAJNLGCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1BE2A10", Offset = "0x1BE1C10", VA = "0x181BE2A10")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1E71AF0", Offset = "0x1E70CF0", VA = "0x181E71AF0")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP, EqualityComparer<T> KFBHPCHEJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1BE2E70", Offset = "0x1BE2070", VA = "0x181BE2E70")]
	public static int IBKMBGJGECB<TElement, TKey>(this IList<TElement> LLOIOFKDLFP, TKey IFHDIPBMJOI, Func<TElement, TKey> IHHAGJMACDJ, [Optional] Func<TKey, TKey, int> BKHGMOKDLGO, int EFBDCIJMFGD = 0, [Optional] int? MNIJHBJDPPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x167CDE0", Offset = "0x167BFE0", VA = "0x18167CDE0")]
	public static T NBMJEPIPHGC<T>(this IReadOnlyList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1E72020", Offset = "0x1E71220", VA = "0x181E72020")]
	public static bool KFDLNLFOGBN<T>(this List<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1943FD0", Offset = "0x19431D0", VA = "0x181943FD0")]
	public static void AINCGKKANMC<T>(this List<T> DAAFDLFCOGO, IEnumerable<T> CGBHMNCBAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x167CD20", Offset = "0x167BF20", VA = "0x18167CD20")]
	public static T NBMJEPIPHGC<T>(this T[] DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1875A50", Offset = "0x1874C50", VA = "0x181875A50")]
	public static void OHDOOOKOMNB<T>(this List<T> CGBHMNCBAGA) where T : UnityEngine.Object
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x167CB60", Offset = "0x167BD60", VA = "0x18167CB60")]
	public static T LLFCJKLELNH<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x167C5D0", Offset = "0x167B7D0", VA = "0x18167C5D0")]
	public static T BMCEKIFDDJK<T>(this List<T> CGBHMNCBAGA, int EFBDCIJMFGD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E706E0", Offset = "0x1E6F8E0", VA = "0x181E706E0")]
	public static bool IDCGECLDIDG<T>(this List<T> LNFKAGBJHOA, List<T> ADFLPMKFAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x167C9E0", Offset = "0x167BBE0", VA = "0x18167C9E0")]
	public static T GPEBLICLPML<T>(this IList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E72090", Offset = "0x1E71290", VA = "0x181E72090")]
	public static bool MGIGDPBNABL<T>(IReadOnlyList<T> DAAFDLFCOGO, int EFBDCIJMFGD, out T GIAOBLMEMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E71800", Offset = "0x1E70A00", VA = "0x181E71800")]
	public static bool JEACGAIICGO<T>(IReadOnlyList<T> DAAFDLFCOGO, ICollection CGBHMNCBAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1943EC0", Offset = "0x19430C0", VA = "0x181943EC0")]
	public static void AEONHOJKJNI<T>(IReadOnlyList<T> DAAFDLFCOGO, ref ICollection CGBHMNCBAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1ADA710", Offset = "0x1AD9910", VA = "0x181ADA710")]
	public static bool LJGBBKKGKOP<T>(this IReadOnlyList<T> DAAFDLFCOGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GEKPCDJEJAK
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x22D5A60", Offset = "0x22D4C60", VA = "0x1822D5A60")]
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

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x378ECF0", Offset = "0x378DEF0", VA = "0x18378ECF0")]
	public static bool MOHPPAOIEMG(int ONGBFDACHHG, int GOICNKGDJEC, int KEBJAIELILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x378F7A0", Offset = "0x378E9A0", VA = "0x18378F7A0")]
	public static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x378DB80", Offset = "0x378CD80", VA = "0x18378DB80")]
	public static float GDKJPBLEGLK(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x378ED10", Offset = "0x378DF10", VA = "0x18378ED10")]
	public static void NADMLFBBFJB(Vector3 JLCIKNNKEAD, out float LMMPJCFJDOL, out float NOFFCKDIOEP, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x378F0A0", Offset = "0x378E2A0", VA = "0x18378F0A0")]
	public static void NPCJFNAJALO(Vector3 JLCIKNNKEAD, out float LBJOIGNPPFB, out float CEOHNIOICHD, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x378F960", Offset = "0x378EB60", VA = "0x18378F960")]
	public static Vector3 PDLGILNJNGC(float LMMPJCFJDOL, float NOFFCKDIOEP, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x378DA10", Offset = "0x378CC10", VA = "0x18378DA10")]
	public static Vector3 FNKFOCAIBGE(float LBJOIGNPPFB, float CEOHNIOICHD, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x378DFE0", Offset = "0x378D1E0", VA = "0x18378DFE0")]
	public static Vector3 HMGHBDPPJAG(Vector3 BBMDCKFFPCE, Vector3 JIOIOMDOAJA, Vector3 KHCCKHOEOKP, Vector3 IJGHHKBAIDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x378D640", Offset = "0x378C840", VA = "0x18378D640")]
	public static bool CFKHNLPBCCE(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x378E7F0", Offset = "0x378D9F0", VA = "0x18378E7F0")]
	public static float MBLIIPEMOGB(Ray FAACBOBPIKK, Ray HEGDAEMJLDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x378F2E0", Offset = "0x378E4E0", VA = "0x18378F2E0")]
	private static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC, float BANKGLOHKOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x378D240", Offset = "0x378C440", VA = "0x18378D240")]
	public static bool BAHBPFFNNJO(float IPHIIJNAEON, float FOJLJNMAJLC, float CIIMMENGOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x378D710", Offset = "0x378C910", VA = "0x18378D710")]
	public static Vector3 DBDLNMAONIL(Vector3 KPLDEODOJID, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x378D870", Offset = "0x378CA70", VA = "0x18378D870")]
	public static Vector3 EAEOKLNFADK(Vector3 DJBBMJBBNHB, Vector3 CKPHGEEPNDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x378DC70", Offset = "0x378CE70", VA = "0x18378DC70")]
	public static void GEFDMDGMEBM(Transform OIFLDNBGJOH, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH, Vector3 AADLCEBLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x378E1B0", Offset = "0x378D3B0", VA = "0x18378E1B0")]
	public static Vector3 JPGHEAINBKJ(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float PIHLBMOKPFJ, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x378EDF0", Offset = "0x378DFF0", VA = "0x18378EDF0")]
	public static Vector3 NDEFIIAMEPM(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x378D2D0", Offset = "0x378C4D0", VA = "0x18378D2D0")]
	private static float BNGIECEAJKA(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x378F080", Offset = "0x378E280", VA = "0x18378F080")]
	public static float NKBLAPMGFEN(float FLIEBIMFHEN, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x378F940", Offset = "0x378EB40", VA = "0x18378F940")]
	public static float PCHIOIGDICJ(float JDFENOCNKAD, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x378F1C0", Offset = "0x378E3C0", VA = "0x18378F1C0")]
	public static float OMBOKJDOGMI(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x378D580", Offset = "0x378C780", VA = "0x18378D580")]
	public static void BOIDIABHGLA(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI, out float AHCGFILIFFM, out float MEMDHFDMDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x378E170", Offset = "0x378D370", VA = "0x18378E170")]
	public static float JBLAJMCFLIK(this float ONGBFDACHHG, Vector2 LMBJKPOFNJA, Vector2 LNMOFOCDKEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x378E7C0", Offset = "0x378D9C0", VA = "0x18378E7C0")]
	public static float LAFFGDDLOFP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x25079E0", Offset = "0x2506BE0", VA = "0x1825079E0")]
	public static float DGKGLMIIKNG(this float NIONDACONFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x378EC60", Offset = "0x378DE60", VA = "0x18378EC60")]
	public static float MJKHBBDDDBL(int DBCLLCJFNJM = 30)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x378E600", Offset = "0x378D800", VA = "0x18378E600")]
	public static Vector3 KEFKCKMCCEG(Vector3 GEOFMLLGABC, Vector3 ILOMMBLNKMA, float GAIPDLMAPJP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FCDBKMOEJMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3778D40", Offset = "0x3777F40", VA = "0x183778D40")]
	public static bool DFIECMNBGCO(this MonoBehaviour BKGIHIBDAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x378C960", Offset = "0x378BB60", VA = "0x18378C960")]
	public static void OMNDHPIFFEM(this MonoBehaviour BKGIHIBDAPA, Coroutine NEPMGGPMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x378C8D0", Offset = "0x378BAD0", VA = "0x18378C8D0")]
	public static void GLFCOPMIKLH(this MonoBehaviour BKGIHIBDAPA, IDisposable KECNNGMBHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x378C740", Offset = "0x378B940", VA = "0x18378C740")]
	public static Coroutine BCAKHIGACHG(this MonoBehaviour BKGIHIBDAPA, float BJJEDIGOMGC, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x378C810", Offset = "0x378BA10", VA = "0x18378C810")]
	public static Coroutine CHAAKFJCLIH(this MonoBehaviour BKGIHIBDAPA, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x378C920", Offset = "0x378BB20", VA = "0x18378C920")]
	public static bool ILCBJMDIMJC(this MonoBehaviour BKGIHIBDAPA, int DGDDMBOMHPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KKAHDGDOALA
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3792FA0", Offset = "0x37921A0", VA = "0x183792FA0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x15568E0", Offset = "0x1555AE0", VA = "0x1815568E0")]
		public NEKCJLGOGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x24C98F0", Offset = "0x24C8AF0", VA = "0x1824C98F0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x15568E0", Offset = "0x1555AE0", VA = "0x1815568E0")]
		public JMJHJMKLADO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x24C8D60", Offset = "0x24C7F60", VA = "0x1824C8D60")]
		internal bool <GetClosestSphereCastHit>b__0(RaycastHit h, float dSqr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly Collider[] DALFGEJDJMM;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly RaycastHit[] OEKJDIPLGML;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x18725D0", Offset = "0x18717D0", VA = "0x1818725D0")]
	public static T LGLGLKGNLMN<T>(Vector3 CACFKFOOHID, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, T> JFJJCCHICDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3792520", Offset = "0x3791720", VA = "0x183792520")]
	public static bool ILIFFJBJEIB(Ray OPMKFDNLHKI, float DJGCMOJICGK, out RaycastHit PAOKLBNMNFL, Func<RaycastHit, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1872200", Offset = "0x1871400", VA = "0x181872200")]
	public static T GDIGJECFAIH<T>(Vector3 CACFKFOOHID, float OMLBPICLALA, Vector3 DJBBMJBBNHB, int NNHBELIOIIM, float DJGCMOJICGK, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, float, T> JFJJCCHICDD, QueryTriggerInteraction CGAPEINEFPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3791F00", Offset = "0x3791100", VA = "0x183791F00")]
	public static Vector3 ABDJDBINPNA(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3792050", Offset = "0x3791250", VA = "0x183792050")]
	private static float HLJCBFHFBNC(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x37921C0", Offset = "0x37913C0", VA = "0x1837921C0")]
	public static bool HPMMIPJACPC(Ray OPMKFDNLHKI, float OMLBPICLALA, float DJGCMOJICGK, out RaycastHit HIFHEHIMEEM, Func<RaycastHit, float, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3791FA0", Offset = "0x37911A0", VA = "0x183791FA0")]
	public static void EOHKJJAHPKJ(this Rigidbody BECMPBBBFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3792790", Offset = "0x3791990", VA = "0x183792790")]
	public static float JKFIAIEANPC(this PhysicMaterial OJLJGNPJMLL, PhysicMaterial KBKEIKNPLEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3792A20", Offset = "0x3791C20", VA = "0x183792A20")]
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

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7E2F30", Offset = "0x7E2130", VA = "0x1807E2F30")]
	public CEMMJOMPAEL(Quaternion GAAKKDLBBGK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x378AAE0", Offset = "0x3789CE0", VA = "0x18378AAE0")]
	public static Quaternion FAJDMKOEFLH(CEMMJOMPAEL CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x378AA80", Offset = "0x3789C80", VA = "0x18378AA80")]
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

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3787B00", Offset = "0x3786D00", VA = "0x183787B00")]
	public static Vector3 OBKNOLONKAG(this Quaternion IGPENJBJADK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3787A00", Offset = "0x3786C00", VA = "0x183787A00")]
	public static Quaternion LIGCJPMNEHL(this Quaternion CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x37874D0", Offset = "0x37866D0", VA = "0x1837874D0")]
	public static Quaternion FNBCAEAEPDN(this Quaternion GAAKKDLBBGK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3787690", Offset = "0x3786890", VA = "0x183787690")]
	public static bool JNEMCKAMAMK(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3787640", Offset = "0x3786840", VA = "0x183787640")]
	public static bool JCLKGFMMODE(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3787A50", Offset = "0x3786C50", VA = "0x183787A50")]
	public static Quaternion MHKNGOGEBNG(this Quaternion NPEOEMEENIK, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3787380", Offset = "0x3786580", VA = "0x183787380")]
	public static Quaternion DKEHHDMGLPO(this Quaternion HICENEOPGOF, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3787C30", Offset = "0x3786E30", VA = "0x183787C30")]
	public static Quaternion PHDAPBGIHIN(this Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3787420", Offset = "0x3786620", VA = "0x183787420")]
	public static Quaternion FLNDPIEAFLK(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3787940", Offset = "0x3786B40", VA = "0x183787940")]
	public static Quaternion LBKFJAFFDJJ(Vector3 KHJFDILDLAD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x37876E0", Offset = "0x37868E0", VA = "0x1837876E0")]
	public static Vector3 KBILIJGGLPM(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3787200", Offset = "0x3786400", VA = "0x183787200")]
	public static Quaternion DHBDEABFFIO(Quaternion JDJIGPDAIEA, Quaternion HEGDAEMJLDE, ref Vector3 FNBDKACNNFH, float MGKFFIBNPNF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EILMCJGGDJA
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x378C530", Offset = "0x378B730", VA = "0x18378C530")]
	public static Rect INDNLPJJCNI(this Rect POMLCDIIKDM, Vector2 KPLDEODOJID)
	{
		return default(Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x378C4E0", Offset = "0x378B6E0", VA = "0x18378C4E0")]
	public static Vector2 EOPELBEEEID(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x378C6A0", Offset = "0x378B8A0", VA = "0x18378C6A0")]
	public static Vector2 OCAPBHHPCHJ(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x378C6F0", Offset = "0x378B8F0", VA = "0x18378C6F0")]
	public static Vector2 OLLAHCIHKFM(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x378C650", Offset = "0x378B850", VA = "0x18378C650")]
	public static Vector2 JANDCGIBIPJ(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class GPEBDLJLJAJ
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly int GMFKHCBFDHO;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static readonly MaterialPropertyBlock PHLNNAPOEIP;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3790760", Offset = "0x378F960", VA = "0x183790760")]
	public static Mesh ANIFOGABCAL(this Renderer CHEJPOIMMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3790910", Offset = "0x378FB10", VA = "0x183790910")]
	public static int JHIDBGOLCLD(this Renderer CHEJPOIMMCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3790BA0", Offset = "0x378FDA0", VA = "0x183790BA0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Color GJAINANBOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3790C80", Offset = "0x378FE80", VA = "0x183790C80")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, float ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3790AC0", Offset = "0x378FCC0", VA = "0x183790AC0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Vector4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x37909C0", Offset = "0x378FBC0", VA = "0x1837909C0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Matrix4x4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3790D50", Offset = "0x378FF50", VA = "0x183790D50")]
	public static void NHHLALGBEPB(this Renderer CHEJPOIMMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3790570", Offset = "0x378F770", VA = "0x183790570")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x37903D0", Offset = "0x378F5D0", VA = "0x1837903D0")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB, int NKJOCEKPCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class OMCHJHPFBDN
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3796A50", Offset = "0x3795C50", VA = "0x183796A50")]
	public static void KBFLHNONOHF(UnityEngine.Object BEKEOBJFIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3796B10", Offset = "0x3795D10", VA = "0x183796B10")]
	public static void KGFPNIMJHIC(GameObject DOJCFCINALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3796990", Offset = "0x3795B90", VA = "0x183796990")]
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
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x378BE30", Offset = "0x378B030", VA = "0x18378BE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x378BD90", Offset = "0x378AF90", VA = "0x18378BD90")]
	public static float KPCDDILAKBL()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FFENLNFBBPG
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x378C9F0", Offset = "0x378BBF0", VA = "0x18378C9F0")]
	public static byte[] APEDNIKLMAA(string MEIIMAIGBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x378CB30", Offset = "0x378BD30", VA = "0x18378CB30")]
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

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3791BA0", Offset = "0x3790DA0", VA = "0x183791BA0")]
	public static string MMDNDBLHCEL(string BILLCLFKNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3791700", Offset = "0x3790900", VA = "0x183791700")]
	public static string EMOFOGPOOLJ(string CKCGCFGOMAA, char JEEKALMPFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3791790", Offset = "0x3790990", VA = "0x183791790")]
	public static string FIJDNLILJFG(this string ONGBFDACHHG, int OMJLGGPHALE, string IEICOECHHLH = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3791E00", Offset = "0x3791000", VA = "0x183791E00")]
	public static int NPNNFCNGMID(this string ENMDDKHBHPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3791A80", Offset = "0x3790C80", VA = "0x183791A80")]
	public static bool LJGGMDGLNOO(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3791B00", Offset = "0x3790D00", VA = "0x183791B00")]
	public static bool MCOIBCNPNAP(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3791840", Offset = "0x3790A40", VA = "0x183791840")]
	public static bool IDLADJKDBBA(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3791A70", Offset = "0x3790C70", VA = "0x183791A70")]
	public static bool LJGBBKKGKOP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3791B90", Offset = "0x3790D90", VA = "0x183791B90")]
	public static bool MIABHAJOKBP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3791550", Offset = "0x3790750", VA = "0x183791550")]
	public static bool AFNHOCAOHON(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x37915D0", Offset = "0x37907D0", VA = "0x1837915D0")]
	public static bool AFNHOCAOHON(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3791810", Offset = "0x3790A10", VA = "0x183791810")]
	public static bool FOKJGKHGHMG(this string CKCGCFGOMAA, string ONGBFDACHHG, out int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3791760", Offset = "0x3790960", VA = "0x183791760")]
	public static bool FBFBJCMPOPJ(this string CKCGCFGOMAA, string ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x37918E0", Offset = "0x3790AE0", VA = "0x1837918E0")]
	public static bool IIPIEIOOMCL(string IPHIIJNAEON, string FOJLJNMAJLC, StringComparison GAJDDOLCCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3791DA0", Offset = "0x3790FA0", VA = "0x183791DA0")]
	public static string NLGELJNDBLM(this string ENMDDKHBHPA, string GNJIBIELEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3791660", Offset = "0x3790860", VA = "0x183791660")]
	public static string DNLAKCPLAPD(this string ENMDDKHBHPA, int MNIJHBJDPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3791940", Offset = "0x3790B40", VA = "0x183791940")]
	public static string KEJAABKOPJP(this string NMELNILPPKN, int PKNNNIDIOGF)
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

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CE0", Offset = "0x3F1EE0", VA = "0x1803F2CE0")]
		public POAHNJIPKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3796BD0", Offset = "0x3795DD0", VA = "0x183796BD0")]
		internal void <ConvertPixelsToGamma>b__0(int i)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x378C2D0", Offset = "0x378B4D0", VA = "0x18378C2D0")]
	public static void MHKFJCHNJEE(this Texture2D CAKFKAGPMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x378BEE0", Offset = "0x378B0E0", VA = "0x18378BEE0")]
	public static void FOFPEEMEIIC(this RenderTexture CNOGINOPPCH, ref Texture2D CAKFKAGPMBF, bool FKLJPOFDILI = false, bool LGJOOBAHIAC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CDCLKFOIBMC
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly Vector3[] ILMEMODIMEF;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3788FB0", Offset = "0x37881B0", VA = "0x183788FB0")]
	public static Vector3 CKMNPHLNJMA(this Transform OIFLDNBGJOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x37894C0", Offset = "0x37886C0", VA = "0x1837894C0")]
	public static Vector3 CPLMAMCMLFN(this Transform OIFLDNBGJOH, Vector3 KNIKPKEBLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x37892A0", Offset = "0x37884A0", VA = "0x1837892A0")]
	public static Vector3 CPLMAMCMLFN(Vector3 DEPGOBCBCAB, Vector3 FFGMLBJDGFM, Vector3 MGCJCNFHMEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x378A590", Offset = "0x3789790", VA = "0x18378A590")]
	public static Vector3 NFFAAMNNHGN(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3788E40", Offset = "0x3788040", VA = "0x183788E40")]
	public static Vector2 CJEBHAJDJMI(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3789A40", Offset = "0x3788C40", VA = "0x183789A40")]
	public static float ILCMBGMEPJE(this RectTransform AIOEKMHLKAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3789E10", Offset = "0x3789010", VA = "0x183789E10")]
	public static Vector3 JBLIBMEOLEB(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x378A6E0", Offset = "0x37898E0", VA = "0x18378A6E0")]
	public static Vector3[] PHMOKHIOHDG(this RectTransform AIOEKMHLKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x378A480", Offset = "0x3789680", VA = "0x18378A480")]
	public static Quaternion MHKNGOGEBNG(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3789760", Offset = "0x3788960", VA = "0x183789760")]
	public static Quaternion DKEHHDMGLPO(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x378A240", Offset = "0x3789440", VA = "0x18378A240")]
	public static Vector3 MHEFIHAJMAD(this Transform OIFLDNBGJOH, Vector3 DDHPAFKBMON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1B16A80", Offset = "0x1B15C80", VA = "0x181B16A80")]
	public static float LACCAFFAOIG(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3788C70", Offset = "0x3787E70", VA = "0x183788C70")]
	public static float ABDKFENDAKH(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3789F90", Offset = "0x3789190", VA = "0x183789F90")]
	public static void MCFLPFCGOOL(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3789C40", Offset = "0x3788E40", VA = "0x183789C40")]
	public static void IMCHPFPFLJJ(this Transform OIFLDNBGJOH, float MKDHFENOFDO, Vector3 KLNFHHBHGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3788CA0", Offset = "0x3787EA0", VA = "0x183788CA0")]
	public static void CAIHJLKEPIF(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x37891D0", Offset = "0x37883D0", VA = "0x1837891D0")]
	public static float CPEJGKGFNJH(this Transform OIFLDNBGJOH, float PLIPOIMDGPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x378A1C0", Offset = "0x37893C0", VA = "0x18378A1C0")]
	public static float MDGALGDEFAK(this Transform OIFLDNBGJOH, float JIBDGOKLJOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3789820", Offset = "0x3788A20", VA = "0x183789820")]
	public static void FABLENJPHFB(this RectTransform AIOEKMHLKAL, Vector3[] NPPHHLLMGEM, [Optional] Canvas NKKFJKIMHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GDCPJCHDFJH
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly Vector2 KPLGKEDLKLM;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xB6FF40", Offset = "0xB6F140", VA = "0x180B6FF40")]
	public static Vector2 KMEKBBFBKCA(Vector2 KDBHHDAJLNL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x378FFE0", Offset = "0x378F1E0", VA = "0x18378FFE0")]
	public static Vector2 KOLMGGDLPDK(this Vector2 PJEDBAONDPP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x378FFB0", Offset = "0x378F1B0", VA = "0x18378FFB0")]
	public static bool CDKDHNKFHFB(this Vector2 PDPPMFNOBMO, float ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x37900D0", Offset = "0x378F2D0", VA = "0x1837900D0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Up = 1,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Down = -1,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Right = 2,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Left = -2,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Forward = 3,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Back = -3
	}

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly float ODOBHKFMCMK;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x37949F0", Offset = "0x3793BF0", VA = "0x1837949F0")]
	public static Vector3 EMJNMOGIAKL(this IEnumerable<Vector3> COAEBIFOBNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3795AB0", Offset = "0x3794CB0", VA = "0x183795AB0")]
	public static float NMDFDMBNFNA(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3796380", Offset = "0x3795580", VA = "0x183796380")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Vector3 IDMBJGPOCAE, Vector3 MCEDKFKKOCM, Vector3 MJPDDCEFPIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3796560", Offset = "0x3795760", VA = "0x183796560")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x37961E0", Offset = "0x37953E0", VA = "0x1837961E0")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH, Vector3 EIHOAEHONBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x3796680", Offset = "0x3795880", VA = "0x183796680")]
	public static Vector3 PFLLEKCBAAL(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x3795B70", Offset = "0x3794D70", VA = "0x183795B70")]
	public static bool OGIEHPPFJCB(this Vector3 BMOIJACGPLN, float LBLHBGPCEMF = 0.001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x37954E0", Offset = "0x37946E0", VA = "0x1837954E0")]
	public static bool ICGLFNNJKAC(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x37950B0", Offset = "0x37942B0", VA = "0x1837950B0")]
	public static bool HPKDFLEPPCG(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3794960", Offset = "0x3793B60", VA = "0x183794960")]
	public static float DGNGDMGOMAA(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x37941C0", Offset = "0x37933C0", VA = "0x1837941C0")]
	public static float AHOKOGPDJNP(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x37948A0", Offset = "0x3793AA0", VA = "0x1837948A0")]
	public static Vector3 DDGPCFJMGII(this Vector3 DINHOLEGEMB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3795730", Offset = "0x3794930", VA = "0x183795730")]
	public static Vector3 JKGIHPNIJLK(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3794640", Offset = "0x3793840", VA = "0x183794640")]
	public static Vector3 BNKOIHAECHN(this Vector3 PJEDBAONDPP, float NNNGNCNIJAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3794560", Offset = "0x3793760", VA = "0x183794560")]
	public static bool BECDFHKOIGK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3795940", Offset = "0x3794B40", VA = "0x183795940")]
	public static bool JNEMCKAMAMK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3795690", Offset = "0x3794890", VA = "0x183795690")]
	public static bool JCLKGFMMODE(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x37945B0", Offset = "0x37937B0", VA = "0x1837945B0")]
	public static Vector3 BMNFGJPMFBG(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3795CA0", Offset = "0x3794EA0", VA = "0x183795CA0")]
	public static Vector3 OHHOPADHBAL(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3794CD0", Offset = "0x3793ED0", VA = "0x183794CD0")]
	public static float FLEMBFIOFJA(this Vector3 BANGBIKOBGO, Vector3 OALKOHJOHFO, [Optional] Vector3? KNIKPKEBLNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3795A90", Offset = "0x3794C90", VA = "0x183795A90")]
	public static Vector3 NELNDENOBLC(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3795120", Offset = "0x3794320", VA = "0x183795120")]
	public static Vector3 IBPJJIDHFFL(Vector3 CHGNDIAMGLF, Quaternion IBCNKFBPCBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3795D30", Offset = "0x3794F30", VA = "0x183795D30")]
	public static KCNMMJEKPBC OJDKGBIHNJD(Transform OIFLDNBGJOH, Vector3 MAPAFOGPKLL, out Vector3 GLHHBDHELAO)
	{
		return default(KCNMMJEKPBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3794E90", Offset = "0x3794090", VA = "0x183794E90")]
	public static Vector3 GKDMJPGOEHO(float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3795080", Offset = "0x3794280", VA = "0x183795080")]
	public static Vector3 HOCFJJAOPDC(float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3794870", Offset = "0x3793A70", VA = "0x183794870")]
	public static Vector3 CLEFGACGMKH(float FOBCKBCBJHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3794F80", Offset = "0x3794180", VA = "0x183794F80")]
	public static Vector3 GNOENAFKJIE(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x37959A0", Offset = "0x3794BA0", VA = "0x1837959A0")]
	public static Vector3 KICDFOACKEL(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x37956F0", Offset = "0x37948F0", VA = "0x1837956F0")]
	public static Vector3 JJOELJJFBAE(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x37947B0", Offset = "0x37939B0", VA = "0x1837947B0")]
	public static Vector3 CIOKEDCFPJI(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x37967B0", Offset = "0x37959B0", VA = "0x1837967B0")]
	public static Vector3 PGCOBFHPJEA(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3796870", Offset = "0x3795A70", VA = "0x183796870")]
	public static Vector3 PLINJEJIIMO(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x37944A0", Offset = "0x37936A0", VA = "0x1837944A0")]
	public static Vector3 BCICENEBNCF(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3794EC0", Offset = "0x37940C0", VA = "0x183794EC0")]
	public static Vector3 GMNHMHPHIJK(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x37959E0", Offset = "0x3794BE0", VA = "0x1837959E0")]
	public static Vector3 KKANLJKPHJI(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3794FC0", Offset = "0x37941C0", VA = "0x183794FC0")]
	public static Vector3 HCLHKJPLONK(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3795550", Offset = "0x3794750", VA = "0x183795550")]
	public static Vector3 IKBIEPLCAKN(Vector3 HGEIABGCFOA, Vector3 IBHEKLCMMNH, Vector3 KNIKPKEBLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3794250", Offset = "0x3793450", VA = "0x183794250")]
	public static Vector3 AOGDEGACCAP(Vector3 PJEDBAONDPP, Vector3 OOEKLKBHAHK, Vector3 AIOJLAJOCEL, bool PNLBALPIOHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x37957F0", Offset = "0x37949F0", VA = "0x1837957F0")]
	public static float JMAEBJBJADJ(this Vector3 BANGBIKOBGO, Vector3 OALKOHJOHFO, Vector3 JKKKLNNDOCL, bool DBIKMABANKE = false)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct JFCMGKMLBMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly RenderTexture LCJOPCGBDFO;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3792E40", Offset = "0x3792040", VA = "0x183792E40")]
	public JFCMGKMLBMN(RenderTexture BGFEHOIGLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3792E30", Offset = "0x3792030", VA = "0x183792E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FNHMBIFJJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x378FCC0", Offset = "0x378EEC0", VA = "0x18378FCC0")]
	public static Quaternion CHDHKJJADFE(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x1B16AB0", Offset = "0x1B15CB0", VA = "0x181B16AB0")]
	public static Vector3 DOAOMJFMLLN(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x378FE00", Offset = "0x378F000", VA = "0x18378FE00")]
	public static Vector3 OHAKMAOEKCG(this Matrix4x4 BKPMKIIFPKO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class IJHPIMJMEIB
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x194DF20", Offset = "0x194D120", VA = "0x18194DF20")]
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
