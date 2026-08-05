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
	[Cpp2IlInjected.Address(RVA = "0x5E7BD30", Offset = "0x5E7AB30", VA = "0x185E7BD30")]
	public IIBELCEICEH(INPGEEFAPCN JEJKKPCCFKI = INPGEEFAPCN.None)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BCF0", Offset = "0x5E7AAF0", VA = "0x185E7BCF0")]
	public IIBELCEICEH(KDEDNHGEBNP OINBKCIAKIF, INPGEEFAPCN JEJKKPCCFKI = INPGEEFAPCN.None)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Method)]
public class EHECDKFEBPL : PreserveAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E79990", Offset = "0x5E78790", VA = "0x185E79990")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E78FD0", Offset = "0x5E77DD0", VA = "0x185E78FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E79990", Offset = "0x5E78790", VA = "0x185E79990")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public PIMNOLENNFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D590", Offset = "0x5E7C390", VA = "0x185E7D590")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D660", Offset = "0x5E7C460", VA = "0x185E7D660")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public JBFKEJMONEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BD70", Offset = "0x5E7AB70", VA = "0x185E7BD70")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public GNLDBFAPIIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BCA0", Offset = "0x5E7AAA0", VA = "0x185E7BCA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E7E1E0", Offset = "0x5E7CFE0", VA = "0x185E7E1E0")]
		private static void GIBFNDIKALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F130", Offset = "0x5E7DF30", VA = "0x185E7F130")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D6D0", Offset = "0x5E7C4D0", VA = "0x185E7D6D0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D940", Offset = "0x5E7C740", VA = "0x185E7D940")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D8F0", Offset = "0x5E7C6F0", VA = "0x185E7D8F0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D720", Offset = "0x5E7C520", VA = "0x185E7D720")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E110", Offset = "0x5E7CF10", VA = "0x185E7E110")]
		private static void COFJDGEKODI(BOALECCCJBK CMANFLLEIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D830", Offset = "0x5E7C630", VA = "0x185E7D830")]
		private static IEnumerable<MethodInfo> BDADDNNIFEM(Type IDOPAKBJEDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7EEE0", Offset = "0x5E7DCE0", VA = "0x185E7EEE0")]
		private static bool LKIODJGNBCD(string GINGNMFKHMN, out Dictionary<string, List<string>> DIJNPKKBLDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D990", Offset = "0x5E7C790", VA = "0x185E7D990")]
		private static IEnumerable<Type> CJACAOPFHNE(Dictionary<string, List<string>> DIJNPKKBLDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E7D0", Offset = "0x5E7D5D0", VA = "0x185E7E7D0")]
		private static IEnumerable<MethodInfo> GLAAKBJKHOM(IEnumerable<Type> BIPGMHLAMBH, Type IDOPAKBJEDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F0A0", Offset = "0x5E7DEA0", VA = "0x185E7F0A0")]
		internal static IEnumerable<MethodInfo> ODNNPFEAIEN(BOALECCCJBK CMANFLLEIMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E9D0", Offset = "0x5E7D7D0", VA = "0x185E7E9D0")]
		internal static void LHKACDJAEEN(IEnumerable<MethodInfo> ALMBHEIJKFJ, Type JDCEEFPGBHD, [Optional] object[] ENIALHNPBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D770", Offset = "0x5E7C570", VA = "0x185E7D770")]
		private static Dictionary<BOALECCCJBK, IGrouping<BOALECCCJBK, MethodInfo>> BABNKANLDEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E8B0", Offset = "0x5E7D6B0", VA = "0x185E7E8B0")]
		private static bool JGPOJPOIKBF(MethodInfo FNCJNLKEPAD, Type DAFDAABLHLO, bool FLIAHFBOIDP)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F2A0", Offset = "0x5E7E0A0", VA = "0x185E7F2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E7D4A0", Offset = "0x5E7C2A0", VA = "0x185E7D4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static HGCFMABKDDJ HHFBAMNODPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D460", Offset = "0x5E7C260", VA = "0x185E7D460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HGCFMABKDDJ LINPKMEFHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D280", Offset = "0x5E7C080", VA = "0x185E7D280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D3B0", Offset = "0x5E7C1B0", VA = "0x185E7D3B0")]
	[KLLDLBHJIAE]
	private static void PDNFMMCIAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D2C0", Offset = "0x5E7C0C0", VA = "0x185E7D2C0")]
	[ICNBDNKNJLD(BOALECCCJBK.Unity_AfterAssembliesLoaded)]
	private static void NLIBFEAGIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C440", Offset = "0x5E7B240", VA = "0x185E7C440")]
	public static HGCFMABKDDJ DPJFEAPNMCM(KDEDNHGEBNP OINBKCIAKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C680", Offset = "0x5E7B480", VA = "0x185E7C680")]
	private static void DPJFEAPNMCM(KDEDNHGEBNP OINBKCIAKIF, HGCFMABKDDJ PPLKNGGGHBP, ref HGCFMABKDDJ FLBJMLJLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BDE0", Offset = "0x5E7ABE0", VA = "0x185E7BDE0")]
	private static void DPJFEAPNMCM(KDEDNHGEBNP OINBKCIAKIF, HGCFMABKDDJ FLBJMLJLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C810", Offset = "0x5E7B610", VA = "0x185E7C810")]
	public static void EMJKLHMFLED(KDEDNHGEBNP OINBKCIAKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D1A0", Offset = "0x5E7BFA0", VA = "0x185E7D1A0")]
	private static bool MKLCEBKCDHA(INPGEEFAPCN JEJKKPCCFKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D0B0", Offset = "0x5E7BEB0", VA = "0x185E7D0B0")]
	private static HGCFMABKDDJ HKGIPEPAOCC(string CFAONFCKLLC, [Optional] HGCFMABKDDJ PPLKNGGGHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C920", Offset = "0x5E7B720", VA = "0x185E7C920")]
	private static void EMJKLHMFLED(ref HGCFMABKDDJ FLBJMLJLEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D3B0", Offset = "0x5E7C1B0", VA = "0x185E7D3B0")]
	private static void NMGMIAPEEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CAE0", Offset = "0x5E7B8E0", VA = "0x185E7CAE0")]
	private static IEnumerable<HMBLPDFOIGD> HBCNBIFHENB(KDEDNHGEBNP OINBKCIAKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C9F0", Offset = "0x5E7B7F0", VA = "0x185E7C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D1AF60", Offset = "0x2D19D60", VA = "0x182D1AF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
	protected BLGALNOFCFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2D1AF20", Offset = "0x2D19D20", VA = "0x182D1AF20", Slot = "5")]
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
