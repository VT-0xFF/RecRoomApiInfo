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
		private sealed class JHMFEBKINOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public JHMFEBKINOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6766950", Offset = "0x6765B50", VA = "0x186766950")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6766A20", Offset = "0x6765C20", VA = "0x186766A20")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class EPMEDJCFOEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public EPMEDJCFOEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67668E0", Offset = "0x6765AE0", VA = "0x1867668E0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class NOLEBMBHGLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public NOLEBMBHGLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67681B0", Offset = "0x67673B0", VA = "0x1867681B0")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string HJPNBNGPLCI = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string PBGMFOKNALG = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<CHIHMKPMNLF, IGrouping<CHIHMKPMNLF, MethodInfo>> EAIBNLFPPAB;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type GBOLMONGALN;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6769670", Offset = "0x6768870", VA = "0x186769670")]
		private static void POFMDPBMMCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6769C60", Offset = "0x6768E60", VA = "0x186769C60")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67683B0", Offset = "0x67675B0", VA = "0x1867683B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67689B0", Offset = "0x6767BB0", VA = "0x1867689B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6768960", Offset = "0x6767B60", VA = "0x186768960")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6768400", Offset = "0x6767600", VA = "0x186768400")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67682E0", Offset = "0x67674E0", VA = "0x1867682E0")]
		private static void ALPOOANFEDJ(CHIHMKPMNLF DJEDNKPEACH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6768C80", Offset = "0x6767E80", VA = "0x186768C80")]
		private static IEnumerable<MethodInfo> GOOJIHPDGEC(Type CFNGHJBJHEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6768AC0", Offset = "0x6767CC0", VA = "0x186768AC0")]
		private static bool EIICEALOHHA(string NPKOMACBEIC, out Dictionary<string, List<string>> MCADFJLLCAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6768D40", Offset = "0x6767F40", VA = "0x186768D40")]
		private static IEnumerable<Type> JMBFDLPNHIB(Dictionary<string, List<string>> MCADFJLLCAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6768200", Offset = "0x6767400", VA = "0x186768200")]
		private static IEnumerable<MethodInfo> ADHDHPKAIPA(IEnumerable<Type> AFKPEPNHHAC, Type CFNGHJBJHEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67694C0", Offset = "0x67686C0", VA = "0x1867694C0")]
		internal static IEnumerable<MethodInfo> KMNLBLAEMIH(CHIHMKPMNLF DJEDNKPEACH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6768450", Offset = "0x6767650", VA = "0x186768450")]
		internal static void BJKPIFHDCAP(IEnumerable<MethodInfo> FBDBEILMDLG, Type AIKFEIJLANB, [Optional] object[] HMJOKPKOPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6768A00", Offset = "0x6767C00", VA = "0x186768A00")]
		private static Dictionary<CHIHMKPMNLF, IGrouping<CHIHMKPMNLF, MethodInfo>> ECIMJHBJMEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6769550", Offset = "0x6768750", VA = "0x186769550")]
		private static bool NHIOMBCJDOH(MethodInfo PEENOKCMOFN, Type ACNCJAIOFFJ, bool HBGBBDMBOMK)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6769DD0", Offset = "0x6768FD0", VA = "0x186769DD0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MPAAIECKLGA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct PCPBMFLIFGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo HJLIDCNDCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NPBJMIOJGOK BPAADIPDOLH;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<NAFLJHIHEAG, List<PCPBMFLIFGI>> KGEOJBOMEHC;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static MNALHHOLFGL OAEHHEPLLJE;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static MNALHHOLFGL MMBNOIJNEKD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MNALHHOLFGL PFMNCAMOCNP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MNALHHOLFGL CFHDLGEGDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67680C0", Offset = "0x67672C0", VA = "0x1867680C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MNALHHOLFGL BOGICFDENBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6767C40", Offset = "0x6766E40", VA = "0x186767C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MNALHHOLFGL GGHABHJJMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6767670", Offset = "0x6766870", VA = "0x186767670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67675C0", Offset = "0x67667C0", VA = "0x1867675C0")]
	[AMNIMFKIEJD]
	private static void FKFNELKEADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6767C80", Offset = "0x6766E80", VA = "0x186767C80")]
	[LCHGFDCANEE(CHIHMKPMNLF.Unity_AfterAssembliesLoaded)]
	private static void LIKNMNIJFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6766F40", Offset = "0x6766140", VA = "0x186766F40")]
	public static MNALHHOLFGL FEFIEKAKJMP(NAFLJHIHEAG ILOFLIEBAGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6766DB0", Offset = "0x6765FB0", VA = "0x186766DB0")]
	private static void FEFIEKAKJMP(NAFLJHIHEAG ILOFLIEBAGP, MNALHHOLFGL DDFCHDGPJBN, ref MNALHHOLFGL FMPHDMAKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6767180", Offset = "0x6766380", VA = "0x186767180")]
	private static void FEFIEKAKJMP(NAFLJHIHEAG ILOFLIEBAGP, MNALHHOLFGL FMPHDMAKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6766A90", Offset = "0x6765C90", VA = "0x186766A90")]
	public static void AJCCCBEKCEO(NAFLJHIHEAG ILOFLIEBAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6767E60", Offset = "0x6767060", VA = "0x186767E60")]
	private static bool MNMMABKBIBN(NPBJMIOJGOK LGGOCLFFLBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6767F40", Offset = "0x6767140", VA = "0x186767F40")]
	private static MNALHHOLFGL OBAIKOPBHAP(string LGENGCEEBPB, [Optional] MNALHHOLFGL DDFCHDGPJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6766BA0", Offset = "0x6765DA0", VA = "0x186766BA0")]
	private static void AJCCCBEKCEO(ref MNALHHOLFGL FMPHDMAKDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67675C0", Offset = "0x67667C0", VA = "0x1867675C0")]
	private static void IIDBOCEJGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67676B0", Offset = "0x67668B0", VA = "0x1867676B0")]
	private static IEnumerable<PCPBMFLIFGI> IAHBBNGNFFA(NAFLJHIHEAG ILOFLIEBAGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6767D70", Offset = "0x6766F70", VA = "0x186767D70")]
	private static MNALHHOLFGL MBBNGJNEHHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AMMPNGFAIJL<T> : IDisposable where T : global::AMMPNGFAIJL<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T CMDPMJBEBAB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T OFDKPDDLIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x31DFC50", Offset = "0x31DEE50", VA = "0x1831DFC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	protected AMMPNGFAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x31DFEE0", Offset = "0x31DF0E0", VA = "0x1831DFEE0", Slot = "5")]
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
