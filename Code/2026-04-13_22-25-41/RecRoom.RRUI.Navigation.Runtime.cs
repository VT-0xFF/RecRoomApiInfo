using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RRUI.Navigation;
using RRUI.Profiling.Runtime;
using RecRoom.Analytics.Statsig;
using RecRoom.Async;
using RecRoom.Attributes;
using RecRoom.Core.UI;
using RecRoom.DataStructures;
using UnityEngine;
using UnityEngine.AddressableAssets;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PageWrapper : MonoBehaviour, XEUIWTFHBZG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject VLDBSTWIOFB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas HSTUAHTKRBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject HFJBCEELKYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA332550", Offset = "0xA330F50", VA = "0x18A332550")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route QTSNQWEUWKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF2F30", VA = "0x180CF4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA332420", Offset = "0xA330E20", VA = "0x18A332420")]
		public void Initialize(GameObject contents, Transform parent, Route route)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA332620", Offset = "0xA331020", VA = "0x18A332620")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA332410", Offset = "0xA330E10", VA = "0x18A332410")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA332660", Offset = "0xA331060", VA = "0x18A332660")]
		private void WJUHOVBFEEC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1820930", Offset = "0x181F330", VA = "0x181820930", Slot = "4")]
		public PageChildrenStats Collect()
		{
			return default(PageChildrenStats);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
		public PageWrapper()
		{
		}
	}
}
namespace RRUI.Navigation
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class VPJIAQNYBUE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly PageWrapper MVMJYFLIRZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly IReadOnlyList<QMXYKHAYMUB> VCELNKMMBVB;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCF2960", Offset = "0xCF1360", VA = "0x180CF2960")]
		public VPJIAQNYBUE(PageWrapper a, IReadOnlyList<QMXYKHAYMUB> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface QMXYKHAYMUB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		GameObject GameObject
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GMTKWIVSBCA OnBeforePageSwapFrom(Uri uri, NavigationInfo info, VPJIAQNYBUE nextPageSwapInfo);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		GMTKWIVSBCA OnBeforePageSwapTo(Uri uri, NavigationInfo info, VPJIAQNYBUE currentPageSwapInfo);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GMTKWIVSBCA OnAfterPageSwapTo(Uri uri, NavigationInfo info, VPJIAQNYBUE previousPageSwapInfo);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GMTKWIVSBCA OnShow(NavigationInfo info, VPJIAQNYBUE fromPageSwapInfo, VPJIAQNYBUE toPageSwapInfo);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "5")]
		GMTKWIVSBCA OnHide(NavigationInfo info, VPJIAQNYBUE fromPageSwapInfo, VPJIAQNYBUE toPageSwapInfo);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct NavigationInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static NavigationInfo Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA3323C0", Offset = "0xA330DC0", VA = "0x18A3323C0")]
			[CompilerGenerated]
			get
			{
				return default(NavigationInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NavigationDirection NavigationDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF4FFA0", VA = "0x180F515A0")]
			[CompilerGenerated]
			readonly get
			{
				return default(NavigationDirection);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x15BB850", Offset = "0x15BA250", VA = "0x1815BB850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool TreatAsPageGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x68522C0", Offset = "0x6850CC0", VA = "0x1868522C0")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8BB1E70", Offset = "0x8BB0870", VA = "0x188BB1E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Uri FromUri
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xF270D0", Offset = "0xF25AD0", VA = "0x180F270D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xF270E0", Offset = "0xF25AE0", VA = "0x180F270E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Uri ToUri
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA332370", Offset = "0xA330D70", VA = "0x18A332370")]
		public NavigationInfo(Uri fromUri, Uri toUri, NavigationDirection navigationDirection = NavigationDirection.None, bool treatAsPageGroup = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum NavigationDirection
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		Forward,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Backward
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum NavigationState
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Pending
	}
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
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B755C0", Offset = "0x2B73FC0", VA = "0x182B755C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA332BE0", Offset = "0xA3315E0", VA = "0x18A332BE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA332970", Offset = "0xA331370", VA = "0x18A332970")]
		public string DFNYLZNWDAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA332A10", Offset = "0xA331410", VA = "0x18A332A10", Slot = "4")]
		public bool Equals(Route other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA332A80", Offset = "0xA331480", VA = "0x18A332A80", Slot = "5")]
		public bool Equals(Uri uri)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA332B90", Offset = "0xA331590", VA = "0x18A332B90")]
		public AssetReference LOHODXAIOGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA332AE0", Offset = "0xA3314E0", VA = "0x18A332AE0")]
		public static Route JODFIFIUISJ(Guid a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA332CA0", Offset = "0xA3316A0", VA = "0x18A332CA0")]
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
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000036")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
			[ArrayElementName("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA335400", Offset = "0xA333E00", VA = "0x18A335400")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FYMUBABGJPV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri KTGXLQBAKOG;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public FYMUBABGJPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA332290", Offset = "0xA330C90", VA = "0x18A332290")]
			internal bool HJQTFRFGEFT(View a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FYHNDTHJAEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View PINYDXWOSJP;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public FYHNDTHJAEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA332250", Offset = "0xA330C50", VA = "0x18A332250")]
			internal bool HJLMIKLIUUK(Route a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class EUKHXKXCZPT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public KBMIQUZVWZE ADTRHTTEIHF;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public EUKHXKXCZPT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA331FA0", Offset = "0xA3309A0", VA = "0x18A331FA0")]
			internal bool YKIXOIOYKTV(View.StatsigVariant a)
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
		private static bool FNNODVESRGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA333800", Offset = "0xA332200", VA = "0x18A333800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> FGGFVDAZQEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA333A40", Offset = "0xA332440", VA = "0x18A333A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> QPPBICPJNPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3330B0", Offset = "0xA331AB0", VA = "0x18A3330B0")]
		private static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA332CD0", Offset = "0xA3316D0", VA = "0x18A332CD0")]
		public bool ContainsUri(Uri uri)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA333490", Offset = "0xA331E90", VA = "0x18A333490")]
		public static bool TryGetRoutesConfigView(Route route, [Out] RoutesConfig routesConfigResult, [Out] View viewResult)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA332DC0", Offset = "0xA3317C0", VA = "0x18A332DC0")]
		public static AssetReference GetPrefabReference(Route route)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3339C0", Offset = "0xA3323C0", VA = "0x18A3339C0")]
		public RoutesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class Uri : IEquatable<Uri>, IEquatable<Route>
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class QPBHAOXKDWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IReadOnlyList<Route> EQYOMNNTKTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Uri JSEABVWGRPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Uri JRYTEPCJIED;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public QPBHAOXKDWK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA332870", Offset = "0xA331270", VA = "0x18A332870")]
			internal bool CKDLOWYMAZD(Route a, int b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA332770", Offset = "0xA331170", VA = "0x18A332770")]
			internal bool CJYERQEORNU(string a)
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
		private Dictionary<string, object> GEHCEZHJWAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private string UWLQWWBBWVM;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA335380", Offset = "0xA333D80", VA = "0x18A335380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA3351D0", Offset = "0xA333BD0", VA = "0x18A3351D0")]
		public Uri(Uri uri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA335120", Offset = "0xA333B20", VA = "0x18A335120")]
		public Uri(params Route[] route)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA3352B0", Offset = "0xA333CB0", VA = "0x18A3352B0")]
		public Uri(IEnumerable<Route> route)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA333FA0", Offset = "0xA3329A0", VA = "0x18A333FA0")]
		public bool Contains(Route route)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA333BA0", Offset = "0xA3325A0", VA = "0x18A333BA0")]
		public bool Contains(IEnumerable<Route> routes)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA333C40", Offset = "0xA332640", VA = "0x18A333C40")]
		public bool Contains(Uri other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA334BB0", Offset = "0xA3335B0", VA = "0x18A334BB0")]
		public static bool IsEmpty(Uri uri)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA3345E0", Offset = "0xA332FE0", VA = "0x18A3345E0")]
		public static bool Equals(Uri a, Uri b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA334230", Offset = "0xA332C30", VA = "0x18A334230")]
		public bool Equals(Uri other, bool strict)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA334900", Offset = "0xA333300", VA = "0x18A334900", Slot = "4")]
		public bool Equals(Uri other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA334320", Offset = "0xA332D20", VA = "0x18A334320")]
		public static bool Equals(Uri uri, Route route)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA3348A0", Offset = "0xA3332A0", VA = "0x18A3348A0", Slot = "5")]
		public bool Equals(Route route)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3344B0", Offset = "0xA332EB0", VA = "0x18A3344B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA334980", Offset = "0xA333380", VA = "0x18A334980", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA334C10", Offset = "0xA333610", VA = "0x18A334C10")]
		public string NJOYYXEWUXH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA334CE0", Offset = "0xA3336E0", VA = "0x18A334CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA334000", Offset = "0xA332A00", VA = "0x18A334000")]
		public string[] DIYUSGNXNDU()
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
