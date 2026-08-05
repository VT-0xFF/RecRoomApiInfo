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
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x786B9D0", Offset = "0x786A9D0", VA = "0x18786B9D0", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LOECLEJDDEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7868020", Offset = "0x7867020", VA = "0x187868020")]
	public static void MPNLEPALHHA(Component GEICOLLOJJK, bool PHLFEEMONCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7867C90", Offset = "0x7866C90", VA = "0x187867C90")]
	public static void BGJFIADMIPO(Text CLILNPELNAA, string JCLHICKJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7867D10", Offset = "0x7866D10", VA = "0x187867D10")]
	public static void BGJFIADMIPO(TMP_Text CLILNPELNAA, string JCLHICKJKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78680B0", Offset = "0x78670B0", VA = "0x1878680B0")]
	public static void ONGKCPPKJPE(Image OFAEDKHNKAO, Sprite KEAFEFCNPPD, bool JMHGMBDCFMH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7867C10", Offset = "0x7866C10", VA = "0x187867C10")]
	public static void AFHOLCMHKHE(RawImage OFAEDKHNKAO, Texture2D JKGKKEHABOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7867F90", Offset = "0x7866F90", VA = "0x187867F90")]
	public static void IEDJHHHHIII(Graphic ICEDOCLMCFJ, Color DANHKIEIFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7867D90", Offset = "0x7866D90", VA = "0x187867D90")]
	public static bool ICDEACDHCGN(GameObject IEELEEMHGEB)
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
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
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
		public readonly JFMBBHOLPOC<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly JFMBBHOLPOC<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BLDMEDEKMLD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E50", Offset = "0x8B8E50", VA = "0x1808B9E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CDKEKNGIFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xE84D60", Offset = "0xE83D60", VA = "0x180E84D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float PNMAOGFFGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x93B340", Offset = "0x93A340", VA = "0x18093B340")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform IOCEOMALDPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7864F60", Offset = "0x7863F60", VA = "0x187864F60", Slot = "5")]
		public void OnDrag(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7864FE0", Offset = "0x7863FE0", VA = "0x187864FE0", Slot = "4")]
		public void OnScroll(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7865060", Offset = "0x7864060", VA = "0x187865060")]
		private Vector2 PCJPNIHNNNG(Vector2 GHMFGIKIHEL)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78650B0", Offset = "0x78640B0", VA = "0x1878650B0")]
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
		private struct AEGHNFHHFFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Graphic BAAFMEAIMNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public int HLNEOBHPOLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Bounds KBOLPMOALAF;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker NJBNKBAFIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool BDOFCBLGEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Canvas IKPEKECBOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Camera BJLKOMHJJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private FastGraphicRaycasterGroup AEGPJGDMOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool BGCJNKJIMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IEBCECFLKLF GGEDCMBIPNC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<Graphic> ABJIGODAMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int BEDBBNNGLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<AEGHNFHHFFF> JELEEDHHFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Vector3[] NIIFCPJCKPA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<AEGHNFHHFFF> LEDOIKNDOKM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FBPBONGGKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7866CF0", Offset = "0x7865CF0", VA = "0x187866CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool FHGIMIIFFMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7865E90", Offset = "0x7864E90", VA = "0x187865E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera EMBOILFPKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7865DD0", Offset = "0x7864DD0", VA = "0x187865DD0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7866BB0", Offset = "0x7865BB0", VA = "0x187866BB0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7866150", Offset = "0x7865150", VA = "0x187866150", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7866200", Offset = "0x7865200", VA = "0x187866200", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7866270", Offset = "0x7865270", VA = "0x187866270", Slot = "17")]
		public override void Raycast(PointerEventData POADLBAMAOE, List<RaycastResult> AGJIHPAMJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7865F20", Offset = "0x7864F20", VA = "0x187865F20")]
		protected void KCJCILFONJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7865340", Offset = "0x7864340", VA = "0x187865340")]
		private void HKNCJBJMNDJ(Canvas APAAJJBNHKC, Camera EMBOILFPKBI, Vector2 DEFCBFJNDCD, Ray FHLLENPIFEP, List<Graphic> INNMCPIJFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7866130", Offset = "0x7865130", VA = "0x187866130", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7865180", Offset = "0x7864180", VA = "0x187865180")]
		public static Bounds GetBounds(Graphic ABNOEFGAADG, Vector3[] JDMNEEOCDAA)
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
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DPEGCPBDAHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FB6380", Offset = "0x5FB5380", VA = "0x185FB6380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IEBCECFLKLF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray PKCNBMLJLDK, [Out] Graphic NNKHLBEPOCD);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable CAMJAJDKBJB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FOCIEDEMBJL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera CKOGGDJLOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GDBINPMHEFP GKALIGGCOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JFMBBHOLPOC<GameObject> IEGDAAELDDM
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
		[DPAAGPNIBEP(CCPGINMHCCO.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool OLIBMNFNNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool GJKKIIFBFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool NIEMDLPAFML;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool GKALBBCAPCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x786B4B0", Offset = "0x786A4B0", VA = "0x18786B4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x786B040", Offset = "0x786A040", VA = "0x18786B040", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x786B6C0", Offset = "0x786A6C0", VA = "0x18786B6C0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x786B6A0", Offset = "0x786A6A0", VA = "0x18786B6A0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x786B600", Offset = "0x786A600", VA = "0x18786B600", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x786B7E0", Offset = "0x786A7E0", VA = "0x18786B7E0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x786B5E0", Offset = "0x786A5E0", VA = "0x18786B5E0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x786B900", Offset = "0x786A900", VA = "0x18786B900")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x786B700", Offset = "0x786A700", VA = "0x18786B700")]
		public void SetFollowerConstraintEnabled(bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x786B510", Offset = "0x786A510", VA = "0x18786B510")]
		private void IILKBDEONIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x786B1A0", Offset = "0x786A1A0", VA = "0x18786B1A0")]
		private void CLAEOOGGANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x786B2C0", Offset = "0x786A2C0", VA = "0x18786B2C0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x786B980", Offset = "0x786A980", VA = "0x18786B980")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CEKEBGHIMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x78646F0", Offset = "0x78636F0", VA = "0x1878646F0")]
	public static bool CGCFKMJNFDL(this Transform KOOGBCPBMOE, Transform JNLBEALAMNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D64F10", Offset = "0x2D63F10", VA = "0x182D64F10")]
	public static T HEDCDFNLHBB<T>(this Component CECLKDDLGFE, bool ODMKGDMEBPB = false) where T : class
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
		private sealed class HHNILHDDOHL : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public HHNILHDDOHL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7867A70", Offset = "0x7866A70", VA = "0x187867A70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7866DC0", Offset = "0x7865DC0", VA = "0x187866DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7866D80", Offset = "0x7865D80", VA = "0x187866D80")]
			private void CLDKBJALKHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7867A20", Offset = "0x7866A20", VA = "0x187867A20", Slot = "8")]
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
		private Vector3 LBLGJLPHNMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Quaternion DNJIGOLGPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Coroutine FCKMPEFDHNN;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float DHLKLPBGHBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x95FBF0", Offset = "0x95EBF0", VA = "0x18095FBF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PBFCOEKKIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5F1ECD0", Offset = "0x5F1DCD0", VA = "0x185F1ECD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7868A10", Offset = "0x7867A10", VA = "0x187868A10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1171F50", Offset = "0x1170F50", VA = "0x181171F50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7868B10", Offset = "0x7867B10", VA = "0x187868B10")]
		public void SetTarget(Vector3 PAMMLHPIJIB, Quaternion JKJHCABJJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7868520", Offset = "0x7867520", VA = "0x187868520")]
		[IteratorStateMachine(typeof(HHNILHDDOHL))]
		private IEnumerator FDAFAEJOIGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x78682B0", Offset = "0x78672B0", VA = "0x1878682B0")]
		private float BABGPLEBHBC(float BAHOFFMAKCH, Vector3 BMGAJLJKLPA, Vector3 BEHCIFAIJND, float GCCOBEICBAO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7868220", Offset = "0x7867220", VA = "0x187868220")]
		private float BABGPLEBHBC(float BAHOFFMAKCH, float NIAJHIMANGO, float MNECJABBGNI, float GCCOBEICBAO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x78685A0", Offset = "0x78675A0", VA = "0x1878685A0")]
		private Vector3 GNFFLJHKHAF(Vector3 JBJJEFGLPGN, Vector3 KJMIODKMJNC, Vector3 IKMGCHAHKMB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x78681F0", Offset = "0x78671F0", VA = "0x1878681F0")]
		private bool AEMABKFGFIL(float GJACHEECGOL, float KJMIODKMJNC, float IKMGCHAHKMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7868440", Offset = "0x7867440", VA = "0x187868440")]
		private Vector3 DBGHOLMPKPO(Quaternion JKJHCABJJIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7868A80", Offset = "0x7867A80", VA = "0x187868A80")]
		private bool PLJENPBCLEG(Vector3 PAMMLHPIJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7868730", Offset = "0x7867730", VA = "0x187868730")]
		private bool ICCDFONLPHL(Quaternion JKJHCABJJIO, bool HDFFHFFOMHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7868680", Offset = "0x7867680", VA = "0x187868680")]
		private bool HJBKKGCICKG(Vector3 LOPBCKBMJBH, Vector3 BMJGCJANGHI, float EHBFEKFMGNI = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x78686D0", Offset = "0x78676D0", VA = "0x1878686D0")]
		private bool HJBKKGCICKG(Quaternion LOPBCKBMJBH, Quaternion BMJGCJANGHI, float EHBFEKFMGNI = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7868D30", Offset = "0x7867D30", VA = "0x187868D30")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum OIEILCIFJJM
		{
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			UIRaycast,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Render
		}

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string KNNHAGFBPAG = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string JKGCEJKFBJO = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const float JNCHDFMMNMO = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly List<UIAnchorFollower> DBODLPNGEGO;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly GDBINPMHEFP OnUIAnchorsUpdated;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static FOCIEDEMBJL GHJGICFDBMI;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static int KKCDNFELJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly GDBINPMHEFP OnSyncTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
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
		private MPAMFIMFCFF OHKCLKOJDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 CJNCCDMKBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Quaternion APECGCFJNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 CMJLLJIOPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool JPJOPCEKJLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool FHNFIMCOGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool JCNAGHDCPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 LNNOKJGINJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private NOFJDNKBMKA LIKAOGBPBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private Transform GAFNBJBNDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private UIAnchor MGJAONACLLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static ProfilerMarker JGHNEHFPMCE;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private bool BENOBKCMAOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x78696B0", Offset = "0x78686B0", VA = "0x1878696B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private Transform IMCFIOFNLHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7869C10", Offset = "0x7868C10", VA = "0x187869C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public UIAnchor FDGCLPLOINH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8B8220", Offset = "0x8B7220", VA = "0x1808B8220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool NKKJGADCAKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7869680", Offset = "0x7868680", VA = "0x187869680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7869470", Offset = "0x7868470", VA = "0x187869470")]
		[GMOOIMKJNLJ]
		internal static void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7869C60", Offset = "0x7868C60", VA = "0x187869C60")]
		[OJEDBLJEHPG(DODBMCGLPPE.ExitingPlayMode, 0)]
		private static void NCKFFNLBFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x786A070", Offset = "0x7869070", VA = "0x18786A070")]
		public static void SyncAllFollowers(OIEILCIFJJM NDMMIOJEOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7869210", Offset = "0x7868210", VA = "0x187869210")]
		private static void BDCKEOMNEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7869BC0", Offset = "0x7868BC0", VA = "0x187869BC0")]
		private static void MFKBIDICFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7868E20", Offset = "0x7867E20", VA = "0x187868E20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7869D30", Offset = "0x7868D30", VA = "0x187869D30", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7869A30", Offset = "0x7868A30", VA = "0x187869A30")]
		public void Initialize(UIAnchor MGJAONACLLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7869EF0", Offset = "0x7868EF0", VA = "0x187869EF0")]
		public void SetAnchorObjectEnabled(bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7869F40", Offset = "0x7868F40", VA = "0x187869F40")]
		public void SetCanvasRenderingEnabled(bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x78696D0", Offset = "0x78686D0", VA = "0x1878696D0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x78698C0", Offset = "0x78688C0", VA = "0x1878698C0")]
		private void HFKBHOGKMCD(bool MBINENIOFBM, object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7869AE0", Offset = "0x7868AE0", VA = "0x187869AE0")]
		private void KAHOJMFBCNG(bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x786A3C0", Offset = "0x78693C0", VA = "0x18786A3C0")]
		public bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x786A000", Offset = "0x7869000", VA = "0x18786A000")]
		public void SetConstraintEnabled(bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7869F90", Offset = "0x7868F90", VA = "0x187869F90")]
		public void SetConstraintAllowed(bool OGPDOGNHKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7869540", Offset = "0x7868540", VA = "0x187869540")]
		private bool DBMIJIBOMNA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7869260", Offset = "0x7868260", VA = "0x187869260")]
		private void CGKFDKGOCNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x786AF00", Offset = "0x7869F00", VA = "0x18786AF00")]
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
		private sealed class HIOAMOMJBCI : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private MIAEKAOKMEH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public HIOAMOMJBCI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7867AF0", Offset = "0x7866AF0", VA = "0x187867AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7867BC0", Offset = "0x7866BC0", VA = "0x187867BC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const float MHHAPACEPJC = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool PBOJHELCJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int EOFAGKLGMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private PointerEventData FGCBLILJGCN;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JFMBBHOLPOC<PointerEventData> HJKAKIJPIPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JFMBBHOLPOC<PointerEventData> IIADFLAFHGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JFMBBHOLPOC<PointerEventData> GBNLHPMONAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JFMBBHOLPOC<PointerEventData> MADFCDEMPBA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JFMBBHOLPOC<PointerEventData> AENKNPIGOLH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public JFMBBHOLPOC<PointerEventData> IHNBCGCMMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8B42A0", Offset = "0x8B32A0", VA = "0x1808B42A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public JFMBBHOLPOC<PointerEventData> AIPOENCFBJG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4280", Offset = "0x8B3280", VA = "0x1808B4280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78649D0", Offset = "0x78639D0", VA = "0x1878649D0", Slot = "4")]
		public void OnPointerClick(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7864D00", Offset = "0x7863D00", VA = "0x187864D00", Slot = "5")]
		public void OnPointerUp(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7864A30", Offset = "0x7863A30", VA = "0x187864A30", Slot = "6")]
		public void OnPointerDown(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7864940", Offset = "0x7863940", VA = "0x187864940")]
		[IteratorStateMachine(typeof(HIOAMOMJBCI))]
		private IEnumerator<MIAEKAOKMEH> MANLNCBHFOM(int EOFAGKLGMJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7864BA0", Offset = "0x7863BA0", VA = "0x187864BA0", Slot = "7")]
		public void OnPointerEnter(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7864C40", Offset = "0x7863C40", VA = "0x187864C40", Slot = "8")]
		public void OnPointerExit(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7864830", Offset = "0x7863830", VA = "0x187864830")]
		private bool KHJFLLHMNFA(GameObject IEELEEMHGEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7864D70", Offset = "0x7863D70", VA = "0x187864D70")]
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
