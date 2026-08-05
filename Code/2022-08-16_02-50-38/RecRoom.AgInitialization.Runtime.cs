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
public class DHIFEAMMLEG : CMANADLJIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x580D170", Offset = "0x580BD70", VA = "0x18580D170")]
	public DHIFEAMMLEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class MAAMNMKLKKN : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	public MAAMNMKLKKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class MLLBDNCHPEI : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly LJIBMCNOLHI NFEPJDGLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly int HCKPAEDAGAL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x580D570", Offset = "0x580C170", VA = "0x18580D570")]
	public MLLBDNCHPEI(LJIBMCNOLHI CIJNHDCCCPE = LJIBMCNOLHI.ExitingPlayMode, int EONCPJFEEDG = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LJIBMCNOLHI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class FJLKHABBCIM : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7486E0", Offset = "0x7472E0", VA = "0x1807486E0")]
	public FJLKHABBCIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class CMANADLJIIG : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly PKJIHGJIELK LGAFAEPIKIC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x580D140", Offset = "0x580BD40", VA = "0x18580D140")]
	public CMANADLJIIG(PKJIHGJIELK AIDDALBPFBK = PKJIHGJIELK.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PKJIHGJIELK
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
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class FCFPAAPOGAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public FCFPAAPOGAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x580D200", Offset = "0x580BE00", VA = "0x18580D200")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x580D2B0", Offset = "0x580BEB0", VA = "0x18580D2B0")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FBFBGPLLAMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public FBFBGPLLAMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x580D190", Offset = "0x580BD90", VA = "0x18580D190")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MCBFKNHEOLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public MCBFKNHEOLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x580D520", Offset = "0x580C120", VA = "0x18580D520")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public const string HGHKLELLNOH = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public const string AECBBIPABEB = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Dictionary<PKJIHGJIELK, IGrouping<PKJIHGJIELK, MethodInfo>> KNCGFLGNONB;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Type AMGJCOLBMBD;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x580D6F0", Offset = "0x580C2F0", VA = "0x18580D6F0")]
		private static void CNEEMCNAIGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x580EB80", Offset = "0x580D780", VA = "0x18580EB80")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x580D5B0", Offset = "0x580C1B0", VA = "0x18580D5B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x580D6A0", Offset = "0x580C2A0", VA = "0x18580D6A0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x580D650", Offset = "0x580C250", VA = "0x18580D650")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x580D600", Offset = "0x580C200", VA = "0x18580D600")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x580EAB0", Offset = "0x580D6B0", VA = "0x18580EAB0")]
		private static void OHBEKIHKGDP(PKJIHGJIELK AIDDALBPFBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x580E0E0", Offset = "0x580CCE0", VA = "0x18580E0E0")]
		private static IEnumerable<MethodInfo> ECFJFDHEOHM(Type IANDDLKDDBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x580E800", Offset = "0x580D400", VA = "0x18580E800")]
		private static bool GHOIFCAHENL(string IHAMDFLHJOH, out Dictionary<string, List<string>> BCCDMIODMBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x580E250", Offset = "0x580CE50", VA = "0x18580E250")]
		private static IEnumerable<Type> FJBHJDNNLAK(Dictionary<string, List<string>> BCCDMIODMBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x580E1A0", Offset = "0x580CDA0", VA = "0x18580E1A0")]
		private static IEnumerable<MethodInfo> EPCMAALIBLO(IEnumerable<Type> GMEAGHGEJOI, Type IANDDLKDDBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x580DBF0", Offset = "0x580C7F0", VA = "0x18580DBF0")]
		private static void DLLHAMGICOD(IEnumerable<MethodInfo> GLMKBBOCEIO, Type DPGLGJNCLCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x580E9C0", Offset = "0x580D5C0", VA = "0x18580E9C0")]
		private static bool LAECMFICIPK(MethodInfo GMLBAPJILHF, Type CHCINACCGBB)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x580EC90", Offset = "0x580D890", VA = "0x18580EC90")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JHFELCFOFBG
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static IBFJOMHJBJL CNIGILNAMAK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IBFJOMHJBJL FLHJMFEAOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x580D320", Offset = "0x580BF20", VA = "0x18580D320")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x580D380", Offset = "0x580BF80", VA = "0x18580D380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IBFJOMHJBJL KBKNGMOBLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x580D450", Offset = "0x580C050", VA = "0x18580D450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EDLFKDMBOMC<T> : IDisposable where T : global::EDLFKDMBOMC<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private static T CPEJHBAMMLH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static T PPLIIACIKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E15390", Offset = "0x3E13F90", VA = "0x183E15390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
	protected EDLFKDMBOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3E15350", Offset = "0x3E13F50", VA = "0x183E15350", Slot = "5")]
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
