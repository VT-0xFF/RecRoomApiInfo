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
public static class EAOFPLBEBDP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x724E750", Offset = "0x724CF50", VA = "0x18724E750")]
	public static void NHDNLEFJMLN(Component INPAFGCEBHH, bool ECOAPNDMJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x724E360", Offset = "0x724CB60", VA = "0x18724E360")]
	public static void AAMPECAMEIJ(Text BPOEPOHDCMI, string PGFCIKJHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x724E3E0", Offset = "0x724CBE0", VA = "0x18724E3E0")]
	public static void AAMPECAMEIJ(TMP_Text BPOEPOHDCMI, string PGFCIKJHGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x724E7E0", Offset = "0x724CFE0", VA = "0x18724E7E0")]
	public static void PDBFPNHLHKO(Image PLFMMCECFGA, Sprite BJJLOPILCOF, bool OHGINAKFGAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x724E6D0", Offset = "0x724CED0", VA = "0x18724E6D0")]
	public static void JHKGBILMJDE(RawImage PLFMMCECFGA, Texture2D IPABEBMKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x724E640", Offset = "0x724CE40", VA = "0x18724E640")]
	public static void IAEDJECBNEP(Graphic PAMOACODPIM, Color KIJNHGNFMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x724E460", Offset = "0x724CC60", VA = "0x18724E460")]
	public static bool FLONMDEAAIE(GameObject NBDLDMDNCAL)
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
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
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
		public readonly ODIOBOMGOFD<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly ODIOBOMGOFD<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GBGPDACLDPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8569B0", Offset = "0x8551B0", VA = "0x1808569B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JAHJKOKKANP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA9F450", Offset = "0xA9DC50", VA = "0x180A9F450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float MMIAKCJECJB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9C71A0", Offset = "0x9C59A0", VA = "0x1809C71A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform CGKEMHBGHIN
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x724E190", Offset = "0x724C990", VA = "0x18724E190", Slot = "5")]
		public void OnDrag(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x724E210", Offset = "0x724CA10", VA = "0x18724E210", Slot = "4")]
		public void OnScroll(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x724E140", Offset = "0x724C940", VA = "0x18724E140")]
		private Vector2 JMIAGBCILAH(Vector2 CNIGABNNHHG)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x724E290", Offset = "0x724CA90", VA = "0x18724E290")]
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
		private struct LENFIIEJPJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic EAOPENCEFGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int FFMANLFIFJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds DBOONJHNNHB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool BKHECOKGAFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas EDGBGKJCPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera FBFHIOFHPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup OBAIDOOGDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool KLAPFNEOEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private AIIEFMDKFDE GCEOFAHJCCJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> LIHHBCGKOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int LKAIMCDJKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<LENFIIEJPJO> ODDNCCMPGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] DCMIJONKKHL;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<LENFIIEJPJO> HFFPLBOCLNL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CBODFNEPLOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x72501D0", Offset = "0x724E9D0", VA = "0x1872501D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool FPLPNOKELLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x724E8B0", Offset = "0x724D0B0", VA = "0x18724E8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera KHKJOKELMDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x724F770", Offset = "0x724DF70", VA = "0x18724F770", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7250090", Offset = "0x724E890", VA = "0x187250090")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x724F850", Offset = "0x724E050", VA = "0x18724F850", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x724F900", Offset = "0x724E100", VA = "0x18724F900", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x724F970", Offset = "0x724E170", VA = "0x18724F970", Slot = "17")]
		public override void Raycast(PointerEventData BGEDEFLEFII, List<RaycastResult> CNKMAHOCEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x724E940", Offset = "0x724D140", VA = "0x18724E940")]
		protected void FBECOJOEBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x724EB50", Offset = "0x724D350", VA = "0x18724EB50")]
		private void GPKNIAFFNLP(Canvas GLCJPMLKGHA, Camera KHKJOKELMDC, Vector2 MOIJIHBECBK, Ray HIAEDABOPME, List<Graphic> GENNLFGNPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x724F830", Offset = "0x724E030", VA = "0x18724F830", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x724F5B0", Offset = "0x724DDB0", VA = "0x18724F5B0")]
		public static Bounds GetBounds(Graphic HEFMBNKPLCC, Vector3[] LHFIMNBGEIJ)
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
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CKCBOLCFHPM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xCC0A40", Offset = "0xCBF240", VA = "0x180CC0A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AIIEFMDKFDE
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray GGHHDOIKIEB, [Out] Graphic IHLKFAABHIF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable AHKGDGDPMEE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MBNBCPPCFFK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera OMMJCBGFMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EHODCIMNDCH APJGKCMJPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	ODIOBOMGOFD<GameObject> DPHEKHMNKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
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
		[CIHMDBDDPOM(LEHCEJJDOON.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool MCMHBBPJADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool AHFDJOLJECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool GGAFLCKANLP;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool FOFBHBNJLJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7253B80", Offset = "0x7252380", VA = "0x187253B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7253870", Offset = "0x7252070", VA = "0x187253870", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7253DE0", Offset = "0x72525E0", VA = "0x187253DE0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7253DC0", Offset = "0x72525C0", VA = "0x187253DC0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7253D20", Offset = "0x7252520", VA = "0x187253D20", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7253FD0", Offset = "0x72527D0", VA = "0x187253FD0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7253D00", Offset = "0x7252500", VA = "0x187253D00", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x72540D0", Offset = "0x72528D0", VA = "0x1872540D0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7253EF0", Offset = "0x72526F0", VA = "0x187253EF0")]
		public void SetFollowerConstraintEnabled(bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7253E20", Offset = "0x7252620", VA = "0x187253E20")]
		private void PKJGKILOOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7253BE0", Offset = "0x72523E0", VA = "0x187253BE0")]
		private void NMDMCILCILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x72539B0", Offset = "0x72521B0", VA = "0x1872539B0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7254150", Offset = "0x7252950", VA = "0x187254150")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LBINNMEIONC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7250FD0", Offset = "0x724F7D0", VA = "0x187250FD0")]
	public static bool KFCGOOMKKLI(this Transform JPEFLCPGHGB, Transform BMBBFJPOJEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C067C0", Offset = "0x2C04FC0", VA = "0x182C067C0")]
	public static T FCKGNKPMEEC<T>(this Component CGKANMHMCOJ, bool AEJPJHFLJPH = false) where T : class
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
		private sealed class JOECIPNONOA : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public JOECIPNONOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7250F50", Offset = "0x724F750", VA = "0x187250F50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x72502A0", Offset = "0x724EAA0", VA = "0x1872502A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7250260", Offset = "0x724EA60", VA = "0x187250260")]
			private void CEOBCCLIKJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7250F00", Offset = "0x724F700", VA = "0x187250F00", Slot = "8")]
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
		private Vector3 MPCBIACINGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Quaternion ONNKAJNPEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Coroutine NFLIJKJDKHL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float IPDFALFAKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8BEA40", Offset = "0x8BD240", VA = "0x1808BEA40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7251A50", Offset = "0x7250250", VA = "0x187251A50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD77DA0", Offset = "0xD765A0", VA = "0x180D77DA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7251AC0", Offset = "0x72502C0", VA = "0x187251AC0")]
		public void SetTarget(Vector3 HGDCPNGLIKJ, Quaternion LCDJINCAHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72515D0", Offset = "0x724FDD0", VA = "0x1872515D0")]
		[IteratorStateMachine(typeof(JOECIPNONOA))]
		private IEnumerator FMJIEMLMBLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72513B0", Offset = "0x724FBB0", VA = "0x1872513B0")]
		private float BDEMMAPFBNK(float MLHGHDHBHIO, Vector3 JJFPGKOJLAM, Vector3 HMMMFCAAHNG, float EHKCHAIPENK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7251320", Offset = "0x724FB20", VA = "0x187251320")]
		private float BDEMMAPFBNK(float MLHGHDHBHIO, float AMGGOMGGFLL, float FKDKFPKFJIH, float EHKCHAIPENK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7251680", Offset = "0x724FE80", VA = "0x187251680")]
		private Vector3 KKNILIIOFEF(Vector3 FDEBBOHADGJ, Vector3 CGCFPGMCFAI, Vector3 FCBGHELDCII)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7251650", Offset = "0x724FE50", VA = "0x187251650")]
		private bool HEKBGJKKMDP(float HJGDDFBNENN, float CGCFPGMCFAI, float FCBGHELDCII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7251240", Offset = "0x724FA40", VA = "0x187251240")]
		private Vector3 AKHDJMCKONO(Quaternion LCDJINCAHMD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7251540", Offset = "0x724FD40", VA = "0x187251540")]
		private bool BGMBFNCIKAD(Vector3 HGDCPNGLIKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7251760", Offset = "0x724FF60", VA = "0x187251760")]
		private bool MDJHDKINDLI(Quaternion LCDJINCAHMD, bool MKGELEMBLAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7251190", Offset = "0x724F990", VA = "0x187251190")]
		private bool AHKKAHFPLJB(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP, float DKFMGMFKAGG = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72511E0", Offset = "0x724F9E0", VA = "0x1872511E0")]
		private bool AHKKAHFPLJB(Quaternion DIAAOCPNHKC, Quaternion LLLBDLGIMPP, float DKFMGMFKAGG = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7251CE0", Offset = "0x72504E0", VA = "0x187251CE0")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string PIMNBNNMBJJ = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string KMBLICBDNMG = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float FFICANHJFBG = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly List<UIAnchorFollower> CEAGEKIBPLN;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly EHODCIMNDCH OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly EHODCIMNDCH OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static MBNBCPPCFFK CEGMLAJABMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
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
		private MJPOGCFKFFN FAEGELJDIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Vector3 KCAHPBJGMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Quaternion ENEEHHKMEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 IKCPFPJGJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool MEBDPEPHPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool JFFCMFKJFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool OABLFMFDMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 BPBGNINKEPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private UIAnchor BPECGFGBDJB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private bool OFOIPJMMFFG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7251DE0", Offset = "0x72505E0", VA = "0x187251DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public UIAnchor MMOMNHOJKKD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x85FE70", Offset = "0x85E670", VA = "0x18085FE70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool LCHNGOGMNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7252480", Offset = "0x7250C80", VA = "0x187252480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7252750", Offset = "0x7250F50", VA = "0x187252750")]
		[FCFOCBHCEIP(MJLCCMEEJMA.Unity_AfterSceneLoad)]
		private static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72523A0", Offset = "0x7250BA0", VA = "0x1872523A0")]
		[JIDCLHKIDAF(KJECFEIFJAL.ExitingPlayMode, 0)]
		private static void EOJEBCEEEFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7252DD0", Offset = "0x72515D0", VA = "0x187252DD0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7251E00", Offset = "0x7250600", VA = "0x187251E00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7252A80", Offset = "0x7251280", VA = "0x187252A80", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7252830", Offset = "0x7251030", VA = "0x187252830")]
		public void Initialize(UIAnchor BPECGFGBDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7252C50", Offset = "0x7251450", VA = "0x187252C50")]
		public void SetAnchorObjectEnabled(bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7252CA0", Offset = "0x72514A0", VA = "0x187252CA0")]
		public void SetCanvasRenderingEnabled(bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72524B0", Offset = "0x7250CB0", VA = "0x1872524B0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x72520F0", Offset = "0x72508F0", VA = "0x1872520F0")]
		private void DBBCLMEMKKL(bool CKPMODOEIJG, object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7252670", Offset = "0x7250E70", VA = "0x187252670")]
		private void GJILOGOBOPN(bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7252F40", Offset = "0x7251740", VA = "0x187252F40")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7252D60", Offset = "0x7251560", VA = "0x187252D60")]
		public void SetConstraintEnabled(bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7252CF0", Offset = "0x72514F0", VA = "0x187252CF0")]
		public void SetConstraintAllowed(bool GGKPHKGMAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7252260", Offset = "0x7250A60", VA = "0x187252260")]
		private bool EEGBHNNKJID()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x72528C0", Offset = "0x72510C0", VA = "0x1872528C0")]
		private void JFGCIGIJMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7253750", Offset = "0x7251F50", VA = "0x187253750")]
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
		private sealed class BJECCGNDPIE : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private JMPDKMJKKGA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public BJECCGNDPIE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x724D8F0", Offset = "0x724C0F0", VA = "0x18724D8F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x724D9C0", Offset = "0x724C1C0", VA = "0x18724D9C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float JGBAILEJIEN = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool DMLCOIOEFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int GPBCLPJMCGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PointerEventData EKLFLLGEAFN;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public ODIOBOMGOFD<PointerEventData> OBDNAMPHGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public ODIOBOMGOFD<PointerEventData> JFOHEBMGKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public ODIOBOMGOFD<PointerEventData> EAOMFCGNONP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ODIOBOMGOFD<PointerEventData> EICJCBEKNEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8552B0", VA = "0x180856AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ODIOBOMGOFD<PointerEventData> KDFJLENDDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8551D0", VA = "0x1808569D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ODIOBOMGOFD<PointerEventData> GMADHDAALIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x854B00", VA = "0x180856300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public ODIOBOMGOFD<PointerEventData> ONGBPIJGKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x856340", Offset = "0x854B40", VA = "0x180856340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x724DBB0", Offset = "0x724C3B0", VA = "0x18724DBB0", Slot = "4")]
		public void OnPointerClick(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x724DEE0", Offset = "0x724C6E0", VA = "0x18724DEE0", Slot = "5")]
		public void OnPointerUp(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x724DC10", Offset = "0x724C410", VA = "0x18724DC10", Slot = "6")]
		public void OnPointerDown(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x724DA10", Offset = "0x724C210", VA = "0x18724DA10")]
		[IteratorStateMachine(typeof(BJECCGNDPIE))]
		private IEnumerator<JMPDKMJKKGA> ANPFOAAAAJA(int GPBCLPJMCGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x724DD80", Offset = "0x724C580", VA = "0x18724DD80", Slot = "7")]
		public void OnPointerEnter(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x724DE20", Offset = "0x724C620", VA = "0x18724DE20", Slot = "8")]
		public void OnPointerExit(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x724DAA0", Offset = "0x724C2A0", VA = "0x18724DAA0")]
		private bool HOEHADOKEAG(GameObject NBDLDMDNCAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x724DF50", Offset = "0x724C750", VA = "0x18724DF50")]
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
