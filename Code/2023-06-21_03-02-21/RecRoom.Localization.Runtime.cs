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
public class CMBJLBEKIPK<TAttr, TType> : Exception where TAttr : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4A48D90", Offset = "0x4A47F90", VA = "0x184A48D90")]
	public CMBJLBEKIPK()
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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public LocaleDisplayName()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AAPADNOKFAM
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class PDODGFLNPKI<T> : IAsyncStateMachine where T : Enum
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
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public PDODGFLNPKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3595490", Offset = "0x3594690", VA = "0x183595490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class BAJGEKGMLFE<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public bool isCacheable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public (Type type, string name) cacheKey;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public BAJGEKGMLFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x59F2170", Offset = "0x59F1370", VA = "0x1859F2170")]
		internal void FHCPHGMPODI(AsyncOperationHandle<string> result)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly Dictionary<(Type, string), string> LDHDKAMOPNC;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Dictionary<Type, string> JBACMPFGGJD;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2AF0", Offset = "0x2AE1CF0", VA = "0x182AE2AF0")]
	private static string FIJNMIEJDDL<T>() where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x14B50D0", Offset = "0x14B42D0", VA = "0x1814B50D0")]
	private static bool JEDGJMCNGJM((Type type, string name) CDBPJPHHEJC, out string FCLIDIHIDJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2F10", Offset = "0x2AE2110", VA = "0x182AE2F10")]
	public static string LEGALLOEDDJ<T>(this T PLDCKCJJIHJ, params object[] FFOHLJIOBKO) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3AE0", Offset = "0x2AE2CE0", VA = "0x182AE3AE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PDODGFLNPKI<>))]
	public static Task<string> PDJKCCHMBDF<T>(this T PLDCKCJJIHJ, params object[] FFOHLJIOBKO) where T : Enum
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2AE3070", Offset = "0x2AE2270", VA = "0x182AE3070")]
	private static AsyncOperationHandle<string> NEGOAOEDGMP<T>(T PLDCKCJJIHJ, params object[] FFOHLJIOBKO) where T : Enum
	{
		return default(AsyncOperationHandle<string>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x14B51D0", Offset = "0x14B43D0", VA = "0x1814B51D0")]
	static AAPADNOKFAM()
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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B7F80", Offset = "0x14B7180", VA = "0x1814B7F80", Slot = "4")]
		public override bool LIAIIAMIEFP(StringTableEntry CDBPJPHHEJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
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
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public LocalizationGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Preserve]
public class KKDKBBHKELP : HJGHHKMMJPM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string GKDENOEFIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x14B7CB0", Offset = "0x14B6EB0", VA = "0x1814B7CB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public string BPECMIAFJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14B7C40", Offset = "0x14B6E40", VA = "0x1814B7C40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public string NPAMCIJHHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x14B7AC0", Offset = "0x14B6CC0", VA = "0x1814B7AC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FEMICBMHCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x14B7BE0", Offset = "0x14B6DE0", VA = "0x1814B7BE0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CultureInfo IJMPJGNECEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x14B7EC0", Offset = "0x14B70C0", VA = "0x1814B7EC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x14B7970", Offset = "0x14B6B70", VA = "0x1814B7970", Slot = "9")]
	public string ADAKKFBAJIE(string PPNIGBBPGOI, string KNNPBPLICIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x14B7D20", Offset = "0x14B6F20", VA = "0x1814B7D20", Slot = "10")]
	public Task<string> KNCGGKNBPIH(string PPNIGBBPGOI, string KNNPBPLICIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x14B7AF0", Offset = "0x14B6CF0", VA = "0x1814B7AF0")]
	[MPKPGFJAEKF(MCJFPPEDLHH.Root, OJBJGAAILBP.None)]
	private static void BDIDELBNDKE(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public KKDKBBHKELP()
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
		[Cpp2IlInjected.Address(RVA = "0x14B7F00", Offset = "0x14B7100", VA = "0x1814B7F00")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x14B83B0", Offset = "0x14B75B0", VA = "0x1814B83B0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider PHKHCLEPGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x14B8890", Offset = "0x14B7A90", VA = "0x1814B8890")]
		public RRCommandLineLocaleSelector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
internal class BHHHAAMNLGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Dictionary<string, Dictionary<long, string>> DELHEHKDMBO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Dictionary<long, string> LOKIFJEIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x14B59A0", Offset = "0x14B4BA0", VA = "0x1814B59A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x10C0640", Offset = "0x10BF840", VA = "0x1810C0640")]
	public void BAICGEGPNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x14B53C0", Offset = "0x14B45C0", VA = "0x1814B53C0")]
	public OOPPNGPPPLE ANDJFHFGOFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xC7F8B0", Offset = "0xC7EAB0", VA = "0x180C7F8B0")]
	public BHHHAAMNLGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x14B5890", Offset = "0x14B4A90", VA = "0x1814B5890")]
	[CompilerGenerated]
	private void MEOLLOKPLJN(Dictionary<string, Dictionary<long, string>> MKMDIKHOKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x14B5770", Offset = "0x14B4970", VA = "0x1814B5770")]
	[CompilerGenerated]
	private void HCFJPNMIPOD(string MKPBIBAIDNM)
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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public RecNetStringsLocaleIdentifier()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Truncator : IPseudoLocalizationMethod
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x14B9BD0", Offset = "0x14B8DD0", VA = "0x1814B9BD0", Slot = "4")]
		public void Transform(Message CEOMJLPEFPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public Truncator()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GBGPMADDHJO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KIEJLGJAIMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public string codeOrName;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public KIEJLGJAIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x14B7930", Offset = "0x14B6B30", VA = "0x1814B7930")]
		internal bool IHDEPOPCFAE(Locale locale)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x14B6670", Offset = "0x14B5870", VA = "0x1814B6670")]
	public static void EGPMBAGLLPO(this LocalizationSettings OGEIODPOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x14B7700", Offset = "0x14B6900", VA = "0x1814B7700")]
	public static List<Locale> PBMEIOBMEKD(this LocalizationSettings OGEIODPOGIP, bool GAMBELHIFEC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x14B6980", Offset = "0x14B5B80", VA = "0x1814B6980")]
	public static void GNJKKLNAKKH(Locale AACNKIAGEMC, string BJCAMPNAGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x14B74F0", Offset = "0x14B66F0", VA = "0x1814B74F0")]
	public static Locale OPHBGGBDOGG(this LocalizationSettings OGEIODPOGIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14B73A0", Offset = "0x14B65A0", VA = "0x1814B73A0")]
	private static void OIFBKLCGDCP(string IMLCDMGHBJF, string DDAEFBOKHCH, string PHDPIMPEHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x14B63F0", Offset = "0x14B55F0", VA = "0x1814B63F0")]
	public static void CEOGBGIINAJ(this LocalizationSettings OGEIODPOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x14B6C80", Offset = "0x14B5E80", VA = "0x1814B6C80")]
	public static Locale GOBAJCGNKEH(this ILocalesProvider PJCENIGMDDE, string PCKMHBLNCII, bool GAMBELHIFEC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x14B7360", Offset = "0x14B6560", VA = "0x1814B7360")]
	public static Locale MMAGFHNPIJO(this LocalizationSettings OGEIODPOGIP, string IMLPPMDCCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x14B7080", Offset = "0x14B6280", VA = "0x1814B7080")]
	public static Locale MMAGFHNPIJO(this ILocalesProvider PJCENIGMDDE, string IMLPPMDCCPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x14B64A0", Offset = "0x14B56A0", VA = "0x1814B64A0")]
	public static string DKOHAJJGKLC(this Locale AACNKIAGEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x14B6910", Offset = "0x14B5B10", VA = "0x1814B6910")]
	public static string FCNIBMOMOOJ(this Locale AACNKIAGEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x14B66F0", Offset = "0x14B58F0", VA = "0x1814B66F0")]
	public static string EKMMCJKNEFB(this CultureInfo NGOJCANHEOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x14B67E0", Offset = "0x14B59E0", VA = "0x1814B67E0")]
	public static void EPPFLJOIAAP(this LocalizedString JMIICNFKEEJ, string PPNIGBBPGOI, string ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14B6EE0", Offset = "0x14B60E0", VA = "0x1814B6EE0")]
	public static string KCBDNELFCCD(this LocalizedString JMIICNFKEEJ, string PPNIGBBPGOI, object ACKOJNNBEBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x14B7030", Offset = "0x14B6230", VA = "0x1814B7030")]
	public static string KCHPBMDECKD(this LocalizedString JMIICNFKEEJ, string KBJLCLBJKEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x14B6050", Offset = "0x14B5250", VA = "0x1814B6050")]
	public static void BPBLEPKDIIG(this StringTableEntry CDBPJPHHEJC, string PHDPIMPEHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x14B6230", Offset = "0x14B5430", VA = "0x1814B6230")]
	public static void BPBLEPKDIIG(this SharedTableData.SharedTableEntry CDBPJPHHEJC, string PHDPIMPEHFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OGKFFDIFAPD
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class GCHBKNHCFLL
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public const string EFKEBMPLKLI = "Locale";

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public const string LDHCKPCAFGA = "language_changed";
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public const string GPEAGJOABFD = "Locale";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string AMJKLHKENGN = "LastSelectedLocale";
}
namespace RecRoom.Localization
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class LocalizationConstraint : IMetadata
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract bool LIAIIAMIEFP(StringTableEntry CDBPJPHHEJC);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
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
		private sealed class PGFACGEKOHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public RecNetLocalizationTableProcessor processor;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public PGFACGEKOHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x14B7FC0", Offset = "0x14B71C0", VA = "0x1814B7FC0")]
			internal void EBMCAJJMENN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private BHHHAAMNLGA retriever;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HashSet<LocalizationTable> queuedTables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private HashSet<LocalizationTable> modifiedTables;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x14B8BB0", Offset = "0x14B7DB0", VA = "0x1814B8BB0")]
		public static OOPPNGPPPLE OHLMLHJNBAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x14B8DF0", Offset = "0x14B7FF0", VA = "0x1814B8DF0", Slot = "4")]
		public void PostprocessTable(LocalizationTable EKLEEGLADPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70")]
		private void GDICLHIHANB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x14B98F0", Offset = "0x14B8AF0", VA = "0x1814B98F0", Slot = "5")]
		public void ResetState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x14B9970", Offset = "0x14B8B70", VA = "0x1814B9970")]
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
		private NMEPAPEIDNF _preferences;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x14B88E0", Offset = "0x14B7AE0", VA = "0x1814B88E0", Slot = "4")]
		public Locale GetStartupLocale(ILocalesProvider PHKHCLEPGIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x14B8B50", Offset = "0x14B7D50", VA = "0x1814B8B50")]
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
		[Cpp2IlInjected.Address(RVA = "0x14B5FA0", Offset = "0x14B51A0", VA = "0x1814B5FA0")]
		public void OHLMLHJNBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x14B5A60", Offset = "0x14B4C60", VA = "0x1814B5A60")]
		public void DEAHKEFKGBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
		private void GDFKMAEPCJC(StringTable KNNPBPLICIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x14B5B10", Offset = "0x14B4D10", VA = "0x1814B5B10")]
		public string EKEHBMKOEHK(string PPNIGBBPGOI, string KBJLCLBJKEG = "", bool OEBNJDFJMBE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x14B5D50", Offset = "0x14B4F50", VA = "0x1814B5D50")]
		public string EKEHBMKOEHK(string PPNIGBBPGOI, string KBJLCLBJKEG = "", bool OEBNJDFJMBE = false, params object[] FFOHLJIOBKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
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
			[Cpp2IlInjected.Address(RVA = "0x14B9B30", Offset = "0x14B8D30", VA = "0x1814B9B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x14B9A60", Offset = "0x14B8C60", VA = "0x1814B9A60")]
		public static bool PLLNGOBMPBN(string NGMCLNPINFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public SkippableKnownText()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[Metadata]
[Description]
public class GICGGGHIPFC : IMetadata
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public GICGGGHIPFC()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
