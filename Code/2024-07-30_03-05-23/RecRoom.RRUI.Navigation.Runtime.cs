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
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		private FastGraphicRaycaster raycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GameObject OOPHBMGNHEM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Canvas EMAMEEAADAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GameObject MBHMFJLOHMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x731C0A0", Offset = "0x731A6A0", VA = "0x18731C0A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Route CNLIHMJLOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x868240", Offset = "0x866840", VA = "0x180868240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x731BF70", Offset = "0x731A570", VA = "0x18731BF70")]
		public void Initialize(GameObject KKIBINCKNKL, Transform PPEEAFEPIIK, Route MGGOJKKLAGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x731C170", Offset = "0x731A770", VA = "0x18731C170")]
		public void Show()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x731BF60", Offset = "0x731A560", VA = "0x18731BF60")]
		public void Hide()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x731BE50", Offset = "0x731A450", VA = "0x18731BE50")]
		private void AGDIMGNLGOF(bool LLMIJLANJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public PageWrapper()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DJIEAMHPFCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PageWrapper AOOEPCPAODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly IReadOnlyList<LCMJBBLHOKD> FIEKOGFAOBL;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x872E80", Offset = "0x871480", VA = "0x180872E80")]
	public DJIEAMHPFCJ(PageWrapper GBMOILAKGAF, IReadOnlyList<LCMJBBLHOKD> JLECPJIBOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LCMJBBLHOKD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject HJMFHICNFLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GJFFIMHAENI OnBeforePageSwapFrom(Uri KPNMJIDMBCH, AGCNOKDAPLL GBGLBCFHOAO, DJIEAMHPFCJ LDMDLAPPFKI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GJFFIMHAENI OnBeforePageSwapTo(Uri KPNMJIDMBCH, AGCNOKDAPLL GBGLBCFHOAO, DJIEAMHPFCJ FFJBCJMDNOO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GJFFIMHAENI OnAfterPageSwapTo(Uri KPNMJIDMBCH, AGCNOKDAPLL GBGLBCFHOAO, DJIEAMHPFCJ MMFHEPIIMEM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GJFFIMHAENI OnShow(AGCNOKDAPLL GBGLBCFHOAO, DJIEAMHPFCJ ADIJPBNDHHI, DJIEAMHPFCJ EAJCNPMAHLL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GJFFIMHAENI OnHide(AGCNOKDAPLL GBGLBCFHOAO, DJIEAMHPFCJ ADIJPBNDHHI, DJIEAMHPFCJ EAJCNPMAHLL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AGCNOKDAPLL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static AGCNOKDAPLL ABMFDACMOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x731B8A0", Offset = "0x7319EA0", VA = "0x18731B8A0")]
		[CompilerGenerated]
		get
		{
			return default(AGCNOKDAPLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PNIMNPJABOC KBDLNGOGLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730")]
		[CompilerGenerated]
		readonly get
		{
			return default(PNIMNPJABOC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KNDMABMBKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x42B0640", Offset = "0x42AEC40", VA = "0x1842B0640")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F71E40", Offset = "0x5F70440", VA = "0x185F71E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Uri BDJHBJLGDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAB7680", Offset = "0xAB5C80", VA = "0x180AB7680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Uri GMJABELHKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x731B8F0", Offset = "0x7319EF0", VA = "0x18731B8F0")]
	public AGCNOKDAPLL(Uri FDFAAJJOPDC, Uri IBPAMFIOJPK, PNIMNPJABOC PAOEDKJHFFK = PNIMNPJABOC.None, bool IOCLHJNKJCC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PNIMNPJABOC
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Forward,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Backward
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FANDMDFOMGF
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
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2018E40", Offset = "0x2017440", VA = "0x182018E40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x731C370", Offset = "0x731A970", VA = "0x18731C370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x731C280", Offset = "0x731A880", VA = "0x18731C280")]
		public string KOMNLCIGAPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x731C1B0", Offset = "0x731A7B0", VA = "0x18731C1B0", Slot = "4")]
		public bool Equals(Route BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x731C220", Offset = "0x731A820", VA = "0x18731C220", Slot = "5")]
		public bool Equals(Uri KPNMJIDMBCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x731C320", Offset = "0x731A920", VA = "0x18731C320")]
		public AssetReference MOMMJMHMCPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x731C430", Offset = "0x731AA30", VA = "0x18731C430")]
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
					[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public AssetReference PrefabReference
				{
					[Cpp2IlInjected.Token(Token = "0x6000033")]
					[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
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
			[CDJDACIHBKJ("StatsigSegment")]
			private StatsigVariant[] statsigVariants;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public SerializedGuid Guid
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public string FriendlyName
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AssetReference PrefabReference
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<StatsigVariant> StatsigVariants
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x731EA90", Offset = "0x731D090", VA = "0x18731EA90")]
			public View()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class NPLNHNPCPGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Uri uri;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public NPLNHNPCPGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x731BB80", Offset = "0x731A180", VA = "0x18731BB80")]
			internal bool BOIOCBDCPJO(View view)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IMHONIFBAML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public View view;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public IMHONIFBAML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x731BB40", Offset = "0x731A140", VA = "0x18731BB40")]
			internal bool IICCKNMJGDG(Route route)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class POKNPFODIPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public NMMBPCBEFII statsig;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public POKNPFODIPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x731BC60", Offset = "0x731A260", VA = "0x18731BC60")]
			internal bool BBGKBKLHPGE(View.StatsigVariant variant)
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
			[Cpp2IlInjected.Address(RVA = "0x731D1E0", Offset = "0x731B7E0", VA = "0x18731D1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static IReadOnlyList<RoutesConfig> Configs
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x731D150", Offset = "0x731B750", VA = "0x18731D150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IReadOnlyList<View> Views
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x731CBB0", Offset = "0x731B1B0", VA = "0x18731CBB0")]
		private static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x731C7D0", Offset = "0x731ADD0", VA = "0x18731C7D0")]
		public bool JFBONEPJLHO(Uri KPNMJIDMBCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x731C460", Offset = "0x731AA60", VA = "0x18731C460")]
		public static bool CEONMMKDAPF(Route MGGOJKKLAGE, [Out] RoutesConfig PNNODGAEAPB, [Out] View PKIBPPHEILL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x731C8D0", Offset = "0x731AED0", VA = "0x18731C8D0")]
		public static AssetReference MOMMJMHMCPG(Route MGGOJKKLAGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x731D0C0", Offset = "0x731B6C0", VA = "0x18731D0C0")]
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
		private sealed class CMDJOOMOOAF
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
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public CMDJOOMOOAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x731B940", Offset = "0x7319F40", VA = "0x18731B940")]
			internal bool ABMDNKPALPF(Route aSubRoute, int index)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x731BA40", Offset = "0x731A040", VA = "0x18731BA40")]
			internal bool MOLLLKPJAFN(string k)
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
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Dictionary<string, object> Data
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x731EA00", Offset = "0x731D000", VA = "0x18731EA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x731E830", Offset = "0x731CE30", VA = "0x18731E830")]
		public Uri(Uri KPNMJIDMBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x731E770", Offset = "0x731CD70", VA = "0x18731E770")]
		public Uri(params Route[] MGGOJKKLAGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x731E920", Offset = "0x731CF20", VA = "0x18731E920")]
		public Uri(IEnumerable<Route> MGGOJKKLAGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x731E200", Offset = "0x731C800", VA = "0x18731E200")]
		public bool LGJHGFMDMBF(Route MGGOJKKLAGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x731DE00", Offset = "0x731C400", VA = "0x18731DE00")]
		public bool LGJHGFMDMBF(IEnumerable<Route> GKECPKJHLAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x731DEA0", Offset = "0x731C4A0", VA = "0x18731DEA0")]
		public bool LGJHGFMDMBF(Uri BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x731D840", Offset = "0x731BE40", VA = "0x18731D840")]
		public static bool HIFFGJEKBHK(Uri KPNMJIDMBCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x731DA40", Offset = "0x731C040", VA = "0x18731DA40")]
		public static bool JBEDIOCGHIG(Uri KHKPJFABMKM, Uri CGBLKAAFCDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x731DD10", Offset = "0x731C310", VA = "0x18731DD10")]
		public bool JBEDIOCGHIG(Uri BHFGHGMPKOJ, bool GMBMLCKFJGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x731D590", Offset = "0x731BB90", VA = "0x18731D590", Slot = "4")]
		public bool Equals(Uri BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x731D8A0", Offset = "0x731BEA0", VA = "0x18731D8A0")]
		public static bool JBEDIOCGHIG(Uri KPNMJIDMBCH, Route MGGOJKKLAGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x731D530", Offset = "0x731BB30", VA = "0x18731D530", Slot = "5")]
		public bool Equals(Route MGGOJKKLAGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x731D3F0", Offset = "0x731B9F0", VA = "0x18731D3F0", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x731D610", Offset = "0x731BC10", VA = "0x18731D610", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x731D360", Offset = "0x731B960", VA = "0x18731D360")]
		public string ANCBHIGDGIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x731E260", Offset = "0x731C860", VA = "0x18731E260", Slot = "3")]
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
