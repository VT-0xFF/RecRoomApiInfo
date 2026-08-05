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
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject BMMKENHDBPF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas NNAEBMGNMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject OFFMAGHCLOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7757670", Offset = "0x7756070", VA = "0x187757670")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route CHLKPMANEMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7757750", Offset = "0x7756150", VA = "0x187757750")]
		public void Initialize(GameObject HNCAEJNFHND, Transform NNFBEGDDJKL, Route OPBHKKKKJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7757990", Offset = "0x7756390", VA = "0x187757990")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7757740", Offset = "0x7756140", VA = "0x187757740")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7757880", Offset = "0x7756280", VA = "0x187757880")]
		private void JNEOJKJPKPK(bool MCECKOBNPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GHECLHHPGED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper HHKIHEOCCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<PAMIMAECMIL> NIMPIILDPOK;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0D0", Offset = "0x8B9AD0", VA = "0x1808BB0D0")]
	public GHECLHHPGED(PageWrapper KIKJBFOJGOE, IReadOnlyList<PAMIMAECMIL> MKDGCEGGCME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PAMIMAECMIL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject LCAKBKAANHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HGKKEBPLLAP OnBeforePageSwapFrom(Uri MCFKOOPMEJG, CPIEDHOIIMF NMAECNIBAJC, GHECLHHPGED GPMHLDFBAFM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HGKKEBPLLAP OnBeforePageSwapTo(Uri MCFKOOPMEJG, CPIEDHOIIMF NMAECNIBAJC, GHECLHHPGED HPPHDLBKIEO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HGKKEBPLLAP OnAfterPageSwapTo(Uri MCFKOOPMEJG, CPIEDHOIIMF NMAECNIBAJC, GHECLHHPGED BOGFDCCGEOE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HGKKEBPLLAP OnShow(CPIEDHOIIMF NMAECNIBAJC, GHECLHHPGED BLPGBAEOIOP, GHECLHHPGED BBEJBLPIPGJ);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HGKKEBPLLAP OnHide(CPIEDHOIIMF NMAECNIBAJC, GHECLHHPGED BLPGBAEOIOP, GHECLHHPGED BBEJBLPIPGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CPIEDHOIIMF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static CPIEDHOIIMF JCFGJMCEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7757020", Offset = "0x7755A20", VA = "0x187757020")]
		[CompilerGenerated]
		get
		{
			return default(CPIEDHOIIMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HCIDJIGECKH DOEJBJHPPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700")]
		[CompilerGenerated]
		readonly get
		{
			return default(HCIDJIGECKH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC9FF70", Offset = "0xC9E970", VA = "0x180C9FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BBHJJCNGLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC9FF80", Offset = "0xC9E980", VA = "0x180C9FF80")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xC9FFA0", Offset = "0xC9E9A0", VA = "0x180C9FFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri INBHFADHICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9577A0", Offset = "0x9561A0", VA = "0x1809577A0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9578D0", Offset = "0x9562D0", VA = "0x1809578D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri HGKNMDKFFBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD970", Offset = "0x8AC370", VA = "0x1808AD970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7757070", Offset = "0x7755A70", VA = "0x187757070")]
	public CPIEDHOIIMF(Uri IAEIGHPPABJ, Uri HLOOFOCMMPM, HCIDJIGECKH PIMCEEAOIFA = HCIDJIGECKH.None, bool LAHOOAPMEIJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HCIDJIGECKH
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NLMHPGLEOFO
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
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x22B6E00", Offset = "0x22B5800", VA = "0x1822B6E00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7757B90", Offset = "0x7756590", VA = "0x187757B90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7757AA0", Offset = "0x77564A0", VA = "0x187757AA0")]
		public string LODKKEJHBBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77579D0", Offset = "0x77563D0", VA = "0x1877579D0", Slot = "4")]
		public bool Equals(Route GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7757A40", Offset = "0x7756440", VA = "0x187757A40", Slot = "5")]
		public bool Equals(Uri MCFKOOPMEJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7757B40", Offset = "0x7756540", VA = "0x187757B40")]
		public AssetReference MMGAIIEOPCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7757C50", Offset = "0x7756650", VA = "0x187757C50")]
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
					[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
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
			[CMNAHKLNBBK("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x775A330", Offset = "0x7758D30", VA = "0x18775A330")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EJLDDEKDOCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public EJLDDEKDOCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x77570C0", Offset = "0x7755AC0", VA = "0x1877570C0")]
			internal bool LGNHDIJJIFA(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ANEBHPIMACL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public ANEBHPIMACL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7756FE0", Offset = "0x77559E0", VA = "0x187756FE0")]
			internal bool FBHHFMPGEDN(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class OKPALEOFANI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public NBJKPJCPFJP statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public OKPALEOFANI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x77573A0", Offset = "0x7755DA0", VA = "0x1877573A0")]
			internal bool DCAIOBMAEDJ(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x77589D0", Offset = "0x77573D0", VA = "0x1877589D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7758940", Offset = "0x7757340", VA = "0x187758940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7757FF0", Offset = "0x77569F0", VA = "0x187757FF0")]
		private static void GCHKJEOLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x77583C0", Offset = "0x7756DC0", VA = "0x1877583C0")]
		public bool MKIACNEMJGO(Uri MCFKOOPMEJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7757C80", Offset = "0x7756680", VA = "0x187757C80")]
		public static bool CMPLCNPDOPL(Route OPBHKKKKJEF, [Out] RoutesConfig JHBDCPPKFFM, [Out] View CNIBHAFDEIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x77584C0", Offset = "0x7756EC0", VA = "0x1877584C0")]
		public static AssetReference MMGAIIEOPCI(Route OPBHKKKKJEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x77588B0", Offset = "0x77572B0", VA = "0x1877588B0")]
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
		private sealed class KHOJDALJIPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public IReadOnlyList<Route> bRoute;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Uri b;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public Uri a;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public KHOJDALJIPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x77571A0", Offset = "0x7755BA0", VA = "0x1877571A0")]
			internal bool OEHNEBCDONG(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x77572A0", Offset = "0x7755CA0", VA = "0x1877572A0")]
			internal bool PBFLCHNMIJD(string k)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly string nullRouteString;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static bool CacheRouteStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private List<Route> route;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Dictionary<string, object> data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private string cachedRouteString;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<Route> Route
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x775A2A0", Offset = "0x7758CA0", VA = "0x18775A2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x775A0D0", Offset = "0x7758AD0", VA = "0x18775A0D0")]
		public Uri(Uri MCFKOOPMEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x775A010", Offset = "0x7758A10", VA = "0x18775A010")]
		public Uri(params Route[] OPBHKKKKJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x775A1C0", Offset = "0x7758BC0", VA = "0x18775A1C0")]
		public Uri(IEnumerable<Route> OPBHKKKKJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7759A50", Offset = "0x7758450", VA = "0x187759A50")]
		public bool OIBNNKGDJBI(Route OPBHKKKKJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7759650", Offset = "0x7758050", VA = "0x187759650")]
		public bool OIBNNKGDJBI(IEnumerable<Route> KOGIHDKBHBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77596F0", Offset = "0x77580F0", VA = "0x1877596F0")]
		public bool OIBNNKGDJBI(Uri GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7758B30", Offset = "0x7757530", VA = "0x187758B30")]
		public static bool EFLKLBKLPDG(Uri MCFKOOPMEJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7759380", Offset = "0x7757D80", VA = "0x187759380")]
		public static bool LLKODAGINCO(Uri PEMPEACEHBG, Uri FDDPOELCNDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77590F0", Offset = "0x7757AF0", VA = "0x1877590F0")]
		public bool LLKODAGINCO(Uri GDOGPMPJPOO, bool LHPAMADDDME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7758D30", Offset = "0x7757730", VA = "0x187758D30", Slot = "4")]
		public bool Equals(Uri GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x77591E0", Offset = "0x7757BE0", VA = "0x1877591E0")]
		public static bool LLKODAGINCO(Uri MCFKOOPMEJG, Route OPBHKKKKJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7758CD0", Offset = "0x77576D0", VA = "0x187758CD0", Slot = "5")]
		public bool Equals(Route OPBHKKKKJEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7758B90", Offset = "0x7757590", VA = "0x187758B90", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7758DB0", Offset = "0x77577B0", VA = "0x187758DB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7758FE0", Offset = "0x77579E0", VA = "0x187758FE0")]
		public string LGCJDCAAMIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7759AB0", Offset = "0x77584B0", VA = "0x187759AB0", Slot = "3")]
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
