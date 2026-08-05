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
public class BCECNELPMON : FFPLOIOAGME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly OGJALAONKNH EKPNJJLFHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly FBFJKBDMJLC JBHGBEBBLFC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x41934D0", Offset = "0x4191CD0", VA = "0x1841934D0")]
	public BCECNELPMON(FBFJKBDMJLC JLIEOKEOAIG = FBFJKBDMJLC.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4193510", Offset = "0x4191D10", VA = "0x184193510")]
	public BCECNELPMON(OGJALAONKNH FHNPKONIMCI, FBFJKBDMJLC JLIEOKEOAIG = FBFJKBDMJLC.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class LLANOEDLJAH : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50")]
	public LLANOEDLJAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class ENAJMPNKNEO : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BGCJOGMHLOH AAFIEFEPEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int GJLGJNGLMHL;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4193550", Offset = "0x4191D50", VA = "0x184193550")]
	public ENAJMPNKNEO(BGCJOGMHLOH MEPLKMNHBEM = BGCJOGMHLOH.ExitingPlayMode, int BMGHFFAGJHI = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BGCJOGMHLOH
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
public class OFDEFDMNMJH : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50")]
	public OFDEFDMNMJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class FFPLOIOAGME : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly KHENOPADNMD KLFMCNJGGOK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4193590", Offset = "0x4191D90", VA = "0x184193590")]
	public FFPLOIOAGME(KHENOPADNMD OMCNMCIMONO = KHENOPADNMD.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KHENOPADNMD
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
		private sealed class GKAAFIDGCJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public GKAAFIDGCJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x41935C0", Offset = "0x4191DC0", VA = "0x1841935C0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x4193670", Offset = "0x4191E70", VA = "0x184193670")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KOGKNLCJCFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public KOGKNLCJCFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4194BD0", Offset = "0x41933D0", VA = "0x184194BD0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NLIFGIIGFNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
			public NLIFGIIGFNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4194C40", Offset = "0x4193440", VA = "0x184194C40")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public const string KBJGPJIBGHN = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string IIDOOOABPEM = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static Dictionary<KHENOPADNMD, IGrouping<KHENOPADNMD, MethodInfo>> FLBLAOIPFNH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Type ONJGFKFHAHK;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4195D80", Offset = "0x4194580", VA = "0x184195D80")]
		private static void PMNIFOPNPMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4196280", Offset = "0x4194A80", VA = "0x184196280")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4195060", Offset = "0x4193860", VA = "0x184195060")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4195310", Offset = "0x4193B10", VA = "0x184195310")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x41952C0", Offset = "0x4193AC0", VA = "0x1841952C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x41950B0", Offset = "0x41938B0", VA = "0x1841950B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4195490", Offset = "0x4193C90", VA = "0x184195490")]
		private static void KPPEIOKBNFJ(KHENOPADNMD OMCNMCIMONO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4195620", Offset = "0x4193E20", VA = "0x184195620")]
		private static IEnumerable<MethodInfo> LHLJJIKJCON(Type ILLFDIMIDMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4195100", Offset = "0x4193900", VA = "0x184195100")]
		private static bool BACJNIJGHGF(string HJFPFJHEJBG, out Dictionary<string, List<string>> PLNCIDBGPGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x41957D0", Offset = "0x4193FD0", VA = "0x1841957D0")]
		private static IEnumerable<Type> PHAKCCGBFCG(Dictionary<string, List<string>> PLNCIDBGPGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x41953E0", Offset = "0x4193BE0", VA = "0x1841953E0")]
		private static IEnumerable<MethodInfo> GDGLOHPDCLP(IEnumerable<Type> PDJCGKDLAGG, Type ILLFDIMIDMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4195360", Offset = "0x4193B60", VA = "0x184195360")]
		internal static IEnumerable<MethodInfo> DKDHFHOOILA(KHENOPADNMD OMCNMCIMONO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4194C90", Offset = "0x4193490", VA = "0x184194C90")]
		internal static void AFGOKNAMNEL(IEnumerable<MethodInfo> IPDHBPIAOAC, Type DLAODFGDKEE, [Optional] object[] IEOIKHEEPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4195560", Offset = "0x4193D60", VA = "0x184195560")]
		private static Dictionary<KHENOPADNMD, IGrouping<KHENOPADNMD, MethodInfo>> LBHFJNBAOCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x41956E0", Offset = "0x4193EE0", VA = "0x1841956E0")]
		private static bool MMFAMJAMCJK(MethodInfo PDKOMFIINCN, Type MACGOCOMOFF)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4196390", Offset = "0x4194B90", VA = "0x184196390")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JNAFKMAKEPF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct LBDIOEMFAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public MethodInfo EIHCOELPDMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FBFJKBDMJLC JBHGBEBBLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public bool EIDELIHPPNA;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static Dictionary<OGJALAONKNH, List<LBDIOEMFAIN>> FFJJDHLMMKB;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static IDLHNLLMOOO HIGGMIHOMBA;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static IDLHNLLMOOO PDBCAGBHCEM;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static IDLHNLLMOOO OHMDAHOGPAG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static IDLHNLLMOOO FMFDBHIKOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x41942C0", Offset = "0x4192AC0", VA = "0x1841942C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IDLHNLLMOOO HGJDLEMHBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x41937C0", Offset = "0x4191FC0", VA = "0x1841937C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IDLHNLLMOOO GPDGCAFEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4194280", Offset = "0x4192A80", VA = "0x184194280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4194480", Offset = "0x4192C80", VA = "0x184194480")]
	[OFDEFDMNMJH]
	private static void KKKIMMNBAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4194530", Offset = "0x4192D30", VA = "0x184194530")]
	[FFPLOIOAGME(KHENOPADNMD.Unity_AfterAssembliesLoaded)]
	private static void MDLBDDAJIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4193D80", Offset = "0x4192580", VA = "0x184193D80")]
	public static IDLHNLLMOOO BIMDEHHDFJD(OGJALAONKNH FHNPKONIMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4193F90", Offset = "0x4192790", VA = "0x184193F90")]
	private static void BIMDEHHDFJD(OGJALAONKNH FHNPKONIMCI, IDLHNLLMOOO JIKLLMLIOBE, ref IDLHNLLMOOO IGEIPKGINDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4193800", Offset = "0x4192000", VA = "0x184193800")]
	private static void BIMDEHHDFJD(OGJALAONKNH FHNPKONIMCI, IDLHNLLMOOO IGEIPKGINDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4194190", Offset = "0x4192990", VA = "0x184194190")]
	public static void DDEFMHHKMNH(OGJALAONKNH FHNPKONIMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x41943A0", Offset = "0x4192BA0", VA = "0x1841943A0")]
	private static bool IPCNAHIODKF(FBFJKBDMJLC JLIEOKEOAIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4194B00", Offset = "0x4193300", VA = "0x184194B00")]
	private static IDLHNLLMOOO NJIEKEKJKAE(string BNPBEGIEMPM, [Optional] IDLHNLLMOOO JIKLLMLIOBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x41940E0", Offset = "0x41928E0", VA = "0x1841940E0")]
	private static void DDEFMHHKMNH(ref IDLHNLLMOOO IGEIPKGINDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4194480", Offset = "0x4192C80", VA = "0x184194480")]
	private static void KLEALLFEBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x41945E0", Offset = "0x4192DE0", VA = "0x1841945E0")]
	private static IEnumerable<LBDIOEMFAIN> MHFCPAFMKDH(OGJALAONKNH FHNPKONIMCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x41936E0", Offset = "0x4191EE0", VA = "0x1841936E0")]
	private static IDLHNLLMOOO AGJIEKDKGMA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GIGKNPEAIPO<T> : IDisposable where T : global::GIGKNPEAIPO<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static T LHFAIDGNGGK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T AAMGPJBHPCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x53CE720", Offset = "0x53CCF20", VA = "0x1853CE720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
	protected GIGKNPEAIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x53CE6E0", Offset = "0x53CCEE0", VA = "0x1853CE6E0", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum FBFJKBDMJLC
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OGJALAONKNH
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
