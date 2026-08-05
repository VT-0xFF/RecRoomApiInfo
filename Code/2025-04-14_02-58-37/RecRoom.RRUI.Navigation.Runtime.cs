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
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject HDCBPOAGIJL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas JJANFDIBBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject MJPNLNDKMCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8350320", Offset = "0x834ED20", VA = "0x188350320")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route KGDADLOCBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9B5530", Offset = "0x9B3F30", VA = "0x1809B5530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83501F0", Offset = "0x834EBF0", VA = "0x1883501F0")]
		public void Initialize(GameObject APKLFNOJIFO, Transform HGBJMKAPAJA, Route NJBPLCGGNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8350500", Offset = "0x834EF00", VA = "0x188350500")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83501E0", Offset = "0x834EBE0", VA = "0x1883501E0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83503F0", Offset = "0x834EDF0", VA = "0x1883503F0")]
		private void ODADBMIGNEN(bool OMJHOLAGIPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PGHPFADKLGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper HOOCIANPBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<INPCMCGDECG> DMOOMGNEGOF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
	public PGHPFADKLGJ(PageWrapper FOBOKOKAKLE, IReadOnlyList<INPCMCGDECG> MBEDJNCLMLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface INPCMCGDECG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject OJFCLDLGCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCIOFMEGJFK OnBeforePageSwapFrom(Uri MOLBCJCHCIG, ODADGPMICHP NKHEGOPIGCH, PGHPFADKLGJ BGFPOLIMELG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JCIOFMEGJFK OnBeforePageSwapTo(Uri MOLBCJCHCIG, ODADGPMICHP NKHEGOPIGCH, PGHPFADKLGJ DFNGDIDDCII);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCIOFMEGJFK OnAfterPageSwapTo(Uri MOLBCJCHCIG, ODADGPMICHP NKHEGOPIGCH, PGHPFADKLGJ GMHAFDDBIDJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JCIOFMEGJFK OnShow(ODADGPMICHP NKHEGOPIGCH, PGHPFADKLGJ CGPKDOHDGKD, PGHPFADKLGJ KKEHGEKHPIE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JCIOFMEGJFK OnHide(ODADGPMICHP NKHEGOPIGCH, PGHPFADKLGJ CGPKDOHDGKD, PGHPFADKLGJ KKEHGEKHPIE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ODADGPMICHP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static ODADGPMICHP JKECEEFIAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8350140", Offset = "0x834EB40", VA = "0x188350140")]
		[CompilerGenerated]
		get
		{
			return default(ODADGPMICHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MAKBNPDEACK CMBBIJHJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		[CompilerGenerated]
		readonly get
		{
			return default(MAKBNPDEACK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PKGHKLFEIAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0700", Offset = "0x4E9F100", VA = "0x184EA0700")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D0F890", Offset = "0x6D0E290", VA = "0x186D0F890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri EAINONNKBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD0E790", Offset = "0xD0D190", VA = "0x180D0E790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri IMODKEINPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8350190", Offset = "0x834EB90", VA = "0x188350190")]
	public ODADGPMICHP(Uri DOHGOAKLMPG, Uri GPFIAOEOEHM, MAKBNPDEACK ADGFCHODLNI = MAKBNPDEACK.None, bool JCBDNOJFHMJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum MAKBNPDEACK
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum DLBFBLHJBAJ
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
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x26C7200", Offset = "0x26C5C00", VA = "0x1826C7200", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8350700", Offset = "0x834F100", VA = "0x188350700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8350540", Offset = "0x834EF40", VA = "0x188350540")]
		public string CKELHLADPGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83505E0", Offset = "0x834EFE0", VA = "0x1883505E0", Slot = "4")]
		public bool Equals(Route OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8350650", Offset = "0x834F050", VA = "0x188350650", Slot = "5")]
		public bool Equals(Uri MOLBCJCHCIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83506B0", Offset = "0x834F0B0", VA = "0x1883506B0")]
		public AssetReference OHIGMPFMDBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83507C0", Offset = "0x834F1C0", VA = "0x1883507C0")]
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
					[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
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
			[EDOHGOEKKON("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x9AED50", Offset = "0x9AD750", VA = "0x1809AED50")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8353070", Offset = "0x8351A70", VA = "0x188353070")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class GILHAADJAJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public GILHAADJAJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x834FE60", Offset = "0x834E860", VA = "0x18834FE60")]
			internal bool GMCOIEIIPHC(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BGHKFLOHJOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public BGHKFLOHJOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x834FB50", Offset = "0x834E550", VA = "0x18834FB50")]
			internal bool ALMMBOOFDCD(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DABIAOBAIOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public OLFIBAGDMNG statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public DABIAOBAIOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x834FB90", Offset = "0x834E590", VA = "0x18834FB90")]
			internal bool EDHJGGFLIKH(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x8351540", Offset = "0x834FF40", VA = "0x188351540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x83514B0", Offset = "0x834FEB0", VA = "0x1883514B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83507F0", Offset = "0x834F1F0", VA = "0x1883507F0")]
		private static void ELAEPFFNBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8350F30", Offset = "0x834F930", VA = "0x188350F30")]
		public bool IKDCMEBHGLK(Uri MOLBCJCHCIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8350BC0", Offset = "0x834F5C0", VA = "0x188350BC0")]
		public static bool FJMKJKNGNDI(Route NJBPLCGGNPG, [Out] RoutesConfig DOMDBJOJFNM, [Out] View LJNMDJLBGPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8351030", Offset = "0x834FA30", VA = "0x188351030")]
		public static AssetReference OHIGMPFMDBN(Route NJBPLCGGNPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8351420", Offset = "0x834FE20", VA = "0x188351420")]
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
		private sealed class ILAMIFBOMJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IReadOnlyList<Route> bRoute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Uri b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Uri a;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public ILAMIFBOMJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x834FF40", Offset = "0x834E940", VA = "0x18834FF40")]
			internal bool ALAIDCABJAE(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8350040", Offset = "0x834EA40", VA = "0x188350040")]
			internal bool GOKEKABPEGF(string k)
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private string cachedRouteString;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8352FE0", Offset = "0x83519E0", VA = "0x188352FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8352E10", Offset = "0x8351810", VA = "0x188352E10")]
		public Uri(Uri MOLBCJCHCIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8352D50", Offset = "0x8351750", VA = "0x188352D50")]
		public Uri(params Route[] NJBPLCGGNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8352F00", Offset = "0x8351900", VA = "0x188352F00")]
		public Uri(IEnumerable<Route> NJBPLCGGNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83517D0", Offset = "0x83501D0", VA = "0x1883517D0")]
		public bool EGACGLIMIFH(Route NJBPLCGGNPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8351830", Offset = "0x8350230", VA = "0x188351830")]
		public bool EGACGLIMIFH(IEnumerable<Route> HHDOBOBIMPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83518D0", Offset = "0x83502D0", VA = "0x1883518D0")]
		public bool EGACGLIMIFH(Uri OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8351770", Offset = "0x8350170", VA = "0x188351770")]
		public static bool DDFCNJDHCLF(Uri MOLBCJCHCIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83523D0", Offset = "0x8350DD0", VA = "0x1883523D0")]
		public static bool HCIIELMKAJD(Uri KEEADJCBJCP, Uri LKKBJAKGIGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83522E0", Offset = "0x8350CE0", VA = "0x1883522E0")]
		public bool HCIIELMKAJD(Uri OLKLGHOAKNE, bool IJLGCCHPEHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8352030", Offset = "0x8350A30", VA = "0x188352030", Slot = "4")]
		public bool Equals(Uri OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83526A0", Offset = "0x83510A0", VA = "0x1883526A0")]
		public static bool HCIIELMKAJD(Uri MOLBCJCHCIG, Route NJBPLCGGNPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8351FD0", Offset = "0x83509D0", VA = "0x188351FD0", Slot = "5")]
		public bool Equals(Route NJBPLCGGNPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8351E90", Offset = "0x8350890", VA = "0x188351E90", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83520B0", Offset = "0x8350AB0", VA = "0x1883520B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83516A0", Offset = "0x83500A0", VA = "0x1883516A0")]
		public string AENCGLJJIMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8352840", Offset = "0x8351240", VA = "0x188352840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8351C30", Offset = "0x8350630", VA = "0x188351C30")]
		public string[] EGOMOFEMHHM()
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
