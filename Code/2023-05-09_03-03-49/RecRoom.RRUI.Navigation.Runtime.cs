using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
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
		[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject OPMJGFPBPKD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas CCFEKIAAFFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject MBCFKFJBCKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x1DF4A20", Offset = "0x1DF3420", VA = "0x181DF4A20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route DDJJJDEMGDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DF48F0", Offset = "0x1DF32F0", VA = "0x181DF48F0")]
		public void Initialize(GameObject NGIACIADGLM, Transform EOBFGLJBCIJ, Route CAGAOJHEEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4AF0", Offset = "0x1DF34F0", VA = "0x181DF4AF0")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DF48E0", Offset = "0x1DF32E0", VA = "0x181DF48E0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DF47B0", Offset = "0x1DF31B0", VA = "0x181DF47B0")]
		private void GDJBLFBMFFC(bool KIFCOCJGKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MBAGALPHCHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper CGGEBKLGMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<CODCKFGHODM> DIJHAOCKLAH;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84CDF0", Offset = "0x84B7F0", VA = "0x18084CDF0")]
	public MBAGALPHCHM(PageWrapper IIBMDIOLKPI, IReadOnlyList<CODCKFGHODM> GFDOEACBJJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CODCKFGHODM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject KLFJADJOODK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OFEHPCFKLFI OnBeforePageSwapFrom(Uri LGNGJCFNHCK, BGBGBOKCINN ILBCDAEEOIE, MBAGALPHCHM GLCJPHJGOIP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OFEHPCFKLFI OnBeforePageSwapTo(Uri LGNGJCFNHCK, BGBGBOKCINN ILBCDAEEOIE, MBAGALPHCHM GNFJBBNIAIH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OFEHPCFKLFI OnAfterPageSwapTo(Uri LGNGJCFNHCK, BGBGBOKCINN ILBCDAEEOIE, MBAGALPHCHM MHFOLACKBCG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OFEHPCFKLFI OnShow(BGBGBOKCINN ILBCDAEEOIE, MBAGALPHCHM NLMCICKOILG, MBAGALPHCHM ICHPAMEMKEA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OFEHPCFKLFI OnHide(BGBGBOKCINN ILBCDAEEOIE, MBAGALPHCHM NLMCICKOILG, MBAGALPHCHM ICHPAMEMKEA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BGBGBOKCINN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static BGBGBOKCINN NHIBPFHOELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1DF3C10", Offset = "0x1DF2610", VA = "0x181DF3C10")]
		[CompilerGenerated]
		get
		{
			return default(BGBGBOKCINN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KNNNMLPDNIJ DOAKNHCNFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x863B20", VA = "0x180865120")]
		[CompilerGenerated]
		readonly get
		{
			return default(KNNNMLPDNIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8650A0", Offset = "0x863AA0", VA = "0x1808650A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool OIBEPCGMCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8552C0", Offset = "0x853CC0", VA = "0x1808552C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8552D0", Offset = "0x853CD0", VA = "0x1808552D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri MHCFJEBPKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x875BC0", Offset = "0x8745C0", VA = "0x180875BC0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x875C80", Offset = "0x874680", VA = "0x180875C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri KCPKFLFPEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3C80", Offset = "0x1DF2680", VA = "0x181DF3C80")]
	public BGBGBOKCINN(Uri GBBFEIKPLND, Uri AJLOEDEAPIA, KNNNMLPDNIJ GOGCBKDCHEG = KNNNMLPDNIJ.None, bool JCKPKLJOHAD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KNNNMLPDNIJ
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum ICKIOOJHMBH
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Pending
}
namespace RRUI.Navigation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class Route : IEquatable<Route>, IEquatable<Uri>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private SerializedGuid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public SerializedGuid ViewGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B3160", Offset = "0x9B1B60", VA = "0x1809B3160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4CD0", Offset = "0x1DF36D0", VA = "0x181DF4CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4B30", Offset = "0x1DF3530", VA = "0x181DF4B30", Slot = "4")]
		public bool Equals(Route EHBPAFKHADK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4C00", Offset = "0x1DF3600", VA = "0x181DF4C00", Slot = "5")]
		public bool Equals(Uri LGNGJCFNHCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4C70", Offset = "0x1DF3670", VA = "0x181DF4C70")]
		public AssetReference PJEHMMAKLMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4DA0", Offset = "0x1DF37A0", VA = "0x181DF4DA0")]
		public Route()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CreateAssetMenu]
	public class RoutesConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public class View
		{
			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public class StatsigVariant
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				[SerializeField]
				private SerializedStatsigExperimentSegment statsigSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public SerializedStatsigExperimentSegment StatsigSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000032")]
					[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
				public StatsigVariant()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[SerializeField]
			private SerializedGuid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[SerializeField]
			private string friendlyName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			[SerializeField]
			private AssetReference prefabReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[SerializeField]
			[MBKHFNCMCIL("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1DF73F0", Offset = "0x1DF5DF0", VA = "0x181DF73F0")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FLHOMMHKLEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public FLHOMMHKLEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1DF4050", Offset = "0x1DF2A50", VA = "0x181DF4050")]
			internal bool <ContainsUri>b__0(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IGOKIFKNCPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public IGOKIFKNCPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DF4140", Offset = "0x1DF2B40", VA = "0x181DF4140")]
			internal bool <ContainsUri>b__1(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CNCNNKMLLIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public KENIFKIDOIC statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public CNCNNKMLLIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1DF3CD0", Offset = "0x1DF26D0", VA = "0x181DF3CD0")]
			internal bool <GetPrefabReference>b__0(View.StatsigVariant variant)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly string ResourcesRoutesDirectoryPath;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly string FullRoutesDirectoryPath;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static List<RoutesConfig> _configs;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static Dictionary<Guid, View> _viewMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private List<View> views;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool _isInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1DF5B10", Offset = "0x1DF4510", VA = "0x181DF5B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1DF5A60", Offset = "0x1DF4460", VA = "0x181DF5A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1DF5290", Offset = "0x1DF3C90", VA = "0x181DF5290")]
		private static void NCBKDFJCMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1DF5190", Offset = "0x1DF3B90", VA = "0x181DF5190")]
		public bool JJIIAMOGBLF(Uri LGNGJCFNHCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4DD0", Offset = "0x1DF37D0", VA = "0x181DF4DD0")]
		public static bool BKIAOMCPNPK(Route CAGAOJHEEIC, out RoutesConfig CFCJBNLABBE, out View KALODFANNLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF55F0", Offset = "0x1DF3FF0", VA = "0x181DF55F0")]
		public static AssetReference PJEHMMAKLMA(Route CAGAOJHEEIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1DF59E0", Offset = "0x1DF43E0", VA = "0x181DF59E0")]
		public RoutesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class Uri : IEquatable<Uri>, IEquatable<Route>
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class DBEOOHPKADD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public IReadOnlyList<Route> bRoute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public Uri b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Uri a;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public DBEOOHPKADD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1DF3E00", Offset = "0x1DF2800", VA = "0x181DF3E00")]
			internal bool <Equals>b__0(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1DF3F50", Offset = "0x1DF2950", VA = "0x181DF3F50")]
			internal bool <Equals>b__1(string k)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly string nullRouteString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private List<Route> route;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private Dictionary<string, object> data;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1DF7370", Offset = "0x1DF5D70", VA = "0x181DF7370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1DF71C0", Offset = "0x1DF5BC0", VA = "0x181DF71C0")]
		public Uri(Uri LGNGJCFNHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7110", Offset = "0x1DF5B10", VA = "0x181DF7110")]
		public Uri(params Route[] CAGAOJHEEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF72A0", Offset = "0x1DF5CA0", VA = "0x181DF72A0")]
		public Uri(IEnumerable<Route> CAGAOJHEEIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6040", Offset = "0x1DF4A40", VA = "0x181DF6040")]
		public bool AAFBPIPDPOL(Route CAGAOJHEEIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DF60A0", Offset = "0x1DF4AA0", VA = "0x181DF60A0")]
		public bool AAFBPIPDPOL(IEnumerable<Route> KGHNCFEPMBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1DF5C80", Offset = "0x1DF4680", VA = "0x181DF5C80")]
		public bool AAFBPIPDPOL(Uri EHBPAFKHADK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6B30", Offset = "0x1DF5530", VA = "0x181DF6B30")]
		public static bool MPMONFPIFAG(Uri LGNGJCFNHCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6840", Offset = "0x1DF5240", VA = "0x181DF6840")]
		public static bool KHPOGCBLNFJ(Uri MGFKDMJBGAK, Uri LPDJCHOFJLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6740", Offset = "0x1DF5140", VA = "0x181DF6740")]
		public bool KHPOGCBLNFJ(Uri EHBPAFKHADK, bool DFJLOMOKODA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1DF61C0", Offset = "0x1DF4BC0", VA = "0x181DF61C0", Slot = "4")]
		public bool Equals(Uri EHBPAFKHADK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1DF65A0", Offset = "0x1DF4FA0", VA = "0x181DF65A0")]
		public static bool KHPOGCBLNFJ(Uri LGNGJCFNHCK, Route CAGAOJHEEIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6150", Offset = "0x1DF4B50", VA = "0x181DF6150", Slot = "5")]
		public bool Equals(Route CAGAOJHEEIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6250", Offset = "0x1DF4C50", VA = "0x181DF6250", Slot = "0")]
		public override bool Equals(object OMHIFHKMIMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6360", Offset = "0x1DF4D60", VA = "0x181DF6360", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6500", Offset = "0x1DF4F00", VA = "0x181DF6500")]
		public string IPLNDIALADF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF6B90", Offset = "0x1DF5590", VA = "0x181DF6B90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4180", Offset = "0x1DF2B80", VA = "0x181DF4180")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4290", Offset = "0x1DF2C90", VA = "0x181DF4290")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
