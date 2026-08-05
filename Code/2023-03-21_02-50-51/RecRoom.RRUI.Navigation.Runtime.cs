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
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject PHONKDGKLKA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas FOHJGACGNKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject HOBIPHOAAHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6595130", Offset = "0x6593930", VA = "0x186595130")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route EDNHCBJPLCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x76DB00", Offset = "0x76C300", VA = "0x18076DB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6594ED0", Offset = "0x65936D0", VA = "0x186594ED0")]
		public void Initialize(GameObject JEADJLGMJJI, Transform FAAJOMIIHED, Route EOPDJDJCCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6595200", Offset = "0x6593A00", VA = "0x186595200")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6594EC0", Offset = "0x65936C0", VA = "0x186594EC0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6595000", Offset = "0x6593800", VA = "0x186595000")]
		private void JDFAJNPMMKF(bool OBFDOLNNMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FJMFNPLEGHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper BOGHOBPLOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<PGJJDLDFFNC> GCIMKGIOJNL;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D56E0", Offset = "0x6D3EE0", VA = "0x1806D56E0")]
	public FJMFNPLEGHC(PageWrapper ODDKODIPBJA, IReadOnlyList<PGJJDLDFFNC> NIJFGOGBKBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PGJJDLDFFNC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject BADAIJBGKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LDGADANDBIO OnBeforePageSwapFrom(Uri JMBEMFHFLND, FGHJJICKGIN CDFJHEMMDBB, FJMFNPLEGHC OPBPOBHKIMA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LDGADANDBIO OnBeforePageSwapTo(Uri JMBEMFHFLND, FGHJJICKGIN CDFJHEMMDBB, FJMFNPLEGHC PNALCAGEPMK);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LDGADANDBIO OnAfterPageSwapTo(Uri JMBEMFHFLND, FGHJJICKGIN CDFJHEMMDBB, FJMFNPLEGHC MLMOLOPDBCD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDGADANDBIO OnShow(FGHJJICKGIN CDFJHEMMDBB, FJMFNPLEGHC DBJCLPEPGJN, FJMFNPLEGHC PKGMHOCFKFK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LDGADANDBIO OnHide(FGHJJICKGIN CDFJHEMMDBB, FJMFNPLEGHC DBJCLPEPGJN, FJMFNPLEGHC PKGMHOCFKFK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FGHJJICKGIN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static FGHJJICKGIN KKHIANFEDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6594410", Offset = "0x6592C10", VA = "0x186594410")]
		[CompilerGenerated]
		get
		{
			return default(FGHJJICKGIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HOJBFNGGEHA MGKHAEFOHIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40")]
		[CompilerGenerated]
		readonly get
		{
			return default(HOJBFNGGEHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x786DB0", Offset = "0x7855B0", VA = "0x180786DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GBCBEJHOGNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD5F4E0", Offset = "0xD5DCE0", VA = "0x180D5F4E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3901380", Offset = "0x38FFB80", VA = "0x183901380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri FPIJHHJHING
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72B840", Offset = "0x72A040", VA = "0x18072B840")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xE85CE0", Offset = "0xE844E0", VA = "0x180E85CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri JDLHNJKBFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5130", Offset = "0x6F3930", VA = "0x1806F5130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6594480", Offset = "0x6592C80", VA = "0x186594480")]
	public FGHJJICKGIN(Uri GCIDBAFGPHI, Uri GCOLAEACKKC, HOJBFNGGEHA LBIHPOFKJOJ = HOJBFNGGEHA.None, bool PPMDPCLKALG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HOJBFNGGEHA
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum DNHEFBKNIGB
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
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x921470", Offset = "0x91FC70", VA = "0x180921470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65953E0", Offset = "0x6593BE0", VA = "0x1865953E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65952A0", Offset = "0x6593AA0", VA = "0x1865952A0", Slot = "4")]
		public bool Equals(Route HAKPJJGEGOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6595370", Offset = "0x6593B70", VA = "0x186595370", Slot = "5")]
		public bool Equals(Uri JMBEMFHFLND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6595240", Offset = "0x6593A40", VA = "0x186595240")]
		public AssetReference BEOFILMCJDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x65954B0", Offset = "0x6593CB0", VA = "0x1865954B0")]
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
					[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
			[EJKGPJLGKFD("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x6D6120", Offset = "0x6D4920", VA = "0x1806D6120")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6597B00", Offset = "0x6596300", VA = "0x186597B00")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class CLIJDIHMBIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public CLIJDIHMBIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6594320", Offset = "0x6592B20", VA = "0x186594320")]
			internal bool <ContainsUri>b__0(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class HHAAPJKEHGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public HHAAPJKEHGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x65944D0", Offset = "0x6592CD0", VA = "0x1865944D0")]
			internal bool <ContainsUri>b__1(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class NKKEHNDKAKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public MIJGMBFDPDO statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public NKKEHNDKAKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6594760", Offset = "0x6592F60", VA = "0x186594760")]
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
			[Cpp2IlInjected.Address(RVA = "0x6596220", Offset = "0x6594A20", VA = "0x186596220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6596170", Offset = "0x6594970", VA = "0x186596170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6595CB0", Offset = "0x65944B0", VA = "0x186595CB0")]
		private static void ODGJJHFNDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x65957F0", Offset = "0x6593FF0", VA = "0x1865957F0")]
		public bool IEJINPEAIGK(Uri JMBEMFHFLND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x65958F0", Offset = "0x65940F0", VA = "0x1865958F0")]
		public static bool JELKFBBAKJF(Route EOPDJDJCCHI, out RoutesConfig ANAHDMOCJAE, out View OLIHMNPLJHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x65954E0", Offset = "0x6593CE0", VA = "0x1865954E0")]
		public static AssetReference BEOFILMCJDO(Route EOPDJDJCCHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x65960F0", Offset = "0x65948F0", VA = "0x1865960F0")]
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
		private sealed class MINCEGMNCLF
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
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public MINCEGMNCLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6594510", Offset = "0x6592D10", VA = "0x186594510")]
			internal bool <Equals>b__0(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6594660", Offset = "0x6592E60", VA = "0x186594660")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6597A80", Offset = "0x6596280", VA = "0x186597A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x65978D0", Offset = "0x65960D0", VA = "0x1865978D0")]
		public Uri(Uri JMBEMFHFLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6597820", Offset = "0x6596020", VA = "0x186597820")]
		public Uri(params Route[] EOPDJDJCCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x65979B0", Offset = "0x65961B0", VA = "0x1865979B0")]
		public Uri(IEnumerable<Route> EOPDJDJCCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6596E80", Offset = "0x6595680", VA = "0x186596E80")]
		public bool JEBNAOILLLF(Route EOPDJDJCCHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6596DD0", Offset = "0x65955D0", VA = "0x186596DD0")]
		public bool JEBNAOILLLF(IEnumerable<Route> FCJMDAKGHHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6596EE0", Offset = "0x65956E0", VA = "0x186596EE0")]
		public bool JEBNAOILLLF(Uri HAKPJJGEGOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6596430", Offset = "0x6594C30", VA = "0x186596430")]
		public static bool BIJBAFFKCJE(Uri JMBEMFHFLND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6596940", Offset = "0x6595140", VA = "0x186596940")]
		public static bool GKAHDDHENKO(Uri HDPOKDCLGGE, Uri JBKIIGINOKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x65966A0", Offset = "0x6594EA0", VA = "0x1865966A0")]
		public bool GKAHDDHENKO(Uri HAKPJJGEGOM, bool MDNLOFOGBKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6596500", Offset = "0x6594D00", VA = "0x186596500", Slot = "4")]
		public bool Equals(Uri HAKPJJGEGOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x65967A0", Offset = "0x6594FA0", VA = "0x1865967A0")]
		public static bool GKAHDDHENKO(Uri JMBEMFHFLND, Route EOPDJDJCCHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6596490", Offset = "0x6594C90", VA = "0x186596490", Slot = "5")]
		public bool Equals(Route EOPDJDJCCHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6596590", Offset = "0x6594D90", VA = "0x186596590", Slot = "0")]
		public override bool Equals(object BFHAMCLNCKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6596C30", Offset = "0x6595430", VA = "0x186596C30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6596390", Offset = "0x6594B90", VA = "0x186596390")]
		public string AKHFOPPALGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x65972A0", Offset = "0x6595AA0", VA = "0x1865972A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6594BE0", Offset = "0x65933E0", VA = "0x186594BE0")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6594890", Offset = "0x6593090", VA = "0x186594890")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
