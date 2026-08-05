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
public static class LPGJDPIAHFP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x636AFC0", Offset = "0x6369DC0", VA = "0x18636AFC0")]
	public static void OONGBEKLMNK(Component KMJCJNGOPHM, bool FLGLFAGJDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x636AD40", Offset = "0x6369B40", VA = "0x18636AD40")]
	public static void MFBHKFNJONC(Text NGMBFCPLECF, string PAAKJCMCMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x636ACB0", Offset = "0x6369AB0", VA = "0x18636ACB0")]
	public static void MFBHKFNJONC(TMP_Text NGMBFCPLECF, string PAAKJCMCMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x636B050", Offset = "0x6369E50", VA = "0x18636B050")]
	public static void PDJGBKNBCKC(Image IKOHEIMLNIJ, Sprite DAOPLBGFIAG, bool LOPAKDPMEKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x636AC30", Offset = "0x6369A30", VA = "0x18636AC30")]
	public static void KJEHJBIFOLK(RawImage IKOHEIMLNIJ, Texture2D OLCMNMBHAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x636AB90", Offset = "0x6369990", VA = "0x18636AB90")]
	public static void KCJIDAFEMGM(Graphic HPKLHNFNPLA, Color OEGNINEOMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x636ADD0", Offset = "0x6369BD0", VA = "0x18636ADD0")]
	public static bool OAKABGAKKKK(GameObject NCAOMIEGHPA)
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
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
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
		public readonly global::PBGGDBDIKGA<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::PBGGDBDIKGA<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HKDKHMJIGEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x733990", Offset = "0x732790", VA = "0x180733990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KFJDPDKKCOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x73B080", Offset = "0x739E80", VA = "0x18073B080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DGNLHMNPDJO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE2CE40", Offset = "0xE2BC40", VA = "0x180E2CE40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform MPLJDEOMHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6368880", Offset = "0x6367680", VA = "0x186368880", Slot = "5")]
		public void OnDrag(PointerEventData APIGNLIODDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6368910", Offset = "0x6367710", VA = "0x186368910", Slot = "4")]
		public void OnScroll(PointerEventData APIGNLIODDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63689A0", Offset = "0x63677A0", VA = "0x1863689A0")]
		private Vector2 PBNPJJMPOIF(Vector2 JNKJLNCDBDJ)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63689F0", Offset = "0x63677F0", VA = "0x1863689F0")]
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
		private struct CKHKEFMDDMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic DOACBDDBFBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int MOOMEAIKFLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds OJOKJIDAMCH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool NIDDNKOPCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas IKPEKKPEAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera EONIODCPHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup EFCAMMBPIAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool NGNMLFNLBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private EICHCMBCEIH NNPGDMHLEEM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> LFGKEIANFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int HCNNDCPFAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<CKHKEFMDDMD> FCCBKCGILHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] APOEKKPMNGO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<CKHKEFMDDMD> PNKIOLAMIKL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LGDHKLBJLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x636A3A0", Offset = "0x63691A0", VA = "0x18636A3A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool PGBDOIPDNOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6368D60", Offset = "0x6367B60", VA = "0x186368D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera GOHHPIDMAHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6C07D0", Offset = "0x6BF5D0", VA = "0x1806C07D0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6369A40", Offset = "0x6368840", VA = "0x186369A40", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x636A280", Offset = "0x6369080", VA = "0x18636A280")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6369B30", Offset = "0x6368930", VA = "0x186369B30", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6369BA0", Offset = "0x63689A0", VA = "0x186369BA0", Slot = "17")]
		public override void Raycast(PointerEventData APIGNLIODDG, List<RaycastResult> AAPGNIHJDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6368AB0", Offset = "0x63678B0", VA = "0x186368AB0")]
		protected void FOHGAGFLMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6368FB0", Offset = "0x6367DB0", VA = "0x186368FB0")]
		private void HFCCBFOEMBC(Canvas BHHKCGDILCC, Camera GOHHPIDMAHG, Vector2 FGHGMAEADOG, Ray IKOHGCEJHOM, List<Graphic> PFKCJHDBJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6369B10", Offset = "0x6368910", VA = "0x186369B10", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6368DF0", Offset = "0x6367BF0", VA = "0x186368DF0")]
		public static Bounds GetBounds(Graphic CCICHMPIDIO, Vector3[] MJBMMHFOCFP)
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
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool NJGPOAGJMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1743100", Offset = "0x1741F00", VA = "0x181743100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78BFB0", Offset = "0x78ADB0", VA = "0x18078BFB0")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class AFHCGMGEIOP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string DIMAMFDHGNH = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string NPMGMFNNGCA = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const string KJEFNIFHIFM = "\ufffd";
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EICHCMBCEIH
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray OMBIILPAJMO, out Graphic CBLCBJADPLO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable MPBJBDCOLDK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IJDMKPKMBCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FMJNLFCNDHK IJOPOGJEECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	global::PBGGDBDIKGA<GameObject> FHGMHAEGDFN
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
		[OBCALLPEFCG(CABHOIOLNCF.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool KAJLHFKBBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool HAFKEKOMLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool DODGIPIFPOF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private bool KMJADOAOADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x636CB00", Offset = "0x636B900", VA = "0x18636CB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x636C4B0", Offset = "0x636B2B0", VA = "0x18636C4B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x636C9F0", Offset = "0x636B7F0", VA = "0x18636C9F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x636C9D0", Offset = "0x636B7D0", VA = "0x18636C9D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x636C930", Offset = "0x636B730", VA = "0x18636C930", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x636CB70", Offset = "0x636B970", VA = "0x18636CB70", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x636C910", Offset = "0x636B710", VA = "0x18636C910", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x636CC40", Offset = "0x636BA40", VA = "0x18636CC40")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x636CA30", Offset = "0x636B830", VA = "0x18636CA30")]
		private void PJHIEDBCPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x636C7E0", Offset = "0x636B5E0", VA = "0x18636C7E0")]
		private void OALCINNDBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x636C5F0", Offset = "0x636B3F0", VA = "0x18636C5F0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x636CCD0", Offset = "0x636BAD0", VA = "0x18636CCD0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CJMDPPIAJLI
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6368040", Offset = "0x6366E40", VA = "0x186368040")]
	public static bool MKAMKANMIFI(this Transform ELFIACEEOOA, Transform ICMEPOIJCJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x37A31E0", Offset = "0x37A1FE0", VA = "0x1837A31E0")]
	public static T GFELHBBKPMB<T>(this Component IBCPLIFFFGK, bool BKEBANKBFBE = false) where T : class
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
		private const string IIFHNAFKNMI = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const string HBMPILCEHKJ = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const float MGEFPLAHPCJ = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly List<UIAnchorFollower> JNGBLPCNEOD;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly FMJNLFCNDHK OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly FMJNLFCNDHK OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IJDMKPKMBCJ HCJEAAPLPBA;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static int PMALJMINCDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private ILPPPAONIDE JMFLPIMLAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Vector3 KGDMFBKPALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Quaternion BHCPBHBGFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Vector3 MFIMJLMHMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private UIAnchor JJPBNNODKJN;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UIAnchor OCINAEGLADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x77DA40", Offset = "0x77C840", VA = "0x18077DA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool FPOIPOHAEKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2435460", Offset = "0x2434260", VA = "0x182435460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x636BA40", Offset = "0x636A840", VA = "0x18636BA40")]
		[NMAEGPBBEAO(MLJIKHLLPGF.Unity_AfterSceneLoad)]
		private static void NAGCBALDEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x636B8F0", Offset = "0x636A6F0", VA = "0x18636B8F0")]
		[CIBCLNKDGPH(MOOMEKEKHGD.ExitingPlayMode, 0)]
		private static void JDADPCMHEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x636BDB0", Offset = "0x636ABB0", VA = "0x18636BDB0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x636B2D0", Offset = "0x636A0D0", VA = "0x18636B2D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x636BB10", Offset = "0x636A910", VA = "0x18636BB10", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x636B8B0", Offset = "0x636A6B0", VA = "0x18636B8B0")]
		public void Initialize(UIAnchor JJPBNNODKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x636BD10", Offset = "0x636AB10", VA = "0x18636BD10")]
		public void SetAnchorObjectEnabled(bool ILHPJDCALOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x636BD60", Offset = "0x636AB60", VA = "0x18636BD60")]
		public void SetCanvasRenderingEnabled(bool ILHPJDCALOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x636B6D0", Offset = "0x636A4D0", VA = "0x18636B6D0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x636B1C0", Offset = "0x6369FC0", VA = "0x18636B1C0")]
		private void AJCHBLFHOBD(bool ILHPJDCALOO, object KCCFEDJJGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x636B9C0", Offset = "0x636A7C0", VA = "0x18636B9C0")]
		private void LKFFHHHAFED(bool ILHPJDCALOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x636BF80", Offset = "0x636AD80", VA = "0x18636BF80")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x636B4F0", Offset = "0x636A2F0", VA = "0x18636B4F0")]
		private void DPDMFBONKCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x636C3E0", Offset = "0x636B1E0", VA = "0x18636C3E0")]
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
		private sealed class GPOPAMCFECD : IEnumerator<ELOHAHHPMGF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private ELOHAHHPMGF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private ELOHAHHPMGF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x78FB50", Offset = "0x78E950", VA = "0x18078FB50")]
			[DebuggerHidden]
			public GPOPAMCFECD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x636A430", Offset = "0x6369230", VA = "0x18636A430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x636A520", Offset = "0x6369320", VA = "0x18636A520", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float HBKHDCKMIMM = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool GNJLPDNFHCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int LEFMOGHCJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private PointerEventData BIBCCAMJHLI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public global::PBGGDBDIKGA<PointerEventData> EOFCPHDHHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public global::PBGGDBDIKGA<PointerEventData> EJOFKJFILPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public global::PBGGDBDIKGA<PointerEventData> ALNFELDBDEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6C07D0", Offset = "0x6BF5D0", VA = "0x1806C07D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public global::PBGGDBDIKGA<PointerEventData> HNAAPEDMPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x73C880", Offset = "0x73B680", VA = "0x18073C880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public global::PBGGDBDIKGA<PointerEventData> AKJBLDCHPLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6BE4D0", Offset = "0x6BD2D0", VA = "0x1806BE4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public global::PBGGDBDIKGA<PointerEventData> MFDPEGDGDHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7678A0", Offset = "0x7666A0", VA = "0x1807678A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public global::PBGGDBDIKGA<PointerEventData> AJBAAEGIANM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6BF760", Offset = "0x6BE560", VA = "0x1806BF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6368330", Offset = "0x6367130", VA = "0x186368330", Slot = "4")]
		public void OnPointerClick(PointerEventData APIGNLIODDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6368660", Offset = "0x6367460", VA = "0x186368660", Slot = "5")]
		public void OnPointerUp(PointerEventData APIGNLIODDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6368390", Offset = "0x6367190", VA = "0x186368390", Slot = "6")]
		public void OnPointerDown(PointerEventData APIGNLIODDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x63682B0", Offset = "0x63670B0", VA = "0x1863682B0")]
		[IteratorStateMachine(typeof(GPOPAMCFECD))]
		private IEnumerator<ELOHAHHPMGF> KLLGMIFCFHD(int LEFMOGHCJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6368500", Offset = "0x6367300", VA = "0x186368500", Slot = "7")]
		public void OnPointerEnter(PointerEventData APIGNLIODDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x63685A0", Offset = "0x63673A0", VA = "0x1863685A0", Slot = "8")]
		public void OnPointerExit(PointerEventData APIGNLIODDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6368190", Offset = "0x6366F90", VA = "0x186368190")]
		private bool EPNAFDDIFBA(GameObject NCAOMIEGHPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x63686D0", Offset = "0x63674D0", VA = "0x1863686D0")]
		public Clickable()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x636A8B0", Offset = "0x63696B0", VA = "0x18636A8B0")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x636A560", Offset = "0x6369360", VA = "0x18636A560")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
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
