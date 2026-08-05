using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Method)]
public class FBDCEBOAGGK : BMMLGDJGCIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly NIDAALAPHOA MOELHHPLAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly ABMKJHLOOPK OBBHCEPMKND;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E32480", Offset = "0x5E30C80", VA = "0x185E32480")]
	public FBDCEBOAGGK(ABMKJHLOOPK IDCMPPGJFDJ = ABMKJHLOOPK.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E32440", Offset = "0x5E30C40", VA = "0x185E32440")]
	public FBDCEBOAGGK(NIDAALAPHOA JKKGMAKLJHN, ABMKJHLOOPK IDCMPPGJFDJ = ABMKJHLOOPK.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class CCMOOFNMNOE : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	public CCMOOFNMNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class DDDKNIGBKHH : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ODNNAFCJNAG KOPPJPCFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int NCABMENALPB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E323B0", Offset = "0x5E30BB0", VA = "0x185E323B0")]
	public DDDKNIGBKHH(ODNNAFCJNAG HLKMAMHIHEA = ODNNAFCJNAG.ExitingPlayMode, int PCMCGMOPFKB = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum ODNNAFCJNAG
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class MLHBGDGHMHN : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	public MLHBGDGHMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class BMMLGDJGCIJ : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly IEFLDJIBODH LGJHHCKMGBK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E32240", Offset = "0x5E30A40", VA = "0x185E32240")]
	public BMMLGDJGCIJ(IEFLDJIBODH FCEJKBMGMIB = IEFLDJIBODH.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum IEFLDJIBODH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Unity_AfterSceneLoad = 0,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Unity_BeforeSceneLoad = 1,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Unity_AfterAssembliesLoaded = 2,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Unity_BeforeSplashScreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Unity_SubsystemRegistration = 4,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	ManuallyInvoked = int.MaxValue
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DBMLHCMMPEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public DBMLHCMMPEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5E32270", Offset = "0x5E30A70", VA = "0x185E32270")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5E32340", Offset = "0x5E30B40", VA = "0x185E32340")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IEBMHHFMDFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public IEBMHHFMDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E324C0", Offset = "0x5E30CC0", VA = "0x185E324C0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ECLKABBIKNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public ECLKABBIKNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E323F0", Offset = "0x5E30BF0", VA = "0x185E323F0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const string NOLLEDKJGLO = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string EFEPGBBCHEK = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static Dictionary<IEFLDJIBODH, IGrouping<IEFLDJIBODH, MethodInfo>> LGFEMANDPGE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Type PHJEIJGONCF;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E340E0", Offset = "0x5E328E0", VA = "0x185E340E0")]
		private static void FNNIGPJMAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E35740", Offset = "0x5E33F40", VA = "0x185E35740")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E33DC0", Offset = "0x5E325C0", VA = "0x185E33DC0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E34090", Offset = "0x5E32890", VA = "0x185E34090")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E34040", Offset = "0x5E32840", VA = "0x185E34040")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E33E10", Offset = "0x5E32610", VA = "0x185E33E10")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E355E0", Offset = "0x5E33DE0", VA = "0x185E355E0")]
		private static void LMHMEFEFLFG(IEFLDJIBODH FCEJKBMGMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E34890", Offset = "0x5E33090", VA = "0x185E34890")]
		private static IEnumerable<MethodInfo> IFGACKCNIPM(Type KBKPDPMIEKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E346D0", Offset = "0x5E32ED0", VA = "0x185E346D0")]
		private static bool HLNPEHNCFFL(string FOGPJLFAFJP, out Dictionary<string, List<string>> DGKOGEFFFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E34E60", Offset = "0x5E33660", VA = "0x185E34E60")]
		private static IEnumerable<Type> JKIAJHKPDNN(Dictionary<string, List<string>> DGKOGEFFFNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E33CE0", Offset = "0x5E324E0", VA = "0x185E33CE0")]
		private static IEnumerable<MethodInfo> AKBBECODLBA(IEnumerable<Type> CEJOIBBGIME, Type KBKPDPMIEKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E356B0", Offset = "0x5E33EB0", VA = "0x185E356B0")]
		internal static IEnumerable<MethodInfo> NHHEMGFELDB(IEFLDJIBODH FCEJKBMGMIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E34950", Offset = "0x5E33150", VA = "0x185E34950")]
		internal static void JKFJGAFMKBD(IEnumerable<MethodInfo> FDPPFBHGFFO, Type GENGPJHOLOL, [Optional] object[] EPEIMBEMAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E33E60", Offset = "0x5E32660", VA = "0x185E33E60")]
		private static Dictionary<IEFLDJIBODH, IGrouping<IEFLDJIBODH, MethodInfo>> BCMIDAOABDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E33F20", Offset = "0x5E32720", VA = "0x185E33F20")]
		private static bool BFDNDLOKBPN(MethodInfo BDEKHACDIFG, Type IIMKJEILFGB)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E358B0", Offset = "0x5E340B0", VA = "0x185E358B0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JDHNLPGAALE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct MECJBGCOGME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MethodInfo PJJDNCCKIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ABMKJHLOOPK OBBHCEPMKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public bool DBEDJNNEOED;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static Dictionary<NIDAALAPHOA, List<MECJBGCOGME>> KBHJPCKONEL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static PCJIKNDFKDJ LBJBLOAAPAC;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static PCJIKNDFKDJ CKLOCMIKCID;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static PCJIKNDFKDJ EOGKPMELAPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PCJIKNDFKDJ MDILBPOCOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E32620", Offset = "0x5E30E20", VA = "0x185E32620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PCJIKNDFKDJ LDLKNNEJPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E33B10", Offset = "0x5E32310", VA = "0x185E33B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PCJIKNDFKDJ FINIDPHNNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E33500", Offset = "0x5E31D00", VA = "0x185E33500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E33C30", Offset = "0x5E32430", VA = "0x185E33C30")]
	[MLHBGDGHMHN]
	private static void PONHGNANKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E33410", Offset = "0x5E31C10", VA = "0x185E33410")]
	[BMMLGDJGCIJ(IEFLDJIBODH.Unity_AfterAssembliesLoaded)]
	private static void HLELGNFCCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E32800", Offset = "0x5E31000", VA = "0x185E32800")]
	public static PCJIKNDFKDJ GGGIMKKLLJH(NIDAALAPHOA JKKGMAKLJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E330A0", Offset = "0x5E318A0", VA = "0x185E330A0")]
	private static void GGGIMKKLLJH(NIDAALAPHOA JKKGMAKLJHN, PCJIKNDFKDJ JAEPIDIGJJL, ref PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E32A40", Offset = "0x5E31240", VA = "0x185E32A40")]
	private static void GGGIMKKLLJH(NIDAALAPHOA JKKGMAKLJHN, PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E33230", Offset = "0x5E31A30", VA = "0x185E33230")]
	public static void HEPKHNOFOOP(NIDAALAPHOA JKKGMAKLJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E33B50", Offset = "0x5E32350", VA = "0x185E33B50")]
	private static bool OAOAKMFCDKF(ABMKJHLOOPK IDCMPPGJFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E32710", Offset = "0x5E30F10", VA = "0x185E32710")]
	private static PCJIKNDFKDJ BNLAGHNGNJO(string OAICAGOGKMO, [Optional] PCJIKNDFKDJ JAEPIDIGJJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E33340", Offset = "0x5E31B40", VA = "0x185E33340")]
	private static void HEPKHNOFOOP(ref PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E33C30", Offset = "0x5E32430", VA = "0x185E33C30")]
	private static void OMNKCNAHDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E33540", Offset = "0x5E31D40", VA = "0x185E33540")]
	private static IEnumerable<MECJBGCOGME> LCLNJNLEGCG(NIDAALAPHOA JKKGMAKLJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E32530", Offset = "0x5E30D30", VA = "0x185E32530")]
	private static PCJIKNDFKDJ ABOOIHAIEFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PDBFJAPKKIL<T> : IDisposable where T : global::PDBFJAPKKIL<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static T NIDJHACIMJI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T KGCADEGMLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F660", Offset = "0x3B1DE60", VA = "0x183B1F660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
	protected PDBFJAPKKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3B1F620", Offset = "0x3B1DE20", VA = "0x183B1F620", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum ABMKJHLOOPK
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum NIDAALAPHOA
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Room
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
