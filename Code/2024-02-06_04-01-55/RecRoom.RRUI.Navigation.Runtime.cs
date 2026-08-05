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
		[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject GHMIEKOABNL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas CIHEMBOEEKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject OPPFGGDENLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6786490", Offset = "0x6785890", VA = "0x186786490")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route ADGHNAGPDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6786680", Offset = "0x6785A80", VA = "0x186786680")]
		public void Initialize(GameObject FAIMAILCGNO, Transform EMDODFFCGEF, Route HNCBLAPBGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67867B0", Offset = "0x6785BB0", VA = "0x1867867B0")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6786670", Offset = "0x6785A70", VA = "0x186786670")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6786560", Offset = "0x6785960", VA = "0x186786560")]
		private void DLMPELMEIKH(bool ONPLKNPLPLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OIJCHAJDNDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper EIDINBNNHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<DGPFDFIGGGM> CPMPJGDCJHF;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A4380", Offset = "0x7A3780", VA = "0x1807A4380")]
	public OIJCHAJDNDO(PageWrapper BMJPJKLDENF, IReadOnlyList<DGPFDFIGGGM> BILCIBIJCIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DGPFDFIGGGM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject LDBFPEKLENK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIJBCHKFBNI OnBeforePageSwapFrom(Uri HCEDJLJKNEP, NOJIOFKICNL NDGLIPKKMHI, OIJCHAJDNDO DACOLKHFHDG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IIJBCHKFBNI OnBeforePageSwapTo(Uri HCEDJLJKNEP, NOJIOFKICNL NDGLIPKKMHI, OIJCHAJDNDO EHLAAGAINJL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IIJBCHKFBNI OnAfterPageSwapTo(Uri HCEDJLJKNEP, NOJIOFKICNL NDGLIPKKMHI, OIJCHAJDNDO OPJGJPAAJHF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IIJBCHKFBNI OnShow(NOJIOFKICNL NDGLIPKKMHI, OIJCHAJDNDO ICPOAEEDFIC, OIJCHAJDNDO NHFMKDPIHND);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IIJBCHKFBNI OnHide(NOJIOFKICNL NDGLIPKKMHI, OIJCHAJDNDO ICPOAEEDFIC, OIJCHAJDNDO NHFMKDPIHND);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NOJIOFKICNL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static NOJIOFKICNL JPDBNDFGACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x67863B0", Offset = "0x67857B0", VA = "0x1867863B0")]
		[CompilerGenerated]
		get
		{
			return default(NOJIOFKICNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BGLGOJLBFMF KGJIHEGHNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		[CompilerGenerated]
		readonly get
		{
			return default(BGLGOJLBFMF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool COJNFCMMCMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3B48AE0", Offset = "0x3B47EE0", VA = "0x183B48AE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x569AAC0", Offset = "0x5699EC0", VA = "0x18569AAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri MEEIPPGLIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x885AD0", Offset = "0x884ED0", VA = "0x180885AD0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA59EA0", Offset = "0xA592A0", VA = "0x180A59EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri NGJOEJHIMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6786400", Offset = "0x6785800", VA = "0x186786400")]
	public NOJIOFKICNL(Uri FMLALKAEMFK, Uri EEIAJGEHFME, BGLGOJLBFMF MPGNBPOAMLK = BGLGOJLBFMF.None, bool LDDGBMOILJL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BGLGOJLBFMF
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GHOCJHAIDFJ
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
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1D4FD70", Offset = "0x1D4F170", VA = "0x181D4FD70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67869B0", Offset = "0x6785DB0", VA = "0x1867869B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67868C0", Offset = "0x6785CC0", VA = "0x1867868C0")]
		public string GKAFFCGNCLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67867F0", Offset = "0x6785BF0", VA = "0x1867867F0", Slot = "4")]
		public bool Equals(Route KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6786860", Offset = "0x6785C60", VA = "0x186786860", Slot = "5")]
		public bool Equals(Uri HCEDJLJKNEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6786960", Offset = "0x6785D60", VA = "0x186786960")]
		public AssetReference IDKCMCHAJMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6786A70", Offset = "0x6785E70", VA = "0x186786A70")]
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
					[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
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
			[GOJMKEJNCOC("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x67890D0", Offset = "0x67884D0", VA = "0x1867890D0")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IGCHOEPHDMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public IGCHOEPHDMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x67862D0", Offset = "0x67856D0", VA = "0x1867862D0")]
			internal bool PHMDJLEBNLF(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class POIMPJCOOEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public POIMPJCOOEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6786450", Offset = "0x6785850", VA = "0x186786450")]
			internal bool FLPMKKDHIGJ(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GOAMDLBMHLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public HNMDOIFKIPI statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public GOAMDLBMHLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6785FA0", Offset = "0x67853A0", VA = "0x186785FA0")]
			internal bool MFJGENDABDP(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x6787820", Offset = "0x6786C20", VA = "0x186787820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6787790", Offset = "0x6786B90", VA = "0x186787790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6786E80", Offset = "0x6786280", VA = "0x186786E80")]
		private static void OBMDJKKOMOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6786D80", Offset = "0x6786180", VA = "0x186786D80")]
		public bool NMHDDIMPKPN(Uri HCEDJLJKNEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6787270", Offset = "0x6786670", VA = "0x186787270")]
		public static bool PBINKPPDLMH(Route HNCBLAPBGIP, [Out] RoutesConfig GKMDBGKKFNE, [Out] View PGGDDBLBKMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6786AA0", Offset = "0x6785EA0", VA = "0x186786AA0")]
		public static AssetReference IDKCMCHAJMP(Route HNCBLAPBGIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6787700", Offset = "0x6786B00", VA = "0x186787700")]
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
		private sealed class HGPDHGDNHBK
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
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public HGPDHGDNHBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67860D0", Offset = "0x67854D0", VA = "0x1867860D0")]
			internal bool AKAKDIODFIO(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x67861D0", Offset = "0x67855D0", VA = "0x1867861D0")]
			internal bool MMMLIGHJPKO(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6789040", Offset = "0x6788440", VA = "0x186789040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6788E70", Offset = "0x6788270", VA = "0x186788E70")]
		public Uri(Uri HCEDJLJKNEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6788DB0", Offset = "0x67881B0", VA = "0x186788DB0")]
		public Uri(params Route[] HNCBLAPBGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6788F60", Offset = "0x6788360", VA = "0x186788F60")]
		public Uri(IEnumerable<Route> HNCBLAPBGIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67883E0", Offset = "0x67877E0", VA = "0x1867883E0")]
		public bool JKHAEKACGLL(Route HNCBLAPBGIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6788440", Offset = "0x6787840", VA = "0x186788440")]
		public bool JKHAEKACGLL(IEnumerable<Route> CJMGPGFFMPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x67884E0", Offset = "0x67878E0", VA = "0x1867884E0")]
		public bool JKHAEKACGLL(Uri KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6788840", Offset = "0x6787C40", VA = "0x186788840")]
		public static bool PFEHLHJGPIL(Uri HCEDJLJKNEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6787D40", Offset = "0x6787140", VA = "0x186787D40")]
		public static bool FFGLIIKNBON(Uri KHCOFGFJDMP, Uri NFAPJGNODPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6787C50", Offset = "0x6787050", VA = "0x186787C50")]
		public bool FFGLIIKNBON(Uri KMJGEHGGFFC, bool KAIEHLFFOHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6787BD0", Offset = "0x6786FD0", VA = "0x186787BD0", Slot = "4")]
		public bool Equals(Uri KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6788010", Offset = "0x6787410", VA = "0x186788010")]
		public static bool FFGLIIKNBON(Uri HCEDJLJKNEP, Route HNCBLAPBGIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6787B70", Offset = "0x6786F70", VA = "0x186787B70", Slot = "5")]
		public bool Equals(Route HNCBLAPBGIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6787A30", Offset = "0x6786E30", VA = "0x186787A30", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x67881B0", Offset = "0x67875B0", VA = "0x1867881B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x67879A0", Offset = "0x6786DA0", VA = "0x1867879A0")]
		public string AGKIPKONMMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67888A0", Offset = "0x6787CA0", VA = "0x1867888A0", Slot = "3")]
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
