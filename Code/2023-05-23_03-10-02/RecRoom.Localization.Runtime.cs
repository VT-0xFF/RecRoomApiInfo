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
public class HCOAINIFAFE<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4335980", Offset = "0x4334D80", VA = "0x184335980")]
	public HCOAINIFAFE()
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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LocaleDisplayName()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CAHBLEKCPGM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class DLJBCLJNMLI<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public bool isCacheable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public (Type type, string name) cacheKey;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public DLJBCLJNMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3C0D9F0", Offset = "0x3C0CDF0", VA = "0x183C0D9F0")]
		internal void MDHDANIOHAC(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Dictionary<(Type, string), string> FHDFKJHCNAK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Dictionary<Type, string> KPODEDLPEFP;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2584C90", Offset = "0x2584090", VA = "0x182584C90")]
	private static string APHODNBDKPG<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15F9CC0", Offset = "0x15F90C0", VA = "0x1815F9CC0")]
	private static bool HPAJMLPOJID((Type type, string name) KAKBJFFEAIH, out string KKEPAKMHJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25850B0", Offset = "0x25844B0", VA = "0x1825850B0")]
	public static string GBLOEMCJECG<T>(this T NFPNNPGKLPI, params object[] NKBGLJJNGOP) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2585210", Offset = "0x2584610", VA = "0x182585210")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AGNEALGFCIH))]
	public static Task<string> GFGDNBKKKAL<T>(this T NFPNNPGKLPI, params object[] NKBGLJJNGOP) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2585390", Offset = "0x2584790", VA = "0x182585390")]
	private static AsyncOperationHandle<string> HJJIKJAHOIL<T>(T NFPNNPGKLPI, params object[] NKBGLJJNGOP) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x15F9DC0", Offset = "0x15F91C0", VA = "0x1815F9DC0")]
	static CAHBLEKCPGM()
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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15FB0D0", Offset = "0x15FA4D0", VA = "0x1815FB0D0", Slot = "4")]
		public override bool PJKLLMDJCLF(StringTableEntry KAKBJFFEAIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Preserve]
public class AEEAKMPKMOK : EFPDJILDMBH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string EPBGFIMFJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x15F9750", Offset = "0x15F8B50", VA = "0x1815F9750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public string EGBOGPEEHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x15F9980", Offset = "0x15F8D80", VA = "0x1815F9980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string CMIFJPFLPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x15F9B40", Offset = "0x15F8F40", VA = "0x1815F9B40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MBDLDHMPJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15F9B70", Offset = "0x15F8F70", VA = "0x1815F9B70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CultureInfo MEAEOFLJLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x15F97C0", Offset = "0x15F8BC0", VA = "0x1815F97C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x15F99F0", Offset = "0x15F8DF0", VA = "0x1815F99F0", Slot = "9")]
	public string JKONOJGGJKE(string LOLIOKKJLEH, string NANLNGBNFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x15F97F0", Offset = "0x15F8BF0", VA = "0x1815F97F0", Slot = "10")]
	public Task<string> HECFGHEPFOE(string LOLIOKKJLEH, string NANLNGBNFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x15F9BD0", Offset = "0x15F8FD0", VA = "0x1815F9BD0")]
	[HECCOHDEPAK(OEAABDENEKP.Root, JCKMLGOOEHJ.None)]
	private static void PKIDGDOGENM(HECDEIOAEPJ BFLCNPAPJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AEEAKMPKMOK()
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
		[Cpp2IlInjected.Address(RVA = "0x15FB050", Offset = "0x15FA450", VA = "0x1815FB050")]
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
			[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x15FC9C0", Offset = "0x15FBDC0", VA = "0x1815FC9C0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider CAHAEBECAFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x15FCEA0", Offset = "0x15FC2A0", VA = "0x1815FCEA0")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
internal class IFELICMFFKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Dictionary<string, Dictionary<long, string>> FMPMOFFIBNC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Dictionary<long, string> KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x15FA9C0", Offset = "0x15F9DC0", VA = "0x1815FA9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x10C0900", Offset = "0x10BFD00", VA = "0x1810C0900")]
	public void IEFECOOIOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x15FABA0", Offset = "0x15F9FA0", VA = "0x1815FABA0")]
	public FKADHPEOOEO FEODAMMBHIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xBBF390", Offset = "0xBBE790", VA = "0x180BBF390")]
	public IFELICMFFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x15FAF40", Offset = "0x15FA340", VA = "0x1815FAF40")]
	[CompilerGenerated]
	private void FJIAFLCDHEJ(Dictionary<string, Dictionary<long, string>> BIPABJPBDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x15FAA80", Offset = "0x15F9E80", VA = "0x1815FAA80")]
	[CompilerGenerated]
	private void DEAAENDABDN(string NEMKEJKFJAE)
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
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x15FE1B0", Offset = "0x15FD5B0", VA = "0x1815FE1B0", Slot = "4")]
		public void Transform(Message HGJOENLBDNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ODDLJNOBDMM
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class CBICHIOIGJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public CBICHIOIGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x15F9FB0", Offset = "0x15F93B0", VA = "0x1815F9FB0")]
		internal bool ENPFBLGCLIK(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x15FB6B0", Offset = "0x15FAAB0", VA = "0x1815FB6B0")]
	public static void DGOBHCCKHKO(this LocalizationSettings AIPHKCIPHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x15FC620", Offset = "0x15FBA20", VA = "0x1815FC620")]
	public static List<Locale> NEIJKPOGOIK(this LocalizationSettings AIPHKCIPHIF, bool IFMLOBCANOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x15FBAC0", Offset = "0x15FAEC0", VA = "0x1815FBAC0")]
	public static void FECGEAFOKBN(Locale JBEEFODLIMA, string ECICADNPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x15FB180", Offset = "0x15FA580", VA = "0x1815FB180")]
	public static Locale BLLNPNMKHAI(this LocalizationSettings AIPHKCIPHIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15FC4D0", Offset = "0x15FB8D0", VA = "0x1815FC4D0")]
	private static void LPHEGEMJODE(string POICOJACDBM, string LABGLDFANPC, string NNEEJCHOPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x15FC070", Offset = "0x15FB470", VA = "0x1815FC070")]
	public static void HEOPBBECEEK(this LocalizationSettings AIPHKCIPHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x15FC270", Offset = "0x15FB670", VA = "0x1815FC270")]
	public static Locale JAHOCBNBBPE(this ILocalesProvider OAKKNJPJALK, string LMAOKJPAKEM, bool IFMLOBCANOP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x15FB390", Offset = "0x15FA790", VA = "0x1815FB390")]
	public static Locale BMHEFDKNKJM(this LocalizationSettings AIPHKCIPHIF, string DEAPOAPALAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x15FB3D0", Offset = "0x15FA7D0", VA = "0x1815FB3D0")]
	public static Locale BMHEFDKNKJM(this ILocalesProvider OAKKNJPJALK, string DEAPOAPALAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x15FBDC0", Offset = "0x15FB1C0", VA = "0x1815FBDC0")]
	public static string FECHJPCNIHA(this Locale JBEEFODLIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x15FB110", Offset = "0x15FA510", VA = "0x1815FB110")]
	public static string AGAJPAEDFCB(this Locale JBEEFODLIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x15FBF80", Offset = "0x15FB380", VA = "0x1815FBF80")]
	public static string GKHPCNIIMNI(this CultureInfo MIGHPBIAGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x15FC890", Offset = "0x15FBC90", VA = "0x1815FC890")]
	public static void POGPFNLAFDB(this LocalizedString DCMHBFFOKJP, string LOLIOKKJLEH, string EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x15FC120", Offset = "0x15FB520", VA = "0x1815FC120")]
	public static string IHJMOHCEGGE(this LocalizedString DCMHBFFOKJP, string LOLIOKKJLEH, object EOEKGHMNIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x15FC840", Offset = "0x15FBC40", VA = "0x1815FC840")]
	public static string NHMBOOMAGEE(this LocalizedString DCMHBFFOKJP, string IKPGLGKFBAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x15FB720", Offset = "0x15FAB20", VA = "0x1815FB720")]
	public static void EEMGHHONIAF(this StringTableEntry KAKBJFFEAIH, string NNEEJCHOPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x15FB900", Offset = "0x15FAD00", VA = "0x1815FB900")]
	public static void EEMGHHONIAF(this SharedTableData.SharedTableEntry KAKBJFFEAIH, string NNEEJCHOPPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MIMPGJKLLFN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class GHELFNOFANP
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public const string OAFFHMAMADJ = "Locale";

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public const string FAKIBMLHDDO = "language_changed";
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public const string LLFAEIBHDBA = "Locale";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string JJLOLOENNDH = "LastSelectedLocale";
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool PJKLLMDJCLF(StringTableEntry KAKBJFFEAIH);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
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
		private sealed class FPBPEALAJAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public FPBPEALAJAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x15F9FF0", Offset = "0x15F93F0", VA = "0x1815F9FF0")]
			internal void OANNKMFELJB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private IFELICMFFKN retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x15FD1C0", Offset = "0x15FC5C0", VA = "0x1815FD1C0")]
		public static FKADHPEOOEO OAGJEKOOFKN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x15FD400", Offset = "0x15FC800", VA = "0x1815FD400", Slot = "4")]
		public void PostprocessTable(LocalizationTable MADLFCGDAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
		private void HHHIABFCHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x15FDED0", Offset = "0x15FD2D0", VA = "0x1815FDED0", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x15FDF50", Offset = "0x15FD350", VA = "0x1815FDF50")]
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
		private ODGLAHCCHJO _preferences;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x15FCEF0", Offset = "0x15FC2F0", VA = "0x1815FCEF0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider CAHAEBECAFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x15FD160", Offset = "0x15FC560", VA = "0x1815FD160")]
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
		[Cpp2IlInjected.Address(RVA = "0x15FA910", Offset = "0x15F9D10", VA = "0x1815FA910")]
		public void OAGJEKOOFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x15FA3D0", Offset = "0x15F97D0", VA = "0x1815FA3D0")]
		public void BEBNHAAGHMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60")]
		private void LMDGMOHNHED(StringTable NANLNGBNFPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x15FA480", Offset = "0x15F9880", VA = "0x1815FA480")]
		public string HNLFDAKEPCA(string LOLIOKKJLEH, string IKPGLGKFBAM = "", bool OLHOJKMAKNP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x15FA6C0", Offset = "0x15F9AC0", VA = "0x1815FA6C0")]
		public string HNLFDAKEPCA(string LOLIOKKJLEH, string IKPGLGKFBAM = "", bool OLHOJKMAKNP = false, params object[] NKBGLJJNGOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x15FE110", Offset = "0x15FD510", VA = "0x1815FE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x15FE040", Offset = "0x15FD440", VA = "0x1815FE040")]
		public static bool MEIKKLBJCPM(string KBPNDAMNPEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public SkippableKnownText()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Metadata]
[Description]
public class DJKCFKKDNDF : IMetadata
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public DJKCFKKDNDF()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
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
