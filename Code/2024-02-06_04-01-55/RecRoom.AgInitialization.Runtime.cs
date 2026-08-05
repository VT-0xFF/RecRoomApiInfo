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
		private sealed class PNPBIJDCKFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public PNPBIJDCKFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5F47490", Offset = "0x5F46890", VA = "0x185F47490")]
			internal IEnumerable<MethodInfo> KKBJLNIBGFO(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5F47550", Offset = "0x5F46950", VA = "0x185F47550")]
			internal bool KNPCAILCCNG(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class GHFFKELPLBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public GHFFKELPLBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5F47370", Offset = "0x5F46770", VA = "0x185F47370")]
			internal bool FICHBJBMENJ(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class GAJGIEGINON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public GAJGIEGINON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5F47320", Offset = "0x5F46720", VA = "0x185F47320")]
			internal bool CKOLGFKPAPC(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<PHBLJIALGCE, IGrouping<PHBLJIALGCE, MethodInfo>> CGHEECJPINN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type GNMFFHFOCEA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F48090", Offset = "0x5F47490", VA = "0x185F48090")]
		private static void JGHLFOJCNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F48E30", Offset = "0x5F48230", VA = "0x185F48E30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5F475B0", Offset = "0x5F469B0", VA = "0x185F475B0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5F476A0", Offset = "0x5F46AA0", VA = "0x185F476A0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5F47650", Offset = "0x5F46A50", VA = "0x185F47650")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5F47600", Offset = "0x5F46A00", VA = "0x185F47600")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F48C50", Offset = "0x5F48050", VA = "0x185F48C50")]
		private static void MEJANGOAHCP(PHBLJIALGCE NMMDAHCOHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F48000", Offset = "0x5F47400", VA = "0x185F48000")]
		private static IEnumerable<MethodInfo> HHBFNAKMKBA(Type PBHNGEDCCLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F48D10", Offset = "0x5F48110", VA = "0x185F48D10")]
		private static bool PLNLPJNJMIB(string OADMPLLOFFL, [Out] Dictionary<string, List<string>> BFINDMFFDOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F476F0", Offset = "0x5F46AF0", VA = "0x185F476F0")]
		private static IEnumerable<Type> CIDDIPCCEGJ(Dictionary<string, List<string>> BFINDMFFDOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F47F20", Offset = "0x5F47320", VA = "0x185F47F20")]
		private static IEnumerable<MethodInfo> DKDFNPCLOAI(IEnumerable<Type> OMIIGGPKPFF, Type PBHNGEDCCLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F486A0", Offset = "0x5F47AA0", VA = "0x185F486A0")]
		internal static IEnumerable<MethodInfo> KNBEEAONAMN(PHBLJIALGCE NMMDAHCOHEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F48730", Offset = "0x5F47B30", VA = "0x185F48730")]
		internal static void LJDEGFKILCM(IEnumerable<MethodInfo> FKAHPFAEIHL, Type NAELAKLECAI, [Optional] object[] HKMEMMHNFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F48600", Offset = "0x5F47A00", VA = "0x185F48600")]
		private static Dictionary<PHBLJIALGCE, IGrouping<PHBLJIALGCE, MethodInfo>> JMALCJMAABO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F47E00", Offset = "0x5F47200", VA = "0x185F47E00")]
		private static bool CJCONJOGPHC(MethodInfo FEDEAKJOICM, Type HGOOJDFEHEE, bool KMIFFOAPBNJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HNIFPAKDOMK
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> LPCEJNMLENH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> BOOIBLDHGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5F473D0", Offset = "0x5F467D0", VA = "0x185F473D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F48F90", Offset = "0x5F48390", VA = "0x185F48F90")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ELICNAHLPPK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct PKFCEEFIEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo ACNMLPGLAPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public FMOKCMPGPEB BIEMHKKCCBO;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<PNDDNINAHEG, List<PKFCEEFIEAN>> HLNDKFBDFKH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static FJIKPBKCIMI CDFMFGEIMFP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static FJIKPBKCIMI KKFFKCNABBC;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static FJIKPBKCIMI DHMAOCDNKJC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FJIKPBKCIMI OPHGKOLAGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F46DD0", Offset = "0x5F461D0", VA = "0x185F46DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static FJIKPBKCIMI ENMLEAEOLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5F45E20", Offset = "0x5F45220", VA = "0x185F45E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static FJIKPBKCIMI NKNDLKNDKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5F46680", Offset = "0x5F45A80", VA = "0x185F46680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5F45E60", Offset = "0x5F45260", VA = "0x185F45E60")]
	[GALAKGAOEFB]
	private static void CNPJMFEKOCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F46F60", Offset = "0x5F46360", VA = "0x185F46F60")]
	[AGCEEPPEOHJ(PHBLJIALGCE.Unity_AfterAssembliesLoaded)]
	private static void PHDHOBJJAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F45F10", Offset = "0x5F45310", VA = "0x185F45F10")]
	public static FJIKPBKCIMI FLDGCKMMHBG(PNDDNINAHEG LFIKHBCGCDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F46540", Offset = "0x5F45940", VA = "0x185F46540")]
	private static void FLDGCKMMHBG(PNDDNINAHEG LFIKHBCGCDD, FJIKPBKCIMI GDFFFOEGNBI, FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F46150", Offset = "0x5F45550", VA = "0x185F46150")]
	private static void FLDGCKMMHBG(PNDDNINAHEG LFIKHBCGCDD, FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F47030", Offset = "0x5F46430", VA = "0x185F47030")]
	public static void PHHKFHEEDIA(PNDDNINAHEG LFIKHBCGCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x21D56A0", Offset = "0x21D4AA0", VA = "0x1821D56A0")]
	private static bool MJJFFIOOAPI(FMOKCMPGPEB ADNAPAHILHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5F46C60", Offset = "0x5F46060", VA = "0x185F46C60")]
	private static FJIKPBKCIMI LNKDLMELDKC(string ONOFJOBDDKE, [Optional] FJIKPBKCIMI GDFFFOEGNBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5F47150", Offset = "0x5F46550", VA = "0x185F47150")]
	private static void PHHKFHEEDIA(FJIKPBKCIMI BHGHMPIHGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5F45E60", Offset = "0x5F45260", VA = "0x185F45E60")]
	private static void JLJHCCENBOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F466C0", Offset = "0x5F45AC0", VA = "0x185F466C0")]
	private static IEnumerable<PKFCEEFIEAN> KFNELGKCOAO(PNDDNINAHEG LFIKHBCGCDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F46EA0", Offset = "0x5F462A0", VA = "0x185F46EA0")]
	private static FJIKPBKCIMI OOPJACEAEGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HOKEHBFONCB<T> : IDisposable where T : HOKEHBFONCB<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T EANIAGEJDFL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T GHDJCOLHINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x377D640", Offset = "0x377CA40", VA = "0x18377D640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	protected HOKEHBFONCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x377D600", Offset = "0x377CA00", VA = "0x18377D600", Slot = "5")]
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
