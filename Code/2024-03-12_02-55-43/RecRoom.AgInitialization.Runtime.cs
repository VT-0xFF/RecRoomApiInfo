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
		private sealed class CEKBLPBAHBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public CEKBLPBAHBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5FF1CB0", Offset = "0x5FF0EB0", VA = "0x185FF1CB0")]
			internal IEnumerable<MethodInfo> BBLLBDKPAKP(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5FF1D70", Offset = "0x5FF0F70", VA = "0x185FF1D70")]
			internal bool KEEGAJNNODK(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class EJBNEDHGADC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public EJBNEDHGADC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5FF32D0", Offset = "0x5FF24D0", VA = "0x185FF32D0")]
			internal bool FMDBDFPPCBM(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class LJMGFPJMIGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public LJMGFPJMIGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5FF3330", Offset = "0x5FF2530", VA = "0x185FF3330")]
			internal bool JNIMKKGGBFF(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<BDNMCGCKBGD, IGrouping<BDNMCGCKBGD, MethodInfo>> JPEDNGCADBM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type JIFICJIKEAI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4670", Offset = "0x5FF3870", VA = "0x185FF4670")]
		private static void MKBBNIOBBMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4CC0", Offset = "0x5FF3EC0", VA = "0x185FF4CC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5FF34D0", Offset = "0x5FF26D0", VA = "0x185FF34D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FF35C0", Offset = "0x5FF27C0", VA = "0x185FF35C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3570", Offset = "0x5FF2770", VA = "0x185FF3570")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3520", Offset = "0x5FF2720", VA = "0x185FF3520")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FF37C0", Offset = "0x5FF29C0", VA = "0x185FF37C0")]
		private static void GIPPAIGPICN(BDNMCGCKBGD FGDPNNCBGJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3440", Offset = "0x5FF2640", VA = "0x185FF3440")]
		private static IEnumerable<MethodInfo> APPHELKBBCN(Type EDBNGGKOPDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4550", Offset = "0x5FF3750", VA = "0x185FF4550")]
		private static bool MAKGMIKCJGL(string JGODIGDGHKP, [Out] Dictionary<string, List<string>> KGHEMIMFOAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3DA0", Offset = "0x5FF2FA0", VA = "0x185FF3DA0")]
		private static IEnumerable<Type> JOIENPPLNMP(Dictionary<string, List<string>> KGHEMIMFOAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4BE0", Offset = "0x5FF3DE0", VA = "0x185FF4BE0")]
		private static IEnumerable<MethodInfo> OAABMHHLMDB(IEnumerable<Type> BNLOCHPCJJL, Type EDBNGGKOPDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3730", Offset = "0x5FF2930", VA = "0x185FF3730")]
		internal static IEnumerable<MethodInfo> FDLAEBJELIP(BDNMCGCKBGD FGDPNNCBGJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3880", Offset = "0x5FF2A80", VA = "0x185FF3880")]
		internal static void JOCGONCGAPE(IEnumerable<MethodInfo> FEMLFJIPEOC, Type APDKNLCCOKM, [Optional] object[] BFBOJFAJKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FF44B0", Offset = "0x5FF36B0", VA = "0x185FF44B0")]
		private static Dictionary<BDNMCGCKBGD, IGrouping<BDNMCGCKBGD, MethodInfo>> KDCCHGFKAJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3610", Offset = "0x5FF2810", VA = "0x185FF3610")]
		private static bool CDNFMBMCKMM(MethodInfo OMHCFJCOENO, Type ALKBCJLPJIK, bool APCHPABIDKF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OGJNNKCMICP
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> CIGCBPOFLIM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> KMLPKDLDDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3380", Offset = "0x5FF2580", VA = "0x185FF3380")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FF4E20", Offset = "0x5FF4020", VA = "0x185FF4E20")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DPHLEANGIBH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct EEELKGIAEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo BMJDCOMMDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public LIEILBDPEFI ACPJCAIPEDE;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<MDFHPBOGAKL, List<EEELKGIAEGC>> KALAPJJHCAE;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static IAIHJGNDPNA PFAAPCGLOOA;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static IAIHJGNDPNA PHBICCONKMK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static IAIHJGNDPNA ALMKLINAAHF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IAIHJGNDPNA EJPDLJOMEBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF25A0", Offset = "0x5FF17A0", VA = "0x185FF25A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IAIHJGNDPNA KECIBNJBMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2B20", Offset = "0x5FF1D20", VA = "0x185FF2B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static IAIHJGNDPNA KOPNCCJNFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FF27F0", Offset = "0x5FF19F0", VA = "0x185FF27F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2740", Offset = "0x5FF1940", VA = "0x185FF2740")]
	[HOMGOLIFNMI]
	private static void OPDDMCOIENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2670", Offset = "0x5FF1870", VA = "0x185FF2670")]
	[NHKJGMGAMEG(BDNMCGCKBGD.Unity_AfterAssembliesLoaded)]
	private static void HONMFDPLPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2CA0", Offset = "0x5FF1EA0", VA = "0x185FF2CA0")]
	public static IAIHJGNDPNA OJEJJDOKCMO(MDFHPBOGAKL HNHFKCGHLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2B60", Offset = "0x5FF1D60", VA = "0x185FF2B60")]
	private static void OJEJJDOKCMO(MDFHPBOGAKL HNHFKCGHLEF, IAIHJGNDPNA BCFAEHPOPNM, IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2EE0", Offset = "0x5FF20E0", VA = "0x185FF2EE0")]
	private static void OJEJJDOKCMO(MDFHPBOGAKL HNHFKCGHLEF, IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2A00", Offset = "0x5FF1C00", VA = "0x185FF2A00")]
	public static void LHPOCNIPHAK(MDFHPBOGAKL HNHFKCGHLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2292AD0", Offset = "0x2291CD0", VA = "0x182292AD0")]
	private static bool OMCKBEEFMLC(LIEILBDPEFI GHOAKBDCDOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1DD0", Offset = "0x5FF0FD0", VA = "0x185FF1DD0")]
	private static IAIHJGNDPNA BAEIIGAJBGC(string DOEFJNPLKMA, [Optional] IAIHJGNDPNA BCFAEHPOPNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2830", Offset = "0x5FF1A30", VA = "0x185FF2830")]
	private static void LHPOCNIPHAK(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2740", Offset = "0x5FF1940", VA = "0x185FF2740")]
	private static void IGHCHECJNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FF1F40", Offset = "0x5FF1140", VA = "0x185FF1F40")]
	private static IEnumerable<EEELKGIAEGC> CAPEFKHFKHG(MDFHPBOGAKL HNHFKCGHLEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF24E0", Offset = "0x5FF16E0", VA = "0x185FF24E0")]
	private static IAIHJGNDPNA CIJIPOHKJEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HMLEIGFOBJN<T> : IDisposable where T : HMLEIGFOBJN<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T PHLEALHFEPH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T MJANIPKLNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3800DF0", Offset = "0x37FFFF0", VA = "0x183800DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	protected HMLEIGFOBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3800DB0", Offset = "0x37FFFB0", VA = "0x183800DB0", Slot = "5")]
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
