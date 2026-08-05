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
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject ELDLHNCIKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6FA9D40", Offset = "0x6FA8540", VA = "0x186FA9D40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route NMDJFNHDPND
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x919F90", Offset = "0x918790", VA = "0x180919F90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9E20", Offset = "0x6FA8620", VA = "0x186FA9E20")]
		public void Initialize(GameObject MFFMMPPNONL, Transform ONIJEEBBCHK, Route IMMPKBIOJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9F50", Offset = "0x6FA8750", VA = "0x186FA9F50")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9E10", Offset = "0x6FA8610", VA = "0x186FA9E10")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9C10", Offset = "0x6FA8410", VA = "0x186FA9C10")]
		private void AIELNKDOKCB(bool LKCGHJCEFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
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
					[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x600001A")]
					[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
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
				[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x8ACF00", Offset = "0x8AB700", VA = "0x1808ACF00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x7F2CE0", Offset = "0x7F14E0", VA = "0x1807F2CE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC8E0", Offset = "0x6FAB0E0", VA = "0x186FAC8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public KMDBPNFAHCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6FA99F0", Offset = "0x6FA81F0", VA = "0x186FA99F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public FLBBCHAKNDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6FA98B0", Offset = "0x6FA80B0", VA = "0x186FA98B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public PGGJPBCBLIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6FA9AE0", Offset = "0x6FA82E0", VA = "0x186FA9AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FAAF70", Offset = "0x6FA9770", VA = "0x186FAAF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6FAAEC0", Offset = "0x6FA96C0", VA = "0x186FAAEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAA00", Offset = "0x6FA9200", VA = "0x186FAAA00")]
		private static void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA540", Offset = "0x6FA8D40", VA = "0x186FAA540")]
		public bool IMAAKILNMDI(Uri IDBNNCGGEDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA640", Offset = "0x6FA8E40", VA = "0x186FAA640")]
		public static bool MCFAIDDKGKO(Route IMMPKBIOJGO, out RoutesConfig CKBBJKLDDGA, out View OGJMJJOGDDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA230", Offset = "0x6FA8A30", VA = "0x186FAA230")]
		public static AssetReference FAHBPCLMLBA(Route IMMPKBIOJGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FAAE40", Offset = "0x6FA9640", VA = "0x186FAAE40")]
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
	[Cpp2IlInjected.Address(RVA = "0x8AC4E0", Offset = "0x8AACE0", VA = "0x1808AC4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FA98F0", Offset = "0x6FA80F0", VA = "0x186FA98F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x95A520", Offset = "0x958D20", VA = "0x18095A520")]
		[CompilerGenerated]
		readonly get
		{
			return default(LGGIMMPNGMP);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9E26F0", Offset = "0x9E0EF0", VA = "0x1809E26F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OBGLLJCJNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x13ABDB0", Offset = "0x13AA5B0", VA = "0x1813ABDB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x35B0180", Offset = "0x35AE980", VA = "0x1835B0180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Uri IGGKCKLEILO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x903380", Offset = "0x901B80", VA = "0x180903380")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF43DC0", Offset = "0xF425C0", VA = "0x180F43DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Uri IPLNFCHIDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8CCF80", Offset = "0x8CB780", VA = "0x1808CCF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FA99A0", Offset = "0x6FA81A0", VA = "0x186FA99A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public DJNFODLINJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6FA9760", Offset = "0x6FA7F60", VA = "0x186FA9760")]
			internal bool LDAMKMBCFCE(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6FA9660", Offset = "0x6FA7E60", VA = "0x186FA9660")]
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
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6FAC860", Offset = "0x6FAB060", VA = "0x186FAC860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC670", Offset = "0x6FAAE70", VA = "0x186FAC670")]
		public Uri(Uri IDBNNCGGEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC5A0", Offset = "0x6FAADA0", VA = "0x186FAC5A0")]
		public Uri(params Route[] IMMPKBIOJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC770", Offset = "0x6FAAF70", VA = "0x186FAC770")]
		public Uri(IEnumerable<Route> IMMPKBIOJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6FABF60", Offset = "0x6FAA760", VA = "0x186FABF60")]
		public bool ODOLPHCGINH(Route IMMPKBIOJGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FABAD0", Offset = "0x6FAA2D0", VA = "0x186FABAD0")]
		public bool ODOLPHCGINH(IEnumerable<Route> OENBILNFNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6FABB80", Offset = "0x6FAA380", VA = "0x186FABB80")]
		public bool ODOLPHCGINH(Uri MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6FABFC0", Offset = "0x6FAA7C0", VA = "0x186FABFC0")]
		public static bool OKHCPHKNICN(Uri IDBNNCGGEDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB2F0", Offset = "0x6FA9AF0", VA = "0x186FAB2F0")]
		public static bool FMOLALLCICL(Uri NBLDAOBEAEA, Uri PAJLLFKCBBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB5E0", Offset = "0x6FA9DE0", VA = "0x186FAB5E0")]
		public bool FMOLALLCICL(Uri MDHJAFNLPON, bool KGGJDHJFFPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB150", Offset = "0x6FA9950", VA = "0x186FAB150", Slot = "4")]
		public bool Equals(Uri MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB6E0", Offset = "0x6FA9EE0", VA = "0x186FAB6E0")]
		public static bool FMOLALLCICL(Uri IDBNNCGGEDH, Route IMMPKBIOJGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB0E0", Offset = "0x6FA98E0", VA = "0x186FAB0E0", Slot = "5")]
		public bool Equals(Route IMMPKBIOJGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB1E0", Offset = "0x6FA99E0", VA = "0x186FAB1E0", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB8A0", Offset = "0x6FAA0A0", VA = "0x186FAB8A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FABA30", Offset = "0x6FAA230", VA = "0x186FABA30")]
		public string MEJDDIFJNOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC020", Offset = "0x6FAA820", VA = "0x186FAC020", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x85D1E0", Offset = "0x85B9E0", VA = "0x18085D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAF0720", Offset = "0xAEEF20", VA = "0x180AF0720", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA130", Offset = "0x6FA8930", VA = "0x186FAA130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FA9F90", Offset = "0x6FA8790", VA = "0x186FA9F90", Slot = "4")]
		public bool Equals(Route MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA060", Offset = "0x6FA8860", VA = "0x186FAA060", Slot = "5")]
		public bool Equals(Uri IDBNNCGGEDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA0D0", Offset = "0x6FA88D0", VA = "0x186FAA0D0")]
		public AssetReference FAHBPCLMLBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6FAA200", Offset = "0x6FA8A00", VA = "0x186FAA200")]
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
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
