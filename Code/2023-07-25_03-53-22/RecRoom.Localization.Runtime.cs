using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
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
public class NFFMPCBJIFF<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x242BB90", Offset = "0x242AB90", VA = "0x18242BB90")]
	public NFFMPCBJIFF()
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
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LocaleDisplayName()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FCAHKHGJOIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BKEMKMJFOGG<T> : IAsyncStateMachine where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public AsyncTaskMethodBuilder<string> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public T enumValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public object[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private string <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public BKEMKMJFOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x23BD080", Offset = "0x23BC080", VA = "0x1823BD080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class IGAPPEHAPGB<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public bool isCacheable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public (Type type, string name) cacheKey;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public IGAPPEHAPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1587620", Offset = "0x1586620", VA = "0x181587620")]
		internal void MNEFMLDKFDJ(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Dictionary<(Type, string), string> FEGMANHEINF;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Dictionary<Type, string> ICJLGJPMGED;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1A6D520", Offset = "0x1A6C520", VA = "0x181A6D520")]
	private static string KEKHAADKIMK<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x70963F0", Offset = "0x70953F0", VA = "0x1870963F0")]
	private static bool CCJGJEMBLJF((Type type, string name) GPLBPEBFHNJ, out string KJIGGHJJMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A6E3B0", Offset = "0x1A6D3B0", VA = "0x181A6E3B0")]
	public static string NNBEMCJHDFH<T>(this T NICLHEEPPOH, params object[] JDOENIAEDAE) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1A6D3A0", Offset = "0x1A6C3A0", VA = "0x181A6D3A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BKEMKMJFOGG<>))]
	public static Task<string> IAFIKKBGFKD<T>(this T NICLHEEPPOH, params object[] JDOENIAEDAE) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1A6D940", Offset = "0x1A6C940", VA = "0x181A6D940")]
	private static AsyncOperationHandle<string> MBCMBMIMGHH<T>(T NICLHEEPPOH, params object[] JDOENIAEDAE) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70964F0", Offset = "0x70954F0", VA = "0x1870964F0")]
	static FCAHKHGJOIJ()
	{
	}
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class LocalizedFontManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class FEMMKNDIMDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TMP_FontAsset fallbackFontAddressables;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public TMP_FontAsset fallbackFontPlayerBuild;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public FEMMKNDIMDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x70966E0", Offset = "0x70956E0", VA = "0x1870966E0")]
			internal void GAEMAMGGJMF(TMP_FontAsset font)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class CEIJJAIFGAG : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LocalizedFontManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private FEMMKNDIMDG <>8__1;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
			[DebuggerHidden]
			public CEIJJAIFGAG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7095DF0", Offset = "0x7094DF0", VA = "0x187095DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x70963B0", Offset = "0x70953B0", VA = "0x1870963B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private AsyncOperationHandle<TMP_FontAsset> NKJACLLOHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private AsyncOperationHandle<IList<TMP_FontAsset>> IOGFPJJGGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LocalizedFontConfig LCFBHAKNLEG;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const string MNLNBPKGNKC = "RR Tools/Localization/Fonts/";

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string IHAAIJOIJNG = "RR Tools/Localization/Fonts/Connect Localized Fonts (Editor Time)";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string MENU_PATH_CLEAR = "RR Tools/Localization/Fonts/Clear Localized Fonts";

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7098F00", Offset = "0x7097F00", VA = "0x187098F00")]
		[IteratorStateMachine(typeof(CEIJJAIFGAG))]
		public IEnumerator Start()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7098D70", Offset = "0x7097D70", VA = "0x187098D70")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public LocalizedFontManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Metadata]
	[Description]
	public class ExcludeFromLanguagePicker : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ExcludeFromLanguagePicker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Metadata]
	public class MaximumLengthConstraint : LocalizationConstraint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int length;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7099A00", Offset = "0x7098A00", VA = "0x187099A00", Slot = "4")]
		public override bool KMLJOGJGJCL(StringTableEntry GPLBPEBFHNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MaximumLengthConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Metadata]
	[Description]
	public class RecNetLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public RecNetLocaleIdentifier()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class LocalizationGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Preserve]
public class HHDEPMLOJKF : NAGBHFDHKMA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string FIGOLABFLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7096E90", Offset = "0x7095E90", VA = "0x187096E90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string DIIMFIINIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70971C0", Offset = "0x70961C0", VA = "0x1870971C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string EMLMBDMLNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7097190", Offset = "0x7096190", VA = "0x187097190", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KDPDDCAOBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7097230", Offset = "0x7096230", VA = "0x187097230", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CultureInfo AMLFAGNMNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7096E50", Offset = "0x7095E50", VA = "0x187096E50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7097290", Offset = "0x7096290", VA = "0x187097290", Slot = "9")]
	public string OOJMDJHINCA(string LOHIKDGDMPP, string CCOIHBNGNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7096FF0", Offset = "0x7095FF0", VA = "0x187096FF0", Slot = "10")]
	public Task<string> HPFEKJELEJP(string LOHIKDGDMPP, string CCOIHBNGNMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7096F00", Offset = "0x7095F00", VA = "0x187096F00")]
	[FBCFLFBFGIL(MELNECENNOL.Root, LAFFCBAHJKM.None)]
	private static void HEBPGFNGBNI(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public HHDEPMLOJKF()
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Metadata]
	[Description]
	public class LocalizationSource : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public List<string> sources;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7098CA0", Offset = "0x7097CA0", VA = "0x187098CA0")]
		public LocalizationSource()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[System.ComponentModel.DisplayName]
	public class RRCommandLineLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private string commandLineArgumentPrefix;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string CommandLineArgument
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7099A40", Offset = "0x7098A40", VA = "0x187099A40", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider CADIHLNJEOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7099F20", Offset = "0x7098F20", VA = "0x187099F20")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
internal class MEAJEIHECDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<string, Dictionary<long, string>> AAAFAMDCHEE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Dictionary<long, string> CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7098F70", Offset = "0x7097F70", VA = "0x187098F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA8F430", Offset = "0xA8E430", VA = "0x180A8F430")]
	public void FDNJPBAKNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7099260", Offset = "0x7098260", VA = "0x187099260")]
	public GAEMIFNLIHB PDPDHHJAMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xA24460", Offset = "0xA23460", VA = "0x180A24460")]
	public MEAJEIHECDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7099030", Offset = "0x7098030", VA = "0x187099030")]
	[CompilerGenerated]
	private void MEEKDELFEHG(Dictionary<string, Dictionary<long, string>> AIHNJOAEGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7099140", Offset = "0x7098140", VA = "0x187099140")]
	[CompilerGenerated]
	private void PCMBIKPMPEH(string OBCOBGBCLOG)
	{
	}
}
namespace RecRoom.Localization
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Metadata]
	[Description]
	public class RecNetStringsLocaleIdentifier : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public string identifier;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x709B220", Offset = "0x709A220", VA = "0x18709B220", Slot = "4")]
		public void Transform(Message HJJLMCEMDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KOJCHODCNBM
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ANPOKNJKCPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public ANPOKNJKCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7095DB0", Offset = "0x7094DB0", VA = "0x187095DB0")]
		internal bool NFDEBAABFBK(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7098330", Offset = "0x7097330", VA = "0x187098330")]
	public static void LKGEFNGJMDK(this LocalizationSettings GGPFDHMAKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7098100", Offset = "0x7097100", VA = "0x187098100")]
	public static List<Locale> KJBLPBCKAII(this LocalizationSettings GGPFDHMAKNG, bool NIKEFDHJHJL = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7097E00", Offset = "0x7096E00", VA = "0x187097E00")]
	public static void JNADBNOCJEE(Locale DCAEMOGJALF, string OAHEFHJKOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7097850", Offset = "0x7096850", VA = "0x187097850")]
	public static Locale FOFHOHLMIAJ(this LocalizationSettings GGPFDHMAKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70975C0", Offset = "0x70965C0", VA = "0x1870975C0")]
	private static void CGNMODOBPOF(string KOPIKKMPAOB, string GGIFDLNELAM, string LPNPMOOMCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7097510", Offset = "0x7096510", VA = "0x187097510")]
	public static void CFBGLIAILGF(this LocalizationSettings GGPFDHMAKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7097A50", Offset = "0x7096A50", VA = "0x187097A50")]
	public static Locale GJKDLLIBCHO(this ILocalesProvider GMNEGCALHOD, string OALFIBFPPAC, bool NIKEFDHJHJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7098A20", Offset = "0x7097A20", VA = "0x187098A20")]
	public static Locale MOLIDKGMLLN(this LocalizationSettings GGPFDHMAKNG, string IJABBNGLMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7098740", Offset = "0x7097740", VA = "0x187098740")]
	public static Locale MOLIDKGMLLN(this ILocalesProvider GMNEGCALHOD, string IJABBNGLMKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7098A60", Offset = "0x7097A60", VA = "0x187098A60")]
	public static string NALFAJJGPPF(this Locale DCAEMOGJALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7098C30", Offset = "0x7097C30", VA = "0x187098C30")]
	public static string NLDLEDLJLNL(this Locale DCAEMOGJALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7097760", Offset = "0x7096760", VA = "0x187097760")]
	public static string FIDNLELLLOL(this CultureInfo KEDEGCEAOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x70973E0", Offset = "0x70963E0", VA = "0x1870973E0")]
	public static void BGNHCEJCPLN(this LocalizedString FHKAFCEPMGC, string LOHIKDGDMPP, string CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7097CB0", Offset = "0x7096CB0", VA = "0x187097CB0")]
	public static string ILOAPAKHAHC(this LocalizedString FHKAFCEPMGC, string LOHIKDGDMPP, object CKDFGEALFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7097710", Offset = "0x7096710", VA = "0x187097710")]
	public static string EDLAPAPBKKD(this LocalizedString FHKAFCEPMGC, string BLHCIOPDMBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7098560", Offset = "0x7097560", VA = "0x187098560")]
	public static void LNOPBCGNEPH(this StringTableEntry GPLBPEBFHNJ, string LPNPMOOMCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x70983B0", Offset = "0x70973B0", VA = "0x1870983B0")]
	public static void LNOPBCGNEPH(this SharedTableData.SharedTableEntry GPLBPEBFHNJ, string LPNPMOOMCIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GMJMOFICJOE
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class LMLICODIAKK
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public const string FGOPKEEMNFM = "Locale";

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public const string NBOOHELOPNJ = "language_changed";
	}

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public const string GDCLKKADIAF = "Locale";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const string IHNGDIPJLEI = "LastSelectedLocale";
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool KMLJOGJGJCL(StringTableEntry GPLBPEBFHNJ);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		protected LocalizationConstraint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RecNetLocalizationTableProcessor : ITablePostprocessor, IReset
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MFDGIOJKEID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public MFDGIOJKEID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7099610", Offset = "0x7098610", VA = "0x187099610")]
			internal void MDANKOIHGPA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private MEAJEIHECDH retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x709A230", Offset = "0x7099230", VA = "0x18709A230")]
		public static GAEMIFNLIHB LLEBBJIFEDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x709A470", Offset = "0x7099470", VA = "0x18709A470", Slot = "4")]
		public void PostprocessTable(LocalizationTable KHACGOBFGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
		private void OANDGPCDIBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x709AF40", Offset = "0x7099F40", VA = "0x18709AF40", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x709AFC0", Offset = "0x7099FC0", VA = "0x18709AFC0")]
		public RecNetLocalizationTableProcessor()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[System.ComponentModel.DisplayName]
	public class RRPlayerPrefLocaleSelector : IStartupLocaleSelector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("Should be the default code, but can be the default name as a fallback")]
		public LocaleIdentifier defaultLocaleIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("If no locale can be found, should fallback to the ProjectLocale?")]
		public bool fallbackToProjectLocale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private PCCHDNKCHLM _preferences;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7099F70", Offset = "0x7098F70", VA = "0x187099F70", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider CADIHLNJEOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x709A1D0", Offset = "0x70991D0", VA = "0x18709A1D0")]
		public RRPlayerPrefLocaleSelector()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class FallbackTableReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public LocalizedStringTable localizationTable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private StringTable loadedStringTable;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7096CA0", Offset = "0x7095CA0", VA = "0x187096CA0")]
		public void LLEBBJIFEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7096D50", Offset = "0x7095D50", VA = "0x187096D50")]
		public void PCLJFJKFDHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
		private void PMGFKGMPDFC(StringTable CCOIHBNGNMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7096820", Offset = "0x7095820", VA = "0x187096820")]
		public string IBFPABNOHGL(string LOHIKDGDMPP, string BLHCIOPDMBH = "", bool CGJPMMKJEHF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7096A60", Offset = "0x7095A60", VA = "0x187096A60")]
		public string IBFPABNOHGL(string LOHIKDGDMPP, string BLHCIOPDMBH = "", bool CGJPMMKJEHF = false, params object[] JDOENIAEDAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public FallbackTableReference()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Metadata]
	public class SkippableKnownText : IMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public List<string> skippableTexts;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static List<string> Strings
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x709B180", Offset = "0x709A180", VA = "0x18709B180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x709B0B0", Offset = "0x709A0B0", VA = "0x18709B0B0")]
		public static bool KAKGJPJGEDI(string IOEEMDDJCAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public SkippableKnownText()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class LocalizedFontConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public class FontAssetReference : AssetReferenceT<TMP_FontAsset>
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7096E00", Offset = "0x7095E00", VA = "0x187096E00")]
			public FontAssetReference(string PLBICILNGEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string SingletonResourceKey = "LocalizedFontConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("All of the actual CJK type fonts should go here")]
		public List<FontAssetReference> localizedFonts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("The font that will contain the fallback chain to CJK")]
		public TMP_FontAsset fallbackFontPlayerBuild;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("An addressable reference to the font that will contain the fallback chains to the CJK fonts")]
		public FontAssetReference fallbackFontAddressable;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7098D20", Offset = "0x7097D20", VA = "0x187098D20")]
		public static LocalizedFontConfig FFELJENILFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
		public LocalizedFontConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Metadata]
[Description]
public class EGLKCHLBCLG : IMetadata
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public EGLKCHLBCLG()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
