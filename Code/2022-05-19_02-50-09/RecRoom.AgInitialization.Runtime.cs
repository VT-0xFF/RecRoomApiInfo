using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Method)]
public class AOGEBGNMPFC : OCMGHBFFHBN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x17A58B0", Offset = "0x17A44B0", VA = "0x1817A58B0")]
	public AOGEBGNMPFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class BIEDHDEFKGL : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly LOMHOCOLDLE GIJEDPFKGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int HNCAPNPFGDF;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x17A58D0", Offset = "0x17A44D0", VA = "0x1817A58D0")]
	public BIEDHDEFKGL(LOMHOCOLDLE HGKEOMFHJGJ = LOMHOCOLDLE.ExitingPlayMode, int MDPIGMOLBNK = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LOMHOCOLDLE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method)]
public class JKICLGGKJCO : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x850150", Offset = "0x84ED50", VA = "0x180850150")]
	public JKICLGGKJCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class OCMGHBFFHBN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly NPADJDIGCKA MMLNKAMMKLJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x17A5A90", Offset = "0x17A4690", VA = "0x1817A5A90")]
	public OCMGHBFFHBN(NPADJDIGCKA MPOFIAIDDEN = NPADJDIGCKA.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NPADJDIGCKA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Unity_AfterSceneLoad,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Unity_BeforeSceneLoad,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Unity_AfterAssembliesLoaded,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Unity_BeforeSplashScreen,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Unity_SubsystemRegistration
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class OIOBLPIIFHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public OIOBLPIIFHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x17A5AC0", Offset = "0x17A46C0", VA = "0x1817A5AC0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x17A5B70", Offset = "0x17A4770", VA = "0x1817A5B70")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class IEBABBNGAML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public IEBABBNGAML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x17A5960", Offset = "0x17A4560", VA = "0x1817A5960")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class HDHKJKCPOLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public HDHKJKCPOLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x17A5910", Offset = "0x17A4510", VA = "0x1817A5910")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string AENNLHBMLKN = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string ECGCGEOEHIN = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<NPADJDIGCKA, IGrouping<NPADJDIGCKA, MethodInfo>> DAONLBIODPL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type BIGJFAAIIJG;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x17A6520", Offset = "0x17A5120", VA = "0x1817A6520")]
		private static void EOADHGIBDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x17A7160", Offset = "0x17A5D60", VA = "0x1817A7160")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x17A5CD0", Offset = "0x17A48D0", VA = "0x1817A5CD0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x17A5DC0", Offset = "0x17A49C0", VA = "0x1817A5DC0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x17A5D70", Offset = "0x17A4970", VA = "0x1817A5D70")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x17A5D20", Offset = "0x17A4920", VA = "0x1817A5D20")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x17A7090", Offset = "0x17A5C90", VA = "0x1817A7090")]
		private static void NKEHDHLDFOP(NPADJDIGCKA MPOFIAIDDEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x17A6A20", Offset = "0x17A5620", VA = "0x1817A6A20")]
		private static IEnumerable<MethodInfo> HIJBPPAOBOD(Type JMBGLHLOOAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x17A5E10", Offset = "0x17A4A10", VA = "0x1817A5E10")]
		private static bool CEHLGLBMHEN(string CCLOOIOCDHE, out Dictionary<string, List<string>> DDFPCJNEOLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x17A6AE0", Offset = "0x17A56E0", VA = "0x1817A6AE0")]
		private static IEnumerable<Type> NGDAGLECJHP(Dictionary<string, List<string>> DDFPCJNEOLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x17A6470", Offset = "0x17A5070", VA = "0x1817A6470")]
		private static IEnumerable<MethodInfo> DPJMGIDADDF(IEnumerable<Type> EAHELHHFOIJ, Type JMBGLHLOOAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x17A5FD0", Offset = "0x17A4BD0", VA = "0x1817A5FD0")]
		private static void DFJPBEFABKG(IEnumerable<MethodInfo> KNOJGPBBFDK, Type EIKPIGEPECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x17A5BE0", Offset = "0x17A47E0", VA = "0x1817A5BE0")]
		private static bool ADDFLAPKIHB(MethodInfo LLBIBLDMIAJ, Type PAMGECGADDM)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x17A7270", Offset = "0x17A5E70", VA = "0x1817A7270")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KDGBMMFBKKF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NCOHEPAGOOP IEPGIADAFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x17A59D0", Offset = "0x17A45D0", VA = "0x1817A59D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KFEBFLGMECK<T> : IDisposable where T : global::KFEBFLGMECK<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static T HEIBHELNIJL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static T APCGFOPGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x120F660", Offset = "0x120E260", VA = "0x18120F660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
	protected KFEBFLGMECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x120F970", Offset = "0x120E570", VA = "0x18120F970", Slot = "5")]
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
