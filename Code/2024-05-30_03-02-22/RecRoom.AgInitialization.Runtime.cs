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
		private sealed class FHCHAMPBDNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public FHCHAMPBDNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x627B280", Offset = "0x627A480", VA = "0x18627B280")]
			internal IEnumerable<MethodInfo> LMNAEGFGFHC(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x627B340", Offset = "0x627A540", VA = "0x18627B340")]
			internal bool ONOGEFNMHHA(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class ABIJEKAMLPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public ABIJEKAMLPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6279C20", Offset = "0x6278E20", VA = "0x186279C20")]
			internal bool FLNHDGCHMNI(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class MJCNBKEDPCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public MJCNBKEDPCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x627B3A0", Offset = "0x627A5A0", VA = "0x18627B3A0")]
			internal bool MKDNAMDPHCP(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<FELFKELNNKC, IGrouping<FELFKELNNKC, MethodInfo>> GECCMCAJCIF;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type CGFKCDAEBGG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x627C730", Offset = "0x627B930", VA = "0x18627C730")]
		private static void PMAGCPLPNLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x627CCA0", Offset = "0x627BEA0", VA = "0x18627CCA0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x627B540", Offset = "0x627A740", VA = "0x18627B540")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x627B710", Offset = "0x627A910", VA = "0x18627B710")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x627B6C0", Offset = "0x627A8C0", VA = "0x18627B6C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x627B590", Offset = "0x627A790", VA = "0x18627B590")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x627B3F0", Offset = "0x627A5F0", VA = "0x18627B3F0")]
		private static void AEJFAGOIFCD(FELFKELNNKC EIANGOJDGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x627BFA0", Offset = "0x627B1A0", VA = "0x18627BFA0")]
		private static IEnumerable<MethodInfo> HFCIOJINIGF(Type JNJNJKJHKAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x627C0D0", Offset = "0x627B2D0", VA = "0x18627C0D0")]
		private static bool KAHAHIFJJAB(string CMBHAPDNCDK, [Out] Dictionary<string, List<string>> LLNBJPGGIJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x627B880", Offset = "0x627AA80", VA = "0x18627B880")]
		private static IEnumerable<Type> DGCLNACNCKG(Dictionary<string, List<string>> LLNBJPGGIJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x627B5E0", Offset = "0x627A7E0", VA = "0x18627B5E0")]
		private static IEnumerable<MethodInfo> BJFPMIKCHDN(IEnumerable<Type> IAGPGLLOEJA, Type JNJNJKJHKAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x627B4B0", Offset = "0x627A6B0", VA = "0x18627B4B0")]
		internal static IEnumerable<MethodInfo> ALBDGFBBIJI(FELFKELNNKC EIANGOJDGCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x627C1F0", Offset = "0x627B3F0", VA = "0x18627C1F0")]
		internal static void NJJANFJMJII(IEnumerable<MethodInfo> HKNIFEDMPCF, Type GGBMLHEGILE, [Optional] object[] EOHMOLAFOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x627C030", Offset = "0x627B230", VA = "0x18627C030")]
		private static Dictionary<FELFKELNNKC, IGrouping<FELFKELNNKC, MethodInfo>> HKANLHACNKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x627B760", Offset = "0x627A960", VA = "0x18627B760")]
		private static bool CCEDLDGNPMF(MethodInfo LGELAMCHOCL, Type NEJHJCLNNFP, bool MCHAOGCCMHA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class CBKAFCAJBMO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> EINNDNLHMBJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> EFGMMKJLGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x627B1C0", Offset = "0x627A3C0", VA = "0x18627B1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x627CE00", Offset = "0x627C000", VA = "0x18627CE00")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AKFKFOGCHGH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct EDHKBDPAHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo JMKONKOOBAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CLDBMEKPFFP FOOMKMHNGOK;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<NFKMIHJOIMG, List<EDHKBDPAHOL>> GPOLHKOMOHB;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static EHGDBDLIOFB OFOKNGPKIAL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static EHGDBDLIOFB NGJOFKKPKLF;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static EHGDBDLIOFB ANFIDHFJINA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static EHGDBDLIOFB LHCGPINMKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x627AA60", Offset = "0x6279C60", VA = "0x18627AA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static EHGDBDLIOFB GCOPFKIOILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x627A9E0", Offset = "0x6279BE0", VA = "0x18627A9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static EHGDBDLIOFB HKBLIGIKMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x627ABE0", Offset = "0x6279DE0", VA = "0x18627ABE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool PCIEIFKCILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x627AA20", Offset = "0x6279C20", VA = "0x18627AA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x627AB30", Offset = "0x6279D30", VA = "0x18627AB30")]
	[IPDMNCFBAKM]
	private static void IJODLFHLEMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6279EB0", Offset = "0x62790B0", VA = "0x186279EB0")]
	[HCFPGNPFDEC(FELFKELNNKC.Unity_AfterAssembliesLoaded)]
	private static void CGEMBAKBBDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x627A270", Offset = "0x6279470", VA = "0x18627A270")]
	public static EHGDBDLIOFB GNBMCOECJIB(NFKMIHJOIMG APFILJCHGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x627A4B0", Offset = "0x62796B0", VA = "0x18627A4B0")]
	private static void GNBMCOECJIB(NFKMIHJOIMG APFILJCHGFB, EHGDBDLIOFB OLJBABBKGFK, EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x627A5F0", Offset = "0x62797F0", VA = "0x18627A5F0")]
	private static void GNBMCOECJIB(NFKMIHJOIMG APFILJCHGFB, EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x627A150", Offset = "0x6279350", VA = "0x18627A150")]
	public static void EAAADDFMOBM(NFKMIHJOIMG APFILJCHGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2429040", Offset = "0x2428240", VA = "0x182429040")]
	private static bool ABLPNDEPFAK(CLDBMEKPFFP CIIJMNOLLDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6279C80", Offset = "0x6278E80", VA = "0x186279C80")]
	private static EHGDBDLIOFB BJOMEIHFDDP(string LPKOHFAFEBO, [Optional] EHGDBDLIOFB OLJBABBKGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6279F80", Offset = "0x6279180", VA = "0x186279F80")]
	private static void EAAADDFMOBM(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x627AB30", Offset = "0x6279D30", VA = "0x18627AB30")]
	private static void PLOGGGKINLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x627AC20", Offset = "0x6279E20", VA = "0x18627AC20")]
	private static IEnumerable<EDHKBDPAHOL> NFKBGLNPPFL(NFKMIHJOIMG APFILJCHGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6279DF0", Offset = "0x6278FF0", VA = "0x186279DF0")]
	private static EHGDBDLIOFB CEFJCPNJMGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PJEKCKKJDPK<T> : IDisposable where T : PJEKCKKJDPK<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T PNLOKOBAKEP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T LNFBMICMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x43B4E50", Offset = "0x43B4050", VA = "0x1843B4E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected PJEKCKKJDPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x43B5100", Offset = "0x43B4300", VA = "0x1843B5100", Slot = "5")]
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
