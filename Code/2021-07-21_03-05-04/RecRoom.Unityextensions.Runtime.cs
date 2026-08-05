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
		[Cpp2IlInjected.Address(RVA = "0x111A730", Offset = "0x1119930", VA = "0x18111A730")]
		public HPIEIOAGEGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1770DB0", Offset = "0x176FFB0", VA = "0x181770DB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x111A730", Offset = "0x1119930", VA = "0x18111A730")]
		public IEKPHHLNIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1770DF0", Offset = "0x176FFF0", VA = "0x181770DF0")]
		internal string <ToFriendlyString>b__1(string s, string s1)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x162BF90", Offset = "0x162B190", VA = "0x18162BF90")]
	public static string JIIMHOLCECD<T>(this IEnumerable<T> NKLIOLCGIDM, [Optional] Func<T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x162BAE0", Offset = "0x162ACE0", VA = "0x18162BAE0")]
	public static string JIIMHOLCECD<T>(this IList<T> DAAFDLFCOGO, [Optional] Func<int, T, string> PMOIBOJHKAB, string IANNLEHMOPH = ", ")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xE8E8E0", Offset = "0xE8DAE0", VA = "0x180E8E8E0")]
	[IteratorStateMachine(typeof(AEABJMALBDK))]
	public static IEnumerable<T> MJJDFHHAOPM<T>(T IOBEPGLJNIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x162AF00", Offset = "0x162A100", VA = "0x18162AF00")]
	public static (T[], U[]) HKJNIHLKENA<T, U>([Cpp2IlInjected.Attribute(Name = "TupleElementNamesAttribute", RVA = "0x9D1B0", Offset = "0x9C5B0")] this IEnumerable<(T, U)> NMELNILPPKN)
	{
		return default((T[], U[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15E6960", Offset = "0x15E5B60", VA = "0x1815E6960")]
	public static IEnumerable<(T, int)> AKGEGLEMFGM<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x162B690", Offset = "0x162A890", VA = "0x18162B690")]
	public static void HOAGBPIIIGP<T>(this IEnumerable<T> NMELNILPPKN, Action<T> EDECJKLDKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x13A8E80", Offset = "0x13A8080", VA = "0x1813A8E80")]
	public static HashSet<T> PBGCPCJGGOO<T>(this IEnumerable<T> NMELNILPPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x15E6B20", Offset = "0x15E5D20", VA = "0x1815E6B20")]
	public static IEnumerable<T> HDLDCPJDNDA<T>(this IEnumerable<T> NKLIOLCGIDM, int KKDPFGADCEK, int MADNOGDODFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x15E6B60", Offset = "0x15E5D60", VA = "0x1815E6B60")]
	public static IEnumerable<T> KPDAENONKPJ<T, TKey>(this IEnumerable<T> NKLIOLCGIDM, Func<T, TKey> HDLMHEHINBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x162B840", Offset = "0x162AA40", VA = "0x18162B840")]
	public static T? ILPGDGMLKDH<T>(this IEnumerable<T> NMELNILPPKN, Func<T, bool> HBPBAJNLGCP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CEEHAKJPFHM
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x373FE20", Offset = "0x373F020", VA = "0x18373FE20")]
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
		[Cpp2IlInjected.Address(RVA = "0x3749260", Offset = "0x3748460", VA = "0x183749260")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static float JHAFCFMBEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x528230", Offset = "0x527430", VA = "0x180528230")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static float DGEAEHEJCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x37491F0", Offset = "0x37483F0", VA = "0x1837491F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3749270", Offset = "0x3748470", VA = "0x183749270")]
	public static float HDHMLEOEOJP(float MOPKOPOKKEE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LHIJJLMMMHM
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3749430", Offset = "0x3748630", VA = "0x183749430")]
	public static bool BKDAHHMFHMC(this DateTime? PBMJJOMBPAH, TimeSpan DOFKHNLEKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3749560", Offset = "0x3748760", VA = "0x183749560")]
	public static string PAKENNFHMEG(this TimeSpan DOFKHNLEKKP, string FEGAGLFEGEP = "minute", bool JKEPCLNFJHH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x37494D0", Offset = "0x37486D0", VA = "0x1837494D0")]
	private static string HIDOGKBNNLG(string IGCKACBLCON, double KEOKDMNJJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IEDIJNKECOL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3748200", Offset = "0x3747400", VA = "0x183748200")]
	public static string MJHFHBGFJHF(this Type GEDCEIDOKJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LFDJHEDEGAJ
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x37492F0", Offset = "0x37484F0", VA = "0x1837492F0")]
	public static void DBCCNEMNLNI(this Animator LDOJFIEANFB, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3749370", Offset = "0x3748570", VA = "0x183749370")]
	public static void DOMIGIEBFCF(this Animator LDOJFIEANFB, int ENJEOLBEALP, bool ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x37493D0", Offset = "0x37485D0", VA = "0x1837493D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1AB8BD0", Offset = "0x1AB7DD0", VA = "0x181AB8BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1ABF860", Offset = "0x1ABEA60", VA = "0x181ABF860")]
		public MKNPILCJOAI(T[] GMOGECKNEEN, IGHKKHEGGBB<T> BKHGMOKDLGO, int DCFEFKGJDOJ, Func<bool> AEMDDGKHONP, T[] CJDMEOAEMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1ABF4A0", Offset = "0x1ABE6A0", VA = "0x181ABF4A0")]
		public bool CDHNACEAFJL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20DC370", Offset = "0x20DB570", VA = "0x1820DC370")]
	public static T[] APNIJAHEGLJ<T>(int OJJOHDIFMEG, T MCACHDBIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x167D380", Offset = "0x167C580", VA = "0x18167D380")]
	public static void KDEILFALGLM<T>(this T[] JABGABGMHPL, T MCACHDBIALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x167CE30", Offset = "0x167C030", VA = "0x18167CE30")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x167CC30", Offset = "0x167BE30", VA = "0x18167CC30")]
	public static void AAJEKBGLFCJ<T>(this T[] OPEBNMBKJJA, int OIDPFPMBCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x167CEC0", Offset = "0x167C0C0", VA = "0x18167CEC0")]
	public static void CDLEKIKHHCD<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO, [Optional] T[] CJDMEOAEMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x167CF60", Offset = "0x167C160", VA = "0x18167CF60")]
	private static void JIHBNKEBJDH<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int DJICGHFJJJP, T[] EPDKOCHMOLC, bool GOJFBEJBPBC, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x167D4F0", Offset = "0x167C6F0", VA = "0x18167D4F0")]
	private static void MNMAEDHAEFJ<T>(this T[] NMELNILPPKN, int ANDOICCNDLA, int GFKCDKBFBBN, T[] HPKICPNGMDJ, int MDIFJBFIGHL, int PPNMMGMDEJI, T[] GIAOBLMEMMI, int CAPPAKEKPLG, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x167D920", Offset = "0x167CB20", VA = "0x18167D920")]
	public static void OIEHNKDGJKK<T>(this T[] NMELNILPPKN, int HKPHMBLKPFI, int MNIJHBJDPPA, IGHKKHEGGBB<T> BKHGMOKDLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x13B4D90", Offset = "0x13B3F90", VA = "0x1813B4D90")]
	public static MKNPILCJOAI<T> JKMCDDAPLHN<T>(this T[] NMELNILPPKN, IGHKKHEGGBB<T> BKHGMOKDLGO, int DCFEFKGJDOJ, Func<bool> AEMDDGKHONP, [Optional] T[] CJDMEOAEMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x20DCCF0", Offset = "0x20DBEF0", VA = "0x1820DCCF0")]
	public static T[] NHGMLEGCCMP<T>(this T[] OPEBNMBKJJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x20DCD10", Offset = "0x20DBF10", VA = "0x1820DCD10")]
	public static T[] PPMHFINCJNE<T>(this T[] IHFOIAODAJC, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x20DC6A0", Offset = "0x20DB8A0", VA = "0x1820DC6A0")]
	public static T[] DECCCEINGDI<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD, T FMDLBNOKCBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x20DCC40", Offset = "0x20DBE40", VA = "0x1820DCC40")]
	public static T[] HNNOENGPBPL<T>(this T[] IHFOIAODAJC, int EFBDCIJMFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x20DC480", Offset = "0x20DB680", VA = "0x1820DC480")]
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
		[Cpp2IlInjected.Address(RVA = "0x3746B90", Offset = "0x3745D90", VA = "0x183746B90")]
		public HKLGKBLGDMN(GameObject DOJCFCINALC, bool AHOAECJDPGH, NCHPJLFOHGM MPBIKBNEFGP, bool CLAOPEDMPGL, Type GEDCEIDOKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x37464E0", Offset = "0x37456E0", VA = "0x1837464E0", Slot = "4")]
		public bool Equals(HKLGKBLGDMN HPKICPNGMDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3746440", Offset = "0x3745640", VA = "0x183746440", Slot = "0")]
		public override bool Equals(object NLNHFEEMFBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37465F0", Offset = "0x37457F0", VA = "0x1837465F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x37466B0", Offset = "0x37458B0", VA = "0x1837466B0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3742770", Offset = "0x3741970", VA = "0x183742770")]
	public static void LKLKGDMFMCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x12D1330", Offset = "0x12D0530", VA = "0x1812D1330")]
	public static T FABKIOBNCHE<T>(this GameObject DOJCFCINALC, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x12D1600", Offset = "0x12D0800", VA = "0x1812D1600")]
	public static T JLOAAIEKGLO<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x12D1720", Offset = "0x12D0920", VA = "0x1812D1720")]
	public static T MHBNENBBNDJ<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1099C80", Offset = "0x1098E80", VA = "0x181099C80")]
	public static IReadOnlyList<T> HLCNADOGJFC<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x109A180", Offset = "0x1099380", VA = "0x18109A180")]
	public static IReadOnlyList<T> PHJEODMHDOK<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL = true, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x12D1440", Offset = "0x12D0640", VA = "0x1812D1440")]
	private static T JGCKGHNCPPC<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1099ED0", Offset = "0x10990D0", VA = "0x181099ED0")]
	private static IReadOnlyList<T> OFLKKOAGMFK<T>(HKLGKBLGDMN MOFPGLPJKKJ, bool CDFHDACBFKN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x37426D0", Offset = "0x37418D0", VA = "0x1837426D0")]
	private static void KIPECKHDOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x37422C0", Offset = "0x37414C0", VA = "0x1837422C0")]
	private static void JOMBFKGNCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x109A080", Offset = "0x1099280", VA = "0x18109A080")]
	private static IReadOnlyList<T> OIJCNPEICPD<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1099DA0", Offset = "0x1098FA0", VA = "0x181099DA0")]
	private static IReadOnlyList<T> MAALAKFHBNE<T>(HKLGKBLGDMN MOFPGLPJKKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BOHNIEMGLMC
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x373DC10", Offset = "0x373CE10", VA = "0x18373DC10")]
	public static float ELCHENEAFFD(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x373E280", Offset = "0x373D480", VA = "0x18373E280")]
	public static float OOIKMLIOLHN(this Camera FOMHGMLPOND, float FAONCIOCBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x373E0B0", Offset = "0x373D2B0", VA = "0x18373E0B0")]
	public static float KCHIFOHABON(this Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x373DA10", Offset = "0x373CC10", VA = "0x18373DA10")]
	private static float DBBKCKNDNOJ(float PPLEDBHELNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x373DA80", Offset = "0x373CC80", VA = "0x18373DA80")]
	private static float DBBKCKNDNOJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x373DEB0", Offset = "0x373D0B0", VA = "0x18373DEB0")]
	private static float FMJNGGHKBNJ(float PPLEDBHELNG, float EHDMLFDEBAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x373DE70", Offset = "0x373D070", VA = "0x18373DE70")]
	private static float FMJNGGHKBNJ(Camera FOMHGMLPOND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x373DD60", Offset = "0x373CF60", VA = "0x18373DD60")]
	public static float FGCPIGKOIHD(float PPLEDBHELNG, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x373DC40", Offset = "0x373CE40", VA = "0x18373DC40")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, float FLDFJHHIHNE, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x373DC80", Offset = "0x373CE80", VA = "0x18373DC80")]
	public static float FGCPIGKOIHD(this Camera ELEFOIEHBFF, Vector2 IJHJIKGDNJH, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x373D960", Offset = "0x373CB60", VA = "0x18373D960")]
	private static float CIMKJKMKPGG(float DABFKGJPFDC, float IJHJIKGDNJH, float PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x373DF30", Offset = "0x373D130", VA = "0x18373DF30")]
	public static float JKGBBKLIAMK(float GGJOIJAKDDC, float EHDMLFDEBAF, Vector2 IJHJIKGDNJH, float HGFAGBNEADJ, Vector2 PCNFOIEFFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x373E1C0", Offset = "0x373D3C0", VA = "0x18373E1C0")]
	private static float NEANFKGDFBM(float DABFKGJPFDC, float IJHJIKGDNJH, float HGFAGBNEADJ, float PCNFOIEFFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x373DB00", Offset = "0x373CD00", VA = "0x18373DB00")]
	public static void DBJKGNBKPDI(this Camera FOMHGMLPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x373E160", Offset = "0x373D360", VA = "0x18373E160")]
	public static bool LPBHGEJLJKD(this Camera FOMHGMLPOND, Renderer CHEJPOIMMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x373DB90", Offset = "0x373CD90", VA = "0x18373DB90")]
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
	[Cpp2IlInjected.Address(RVA = "0x3740B90", Offset = "0x373FD90", VA = "0x183740B90")]
	public static bool HAKOLMGKNPH(this Collider GLPOLGOBLAA, Vector3 KMIFDIBBCDI, Vector3 EDKKBNDGKAO, float OMLBPICLALA, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, out RaycastHit IIILNCEEBPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3740160", Offset = "0x373F360", VA = "0x183740160")]
	public static int AMAOMIJGJBF(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, Collider[] GIJOIBPGGOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x37408F0", Offset = "0x373FAF0", VA = "0x1837408F0")]
	public static bool FKFGLHIBHJC(this BoxCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x37410E0", Offset = "0x37402E0", VA = "0x1837410E0")]
	public static int NBOGLHFIMJA(this BoxCollider GLPOLGOBLAA, Collider[] PANOGCJFAOD, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3740EF0", Offset = "0x37400F0", VA = "0x183740EF0")]
	public static bool KCFPIEEMJON(this BoxCollider CEGIONPIIAO, Vector3 NAIDPMBKHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3740530", Offset = "0x373F730", VA = "0x183740530")]
	public static bool FKFGLHIBHJC(this CapsuleCollider GLPOLGOBLAA, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3740E60", Offset = "0x3740060", VA = "0x183740E60")]
	public static Vector3 HHNMMNMLAMF(this BoxCollider GLPOLGOBLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3740420", Offset = "0x373F620", VA = "0x183740420")]
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
	[Cpp2IlInjected.Address(RVA = "0x3749100", Offset = "0x3748300", VA = "0x183749100")]
	public static Color FKDFDGMNNLG(this Color GJAINANBOCB, float FBPFONBFPEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3749010", Offset = "0x3748210", VA = "0x183749010")]
	public static Vector3 AHOMKMDCPOH(this Vector3 DKIELBAENOL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3748F10", Offset = "0x3748110", VA = "0x183748F10")]
	public static Color AHOMKMDCPOH(this Color DKIELBAENOL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3749140", Offset = "0x3748340", VA = "0x183749140")]
	public static Color LGPCCFOGKGG(this Color GJAINANBOCB, float IOAMFOPBCMN)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BEBOIKCDHFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x373D390", Offset = "0x373C590", VA = "0x18373D390")]
	public static void OFKIHGPJHJI(this Component CKCMODJNCNF, bool CBHMNNAINHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097840", VA = "0x181098640")]
	public static List<T> PFOKAFNFHHM<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x12CC4C0", Offset = "0x12CB6C0", VA = "0x1812CC4C0")]
	public static T LNJIMABEJLG<T>(this Component CKCMODJNCNF, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EJFNMBLOPLC
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x15E73A0", Offset = "0x15E65A0", VA = "0x1815E73A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F0500", Offset = "0x3EF700", VA = "0x1803F0500", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F0500", Offset = "0x3EF700", VA = "0x1803F0500", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3F0570", Offset = "0x3EF770", VA = "0x1803F0570")]
		[DebuggerHidden]
		public AFMAGHBPHLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F0560", Offset = "0x3EF760", VA = "0x1803F0560", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x373C760", Offset = "0x373B960", VA = "0x18373C760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x373C810", Offset = "0x373BA10", VA = "0x18373C810", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F0500", Offset = "0x3EF700", VA = "0x1803F0500", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F0500", Offset = "0x3EF700", VA = "0x1803F0500", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3F0570", Offset = "0x3EF770", VA = "0x1803F0570")]
		[DebuggerHidden]
		public EGJGCHCIGPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3F0560", Offset = "0x3EF760", VA = "0x1803F0560", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3741A40", Offset = "0x3740C40", VA = "0x183741A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3741AF0", Offset = "0x3740CF0", VA = "0x183741AF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static WaitForEndOfFrame NAKHMEPNJEL;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x37484D0", Offset = "0x37476D0", VA = "0x1837484D0")]
	[IteratorStateMachine(typeof(AFMAGHBPHLI))]
	public static IEnumerator BCAKHIGACHG(float CAHAMMIHDFG, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3748540", Offset = "0x3747740", VA = "0x183748540")]
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
		[Cpp2IlInjected.Address(RVA = "0x37483F0", Offset = "0x37475F0", VA = "0x1837483F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x37483C0", Offset = "0x37475C0", VA = "0x1837483C0")]
	public IGHCGCAGAFH(float HABFNPMBADP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CDHKGKPIOLK
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x20C21F0", Offset = "0x20C13F0", VA = "0x1820C21F0")]
	public static TValue KGAPEMHMJHI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG) where TValue : new()
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x20C2490", Offset = "0x20C1690", VA = "0x1820C2490")]
	public static TValue PLOELFMPHEI<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x20C1E20", Offset = "0x20C1020", VA = "0x1820C1E20")]
	public static TValue GLPALAONCFG<TValue, TKey>(this IDictionary<TKey, TValue> PMMGDNALAEB, TKey DNGKIAJLLHG, [Optional] TValue EMEBALPLJDF)
	{
		return (TValue)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FKFGKDOBBOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3745240", Offset = "0x3744440", VA = "0x183745240")]
	public static string CPIKLJJCBAB(this Guid COFLAJFOPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3745160", Offset = "0x3744360", VA = "0x183745160")]
	public static string CPIKLJJCBAB(this byte[] MGPDDEMABPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LBEHNMANHHL
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3748690", Offset = "0x3747890", VA = "0x183748690")]
	public static string GKBCGFOAIJM(this FileInfo NOHHLFHPPDF, string IFKMFOPALAO, string EAEOAIMAJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3748840", Offset = "0x3747A40", VA = "0x183748840")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F0500", Offset = "0x3EF700", VA = "0x1803F0500", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F0500", Offset = "0x3EF700", VA = "0x1803F0500", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x647B20", Offset = "0x646D20", VA = "0x180647B20")]
		[DebuggerHidden]
		public BJBOHHCEKDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F0560", Offset = "0x3EF760", VA = "0x1803F0560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x373D780", Offset = "0x373C980", VA = "0x18373D780", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x373D910", Offset = "0x373CB10", VA = "0x18373D910", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x373D870", Offset = "0x373CA70", VA = "0x18373D870", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x373D870", Offset = "0x373CA70", VA = "0x18373D870", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Dictionary<int, int> IKJIECFLKJL;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x12D6170", Offset = "0x12D5370", VA = "0x1812D6170")]
	public static T LNJIMABEJLG<T>(this GameObject DOJCFCINALC, bool JOMPNFHMIFG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x12D60C0", Offset = "0x12D52C0", VA = "0x1812D60C0")]
	public static T GLENGLDKGCK<T>(this GameObject DOJCFCINALC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x12D6090", Offset = "0x12D5290", VA = "0x1812D6090")]
	public static T GLENGLDKGCK<T>(this Component CKCMODJNCNF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x167A020", Offset = "0x1679220", VA = "0x18167A020")]
	public static void IFFLOPMPLPN<T>(this GameObject DOJCFCINALC, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1679F70", Offset = "0x1679170", VA = "0x181679F70")]
	public static void IFFLOPMPLPN<T>(this Component CKCMODJNCNF, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x167A0D0", Offset = "0x16792D0", VA = "0x18167A0D0")]
	public static void OPKLCCBLMCM<T>(this GameObject DOJCFCINALC, bool CLAOPEDMPGL, List<T> LLCIDEKMKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3748CD0", Offset = "0x3747ED0", VA = "0x183748CD0")]
	public static void OLLDCMIMDLM(this GameObject DOJCFCINALC, string GHBNIGCAPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x37489D0", Offset = "0x3747BD0", VA = "0x1837489D0")]
	public static string AOEFKLMCCGH(this GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3748B00", Offset = "0x3747D00", VA = "0x183748B00")]
	[IteratorStateMachine(typeof(BJBOHHCEKDF))]
	private static IEnumerable<string> CLDAIOKJMCC(GameObject NNNMGKGMIFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3748B70", Offset = "0x3747D70", VA = "0x183748B70")]
	public static int MOOKPIOIGOD(this GameObject NLNHFEEMFBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class LOJLAODGLLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x19FECE0", Offset = "0x19FDEE0", VA = "0x1819FECE0")]
	public static V ODHHPEIEBCB<V, T>(this T LIMOILDIGKF, Func<T, V> PAFOMEECIMH, [Optional] V OANDOPIEEPO) where T : class
	{
		return (V)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x167A190", Offset = "0x1679390", VA = "0x18167A190")]
	public static void CLELOGIOOCO<T>(this T LIMOILDIGKF, Action<T> PAFOMEECIMH) where T : class
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class ECNNGIFNNNM
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x15E41F0", Offset = "0x15E33F0", VA = "0x1815E41F0")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> OPEBNMBKJJA, T ONGBFDACHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x166BC00", Offset = "0x166AE00", VA = "0x18166BC00")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x166BC90", Offset = "0x166AE90", VA = "0x18166BC90")]
	public static void AAJEKBGLFCJ<T>(this IList<T> DAAFDLFCOGO, int KIJHGBLLCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1098EF0", Offset = "0x10980F0", VA = "0x181098EF0")]
	public static List<T> FHAOCJFENEF<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x15E4120", Offset = "0x15E3320", VA = "0x1815E4120")]
	public static int IDHAEOMJOML<T>(this IReadOnlyList<T> DAAFDLFCOGO, Predicate<T> HBPBAJNLGCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x15E30B0", Offset = "0x15E22B0", VA = "0x1815E30B0")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1A38900", Offset = "0x1A37B00", VA = "0x181A38900")]
	public static bool KCFPIEEMJON<T>(this IReadOnlyList<T> DAAFDLFCOGO, T IOBEPGLJNIP, EqualityComparer<T> KFBHPCHEJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x15E3510", Offset = "0x15E2710", VA = "0x1815E3510")]
	public static int IBKMBGJGECB<TElement, TKey>(this IList<TElement> LLOIOFKDLFP, TKey IFHDIPBMJOI, Func<TElement, TKey> IHHAGJMACDJ, [Optional] Func<TKey, TKey, int> BKHGMOKDLGO, int EFBDCIJMFGD = 0, [Optional] int? MNIJHBJDPPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x12D04A0", Offset = "0x12CF6A0", VA = "0x1812D04A0")]
	public static T NBMJEPIPHGC<T>(this IReadOnlyList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1A38E30", Offset = "0x1A38030", VA = "0x181A38E30")]
	public static bool KFDLNLFOGBN<T>(this List<T> DAAFDLFCOGO, T IOBEPGLJNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x166C490", Offset = "0x166B690", VA = "0x18166C490")]
	public static void AINCGKKANMC<T>(this List<T> DAAFDLFCOGO, IEnumerable<T> CGBHMNCBAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x12D03E0", Offset = "0x12CF5E0", VA = "0x1812D03E0")]
	public static T NBMJEPIPHGC<T>(this T[] DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x12D5ED0", Offset = "0x12D50D0", VA = "0x1812D5ED0")]
	public static void OHDOOOKOMNB<T>(this List<T> CGBHMNCBAGA) where T : UnityEngine.Object
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x12D0220", Offset = "0x12CF420", VA = "0x1812D0220")]
	public static T LLFCJKLELNH<T>(this List<T> CGBHMNCBAGA, Predicate<T> PBPLOKIJLLN) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x12CFC90", Offset = "0x12CEE90", VA = "0x1812CFC90")]
	public static T BMCEKIFDDJK<T>(this List<T> CGBHMNCBAGA, int EFBDCIJMFGD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1A374F0", Offset = "0x1A366F0", VA = "0x181A374F0")]
	public static bool IDCGECLDIDG<T>(this List<T> LNFKAGBJHOA, List<T> ADFLPMKFAGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x12D00A0", Offset = "0x12CF2A0", VA = "0x1812D00A0")]
	public static T GPEBLICLPML<T>(this IList<T> DAAFDLFCOGO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1A38EA0", Offset = "0x1A380A0", VA = "0x181A38EA0")]
	public static bool MGIGDPBNABL<T>(IReadOnlyList<T> DAAFDLFCOGO, int EFBDCIJMFGD, out T GIAOBLMEMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1A38610", Offset = "0x1A37810", VA = "0x181A38610")]
	public static bool JEACGAIICGO<T>(IReadOnlyList<T> DAAFDLFCOGO, ICollection CGBHMNCBAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x166C380", Offset = "0x166B580", VA = "0x18166C380")]
	public static void AEONHOJKJNI<T>(IReadOnlyList<T> DAAFDLFCOGO, ref ICollection CGBHMNCBAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x16A49C0", Offset = "0x16A3BC0", VA = "0x1816A49C0")]
	public static bool LJGBBKKGKOP<T>(this IReadOnlyList<T> DAAFDLFCOGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GEKPCDJEJAK
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E71590", Offset = "0x1E70790", VA = "0x181E71590")]
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
	[Cpp2IlInjected.Address(RVA = "0x3744350", Offset = "0x3743550", VA = "0x183744350")]
	public static bool MOHPPAOIEMG(int ONGBFDACHHG, int GOICNKGDJEC, int KEBJAIELILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3744E00", Offset = "0x3744000", VA = "0x183744E00")]
	public static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37431E0", Offset = "0x37423E0", VA = "0x1837431E0")]
	public static float GDKJPBLEGLK(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3744370", Offset = "0x3743570", VA = "0x183744370")]
	public static void NADMLFBBFJB(Vector3 JLCIKNNKEAD, out float LMMPJCFJDOL, out float NOFFCKDIOEP, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3744700", Offset = "0x3743900", VA = "0x183744700")]
	public static void NPCJFNAJALO(Vector3 JLCIKNNKEAD, out float LBJOIGNPPFB, out float CEOHNIOICHD, out float OMLBPICLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3744FC0", Offset = "0x37441C0", VA = "0x183744FC0")]
	public static Vector3 PDLGILNJNGC(float LMMPJCFJDOL, float NOFFCKDIOEP, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3743070", Offset = "0x3742270", VA = "0x183743070")]
	public static Vector3 FNKFOCAIBGE(float LBJOIGNPPFB, float CEOHNIOICHD, float OMLBPICLALA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3743640", Offset = "0x3742840", VA = "0x183743640")]
	public static Vector3 HMGHBDPPJAG(Vector3 BBMDCKFFPCE, Vector3 JIOIOMDOAJA, Vector3 KHCCKHOEOKP, Vector3 IJGHHKBAIDB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3742CA0", Offset = "0x3741EA0", VA = "0x183742CA0")]
	public static bool CFKHNLPBCCE(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3743E50", Offset = "0x3743050", VA = "0x183743E50")]
	public static float MBLIIPEMOGB(Ray FAACBOBPIKK, Ray HEGDAEMJLDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3744940", Offset = "0x3743B40", VA = "0x183744940")]
	private static float PALAEPOMPDP(this IList<float> PJGCPEAIPOH, int PDBMBOMEGAC, float BANKGLOHKOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x37428A0", Offset = "0x3741AA0", VA = "0x1837428A0")]
	public static bool BAHBPFFNNJO(float IPHIIJNAEON, float FOJLJNMAJLC, float CIIMMENGOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3742D70", Offset = "0x3741F70", VA = "0x183742D70")]
	public static Vector3 DBDLNMAONIL(Vector3 KPLDEODOJID, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3742ED0", Offset = "0x37420D0", VA = "0x183742ED0")]
	public static Vector3 EAEOKLNFADK(Vector3 DJBBMJBBNHB, Vector3 CKPHGEEPNDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x37432D0", Offset = "0x37424D0", VA = "0x1837432D0")]
	public static void GEFDMDGMEBM(Transform OIFLDNBGJOH, Vector3 CKPHGEEPNDN, Vector3 FGHCICOBPHH, Vector3 AADLCEBLCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3743810", Offset = "0x3742A10", VA = "0x183743810")]
	public static Vector3 JPGHEAINBKJ(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float PIHLBMOKPFJ, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3744450", Offset = "0x3743650", VA = "0x183744450")]
	public static Vector3 NDEFIIAMEPM(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF, out float NOCJGAKBBNA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3742930", Offset = "0x3741B30", VA = "0x183742930")]
	private static float BNGIECEAJKA(Vector3 CACFKFOOHID, Vector3 HEGDAEMJLDE, float EJHELOHKGCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x37446E0", Offset = "0x37438E0", VA = "0x1837446E0")]
	public static float NKBLAPMGFEN(float FLIEBIMFHEN, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3744FA0", Offset = "0x37441A0", VA = "0x183744FA0")]
	public static float PCHIOIGDICJ(float JDFENOCNKAD, float BGDCLAFLLPC, float LIMOILDIGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3744820", Offset = "0x3743A20", VA = "0x183744820")]
	public static float OMBOKJDOGMI(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3742BE0", Offset = "0x3741DE0", VA = "0x183742BE0")]
	public static void BOIDIABHGLA(float IPHIIJNAEON, float FOJLJNMAJLC, float MBEHODBGOJI, out float AHCGFILIFFM, out float MEMDHFDMDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x37437D0", Offset = "0x37429D0", VA = "0x1837437D0")]
	public static float JBLAJMCFLIK(this float ONGBFDACHHG, Vector2 LMBJKPOFNJA, Vector2 LNMOFOCDKEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3743E20", Offset = "0x3743020", VA = "0x183743E20")]
	public static float LAFFGDDLOFP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x216EBB0", Offset = "0x216DDB0", VA = "0x18216EBB0")]
	public static float DGKGLMIIKNG(this float NIONDACONFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x37442C0", Offset = "0x37434C0", VA = "0x1837442C0")]
	public static float MJKHBBDDDBL(int DBCLLCJFNJM = 30)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3743C60", Offset = "0x3742E60", VA = "0x183743C60")]
	public static Vector3 KEFKCKMCCEG(Vector3 GEOFMLLGABC, Vector3 ILOMMBLNKMA, float GAIPDLMAPJP)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FCDBKMOEJMJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3714D30", Offset = "0x3713F30", VA = "0x183714D30")]
	public static bool DFIECMNBGCO(this MonoBehaviour BKGIHIBDAPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3741FC0", Offset = "0x37411C0", VA = "0x183741FC0")]
	public static void OMNDHPIFFEM(this MonoBehaviour BKGIHIBDAPA, Coroutine NEPMGGPMFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3741F30", Offset = "0x3741130", VA = "0x183741F30")]
	public static void GLFCOPMIKLH(this MonoBehaviour BKGIHIBDAPA, IDisposable KECNNGMBHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3741DA0", Offset = "0x3740FA0", VA = "0x183741DA0")]
	public static Coroutine BCAKHIGACHG(this MonoBehaviour BKGIHIBDAPA, float BJJEDIGOMGC, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3741E70", Offset = "0x3741070", VA = "0x183741E70")]
	public static Coroutine CHAAKFJCLIH(this MonoBehaviour BKGIHIBDAPA, Action JJGHIEJCCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3741F80", Offset = "0x3741180", VA = "0x183741F80")]
	public static bool ILCBJMDIMJC(this MonoBehaviour BKGIHIBDAPA, int DGDDMBOMHPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KKAHDGDOALA
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3748600", Offset = "0x3747800", VA = "0x183748600")]
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
		[Cpp2IlInjected.Address(RVA = "0x111A730", Offset = "0x1119930", VA = "0x18111A730")]
		public NEKCJLGOGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x20A8AD0", Offset = "0x20A7CD0", VA = "0x1820A8AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x111A730", Offset = "0x1119930", VA = "0x18111A730")]
		public JMJHJMKLADO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x20A7F30", Offset = "0x20A7130", VA = "0x1820A7F30")]
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
	[Cpp2IlInjected.Address(RVA = "0x12D3F90", Offset = "0x12D3190", VA = "0x1812D3F90")]
	public static T LGLGLKGNLMN<T>(Vector3 CACFKFOOHID, Vector3 DJBBMJBBNHB, float DJGCMOJICGK, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, T> JFJJCCHICDD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3747B80", Offset = "0x3746D80", VA = "0x183747B80")]
	public static bool ILIFFJBJEIB(Ray OPMKFDNLHKI, float DJGCMOJICGK, out RaycastHit PAOKLBNMNFL, Func<RaycastHit, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x12D3BC0", Offset = "0x12D2DC0", VA = "0x1812D3BC0")]
	public static T GDIGJECFAIH<T>(Vector3 CACFKFOOHID, float OMLBPICLALA, Vector3 DJBBMJBBNHB, int NNHBELIOIIM, float DJGCMOJICGK, out Vector3 GMENKJKOGMD, out Collider GKPCABGDNLO, Func<Collider, float, T> JFJJCCHICDD, QueryTriggerInteraction CGAPEINEFPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3747560", Offset = "0x3746760", VA = "0x183747560")]
	public static Vector3 ABDJDBINPNA(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x37476B0", Offset = "0x37468B0", VA = "0x1837476B0")]
	private static float HLJCBFHFBNC(Vector3 CACFKFOOHID, RaycastHit PAOKLBNMNFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3747820", Offset = "0x3746A20", VA = "0x183747820")]
	public static bool HPMMIPJACPC(Ray OPMKFDNLHKI, float OMLBPICLALA, float DJGCMOJICGK, out RaycastHit HIFHEHIMEEM, Func<RaycastHit, float, bool> HBPBAJNLGCP, int NNHBELIOIIM, QueryTriggerInteraction CGAPEINEFPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3747600", Offset = "0x3746800", VA = "0x183747600")]
	public static void EOHKJJAHPKJ(this Rigidbody BECMPBBBFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3747DF0", Offset = "0x3746FF0", VA = "0x183747DF0")]
	public static float JKFIAIEANPC(this PhysicMaterial OJLJGNPJMLL, PhysicMaterial KBKEIKNPLEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3748080", Offset = "0x3747280", VA = "0x183748080")]
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
	[Cpp2IlInjected.Address(RVA = "0x15B11A0", Offset = "0x15B03A0", VA = "0x1815B11A0")]
	public CEMMJOMPAEL(Quaternion GAAKKDLBBGK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3740140", Offset = "0x373F340", VA = "0x183740140")]
	public static Quaternion FAJDMKOEFLH(CEMMJOMPAEL CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x37400E0", Offset = "0x373F2E0", VA = "0x1837400E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x373D160", Offset = "0x373C360", VA = "0x18373D160")]
	public static Vector3 OBKNOLONKAG(this Quaternion IGPENJBJADK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x373D060", Offset = "0x373C260", VA = "0x18373D060")]
	public static Quaternion LIGCJPMNEHL(this Quaternion CHBGHGPPLCN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x373CB30", Offset = "0x373BD30", VA = "0x18373CB30")]
	public static Quaternion FNBCAEAEPDN(this Quaternion GAAKKDLBBGK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x373CCF0", Offset = "0x373BEF0", VA = "0x18373CCF0")]
	public static bool JNEMCKAMAMK(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x373CCA0", Offset = "0x373BEA0", VA = "0x18373CCA0")]
	public static bool JCLKGFMMODE(this Quaternion GAAKKDLBBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x373D0B0", Offset = "0x373C2B0", VA = "0x18373D0B0")]
	public static Quaternion MHKNGOGEBNG(this Quaternion NPEOEMEENIK, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x373C9E0", Offset = "0x373BBE0", VA = "0x18373C9E0")]
	public static Quaternion DKEHHDMGLPO(this Quaternion HICENEOPGOF, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x373D290", Offset = "0x373C490", VA = "0x18373D290")]
	public static Quaternion PHDAPBGIHIN(this Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x373CA80", Offset = "0x373BC80", VA = "0x18373CA80")]
	public static Quaternion FLNDPIEAFLK(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x373CFA0", Offset = "0x373C1A0", VA = "0x18373CFA0")]
	public static Quaternion LBKFJAFFDJJ(Vector3 KHJFDILDLAD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x373CD40", Offset = "0x373BF40", VA = "0x18373CD40")]
	public static Vector3 KBILIJGGLPM(Quaternion BANGBIKOBGO, Quaternion OALKOHJOHFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x373C860", Offset = "0x373BA60", VA = "0x18373C860")]
	public static Quaternion DHBDEABFFIO(Quaternion JDJIGPDAIEA, Quaternion HEGDAEMJLDE, ref Vector3 FNBDKACNNFH, float MGKFFIBNPNF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EILMCJGGDJA
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3741B90", Offset = "0x3740D90", VA = "0x183741B90")]
	public static Rect INDNLPJJCNI(this Rect POMLCDIIKDM, Vector2 KPLDEODOJID)
	{
		return default(Rect);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3741B40", Offset = "0x3740D40", VA = "0x183741B40")]
	public static Vector2 EOPELBEEEID(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3741D00", Offset = "0x3740F00", VA = "0x183741D00")]
	public static Vector2 OCAPBHHPCHJ(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3741D50", Offset = "0x3740F50", VA = "0x183741D50")]
	public static Vector2 OLLAHCIHKFM(this Rect POMLCDIIKDM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3741CB0", Offset = "0x3740EB0", VA = "0x183741CB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3745DC0", Offset = "0x3744FC0", VA = "0x183745DC0")]
	public static Mesh ANIFOGABCAL(this Renderer CHEJPOIMMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3745F70", Offset = "0x3745170", VA = "0x183745F70")]
	public static int JHIDBGOLCLD(this Renderer CHEJPOIMMCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3746200", Offset = "0x3745400", VA = "0x183746200")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Color GJAINANBOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x37462E0", Offset = "0x37454E0", VA = "0x1837462E0")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, float ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3746120", Offset = "0x3745320", VA = "0x183746120")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Vector4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3746020", Offset = "0x3745220", VA = "0x183746020")]
	public static void NCCAFFCNPJI(this Renderer CHEJPOIMMCK, int NMGPBLNBANO, Matrix4x4 ONGBFDACHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x37463B0", Offset = "0x37455B0", VA = "0x1837463B0")]
	public static void NHHLALGBEPB(this Renderer CHEJPOIMMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3745BD0", Offset = "0x3744DD0", VA = "0x183745BD0")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3745A30", Offset = "0x3744C30", VA = "0x183745A30")]
	public static void AMANKFJDKBD(this Renderer CHEJPOIMMCK, float FBPFONBFPEB, int NKJOCEKPCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class OMCHJHPFBDN
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x374C0B0", Offset = "0x374B2B0", VA = "0x18374C0B0")]
	public static void KBFLHNONOHF(UnityEngine.Object BEKEOBJFIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x374C170", Offset = "0x374B370", VA = "0x18374C170")]
	public static void KGFPNIMJHIC(GameObject DOJCFCINALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x374BFF0", Offset = "0x374B1F0", VA = "0x18374BFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3741490", Offset = "0x3740690", VA = "0x183741490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x37413F0", Offset = "0x37405F0", VA = "0x1837413F0")]
	public static float KPCDDILAKBL()
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class FFENLNFBBPG
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3742050", Offset = "0x3741250", VA = "0x183742050")]
	public static byte[] APEDNIKLMAA(string MEIIMAIGBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3742190", Offset = "0x3741390", VA = "0x183742190")]
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
	[Cpp2IlInjected.Address(RVA = "0x3747200", Offset = "0x3746400", VA = "0x183747200")]
	public static string MMDNDBLHCEL(string BILLCLFKNLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3746D60", Offset = "0x3745F60", VA = "0x183746D60")]
	public static string EMOFOGPOOLJ(string CKCGCFGOMAA, char JEEKALMPFNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3746DF0", Offset = "0x3745FF0", VA = "0x183746DF0")]
	public static string FIJDNLILJFG(this string ONGBFDACHHG, int OMJLGGPHALE, string IEICOECHHLH = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3747460", Offset = "0x3746660", VA = "0x183747460")]
	public static int NPNNFCNGMID(this string ENMDDKHBHPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x37470E0", Offset = "0x37462E0", VA = "0x1837470E0")]
	public static bool LJGGMDGLNOO(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3747160", Offset = "0x3746360", VA = "0x183747160")]
	public static bool MCOIBCNPNAP(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3746EA0", Offset = "0x37460A0", VA = "0x183746EA0")]
	public static bool IDLADJKDBBA(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x37470D0", Offset = "0x37462D0", VA = "0x1837470D0")]
	public static bool LJGBBKKGKOP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x37471F0", Offset = "0x37463F0", VA = "0x1837471F0")]
	public static bool MIABHAJOKBP(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3746BB0", Offset = "0x3745DB0", VA = "0x183746BB0")]
	public static bool AFNHOCAOHON(this string ENMDDKHBHPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3746C30", Offset = "0x3745E30", VA = "0x183746C30")]
	public static bool AFNHOCAOHON(this char MBEHODBGOJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3746E70", Offset = "0x3746070", VA = "0x183746E70")]
	public static bool FOKJGKHGHMG(this string CKCGCFGOMAA, string ONGBFDACHHG, out int EFBDCIJMFGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3746DC0", Offset = "0x3745FC0", VA = "0x183746DC0")]
	public static bool FBFBJCMPOPJ(this string CKCGCFGOMAA, string ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3746F40", Offset = "0x3746140", VA = "0x183746F40")]
	public static bool IIPIEIOOMCL(string IPHIIJNAEON, string FOJLJNMAJLC, StringComparison GAJDDOLCCIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3747400", Offset = "0x3746600", VA = "0x183747400")]
	public static string NLGELJNDBLM(this string ENMDDKHBHPA, string GNJIBIELEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3746CC0", Offset = "0x3745EC0", VA = "0x183746CC0")]
	public static string DNLAKCPLAPD(this string ENMDDKHBHPA, int MNIJHBJDPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3746FA0", Offset = "0x37461A0", VA = "0x183746FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F02B0", Offset = "0x3EF4B0", VA = "0x1803F02B0")]
		public POAHNJIPKDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x374C230", Offset = "0x374B430", VA = "0x18374C230")]
		internal void <ConvertPixelsToGamma>b__0(int i)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3741930", Offset = "0x3740B30", VA = "0x183741930")]
	public static void MHKFJCHNJEE(this Texture2D CAKFKAGPMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3741540", Offset = "0x3740740", VA = "0x183741540")]
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
	[Cpp2IlInjected.Address(RVA = "0x373E610", Offset = "0x373D810", VA = "0x18373E610")]
	public static Vector3 CKMNPHLNJMA(this Transform OIFLDNBGJOH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x373EB20", Offset = "0x373DD20", VA = "0x18373EB20")]
	public static Vector3 CPLMAMCMLFN(this Transform OIFLDNBGJOH, Vector3 KNIKPKEBLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x373E900", Offset = "0x373DB00", VA = "0x18373E900")]
	public static Vector3 CPLMAMCMLFN(Vector3 DEPGOBCBCAB, Vector3 FFGMLBJDGFM, Vector3 MGCJCNFHMEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x373FBF0", Offset = "0x373EDF0", VA = "0x18373FBF0")]
	public static Vector3 NFFAAMNNHGN(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x373E4A0", Offset = "0x373D6A0", VA = "0x18373E4A0")]
	public static Vector2 CJEBHAJDJMI(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x373F0A0", Offset = "0x373E2A0", VA = "0x18373F0A0")]
	public static float ILCMBGMEPJE(this RectTransform AIOEKMHLKAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x373F470", Offset = "0x373E670", VA = "0x18373F470")]
	public static Vector3 JBLIBMEOLEB(this RectTransform AIOEKMHLKAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x373FD40", Offset = "0x373EF40", VA = "0x18373FD40")]
	public static Vector3[] PHMOKHIOHDG(this RectTransform AIOEKMHLKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x373FAE0", Offset = "0x373ECE0", VA = "0x18373FAE0")]
	public static Quaternion MHKNGOGEBNG(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x373EDC0", Offset = "0x373DFC0", VA = "0x18373EDC0")]
	public static Quaternion DKEHHDMGLPO(this Transform OIFLDNBGJOH, Quaternion IGPENJBJADK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x373F8A0", Offset = "0x373EAA0", VA = "0x18373F8A0")]
	public static Vector3 MHEFIHAJMAD(this Transform OIFLDNBGJOH, Vector3 DDHPAFKBMON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x16FF0B0", Offset = "0x16FE2B0", VA = "0x1816FF0B0")]
	public static float LACCAFFAOIG(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x373E2D0", Offset = "0x373D4D0", VA = "0x18373E2D0")]
	public static float ABDKFENDAKH(this Transform OIFLDNBGJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x373F5F0", Offset = "0x373E7F0", VA = "0x18373F5F0")]
	public static void MCFLPFCGOOL(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x373F2A0", Offset = "0x373E4A0", VA = "0x18373F2A0")]
	public static void IMCHPFPFLJJ(this Transform OIFLDNBGJOH, float MKDHFENOFDO, Vector3 KLNFHHBHGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x373E300", Offset = "0x373D500", VA = "0x18373E300")]
	public static void CAIHJLKEPIF(this Transform OIFLDNBGJOH, float MKDHFENOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x373E830", Offset = "0x373DA30", VA = "0x18373E830")]
	public static float CPEJGKGFNJH(this Transform OIFLDNBGJOH, float PLIPOIMDGPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x373F820", Offset = "0x373EA20", VA = "0x18373F820")]
	public static float MDGALGDEFAK(this Transform OIFLDNBGJOH, float JIBDGOKLJOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x373EE80", Offset = "0x373E080", VA = "0x18373EE80")]
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
	[Cpp2IlInjected.Address(RVA = "0x63DDB0", Offset = "0x63CFB0", VA = "0x18063DDB0")]
	public static Vector2 KMEKBBFBKCA(Vector2 KDBHHDAJLNL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3745640", Offset = "0x3744840", VA = "0x183745640")]
	public static Vector2 KOLMGGDLPDK(this Vector2 PJEDBAONDPP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3745610", Offset = "0x3744810", VA = "0x183745610")]
	public static bool CDKDHNKFHFB(this Vector2 PDPPMFNOBMO, float ONGBFDACHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3745730", Offset = "0x3744930", VA = "0x183745730")]
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
	[Cpp2IlInjected.Address(RVA = "0x374A050", Offset = "0x3749250", VA = "0x18374A050")]
	public static Vector3 EMJNMOGIAKL(this IEnumerable<Vector3> COAEBIFOBNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x374B110", Offset = "0x374A310", VA = "0x18374B110")]
	public static float NMDFDMBNFNA(Vector3 IPHIIJNAEON, Vector3 FOJLJNMAJLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x374B9E0", Offset = "0x374ABE0", VA = "0x18374B9E0")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Vector3 IDMBJGPOCAE, Vector3 MCEDKFKKOCM, Vector3 MJPDDCEFPIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x374BBC0", Offset = "0x374ADC0", VA = "0x18374BBC0")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x374B840", Offset = "0x374AA40", VA = "0x18374B840")]
	public static Vector3 OLKHIPGPHIF(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH, Vector3 EIHOAEHONBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x374BCE0", Offset = "0x374AEE0", VA = "0x18374BCE0")]
	public static Vector3 PFLLEKCBAAL(this Vector3 DINHOLEGEMB, Vector3 OBAHDHCBDHN, Quaternion IHBAOAEOMIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x374B1D0", Offset = "0x374A3D0", VA = "0x18374B1D0")]
	public static bool OGIEHPPFJCB(this Vector3 BMOIJACGPLN, float LBLHBGPCEMF = 0.001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x374AB40", Offset = "0x3749D40", VA = "0x18374AB40")]
	public static bool ICGLFNNJKAC(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x374A710", Offset = "0x3749910", VA = "0x18374A710")]
	public static bool HPKDFLEPPCG(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3749FC0", Offset = "0x37491C0", VA = "0x183749FC0")]
	public static float DGNGDMGOMAA(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3749820", Offset = "0x3748A20", VA = "0x183749820")]
	public static float AHOKOGPDJNP(this Vector3 DINHOLEGEMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3749F00", Offset = "0x3749100", VA = "0x183749F00")]
	public static Vector3 DDGPCFJMGII(this Vector3 DINHOLEGEMB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x374AD90", Offset = "0x3749F90", VA = "0x18374AD90")]
	public static Vector3 JKGIHPNIJLK(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x3749CA0", Offset = "0x3748EA0", VA = "0x183749CA0")]
	public static Vector3 BNKOIHAECHN(this Vector3 PJEDBAONDPP, float NNNGNCNIJAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3749BC0", Offset = "0x3748DC0", VA = "0x183749BC0")]
	public static bool BECDFHKOIGK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x374AFA0", Offset = "0x374A1A0", VA = "0x18374AFA0")]
	public static bool JNEMCKAMAMK(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x374ACF0", Offset = "0x3749EF0", VA = "0x18374ACF0")]
	public static bool JCLKGFMMODE(this Vector3 PJEDBAONDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3749C10", Offset = "0x3748E10", VA = "0x183749C10")]
	public static Vector3 BMNFGJPMFBG(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x374B300", Offset = "0x374A500", VA = "0x18374B300")]
	public static Vector3 OHHOPADHBAL(this Vector3 HNPCOFJKHHJ, Vector3 HPKICPNGMDJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x374A330", Offset = "0x3749530", VA = "0x18374A330")]
	public static float FLEMBFIOFJA(this Vector3 BANGBIKOBGO, Vector3 OALKOHJOHFO, [Optional] Vector3? KNIKPKEBLNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x374B0F0", Offset = "0x374A2F0", VA = "0x18374B0F0")]
	public static Vector3 NELNDENOBLC(this Vector3 PJEDBAONDPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x374A780", Offset = "0x3749980", VA = "0x18374A780")]
	public static Vector3 IBPJJIDHFFL(Vector3 CHGNDIAMGLF, Quaternion IBCNKFBPCBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x374B390", Offset = "0x374A590", VA = "0x18374B390")]
	public static KCNMMJEKPBC OJDKGBIHNJD(Transform OIFLDNBGJOH, Vector3 MAPAFOGPKLL, out Vector3 GLHHBDHELAO)
	{
		return default(KCNMMJEKPBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x374A4F0", Offset = "0x37496F0", VA = "0x18374A4F0")]
	public static Vector3 GKDMJPGOEHO(float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x374A6E0", Offset = "0x37498E0", VA = "0x18374A6E0")]
	public static Vector3 HOCFJJAOPDC(float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3749ED0", Offset = "0x37490D0", VA = "0x183749ED0")]
	public static Vector3 CLEFGACGMKH(float FOBCKBCBJHD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x374A5E0", Offset = "0x37497E0", VA = "0x18374A5E0")]
	public static Vector3 GNOENAFKJIE(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x374B000", Offset = "0x374A200", VA = "0x18374B000")]
	public static Vector3 KICDFOACKEL(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x374AD50", Offset = "0x3749F50", VA = "0x18374AD50")]
	public static Vector3 JJOELJJFBAE(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3749E10", Offset = "0x3749010", VA = "0x183749E10")]
	public static Vector3 CIOKEDCFPJI(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x374BE10", Offset = "0x374B010", VA = "0x18374BE10")]
	public static Vector3 PGCOBFHPJEA(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x374BED0", Offset = "0x374B0D0", VA = "0x18374BED0")]
	public static Vector3 PLINJEJIIMO(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3749B00", Offset = "0x3748D00", VA = "0x183749B00")]
	public static Vector3 BCICENEBNCF(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x374A520", Offset = "0x3749720", VA = "0x18374A520")]
	public static Vector3 GMNHMHPHIJK(this Vector3 NMELNILPPKN, float DFICPKCPNLK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x374B040", Offset = "0x374A240", VA = "0x18374B040")]
	public static Vector3 KKANLJKPHJI(this Vector3 NMELNILPPKN, float INKIBDEPLIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x374A620", Offset = "0x3749820", VA = "0x18374A620")]
	public static Vector3 HCLHKJPLONK(this Vector3 NMELNILPPKN, float NDILEEFABJA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x374ABB0", Offset = "0x3749DB0", VA = "0x18374ABB0")]
	public static Vector3 IKBIEPLCAKN(Vector3 HGEIABGCFOA, Vector3 IBHEKLCMMNH, Vector3 KNIKPKEBLNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x37498B0", Offset = "0x3748AB0", VA = "0x1837498B0")]
	public static Vector3 AOGDEGACCAP(Vector3 PJEDBAONDPP, Vector3 OOEKLKBHAHK, Vector3 AIOJLAJOCEL, bool PNLBALPIOHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x374AE50", Offset = "0x374A050", VA = "0x18374AE50")]
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
	[Cpp2IlInjected.Address(RVA = "0x37484A0", Offset = "0x37476A0", VA = "0x1837484A0")]
	public JFCMGKMLBMN(RenderTexture BGFEHOIGLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3748490", Offset = "0x3747690", VA = "0x183748490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FNHMBIFJJLB
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3745320", Offset = "0x3744520", VA = "0x183745320")]
	public static Quaternion CHDHKJJADFE(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x16FF0E0", Offset = "0x16FE2E0", VA = "0x1816FF0E0")]
	public static Vector3 DOAOMJFMLLN(this Matrix4x4 MBDBBCDFFHK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3745460", Offset = "0x3744660", VA = "0x183745460")]
	public static Vector3 OHAKMAOEKCG(this Matrix4x4 BKPMKIIFPKO)
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class IJHPIMJMEIB
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x1676780", Offset = "0x1675980", VA = "0x181676780")]
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
