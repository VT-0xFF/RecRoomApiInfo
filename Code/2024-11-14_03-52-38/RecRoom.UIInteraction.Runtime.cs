using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using TMPro;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_UIInteraction_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x77241E0", Offset = "0x77235E0", VA = "0x1877241E0", Slot = "8")]
		public override void LFFFLDDGBMJ(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PJBADMHHLAN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7720400", Offset = "0x771F800", VA = "0x187720400")]
	public static void ADJJFKFCABL(Component COMALCPHDMG, bool PNJBBPJHGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x77207A0", Offset = "0x771FBA0", VA = "0x1877207A0")]
	public static void FAENBHCEOIL(Text OMEGOOPJHDI, string KJNFHDLCDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7720720", Offset = "0x771FB20", VA = "0x187720720")]
	public static void FAENBHCEOIL(TMP_Text OMEGOOPJHDI, string KJNFHDLCDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x77208A0", Offset = "0x771FCA0", VA = "0x1877208A0")]
	public static void PCMDANJIENO(Image MNMJDLBNGFD, Sprite OKEOJEEBKOK, bool LOPLBAKOJND = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7720820", Offset = "0x771FC20", VA = "0x187720820")]
	public static void LANCIFEGCJO(RawImage MNMJDLBNGFD, Texture2D LGMOHAIKHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7720690", Offset = "0x771FA90", VA = "0x187720690")]
	public static void EEIKJINDLCM(Graphic DPAFKAEECLO, Color FKCCOIADMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7720490", Offset = "0x771F890", VA = "0x187720490")]
	public static bool EDPLAJFDHFO(GameObject NEMCGAENDDH)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class DragScrollDecorator : MonoBehaviour, IScrollHandler, IEventSystemHandler, IDragHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
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
		public readonly EJELNBCCPAC<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly EJELNBCCPAC<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BOABDKDDCCP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8A1FC0", Offset = "0x8A13C0", VA = "0x1808A1FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NMNEJDOIFEA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xDDFFC0", Offset = "0xDDF3C0", VA = "0x180DDFFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float FOGOLGHICPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB92A50", Offset = "0xB91E50", VA = "0x180B92A50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform IJJIKOABALG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x771E570", Offset = "0x771D970", VA = "0x18771E570", Slot = "5")]
		public void OnDrag(PointerEventData KKIOOCHBIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x771E5F0", Offset = "0x771D9F0", VA = "0x18771E5F0", Slot = "4")]
		public void OnScroll(PointerEventData KKIOOCHBIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x771E520", Offset = "0x771D920", VA = "0x18771E520")]
		private Vector2 DGJMCGMBMJN(Vector2 OMILCGJNOPM)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x771E670", Offset = "0x771DA70", VA = "0x18771E670")]
		public DragScrollDecorator()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("Event/Fast Graphic Raycaster")]
	[RequireComponent(typeof(Canvas))]
	public class FastGraphicRaycaster : BaseRaycaster
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private struct NFDOJLBOGBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Graphic CKMMBMIINJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public int FMBFFMGHCEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Bounds GLGADAGEJMJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker HDEKEHMEHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool NBGMGOEMPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Canvas MMGFBGDFMPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Camera HJFMKCLFIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private FastGraphicRaycasterGroup EMEDHKLOAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool ODPHGANGKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IAMBBADEFNH KPKNIKLFHIL;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<Graphic> BHIHBHFKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int CABBHMCGKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<NFDOJLBOGBP> FJHKAEPLHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Vector3[] IBMGEFLNEKE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<NFDOJLBOGBP> LKIPJLIFBDC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IDKKOHPNOJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7720230", Offset = "0x771F630", VA = "0x187720230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool HJNAFKEKNDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x771EBD0", Offset = "0x771DFD0", VA = "0x18771EBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera HGDKNLPFCGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x771EB10", Offset = "0x771DF10", VA = "0x18771EB10", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x77200F0", Offset = "0x771F4F0", VA = "0x1877200F0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x771F710", Offset = "0x771EB10", VA = "0x18771F710", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x771F7C0", Offset = "0x771EBC0", VA = "0x18771F7C0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x771F830", Offset = "0x771EC30", VA = "0x18771F830", Slot = "17")]
		public override void Raycast(PointerEventData KKIOOCHBIJO, List<RaycastResult> BGHKJLONGJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x771E740", Offset = "0x771DB40", VA = "0x18771E740")]
		protected void CPMMOAJDMGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x771EC60", Offset = "0x771E060", VA = "0x18771EC60")]
		private void JDJGCENCHGO(Canvas LNOBCAHDGKO, Camera HGDKNLPFCGO, Vector2 PEDIKDOCLEA, Ray CEMEGDKOMEP, List<Graphic> NGOGOFCOAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x771F6F0", Offset = "0x771EAF0", VA = "0x18771F6F0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x771E950", Offset = "0x771DD50", VA = "0x18771E950")]
		public static Bounds GetBounds(Graphic ENLCABFJIOK, Vector3[] DDCEGGHIDKN)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FastGraphicRaycasterGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PFAKIKACPFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5E40B20", Offset = "0x5E3FF20", VA = "0x185E40B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IAMBBADEFNH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray JCAJDCBECDC, [Out] Graphic OCFMLMLMHAC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable GGKEELAEOMC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AHBHIANGHEO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera KEPJLLFHLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BDDIJCFMLKF HFMJNHEDCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EJELNBCCPAC<GameObject> FIAPBMGPMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
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
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[PCIEPDMGHOH(AHBKOCJDDCB.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool IGFOOFIBCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool BJDEHFBEHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool MGLJGFBILJN;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool EHHENPEELIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7723D90", Offset = "0x7723190", VA = "0x187723D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7723850", Offset = "0x7722C50", VA = "0x187723850", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7723ED0", Offset = "0x77232D0", VA = "0x187723ED0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7723EB0", Offset = "0x77232B0", VA = "0x187723EB0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7723E10", Offset = "0x7723210", VA = "0x187723E10", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7723FF0", Offset = "0x77233F0", VA = "0x187723FF0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7723DF0", Offset = "0x77231F0", VA = "0x187723DF0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7724110", Offset = "0x7723510", VA = "0x187724110")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7723F10", Offset = "0x7723310", VA = "0x187723F10")]
		public void SetFollowerConstraintEnabled(bool FCINDJJJBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7723AD0", Offset = "0x7722ED0", VA = "0x187723AD0")]
		private void CKJBBDFIGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x77239B0", Offset = "0x7722DB0", VA = "0x1877239B0")]
		private void BNJECMPOHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7723BA0", Offset = "0x7722FA0", VA = "0x187723BA0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7724190", Offset = "0x7723590", VA = "0x187724190")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LMMFKEKMMMO
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77202C0", Offset = "0x771F6C0", VA = "0x1877202C0")]
	public static bool MPNEMJCOJLJ(this Transform KFLLLPCKFFO, Transform EGIKLIBGODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4520", Offset = "0x2FA3920", VA = "0x182FA4520")]
	public static T NKCKCCDHPDE<T>(this Component KLACLBHAHNL, bool KLKOPMFDPOO = false) where T : class
	{
		return null;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BPJDMHICAJK : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public UIAnchorFollowConstraint <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Vector3 <initialPosition>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private Vector3 <initialRotationEuler>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private bool <doMove>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool <doRotate>5__5;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004C")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public BPJDMHICAJK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x771DC50", Offset = "0x771D050", VA = "0x18771DC50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x771CFA0", Offset = "0x771C3A0", VA = "0x18771CFA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x771CF60", Offset = "0x771C360", VA = "0x18771CF60")]
			private void KAONCANHJBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x771DC00", Offset = "0x771D000", VA = "0x18771DC00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("Curve that describes the rate of follow motion at different points in the follow (e.g.- ease in and out when starting or stopping the motion).")]
		private AnimationCurve easingCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Tooltip("How much can the UI anchor move (in meters) before this object starts following it.")]
		private float followPositionThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		[Tooltip("How much can the UI anchor rotate (in degrees) before this object starts following it.")]
		private float followRotationThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Tooltip("The maximum speed (in meters/second) that the UI anchor follower move when following the anchor.")]
		private float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("The maximum speed (in degrees/second) that the UI anchor follower rotate when following the anchor.")]
		private float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("The position delta (in meters) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		[SerializeField]
		private float easingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("The rotation delta (in degrees) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		[SerializeField]
		private float rotationEasingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the X-axis.")]
		private bool allowXRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("Whether this object should match any rotation along the Y-axis.")]
		[SerializeField]
		private bool allowYRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Z-axis.")]
		private bool allowZRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private float maxAllowedVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Vector3 LFLGBLJBCAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Quaternion PFIIJNABFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Coroutine FLKJKBFKGBA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float LLNIJNLDKLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA9B870", Offset = "0xA9AC70", VA = "0x180A9B870")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool IKKFEFBDIKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5DA86D0", Offset = "0x5DA7AD0", VA = "0x185DA86D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77212A0", Offset = "0x77206A0", VA = "0x1877212A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x10CCEA0", Offset = "0x10CC2A0", VA = "0x1810CCEA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7721310", Offset = "0x7720710", VA = "0x187721310")]
		public void SetTarget(Vector3 OGKCMCMHLOD, Quaternion GEMHEIIKJKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7720AD0", Offset = "0x771FED0", VA = "0x187720AD0")]
		[IteratorStateMachine(typeof(BPJDMHICAJK))]
		private IEnumerator ECCJKFPEELE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7721000", Offset = "0x7720400", VA = "0x187721000")]
		private float HGNDIOMNPBG(float FFFHPHJACAD, Vector3 AFFNGGKBHJL, Vector3 DBJNKPMHBNE, float CBIHIMBCJJH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7720F70", Offset = "0x7720370", VA = "0x187720F70")]
		private float HGNDIOMNPBG(float FFFHPHJACAD, float DEFCPPJOEIP, float NDFIDCOBNHL, float CBIHIMBCJJH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77209F0", Offset = "0x771FDF0", VA = "0x1877209F0")]
		private Vector3 ABLCLDLDEGL(Vector3 DKEOGKADJDG, Vector3 CCGEFIKPADI, Vector3 KACCFANBELL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7721270", Offset = "0x7720670", VA = "0x187721270")]
		private bool OALDBIEOHMJ(float HHLPCCPCMEJ, float CCGEFIKPADI, float KACCFANBELL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7721190", Offset = "0x7720590", VA = "0x187721190")]
		private Vector3 NNJGKDIMJNE(Quaternion GEMHEIIKJKD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7720E30", Offset = "0x7720230", VA = "0x187720E30")]
		private bool GKHILFCNAID(Vector3 OGKCMCMHLOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7720B50", Offset = "0x771FF50", VA = "0x187720B50")]
		private bool FMDAOGHKKFO(Quaternion GEMHEIIKJKD, bool KJKAPDIKGGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7720F20", Offset = "0x7720320", VA = "0x187720F20")]
		private bool GOPMBIMMHNI(Vector3 MMHCOKHACHF, Vector3 DEOGINMLLDP, float LEJDKGIOJFB = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7720EC0", Offset = "0x77202C0", VA = "0x187720EC0")]
		private bool GOPMBIMMHNI(Quaternion MMHCOKHACHF, Quaternion DEOGINMLLDP, float LEJDKGIOJFB = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7721530", Offset = "0x7720930", VA = "0x187721530")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum MMFNHKFKIBM
		{
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			UIRaycast,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Render
		}

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string KGKDPLKNBMO = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string NIBLHAAMPEP = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const float MHEPMEILPAM = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly List<UIAnchorFollower> FEONPANIHFO;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly BDDIJCFMLKF OnUIAnchorsUpdated;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static AHBHIANGHEO FAKAHNNCCGH;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static int AMPLJOLGMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly BDDIJCFMLKF OnSyncTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
		[SerializeField]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		[SerializeField]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private UIAnchorFollowConstraint followConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JLCPCMNKJOG FFCCNKNLHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 LBNGDGAIKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Quaternion DJOOONFMJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 KDPMLGPBIPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool KCPCDKPCCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool ACJOPLFFCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool PGDOMBKILHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 HLBEAIHOBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private OLLILMFFDHE HIDILJBLNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private Transform KHBDEMOBGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private UIAnchor FMJFDIEJEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static ProfilerMarker MOMMGLAPJBO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private bool LLCPGLEOPFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7722360", Offset = "0x7721760", VA = "0x187722360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private Transform JGDFNKEDOMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7721BA0", Offset = "0x7720FA0", VA = "0x187721BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public UIAnchor MDEGEEHOGJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x89FBC0", Offset = "0x89EFC0", VA = "0x18089FBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool KLOLPCLIIKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7722460", Offset = "0x7721860", VA = "0x187722460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7722490", Offset = "0x7721890", VA = "0x187722490")]
		[BEJKEFNNDNF]
		internal static void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7722280", Offset = "0x7721680", VA = "0x187722280")]
		[DOKEIHGOPGG(AFDHANBPPBK.ExitingPlayMode, 0)]
		private static void JJHBPEBHDLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x77228C0", Offset = "0x7721CC0", VA = "0x1877228C0")]
		public static void SyncAllFollowers(MMFNHKFKIBM EPLPPJHJIIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7722180", Offset = "0x7721580", VA = "0x187722180")]
		private static void IJCEHLCDJLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7721FF0", Offset = "0x77213F0", VA = "0x187721FF0")]
		private static void GBJDLIACBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7721630", Offset = "0x7720A30", VA = "0x187721630", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7722570", Offset = "0x7721970", VA = "0x187722570", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x77221D0", Offset = "0x77215D0", VA = "0x1877221D0")]
		public void Initialize(UIAnchor FMJFDIEJEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7722740", Offset = "0x7721B40", VA = "0x187722740")]
		public void SetAnchorObjectEnabled(bool FCINDJJJBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7722790", Offset = "0x7721B90", VA = "0x187722790")]
		public void SetCanvasRenderingEnabled(bool FCINDJJJBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7721E00", Offset = "0x7721200", VA = "0x187721E00")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7721A30", Offset = "0x7720E30", VA = "0x187721A30")]
		private void EDIJPMMPHJD(bool FCINDJJJBNF, object CFGHNHCDKCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7722380", Offset = "0x7721780", VA = "0x187722380")]
		private void KJBOJJJPIMA(bool FCINDJJJBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7722C20", Offset = "0x7722020", VA = "0x187722C20")]
		public bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7722850", Offset = "0x7721C50", VA = "0x187722850")]
		public void SetConstraintEnabled(bool FCINDJJJBNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x77227E0", Offset = "0x7721BE0", VA = "0x1877227E0")]
		public void SetConstraintAllowed(bool AAFGADDMAGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7722040", Offset = "0x7721440", VA = "0x187722040")]
		private bool IHNKDIKFNCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7721BF0", Offset = "0x7720FF0", VA = "0x187721BF0")]
		private void FHHHHMDEOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7723710", Offset = "0x7722B10", VA = "0x187723710")]
		public UIAnchorFollower()
		{
		}
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DKEIMCGCNND : IEnumerator<MLEAAPMIINP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private MLEAAPMIINP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private MLEAAPMIINP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
			[DebuggerHidden]
			public DKEIMCGCNND(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x771E400", Offset = "0x771D800", VA = "0x18771E400", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x771E4D0", Offset = "0x771D8D0", VA = "0x18771E4D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const float AKAPLLFHDGF = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool KCDJDELACLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int CKMGHLEKIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private PointerEventData GLEEAPCBGPF;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public EJELNBCCPAC<PointerEventData> ACGBFKBOMFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public EJELNBCCPAC<PointerEventData> DGDFNCAOJIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public EJELNBCCPAC<PointerEventData> KICEKFELFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public EJELNBCCPAC<PointerEventData> MFNJKCLPFMD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8A0F80", Offset = "0x8A0380", VA = "0x1808A0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public EJELNBCCPAC<PointerEventData> GAOBFJKFIOG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x89FDB0", Offset = "0x89F1B0", VA = "0x18089FDB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public EJELNBCCPAC<PointerEventData> BOLJBBOCJEF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x89D950", Offset = "0x89CD50", VA = "0x18089D950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public EJELNBCCPAC<PointerEventData> LFIEPJHCACO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x89D960", Offset = "0x89CD60", VA = "0x18089D960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x771DE70", Offset = "0x771D270", VA = "0x18771DE70", Slot = "4")]
		public void OnPointerClick(PointerEventData KKIOOCHBIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x771E1A0", Offset = "0x771D5A0", VA = "0x18771E1A0", Slot = "5")]
		public void OnPointerUp(PointerEventData KKIOOCHBIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x771DED0", Offset = "0x771D2D0", VA = "0x18771DED0", Slot = "6")]
		public void OnPointerDown(PointerEventData KKIOOCHBIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x771DCD0", Offset = "0x771D0D0", VA = "0x18771DCD0")]
		[IteratorStateMachine(typeof(DKEIMCGCNND))]
		private IEnumerator<MLEAAPMIINP> KHEOIADKMPA(int CKMGHLEKIIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x771E040", Offset = "0x771D440", VA = "0x18771E040", Slot = "7")]
		public void OnPointerEnter(PointerEventData KKIOOCHBIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x771E0E0", Offset = "0x771D4E0", VA = "0x18771E0E0", Slot = "8")]
		public void OnPointerExit(PointerEventData KKIOOCHBIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x771DD60", Offset = "0x771D160", VA = "0x18771DD60")]
		private bool NKBMIIPPFPF(GameObject NEMCGAENDDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x771E210", Offset = "0x771D610", VA = "0x18771E210")]
		public Clickable()
		{
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
