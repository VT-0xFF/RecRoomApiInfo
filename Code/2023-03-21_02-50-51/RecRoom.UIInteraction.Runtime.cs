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
public static class LJGDBBNNJLA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64C3DA0", Offset = "0x64C25A0", VA = "0x1864C3DA0")]
	public static void ODOEEPCHHFF(Component DMKJFEIEPGB, bool NBJFHLJMABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64C3C80", Offset = "0x64C2480", VA = "0x1864C3C80")]
	public static void NEPJCLOBOKE(Text FILDHIIONJI, string ENBCBHDDENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64C3D10", Offset = "0x64C2510", VA = "0x1864C3D10")]
	public static void NEPJCLOBOKE(TMP_Text FILDHIIONJI, string ENBCBHDDENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64C3910", Offset = "0x64C2110", VA = "0x1864C3910")]
	public static void AFFBLLNMFPL(Image PIJPFBNHLBJ, Sprite IHDGAKGGNKB, bool GONLCHPPANP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64C3890", Offset = "0x64C2090", VA = "0x1864C3890")]
	public static void ADDAJAOPOEM(RawImage PIJPFBNHLBJ, Texture2D KDIGAMMGOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64C39F0", Offset = "0x64C21F0", VA = "0x1864C39F0")]
	public static void GDDHDMHMOIA(Graphic DHHPBJCMFBC, Color LCCPJBCAOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64C3A90", Offset = "0x64C2290", VA = "0x1864C3A90")]
	public static bool GFNLLDEBBHP(GameObject IMPKIJJJHKI)
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
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
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
		public readonly global::CNOGLFLGNKP<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::CNOGLFLGNKP<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CPDOILGPIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6F03D0", Offset = "0x6EEBD0", VA = "0x1806F03D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KACLHOPODOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6F03E0", Offset = "0x6EEBE0", VA = "0x1806F03E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float LAHBJOHPICM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xFCDB10", Offset = "0xFCC310", VA = "0x180FCDB10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform FILMHAPPBEI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64C1C00", Offset = "0x64C0400", VA = "0x1864C1C00", Slot = "5")]
		public void OnDrag(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64C1C90", Offset = "0x64C0490", VA = "0x1864C1C90", Slot = "4")]
		public void OnScroll(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64C1BB0", Offset = "0x64C03B0", VA = "0x1864C1BB0")]
		private Vector2 ECGFBOKOHIB(Vector2 NEPBNLHGHBB)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64C1D20", Offset = "0x64C0520", VA = "0x1864C1D20")]
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
		private struct IAOLBFEJAHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic NGIDHEJMBHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int NPFABNJBOOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds BLINPOBECMI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool JPKILKAEBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas INGONBGFBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera MFCKNEICACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup GNJNCAJNLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool BBGDLOPPHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private EFPODMMCMIE ABLNKMJEJNH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> EIDBKMAELCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int OFLFLLCAGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<IAOLBFEJAHP> OEGIPLEBFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] GHCLHHBBBMA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<IAOLBFEJAHP> DCEMOLJNBMA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CBNCHOIHDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x64C36D0", Offset = "0x64C1ED0", VA = "0x1864C36D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool ADAGNCIMEJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x64C2DB0", Offset = "0x64C15B0", VA = "0x1864C2DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera DDPDDMCJFFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x64C2CE0", Offset = "0x64C14E0", VA = "0x1864C2CE0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x64C35B0", Offset = "0x64C1DB0", VA = "0x1864C35B0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x64C2E60", Offset = "0x64C1660", VA = "0x1864C2E60", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x64C2ED0", Offset = "0x64C16D0", VA = "0x1864C2ED0", Slot = "17")]
		public override void Raycast(PointerEventData HIGIGMBKOED, List<RaycastResult> IBEDFLBOMCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64C1DE0", Offset = "0x64C05E0", VA = "0x1864C1DE0")]
		protected void FGOOELGKDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x64C2250", Offset = "0x64C0A50", VA = "0x1864C2250")]
		private void HNABONJCHIG(Canvas BKIBOHCDNEC, Camera DDPDDMCJFFF, Vector2 LBLIABDHLBL, Ray PDEAAOEPBGO, List<Graphic> LELFOBIJDCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x64C2E40", Offset = "0x64C1640", VA = "0x1864C2E40", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x64C2090", Offset = "0x64C0890", VA = "0x1864C2090")]
		public static Bounds GetBounds(Graphic NELIICGHDHB, Vector3[] BFABJEPEFKG)
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
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BFCAGIPBEBK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCD2820", Offset = "0xCD1020", VA = "0x180CD2820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FOFPAFOKGME
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string HAOMNHEDAEC = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string AOEPBGBMDMH = "\ufffd";

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const string AOIKLPKLOPI = "\ufffd";
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EFPODMMCMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray AOPEGEIBDED, out Graphic MEJMMFMJDIF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable EHNGEKBPIHL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LLOKPPMEGNO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera FABBNCMHLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IFEOEDLAFMF LFOPDEFDHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	global::CNOGLFLGNKP<GameObject> IOAKPKIGFAB
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
		[PMFJBMBMCHD(OLIJGBPJKMJ.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool FNKPDDHBPPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool PNGNAIJBEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool JKHEOAGBBFE;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool FBJDEEPHIAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x64C5A60", Offset = "0x64C4260", VA = "0x1864C5A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x64C57F0", Offset = "0x64C3FF0", VA = "0x1864C57F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x64C5E70", Offset = "0x64C4670", VA = "0x1864C5E70", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x64C5E50", Offset = "0x64C4650", VA = "0x1864C5E50", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x64C5DB0", Offset = "0x64C45B0", VA = "0x1864C5DB0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x64C5EB0", Offset = "0x64C46B0", VA = "0x1864C5EB0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x64C5D90", Offset = "0x64C4590", VA = "0x1864C5D90", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x64C5F80", Offset = "0x64C4780", VA = "0x1864C5F80")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x64C5CC0", Offset = "0x64C44C0", VA = "0x1864C5CC0")]
		private void LIHKPCJIAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x64C5930", Offset = "0x64C4130", VA = "0x1864C5930")]
		private void CFBPGCKAKEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x64C5AD0", Offset = "0x64C42D0", VA = "0x1864C5AD0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x64C6010", Offset = "0x64C4810", VA = "0x1864C6010")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class POBBMDBGLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x64C4460", Offset = "0x64C2C60", VA = "0x1864C4460")]
	public static bool BKJBHKICBCB(this Transform PLIEEOJAEAM, Transform FAAJOMIIHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2A1C2A0", Offset = "0x2A1AAA0", VA = "0x182A1C2A0")]
	public static T OENGNEPFPAH<T>(this Component DJDDCFICJJN, bool ADAJHJNOOOJ = false) where T : class
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
		private const string OJBJIJNDGDM = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const string DGLKOEMCOAB = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const float GCBJKGCNGMH = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly List<UIAnchorFollower> EDFFAIMDGEI;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly IFEOEDLAFMF OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IFEOEDLAFMF OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static LLOKPPMEGNO LFGPPBPOOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private BGPIKFBGOJB PGPLMIOLKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Vector3 NICJHNIPFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion HCHPHLBKAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Vector3 NIIGBNBPMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private UIAnchor LPCBAHKJJCI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public UIAnchor DINBOMOCLLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6EB700", Offset = "0x6E9F00", VA = "0x1806EB700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private bool GEKHCAMDCMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1DC9DE0", Offset = "0x1DC85E0", VA = "0x181DC9DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x64C4E80", Offset = "0x64C3680", VA = "0x1864C4E80")]
		[FKLAFGEGFDL(FBKMDIMHGAB.Unity_AfterSceneLoad)]
		private static void ODGJJHFNDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x64C4F50", Offset = "0x64C3750", VA = "0x1864C4F50")]
		[GHKHCFMPNPN(HCEJJADFNPJ.ExitingPlayMode, 0)]
		private static void ODIECCKLJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x64C5150", Offset = "0x64C3950", VA = "0x1864C5150")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x64C4820", Offset = "0x64C3020", VA = "0x1864C4820", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x64C5020", Offset = "0x64C3820", VA = "0x1864C5020", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x64C4D30", Offset = "0x64C3530", VA = "0x1864C4D30")]
		public void Initialize(UIAnchor LPCBAHKJJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x64C50B0", Offset = "0x64C38B0", VA = "0x1864C50B0")]
		public void SetAnchorObjectEnabled(bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x64C5100", Offset = "0x64C3900", VA = "0x1864C5100")]
		public void SetCanvasRenderingEnabled(bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x64C4B50", Offset = "0x64C3350", VA = "0x1864C4B50")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x64C4D70", Offset = "0x64C3570", VA = "0x1864C4D70")]
		private void MPKDPPIKIKO(bool KEBPJDOCLJC, object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x64C4AD0", Offset = "0x64C32D0", VA = "0x1864C4AD0")]
		private void CGGAHANCOKA(bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x64C52C0", Offset = "0x64C3AC0", VA = "0x1864C52C0")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x64C4640", Offset = "0x64C2E40", VA = "0x1864C4640")]
		private void ADPGLHKKJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x64C5720", Offset = "0x64C3F20", VA = "0x1864C5720")]
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
		private sealed class HIJLCIHIHKI : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private MBIPJOOACNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public HIJLCIHIHKI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x64C3760", Offset = "0x64C1F60", VA = "0x1864C3760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x64C3850", Offset = "0x64C2050", VA = "0x1864C3850", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float ABGBMCDIKDE = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool LMCGAKAMHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int CEOIOGOEHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private PointerEventData BHALCGGHFGA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public global::CNOGLFLGNKP<PointerEventData> CPDHFKBBIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8E0", Offset = "0x6EE0E0", VA = "0x1806EF8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public global::CNOGLFLGNKP<PointerEventData> HCNGNLNBNBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public global::CNOGLFLGNKP<PointerEventData> KBAGPEFLENC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public global::CNOGLFLGNKP<PointerEventData> EMILCAJKCPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6DC580", Offset = "0x6DAD80", VA = "0x1806DC580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public global::CNOGLFLGNKP<PointerEventData> OJOJKBBKHCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6D50D0", Offset = "0x6D38D0", VA = "0x1806D50D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public global::CNOGLFLGNKP<PointerEventData> OLGOJHFDCDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6EB760", Offset = "0x6E9F60", VA = "0x1806EB760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public global::CNOGLFLGNKP<PointerEventData> JICKEPOIEHN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6D50B0", Offset = "0x6D38B0", VA = "0x1806D50B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x64C1660", Offset = "0x64BFE60", VA = "0x1864C1660", Slot = "4")]
		public void OnPointerClick(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x64C1990", Offset = "0x64C0190", VA = "0x1864C1990", Slot = "5")]
		public void OnPointerUp(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x64C16C0", Offset = "0x64BFEC0", VA = "0x1864C16C0", Slot = "6")]
		public void OnPointerDown(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64C15E0", Offset = "0x64BFDE0", VA = "0x1864C15E0")]
		[IteratorStateMachine(typeof(HIJLCIHIHKI))]
		private IEnumerator<MBIPJOOACNE> LFOJOAHGEPP(int CEOIOGOEHCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x64C1830", Offset = "0x64C0030", VA = "0x1864C1830", Slot = "7")]
		public void OnPointerEnter(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x64C18D0", Offset = "0x64C00D0", VA = "0x1864C18D0", Slot = "8")]
		public void OnPointerExit(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x64C14C0", Offset = "0x64BFCC0", VA = "0x1864C14C0")]
		private bool EHMOKKNMPLH(GameObject IMPKIJJJHKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x64C1A00", Offset = "0x64C0200", VA = "0x1864C1A00")]
		public Clickable()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x64C4180", Offset = "0x64C2980", VA = "0x1864C4180")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64C3E30", Offset = "0x64C2630", VA = "0x1864C3E30")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
