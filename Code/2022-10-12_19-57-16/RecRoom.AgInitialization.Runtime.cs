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
	[Cpp2IlInjected.Address(RVA = "0x5DF1DB0", Offset = "0x5DF0DB0", VA = "0x185DF1DB0")]
	public FBDCEBOAGGK(ABMKJHLOOPK IDCMPPGJFDJ = ABMKJHLOOPK.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1D70", Offset = "0x5DF0D70", VA = "0x185DF1D70")]
	public FBDCEBOAGGK(NIDAALAPHOA JKKGMAKLJHN, ABMKJHLOOPK IDCMPPGJFDJ = ABMKJHLOOPK.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class CCMOOFNMNOE : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DF1CE0", Offset = "0x5DF0CE0", VA = "0x185DF1CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DF1B70", Offset = "0x5DF0B70", VA = "0x185DF1B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public DBMLHCMMPEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5DF1BA0", Offset = "0x5DF0BA0", VA = "0x185DF1BA0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5DF1C70", Offset = "0x5DF0C70", VA = "0x185DF1C70")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public IEBMHHFMDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DF1DF0", Offset = "0x5DF0DF0", VA = "0x185DF1DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public ECLKABBIKNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DF1D20", Offset = "0x5DF0D20", VA = "0x185DF1D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DF3A10", Offset = "0x5DF2A10", VA = "0x185DF3A10")]
		private static void FNNIGPJMAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DF5070", Offset = "0x5DF4070", VA = "0x185DF5070")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DF36F0", Offset = "0x5DF26F0", VA = "0x185DF36F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DF39C0", Offset = "0x5DF29C0", VA = "0x185DF39C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3970", Offset = "0x5DF2970", VA = "0x185DF3970")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3740", Offset = "0x5DF2740", VA = "0x185DF3740")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4F10", Offset = "0x5DF3F10", VA = "0x185DF4F10")]
		private static void LMHMEFEFLFG(IEFLDJIBODH FCEJKBMGMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF41C0", Offset = "0x5DF31C0", VA = "0x185DF41C0")]
		private static IEnumerable<MethodInfo> IFGACKCNIPM(Type KBKPDPMIEKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4000", Offset = "0x5DF3000", VA = "0x185DF4000")]
		private static bool HLNPEHNCFFL(string FOGPJLFAFJP, out Dictionary<string, List<string>> DGKOGEFFFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4790", Offset = "0x5DF3790", VA = "0x185DF4790")]
		private static IEnumerable<Type> JKIAJHKPDNN(Dictionary<string, List<string>> DGKOGEFFFNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3610", Offset = "0x5DF2610", VA = "0x185DF3610")]
		private static IEnumerable<MethodInfo> AKBBECODLBA(IEnumerable<Type> CEJOIBBGIME, Type KBKPDPMIEKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4FE0", Offset = "0x5DF3FE0", VA = "0x185DF4FE0")]
		internal static IEnumerable<MethodInfo> NHHEMGFELDB(IEFLDJIBODH FCEJKBMGMIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4280", Offset = "0x5DF3280", VA = "0x185DF4280")]
		internal static void JKFJGAFMKBD(IEnumerable<MethodInfo> FDPPFBHGFFO, Type GENGPJHOLOL, [Optional] object[] EPEIMBEMAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3790", Offset = "0x5DF2790", VA = "0x185DF3790")]
		private static Dictionary<IEFLDJIBODH, IGrouping<IEFLDJIBODH, MethodInfo>> BCMIDAOABDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3850", Offset = "0x5DF2850", VA = "0x185DF3850")]
		private static bool BFDNDLOKBPN(MethodInfo BDEKHACDIFG, Type IIMKJEILFGB)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5DF51E0", Offset = "0x5DF41E0", VA = "0x185DF51E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DF1F50", Offset = "0x5DF0F50", VA = "0x185DF1F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static PCJIKNDFKDJ LDLKNNEJPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3440", Offset = "0x5DF2440", VA = "0x185DF3440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PCJIKNDFKDJ FINIDPHNNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2E30", Offset = "0x5DF1E30", VA = "0x185DF2E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3560", Offset = "0x5DF2560", VA = "0x185DF3560")]
	[MLHBGDGHMHN]
	private static void PONHGNANKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2D40", Offset = "0x5DF1D40", VA = "0x185DF2D40")]
	[BMMLGDJGCIJ(IEFLDJIBODH.Unity_AfterAssembliesLoaded)]
	private static void HLELGNFCCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2130", Offset = "0x5DF1130", VA = "0x185DF2130")]
	public static PCJIKNDFKDJ GGGIMKKLLJH(NIDAALAPHOA JKKGMAKLJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF29D0", Offset = "0x5DF19D0", VA = "0x185DF29D0")]
	private static void GGGIMKKLLJH(NIDAALAPHOA JKKGMAKLJHN, PCJIKNDFKDJ JAEPIDIGJJL, ref PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2370", Offset = "0x5DF1370", VA = "0x185DF2370")]
	private static void GGGIMKKLLJH(NIDAALAPHOA JKKGMAKLJHN, PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2B60", Offset = "0x5DF1B60", VA = "0x185DF2B60")]
	public static void HEPKHNOFOOP(NIDAALAPHOA JKKGMAKLJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3480", Offset = "0x5DF2480", VA = "0x185DF3480")]
	private static bool OAOAKMFCDKF(ABMKJHLOOPK IDCMPPGJFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2040", Offset = "0x5DF1040", VA = "0x185DF2040")]
	private static PCJIKNDFKDJ BNLAGHNGNJO(string OAICAGOGKMO, [Optional] PCJIKNDFKDJ JAEPIDIGJJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2C70", Offset = "0x5DF1C70", VA = "0x185DF2C70")]
	private static void HEPKHNOFOOP(ref PCJIKNDFKDJ DFNJPCAHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3560", Offset = "0x5DF2560", VA = "0x185DF3560")]
	private static void OMNKCNAHDMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2E70", Offset = "0x5DF1E70", VA = "0x185DF2E70")]
	private static IEnumerable<MECJBGCOGME> LCLNJNLEGCG(NIDAALAPHOA JKKGMAKLJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1E60", Offset = "0x5DF0E60", VA = "0x185DF1E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D24840", Offset = "0x2D23840", VA = "0x182D24840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	protected PDBFJAPKKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D24800", Offset = "0x2D23800", VA = "0x182D24800", Slot = "5")]
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
