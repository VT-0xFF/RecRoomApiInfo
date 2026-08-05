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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public IEHFFAAJDFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6632330", Offset = "0x6631330", VA = "0x186632330")]
			internal IEnumerable<MethodInfo> <GetMethodsUsingReflection>b__0(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6632400", Offset = "0x6631400", VA = "0x186632400")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public AEELIDAMHPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6630BA0", Offset = "0x662FBA0", VA = "0x186630BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public MMELOOBKNIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6632470", Offset = "0x6631470", VA = "0x186632470")]
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
		[Cpp2IlInjected.Address(RVA = "0x6633930", Offset = "0x6632930", VA = "0x186633930")]
		private static void PKOHBEFGHHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6633F20", Offset = "0x6632F20", VA = "0x186633F20")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x66324C0", Offset = "0x66314C0", VA = "0x1866324C0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x66325B0", Offset = "0x66315B0", VA = "0x1866325B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6632560", Offset = "0x6631560", VA = "0x186632560")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6632510", Offset = "0x6631510", VA = "0x186632510")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6633230", Offset = "0x6632230", VA = "0x186633230")]
		private static void MCNCBIGKMML(JAIANHPNEMN DOOOFAICEGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6633170", Offset = "0x6632170", VA = "0x186633170")]
		private static IEnumerable<MethodInfo> LMFJABECEIC(Type DKMMBOGOKHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66326C0", Offset = "0x66316C0", VA = "0x1866326C0")]
		private static bool EJOPBPHEBPH(string CPHMKCNKEMP, out Dictionary<string, List<string>> AJGPPPEAKNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66329F0", Offset = "0x66319F0", VA = "0x1866329F0")]
		private static IEnumerable<Type> JMBJAIPMFIE(Dictionary<string, List<string>> AJGPPPEAKNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6632910", Offset = "0x6631910", VA = "0x186632910")]
		private static IEnumerable<MethodInfo> JLCBIFCBOMF(IEnumerable<Type> HGOEKJDCDEG, Type DKMMBOGOKHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6632880", Offset = "0x6631880", VA = "0x186632880")]
		internal static IEnumerable<MethodInfo> GNDHLDNBHMM(JAIANHPNEMN DOOOFAICEGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6633420", Offset = "0x6632420", VA = "0x186633420")]
		internal static void PJCGHNEIGGF(IEnumerable<MethodInfo> NNGFLGOCPPL, Type GHKCAALMMPE, [Optional] object[] DGCNIAGLPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6632600", Offset = "0x6631600", VA = "0x186632600")]
		private static Dictionary<JAIANHPNEMN, IGrouping<JAIANHPNEMN, MethodInfo>> DKBMCOIFFDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6633300", Offset = "0x6632300", VA = "0x186633300")]
		private static bool NNPCKHFGNMC(MethodInfo ELEDFMNCKKD, Type FAEKFFCEBGJ, bool IEIDCLPBKOO)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class TypeCachingUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6634090", Offset = "0x6633090", VA = "0x186634090")]
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
		[Cpp2IlInjected.Address(RVA = "0x66310D0", Offset = "0x66300D0", VA = "0x1866310D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static DDFGGHLLPGI EPFOMIHIPNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66311C0", Offset = "0x66301C0", VA = "0x1866311C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static DDFGGHLLPGI PJHHFIDCADJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6631200", Offset = "0x6630200", VA = "0x186631200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6630C10", Offset = "0x662FC10", VA = "0x186630C10")]
	[AELNEKNDKOO]
	private static void BGCGLCGAILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6632160", Offset = "0x6631160", VA = "0x186632160")]
	[DBEMBPHJILD(JAIANHPNEMN.Unity_AfterAssembliesLoaded)]
	private static void MHPDDDMGDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6631960", Offset = "0x6630960", VA = "0x186631960")]
	public static DDFGGHLLPGI LNNGFFOFNLE(KHPALILEHND MJNJNEKOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x66317D0", Offset = "0x66307D0", VA = "0x1866317D0")]
	private static void LNNGFFOFNLE(KHPALILEHND MJNJNEKOMNC, DDFGGHLLPGI ADEMMHFFKHC, ref DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6631BA0", Offset = "0x6630BA0", VA = "0x186631BA0")]
	private static void LNNGFFOFNLE(KHPALILEHND MJNJNEKOMNC, DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6630DB0", Offset = "0x662FDB0", VA = "0x186630DB0")]
	public static void CMOBILLEELD(KHPALILEHND MJNJNEKOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6632250", Offset = "0x6631250", VA = "0x186632250")]
	private static bool OLJOADOFPJH(MEDANDNEHIF GGFDIJPKBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6631FE0", Offset = "0x6630FE0", VA = "0x186631FE0")]
	private static DDFGGHLLPGI LOKKOCJOODO(string CFNHEFHNJKD, [Optional] DDFGGHLLPGI ADEMMHFFKHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6630EC0", Offset = "0x662FEC0", VA = "0x186630EC0")]
	private static void CMOBILLEELD(ref DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6630C10", Offset = "0x662FC10", VA = "0x186630C10")]
	private static void DOKBGGMOGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6631240", Offset = "0x6630240", VA = "0x186631240")]
	private static IEnumerable<KPMHKAEPODN> KDNJIIJEEDC(KHPALILEHND MJNJNEKOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6630CC0", Offset = "0x662FCC0", VA = "0x186630CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x299DFB0", Offset = "0x299CFB0", VA = "0x18299DFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
	protected DBDGFNJPOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x299DF70", Offset = "0x299CF70", VA = "0x18299DF70", Slot = "5")]
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
