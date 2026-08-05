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
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject IAFLELOGMOM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas DIDAPAALBOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject ILNCBALCDME
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x69CCC40", Offset = "0x69CC040", VA = "0x1869CCC40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route LFCDIABHGIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0D30", VA = "0x1807B1930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69CCD20", Offset = "0x69CC120", VA = "0x1869CCD20")]
		public void Initialize(GameObject GIPNABGMLIN, Transform GGEKFPEBLKN, Route IENKOHJBBMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69CCF80", Offset = "0x69CC380", VA = "0x1869CCF80")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69CCD10", Offset = "0x69CC110", VA = "0x1869CCD10")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69CCE50", Offset = "0x69CC250", VA = "0x1869CCE50")]
		private void PPNCLANOLID(bool KIGKGNKOIAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KPEFJOMENFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper PJJJAADNOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<AGDCBDFIDIL> GEMJJGEMKEK;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DE200", Offset = "0x7DD600", VA = "0x1807DE200")]
	public KPEFJOMENFG(PageWrapper JCBJBHKKAJJ, IReadOnlyList<AGDCBDFIDIL> GBOIIDABDGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AGDCBDFIDIL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject MILHHPLGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKAHJLGEFLE OnBeforePageSwapFrom(Uri NCCMFAGMAPP, FMFKNFHPKEF FDDJEMNDCNJ, KPEFJOMENFG EBOGJKGNPON);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKAHJLGEFLE OnBeforePageSwapTo(Uri NCCMFAGMAPP, FMFKNFHPKEF FDDJEMNDCNJ, KPEFJOMENFG PPDOAANLPKB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JKAHJLGEFLE OnAfterPageSwapTo(Uri NCCMFAGMAPP, FMFKNFHPKEF FDDJEMNDCNJ, KPEFJOMENFG BFJKDKGOBPD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JKAHJLGEFLE OnShow(FMFKNFHPKEF FDDJEMNDCNJ, KPEFJOMENFG EIFLLBIEKDC, KPEFJOMENFG EFMOBEMEHMD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JKAHJLGEFLE OnHide(FMFKNFHPKEF FDDJEMNDCNJ, KPEFJOMENFG EIFLLBIEKDC, KPEFJOMENFG EFMOBEMEHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FMFKNFHPKEF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static FMFKNFHPKEF EBMJMAANCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69CC550", Offset = "0x69CB950", VA = "0x1869CC550")]
		[CompilerGenerated]
		get
		{
			return default(FMFKNFHPKEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PGCFNBIHDNO FMHNFBAPKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0")]
		[CompilerGenerated]
		readonly get
		{
			return default(PGCFNBIHDNO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBF6690", Offset = "0xBF5A90", VA = "0x180BF6690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NLFFBPLHEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBCAF50", Offset = "0xBCA350", VA = "0x180BCAF50")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3846450", Offset = "0x3845850", VA = "0x183846450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri BJLABAKOPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x979860", Offset = "0x978C60", VA = "0x180979860")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCB80B0", Offset = "0xCB74B0", VA = "0x180CB80B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri LOAHHFNCHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x734AE0", Offset = "0x733EE0", VA = "0x180734AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69CC5C0", Offset = "0x69CB9C0", VA = "0x1869CC5C0")]
	public FMFKNFHPKEF(Uri HPPEEEAPJFA, Uri KJCJBICGMDH, PGCFNBIHDNO FPOCKFGBHII = PGCFNBIHDNO.None, bool BNIGNOBKEIA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PGCFNBIHDNO
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OFPBMALOGDA
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
			[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x754730", Offset = "0x753B30", VA = "0x180754730", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69CD160", Offset = "0x69CC560", VA = "0x1869CD160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69CCFC0", Offset = "0x69CC3C0", VA = "0x1869CCFC0", Slot = "4")]
		public bool Equals(Route MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69CD090", Offset = "0x69CC490", VA = "0x1869CD090", Slot = "5")]
		public bool Equals(Uri NCCMFAGMAPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69CD100", Offset = "0x69CC500", VA = "0x1869CD100")]
		public AssetReference HJEEKDDGHPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69CD230", Offset = "0x69CC630", VA = "0x1869CD230")]
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
					[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
			[GLFADEJPPJM("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x72F250", Offset = "0x72E650", VA = "0x18072F250")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x72F270", Offset = "0x72E670", VA = "0x18072F270")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x69CF880", Offset = "0x69CEC80", VA = "0x1869CF880")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EHEPCLMAANK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public EHEPCLMAANK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x69CC210", Offset = "0x69CB610", VA = "0x1869CC210")]
			internal bool <ContainsUri>b__0(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EGLGKJEIBNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public EGLGKJEIBNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x69CC1D0", Offset = "0x69CB5D0", VA = "0x1869CC1D0")]
			internal bool <ContainsUri>b__1(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DADHNKDGGEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IODJOPPJCKG statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public DADHNKDGGEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x69CC0A0", Offset = "0x69CB4A0", VA = "0x1869CC0A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x69CDFA0", Offset = "0x69CD3A0", VA = "0x1869CDFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69CDEF0", Offset = "0x69CD2F0", VA = "0x1869CDEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69CDA30", Offset = "0x69CCE30", VA = "0x1869CDA30")]
		private static void KADCCJJCHBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69CD620", Offset = "0x69CCA20", VA = "0x1869CD620")]
		public bool BDJLJNPIIPC(Uri NCCMFAGMAPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69CD260", Offset = "0x69CC660", VA = "0x1869CD260")]
		public static bool ANCKEKFEGIN(Route IENKOHJBBMM, out RoutesConfig OCBPIMJIAPD, out View OAEGMEMBFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69CD720", Offset = "0x69CCB20", VA = "0x1869CD720")]
		public static AssetReference HJEEKDDGHPO(Route IENKOHJBBMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69CDE70", Offset = "0x69CD270", VA = "0x1869CDE70")]
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
		private sealed class EKOCNDICBMN
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
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public EKOCNDICBMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x69CC300", Offset = "0x69CB700", VA = "0x1869CC300")]
			internal bool <Equals>b__0(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x69CC450", Offset = "0x69CB850", VA = "0x1869CC450")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B010", Offset = "0x72A410", VA = "0x18072B010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x69CF800", Offset = "0x69CEC00", VA = "0x1869CF800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x69CF650", Offset = "0x69CEA50", VA = "0x1869CF650")]
		public Uri(Uri NCCMFAGMAPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x69CF5A0", Offset = "0x69CE9A0", VA = "0x1869CF5A0")]
		public Uri(params Route[] IENKOHJBBMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x69CF730", Offset = "0x69CEB30", VA = "0x1869CF730")]
		public Uri(IEnumerable<Route> IENKOHJBBMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x69CE3C0", Offset = "0x69CD7C0", VA = "0x1869CE3C0")]
		public bool GMBMHDKFMPB(Route IENKOHJBBMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x69CE7E0", Offset = "0x69CDBE0", VA = "0x1869CE7E0")]
		public bool GMBMHDKFMPB(IEnumerable<Route> OHFMNJGKFKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x69CE420", Offset = "0x69CD820", VA = "0x1869CE420")]
		public bool GMBMHDKFMPB(Uri MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69CEA30", Offset = "0x69CDE30", VA = "0x1869CEA30")]
		public static bool JEJILLMBCFE(Uri NCCMFAGMAPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69CEA90", Offset = "0x69CDE90", VA = "0x1869CEA90")]
		public static bool MDDDKCHCFCJ(Uri HFOFADIOHHP, Uri GFCGIJPPCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x69CEF20", Offset = "0x69CE320", VA = "0x1869CEF20")]
		public bool MDDDKCHCFCJ(Uri MPHACEGLFIL, bool PIBJLDPKDBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x69CE220", Offset = "0x69CD620", VA = "0x1869CE220", Slot = "4")]
		public bool Equals(Uri MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69CED80", Offset = "0x69CE180", VA = "0x1869CED80")]
		public static bool MDDDKCHCFCJ(Uri NCCMFAGMAPP, Route IENKOHJBBMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x69CE1B0", Offset = "0x69CD5B0", VA = "0x1869CE1B0", Slot = "5")]
		public bool Equals(Route IENKOHJBBMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69CE2B0", Offset = "0x69CD6B0", VA = "0x1869CE2B0", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x69CE890", Offset = "0x69CDC90", VA = "0x1869CE890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x69CE110", Offset = "0x69CD510", VA = "0x1869CE110")]
		public string AGGMJNFBCLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69CF020", Offset = "0x69CE420", VA = "0x1869CF020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x69CC960", Offset = "0x69CBD60", VA = "0x1869CC960")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69CC610", Offset = "0x69CBA10", VA = "0x1869CC610")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
