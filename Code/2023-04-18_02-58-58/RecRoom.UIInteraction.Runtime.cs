using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MDPEDDACDFD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6634E20", Offset = "0x6634020", VA = "0x186634E20")]
	public static void NIMICFBKJGO(Component KLEOIMLJIAC, bool FBHDABEFLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6634F40", Offset = "0x6634140", VA = "0x186634F40")]
	public static void OFJOPFOBKBN(Text CKBPJJNGFIH, string HLIGBKANEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6634EB0", Offset = "0x66340B0", VA = "0x186634EB0")]
	public static void OFJOPFOBKBN(TMP_Text CKBPJJNGFIH, string HLIGBKANEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6634AB0", Offset = "0x6633CB0", VA = "0x186634AB0")]
	public static void DHEHONPIFMH(Image IECDHEIBMJN, Sprite DLADPCHJMME, bool BFPKOLNOOLK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6634A30", Offset = "0x6633C30", VA = "0x186634A30")]
	public static void DFODLPLKHKI(RawImage IECDHEIBMJN, Texture2D CIONKGJFLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6634D80", Offset = "0x6633F80", VA = "0x186634D80")]
	public static void LHHPAPNINIL(Graphic OPGIKGIGKLO, Color HMCAFGCGFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6634B90", Offset = "0x6633D90", VA = "0x186634B90")]
	public static bool DLHKKFAFOKF(GameObject BMNLOPDIJGF)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class DragScrollDecorator : MonoBehaviour, IScrollHandler, IEventSystemHandler, IDragHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private bool supportsHorizontalScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool supportsVerticalScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly global::HHOBPMOCKMJ<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::HHOBPMOCKMJ<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HALHAFEBIKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8297A0", Offset = "0x8289A0", VA = "0x1808297A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DJBMAEPKOOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xC4A880", Offset = "0xC49A80", VA = "0x180C4A880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float HLPCDCOLELK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9CB530", Offset = "0x9CA730", VA = "0x1809CB530")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform LFMHDGFIOAP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6632C50", Offset = "0x6631E50", VA = "0x186632C50", Slot = "5")]
		public void OnDrag(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6632CE0", Offset = "0x6631EE0", VA = "0x186632CE0", Slot = "4")]
		public void OnScroll(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6632C00", Offset = "0x6631E00", VA = "0x186632C00")]
		private Vector2 FFHGCOONFHO(Vector2 FKHDPLPGMAK)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6632D70", Offset = "0x6631F70", VA = "0x186632D70")]
		public DragScrollDecorator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AddComponentMenu("Event/Fast Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class FastGraphicRaycaster : BaseRaycaster
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct DLHGFBAHLBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic NNFJPHFHBCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int BFMBCMJILKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds LJGAEEGLFMO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool FGOPMHCNDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas JLIFKDDNCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera CFDDMKEJIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup JCJCJFNLNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool OEAONLGBBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private PDPHLPEHFOO CEHBLLJLDBA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> EGEOLGFICAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int OIEDFKJFNNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<DLHGFBAHLBK> LMAHHKNIOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] DLPKEMAHBHL;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<DLHGFBAHLBK> MIPEEIBIFKL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DPFFHKFDPHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6634720", Offset = "0x6633920", VA = "0x186634720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool KPLBAPKPLEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x66330C0", Offset = "0x66322C0", VA = "0x1866330C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera FBFLGGLCJMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6632FF0", Offset = "0x66321F0", VA = "0x186632FF0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6634600", Offset = "0x6633800", VA = "0x186634600")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6633EB0", Offset = "0x66330B0", VA = "0x186633EB0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6633F20", Offset = "0x6633120", VA = "0x186633F20", Slot = "17")]
		public override void Raycast(PointerEventData OEPDOIOJPHD, List<RaycastResult> DPKMEIGCEOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6633BE0", Offset = "0x6632DE0", VA = "0x186633BE0")]
		protected void MJFDOBKCALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6633150", Offset = "0x6632350", VA = "0x186633150")]
		private void KHDIAAGJBJI(Canvas NGHMKGJCELB, Camera FBFLGGLCJMB, Vector2 GGDFBDJCCPH, Ray GMEPKAFJMJP, List<Graphic> ILJGHKGMILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6633E90", Offset = "0x6633090", VA = "0x186633E90", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6632E30", Offset = "0x6632030", VA = "0x186632E30")]
		public static Bounds GetBounds(Graphic DCJDBKALJKL, Vector3[] OJFNKOLLCKG)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class FastGraphicRaycasterGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BGGLHEPHJFK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x4757C60", Offset = "0x4756E60", VA = "0x184757C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JBLMDAMIHAC
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string COIBCEHJGCN = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string CNKOFGDLCMA = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const string BKJCBPILAEP = "\ufffd";
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PDPHLPEHFOO
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray HAAAJDJGEFF, out Graphic LIFJFEFFOPP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable DNPIJEOOLKB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GBBFHAOMGIF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera JDIMEJBGLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EEANDDJEMJC MIOEHOAOIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	global::HHOBPMOCKMJ<GameObject> AJGKGEJJBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DisallowMultipleComponent]
	public class UIAnchor : UIBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool ONPNOALNMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool FBDBOFGNKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool FBIBJOCCBNN;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool LJKMDHOKOCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6636CA0", Offset = "0x6635EA0", VA = "0x186636CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6636840", Offset = "0x6635A40", VA = "0x186636840", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6636EC0", Offset = "0x66360C0", VA = "0x186636EC0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6636EA0", Offset = "0x66360A0", VA = "0x186636EA0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6636E00", Offset = "0x6636000", VA = "0x186636E00", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6636F00", Offset = "0x6636100", VA = "0x186636F00", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6636DE0", Offset = "0x6635FE0", VA = "0x186636DE0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6636FD0", Offset = "0x66361D0", VA = "0x186636FD0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6636D10", Offset = "0x6635F10", VA = "0x186636D10")]
		private void OKFOLJBMEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6636980", Offset = "0x6635B80", VA = "0x186636980")]
		private void BKPCAAJIKOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6636AB0", Offset = "0x6635CB0", VA = "0x186636AB0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6637060", Offset = "0x6636260", VA = "0x186637060")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KFCAICMFKAI
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x66348E0", Offset = "0x6633AE0", VA = "0x1866348E0")]
	public static bool OIMDAGOMIFH(this Transform AAFNLLCIFBP, Transform HHFDFFDPCGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x12F47A0", Offset = "0x12F39A0", VA = "0x1812F47A0")]
	public static T AENFANLCNED<T>(this Component GFCPAMJILIO, bool AAADJPJJFDJ = false) where T : class
	{
		return null;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private const string POFFHGAFAPJ = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const string PGEJNOOLOKB = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const float FJHNBNJJBGO = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly List<UIAnchorFollower> CBCLPHBGHAK;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly EEANDDJEMJC OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly EEANDDJEMJC OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static GBBFHAOMGIF HFEFJLNJLJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private FIHGBEHGLGB GEGDLLGFILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Vector3 LIGOHLDLHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion HBPKCOJKDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Vector3 MJFGINPGMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private UIAnchor GPDDMFGCOCF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public UIAnchor BPKCMIPKDBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9AD0E0", Offset = "0x9AC2E0", VA = "0x1809AD0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool AFJFOKCCEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xBAB0E0", Offset = "0xBAA2E0", VA = "0x180BAB0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6635F60", Offset = "0x6635160", VA = "0x186635F60")]
		[LCHGFDCANEE(CHIHMKPMNLF.Unity_AfterSceneLoad)]
		private static void IHEKMEOIBOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6635AD0", Offset = "0x6634CD0", VA = "0x186635AD0")]
		[HBJMIOFCGBI(OJDMGNCPNKA.ExitingPlayMode, 0)]
		private static void FCCAJFNJBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66361A0", Offset = "0x66353A0", VA = "0x1866361A0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6635690", Offset = "0x6634890", VA = "0x186635690", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6636070", Offset = "0x6635270", VA = "0x186636070", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6636030", Offset = "0x6635230", VA = "0x186636030")]
		public void Initialize(UIAnchor GPDDMFGCOCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6636100", Offset = "0x6635300", VA = "0x186636100")]
		public void SetAnchorObjectEnabled(bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6636150", Offset = "0x6635350", VA = "0x186636150")]
		public void SetCanvasRenderingEnabled(bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6635BA0", Offset = "0x6634DA0", VA = "0x186635BA0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6635940", Offset = "0x6634B40", VA = "0x186635940")]
		private void BAKOHGANACG(bool BFDBCMGIOBG, object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6635A50", Offset = "0x6634C50", VA = "0x186635A50")]
		private void DBDOCGHOGMK(bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6636310", Offset = "0x6635510", VA = "0x186636310")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6635D80", Offset = "0x6634F80", VA = "0x186635D80")]
		private void GPKBBJCGGLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6636770", Offset = "0x6635970", VA = "0x186636770")]
		public UIAnchorFollower()
		{
		}
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class IHDJBFBJHOC : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private EGGPGCCKPCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public IHDJBFBJHOC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x66347B0", Offset = "0x66339B0", VA = "0x1866347B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x66348A0", Offset = "0x6633AA0", VA = "0x1866348A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float LCJLLHHNPME = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool KABKDMJKJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int PBOFPNNFEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private PointerEventData GCIKHIFJNKB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public global::HHOBPMOCKMJ<PointerEventData> MOGEBALLHBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x75C710", Offset = "0x75B910", VA = "0x18075C710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public global::HHOBPMOCKMJ<PointerEventData> ANLCPLAMKHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public global::HHOBPMOCKMJ<PointerEventData> NNGGFCFAPCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public global::HHOBPMOCKMJ<PointerEventData> PELBAFNMGDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x813690", Offset = "0x812890", VA = "0x180813690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public global::HHOBPMOCKMJ<PointerEventData> BCEINJGHMNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x75F110", Offset = "0x75E310", VA = "0x18075F110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public global::HHOBPMOCKMJ<PointerEventData> DLDBPBJPHII
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7A7A90", Offset = "0x7A6C90", VA = "0x1807A7A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public global::HHOBPMOCKMJ<PointerEventData> KPEMBDLDINO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8532C0", Offset = "0x8524C0", VA = "0x1808532C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x66326B0", Offset = "0x66318B0", VA = "0x1866326B0", Slot = "4")]
		public void OnPointerClick(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x66329E0", Offset = "0x6631BE0", VA = "0x1866329E0", Slot = "5")]
		public void OnPointerUp(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6632710", Offset = "0x6631910", VA = "0x186632710", Slot = "6")]
		public void OnPointerDown(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6632510", Offset = "0x6631710", VA = "0x186632510")]
		[IteratorStateMachine(typeof(IHDJBFBJHOC))]
		private IEnumerator<EGGPGCCKPCO> OECMFAOJIPC(int PBOFPNNFEOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6632880", Offset = "0x6631A80", VA = "0x186632880", Slot = "7")]
		public void OnPointerEnter(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6632920", Offset = "0x6631B20", VA = "0x186632920", Slot = "8")]
		public void OnPointerExit(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6632590", Offset = "0x6631790", VA = "0x186632590")]
		private bool OJMJIDIEILP(GameObject BMNLOPDIJGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6632A50", Offset = "0x6631C50", VA = "0x186632A50")]
		public Clickable()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6634FD0", Offset = "0x66341D0", VA = "0x186634FD0")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x66350E0", Offset = "0x66342E0", VA = "0x1866350E0")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
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
