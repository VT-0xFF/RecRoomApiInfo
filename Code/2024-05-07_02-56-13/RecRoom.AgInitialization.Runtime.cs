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
		private sealed class EGHEFGMBCAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public Type requiredAttribute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public Func<MethodInfo, bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public EGHEFGMBCAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6070EC0", Offset = "0x60700C0", VA = "0x186070EC0")]
			internal IEnumerable<MethodInfo> AAHBFJEAFNI(Type type)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6070F80", Offset = "0x6070180", VA = "0x186070F80")]
			internal bool PGKCLFDIPGH(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		[CompilerGenerated]
		private sealed class HOPGCIAHJHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Type attributeType;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public HOPGCIAHJHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x60710A0", Offset = "0x60702A0", VA = "0x1860710A0")]
			internal bool MNDLPPNIGKA(MethodInfo method)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class ICPLPJCDCFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Type requiredAttributeType;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public ICPLPJCDCFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6071100", Offset = "0x6070300", VA = "0x186071100")]
			internal bool IEHPOAFMIPH(CustomAttributeData attribute)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Dictionary<BLJBFKICAJD, IGrouping<BLJBFKICAJD, MethodInfo>> JJIIJPJDPPE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Type OOFJOLGGOIJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6073110", Offset = "0x6072310", VA = "0x186073110")]
		private static void HJJBLCNICHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6073E40", Offset = "0x6073040", VA = "0x186073E40")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void SubsystemRegistration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6072D10", Offset = "0x6071F10", VA = "0x186072D10")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void AfterAssembliesLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6073000", Offset = "0x6072200", VA = "0x186073000")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		private static void BeforeSplashScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6072FB0", Offset = "0x60721B0", VA = "0x186072FB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void BeforeSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6072D60", Offset = "0x6071F60", VA = "0x186072D60")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void AfterSceneLoad()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6073050", Offset = "0x6072250", VA = "0x186073050")]
		private static void GFJHAIHDDFO(BLJBFKICAJD KBJLNJMMKJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6073650", Offset = "0x6072850", VA = "0x186073650")]
		private static IEnumerable<MethodInfo> JFNAAILJCAB(Type DMEJGGIFOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6073C90", Offset = "0x6072E90", VA = "0x186073C90")]
		private static bool PHAGKIEJAKK(string MLCDFCGDKCB, [Out] Dictionary<string, List<string>> BPPFELCGKKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6072600", Offset = "0x6071800", VA = "0x186072600")]
		private static IEnumerable<Type> AGFJDFMHPCB(Dictionary<string, List<string>> BPPFELCGKKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6072DB0", Offset = "0x6071FB0", VA = "0x186072DB0")]
		private static IEnumerable<MethodInfo> BAGJIKCOLAF(IEnumerable<Type> CKIGCMBDDLG, Type DMEJGGIFOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6073DB0", Offset = "0x6072FB0", VA = "0x186073DB0")]
		internal static IEnumerable<MethodInfo> PMOCIDHDCCE(BLJBFKICAJD KBJLNJMMKJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60736E0", Offset = "0x60728E0", VA = "0x1860736E0")]
		internal static void OILODIANEEN(IEnumerable<MethodInfo> KJHGEKKFMBK, Type NLADLNALBAK, [Optional] object[] HELLICJGLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6073C00", Offset = "0x6072E00", VA = "0x186073C00")]
		private static Dictionary<BLJBFKICAJD, IGrouping<BLJBFKICAJD, MethodInfo>> PEJMAOJLBJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6072E90", Offset = "0x6072090", VA = "0x186072E90")]
		private static bool BCBJPCICHCB(MethodInfo KFBFAFBOJIK, Type PAIEIOCNKHO, bool KKBBKFMBIPF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GEGMFNDDKHD
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static Dictionary<string, List<string>> JLJNLDOAAFK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static Dictionary<string, List<string>> JFHJIBMKJII
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6070FE0", Offset = "0x60701E0", VA = "0x186070FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6073F90", Offset = "0x6073190", VA = "0x186073F90")]
		public static Type GetTypeWithErrorHandling(string qualifiedTypeName, string callingClassName)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KCHGANJJBPP
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct PBPEDEJCNGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MethodInfo LAICBOGIEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CMEECPGEPNF ADBHFCMDFIK;
	}

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static Dictionary<BDECECCJEGA, List<PBPEDEJCNGC>> IICKLNAIGLM;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static LEHDPNIFNIH DHFJHOHPOGP;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LEHDPNIFNIH LJNDMGKOICM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static LEHDPNIFNIH GEKCAGBNGAF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static LEHDPNIFNIH AKJHKAMODFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6071810", Offset = "0x6070A10", VA = "0x186071810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static LEHDPNIFNIH EAPOPFDDNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x60717D0", Offset = "0x60709D0", VA = "0x1860717D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static LEHDPNIFNIH AKCCIFCOJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60718D0", Offset = "0x6070AD0", VA = "0x1860718D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool DKOOGMHMHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6071790", Offset = "0x6070990", VA = "0x186071790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6071150", Offset = "0x6070350", VA = "0x186071150")]
	[JNPPMLEKKFK]
	private static void ABKONOIMBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6072530", Offset = "0x6071730", VA = "0x186072530")]
	[IGEKFJAFMOG(BLJBFKICAJD.Unity_AfterAssembliesLoaded)]
	private static void ONNNMDHFIDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60721A0", Offset = "0x60713A0", VA = "0x1860721A0")]
	public static LEHDPNIFNIH LNKLNCPHGHI(BDECECCJEGA AKOOFPGAMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6071C90", Offset = "0x6070E90", VA = "0x186071C90")]
	private static void LNKLNCPHGHI(BDECECCJEGA AKOOFPGAMJH, LEHDPNIFNIH MPDCPFFFOEC, LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6071DD0", Offset = "0x6070FD0", VA = "0x186071DD0")]
	private static void LNKLNCPHGHI(BDECECCJEGA AKOOFPGAMJH, LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6071B80", Offset = "0x6070D80", VA = "0x186071B80")]
	public static void KPGDEODOMHE(BDECECCJEGA AKOOFPGAMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2399320", Offset = "0x2398520", VA = "0x182399320")]
	private static bool JPGMOHNMOCG(CMEECPGEPNF EGPCCILLCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60723C0", Offset = "0x60715C0", VA = "0x1860723C0")]
	private static LEHDPNIFNIH MCCDHACJEPI(string FKECDANHNMP, [Optional] LEHDPNIFNIH MPDCPFFFOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60719C0", Offset = "0x6070BC0", VA = "0x1860719C0")]
	private static void KPGDEODOMHE(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6071150", Offset = "0x6070350", VA = "0x186071150")]
	private static void KIOIADNPBDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60711F0", Offset = "0x60703F0", VA = "0x1860711F0")]
	private static IEnumerable<PBPEDEJCNGC> ALJMBPACGDD(BDECECCJEGA AKOOFPGAMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6071910", Offset = "0x6070B10", VA = "0x186071910")]
	private static LEHDPNIFNIH GPEONGGIFOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DNEDBDNHMJH<T> : IDisposable where T : DNEDBDNHMJH<T>, new()
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static T JHPIMPOFIFB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static T KMGHIJMKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x51357C0", Offset = "0x51349C0", VA = "0x1851357C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected DNEDBDNHMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5135790", Offset = "0x5134990", VA = "0x185135790", Slot = "5")]
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
