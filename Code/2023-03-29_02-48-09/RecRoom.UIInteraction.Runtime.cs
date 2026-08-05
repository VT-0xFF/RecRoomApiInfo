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
public static class IGIBFNDJOGD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x651DA50", Offset = "0x651C850", VA = "0x18651DA50")]
	public static void HFFJMLCEBOF(Component BJCJNGNNING, bool KOFABCECKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x651DB70", Offset = "0x651C970", VA = "0x18651DB70")]
	public static void JNIIANPDNNN(Text EEJGFAMIHHD, string OOGEFLICJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x651DAE0", Offset = "0x651C8E0", VA = "0x18651DAE0")]
	public static void JNIIANPDNNN(TMP_Text EEJGFAMIHHD, string OOGEFLICJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x651D660", Offset = "0x651C460", VA = "0x18651D660")]
	public static void AKEPBAKBNJD(Image PHKKMHMKAJA, Sprite LGMEBJLMMGC, bool LDABPDAPAIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x651D930", Offset = "0x651C730", VA = "0x18651D930")]
	public static void FEMAPBBJODM(RawImage PHKKMHMKAJA, Texture2D BHABCHLJFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x651D9B0", Offset = "0x651C7B0", VA = "0x18651D9B0")]
	public static void FIMJFBABADC(Graphic EFKDDLLGLFD, Color HCHGJCCJIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x651D740", Offset = "0x651C540", VA = "0x18651D740")]
	public static bool CDHOOPCLGFE(GameObject AAMBGNNHMBI)
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
		[CGLCMPPNAMG(PCMMCGDMCAJ.Self, false, false, false)]
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
		public readonly global::KMABOJJOEJK<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::KMABOJJOEJK<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool COBBGEJFJNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7F1340", Offset = "0x7F0140", VA = "0x1807F1340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GDMOEELANCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7F1350", Offset = "0x7F0150", VA = "0x1807F1350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DPJJCELCMHB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x99BF40", Offset = "0x99AD40", VA = "0x18099BF40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform HBGLEEIHFJE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x651B960", Offset = "0x651A760", VA = "0x18651B960", Slot = "5")]
		public void OnDrag(PointerEventData GCNPDCEJPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x651B9F0", Offset = "0x651A7F0", VA = "0x18651B9F0", Slot = "4")]
		public void OnScroll(PointerEventData GCNPDCEJPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x651BA80", Offset = "0x651A880", VA = "0x18651BA80")]
		private Vector2 PIEGHDILGNH(Vector2 FNPIGPFOPAE)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x651BAD0", Offset = "0x651A8D0", VA = "0x18651BAD0")]
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
		private struct DPFECHGKDDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic HPJKKDHGLKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int CNFIDKNDCHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds EJLGDHBILJP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool DDJAPLJOEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas NIMOBLFAHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera LGIMHBIONLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup FMELBDKJAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool JFPDNAPNICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private DOLMGPMJGJG IJCJEPIJDDO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> LLCFDMJLMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int PBBFLGALLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<DPFECHGKDDP> IFFANECDGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] CLKIJGOCMCA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<DPFECHGKDDP> LOIANOGNMMJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NAIACCHCAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x651D5D0", Offset = "0x651C3D0", VA = "0x18651D5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool NJHHIEDAIMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x651CD40", Offset = "0x651BB40", VA = "0x18651CD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera PFGADJINLPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x651C150", Offset = "0x651AF50", VA = "0x18651C150", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x651D4B0", Offset = "0x651C2B0", VA = "0x18651D4B0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x651CCD0", Offset = "0x651BAD0", VA = "0x18651CCD0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x651CDD0", Offset = "0x651BBD0", VA = "0x18651CDD0", Slot = "17")]
		public override void Raycast(PointerEventData GCNPDCEJPLG, List<RaycastResult> NMBNJJHECIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x651BCE0", Offset = "0x651AAE0", VA = "0x18651BCE0")]
		protected void DPNEIPGBFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x651C220", Offset = "0x651B020", VA = "0x18651C220")]
		private void JEFIOCCBAIC(Canvas FFHALEIAIMH, Camera PFGADJINLPP, Vector2 CFMEGOMCDGP, Ray OOIMDAJHJKB, List<Graphic> KHKFOKFHHGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x651CCB0", Offset = "0x651BAB0", VA = "0x18651CCB0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x651BF90", Offset = "0x651AD90", VA = "0x18651BF90")]
		public static Bounds GetBounds(Graphic EFOGODKFGOO, Vector3[] IFDNEJPKPHF)
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
		[CGLCMPPNAMG(PCMMCGDMCAJ.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LELALLAJPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x4B0C950", Offset = "0x4B0B750", VA = "0x184B0C950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FA110", Offset = "0x6F8F10", VA = "0x1806FA110")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DBNCPBKBOAP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string BIAJEPBINPE = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string OCAIBNPPNOC = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const string MDLJDJLDHAP = "\ufffd";
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DOLMGPMJGJG
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray APHBJNEOFJF, out Graphic PNJLJCKJPJD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable ENPAAAHICKF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GBANBJLMAMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera KOJIMIFNOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CPHLPGCHIIP MJFKHBDMHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	global::KMABOJJOEJK<GameObject> OEHBPJMEKCB
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
		[CGLCMPPNAMG(PCMMCGDMCAJ.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool NOHFNFCLIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool NKOEFECECLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool DIHGBCBMNPM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool GDNNNNDMNOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x651F8D0", Offset = "0x651E6D0", VA = "0x18651F8D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x651F470", Offset = "0x651E270", VA = "0x18651F470", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x651FAF0", Offset = "0x651E8F0", VA = "0x18651FAF0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x651FAD0", Offset = "0x651E8D0", VA = "0x18651FAD0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x651FA30", Offset = "0x651E830", VA = "0x18651FA30", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x651FB30", Offset = "0x651E930", VA = "0x18651FB30", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x651FA10", Offset = "0x651E810", VA = "0x18651FA10", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x651FC00", Offset = "0x651EA00", VA = "0x18651FC00")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x651F940", Offset = "0x651E740", VA = "0x18651F940")]
		private void MBKLAMPECBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x651F5B0", Offset = "0x651E3B0", VA = "0x18651F5B0")]
		private void ECNNMIJJPLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x651F6E0", Offset = "0x651E4E0", VA = "0x18651F6E0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x651FC90", Offset = "0x651EA90", VA = "0x18651FC90")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EOPAGHHOGOK
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x651BB90", Offset = "0x651A990", VA = "0x18651BB90")]
	public static bool IFOIKEJKAAG(this Transform CPAHKPHLOLP, Transform AABHIBJPKOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x267B8E0", Offset = "0x267A6E0", VA = "0x18267B8E0")]
	public static T BNHFINEIAGC<T>(this Component INOJNNAPINL, bool ADOAKHCFMOJ = false) where T : class
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
		private const string ABIBBICBFOP = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const string AEALFJNGGOO = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const float BMJDOLNAEMG = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly List<UIAnchorFollower> DCEIKKJABDH;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly CPHLPGCHIIP OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly CPHLPGCHIIP OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static GBANBJLMAMJ GJFCONJKPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[CGLCMPPNAMG(PCMMCGDMCAJ.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[CGLCMPPNAMG(PCMMCGDMCAJ.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private JGIJICGALKO GIPHMMAIIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Vector3 HBOKDEOODPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion GBOHICPKDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Vector3 ODBJDMLAAHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private UIAnchor BDECPHLKGHP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public UIAnchor LPNGOCFEMOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x706B50", Offset = "0x705950", VA = "0x180706B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool AMOOICADHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1614FF0", Offset = "0x1613DF0", VA = "0x181614FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x651EA40", Offset = "0x651D840", VA = "0x18651EA40")]
		[KOIFHKBOHLF(NIJEKHCIIFG.Unity_AfterSceneLoad)]
		private static void GIHONBOCKDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x651EB50", Offset = "0x651D950", VA = "0x18651EB50")]
		[PONPKGMPDGG(ELCDPILLABI.ExitingPlayMode, 0)]
		private static void MCOOAKLPGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x651EDD0", Offset = "0x651DBD0", VA = "0x18651EDD0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x651E4A0", Offset = "0x651D2A0", VA = "0x18651E4A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x651ECA0", Offset = "0x651DAA0", VA = "0x18651ECA0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x651EB10", Offset = "0x651D910", VA = "0x18651EB10")]
		public void Initialize(UIAnchor BDECPHLKGHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x651ED30", Offset = "0x651DB30", VA = "0x18651ED30")]
		public void SetAnchorObjectEnabled(bool INLFOKCKKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x651ED80", Offset = "0x651DB80", VA = "0x18651ED80")]
		public void SetCanvasRenderingEnabled(bool INLFOKCKKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x651E860", Offset = "0x651D660", VA = "0x18651E860")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x651E750", Offset = "0x651D550", VA = "0x18651E750")]
		private void BFNODLIAKDE(bool INLFOKCKKHD, object INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x651EC20", Offset = "0x651DA20", VA = "0x18651EC20")]
		private void OJEBCHEMBKJ(bool INLFOKCKKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x651EF40", Offset = "0x651DD40", VA = "0x18651EF40")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x651E2C0", Offset = "0x651D0C0", VA = "0x18651E2C0")]
		private void ALLCDPFNBHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x651F3A0", Offset = "0x651E1A0", VA = "0x18651F3A0")]
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
		private sealed class BFLIECDDDOF : IEnumerator<FFIMBIIMMMD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private FFIMBIIMMMD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private FFIMBIIMMMD System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8A7890", Offset = "0x8A6690", VA = "0x1808A7890")]
			[DebuggerHidden]
			public BFLIECDDDOF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x651B140", Offset = "0x6519F40", VA = "0x18651B140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x651B230", Offset = "0x651A030", VA = "0x18651B230", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float DICANCIJNKA = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool IBHHMIAPBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int ENEHHFOLKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private PointerEventData ACJDDNMJAJP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public global::KMABOJJOEJK<PointerEventData> LIOINCFKLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public global::KMABOJJOEJK<PointerEventData> GOODNOAKPFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public global::KMABOJJOEJK<PointerEventData> BDEICJJIGGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public global::KMABOJJOEJK<PointerEventData> JDEIFHHOCNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6FA150", Offset = "0x6F8F50", VA = "0x1806FA150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public global::KMABOJJOEJK<PointerEventData> EIJMIDJENDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6FD9C0", Offset = "0x6FC7C0", VA = "0x1806FD9C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public global::KMABOJJOEJK<PointerEventData> HFGGHHMOKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x77F2A0", Offset = "0x77E0A0", VA = "0x18077F2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public global::KMABOJJOEJK<PointerEventData> NFKBMALIDED
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA40", Offset = "0x7CE840", VA = "0x1807CFA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x651B410", Offset = "0x651A210", VA = "0x18651B410", Slot = "4")]
		public void OnPointerClick(PointerEventData GCNPDCEJPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x651B740", Offset = "0x651A540", VA = "0x18651B740", Slot = "5")]
		public void OnPointerUp(PointerEventData GCNPDCEJPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x651B470", Offset = "0x651A270", VA = "0x18651B470", Slot = "6")]
		public void OnPointerDown(PointerEventData GCNPDCEJPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x651B390", Offset = "0x651A190", VA = "0x18651B390")]
		[IteratorStateMachine(typeof(BFLIECDDDOF))]
		private IEnumerator<FFIMBIIMMMD> IJMCHPJKJFD(int ENEHHFOLKEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x651B5E0", Offset = "0x651A3E0", VA = "0x18651B5E0", Slot = "7")]
		public void OnPointerEnter(PointerEventData GCNPDCEJPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x651B680", Offset = "0x651A480", VA = "0x18651B680", Slot = "8")]
		public void OnPointerExit(PointerEventData GCNPDCEJPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x651B270", Offset = "0x651A070", VA = "0x18651B270")]
		private bool FKHEJNDMECD(GameObject AAMBGNNHMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x651B7B0", Offset = "0x651A5B0", VA = "0x18651B7B0")]
		public Clickable()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x651DC00", Offset = "0x651CA00", VA = "0x18651DC00")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x651DD10", Offset = "0x651CB10", VA = "0x18651DD10")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
