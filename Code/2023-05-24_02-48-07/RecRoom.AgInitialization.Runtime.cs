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
		[Cpp2IlInjected.Address(RVA = "0x134A250", Offset = "0x1348E50", VA = "0x18134A250")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public CPEKGFHODND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1346E60", Offset = "0x1345A60", VA = "0x181346E60")]
			internal IEnumerable<MethodInfo> BMMLHLHEOIL(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1346F30", Offset = "0x1345B30", VA = "0x181346F30")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public FMLDPGNFPAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1346FA0", Offset = "0x1345BA0", VA = "0x181346FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public HKLJMLJJGKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1347010", Offset = "0x1345C10", VA = "0x181347010")]
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
		[Cpp2IlInjected.Address(RVA = "0x1349160", Offset = "0x1347D60", VA = "0x181349160")]
		private static void GLDEKEJJKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x134A0E0", Offset = "0x1348CE0", VA = "0x18134A0E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1348680", Offset = "0x1347280", VA = "0x181348680")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1348830", Offset = "0x1347430", VA = "0x181348830")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x13487E0", Offset = "0x13473E0", VA = "0x1813487E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x13486D0", Offset = "0x13472D0", VA = "0x1813486D0")]
		[RuntimeInitializeOnLoadMethod]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1348910", Offset = "0x1347510", VA = "0x181348910")]
		private static void EGHPKLLJEFA(OEMLBLOOECK DMNLINKFLAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1349C60", Offset = "0x1348860", VA = "0x181349C60")]
		private static IEnumerable<MethodInfo> JCHKPONBKLK(Type FHAKPHFBAMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1349F20", Offset = "0x1348B20", VA = "0x181349F20")]
		private static bool KPEANHJHOMK(string KEGCCBBGEPM, out Dictionary<string, List<string>> BHJNLKKMJOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x13489E0", Offset = "0x13475E0", VA = "0x1813489E0")]
		private static IEnumerable<Type> GGHOOGPAODJ(Dictionary<string, List<string>> BHJNLKKMJOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1349E40", Offset = "0x1348A40", VA = "0x181349E40")]
		private static IEnumerable<MethodInfo> KKGIFDKLMCE(IEnumerable<Type> LONDNADJAMP, Type FHAKPHFBAMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1348880", Offset = "0x1347480", VA = "0x181348880")]
		internal static IEnumerable<MethodInfo> DHCNMPKGFED(OEMLBLOOECK DMNLINKFLAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1349750", Offset = "0x1348350", VA = "0x181349750")]
		internal static void INLBLAOIEGM(IEnumerable<MethodInfo> KGECLNGJJGL, Type DDFCJLDLFGC, [Optional] object[] DAKKAABHBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1348720", Offset = "0x1347320", VA = "0x181348720")]
		private static Dictionary<OEMLBLOOECK, IGrouping<OEMLBLOOECK, MethodInfo>> BOPCKHKNLCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1349D20", Offset = "0x1348920", VA = "0x181349D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1347D70", Offset = "0x1346970", VA = "0x181347D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MHOBEFMLEFD OHGPOPBBIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1347360", Offset = "0x1345F60", VA = "0x181347360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MHOBEFMLEFD LEHHFPENHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x13473A0", Offset = "0x1345FA0", VA = "0x1813473A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x13473E0", Offset = "0x1345FE0", VA = "0x1813473E0")]
	[JFKPICHOBNP]
	private static void HOBPBOCADCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1347B00", Offset = "0x1346700", VA = "0x181347B00")]
	[GOLHGLLJIPN(OEMLBLOOECK.Unity_AfterAssembliesLoaded)]
	private static void JPNLJCGDOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x13482A0", Offset = "0x1346EA0", VA = "0x1813482A0")]
	public static MHOBEFMLEFD OPGDHOIHBNK(BLGLNFDFDJO EENKPDMMAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x13484F0", Offset = "0x13470F0", VA = "0x1813484F0")]
	private static void OPGDHOIHBNK(BLGLNFDFDJO EENKPDMMAPL, MHOBEFMLEFD EOHDEJOCEFD, ref MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1347E60", Offset = "0x1346A60", VA = "0x181347E60")]
	private static void OPGDHOIHBNK(BLGLNFDFDJO EENKPDMMAPL, MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1347250", Offset = "0x1345E50", VA = "0x181347250")]
	public static void AIOKBDCGIKB(BLGLNFDFDJO EENKPDMMAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1347A20", Offset = "0x1346620", VA = "0x181347A20")]
	private static bool JEEPCFICJFL(EDNJEIFHIMJ IBDHMNLNLJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1347BF0", Offset = "0x13467F0", VA = "0x181347BF0")]
	private static MHOBEFMLEFD LJNFCOJPLGL(string EKBMKNPFLLG, [Optional] MHOBEFMLEFD EOHDEJOCEFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1347060", Offset = "0x1345C60", VA = "0x181347060")]
	private static void AIOKBDCGIKB(ref MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x13473E0", Offset = "0x1345FE0", VA = "0x1813473E0")]
	private static void GOLEMJHJMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1347490", Offset = "0x1346090", VA = "0x181347490")]
	private static IEnumerable<IKGECKKFLKH> IFGNHMCALON(BLGLNFDFDJO EENKPDMMAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1347D70", Offset = "0x1346970", VA = "0x181347D70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3908800", Offset = "0x3907400", VA = "0x183908800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14BBF20", Offset = "0x14BAB20", VA = "0x1814BBF20")]
	protected ABCKONBHMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x39087C0", Offset = "0x39073C0", VA = "0x1839087C0", Slot = "5")]
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
