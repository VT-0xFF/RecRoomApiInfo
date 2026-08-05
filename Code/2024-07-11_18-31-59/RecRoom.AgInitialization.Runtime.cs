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
		private sealed class LLNLGCEMGOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public LLNLGCEMGOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6745750", Offset = "0x6744150", VA = "0x186745750")]
			internal IEnumerable<MethodInfo> BOCEBPOHCFN(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6745810", Offset = "0x6744210", VA = "0x186745810")]
			internal bool DNPGCBCEDIA(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class JDBONFEBGJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public JDBONFEBGJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67456F0", Offset = "0x67440F0", VA = "0x1867456F0")]
			internal bool CEEONHDAKDJ(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ADNFMFEEMEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
			public ADNFMFEEMEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67440A0", Offset = "0x6742AA0", VA = "0x1867440A0")]
			internal bool MPCECIBEJMN(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<MJLCCMEEJMA, IGrouping<MJLCCMEEJMA, MethodInfo>> DAADOCPIIOB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type LOEMJDEBKDO;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6746BB0", Offset = "0x67455B0", VA = "0x186746BB0")]
		private static void PGAOEFOGFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6747120", Offset = "0x6745B20", VA = "0x186747120")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67459C0", Offset = "0x67443C0", VA = "0x1867459C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6745B50", Offset = "0x6744550", VA = "0x186745B50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6745B00", Offset = "0x6744500", VA = "0x186745B00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6745A10", Offset = "0x6744410", VA = "0x186745A10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6745900", Offset = "0x6744300", VA = "0x186745900")]
		private static void AFBOIOGKJGF(MJLCCMEEJMA CGNIBFGKCMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6746A40", Offset = "0x6745440", VA = "0x186746A40")]
		private static IEnumerable<MethodInfo> JOBIMCJJKNL(Type JLDNINICBDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6745CC0", Offset = "0x67446C0", VA = "0x186745CC0")]
		private static bool DKIGCHDMCNI(string EOECEMBLGPP, [Out] Dictionary<string, List<string>> DPFAOFMILGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6745DE0", Offset = "0x67447E0", VA = "0x186745DE0")]
		private static IEnumerable<Type> ELIKBKMPNGE(Dictionary<string, List<string>> DPFAOFMILGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6746AD0", Offset = "0x67454D0", VA = "0x186746AD0")]
		private static IEnumerable<MethodInfo> LDIECJLBAMC(IEnumerable<Type> DGLFPPDJICE, Type JLDNINICBDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6745870", Offset = "0x6744270", VA = "0x186745870")]
		internal static IEnumerable<MethodInfo> ACGFHNOPPGJ(MJLCCMEEJMA CGNIBFGKCMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6746500", Offset = "0x6744F00", VA = "0x186746500")]
		internal static void EPOGJOCFJFM(IEnumerable<MethodInfo> IPGMMCKMPDK, Type LGFAKEDPPNG, [Optional] object[] LDMPLMIKDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6745A60", Offset = "0x6744460", VA = "0x186745A60")]
		private static Dictionary<MJLCCMEEJMA, IGrouping<MJLCCMEEJMA, MethodInfo>> BNJIJOBINED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6745BA0", Offset = "0x67445A0", VA = "0x186745BA0")]
		private static bool CDFACLHNJHK(MethodInfo NKCFICHAONK, Type JOCEGNPJLFO, bool HINLKFFNMOD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CPJNPIDHKED
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> HMPHIPODLGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> EPDAIGGLFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67440F0", Offset = "0x6742AF0", VA = "0x1867440F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6747280", Offset = "0x6745C80", VA = "0x186747280")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GIKCNCMAGGC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct MGJKIPEAOMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo MOJNKCMMBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JMIPDAHBNNG ODFJAPECCDL;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<JAFPILLCEJB, List<MGJKIPEAOMK>> OFMMIIBMCAG;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static INCIOHANCNE NDGFPJIAKFP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static INCIOHANCNE DPCJNOOLMKD;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static INCIOHANCNE ECBMDAOIEON;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static INCIOHANCNE DHCIAOJNIGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6744CE0", Offset = "0x67436E0", VA = "0x186744CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static INCIOHANCNE ODKOCJOOHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6744CA0", Offset = "0x67436A0", VA = "0x186744CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static INCIOHANCNE PMFGCGHPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67455F0", Offset = "0x6743FF0", VA = "0x1867455F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool OCGCLHIGNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6744C60", Offset = "0x6743660", VA = "0x186744C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67448C0", Offset = "0x67432C0", VA = "0x1867448C0")]
	[KDMKPJDAJLL]
	private static void EPEFAHGCDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6745520", Offset = "0x6743F20", VA = "0x186745520")]
	[FCFOCBHCEIP(MJLCCMEEJMA.Unity_AfterAssembliesLoaded)]
	private static void LCDCAKLDKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6744DB0", Offset = "0x67437B0", VA = "0x186744DB0")]
	public static INCIOHANCNE KFAANGMGFBB(JAFPILLCEJB AOANHMLCKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67453E0", Offset = "0x6743DE0", VA = "0x1867453E0")]
	private static void KFAANGMGFBB(JAFPILLCEJB AOANHMLCKPG, INCIOHANCNE OOEKFBLDDAA, INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6744FF0", Offset = "0x67439F0", VA = "0x186744FF0")]
	private static void KFAANGMGFBB(JAFPILLCEJB AOANHMLCKPG, INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6744B40", Offset = "0x6743540", VA = "0x186744B40")]
	public static void FDAHEMCLIJO(JAFPILLCEJB AOANHMLCKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2576240", Offset = "0x2574C40", VA = "0x182576240")]
	private static bool KDEBKIDEFBA(JMIPDAHBNNG ANGEEBBNNIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67441B0", Offset = "0x6742BB0", VA = "0x1867441B0")]
	private static INCIOHANCNE EAHKIMMMHCG(string PLAKPHMPIIP, [Optional] INCIOHANCNE OOEKFBLDDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6744970", Offset = "0x6743370", VA = "0x186744970")]
	private static void FDAHEMCLIJO(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67448C0", Offset = "0x67432C0", VA = "0x1867448C0")]
	private static void OMFHNDNJLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6744320", Offset = "0x6742D20", VA = "0x186744320")]
	private static IEnumerable<MGJKIPEAOMK> EOHEKEGJDKJ(JAFPILLCEJB AOANHMLCKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6745630", Offset = "0x6744030", VA = "0x186745630")]
	private static INCIOHANCNE PJMFJGBNFGC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MMLHCKCLJMK<T> : IDisposable where T : MMLHCKCLJMK<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T BOLGDNNEFAC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T MJFJCBEEADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x44ABCE0", Offset = "0x44AA6E0", VA = "0x1844ABCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	protected MMLHCKCLJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x44ABFB0", Offset = "0x44AA9B0", VA = "0x1844ABFB0", Slot = "5")]
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
