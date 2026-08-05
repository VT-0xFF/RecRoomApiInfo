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
		[CGLCMPPNAMG(PCMMCGDMCAJ.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[CGLCMPPNAMG(PCMMCGDMCAJ.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject BCNNGEDILJG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas BLPODACMJLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject CEFEPJNKOGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x65EB800", Offset = "0x65EA600", VA = "0x1865EB800")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route DKEIALANAGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x65EB8E0", Offset = "0x65EA6E0", VA = "0x1865EB8E0")]
		public void Initialize(GameObject GLHAAIAEFEG, Transform AABHIBJPKOH, Route HAOLDJDDHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65EBB40", Offset = "0x65EA940", VA = "0x1865EBB40")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x65EB8D0", Offset = "0x65EA6D0", VA = "0x1865EB8D0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x65EBA10", Offset = "0x65EA810", VA = "0x1865EBA10")]
		private void POGNGBLBHJE(bool AGJCAJNDMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OJLFIPPEOAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper NFEFFPGHHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<ELNDANIEPDH> CFPOBOILCDB;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x87BC00", Offset = "0x87AA00", VA = "0x18087BC00")]
	public OJLFIPPEOAM(PageWrapper GAPALIBCMEE, IReadOnlyList<ELNDANIEPDH> JDMDONJEBPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ELNDANIEPDH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject MOOKKKOOHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LMAPELGHNPL OnBeforePageSwapFrom(Uri MLEAJGFCDIB, LDHGAPPHLJK DNOEJKEOKKF, OJLFIPPEOAM BJFJGEPJEEB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LMAPELGHNPL OnBeforePageSwapTo(Uri MLEAJGFCDIB, LDHGAPPHLJK DNOEJKEOKKF, OJLFIPPEOAM HNFMLMCAGEB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LMAPELGHNPL OnAfterPageSwapTo(Uri MLEAJGFCDIB, LDHGAPPHLJK DNOEJKEOKKF, OJLFIPPEOAM BCDPLCGJFFP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LMAPELGHNPL OnShow(LDHGAPPHLJK DNOEJKEOKKF, OJLFIPPEOAM LGHBBCNFMEA, OJLFIPPEOAM HNAHKBBGEFD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LMAPELGHNPL OnHide(LDHGAPPHLJK DNOEJKEOKKF, OJLFIPPEOAM LGHBBCNFMEA, OJLFIPPEOAM HNAHKBBGEFD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LDHGAPPHLJK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static LDHGAPPHLJK LKPPHHDONBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x65EB4B0", Offset = "0x65EA2B0", VA = "0x1865EB4B0")]
		[CompilerGenerated]
		get
		{
			return default(LDHGAPPHLJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AOIIKALEEBO PPIOIEGLBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(AOIIKALEEBO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x73D530", Offset = "0x73C330", VA = "0x18073D530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FGLNGJHKMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x899790", Offset = "0x898590", VA = "0x180899790")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x899B50", Offset = "0x898950", VA = "0x180899B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri PFENHKBCDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E50", Offset = "0x6F6C50", VA = "0x1806F7E50")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F20", Offset = "0x6F6D20", VA = "0x1806F7F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri GEFGDIAIJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x65EB520", Offset = "0x65EA320", VA = "0x1865EB520")]
	public LDHGAPPHLJK(Uri LENNEOLDLKG, Uri GPHGOPNGAGE, AOIIKALEEBO HEDIKFOBFMC = AOIIKALEEBO.None, bool BJCMHIGPNPK = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum AOIIKALEEBO
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CLKAKCBNECO
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
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8200E0", Offset = "0x81EEE0", VA = "0x1808200E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65EBD20", Offset = "0x65EAB20", VA = "0x1865EBD20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65EBBE0", Offset = "0x65EA9E0", VA = "0x1865EBBE0", Slot = "4")]
		public bool Equals(Route ONICAEEHHFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x65EBCB0", Offset = "0x65EAAB0", VA = "0x1865EBCB0", Slot = "5")]
		public bool Equals(Uri MLEAJGFCDIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x65EBB80", Offset = "0x65EA980", VA = "0x1865EBB80")]
		public AssetReference BMDIDNCMHCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x65EBDF0", Offset = "0x65EABF0", VA = "0x1865EBDF0")]
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
					[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
			[LPFBBHCHMLO("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x65EE440", Offset = "0x65ED240", VA = "0x1865EE440")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EKIIGBKNCKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public EKIIGBKNCKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x65EAD90", Offset = "0x65E9B90", VA = "0x1865EAD90")]
			internal bool <ContainsUri>b__0(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NFJOMJOCFFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public NFJOMJOCFFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x65EB570", Offset = "0x65EA370", VA = "0x1865EB570")]
			internal bool <ContainsUri>b__1(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BGEDBEJBGHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public MGFDLFIFDLL statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public BGEDBEJBGHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x65EAC60", Offset = "0x65E9A60", VA = "0x1865EAC60")]
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
			[Cpp2IlInjected.Address(RVA = "0x65ECB60", Offset = "0x65EB960", VA = "0x1865ECB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x65ECAB0", Offset = "0x65EB8B0", VA = "0x1865ECAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x65EC4F0", Offset = "0x65EB2F0", VA = "0x1865EC4F0")]
		private static void GIHONBOCKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x65EC850", Offset = "0x65EB650", VA = "0x1865EC850")]
		public bool HEKJAHDJGFD(Uri MLEAJGFCDIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x65EC130", Offset = "0x65EAF30", VA = "0x1865EC130")]
		public static bool CNBOMFLCPMA(Route HAOLDJDDHNP, out RoutesConfig DMDOELJNKDK, out View OCPKJDMAKCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x65EBE20", Offset = "0x65EAC20", VA = "0x1865EBE20")]
		public static AssetReference BMDIDNCMHCB(Route HAOLDJDDHNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x65ECA30", Offset = "0x65EB830", VA = "0x1865ECA30")]
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
		private sealed class PGPKECCOGPP
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
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public PGPKECCOGPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x65EB5B0", Offset = "0x65EA3B0", VA = "0x1865EB5B0")]
			internal bool <Equals>b__0(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x65EB700", Offset = "0x65EA500", VA = "0x1865EB700")]
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
			[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x65EE3C0", Offset = "0x65ED1C0", VA = "0x1865EE3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x65EE210", Offset = "0x65ED010", VA = "0x1865EE210")]
		public Uri(Uri MLEAJGFCDIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x65EE160", Offset = "0x65ECF60", VA = "0x1865EE160")]
		public Uri(params Route[] HAOLDJDDHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x65EE2F0", Offset = "0x65ED0F0", VA = "0x1865EE2F0")]
		public Uri(IEnumerable<Route> HAOLDJDDHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x65EDAD0", Offset = "0x65EC8D0", VA = "0x1865EDAD0")]
		public bool PGDHOKOGAJF(Route HAOLDJDDHNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x65EDB30", Offset = "0x65EC930", VA = "0x1865EDB30")]
		public bool PGDHOKOGAJF(IEnumerable<Route> MCHLPFOGAJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x65ED710", Offset = "0x65EC510", VA = "0x1865ED710")]
		public bool PGDHOKOGAJF(Uri ONICAEEHHFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x65ED6B0", Offset = "0x65EC4B0", VA = "0x1865ED6B0")]
		public static bool NNIBKOJBFNK(Uri MLEAJGFCDIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x65ED080", Offset = "0x65EBE80", VA = "0x1865ED080")]
		public static bool MIHMMJHONAF(Uri FEIPFLDEPBD, Uri MIECAKFJHNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x65ED510", Offset = "0x65EC310", VA = "0x1865ED510")]
		public bool MIHMMJHONAF(Uri ONICAEEHHFG, bool LNDDKMOHCOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x65ECD40", Offset = "0x65EBB40", VA = "0x1865ECD40", Slot = "4")]
		public bool Equals(Uri ONICAEEHHFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x65ED370", Offset = "0x65EC170", VA = "0x1865ED370")]
		public static bool MIHMMJHONAF(Uri MLEAJGFCDIB, Route HAOLDJDDHNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x65ECCD0", Offset = "0x65EBAD0", VA = "0x1865ECCD0", Slot = "5")]
		public bool Equals(Route HAOLDJDDHNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x65ECDD0", Offset = "0x65EBBD0", VA = "0x1865ECDD0", Slot = "0")]
		public override bool Equals(object BLIKPCIFNNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x65ECEE0", Offset = "0x65EBCE0", VA = "0x1865ECEE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x65ED610", Offset = "0x65EC410", VA = "0x1865ED610")]
		public string NGMIHCJGLOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x65EDBE0", Offset = "0x65EC9E0", VA = "0x1865EDBE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x65EAE80", Offset = "0x65E9C80", VA = "0x1865EAE80")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x65EAF90", Offset = "0x65E9D90", VA = "0x1865EAF90")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
