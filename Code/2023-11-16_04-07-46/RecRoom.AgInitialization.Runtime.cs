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
		private sealed class LKAIDHOEEEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public LKAIDHOEEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5CF0F20", Offset = "0x5CEFF20", VA = "0x185CF0F20")]
			internal IEnumerable<MethodInfo> MHFMAGDJEHL(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5CF0FE0", Offset = "0x5CEFFE0", VA = "0x185CF0FE0")]
			internal bool NMPHFCKMCGB(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class BKGHBFBAAJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public BKGHBFBAAJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5CEF8B0", Offset = "0x5CEE8B0", VA = "0x185CEF8B0")]
			internal bool IPPBGNFMEFH(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class DCMNOMBAFAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public DCMNOMBAFAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5CF0E10", Offset = "0x5CEFE10", VA = "0x185CF0E10")]
			internal bool OLEPFGNINIG(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<HMIDDPKLECI, IGrouping<HMIDDPKLECI, MethodInfo>> JAMPCBJHFEA;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type IDHMAKPHENK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5CF13D0", Offset = "0x5CF03D0", VA = "0x185CF13D0")]
		private static void KKKPHJLOMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CF28C0", Offset = "0x5CF18C0", VA = "0x185CF28C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1040", Offset = "0x5CF0040", VA = "0x185CF1040")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1130", Offset = "0x5CF0130", VA = "0x185CF1130")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5CF10E0", Offset = "0x5CF00E0", VA = "0x185CF10E0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1090", Offset = "0x5CF0090", VA = "0x185CF1090")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1940", Offset = "0x5CF0940", VA = "0x185CF1940")]
		private static void LLKJMHOCLHL(HMIDDPKLECI JMHCKGIAPGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CF12A0", Offset = "0x5CF02A0", VA = "0x185CF12A0")]
		private static IEnumerable<MethodInfo> FGABHLNJENK(Type CIEHPAHMFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1180", Offset = "0x5CF0180", VA = "0x185CF1180")]
		private static bool COLCHJECJJO(string CKOKDENOFCE, [Out] Dictionary<string, List<string>> AMOBMLHIDGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2120", Offset = "0x5CF1120", VA = "0x185CF2120")]
		private static IEnumerable<Type> OIMGMDHHABF(Dictionary<string, List<string>> AMOBMLHIDGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1A00", Offset = "0x5CF0A00", VA = "0x185CF1A00")]
		private static IEnumerable<MethodInfo> LPIAMGEDLJE(IEnumerable<Type> AEOENHDANFE, Type CIEHPAHMFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2830", Offset = "0x5CF1830", VA = "0x185CF2830")]
		internal static IEnumerable<MethodInfo> PKPMKMDDJIH(HMIDDPKLECI JMHCKGIAPGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1AE0", Offset = "0x5CF0AE0", VA = "0x185CF1AE0")]
		internal static void MFGHMJGBGNM(IEnumerable<MethodInfo> LDPHOMEDLBG, Type DCOEKDEGDMH, [Optional] object[] DFHMEJDFNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CF1330", Offset = "0x5CF0330", VA = "0x185CF1330")]
		private static Dictionary<HMIDDPKLECI, IGrouping<HMIDDPKLECI, MethodInfo>> FJJFHJJAAEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2000", Offset = "0x5CF1000", VA = "0x185CF2000")]
		private static bool NDEGCFINFEP(MethodInfo OEBOPIBGPPB, Type GNDFNLGHLFF, bool DMGCLMNFMMO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class KHKABNNHFKA
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> NCAIIJLINCE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> FADPAAAOBGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0E60", Offset = "0x5CEFE60", VA = "0x185CF0E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CF2A20", Offset = "0x5CF1A20", VA = "0x185CF2A20")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CPHCHJBIIMM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct KBFGKBEANHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo DFIADCIJMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public OMIAJJHDDGO EGBHONKAJEL;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<OPHHJIDIAGK, List<KBFGKBEANHF>> CFACIDLALNK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static EIABFOFJCDK MNNNAFHIJCH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static EIABFOFJCDK DPHCODMJCED;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static EIABFOFJCDK BKLNILDALLM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static EIABFOFJCDK FMAEDMDFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CF03E0", Offset = "0x5CEF3E0", VA = "0x185CF03E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static EIABFOFJCDK DBFLAIGNLAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF910", Offset = "0x5CEE910", VA = "0x185CEF910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static EIABFOFJCDK GJMIIAOFCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5CF02E0", Offset = "0x5CEF2E0", VA = "0x185CF02E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0230", Offset = "0x5CEF230", VA = "0x185CF0230")]
	[MGLDGFMEHGD]
	private static void IALDGMIADBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0D40", Offset = "0x5CEFD40", VA = "0x185CF0D40")]
	[GABBFJBHOKF(HMIDDPKLECI.Unity_AfterAssembliesLoaded)]
	private static void PIFAFJKENON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFAC0", Offset = "0x5CEEAC0", VA = "0x185CEFAC0")]
	public static EIABFOFJCDK GNKNAGAGMBF(OPHHJIDIAGK GGJDDKJMLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFD00", Offset = "0x5CEED00", VA = "0x185CEFD00")]
	private static void GNKNAGAGMBF(OPHHJIDIAGK GGJDDKJMLHI, EIABFOFJCDK BKLFELEFPAL, EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFE40", Offset = "0x5CEEE40", VA = "0x185CEFE40")]
	private static void GNKNAGAGMBF(OPHHJIDIAGK GGJDDKJMLHI, EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0C20", Offset = "0x5CEFC20", VA = "0x185CF0C20")]
	public static void OBEABAKPGNH(OPHHJIDIAGK GGJDDKJMLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x34DFFC0", Offset = "0x34DEFC0", VA = "0x1834DFFC0")]
	private static bool FBGKKMAGLHN(OMIAJJHDDGO HFBBBONDFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF950", Offset = "0x5CEE950", VA = "0x185CEF950")]
	private static EIABFOFJCDK GIKKGNCCENI(string JKIEOHKIFBH, [Optional] EIABFOFJCDK BKLFELEFPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0A50", Offset = "0x5CEFA50", VA = "0x185CF0A50")]
	private static void OBEABAKPGNH(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0230", Offset = "0x5CEF230", VA = "0x185CF0230")]
	private static void INAJMJCGNIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF04B0", Offset = "0x5CEF4B0", VA = "0x185CF04B0")]
	private static IEnumerable<KBFGKBEANHF> NPMMHFNLLAN(OPHHJIDIAGK GGJDDKJMLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0320", Offset = "0x5CEF320", VA = "0x185CF0320")]
	private static EIABFOFJCDK NKOBGAIHKFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OOFHKLNMFIB<T> : IDisposable where T : OOFHKLNMFIB<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T PBJLMCDEAOF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T NKFKDADGOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EC20", Offset = "0x3E0DC20", VA = "0x183E0EC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	protected OOFHKLNMFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3E0EBE0", Offset = "0x3E0DBE0", VA = "0x183E0EBE0", Slot = "5")]
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
