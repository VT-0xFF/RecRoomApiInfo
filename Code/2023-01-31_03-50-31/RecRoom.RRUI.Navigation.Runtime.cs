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
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject DFNDAGDELMI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas KDDEDFGKDLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject DNHBAMJFGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x21ED310", Offset = "0x21EC110", VA = "0x1821ED310")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21ED520", Offset = "0x21EC320", VA = "0x1821ED520")]
		public void Initialize(GameObject NJLFDELBPNE, Transform ICMEPOIJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21ED640", Offset = "0x21EC440", VA = "0x1821ED640")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21ED510", Offset = "0x21EC310", VA = "0x1821ED510")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21ED3E0", Offset = "0x21EC1E0", VA = "0x1821ED3E0")]
		private void GDCGJPJNHCJ(bool EDJPNIOAEBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NMCNHONKOGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PageWrapper KCDCHOFOBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IReadOnlyList<EIKABDEIAPD> GEPIPJFCNJM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C40", Offset = "0x6B1A40", VA = "0x1806B2C40")]
	public NMCNHONKOGD(PageWrapper OFNFCEAJIIE, IReadOnlyList<EIKABDEIAPD> GOFKMMDPMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EIKABDEIAPD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GameObject NAAHLJGFEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCBLCAIHLNA OnBeforePageSwapFrom(Uri IJBMFPIHMGJ, CJAMNGJPJBI FEPBBMGBAMP, NMCNHONKOGD BOFMBHPCMIB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CCBLCAIHLNA OnBeforePageSwapTo(Uri IJBMFPIHMGJ, CJAMNGJPJBI FEPBBMGBAMP, NMCNHONKOGD JACJHENCNPB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CCBLCAIHLNA OnAfterPageSwapTo(Uri IJBMFPIHMGJ, CJAMNGJPJBI FEPBBMGBAMP, NMCNHONKOGD PFGIDKFGPHG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CCBLCAIHLNA OnShow(CJAMNGJPJBI FEPBBMGBAMP, NMCNHONKOGD HCPJABHFLNF, NMCNHONKOGD FLNBDDNMNAI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CCBLCAIHLNA OnHide(CJAMNGJPJBI FEPBBMGBAMP, NMCNHONKOGD HCPJABHFLNF, NMCNHONKOGD FLNBDDNMNAI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CJAMNGJPJBI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static CJAMNGJPJBI DCLACCPOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x21EC8A0", Offset = "0x21EB6A0", VA = "0x1821EC8A0")]
		[CompilerGenerated]
		get
		{
			return default(CJAMNGJPJBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HIGEJEEMPBP BEEBLEGAGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x91D790", Offset = "0x91C590", VA = "0x18091D790")]
		[CompilerGenerated]
		readonly get
		{
			return default(HIGEJEEMPBP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x91EFB0", Offset = "0x91DDB0", VA = "0x18091EFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ALJKOBPNDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCBEC70", Offset = "0xCBDA70", VA = "0x180CBEC70")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCBF000", Offset = "0xCBDE00", VA = "0x180CBF000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Uri JEGCMIJHPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x775520", Offset = "0x774320", VA = "0x180775520")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D90", Offset = "0x8B7B90", VA = "0x1808B8D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri AEALKMCMEOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x21EC910", Offset = "0x21EB710", VA = "0x1821EC910")]
	public CJAMNGJPJBI(Uri IOGHJGPIHLF, Uri AECCDBNPLMN, HIGEJEEMPBP FKLNJEGGGAE = HIGEJEEMPBP.None, bool LIBEILGIGLP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HIGEJEEMPBP
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GJBFLFECADF
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Pending
}
namespace RRUI.Navigation
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class Route : IEquatable<Route>, IEquatable<Uri>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private SerializedGuid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public SerializedGuid ViewGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9B4340", Offset = "0x9B3140", VA = "0x1809B4340", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x21ED7D0", Offset = "0x21EC5D0", VA = "0x1821ED7D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x21ED680", Offset = "0x21EC480", VA = "0x1821ED680", Slot = "4")]
		public bool Equals(Route KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x21ED750", Offset = "0x21EC550", VA = "0x1821ED750", Slot = "5")]
		public bool Equals(Uri IJBMFPIHMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x21ED770", Offset = "0x21EC570", VA = "0x1821ED770")]
		public AssetReference MKPFANFFNHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x21ED8A0", Offset = "0x21EC6A0", VA = "0x1821ED8A0")]
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
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				[SerializeField]
				private SerializedSplitTestExperimentSegment splitTestingSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public SerializedSplitTestExperimentSegment SplitTestingSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000031")]
					[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000032")]
					[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
				public SplitTestingVariant()
				{
				}
			}

			[Serializable]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public class StatsigVariant
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400001F")]
				[SerializeField]
				private SerializedStatsigExperimentSegment statsigSegment;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000020")]
				[SerializeField]
				[InspectorName("Prefab Reference")]
				private AssetReference prefabReference;

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public SerializedStatsigExperimentSegment StatsigSegment
				{
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
				public StatsigVariant()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			[SerializeField]
			private SerializedGuid guid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[SerializeField]
			private string friendlyName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[SerializeField]
			private AssetReference prefabReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			[SerializeField]
			[IOMFOKFOBBB("SplitTestingSegment")]
			private SplitTestingVariant[] splitTestingVariants;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[SerializeField]
			[IOMFOKFOBBB("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public IReadOnlyList<SplitTestingVariant> SplitTestingVariants
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x21F0070", Offset = "0x21EEE70", VA = "0x1821F0070")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OPFIACMGKDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public OPFIACMGKDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x21ED220", Offset = "0x21EC020", VA = "0x1821ED220")]
			internal bool <ContainsUri>b__0(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class EAIEJCCFNMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public EAIEJCCFNMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x21EC960", Offset = "0x21EB760", VA = "0x1821EC960")]
			internal bool <ContainsUri>b__1(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly string ResourcesRoutesDirectoryPath;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly string FullRoutesDirectoryPath;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static List<RoutesConfig> _configs;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static Dictionary<Guid, View> _viewMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private List<View> views;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool _isInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x21EE6F0", Offset = "0x21ED4F0", VA = "0x1821EE6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x21EE640", Offset = "0x21ED440", VA = "0x1821EE640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x21EDDC0", Offset = "0x21ECBC0", VA = "0x1821EDDC0")]
		private static void NAGCBALDEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x21ED8D0", Offset = "0x21EC6D0", VA = "0x1821ED8D0")]
		public bool JKCDIEMHKJB(Uri IJBMFPIHMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x21EE120", Offset = "0x21ECF20", VA = "0x1821EE120")]
		public static bool PNKAINEEIJJ(Route MJNBBIFMFAE, out RoutesConfig HJNIEBGLFKE, out View AIBPHFDAGDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x21ED9D0", Offset = "0x21EC7D0", VA = "0x1821ED9D0")]
		public static AssetReference MKPFANFFNHP(Route MJNBBIFMFAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x21EE5C0", Offset = "0x21ED3C0", VA = "0x1821EE5C0")]
		public RoutesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class Uri : IEquatable<Uri>, IEquatable<Route>
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class MOJACBMBGBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IReadOnlyList<Route> bRoute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Uri b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Uri a;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
			public MOJACBMBGBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x21ECFD0", Offset = "0x21EBDD0", VA = "0x1821ECFD0")]
			internal bool <Equals>b__0(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x21ED120", Offset = "0x21EBF20", VA = "0x1821ED120")]
			internal bool <Equals>b__1(string k)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private List<Route> route;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Dictionary<string, object> data;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x21EFFF0", Offset = "0x21EEDF0", VA = "0x1821EFFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x21EFE40", Offset = "0x21EEC40", VA = "0x1821EFE40")]
		public Uri(Uri IJBMFPIHMGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x21EFD90", Offset = "0x21EEB90", VA = "0x1821EFD90")]
		public Uri(params Route[] MJNBBIFMFAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x21EFF20", Offset = "0x21EED20", VA = "0x1821EFF20")]
		public Uri(IEnumerable<Route> MJNBBIFMFAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x21EEE10", Offset = "0x21EDC10", VA = "0x1821EEE10")]
		public bool HGEFFBLNLHD(Route MJNBBIFMFAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x21EEE70", Offset = "0x21EDC70", VA = "0x1821EEE70")]
		public bool HGEFFBLNLHD(IEnumerable<Route> OFBAIAALDEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x21EEF20", Offset = "0x21EDD20", VA = "0x1821EEF20")]
		public bool HGEFFBLNLHD(Uri KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x21EF350", Offset = "0x21EE150", VA = "0x1821EF350")]
		public static bool NOHLHLNDIHM(Uri NCNGLFNLPAG, Uri OPGAGDBKIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x21EF7C0", Offset = "0x21EE5C0", VA = "0x1821EF7C0")]
		public bool NOHLHLNDIHM(Uri KICLNADFIEK, bool FMELINKGPKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x21EEB40", Offset = "0x21ED940", VA = "0x1821EEB40", Slot = "4")]
		public bool Equals(Uri KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x21EF640", Offset = "0x21EE440", VA = "0x1821EF640")]
		public static bool NOHLHLNDIHM(Uri IJBMFPIHMGJ, Route MJNBBIFMFAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x21EEB30", Offset = "0x21ED930", VA = "0x1821EEB30", Slot = "5")]
		public bool Equals(Route MJNBBIFMFAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x21EEB60", Offset = "0x21ED960", VA = "0x1821EEB60", Slot = "0")]
		public override bool Equals(object GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x21EEC70", Offset = "0x21EDA70", VA = "0x1821EEC70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x21EF2E0", Offset = "0x21EE0E0", VA = "0x1821EF2E0")]
		public string MAAPGMIOPKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x21EF880", Offset = "0x21EE680", VA = "0x1821EF880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x21ECCF0", Offset = "0x21EBAF0", VA = "0x1821ECCF0")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x21EC9A0", Offset = "0x21EB7A0", VA = "0x1821EC9A0")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
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
