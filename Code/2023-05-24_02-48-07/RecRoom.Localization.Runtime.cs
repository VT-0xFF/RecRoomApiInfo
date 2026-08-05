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
	[Cpp2IlInjected.Address(RVA = "0x5096E60", Offset = "0x5095A60", VA = "0x185096E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
		public HMPMNODMIHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3200", Offset = "0x2EC1E00", VA = "0x182EC3200")]
		internal void DPELCNKDIOG(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Dictionary<(Type, string), string> FOPCKFMOMNP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Dictionary<Type, string> PANIKHABFPC;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2D00", Offset = "0x2CE1900", VA = "0x182CE2D00")]
	private static string MABDCCDGHFL<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4210", Offset = "0x6EE2E10", VA = "0x186EE4210")]
	private static bool ACHBBPNKNLA((Type type, string name) PECELBJIIAP, out string ENIFPKFIJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3B90", Offset = "0x2CE2790", VA = "0x182CE3B90")]
	public static string NMGECJBAKOF<T>(this T AMNNIMCNJDH, params object[] HLDFMFOCOAM) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CE2B80", Offset = "0x2CE1780", VA = "0x182CE2B80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDDEIFLJLNE))]
	public static Task<string> BDEAALKHJBN<T>(this T AMNNIMCNJDH, params object[] HLDFMFOCOAM) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CE3120", Offset = "0x2CE1D20", VA = "0x182CE3120")]
	private static AsyncOperationHandle<string> NGIFIKCFJMN<T>(T AMNNIMCNJDH, params object[] HLDFMFOCOAM) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EE4310", Offset = "0x6EE2F10", VA = "0x186EE4310")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE41D0", Offset = "0x6EE2DD0", VA = "0x186EE41D0", Slot = "4")]
		public override bool HMEFICDIDBP(StringTableEntry PECELBJIIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x892580", Offset = "0x891180", VA = "0x180892580")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE2F90", Offset = "0x6EE1B90", VA = "0x186EE2F90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public string CCAANCFCECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EE2F20", Offset = "0x6EE1B20", VA = "0x186EE2F20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string IGMCHPHAPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6EE32A0", Offset = "0x6EE1EA0", VA = "0x186EE32A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool AGFOHEAOFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3150", Offset = "0x6EE1D50", VA = "0x186EE3150", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CultureInfo PKPKDOKDPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE32D0", Offset = "0x6EE1ED0", VA = "0x186EE32D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3000", Offset = "0x6EE1C00", VA = "0x186EE3000", Slot = "9")]
	public string GALCDJIPKCO(string BDFCACLHAFA, string GGNABAJOGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3300", Offset = "0x6EE1F00", VA = "0x186EE3300", Slot = "10")]
	public Task<string> PMGIKEBOPMF(string BDFCACLHAFA, string GGNABAJOGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE31B0", Offset = "0x6EE1DB0", VA = "0x186EE31B0")]
	[BBAPFPLPODF(BLGLNFDFDJO.Root, EDNJEIFHIMJ.None)]
	private static void JBHKDDKGJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE4150", Offset = "0x6EE2D50", VA = "0x186EE4150")]
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
			[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4500", Offset = "0x6EE3100", VA = "0x186EE4500", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider DAMFFGGAHDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6EE49E0", Offset = "0x6EE35E0", VA = "0x186EE49E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE3940", Offset = "0x6EE2540", VA = "0x186EE3940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xF50180", Offset = "0xF4ED80", VA = "0x180F50180")]
	public void EAGHKAECELD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EE35A0", Offset = "0x6EE21A0", VA = "0x186EE35A0")]
	public EILHPPDHBHH BNOLAIBPMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x16B8840", Offset = "0x16B7440", VA = "0x1816B8840")]
	public ENFPBHBMCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3490", Offset = "0x6EE2090", VA = "0x186EE3490")]
	[CompilerGenerated]
	private void AFBIEMPGBKC(Dictionary<string, Dictionary<long, string>> NABJDJHMKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3A00", Offset = "0x6EE2600", VA = "0x186EE3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5CF0", Offset = "0x6EE48F0", VA = "0x186EE5CF0", Slot = "4")]
		public void Transform(Message DKIECHCHJFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public FAOABKAMIIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3B20", Offset = "0x6EE2720", VA = "0x186EE3B20")]
		internal bool DPJGKIHMMLC(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1450", Offset = "0x6EE0050", VA = "0x186EE1450")]
	public static void FEOAHOEPMNK(this LocalizationSettings BDFDGGAOPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2530", Offset = "0x6EE1130", VA = "0x186EE2530")]
	public static List<Locale> OAEIBNHOGNM(this LocalizationSettings BDFDGGAOPFB, bool FLHDDJNNJNC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1D50", Offset = "0x6EE0950", VA = "0x186EE1D50")]
	public static void IDGPCDGPGIM(Locale CMIDNPLIFLG, string GMLJNBIEKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1890", Offset = "0x6EE0490", VA = "0x186EE1890")]
	public static Locale HKGNNMKOHEI(this LocalizationSettings BDFDGGAOPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1B10", Offset = "0x6EE0710", VA = "0x186EE1B10")]
	private static void IBPHBOFEKAK(string GFADDKFMOKC, string AFBCONFOFCJ, string PDHOFJLLEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6EE14C0", Offset = "0x6EE00C0", VA = "0x186EE14C0")]
	public static void GIFAFDHGCEJ(this LocalizationSettings BDFDGGAOPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2050", Offset = "0x6EE0C50", VA = "0x186EE2050")]
	public static Locale MOBENANOBOM(this ILocalesProvider MGCHHMKAMOF, string BPOKAAOBIOI, bool FLHDDJNNJNC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1850", Offset = "0x6EE0450", VA = "0x186EE1850")]
	public static Locale GJJEEEJMLHH(this LocalizationSettings BDFDGGAOPFB, string JFBGOLLKHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1570", Offset = "0x6EE0170", VA = "0x186EE1570")]
	public static Locale GJJEEEJMLHH(this ILocalesProvider MGCHHMKAMOF, string JFBGOLLKHJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1290", Offset = "0x6EDFE90", VA = "0x186EE1290")]
	public static string EGNJPGLHPJN(this Locale CMIDNPLIFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1AA0", Offset = "0x6EE06A0", VA = "0x186EE1AA0")]
	public static string HLKKPKENMPD(this Locale CMIDNPLIFLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1C60", Offset = "0x6EE0860", VA = "0x186EE1C60")]
	public static string ICGFOILDOOO(this CultureInfo KOKKFHCNCDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE22B0", Offset = "0x6EE0EB0", VA = "0x186EE22B0")]
	public static void NHMENLNJLMG(this LocalizedString DLCNFGGONLF, string BDFCACLHAFA, string ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE23E0", Offset = "0x6EE0FE0", VA = "0x186EE23E0")]
	public static string NJBPOCHGIIG(this LocalizedString DLCNFGGONLF, string BDFCACLHAFA, object ECNGHFJBIJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2750", Offset = "0x6EE1350", VA = "0x186EE2750")]
	public static string OCCONNKFANB(this LocalizedString DLCNFGGONLF, string CEDIPPBNHGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE27A0", Offset = "0x6EE13A0", VA = "0x186EE27A0")]
	public static void OEPCHJFFMIG(this StringTableEntry PECELBJIIAP, string PDHOFJLLEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE2980", Offset = "0x6EE1580", VA = "0x186EE2980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public DJGENKFENLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6EE2B40", Offset = "0x6EE1740", VA = "0x186EE2B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE4D00", Offset = "0x6EE3900", VA = "0x186EE4D00")]
		public static EILHPPDHBHH PBAELFIBGFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4F40", Offset = "0x6EE3B40", VA = "0x186EE4F40", Slot = "4")]
		public void PostprocessTable(LocalizationTable IOPBDBCNKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010")]
		private void EMLNJOIBLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5A10", Offset = "0x6EE4610", VA = "0x186EE5A10", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5A90", Offset = "0x6EE4690", VA = "0x186EE5A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE4A30", Offset = "0x6EE3630", VA = "0x186EE4A30", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider DAMFFGGAHDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE4CA0", Offset = "0x6EE38A0", VA = "0x186EE4CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE40A0", Offset = "0x6EE2CA0", VA = "0x186EE40A0")]
		public void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3B60", Offset = "0x6EE2760", VA = "0x186EE3B60")]
		public void ENFMBIKBCAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F3030", Offset = "0x7F1C30", VA = "0x1807F3030")]
		private void JPEPKMFEICH(StringTable GGNABAJOGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3E60", Offset = "0x6EE2A60", VA = "0x186EE3E60")]
		public string IBMKOALPJDJ(string BDFCACLHAFA, string CEDIPPBNHGF = "", bool HGFFDKCANPF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EE3C10", Offset = "0x6EE2810", VA = "0x186EE3C10")]
		public string IBMKOALPJDJ(string BDFCACLHAFA, string CEDIPPBNHGF = "", bool HGFFDKCANPF = false, params object[] HLDFMFOCOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6EE5C50", Offset = "0x6EE4850", VA = "0x186EE5C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5B80", Offset = "0x6EE4780", VA = "0x186EE5B80")]
		public static bool ODOLPHCGINH(string IJAKCFMLLEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public FMDOLEBAEJB()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
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
