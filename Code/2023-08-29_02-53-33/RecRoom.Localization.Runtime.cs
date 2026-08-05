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
public class BMLDFNCFGPA<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24D3EB0", Offset = "0x24D32B0", VA = "0x1824D3EB0")]
	public BMLDFNCFGPA()
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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public LocaleDisplayName()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FLCAIGLFDBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JLAGIKDIMBI<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public T enumValue;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x928540", Offset = "0x927940", VA = "0x180928540")]
		public JLAGIKDIMBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x20594A0", Offset = "0x20588A0", VA = "0x1820594A0")]
		internal void DMPNABGANPH(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Dictionary<(Type, string), string> BOJOBABOBDN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Dictionary<Type, string> EMMBNMMCBOA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1964AC0", Offset = "0x1963EC0", VA = "0x181964AC0")]
	private static string DEJFAMLINBA<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E7D0", Offset = "0x6D8DBD0", VA = "0x186D8E7D0")]
	private static bool PLJOLMNHCMD((Type type, string name) JGIIJLJNJGO, out string DKMHPKKGNHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x19654E0", Offset = "0x19648E0", VA = "0x1819654E0")]
	public static string JNOPKFLAFFI<T>(this T EALIBHBPMAH, params object[] KGCNLCOBHCL) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x19645B0", Offset = "0x19639B0", VA = "0x1819645B0")]
	private static bool BIFJECMCBEF<T>(out string KKIAKNLLHIO, T EALIBHBPMAH, params object[] KGCNLCOBHCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1964EE0", Offset = "0x19642E0", VA = "0x181964EE0")]
	private static AsyncOperationHandle<string> EFPODLPPKDH<T>(T EALIBHBPMAH, params object[] KGCNLCOBHCL) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D8E8D0", Offset = "0x6D8DCD0", VA = "0x186D8E8D0")]
	static FLCAIGLFDBJ()
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
		private sealed class OAJHGAMDEEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public TMP_FontAsset fallbackFontAddressables;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public TMP_FontAsset fallbackFontPlayerBuild;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public OAJHGAMDEEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6D90DD0", Offset = "0x6D901D0", VA = "0x186D90DD0")]
			internal void PJLANGIDNGJ(TMP_FontAsset font)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class CKJCDMPLLGK : IEnumerator<object>, IEnumerator, IDisposable
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
			private OAJHGAMDEEH <>8__1;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
			[DebuggerHidden]
			public CKJCDMPLLGK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E190", Offset = "0x6D8D590", VA = "0x186D8E190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E750", Offset = "0x6D8DB50", VA = "0x186D8E750", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private AsyncOperationHandle<TMP_FontAsset> APEFBCKJAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private AsyncOperationHandle<IList<TMP_FontAsset>> PFGLMKGKNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private LocalizedFontConfig DPEGKOHKGDO;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string FHOKDEGPCEN = "RR Tools/Localization/Fonts/";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string KCNGPEABHGL = "RR Tools/Localization/Fonts/Connect Localized Fonts (Editor Time)";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public const string MENU_PATH_CLEAR = "RR Tools/Localization/Fonts/Clear Localized Fonts";

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D90390", Offset = "0x6D8F790", VA = "0x186D90390")]
		[IteratorStateMachine(typeof(CKJCDMPLLGK))]
		public IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D90200", Offset = "0x6D8F600", VA = "0x186D90200")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Preserve]
public class LDIGDIFLCFB : DJPDGPHJLIM
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string ACMPFBMGEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FF80", Offset = "0x6D8F380", VA = "0x186D8FF80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string NJAJFFNJMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FFF0", Offset = "0x6D8F3F0", VA = "0x186D8FFF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool APDGNPHICJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D90060", Offset = "0x6D8F460", VA = "0x186D90060", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D900C0", Offset = "0x6D8F4C0", VA = "0x186D900C0")]
	[GHLDKGGJCDP(BOCOADOGGBA.Root, FGNCLGKDFDK.None)]
	private static void NAFFPAPIKOC(EPBOEGFMAOO OHJGEOICJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public LDIGDIFLCFB()
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
		[Cpp2IlInjected.Address(RVA = "0x6D90F10", Offset = "0x6D90310", VA = "0x186D90F10", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider DJHHDFHDNBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D913F0", Offset = "0x6D907F0", VA = "0x186D913F0")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
internal class MHLIHFMJJNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Dictionary<string, Dictionary<long, string>> BAPFECCJDJH;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA2EC30", Offset = "0xA2E030", VA = "0x180A2EC30")]
	public void LHICDLLELNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D90630", Offset = "0x6D8FA30", VA = "0x186D90630")]
	public CCKGNGCPCCF NDEOELJINEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xDA7860", Offset = "0xDA6C60", VA = "0x180DA7860")]
	public MHLIHFMJJNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D90400", Offset = "0x6D8F800", VA = "0x186D90400")]
	[CompilerGenerated]
	private void BNKNPIHEHOH(Dictionary<string, Dictionary<long, string>> PMFMEGBKHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D90510", Offset = "0x6D8F910", VA = "0x186D90510")]
	[CompilerGenerated]
	private void MBOALLCOHGO(string LIOFBOCKKOC)
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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6D92580", Offset = "0x6D91980", VA = "0x186D92580", Slot = "4")]
		public void Transform(Message HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IAFENIBFACK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class DECGCHFFEKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public DECGCHFFEKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E790", Offset = "0x6D8DB90", VA = "0x186D8E790")]
		internal bool EOONLBABGJD(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D8F540", Offset = "0x6D8E940", VA = "0x186D8F540")]
	public static List<Locale> FKGGGCOPCCK(this LocalizationSettings BHFHCNCPAIO, bool DPEGMCDPNMB = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D8F070", Offset = "0x6D8E470", VA = "0x186D8F070")]
	public static void EMNIJMCPBDG(Locale DGIEAIHBNAG, string OHGPDGIEKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D8F860", Offset = "0x6D8EC60", VA = "0x186D8F860")]
	public static Locale IDMPMHDHPID(this LocalizationSettings BHFHCNCPAIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D8EEB0", Offset = "0x6D8E2B0", VA = "0x186D8EEB0")]
	private static void BOOKJIGOKNH(string OBFDOLCLBME, string MFILHAEKEBL, string CANIEFMHGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FD80", Offset = "0x6D8F180", VA = "0x186D8FD80")]
	public static void KLDBJOCMOOA(this LocalizationSettings BHFHCNCPAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FD40", Offset = "0x6D8F140", VA = "0x186D8FD40")]
	public static Locale JBCEKLKFPEO(this LocalizationSettings BHFHCNCPAIO, string MCPMLIAOELF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FA60", Offset = "0x6D8EE60", VA = "0x186D8FA60")]
	public static Locale JBCEKLKFPEO(this ILocalesProvider OAFHBNBFBHG, string MCPMLIAOELF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D8F370", Offset = "0x6D8E770", VA = "0x186D8F370")]
	public static string FANKECMMJDA(this Locale DGIEAIHBNAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D8F000", Offset = "0x6D8E400", VA = "0x186D8F000")]
	public static string ELEJFBOIPPO(this Locale DGIEAIHBNAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D8F770", Offset = "0x6D8EB70", VA = "0x186D8F770")]
	public static string IBNNKPDPGGD(this CultureInfo AOLOJNLLIEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D8FE30", Offset = "0x6D8F230", VA = "0x186D8FE30")]
	public static string PAEINAAKAHB(this LocalizedString JANGJCKELPK, string KOFPKIJDAMC, object KKIAKNLLHIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D8EE60", Offset = "0x6D8E260", VA = "0x186D8EE60")]
	public static string BMGEIAFBEFL(this LocalizedString JANGJCKELPK, string GGMNJJDADOC)
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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
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
		private sealed class OAEPADFJMLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public OAEPADFJMLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6D909E0", Offset = "0x6D8FDE0", VA = "0x186D909E0")]
			internal void GBAMNAKGEGD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MHLIHFMJJNN retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D91700", Offset = "0x6D90B00", VA = "0x186D91700")]
		public static CCKGNGCPCCF BEFDPLAELIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D91940", Offset = "0x6D90D40", VA = "0x186D91940", Slot = "4")]
		public void PostprocessTable(LocalizationTable KNAHKANBIEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		private void ODBOKIKBLII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D92410", Offset = "0x6D91810", VA = "0x186D92410", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6D92490", Offset = "0x6D91890", VA = "0x186D92490")]
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
		private HNFFDGDJOBC _preferences;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6D91440", Offset = "0x6D90840", VA = "0x186D91440", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider DJHHDFHDNBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D916A0", Offset = "0x6D90AA0", VA = "0x186D916A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D8EAC0", Offset = "0x6D8DEC0", VA = "0x186D8EAC0")]
		public void BEFDPLAELIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8EB70", Offset = "0x6D8DF70", VA = "0x186D8EB70")]
		public void FBDDBFFKADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		private void EAHLHOMAPCO(StringTable ECLGPCGKEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8EC20", Offset = "0x6D8E020", VA = "0x186D8EC20")]
		public string KKJDNCGHJAA(string KOFPKIJDAMC, string GGMNJJDADOC = "", bool FDJKGAAPBBG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D901B0", Offset = "0x6D8F5B0", VA = "0x186D901B0")]
		public static LocalizedFontConfig LKIKEHGFEEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x992770", Offset = "0x991B70", VA = "0x180992770")]
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
