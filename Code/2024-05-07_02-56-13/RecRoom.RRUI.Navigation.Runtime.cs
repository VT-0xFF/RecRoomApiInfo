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
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject OJOCGEADENK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas IBOOJNEAOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject CIIAMBKCFBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6A6E670", Offset = "0x6A6D870", VA = "0x186A6E670")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route LNEPDNOAEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E860", Offset = "0x6A6DA60", VA = "0x186A6E860")]
		public void Initialize(GameObject PGCLKHPOEBL, Transform BHNONFFBKHO, Route OICCKPCKJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E990", Offset = "0x6A6DB90", VA = "0x186A6E990")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E850", Offset = "0x6A6DA50", VA = "0x186A6E850")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E740", Offset = "0x6A6D940", VA = "0x186A6E740")]
		private void EJIHKAIELEL(bool ILHDENLPHEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JPKOHCKMCLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper DAFKPOLGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<ADGLMAOHDEL> BIEBKHGJGHL;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
	public JPKOHCKMCLN(PageWrapper FIOOPEKJICF, IReadOnlyList<ADGLMAOHDEL> GCAJMOHLEDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ADGLMAOHDEL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject OFPFIDAFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OFPHFCMJPLJ OnBeforePageSwapFrom(Uri GNEFEELIDCC, IIGMLEDPKPF FNIBPAONDEO, JPKOHCKMCLN HOCIMNLMIGG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OFPHFCMJPLJ OnBeforePageSwapTo(Uri GNEFEELIDCC, IIGMLEDPKPF FNIBPAONDEO, JPKOHCKMCLN NGGLJEFNLHM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OFPHFCMJPLJ OnAfterPageSwapTo(Uri GNEFEELIDCC, IIGMLEDPKPF FNIBPAONDEO, JPKOHCKMCLN EMOPPEGKCJL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OFPHFCMJPLJ OnShow(IIGMLEDPKPF FNIBPAONDEO, JPKOHCKMCLN EALIKADMDED, JPKOHCKMCLN HDOPPIBCNLL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OFPHFCMJPLJ OnHide(IIGMLEDPKPF FNIBPAONDEO, JPKOHCKMCLN EALIKADMDED, JPKOHCKMCLN HDOPPIBCNLL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IIGMLEDPKPF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static IIGMLEDPKPF CGCFGJJDBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E1A0", Offset = "0x6A6D3A0", VA = "0x186A6E1A0")]
		[CompilerGenerated]
		get
		{
			return default(IIGMLEDPKPF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AEDCBBECIIG DOKEIEMEPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
		[CompilerGenerated]
		readonly get
		{
			return default(AEDCBBECIIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BFDFBPGHKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D10810", Offset = "0x3D0FA10", VA = "0x183D10810")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x57BDC70", Offset = "0x57BCE70", VA = "0x1857BDC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri FKDICNNIMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xB0A970", Offset = "0xB09B70", VA = "0x180B0A970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri GHNPIFAJONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6E1F0", Offset = "0x6A6D3F0", VA = "0x186A6E1F0")]
	public IIGMLEDPKPF(Uri OAMGNMNBBFC, Uri CIMHHKGDDPI, AEDCBBECIIG NHKDMOHEBCO = AEDCBBECIIG.None, bool KNLBMFIMGEO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum AEDCBBECIIG
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum DNGDGAEBIPK
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
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1E5B540", Offset = "0x1E5A740", VA = "0x181E5B540", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EB90", Offset = "0x6A6DD90", VA = "0x186A6EB90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EAA0", Offset = "0x6A6DCA0", VA = "0x186A6EAA0")]
		public string GPNOKGMNMHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A6E9D0", Offset = "0x6A6DBD0", VA = "0x186A6E9D0", Slot = "4")]
		public bool Equals(Route NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EA40", Offset = "0x6A6DC40", VA = "0x186A6EA40", Slot = "5")]
		public bool Equals(Uri GNEFEELIDCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EB40", Offset = "0x6A6DD40", VA = "0x186A6EB40")]
		public AssetReference KIJEDGPEOCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EC50", Offset = "0x6A6DE50", VA = "0x186A6EC50")]
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
					[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
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
			[MOEKDDJBDDK("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6A71210", Offset = "0x6A70410", VA = "0x186A71210")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class AOFDHFNJCMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public AOFDHFNJCMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6A6E0C0", Offset = "0x6A6D2C0", VA = "0x186A6E0C0")]
			internal bool CPALBPPOMIM(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JLKLIHDCBOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public JLKLIHDCBOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6A6E240", Offset = "0x6A6D440", VA = "0x186A6E240")]
			internal bool JJFAPOFFJHH(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MNMDJKFAEKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public LFGFELEHJNP statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public MNMDJKFAEKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6A6E480", Offset = "0x6A6D680", VA = "0x186A6E480")]
			internal bool MMJHJHIICLF(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x6A6F9B0", Offset = "0x6A6EBB0", VA = "0x186A6F9B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6A6F920", Offset = "0x6A6EB20", VA = "0x186A6F920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F0F0", Offset = "0x6A6E2F0", VA = "0x186A6F0F0")]
		private static void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A6EC80", Offset = "0x6A6DE80", VA = "0x186A6EC80")]
		public bool ALPJEKPHKCB(Uri GNEFEELIDCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A6ED80", Offset = "0x6A6DF80", VA = "0x186A6ED80")]
		public static bool ENBLMMFMCLO(Route OICCKPCKJND, [Out] RoutesConfig EBLKLMONLLL, [Out] View GCMOEFONIPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F4C0", Offset = "0x6A6E6C0", VA = "0x186A6F4C0")]
		public static AssetReference KIJEDGPEOCK(Route OICCKPCKJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A6F890", Offset = "0x6A6EA90", VA = "0x186A6F890")]
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
		private sealed class MLHKKBNJOOH
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
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public MLHKKBNJOOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6A6E380", Offset = "0x6A6D580", VA = "0x186A6E380")]
			internal bool FLJIMNAPGBP(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6A6E280", Offset = "0x6A6D480", VA = "0x186A6E280")]
			internal bool EPBGPJOHJLE(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6A71180", Offset = "0x6A70380", VA = "0x186A71180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A70FB0", Offset = "0x6A701B0", VA = "0x186A70FB0")]
		public Uri(Uri GNEFEELIDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A70EF0", Offset = "0x6A700F0", VA = "0x186A70EF0")]
		public Uri(params Route[] OICCKPCKJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A710A0", Offset = "0x6A702A0", VA = "0x186A710A0")]
		public Uri(IEnumerable<Route> OICCKPCKJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6A70680", Offset = "0x6A6F880", VA = "0x186A70680")]
		public bool GIIBKAKCCGO(Route OICCKPCKJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A706E0", Offset = "0x6A6F8E0", VA = "0x186A706E0")]
		public bool GIIBKAKCCGO(IEnumerable<Route> OOGPAJGJGEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A70320", Offset = "0x6A6F520", VA = "0x186A70320")]
		public bool GIIBKAKCCGO(Uri NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A709B0", Offset = "0x6A6FBB0", VA = "0x186A709B0")]
		public static bool PPFMDOGEELH(Uri GNEFEELIDCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FDA0", Offset = "0x6A6EFA0", VA = "0x186A6FDA0")]
		public static bool DBJIIIOILFO(Uri JPEEHDCLFEK, Uri HGMCBKHHGFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FB10", Offset = "0x6A6ED10", VA = "0x186A6FB10")]
		public bool DBJIIIOILFO(Uri NOBJAPGNDAK, bool OECNPADKLAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A702A0", Offset = "0x6A6F4A0", VA = "0x186A702A0", Slot = "4")]
		public bool Equals(Uri NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A6FC00", Offset = "0x6A6EE00", VA = "0x186A6FC00")]
		public static bool DBJIIIOILFO(Uri GNEFEELIDCC, Route OICCKPCKJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A70240", Offset = "0x6A6F440", VA = "0x186A70240", Slot = "5")]
		public bool Equals(Route OICCKPCKJND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A70100", Offset = "0x6A6F300", VA = "0x186A70100", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A70780", Offset = "0x6A6F980", VA = "0x186A70780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A70070", Offset = "0x6A6F270", VA = "0x186A70070")]
		public string EKLMBFGOFFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A70A10", Offset = "0x6A6FC10", VA = "0x186A70A10", Slot = "3")]
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
