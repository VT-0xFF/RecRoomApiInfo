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
		private sealed class GEFHJLPNPJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public GEFHJLPNPJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x65760F0", Offset = "0x65748F0", VA = "0x1865760F0")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x65761C0", Offset = "0x65749C0", VA = "0x1865761C0")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class HMJDGGKDKBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public HMJDGGKDKBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x65779A0", Offset = "0x65761A0", VA = "0x1865779A0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class HJIICMNLOJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public HJIICMNLOJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6577950", Offset = "0x6576150", VA = "0x186577950")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string GEKOCGMIFNN = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string PKIBOJMHAFD = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<FBKMDIMHGAB, IGrouping<FBKMDIMHGAB, MethodInfo>> HKEKJEMNDFF;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type DHDCGMHJGNG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x65783A0", Offset = "0x6576BA0", VA = "0x1865783A0")]
		private static void DBNEFJFBDDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6579470", Offset = "0x6577C70", VA = "0x186579470")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6577AE0", Offset = "0x65762E0", VA = "0x186577AE0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6578350", Offset = "0x6576B50", VA = "0x186578350")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6578300", Offset = "0x6576B00", VA = "0x186578300")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6577B30", Offset = "0x6576330", VA = "0x186577B30")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6577A10", Offset = "0x6576210", VA = "0x186577A10")]
		private static void AHMAAAIAFNG(FBKMDIMHGAB CCPJCOMOCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6578CF0", Offset = "0x65774F0", VA = "0x186578CF0")]
		private static IEnumerable<MethodInfo> MJBACKACGBJ(Type KJMCDCGJHAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6578B30", Offset = "0x6577330", VA = "0x186578B30")]
		private static bool KMOEFIECNOF(string GPFKHDGIMKC, out Dictionary<string, List<string>> HEAPGLEIMMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6577B80", Offset = "0x6576380", VA = "0x186577B80")]
		private static IEnumerable<Type> BIJJMFGLGDM(Dictionary<string, List<string>> HEAPGLEIMMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6578990", Offset = "0x6577190", VA = "0x186578990")]
		private static IEnumerable<MethodInfo> GHBCMNOPMAK(IEnumerable<Type> ELMBJAGHLEM, Type KJMCDCGJHAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65793E0", Offset = "0x6577BE0", VA = "0x1865793E0")]
		internal static IEnumerable<MethodInfo> OHHOCJOOAJD(FBKMDIMHGAB CCPJCOMOCDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6578DB0", Offset = "0x65775B0", VA = "0x186578DB0")]
		internal static void NFGNPOPJLNJ(IEnumerable<MethodInfo> KFEMHPOBFHA, Type NLNDAMJGLEN, [Optional] object[] NDEGHHCMGIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6578A70", Offset = "0x6577270", VA = "0x186578A70")]
		private static Dictionary<FBKMDIMHGAB, IGrouping<FBKMDIMHGAB, MethodInfo>> JDFJMAEPLAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65792C0", Offset = "0x6577AC0", VA = "0x1865792C0")]
		private static bool OABICBDMBBH(MethodInfo DLAKBGGDNHG, Type HPHBIMMAJHL, bool GHIEIIMECEP)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65795E0", Offset = "0x6577DE0", VA = "0x1865795E0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GOBKBBJHBCO
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct PHCCIKOOENB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo DGJOFCKEKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MDCFJLLNHDJ IOJAFHGHDEA;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<OKOGBEPHCIM, List<PHCCIKOOENB>> KMHJHDHAIMG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BENLBCJOMLF BHJCMAOCBFF;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static BENLBCJOMLF HFLACNCJJOD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static BENLBCJOMLF HLMEDCDFFBN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BENLBCJOMLF GOKJGEHOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6577860", Offset = "0x6576060", VA = "0x186577860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BENLBCJOMLF DMOHGBAFOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6576230", Offset = "0x6574A30", VA = "0x186576230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BENLBCJOMLF CELKKPIOOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6576270", Offset = "0x6574A70", VA = "0x186576270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6576AB0", Offset = "0x65752B0", VA = "0x186576AB0")]
	[FAKMCIHPINM]
	private static void PJOIJPBKDFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6576840", Offset = "0x6575040", VA = "0x186576840")]
	[FKLAFGEGFDL(FBKMDIMHGAB.Unity_AfterAssembliesLoaded)]
	private static void ENAGPEAGFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6577130", Offset = "0x6575930", VA = "0x186577130")]
	public static BENLBCJOMLF IPJAGCDHLGH(OKOGBEPHCIM HGKCIGDHGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6576FA0", Offset = "0x65757A0", VA = "0x186576FA0")]
	private static void IPJAGCDHLGH(OKOGBEPHCIM HGKCIGDHGDN, BENLBCJOMLF BFIDMGIFLCH, ref BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6576B60", Offset = "0x6575360", VA = "0x186576B60")]
	private static void IPJAGCDHLGH(OKOGBEPHCIM HGKCIGDHGDN, BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6577750", Offset = "0x6575F50", VA = "0x186577750")]
	public static void ODCMGIHMJBF(OKOGBEPHCIM HGKCIGDHGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6577460", Offset = "0x6575C60", VA = "0x186577460")]
	private static bool MKOPHKPNBIA(MDCFJLLNHDJ NHBKMAFLOKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6576930", Offset = "0x6575130", VA = "0x186576930")]
	private static BENLBCJOMLF FFAKLJDMJDH(string KHKIGMADHCO, [Optional] BENLBCJOMLF BFIDMGIFLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6577540", Offset = "0x6575D40", VA = "0x186577540")]
	private static void ODCMGIHMJBF(ref BENLBCJOMLF NDEFPJDAEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6576AB0", Offset = "0x65752B0", VA = "0x186576AB0")]
	private static void GABHFBOMGCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65762B0", Offset = "0x6574AB0", VA = "0x1865762B0")]
	private static IEnumerable<PHCCIKOOENB> DJCPIKIMBJA(OKOGBEPHCIM HGKCIGDHGDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6577370", Offset = "0x6575B70", VA = "0x186577370")]
	private static BENLBCJOMLF MHMPOJCKPPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DNJGAHEFEJI<T> : IDisposable where T : global::DNJGAHEFEJI<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T HBJDGFDOIDP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T PDCOCJBICGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4BC0", Offset = "0x2BC33C0", VA = "0x182BC4BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
	protected DNJGAHEFEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4B80", Offset = "0x2BC3380", VA = "0x182BC4B80", Slot = "5")]
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
