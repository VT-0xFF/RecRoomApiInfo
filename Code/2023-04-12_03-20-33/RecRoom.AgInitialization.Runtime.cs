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
		private sealed class IEHFFAAJDFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public IEHFFAAJDFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x66AE350", Offset = "0x66AD750", VA = "0x1866AE350")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66AE420", Offset = "0x66AD820", VA = "0x1866AE420")]
			internal bool <GetMethodsUsingReflection>b__1(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class AEELIDAMHPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public AEELIDAMHPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x66ACBC0", Offset = "0x66ABFC0", VA = "0x1866ACBC0")]
			internal bool <InvokeStaticMethodsWithAttribute>b__0(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class MMELOOBKNIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public MMELOOBKNIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x66AE490", Offset = "0x66AD890", VA = "0x1866AE490")]
			internal bool <IsValidStaticMethod>b__0(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const string NNAEIGMDAIB = "StreamingAssets";

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const string LAFIPDGNLHL = "runtimeInitializedMethods.bytes";

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Dictionary<JAIANHPNEMN, IGrouping<JAIANHPNEMN, MethodInfo>> OMJDCIMDLDA;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Type NNEEEFPANCI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66AF950", Offset = "0x66AED50", VA = "0x1866AF950")]
		private static void PKOHBEFGHHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66AFF40", Offset = "0x66AF340", VA = "0x1866AFF40")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x66AE4E0", Offset = "0x66AD8E0", VA = "0x1866AE4E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x66AE5D0", Offset = "0x66AD9D0", VA = "0x1866AE5D0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66AE580", Offset = "0x66AD980", VA = "0x1866AE580")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66AE530", Offset = "0x66AD930", VA = "0x1866AE530")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66AF250", Offset = "0x66AE650", VA = "0x1866AF250")]
		private static void MCNCBIGKMML(JAIANHPNEMN DOOOFAICEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66AF190", Offset = "0x66AE590", VA = "0x1866AF190")]
		private static IEnumerable<MethodInfo> LMFJABECEIC(Type DKMMBOGOKHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66AE6E0", Offset = "0x66ADAE0", VA = "0x1866AE6E0")]
		private static bool EJOPBPHEBPH(string CPHMKCNKEMP, out Dictionary<string, List<string>> AJGPPPEAKNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66AEA10", Offset = "0x66ADE10", VA = "0x1866AEA10")]
		private static IEnumerable<Type> JMBJAIPMFIE(Dictionary<string, List<string>> AJGPPPEAKNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66AE930", Offset = "0x66ADD30", VA = "0x1866AE930")]
		private static IEnumerable<MethodInfo> JLCBIFCBOMF(IEnumerable<Type> HGOEKJDCDEG, Type DKMMBOGOKHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66AE8A0", Offset = "0x66ADCA0", VA = "0x1866AE8A0")]
		internal static IEnumerable<MethodInfo> GNDHLDNBHMM(JAIANHPNEMN DOOOFAICEGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66AF440", Offset = "0x66AE840", VA = "0x1866AF440")]
		internal static void PJCGHNEIGGF(IEnumerable<MethodInfo> NNGFLGOCPPL, Type GHKCAALMMPE, [Optional] object[] DGCNIAGLPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x66AE620", Offset = "0x66ADA20", VA = "0x1866AE620")]
		private static Dictionary<JAIANHPNEMN, IGrouping<JAIANHPNEMN, MethodInfo>> DKBMCOIFFDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66AF320", Offset = "0x66AE720", VA = "0x1866AF320")]
		private static bool NNPCKHFGNMC(MethodInfo ELEDFMNCKKD, Type FAEKFFCEBGJ, bool IEIDCLPBKOO)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x66B00B0", Offset = "0x66AF4B0", VA = "0x1866B00B0")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GCBNINNMBFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct KPMHKAEPODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MethodInfo KAOFEMHAGFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public MEDANDNEHIF OMGLNHFKBNP;
	}

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static Dictionary<KHPALILEHND, List<KPMHKAEPODN>> DDNLAPEFGEJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DDFGGHLLPGI OMIIPHDEGMK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static DDFGGHLLPGI JJNCEAGCKGC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static DDFGGHLLPGI EIDCEHJMBIN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DDFGGHLLPGI IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x66AD0F0", Offset = "0x66AC4F0", VA = "0x1866AD0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static DDFGGHLLPGI EPFOMIHIPNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66AD1E0", Offset = "0x66AC5E0", VA = "0x1866AD1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DDFGGHLLPGI PJHHFIDCADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x66AD220", Offset = "0x66AC620", VA = "0x1866AD220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x66ACC30", Offset = "0x66AC030", VA = "0x1866ACC30")]
	[AELNEKNDKOO]
	private static void BGCGLCGAILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x66AE180", Offset = "0x66AD580", VA = "0x1866AE180")]
	[DBEMBPHJILD(JAIANHPNEMN.Unity_AfterAssembliesLoaded)]
	private static void MHPDDDMGDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x66AD980", Offset = "0x66ACD80", VA = "0x1866AD980")]
	public static DDFGGHLLPGI LNNGFFOFNLE(KHPALILEHND MJNJNEKOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x66AD7F0", Offset = "0x66ACBF0", VA = "0x1866AD7F0")]
	private static void LNNGFFOFNLE(KHPALILEHND MJNJNEKOMNC, DDFGGHLLPGI ADEMMHFFKHC, ref DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x66ADBC0", Offset = "0x66ACFC0", VA = "0x1866ADBC0")]
	private static void LNNGFFOFNLE(KHPALILEHND MJNJNEKOMNC, DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x66ACDD0", Offset = "0x66AC1D0", VA = "0x1866ACDD0")]
	public static void CMOBILLEELD(KHPALILEHND MJNJNEKOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x66AE270", Offset = "0x66AD670", VA = "0x1866AE270")]
	private static bool OLJOADOFPJH(MEDANDNEHIF GGFDIJPKBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x66AE000", Offset = "0x66AD400", VA = "0x1866AE000")]
	private static DDFGGHLLPGI LOKKOCJOODO(string CFNHEFHNJKD, [Optional] DDFGGHLLPGI ADEMMHFFKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x66ACEE0", Offset = "0x66AC2E0", VA = "0x1866ACEE0")]
	private static void CMOBILLEELD(ref DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x66ACC30", Offset = "0x66AC030", VA = "0x1866ACC30")]
	private static void DOKBGGMOGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x66AD260", Offset = "0x66AC660", VA = "0x1866AD260")]
	private static IEnumerable<KPMHKAEPODN> KDNJIIJEEDC(KHPALILEHND MJNJNEKOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x66ACCE0", Offset = "0x66AC0E0", VA = "0x1866ACCE0")]
	private static DDFGGHLLPGI BOAOKDFCBLO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DBDGFNJPOGN<T> : IDisposable where T : global::DBDGFNJPOGN<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T NMHCDAEEFOA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T FDNKALDKIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2FEA2A0", Offset = "0x2FE96A0", VA = "0x182FEA2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
	protected DBDGFNJPOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2FEA260", Offset = "0x2FE9660", VA = "0x182FEA260", Slot = "5")]
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
