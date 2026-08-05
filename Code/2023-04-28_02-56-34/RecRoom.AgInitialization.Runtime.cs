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
		private sealed class ADKABJIGKDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public ADKABJIGKDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6995570", Offset = "0x6993F70", VA = "0x186995570")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6995640", Offset = "0x6994040", VA = "0x186995640")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BHPMBGHNJFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public BHPMBGHNJFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x69956B0", Offset = "0x69940B0", VA = "0x1869956B0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class KJGKHIFDEFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public KJGKHIFDEFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6996E40", Offset = "0x6995840", VA = "0x186996E40")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string COGICBELLON = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string HFLLGOFADFC = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<BAHKGFILFFP, IGrouping<BAHKGFILFFP, MethodInfo>> KEFJMCOLMFE;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type HGCFABHHMNK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6996FD0", Offset = "0x69959D0", VA = "0x186996FD0")]
		private static void DFMJMCHLIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69988F0", Offset = "0x69972F0", VA = "0x1869988F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6996E90", Offset = "0x6995890", VA = "0x186996E90")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6996F80", Offset = "0x6995980", VA = "0x186996F80")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6996F30", Offset = "0x6995930", VA = "0x186996F30")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6996EE0", Offset = "0x69958E0", VA = "0x186996EE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6998740", Offset = "0x6997140", VA = "0x186998740")]
		private static void PCHLJFIBPKO(BAHKGFILFFP PDCDBLMJOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6997680", Offset = "0x6996080", VA = "0x186997680")]
		private static IEnumerable<MethodInfo> FMLDBNDJDCB(Type FPDCPEHOLLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6998070", Offset = "0x6996A70", VA = "0x186998070")]
		private static bool JIJKLKHBDLE(string EONJLFKAPKG, out Dictionary<string, List<string>> AAIIPLCELHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69978F0", Offset = "0x69962F0", VA = "0x1869978F0")]
		private static IEnumerable<Type> IJAIJGJCGJO(Dictionary<string, List<string>> AAIIPLCELHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6998810", Offset = "0x6997210", VA = "0x186998810")]
		private static IEnumerable<MethodInfo> PIJHEAHIKCB(IEnumerable<Type> OFGCLOACCDN, Type FPDCPEHOLLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6997740", Offset = "0x6996140", VA = "0x186997740")]
		internal static IEnumerable<MethodInfo> FPPHOHIDAGL(BAHKGFILFFP PDCDBLMJOPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6998230", Offset = "0x6996C30", VA = "0x186998230")]
		internal static void NKCGBIPLIGG(IEnumerable<MethodInfo> JOEJGOEBMOG, Type NHCMIDLJAIE, [Optional] object[] BHGFJLDJJON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69975C0", Offset = "0x6995FC0", VA = "0x1869975C0")]
		private static Dictionary<BAHKGFILFFP, IGrouping<BAHKGFILFFP, MethodInfo>> EPKHGHCJNMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69977D0", Offset = "0x69961D0", VA = "0x1869977D0")]
		private static bool GJELOHPFLJM(MethodInfo EIPDGEHJIMJ, Type HHJOOLAJIID, bool JCGNIENIAFC)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6998A60", Offset = "0x6997460", VA = "0x186998A60")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class ILIPGJAEFBH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct OAKNAMDBJJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo LOGHEHHCJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public GHILFLKBMBN JOKCBJALNCF;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<JMBPMAGFLED, List<OAKNAMDBJJA>> FJFDDJLDKLG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static AOONKACGDKK PGBBHMMBPLO;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static AOONKACGDKK JHECPHIDKEI;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static AOONKACGDKK FCOLMAPPEAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AOONKACGDKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6995A40", Offset = "0x6994440", VA = "0x186995A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static AOONKACGDKK JBODINJNCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6995B30", Offset = "0x6994530", VA = "0x186995B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static AOONKACGDKK MLIMPCGENLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6995C50", Offset = "0x6994650", VA = "0x186995C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6995720", Offset = "0x6994120", VA = "0x186995720")]
	[FHKIMKMNPFP]
	private static void HGKNDKJOILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6996220", Offset = "0x6994C20", VA = "0x186996220")]
	[DKOCLKLDKBJ(BAHKGFILFFP.Unity_AfterAssembliesLoaded)]
	private static void FPOPGLDFDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6996C00", Offset = "0x6995600", VA = "0x186996C00")]
	public static AOONKACGDKK LJMEEDAIOHE(JMBPMAGFLED MCPBHLPAFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6996630", Offset = "0x6995030", VA = "0x186996630")]
	private static void LJMEEDAIOHE(JMBPMAGFLED MCPBHLPAFGP, AOONKACGDKK IAAJAFHICGC, ref AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69967C0", Offset = "0x69951C0", VA = "0x1869967C0")]
	private static void LJMEEDAIOHE(JMBPMAGFLED MCPBHLPAFGP, AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6996310", Offset = "0x6994D10", VA = "0x186996310")]
	public static void JIHJGLFLGDJ(JMBPMAGFLED MCPBHLPAFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6995B70", Offset = "0x6994570", VA = "0x186995B70")]
	private static bool EAFNGPMKNMN(GHILFLKBMBN DNBBJGKAGMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69958C0", Offset = "0x69942C0", VA = "0x1869958C0")]
	private static AOONKACGDKK CIPMNLGHOOM(string DLHDIKGEIFJ, [Optional] AOONKACGDKK IAAJAFHICGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6996420", Offset = "0x6994E20", VA = "0x186996420")]
	private static void JIHJGLFLGDJ(ref AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6995720", Offset = "0x6994120", VA = "0x186995720")]
	private static void BHAEDPFBFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6995C90", Offset = "0x6994690", VA = "0x186995C90")]
	private static IEnumerable<OAKNAMDBJJA> FKAHLCJDNGC(JMBPMAGFLED MCPBHLPAFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69957D0", Offset = "0x69941D0", VA = "0x1869957D0")]
	private static AOONKACGDKK CHMPIIEGHOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LLCJBHJOIDP<T> : IDisposable where T : global::LLCJBHJOIDP<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T MLLKBCFLFJE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T AGBLMGNNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x228DA70", Offset = "0x228C470", VA = "0x18228DA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
	protected LLCJBHJOIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x228DD00", Offset = "0x228C700", VA = "0x18228DD00", Slot = "5")]
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
