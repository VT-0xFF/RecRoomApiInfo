using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;
using UnityEngine.Localization.Metadata;
using UnityEngine.Localization.Pseudo;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BELGADNCDII<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2D01230", Offset = "0x2D00630", VA = "0x182D01230")]
	public BELGADNCDII()
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
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public LocaleDisplayName()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EMNMHAAJMGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class KNKOGKBJNMK<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public T enumValue;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public KNKOGKBJNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2E61FE0", Offset = "0x2E613E0", VA = "0x182E61FE0")]
		internal void HJJEKEDDPGP(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Dictionary<(Type, string), string> LCFGEAMODIA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Dictionary<Type, string> LCLMOLHIHNF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x224C760", Offset = "0x224BB60", VA = "0x18224C760")]
	private static string KKGPNAKFJKF<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAD30", Offset = "0x6FEA130", VA = "0x186FEAD30")]
	private static bool PKMONOAONDJ((Type type, string name) FPOEIPLIPEP, out string AOFGIMJLFMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x224CB80", Offset = "0x224BF80", VA = "0x18224CB80")]
	public static string MGBBIJGLMHI<T>(this T HIMOPIMKOMB, params object[] GIAFHFNHDKC) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x224CDA0", Offset = "0x224C1A0", VA = "0x18224CDA0")]
	private static bool NIEHBHJEKAC<T>(out string AGLCIEKHLEE, T HIMOPIMKOMB, params object[] GIAFHFNHDKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x224C160", Offset = "0x224B560", VA = "0x18224C160")]
	private static AsyncOperationHandle<string> DOAHKJBIOOA<T>(T HIMOPIMKOMB, params object[] GIAFHFNHDKC) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAE30", Offset = "0x6FEA230", VA = "0x186FEAE30")]
	static EMNMHAAJMGJ()
	{
	}
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class LocalizedFontManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AKDFOHOCMML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public TMP_FontAsset fallbackFontAddressables;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public TMP_FontAsset fallbackFontPlayerBuild;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public AKDFOHOCMML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6FEA800", Offset = "0x6FE9C00", VA = "0x186FEA800")]
			internal void EKMHNDFGLBI(TMP_FontAsset font)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PEKNGMFDDEL : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LocalizedFontManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private AKDFOHOCMML <>8__1;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
			[DebuggerHidden]
			public PEKNGMFDDEL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6FECF80", Offset = "0x6FEC380", VA = "0x186FECF80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6FED540", Offset = "0x6FEC940", VA = "0x186FED540", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private AsyncOperationHandle<TMP_FontAsset> FPEOIADGCJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private AsyncOperationHandle<IList<TMP_FontAsset>> IHPGDJOPHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private LocalizedFontConfig PPCPEOGMHIJ;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string JAAGHAHOPLI = "RR Tools/Localization/Fonts/";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string EFPJPKADKOF = "RR Tools/Localization/Fonts/Connect Localized Fonts (Editor Time)";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public const string MENU_PATH_CLEAR = "RR Tools/Localization/Fonts/Clear Localized Fonts";

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC930", Offset = "0x6FEBD30", VA = "0x186FEC930")]
		[IteratorStateMachine(typeof(PEKNGMFDDEL))]
		public IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC7A0", Offset = "0x6FEBBA0", VA = "0x186FEC7A0")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public LocalizedFontManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Metadata]
	[Description]
	public class ExcludeFromLanguagePicker : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public ExcludeFromLanguagePicker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Metadata]
	public class MaximumLengthConstraint : LocalizationConstraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MaximumLengthConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Metadata]
	[Description]
	public class RecNetLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public RecNetLocaleIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class LocalizationGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Preserve]
public class LGLGLKNMOJA : EJPMHMLKGEF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string MIKEHGLOMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC6E0", Offset = "0x6FEBAE0", VA = "0x186FEC6E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string OJJGGLNGEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC520", Offset = "0x6FEB920", VA = "0x186FEC520", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool FCDIJKGBGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC590", Offset = "0x6FEB990", VA = "0x186FEC590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC5F0", Offset = "0x6FEB9F0", VA = "0x186FEC5F0")]
	[PGKDFPMEDOJ(OCCBJMOEDKI.Root, CDFBKAGHDGH.None)]
	private static void JOJBKOBJJHB(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public LGLGLKNMOJA()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisplayName]
	public class RRCommandLineLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private string commandLineArgumentPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FED580", Offset = "0x6FEC980", VA = "0x186FED580", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider ICMMJMFGPLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDA60", Offset = "0x6FECE60", VA = "0x186FEDA60")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
internal class MLJCJFDOLFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Dictionary<string, Dictionary<long, string>> NDLEKKDBFPA;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA9CB00", Offset = "0xA9BF00", VA = "0x180A9CB00")]
	public void GKKLLPKKEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6FECAB0", Offset = "0x6FEBEB0", VA = "0x186FECAB0")]
	public LMHNGLGIJDH ICJHDEOHEHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9CE820", Offset = "0x9CDC20", VA = "0x1809CE820")]
	public MLJCJFDOLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC9A0", Offset = "0x6FEBDA0", VA = "0x186FEC9A0")]
	[CompilerGenerated]
	private void EMMEOJLKJPE(Dictionary<string, Dictionary<long, string>> PLPIABMJLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6FECE60", Offset = "0x6FEC260", VA = "0x186FECE60")]
	[CompilerGenerated]
	private void KJENOFGOPOC(string OABFELNKNEB)
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Metadata]
	[Description]
	public class RecNetStringsLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEBF0", Offset = "0x6FEDFF0", VA = "0x186FEEBF0", Slot = "4")]
		public void Transform(Message FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KAGECPCCFCH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class FLOJELDBOKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public FLOJELDBOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB020", Offset = "0x6FEA420", VA = "0x186FEB020")]
		internal bool NCJMBAFIOGA(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBF20", Offset = "0x6FEB320", VA = "0x186FEBF20")]
	public static List<Locale> OCMFEFLKEFP(this LocalizationSettings KHIAIPDLLBL, bool IJEBFMBJPNH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB690", Offset = "0x6FEAA90", VA = "0x186FEB690")]
	public static void IJHNDJAPPNJ(Locale LFKOCLEFLJD, string KENJKCCHBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB990", Offset = "0x6FEAD90", VA = "0x186FEB990")]
	public static Locale IPCLGFHECKE(this LocalizationSettings KHIAIPDLLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBCE0", Offset = "0x6FEB0E0", VA = "0x186FEBCE0")]
	private static void MOBODBLLPKB(string DGKKBFPKOAN, string EJBAOAAIEMD, string OIEACLJHHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC470", Offset = "0x6FEB870", VA = "0x186FEC470")]
	public static void PLEMKGFCOJA(this LocalizationSettings KHIAIPDLLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC150", Offset = "0x6FEB550", VA = "0x186FEC150")]
	public static Locale OMCHJNIBDGH(this LocalizationSettings KHIAIPDLLBL, string BIJHOCFNLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6FEC190", Offset = "0x6FEB590", VA = "0x186FEC190")]
	public static Locale OMCHJNIBDGH(this ILocalesProvider BNBFBKGLLNF, string BIJHOCFNLGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB470", Offset = "0x6FEA870", VA = "0x186FEB470")]
	public static string BHFGFOBAECH(this Locale LFKOCLEFLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB400", Offset = "0x6FEA800", VA = "0x186FEB400")]
	public static string BEEDCKILCEO(this Locale LFKOCLEFLJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBE30", Offset = "0x6FEB230", VA = "0x186FEBE30")]
	public static string MOOIMBCMENN(this CultureInfo LDELPMJLIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEBB90", Offset = "0x6FEAF90", VA = "0x186FEBB90")]
	public static string MNLGIKNJJJI(this LocalizedString NMEFMJHDALE, string PMMAAICOJOP, object AGLCIEKHLEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEB640", Offset = "0x6FEAA40", VA = "0x186FEB640")]
	public static string HDMHOGANFOB(this LocalizedString NMEFMJHDALE, string HHEMJEJHEHE)
	{
		return null;
	}
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
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
		private sealed class BAODMGKGADI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public BAODMGKGADI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6FEA940", Offset = "0x6FE9D40", VA = "0x186FEA940")]
			internal void NDPKEMFADIF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MLJCJFDOLFE retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDD70", Offset = "0x6FED170", VA = "0x186FEDD70")]
		public static LMHNGLGIJDH MHIDNOPDKCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDFB0", Offset = "0x6FED3B0", VA = "0x186FEDFB0", Slot = "4")]
		public void PostprocessTable(LocalizationTable KEIEFCJLPMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		private void GCKIBNEJKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEA80", Offset = "0x6FEDE80", VA = "0x186FEEA80", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEB00", Offset = "0x6FEDF00", VA = "0x186FEEB00")]
		public RecNetLocalizationTableProcessor()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DisplayName]
	public class RRPlayerPrefLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Should be the default code, but can be the default name as a fallback")]
		public LocaleIdentifier defaultLocaleIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("If no locale can be found, should fallback to the ProjectLocale?")]
		public bool fallbackToProjectLocale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IAJGLGCJAOD _preferences;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDAB0", Offset = "0x6FECEB0", VA = "0x186FEDAB0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider ICMMJMFGPLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6FEDD10", Offset = "0x6FED110", VA = "0x186FEDD10")]
		public RRPlayerPrefLocaleSelector()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class FallbackTableReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private StringTable loadedStringTable;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB350", Offset = "0x6FEA750", VA = "0x186FEB350")]
		public void MHIDNOPDKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB060", Offset = "0x6FEA460", VA = "0x186FEB060")]
		public void EHKLIGBABLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		private void GHCKLFJLAIL(StringTable GIJIHPKEAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEB110", Offset = "0x6FEA510", VA = "0x186FEB110")]
		public string KMEKLONPAAA(string PMMAAICOJOP, string HHEMJEJHEHE = "", bool IGCLICKKCHJ = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
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
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public List<string> skippableTexts;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public SkippableKnownText()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class LocalizedFontConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class FontAssetReference : AssetReferenceT<TMP_FontAsset>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private const string SingletonResourceKey = "LocalizedFontConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("All of the actual CJK type fonts should go here")]
		public List<FontAssetReference> localizedFonts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("The font that will contain the fallback chain to CJK")]
		public TMP_FontAsset fallbackFontPlayerBuild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("An addressable reference to the font that will contain the fallback chains to the CJK fonts")]
		public FontAssetReference fallbackFontAddressable;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6FEC750", Offset = "0x6FEBB50", VA = "0x186FEC750")]
		public static LocalizedFontConfig GOCGNBKPGGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9840D0", Offset = "0x9834D0", VA = "0x1809840D0")]
		public LocalizedFontConfig()
		{
		}
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
