using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RRUI;
using RRUI.Navigation;
using RecRoom.Analytics.Statsig;
using RecRoom.Core.UI;
using RecRoom.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PageWrapper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject IKFEJPMFOIP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas FMOMPPKHPBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject ELDLHNCIKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7F3240", Offset = "0x7F1E40", VA = "0x1807F3240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A790", Offset = "0x6F79390", VA = "0x186F7A790")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route NMDJFNHDPND
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x88FE20", Offset = "0x88EA20", VA = "0x18088FE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A870", Offset = "0x6F79470", VA = "0x186F7A870")]
		public void Initialize(GameObject MFFMMPPNONL, Transform ONIJEEBBCHK, Route IMMPKBIOJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A9A0", Offset = "0x6F795A0", VA = "0x186F7A9A0")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A860", Offset = "0x6F79460", VA = "0x186F7A860")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A660", Offset = "0x6F79260", VA = "0x186F7A660")]
		private void AIELNKDOKCB(bool LKCGHJCEFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87DF50", Offset = "0x87CB50", VA = "0x18087DF50")]
		public PageWrapper()
		{
		}
	}
}
namespace RRUI.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CreateAssetMenu]
	public class RoutesConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public class View
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public class StatsigVariant
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				[SerializeField]
				private SerializedStatsigExperimentSegment statsigSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public SerializedStatsigExperimentSegment StatsigSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000019")]
					[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x600001A")]
					[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
				public StatsigVariant()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			[SerializeField]
			private SerializedGuid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			[SerializeField]
			private string friendlyName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			[SerializeField]
			private AssetReference prefabReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			[SerializeField]
			[HFGPJOINBMP("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x7F3240", Offset = "0x7F1E40", VA = "0x1807F3240")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F7D330", Offset = "0x6F7BF30", VA = "0x186F7D330")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class KMDBPNFAHCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public KMDBPNFAHCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A440", Offset = "0x6F79040", VA = "0x186F7A440")]
			internal bool LAFFOFAJBJE(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class FLBBCHAKNDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public FLBBCHAKNDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A300", Offset = "0x6F78F00", VA = "0x186F7A300")]
			internal bool FNCFOANDNOL(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PGGJPBCBLIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public CHMPJAOMKBA statsig;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public PGGJPBCBLIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A530", Offset = "0x6F79130", VA = "0x186F7A530")]
			internal bool MAMNBNDNHDE(View.StatsigVariant variant)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly string ResourcesRoutesDirectoryPath;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly string FullRoutesDirectoryPath;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static List<RoutesConfig> _configs;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static Dictionary<Guid, View> _viewMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private List<View> views;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private static bool _isInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B9C0", Offset = "0x6F7A5C0", VA = "0x186F7B9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6F7B910", Offset = "0x6F7A510", VA = "0x186F7B910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B450", Offset = "0x6F7A050", VA = "0x186F7B450")]
		private static void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AF90", Offset = "0x6F79B90", VA = "0x186F7AF90")]
		public bool IMAAKILNMDI(Uri IDBNNCGGEDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B090", Offset = "0x6F79C90", VA = "0x186F7B090")]
		public static bool MCFAIDDKGKO(Route IMMPKBIOJGO, out RoutesConfig CKBBJKLDDGA, out View OGJMJJOGDDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AC80", Offset = "0x6F79880", VA = "0x186F7AC80")]
		public static AssetReference FAHBPCLMLBA(Route IMMPKBIOJGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F7B890", Offset = "0x6F7A490", VA = "0x186F7B890")]
		public RoutesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JKNJJFFOCDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly PageWrapper DPJHMEECEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IReadOnlyList<BCKJFPIDBNC> CHIFNPPPOLJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9138A0", Offset = "0x9124A0", VA = "0x1809138A0")]
	public JKNJJFFOCDP(PageWrapper NAEMAAKCJBE, IReadOnlyList<BCKJFPIDBNC> ECOMHNEEECN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BCKJFPIDBNC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GameObject ICCGPNIDAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EILHPPDHBHH OnBeforePageSwapFrom(Uri IDBNNCGGEDH, IGLBDMKFFFH BNKIEKDIHNM, JKNJJFFOCDP DLEANHGBCFF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EILHPPDHBHH OnBeforePageSwapTo(Uri IDBNNCGGEDH, IGLBDMKFFFH BNKIEKDIHNM, JKNJJFFOCDP CJNDEDMHCEP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EILHPPDHBHH OnAfterPageSwapTo(Uri IDBNNCGGEDH, IGLBDMKFFFH BNKIEKDIHNM, JKNJJFFOCDP FOACEEHOOHB);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EILHPPDHBHH OnShow(IGLBDMKFFFH BNKIEKDIHNM, JKNJJFFOCDP LAEHMFOFKHG, JKNJJFFOCDP DFIMKCFMDJN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EILHPPDHBHH OnHide(IGLBDMKFFFH BNKIEKDIHNM, JKNJJFFOCDP LAEHMFOFKHG, JKNJJFFOCDP DFIMKCFMDJN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IGLBDMKFFFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static IGLBDMKFFFH OAEIAFEPBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A340", Offset = "0x6F78F40", VA = "0x186F7A340")]
		[CompilerGenerated]
		get
		{
			return default(IGLBDMKFFFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LGGIMMPNGMP LANMMNCINOI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x91F8E0", Offset = "0x91E4E0", VA = "0x18091F8E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(LGGIMMPNGMP);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x91F850", Offset = "0x91E450", VA = "0x18091F850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OBGLLJCJNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xFDDAE0", Offset = "0xFDC6E0", VA = "0x180FDDAE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3188BE0", Offset = "0x31877E0", VA = "0x183188BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Uri IGGKCKLEILO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8791D0", Offset = "0x877DD0", VA = "0x1808791D0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xD5A350", Offset = "0xD58F50", VA = "0x180D5A350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Uri IPLNFCHIDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x842A50", Offset = "0x841650", VA = "0x180842A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A3F0", Offset = "0x6F78FF0", VA = "0x186F7A3F0")]
	public IGLBDMKFFFH(Uri HFHGIHPGANA, Uri IAALBJPHFKI, LGGIMMPNGMP OBFFPNLHFFK = LGGIMMPNGMP.None, bool OIDFINMDFOM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum LGGIMMPNGMP
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum GPJMGIAGHCF
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Pending
}
namespace RRUI.Navigation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class Uri : IEquatable<Uri>, IEquatable<Route>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DJNFODLINJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public IReadOnlyList<Route> bRoute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Uri b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Uri a;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public DJNFODLINJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A1B0", Offset = "0x6F78DB0", VA = "0x186F7A1B0")]
			internal bool LDAMKMBCFCE(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A0B0", Offset = "0x6F78CB0", VA = "0x186F7A0B0")]
			internal bool JJFPLONAFEO(string k)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly string nullRouteString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private List<Route> route;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Dictionary<string, object> data;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F7D2B0", Offset = "0x6F7BEB0", VA = "0x186F7D2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D0C0", Offset = "0x6F7BCC0", VA = "0x186F7D0C0")]
		public Uri(Uri IDBNNCGGEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CFF0", Offset = "0x6F7BBF0", VA = "0x186F7CFF0")]
		public Uri(params Route[] IMMPKBIOJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F7D1C0", Offset = "0x6F7BDC0", VA = "0x186F7D1C0")]
		public Uri(IEnumerable<Route> IMMPKBIOJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C9B0", Offset = "0x6F7B5B0", VA = "0x186F7C9B0")]
		public bool ODOLPHCGINH(Route IMMPKBIOJGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C520", Offset = "0x6F7B120", VA = "0x186F7C520")]
		public bool ODOLPHCGINH(IEnumerable<Route> OENBILNFNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C5D0", Offset = "0x6F7B1D0", VA = "0x186F7C5D0")]
		public bool ODOLPHCGINH(Uri MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CA10", Offset = "0x6F7B610", VA = "0x186F7CA10")]
		public static bool OKHCPHKNICN(Uri IDBNNCGGEDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BD40", Offset = "0x6F7A940", VA = "0x186F7BD40")]
		public static bool FMOLALLCICL(Uri NBLDAOBEAEA, Uri PAJLLFKCBBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C030", Offset = "0x6F7AC30", VA = "0x186F7C030")]
		public bool FMOLALLCICL(Uri MDHJAFNLPON, bool KGGJDHJFFPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BBA0", Offset = "0x6F7A7A0", VA = "0x186F7BBA0", Slot = "4")]
		public bool Equals(Uri MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C130", Offset = "0x6F7AD30", VA = "0x186F7C130")]
		public static bool FMOLALLCICL(Uri IDBNNCGGEDH, Route IMMPKBIOJGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BB30", Offset = "0x6F7A730", VA = "0x186F7BB30", Slot = "5")]
		public bool Equals(Route IMMPKBIOJGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F7BC30", Offset = "0x6F7A830", VA = "0x186F7BC30", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C2F0", Offset = "0x6F7AEF0", VA = "0x186F7C2F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6F7C480", Offset = "0x6F7B080", VA = "0x186F7C480")]
		public string MEJDDIFJNOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F7CA70", Offset = "0x6F7B670", VA = "0x186F7CA70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Route : IEquatable<Route>, IEquatable<Uri>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private SerializedGuid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public SerializedGuid ViewGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xE4DB40", Offset = "0xE4C740", VA = "0x180E4DB40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AB80", Offset = "0x6F79780", VA = "0x186F7AB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A9E0", Offset = "0x6F795E0", VA = "0x186F7A9E0", Slot = "4")]
		public bool Equals(Route MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AAB0", Offset = "0x6F796B0", VA = "0x186F7AAB0", Slot = "5")]
		public bool Equals(Uri IDBNNCGGEDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AB20", Offset = "0x6F79720", VA = "0x186F7AB20")]
		public AssetReference FAHBPCLMLBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F7AC50", Offset = "0x6F79850", VA = "0x186F7AC50")]
		public Route()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
