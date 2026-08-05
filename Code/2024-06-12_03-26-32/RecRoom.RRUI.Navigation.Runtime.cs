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
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject IGOEGALAMEC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas BFEPMFLDCNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject NJNPLEDEDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x71D1F00", Offset = "0x71D0B00", VA = "0x1871D1F00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route FNMKCFIEEFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71D1DD0", Offset = "0x71D09D0", VA = "0x1871D1DD0")]
		public void Initialize(GameObject FNAMIJIHKEF, Transform GPMGJNAOOEP, Route CDAPLKAFGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71D1FD0", Offset = "0x71D0BD0", VA = "0x1871D1FD0")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71D1DC0", Offset = "0x71D09C0", VA = "0x1871D1DC0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71D1CB0", Offset = "0x71D08B0", VA = "0x1871D1CB0")]
		private void BFMMGKOLFHC(bool ECJEHODDMGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KBANLONPCBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper HPONNEFJJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<IDJLNHKNANO> IAFPAJOKLLN;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
	public KBANLONPCBN(PageWrapper PMOGHEIIIEJ, IReadOnlyList<IDJLNHKNANO> AFBKPNIHDDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IDJLNHKNANO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject KNJFPDLIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CEIMLGOLMNM OnBeforePageSwapFrom(Uri NPKDOGFDBLA, BMCHBPBGIFA KONMDJKGHML, KBANLONPCBN ECIANNDLIJJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CEIMLGOLMNM OnBeforePageSwapTo(Uri NPKDOGFDBLA, BMCHBPBGIFA KONMDJKGHML, KBANLONPCBN FNAJLHHMNLI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CEIMLGOLMNM OnAfterPageSwapTo(Uri NPKDOGFDBLA, BMCHBPBGIFA KONMDJKGHML, KBANLONPCBN OFFJEJGBMFO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CEIMLGOLMNM OnShow(BMCHBPBGIFA KONMDJKGHML, KBANLONPCBN CNKNECHPIEC, KBANLONPCBN LHGFADJDLNN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CEIMLGOLMNM OnHide(BMCHBPBGIFA KONMDJKGHML, KBANLONPCBN CNKNECHPIEC, KBANLONPCBN LHGFADJDLNN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BMCHBPBGIFA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static BMCHBPBGIFA IOGFCHMIMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71D1710", Offset = "0x71D0310", VA = "0x1871D1710")]
		[CompilerGenerated]
		get
		{
			return default(BMCHBPBGIFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DGBKEOPFNNC ALJDKJNGOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x916930", Offset = "0x915530", VA = "0x180916930")]
		[CompilerGenerated]
		readonly get
		{
			return default(DGBKEOPFNNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JABPBCHNEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x41DBB20", Offset = "0x41DA720", VA = "0x1841DBB20")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CE70", Offset = "0x5E7BA70", VA = "0x185E7CE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri BCEJPMJHABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xC41270", Offset = "0xC3FE70", VA = "0x180C41270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri PFDHBFGACNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x71D1760", Offset = "0x71D0360", VA = "0x1871D1760")]
	public BMCHBPBGIFA(Uri PCJCELDMOEK, Uri LBENJDHKAEL, DGBKEOPFNNC GPGOHFDIJDI = DGBKEOPFNNC.None, bool LGLAOKOIGOP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DGBKEOPFNNC
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EAMKCLAGEDO
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
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA7620", Offset = "0x1FA6220", VA = "0x181FA7620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x71D21D0", Offset = "0x71D0DD0", VA = "0x1871D21D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71D2010", Offset = "0x71D0C10", VA = "0x1871D2010")]
		public string EOAEAMNMOHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71D20B0", Offset = "0x71D0CB0", VA = "0x1871D20B0", Slot = "4")]
		public bool Equals(Route OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71D2120", Offset = "0x71D0D20", VA = "0x1871D2120", Slot = "5")]
		public bool Equals(Uri NPKDOGFDBLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71D2180", Offset = "0x71D0D80", VA = "0x1871D2180")]
		public AssetReference PAODAGOOBKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71D2290", Offset = "0x71D0E90", VA = "0x1871D2290")]
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
					[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
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
			[MPPGJHPHAPD("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x71D48F0", Offset = "0x71D34F0", VA = "0x1871D48F0")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class JAKPPFIPKJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public JAKPPFIPKJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71D1B90", Offset = "0x71D0790", VA = "0x1871D1B90")]
			internal bool LCBKKHHNAMN(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OGNLPDDCBOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public OGNLPDDCBOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x71D1C70", Offset = "0x71D0870", VA = "0x1871D1C70")]
			internal bool DIJMIOIGHAO(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class ELHGENNOOCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public GKDHMMKGFLI statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public ELHGENNOOCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x71D19B0", Offset = "0x71D05B0", VA = "0x1871D19B0")]
			internal bool CJBHGIFFPLC(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x71D3040", Offset = "0x71D1C40", VA = "0x1871D3040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x71D2FB0", Offset = "0x71D1BB0", VA = "0x1871D2FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x71D22C0", Offset = "0x71D0EC0", VA = "0x1871D22C0")]
		private static void EHHLDMLDHNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71D2A20", Offset = "0x71D1620", VA = "0x1871D2A20")]
		public bool LBPGEBPLCDM(Uri NPKDOGFDBLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71D26B0", Offset = "0x71D12B0", VA = "0x1871D26B0")]
		public static bool IONALMMAMJF(Route CDAPLKAFGDN, [Out] RoutesConfig FHHCNEEIACA, [Out] View BHLDJICDMFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71D2B20", Offset = "0x71D1720", VA = "0x1871D2B20")]
		public static AssetReference PAODAGOOBKM(Route CDAPLKAFGDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71D2F20", Offset = "0x71D1B20", VA = "0x1871D2F20")]
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
		private sealed class DLDKHIANMMB
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
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public DLDKHIANMMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x71D18B0", Offset = "0x71D04B0", VA = "0x1871D18B0")]
			internal bool NPECAEELMCM(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x71D17B0", Offset = "0x71D03B0", VA = "0x1871D17B0")]
			internal bool GFMHJLHFOFO(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x71D4860", Offset = "0x71D3460", VA = "0x1871D4860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71D4690", Offset = "0x71D3290", VA = "0x1871D4690")]
		public Uri(Uri NPKDOGFDBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x71D45D0", Offset = "0x71D31D0", VA = "0x1871D45D0")]
		public Uri(params Route[] CDAPLKAFGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x71D4780", Offset = "0x71D3380", VA = "0x1871D4780")]
		public Uri(IEnumerable<Route> CDAPLKAFGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71D31C0", Offset = "0x71D1DC0", VA = "0x1871D31C0")]
		public bool CPCALDGNEHE(Route CDAPLKAFGDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71D3580", Offset = "0x71D2180", VA = "0x1871D3580")]
		public bool CPCALDGNEHE(IEnumerable<Route> FEBNEKBCJKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71D3220", Offset = "0x71D1E20", VA = "0x1871D3220")]
		public bool CPCALDGNEHE(Uri OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x71D3B00", Offset = "0x71D2700", VA = "0x1871D3B00")]
		public static bool IHNECOIEJHB(Uri NPKDOGFDBLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x71D3B60", Offset = "0x71D2760", VA = "0x1871D3B60")]
		public static bool NKPGMPOIHJL(Uri NABHBOMGBNH, Uri EIKHFLMLKJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71D3FD0", Offset = "0x71D2BD0", VA = "0x1871D3FD0")]
		public bool NKPGMPOIHJL(Uri OCNJFCPHJLD, bool EMAMHCAAKDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71D3850", Offset = "0x71D2450", VA = "0x1871D3850", Slot = "4")]
		public bool Equals(Uri OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x71D3E30", Offset = "0x71D2A30", VA = "0x1871D3E30")]
		public static bool NKPGMPOIHJL(Uri NPKDOGFDBLA, Route CDAPLKAFGDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x71D37F0", Offset = "0x71D23F0", VA = "0x1871D37F0", Slot = "5")]
		public bool Equals(Route CDAPLKAFGDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71D36B0", Offset = "0x71D22B0", VA = "0x1871D36B0", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71D38D0", Offset = "0x71D24D0", VA = "0x1871D38D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x71D3620", Offset = "0x71D2220", VA = "0x1871D3620")]
		public string DECKJHCLIMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71D40C0", Offset = "0x71D2CC0", VA = "0x1871D40C0", Slot = "3")]
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
