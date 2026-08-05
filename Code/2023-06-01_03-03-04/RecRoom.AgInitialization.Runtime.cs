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
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F68960", Offset = "0x6F67560", VA = "0x186F68960")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class CPEKGFHODND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public CPEKGFHODND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F65570", Offset = "0x6F64170", VA = "0x186F65570")]
			internal IEnumerable<MethodInfo> BMMLHLHEOIL(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F65640", Offset = "0x6F64240", VA = "0x186F65640")]
			internal bool LIIBJIDPJKA(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class FMLDPGNFPAD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public FMLDPGNFPAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F656B0", Offset = "0x6F642B0", VA = "0x186F656B0")]
			internal bool HEDHKINEBEB(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HKLJMLJJGKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public HKLJMLJJGKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F65720", Offset = "0x6F64320", VA = "0x186F65720")]
			internal bool OFMGJDOAGAO(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string AMMOENOMDEC = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string MHGCPGOMAIF = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<OEMLBLOOECK, IGrouping<OEMLBLOOECK, MethodInfo>> DEDPMHGEKLN;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type JALCKHAPHKG;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F67870", Offset = "0x6F66470", VA = "0x186F67870")]
		private static void GLDEKEJJKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F687F0", Offset = "0x6F673F0", VA = "0x186F687F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F66D90", Offset = "0x6F65990", VA = "0x186F66D90")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F40", Offset = "0x6F65B40", VA = "0x186F66F40")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F66EF0", Offset = "0x6F65AF0", VA = "0x186F66EF0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F66DE0", Offset = "0x6F659E0", VA = "0x186F66DE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F67020", Offset = "0x6F65C20", VA = "0x186F67020")]
		private static void EGHPKLLJEFA(OEMLBLOOECK DMNLINKFLAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F68370", Offset = "0x6F66F70", VA = "0x186F68370")]
		private static IEnumerable<MethodInfo> JCHKPONBKLK(Type FHAKPHFBAMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F68630", Offset = "0x6F67230", VA = "0x186F68630")]
		private static bool KPEANHJHOMK(string KEGCCBBGEPM, out Dictionary<string, List<string>> BHJNLKKMJOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F670F0", Offset = "0x6F65CF0", VA = "0x186F670F0")]
		private static IEnumerable<Type> GGHOOGPAODJ(Dictionary<string, List<string>> BHJNLKKMJOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F68550", Offset = "0x6F67150", VA = "0x186F68550")]
		private static IEnumerable<MethodInfo> KKGIFDKLMCE(IEnumerable<Type> LONDNADJAMP, Type FHAKPHFBAMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F90", Offset = "0x6F65B90", VA = "0x186F66F90")]
		internal static IEnumerable<MethodInfo> DHCNMPKGFED(OEMLBLOOECK DMNLINKFLAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F67E60", Offset = "0x6F66A60", VA = "0x186F67E60")]
		internal static void INLBLAOIEGM(IEnumerable<MethodInfo> KGECLNGJJGL, Type DDFCJLDLFGC, [Optional] object[] DAKKAABHBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F66E30", Offset = "0x6F65A30", VA = "0x186F66E30")]
		private static Dictionary<OEMLBLOOECK, IGrouping<OEMLBLOOECK, MethodInfo>> BOPCKHKNLCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F68430", Offset = "0x6F67030", VA = "0x186F68430")]
		private static bool KIAGLMAPBDF(MethodInfo FJOEMKIGLIC, Type JFOMCKHJNOP, bool GNBFLJABEKP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JDHKJHDNLMI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct IKGECKKFLKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo JACINFDELEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EDNJEIFHIMJ BKKIDBBNLPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<BLGLNFDFDJO, List<IKGECKKFLKH>> BCIPLNKGGJN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static MHOBEFMLEFD KHMAFBBLIID;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static MHOBEFMLEFD HNGJMJICJBM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MHOBEFMLEFD IOLKACNAGJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MHOBEFMLEFD ODFEIMILGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F66480", Offset = "0x6F65080", VA = "0x186F66480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MHOBEFMLEFD OHGPOPBBIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F65A70", Offset = "0x6F64670", VA = "0x186F65A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MHOBEFMLEFD LEHHFPENHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F65AB0", Offset = "0x6F646B0", VA = "0x186F65AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F65AF0", Offset = "0x6F646F0", VA = "0x186F65AF0")]
	[JFKPICHOBNP]
	private static void HOBPBOCADCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F66210", Offset = "0x6F64E10", VA = "0x186F66210")]
	[GOLHGLLJIPN(OEMLBLOOECK.Unity_AfterAssembliesLoaded)]
	private static void JPNLJCGDOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F669B0", Offset = "0x6F655B0", VA = "0x186F669B0")]
	public static MHOBEFMLEFD OPGDHOIHBNK(BLGLNFDFDJO EENKPDMMAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F66C00", Offset = "0x6F65800", VA = "0x186F66C00")]
	private static void OPGDHOIHBNK(BLGLNFDFDJO EENKPDMMAPL, MHOBEFMLEFD EOHDEJOCEFD, ref MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F66570", Offset = "0x6F65170", VA = "0x186F66570")]
	private static void OPGDHOIHBNK(BLGLNFDFDJO EENKPDMMAPL, MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F65960", Offset = "0x6F64560", VA = "0x186F65960")]
	public static void AIOKBDCGIKB(BLGLNFDFDJO EENKPDMMAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F66130", Offset = "0x6F64D30", VA = "0x186F66130")]
	private static bool JEEPCFICJFL(EDNJEIFHIMJ IBDHMNLNLJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F66300", Offset = "0x6F64F00", VA = "0x186F66300")]
	private static MHOBEFMLEFD LJNFCOJPLGL(string EKBMKNPFLLG, [Optional] MHOBEFMLEFD EOHDEJOCEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F65770", Offset = "0x6F64370", VA = "0x186F65770")]
	private static void AIOKBDCGIKB(ref MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F65AF0", Offset = "0x6F646F0", VA = "0x186F65AF0")]
	private static void GOLEMJHJMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F65BA0", Offset = "0x6F647A0", VA = "0x186F65BA0")]
	private static IEnumerable<IKGECKKFLKH> IFGNHMCALON(BLGLNFDFDJO EENKPDMMAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F66480", Offset = "0x6F65080", VA = "0x186F66480")]
	private static MHOBEFMLEFD PDODAKOBMLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ABCKONBHMBO<T> : IDisposable where T : ABCKONBHMBO<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T PKIKEDNMDGD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T EABDDJEADPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4B615C0", Offset = "0x4B601C0", VA = "0x184B615C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14FE990", Offset = "0x14FD590", VA = "0x1814FE990")]
	protected ABCKONBHMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4B61580", Offset = "0x4B60180", VA = "0x184B61580", Slot = "5")]
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
