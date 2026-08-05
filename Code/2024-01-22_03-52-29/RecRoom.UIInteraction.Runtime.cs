using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JENEGHCBPHA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x676DE00", Offset = "0x676D200", VA = "0x18676DE00")]
	public static void NILNKCMPOAD(Component GHPJMKBNPML, bool FGKEMBDNNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x676DC80", Offset = "0x676D080", VA = "0x18676DC80")]
	public static void IINCKFAKKKN(Text BBHOPAFELHP, string ICHMPNFGJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x676DD00", Offset = "0x676D100", VA = "0x18676DD00")]
	public static void IINCKFAKKKN(TMP_Text BBHOPAFELHP, string ICHMPNFGJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x676DE90", Offset = "0x676D290", VA = "0x18676DE90")]
	public static void OMCHIFKJKHB(Image KBOKJLLMPHM, Sprite GOOJEJNMBFI, bool NOLPNPMBNFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x676DD80", Offset = "0x676D180", VA = "0x18676DD80")]
	public static void NIHIHGDMOFL(RawImage KBOKJLLMPHM, Texture2D PGJDHNNPIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x676DBF0", Offset = "0x676CFF0", VA = "0x18676DBF0")]
	public static void GJDEOLFDDFC(Graphic JALKPPILOEB, Color JKOGDMNIBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x676DF60", Offset = "0x676D360", VA = "0x18676DF60")]
	public static bool OMDPLCEKJDD(GameObject IFGJJHCIEPA)
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
		[CEJHJKODPLN(ELJJCPAPFEG.Self, false, false, false)]
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
		public readonly NFAKNFEBDCB<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly NFAKNFEBDCB<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LDFAODFBLEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x793FF0", Offset = "0x7933F0", VA = "0x180793FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IONOGODMKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B1DD0", Offset = "0x8B11D0", VA = "0x1808B1DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float CICAAHAAPJM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7FA910", Offset = "0x7F9D10", VA = "0x1807FA910")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform GAHPOKLEHHE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x676BF90", Offset = "0x676B390", VA = "0x18676BF90", Slot = "5")]
		public void OnDrag(PointerEventData FILLDNNEIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x676C010", Offset = "0x676B410", VA = "0x18676C010", Slot = "4")]
		public void OnScroll(PointerEventData FILLDNNEIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x676C090", Offset = "0x676B490", VA = "0x18676C090")]
		private Vector2 PCJKAEJDHNO(Vector2 DJJFEMOLJIL)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x676C0E0", Offset = "0x676B4E0", VA = "0x18676C0E0")]
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
		private struct IJEKAOCGOGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic DFGFHHKEJMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int OHBIEFPKIPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds KDANMJMHPOK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool FECDPMEDKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas PIANMGKIKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera POJMIAKPJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup NBMGJBKEAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool OJGPKHELHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private HKEJFCGKFCP NDMJGKNHNDB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> LMAOBOEMBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int IBMGEMDNCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<IJEKAOCGOGH> CCNLFLCLHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] FNICKDFKMDB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<IJEKAOCGOGH> FHMBIHJFKAN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FDFNMGPGGMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x676DB60", Offset = "0x676CF60", VA = "0x18676DB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool CHENOPEIMOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x676C2F0", Offset = "0x676B6F0", VA = "0x18676C2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera CAJJCEKNJBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x793ED0", Offset = "0x7932D0", VA = "0x180793ED0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x676C540", Offset = "0x676B940", VA = "0x18676C540", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x676DA20", Offset = "0x676CE20", VA = "0x18676DA20")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x676D290", Offset = "0x676C690", VA = "0x18676D290", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x676D300", Offset = "0x676C700", VA = "0x18676D300", Slot = "17")]
		public override void Raycast(PointerEventData FILLDNNEIPF, List<RaycastResult> JGMDIHMDADE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x676C600", Offset = "0x676BA00", VA = "0x18676C600")]
		protected void JKPDIMJFJFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x676C810", Offset = "0x676BC10", VA = "0x18676C810")]
		private void MLGONMFEPKB(Canvas FENPFIPHPIG, Camera CAJJCEKNJBC, Vector2 AHBGKCIFOOO, Ray PJLCCBIAGCO, List<Graphic> PCKKGIDDBDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x676D270", Offset = "0x676C670", VA = "0x18676D270", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x676C380", Offset = "0x676B780", VA = "0x18676C380")]
		public static Bounds GetBounds(Graphic GEBIGMANBLB, Vector3[] MALJJNCKAEE)
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
		[CEJHJKODPLN(ELJJCPAPFEG.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PEEHDGOMBAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE4F0", Offset = "0xAAD8F0", VA = "0x180AAE4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HKEJFCGKFCP
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray BLFHLECHKFO, [Out] Graphic DLBNGKIKGLB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable CBOEBDHAHCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HJKEOMJBAJM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera GAABFPNKIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DECPPMKECOG PKMOIHAKFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NFAKNFEBDCB<GameObject> GGHOAPCFFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	public class UIAnchor : UIBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[CEJHJKODPLN(ELJJCPAPFEG.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool CGMFIHELBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool OKLHDIAMAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool LDNENPDDBIL;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool HMJJLGIEBEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6771750", Offset = "0x6770B50", VA = "0x186771750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6771610", Offset = "0x6770A10", VA = "0x186771610", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6771C50", Offset = "0x6771050", VA = "0x186771C50", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6771C30", Offset = "0x6771030", VA = "0x186771C30", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6771B90", Offset = "0x6770F90", VA = "0x186771B90", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6771D70", Offset = "0x6771170", VA = "0x186771D70", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6771B70", Offset = "0x6770F70", VA = "0x186771B70", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6771E70", Offset = "0x6771270", VA = "0x186771E70")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6771C90", Offset = "0x6771090", VA = "0x186771C90")]
		public void SetFollowerConstraintEnabled(bool MKECFCAPOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67717B0", Offset = "0x6770BB0", VA = "0x1867717B0")]
		private void FOKPAFCBLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6771A50", Offset = "0x6770E50", VA = "0x186771A50")]
		private void OEJPGIDMECD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6771880", Offset = "0x6770C80", VA = "0x186771880")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6771EF0", Offset = "0x67712F0", VA = "0x186771EF0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EMJFHEELCPL
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x676C1B0", Offset = "0x676B5B0", VA = "0x18676C1B0")]
	public static bool AFAMBEDFAML(this Transform KDABCDIIADN, Transform AOGBEAODJPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x24D16E0", Offset = "0x24D0AE0", VA = "0x1824D16E0")]
	public static T LCCBHKAMOHA<T>(this Component GOOANMNBGEP, bool PLGLILLKHCM = false) where T : class
	{
		return null;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NDHFPMFMJKD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public UIAnchorFollowConstraint <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private Vector3 <initialPosition>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Vector3 <initialRotationEuler>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private bool <doMove>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private bool <doRotate>5__5;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
			[DebuggerHidden]
			public NDHFPMFMJKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x676EE30", Offset = "0x676E230", VA = "0x18676EE30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x676E140", Offset = "0x676D540", VA = "0x18676E140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x676EDA0", Offset = "0x676E1A0", VA = "0x18676EDA0")]
			private void OPFNICOLGEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x676EDE0", Offset = "0x676E1E0", VA = "0x18676EDE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[Tooltip("Curve that describes the rate of follow motion at different points in the follow (e.g.- ease in and out when starting or stopping the motion).")]
		private AnimationCurve easingCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("How much can the UI anchor move (in meters) before this object starts following it.")]
		private float followPositionThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Tooltip("How much can the UI anchor rotate (in degrees) before this object starts following it.")]
		private float followRotationThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		[Tooltip("The maximum speed (in meters/second) that the UI anchor follower move when following the anchor.")]
		private float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Tooltip("The maximum speed (in degrees/second) that the UI anchor follower rotate when following the anchor.")]
		private float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("The position delta (in meters) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float easingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("The rotation delta (in degrees) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float rotationEasingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the X-axis.")]
		private bool allowXRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Y-axis.")]
		private bool allowYRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Z-axis.")]
		private bool allowZRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private float maxAllowedVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Vector3 ODFEADMFNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Quaternion BHPMBNCGBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Coroutine NEGFBIAKEJM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float BPCOHHDBJDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8B7AF0", Offset = "0x8B6EF0", VA = "0x1808B7AF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x676F740", Offset = "0x676EB40", VA = "0x18676F740")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB634C0", Offset = "0xB628C0", VA = "0x180B634C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x676F860", Offset = "0x676EC60", VA = "0x18676F860")]
		public void SetTarget(Vector3 BCGGHPIMKDA, Quaternion GIJALKLADPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x676F010", Offset = "0x676E410", VA = "0x18676F010")]
		[IteratorStateMachine(typeof(NDHFPMFMJKD))]
		private IEnumerator ELOKKLENNLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x676F380", Offset = "0x676E780", VA = "0x18676F380")]
		private float FDOFGDFIEMF(float LJJNCBAPDNA, Vector3 GNKNDANMFBB, Vector3 MEJDMKBJDPB, float JKJBOHPDICH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x676F510", Offset = "0x676E910", VA = "0x18676F510")]
		private float FDOFGDFIEMF(float LJJNCBAPDNA, float COKOHPLGDGD, float FDJHKBEEDFO, float JKJBOHPDICH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x676EF30", Offset = "0x676E330", VA = "0x18676EF30")]
		private Vector3 CLNJJGIKOJJ(Vector3 LENKKFOFMMJ, Vector3 EBFOLDKBDJP, Vector3 PLJNLCOFMBP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x676F710", Offset = "0x676EB10", VA = "0x18676F710")]
		private bool HNEIHIPIHHA(float AJLBCMDFHAC, float EBFOLDKBDJP, float PLJNLCOFMBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x676F5A0", Offset = "0x676E9A0", VA = "0x18676F5A0")]
		private Vector3 FKIICMKMANF(Quaternion GIJALKLADPN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x676F680", Offset = "0x676EA80", VA = "0x18676F680")]
		private bool HMGJHIGLILN(Vector3 BCGGHPIMKDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x676F090", Offset = "0x676E490", VA = "0x18676F090")]
		private bool EPJCPMNMPAJ(Quaternion GIJALKLADPN, bool BGHDILNIPLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x676F810", Offset = "0x676EC10", VA = "0x18676F810")]
		private bool PKCAEPLGFEB(Vector3 KKNFIGGNDFK, Vector3 PPBIBECNBNN, float BMHKAMMEIHF = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x676F7B0", Offset = "0x676EBB0", VA = "0x18676F7B0")]
		private bool PKCAEPLGFEB(Quaternion KKNFIGGNDFK, Quaternion PPBIBECNBNN, float BMHKAMMEIHF = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x676FA80", Offset = "0x676EE80", VA = "0x18676FA80")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string LIKFIAONHLM = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string FEJLMMDGBDK = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float BAOPOKIEKBL = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly List<UIAnchorFollower> DKGKIKFDKOB;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly DECPPMKECOG OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly DECPPMKECOG OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static HJKEOMJBAJM PLJFECMMJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[CEJHJKODPLN(ELJJCPAPFEG.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[CEJHJKODPLN(ELJJCPAPFEG.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private UIAnchorFollowConstraint followConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GDJEDKCANMC AILFEJPEIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Vector3 BGDBFFAICPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Quaternion AAHGNIPDBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 CPMFJBIILEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool PJPCIEOOMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool JJIBEKLEFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool MPOAPCHAKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 HCAOEEOHFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private UIAnchor MPLDDLGNCAG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private bool PDBDGGBOKNC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6770690", Offset = "0x676FA90", VA = "0x186770690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public UIAnchor GOBNIDHBIMF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x78F280", Offset = "0x78E680", VA = "0x18078F280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool FBNIDEGIFHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x67703C0", Offset = "0x676F7C0", VA = "0x1867703C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6770120", Offset = "0x676F520", VA = "0x186770120")]
		[PFGHMHCOGDP(HCKINNNGEKD.Unity_AfterSceneLoad)]
		private static void FILODNFGCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x67705B0", Offset = "0x676F9B0", VA = "0x1867705B0")]
		[ENPAFNLIOMH(MAAKBDKIBHC.ExitingPlayMode, 0)]
		private static void HEPEJPFCJHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6770B70", Offset = "0x676FF70", VA = "0x186770B70")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x676FB80", Offset = "0x676EF80", VA = "0x18676FB80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6770820", Offset = "0x676FC20", VA = "0x186770820", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x67706B0", Offset = "0x676FAB0", VA = "0x1867706B0")]
		public void Initialize(UIAnchor MPLDDLGNCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x67709F0", Offset = "0x676FDF0", VA = "0x1867709F0")]
		public void SetAnchorObjectEnabled(bool MKECFCAPOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6770A40", Offset = "0x676FE40", VA = "0x186770A40")]
		public void SetCanvasRenderingEnabled(bool MKECFCAPOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x67703F0", Offset = "0x676F7F0", VA = "0x1867703F0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x676FE70", Offset = "0x676F270", VA = "0x18676FE70")]
		private void BMLDKHBLMEP(bool MKECFCAPOLO, object KNOHBODGPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6770740", Offset = "0x676FB40", VA = "0x186770740")]
		private void KKCHGLFHBGN(bool MKECFCAPOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6770CE0", Offset = "0x67700E0", VA = "0x186770CE0")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6770B00", Offset = "0x676FF00", VA = "0x186770B00")]
		public void SetConstraintEnabled(bool MKECFCAPOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6770A90", Offset = "0x676FE90", VA = "0x186770A90")]
		public void SetConstraintAllowed(bool NDFNPGIOGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x676FFE0", Offset = "0x676F3E0", VA = "0x18676FFE0")]
		private bool EPHMFJGNAIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6770200", Offset = "0x676F600", VA = "0x186770200")]
		private void FOEMIOOOGNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x67714F0", Offset = "0x67708F0", VA = "0x1867714F0")]
		public UIAnchorFollower()
		{
		}
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class APKDDMLIMJA : IEnumerator<LEOLCGBMIAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private LEOLCGBMIAN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private LEOLCGBMIAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
			[DebuggerHidden]
			public APKDDMLIMJA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x676B740", Offset = "0x676AB40", VA = "0x18676B740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x676B810", Offset = "0x676AC10", VA = "0x18676B810", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float JFPCGFIENJD = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool KCGNNIDIHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int HDLBDILGHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PointerEventData GFNCMBNGAIM;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public NFAKNFEBDCB<PointerEventData> KGMGMBFHAAA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public NFAKNFEBDCB<PointerEventData> JLBLKHCLGIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public NFAKNFEBDCB<PointerEventData> OABBJFPFEEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x793ED0", Offset = "0x7932D0", VA = "0x180793ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NFAKNFEBDCB<PointerEventData> DHBEJEEPKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x793E80", Offset = "0x793280", VA = "0x180793E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NFAKNFEBDCB<PointerEventData> JBADOEHFAFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x78F350", Offset = "0x78E750", VA = "0x18078F350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NFAKNFEBDCB<PointerEventData> LFNNMJKANHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x792F30", Offset = "0x792330", VA = "0x180792F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NFAKNFEBDCB<PointerEventData> EIAFFFBOAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x792F40", Offset = "0x792340", VA = "0x180792F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x676BA00", Offset = "0x676AE00", VA = "0x18676BA00", Slot = "4")]
		public void OnPointerClick(PointerEventData FILLDNNEIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x676BD30", Offset = "0x676B130", VA = "0x18676BD30", Slot = "5")]
		public void OnPointerUp(PointerEventData FILLDNNEIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x676BA60", Offset = "0x676AE60", VA = "0x18676BA60", Slot = "6")]
		public void OnPointerDown(PointerEventData FILLDNNEIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x676B970", Offset = "0x676AD70", VA = "0x18676B970")]
		[IteratorStateMachine(typeof(APKDDMLIMJA))]
		private IEnumerator<LEOLCGBMIAN> MIIACHNHPIH(int HDLBDILGHNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x676BBD0", Offset = "0x676AFD0", VA = "0x18676BBD0", Slot = "7")]
		public void OnPointerEnter(PointerEventData FILLDNNEIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x676BC70", Offset = "0x676B070", VA = "0x18676BC70", Slot = "8")]
		public void OnPointerExit(PointerEventData FILLDNNEIPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x676B860", Offset = "0x676AC60", VA = "0x18676B860")]
		private bool AOBHFHDAKJJ(GameObject IFGJJHCIEPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x676BDA0", Offset = "0x676B1A0", VA = "0x18676BDA0")]
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
