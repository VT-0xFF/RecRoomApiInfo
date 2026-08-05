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
		private sealed class AJGLOGONBGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public AJGLOGONBGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A270", Offset = "0x5E99070", VA = "0x185E9A270")]
			internal IEnumerable<MethodInfo> OICJENIDAAE(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A210", Offset = "0x5E99010", VA = "0x185E9A210")]
			internal bool CIPLBOLJKHE(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class EIMBBICDGHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public EIMBBICDGHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A380", Offset = "0x5E99180", VA = "0x185E9A380")]
			internal bool IFMPBPGALHI(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class BJHCEFGGDEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public BJHCEFGGDEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A330", Offset = "0x5E99130", VA = "0x185E9A330")]
			internal bool CKAJIBJIHOH(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<HCIPOEFGANF, IGrouping<HCIPOEFGANF, MethodInfo>> DAMDDNHMNKF;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type CHHHJKNKGGI;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C440", Offset = "0x5E9B240", VA = "0x185E9C440")]
		private static void EDEKDMNJNDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D220", Offset = "0x5E9C020", VA = "0x185E9D220")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BA30", Offset = "0x5E9A830", VA = "0x185E9BA30")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BBC0", Offset = "0x5E9A9C0", VA = "0x185E9BBC0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BB70", Offset = "0x5E9A970", VA = "0x185E9BB70")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BA80", Offset = "0x5E9A880", VA = "0x185E9BA80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CAD0", Offset = "0x5E9B8D0", VA = "0x185E9CAD0")]
		private static void GLFBPLMCNND(HCIPOEFGANF OCMGAJOHNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CC70", Offset = "0x5E9BA70", VA = "0x185E9CC70")]
		private static IEnumerable<MethodInfo> KCMBMEPKGKC(Type JNPLICENOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BC10", Offset = "0x5E9AA10", VA = "0x185E9BC10")]
		private static bool CMPBJKIDFJE(string DADFIHCEECO, [Out] Dictionary<string, List<string>> MMDJDEDGCHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BD30", Offset = "0x5E9AB30", VA = "0x185E9BD30")]
		private static IEnumerable<Type> ECPHODHNIKK(Dictionary<string, List<string>> MMDJDEDGCHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CB90", Offset = "0x5E9B990", VA = "0x185E9CB90")]
		private static IEnumerable<MethodInfo> JLDEBMLAGOO(IEnumerable<Type> DCMNBNHNEPM, Type JNPLICENOFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B9A0", Offset = "0x5E9A7A0", VA = "0x185E9B9A0")]
		internal static IEnumerable<MethodInfo> ABMKNPBDOBO(HCIPOEFGANF OCMGAJOHNHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CD00", Offset = "0x5E9BB00", VA = "0x185E9CD00")]
		internal static void LEPDNOCJPML(IEnumerable<MethodInfo> NEOMODIKDFH, Type PCJHECLMHKN, [Optional] object[] FGAICHJHDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BAD0", Offset = "0x5E9A8D0", VA = "0x185E9BAD0")]
		private static Dictionary<HCIPOEFGANF, IGrouping<HCIPOEFGANF, MethodInfo>> BDDCMFOBAMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C9B0", Offset = "0x5E9B7B0", VA = "0x185E9C9B0")]
		private static bool EJAPCLNOFCI(MethodInfo OAKNBPEDCBH, Type KDJAKNBNDBN, bool KCJPBJNMEEC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MFGGHGHLEGB
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> JCABJOCEHDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> EGPGOHFOCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B8E0", Offset = "0x5E9A6E0", VA = "0x185E9B8E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E9D380", Offset = "0x5E9C180", VA = "0x185E9D380")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LBDPHCDIJKM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct DBNBKEOPBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo KGJEBFPALJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public PBKIGNPNCFO NKCIKJIIENE;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<KMIEHGCCHON, List<DBNBKEOPBMA>> AOPGBDKEDBK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static IBPIJCMLLGH KCKHCAPANAJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static IBPIJCMLLGH HOLJMDCCGIK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static IBPIJCMLLGH PAPPOBJGEJC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IBPIJCMLLGH CGOAPMHKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AF50", Offset = "0x5E99D50", VA = "0x185E9AF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IBPIJCMLLGH DKGKINMPKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A7A0", Offset = "0x5E995A0", VA = "0x185E9A7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static IBPIJCMLLGH JEMPBDLIPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B190", Offset = "0x5E99F90", VA = "0x185E9B190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B020", Offset = "0x5E99E20", VA = "0x185E9B020")]
	[IKBBGLEHKFO]
	private static void GEKBKJKGKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A3E0", Offset = "0x5E991E0", VA = "0x185E9A3E0")]
	[FIGCBHDOGLN(HCIPOEFGANF.Unity_AfterAssembliesLoaded)]
	private static void CFEBHPOIKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A920", Offset = "0x5E99720", VA = "0x185E9A920")]
	public static IBPIJCMLLGH EGBGACMAIAC(KMIEHGCCHON BJINIIEBJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A7E0", Offset = "0x5E995E0", VA = "0x185E9A7E0")]
	private static void EGBGACMAIAC(KMIEHGCCHON BJINIIEBJOK, IBPIJCMLLGH AAMJLCHCCEI, IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E9AB60", Offset = "0x5E99960", VA = "0x185E9AB60")]
	private static void EGBGACMAIAC(KMIEHGCCHON BJINIIEBJOK, IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A680", Offset = "0x5E99480", VA = "0x185E9A680")]
	public static void CFENHGMJHFI(KMIEHGCCHON BJINIIEBJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x221CB80", Offset = "0x221B980", VA = "0x18221CB80")]
	private static bool IABMMPBIBKO(PBKIGNPNCFO EKIFJPLCFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B1D0", Offset = "0x5E99FD0", VA = "0x185E9B1D0")]
	private static IBPIJCMLLGH NFDPCKPLHGB(string ENADFOHMDAC, [Optional] IBPIJCMLLGH AAMJLCHCCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A4B0", Offset = "0x5E992B0", VA = "0x185E9A4B0")]
	private static void CFENHGMJHFI(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B020", Offset = "0x5E99E20", VA = "0x185E9B020")]
	private static void HIFJGDLJKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B340", Offset = "0x5E9A140", VA = "0x185E9B340")]
	private static IEnumerable<DBNBKEOPBMA> PJKBEMPEIKJ(KMIEHGCCHON BJINIIEBJOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B0D0", Offset = "0x5E99ED0", VA = "0x185E9B0D0")]
	private static IBPIJCMLLGH KIFDCKDMINK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BDBIJHKCEBM<T> : IDisposable where T : BDBIJHKCEBM<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T NNOMIIGCPPJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static T AHFNEPHAKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46632B0", Offset = "0x46620B0", VA = "0x1846632B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	protected BDBIJHKCEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4663270", Offset = "0x4662070", VA = "0x184663270", Slot = "5")]
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
