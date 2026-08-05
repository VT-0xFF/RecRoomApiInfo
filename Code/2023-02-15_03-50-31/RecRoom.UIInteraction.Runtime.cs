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
public static class IKPKMHPLMIG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63BDC10", Offset = "0x63BD010", VA = "0x1863BDC10")]
	public static void OKNIFKLHLIG(Component BGHFDNDJKMA, bool BEIBHGPBPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63BD860", Offset = "0x63BCC60", VA = "0x1863BD860")]
	public static void BCJEPEFBFKA(Text CMKEKMIOAII, string KKNAIGLCEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63BD8F0", Offset = "0x63BCCF0", VA = "0x1863BD8F0")]
	public static void BCJEPEFBFKA(TMP_Text CMKEKMIOAII, string KKNAIGLCEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63BD780", Offset = "0x63BCB80", VA = "0x1863BD780")]
	public static void AEMBIHLGEPC(Image DJDCMBIIBIN, Sprite FDCBBALCAMG, bool MOJEIKMBFGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63BDCA0", Offset = "0x63BD0A0", VA = "0x1863BDCA0")]
	public static void ONAGEOOBELD(RawImage DJDCMBIIBIN, Texture2D IGCBGLPMGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x63BD980", Offset = "0x63BCD80", VA = "0x1863BD980")]
	public static void MMCMNGIJLFM(Graphic BNMLCDKFKFC, Color GEDOLEMBLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x63BDA20", Offset = "0x63BCE20", VA = "0x1863BDA20")]
	public static bool OEAMHPOEMBA(GameObject OOKBNBHDPPG)
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
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
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
		public readonly global::KOEHNDLKDFN<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::KOEHNDLKDFN<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OOIOFNOKOGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7D3DD0", Offset = "0x7D31D0", VA = "0x1807D3DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FDJGCPIOBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7D3DE0", Offset = "0x7D31E0", VA = "0x1807D3DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float IAIGKDOGODF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA30490", Offset = "0xA2F890", VA = "0x180A30490")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform PKMBFDHHDJG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x63BB5F0", Offset = "0x63BA9F0", VA = "0x1863BB5F0", Slot = "5")]
		public void OnDrag(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63BB680", Offset = "0x63BAA80", VA = "0x1863BB680", Slot = "4")]
		public void OnScroll(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63BB5A0", Offset = "0x63BA9A0", VA = "0x1863BB5A0")]
		private Vector2 ACNIDFMLKOH(Vector2 BKKNDNJECCL)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63BB710", Offset = "0x63BAB10", VA = "0x1863BB710")]
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
		private struct HHACDJAGAMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic AIBALLAMOFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int DFMMDINPBMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds IAFIANICJAE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool LIGEBLFEFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas HDDPIMICOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera FGDPLNFCDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup BFLHJANJPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool OGJMPNNBHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private EEFDAMLLALM JELFEKLHBCC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> GBPMCLOABNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int NCIAJFBEGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<HHACDJAGAMA> GKEMPCGLMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] GFIKDEIDJIJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<HHACDJAGAMA> AFEOGCOALHG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NFHBECKFBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x63BD6F0", Offset = "0x63BCAF0", VA = "0x1863BD6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool DAOAAMEENLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x63BCB40", Offset = "0x63BBF40", VA = "0x1863BCB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera ABDLFKNDOHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63BCD90", Offset = "0x63BC190", VA = "0x1863BCD90", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x63BD5D0", Offset = "0x63BC9D0", VA = "0x1863BD5D0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x63BCE80", Offset = "0x63BC280", VA = "0x1863BCE80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x63BCEF0", Offset = "0x63BC2F0", VA = "0x1863BCEF0", Slot = "17")]
		public override void Raycast(PointerEventData FFEKEOCBAFH, List<RaycastResult> NIDHNMNEDBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63BC890", Offset = "0x63BBC90", VA = "0x1863BC890")]
		protected void BLJKPBNENCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x63BBE00", Offset = "0x63BB200", VA = "0x1863BBE00")]
		private void APHFDLGPJFP(Canvas EIBHEGAAPAO, Camera ABDLFKNDOHD, Vector2 DEACEBMAFNJ, Ray GPCJLJJKIAN, List<Graphic> CKPHEBNBPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x63BCE60", Offset = "0x63BC260", VA = "0x1863BCE60", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63BCBD0", Offset = "0x63BBFD0", VA = "0x1863BCBD0")]
		public static Bounds GetBounds(Graphic CCLEFJGBMLL, Vector3[] JGHBDHCIFJM)
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
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ALLLILMAHLP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x107DD80", Offset = "0x107D180", VA = "0x18107DD80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PHIOMJDKGGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string LPIHIALFNFC = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string FGJALLALJHF = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const string MNPNJJGPMAD = "\ufffd";
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EEFDAMLLALM
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray FFPOAHDAKKN, out Graphic PIMGKJKNPLO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable HHCMAHINJOA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BFPJFODMFIN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CBKLEJNNKJH NOKGIMPKNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	global::KOEHNDLKDFN<GameObject> ELCHECHIIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
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
		[PLDPAHFKOHO(BCMNNOMINIG.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool ICGPEIAOIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool JFNLPKCPMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool GDFFAOPCCOG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private bool JDJMBENOODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63BF5C0", Offset = "0x63BE9C0", VA = "0x1863BF5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63BF1C0", Offset = "0x63BE5C0", VA = "0x1863BF1C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x63BF710", Offset = "0x63BEB10", VA = "0x1863BF710", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x63BF6F0", Offset = "0x63BEAF0", VA = "0x1863BF6F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x63BF650", Offset = "0x63BEA50", VA = "0x1863BF650", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x63BF750", Offset = "0x63BEB50", VA = "0x1863BF750", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x63BF630", Offset = "0x63BEA30", VA = "0x1863BF630", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x63BF820", Offset = "0x63BEC20", VA = "0x1863BF820")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x63BF4F0", Offset = "0x63BE8F0", VA = "0x1863BF4F0")]
		private void GHNFENFHPAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x63BF090", Offset = "0x63BE490", VA = "0x1863BF090")]
		private void AMBEGJBBPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63BF300", Offset = "0x63BE700", VA = "0x1863BF300")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x63BF8B0", Offset = "0x63BECB0", VA = "0x1863BF8B0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BHJKCMNLIAB
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63BAD60", Offset = "0x63BA160", VA = "0x1863BAD60")]
	public static bool LLGAJACLHBI(this Transform LKJGCNCCCDD, Transform GPFONCECPBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1880", Offset = "0x2BD0C80", VA = "0x182BD1880")]
	public static T CFJLPDAKNJA<T>(this Component MOOHJICILGA, bool IGHGBNPCCBC = false) where T : class
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
		private const string KEIEJFDDHHF = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const string FHHLMLHFBGI = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const float CPGEGJGHHLI = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly List<UIAnchorFollower> AEIAKOAANNJ;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly CBKLEJNNKJH OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly CBKLEJNNKJH OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static BFPJFODMFIN BMPOMIHNECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private JMMOMAJEGFM LDLJADFLIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Vector3 IHDNPDENHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion PFMFJJGHDAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Vector3 EGLNFGAJJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private UIAnchor JCOIBIOBJJK;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UIAnchor FLNNGOAOHNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F0B50", Offset = "0x6EFF50", VA = "0x1806F0B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool GFGJNCBDFFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x19BED40", Offset = "0x19BE140", VA = "0x1819BED40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x63BE190", Offset = "0x63BD590", VA = "0x1863BE190")]
		[NHJENIDEHPD(PAIIGJKJFJG.Unity_AfterSceneLoad)]
		private static void BNACPANAOEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x63BE7F0", Offset = "0x63BDBF0", VA = "0x1863BE7F0")]
		[ODBBCFLHGDG(BHNMFCNEJDF.ExitingPlayMode, 0)]
		private static void NJPOAOFBPKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63BE9F0", Offset = "0x63BDDF0", VA = "0x1863BE9F0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x63BDEE0", Offset = "0x63BD2E0", VA = "0x1863BDEE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x63BE8C0", Offset = "0x63BDCC0", VA = "0x1863BE8C0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x63BE4C0", Offset = "0x63BD8C0", VA = "0x1863BE4C0")]
		public void Initialize(UIAnchor JCOIBIOBJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x63BE950", Offset = "0x63BDD50", VA = "0x1863BE950")]
		public void SetAnchorObjectEnabled(bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x63BE9A0", Offset = "0x63BDDA0", VA = "0x1863BE9A0")]
		public void SetCanvasRenderingEnabled(bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x63BE2E0", Offset = "0x63BD6E0", VA = "0x1863BE2E0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x63BE500", Offset = "0x63BD900", VA = "0x1863BE500")]
		private void KAEBKLKNAOB(bool LNJLGDKOFHH, object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63BE260", Offset = "0x63BD660", VA = "0x1863BE260")]
		private void CPPDNDIOJND(bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x63BEB60", Offset = "0x63BDF60", VA = "0x1863BEB60")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x63BE610", Offset = "0x63BDA10", VA = "0x1863BE610")]
		private void MADJMNOIILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x63BEFC0", Offset = "0x63BE3C0", VA = "0x1863BEFC0")]
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
		private sealed class IMJLKLOILLP : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private MOELIBACAGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public IMJLKLOILLP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63BDD20", Offset = "0x63BD120", VA = "0x1863BDD20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63BDE10", Offset = "0x63BD210", VA = "0x1863BDE10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float OAMMIELLODH = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool HIKEGILAJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int EMLKOODIPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private PointerEventData CHOIPFILMPL;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public global::KOEHNDLKDFN<PointerEventData> EGGOENPBMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6E42D0", Offset = "0x6E36D0", VA = "0x1806E42D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public global::KOEHNDLKDFN<PointerEventData> MEDFCIHPPJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public global::KOEHNDLKDFN<PointerEventData> IODLAFHCGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public global::KOEHNDLKDFN<PointerEventData> KHEPCLCBECE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E4150", Offset = "0x6E3550", VA = "0x1806E4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public global::KOEHNDLKDFN<PointerEventData> HEAGIAMNNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public global::KOEHNDLKDFN<PointerEventData> MKAPBMIGGDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7CBB40", Offset = "0x7CAF40", VA = "0x1807CBB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public global::KOEHNDLKDFN<PointerEventData> PGEKGNECIHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x77F5A0", Offset = "0x77E9A0", VA = "0x18077F5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x63BB050", Offset = "0x63BA450", VA = "0x1863BB050", Slot = "4")]
		public void OnPointerClick(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x63BB380", Offset = "0x63BA780", VA = "0x1863BB380", Slot = "5")]
		public void OnPointerUp(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x63BB0B0", Offset = "0x63BA4B0", VA = "0x1863BB0B0", Slot = "6")]
		public void OnPointerDown(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x63BAFD0", Offset = "0x63BA3D0", VA = "0x1863BAFD0")]
		[IteratorStateMachine(typeof(IMJLKLOILLP))]
		private IEnumerator<MOELIBACAGH> MBCBGIAEDHO(int EMLKOODIPOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x63BB220", Offset = "0x63BA620", VA = "0x1863BB220", Slot = "7")]
		public void OnPointerEnter(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x63BB2C0", Offset = "0x63BA6C0", VA = "0x1863BB2C0", Slot = "8")]
		public void OnPointerExit(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x63BAEB0", Offset = "0x63BA2B0", VA = "0x1863BAEB0")]
		private bool FOCFKBIPEOF(GameObject OOKBNBHDPPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x63BB3F0", Offset = "0x63BA7F0", VA = "0x1863BB3F0")]
		public Clickable()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x63BB7D0", Offset = "0x63BABD0", VA = "0x1863BB7D0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x63BB8E0", Offset = "0x63BACE0", VA = "0x1863BB8E0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
