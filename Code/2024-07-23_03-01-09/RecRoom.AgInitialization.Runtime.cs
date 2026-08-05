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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public LLNLGCEMGOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x675F360", Offset = "0x675E560", VA = "0x18675F360")]
			internal IEnumerable<MethodInfo> BOCEBPOHCFN(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x675F420", Offset = "0x675E620", VA = "0x18675F420")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public JDBONFEBGJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x675F300", Offset = "0x675E500", VA = "0x18675F300")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public ADNFMFEEMEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x675DCB0", Offset = "0x675CEB0", VA = "0x18675DCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67607C0", Offset = "0x675F9C0", VA = "0x1867607C0")]
		private static void PGAOEFOGFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6760D30", Offset = "0x675FF30", VA = "0x186760D30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x675F5D0", Offset = "0x675E7D0", VA = "0x18675F5D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x675F760", Offset = "0x675E960", VA = "0x18675F760")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x675F710", Offset = "0x675E910", VA = "0x18675F710")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x675F620", Offset = "0x675E820", VA = "0x18675F620")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x675F510", Offset = "0x675E710", VA = "0x18675F510")]
		private static void AFBOIOGKJGF(MJLCCMEEJMA CGNIBFGKCMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6760650", Offset = "0x675F850", VA = "0x186760650")]
		private static IEnumerable<MethodInfo> JOBIMCJJKNL(Type JLDNINICBDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x675F8D0", Offset = "0x675EAD0", VA = "0x18675F8D0")]
		private static bool DKIGCHDMCNI(string EOECEMBLGPP, [Out] Dictionary<string, List<string>> DPFAOFMILGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x675F9F0", Offset = "0x675EBF0", VA = "0x18675F9F0")]
		private static IEnumerable<Type> ELIKBKMPNGE(Dictionary<string, List<string>> DPFAOFMILGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67606E0", Offset = "0x675F8E0", VA = "0x1867606E0")]
		private static IEnumerable<MethodInfo> LDIECJLBAMC(IEnumerable<Type> DGLFPPDJICE, Type JLDNINICBDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x675F480", Offset = "0x675E680", VA = "0x18675F480")]
		internal static IEnumerable<MethodInfo> ACGFHNOPPGJ(MJLCCMEEJMA CGNIBFGKCMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6760110", Offset = "0x675F310", VA = "0x186760110")]
		internal static void EPOGJOCFJFM(IEnumerable<MethodInfo> IPGMMCKMPDK, Type LGFAKEDPPNG, [Optional] object[] LDMPLMIKDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x675F670", Offset = "0x675E870", VA = "0x18675F670")]
		private static Dictionary<MJLCCMEEJMA, IGrouping<MJLCCMEEJMA, MethodInfo>> BNJIJOBINED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x675F7B0", Offset = "0x675E9B0", VA = "0x18675F7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x675DD00", Offset = "0x675CF00", VA = "0x18675DD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6760E90", Offset = "0x6760090", VA = "0x186760E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x675E8F0", Offset = "0x675DAF0", VA = "0x18675E8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static INCIOHANCNE ODKOCJOOHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x675E8B0", Offset = "0x675DAB0", VA = "0x18675E8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static INCIOHANCNE PMFGCGHPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x675F200", Offset = "0x675E400", VA = "0x18675F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool OCGCLHIGNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x675E870", Offset = "0x675DA70", VA = "0x18675E870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x675E4D0", Offset = "0x675D6D0", VA = "0x18675E4D0")]
	[KDMKPJDAJLL]
	private static void EPEFAHGCDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x675F130", Offset = "0x675E330", VA = "0x18675F130")]
	[FCFOCBHCEIP(MJLCCMEEJMA.Unity_AfterAssembliesLoaded)]
	private static void LCDCAKLDKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x675E9C0", Offset = "0x675DBC0", VA = "0x18675E9C0")]
	public static INCIOHANCNE KFAANGMGFBB(JAFPILLCEJB AOANHMLCKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x675EFF0", Offset = "0x675E1F0", VA = "0x18675EFF0")]
	private static void KFAANGMGFBB(JAFPILLCEJB AOANHMLCKPG, INCIOHANCNE OOEKFBLDDAA, INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x675EC00", Offset = "0x675DE00", VA = "0x18675EC00")]
	private static void KFAANGMGFBB(JAFPILLCEJB AOANHMLCKPG, INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x675E750", Offset = "0x675D950", VA = "0x18675E750")]
	public static void FDAHEMCLIJO(JAFPILLCEJB AOANHMLCKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2585120", Offset = "0x2584320", VA = "0x182585120")]
	private static bool KDEBKIDEFBA(JMIPDAHBNNG ANGEEBBNNIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x675DDC0", Offset = "0x675CFC0", VA = "0x18675DDC0")]
	private static INCIOHANCNE EAHKIMMMHCG(string PLAKPHMPIIP, [Optional] INCIOHANCNE OOEKFBLDDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x675E580", Offset = "0x675D780", VA = "0x18675E580")]
	private static void FDAHEMCLIJO(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x675E4D0", Offset = "0x675D6D0", VA = "0x18675E4D0")]
	private static void OMFHNDNJLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x675DF30", Offset = "0x675D130", VA = "0x18675DF30")]
	private static IEnumerable<MGJKIPEAOMK> EOHEKEGJDKJ(JAFPILLCEJB AOANHMLCKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x675F240", Offset = "0x675E440", VA = "0x18675F240")]
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
		[Cpp2IlInjected.Address(RVA = "0x44C1480", Offset = "0x44C0680", VA = "0x1844C1480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	protected MMLHCKCLJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x44C1750", Offset = "0x44C0950", VA = "0x1844C1750", Slot = "5")]
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
