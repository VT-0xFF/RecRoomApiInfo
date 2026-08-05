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
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject MHOHHGBCING;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas CMGPNIEPHHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject HFDMLNIECGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6BC9940", Offset = "0x6BC8340", VA = "0x186BC9940")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route KAFALEDNJLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C8FA0", Offset = "0x7C79A0", VA = "0x1807C8FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9810", Offset = "0x6BC8210", VA = "0x186BC9810")]
		public void Initialize(GameObject EJCMPLOJDOL, Transform HHJLJBMAMDD, Route CKEKGJJGIOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9A10", Offset = "0x6BC8410", VA = "0x186BC9A10")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9800", Offset = "0x6BC8200", VA = "0x186BC9800")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6BC96F0", Offset = "0x6BC80F0", VA = "0x186BC96F0")]
		private void HINIKKFCMIL(bool JGLFOIIEBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HHOOABINEHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper KMGNJPOBCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<KPJKPHOHHAO> CGPAHELMMLA;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D18F0", Offset = "0x7D02F0", VA = "0x1807D18F0")]
	public HHOOABINEHP(PageWrapper NCDEAGNEKJA, IReadOnlyList<KPJKPHOHHAO> FHEPFIAOKBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KPJKPHOHHAO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject JKMOLLDKDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DBBHNMNBJNG OnBeforePageSwapFrom(Uri INGKMNPEEAN, LOACIABEEEN BAEGICLJJGI, HHOOABINEHP FCAMHOEKCAI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DBBHNMNBJNG OnBeforePageSwapTo(Uri INGKMNPEEAN, LOACIABEEEN BAEGICLJJGI, HHOOABINEHP BHKMAHJGLLF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DBBHNMNBJNG OnAfterPageSwapTo(Uri INGKMNPEEAN, LOACIABEEEN BAEGICLJJGI, HHOOABINEHP NJEHBGOLMKL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBBHNMNBJNG OnShow(LOACIABEEEN BAEGICLJJGI, HHOOABINEHP IHOJFLLMMLC, HHOOABINEHP LGFIKDHDEIF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DBBHNMNBJNG OnHide(LOACIABEEEN BAEGICLJJGI, HHOOABINEHP IHOJFLLMMLC, HHOOABINEHP LGFIKDHDEIF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LOACIABEEEN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static LOACIABEEEN GMHFJIOGOCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9450", Offset = "0x6BC7E50", VA = "0x186BC9450")]
		[CompilerGenerated]
		get
		{
			return default(LOACIABEEEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KKILMFLLGDD POGGMGNEAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x927700", Offset = "0x926100", VA = "0x180927700")]
		[CompilerGenerated]
		readonly get
		{
			return default(KKILMFLLGDD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x927740", Offset = "0x926140", VA = "0x180927740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool IMKBDNODLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB660", Offset = "0x3DFA060", VA = "0x183DFB660")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x58FA050", Offset = "0x58F8A50", VA = "0x1858FA050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri ANDNGEIIGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x91FF80", Offset = "0x91E980", VA = "0x18091FF80")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB20250", Offset = "0xB1EC50", VA = "0x180B20250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri BOJKAILOGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC94A0", Offset = "0x6BC7EA0", VA = "0x186BC94A0")]
	public LOACIABEEEN(Uri JJLOKFCNLHF, Uri IICGBLGMMCB, KKILMFLLGDD BOMGMBCBGMF = KKILMFLLGDD.None, bool BMHDEENNGOO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KKILMFLLGDD
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BDFKKDDIPJH
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
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1E8C8E0", Offset = "0x1E8B2E0", VA = "0x181E8C8E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9C10", Offset = "0x6BC8610", VA = "0x186BC9C10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9B70", Offset = "0x6BC8570", VA = "0x186BC9B70")]
		public string HDHLPENMGHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9AA0", Offset = "0x6BC84A0", VA = "0x186BC9AA0", Slot = "4")]
		public bool Equals(Route HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9B10", Offset = "0x6BC8510", VA = "0x186BC9B10", Slot = "5")]
		public bool Equals(Uri INGKMNPEEAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9A50", Offset = "0x6BC8450", VA = "0x186BC9A50")]
		public AssetReference DFCFGFFGHIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9CD0", Offset = "0x6BC86D0", VA = "0x186BC9CD0")]
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
					[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
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
			[NMLKGLJMHPO("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6BCC330", Offset = "0x6BCAD30", VA = "0x186BCC330")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class GBALLFCODFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public GBALLFCODFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6BC9150", Offset = "0x6BC7B50", VA = "0x186BC9150")]
			internal bool MJJBMLNGACK(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GCIDFGLJPBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public GCIDFGLJPBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6BC9230", Offset = "0x6BC7C30", VA = "0x186BC9230")]
			internal bool POPMKKELMIE(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IJHJDGGGNFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public PNBPIKBDKFG statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public IJHJDGGGNFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6BC9270", Offset = "0x6BC7C70", VA = "0x186BC9270")]
			internal bool CCKJPEOOKGI(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x6BCAA80", Offset = "0x6BC9480", VA = "0x186BCAA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6BCA9F0", Offset = "0x6BC93F0", VA = "0x186BCA9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9FE0", Offset = "0x6BC89E0", VA = "0x186BC9FE0")]
		private static void MPOMBMILLLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA740", Offset = "0x6BC9140", VA = "0x186BCA740")]
		public bool PNENDKCOHCK(Uri INGKMNPEEAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA3D0", Offset = "0x6BC8DD0", VA = "0x186BCA3D0")]
		public static bool OHBIMHFCPCC(Route CKEKGJJGIOJ, [Out] RoutesConfig DJMIGMGBNGJ, [Out] View BJLIAPJIDDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6BC9D00", Offset = "0x6BC8700", VA = "0x186BC9D00")]
		public static AssetReference DFCFGFFGHIH(Route CKEKGJJGIOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BCA960", Offset = "0x6BC9360", VA = "0x186BCA960")]
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
		private sealed class PGDAFNAFDKI
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
			[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
			public PGDAFNAFDKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6BC95F0", Offset = "0x6BC7FF0", VA = "0x186BC95F0")]
			internal bool NHBHDECNDKL(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6BC94F0", Offset = "0x6BC7EF0", VA = "0x186BC94F0")]
			internal bool BEBPHFHBMLM(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6BCC2A0", Offset = "0x6BCACA0", VA = "0x186BCC2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6BCC0D0", Offset = "0x6BCAAD0", VA = "0x186BCC0D0")]
		public Uri(Uri INGKMNPEEAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6BCC010", Offset = "0x6BCAA10", VA = "0x186BCC010")]
		public Uri(params Route[] CKEKGJJGIOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6BCC1C0", Offset = "0x6BCABC0", VA = "0x186BCC1C0")]
		public Uri(IEnumerable<Route> CKEKGJJGIOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBAA0", Offset = "0x6BCA4A0", VA = "0x186BCBAA0")]
		public bool OBHCHEDFPHH(Route CKEKGJJGIOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB6A0", Offset = "0x6BCA0A0", VA = "0x186BCB6A0")]
		public bool OBHCHEDFPHH(IEnumerable<Route> OLHKBCNILGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB740", Offset = "0x6BCA140", VA = "0x186BCB740")]
		public bool OBHCHEDFPHH(Uri HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB640", Offset = "0x6BCA040", VA = "0x186BCB640")]
		public static bool MJOGKGKNLAM(Uri INGKMNPEEAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB280", Offset = "0x6BC9C80", VA = "0x186BCB280")]
		public static bool KGKJIIAJPND(Uri LMANHAAPNDE, Uri AMHFHPBEBNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB550", Offset = "0x6BC9F50", VA = "0x186BCB550")]
		public bool KGKJIIAJPND(Uri HKMMPHJFKEA, bool MGKKDNNMIBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6BCAE30", Offset = "0x6BC9830", VA = "0x186BCAE30", Slot = "4")]
		public bool Equals(Uri HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB0E0", Offset = "0x6BC9AE0", VA = "0x186BCB0E0")]
		public static bool KGKJIIAJPND(Uri INGKMNPEEAN, Route CKEKGJJGIOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6BCADD0", Offset = "0x6BC97D0", VA = "0x186BCADD0", Slot = "5")]
		public bool Equals(Route CKEKGJJGIOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BCAC90", Offset = "0x6BC9690", VA = "0x186BCAC90", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BCAEB0", Offset = "0x6BC98B0", VA = "0x186BCAEB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BCAC00", Offset = "0x6BC9600", VA = "0x186BCAC00")]
		public string CLLBFBOLDDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBB00", Offset = "0x6BCA500", VA = "0x186BCBB00", Slot = "3")]
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
