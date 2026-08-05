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
public static class NABNOOKICAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A50C20", Offset = "0x6A4FC20", VA = "0x186A50C20")]
	public static void IDHDHCNDCBD(Component HDIPHGOKDCK, bool JDPFGDIKIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A50D80", Offset = "0x6A4FD80", VA = "0x186A50D80")]
	public static void KBKEFJHFDAL(Text ACAAANNJCLO, string ONPLBJHGAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A50E00", Offset = "0x6A4FE00", VA = "0x186A50E00")]
	public static void KBKEFJHFDAL(TMP_Text ACAAANNJCLO, string ONPLBJHGAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A50CB0", Offset = "0x6A4FCB0", VA = "0x186A50CB0")]
	public static void KBHADGGIODJ(Image JMEDGMAHDFE, Sprite AHLMFCCAIMK, bool OEFPGNFGFFM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A50E80", Offset = "0x6A4FE80", VA = "0x186A50E80")]
	public static void MLBDFCALKAG(RawImage JMEDGMAHDFE, Texture2D INGLEABGJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A50F00", Offset = "0x6A4FF00", VA = "0x186A50F00")]
	public static void OMPMBKLCIII(Graphic HAHBMDIOGDJ, Color DDCPEHLFHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A50A40", Offset = "0x6A4FA40", VA = "0x186A50A40")]
	public static bool DFAHCGMHNLG(GameObject LNIPGKDIFCK)
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
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
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
		public readonly MDKLHFICKPP<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly MDKLHFICKPP<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NHEAJOHLPON
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7BC460", Offset = "0x7BB460", VA = "0x1807BC460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LKEMJCHMJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x935EB0", Offset = "0x934EB0", VA = "0x180935EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float GMDILDPNKLF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x867690", Offset = "0x866690", VA = "0x180867690")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform GHAGDDPJHJO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A4ED10", Offset = "0x6A4DD10", VA = "0x186A4ED10", Slot = "5")]
		public void OnDrag(PointerEventData KGGAPJLLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A4ED90", Offset = "0x6A4DD90", VA = "0x186A4ED90", Slot = "4")]
		public void OnScroll(PointerEventData KGGAPJLLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4ECC0", Offset = "0x6A4DCC0", VA = "0x186A4ECC0")]
		private Vector2 FIGFLFLNBHM(Vector2 BJLJIJAPMHP)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EE10", Offset = "0x6A4DE10", VA = "0x186A4EE10")]
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
		private struct ANGKGMDCLCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic OMDHAPDIFHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int FPDENPKHNBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds OOOHNKEOMNF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool CIIHJFAIBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas KMDFGAFGNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera PBIOMOPJNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup FGDDGBNPFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool KNKNMCJBEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private CLGCCILEFPF FDNINOGJMMP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> BJIJGJLHEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int AKCHOJEGBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<ANGKGMDCLCP> HBEHFCJDPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] CHJNPGLEOGK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<ANGKGMDCLCP> ANKGNHOCCNF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KECMNOEPNJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6A50750", Offset = "0x6A4F750", VA = "0x186A50750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool JKEAELGHAON
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6A4EEE0", Offset = "0x6A4DEE0", VA = "0x186A4EEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera EMMBJFPBHFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FDA0", Offset = "0x6A4EDA0", VA = "0x186A4FDA0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A50610", Offset = "0x6A4F610", VA = "0x186A50610")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FE80", Offset = "0x6A4EE80", VA = "0x186A4FE80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FEF0", Offset = "0x6A4EEF0", VA = "0x186A4FEF0", Slot = "17")]
		public override void Raycast(PointerEventData KGGAPJLLPNF, List<RaycastResult> KELDPCEDKJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EF70", Offset = "0x6A4DF70", VA = "0x186A4EF70")]
		protected void DFDLNMOMHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F340", Offset = "0x6A4E340", VA = "0x186A4F340")]
		private void HACMACIEHCJ(Canvas ACFNCHMEJCN, Camera EMMBJFPBHFE, Vector2 GFDKEEHDLNN, Ray IIFNOIHCFME, List<Graphic> EHLPNPCDCBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FE60", Offset = "0x6A4EE60", VA = "0x186A4FE60", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F180", Offset = "0x6A4E180", VA = "0x186A4F180")]
		public static Bounds GetBounds(Graphic AIAGFCPBNID, Vector3[] ADIFAICGMAG)
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
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EJJDCENODGP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xC27070", Offset = "0xC26070", VA = "0x180C27070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CLGCCILEFPF
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray LDMBNGCPEPM, [Out] Graphic IAADGJJOILN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable PMDOMHALIJG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NHKPLHMJECC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera GACIBIKAMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LHMMLLGDOFK LDHDFABDKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MDKLHFICKPP<GameObject> EGIMNJMJPCH
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
		[JMOFFDBDEHI(HLBGFFAONPF.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool GJOKMKLCCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool CBLGAPDPMGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool AOHFPCMCBLA;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool GEJCENLKCCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6A54670", Offset = "0x6A53670", VA = "0x186A54670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6A54530", Offset = "0x6A53530", VA = "0x186A54530", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A54AA0", Offset = "0x6A53AA0", VA = "0x186A54AA0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A54A80", Offset = "0x6A53A80", VA = "0x186A54A80", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A549E0", Offset = "0x6A539E0", VA = "0x186A549E0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A54BC0", Offset = "0x6A53BC0", VA = "0x186A54BC0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A549C0", Offset = "0x6A539C0", VA = "0x186A549C0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A54CC0", Offset = "0x6A53CC0", VA = "0x186A54CC0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A54AE0", Offset = "0x6A53AE0", VA = "0x186A54AE0")]
		public void SetFollowerConstraintEnabled(bool PNLCCPNIGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A54460", Offset = "0x6A53460", VA = "0x186A54460")]
		private void ADNODOFHCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A546D0", Offset = "0x6A536D0", VA = "0x186A546D0")]
		private void DNMHJBJFLMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A547F0", Offset = "0x6A537F0", VA = "0x186A547F0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A54D40", Offset = "0x6A53D40", VA = "0x186A54D40")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GGIIFLEPEEB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A507E0", Offset = "0x6A4F7E0", VA = "0x186A507E0")]
	public static bool HKIIAECNHCG(this Transform ONPHKLFILKP, Transform MMPNPJILHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2798A60", Offset = "0x2797A60", VA = "0x182798A60")]
	public static T NEGOJIEIMDA<T>(this Component PGJBCOPPFBK, bool KPEFJOBHHBM = false) where T : class
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
		private sealed class PDOIDLBMBGJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
			[DebuggerHidden]
			public PDOIDLBMBGJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6A51C80", Offset = "0x6A50C80", VA = "0x186A51C80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6A50FD0", Offset = "0x6A4FFD0", VA = "0x186A50FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6A50F90", Offset = "0x6A4FF90", VA = "0x186A50F90")]
			private void GFMFCNEFFMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6A51C30", Offset = "0x6A50C30", VA = "0x186A51C30", Slot = "8")]
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
		private Vector3 BBLPJCAILJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Quaternion BJGCHNMAADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Coroutine CEAIICGCFEF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float GPIILIMDBDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x93B670", Offset = "0x93A670", VA = "0x18093B670")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A52350", Offset = "0x6A51350", VA = "0x186A52350")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xBFE200", Offset = "0xBFD200", VA = "0x180BFE200")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A526B0", Offset = "0x6A516B0", VA = "0x186A526B0")]
		public void SetTarget(Vector3 PKDBIHBDKOO, Quaternion GOAHENPPMCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6A51E60", Offset = "0x6A50E60", VA = "0x186A51E60")]
		[IteratorStateMachine(typeof(PDOIDLBMBGJ))]
		private IEnumerator DCEHJCLICAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6A521C0", Offset = "0x6A511C0", VA = "0x186A521C0")]
		private float OHIFHHGNGFD(float LNEJHBNJAFA, Vector3 AHLKGDDHNNA, Vector3 AEGGNJLJNAB, float INLBGPNEMLP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A52130", Offset = "0x6A51130", VA = "0x186A52130")]
		private float OHIFHHGNGFD(float LNEJHBNJAFA, float PDBJCHDPHFD, float HEMEOOMKGDD, float INLBGPNEMLP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6A51D80", Offset = "0x6A50D80", VA = "0x186A51D80")]
		private Vector3 CFDGFFNPGNA(Vector3 BJGFGACJMCM, Vector3 BDHDJIPOCAA, Vector3 PKIECLPJPAP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6A52020", Offset = "0x6A51020", VA = "0x186A52020")]
		private bool KGBLAAMAAFF(float GMAICFHLBBK, float BDHDJIPOCAA, float PKIECLPJPAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A52050", Offset = "0x6A51050", VA = "0x186A52050")]
		private Vector3 MCNOJJKGKEM(Quaternion GOAHENPPMCD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A51EE0", Offset = "0x6A50EE0", VA = "0x186A51EE0")]
		private bool EOHIOAEILJK(Vector3 PKDBIHBDKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A523C0", Offset = "0x6A513C0", VA = "0x186A523C0")]
		private bool PNKAOOOLOKE(Quaternion GOAHENPPMCD, bool FPEBHNFHFPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6A51F70", Offset = "0x6A50F70", VA = "0x186A51F70")]
		private bool FBDJMBNKMEL(Vector3 JAIIDLBPFND, Vector3 ECFHNKKEKBJ, float DACFOJIHNEM = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A51FC0", Offset = "0x6A50FC0", VA = "0x186A51FC0")]
		private bool FBDJMBNKMEL(Quaternion JAIIDLBPFND, Quaternion ECFHNKKEKBJ, float DACFOJIHNEM = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6A528D0", Offset = "0x6A518D0", VA = "0x186A528D0")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string IDMBKCCPFDP = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string BKFGAKPLGAF = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float CNJGIDBCIFM = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly List<UIAnchorFollower> FEDOIANAGLF;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly LHMMLLGDOFK OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly LHMMLLGDOFK OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static NHKPLHMJECC LJKEDGNJJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
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
		private FCANMKLMDOK IIAJPLAPCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Vector3 DJFLFGODKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Quaternion IFPGPPHMOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 GJDPHPFGPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool JCAPOPIGKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool IINCKNJMKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool LJAMLKDDDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 LCICFCLAGIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private UIAnchor KEGKJOAILML;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private bool BCJDGBNNAGK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6A533A0", Offset = "0x6A523A0", VA = "0x186A533A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public UIAnchor OJOMCACHIMM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C00B0", Offset = "0x7BF0B0", VA = "0x1807C00B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool CCJPKKFGAOC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6A52E30", Offset = "0x6A51E30", VA = "0x186A52E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A53100", Offset = "0x6A52100", VA = "0x186A53100")]
		[HMAONFLKHFC(PNOGLCABCMB.Unity_AfterSceneLoad)]
		private static void DPGLELIALOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A52E60", Offset = "0x6A51E60", VA = "0x186A52E60")]
		[CLABBHPJDBB(GLDCPGEPGFO.ExitingPlayMode, 0)]
		private static void DAKOGHLMLGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6A539C0", Offset = "0x6A529C0", VA = "0x186A539C0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6A52B40", Offset = "0x6A51B40", VA = "0x186A52B40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6A53670", Offset = "0x6A52670", VA = "0x186A53670", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A533C0", Offset = "0x6A523C0", VA = "0x186A533C0")]
		public void Initialize(UIAnchor KEGKJOAILML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A53840", Offset = "0x6A52840", VA = "0x186A53840")]
		public void SetAnchorObjectEnabled(bool PNLCCPNIGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6A53890", Offset = "0x6A52890", VA = "0x186A53890")]
		public void SetCanvasRenderingEnabled(bool PNLCCPNIGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6A531E0", Offset = "0x6A521E0", VA = "0x186A531E0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6A529D0", Offset = "0x6A519D0", VA = "0x186A529D0")]
		private void APJCBLPMCKK(bool PNLCCPNIGII, object OGACLNNOKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6A53590", Offset = "0x6A52590", VA = "0x186A53590")]
		private void NBLCEOPOKFP(bool PNLCCPNIGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A53B30", Offset = "0x6A52B30", VA = "0x186A53B30")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6A53950", Offset = "0x6A52950", VA = "0x186A53950")]
		public void SetConstraintEnabled(bool PNLCCPNIGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A538E0", Offset = "0x6A528E0", VA = "0x186A538E0")]
		public void SetConstraintAllowed(bool LCJMLCDJONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6A53450", Offset = "0x6A52450", VA = "0x186A53450")]
		private bool KGKFFEFIIDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A52F40", Offset = "0x6A51F40", VA = "0x186A52F40")]
		private void DPCPFILNPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6A54340", Offset = "0x6A53340", VA = "0x186A54340")]
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
		private sealed class MPAJJHCDOMN : IEnumerator<LLCDBDMNGNA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private LLCDBDMNGNA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private LLCDBDMNGNA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
			[DebuggerHidden]
			public MPAJJHCDOMN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6A50920", Offset = "0x6A4F920", VA = "0x186A50920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6A509F0", Offset = "0x6A4F9F0", VA = "0x186A509F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float JBMABNGBLBP = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool CHAJMENIPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int IJJFPADNKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PointerEventData PFMGNDGMLNB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public MDKLHFICKPP<PointerEventData> OMCPHCOCOKH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public MDKLHFICKPP<PointerEventData> GHCNJGDFJMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public MDKLHFICKPP<PointerEventData> AKMNAPOAKHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public MDKLHFICKPP<PointerEventData> MHGAMCDMCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7C3310", Offset = "0x7C2310", VA = "0x1807C3310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MDKLHFICKPP<PointerEventData> ALPEHHBNDJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MDKLHFICKPP<PointerEventData> MNNDLOMMMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7C1250", Offset = "0x7C0250", VA = "0x1807C1250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public MDKLHFICKPP<PointerEventData> MLJPMFMCLKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7C1270", Offset = "0x7C0270", VA = "0x1807C1270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E730", Offset = "0x6A4D730", VA = "0x186A4E730", Slot = "4")]
		public void OnPointerClick(PointerEventData KGGAPJLLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA60", Offset = "0x6A4DA60", VA = "0x186A4EA60", Slot = "5")]
		public void OnPointerUp(PointerEventData KGGAPJLLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E790", Offset = "0x6A4D790", VA = "0x186A4E790", Slot = "6")]
		public void OnPointerDown(PointerEventData KGGAPJLLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E6A0", Offset = "0x6A4D6A0", VA = "0x186A4E6A0")]
		[IteratorStateMachine(typeof(MPAJJHCDOMN))]
		private IEnumerator<LLCDBDMNGNA> JNGGBLFLCHE(int IJJFPADNKFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E900", Offset = "0x6A4D900", VA = "0x186A4E900", Slot = "7")]
		public void OnPointerEnter(PointerEventData KGGAPJLLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E9A0", Offset = "0x6A4D9A0", VA = "0x186A4E9A0", Slot = "8")]
		public void OnPointerExit(PointerEventData KGGAPJLLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E590", Offset = "0x6A4D590", VA = "0x186A4E590")]
		private bool HCKOKLHDNEF(GameObject LNIPGKDIFCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EAD0", Offset = "0x6A4DAD0", VA = "0x186A4EAD0")]
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
