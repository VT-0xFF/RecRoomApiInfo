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
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject PJEAAHLPMCA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas IIEHFFIFPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject AOFIDJLHCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x71434C0", Offset = "0x7141CC0", VA = "0x1871434C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route EKMKMFPLEFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7143390", Offset = "0x7141B90", VA = "0x187143390")]
		public void Initialize(GameObject IIGPFLCBIDC, Transform GGJNHHDMGON, Route MKBBGGFKGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7143590", Offset = "0x7141D90", VA = "0x187143590")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7143270", Offset = "0x7141A70", VA = "0x187143270")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7143280", Offset = "0x7141A80", VA = "0x187143280")]
		private void IKBKKLFBKFB(bool MPHCENDLGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ACLFJABALOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper EJMEMNELEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<OBLGPLHBPAG> KKECLNNJHFF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84B520", Offset = "0x849D20", VA = "0x18084B520")]
	public ACLFJABALOB(PageWrapper KBBNMHBKCBH, IReadOnlyList<OBLGPLHBPAG> CEBGLEJOGLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OBLGPLHBPAG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject ADPKHONGLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JHMBDMCOPKA OnBeforePageSwapFrom(Uri NADLCOGBJKK, JJDMLPPBOFA HIAJCEJJCOE, ACLFJABALOB JILGCBMODFM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JHMBDMCOPKA OnBeforePageSwapTo(Uri NADLCOGBJKK, JJDMLPPBOFA HIAJCEJJCOE, ACLFJABALOB GAMCFBFMNJG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JHMBDMCOPKA OnAfterPageSwapTo(Uri NADLCOGBJKK, JJDMLPPBOFA HIAJCEJJCOE, ACLFJABALOB PCCACGCHMJC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JHMBDMCOPKA OnShow(JJDMLPPBOFA HIAJCEJJCOE, ACLFJABALOB FDCLKDOOCOI, ACLFJABALOB GFPDEIPEBMG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JHMBDMCOPKA OnHide(JJDMLPPBOFA HIAJCEJJCOE, ACLFJABALOB FDCLKDOOCOI, ACLFJABALOB GFPDEIPEBMG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JJDMLPPBOFA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JJDMLPPBOFA BMGLDIIFJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7142EF0", Offset = "0x71416F0", VA = "0x187142EF0")]
		[CompilerGenerated]
		get
		{
			return default(JJDMLPPBOFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BHDAAKNAPAC LPKIEDNFJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6D0", Offset = "0x8FAED0", VA = "0x1808FC6D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(BHDAAKNAPAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool COGFKFNPOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4134C60", Offset = "0x4133460", VA = "0x184134C60")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FAC0", Offset = "0x5E1E2C0", VA = "0x185E1FAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri DPNLJJPIIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B90C0", Offset = "0x8B78C0", VA = "0x1808B90C0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC13670", Offset = "0xC11E70", VA = "0x180C13670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri HIGCFNLJOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7142F40", Offset = "0x7141740", VA = "0x187142F40")]
	public JJDMLPPBOFA(Uri PEFHBBMEHAH, Uri BHAADBDKPGO, BHDAAKNAPAC NFCOIBKJNMF = BHDAAKNAPAC.None, bool KLJOLKMDIDC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BHDAAKNAPAC
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum IIAEHNIHOLJ
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
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1F4FAD0", Offset = "0x1F4E2D0", VA = "0x181F4FAD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7143790", Offset = "0x7141F90", VA = "0x187143790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71435D0", Offset = "0x7141DD0", VA = "0x1871435D0")]
		public string BCAFHHBPCKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7143670", Offset = "0x7141E70", VA = "0x187143670", Slot = "4")]
		public bool Equals(Route OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71436E0", Offset = "0x7141EE0", VA = "0x1871436E0", Slot = "5")]
		public bool Equals(Uri NADLCOGBJKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7143740", Offset = "0x7141F40", VA = "0x187143740")]
		public AssetReference MHGODJJLPFB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7143850", Offset = "0x7142050", VA = "0x187143850")]
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
					[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
			[JHDHKHGHMBJ("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7145E20", Offset = "0x7144620", VA = "0x187145E20")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KKHOHGMIGLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public KKHOHGMIGLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7142F90", Offset = "0x7141790", VA = "0x187142F90")]
			internal bool CEOGHFMGNOL(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IEOJCCDIBCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public IEOJCCDIBCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7142CC0", Offset = "0x71414C0", VA = "0x187142CC0")]
			internal bool OGMHHGGIEAA(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class INHJLODHPDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public CKECBDNFIAF statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public INHJLODHPDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7142D00", Offset = "0x7141500", VA = "0x187142D00")]
			internal bool ECKBDIBCIBN(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x71445B0", Offset = "0x7142DB0", VA = "0x1871445B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7144520", Offset = "0x7142D20", VA = "0x187144520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7143880", Offset = "0x7142080", VA = "0x187143880")]
		private static void DIHNAABPOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7143C50", Offset = "0x7142450", VA = "0x187143C50")]
		public bool GGLGHJAGHPE(Uri NADLCOGBJKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7143D50", Offset = "0x7142550", VA = "0x187143D50")]
		public static bool GIDAENJBKHI(Route MKBBGGFKGBA, [Out] RoutesConfig NELGMCFMKLI, [Out] View BCPMNDKNCIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71440C0", Offset = "0x71428C0", VA = "0x1871440C0")]
		public static AssetReference MHGODJJLPFB(Route MKBBGGFKGBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7144490", Offset = "0x7142C90", VA = "0x187144490")]
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
		private sealed class NCGMGEJDCCF
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
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public NCGMGEJDCCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7143170", Offset = "0x7141970", VA = "0x187143170")]
			internal bool OBBCPHHFFNJ(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7143070", Offset = "0x7141870", VA = "0x187143070")]
			internal bool NNGHLGLGMMD(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7145D90", Offset = "0x7144590", VA = "0x187145D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7145BC0", Offset = "0x71443C0", VA = "0x187145BC0")]
		public Uri(Uri NADLCOGBJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7145B00", Offset = "0x7144300", VA = "0x187145B00")]
		public Uri(params Route[] MKBBGGFKGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7145CB0", Offset = "0x71444B0", VA = "0x187145CB0")]
		public Uri(IEnumerable<Route> MKBBGGFKGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7144C50", Offset = "0x7143450", VA = "0x187144C50")]
		public bool HFKAHFAOINF(Route MKBBGGFKGBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7145010", Offset = "0x7143810", VA = "0x187145010")]
		public bool HFKAHFAOINF(IEnumerable<Route> DPOEDHFDBPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7144CB0", Offset = "0x71434B0", VA = "0x187144CB0")]
		public bool HFKAHFAOINF(Uri OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7144BF0", Offset = "0x71433F0", VA = "0x187144BF0")]
		public static bool HACFJPDLFNP(Uri NADLCOGBJKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7145250", Offset = "0x7143A50", VA = "0x187145250")]
		public static bool IHJMDBLAKJJ(Uri NKCCEIKLOPK, Uri ICPBHPBDLLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7145520", Offset = "0x7143D20", VA = "0x187145520")]
		public bool IHJMDBLAKJJ(Uri OGFCKBADKBE, bool KJMFJADDAFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7144940", Offset = "0x7143140", VA = "0x187144940", Slot = "4")]
		public bool Equals(Uri OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x71450B0", Offset = "0x71438B0", VA = "0x1871450B0")]
		public static bool IHJMDBLAKJJ(Uri NADLCOGBJKK, Route MKBBGGFKGBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x71448E0", Offset = "0x71430E0", VA = "0x1871448E0", Slot = "5")]
		public bool Equals(Route MKBBGGFKGBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71447A0", Offset = "0x7142FA0", VA = "0x1871447A0", Slot = "0")]
		public override bool Equals(object GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71449C0", Offset = "0x71431C0", VA = "0x1871449C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7144710", Offset = "0x7142F10", VA = "0x187144710")]
		public string EBJIGKGLPLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7145610", Offset = "0x7143E10", VA = "0x187145610", Slot = "3")]
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
