using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Metadata;
using UnityEngine.Localization.Pseudo;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GBHJACDEEIO<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x49E0500", Offset = "0x49DED00", VA = "0x1849E0500")]
	public GBHJACDEEIO()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Metadata]
	public class LocaleDisplayName : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public string DisplayName;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public LocaleDisplayName()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NGBGBDMPNKD
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class HMPMNODMIHC<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public bool isCacheable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public (Type type, string name) cacheKey;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
		public HMPMNODMIHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x35865F0", Offset = "0x3584DF0", VA = "0x1835865F0")]
		internal void DPELCNKDIOG(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Dictionary<(Type, string), string> FOPCKFMOMNP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Dictionary<Type, string> PANIKHABFPC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6EC0", Offset = "0x2FB56C0", VA = "0x182FB6EC0")]
	private static string MABDCCDGHFL<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x157CC60", Offset = "0x157B460", VA = "0x18157CC60")]
	private static bool ACHBBPNKNLA((Type type, string name) PECELBJIIAP, out string ENIFPKFIJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2FB7D50", Offset = "0x2FB6550", VA = "0x182FB7D50")]
	public static string NMGECJBAKOF<T>(this T AMNNIMCNJDH, params object[] HLDFMFOCOAM) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6D40", Offset = "0x2FB5540", VA = "0x182FB6D40")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDDEIFLJLNE))]
	public static Task<string> BDEAALKHJBN<T>(this T AMNNIMCNJDH, params object[] HLDFMFOCOAM) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2FB72E0", Offset = "0x2FB5AE0", VA = "0x182FB72E0")]
	private static AsyncOperationHandle<string> NGIFIKCFJMN<T>(T AMNNIMCNJDH, params object[] HLDFMFOCOAM) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x157CD60", Offset = "0x157B560", VA = "0x18157CD60")]
	static NGBGBDMPNKD()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Metadata]
	[Description]
	public class ExcludeFromLanguagePicker : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public ExcludeFromLanguagePicker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Metadata]
	public class MaximumLengthConstraint : LocalizationConstraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x157CC20", Offset = "0x157B420", VA = "0x18157CC20", Slot = "4")]
		public override bool HMEFICDIDBP(StringTableEntry PECELBJIIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public MaximumLengthConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[Metadata]
	[Description]
	public class RecNetLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public RecNetLocaleIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class LocalizationGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Preserve]
public class EEJOKCFKFFO : HPHJMEFPAPN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string ADBJCHPOLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x157B9E0", Offset = "0x157A1E0", VA = "0x18157B9E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public string CCAANCFCECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x157B970", Offset = "0x157A170", VA = "0x18157B970", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string IGMCHPHAPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x157BCF0", Offset = "0x157A4F0", VA = "0x18157BCF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool AGFOHEAOFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x157BBA0", Offset = "0x157A3A0", VA = "0x18157BBA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CultureInfo PKPKDOKDPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x157BD20", Offset = "0x157A520", VA = "0x18157BD20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x157BA50", Offset = "0x157A250", VA = "0x18157BA50", Slot = "9")]
	public string GALCDJIPKCO(string BDFCACLHAFA, string GGNABAJOGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x157BD50", Offset = "0x157A550", VA = "0x18157BD50", Slot = "10")]
	public Task<string> PMGIKEBOPMF(string BDFCACLHAFA, string GGNABAJOGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x157BC00", Offset = "0x157A400", VA = "0x18157BC00")]
	[BBAPFPLPODF(BLGLNFDFDJO.Root, EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public EEJOKCFKFFO()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Metadata]
	[Description]
	public class LocalizationSource : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public List<string> sources;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x157CBA0", Offset = "0x157B3A0", VA = "0x18157CBA0")]
		public LocalizationSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[System.ComponentModel.DisplayName]
	public class RRCommandLineLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private string commandLineArgumentPrefix;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string CommandLineArgument
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x157CF50", Offset = "0x157B750", VA = "0x18157CF50", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider DAMFFGGAHDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x157D430", Offset = "0x157BC30", VA = "0x18157D430")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
internal class ENFPBHBMCEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Dictionary<string, Dictionary<long, string>> ICAOAIEGCJH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Dictionary<long, string> OILDPKEFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x157C390", Offset = "0x157AB90", VA = "0x18157C390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1080410", Offset = "0x107EC10", VA = "0x181080410")]
	public void EAGHKAECELD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x157BFF0", Offset = "0x157A7F0", VA = "0x18157BFF0")]
	public EILHPPDHBHH BNOLAIBPMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBC0DE0", Offset = "0xBBF5E0", VA = "0x180BC0DE0")]
	public ENFPBHBMCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x157BEE0", Offset = "0x157A6E0", VA = "0x18157BEE0")]
	[CompilerGenerated]
	private void AFBIEMPGBKC(Dictionary<string, Dictionary<long, string>> NABJDJHMKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x157C450", Offset = "0x157AC50", VA = "0x18157C450")]
	[CompilerGenerated]
	private void OIDACJGAGDD(string EIJFOGFJFOP)
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Metadata]
	[Description]
	public class RecNetStringsLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x157E740", Offset = "0x157CF40", VA = "0x18157E740", Slot = "4")]
		public void Transform(Message DKIECHCHJFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BNMCKECJDNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FAOABKAMIIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FAOABKAMIIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x157C570", Offset = "0x157AD70", VA = "0x18157C570")]
		internal bool DPJGKIHMMLC(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1579EA0", Offset = "0x15786A0", VA = "0x181579EA0")]
	public static void FEOAHOEPMNK(this LocalizationSettings BDFDGGAOPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x157AF80", Offset = "0x1579780", VA = "0x18157AF80")]
	public static List<Locale> OAEIBNHOGNM(this LocalizationSettings BDFDGGAOPFB, bool FLHDDJNNJNC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x157A7A0", Offset = "0x1578FA0", VA = "0x18157A7A0")]
	public static void IDGPCDGPGIM(Locale CMIDNPLIFLG, string GMLJNBIEKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x157A2E0", Offset = "0x1578AE0", VA = "0x18157A2E0")]
	public static Locale HKGNNMKOHEI(this LocalizationSettings BDFDGGAOPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x157A560", Offset = "0x1578D60", VA = "0x18157A560")]
	private static void IBPHBOFEKAK(string GFADDKFMOKC, string AFBCONFOFCJ, string PDHOFJLLEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1579F10", Offset = "0x1578710", VA = "0x181579F10")]
	public static void GIFAFDHGCEJ(this LocalizationSettings BDFDGGAOPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x157AAA0", Offset = "0x15792A0", VA = "0x18157AAA0")]
	public static Locale MOBENANOBOM(this ILocalesProvider MGCHHMKAMOF, string BPOKAAOBIOI, bool FLHDDJNNJNC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x157A2A0", Offset = "0x1578AA0", VA = "0x18157A2A0")]
	public static Locale GJJEEEJMLHH(this LocalizationSettings BDFDGGAOPFB, string JFBGOLLKHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1579FC0", Offset = "0x15787C0", VA = "0x181579FC0")]
	public static Locale GJJEEEJMLHH(this ILocalesProvider MGCHHMKAMOF, string JFBGOLLKHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1579CE0", Offset = "0x15784E0", VA = "0x181579CE0")]
	public static string EGNJPGLHPJN(this Locale CMIDNPLIFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x157A4F0", Offset = "0x1578CF0", VA = "0x18157A4F0")]
	public static string HLKKPKENMPD(this Locale CMIDNPLIFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x157A6B0", Offset = "0x1578EB0", VA = "0x18157A6B0")]
	public static string ICGFOILDOOO(this CultureInfo KOKKFHCNCDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x157AD00", Offset = "0x1579500", VA = "0x18157AD00")]
	public static void NHMENLNJLMG(this LocalizedString DLCNFGGONLF, string BDFCACLHAFA, string ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x157AE30", Offset = "0x1579630", VA = "0x18157AE30")]
	public static string NJBPOCHGIIG(this LocalizedString DLCNFGGONLF, string BDFCACLHAFA, object ECNGHFJBIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x157B1A0", Offset = "0x15799A0", VA = "0x18157B1A0")]
	public static string OCCONNKFANB(this LocalizedString DLCNFGGONLF, string CEDIPPBNHGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x157B1F0", Offset = "0x15799F0", VA = "0x18157B1F0")]
	public static void OEPCHJFFMIG(this StringTableEntry PECELBJIIAP, string PDHOFJLLEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x157B3D0", Offset = "0x1579BD0", VA = "0x18157B3D0")]
	public static void OEPCHJFFMIG(this SharedTableData.SharedTableEntry PECELBJIIAP, string PDHOFJLLEID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OOLLLPHIEKL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class MALHEFJLFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public const string AMJJGBAGOPM = "Locale";

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public const string IFJCADBOAKB = "language_changed";
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public const string HHMKNMDCFNN = "Locale";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string GDDLIJOBLHJ = "LastSelectedLocale";
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool HMEFICDIDBP(StringTableEntry PECELBJIIAP);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		protected LocalizationConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class RecNetLocalizationTableProcessor : ITablePostprocessor, IReset
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class DJGENKFENLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public DJGENKFENLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x157B590", Offset = "0x1579D90", VA = "0x18157B590")]
			internal void ABAEAAMKOAI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private ENFPBHBMCEG retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x157D750", Offset = "0x157BF50", VA = "0x18157D750")]
		public static EILHPPDHBHH PBAELFIBGFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x157D990", Offset = "0x157C190", VA = "0x18157D990", Slot = "4")]
		public void PostprocessTable(LocalizationTable IOPBDBCNKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80")]
		private void EMLNJOIBLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x157E460", Offset = "0x157CC60", VA = "0x18157E460", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x157E4E0", Offset = "0x157CCE0", VA = "0x18157E4E0")]
		public RecNetLocalizationTableProcessor()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[System.ComponentModel.DisplayName]
	public class RRPlayerPrefLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("Should be the default code, but can be the default name as a fallback")]
		public LocaleIdentifier defaultLocaleIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("If no locale can be found, should fallback to the ProjectLocale?")]
		public bool fallbackToProjectLocale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private IIDHLOGLACP _preferences;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x157D480", Offset = "0x157BC80", VA = "0x18157D480", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider DAMFFGGAHDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x157D6F0", Offset = "0x157BEF0", VA = "0x18157D6F0")]
		public RRPlayerPrefLocaleSelector()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class FallbackTableReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private StringTable loadedStringTable;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x157CAF0", Offset = "0x157B2F0", VA = "0x18157CAF0")]
		public void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x157C5B0", Offset = "0x157ADB0", VA = "0x18157C5B0")]
		public void ENFMBIKBCAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x811A70", Offset = "0x810270", VA = "0x180811A70")]
		private void JPEPKMFEICH(StringTable GGNABAJOGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x157C8B0", Offset = "0x157B0B0", VA = "0x18157C8B0")]
		public string IBMKOALPJDJ(string BDFCACLHAFA, string CEDIPPBNHGF = "", bool HGFFDKCANPF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x157C660", Offset = "0x157AE60", VA = "0x18157C660")]
		public string IBMKOALPJDJ(string BDFCACLHAFA, string CEDIPPBNHGF = "", bool HGFFDKCANPF = false, params object[] HLDFMFOCOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public FallbackTableReference()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[Metadata]
	public class SkippableKnownText : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<string> skippableTexts;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static List<string> Strings
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x157E6A0", Offset = "0x157CEA0", VA = "0x18157E6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x157E5D0", Offset = "0x157CDD0", VA = "0x18157E5D0")]
		public static bool ODOLPHCGINH(string IJAKCFMLLEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public SkippableKnownText()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Metadata]
[Description]
public class FMDOLEBAEJB : IMetadata
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public FMDOLEBAEJB()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
