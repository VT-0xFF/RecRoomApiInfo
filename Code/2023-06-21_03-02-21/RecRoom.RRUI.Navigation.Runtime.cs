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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject KKFGDNHNEPN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas EJANCPACGFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject CFDGIDDPOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x70B9030", Offset = "0x70B8230", VA = "0x1870B9030")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route CAGPDPABNCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x943020", Offset = "0x942220", VA = "0x180943020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70B8F00", Offset = "0x70B8100", VA = "0x1870B8F00")]
		public void Initialize(GameObject EDCHEECPPLC, Transform BLFIAOLNAKG, Route GLCALGAECAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70B9100", Offset = "0x70B8300", VA = "0x1870B9100")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70B8EF0", Offset = "0x70B80F0", VA = "0x1870B8EF0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70B8DC0", Offset = "0x70B7FC0", VA = "0x1870B8DC0")]
		private void CHMKEIHKOCD(bool BDNJHFDGEBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
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
					[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x600001A")]
					[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
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
			[JBNLAEMHODB("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x70BBA90", Offset = "0x70BAC90", VA = "0x1870BBA90")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class EBKBLMKGGFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public EBKBLMKGGFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x70B8A60", Offset = "0x70B7C60", VA = "0x1870B8A60")]
			internal bool MFBDHKAAAON(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class ONDFIIDFKJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public ONDFIIDFKJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x70B8C50", Offset = "0x70B7E50", VA = "0x1870B8C50")]
			internal bool BIJGACJJOCC(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OPGBKAMOOBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public AAPEKDAMDII statsig;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public OPGBKAMOOBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x70B8C90", Offset = "0x70B7E90", VA = "0x1870B8C90")]
			internal bool ILBKJJEGGHH(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x70BA130", Offset = "0x70B9330", VA = "0x1870BA130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x70BA080", Offset = "0x70B9280", VA = "0x1870BA080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x70B9BC0", Offset = "0x70B8DC0", VA = "0x1870B9BC0")]
		private static void OHLMLHJNBAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70B93E0", Offset = "0x70B85E0", VA = "0x1870B93E0")]
		public bool EKLHALAOABL(Uri JDPHIKOLOHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x70B97F0", Offset = "0x70B89F0", VA = "0x1870B97F0")]
		public static bool LAMCBIIOCHI(Route GLCALGAECAB, out RoutesConfig LIPENGPOJND, out View LDFJDOOOCIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70B94E0", Offset = "0x70B86E0", VA = "0x1870B94E0")]
		public static AssetReference HIPEBCIKMMA(Route GLCALGAECAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70BA000", Offset = "0x70B9200", VA = "0x1870BA000")]
		public RoutesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LLAADIOHKHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly PageWrapper CEFBHMDLEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IReadOnlyList<JLCNLCDOBLA> FLAKFBPCEDB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8D7200", Offset = "0x8D6400", VA = "0x1808D7200")]
	public LLAADIOHKHO(PageWrapper CAAEGEOIGJE, IReadOnlyList<JLCNLCDOBLA> FOEDOAFANFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JLCNLCDOBLA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GameObject ALPDOCMMBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OOPPNGPPPLE OnBeforePageSwapFrom(Uri JDPHIKOLOHO, JDAPKCCDBPB DENELMLOMPN, LLAADIOHKHO MFBDAKPFHCB);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OOPPNGPPPLE OnBeforePageSwapTo(Uri JDPHIKOLOHO, JDAPKCCDBPB DENELMLOMPN, LLAADIOHKHO EGLBMOHBFJM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OOPPNGPPPLE OnAfterPageSwapTo(Uri JDPHIKOLOHO, JDAPKCCDBPB DENELMLOMPN, LLAADIOHKHO PHHOFLPJACA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OOPPNGPPPLE OnShow(JDAPKCCDBPB DENELMLOMPN, LLAADIOHKHO FFGIIIIJPCJ, LLAADIOHKHO GIBFOFCBCOJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OOPPNGPPPLE OnHide(JDAPKCCDBPB DENELMLOMPN, LLAADIOHKHO FFGIIIIJPCJ, LLAADIOHKHO GIBFOFCBCOJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JDAPKCCDBPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static JDAPKCCDBPB OONGDIKAKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x70B8B50", Offset = "0x70B7D50", VA = "0x1870B8B50")]
		[CompilerGenerated]
		get
		{
			return default(JDAPKCCDBPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public OJLEHFDFHHN MBHAHLIBACK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x985170", Offset = "0x984370", VA = "0x180985170")]
		[CompilerGenerated]
		readonly get
		{
			return default(OJLEHFDFHHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x985240", Offset = "0x984440", VA = "0x180985240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool HKAMGBEHKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1340CE0", Offset = "0x133FEE0", VA = "0x181340CE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x35274F0", Offset = "0x35266F0", VA = "0x1835274F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Uri IHDGNNPHHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x92C1F0", Offset = "0x92B3F0", VA = "0x18092C1F0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xFB98A0", Offset = "0xFB8AA0", VA = "0x180FB98A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Uri FOJCFKNDFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70B8C00", Offset = "0x70B7E00", VA = "0x1870B8C00")]
	public JDAPKCCDBPB(Uri FCKPOAHIACP, Uri PFDLFGKGINB, OJLEHFDFHHN IAFOCLFBEND = OJLEHFDFHHN.None, bool KPFALAMNALE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum OJLEHFDFHHN
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum CNEEPMCFDEH
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
		private sealed class BMCPIMENONM
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
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public BMCPIMENONM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x70B8800", Offset = "0x70B7A00", VA = "0x1870B8800")]
			internal bool DAEDNHCJPHM(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x70B8960", Offset = "0x70B7B60", VA = "0x1870B8960")]
			internal bool DHLPFMJAEAB(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x70BBA10", Offset = "0x70BAC10", VA = "0x1870BBA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x70BB820", Offset = "0x70BAA20", VA = "0x1870BB820")]
		public Uri(Uri JDPHIKOLOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70BB750", Offset = "0x70BA950", VA = "0x1870BB750")]
		public Uri(params Route[] GLCALGAECAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x70BB920", Offset = "0x70BAB20", VA = "0x1870BB920")]
		public Uri(IEnumerable<Route> GLCALGAECAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x70BACE0", Offset = "0x70B9EE0", VA = "0x1870BACE0")]
		public bool PLLNGOBMPBN(Route GLCALGAECAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x70BAD40", Offset = "0x70B9F40", VA = "0x1870BAD40")]
		public bool PLLNGOBMPBN(IEnumerable<Route> MKJFAHABNBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x70BADF0", Offset = "0x70B9FF0", VA = "0x1870BADF0")]
		public bool PLLNGOBMPBN(Uri HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x70BA630", Offset = "0x70B9830", VA = "0x1870BA630")]
		public static bool JNICLPBNKND(Uri JDPHIKOLOHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x70BA690", Offset = "0x70B9890", VA = "0x1870BA690")]
		public static bool KKBGDLBHIFL(Uri KCJELMMMDCA, Uri NMKMEIDKGEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x70BA980", Offset = "0x70B9B80", VA = "0x1870BA980")]
		public bool KKBGDLBHIFL(Uri HPOECFLNEOJ, bool GBHJEJHJOKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x70BA310", Offset = "0x70B9510", VA = "0x1870BA310", Slot = "4")]
		public bool Equals(Uri HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70BAA80", Offset = "0x70B9C80", VA = "0x1870BAA80")]
		public static bool KKBGDLBHIFL(Uri JDPHIKOLOHO, Route GLCALGAECAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x70BA2A0", Offset = "0x70B94A0", VA = "0x1870BA2A0", Slot = "5")]
		public bool Equals(Route GLCALGAECAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x70BA3A0", Offset = "0x70B95A0", VA = "0x1870BA3A0", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70BA4B0", Offset = "0x70B96B0", VA = "0x1870BA4B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x70BAC40", Offset = "0x70B9E40", VA = "0x1870BAC40")]
		public string MJHNLBIFAHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x70BB1D0", Offset = "0x70BA3D0", VA = "0x1870BB1D0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA37810", Offset = "0xA36A10", VA = "0x180A37810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70B92E0", Offset = "0x70B84E0", VA = "0x1870B92E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x70B9140", Offset = "0x70B8340", VA = "0x1870B9140", Slot = "4")]
		public bool Equals(Route HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x70B9210", Offset = "0x70B8410", VA = "0x1870B9210", Slot = "5")]
		public bool Equals(Uri JDPHIKOLOHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x70B9280", Offset = "0x70B8480", VA = "0x1870B9280")]
		public AssetReference HIPEBCIKMMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x70B93B0", Offset = "0x70B85B0", VA = "0x1870B93B0")]
		public Route()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
