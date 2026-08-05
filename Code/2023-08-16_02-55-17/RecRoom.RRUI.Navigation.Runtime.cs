using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject CFHEEPKPLCO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas HNEAEMDFMKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject AABFGNFECFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB5D0", Offset = "0x6ECA7D0", VA = "0x186ECB5D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route GMFJMLEFBAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8D3DD0", Offset = "0x8D2FD0", VA = "0x1808D3DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB4A0", Offset = "0x6ECA6A0", VA = "0x186ECB4A0")]
		public void Initialize(GameObject MPJLCGCFMHD, Transform OJEMCPHOKBP, Route LAEOBNIKFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB6A0", Offset = "0x6ECA8A0", VA = "0x186ECB6A0")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB490", Offset = "0x6ECA690", VA = "0x186ECB490")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB360", Offset = "0x6ECA560", VA = "0x186ECB360")]
		private void ENBGOADNLJL(bool IJALPAMOFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
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
					[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x600001A")]
					[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
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
			[HOLANPNIEIG("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6ECE030", Offset = "0x6ECD230", VA = "0x186ECE030")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class CCCDNEOKMFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public CCCDNEOKMFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6ECADA0", Offset = "0x6EC9FA0", VA = "0x186ECADA0")]
			internal bool KNMJNNDABBF(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class NAIGDHJOEOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public NAIGDHJOEOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB320", Offset = "0x6ECA520", VA = "0x186ECB320")]
			internal bool EFHNHDLEGBO(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IINFBFKGAPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public HJMPLECDHEG statsig;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public IINFBFKGAPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6ECAE90", Offset = "0x6ECA090", VA = "0x186ECAE90")]
			internal bool GIGACDGEDLN(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x6ECC6D0", Offset = "0x6ECB8D0", VA = "0x186ECC6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC620", Offset = "0x6ECB820", VA = "0x186ECC620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC160", Offset = "0x6ECB360", VA = "0x186ECC160")]
		private static void KCEHONPEIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBC90", Offset = "0x6ECAE90", VA = "0x186ECBC90")]
		public bool CLOCNONGMIB(Uri HEEAGBHJANP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBD90", Offset = "0x6ECAF90", VA = "0x186ECBD90")]
		public static bool ECCHHBHGCCE(Route LAEOBNIKFGN, out RoutesConfig MDCEDIPHMBD, out View HGEDNPHFLEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB980", Offset = "0x6ECAB80", VA = "0x186ECB980")]
		public static AssetReference CLDCGJPHLKG(Route LAEOBNIKFGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC5A0", Offset = "0x6ECB7A0", VA = "0x186ECC5A0")]
		public RoutesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class POBNGJJNIKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly PageWrapper ALPEALJJBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IReadOnlyList<NODIGKLKHHM> COABAIAMPEN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x927D00", Offset = "0x926F00", VA = "0x180927D00")]
	public POBNGJJNIKE(PageWrapper CIIHIGHGFPF, IReadOnlyList<NODIGKLKHHM> DBKGEHBNHOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NODIGKLKHHM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GameObject KHDPFEHDDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GIOBGNHJLID OnBeforePageSwapFrom(Uri HEEAGBHJANP, LNJJNILMMCM OJDIKMLBBCE, POBNGJJNIKE BEGBNOFPKGL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GIOBGNHJLID OnBeforePageSwapTo(Uri HEEAGBHJANP, LNJJNILMMCM OJDIKMLBBCE, POBNGJJNIKE HIPKPMDDEBN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GIOBGNHJLID OnAfterPageSwapTo(Uri HEEAGBHJANP, LNJJNILMMCM OJDIKMLBBCE, POBNGJJNIKE DJKMCBLLKDI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GIOBGNHJLID OnShow(LNJJNILMMCM OJDIKMLBBCE, POBNGJJNIKE LFDJEENIKEB, POBNGJJNIKE POHCGGEPHGL);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GIOBGNHJLID OnHide(LNJJNILMMCM OJDIKMLBBCE, POBNGJJNIKE LFDJEENIKEB, POBNGJJNIKE POHCGGEPHGL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LNJJNILMMCM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LNJJNILMMCM NBIAOCJLGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6ECAFC0", Offset = "0x6ECA1C0", VA = "0x186ECAFC0")]
		[CompilerGenerated]
		get
		{
			return default(LNJJNILMMCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BDNJNGBCNNI LCKADGNIMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB325B0", Offset = "0xB317B0", VA = "0x180B325B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(BDNJNGBCNNI);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x892940", Offset = "0x891B40", VA = "0x180892940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool KEAPNBDOJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x15BDE50", Offset = "0x15BD050", VA = "0x1815BDE50")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28BFEE0", Offset = "0x28BF0E0", VA = "0x1828BFEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Uri DEBEAABKNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x902ED0", Offset = "0x9020D0", VA = "0x180902ED0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x902F00", Offset = "0x902100", VA = "0x180902F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Uri OFJBCPHMCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x902EE0", Offset = "0x9020E0", VA = "0x180902EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB070", Offset = "0x6ECA270", VA = "0x186ECB070")]
	public LNJJNILMMCM(Uri INKIDIJMICF, Uri BIKMLOMPBOL, BDNJNGBCNNI HOMKEEHGIDB = BDNJNGBCNNI.None, bool MBOAHGLIKME = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum BDNJNGBCNNI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum HKEALIKJPII
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
		private sealed class MIENFCMEAMB
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
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public MIENFCMEAMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB1C0", Offset = "0x6ECA3C0", VA = "0x186ECB1C0")]
			internal bool NJEKCHPJLOF(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6ECB0C0", Offset = "0x6ECA2C0", VA = "0x186ECB0C0")]
			internal bool BLNGBKABJOK(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6ECDFB0", Offset = "0x6ECD1B0", VA = "0x186ECDFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDDC0", Offset = "0x6ECCFC0", VA = "0x186ECDDC0")]
		public Uri(Uri HEEAGBHJANP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDCF0", Offset = "0x6ECCEF0", VA = "0x186ECDCF0")]
		public Uri(params Route[] LAEOBNIKFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDEC0", Offset = "0x6ECD0C0", VA = "0x186ECDEC0")]
		public Uri(IEnumerable<Route> LAEOBNIKFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD1E0", Offset = "0x6ECC3E0", VA = "0x186ECD1E0")]
		public bool NOBHIKHJOLD(Route LAEOBNIKFGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD620", Offset = "0x6ECC820", VA = "0x186ECD620")]
		public bool NOBHIKHJOLD(IEnumerable<Route> IBCGBIOHONK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD240", Offset = "0x6ECC440", VA = "0x186ECD240")]
		public bool NOBHIKHJOLD(Uri JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC840", Offset = "0x6ECBA40", VA = "0x186ECC840")]
		public static bool AIIPHFCAOIP(Uri HEEAGBHJANP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCAB0", Offset = "0x6ECBCB0", VA = "0x186ECCAB0")]
		public static bool GJNFKNOLOFN(Uri GGFLAOCNMAP, Uri PIINDHALINJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCF60", Offset = "0x6ECC160", VA = "0x186ECCF60")]
		public bool GJNFKNOLOFN(Uri JMNBIHILIIC, bool MMKGMADJMFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC910", Offset = "0x6ECBB10", VA = "0x186ECC910", Slot = "4")]
		public bool Equals(Uri JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCDA0", Offset = "0x6ECBFA0", VA = "0x186ECCDA0")]
		public static bool GJNFKNOLOFN(Uri HEEAGBHJANP, Route LAEOBNIKFGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC8A0", Offset = "0x6ECBAA0", VA = "0x186ECC8A0", Slot = "5")]
		public bool Equals(Route LAEOBNIKFGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC9A0", Offset = "0x6ECBBA0", VA = "0x186ECC9A0", Slot = "0")]
		public override bool Equals(object PPNJOAJJOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD060", Offset = "0x6ECC260", VA = "0x186ECD060", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD6D0", Offset = "0x6ECC8D0", VA = "0x186ECD6D0")]
		public string OMGGDJBJIOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD770", Offset = "0x6ECC970", VA = "0x186ECD770", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E2110", Offset = "0x7E1310", VA = "0x1807E2110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x30D99C0", Offset = "0x30D8BC0", VA = "0x1830D99C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB880", Offset = "0x6ECAA80", VA = "0x186ECB880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB740", Offset = "0x6ECA940", VA = "0x186ECB740", Slot = "4")]
		public bool Equals(Route JMNBIHILIIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB810", Offset = "0x6ECAA10", VA = "0x186ECB810", Slot = "5")]
		public bool Equals(Uri HEEAGBHJANP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB6E0", Offset = "0x6ECA8E0", VA = "0x186ECB6E0")]
		public AssetReference CLDCGJPHLKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6ECB950", Offset = "0x6ECAB50", VA = "0x186ECB950")]
		public Route()
		{
		}
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
