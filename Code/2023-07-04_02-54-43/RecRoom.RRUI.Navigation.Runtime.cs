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
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject LMKKAHBIBLI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas MBBOGHPJKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject IOJEGJMLOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x71B8930", Offset = "0x71B6F30", VA = "0x1871B8930")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route MEFPIJJPIME
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA3CD70", Offset = "0xA3B370", VA = "0x180A3CD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71B8800", Offset = "0x71B6E00", VA = "0x1871B8800")]
		public void Initialize(GameObject FIFEMEJBAEP, Transform KHJHJOOPMKP, Route DGDFGPMIPMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71B8A00", Offset = "0x71B7000", VA = "0x1871B8A00")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71B87F0", Offset = "0x71B6DF0", VA = "0x1871B87F0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71B86C0", Offset = "0x71B6CC0", VA = "0x1871B86C0")]
		private void BCLFJPDBECG(bool IHNIEFOJNHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
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
					[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x600001A")]
					[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
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
			[KNBJMKOPPHH("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x6000016")]
				[Cpp2IlInjected.Address(RVA = "0x86F2A0", Offset = "0x86D8A0", VA = "0x18086F2A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x86F230", Offset = "0x86D830", VA = "0x18086F230")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x71BB390", Offset = "0x71B9990", VA = "0x1871BB390")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class CGBCDNINEAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public CGBCDNINEAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x71B8140", Offset = "0x71B6740", VA = "0x1871B8140")]
			internal bool LCPEIIBFHMC(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class AGGNONEPHLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public AGGNONEPHLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x71B8100", Offset = "0x71B6700", VA = "0x1871B8100")]
			internal bool HAEACLENBMK(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FPIFLFEKMHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public KADEJCMCOAK statsig;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public FPIFLFEKMHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x71B8230", Offset = "0x71B6830", VA = "0x1871B8230")]
			internal bool KDACEBOAKOK(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x71B9A30", Offset = "0x71B8030", VA = "0x1871B9A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x71B9980", Offset = "0x71B7F80", VA = "0x1871B9980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71B94C0", Offset = "0x71B7AC0", VA = "0x1871B94C0")]
		private static void KGHKJOCLFMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71B93C0", Offset = "0x71B79C0", VA = "0x1871B93C0")]
		public bool HMKNLOPIMGI(Uri POEBKJDGCIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71B8FF0", Offset = "0x71B75F0", VA = "0x1871B8FF0")]
		public static bool FEPMMFBEBFA(Route DGDFGPMIPMK, out RoutesConfig ALCFNBDJMOH, out View CLFNEDLOJDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71B8CE0", Offset = "0x71B72E0", VA = "0x1871B8CE0")]
		public static AssetReference EILMAOKOEFK(Route DGDFGPMIPMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71B9900", Offset = "0x71B7F00", VA = "0x1871B9900")]
		public RoutesConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IKHBFLMGCPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly PageWrapper KEEKGMLLPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IReadOnlyList<CKBEGKAHMDM> CNNCCGLOFHM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x953E90", Offset = "0x952490", VA = "0x180953E90")]
	public IKHBFLMGCPA(PageWrapper KDDCJMKPHOF, IReadOnlyList<CKBEGKAHMDM> DFNAIEJJJCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CKBEGKAHMDM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GameObject GLLEEPIMCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ADCACBFKFKM OnBeforePageSwapFrom(Uri POEBKJDGCIP, LKFMLPEBONA IKGDLDLKENE, IKHBFLMGCPA LPGEHCFHJCI);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ADCACBFKFKM OnBeforePageSwapTo(Uri POEBKJDGCIP, LKFMLPEBONA IKGDLDLKENE, IKHBFLMGCPA HLIBPLNNGOH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ADCACBFKFKM OnAfterPageSwapTo(Uri POEBKJDGCIP, LKFMLPEBONA IKGDLDLKENE, IKHBFLMGCPA MOPDJDONGBN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ADCACBFKFKM OnShow(LKFMLPEBONA IKGDLDLKENE, IKHBFLMGCPA OKGKPEAJJFB, IKHBFLMGCPA JIEEKOHFMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ADCACBFKFKM OnHide(LKFMLPEBONA IKGDLDLKENE, IKHBFLMGCPA OKGKPEAJJFB, IKHBFLMGCPA JIEEKOHFMMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LKFMLPEBONA
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static LKFMLPEBONA EDEKLFBDJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71B8360", Offset = "0x71B6960", VA = "0x1871B8360")]
		[CompilerGenerated]
		get
		{
			return default(LKFMLPEBONA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NOOJJKPDMJK OPOPFKPNDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC2E540", Offset = "0xC2CB40", VA = "0x180C2E540")]
		[CompilerGenerated]
		readonly get
		{
			return default(NOOJJKPDMJK);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA47570", Offset = "0xA45B70", VA = "0x180A47570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool KPAGONJDOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x15C4FE0", Offset = "0x15C35E0", VA = "0x1815C4FE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x38AE7E0", Offset = "0x38ACDE0", VA = "0x1838AE7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Uri IAOKBEAIOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9BE150", Offset = "0x9BC750", VA = "0x1809BE150")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA7EC40", Offset = "0xA7D240", VA = "0x180A7EC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Uri CHCNBLDOHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x943F50", Offset = "0x942550", VA = "0x180943F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71B8410", Offset = "0x71B6A10", VA = "0x1871B8410")]
	public LKFMLPEBONA(Uri DLCELGCGMOB, Uri GJDKIOIIKEM, NOOJJKPDMJK LJHOBHGNEAM = NOOJJKPDMJK.None, bool NOPCOOEMMPP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum NOOJJKPDMJK
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum LHBMDDEJLHL
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
		private sealed class OEEHJLEGPHK
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
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public OEEHJLEGPHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x71B8560", Offset = "0x71B6B60", VA = "0x1871B8560")]
			internal bool LGBHHBFNFOM(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x71B8460", Offset = "0x71B6A60", VA = "0x1871B8460")]
			internal bool GPNOENPMADK(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x71BB310", Offset = "0x71B9910", VA = "0x1871BB310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x71BB120", Offset = "0x71B9720", VA = "0x1871BB120")]
		public Uri(Uri POEBKJDGCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x71BB050", Offset = "0x71B9650", VA = "0x1871BB050")]
		public Uri(params Route[] DGDFGPMIPMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x71BB220", Offset = "0x71B9820", VA = "0x1871BB220")]
		public Uri(IEnumerable<Route> DGDFGPMIPMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x71BA8F0", Offset = "0x71B8EF0", VA = "0x1871BA8F0")]
		public bool GGHKDEOPGPN(Route DGDFGPMIPMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x71BA840", Offset = "0x71B8E40", VA = "0x1871BA840")]
		public bool GGHKDEOPGPN(IEnumerable<Route> AIFOJFECEBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x71BA460", Offset = "0x71B8A60", VA = "0x1871BA460")]
		public bool GGHKDEOPGPN(Uri EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x71B9C40", Offset = "0x71B8240", VA = "0x1871B9C40")]
		public static bool DDCPNIBOGHA(Uri POEBKJDGCIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71BA170", Offset = "0x71B8770", VA = "0x1871BA170")]
		public static bool FCJJJAFBLNE(Uri LLAFGJINMOA, Uri LKIHFBEPDMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x71BA070", Offset = "0x71B8670", VA = "0x1871BA070")]
		public bool FCJJJAFBLNE(Uri EJECOGCICOM, bool MNODBAPFPPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x71B9D10", Offset = "0x71B8310", VA = "0x1871B9D10", Slot = "4")]
		public bool Equals(Uri EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71B9EB0", Offset = "0x71B84B0", VA = "0x1871B9EB0")]
		public static bool FCJJJAFBLNE(Uri POEBKJDGCIP, Route DGDFGPMIPMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71B9CA0", Offset = "0x71B82A0", VA = "0x1871B9CA0", Slot = "5")]
		public bool Equals(Route DGDFGPMIPMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71B9DA0", Offset = "0x71B83A0", VA = "0x1871B9DA0", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x71BA950", Offset = "0x71B8F50", VA = "0x1871BA950", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x71B9BA0", Offset = "0x71B81A0", VA = "0x1871B9BA0")]
		public string BIABJMLJCAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71BAAD0", Offset = "0x71B90D0", VA = "0x1871BAAD0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x86D400", Offset = "0x86BA00", VA = "0x18086D400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2623050", Offset = "0x2621650", VA = "0x182623050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x71B8BE0", Offset = "0x71B71E0", VA = "0x1871B8BE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x71B8AA0", Offset = "0x71B70A0", VA = "0x1871B8AA0", Slot = "4")]
		public bool Equals(Route EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71B8B70", Offset = "0x71B7170", VA = "0x1871B8B70", Slot = "5")]
		public bool Equals(Uri POEBKJDGCIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71B8A40", Offset = "0x71B7040", VA = "0x1871B8A40")]
		public AssetReference EILMAOKOEFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71B8CB0", Offset = "0x71B72B0", VA = "0x1871B8CB0")]
		public Route()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
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
