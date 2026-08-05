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
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject IMKHIAEHMPK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas IFJHCDGBHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject FDFHJGFFCKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x71E2380", Offset = "0x71E0B80", VA = "0x1871E2380")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route POGFBCDMBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x859CC0", VA = "0x18085B4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71E2140", Offset = "0x71E0940", VA = "0x1871E2140")]
		public void Initialize(GameObject LDIDGLFLGNK, Transform BMBBFJPOJEB, Route ODGODDBGOIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71E2450", Offset = "0x71E0C50", VA = "0x1871E2450")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71E2130", Offset = "0x71E0930", VA = "0x1871E2130")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71E2270", Offset = "0x71E0A70", VA = "0x1871E2270")]
		private void KNLHDCOHIKN(bool MJEAMAFIMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JFCFNNCMNAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper KFCCHIHIEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<BLKJPDKHCPJ> CKBLANIDDKL;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85D850", VA = "0x18085F050")]
	public JFCFNNCMNAE(PageWrapper MBMMCAMPJME, IReadOnlyList<BLKJPDKHCPJ> HDEJMDOIBFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BLKJPDKHCPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject BGONLCODLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OABICBNODGM OnBeforePageSwapFrom(Uri GHDGOIAIBMC, EONMHMMJGJE OGHLFHGIOLB, JFCFNNCMNAE HCANACDHIPN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OABICBNODGM OnBeforePageSwapTo(Uri GHDGOIAIBMC, EONMHMMJGJE OGHLFHGIOLB, JFCFNNCMNAE LFHOAPHHNHD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OABICBNODGM OnAfterPageSwapTo(Uri GHDGOIAIBMC, EONMHMMJGJE OGHLFHGIOLB, JFCFNNCMNAE ABPIJEAOBFL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OABICBNODGM OnShow(EONMHMMJGJE OGHLFHGIOLB, JFCFNNCMNAE OBOPGDHBBIF, JFCFNNCMNAE EIKJAJHIPAE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OABICBNODGM OnHide(EONMHMMJGJE OGHLFHGIOLB, JFCFNNCMNAE OBOPGDHBBIF, JFCFNNCMNAE EIKJAJHIPAE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EONMHMMJGJE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static EONMHMMJGJE ELIKMDBCIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71E1F70", Offset = "0x71E0770", VA = "0x1871E1F70")]
		[CompilerGenerated]
		get
		{
			return default(EONMHMMJGJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DJLGBPBPLNP FADJHCPPBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00")]
		[CompilerGenerated]
		readonly get
		{
			return default(DJLGBPBPLNP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A710", VA = "0x180A7BF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DEJEOFOCOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x421A640", Offset = "0x4218E40", VA = "0x18421A640")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E47050", Offset = "0x5E45850", VA = "0x185E47050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri DIBMIGCCDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2900", VA = "0x1808C4100")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA7AFE0", Offset = "0xA797E0", VA = "0x180A7AFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri PPJMPEPBOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8518F0", VA = "0x1808530F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x71E1FC0", Offset = "0x71E07C0", VA = "0x1871E1FC0")]
	public EONMHMMJGJE(Uri IGPBMAELJAH, Uri HEHPNJEAOGA, DJLGBPBPLNP BNPCOHLNJFC = DJLGBPBPLNP.None, bool KCLANFPILKI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DJLGBPBPLNP
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CPAONDOLJME
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5740", Offset = "0x1FE3F40", VA = "0x181FE5740", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x71E2650", Offset = "0x71E0E50", VA = "0x1871E2650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71E2490", Offset = "0x71E0C90", VA = "0x1871E2490")]
		public string DMDCNPKCHFN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x71E2530", Offset = "0x71E0D30", VA = "0x1871E2530", Slot = "4")]
		public bool Equals(Route OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71E25A0", Offset = "0x71E0DA0", VA = "0x1871E25A0", Slot = "5")]
		public bool Equals(Uri GHDGOIAIBMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71E2600", Offset = "0x71E0E00", VA = "0x1871E2600")]
		public AssetReference JNIOLKLGNCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71E2710", Offset = "0x71E0F10", VA = "0x1871E2710")]
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
					[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
			[GAHJBHBDFNE("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x71E4D70", Offset = "0x71E3570", VA = "0x1871E4D70")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class OPMEFALHGGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public OPMEFALHGGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71E2050", Offset = "0x71E0850", VA = "0x1871E2050")]
			internal bool BKEMCCIMMHN(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OMNFLMMLJNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public OMNFLMMLJNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x71E2010", Offset = "0x71E0810", VA = "0x1871E2010")]
			internal bool CPLCAEKNEKA(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DHFIFKMGLHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public NICHJPMKMDF statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public DHFIFKMGLHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x71E1B90", Offset = "0x71E0390", VA = "0x1871E1B90")]
			internal bool FLDOBPHGBOG(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x71E34C0", Offset = "0x71E1CC0", VA = "0x1871E34C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x71E3430", Offset = "0x71E1C30", VA = "0x1871E3430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x71E2BB0", Offset = "0x71E13B0", VA = "0x1871E2BB0")]
		private static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71E2AB0", Offset = "0x71E12B0", VA = "0x1871E2AB0")]
		public bool EMIJBIIBKLG(Uri GHDGOIAIBMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71E2740", Offset = "0x71E0F40", VA = "0x1871E2740")]
		public static bool CINMIJJONMJ(Route ODGODDBGOIK, [Out] RoutesConfig MEMBKPIPJHA, [Out] View CMGLOHLIIPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71E2FA0", Offset = "0x71E17A0", VA = "0x1871E2FA0")]
		public static AssetReference JNIOLKLGNCK(Route ODGODDBGOIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71E33A0", Offset = "0x71E1BA0", VA = "0x1871E33A0")]
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
		private sealed class EJKBPNCJKCC
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
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
			public EJKBPNCJKCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x71E1E70", Offset = "0x71E0670", VA = "0x1871E1E70")]
			internal bool PIBJMLKAABL(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x71E1D70", Offset = "0x71E0570", VA = "0x1871E1D70")]
			internal bool EAENODINMFE(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x71E4CE0", Offset = "0x71E34E0", VA = "0x1871E4CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x71E4B10", Offset = "0x71E3310", VA = "0x1871E4B10")]
		public Uri(Uri GHDGOIAIBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x71E4A50", Offset = "0x71E3250", VA = "0x1871E4A50")]
		public Uri(params Route[] ODGODDBGOIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x71E4C00", Offset = "0x71E3400", VA = "0x1871E4C00")]
		public Uri(IEnumerable<Route> ODGODDBGOIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71E3AA0", Offset = "0x71E22A0", VA = "0x1871E3AA0")]
		public bool DJONJHALGBO(Route ODGODDBGOIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71E3A00", Offset = "0x71E2200", VA = "0x1871E3A00")]
		public bool DJONJHALGBO(IEnumerable<Route> GGKDDKHAJFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71E36A0", Offset = "0x71E1EA0", VA = "0x1871E36A0")]
		public bool DJONJHALGBO(Uri OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x71E3640", Offset = "0x71E1E40", VA = "0x1871E3640")]
		public static bool CFHDDGLKNCC(Uri GHDGOIAIBMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x71E3FE0", Offset = "0x71E27E0", VA = "0x1871E3FE0")]
		public static bool KDJLOMMBFFK(Uri MLFGLJKBOIG, Uri GANEOONFJPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71E4450", Offset = "0x71E2C50", VA = "0x1871E4450")]
		public bool KDJLOMMBFFK(Uri OKGBBGMIACH, bool MMLGJDANNHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71E3CA0", Offset = "0x71E24A0", VA = "0x1871E3CA0", Slot = "4")]
		public bool Equals(Uri OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x71E42B0", Offset = "0x71E2AB0", VA = "0x1871E42B0")]
		public static bool KDJLOMMBFFK(Uri GHDGOIAIBMC, Route ODGODDBGOIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x71E3C40", Offset = "0x71E2440", VA = "0x1871E3C40", Slot = "5")]
		public bool Equals(Route ODGODDBGOIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71E3B00", Offset = "0x71E2300", VA = "0x1871E3B00", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71E3D20", Offset = "0x71E2520", VA = "0x1871E3D20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x71E3F50", Offset = "0x71E2750", VA = "0x1871E3F50")]
		public string KBFDMBNENKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71E4540", Offset = "0x71E2D40", VA = "0x1871E4540", Slot = "3")]
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
