using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4290", Offset = "0x8AF2A90", VA = "0x188AF4290", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MAJHCOGHGHL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0540", Offset = "0x8AEED40", VA = "0x188AF0540")]
	public static void HOCEHBCGHJP(Component EIBGHDHLJMO, bool CICNLBIFCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0860", Offset = "0x8AEF060", VA = "0x188AF0860")]
	public static void OGECOFFFCFO(Text NKMBALLBMMC, string HFGOALBMNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8AF08E0", Offset = "0x8AEF0E0", VA = "0x188AF08E0")]
	public static void OGECOFFFCFO(TMP_Text NKMBALLBMMC, string HFGOALBMNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8AF03F0", Offset = "0x8AEEBF0", VA = "0x188AF03F0")]
	public static void BCJIJIPNOLP(Image AKLBOBMABFA, Sprite DOMFEHGEBFF, bool BMPHBGCLHKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8AF04C0", Offset = "0x8AEECC0", VA = "0x188AF04C0")]
	public static void CEHMGNFMLOO(RawImage AKLBOBMABFA, Texture2D AILALHOICPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8AF05D0", Offset = "0x8AEEDD0", VA = "0x188AF05D0")]
	public static void JIAONEIJMEC(Graphic LKDILIBLONL, Color BIKIHAKPCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0660", Offset = "0x8AEEE60", VA = "0x188AF0660")]
	public static bool JIEEOHNBDEH(GameObject EMOLHEPHCGI)
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
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
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
		public readonly LBOAOFAOKMM<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly LBOAOFAOKMM<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BCHDHMPJLEB
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IKFHOLJOKIB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xFAF9C0", Offset = "0xFAE1C0", VA = "0x180FAF9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float EEOKCEPKELE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7D0", Offset = "0xA8CFD0", VA = "0x180A8E7D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform EIKDOLJNDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE3C0", Offset = "0x8AECBC0", VA = "0x188AEE3C0", Slot = "5")]
		public void OnDrag(PointerEventData NPLHFNMEMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE440", Offset = "0x8AECC40", VA = "0x188AEE440", Slot = "4")]
		public void OnScroll(PointerEventData NPLHFNMEMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE370", Offset = "0x8AECB70", VA = "0x188AEE370")]
		private Vector2 JAHFKHJDDAL(Vector2 NMEJLHIHCCE)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE4C0", Offset = "0x8AECCC0", VA = "0x188AEE4C0")]
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
		private struct KBECFEMLFNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Graphic PEJLBPLAMLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int APFPECDEIHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Bounds PBPEMFFHNNP;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker LOOBGCDJHKN;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool DoOptimizedEarlyOutOfRaycast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly CMFHIFMOMMG BFLLFBNKDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool OJHCNKGLEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Canvas NKCLBPHGNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected Camera LHJNPBPJNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FastGraphicRaycasterGroup MKONKEJLPNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool HIIPNIGEIHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MNKIALBPIIG CELDKJGPKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool? AMNACJEFDGD;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<Graphic> MLBGAGFMBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int DLIAMKEDIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<KBECFEMLFNN> IJDLOOACONA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Vector3[] KJLLKEKIMOC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<KBECFEMLFNN> CHLGMLKPBNI;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CKGJFCJCCLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8AF0270", Offset = "0x8AEEA70", VA = "0x188AF0270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool LCMINHDFHML
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8AF0360", Offset = "0x8AEEB60", VA = "0x188AF0360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool OIKGCFODGHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8AEE750", Offset = "0x8AECF50", VA = "0x188AEE750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera LAAFCFIAEDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE9F0", Offset = "0x8AED1F0", VA = "0x188AEE9F0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8AF00E0", Offset = "0x8AEE8E0", VA = "0x188AF00E0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF580", Offset = "0x8AEDD80", VA = "0x188AEF580", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF630", Offset = "0x8AEDE30", VA = "0x188AEF630", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8AEFFF0", Offset = "0x8AEE7F0", VA = "0x188AEFFF0")]
		public void SetDisabledToken(bool MGONBEDEDON, JHEECHAOLLM KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF6A0", Offset = "0x8AEDEA0", VA = "0x188AEF6A0", Slot = "17")]
		public override void Raycast(PointerEventData NPLHFNMEMBD, List<RaycastResult> KMANDGFCFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE7E0", Offset = "0x8AECFE0", VA = "0x188AEE7E0")]
		protected void IKMCFHGEOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8AEEAB0", Offset = "0x8AED2B0", VA = "0x188AEEAB0")]
		private void MOEFDPJIIEA(Canvas HMODGAIILPK, Camera LAAFCFIAEDB, Vector2 NGCDBABHPBK, Ray MDJOLFECBJH, List<Graphic> EBAHALBPMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF560", Offset = "0x8AEDD60", VA = "0x188AEF560", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE590", Offset = "0x8AECD90", VA = "0x188AEE590")]
		public static Bounds GetBounds(Graphic OPFJIIPHLBO, Vector3[] AAEEMPIJKKE)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FastGraphicRaycasterGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ALIOKCOAJKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F05DE0", Offset = "0x6F045E0", VA = "0x186F05DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public FullScreenModalUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MNKIALBPIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray GEBOBJIAJLJ, [Out] Graphic MLMEICJHHDO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable ACCGJMFJKMB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NHIEDONGBEE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera GOHBJFKADDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KECNPIDOCPH CJGEIPAOCLO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LBOAOFAOKMM<GameObject> HNPIDOHHAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	public class UIAnchor : UIBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[GKBMICLOBGF(CGAFHOMJNOP.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool NOOGLAAENHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool MFFINFDKAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool NIPFCDHCMLL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool DGINFOEDCNF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3BC0", Offset = "0x8AF23C0", VA = "0x188AF3BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JAJKMINJAAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4200", Offset = "0x8AF2A00", VA = "0x188AF4200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3870", Offset = "0x8AF2070", VA = "0x188AF3870", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3EF0", Offset = "0x8AF26F0", VA = "0x188AF3EF0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3ED0", Offset = "0x8AF26D0", VA = "0x188AF3ED0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3E30", Offset = "0x8AF2630", VA = "0x188AF3E30", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4010", Offset = "0x8AF2810", VA = "0x188AF4010", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3E10", Offset = "0x8AF2610", VA = "0x188AF3E10", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4130", Offset = "0x8AF2930", VA = "0x188AF4130")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3F30", Offset = "0x8AF2730", VA = "0x188AF3F30")]
		public void SetFollowerConstraintEnabled(bool EMMOENAPJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3D40", Offset = "0x8AF2540", VA = "0x188AF3D40")]
		private void MKLNNFOCPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3C20", Offset = "0x8AF2420", VA = "0x188AF3C20")]
		private void JLBBGIKBDEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8AF39D0", Offset = "0x8AF21D0", VA = "0x188AF39D0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8AF41B0", Offset = "0x8AF29B0", VA = "0x188AF41B0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BMFDLJBFLGP
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8AED9E0", Offset = "0x8AEC1E0", VA = "0x188AED9E0")]
	public static bool FGDKOOLBNPM(this Transform LNFGEICLAJH, Transform MJNLMOPPION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3734F80", Offset = "0x3733780", VA = "0x183734F80")]
	public static T OCBJGIDHLPG<T>(this Component OLBBKGLINIK, bool KDNOHAOEBFK = false) where T : class
	{
		return null;
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BIGKNCFPIMM : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public UIAnchorFollowConstraint <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private Vector3 <initialPosition>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Vector3 <initialRotationEuler>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private bool <doMove>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private bool <doRotate>5__5;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public BIGKNCFPIMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8AED960", Offset = "0x8AEC160", VA = "0x188AED960", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8AECCB0", Offset = "0x8AEB4B0", VA = "0x188AECCB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8AECC70", Offset = "0x8AEB470", VA = "0x188AECC70")]
			private void EGKKBNFIFOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8AED910", Offset = "0x8AEC110", VA = "0x188AED910", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Tooltip("Curve that describes the rate of follow motion at different points in the follow (e.g.- ease in and out when starting or stopping the motion).")]
		private AnimationCurve easingCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("How much can the UI anchor move (in meters) before this object starts following it.")]
		private float followPositionThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("How much can the UI anchor rotate (in degrees) before this object starts following it.")]
		private float followRotationThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Tooltip("The maximum speed (in meters/second) that the UI anchor follower move when following the anchor.")]
		private float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[Tooltip("The maximum speed (in degrees/second) that the UI anchor follower rotate when following the anchor.")]
		private float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[Tooltip("The position delta (in meters) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float easingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Tooltip("The rotation delta (in degrees) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float rotationEasingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the X-axis.")]
		private bool allowXRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Y-axis.")]
		private bool allowYRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Z-axis.")]
		private bool allowZRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private float maxAllowedVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Vector3 AEIIIEBLJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Quaternion MLOJGNMFDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Coroutine CGDIKKPIGPE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float IMMANAJCHEL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xC860C0", Offset = "0xC848C0", VA = "0x180C860C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CECNGDGBOGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E01400", Offset = "0x6DFFC00", VA = "0x186E01400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1280", Offset = "0x8AEFA80", VA = "0x188AF1280")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x17360C0", Offset = "0x17348C0", VA = "0x1817360C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8AF12F0", Offset = "0x8AEFAF0", VA = "0x188AF12F0")]
		public void SetTarget(Vector3 KKEEFCOJJFM, Quaternion FENAGHBAFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8AF11D0", Offset = "0x8AEF9D0", VA = "0x188AF11D0")]
		[IteratorStateMachine(typeof(BIGKNCFPIMM))]
		private IEnumerator KKMGCIGCNBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0C20", Offset = "0x8AEF420", VA = "0x188AF0C20")]
		private float GIMBCCFLEFH(float NEONBKGLCCN, Vector3 MLLCMFOLBLC, Vector3 KACHJDILOEK, float IILNEBJHNFN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0DB0", Offset = "0x8AEF5B0", VA = "0x188AF0DB0")]
		private float GIMBCCFLEFH(float NEONBKGLCCN, float FBCONJBOEDF, float AMECAJCFBEL, float IILNEBJHNFN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0A60", Offset = "0x8AEF260", VA = "0x188AF0A60")]
		private Vector3 DIGBACGFANJ(Vector3 BGIHIJGCNPG, Vector3 PLPNNLPKPLJ, Vector3 LONBCENHPHO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1250", Offset = "0x8AEFA50", VA = "0x188AF1250")]
		private bool LHBILLPFIEC(float HIMJFHGCNCC, float PLPNNLPKPLJ, float LONBCENHPHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0B40", Offset = "0x8AEF340", VA = "0x188AF0B40")]
		private Vector3 FPLJJNLBCPL(Quaternion FENAGHBAFHI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8AF09D0", Offset = "0x8AEF1D0", VA = "0x188AF09D0")]
		private bool AKANJDLIKJL(Vector3 KKEEFCOJJFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0E40", Offset = "0x8AEF640", VA = "0x188AF0E40")]
		private bool HAACCGNDNAM(Quaternion FENAGHBAFHI, bool GMGACNDJMKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1180", Offset = "0x8AEF980", VA = "0x188AF1180")]
		private bool KJNFHPMBBNN(Vector3 NOGJAHKGFJD, Vector3 LHMEHOJLNDH, float PGEHLKEFHDO = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1120", Offset = "0x8AEF920", VA = "0x188AF1120")]
		private bool KJNFHPMBBNN(Quaternion NOGJAHKGFJD, Quaternion LHMEHOJLNDH, float PGEHLKEFHDO = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1510", Offset = "0x8AEFD10", VA = "0x188AF1510")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum LGGBPJLCMFN
		{
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			UIRaycast,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			CanvasRender
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static bool UseFaceCameraSyncOptimizations;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static bool DisableUIAnchorFaceCameraForMirrors;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string OPOEHIEFAFJ = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string DBNHEKEEKFE = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static readonly List<UIAnchorFollower> HEKEENEEAMG;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly KECNPIDOCPH OnUIAnchorsUpdated;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static NHIEDONGBEE KNEBHOKFEII;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int DDNEGPMKKBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly KECNPIDOCPH OnSyncTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		[SerializeField]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private UIAnchorFollowConstraint followConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private BFPHHCAGGHH KJPOIKHNPAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 OONHEJBHIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion KBCNLKGDPKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 BCOLCKOKMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool PNCJEPGKGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool OMHBEPICKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool HIBCLIKINDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 PPELFDEPCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly JHEECHAOLLM KAJENDFCCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private DKAALOPIDKO IGGEKIAMILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Transform KIDGNKPGBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private UIAnchor CHEKIBKEJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public bool DoCanvasRenderSync;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static ProfilerMarker PELGMAMFNJO;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool FDKEILBNPFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2220", Offset = "0x8AF0A20", VA = "0x188AF2220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private Transform KCODNJGBFEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1F61A10", Offset = "0x1F60210", VA = "0x181F61A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public UIAnchor KNNMEHOONFD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool OKMAKJOCFFN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF1D40", Offset = "0x8AF0540", VA = "0x188AF1D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2050", Offset = "0x8AF0850", VA = "0x188AF2050")]
		[BDPIALLOKEK]
		internal static void IEAMPCKAMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2240", Offset = "0x8AF0A40", VA = "0x188AF2240")]
		[IDECILCAMBG(GNJLFMHIMOJ.ExitingPlayMode, 0)]
		private static void NIKNJLKBDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2860", Offset = "0x8AF1060", VA = "0x188AF2860")]
		public static void SyncAllFollowers(LGGBPJLCMFN MJAGIMDGJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2310", Offset = "0x8AF0B10", VA = "0x188AF2310")]
		private static void OBDALKBOLJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8AF21D0", Offset = "0x8AF09D0", VA = "0x188AF21D0")]
		private static void MOFMKCOBGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1810", Offset = "0x8AF0010", VA = "0x188AF1810", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF24E0", Offset = "0x8AF0CE0", VA = "0x188AF24E0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2120", Offset = "0x8AF0920", VA = "0x188AF2120")]
		public void Initialize(UIAnchor CHEKIBKEJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF26E0", Offset = "0x8AF0EE0", VA = "0x188AF26E0")]
		public void SetAnchorObjectEnabled(bool EMMOENAPJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2730", Offset = "0x8AF0F30", VA = "0x188AF2730")]
		public void SetCanvasRenderingEnabled(bool EMMOENAPJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1D70", Offset = "0x8AF0570", VA = "0x188AF1D70")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2360", Offset = "0x8AF0B60", VA = "0x188AF2360")]
		private void OJOFMLGHKNB(bool EMMOENAPJHM, object KAJENDFCCBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1F60", Offset = "0x8AF0760", VA = "0x188AF1F60")]
		private void IAPLEPFHEKG(bool EMMOENAPJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2BC0", Offset = "0x8AF13C0", VA = "0x188AF2BC0")]
		public bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8AF27F0", Offset = "0x8AF0FF0", VA = "0x188AF27F0")]
		public void SetConstraintEnabled(bool EMMOENAPJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2780", Offset = "0x8AF0F80", VA = "0x188AF2780")]
		public void SetConstraintAllowed(bool DCGBMIDFHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1C00", Offset = "0x8AF0400", VA = "0x188AF1C00")]
		private bool DJCFFPEPOOB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1600", Offset = "0x8AEFE00", VA = "0x188AF1600")]
		private void AALLELOIEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8AF36D0", Offset = "0x8AF1ED0", VA = "0x188AF36D0")]
		public UIAnchorFollower()
		{
		}
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class CIIPMMFPPMB : IEnumerator<ENGFNCJEKHI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private ENGFNCJEKHI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private ENGFNCJEKHI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public CIIPMMFPPMB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8AEDB20", Offset = "0x8AEC320", VA = "0x188AEDB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8AEDBF0", Offset = "0x8AEC3F0", VA = "0x188AEDBF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private const float LLAEILEJOKL = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool EGFNICIJKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int FIDPBMCCEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private PointerEventData GLOGKBEJNMI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public LBOAOFAOKMM<PointerEventData> CAJNNMPPCMH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public LBOAOFAOKMM<PointerEventData> GNCMNMCNFMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public LBOAOFAOKMM<PointerEventData> BFELLDCLAMG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public LBOAOFAOKMM<PointerEventData> BDGGCFNLDMB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public LBOAOFAOKMM<PointerEventData> CILBEBAJGEF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public LBOAOFAOKMM<PointerEventData> CDIHNIJEEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public LBOAOFAOKMM<PointerEventData> DFGABDNGBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDDE0", Offset = "0x8AEC5E0", VA = "0x188AEDDE0", Slot = "4")]
		public void OnPointerClick(PointerEventData NPLHFNMEMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE110", Offset = "0x8AEC910", VA = "0x188AEE110", Slot = "5")]
		public void OnPointerUp(PointerEventData NPLHFNMEMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDE40", Offset = "0x8AEC640", VA = "0x188AEDE40", Slot = "6")]
		public void OnPointerDown(PointerEventData NPLHFNMEMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDC40", Offset = "0x8AEC440", VA = "0x188AEDC40")]
		[IteratorStateMachine(typeof(CIIPMMFPPMB))]
		private IEnumerator<ENGFNCJEKHI> DODDCMGAIPI(int FIDPBMCCEGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDFB0", Offset = "0x8AEC7B0", VA = "0x188AEDFB0", Slot = "7")]
		public void OnPointerEnter(PointerEventData NPLHFNMEMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE050", Offset = "0x8AEC850", VA = "0x188AEE050", Slot = "8")]
		public void OnPointerExit(PointerEventData NPLHFNMEMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8AEDCD0", Offset = "0x8AEC4D0", VA = "0x188AEDCD0")]
		private bool OBJHABBMJCD(GameObject EMOLHEPHCGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8AEE180", Offset = "0x8AEC980", VA = "0x188AEE180")]
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
