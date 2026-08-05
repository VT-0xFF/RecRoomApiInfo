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
public static class FCOLFBNBHJC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2029870", Offset = "0x2028670", VA = "0x182029870")]
	public static void PGAJOHKJPJG(Component BFKBHAILEEA, bool MLLDIDGDNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2029630", Offset = "0x2028430", VA = "0x182029630")]
	public static void EPFEOLMNIDM(Text JPLLMHONJIM, string DJNOGODKGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x20296C0", Offset = "0x20284C0", VA = "0x1820296C0")]
	public static void EPFEOLMNIDM(TMP_Text JPLLMHONJIM, string DJNOGODKGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2029550", Offset = "0x2028350", VA = "0x182029550")]
	public static void DKKEHOIBDFG(Image ONAELPLGGBF, Sprite JBINMMNMJGM, bool NFCFMKFIDGF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2029750", Offset = "0x2028550", VA = "0x182029750")]
	public static void GOCBAEDLGGK(RawImage ONAELPLGGBF, Texture2D MACEMPHCNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20297D0", Offset = "0x20285D0", VA = "0x1820297D0")]
	public static void KMDBBGCKHGB(Graphic MCMFGOKALLL, Color IPFDGHGEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2029360", Offset = "0x2028160", VA = "0x182029360")]
	public static bool CDMADCLCMBJ(GameObject NGIKODIIBGN)
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
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
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
		public readonly global::EGPJGAAPCPL<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::EGPJGAAPCPL<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NELOMMEOKKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x88A3B0", Offset = "0x8891B0", VA = "0x18088A3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MDINAPFFCFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8895A0", Offset = "0x8883A0", VA = "0x1808895A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float NMOFOCLBLAO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7454A0", Offset = "0x7442A0", VA = "0x1807454A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform LGICNLDCILP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2029050", Offset = "0x2027E50", VA = "0x182029050", Slot = "5")]
		public void OnDrag(PointerEventData POLNENKGJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x20290E0", Offset = "0x2027EE0", VA = "0x1820290E0", Slot = "4")]
		public void OnScroll(PointerEventData POLNENKGJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2029000", Offset = "0x2027E00", VA = "0x182029000")]
		private Vector2 MFKGDMIDDGF(Vector2 PFBLKCFHOHD)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2029170", Offset = "0x2027F70", VA = "0x182029170")]
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
		private struct AHPEGNFNIOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic FJCFHINACIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int AENHNPJCMFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds LNINFOHAGEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool ABFPNDEIKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas MDPNPJOBPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera FKAKLPBELLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup OBJEKFILINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool AFCJEAMJAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private BFFMGDMECNA CNMKKAENNJE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> BLEMCJOBAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int MLDINIOJGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<AHPEGNFNIOL> OJNFJHEKPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] AOOBMDALCHH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<AHPEGNFNIOL> KIOPHJPCAHP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JJGNHGAGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x202B1F0", Offset = "0x2029FF0", VA = "0x18202B1F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool NFPBMNICMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2029B90", Offset = "0x2028990", VA = "0x182029B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera HDOANENNNPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6D4450", Offset = "0x6D3250", VA = "0x1806D4450", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2029AC0", Offset = "0x20288C0", VA = "0x182029AC0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x202B0D0", Offset = "0x2029ED0", VA = "0x18202B0D0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x202A980", Offset = "0x2029780", VA = "0x18202A980", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x202A9F0", Offset = "0x20297F0", VA = "0x18202A9F0", Slot = "17")]
		public override void Raycast(PointerEventData POLNENKGJEO, List<RaycastResult> COPLMANLJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2029C20", Offset = "0x2028A20", VA = "0x182029C20")]
		protected void NEJLKGOBJMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2029ED0", Offset = "0x2028CD0", VA = "0x182029ED0")]
		private void NHJCBNIIGDP(Canvas IBGLIJJDEKG, Camera HDOANENNNPA, Vector2 NCAMDMJCFLL, Ray OJJPHFJNOOI, List<Graphic> DDMCDBNKELI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x202A960", Offset = "0x2029760", VA = "0x18202A960", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2029900", Offset = "0x2028700", VA = "0x182029900")]
		public static Bounds GetBounds(Graphic DCMAJEHDEPD, Vector3[] LLCPOAPFEOC)
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
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HDPFLLBOJNP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1592A90", Offset = "0x1591890", VA = "0x181592A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EAJHMGLPILM
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string HKDNEFFGJFH = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string ODHFJAFBMBE = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const string NGAHCFCDKBG = "\ufffd";
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BFFMGDMECNA
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray HNAHKBBFCPI, out Graphic ANEJCODKAKP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable BKGAHFIJAIC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EMKOKCNBFBM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EEDHONDEDDI IAHLHCBNHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	global::EGPJGAAPCPL<GameObject> CJDDMNAMEFL
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
		[GBGNHGGGIDI(DKGJGBDJNIO.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool CBLMHHLELLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool JGIKDKNMGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool DJFEGLEHADC;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private bool NGJOCDFEHDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x202D1A0", Offset = "0x202BFA0", VA = "0x18202D1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x202CC70", Offset = "0x202BA70", VA = "0x18202CC70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x202D2F0", Offset = "0x202C0F0", VA = "0x18202D2F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x202D2D0", Offset = "0x202C0D0", VA = "0x18202D2D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x202D230", Offset = "0x202C030", VA = "0x18202D230", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x202D330", Offset = "0x202C130", VA = "0x18202D330", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x202D210", Offset = "0x202C010", VA = "0x18202D210", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x202D400", Offset = "0x202C200", VA = "0x18202D400")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x202CFA0", Offset = "0x202BDA0", VA = "0x18202CFA0")]
		private void KMMAFDHMILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x202D070", Offset = "0x202BE70", VA = "0x18202D070")]
		private void LGDFGPFKKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x202CDB0", Offset = "0x202BBB0", VA = "0x18202CDB0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x202D490", Offset = "0x202C290", VA = "0x18202D490")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PHFGBCFCAKB
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x202B8B0", Offset = "0x202A6B0", VA = "0x18202B8B0")]
	public static bool OGBODLOBKBP(this Transform JJJNIHBIILJ, Transform KICGHGEEADG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x33EF3C0", Offset = "0x33EE1C0", VA = "0x1833EF3C0")]
	public static T IBMPIIKIBIG<T>(this Component KMOIJDECCNO, bool JLAPDJNFEPJ = false) where T : class
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
		private const string JFOPJODCCPD = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const string EECHIMGIPOC = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const float NDCIBMEHIIO = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly List<UIAnchorFollower> HOBGFCFDFDM;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly EEDHONDEDDI OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly EEDHONDEDDI OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static EMKOKCNBFBM KAELFCHIJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private MKBPEOEKJNO ANMLBDOHCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Vector3 DAMBNGLPBFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion KEBBKKFKDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Vector3 NJDFBNNFFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private UIAnchor DLHLFIGJION;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public UIAnchor NPDJGOMDBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6CDB70", Offset = "0x6CC970", VA = "0x1806CDB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool OHMAONPNIOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x202BA90", Offset = "0x202A890", VA = "0x18202BA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x202BF50", Offset = "0x202AD50", VA = "0x18202BF50")]
		[FFDJMNHKGHP(HBBPKJPMKNI.Unity_AfterSceneLoad)]
		private static void FKIENGHPLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x202C280", Offset = "0x202B080", VA = "0x18202C280")]
		[PHHAPANKJKM(AJLNLJAJGIO.ExitingPlayMode, 0)]
		private static void IOHAJCJNHON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x202C5D0", Offset = "0x202B3D0", VA = "0x18202C5D0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x202BAC0", Offset = "0x202A8C0", VA = "0x18202BAC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x202C4A0", Offset = "0x202B2A0", VA = "0x18202C4A0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x202C350", Offset = "0x202B150", VA = "0x18202C350")]
		public void Initialize(UIAnchor DLHLFIGJION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x202C530", Offset = "0x202B330", VA = "0x18202C530")]
		public void SetAnchorObjectEnabled(bool BBEGNBBGFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x202C580", Offset = "0x202B380", VA = "0x18202C580")]
		public void SetCanvasRenderingEnabled(bool BBEGNBBGFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x202C020", Offset = "0x202AE20", VA = "0x18202C020")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x202C390", Offset = "0x202B190", VA = "0x18202C390")]
		private void LMBBKHBDHPB(bool BBEGNBBGFBF, object DPODOOAHECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x202C200", Offset = "0x202B000", VA = "0x18202C200")]
		private void HKCOKDGLDFJ(bool BBEGNBBGFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x202C740", Offset = "0x202B540", VA = "0x18202C740")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x202BD70", Offset = "0x202AB70", VA = "0x18202BD70")]
		private void DKHLJNFLGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x202CBA0", Offset = "0x202B9A0", VA = "0x18202CBA0")]
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
		private sealed class EIPPCGNDBPL : IEnumerator<KDNIAKIKLPJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private KDNIAKIKLPJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private KDNIAKIKLPJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8CCB00", Offset = "0x8CB900", VA = "0x1808CCB00")]
			[DebuggerHidden]
			public EIPPCGNDBPL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2029230", Offset = "0x2028030", VA = "0x182029230", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2029320", Offset = "0x2028120", VA = "0x182029320", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float EFONJAJLDCO = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool BHPDFFKKCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int ELPMDDBLCEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private PointerEventData NJOINFDFMCL;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public global::EGPJGAAPCPL<PointerEventData> HFJCBOCMDIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public global::EGPJGAAPCPL<PointerEventData> APEFHMLDHGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public global::EGPJGAAPCPL<PointerEventData> NCHEDFINNFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6D4450", Offset = "0x6D3250", VA = "0x1806D4450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public global::EGPJGAAPCPL<PointerEventData> GHHDECNNPAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6C5A70", Offset = "0x6C4870", VA = "0x1806C5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public global::EGPJGAAPCPL<PointerEventData> ENMOBLJANJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6CB7A0", Offset = "0x6CA5A0", VA = "0x1806CB7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public global::EGPJGAAPCPL<PointerEventData> FNIBOAAHMJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6C5CC0", Offset = "0x6C4AC0", VA = "0x1806C5CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public global::EGPJGAAPCPL<PointerEventData> NNGLJCEGNAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6C5C90", Offset = "0x6C4A90", VA = "0x1806C5C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2028AB0", Offset = "0x20278B0", VA = "0x182028AB0", Slot = "4")]
		public void OnPointerClick(PointerEventData POLNENKGJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2028DE0", Offset = "0x2027BE0", VA = "0x182028DE0", Slot = "5")]
		public void OnPointerUp(PointerEventData POLNENKGJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2028B10", Offset = "0x2027910", VA = "0x182028B10", Slot = "6")]
		public void OnPointerDown(PointerEventData POLNENKGJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2028A30", Offset = "0x2027830", VA = "0x182028A30")]
		[IteratorStateMachine(typeof(EIPPCGNDBPL))]
		private IEnumerator<KDNIAKIKLPJ> JBEACKLHJGP(int ELPMDDBLCEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x2028C80", Offset = "0x2027A80", VA = "0x182028C80", Slot = "7")]
		public void OnPointerEnter(PointerEventData POLNENKGJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2028D20", Offset = "0x2027B20", VA = "0x182028D20", Slot = "8")]
		public void OnPointerExit(PointerEventData POLNENKGJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2028910", Offset = "0x2027710", VA = "0x182028910")]
		private bool BGNLODFFLFH(GameObject NGIKODIIBGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2028E50", Offset = "0x2027C50", VA = "0x182028E50")]
		public Clickable()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x202B5D0", Offset = "0x202A3D0", VA = "0x18202B5D0")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x202B280", Offset = "0x202A080", VA = "0x18202B280")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
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
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
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
