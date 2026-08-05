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
		private sealed class BKEDGBJGHJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public BKEDGBJGHJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6745340", Offset = "0x6743F40", VA = "0x186745340")]
			internal IEnumerable<MethodInfo> JPHIBIJLKPI(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67452E0", Offset = "0x6743EE0", VA = "0x1867452E0")]
			internal bool AMPMFKMGJIH(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BHADIGKKEEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public BHADIGKKEEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6745280", Offset = "0x6743E80", VA = "0x186745280")]
			internal bool GMBMJGBCEDJ(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class GFJKEKJAEGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public GFJKEKJAEGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67454C0", Offset = "0x67440C0", VA = "0x1867454C0")]
			internal bool IKOGNJMCDII(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<CBKAKHJHIKE, IGrouping<CBKAKHJHIKE, MethodInfo>> AOMOABFKEAG;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type DFCNHKOBOGK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6746C50", Offset = "0x6745850", VA = "0x186746C50")]
		private static void DANONJDDKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6748300", Offset = "0x6746F00", VA = "0x186748300")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6746B10", Offset = "0x6745710", VA = "0x186746B10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6746C00", Offset = "0x6745800", VA = "0x186746C00")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6746BB0", Offset = "0x67457B0", VA = "0x186746BB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6746B60", Offset = "0x6745760", VA = "0x186746B60")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6746A50", Offset = "0x6745650", VA = "0x186746A50")]
		private static void AJEAIPCIBHK(CBKAKHJHIKE NGDMKNMBCHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6748270", Offset = "0x6746E70", VA = "0x186748270")]
		private static IEnumerable<MethodInfo> OMCLIFMLHCP(Type DHDNIEBDLJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67472A0", Offset = "0x6745EA0", VA = "0x1867472A0")]
		private static bool INGMIHOJAEE(string MJEGMENNIPM, [Out] Dictionary<string, List<string>> APICICDMIHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67473C0", Offset = "0x6745FC0", VA = "0x1867473C0")]
		private static IEnumerable<Type> KGPALMBAINH(Dictionary<string, List<string>> APICICDMIHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67471C0", Offset = "0x6745DC0", VA = "0x1867471C0")]
		private static IEnumerable<MethodInfo> HKBJHAEHKBD(IEnumerable<Type> IIHAEOJGBKP, Type DHDNIEBDLJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6747AE0", Offset = "0x67466E0", VA = "0x186747AE0")]
		internal static IEnumerable<MethodInfo> KKLLBEICJOO(CBKAKHJHIKE NGDMKNMBCHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6747B70", Offset = "0x6746770", VA = "0x186747B70")]
		internal static void LIJMABINALL(IEnumerable<MethodInfo> HONEHGFDDBD, Type GNJOCHKBFBP, [Optional] object[] ENFOCCMDNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67480B0", Offset = "0x6746CB0", VA = "0x1867480B0")]
		private static Dictionary<CBKAKHJHIKE, IGrouping<CBKAKHJHIKE, MethodInfo>> MEAHNCOFMJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6748150", Offset = "0x6746D50", VA = "0x186748150")]
		private static bool MMPEIEEMBPC(MethodInfo FNCMANLIHKP, Type MGLOGCEKCLF, bool CNJEAJBFLPA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CHFAOCGAKIA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> ADKFBPNPJPM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> EGAOKIOKNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6745400", Offset = "0x6744000", VA = "0x186745400")]
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
		[Cpp2IlInjected.Address(RVA = "0x6748460", Offset = "0x6747060", VA = "0x186748460")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PFPBKKDCIIF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct GIPFGAFDEPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo EMHDCNEKCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JBEKPLNNIEC ADHIDMKPOJP;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<AMDAGODFNAF, List<GIPFGAFDEPI>> DOADHHAPECJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static LLIMAHMFNLB JFHGHHDGPJB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LLIMAHMFNLB CJENIPCOEDN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static LLIMAHMFNLB LBGAKKEIGHJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LLIMAHMFNLB MOHNEGNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6745D60", Offset = "0x6744960", VA = "0x186745D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LLIMAHMFNLB CAMPFCEJHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6745F00", Offset = "0x6744B00", VA = "0x186745F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static LLIMAHMFNLB CFAIACIJDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6745CE0", Offset = "0x67448E0", VA = "0x186745CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool HGPOHMNDDCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6745D20", Offset = "0x6744920", VA = "0x186745D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67466B0", Offset = "0x67452B0", VA = "0x1867466B0")]
	[IFAMMMEKLKB]
	private static void PGKNNEMMOJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6745E30", Offset = "0x6744A30", VA = "0x186745E30")]
	[JINDIHIDKGM(CBKAKHJHIKE.Unity_AfterAssembliesLoaded)]
	private static void LLPLKHKPJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6745F40", Offset = "0x6744B40", VA = "0x186745F40")]
	public static LLIMAHMFNLB NHAGNJBJABM(AMDAGODFNAF OCPKGIBEFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6746570", Offset = "0x6745170", VA = "0x186746570")]
	private static void NHAGNJBJABM(AMDAGODFNAF OCPKGIBEFGJ, LLIMAHMFNLB DAIMANBCFHH, LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6746180", Offset = "0x6744D80", VA = "0x186746180")]
	private static void NHAGNJBJABM(AMDAGODFNAF OCPKGIBEFGJ, LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6746930", Offset = "0x6745530", VA = "0x186746930")]
	public static void OHFMELKJHBM(AMDAGODFNAF OCPKGIBEFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x252DA60", Offset = "0x252C660", VA = "0x18252DA60")]
	private static bool MAPALECIHHC(JBEKPLNNIEC LAFMDAMIHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6745510", Offset = "0x6744110", VA = "0x186745510")]
	private static LLIMAHMFNLB ENPMOGIHJBG(string BJMLJMFLGKH, [Optional] LLIMAHMFNLB DAIMANBCFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6746760", Offset = "0x6745360", VA = "0x186746760")]
	private static void OHFMELKJHBM(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67466B0", Offset = "0x67452B0", VA = "0x1867466B0")]
	private static void NNDBKLHLNPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6745680", Offset = "0x6744280", VA = "0x186745680")]
	private static IEnumerable<GIPFGAFDEPI> FEJJGCEAMMB(AMDAGODFNAF OCPKGIBEFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6745C20", Offset = "0x6744820", VA = "0x186745C20")]
	private static LLIMAHMFNLB FPDDJAJKLMA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IAKPNFMDMLM<T> : IDisposable where T : IAKPNFMDMLM<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T HFEGKIPECIL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T GGKBGANLBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E640", Offset = "0x3E1D240", VA = "0x183E1E640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected IAKPNFMDMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E910", Offset = "0x3E1D510", VA = "0x183E1E910", Slot = "5")]
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
