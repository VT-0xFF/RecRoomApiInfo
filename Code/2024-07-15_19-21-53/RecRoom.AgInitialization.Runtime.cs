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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public LLNLGCEMGOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6745650", Offset = "0x6743E50", VA = "0x186745650")]
			internal IEnumerable<MethodInfo> BOCEBPOHCFN(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6745710", Offset = "0x6743F10", VA = "0x186745710")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public JDBONFEBGJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x67455F0", Offset = "0x6743DF0", VA = "0x1867455F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public ADNFMFEEMEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6743FA0", Offset = "0x67427A0", VA = "0x186743FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6746AB0", Offset = "0x67452B0", VA = "0x186746AB0")]
		private static void PGAOEFOGFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6747020", Offset = "0x6745820", VA = "0x186747020")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67458C0", Offset = "0x67440C0", VA = "0x1867458C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6745A50", Offset = "0x6744250", VA = "0x186745A50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6745A00", Offset = "0x6744200", VA = "0x186745A00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6745910", Offset = "0x6744110", VA = "0x186745910")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6745800", Offset = "0x6744000", VA = "0x186745800")]
		private static void AFBOIOGKJGF(MJLCCMEEJMA CGNIBFGKCMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6746940", Offset = "0x6745140", VA = "0x186746940")]
		private static IEnumerable<MethodInfo> JOBIMCJJKNL(Type JLDNINICBDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6745BC0", Offset = "0x67443C0", VA = "0x186745BC0")]
		private static bool DKIGCHDMCNI(string EOECEMBLGPP, [Out] Dictionary<string, List<string>> DPFAOFMILGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6745CE0", Offset = "0x67444E0", VA = "0x186745CE0")]
		private static IEnumerable<Type> ELIKBKMPNGE(Dictionary<string, List<string>> DPFAOFMILGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67469D0", Offset = "0x67451D0", VA = "0x1867469D0")]
		private static IEnumerable<MethodInfo> LDIECJLBAMC(IEnumerable<Type> DGLFPPDJICE, Type JLDNINICBDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6745770", Offset = "0x6743F70", VA = "0x186745770")]
		internal static IEnumerable<MethodInfo> ACGFHNOPPGJ(MJLCCMEEJMA CGNIBFGKCMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6746400", Offset = "0x6744C00", VA = "0x186746400")]
		internal static void EPOGJOCFJFM(IEnumerable<MethodInfo> IPGMMCKMPDK, Type LGFAKEDPPNG, [Optional] object[] LDMPLMIKDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6745960", Offset = "0x6744160", VA = "0x186745960")]
		private static Dictionary<MJLCCMEEJMA, IGrouping<MJLCCMEEJMA, MethodInfo>> BNJIJOBINED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6745AA0", Offset = "0x67442A0", VA = "0x186745AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6743FF0", Offset = "0x67427F0", VA = "0x186743FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6747180", Offset = "0x6745980", VA = "0x186747180")]
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
		[Cpp2IlInjected.Address(RVA = "0x6744BE0", Offset = "0x67433E0", VA = "0x186744BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static INCIOHANCNE ODKOCJOOHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6744BA0", Offset = "0x67433A0", VA = "0x186744BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static INCIOHANCNE PMFGCGHPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67454F0", Offset = "0x6743CF0", VA = "0x1867454F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool OCGCLHIGNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6744B60", Offset = "0x6743360", VA = "0x186744B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67447C0", Offset = "0x6742FC0", VA = "0x1867447C0")]
	[KDMKPJDAJLL]
	private static void EPEFAHGCDED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6745420", Offset = "0x6743C20", VA = "0x186745420")]
	[FCFOCBHCEIP(MJLCCMEEJMA.Unity_AfterAssembliesLoaded)]
	private static void LCDCAKLDKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6744CB0", Offset = "0x67434B0", VA = "0x186744CB0")]
	public static INCIOHANCNE KFAANGMGFBB(JAFPILLCEJB AOANHMLCKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67452E0", Offset = "0x6743AE0", VA = "0x1867452E0")]
	private static void KFAANGMGFBB(JAFPILLCEJB AOANHMLCKPG, INCIOHANCNE OOEKFBLDDAA, INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6744EF0", Offset = "0x67436F0", VA = "0x186744EF0")]
	private static void KFAANGMGFBB(JAFPILLCEJB AOANHMLCKPG, INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6744A40", Offset = "0x6743240", VA = "0x186744A40")]
	public static void FDAHEMCLIJO(JAFPILLCEJB AOANHMLCKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2576240", Offset = "0x2574A40", VA = "0x182576240")]
	private static bool KDEBKIDEFBA(JMIPDAHBNNG ANGEEBBNNIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67440B0", Offset = "0x67428B0", VA = "0x1867440B0")]
	private static INCIOHANCNE EAHKIMMMHCG(string PLAKPHMPIIP, [Optional] INCIOHANCNE OOEKFBLDDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6744870", Offset = "0x6743070", VA = "0x186744870")]
	private static void FDAHEMCLIJO(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67447C0", Offset = "0x6742FC0", VA = "0x1867447C0")]
	private static void OMFHNDNJLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6744220", Offset = "0x6742A20", VA = "0x186744220")]
	private static IEnumerable<MGJKIPEAOMK> EOHEKEGJDKJ(JAFPILLCEJB AOANHMLCKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6745530", Offset = "0x6743D30", VA = "0x186745530")]
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
		[Cpp2IlInjected.Address(RVA = "0x44ABBE0", Offset = "0x44AA3E0", VA = "0x1844ABBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	protected MMLHCKCLJMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x44ABEB0", Offset = "0x44AA6B0", VA = "0x1844ABEB0", Slot = "5")]
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
