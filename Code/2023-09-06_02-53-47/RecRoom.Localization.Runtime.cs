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
public class FBLKOOLBJGL<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x49D40B0", Offset = "0x49D26B0", VA = "0x1849D40B0")]
	public FBLKOOLBJGL()
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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public LocaleDisplayName()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BPLIBBKDODM
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class FKLDEOICCNN<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public T enumValue;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public FKLDEOICCNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x31BFB80", Offset = "0x31BE180", VA = "0x1831BFB80")]
		internal void KDMDMLMGIPA(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Dictionary<(Type, string), string> LNLPGEFNJMP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Dictionary<Type, string> KKKCJJLKMLG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x35A5EF0", Offset = "0x35A44F0", VA = "0x1835A5EF0")]
	private static string GMEBAKGGKAM<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6DDAE50", Offset = "0x6DD9450", VA = "0x186DDAE50")]
	private static bool APEEHDDFNFJ((Type type, string name) BAPBNBONCKI, out string KFAPMEBEBJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x35A57C0", Offset = "0x35A3DC0", VA = "0x1835A57C0")]
	public static string AGAHKHDBEPP<T>(this T KEFANKKKDEM, params object[] MOPLBNNHBOM) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35A59E0", Offset = "0x35A3FE0", VA = "0x1835A59E0")]
	private static bool BOICGAIEIBM<T>(out string MOLEJFDINLH, T KEFANKKKDEM, params object[] MOPLBNNHBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x35A51C0", Offset = "0x35A37C0", VA = "0x1835A51C0")]
	private static AsyncOperationHandle<string> ACNGGFJNCBO<T>(T KEFANKKKDEM, params object[] MOPLBNNHBOM) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6DDAF50", Offset = "0x6DD9550", VA = "0x186DDAF50")]
	static BPLIBBKDODM()
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
		private sealed class CPNOCAPFPEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public TMP_FontAsset fallbackFontAddressables;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public TMP_FontAsset fallbackFontPlayerBuild;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public CPNOCAPFPEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6DDB140", Offset = "0x6DD9740", VA = "0x186DDB140")]
			internal void HJICCBLOKNC(TMP_FontAsset font)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PGEBCNDLGFF : IEnumerator<object>, IEnumerator, IDisposable
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
			private CPNOCAPFPEM <>8__1;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
			[DebuggerHidden]
			public PGEBCNDLGFF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6DDD3A0", Offset = "0x6DDB9A0", VA = "0x186DDD3A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6DDD960", Offset = "0x6DDBF60", VA = "0x186DDD960", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private AsyncOperationHandle<TMP_FontAsset> DKLMKJBPNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private AsyncOperationHandle<IList<TMP_FontAsset>> PHMCAEMJFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private LocalizedFontConfig GCGOLIKBAAL;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private const string DBPCCGDJLHA = "RR Tools/Localization/Fonts/";

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const string IGBPGOPJKIJ = "RR Tools/Localization/Fonts/Connect Localized Fonts (Editor Time)";

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public const string MENU_PATH_CLEAR = "RR Tools/Localization/Fonts/Clear Localized Fonts";

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DDD330", Offset = "0x6DDB930", VA = "0x186DDD330")]
		[IteratorStateMachine(typeof(PGEBCNDLGFF))]
		public IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DDD1A0", Offset = "0x6DDB7A0", VA = "0x186DDD1A0")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Preserve]
public class AFGKKPNPMGF : GHCKLEFINDF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string DMNLABGHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DDAC20", Offset = "0x6DD9220", VA = "0x186DDAC20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string OFKOHDOKPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DDADE0", Offset = "0x6DD93E0", VA = "0x186DDADE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HOINMLKPGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6DDAC90", Offset = "0x6DD9290", VA = "0x186DDAC90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DDACF0", Offset = "0x6DD92F0", VA = "0x186DDACF0")]
	[HFALCAKMDCP(DGHGCOPCCJK.Root, BFPOMPMIJIJ.None)]
	private static void KDCCKDGHAKL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public AFGKKPNPMGF()
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
		[Cpp2IlInjected.Address(RVA = "0x6DDD9A0", Offset = "0x6DDBFA0", VA = "0x186DDD9A0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider GMMIAGKEKGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6DDDE80", Offset = "0x6DDC480", VA = "0x186DDDE80")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
internal class ILPIIBNBMKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Dictionary<string, Dictionary<long, string>> DPIJLEFBLOB;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC0B550", Offset = "0xC09B50", VA = "0x180C0B550")]
	public void OMPIDGEJBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DDBA50", Offset = "0x6DDA050", VA = "0x186DDBA50")]
	public HHGLIBCDIDA AAFIACOJNDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xC286B0", Offset = "0xC26CB0", VA = "0x180C286B0")]
	public ILPIIBNBMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DDBE00", Offset = "0x6DDA400", VA = "0x186DDBE00")]
	[CompilerGenerated]
	private void LGOILFGJMNC(Dictionary<string, Dictionary<long, string>> DLLEIILINAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DDBF10", Offset = "0x6DDA510", VA = "0x186DDBF10")]
	[CompilerGenerated]
	private void OGOAHELHAOI(string NGKEJFEICEP)
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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6DDF010", Offset = "0x6DDD610", VA = "0x186DDF010", Slot = "4")]
		public void Transform(Message DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JBLMDLKBJAM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class IAICOAGDLHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IAICOAGDLHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6DDBA10", Offset = "0x6DDA010", VA = "0x186DDBA10")]
		internal bool LFHFNBFAAAN(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DDC350", Offset = "0x6DDA950", VA = "0x186DDC350")]
	public static List<Locale> AINAHJEKKLK(this LocalizationSettings FGIOGJGPMCI, bool NFJFMPIIGAD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DDCD30", Offset = "0x6DDB330", VA = "0x186DDCD30")]
	public static void NBBEMJDGECO(Locale JBMIHCLHGDI, string KFABAPPNBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DDC580", Offset = "0x6DDAB80", VA = "0x186DDC580")]
	public static Locale BLMLDDLEPCK(this LocalizationSettings FGIOGJGPMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DDC780", Offset = "0x6DDAD80", VA = "0x186DDC780")]
	private static void CDCJNKPNHHC(string KOBCDHKCIEI, string PIPBOGEDGDN, string PAKFOBAPADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DDD0A0", Offset = "0x6DDB6A0", VA = "0x186DDD0A0")]
	public static void PDILJMIGJGJ(this LocalizationSettings FGIOGJGPMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DDC310", Offset = "0x6DDA910", VA = "0x186DDC310")]
	public static Locale AFDPJLAAKCI(this LocalizationSettings FGIOGJGPMCI, string AOLDOIAEDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DDC030", Offset = "0x6DDA630", VA = "0x186DDC030")]
	public static Locale AFDPJLAAKCI(this ILocalesProvider HINHIGGCLIA, string AOLDOIAEDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DDCB10", Offset = "0x6DDB110", VA = "0x186DDCB10")]
	public static string GIFBIHHJDID(this Locale JBMIHCLHGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DDD030", Offset = "0x6DDB630", VA = "0x186DDD030")]
	public static string NCPNEOLKJAL(this Locale JBMIHCLHGDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6DDC8D0", Offset = "0x6DDAED0", VA = "0x186DDC8D0")]
	public static string DONEIHDJJPK(this CultureInfo HGLKNODKEHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DDC9C0", Offset = "0x6DDAFC0", VA = "0x186DDC9C0")]
	public static string EJNJJILBCMI(this LocalizedString MLOGFOELHAO, string BOMEFJIOGGM, object MOLEJFDINLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DDCCE0", Offset = "0x6DDB2E0", VA = "0x186DDCCE0")]
	public static string HDKGJKBBGJG(this LocalizedString MLOGFOELHAO, string JPILKGGBKAF)
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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
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
		private sealed class DOBLKGHMEIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
			public DOBLKGHMEIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6DDB280", Offset = "0x6DD9880", VA = "0x186DDB280")]
			internal void IDDOELEGIFB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ILPIIBNBMKG retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE190", Offset = "0x6DDC790", VA = "0x186DDE190")]
		public static HHGLIBCDIDA GMAKAKECEDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE3D0", Offset = "0x6DDC9D0", VA = "0x186DDE3D0", Slot = "4")]
		public void PostprocessTable(LocalizationTable EDKKGDIMOHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		private void CAKKECNIOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6DDEEA0", Offset = "0x6DDD4A0", VA = "0x186DDEEA0", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6DDEF20", Offset = "0x6DDD520", VA = "0x186DDEF20")]
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
		private OEDCEGNGFJP _preferences;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DDDED0", Offset = "0x6DDC4D0", VA = "0x186DDDED0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider GMMIAGKEKGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE130", Offset = "0x6DDC730", VA = "0x186DDE130")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DDB720", Offset = "0x6DD9D20", VA = "0x186DDB720")]
		public void GMAKAKECEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB670", Offset = "0x6DD9C70", VA = "0x186DDB670")]
		public void AFFJDJOCMDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		private void PFIMENFBAHK(StringTable MEGKOINPICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6DDB7D0", Offset = "0x6DD9DD0", VA = "0x186DDB7D0")]
		public string LBEDADAPHMH(string BOMEFJIOGGM, string JPILKGGBKAF = "", bool BILPDCGHAAG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DDD150", Offset = "0x6DDB750", VA = "0x186DDD150")]
		public static LocalizedFontConfig EKMNNAAHKGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9341D0", Offset = "0x9327D0", VA = "0x1809341D0")]
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
