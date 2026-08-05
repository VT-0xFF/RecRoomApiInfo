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
public class CBLAKEGOJMG<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5980", Offset = "0x3AE4780", VA = "0x183AE5980")]
	public CBLAKEGOJMG()
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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public LocaleDisplayName()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FIDAKPPICMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class IAKCHBJKHID<T> : IAsyncStateMachine where T : Enum
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
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public IAKCHBJKHID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3661390", Offset = "0x3660190", VA = "0x183661390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class HPAHCOPKEIB<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public bool isCacheable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public (Type type, string name) cacheKey;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public HPAHCOPKEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7F70", Offset = "0x4EA6D70", VA = "0x184EA7F70")]
		internal void PDPOEDEDBFC(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Dictionary<(Type, string), string> JBNBLAPOOHB;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Dictionary<Type, string> GAPCIDKMKHF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23361B0", Offset = "0x2334FB0", VA = "0x1823361B0")]
	private static string EMMGOHKCENA<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x18399E0", Offset = "0x18387E0", VA = "0x1818399E0")]
	private static bool PCJJPMJKNCP((Type type, string name) DMAJMJFGPMP, out string FNEBKNAABGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23365D0", Offset = "0x23353D0", VA = "0x1823365D0")]
	public static string IDHFLOOOBNK<T>(this T KAPFFDGHCGG, params object[] DHGGALLJGGG) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2336730", Offset = "0x2335530", VA = "0x182336730")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IAKCHBJKHID<>))]
	public static Task<string> MIKIOOAJNPL<T>(this T KAPFFDGHCGG, params object[] DHGGALLJGGG) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x23368B0", Offset = "0x23356B0", VA = "0x1823368B0")]
	private static AsyncOperationHandle<string> NJIDBMBNONB<T>(T KAPFFDGHCGG, params object[] DHGGALLJGGG) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1839AE0", Offset = "0x18388E0", VA = "0x181839AE0")]
	static FIDAKPPICMJ()
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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x183AF40", Offset = "0x1839D40", VA = "0x18183AF40", Slot = "4")]
		public override bool HNOLCBAHNCD(StringTableEntry DMAJMJFGPMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Preserve]
public class LKIMLLKMHNF : NAALNNPEKLC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string BKCCENAEKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x183AC20", Offset = "0x1839A20", VA = "0x18183AC20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public string EMMNIFNJBCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x183AC90", Offset = "0x1839A90", VA = "0x18183AC90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string NMBIJKMOCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x183AD00", Offset = "0x1839B00", VA = "0x18183AD00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HINFAOLKLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x183ABC0", Offset = "0x18399C0", VA = "0x18183ABC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CultureInfo AALHGHJKPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x183AA40", Offset = "0x1839840", VA = "0x18183AA40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x183AA70", Offset = "0x1839870", VA = "0x18183AA70", Slot = "9")]
	public string EMHJICBPOLD(string LGKPJAJAOLI, string CMANLHJEGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x183AD30", Offset = "0x1839B30", VA = "0x18183AD30", Slot = "10")]
	public Task<string> PNMHNONMMAP(string LGKPJAJAOLI, string CMANLHJEGLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x183A950", Offset = "0x1839750", VA = "0x18183A950")]
	[GIEEOCCBBIJ(EMJNPDDLMAF.Root, PFHGMCKNAFN.None)]
	private static void BALEBCFJGHH(OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public LKIMLLKMHNF()
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
		[Cpp2IlInjected.Address(RVA = "0x183AEC0", Offset = "0x1839CC0", VA = "0x18183AEC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x183C830", Offset = "0x183B630", VA = "0x18183C830", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider CKKNGJHFFEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x183CD10", Offset = "0x183BB10", VA = "0x18183CD10")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
internal class GCGILBBKFBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Dictionary<string, Dictionary<long, string>> FAPOLKPFAOD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Dictionary<long, string> MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x183A660", Offset = "0x1839460", VA = "0x18183A660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x12E8170", Offset = "0x12E6F70", VA = "0x1812E8170")]
	public void BNDICIAMFDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x183A2C0", Offset = "0x18390C0", VA = "0x18183A2C0")]
	public NONMCJIBNII BLBDCKDLBFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xD6EBA0", Offset = "0xD6D9A0", VA = "0x180D6EBA0")]
	public GCGILBBKFBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x183A840", Offset = "0x1839640", VA = "0x18183A840")]
	[CompilerGenerated]
	private void OFNOMCBJEIH(Dictionary<string, Dictionary<long, string>> FFJOOBKFJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x183A720", Offset = "0x1839520", VA = "0x18183A720")]
	[CompilerGenerated]
	private void LMCFGPAAAOG(string PAAKDHAMJAA)
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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x183E020", Offset = "0x183CE20", VA = "0x18183E020", Slot = "4")]
		public void Transform(Message CAJMIGKHKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NHGMMEGHEHP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class CJKEIIJNBMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public CJKEIIJNBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x18395C0", Offset = "0x18383C0", VA = "0x1818395C0")]
		internal bool BHPJBCOKCCF(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x183B280", Offset = "0x183A080", VA = "0x18183B280")]
	public static void DGOJAEJGDAF(this LocalizationSettings OAHFBIINMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x183B2F0", Offset = "0x183A0F0", VA = "0x18183B2F0")]
	public static List<Locale> EPEGHGHOKOE(this LocalizationSettings OAHFBIINMJB, bool KACOHHDCPFJ = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x183AF80", Offset = "0x1839D80", VA = "0x18183AF80")]
	public static void DFEMFAACJEJ(Locale AAOEOILEOGG, string NPKKDNICGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x183B870", Offset = "0x183A670", VA = "0x18183B870")]
	public static Locale GEPHEPHCCJK(this LocalizationSettings OAHFBIINMJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x183C6E0", Offset = "0x183B4E0", VA = "0x18183C6E0")]
	private static void OKADHMLMOGP(string BELJPMLNIGN, string NOLEFNCEFON, string KGDHPOJLMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x183B510", Offset = "0x183A310", VA = "0x18183B510")]
	public static void FDLHFKOFAHF(this LocalizationSettings OAHFBIINMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x183B610", Offset = "0x183A410", VA = "0x18183B610")]
	public static Locale FJBIMDNJJAI(this ILocalesProvider IOMELMCKHGA, string PPPOJKMOIGD, bool KACOHHDCPFJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x183BA80", Offset = "0x183A880", VA = "0x18183BA80")]
	public static Locale HDFMFFNAGID(this LocalizationSettings OAHFBIINMJB, string MIHHODBCPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x183BAC0", Offset = "0x183A8C0", VA = "0x18183BAC0")]
	public static Locale HDFMFFNAGID(this ILocalesProvider IOMELMCKHGA, string MIHHODBCPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x183BE10", Offset = "0x183AC10", VA = "0x18183BE10")]
	public static string KIJBFPELHLA(this Locale AAOEOILEOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x183BDA0", Offset = "0x183ABA0", VA = "0x18183BDA0")]
	public static string IPGCMBAAANO(this Locale AAOEOILEOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x183C4A0", Offset = "0x183B2A0", VA = "0x18183C4A0")]
	public static string LPLHCNCEBCK(this CultureInfo KCANMJOGDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x183C370", Offset = "0x183B170", VA = "0x18183C370")]
	public static void LHCFOEAEKKB(this LocalizedString CCIJMIHLABI, string LGKPJAJAOLI, string KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x183C590", Offset = "0x183B390", VA = "0x18183C590")]
	public static string MGDAJHOICPC(this LocalizedString CCIJMIHLABI, string LGKPJAJAOLI, object KKLNCEHOHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x183B5C0", Offset = "0x183A3C0", VA = "0x18183B5C0")]
	public static string FHADIPHDBHI(this LocalizedString CCIJMIHLABI, string GNNNMKNOKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x183BFD0", Offset = "0x183ADD0", VA = "0x18183BFD0")]
	public static void LEALDLKFPJM(this StringTableEntry DMAJMJFGPMP, string KGDHPOJLMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x183C1B0", Offset = "0x183AFB0", VA = "0x18183C1B0")]
	public static void LEALDLKFPJM(this SharedTableData.SharedTableEntry DMAJMJFGPMP, string KGDHPOJLMNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class HHNGAEGPMHK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class OAKJDEBLJJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public const string ODGGGOIDCAN = "Locale";

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public const string KMIJNHFLCGD = "language_changed";
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public const string PPMCPDMLKDJ = "Locale";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string PKJMAOJEHFK = "LastSelectedLocale";
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool HNOLCBAHNCD(StringTableEntry DMAJMJFGPMP);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
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
		private sealed class DGJMIJCEAPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public DGJMIJCEAPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1839600", Offset = "0x1838400", VA = "0x181839600")]
			internal void ONDLJKAAGAH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GCGILBBKFBP retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x183D030", Offset = "0x183BE30", VA = "0x18183D030")]
		public static NONMCJIBNII HFKECJNCAPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x183D270", Offset = "0x183C070", VA = "0x18183D270", Slot = "4")]
		public void PostprocessTable(LocalizationTable LHOAFLMNGJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0")]
		private void NOLEGHMKEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x183DD40", Offset = "0x183CB40", VA = "0x18183DD40", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x183DDC0", Offset = "0x183CBC0", VA = "0x18183DDC0")]
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
		private DHHONCAICPN _preferences;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x183CD60", Offset = "0x183BB60", VA = "0x18183CD60", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider CKKNGJHFFEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x183CFD0", Offset = "0x183BDD0", VA = "0x18183CFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1839CD0", Offset = "0x1838AD0", VA = "0x181839CD0")]
		public void HFKECJNCAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1839D80", Offset = "0x1838B80", VA = "0x181839D80")]
		public void MBKJDOLMADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0")]
		private void GAKHENOLGKI(StringTable CMANLHJEGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x183A080", Offset = "0x1838E80", VA = "0x18183A080")]
		public string NMGDNFOGJJD(string LGKPJAJAOLI, string GNNNMKNOKHD = "", bool EKFPDHJKIFI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1839E30", Offset = "0x1838C30", VA = "0x181839E30")]
		public string NMGDNFOGJJD(string LGKPJAJAOLI, string GNNNMKNOKHD = "", bool EKFPDHJKIFI = false, params object[] DHGGALLJGGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x183DF80", Offset = "0x183CD80", VA = "0x18183DF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x183DEB0", Offset = "0x183CCB0", VA = "0x18183DEB0")]
		public static bool BBJPLADBJND(string MAGABHMDKJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public SkippableKnownText()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Metadata]
[Description]
public class LOGBLMONPGC : IMetadata
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public LOGBLMONPGC()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
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
