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
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject JHBMFMEOOAH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas BHFEOPLJMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject JKNLOPGLHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x75BB770", Offset = "0x75BA370", VA = "0x1875BB770")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route NKKOAJLKCEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75BB850", Offset = "0x75BA450", VA = "0x1875BB850")]
		public void Initialize(GameObject ALEGECJMLHO, Transform CDBGCEIGNJC, Route PPFGDPBJMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75BBA90", Offset = "0x75BA690", VA = "0x1875BBA90")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75BB840", Offset = "0x75BA440", VA = "0x1875BB840")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x75BB980", Offset = "0x75BA580", VA = "0x1875BB980")]
		private void NEHHIDGOGDE(bool KADHLHDKJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HJCMCJDHFBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper FCHDNBODJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<KBKEDJJCPEI> MGCOPIOMGHH;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x887A10", Offset = "0x886610", VA = "0x180887A10")]
	public HJCMCJDHFBB(PageWrapper FNMNNIIBKAH, IReadOnlyList<KBKEDJJCPEI> EOIJLOGAFDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KBKEDJJCPEI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject MNEKHEHNFLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DMMKPEDFDBF OnBeforePageSwapFrom(Uri GIPAACKAAKI, DHENCECKGJE ODPJPJLEOIN, HJCMCJDHFBB OHLBNNJKJND);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DMMKPEDFDBF OnBeforePageSwapTo(Uri GIPAACKAAKI, DHENCECKGJE ODPJPJLEOIN, HJCMCJDHFBB PBFACJBLLBC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DMMKPEDFDBF OnAfterPageSwapTo(Uri GIPAACKAAKI, DHENCECKGJE ODPJPJLEOIN, HJCMCJDHFBB DBHNPHFJKNO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DMMKPEDFDBF OnShow(DHENCECKGJE ODPJPJLEOIN, HJCMCJDHFBB DNMNKLPPCJN, HJCMCJDHFBB PFLLADCFCPL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DMMKPEDFDBF OnHide(DHENCECKGJE ODPJPJLEOIN, HJCMCJDHFBB DNMNKLPPCJN, HJCMCJDHFBB PFLLADCFCPL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DHENCECKGJE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static DHENCECKGJE GHFEJGGLAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75BB3B0", Offset = "0x75B9FB0", VA = "0x1875BB3B0")]
		[CompilerGenerated]
		get
		{
			return default(DHENCECKGJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KEDFJBEBHML BOLLOAOMIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980")]
		[CompilerGenerated]
		readonly get
		{
			return default(KEDFJBEBHML);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NLMBMMJGKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB227F0", Offset = "0xB213F0", VA = "0x180B227F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xB22820", Offset = "0xB21420", VA = "0x180B22820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri JBPCAPGOGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC329B0", Offset = "0xC315B0", VA = "0x180C329B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri OHLEJHOJDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75BB400", Offset = "0x75BA000", VA = "0x1875BB400")]
	public DHENCECKGJE(Uri JDPDDIKNPCN, Uri NEJEEJIENDA, KEDFJBEBHML FBBHAKAEAGL = KEDFJBEBHML.None, bool PPJGJNEIFBA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KEDFJBEBHML
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum ELOIOCDAJIP
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
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x218AF20", Offset = "0x2189B20", VA = "0x18218AF20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75BBC90", Offset = "0x75BA890", VA = "0x1875BBC90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75BBBA0", Offset = "0x75BA7A0", VA = "0x1875BBBA0")]
		public string GMGBLCAADCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x75BBAD0", Offset = "0x75BA6D0", VA = "0x1875BBAD0", Slot = "4")]
		public bool Equals(Route FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x75BBB40", Offset = "0x75BA740", VA = "0x1875BBB40", Slot = "5")]
		public bool Equals(Uri GIPAACKAAKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75BBC40", Offset = "0x75BA840", VA = "0x1875BBC40")]
		public AssetReference IMLLOCCDHBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x75BBD50", Offset = "0x75BA950", VA = "0x1875BBD50")]
		public Route()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CreateAssetMenu(fileName = "RoutesConfig", menuName = "RecRoom/UI/Routes Config", order = 1)]
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
					[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
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
			[LNIAJCDMOMF("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x75BE430", Offset = "0x75BD030", VA = "0x1875BE430")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KHJEAENIHLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public KHJEAENIHLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x75BB690", Offset = "0x75BA290", VA = "0x1875BB690")]
			internal bool PDBDPBLFHMF(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EGAHMCKHCBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public EGAHMCKHCBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x75BB450", Offset = "0x75BA050", VA = "0x1875BB450")]
			internal bool JDNDADMLCMB(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BIEOAPENPBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public OAJBCHCNOFD statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public BIEOAPENPBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x75BB0E0", Offset = "0x75B9CE0", VA = "0x1875BB0E0")]
			internal bool DHFBHMKBCDC(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x75BCAD0", Offset = "0x75BB6D0", VA = "0x1875BCAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x75BCA40", Offset = "0x75BB640", VA = "0x1875BCA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x75BC4E0", Offset = "0x75BB0E0", VA = "0x1875BC4E0")]
		private static void KMAKNPIEEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75BC0F0", Offset = "0x75BACF0", VA = "0x1875BC0F0")]
		public bool FDPDCCNIDMD(Uri GIPAACKAAKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75BBD80", Offset = "0x75BA980", VA = "0x1875BBD80")]
		public static bool AEGJBDHCDKA(Route PPFGDPBJMOL, [Out] RoutesConfig EEHMCGCANCG, [Out] View CMBKOODCEHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75BC1F0", Offset = "0x75BADF0", VA = "0x1875BC1F0")]
		public static AssetReference IMLLOCCDHBA(Route PPFGDPBJMOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75BC9B0", Offset = "0x75BB5B0", VA = "0x1875BC9B0")]
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
		private sealed class IEDCNDAHKAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public IReadOnlyList<Route> bRoute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Uri b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Uri a;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public IEDCNDAHKAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x75BB590", Offset = "0x75BA190", VA = "0x1875BB590")]
			internal bool LBDIGHNMHNO(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x75BB490", Offset = "0x75BA090", VA = "0x1875BB490")]
			internal bool FBJIHEBAEDN(string k)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly string nullRouteString;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static bool CacheRouteStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private List<Route> route;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Dictionary<string, object> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string cachedRouteString;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x75BE3A0", Offset = "0x75BCFA0", VA = "0x1875BE3A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x75BE1D0", Offset = "0x75BCDD0", VA = "0x1875BE1D0")]
		public Uri(Uri GIPAACKAAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x75BE110", Offset = "0x75BCD10", VA = "0x1875BE110")]
		public Uri(params Route[] PPFGDPBJMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x75BE2C0", Offset = "0x75BCEC0", VA = "0x1875BE2C0")]
		public Uri(IEnumerable<Route> PPFGDPBJMOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75BD940", Offset = "0x75BC540", VA = "0x1875BD940")]
		public bool IFELPNGNEIG(Route PPFGDPBJMOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x75BD9A0", Offset = "0x75BC5A0", VA = "0x1875BD9A0")]
		public bool IFELPNGNEIG(IEnumerable<Route> LJKNEHKJHIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x75BD5E0", Offset = "0x75BC1E0", VA = "0x1875BD5E0")]
		public bool IFELPNGNEIG(Uri FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x75BDB50", Offset = "0x75BC750", VA = "0x1875BDB50")]
		public static bool PEBIHPCGOKK(Uri GIPAACKAAKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x75BD310", Offset = "0x75BBF10", VA = "0x1875BD310")]
		public static bool HELLGNHACPM(Uri ALHLFNOAFIL, Uri AFHCIMLJCHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x75BD220", Offset = "0x75BBE20", VA = "0x1875BD220")]
		public bool HELLGNHACPM(Uri FDOEIPBMJJM, bool KDJBNHLJICC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75BCDD0", Offset = "0x75BB9D0", VA = "0x1875BCDD0", Slot = "4")]
		public bool Equals(Uri FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x75BD080", Offset = "0x75BBC80", VA = "0x1875BD080")]
		public static bool HELLGNHACPM(Uri GIPAACKAAKI, Route PPFGDPBJMOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75BCD70", Offset = "0x75BB970", VA = "0x1875BCD70", Slot = "5")]
		public bool Equals(Route PPFGDPBJMOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x75BCC30", Offset = "0x75BB830", VA = "0x1875BCC30", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x75BCE50", Offset = "0x75BBA50", VA = "0x1875BCE50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x75BDA40", Offset = "0x75BC640", VA = "0x1875BDA40")]
		public string OMDMOODGGAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x75BDBB0", Offset = "0x75BC7B0", VA = "0x1875BDBB0", Slot = "3")]
		public override string ToString()
		{
			return null;
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
