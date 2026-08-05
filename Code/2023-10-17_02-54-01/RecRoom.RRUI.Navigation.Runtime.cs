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
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject IFOCCNFJOIE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas FJBEEDLEFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject DOMEEILHDNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x634E2B0", Offset = "0x634CAB0", VA = "0x18634E2B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route JPPGDBHGPIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x634E390", Offset = "0x634CB90", VA = "0x18634E390")]
		public void Initialize(GameObject DKLHLNCIIOO, Transform OBIIIBPBMLD, Route JGGMJBPLAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x634E5D0", Offset = "0x634CDD0", VA = "0x18634E5D0")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x634E380", Offset = "0x634CB80", VA = "0x18634E380")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x634E4C0", Offset = "0x634CCC0", VA = "0x18634E4C0")]
		private void NOEOIBOCIBJ(bool PEJKHFEJKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NIFKKBMBFLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper HBBJNIDOAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<OBNHMDIGIGD> BNGHLGGIENK;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	public NIFKKBMBFLE(PageWrapper BFKPEPNJNDK, IReadOnlyList<OBNHMDIGIGD> PEHAAIMLKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OBNHMDIGIGD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject MLINCMAHJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CPOBDANHFCI OnBeforePageSwapFrom(Uri FBJCLEOEDOO, KMNPHCCOAAM EEILNADBKNP, NIFKKBMBFLE HOBBJBJNLEM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CPOBDANHFCI OnBeforePageSwapTo(Uri FBJCLEOEDOO, KMNPHCCOAAM EEILNADBKNP, NIFKKBMBFLE IHDDIJAFDFP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CPOBDANHFCI OnAfterPageSwapTo(Uri FBJCLEOEDOO, KMNPHCCOAAM EEILNADBKNP, NIFKKBMBFLE ICCBHCCOFFA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CPOBDANHFCI OnShow(KMNPHCCOAAM EEILNADBKNP, NIFKKBMBFLE JMNLJEADKNI, NIFKKBMBFLE IEJDGJCGJHN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CPOBDANHFCI OnHide(KMNPHCCOAAM EEILNADBKNP, NIFKKBMBFLE JMNLJEADKNI, NIFKKBMBFLE IEJDGJCGJHN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KMNPHCCOAAM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static KMNPHCCOAAM MHFKJLABGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x634E0E0", Offset = "0x634C8E0", VA = "0x18634E0E0")]
		[CompilerGenerated]
		get
		{
			return default(KMNPHCCOAAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GKBJCGOEGOJ MIJNEIAPNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		[CompilerGenerated]
		readonly get
		{
			return default(GKBJCGOEGOJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F1550", Offset = "0x7EFD50", VA = "0x1807F1550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GJPEGJEHEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38FFAD0", Offset = "0x38FE2D0", VA = "0x1838FFAD0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5379C60", Offset = "0x5378460", VA = "0x185379C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri NJJPLPDBJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98F9E0", Offset = "0x98E1E0", VA = "0x18098F9E0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98FAB0", Offset = "0x98E2B0", VA = "0x18098FAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri NMEEBEOIKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x634E130", Offset = "0x634C930", VA = "0x18634E130")]
	public KMNPHCCOAAM(Uri FCGKIGBPDFK, Uri INNPKGHIFJD, GKBJCGOEGOJ JOIHBAJKECN = GKBJCGOEGOJ.None, bool FEIMHKJHMHL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GKBJCGOEGOJ
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum PKLANCLHOCA
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
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1C32270", Offset = "0x1C30A70", VA = "0x181C32270", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x634E7D0", Offset = "0x634CFD0", VA = "0x18634E7D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x634E6E0", Offset = "0x634CEE0", VA = "0x18634E6E0")]
		public string MPODFLJDFJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x634E610", Offset = "0x634CE10", VA = "0x18634E610", Slot = "4")]
		public bool Equals(Route IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x634E680", Offset = "0x634CE80", VA = "0x18634E680", Slot = "5")]
		public bool Equals(Uri FBJCLEOEDOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x634E780", Offset = "0x634CF80", VA = "0x18634E780")]
		public AssetReference OJPDIOLFONJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x634E890", Offset = "0x634D090", VA = "0x18634E890")]
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
					[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
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
			[DFCDIMJJEDM("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6350EF0", Offset = "0x634F6F0", VA = "0x186350EF0")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BLOGHBPPEOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public BLOGHBPPEOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x634DDC0", Offset = "0x634C5C0", VA = "0x18634DDC0")]
			internal bool OHCFGEFKILL(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ELJFNNFBBHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public ELJFNNFBBHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x634DEA0", Offset = "0x634C6A0", VA = "0x18634DEA0")]
			internal bool BCAOICHNMNL(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class POEGGIAGEGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public JJCDNFCIIMN statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public POEGGIAGEGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x634E180", Offset = "0x634C980", VA = "0x18634E180")]
			internal bool GJEHDPILDML(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x634F640", Offset = "0x634DE40", VA = "0x18634F640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x634F5B0", Offset = "0x634DDB0", VA = "0x18634F5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x634EC30", Offset = "0x634D430", VA = "0x18634EC30")]
		private static void GLJEDCMMNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x634F020", Offset = "0x634D820", VA = "0x18634F020")]
		public bool IHBNEIIHPJL(Uri FBJCLEOEDOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x634E8C0", Offset = "0x634D0C0", VA = "0x18634E8C0")]
		public static bool GCEBGBCGDOM(Route JGGMJBPLAMB, [Out] RoutesConfig DOIOACIGMJB, [Out] View GODBNCGAEIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x634F120", Offset = "0x634D920", VA = "0x18634F120")]
		public static AssetReference OJPDIOLFONJ(Route JGGMJBPLAMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x634F520", Offset = "0x634DD20", VA = "0x18634F520")]
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
		private sealed class JODEMGNOLJJ
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
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public JODEMGNOLJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x634DEE0", Offset = "0x634C6E0", VA = "0x18634DEE0")]
			internal bool IMPDFAAKMMA(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x634DFE0", Offset = "0x634C7E0", VA = "0x18634DFE0")]
			internal bool KIPMHKFGAJF(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6350E60", Offset = "0x634F660", VA = "0x186350E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6350C90", Offset = "0x634F490", VA = "0x186350C90")]
		public Uri(Uri FBJCLEOEDOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6350BD0", Offset = "0x634F3D0", VA = "0x186350BD0")]
		public Uri(params Route[] JGGMJBPLAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6350D80", Offset = "0x634F580", VA = "0x186350D80")]
		public Uri(IEnumerable<Route> JGGMJBPLAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x634FA70", Offset = "0x634E270", VA = "0x18634FA70")]
		public bool FGLNMIBCGML(Route JGGMJBPLAMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x634FE30", Offset = "0x634E630", VA = "0x18634FE30")]
		public bool FGLNMIBCGML(IEnumerable<Route> BFNJPNAMPAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x634FAD0", Offset = "0x634E2D0", VA = "0x18634FAD0")]
		public bool FGLNMIBCGML(Uri IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6350660", Offset = "0x634EE60", VA = "0x186350660")]
		public static bool NJJJJBFIMNL(Uri FBJCLEOEDOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x63501F0", Offset = "0x634E9F0", VA = "0x1863501F0")]
		public static bool JDJBPEMKOJF(Uri EOFAJFKEBLN, Uri DNOEGKBPKDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6350100", Offset = "0x634E900", VA = "0x186350100")]
		public bool JDJBPEMKOJF(Uri IFHFGCDLDEA, bool EJOBECLBGAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x634F9F0", Offset = "0x634E1F0", VA = "0x18634F9F0", Slot = "4")]
		public bool Equals(Uri IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x63504C0", Offset = "0x634ECC0", VA = "0x1863504C0")]
		public static bool JDJBPEMKOJF(Uri FBJCLEOEDOO, Route JGGMJBPLAMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x634F990", Offset = "0x634E190", VA = "0x18634F990", Slot = "5")]
		public bool Equals(Route JGGMJBPLAMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x634F850", Offset = "0x634E050", VA = "0x18634F850", Slot = "0")]
		public override bool Equals(object CBBCDNDPNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x634FED0", Offset = "0x634E6D0", VA = "0x18634FED0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x634F7C0", Offset = "0x634DFC0", VA = "0x18634F7C0")]
		public string BLKPNKFFLMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63506C0", Offset = "0x634EEC0", VA = "0x1863506C0", Slot = "3")]
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
