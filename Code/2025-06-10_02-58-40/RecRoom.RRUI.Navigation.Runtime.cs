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
	public class PageWrapper : MonoBehaviour, DFMMPFEMCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject BBKNOFILFAJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas JDDIIGEPOML
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject FGGBIMHFAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8731FE0", Offset = "0x87311E0", VA = "0x188731FE0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route KOILLPIPAEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87321D0", Offset = "0x87313D0", VA = "0x1887321D0")]
		public void Initialize(GameObject GGPCLAPMNBA, Transform FLKKOCNDECC, Route ACNLMOPEGLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8732300", Offset = "0x8731500", VA = "0x188732300")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87320B0", Offset = "0x87312B0", VA = "0x1887320B0")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87320C0", Offset = "0x87312C0", VA = "0x1887320C0")]
		private void IKGJDDLBNPO(bool DMHGIJPNHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x15F80F0", Offset = "0x15F72F0", VA = "0x1815F80F0", Slot = "4")]
		public HLHAADFELHC Collect()
		{
			return default(HLHAADFELHC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BIMHEGOAFCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper PMLDOFMBCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<GMDEDOBLNMJ> PPLIJBHHEAG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA058E0", Offset = "0xA04AE0", VA = "0x180A058E0")]
	public BIMHEGOAFCM(PageWrapper LKFCDKLDDPI, IReadOnlyList<GMDEDOBLNMJ> FBDJNNFBBAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GMDEDOBLNMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject DEOJDBDDHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IFBEDABPFIF OnBeforePageSwapFrom(Uri LPHBKABPDPO, BBIMJCMJBEK ALLIBLOLGHD, BIMHEGOAFCM DDFHOGPPBBA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IFBEDABPFIF OnBeforePageSwapTo(Uri LPHBKABPDPO, BBIMJCMJBEK ALLIBLOLGHD, BIMHEGOAFCM CPGBCBEIIHK);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IFBEDABPFIF OnAfterPageSwapTo(Uri LPHBKABPDPO, BBIMJCMJBEK ALLIBLOLGHD, BIMHEGOAFCM ALALGCLOCNA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IFBEDABPFIF OnShow(BBIMJCMJBEK ALLIBLOLGHD, BIMHEGOAFCM MBPGPIHMEOA, BIMHEGOAFCM DGHBBBJLDOM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IFBEDABPFIF OnHide(BBIMJCMJBEK ALLIBLOLGHD, BIMHEGOAFCM MBPGPIHMEOA, BIMHEGOAFCM DGHBBBJLDOM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BBIMJCMJBEK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static BBIMJCMJBEK LGHIFDBIJOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8731950", Offset = "0x8730B50", VA = "0x188731950")]
		[CompilerGenerated]
		get
		{
			return default(BBIMJCMJBEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HPOCLBGGBDN JCIEJCAEOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBB1DE0", Offset = "0xBB0FE0", VA = "0x180BB1DE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(HPOCLBGGBDN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1399440", Offset = "0x1398640", VA = "0x181399440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BNLCPCCHLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51CF3F0", Offset = "0x51CE5F0", VA = "0x1851CF3F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FE70A0", Offset = "0x6FE62A0", VA = "0x186FE70A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri EPENFOJPMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xDFAF60", Offset = "0xDFA160", VA = "0x180DFAF60")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xDFAF70", Offset = "0xDFA170", VA = "0x180DFAF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri JCPMLMNFIGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x87319A0", Offset = "0x8730BA0", VA = "0x1887319A0")]
	public BBIMJCMJBEK(Uri LGKPABBBCFK, Uri ADKPMNMPEOF, HPOCLBGGBDN ILDDCDOJNCH = HPOCLBGGBDN.None, bool JBAIABNCIIP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HPOCLBGGBDN
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KLJKMGBPMBO
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
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28C9840", Offset = "0x28C8A40", VA = "0x1828C9840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8732500", Offset = "0x8731700", VA = "0x188732500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8732410", Offset = "0x8731610", VA = "0x188732410")]
		public string LFPMHPBCBMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8732340", Offset = "0x8731540", VA = "0x188732340", Slot = "4")]
		public bool Equals(Route CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x87323B0", Offset = "0x87315B0", VA = "0x1887323B0", Slot = "5")]
		public bool Equals(Uri LPHBKABPDPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87324B0", Offset = "0x87316B0", VA = "0x1887324B0")]
		public AssetReference MKHDMDNCPDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x87325C0", Offset = "0x87317C0", VA = "0x1887325C0")]
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
					[Cpp2IlInjected.Token(Token = "0x6000034")]
					[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000035")]
					[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
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
			[CKPFOJOACME("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8734E90", Offset = "0x8734090", VA = "0x188734E90")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class PDNHHAGBOOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public PDNHHAGBOOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8731F00", Offset = "0x8731100", VA = "0x188731F00")]
			internal bool ACOGHKCBBHO(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LDEGOHBNGBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public LDEGOHBNGBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8731BF0", Offset = "0x8730DF0", VA = "0x188731BF0")]
			internal bool GBOFBFLCLJJ(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MPEIIKDBHKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public ABCAKKCKJPM statsig;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public MPEIIKDBHKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8731C30", Offset = "0x8730E30", VA = "0x188731C30")]
			internal bool ICKJDPEPABL(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8733340", Offset = "0x8732540", VA = "0x188733340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x87332B0", Offset = "0x87324B0", VA = "0x1887332B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x87325F0", Offset = "0x87317F0", VA = "0x1887325F0")]
		private static void AFLILFPIJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87329C0", Offset = "0x8731BC0", VA = "0x1887329C0")]
		public bool DODMOLPAJHH(Uri LPHBKABPDPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8732DB0", Offset = "0x8731FB0", VA = "0x188732DB0")]
		public static bool OOIOHIONPBH(Route ACNLMOPEGLN, [Out] RoutesConfig LPLPACKNDCK, [Out] View NHPFBIKJIIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8732AC0", Offset = "0x8731CC0", VA = "0x188732AC0")]
		public static AssetReference MKHDMDNCPDO(Route ACNLMOPEGLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8733220", Offset = "0x8732420", VA = "0x188733220")]
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
		private sealed class CKNGFPEHCCO
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

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public CKNGFPEHCCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x87319F0", Offset = "0x8730BF0", VA = "0x1887319F0")]
			internal bool CCACIBKABGM(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8731AF0", Offset = "0x8730CF0", VA = "0x188731AF0")]
			internal bool CGFBGFCNHEI(string k)
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
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8734E00", Offset = "0x8734000", VA = "0x188734E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8734C30", Offset = "0x8733E30", VA = "0x188734C30")]
		public Uri(Uri LPHBKABPDPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8734B70", Offset = "0x8733D70", VA = "0x188734B70")]
		public Uri(params Route[] ACNLMOPEGLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8734D20", Offset = "0x8733F20", VA = "0x188734D20")]
		public Uri(IEnumerable<Route> ACNLMOPEGLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x87341F0", Offset = "0x87333F0", VA = "0x1887341F0")]
		public bool NJCAMOKKLGF(Route ACNLMOPEGLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8734250", Offset = "0x8733450", VA = "0x188734250")]
		public bool NJCAMOKKLGF(IEnumerable<Route> NHOLDNGLBMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x87342F0", Offset = "0x87334F0", VA = "0x1887342F0")]
		public bool NJCAMOKKLGF(Uri CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x87334A0", Offset = "0x87326A0", VA = "0x1887334A0")]
		public static bool AEOGNGCAJFN(Uri LPHBKABPDPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8733D80", Offset = "0x8732F80", VA = "0x188733D80")]
		public static bool JBCCCOHNJLL(Uri BGPKBCGBDMP, Uri NIJBGCGEGBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8733C90", Offset = "0x8732E90", VA = "0x188733C90")]
		public bool JBCCCOHNJLL(Uri CMOCFNBHPLJ, bool ICDMFOLNEPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x87339E0", Offset = "0x8732BE0", VA = "0x1887339E0", Slot = "4")]
		public bool Equals(Uri CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8734050", Offset = "0x8733250", VA = "0x188734050")]
		public static bool JBCCCOHNJLL(Uri LPHBKABPDPO, Route ACNLMOPEGLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8733980", Offset = "0x8732B80", VA = "0x188733980", Slot = "5")]
		public bool Equals(Route ACNLMOPEGLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8733840", Offset = "0x8732A40", VA = "0x188733840", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8733A60", Offset = "0x8732C60", VA = "0x188733A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8733770", Offset = "0x8732970", VA = "0x188733770")]
		public string DHDLIDKCKEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8734650", Offset = "0x8733850", VA = "0x188734650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8733500", Offset = "0x8732700", VA = "0x188733500")]
		public string[] CMKICLCBCIO()
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
