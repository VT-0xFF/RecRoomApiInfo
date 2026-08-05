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
		[Cpp2IlInjected.Address(RVA = "0x1609580", Offset = "0x1607D80", VA = "0x181609580")]
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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public CPEKGFHODND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1606190", Offset = "0x1604990", VA = "0x181606190")]
			internal IEnumerable<MethodInfo> BMMLHLHEOIL(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1606260", Offset = "0x1604A60", VA = "0x181606260")]
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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public FMLDPGNFPAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x16062D0", Offset = "0x1604AD0", VA = "0x1816062D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public HKLJMLJJGKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1606340", Offset = "0x1604B40", VA = "0x181606340")]
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
		[Cpp2IlInjected.Address(RVA = "0x1608490", Offset = "0x1606C90", VA = "0x181608490")]
		private static void GLDEKEJJKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1609410", Offset = "0x1607C10", VA = "0x181609410")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x16079B0", Offset = "0x16061B0", VA = "0x1816079B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1607B60", Offset = "0x1606360", VA = "0x181607B60")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1607B10", Offset = "0x1606310", VA = "0x181607B10")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1607A00", Offset = "0x1606200", VA = "0x181607A00")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1607C40", Offset = "0x1606440", VA = "0x181607C40")]
		private static void EGHPKLLJEFA(OEMLBLOOECK DMNLINKFLAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1608F90", Offset = "0x1607790", VA = "0x181608F90")]
		private static IEnumerable<MethodInfo> JCHKPONBKLK(Type FHAKPHFBAMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1609250", Offset = "0x1607A50", VA = "0x181609250")]
		private static bool KPEANHJHOMK(string KEGCCBBGEPM, out Dictionary<string, List<string>> BHJNLKKMJOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1607D10", Offset = "0x1606510", VA = "0x181607D10")]
		private static IEnumerable<Type> GGHOOGPAODJ(Dictionary<string, List<string>> BHJNLKKMJOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1609170", Offset = "0x1607970", VA = "0x181609170")]
		private static IEnumerable<MethodInfo> KKGIFDKLMCE(IEnumerable<Type> LONDNADJAMP, Type FHAKPHFBAMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1607BB0", Offset = "0x16063B0", VA = "0x181607BB0")]
		internal static IEnumerable<MethodInfo> DHCNMPKGFED(OEMLBLOOECK DMNLINKFLAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1608A80", Offset = "0x1607280", VA = "0x181608A80")]
		internal static void INLBLAOIEGM(IEnumerable<MethodInfo> KGECLNGJJGL, Type DDFCJLDLFGC, [Optional] object[] DAKKAABHBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1607A50", Offset = "0x1606250", VA = "0x181607A50")]
		private static Dictionary<OEMLBLOOECK, IGrouping<OEMLBLOOECK, MethodInfo>> BOPCKHKNLCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1609050", Offset = "0x1607850", VA = "0x181609050")]
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
		[Cpp2IlInjected.Address(RVA = "0x16070A0", Offset = "0x16058A0", VA = "0x1816070A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MHOBEFMLEFD OHGPOPBBIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1606690", Offset = "0x1604E90", VA = "0x181606690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MHOBEFMLEFD LEHHFPENHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x16066D0", Offset = "0x1604ED0", VA = "0x1816066D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1606710", Offset = "0x1604F10", VA = "0x181606710")]
	[JFKPICHOBNP]
	private static void HOBPBOCADCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1606E30", Offset = "0x1605630", VA = "0x181606E30")]
	[GOLHGLLJIPN(OEMLBLOOECK.Unity_AfterAssembliesLoaded)]
	private static void JPNLJCGDOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x16075D0", Offset = "0x1605DD0", VA = "0x1816075D0")]
	public static MHOBEFMLEFD OPGDHOIHBNK(BLGLNFDFDJO EENKPDMMAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1607820", Offset = "0x1606020", VA = "0x181607820")]
	private static void OPGDHOIHBNK(BLGLNFDFDJO EENKPDMMAPL, MHOBEFMLEFD EOHDEJOCEFD, ref MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1607190", Offset = "0x1605990", VA = "0x181607190")]
	private static void OPGDHOIHBNK(BLGLNFDFDJO EENKPDMMAPL, MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1606580", Offset = "0x1604D80", VA = "0x181606580")]
	public static void AIOKBDCGIKB(BLGLNFDFDJO EENKPDMMAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1606D50", Offset = "0x1605550", VA = "0x181606D50")]
	private static bool JEEPCFICJFL(EDNJEIFHIMJ IBDHMNLNLJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1606F20", Offset = "0x1605720", VA = "0x181606F20")]
	private static MHOBEFMLEFD LJNFCOJPLGL(string EKBMKNPFLLG, [Optional] MHOBEFMLEFD EOHDEJOCEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1606390", Offset = "0x1604B90", VA = "0x181606390")]
	private static void AIOKBDCGIKB(ref MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1606710", Offset = "0x1604F10", VA = "0x181606710")]
	private static void GOLEMJHJMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x16067C0", Offset = "0x1604FC0", VA = "0x1816067C0")]
	private static IEnumerable<IKGECKKFLKH> IFGNHMCALON(BLGLNFDFDJO EENKPDMMAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x16070A0", Offset = "0x16058A0", VA = "0x1816070A0")]
	private static MHOBEFMLEFD PDODAKOBMLB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ABCKONBHMBO<T> : IDisposable where T : global::ABCKONBHMBO<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static T PKIKEDNMDGD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T EABDDJEADPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3B96A60", Offset = "0x3B95260", VA = "0x183B96A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x185F860", Offset = "0x185E060", VA = "0x18185F860")]
	protected ABCKONBHMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3B96A20", Offset = "0x3B95220", VA = "0x183B96A20", Slot = "5")]
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
