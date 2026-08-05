using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class NEJJEIKAKEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public NEJJEIKAKEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5BF6C80", Offset = "0x5BF6080", VA = "0x185BF6C80")]
			internal IEnumerable<MethodInfo> PCJCBICHMKH(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5BF6C20", Offset = "0x5BF6020", VA = "0x185BF6C20")]
			internal bool ACEGJKGLGGL(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class IFBFLGCIFLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public IFBFLGCIFLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5BF6B00", Offset = "0x5BF5F00", VA = "0x185BF6B00")]
			internal bool JPIKNLELGHE(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ALOAOLJKHMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public ALOAOLJKHMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5BF55B0", Offset = "0x5BF49B0", VA = "0x185BF55B0")]
			internal bool BJOCALEOMGL(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<MEEEIBLMBLE, IGrouping<MEEEIBLMBLE, MethodInfo>> KIOONMLNMME;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type NPEGHMNFFFD;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BF7F90", Offset = "0x5BF7390", VA = "0x185BF7F90")]
		private static void LFOJFALPMMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BF85C0", Offset = "0x5BF79C0", VA = "0x185BF85C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6E60", Offset = "0x5BF6260", VA = "0x185BF6E60")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6F50", Offset = "0x5BF6350", VA = "0x185BF6F50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6F00", Offset = "0x5BF6300", VA = "0x185BF6F00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6EB0", Offset = "0x5BF62B0", VA = "0x185BF6EB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5BF8500", Offset = "0x5BF7900", VA = "0x185BF8500")]
		private static void MIOFFNFAAAK(MEEEIBLMBLE BKKPDHGLGLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BF7820", Offset = "0x5BF6C20", VA = "0x185BF7820")]
		private static IEnumerable<MethodInfo> DJDJEDJOBKO(Type GDBPPKIKFHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6D40", Offset = "0x5BF6140", VA = "0x185BF6D40")]
		private static bool AAGPILOOOPJ(string GKDEICMIABL, [Out] Dictionary<string, List<string>> PNLHEEBEEPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5BF7030", Offset = "0x5BF6430", VA = "0x185BF7030")]
		private static IEnumerable<Type> CIODFHMCEKM(Dictionary<string, List<string>> PNLHEEBEEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5BF7740", Offset = "0x5BF6B40", VA = "0x185BF7740")]
		private static IEnumerable<MethodInfo> DAPBPIOHIBC(IEnumerable<Type> OKPOLIJIPHH, Type GDBPPKIKFHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6FA0", Offset = "0x5BF63A0", VA = "0x185BF6FA0")]
		internal static IEnumerable<MethodInfo> CFNCECAILOD(MEEEIBLMBLE BKKPDHGLGLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5BF7A70", Offset = "0x5BF6E70", VA = "0x185BF7A70")]
		internal static void JJNJKJBNOCP(IEnumerable<MethodInfo> EOKMAAJIOON, Type DEAEEEFBDLA, [Optional] object[] OJJNHGGGKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5BF78B0", Offset = "0x5BF6CB0", VA = "0x185BF78B0")]
		private static Dictionary<MEEEIBLMBLE, IGrouping<MEEEIBLMBLE, MethodInfo>> GCIGGKIBMIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5BF7950", Offset = "0x5BF6D50", VA = "0x185BF7950")]
		private static bool GMOFFHIEEPF(MethodInfo DIPOPGLLDPF, Type CBMIAIFOIAG, bool GDGJAPKHNLA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MKAAIGDIMBJ
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> IPDPJIABGMC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> KIGBPECCKNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6B60", Offset = "0x5BF5F60", VA = "0x185BF6B60")]
		get
		{
			return null;
		}
	}
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5BF8720", Offset = "0x5BF7B20", VA = "0x185BF8720")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EEHGHKKPAHJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct OKHGOFBOPGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo ODKJDEDJIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IIPPAMCLFBJ NCFIDPFADKC;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<HKDEIDHACLB, List<OKHGOFBOPGK>> GMMFBKNBOKE;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static BFGBHKPNKEI LCCLFGNLCPJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BFGBHKPNKEI OBHFMJJMPLN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static BFGBHKPNKEI JKEEEFNDKGB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BFGBHKPNKEI BFOGAKMAJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6630", Offset = "0x5BF5A30", VA = "0x185BF6630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BFGBHKPNKEI IKJLEABLMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6700", Offset = "0x5BF5B00", VA = "0x185BF6700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static BFGBHKPNKEI MLKHHDCMCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5C50", Offset = "0x5BF5050", VA = "0x185BF5C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5BA0", Offset = "0x5BF4FA0", VA = "0x185BF5BA0")]
	[KPPAHEDLIJC]
	private static void KJICBGPOMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6740", Offset = "0x5BF5B40", VA = "0x185BF6740")]
	[LADHGFOOMDP(MEEEIBLMBLE.Unity_AfterAssembliesLoaded)]
	private static void NFEOLADDIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5BF63F0", Offset = "0x5BF57F0", VA = "0x185BF63F0")]
	public static BFGBHKPNKEI IIEDFAIFNOJ(HKDEIDHACLB DHPKIAEHFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BF62B0", Offset = "0x5BF56B0", VA = "0x185BF62B0")]
	private static void IIEDFAIFNOJ(HKDEIDHACLB DHPKIAEHFBF, BFGBHKPNKEI FMGMKMDJHPG, BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5EC0", Offset = "0x5BF52C0", VA = "0x185BF5EC0")]
	private static void IIEDFAIFNOJ(HKDEIDHACLB DHPKIAEHFBF, BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BF69E0", Offset = "0x5BF5DE0", VA = "0x185BF69E0")]
	public static void OOJMECJOBCJ(HKDEIDHACLB DHPKIAEHFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7AD0", Offset = "0x3BC6ED0", VA = "0x183BC7AD0")]
	private static bool KFNFIJOABAB(IIPPAMCLFBJ KJJABNAGKIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5C90", Offset = "0x5BF5090", VA = "0x185BF5C90")]
	private static BFGBHKPNKEI GLLDEMPMFCB(string GJKFHMFCGHO, [Optional] BFGBHKPNKEI FMGMKMDJHPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BF6810", Offset = "0x5BF5C10", VA = "0x185BF6810")]
	private static void OOJMECJOBCJ(BFGBHKPNKEI MIPCMNILFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5BA0", Offset = "0x5BF4FA0", VA = "0x185BF5BA0")]
	private static void CEFODPAHLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5600", Offset = "0x5BF4A00", VA = "0x185BF5600")]
	private static IEnumerable<OKHGOFBOPGK> BDELDKPLMHE(HKDEIDHACLB DHPKIAEHFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5BF5E00", Offset = "0x5BF5200", VA = "0x185BF5E00")]
	private static BFGBHKPNKEI HDBCFGHDPPF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HCAAPHLNEMH<T> : IDisposable where T : HCAAPHLNEMH<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T CLFOAALEFAI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T OMCMBELJBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x34FF560", Offset = "0x34FE960", VA = "0x1834FF560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
	protected HCAAPHLNEMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x34FF820", Offset = "0x34FEC20", VA = "0x1834FF820", Slot = "5")]
	public virtual void Dispose()
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
