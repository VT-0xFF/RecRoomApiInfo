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
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject AGLOIIHMPDN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas HLIMOGKPKHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject JHPPONOONEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7273C40", Offset = "0x7272C40", VA = "0x187273C40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route BCAPCLHIIML
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x868800", Offset = "0x867800", VA = "0x180868800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7273D10", Offset = "0x7272D10", VA = "0x187273D10")]
		public void Initialize(GameObject JKHGLADLIKN, Transform HHMPHBNGMGF, Route AFMILICDFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7273E40", Offset = "0x7272E40", VA = "0x187273E40")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7273C30", Offset = "0x7272C30", VA = "0x187273C30")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7273B20", Offset = "0x7272B20", VA = "0x187273B20")]
		private void HPJGAKKCLHG(bool ICMGHBPICHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EKPGICKJMNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper IOKLCCCNPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<KKDPKMFOEIC> JPGPHBLLGID;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86A7E0", Offset = "0x8697E0", VA = "0x18086A7E0")]
	public EKPGICKJMNP(PageWrapper OLDMHOLDBKC, IReadOnlyList<KKDPKMFOEIC> ANAODOINKHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KKDPKMFOEIC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject CHNINBIEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PGILFKJEHOF OnBeforePageSwapFrom(Uri KHEDPODBCHI, FKAFAPKJILG DBJFNIAKFEB, EKPGICKJMNP FHNIJBNFKKO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PGILFKJEHOF OnBeforePageSwapTo(Uri KHEDPODBCHI, FKAFAPKJILG DBJFNIAKFEB, EKPGICKJMNP LOJDLLOFNJH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PGILFKJEHOF OnAfterPageSwapTo(Uri KHEDPODBCHI, FKAFAPKJILG DBJFNIAKFEB, EKPGICKJMNP NLKDACFGMEP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PGILFKJEHOF OnShow(FKAFAPKJILG DBJFNIAKFEB, EKPGICKJMNP POFGPIDGPBK, EKPGICKJMNP FABJEGNGFJP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PGILFKJEHOF OnHide(FKAFAPKJILG DBJFNIAKFEB, EKPGICKJMNP POFGPIDGPBK, EKPGICKJMNP FABJEGNGFJP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FKAFAPKJILG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static FKAFAPKJILG BMMJODHNHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7273760", Offset = "0x7272760", VA = "0x187273760")]
		[CompilerGenerated]
		get
		{
			return default(FKAFAPKJILG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JJNPBECHLFP FEBCNJAENHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA8D560", Offset = "0xA8C560", VA = "0x180A8D560")]
		[CompilerGenerated]
		readonly get
		{
			return default(JJNPBECHLFP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA8D540", Offset = "0xA8C540", VA = "0x180A8D540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MKPAOIDBPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x42B3E20", Offset = "0x42B2E20", VA = "0x1842B3E20")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5EF57E0", Offset = "0x5EF47E0", VA = "0x185EF57E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri LBJEMLJEAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EC0", Offset = "0x8D3EC0", VA = "0x1808D4EC0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA89A70", Offset = "0xA88A70", VA = "0x180A89A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri JLJPCAKKONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x72737B0", Offset = "0x72727B0", VA = "0x1872737B0")]
	public FKAFAPKJILG(Uri EOCCHLPDJOK, Uri KKEKKGGIIBK, JJNPBECHLFP MALICIMENAP = JJNPBECHLFP.None, bool NJNANHCLIGA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JJNPBECHLFP
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LFBNJIGDGPK
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
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE15F0", Offset = "0x1FE05F0", VA = "0x181FE15F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7274040", Offset = "0x7273040", VA = "0x187274040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7273E80", Offset = "0x7272E80", VA = "0x187273E80")]
		public string AHLIAMMJLAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7273F20", Offset = "0x7272F20", VA = "0x187273F20", Slot = "4")]
		public bool Equals(Route LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7273F90", Offset = "0x7272F90", VA = "0x187273F90", Slot = "5")]
		public bool Equals(Uri KHEDPODBCHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7273FF0", Offset = "0x7272FF0", VA = "0x187273FF0")]
		public AssetReference MKJNCBDMMML()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7274100", Offset = "0x7273100", VA = "0x187274100")]
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
					[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
			[DPOHCKPIABI("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7276760", Offset = "0x7275760", VA = "0x187276760")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IFKEPHJLBAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public IFKEPHJLBAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7273800", Offset = "0x7272800", VA = "0x187273800")]
			internal bool ONPGMNJFIFE(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KCLBPIAMLJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public KCLBPIAMLJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72738E0", Offset = "0x72728E0", VA = "0x1872738E0")]
			internal bool MPIJNOGIFFC(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CECNPGNENON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public KKBDEFJOIBO statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public CECNPGNENON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7273570", Offset = "0x7272570", VA = "0x187273570")]
			internal bool HDOJGOADHLI(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x7274EB0", Offset = "0x7273EB0", VA = "0x187274EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7274E20", Offset = "0x7273E20", VA = "0x187274E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7274130", Offset = "0x7273130", VA = "0x187274130")]
		private static void BGGINNGCCML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7274B70", Offset = "0x7273B70", VA = "0x187274B70")]
		public bool NIMCEBFGHOC(Uri KHEDPODBCHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7274520", Offset = "0x7273520", VA = "0x187274520")]
		public static bool CFEGLPMCDON(Route AFMILICDFOJ, [Out] RoutesConfig FBIEHKDBMEB, [Out] View ALHGCOOPFPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7274890", Offset = "0x7273890", VA = "0x187274890")]
		public static AssetReference MKJNCBDMMML(Route AFMILICDFOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7274D90", Offset = "0x7273D90", VA = "0x187274D90")]
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
		private sealed class NEMMONNFAMA
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
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public NEMMONNFAMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7273A20", Offset = "0x7272A20", VA = "0x187273A20")]
			internal bool LJAGEAFHHMC(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7273920", Offset = "0x7272920", VA = "0x187273920")]
			internal bool JIKBKAHIOLB(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x72766D0", Offset = "0x72756D0", VA = "0x1872766D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7276500", Offset = "0x7275500", VA = "0x187276500")]
		public Uri(Uri KHEDPODBCHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7276440", Offset = "0x7275440", VA = "0x187276440")]
		public Uri(params Route[] AFMILICDFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72765F0", Offset = "0x72755F0", VA = "0x1872765F0")]
		public Uri(IEnumerable<Route> AFMILICDFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7275B70", Offset = "0x7274B70", VA = "0x187275B70")]
		public bool PMELAKIMKGE(Route AFMILICDFOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7275AD0", Offset = "0x7274AD0", VA = "0x187275AD0")]
		public bool PMELAKIMKGE(IEnumerable<Route> MLABHJBJIGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7275BD0", Offset = "0x7274BD0", VA = "0x187275BD0")]
		public bool PMELAKIMKGE(Uri LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7275030", Offset = "0x7274030", VA = "0x187275030")]
		public static bool DFLAHLKBLGO(Uri KHEDPODBCHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7275180", Offset = "0x7274180", VA = "0x187275180")]
		public static bool EHCCFIAHGOE(Uri FAGKOOGCGBH, Uri HEOHCJKCOLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7275090", Offset = "0x7274090", VA = "0x187275090")]
		public bool EHCCFIAHGOE(Uri LJAAPFIIPOF, bool HONMHPJHJIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7275790", Offset = "0x7274790", VA = "0x187275790", Slot = "4")]
		public bool Equals(Uri LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7275450", Offset = "0x7274450", VA = "0x187275450")]
		public static bool EHCCFIAHGOE(Uri KHEDPODBCHI, Route AFMILICDFOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7275730", Offset = "0x7274730", VA = "0x187275730", Slot = "5")]
		public bool Equals(Route AFMILICDFOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x72755F0", Offset = "0x72745F0", VA = "0x1872755F0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7275810", Offset = "0x7274810", VA = "0x187275810", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7275A40", Offset = "0x7274A40", VA = "0x187275A40")]
		public string OOKJGDJLALC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7275F30", Offset = "0x7274F30", VA = "0x187275F30", Slot = "3")]
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
