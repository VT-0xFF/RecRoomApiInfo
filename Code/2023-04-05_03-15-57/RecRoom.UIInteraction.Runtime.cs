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
public static class ABPJEAMDBHL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x656AF00", Offset = "0x6569F00", VA = "0x18656AF00")]
	public static void CGBJLBGGAEH(Component NANIPOPDLDJ, bool HAAPPAEMABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x656AD60", Offset = "0x6569D60", VA = "0x18656AD60")]
	public static void ABOKCIGJLBK(Text DKMIGLMABNH, string CHPNEJPOGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x656ADF0", Offset = "0x6569DF0", VA = "0x18656ADF0")]
	public static void ABOKCIGJLBK(TMP_Text DKMIGLMABNH, string CHPNEJPOGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x656AF90", Offset = "0x6569F90", VA = "0x18656AF90")]
	public static void MJJIJPKDDMN(Image MLAHBAKJHAE, Sprite PMOFICFJAIE, bool MCJINBOLKPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x656AE80", Offset = "0x6569E80", VA = "0x18656AE80")]
	public static void BBGGCPKFPMP(RawImage MLAHBAKJHAE, Texture2D IPAMFLJFLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x656B070", Offset = "0x656A070", VA = "0x18656B070")]
	public static void NCHAALELPCF(Graphic OFCIKCKBFAK, Color LDFNLMPJEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x656B110", Offset = "0x656A110", VA = "0x18656B110")]
	public static bool PNCBHGOBFMJ(GameObject BLPBCMIHDMD)
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
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
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
		public readonly global::OKNKFJGELPL<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::OKNKFJGELPL<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LDNGEPIBBFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6FA3D0", Offset = "0x6F93D0", VA = "0x1806FA3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HAPEJNMEFOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6FA3E0", Offset = "0x6F93E0", VA = "0x1806FA3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float ABJEAODBPAN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xFBEFB0", Offset = "0xFBDFB0", VA = "0x180FBEFB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform KAGPOFDFGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x656BA40", Offset = "0x656AA40", VA = "0x18656BA40", Slot = "5")]
		public void OnDrag(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x656BAD0", Offset = "0x656AAD0", VA = "0x18656BAD0", Slot = "4")]
		public void OnScroll(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x656B9F0", Offset = "0x656A9F0", VA = "0x18656B9F0")]
		private Vector2 LGKPKCEGDJK(Vector2 GFGCIGJBGIF)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x656BB60", Offset = "0x656AB60", VA = "0x18656BB60")]
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
		private struct AFLLEAHMPGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic JDOJFOBHNID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int CMBGEAMEFPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds NOFMLHGBILJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool IKIOFMOIPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas HHKGFFCJEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera MOHEBEEGOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup JFECJDCCLCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool PJPDOBNJCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private LFDECDBOFEL MBFCMDJAKGF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> IGJNBGPJGHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int AHDNLPJCOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<AFLLEAHMPGH> APEEKCGNIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] DLMGDOEMBJB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<AFLLEAHMPGH> HLFKJBOGCLF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BBDFACHICKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x656D640", Offset = "0x656C640", VA = "0x18656D640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool JOIAIFMLNOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x656BD50", Offset = "0x656AD50", VA = "0x18656BD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera CNPOBGIELCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x656BFA0", Offset = "0x656AFA0", VA = "0x18656BFA0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x656D520", Offset = "0x656C520", VA = "0x18656D520")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x656CDD0", Offset = "0x656BDD0", VA = "0x18656CDD0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x656CE40", Offset = "0x656BE40", VA = "0x18656CE40", Slot = "17")]
		public override void Raycast(PointerEventData KOMNBMOHOIG, List<RaycastResult> BKPOOKMPLCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x656C070", Offset = "0x656B070", VA = "0x18656C070")]
		protected void KFCHJOBBACI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x656C320", Offset = "0x656B320", VA = "0x18656C320")]
		private void LANBAAACLOF(Canvas PMNHKDLPHCA, Camera CNPOBGIELCM, Vector2 DJJFLGGHMNG, Ray EDLLGFPHGJO, List<Graphic> DBIGCGIMDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x656CDB0", Offset = "0x656BDB0", VA = "0x18656CDB0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x656BDE0", Offset = "0x656ADE0", VA = "0x18656BDE0")]
		public static Bounds GetBounds(Graphic FIOLNGJADNH, Vector3[] EOLLMKAGGBN)
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
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool APJNBIELNNN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCDC820", Offset = "0xCDB820", VA = "0x180CDC820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HKDINCMFDDN
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string BPLIBPCOABK = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string FJHGGAOCBGJ = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const string EHGPFLPDDCE = "\ufffd";
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LFDECDBOFEL
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray IJKFJKKNMNE, out Graphic KHBNGFFPMLF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable LBKEBCHPCDK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HFELCDKJDIG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera KOINJAGAIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AMNHKKJOBOK EGKPLLJDOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	global::OKNKFJGELPL<GameObject> HCPHDBKFDML
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
		[CBBPHEOMBGL(LNNFGJICGEC.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool NCKFGLKMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool GKDBHENAEDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool DHMJEGMIPKE;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool LMIIHJOEHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x656F1D0", Offset = "0x656E1D0", VA = "0x18656F1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x656F090", Offset = "0x656E090", VA = "0x18656F090", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x656F710", Offset = "0x656E710", VA = "0x18656F710", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x656F6F0", Offset = "0x656E6F0", VA = "0x18656F6F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x656F650", Offset = "0x656E650", VA = "0x18656F650", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x656F750", Offset = "0x656E750", VA = "0x18656F750", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x656F630", Offset = "0x656E630", VA = "0x18656F630", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x656F820", Offset = "0x656E820", VA = "0x18656F820")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x656F560", Offset = "0x656E560", VA = "0x18656F560")]
		private void OFAOLOFHELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x656F430", Offset = "0x656E430", VA = "0x18656F430")]
		private void MCIAFOMOGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x656F240", Offset = "0x656E240", VA = "0x18656F240")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x656F8B0", Offset = "0x656E8B0", VA = "0x18656F8B0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KADJKIEJGOA
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x656DD00", Offset = "0x656CD00", VA = "0x18656DD00")]
	public static bool LGCPLHINIKN(this Transform BOGHNKLNLII, Transform OKMBLMILFGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x21D6FB0", Offset = "0x21D5FB0", VA = "0x1821D6FB0")]
	public static T HAELAPDFOJF<T>(this Component NMAMPMADCBK, bool CPNIACDEHHD = false) where T : class
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
		private const string PMBMBOOAFMN = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const string PIKAFCAKOLE = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const float EHNMBNGOMIC = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly List<UIAnchorFollower> NHOPDEJILKE;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly AMNHKKJOBOK OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly AMNHKKJOBOK OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static HFELCDKJDIG PCAECPHFHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private JLNNFJHBOML LLJBEINGHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Vector3 PEBMPDKMLOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion LAOPPDBDLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Vector3 IPKPIPGMNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private UIAnchor GKIJNODKPLP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public UIAnchor PEEMKLKEIBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F5700", Offset = "0x6F4700", VA = "0x1806F5700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool JOFBAGIEPII
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x118C600", Offset = "0x118B600", VA = "0x18118C600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x656E720", Offset = "0x656D720", VA = "0x18656E720")]
		[DBEMBPHJILD(JAIANHPNEMN.Unity_AfterSceneLoad)]
		private static void JHHOMPLGCBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x656E7F0", Offset = "0x656D7F0", VA = "0x18656E7F0")]
		[DFDEPFOCOOG(GCCGOPEBDFE.ExitingPlayMode, 0)]
		private static void NMIJBJMPDNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x656E9F0", Offset = "0x656D9F0", VA = "0x18656E9F0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x656DEE0", Offset = "0x656CEE0", VA = "0x18656DEE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x656E8C0", Offset = "0x656D8C0", VA = "0x18656E8C0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x656E660", Offset = "0x656D660", VA = "0x18656E660")]
		public void Initialize(UIAnchor GKIJNODKPLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x656E950", Offset = "0x656D950", VA = "0x18656E950")]
		public void SetAnchorObjectEnabled(bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x656E9A0", Offset = "0x656D9A0", VA = "0x18656E9A0")]
		public void SetCanvasRenderingEnabled(bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x656E480", Offset = "0x656D480", VA = "0x18656E480")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x656E190", Offset = "0x656D190", VA = "0x18656E190")]
		private void BHCEJJLFFDL(bool IGPDCEGDODH, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x656E6A0", Offset = "0x656D6A0", VA = "0x18656E6A0")]
		private void JEBIOCOGANE(bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x656EB60", Offset = "0x656DB60", VA = "0x18656EB60")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x656E2A0", Offset = "0x656D2A0", VA = "0x18656E2A0")]
		private void DIFAPECPJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x656EFC0", Offset = "0x656DFC0", VA = "0x18656EFC0")]
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
		private sealed class EOEAEIAGONP : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private FEEMOJCDGJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
			[DebuggerHidden]
			public EOEAEIAGONP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x656BC20", Offset = "0x656AC20", VA = "0x18656BC20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x656BD10", Offset = "0x656AD10", VA = "0x18656BD10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float IHPOFKGOBBI = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool KIDLMMMDPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int CNEMLKFLMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private PointerEventData OJPPMHNFCEO;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public global::OKNKFJGELPL<PointerEventData> IAGNKCFBLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public global::OKNKFJGELPL<PointerEventData> JILKNMMHCGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public global::OKNKFJGELPL<PointerEventData> FHDIEIBDLNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public global::OKNKFJGELPL<PointerEventData> HKBCAFLFCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6E6580", Offset = "0x6E5580", VA = "0x1806E6580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public global::OKNKFJGELPL<PointerEventData> LMEHJGJBNPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0D0", Offset = "0x6DE0D0", VA = "0x1806DF0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public global::OKNKFJGELPL<PointerEventData> HMBDAHAPFPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6F5760", Offset = "0x6F4760", VA = "0x1806F5760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public global::OKNKFJGELPL<PointerEventData> MECIFLDNOMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0B0", Offset = "0x6DE0B0", VA = "0x1806DF0B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x656B4A0", Offset = "0x656A4A0", VA = "0x18656B4A0", Slot = "4")]
		public void OnPointerClick(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x656B7D0", Offset = "0x656A7D0", VA = "0x18656B7D0", Slot = "5")]
		public void OnPointerUp(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x656B500", Offset = "0x656A500", VA = "0x18656B500", Slot = "6")]
		public void OnPointerDown(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x656B420", Offset = "0x656A420", VA = "0x18656B420")]
		[IteratorStateMachine(typeof(EOEAEIAGONP))]
		private IEnumerator<FEEMOJCDGJP> MOADINGCICC(int CNEMLKFLMCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x656B670", Offset = "0x656A670", VA = "0x18656B670", Slot = "7")]
		public void OnPointerEnter(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x656B710", Offset = "0x656A710", VA = "0x18656B710", Slot = "8")]
		public void OnPointerExit(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x656B300", Offset = "0x656A300", VA = "0x18656B300")]
		private bool GDPNGLIOMME(GameObject BLPBCMIHDMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x656B840", Offset = "0x656A840", VA = "0x18656B840")]
		public Clickable()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x656D6D0", Offset = "0x656C6D0", VA = "0x18656D6D0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x656D7E0", Offset = "0x656C7E0", VA = "0x18656D7E0")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
