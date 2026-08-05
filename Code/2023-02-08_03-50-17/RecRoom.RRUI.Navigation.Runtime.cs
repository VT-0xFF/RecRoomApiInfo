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
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject PKFNCFNBILA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas HFEAFFOKCPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject LMLHJOFCJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x215AB00", Offset = "0x2159900", VA = "0x18215AB00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x215A8B0", Offset = "0x21596B0", VA = "0x18215A8B0")]
		public void Initialize(GameObject CEJJEPABPHM, Transform KICGHGEEADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x215ABD0", Offset = "0x21599D0", VA = "0x18215ABD0")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x215A8A0", Offset = "0x21596A0", VA = "0x18215A8A0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x215A9D0", Offset = "0x21597D0", VA = "0x18215A9D0")]
		private void KBENNLMIBIN(bool OHEOJBCEEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OHBHKFNALOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PageWrapper CGJHHLMEHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IReadOnlyList<OMNPPICFBCB> IFHIJFNENNF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8FC090", Offset = "0x8FAE90", VA = "0x1808FC090")]
	public OHBHKFNALOI(PageWrapper MAHFJHNNIOC, IReadOnlyList<OMNPPICFBCB> LEIJINJKDKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OMNPPICFBCB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GameObject DCLAADPIBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FFFHIGBANBM OnBeforePageSwapFrom(Uri KCAPMDDAGKI, JKJFKAJFBAA MNBGKMFFCML, OHBHKFNALOI ECPCGACOHJB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FFFHIGBANBM OnBeforePageSwapTo(Uri KCAPMDDAGKI, JKJFKAJFBAA MNBGKMFFCML, OHBHKFNALOI CPOABOOOJPK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FFFHIGBANBM OnAfterPageSwapTo(Uri KCAPMDDAGKI, JKJFKAJFBAA MNBGKMFFCML, OHBHKFNALOI NDBFBKLIFFJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FFFHIGBANBM OnShow(JKJFKAJFBAA MNBGKMFFCML, OHBHKFNALOI GDHNGOIJFBH, OHBHKFNALOI PKPFABHBGMK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FFFHIGBANBM OnHide(JKJFKAJFBAA MNBGKMFFCML, OHBHKFNALOI GDHNGOIJFBH, OHBHKFNALOI PKPFABHBGMK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JKJFKAJFBAA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JKJFKAJFBAA JLGGJMINNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x215A1B0", Offset = "0x2158FB0", VA = "0x18215A1B0")]
		[CompilerGenerated]
		get
		{
			return default(JKJFKAJFBAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FOHLHBHEKMA BKIHHABOGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(FOHLHBHEKMA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA40", Offset = "0x6EE840", VA = "0x1806EFA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HKBFKKHMMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D44F0", Offset = "0x8D32F0", VA = "0x1808D44F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D44E0", Offset = "0x8D32E0", VA = "0x1808D44E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Uri HJCBIEMMKHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x804EC0", Offset = "0x803CC0", VA = "0x180804EC0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x804ED0", Offset = "0x803CD0", VA = "0x180804ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri FAJDDGPIJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F00", Offset = "0x6E5D00", VA = "0x1806E6F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x215A220", Offset = "0x2159020", VA = "0x18215A220")]
	public JKJFKAJFBAA(Uri GGOGNEKFMKL, Uri PMHMGFNPONN, FOHLHBHEKMA LBBFIAPLLIM = FOHLHBHEKMA.None, bool IHAKFHJBJAE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FOHLHBHEKMA
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KFOOGKHEIEL
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Pending
}
namespace RRUI.Navigation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class Route : IEquatable<Route>, IEquatable<Uri>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private SerializedGuid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public SerializedGuid ViewGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C77B0", Offset = "0x9C65B0", VA = "0x1809C77B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x215AD60", Offset = "0x2159B60", VA = "0x18215AD60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x215AC70", Offset = "0x2159A70", VA = "0x18215AC70", Slot = "4")]
		public bool Equals(Route BNIMMCIKNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x215AD40", Offset = "0x2159B40", VA = "0x18215AD40", Slot = "5")]
		public bool Equals(Uri KCAPMDDAGKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x215AC10", Offset = "0x2159A10", VA = "0x18215AC10")]
		public AssetReference EPNMMDBOOOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x215AE30", Offset = "0x2159C30", VA = "0x18215AE30")]
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
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				[SerializeField]
				private SerializedSplitTestExperimentSegment splitTestingSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public SerializedSplitTestExperimentSegment SplitTestingSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000031")]
					[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000032")]
					[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
				public SplitTestingVariant()
				{
				}
			}

			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public class StatsigVariant
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				[SerializeField]
				private SerializedStatsigExperimentSegment statsigSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public SerializedStatsigExperimentSegment StatsigSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
				public StatsigVariant()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			[SerializeField]
			private SerializedGuid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[SerializeField]
			private string friendlyName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[SerializeField]
			private AssetReference prefabReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			[SerializeField]
			[GKEHEANINHF("SplitTestingSegment")]
			private SplitTestingVariant[] splitTestingVariants;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[SerializeField]
			[GKEHEANINHF("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IReadOnlyList<SplitTestingVariant> SplitTestingVariants
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x215D600", Offset = "0x215C400", VA = "0x18215D600")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class CLLNLNGNIJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public CLLNLNGNIJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2159E70", Offset = "0x2158C70", VA = "0x182159E70")]
			internal bool <ContainsUri>b__0(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BBJPNPFLEDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public BBJPNPFLEDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2159E30", Offset = "0x2158C30", VA = "0x182159E30")]
			internal bool <ContainsUri>b__1(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly string ResourcesRoutesDirectoryPath;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly string FullRoutesDirectoryPath;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static List<RoutesConfig> _configs;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static Dictionary<Guid, View> _viewMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private List<View> views;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool _isInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x215BC80", Offset = "0x215AA80", VA = "0x18215BC80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x215BBD0", Offset = "0x215A9D0", VA = "0x18215BBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x215B250", Offset = "0x215A050", VA = "0x18215B250")]
		private static void FKIENGHPLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x215B5B0", Offset = "0x215A3B0", VA = "0x18215B5B0")]
		public bool FMNIBENJFNA(Uri KCAPMDDAGKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x215B6B0", Offset = "0x215A4B0", VA = "0x18215B6B0")]
		public static bool GJLEKMKPNGA(Route AIKHBOBABNP, out RoutesConfig EGEELIPJMNB, out View ICMFBJLNDPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x215AE60", Offset = "0x2159C60", VA = "0x18215AE60")]
		public static AssetReference EPNMMDBOOOJ(Route AIKHBOBABNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x215BB50", Offset = "0x215A950", VA = "0x18215BB50")]
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
		private sealed class IBEKBLFCEGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IReadOnlyList<Route> bRoute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Uri b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Uri a;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public IBEKBLFCEGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2159F60", Offset = "0x2158D60", VA = "0x182159F60")]
			internal bool <Equals>b__0(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x215A0B0", Offset = "0x2158EB0", VA = "0x18215A0B0")]
			internal bool <Equals>b__1(string k)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private List<Route> route;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Dictionary<string, object> data;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x215D580", Offset = "0x215C380", VA = "0x18215D580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x215D3D0", Offset = "0x215C1D0", VA = "0x18215D3D0")]
		public Uri(Uri KCAPMDDAGKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x215D320", Offset = "0x215C120", VA = "0x18215D320")]
		public Uri(params Route[] AIKHBOBABNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x215D4B0", Offset = "0x215C2B0", VA = "0x18215D4B0")]
		public Uri(IEnumerable<Route> AIKHBOBABNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x215C530", Offset = "0x215B330", VA = "0x18215C530")]
		public bool DOMBPGEJHPH(Route AIKHBOBABNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x215C0C0", Offset = "0x215AEC0", VA = "0x18215C0C0")]
		public bool DOMBPGEJHPH(IEnumerable<Route> POKKLDOFOMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x215C170", Offset = "0x215AF70", VA = "0x18215C170")]
		public bool DOMBPGEJHPH(Uri BNIMMCIKNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x215CB20", Offset = "0x215B920", VA = "0x18215CB20")]
		public static bool MLHEGDJEPEH(Uri EFBCPNIKEHB, Uri BFLEMGIJKLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x215C8E0", Offset = "0x215B6E0", VA = "0x18215C8E0")]
		public bool MLHEGDJEPEH(Uri BNIMMCIKNIE, bool NDLNGIIEEOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x215C5A0", Offset = "0x215B3A0", VA = "0x18215C5A0", Slot = "4")]
		public bool Equals(Uri BNIMMCIKNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x215C9A0", Offset = "0x215B7A0", VA = "0x18215C9A0")]
		public static bool MLHEGDJEPEH(Uri KCAPMDDAGKI, Route AIKHBOBABNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x215C590", Offset = "0x215B390", VA = "0x18215C590", Slot = "5")]
		public bool Equals(Route AIKHBOBABNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x215C5C0", Offset = "0x215B3C0", VA = "0x18215C5C0", Slot = "0")]
		public override bool Equals(object LOPIEGGIDMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x215C6D0", Offset = "0x215B4D0", VA = "0x18215C6D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x215C870", Offset = "0x215B670", VA = "0x18215C870")]
		public string IODJEFFAIAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x215CE10", Offset = "0x215BC10", VA = "0x18215CE10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x215A5C0", Offset = "0x21593C0", VA = "0x18215A5C0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x215A270", Offset = "0x2159070", VA = "0x18215A270")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
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

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
