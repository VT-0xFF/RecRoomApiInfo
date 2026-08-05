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
		[Cpp2IlInjected.Address(RVA = "0x61E2F0", Offset = "0x61D2F0", VA = "0x18061E2F0")]
		public HPIEIOAGEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68E850", Offset = "0x68D850", VA = "0x18068E850")]
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
		[Cpp2IlInjected.Address(RVA = "0x61E2F0", Offset = "0x61D2F0", VA = "0x18061E2F0")]
		public IEKPHHLNIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68E890", Offset = "0x68D890", VA = "0x18068E890")]
		internal string <ToFriendlyString>b__1(string s, string s1)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2F10970", Offset = "0x2F0F970", VA = "0x182F10970")]
	public static string JIIMHOLCECD<T>(this IEnumerable<T> NKLIOLCGIDM, [Optional] Func<T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2F104C0", Offset = "0x2F0F4C0", VA = "0x182F104C0")]
	public static string JIIMHOLCECD<T>(this IList<T> DAAFDLFCOGO, [Optional] Func<int, T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26C9270", Offset = "0x26C8270", VA = "0x1826C9270")]
	[IteratorStateMachine(typeof(AEABJMALBDK))]
	public static IEnumerable<T> MJJDFHHAOPM<T>(T IOBEPGLJNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F0B0", Offset = "0x2D1E0B0", VA = "0x182D1F0B0")]
	public static (T[], U[]) HKJNIHLKENA<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1D8DA0", Offset = "0x1D81A0")] this IEnumerable<(T, U)> NMELNILPPKN)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2D34A10", Offset = "0x2D33A10", VA = "0x182D34A10")]
	public static IEnumerable<(T, int)> AKGEGLEMFGM<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D1F690", Offset = "0x2D1E690", VA = "0x182D1F690")]
	public static void HOAGBPIIIGP<T>(this IEnumerable<T> NMELNILPPKN, Action<T> EDECJKLDKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2820030", Offset = "0x281F030", VA = "0x182820030")]
	public static HashSet<T> PBGCPCJGGOO<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D34BD0", Offset = "0x2D33BD0", VA = "0x182D34BD0")]
	public static IEnumerable<T> HDLDCPJDNDA<T>(this IEnumerable<T> NKLIOLCGIDM, int KKDPFGADCEK, int MADNOGDODFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2D34C10", Offset = "0x2D33C10", VA = "0x182D34C10")]
	public static IEnumerable<T> KPDAENONKPJ<T, TKey>(this IEnumerable<T> NKLIOLCGIDM, Func<T, TKey> HDLMHEHINBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CEEHAKJPFHM
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F1D0", Offset = "0x1C5E1D0", VA = "0x181C5F1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C68670", Offset = "0x1C67670", VA = "0x181C68670")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static float JHAFCFMBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xC0F720", Offset = "0xC0E720", VA = "0x180C0F720")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static float DGEAEHEJCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1C68600", Offset = "0x1C67600", VA = "0x181C68600")]
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
	[Cpp2IlInjected.Address(RVA = "0x1C687C0", Offset = "0x1C677C0", VA = "0x181C687C0")]
	public static bool BKDAHHMFHMC(this DateTime? PBMJJOMBPAH, TimeSpan DOFKHNLEKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1C688F0", Offset = "0x1C678F0", VA = "0x181C688F0")]
	public static string PAKENNFHMEG(this TimeSpan DOFKHNLEKKP, string FEGAGLFEGEP = "minute", bool JKEPCLNFJHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1C68860", Offset = "0x1C67860", VA = "0x181C68860")]
	private static string HIDOGKBNNLG(string IGCKACBLCON, double KEOKDMNJJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IEDIJNKECOL
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1C67610", Offset = "0x1C66610", VA = "0x181C67610")]
	public static string MJHFHBGFJHF(this Type GEDCEIDOKJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LFDJHEDEGAJ
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1C68680", Offset = "0x1C67680", VA = "0x181C68680")]
	public static void DBCCNEMNLNI(this Animator LDOJFIEANFB, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1C68700", Offset = "0x1C67700", VA = "0x181C68700")]
	public static void DOMIGIEBFCF(this Animator LDOJFIEANFB, int ENJEOLBEALP, bool ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1C68760", Offset = "0x1C67760", VA = "0x181C68760")]
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
			[Cpp2IlInjected.Address(RVA = "0xAE6AF0", Offset = "0xAE5AF0", VA = "0x180AE6AF0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAF1740", Offset = "0xAF0740", VA = "0x180AF1740")]
		public MKNPILCJOAI(T[] GMOGECKNEEN, IGHKKHEGGBB<T> BKHGMOKDLGO, int DCFEFKGJDOJ, Func<bool> AEMDDGKHONP, T[] CJDMEOAEMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAF1380", Offset = "0xAF0380", VA = "0x180AF1380")]
		public bool CDHNACEAFJL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3253890", Offset = "0x3252890", VA = "0x183253890")]
	public static T[] APNIJAHEGLJ<T>(int OJJOHDIFMEG, T MCACHDBIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x34A9470", Offset = "0x34A8470", VA = "0x1834A9470")]
	public static void KDEILFALGLM<T>(this T[] JABGABGMHPL, T MCACHDBIALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x34A8F20", Offset = "0x34A7F20", VA = "0x1834A8F20")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x34A8D20", Offset = "0x34A7D20", VA = "0x1834A8D20")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA, int OIDPFPMBCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x34A8FB0", Offset = "0x34A7FB0", VA = "0x1834A8FB0")]
	public static void CDLEKIKHHCD<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO, [Optional] T[] CJDMEOAEMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x34A9050", Offset = "0x34A8050", VA = "0x1834A9050")]
	private static void JIHBNKEBJDH<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int DJICGHFJJJP, T[] EPDKOCHMOLC, bool GOJFBEJBPBC, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x34A95E0", Offset = "0x34A85E0", VA = "0x1834A95E0")]
	private static void MNMAEDHAEFJ<T>(this T[] NMELNILPPKN, int ANDOICCNDLA, int GFKCDKBFBBN, T[] HPKICPNGMDJ, int MDIFJBFIGHL, int PPNMMGMDEJI, T[] GIAOBLMEMMI, int CAPPAKEKPLG, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34A9A10", Offset = "0x34A8A10", VA = "0x1834A9A10")]
	public static void OIEHNKDGJKK<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int MNIJHBJDPPA, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C87C10", Offset = "0x2C86C10", VA = "0x182C87C10")]
	public static MKNPILCJOAI<T> JKMCDDAPLHN<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO, int DCFEFKGJDOJ, Func<bool> AEMDDGKHONP, [Optional] T[] CJDMEOAEMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3254210", Offset = "0x3253210", VA = "0x183254210")]
	public static T[] NHGMLEGCCMP<T>(this T[] OPEBNMBKJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3254230", Offset = "0x3253230", VA = "0x183254230")]
	public static T[] PPMHFINCJNE<T>(this T[] IHFOIAODAJC, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3253BC0", Offset = "0x3252BC0", VA = "0x183253BC0")]
	public static T[] DECCCEINGDI<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3254160", Offset = "0x3253160", VA = "0x183254160")]
	public static T[] HNNOENGPBPL<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x32539A0", Offset = "0x32529A0", VA = "0x1832539A0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1C65FA0", Offset = "0x1C64FA0", VA = "0x181C65FA0")]
		public HKLGKBLGDMN(GameObject DOJCFCINALC, bool AHOAECJDPGH, NCHPJLFOHGM MPBIKBNEFGP, bool CLAOPEDMPGL, Type GEDCEIDOKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1C658F0", Offset = "0x1C648F0", VA = "0x181C658F0", Slot = "4")]
		public bool Equals(HKLGKBLGDMN HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1C65850", Offset = "0x1C64850", VA = "0x181C65850", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1C65A00", Offset = "0x1C64A00", VA = "0x181C65A00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1C65AC0", Offset = "0x1C64AC0", VA = "0x181C65AC0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1C61B20", Offset = "0x1C60B20", VA = "0x181C61B20")]
	public static void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2B04110", Offset = "0x2B03110", VA = "0x182B04110")]
	public static T FABKIOBNCHE<T>(this GameObject DOJCFCINALC, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2B043E0", Offset = "0x2B033E0", VA = "0x182B043E0")]
	public static T JLOAAIEKGLO<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2B04500", Offset = "0x2B03500", VA = "0x182B04500")]
	public static T MHBNENBBNDJ<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x281EB60", Offset = "0x281DB60", VA = "0x18281EB60")]
	public static IReadOnlyList<T> HLCNADOGJFC<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x281F060", Offset = "0x281E060", VA = "0x18281F060")]
	public static IReadOnlyList<T> PHJEODMHDOK<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B04220", Offset = "0x2B03220", VA = "0x182B04220")]
	private static T JGCKGHNCPPC<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x281EDB0", Offset = "0x281DDB0", VA = "0x18281EDB0")]
	private static IReadOnlyList<T> OFLKKOAGMFK<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1C61A80", Offset = "0x1C60A80", VA = "0x181C61A80")]
	private static void KIPECKHDOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1C61670", Offset = "0x1C60670", VA = "0x181C61670")]
	private static void JOMBFKGNCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x281EF60", Offset = "0x281DF60", VA = "0x18281EF60")]
	private static IReadOnlyList<T> OIJCNPEICPD<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x281EC80", Offset = "0x281DC80", VA = "0x18281EC80")]
	private static IReadOnlyList<T> MAALAKFHBNE<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BOHNIEMGLMC
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D220", Offset = "0x1C5C220", VA = "0x181C5D220")]
	public static float ELCHENEAFFD(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D890", Offset = "0x1C5C890", VA = "0x181C5D890")]
	public static float OOIKMLIOLHN(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D6C0", Offset = "0x1C5C6C0", VA = "0x181C5D6C0")]
	public static float KCHIFOHABON(this Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D020", Offset = "0x1C5C020", VA = "0x181C5D020")]
	private static float DBBKCKNDNOJ(float PPLEDBHELNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D090", Offset = "0x1C5C090", VA = "0x181C5D090")]
	private static float DBBKCKNDNOJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D4C0", Offset = "0x1C5C4C0", VA = "0x181C5D4C0")]
	private static float FMJNGGHKBNJ(float PPLEDBHELNG, float EHDMLFDEBAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D480", Offset = "0x1C5C480", VA = "0x181C5D480")]
	private static float FMJNGGHKBNJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D370", Offset = "0x1C5C370", VA = "0x181C5D370")]
	public static float FGCPIGKOIHD(float PPLEDBHELNG, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D250", Offset = "0x1C5C250", VA = "0x181C5D250")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D290", Offset = "0x1C5C290", VA = "0x181C5D290")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, Vector2 IJHJIKGDNJH, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1C5CF70", Offset = "0x1C5BF70", VA = "0x181C5CF70")]
	private static float CIMKJKMKPGG(float DABFKGJPFDC, float IJHJIKGDNJH, float PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D540", Offset = "0x1C5C540", VA = "0x181C5D540")]
	public static float JKGBBKLIAMK(float GGJOIJAKDDC, float EHDMLFDEBAF, Vector2 IJHJIKGDNJH, float HGFAGBNEADJ, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D7D0", Offset = "0x1C5C7D0", VA = "0x181C5D7D0")]
	private static float NEANFKGDFBM(float DABFKGJPFDC, float IJHJIKGDNJH, float HGFAGBNEADJ, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D110", Offset = "0x1C5C110", VA = "0x181C5D110")]
	public static void DBJKGNBKPDI(this Camera FOMHGMLPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D770", Offset = "0x1C5C770", VA = "0x181C5D770")]
	public static bool LPBHGEJLJKD(this Camera FOMHGMLPOND, Renderer CHEJPOIMMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D1A0", Offset = "0x1C5C1A0", VA = "0x181C5D1A0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C5FF40", Offset = "0x1C5EF40", VA = "0x181C5FF40")]
	public static bool HAKOLMGKNPH(this Collider GLPOLGOBLAA, Vector3 KMIFDIBBCDI, Vector3 EDKKBNDGKAO, float OMLBPICLALA, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, out RaycastHit IIILNCEEBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F510", Offset = "0x1C5E510", VA = "0x181C5F510")]
	public static int AMAOMIJGJBF(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, Collider[] GIJOIBPGGOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1C5FCA0", Offset = "0x1C5ECA0", VA = "0x181C5FCA0")]
	public static bool FKFGLHIBHJC(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1C60490", Offset = "0x1C5F490", VA = "0x181C60490")]
	public static int NBOGLHFIMJA(this BoxCollider GLPOLGOBLAA, Collider[] PANOGCJFAOD, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1C602A0", Offset = "0x1C5F2A0", VA = "0x181C602A0")]
	public static bool KCFPIEEMJON(this BoxCollider CEGIONPIIAO, Vector3 NAIDPMBKHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F8E0", Offset = "0x1C5E8E0", VA = "0x181C5F8E0")]
	public static bool FKFGLHIBHJC(this CapsuleCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1C60210", Offset = "0x1C5F210", VA = "0x181C60210")]
	public static Vector3 HHNMMNMLAMF(this BoxCollider GLPOLGOBLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F7D0", Offset = "0x1C5E7D0", VA = "0x181C5F7D0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1C68510", Offset = "0x1C67510", VA = "0x181C68510")]
	public static Color FKDFDGMNNLG(this Color GJAINANBOCB, float FBPFONBFPEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1C68420", Offset = "0x1C67420", VA = "0x181C68420")]
	public static Vector3 AHOMKMDCPOH(this Vector3 DKIELBAENOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1C68320", Offset = "0x1C67320", VA = "0x181C68320")]
	public static Color AHOMKMDCPOH(this Color DKIELBAENOL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1C68550", Offset = "0x1C67550", VA = "0x181C68550")]
	public static Color LGPCCFOGKGG(this Color GJAINANBOCB, float IOAMFOPBCMN)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BEBOIKCDHFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C9A0", Offset = "0x1C5B9A0", VA = "0x181C5C9A0")]
	public static void OFKIHGPJHJI(this Component CKCMODJNCNF, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x281C0B0", Offset = "0x281B0B0", VA = "0x18281C0B0")]
	public static List<T> PFOKAFNFHHM<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFED0", Offset = "0x2AFEED0", VA = "0x182AFFED0")]
	public static T LNJIMABEJLG<T>(this Component CKCMODJNCNF, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EJFNMBLOPLC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2D35270", Offset = "0x2D34270", VA = "0x182D35270")]
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
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x40B080", Offset = "0x40A080", VA = "0x18040B080")]
		[DebuggerHidden]
		public AFMAGHBPHLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1C5BD70", Offset = "0x1C5AD70", VA = "0x181C5BD70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1C5BE20", Offset = "0x1C5AE20", VA = "0x181C5BE20", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x40B080", Offset = "0x40A080", VA = "0x18040B080")]
		[DebuggerHidden]
		public EGJGCHCIGPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1C60DF0", Offset = "0x1C5FDF0", VA = "0x181C60DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1C60EA0", Offset = "0x1C5FEA0", VA = "0x181C60EA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static WaitForEndOfFrame NAKHMEPNJEL;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1C678E0", Offset = "0x1C668E0", VA = "0x181C678E0")]
	[IteratorStateMachine(typeof(AFMAGHBPHLI))]
	public static IEnumerator BCAKHIGACHG(float CAHAMMIHDFG, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1C67950", Offset = "0x1C66950", VA = "0x181C67950")]
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
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1C67800", Offset = "0x1C66800", VA = "0x181C67800", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1C677D0", Offset = "0x1C667D0", VA = "0x181C677D0")]
	public IGHCGCAGAFH(float HABFNPMBADP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CDHKGKPIOLK
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x323A4A0", Offset = "0x32394A0", VA = "0x18323A4A0")]
	public static TValue KGAPEMHMJHI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG) where TValue : new()
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x323A740", Offset = "0x3239740", VA = "0x18323A740")]
	public static TValue PLOELFMPHEI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x323A0D0", Offset = "0x32390D0", VA = "0x18323A0D0")]
	public static TValue GLPALAONCFG<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FKFGKDOBBOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1C645F0", Offset = "0x1C635F0", VA = "0x181C645F0")]
	public static string CPIKLJJCBAB(this Guid COFLAJFOPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1C64510", Offset = "0x1C63510", VA = "0x181C64510")]
	public static string CPIKLJJCBAB(this byte[] MGPDDEMABPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LBEHNMANHHL
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1C67AA0", Offset = "0x1C66AA0", VA = "0x181C67AA0")]
	public static string GKBCGFOAIJM(this FileInfo NOHHLFHPPDF, string IFKMFOPALAO, string EAEOAIMAJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1C67C50", Offset = "0x1C66C50", VA = "0x181C67C50")]
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
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3E6170", Offset = "0x3E5170", VA = "0x1803E6170", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x448FC0", Offset = "0x447FC0", VA = "0x180448FC0")]
		[DebuggerHidden]
		public BJBOHHCEKDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCA0", Offset = "0x3EECA0", VA = "0x1803EFCA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1C5CD90", Offset = "0x1C5BD90", VA = "0x181C5CD90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1C5CF20", Offset = "0x1C5BF20", VA = "0x181C5CF20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1C5CE80", Offset = "0x1C5BE80", VA = "0x181C5CE80", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1C5CE80", Offset = "0x1C5BE80", VA = "0x181C5CE80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Dictionary<int, int> IKJIECFLKJL;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2BCA870", Offset = "0x2BC9870", VA = "0x182BCA870")]
	public static T LNJIMABEJLG<T>(this GameObject DOJCFCINALC, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2B07AF0", Offset = "0x2B06AF0", VA = "0x182B07AF0")]
	public static T GLENGLDKGCK<T>(this GameObject DOJCFCINALC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2B07AC0", Offset = "0x2B06AC0", VA = "0x182B07AC0")]
	public static T GLENGLDKGCK<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2D2F1C0", Offset = "0x2D2E1C0", VA = "0x182D2F1C0")]
	public static void IFFLOPMPLPN<T>(this GameObject DOJCFCINALC, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2D2F110", Offset = "0x2D2E110", VA = "0x182D2F110")]
	public static void IFFLOPMPLPN<T>(this Component CKCMODJNCNF, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2D2F270", Offset = "0x2D2E270", VA = "0x182D2F270")]
	public static void OPKLCCBLMCM<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1C680E0", Offset = "0x1C670E0", VA = "0x181C680E0")]
	public static void OLLDCMIMDLM(this GameObject DOJCFCINALC, string GHBNIGCAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1C67DE0", Offset = "0x1C66DE0", VA = "0x181C67DE0")]
	public static string AOEFKLMCCGH(this GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1C67F10", Offset = "0x1C66F10", VA = "0x181C67F10")]
	[IteratorStateMachine(typeof(BJBOHHCEKDF))]
	private static IEnumerable<string> CLDAIOKJMCC(GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1C67F80", Offset = "0x1C66F80", VA = "0x181C67F80")]
	public static int MOOKPIOIGOD(this GameObject NLNHFEEMFBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LOJLAODGLLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3283CF0", Offset = "0x3282CF0", VA = "0x183283CF0")]
	public static V ODHHPEIEBCB<V, T>(this T LIMOILDIGKF, Func<T, V> PAFOMEECIMH, [Optional] V OANDOPIEEPO) where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D2F710", Offset = "0x2D2E710", VA = "0x182D2F710")]
	public static void CLELOGIOOCO<T>(this T LIMOILDIGKF, Action<T> PAFOMEECIMH) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ECNNGIFNNNM
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D94550", Offset = "0x2D93550", VA = "0x182D94550")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> OPEBNMBKJJA, T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D212C0", Offset = "0x2D202C0", VA = "0x182D212C0")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D21350", Offset = "0x2D20350", VA = "0x182D21350")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO, int KIJHGBLLCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x281C370", Offset = "0x281B370", VA = "0x18281C370")]
	public static List<T> FHAOCJFENEF<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D94480", Offset = "0x2D93480", VA = "0x182D94480")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> DAAFDLFCOGO, Predicate<T> HBPBAJNLGCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DEF0", Offset = "0x2E7CEF0", VA = "0x182E7DEF0")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DAB0", Offset = "0x2E7CAB0", VA = "0x182E7DAB0")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP, EqualityComparer<T> KFBHPCHEJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2D93870", Offset = "0x2D92870", VA = "0x182D93870")]
	public static int IBKMBGJGECB<TElement, TKey>(this IList<TElement> LLOIOFKDLFP, TKey IFHDIPBMJOI, Func<TElement, TKey> IHHAGJMACDJ, [Optional] Func<TKey, TKey, int> BKHGMOKDLGO, int EFBDCIJMFGD = 0, [Optional] int? MNIJHBJDPPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2B03280", Offset = "0x2B02280", VA = "0x182B03280")]
	public static T NBMJEPIPHGC<T>(this IReadOnlyList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2E7E030", Offset = "0x2E7D030", VA = "0x182E7E030")]
	public static bool KFDLNLFOGBN<T>(this List<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2D21B50", Offset = "0x2D20B50", VA = "0x182D21B50")]
	public static void AINCGKKANMC<T>(this List<T> DAAFDLFCOGO, IEnumerable<T> CGBHMNCBAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B031C0", Offset = "0x2B021C0", VA = "0x182B031C0")]
	public static T NBMJEPIPHGC<T>(this T[] DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2B07900", Offset = "0x2B06900", VA = "0x182B07900")]
	public static void OHDOOOKOMNB<T>(this List<T> CGBHMNCBAGA) where T : UnityEngine.Object
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B03000", Offset = "0x2B02000", VA = "0x182B03000")]
	public static T LLFCJKLELNH<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B02A70", Offset = "0x2B01A70", VA = "0x182B02A70")]
	public static T BMCEKIFDDJK<T>(this List<T> CGBHMNCBAGA, int EFBDCIJMFGD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2E7C6A0", Offset = "0x2E7B6A0", VA = "0x182E7C6A0")]
	public static bool IDCGECLDIDG<T>(this List<T> LNFKAGBJHOA, List<T> ADFLPMKFAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B02E80", Offset = "0x2B01E80", VA = "0x182B02E80")]
	public static T GPEBLICLPML<T>(this IList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2E7E0A0", Offset = "0x2E7D0A0", VA = "0x182E7E0A0")]
	public static bool MGIGDPBNABL<T>(IReadOnlyList<T> DAAFDLFCOGO, int EFBDCIJMFGD, out T GIAOBLMEMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2E7D7C0", Offset = "0x2E7C7C0", VA = "0x182E7D7C0")]
	public static bool JEACGAIICGO<T>(IReadOnlyList<T> DAAFDLFCOGO, ICollection CGBHMNCBAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2D21A40", Offset = "0x2D20A40", VA = "0x182D21A40")]
	public static void AEONHOJKJNI<T>(IReadOnlyList<T> DAAFDLFCOGO, ref ICollection CGBHMNCBAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF350", Offset = "0x2DDE350", VA = "0x182DDF350")]
	public static bool LJGBBKKGKOP<T>(this IReadOnlyList<T> DAAFDLFCOGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GEKPCDJEJAK
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x9CEC80", Offset = "0x9CDC80", VA = "0x1809CEC80")]
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

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1C63700", Offset = "0x1C62700", VA = "0x181C63700")]
	public static bool MOHPPAOIEMG(int ONGBFDACHHG, int GOICNKGDJEC, int KEBJAIELILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1C641B0", Offset = "0x1C631B0", VA = "0x181C641B0")]
	public static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1C62590", Offset = "0x1C61590", VA = "0x181C62590")]
	public static float GDKJPBLEGLK(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C63720", Offset = "0x1C62720", VA = "0x181C63720")]
	public static void NADMLFBBFJB(Vector3 JLCIKNNKEAD, out float LMMPJCFJDOL, out float NOFFCKDIOEP, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C63AB0", Offset = "0x1C62AB0", VA = "0x181C63AB0")]
	public static void NPCJFNAJALO(Vector3 JLCIKNNKEAD, out float LBJOIGNPPFB, out float CEOHNIOICHD, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1C64370", Offset = "0x1C63370", VA = "0x181C64370")]
	public static Vector3 PDLGILNJNGC(float LMMPJCFJDOL, float NOFFCKDIOEP, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C62420", Offset = "0x1C61420", VA = "0x181C62420")]
	public static Vector3 FNKFOCAIBGE(float LBJOIGNPPFB, float CEOHNIOICHD, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1C629F0", Offset = "0x1C619F0", VA = "0x181C629F0")]
	public static Vector3 HMGHBDPPJAG(Vector3 BBMDCKFFPCE, Vector3 JIOIOMDOAJA, Vector3 KHCCKHOEOKP, Vector3 IJGHHKBAIDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1C62050", Offset = "0x1C61050", VA = "0x181C62050")]
	public static bool CFKHNLPBCCE(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1C63200", Offset = "0x1C62200", VA = "0x181C63200")]
	public static float MBLIIPEMOGB(Ray FAACBOBPIKK, Ray HEGDAEMJLDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1C63CF0", Offset = "0x1C62CF0", VA = "0x181C63CF0")]
	private static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC, float BANKGLOHKOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1C61C50", Offset = "0x1C60C50", VA = "0x181C61C50")]
	public static bool BAHBPFFNNJO(float IPHIIJNAEON, float FOJLJNMAJLC, float CIIMMENGOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1C62120", Offset = "0x1C61120", VA = "0x181C62120")]
	public static Vector3 DBDLNMAONIL(Vector3 KPLDEODOJID, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1C62280", Offset = "0x1C61280", VA = "0x181C62280")]
	public static Vector3 EAEOKLNFADK(Vector3 DJBBMJBBNHB, Vector3 CKPHGEEPNDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1C62680", Offset = "0x1C61680", VA = "0x181C62680")]
	public static void GEFDMDGMEBM(Transform OIFLDNBGJOH, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH, Vector3 AADLCEBLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1C62BC0", Offset = "0x1C61BC0", VA = "0x181C62BC0")]
	public static Vector3 JPGHEAINBKJ(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float PIHLBMOKPFJ, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1C63800", Offset = "0x1C62800", VA = "0x181C63800")]
	public static Vector3 NDEFIIAMEPM(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1C61CE0", Offset = "0x1C60CE0", VA = "0x181C61CE0")]
	private static float BNGIECEAJKA(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1C63A90", Offset = "0x1C62A90", VA = "0x181C63A90")]
	public static float NKBLAPMGFEN(float FLIEBIMFHEN, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1C64350", Offset = "0x1C63350", VA = "0x181C64350")]
	public static float PCHIOIGDICJ(float JDFENOCNKAD, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1C63BD0", Offset = "0x1C62BD0", VA = "0x181C63BD0")]
	public static float OMBOKJDOGMI(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1C61F90", Offset = "0x1C60F90", VA = "0x181C61F90")]
	public static void BOIDIABHGLA(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI, out float AHCGFILIFFM, out float MEMDHFDMDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1C62B80", Offset = "0x1C61B80", VA = "0x181C62B80")]
	public static float JBLAJMCFLIK(this float ONGBFDACHHG, Vector2 LMBJKPOFNJA, Vector2 LNMOFOCDKEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1C631D0", Offset = "0x1C621D0", VA = "0x181C631D0")]
	public static float LAFFGDDLOFP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0xB92D50", Offset = "0xB91D50", VA = "0x180B92D50")]
	public static float DGKGLMIIKNG(this float NIONDACONFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1C63670", Offset = "0x1C62670", VA = "0x181C63670")]
	public static float MJKHBBDDDBL(int DBCLLCJFNJM = 30)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1C63010", Offset = "0x1C62010", VA = "0x181C63010")]
	public static Vector3 KEFKCKMCCEG(Vector3 GEOFMLLGABC, Vector3 ILOMMBLNKMA, float GAIPDLMAPJP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FCDBKMOEJMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1C3BB60", Offset = "0x1C3AB60", VA = "0x181C3BB60")]
	public static bool DFIECMNBGCO(this MonoBehaviour BKGIHIBDAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1C61370", Offset = "0x1C60370", VA = "0x181C61370")]
	public static void OMNDHPIFFEM(this MonoBehaviour BKGIHIBDAPA, Coroutine NEPMGGPMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C612E0", Offset = "0x1C602E0", VA = "0x181C612E0")]
	public static void GLFCOPMIKLH(this MonoBehaviour BKGIHIBDAPA, IDisposable KECNNGMBHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1C61150", Offset = "0x1C60150", VA = "0x181C61150")]
	public static Coroutine BCAKHIGACHG(this MonoBehaviour BKGIHIBDAPA, float BJJEDIGOMGC, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1C61220", Offset = "0x1C60220", VA = "0x181C61220")]
	public static Coroutine CHAAKFJCLIH(this MonoBehaviour BKGIHIBDAPA, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1C61330", Offset = "0x1C60330", VA = "0x181C61330")]
	public static bool ILCBJMDIMJC(this MonoBehaviour BKGIHIBDAPA, int DGDDMBOMHPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KKAHDGDOALA
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1C67A10", Offset = "0x1C66A10", VA = "0x181C67A10")]
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

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x61E2F0", Offset = "0x61D2F0", VA = "0x18061E2F0")]
		public NEKCJLGOGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xDA6B10", Offset = "0xDA5B10", VA = "0x180DA6B10")]
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

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x61E2F0", Offset = "0x61D2F0", VA = "0x18061E2F0")]
		public JMJHJMKLADO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xDA5E40", Offset = "0xDA4E40", VA = "0x180DA5E40")]
		internal bool <GetClosestSphereCastHit>b__0(RaycastHit h, float dSqr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly Collider[] DALFGEJDJMM;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly RaycastHit[] OEKJDIPLGML;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B06610", Offset = "0x2B05610", VA = "0x182B06610")]
	public static T LGLGLKGNLMN<T>(Vector3 CACFKFOOHID, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, T> JFJJCCHICDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1C66F90", Offset = "0x1C65F90", VA = "0x181C66F90")]
	public static bool ILIFFJBJEIB(Ray OPMKFDNLHKI, float DJGCMOJICGK, out RaycastHit PAOKLBNMNFL, Func<RaycastHit, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B06240", Offset = "0x2B05240", VA = "0x182B06240")]
	public static T GDIGJECFAIH<T>(Vector3 CACFKFOOHID, float OMLBPICLALA, Vector3 DJBBMJBBNHB, int NNHBELIOIIM, float DJGCMOJICGK, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, float, T> JFJJCCHICDD, QueryTriggerInteraction CGAPEINEFPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1C66970", Offset = "0x1C65970", VA = "0x181C66970")]
	public static Vector3 ABDJDBINPNA(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1C66AC0", Offset = "0x1C65AC0", VA = "0x181C66AC0")]
	private static float HLJCBFHFBNC(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1C66C30", Offset = "0x1C65C30", VA = "0x181C66C30")]
	public static bool HPMMIPJACPC(Ray OPMKFDNLHKI, float OMLBPICLALA, float DJGCMOJICGK, out RaycastHit HIFHEHIMEEM, Func<RaycastHit, float, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1C66A10", Offset = "0x1C65A10", VA = "0x181C66A10")]
	public static void EOHKJJAHPKJ(this Rigidbody BECMPBBBFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1C67200", Offset = "0x1C66200", VA = "0x181C67200")]
	public static float JKFIAIEANPC(this PhysicMaterial OJLJGNPJMLL, PhysicMaterial KBKEIKNPLEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1C67490", Offset = "0x1C66490", VA = "0x181C67490")]
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

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x577F10", Offset = "0x576F10", VA = "0x180577F10")]
	public CEMMJOMPAEL(Quaternion GAAKKDLBBGK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F4F0", Offset = "0x1C5E4F0", VA = "0x181C5F4F0")]
	public static Quaternion FAJDMKOEFLH(CEMMJOMPAEL CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F490", Offset = "0x1C5E490", VA = "0x181C5F490")]
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

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C770", Offset = "0x1C5B770", VA = "0x181C5C770")]
	public static Vector3 OBKNOLONKAG(this Quaternion IGPENJBJADK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C670", Offset = "0x1C5B670", VA = "0x181C5C670")]
	public static Quaternion LIGCJPMNEHL(this Quaternion CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C140", Offset = "0x1C5B140", VA = "0x181C5C140")]
	public static Quaternion FNBCAEAEPDN(this Quaternion GAAKKDLBBGK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C300", Offset = "0x1C5B300", VA = "0x181C5C300")]
	public static bool JNEMCKAMAMK(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C2B0", Offset = "0x1C5B2B0", VA = "0x181C5C2B0")]
	public static bool JCLKGFMMODE(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C6C0", Offset = "0x1C5B6C0", VA = "0x181C5C6C0")]
	public static Quaternion MHKNGOGEBNG(this Quaternion NPEOEMEENIK, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1C5BFF0", Offset = "0x1C5AFF0", VA = "0x181C5BFF0")]
	public static Quaternion DKEHHDMGLPO(this Quaternion HICENEOPGOF, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C8A0", Offset = "0x1C5B8A0", VA = "0x181C5C8A0")]
	public static Quaternion PHDAPBGIHIN(this Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C090", Offset = "0x1C5B090", VA = "0x181C5C090")]
	public static Quaternion FLNDPIEAFLK(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C5B0", Offset = "0x1C5B5B0", VA = "0x181C5C5B0")]
	public static Quaternion LBKFJAFFDJJ(Vector3 KHJFDILDLAD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C350", Offset = "0x1C5B350", VA = "0x181C5C350")]
	public static Vector3 KBILIJGGLPM(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x1C5BE70", Offset = "0x1C5AE70", VA = "0x181C5BE70")]
	public static Quaternion DHBDEABFFIO(Quaternion JDJIGPDAIEA, Quaternion HEGDAEMJLDE, ref Vector3 FNBDKACNNFH, float MGKFFIBNPNF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EILMCJGGDJA
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1C60F40", Offset = "0x1C5FF40", VA = "0x181C60F40")]
	public static Rect INDNLPJJCNI(this Rect POMLCDIIKDM, Vector2 KPLDEODOJID)
	{
		return default(Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1C60EF0", Offset = "0x1C5FEF0", VA = "0x181C60EF0")]
	public static Vector2 EOPELBEEEID(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1C610B0", Offset = "0x1C600B0", VA = "0x181C610B0")]
	public static Vector2 OCAPBHHPCHJ(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1C61100", Offset = "0x1C60100", VA = "0x181C61100")]
	public static Vector2 OLLAHCIHKFM(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1C61060", Offset = "0x1C60060", VA = "0x181C61060")]
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

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1C651D0", Offset = "0x1C641D0", VA = "0x181C651D0")]
	public static Mesh ANIFOGABCAL(this Renderer CHEJPOIMMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1C65380", Offset = "0x1C64380", VA = "0x181C65380")]
	public static int JHIDBGOLCLD(this Renderer CHEJPOIMMCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1C65610", Offset = "0x1C64610", VA = "0x181C65610")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Color GJAINANBOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1C656F0", Offset = "0x1C646F0", VA = "0x181C656F0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, float ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1C65530", Offset = "0x1C64530", VA = "0x181C65530")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Vector4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1C65430", Offset = "0x1C64430", VA = "0x181C65430")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Matrix4x4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1C657C0", Offset = "0x1C647C0", VA = "0x181C657C0")]
	public static void NHHLALGBEPB(this Renderer CHEJPOIMMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1C64FE0", Offset = "0x1C63FE0", VA = "0x181C64FE0")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1C64E40", Offset = "0x1C63E40", VA = "0x181C64E40")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB, int NKJOCEKPCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class OMCHJHPFBDN
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B440", Offset = "0x1C6A440", VA = "0x181C6B440")]
	public static void KBFLHNONOHF(UnityEngine.Object BEKEOBJFIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B500", Offset = "0x1C6A500", VA = "0x181C6B500")]
	public static void KGFPNIMJHIC(GameObject DOJCFCINALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B380", Offset = "0x1C6A380", VA = "0x181C6B380")]
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
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1C60840", Offset = "0x1C5F840", VA = "0x181C60840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1C607A0", Offset = "0x1C5F7A0", VA = "0x181C607A0")]
	public static float KPCDDILAKBL()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FFENLNFBBPG
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1C61400", Offset = "0x1C60400", VA = "0x181C61400")]
	public static byte[] APEDNIKLMAA(string MEIIMAIGBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1C61540", Offset = "0x1C60540", VA = "0x181C61540")]
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

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1C66610", Offset = "0x1C65610", VA = "0x181C66610")]
	public static string MMDNDBLHCEL(string BILLCLFKNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1C66170", Offset = "0x1C65170", VA = "0x181C66170")]
	public static string EMOFOGPOOLJ(string CKCGCFGOMAA, char JEEKALMPFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1C66200", Offset = "0x1C65200", VA = "0x181C66200")]
	public static string FIJDNLILJFG(this string ONGBFDACHHG, int OMJLGGPHALE, string IEICOECHHLH = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1C66870", Offset = "0x1C65870", VA = "0x181C66870")]
	public static int NPNNFCNGMID(this string ENMDDKHBHPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x1C664F0", Offset = "0x1C654F0", VA = "0x181C664F0")]
	public static bool LJGGMDGLNOO(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1C66570", Offset = "0x1C65570", VA = "0x181C66570")]
	public static bool MCOIBCNPNAP(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1C662B0", Offset = "0x1C652B0", VA = "0x181C662B0")]
	public static bool IDLADJKDBBA(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1C664E0", Offset = "0x1C654E0", VA = "0x181C664E0")]
	public static bool LJGBBKKGKOP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1C66600", Offset = "0x1C65600", VA = "0x181C66600")]
	public static bool MIABHAJOKBP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1C65FC0", Offset = "0x1C64FC0", VA = "0x181C65FC0")]
	public static bool AFNHOCAOHON(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x1C66040", Offset = "0x1C65040", VA = "0x181C66040")]
	public static bool AFNHOCAOHON(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1C66280", Offset = "0x1C65280", VA = "0x181C66280")]
	public static bool FOKJGKHGHMG(this string CKCGCFGOMAA, string ONGBFDACHHG, out int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1C661D0", Offset = "0x1C651D0", VA = "0x181C661D0")]
	public static bool FBFBJCMPOPJ(this string CKCGCFGOMAA, string ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1C66350", Offset = "0x1C65350", VA = "0x181C66350")]
	public static bool IIPIEIOOMCL(string IPHIIJNAEON, string FOJLJNMAJLC, StringComparison GAJDDOLCCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1C66810", Offset = "0x1C65810", VA = "0x181C66810")]
	public static string NLGELJNDBLM(this string ENMDDKHBHPA, string GNJIBIELEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1C660D0", Offset = "0x1C650D0", VA = "0x181C660D0")]
	public static string DNLAKCPLAPD(this string ENMDDKHBHPA, int MNIJHBJDPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1C663B0", Offset = "0x1C653B0", VA = "0x181C663B0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3E5020", Offset = "0x3E4020", VA = "0x1803E5020")]
		public POAHNJIPKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1C6B5C0", Offset = "0x1C6A5C0", VA = "0x181C6B5C0")]
		internal void <ConvertPixelsToGamma>b__0(int i)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1C60CE0", Offset = "0x1C5FCE0", VA = "0x181C60CE0")]
	public static void MHKFJCHNJEE(this Texture2D CAKFKAGPMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x1C608F0", Offset = "0x1C5F8F0", VA = "0x181C608F0")]
	public static void FOFPEEMEIIC(this RenderTexture CNOGINOPPCH, ref Texture2D CAKFKAGPMBF, bool FKLJPOFDILI = false, bool LGJOOBAHIAC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CDCLKFOIBMC
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private static readonly Vector3[] ILMEMODIMEF;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DC20", Offset = "0x1C5CC20", VA = "0x181C5DC20")]
	public static Vector3 CKMNPHLNJMA(this Transform OIFLDNBGJOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DF10", Offset = "0x1C5CF10", VA = "0x181C5DF10")]
	public static Vector3 CPLMAMCMLFN(this Transform OIFLDNBGJOH, Vector3 KNIKPKEBLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1C5EFA0", Offset = "0x1C5DFA0", VA = "0x181C5EFA0")]
	public static Vector3 NFFAAMNNHGN(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DAB0", Offset = "0x1C5CAB0", VA = "0x181C5DAB0")]
	public static Vector2 CJEBHAJDJMI(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E450", Offset = "0x1C5D450", VA = "0x181C5E450")]
	public static float ILCMBGMEPJE(this RectTransform AIOEKMHLKAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E820", Offset = "0x1C5D820", VA = "0x181C5E820")]
	public static Vector3 JBLIBMEOLEB(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F0F0", Offset = "0x1C5E0F0", VA = "0x181C5F0F0")]
	public static Vector3[] PHMOKHIOHDG(this RectTransform AIOEKMHLKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5EE90", Offset = "0x1C5DE90", VA = "0x181C5EE90")]
	public static Quaternion MHKNGOGEBNG(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E170", Offset = "0x1C5D170", VA = "0x181C5E170")]
	public static Quaternion DKEHHDMGLPO(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5EC50", Offset = "0x1C5DC50", VA = "0x181C5EC50")]
	public static Vector3 MHEFIHAJMAD(this Transform OIFLDNBGJOH, Vector3 DDHPAFKBMON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x62A880", Offset = "0x629880", VA = "0x18062A880")]
	public static float LACCAFFAOIG(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D8E0", Offset = "0x1C5C8E0", VA = "0x181C5D8E0")]
	public static float ABDKFENDAKH(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E9A0", Offset = "0x1C5D9A0", VA = "0x181C5E9A0")]
	public static void MCFLPFCGOOL(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E650", Offset = "0x1C5D650", VA = "0x181C5E650")]
	public static void IMCHPFPFLJJ(this Transform OIFLDNBGJOH, float MKDHFENOFDO, Vector3 KLNFHHBHGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1C5D910", Offset = "0x1C5C910", VA = "0x181C5D910")]
	public static void CAIHJLKEPIF(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x1C5DE40", Offset = "0x1C5CE40", VA = "0x181C5DE40")]
	public static float CPEJGKGFNJH(this Transform OIFLDNBGJOH, float PLIPOIMDGPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1C5EBD0", Offset = "0x1C5DBD0", VA = "0x181C5EBD0")]
	public static float MDGALGDEFAK(this Transform OIFLDNBGJOH, float JIBDGOKLJOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E230", Offset = "0x1C5D230", VA = "0x181C5E230")]
	public static void FABLENJPHFB(this RectTransform AIOEKMHLKAL, Vector3[] NPPHHLLMGEM, [Optional] Canvas NKKFJKIMHBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GDCPJCHDFJH
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly Vector2 KPLGKEDLKLM;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1C649F0", Offset = "0x1C639F0", VA = "0x181C649F0")]
	public static Vector2 KMEKBBFBKCA(Vector2 KDBHHDAJLNL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1C64A50", Offset = "0x1C63A50", VA = "0x181C64A50")]
	public static Vector2 KOLMGGDLPDK(this Vector2 PJEDBAONDPP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C649C0", Offset = "0x1C639C0", VA = "0x181C649C0")]
	public static bool CDKDHNKFHFB(this Vector2 PDPPMFNOBMO, float ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1C64B40", Offset = "0x1C63B40", VA = "0x181C64B40")]
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

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1C693E0", Offset = "0x1C683E0", VA = "0x181C693E0")]
	public static Vector3 EMJNMOGIAKL(this IEnumerable<Vector3> COAEBIFOBNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A4A0", Offset = "0x1C694A0", VA = "0x181C6A4A0")]
	public static float NMDFDMBNFNA(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1C6AD70", Offset = "0x1C69D70", VA = "0x181C6AD70")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Vector3 IDMBJGPOCAE, Vector3 MCEDKFKKOCM, Vector3 MJPDDCEFPIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1C6AF50", Offset = "0x1C69F50", VA = "0x181C6AF50")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1C6ABD0", Offset = "0x1C69BD0", VA = "0x181C6ABD0")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH, Vector3 EIHOAEHONBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B070", Offset = "0x1C6A070", VA = "0x181C6B070")]
	public static Vector3 PFLLEKCBAAL(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A560", Offset = "0x1C69560", VA = "0x181C6A560")]
	public static bool OGIEHPPFJCB(this Vector3 BMOIJACGPLN, float LBLHBGPCEMF = 0.001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1C69ED0", Offset = "0x1C68ED0", VA = "0x181C69ED0")]
	public static bool ICGLFNNJKAC(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1C69AA0", Offset = "0x1C68AA0", VA = "0x181C69AA0")]
	public static bool HPKDFLEPPCG(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1C69350", Offset = "0x1C68350", VA = "0x181C69350")]
	public static float DGNGDMGOMAA(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1C68BB0", Offset = "0x1C67BB0", VA = "0x181C68BB0")]
	public static float AHOKOGPDJNP(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1C69290", Offset = "0x1C68290", VA = "0x181C69290")]
	public static Vector3 DDGPCFJMGII(this Vector3 DINHOLEGEMB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A120", Offset = "0x1C69120", VA = "0x181C6A120")]
	public static Vector3 JKGIHPNIJLK(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1C69030", Offset = "0x1C68030", VA = "0x181C69030")]
	public static Vector3 BNKOIHAECHN(this Vector3 PJEDBAONDPP, float NNNGNCNIJAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x1C68F50", Offset = "0x1C67F50", VA = "0x181C68F50")]
	public static bool BECDFHKOIGK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A330", Offset = "0x1C69330", VA = "0x181C6A330")]
	public static bool JNEMCKAMAMK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A080", Offset = "0x1C69080", VA = "0x181C6A080")]
	public static bool JCLKGFMMODE(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1C68FA0", Offset = "0x1C67FA0", VA = "0x181C68FA0")]
	public static Vector3 BMNFGJPMFBG(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A690", Offset = "0x1C69690", VA = "0x181C6A690")]
	public static Vector3 OHHOPADHBAL(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x1C696C0", Offset = "0x1C686C0", VA = "0x181C696C0")]
	public static float FLEMBFIOFJA(this Vector3 BANGBIKOBGO, Vector3 OALKOHJOHFO, [Optional] Vector3? KNIKPKEBLNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A480", Offset = "0x1C69480", VA = "0x181C6A480")]
	public static Vector3 NELNDENOBLC(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x1C69B10", Offset = "0x1C68B10", VA = "0x181C69B10")]
	public static Vector3 IBPJJIDHFFL(Vector3 CHGNDIAMGLF, Quaternion IBCNKFBPCBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A720", Offset = "0x1C69720", VA = "0x181C6A720")]
	public static KCNMMJEKPBC OJDKGBIHNJD(Transform OIFLDNBGJOH, Vector3 MAPAFOGPKLL, out Vector3 GLHHBDHELAO)
	{
		return default(KCNMMJEKPBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1C69880", Offset = "0x1C68880", VA = "0x181C69880")]
	public static Vector3 GKDMJPGOEHO(float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1C69A70", Offset = "0x1C68A70", VA = "0x181C69A70")]
	public static Vector3 HOCFJJAOPDC(float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x1C69260", Offset = "0x1C68260", VA = "0x181C69260")]
	public static Vector3 CLEFGACGMKH(float FOBCKBCBJHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x1C69970", Offset = "0x1C68970", VA = "0x181C69970")]
	public static Vector3 GNOENAFKJIE(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A390", Offset = "0x1C69390", VA = "0x181C6A390")]
	public static Vector3 KICDFOACKEL(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A0E0", Offset = "0x1C690E0", VA = "0x181C6A0E0")]
	public static Vector3 JJOELJJFBAE(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1C691A0", Offset = "0x1C681A0", VA = "0x181C691A0")]
	public static Vector3 CIOKEDCFPJI(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B1A0", Offset = "0x1C6A1A0", VA = "0x181C6B1A0")]
	public static Vector3 PGCOBFHPJEA(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B260", Offset = "0x1C6A260", VA = "0x181C6B260")]
	public static Vector3 PLINJEJIIMO(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x1C68E90", Offset = "0x1C67E90", VA = "0x181C68E90")]
	public static Vector3 BCICENEBNCF(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x1C698B0", Offset = "0x1C688B0", VA = "0x181C698B0")]
	public static Vector3 GMNHMHPHIJK(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A3D0", Offset = "0x1C693D0", VA = "0x181C6A3D0")]
	public static Vector3 KKANLJKPHJI(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1C699B0", Offset = "0x1C689B0", VA = "0x181C699B0")]
	public static Vector3 HCLHKJPLONK(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1C69F40", Offset = "0x1C68F40", VA = "0x181C69F40")]
	public static Vector3 IKBIEPLCAKN(Vector3 HGEIABGCFOA, Vector3 IBHEKLCMMNH, Vector3 KNIKPKEBLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1C68C40", Offset = "0x1C67C40", VA = "0x181C68C40")]
	public static Vector3 AOGDEGACCAP(Vector3 PJEDBAONDPP, Vector3 OOEKLKBHAHK, Vector3 AIOJLAJOCEL, bool PNLBALPIOHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1C6A1E0", Offset = "0x1C691E0", VA = "0x181C6A1E0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1C678B0", Offset = "0x1C668B0", VA = "0x181C678B0")]
	public JFCMGKMLBMN(RenderTexture BGFEHOIGLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1C678A0", Offset = "0x1C668A0", VA = "0x181C678A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FNHMBIFJJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1C646D0", Offset = "0x1C636D0", VA = "0x181C646D0")]
	public static Quaternion CHDHKJJADFE(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x62A8B0", Offset = "0x6298B0", VA = "0x18062A8B0")]
	public static Vector3 DOAOMJFMLLN(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1C64810", Offset = "0x1C63810", VA = "0x181C64810")]
	public static Vector3 OHAKMAOEKCG(this Matrix4x4 BKPMKIIFPKO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class IJHPIMJMEIB
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2D2B870", Offset = "0x2D2A870", VA = "0x182D2B870")]
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
