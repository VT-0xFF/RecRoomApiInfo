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
		private sealed class PDHELNLMLEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public PDHELNLMLEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x65CC950", Offset = "0x65CB750", VA = "0x1865CC950")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x65CCA20", Offset = "0x65CB820", VA = "0x1865CCA20")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class PNIBFAAHAGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public PNIBFAAHAGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x65CCAE0", Offset = "0x65CB8E0", VA = "0x1865CCAE0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class PHMKBKFMGMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public PHMKBKFMGMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x65CCA90", Offset = "0x65CB890", VA = "0x1865CCA90")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string IHBHDKHMEJO = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string LJNCFADKBFB = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<NIJEKHCIIFG, IGrouping<NIJEKHCIIFG, MethodInfo>> KKCMEJGGNJB;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type CPDJAALHIDF;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x65CD8A0", Offset = "0x65CC6A0", VA = "0x1865CD8A0")]
		private static void IGFOEDFNJLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x65CE5B0", Offset = "0x65CD3B0", VA = "0x1865CE5B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x65CCB50", Offset = "0x65CB950", VA = "0x1865CCB50")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x65CD580", Offset = "0x65CC380", VA = "0x1865CD580")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x65CD530", Offset = "0x65CC330", VA = "0x1865CD530")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x65CCBA0", Offset = "0x65CB9A0", VA = "0x1865CCBA0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65CD5D0", Offset = "0x65CC3D0", VA = "0x1865CD5D0")]
		private static void GENBFAADONA(NIJEKHCIIFG BAFCGNDKPGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x65CDE90", Offset = "0x65CCC90", VA = "0x1865CDE90")]
		private static IEnumerable<MethodInfo> KBDIDDIFCFG(Type EILENIJELND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x65CD370", Offset = "0x65CC170", VA = "0x1865CD370")]
		private static bool BNIGIICOCLL(string NDLHJNAOGAA, out Dictionary<string, List<string>> IEOBHFCJPJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x65CCBF0", Offset = "0x65CB9F0", VA = "0x1865CCBF0")]
		private static IEnumerable<Type> BCHOCOODIKM(Dictionary<string, List<string>> IEOBHFCJPJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x65CD7C0", Offset = "0x65CC5C0", VA = "0x1865CD7C0")]
		private static IEnumerable<MethodInfo> IEDOIPECDLK(IEnumerable<Type> JGOGDIOCDNG, Type EILENIJELND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65CE460", Offset = "0x65CD260", VA = "0x1865CE460")]
		internal static IEnumerable<MethodInfo> NOEMPCCCNBN(NIJEKHCIIFG BAFCGNDKPGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65CDF50", Offset = "0x65CCD50", VA = "0x1865CDF50")]
		internal static void MEDFOCDMHOB(IEnumerable<MethodInfo> DIIGIKBLIGJ, Type HMICOJLGLDB, [Optional] object[] FGGPHJMDLJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65CE4F0", Offset = "0x65CD2F0", VA = "0x1865CE4F0")]
		private static Dictionary<NIJEKHCIIFG, IGrouping<NIJEKHCIIFG, MethodInfo>> OIDNDCCCFHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65CD6A0", Offset = "0x65CC4A0", VA = "0x1865CD6A0")]
		private static bool ICIHEIBKDFL(MethodInfo BHICEKNAPFA, Type EENBIBMEONP, bool KEKHNOICDLI)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65CE720", Offset = "0x65CD520", VA = "0x1865CE720")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NEEHCHAALAG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct APOLPKIDDEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo DMHIEPHOAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AIJEIIPHIJH BGEPMJMIAMK;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<LGHNOHBEMLG, List<APOLPKIDDEC>> AAMKCOMGOJP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static HKDBAIGILEN ICJMDPGBHJM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static HKDBAIGILEN GIJLFDMAHKD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static HKDBAIGILEN LAPHIEBLKLE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HKDBAIGILEN CAHHKGJGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x65CBD60", Offset = "0x65CAB60", VA = "0x1865CBD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HKDBAIGILEN CJHPMIKBGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65CBE90", Offset = "0x65CAC90", VA = "0x1865CBE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HKDBAIGILEN MEJEJBDOPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65CBE50", Offset = "0x65CAC50", VA = "0x1865CBE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65CBCB0", Offset = "0x65CAAB0", VA = "0x1865CBCB0")]
	[KLCOGBHNPHN]
	private static void JGKCECMGDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x65CBBC0", Offset = "0x65CA9C0", VA = "0x1865CBBC0")]
	[KOIFHKBOHLF(NIJEKHCIIFG.Unity_AfterAssembliesLoaded)]
	private static void INAJFBFCGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x65CC050", Offset = "0x65CAE50", VA = "0x1865CC050")]
	public static HKDBAIGILEN NNLPMHJLAIN(LGHNOHBEMLG FHANGPOPCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x65CC6D0", Offset = "0x65CB4D0", VA = "0x1865CC6D0")]
	private static void NNLPMHJLAIN(LGHNOHBEMLG FHANGPOPCKF, HKDBAIGILEN OEEJCDDHGBB, ref HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x65CC290", Offset = "0x65CB090", VA = "0x1865CC290")]
	private static void NNLPMHJLAIN(LGHNOHBEMLG FHANGPOPCKF, HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x65CB8A0", Offset = "0x65CA6A0", VA = "0x1865CB8A0")]
	public static void FDHJEMDJMBC(LGHNOHBEMLG FHANGPOPCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65CB230", Offset = "0x65CA030", VA = "0x1865CB230")]
	private static bool ALKILFHGMHG(AIJEIIPHIJH NLIABKMGBAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65CBED0", Offset = "0x65CACD0", VA = "0x1865CBED0")]
	private static HKDBAIGILEN KHLFPHLBOAJ(string IBKBJDDGNLG, [Optional] HKDBAIGILEN OEEJCDDHGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x65CB9B0", Offset = "0x65CA7B0", VA = "0x1865CB9B0")]
	private static void FDHJEMDJMBC(ref HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65CBCB0", Offset = "0x65CAAB0", VA = "0x1865CBCB0")]
	private static void OFOAILNLJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65CB310", Offset = "0x65CA110", VA = "0x1865CB310")]
	private static IEnumerable<APOLPKIDDEC> AMMCKIFHLIN(LGHNOHBEMLG FHANGPOPCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65CC860", Offset = "0x65CB660", VA = "0x1865CC860")]
	private static HKDBAIGILEN OMJGCBPLCMD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KFMDGGGMMDD<T> : IDisposable where T : global::KFMDGGGMMDD<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T JKPACBEDIJD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T PDNDNIMAPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x271F240", Offset = "0x271E040", VA = "0x18271F240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
	protected KFMDGGGMMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x271F4D0", Offset = "0x271E2D0", VA = "0x18271F4D0", Slot = "5")]
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
