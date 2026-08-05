using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RRUI;
using RRUI.Navigation;
using RecRoom.Analytics.SplitTesting;
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
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject MJAEJEBJAMG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas CLKADHJMLGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject JLLECFKIFFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6432010", Offset = "0x6431210", VA = "0x186432010")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route IKDOKLALHMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64320E0", Offset = "0x64312E0", VA = "0x1864320E0")]
		public void Initialize(GameObject ODJFFDBDPNA, Transform GPFONCECPBK, Route BDDPBGGILLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6432210", Offset = "0x6431410", VA = "0x186432210")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6432000", Offset = "0x6431200", VA = "0x186432000")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6431ED0", Offset = "0x64310D0", VA = "0x186431ED0")]
		private void ALILMMLPKBF(bool GDEOBMEPMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OALJFAKJNGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper IAOGJEDDPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<JAIOHJJJNMP> PLAMPCELFPF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C76E0", Offset = "0x6C68E0", VA = "0x1806C76E0")]
	public OALJFAKJNGN(PageWrapper BLKCDAHGFAC, IReadOnlyList<JAIOHJJJNMP> BOKOEKMDGIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JAIOHJJJNMP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject MNGKPNJJMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PMOAFBNPLHC OnBeforePageSwapFrom(Uri ILELBCEHKHI, BKHDJJNNONC HHCANBNBHNP, OALJFAKJNGN LOHCCANLMPD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PMOAFBNPLHC OnBeforePageSwapTo(Uri ILELBCEHKHI, BKHDJJNNONC HHCANBNBHNP, OALJFAKJNGN JDAGLPABMEB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PMOAFBNPLHC OnAfterPageSwapTo(Uri ILELBCEHKHI, BKHDJJNNONC HHCANBNBHNP, OALJFAKJNGN GJPCKKODALM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PMOAFBNPLHC OnShow(BKHDJJNNONC HHCANBNBHNP, OALJFAKJNGN LBHAIOCMNEA, OALJFAKJNGN KJOBGIEHNAF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PMOAFBNPLHC OnHide(BKHDJJNNONC HHCANBNBHNP, OALJFAKJNGN LBHAIOCMNEA, OALJFAKJNGN KJOBGIEHNAF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BKHDJJNNONC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static BKHDJJNNONC HMBHBEDALCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6431460", Offset = "0x6430660", VA = "0x186431460")]
		[CompilerGenerated]
		get
		{
			return default(BKHDJJNNONC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ODBDPHLPOEE LBGAAGJFCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20")]
		[CompilerGenerated]
		readonly get
		{
			return default(ODBDPHLPOEE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x778D90", Offset = "0x777F90", VA = "0x180778D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool IDJCPEDLJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD51110", Offset = "0xD50310", VA = "0x180D51110")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x373A340", Offset = "0x3739540", VA = "0x18373A340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri KNKDJJNOKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71DB00", Offset = "0x71CD00", VA = "0x18071DB00")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xE99080", Offset = "0xE98280", VA = "0x180E99080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri PCMDGGBGBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6E7130", Offset = "0x6E6330", VA = "0x1806E7130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64314D0", Offset = "0x64306D0", VA = "0x1864314D0")]
	public BKHDJJNNONC(Uri FBJPDMBGJPP, Uri FFDBDFECHND, ODBDPHLPOEE OBMPDKLICHH = ODBDPHLPOEE.None, bool HKBMKMKACOA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum ODBDPHLPOEE
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BNHFJOKKJKN
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
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x913510", Offset = "0x912710", VA = "0x180913510", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x64323F0", Offset = "0x64315F0", VA = "0x1864323F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6432250", Offset = "0x6431450", VA = "0x186432250", Slot = "4")]
		public bool Equals(Route IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6432320", Offset = "0x6431520", VA = "0x186432320", Slot = "5")]
		public bool Equals(Uri ILELBCEHKHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6432390", Offset = "0x6431590", VA = "0x186432390")]
		public AssetReference KDKCHGPIMKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x64324C0", Offset = "0x64316C0", VA = "0x1864324C0")]
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
			public class SplitTestingVariant
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				[SerializeField]
				private SerializedSplitTestExperimentSegment splitTestingSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public SerializedSplitTestExperimentSegment SplitTestingSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
				public SplitTestingVariant()
				{
				}
			}

			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public class StatsigVariant
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				[SerializeField]
				private SerializedStatsigExperimentSegment statsigSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public SerializedStatsigExperimentSegment StatsigSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000036")]
					[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000037")]
					[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
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
			[NKNJAIMLBKK("SplitTestingSegment")]
			private SplitTestingVariant[] splitTestingVariants;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			[SerializeField]
			[NKNJAIMLBKK("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6C8120", Offset = "0x6C7320", VA = "0x1806C8120")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<SplitTestingVariant> SplitTestingVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x6E18E0", Offset = "0x6E0AE0", VA = "0x1806E18E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6434E60", Offset = "0x6434060", VA = "0x186434E60")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IDFGPJLHHNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public IDFGPJLHHNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6431DE0", Offset = "0x6430FE0", VA = "0x186431DE0")]
			internal bool <ContainsUri>b__0(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class EIMGINGCPJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public EIMGINGCPJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6431B50", Offset = "0x6430D50", VA = "0x186431B50")]
			internal bool <ContainsUri>b__1(Route route)
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
			[Cpp2IlInjected.Address(RVA = "0x6433310", Offset = "0x6432510", VA = "0x186433310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6433260", Offset = "0x6432460", VA = "0x186433260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x64328B0", Offset = "0x6431AB0", VA = "0x1864328B0")]
		private static void BNACPANAOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6433000", Offset = "0x6432200", VA = "0x186433000")]
		public bool LIBDDPINIFL(Uri ILELBCEHKHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x64324F0", Offset = "0x64316F0", VA = "0x1864324F0")]
		public static bool AHAHEGOJFLO(Route BDDPBGGILLJ, out RoutesConfig HMNDKCHBDID, out View PAHKHNHPCEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6432C10", Offset = "0x6431E10", VA = "0x186432C10")]
		public static AssetReference KDKCHGPIMKE(Route BDDPBGGILLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x64331E0", Offset = "0x64323E0", VA = "0x1864331E0")]
		public RoutesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class Uri : IEquatable<Uri>, IEquatable<Route>
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class GPNGNLJNJJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public IReadOnlyList<Route> bRoute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Uri b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Uri a;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public GPNGNLJNJJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6431B90", Offset = "0x6430D90", VA = "0x186431B90")]
			internal bool <Equals>b__0(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6431CE0", Offset = "0x6430EE0", VA = "0x186431CE0")]
			internal bool <Equals>b__1(string k)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly string nullRouteString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private List<Route> route;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> data;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6434DE0", Offset = "0x6433FE0", VA = "0x186434DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6434C30", Offset = "0x6433E30", VA = "0x186434C30")]
		public Uri(Uri ILELBCEHKHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6434B80", Offset = "0x6433D80", VA = "0x186434B80")]
		public Uri(params Route[] BDDPBGGILLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6434D10", Offset = "0x6433F10", VA = "0x186434D10")]
		public Uri(IEnumerable<Route> BDDPBGGILLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6433960", Offset = "0x6432B60", VA = "0x186433960")]
		public bool GPEECKGOEKF(Route BDDPBGGILLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x64339C0", Offset = "0x6432BC0", VA = "0x1864339C0")]
		public bool GPEECKGOEKF(IEnumerable<Route> ODGBNCHLDJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6433A70", Offset = "0x6432C70", VA = "0x186433A70")]
		public bool GPEECKGOEKF(Uri IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6434070", Offset = "0x6433270", VA = "0x186434070")]
		public static bool MHAKOGLEHCF(Uri FAMKPEGNHFC, Uri GPHMIGDKMEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6434500", Offset = "0x6433700", VA = "0x186434500")]
		public bool MHAKOGLEHCF(Uri IHIJPIJNLJM, bool AHHNIFKPGKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x64337C0", Offset = "0x64329C0", VA = "0x1864337C0", Slot = "4")]
		public bool Equals(Uri IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6434360", Offset = "0x6433560", VA = "0x186434360")]
		public static bool MHAKOGLEHCF(Uri ILELBCEHKHI, Route BDDPBGGILLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6433750", Offset = "0x6432950", VA = "0x186433750", Slot = "5")]
		public bool Equals(Route BDDPBGGILLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6433850", Offset = "0x6432A50", VA = "0x186433850", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6433E30", Offset = "0x6433030", VA = "0x186433E30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6433FD0", Offset = "0x64331D0", VA = "0x186433FD0")]
		public string MCHGAEFMFEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6434600", Offset = "0x6433800", VA = "0x186434600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6431520", Offset = "0x6430720", VA = "0x186431520")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6431630", Offset = "0x6430830", VA = "0x186431630")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
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
