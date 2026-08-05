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
public class IIBELCEICEH : ICNBDNKNJLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly KDEDNHGEBNP HNEMMEOAEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly INPGEEFAPCN JPKEADFNMMH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6044790", Offset = "0x6043390", VA = "0x186044790")]
	public IIBELCEICEH(INPGEEFAPCN JEJKKPCCFKI = INPGEEFAPCN.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6044750", Offset = "0x6043350", VA = "0x186044750")]
	public IIBELCEICEH(KDEDNHGEBNP OINBKCIAKIF, INPGEEFAPCN JEJKKPCCFKI = INPGEEFAPCN.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class EHECDKFEBPL : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60423F0", Offset = "0x6040FF0", VA = "0x1860423F0")]
	public EHECDKFEBPL(int KFNPPICHBLJ = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Method)]
public class ECPMKACBNFP : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly JMKOAIIKPBP JGMKPIIDKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int EGHNEAEEKBF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6041A30", Offset = "0x6040630", VA = "0x186041A30")]
	public ECPMKACBNFP(JMKOAIIKPBP KIOPBPFLOBC = JMKOAIIKPBP.ExitingPlayMode, int KFNPPICHBLJ = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JMKOAIIKPBP
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	ExitingPlayMode,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	EnteredEditMode,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	EnteredEditModeNextFrame
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public class KLLDLBHJIAE : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0")]
	public KLLDLBHJIAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method)]
public class ICNBDNKNJLD : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly BOALECCCJBK PECOHLDENOG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60423F0", Offset = "0x6040FF0", VA = "0x1860423F0")]
	public ICNBDNKNJLD(BOALECCCJBK CMANFLLEIMA = BOALECCCJBK.Unity_AfterSceneLoad)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BOALECCCJBK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Unity_AfterSceneLoad = 0,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Unity_BeforeSceneLoad = 1,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Unity_AfterAssembliesLoaded = 2,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Unity_BeforeSplashScreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Unity_SubsystemRegistration = 4,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	ManuallyInvoked = int.MaxValue
}
namespace RecRoom.Initialization
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class RuntimeInitializationHelper
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PIMNOLENNFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public PIMNOLENNFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6045FF0", Offset = "0x6044BF0", VA = "0x186045FF0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x60460C0", Offset = "0x6044CC0", VA = "0x1860460C0")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class JBFKEJMONEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public JBFKEJMONEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60447D0", Offset = "0x60433D0", VA = "0x1860447D0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GNLDBFAPIIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public GNLDBFAPIIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6044700", Offset = "0x6043300", VA = "0x186044700")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public const string KMGNCIHNFAB = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const string OHOCGODDAEP = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static Dictionary<BOALECCCJBK, IGrouping<BOALECCCJBK, MethodInfo>> PLKODFINBFH;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Type CIMIOPNJOAD;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6046C40", Offset = "0x6045840", VA = "0x186046C40")]
		private static void GIBFNDIKALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6047B90", Offset = "0x6046790", VA = "0x186047B90")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6046130", Offset = "0x6044D30", VA = "0x186046130")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60463A0", Offset = "0x6044FA0", VA = "0x1860463A0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6046350", Offset = "0x6044F50", VA = "0x186046350")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6046180", Offset = "0x6044D80", VA = "0x186046180")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6046B70", Offset = "0x6045770", VA = "0x186046B70")]
		private static void COFJDGEKODI(BOALECCCJBK CMANFLLEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6046290", Offset = "0x6044E90", VA = "0x186046290")]
		private static IEnumerable<MethodInfo> BDADDNNIFEM(Type IDOPAKBJEDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6047940", Offset = "0x6046540", VA = "0x186047940")]
		private static bool LKIODJGNBCD(string GINGNMFKHMN, out Dictionary<string, List<string>> DIJNPKKBLDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60463F0", Offset = "0x6044FF0", VA = "0x1860463F0")]
		private static IEnumerable<Type> CJACAOPFHNE(Dictionary<string, List<string>> DIJNPKKBLDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6047230", Offset = "0x6045E30", VA = "0x186047230")]
		private static IEnumerable<MethodInfo> GLAAKBJKHOM(IEnumerable<Type> BIPGMHLAMBH, Type IDOPAKBJEDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6047B00", Offset = "0x6046700", VA = "0x186047B00")]
		internal static IEnumerable<MethodInfo> ODNNPFEAIEN(BOALECCCJBK CMANFLLEIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6047430", Offset = "0x6046030", VA = "0x186047430")]
		internal static void LHKACDJAEEN(IEnumerable<MethodInfo> ALMBHEIJKFJ, Type JDCEEFPGBHD, [Optional] object[] ENIALHNPBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60461D0", Offset = "0x6044DD0", VA = "0x1860461D0")]
		private static Dictionary<BOALECCCJBK, IGrouping<BOALECCCJBK, MethodInfo>> BABNKANLDEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6047310", Offset = "0x6045F10", VA = "0x186047310")]
		private static bool JGPOJPOIKBF(MethodInfo FNCJNLKEPAD, Type DAFDAABLHLO, bool FLIAHFBOIDP)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6047D00", Offset = "0x6046900", VA = "0x186047D00")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LJAKMLAFKIL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private struct HMBLPDFOIGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public MethodInfo JMHEMAOBKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public INPGEEFAPCN JPKEADFNMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool NIGJHHAELEL;
	}

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static Dictionary<KDEDNHGEBNP, List<HMBLPDFOIGD>> JBDMJELNJEP;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static HGCFMABKDDJ KBHJLAPDNLK;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static HGCFMABKDDJ KOFPHAMLKGI;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static HGCFMABKDDJ DGLIIAGBBDE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HGCFMABKDDJ AJIGMJGLFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6045F00", Offset = "0x6044B00", VA = "0x186045F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HGCFMABKDDJ HHFBAMNODPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6045EC0", Offset = "0x6044AC0", VA = "0x186045EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HGCFMABKDDJ LINPKMEFHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6045CE0", Offset = "0x60448E0", VA = "0x186045CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6045E10", Offset = "0x6044A10", VA = "0x186045E10")]
	[KLLDLBHJIAE]
	private static void PDNFMMCIAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6045D20", Offset = "0x6044920", VA = "0x186045D20")]
	[ICNBDNKNJLD(BOALECCCJBK.Unity_AfterAssembliesLoaded)]
	private static void NLIBFEAGIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6044EA0", Offset = "0x6043AA0", VA = "0x186044EA0")]
	public static HGCFMABKDDJ DPJFEAPNMCM(KDEDNHGEBNP OINBKCIAKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60450E0", Offset = "0x6043CE0", VA = "0x1860450E0")]
	private static void DPJFEAPNMCM(KDEDNHGEBNP OINBKCIAKIF, HGCFMABKDDJ PPLKNGGGHBP, ref HGCFMABKDDJ FLBJMLJLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6044840", Offset = "0x6043440", VA = "0x186044840")]
	private static void DPJFEAPNMCM(KDEDNHGEBNP OINBKCIAKIF, HGCFMABKDDJ FLBJMLJLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6045270", Offset = "0x6043E70", VA = "0x186045270")]
	public static void EMJKLHMFLED(KDEDNHGEBNP OINBKCIAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6045C00", Offset = "0x6044800", VA = "0x186045C00")]
	private static bool MKLCEBKCDHA(INPGEEFAPCN JEJKKPCCFKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6045B10", Offset = "0x6044710", VA = "0x186045B10")]
	private static HGCFMABKDDJ HKGIPEPAOCC(string CFAONFCKLLC, [Optional] HGCFMABKDDJ PPLKNGGGHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6045380", Offset = "0x6043F80", VA = "0x186045380")]
	private static void EMJKLHMFLED(ref HGCFMABKDDJ FLBJMLJLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6045E10", Offset = "0x6044A10", VA = "0x186045E10")]
	private static void NMGMIAPEEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6045540", Offset = "0x6044140", VA = "0x186045540")]
	private static IEnumerable<HMBLPDFOIGD> HBCNBIFHENB(KDEDNHGEBNP OINBKCIAKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6045450", Offset = "0x6044050", VA = "0x186045450")]
	private static HGCFMABKDDJ FJBDFNGJNNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BLGALNOFCFE<T> : IDisposable where T : global::BLGALNOFCFE<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static T CFBIOKMMOEB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T EBMHMHOHCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x288B590", Offset = "0x288A190", VA = "0x18288B590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
	protected BLGALNOFCFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x288B550", Offset = "0x288A150", VA = "0x18288B550", Slot = "5")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum INPGEEFAPCN
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	EditorOnly = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	GameOnly = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum KDEDNHGEBNP
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Root,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Session,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
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
