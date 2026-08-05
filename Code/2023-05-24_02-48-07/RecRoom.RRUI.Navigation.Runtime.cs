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
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject ELDLHNCIKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6F77ED0", Offset = "0x6F76AD0", VA = "0x186F77ED0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route NMDJFNHDPND
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8A4420", Offset = "0x8A3020", VA = "0x1808A4420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F77FB0", Offset = "0x6F76BB0", VA = "0x186F77FB0")]
		public void Initialize(GameObject MFFMMPPNONL, Transform ONIJEEBBCHK, Route IMMPKBIOJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F780E0", Offset = "0x6F76CE0", VA = "0x186F780E0")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F77FA0", Offset = "0x6F76BA0", VA = "0x186F77FA0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F77DA0", Offset = "0x6F769A0", VA = "0x186F77DA0")]
		private void AIELNKDOKCB(bool LKCGHJCEFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x892580", Offset = "0x891180", VA = "0x180892580")]
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
					[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x600001A")]
					[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x8370C0", Offset = "0x835CC0", VA = "0x1808370C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x7F0240", Offset = "0x7EEE40", VA = "0x1807F0240")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F7AA70", Offset = "0x6F79670", VA = "0x186F7AA70")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public KMDBPNFAHCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F77B80", Offset = "0x6F76780", VA = "0x186F77B80")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public FLBBCHAKNDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F77A40", Offset = "0x6F76640", VA = "0x186F77A40")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public PGGJPBCBLIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F77C70", Offset = "0x6F76870", VA = "0x186F77C70")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F79100", Offset = "0x6F77D00", VA = "0x186F79100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6F79050", Offset = "0x6F77C50", VA = "0x186F79050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F78B90", Offset = "0x6F77790", VA = "0x186F78B90")]
		private static void PBAELFIBGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F786D0", Offset = "0x6F772D0", VA = "0x186F786D0")]
		public bool IMAAKILNMDI(Uri IDBNNCGGEDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F787D0", Offset = "0x6F773D0", VA = "0x186F787D0")]
		public static bool MCFAIDDKGKO(Route IMMPKBIOJGO, out RoutesConfig CKBBJKLDDGA, out View OGJMJJOGDDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F783C0", Offset = "0x6F76FC0", VA = "0x186F783C0")]
		public static AssetReference FAHBPCLMLBA(Route IMMPKBIOJGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F78FD0", Offset = "0x6F77BD0", VA = "0x186F78FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8366A0", Offset = "0x8352A0", VA = "0x1808366A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F77A80", Offset = "0x6F76680", VA = "0x186F77A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E49B0", Offset = "0x8E35B0", VA = "0x1808E49B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(LGGIMMPNGMP);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x96CBB0", Offset = "0x96B7B0", VA = "0x18096CBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OBGLLJCJNPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1164850", Offset = "0x1163450", VA = "0x181164850")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x332BB10", Offset = "0x332A710", VA = "0x18332BB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Uri IGGKCKLEILO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88D810", Offset = "0x88C410", VA = "0x18088D810")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE2AF90", Offset = "0xE29B90", VA = "0x180E2AF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Uri IPLNFCHIDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x857190", Offset = "0x855D90", VA = "0x180857190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F77B30", Offset = "0x6F76730", VA = "0x186F77B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public DJNFODLINJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6F778F0", Offset = "0x6F764F0", VA = "0x186F778F0")]
			internal bool LDAMKMBCFCE(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F777F0", Offset = "0x6F763F0", VA = "0x186F777F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F7A9F0", Offset = "0x6F795F0", VA = "0x186F7A9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A800", Offset = "0x6F79400", VA = "0x186F7A800")]
		public Uri(Uri IDBNNCGGEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A730", Offset = "0x6F79330", VA = "0x186F7A730")]
		public Uri(params Route[] IMMPKBIOJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A900", Offset = "0x6F79500", VA = "0x186F7A900")]
		public Uri(IEnumerable<Route> IMMPKBIOJGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A0F0", Offset = "0x6F78CF0", VA = "0x186F7A0F0")]
		public bool ODOLPHCGINH(Route IMMPKBIOJGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6F79C60", Offset = "0x6F78860", VA = "0x186F79C60")]
		public bool ODOLPHCGINH(IEnumerable<Route> OENBILNFNCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6F79D10", Offset = "0x6F78910", VA = "0x186F79D10")]
		public bool ODOLPHCGINH(Uri MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A150", Offset = "0x6F78D50", VA = "0x186F7A150")]
		public static bool OKHCPHKNICN(Uri IDBNNCGGEDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6F79480", Offset = "0x6F78080", VA = "0x186F79480")]
		public static bool FMOLALLCICL(Uri NBLDAOBEAEA, Uri PAJLLFKCBBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6F79770", Offset = "0x6F78370", VA = "0x186F79770")]
		public bool FMOLALLCICL(Uri MDHJAFNLPON, bool KGGJDHJFFPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6F792E0", Offset = "0x6F77EE0", VA = "0x186F792E0", Slot = "4")]
		public bool Equals(Uri MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F79870", Offset = "0x6F78470", VA = "0x186F79870")]
		public static bool FMOLALLCICL(Uri IDBNNCGGEDH, Route IMMPKBIOJGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F79270", Offset = "0x6F77E70", VA = "0x186F79270", Slot = "5")]
		public bool Equals(Route IMMPKBIOJGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6F79370", Offset = "0x6F77F70", VA = "0x186F79370", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6F79A30", Offset = "0x6F78630", VA = "0x186F79A30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6F79BC0", Offset = "0x6F787C0", VA = "0x186F79BC0")]
		public string MEJDDIFJNOO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A1B0", Offset = "0x6F78DB0", VA = "0x186F7A1B0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x837A60", Offset = "0x836660", VA = "0x180837A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xD86A90", Offset = "0xD85690", VA = "0x180D86A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F782C0", Offset = "0x6F76EC0", VA = "0x186F782C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F78120", Offset = "0x6F76D20", VA = "0x186F78120", Slot = "4")]
		public bool Equals(Route MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6F781F0", Offset = "0x6F76DF0", VA = "0x186F781F0", Slot = "5")]
		public bool Equals(Uri IDBNNCGGEDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F78260", Offset = "0x6F76E60", VA = "0x186F78260")]
		public AssetReference FAHBPCLMLBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F78390", Offset = "0x6F76F90", VA = "0x186F78390")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
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
