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
public static class IBEKONFHLJP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x672F520", Offset = "0x672DF20", VA = "0x18672F520")]
	public static void CDHPNKBHIDJ(Component BBNHMANAAIO, bool IFLHKNDBIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x672F3A0", Offset = "0x672DDA0", VA = "0x18672F3A0")]
	public static void ACBKAGHHOHO(Text PCDBHICDHEH, string FINCPMICINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x672F420", Offset = "0x672DE20", VA = "0x18672F420")]
	public static void ACBKAGHHOHO(TMP_Text PCDBHICDHEH, string FINCPMICINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x672F5B0", Offset = "0x672DFB0", VA = "0x18672F5B0")]
	public static void CDNIFMIKLMJ(Image AEDDPBDNOLF, Sprite LEPFBFACFNP, bool OOPJLGHKNDF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x672F4A0", Offset = "0x672DEA0", VA = "0x18672F4A0")]
	public static void BKBBGCNDJFA(RawImage AEDDPBDNOLF, Texture2D JFFMCLFLHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x672F680", Offset = "0x672E080", VA = "0x18672F680")]
	public static void HPKGMIGDFJK(Graphic GFJNDNAKELB, Color GJNHDHNOICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x672F710", Offset = "0x672E110", VA = "0x18672F710")]
	public static bool NHJLGNJCNBF(GameObject PKKHAEKNIBL)
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
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
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
		public readonly BFONFBJGKIG<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly BFONFBJGKIG<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LNIJNEDODLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x799120", Offset = "0x797B20", VA = "0x180799120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NIPFNJOOHBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B11B0", Offset = "0x8AFBB0", VA = "0x1808B11B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float ONPJEILPAFN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7FA290", Offset = "0x7F8C90", VA = "0x1807FA290")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform EJLINGFILLI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x672CB60", Offset = "0x672B560", VA = "0x18672CB60", Slot = "5")]
		public void OnDrag(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x672CBE0", Offset = "0x672B5E0", VA = "0x18672CBE0", Slot = "4")]
		public void OnScroll(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x672CB10", Offset = "0x672B510", VA = "0x18672CB10")]
		private Vector2 ICOCDBKIGIP(Vector2 PAGJDNMNKAD)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x672CC60", Offset = "0x672B660", VA = "0x18672CC60")]
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
		private struct BBPOOPIPDDG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic KBKILJMONHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int AOAJOADJMEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds NEHIAEBIKOI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool FAODKCCIFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas GJGJOKOOAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera KJDHKKALHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup MEAHPFBFGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool PJPBCDOMMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private PMMBOILGHHA FGGBKJALIJM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> FDLNHFOMOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int JKEGFBAPLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<BBPOOPIPDDG> JMNLNLFIABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] DHDLDNMGPHE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<BBPOOPIPDDG> KCMEBLHLAGO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GNKEJNFEBNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x672F310", Offset = "0x672DD10", VA = "0x18672F310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool FOLCCLDPOGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x672DD20", Offset = "0x672C720", VA = "0x18672DD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera CBMLJOAMEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x672DC60", Offset = "0x672C660", VA = "0x18672DC60", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x672F1D0", Offset = "0x672DBD0", VA = "0x18672F1D0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x672E830", Offset = "0x672D230", VA = "0x18672E830", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x672EAB0", Offset = "0x672D4B0", VA = "0x18672EAB0", Slot = "17")]
		public override void Raycast(PointerEventData KMDMCPBDECK, List<RaycastResult> GPCCEMPNIFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x672E8A0", Offset = "0x672D2A0", VA = "0x18672E8A0")]
		protected void PGFBPPBMOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x672DDB0", Offset = "0x672C7B0", VA = "0x18672DDB0")]
		private void NBFGDMFMJOP(Canvas GJPGDKGHJME, Camera CBMLJOAMEFJ, Vector2 JJIAFEPCCPM, Ray HEECANFHHFK, List<Graphic> MPNPIBEFEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x672E810", Offset = "0x672D210", VA = "0x18672E810", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x672DAA0", Offset = "0x672C4A0", VA = "0x18672DAA0")]
		public static Bounds GetBounds(Graphic COGJFEICKFK, Vector3[] PBBOMBMLHEI)
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
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ILFJJNBKGKA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD7F0", Offset = "0xAAC1F0", VA = "0x180AAD7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PMMBOILGHHA
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray BBMEOOANEBI, [Out] Graphic DBKFPIPOGAI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable MLJHNHOMBOM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PKHMBCIKBCD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera ILFIECPHOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BCNLEBGHOIF MAAAOLMPPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BFONFBJGKIG<GameObject> HMFEODPLNFA
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
		[IGEHDIPFLIF(EEBNILOIPCE.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool KHJCPJLHFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool FLGNCPDKJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool MAFEFGFFNBM;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool ABPPJGOFBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6732430", Offset = "0x6730E30", VA = "0x186732430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6732050", Offset = "0x6730A50", VA = "0x186732050", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6732690", Offset = "0x6731090", VA = "0x186732690", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6732670", Offset = "0x6731070", VA = "0x186732670", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67325D0", Offset = "0x6730FD0", VA = "0x1867325D0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67327B0", Offset = "0x67311B0", VA = "0x1867327B0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67325B0", Offset = "0x6730FB0", VA = "0x1867325B0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67328B0", Offset = "0x67312B0", VA = "0x1867328B0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67326D0", Offset = "0x67310D0", VA = "0x1867326D0")]
		public void SetFollowerConstraintEnabled(bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6732190", Offset = "0x6730B90", VA = "0x186732190")]
		private void EMDLAEKNCIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6732490", Offset = "0x6730E90", VA = "0x186732490")]
		private void GLIGHNHPABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6732260", Offset = "0x6730C60", VA = "0x186732260")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6732930", Offset = "0x6731330", VA = "0x186732930")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AILHMMLCCJB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x672C2A0", Offset = "0x672ACA0", VA = "0x18672C2A0")]
	public static bool HDENPNLDCII(this Transform PMJGAJHPHFJ, Transform CDMOGOKIPKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B1B0", Offset = "0x2C39BB0", VA = "0x182C3B1B0")]
	public static T LMBLOBGHIMN<T>(this Component DMFBOAFMPLH, bool LGKENECBMLI = false) where T : class
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
		private sealed class EICHCJFPNLJ : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
			[DebuggerHidden]
			public EICHCJFPNLJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x672DA20", Offset = "0x672C420", VA = "0x18672DA20", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x672CD30", Offset = "0x672B730", VA = "0x18672CD30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x672D990", Offset = "0x672C390", VA = "0x18672D990")]
			private void OEKMCAOJCOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x672D9D0", Offset = "0x672C3D0", VA = "0x18672D9D0", Slot = "8")]
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
		private Vector3 PONHBPHPBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Quaternion NBNHHGOKGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Coroutine INFIFEGLFHE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float HCCKPPFDIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8B6ED0", Offset = "0x8B58D0", VA = "0x1808B6ED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6730230", Offset = "0x672EC30", VA = "0x186730230")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB61B90", Offset = "0xB60590", VA = "0x180B61B90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67302A0", Offset = "0x672ECA0", VA = "0x1867302A0")]
		public void SetTarget(Vector3 CJONGNPPIAD, Quaternion KPKKBKKOGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x672FA50", Offset = "0x672E450", VA = "0x18672FA50")]
		[IteratorStateMachine(typeof(EICHCJFPNLJ))]
		private IEnumerator BMFFPLFLEBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x672FC10", Offset = "0x672E610", VA = "0x18672FC10")]
		private float HALMCIMGOMB(float EBAELNNINNA, Vector3 ENPEMILBPHM, Vector3 JMBODMPGOJP, float FEENIOHLELK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x672FDA0", Offset = "0x672E7A0", VA = "0x18672FDA0")]
		private float HALMCIMGOMB(float EBAELNNINNA, float JEMLFAEHOHD, float OPCGKJAILJL, float FEENIOHLELK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x672F970", Offset = "0x672E370", VA = "0x18672F970")]
		private Vector3 ADIAEGAHNND(Vector3 DDKGNAKNMEA, Vector3 BKCGACPHNCN, Vector3 NEGLEJJNHEL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6730200", Offset = "0x672EC00", VA = "0x186730200")]
		private bool LADALNOHFHB(float ENBLOMKHKAC, float BKCGACPHNCN, float NEGLEJJNHEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x672FE30", Offset = "0x672E830", VA = "0x18672FE30")]
		private Vector3 HCIFCILKJDF(Quaternion KPKKBKKOGOG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x672FAD0", Offset = "0x672E4D0", VA = "0x18672FAD0")]
		private bool DGOPIOLHIJF(Vector3 CJONGNPPIAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x672FF10", Offset = "0x672E910", VA = "0x18672FF10")]
		private bool KKNIONNDABJ(Quaternion KPKKBKKOGOG, bool BCEPGMANBLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x672FBC0", Offset = "0x672E5C0", VA = "0x18672FBC0")]
		private bool DNMCENFBGBO(Vector3 KKLPBLEHAEB, Vector3 MFJBAALKDKH, float CBDNLCPOOOO = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x672FB60", Offset = "0x672E560", VA = "0x18672FB60")]
		private bool DNMCENFBGBO(Quaternion KKLPBLEHAEB, Quaternion MFJBAALKDKH, float CBDNLCPOOOO = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x67304C0", Offset = "0x672EEC0", VA = "0x1867304C0")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string GAHCPMIOLLC = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string CJPNGLLECAA = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float PPCECGMGKBF = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly List<UIAnchorFollower> FHHOMEDMKEF;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly BCNLEBGHOIF OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly BCNLEBGHOIF OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static PKHMBCIKBCD LAHPLMNECAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
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
		private NFHAIGOLJDB LAICMGEOJBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Vector3 CFJOHEMPKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Quaternion EMJPAILCOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 DADLLDIGHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool PNCHNGADCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool HAGBPONFGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool HMBENHJDJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 BECOKLONAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private UIAnchor GOFMNFFEFJM;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private bool DGIPCMIBJBL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x67305C0", Offset = "0x672EFC0", VA = "0x1867305C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public UIAnchor JKCLDIOEBLE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x797700", Offset = "0x796100", VA = "0x180797700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool AONNGLCLOJC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6730FE0", Offset = "0x672F9E0", VA = "0x186730FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6730E70", Offset = "0x672F870", VA = "0x186730E70")]
		[DLKEJLMCDAC(LIAHCPEMJMG.Unity_AfterSceneLoad)]
		private static void IAMMEFBKIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6731180", Offset = "0x672FB80", VA = "0x186731180")]
		[NHDGMMNNJIB(ANBGDHPPCHK.ExitingPlayMode, 0)]
		private static void LNENHBICFIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x67315B0", Offset = "0x672FFB0", VA = "0x1867315B0")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x67305E0", Offset = "0x672EFE0", VA = "0x1867305E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6731260", Offset = "0x672FC60", VA = "0x186731260", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6730F50", Offset = "0x672F950", VA = "0x186730F50")]
		public void Initialize(UIAnchor GOFMNFFEFJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6731430", Offset = "0x672FE30", VA = "0x186731430")]
		public void SetAnchorObjectEnabled(bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6731480", Offset = "0x672FE80", VA = "0x186731480")]
		public void SetCanvasRenderingEnabled(bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6730AF0", Offset = "0x672F4F0", VA = "0x186730AF0")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6731010", Offset = "0x672FA10", VA = "0x186731010")]
		private void LGDFBKGHANK(bool GJMLPIHBLBF, object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6730A10", Offset = "0x672F410", VA = "0x186730A10")]
		private void EPPLMJIBHLI(bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6731720", Offset = "0x6730120", VA = "0x186731720")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6731540", Offset = "0x672FF40", VA = "0x186731540")]
		public void SetConstraintEnabled(bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67314D0", Offset = "0x672FED0", VA = "0x1867314D0")]
		public void SetConstraintAllowed(bool NMBBJEFGMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x67308D0", Offset = "0x672F2D0", VA = "0x1867308D0")]
		private bool EIBEABIOEEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6730CB0", Offset = "0x672F6B0", VA = "0x186730CB0")]
		private void HDGPGPPJIEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6731F30", Offset = "0x6730930", VA = "0x186731F30")]
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
		private sealed class ABMLOCMFJOI : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private KMDFFEOBLOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
			[DebuggerHidden]
			public ABMLOCMFJOI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x672C180", Offset = "0x672AB80", VA = "0x18672C180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x672C250", Offset = "0x672AC50", VA = "0x18672C250", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float GIKDHHPPFHN = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool AMLGLJHDBPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int LEJLDCMILGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PointerEventData BKLFOHFPBND;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public BFONFBJGKIG<PointerEventData> AHEFCJFIAHM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public BFONFBJGKIG<PointerEventData> FPIIHLPJBGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public BFONFBJGKIG<PointerEventData> DLJEKNCKILI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BFONFBJGKIG<PointerEventData> CNHDJBEFOFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x793D40", Offset = "0x792740", VA = "0x180793D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BFONFBJGKIG<PointerEventData> NNENEECLMJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7976F0", Offset = "0x7960F0", VA = "0x1807976F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BFONFBJGKIG<PointerEventData> NFKNJPEHADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x78FC90", Offset = "0x78E690", VA = "0x18078FC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public BFONFBJGKIG<PointerEventData> BMENCNDHDOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x78FCC0", Offset = "0x78E6C0", VA = "0x18078FCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x672C580", Offset = "0x672AF80", VA = "0x18672C580", Slot = "4")]
		public void OnPointerClick(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x672C8B0", Offset = "0x672B2B0", VA = "0x18672C8B0", Slot = "5")]
		public void OnPointerUp(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x672C5E0", Offset = "0x672AFE0", VA = "0x18672C5E0", Slot = "6")]
		public void OnPointerDown(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x672C4F0", Offset = "0x672AEF0", VA = "0x18672C4F0")]
		[IteratorStateMachine(typeof(ABMLOCMFJOI))]
		private IEnumerator<KMDFFEOBLOI> KOBJJNLDAOE(int LEJLDCMILGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x672C750", Offset = "0x672B150", VA = "0x18672C750", Slot = "7")]
		public void OnPointerEnter(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x672C7F0", Offset = "0x672B1F0", VA = "0x18672C7F0", Slot = "8")]
		public void OnPointerExit(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x672C3E0", Offset = "0x672ADE0", VA = "0x18672C3E0")]
		private bool GJEDNBEPDJD(GameObject PKKHAEKNIBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x672C920", Offset = "0x672B320", VA = "0x18672C920")]
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
