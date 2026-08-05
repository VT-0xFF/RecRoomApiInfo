using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RRUI;
using RRUI.Navigation;
using RecRoom.Analytics.SplitTesting;
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
		[IDDCODEHLBF(HLAHMBHIFJM.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[IDDCODEHLBF(HLAHMBHIFJM.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject LIHCANLOEGB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas CGAMACJGINI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject ICFOFOEKJFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x19EA260", Offset = "0x19E9660", VA = "0x1819EA260")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route GJNOBNCNKHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x19EA130", Offset = "0x19E9530", VA = "0x1819EA130")]
		public void Initialize(GameObject BBLAPDGAFKJ, Transform CNDFBGEJOLI, Route ANBECLHDDBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x19EA330", Offset = "0x19E9730", VA = "0x1819EA330")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x19EA120", Offset = "0x19E9520", VA = "0x1819EA120")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x19E9FF0", Offset = "0x19E93F0", VA = "0x1819E9FF0")]
		private void GHIFLNEDHPF(bool MDFMFDKFGLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x782BC0", Offset = "0x781FC0", VA = "0x180782BC0")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GCADCAKNNLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper JLGPNALDBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<KCHEHPLLPFM> CLECCLAMMML;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x77E010", Offset = "0x77D410", VA = "0x18077E010")]
	public GCADCAKNNLA(PageWrapper JPFJLDEOPJL, IReadOnlyList<KCHEHPLLPFM> CKGGHEALKLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KCHEHPLLPFM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject BNDGKEGJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NDNJBANLHJC OnBeforePageSwapFrom(Uri GJGBCPGPHJL, FACJDDIKADG NOENCABPBHG, GCADCAKNNLA HHEHNOPGKMJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NDNJBANLHJC OnBeforePageSwapTo(Uri GJGBCPGPHJL, FACJDDIKADG NOENCABPBHG, GCADCAKNNLA LGHGGHHPLHM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NDNJBANLHJC OnAfterPageSwapTo(Uri GJGBCPGPHJL, FACJDDIKADG NOENCABPBHG, GCADCAKNNLA LBACIEJLGPP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NDNJBANLHJC OnShow(FACJDDIKADG NOENCABPBHG, GCADCAKNNLA GHILDCLCCBH, GCADCAKNNLA AILKDFCOODD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NDNJBANLHJC OnHide(FACJDDIKADG NOENCABPBHG, GCADCAKNNLA GHILDCLCCBH, GCADCAKNNLA AILKDFCOODD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FACJDDIKADG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static FACJDDIKADG OKLBJLNFLNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x19E9BB0", Offset = "0x19E8FB0", VA = "0x1819E9BB0")]
		[CompilerGenerated]
		get
		{
			return default(FACJDDIKADG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KPCINEFPLNG CJEBAEJJNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660")]
		[CompilerGenerated]
		readonly get
		{
			return default(KPCINEFPLNG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FKBPEKLCPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9E4090", Offset = "0x9E3490", VA = "0x1809E4090")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9E4450", Offset = "0x9E3850", VA = "0x1809E4450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri CDIEAFDCCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x780910", Offset = "0x77FD10", VA = "0x180780910")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7809D0", Offset = "0x77FDD0", VA = "0x1807809D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri MIONJGGEOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x19E9C20", Offset = "0x19E9020", VA = "0x1819E9C20")]
	public FACJDDIKADG(Uri PKCLGAMOJON, Uri LHFKPJCDKGO, KPCINEFPLNG KLBECFKEFFM = KPCINEFPLNG.None, bool MGPFHJDDHFL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KPCINEFPLNG
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KMHADOGJOMM
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
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD780", Offset = "0x8ACB80", VA = "0x1808AD780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x19EA510", Offset = "0x19E9910", VA = "0x1819EA510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x19EA3D0", Offset = "0x19E97D0", VA = "0x1819EA3D0", Slot = "4")]
		public bool Equals(Route FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x19EA4A0", Offset = "0x19E98A0", VA = "0x1819EA4A0", Slot = "5")]
		public bool Equals(Uri GJGBCPGPHJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x19EA370", Offset = "0x19E9770", VA = "0x1819EA370")]
		public AssetReference DNJCBJGNDKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x19EA5E0", Offset = "0x19E99E0", VA = "0x1819EA5E0")]
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
			public class SplitTestingVariant
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				[SerializeField]
				private SerializedSplitTestExperimentSegment splitTestingSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public SerializedSplitTestExperimentSegment SplitTestingSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
				public SplitTestingVariant()
				{
				}
			}

			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public class StatsigVariant
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				[SerializeField]
				private SerializedStatsigExperimentSegment statsigSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public SerializedStatsigExperimentSegment StatsigSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000036")]
					[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000037")]
					[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
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
			[CPABMNKOEBK("SplitTestingSegment")]
			private SplitTestingVariant[] splitTestingVariants;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			[SerializeField]
			[CPABMNKOEBK("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<SplitTestingVariant> SplitTestingVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x19ECE60", Offset = "0x19EC260", VA = "0x1819ECE60")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PDJNIBGBAPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public PDJNIBGBAPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x19E9F00", Offset = "0x19E9300", VA = "0x1819E9F00")]
			internal bool <ContainsUri>b__0(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GPOBGLCBKJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public GPOBGLCBKJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x19E9EC0", Offset = "0x19E92C0", VA = "0x1819E9EC0")]
			internal bool <ContainsUri>b__1(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BLMHOOAHDHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public GGEKGDKECIA statsig;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public BLMHOOAHDHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x19E9A80", Offset = "0x19E8E80", VA = "0x1819E9A80")]
			internal bool <GetPrefabReference>b__1(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x19EB460", Offset = "0x19EA860", VA = "0x1819EB460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x19EB3B0", Offset = "0x19EA7B0", VA = "0x1819EB3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x19EAB30", Offset = "0x19E9F30", VA = "0x1819EAB30")]
		private static void NPFGFFCDMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x19EAA30", Offset = "0x19E9E30", VA = "0x1819EAA30")]
		public bool GFFLMHDFFOH(Uri GJGBCPGPHJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x19EAE90", Offset = "0x19EA290", VA = "0x1819EAE90")]
		public static bool PFNNCNICCAE(Route ANBECLHDDBE, out RoutesConfig AHMBDOEOLFP, out View JDJMBDOCNCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x19EA610", Offset = "0x19E9A10", VA = "0x1819EA610")]
		public static AssetReference DNJCBJGNDKB(Route ANBECLHDDBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x19EB330", Offset = "0x19EA730", VA = "0x1819EB330")]
		public RoutesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Uri : IEquatable<Uri>, IEquatable<Route>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FDHFNNLJHDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public IReadOnlyList<Route> bRoute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Uri b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Uri a;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public FDHFNNLJHDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x19E9C70", Offset = "0x19E9070", VA = "0x1819E9C70")]
			internal bool <Equals>b__0(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x19E9DC0", Offset = "0x19E91C0", VA = "0x1819E9DC0")]
			internal bool <Equals>b__1(string k)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly string nullRouteString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private List<Route> route;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Dictionary<string, object> data;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x19ECDE0", Offset = "0x19EC1E0", VA = "0x1819ECDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x19ECC30", Offset = "0x19EC030", VA = "0x1819ECC30")]
		public Uri(Uri GJGBCPGPHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x19ECB80", Offset = "0x19EBF80", VA = "0x1819ECB80")]
		public Uri(params Route[] ANBECLHDDBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x19ECD10", Offset = "0x19EC110", VA = "0x1819ECD10")]
		public Uri(IEnumerable<Route> ANBECLHDDBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x19EBB10", Offset = "0x19EAF10", VA = "0x1819EBB10")]
		public bool AGHBGCOAOGM(Route ANBECLHDDBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x19EBB70", Offset = "0x19EAF70", VA = "0x1819EBB70")]
		public bool AGHBGCOAOGM(IEnumerable<Route> OADOIOKCIAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x19EB750", Offset = "0x19EAB50", VA = "0x1819EB750")]
		public bool AGHBGCOAOGM(Uri FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x19EBFD0", Offset = "0x19EB3D0", VA = "0x1819EBFD0")]
		public static bool LNPLILOIFFP(Uri KEPOHMNFLGL, Uri CFEKEMJOJGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x19EC460", Offset = "0x19EB860", VA = "0x1819EC460")]
		public bool LNPLILOIFFP(Uri FJLHJLAMLMA, bool JCBJEIKACON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x19EBC90", Offset = "0x19EB090", VA = "0x1819EBC90", Slot = "4")]
		public bool Equals(Uri FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x19EC2C0", Offset = "0x19EB6C0", VA = "0x1819EC2C0")]
		public static bool LNPLILOIFFP(Uri GJGBCPGPHJL, Route ANBECLHDDBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x19EBC20", Offset = "0x19EB020", VA = "0x1819EBC20", Slot = "5")]
		public bool Equals(Route ANBECLHDDBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x19EBD20", Offset = "0x19EB120", VA = "0x1819EBD20", Slot = "0")]
		public override bool Equals(object JGHFLANLLNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x19EBE30", Offset = "0x19EB230", VA = "0x1819EBE30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x19EC560", Offset = "0x19EB960", VA = "0x1819EC560")]
		public string MMKFIMNINJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x19EC600", Offset = "0x19EBA00", VA = "0x1819EC600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x19E97A0", Offset = "0x19E8BA0", VA = "0x1819E97A0")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x19E9450", Offset = "0x19E8850", VA = "0x1819E9450")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
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
