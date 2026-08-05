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
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x750C050", Offset = "0x750A650", VA = "0x18750C050", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CBGDGPOKEOH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75058A0", Offset = "0x7503EA0", VA = "0x1875058A0")]
	public static void LKGPIBBMGEC(Component INEJDODHNGG, bool OPPPLDKFPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x75057A0", Offset = "0x7503DA0", VA = "0x1875057A0")]
	public static void IEMCHLKINLB(Text JBBFOPBNKKK, string FDDGJBJOOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7505820", Offset = "0x7503E20", VA = "0x187505820")]
	public static void IEMCHLKINLB(TMP_Text JBBFOPBNKKK, string FDDGJBJOOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75056D0", Offset = "0x7503CD0", VA = "0x1875056D0")]
	public static void HCLIAOCILCI(Image MJKGDFNOAAD, Sprite OGHEOOIPDFD, bool EOJADMCBDCD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75053C0", Offset = "0x75039C0", VA = "0x1875053C0")]
	public static void ANMGICGIOMJ(RawImage MJKGDFNOAAD, Texture2D AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7505440", Offset = "0x7503A40", VA = "0x187505440")]
	public static void BPLOCIFAGIK(Graphic CMBJHJAFNGH, Color FEHNKBJAMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75054D0", Offset = "0x7503AD0", VA = "0x1875054D0")]
	public static bool HACLABLDPEL(GameObject MNKAGJEGJCF)
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
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
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
		public readonly KHECJJJIFBB<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly KHECJJJIFBB<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DEGPAOMFKGE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x887870", Offset = "0x885E70", VA = "0x180887870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MKMDBKPPKAA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC41F70", Offset = "0xC40570", VA = "0x180C41F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float FPBHBJEPLPD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA1F3C0", Offset = "0xA1D9C0", VA = "0x180A1F3C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform PNLDEJHJHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x75060B0", Offset = "0x75046B0", VA = "0x1875060B0", Slot = "5")]
		public void OnDrag(PointerEventData GIEOAGIJFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7506130", Offset = "0x7504730", VA = "0x187506130", Slot = "4")]
		public void OnScroll(PointerEventData GIEOAGIJFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7506060", Offset = "0x7504660", VA = "0x187506060")]
		private Vector2 LBCDLADDFGJ(Vector2 JHBFDEBKANF)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x75061B0", Offset = "0x75047B0", VA = "0x1875061B0")]
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
		private struct EEIFKAKDCDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Graphic DMFEOGMFBCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public int AIFNLCCDOPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Bounds MODFHKDNMEC;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker JPGAGOABABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool MPCFCFJAMKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Canvas CNJHMCINIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Camera LPIPJOCENFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private FastGraphicRaycasterGroup NIBGPLBDNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool AJOLOLIADAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DPMIJCHFAGF LGIKDHMKAGO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private List<Graphic> LEDLJKGCDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int NIBEDFIDHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<EEIFKAKDCDI> LHFJJGBGCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Vector3[] FDHJOKHMJHN;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<EEIFKAKDCDI> MOHACPHHCDP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CNCNGEBGION
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7508CB0", Offset = "0x75072B0", VA = "0x187508CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool FJJPOFHCGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x75081A0", Offset = "0x75067A0", VA = "0x1875081A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera PAFMPCKJGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x75072F0", Offset = "0x75058F0", VA = "0x1875072F0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7508B70", Offset = "0x7507170", VA = "0x187508B70")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7508080", Offset = "0x7506680", VA = "0x187508080", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7508130", Offset = "0x7506730", VA = "0x187508130", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7508230", Offset = "0x7506830", VA = "0x187508230", Slot = "17")]
		public override void Raycast(PointerEventData GIEOAGIJFBB, List<RaycastResult> AOKJCFMEOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x75073B0", Offset = "0x75059B0", VA = "0x1875073B0")]
		protected void JMBBIPKHHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x75075C0", Offset = "0x7505BC0", VA = "0x1875075C0")]
		private void NGKFGBMCFPO(Canvas BOJDJHHBBIN, Camera PAFMPCKJGLJ, Vector2 EHEKMIECELA, Ray HNCMLLPEKOF, List<Graphic> NEPIFFELNII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7508060", Offset = "0x7506660", VA = "0x187508060", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7507130", Offset = "0x7505730", VA = "0x187507130")]
		public static Bounds GetBounds(Graphic BDFEFAPJDHE, Vector3[] ONLLMBOLPPP)
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
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OKKHPAEKBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5C9B400", Offset = "0x5C99A00", VA = "0x185C9B400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DPMIJCHFAGF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray IHPBALDNPAB, [Out] Graphic JIFLLICLEEK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable PCDCPIHNCOK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DNKIPLLAFMB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera NGGJOFBCLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GHNLMGKLHKE EBLOFMDENNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KHECJJJIFBB<GameObject> COBFGHOBOKJ
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
		[JLEDHNACBFM(LPFNGFMJOGK.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool CHFEIEIPHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool DECHMHNGOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool DBFJCOMNGOE;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool FHPAFPCCJPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x750BA10", Offset = "0x750A010", VA = "0x18750BA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x750B6C0", Offset = "0x7509CC0", VA = "0x18750B6C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x750BD40", Offset = "0x750A340", VA = "0x18750BD40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x750BD20", Offset = "0x750A320", VA = "0x18750BD20", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x750BC80", Offset = "0x750A280", VA = "0x18750BC80", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x750BE60", Offset = "0x750A460", VA = "0x18750BE60", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x750BC60", Offset = "0x750A260", VA = "0x18750BC60", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x750BF80", Offset = "0x750A580", VA = "0x18750BF80")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x750BD80", Offset = "0x750A380", VA = "0x18750BD80")]
		public void SetFollowerConstraintEnabled(bool GCKGFMHINMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x750BB90", Offset = "0x750A190", VA = "0x18750BB90")]
		private void NJPHPLHGCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x750BA70", Offset = "0x750A070", VA = "0x18750BA70")]
		private void MPNLOPNEFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x750B820", Offset = "0x7509E20", VA = "0x18750B820")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x750C000", Offset = "0x750A600", VA = "0x18750C000")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FMKNHHDBFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7506280", Offset = "0x7504880", VA = "0x187506280")]
	public static bool OAPJDPHJEGA(this Transform JGEMMJEFOMN, Transform LDJCBIBELIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2CB4E40", Offset = "0x2CB3440", VA = "0x182CB4E40")]
	public static T KBPLLONBGHJ<T>(this Component LLMCGMPLMBL, bool FGPBNNBIOHI = false) where T : class
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
		private sealed class FNNKAEGJHGE : IEnumerator<object>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
			[DebuggerHidden]
			public FNNKAEGJHGE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x75070B0", Offset = "0x75056B0", VA = "0x1875070B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7506400", Offset = "0x7504A00", VA = "0x187506400", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x75063C0", Offset = "0x75049C0", VA = "0x1875063C0")]
			private void LFOMCLLDDBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7507060", Offset = "0x7505660", VA = "0x187507060", Slot = "8")]
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
		private Vector3 JOIBHGPGLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Quaternion PIPOCGEFJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Coroutine ANPHGAGBEOE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float NMHPMGOKCAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x925380", Offset = "0x923980", VA = "0x180925380")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x75095F0", Offset = "0x7507BF0", VA = "0x1875095F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xF22560", Offset = "0xF20B60", VA = "0x180F22560")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x75096E0", Offset = "0x7507CE0", VA = "0x1875096E0")]
		public void SetTarget(Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7509660", Offset = "0x7507C60", VA = "0x187509660")]
		[IteratorStateMachine(typeof(FNNKAEGJHGE))]
		private IEnumerator PFBPEKPAGGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x75092C0", Offset = "0x75078C0", VA = "0x1875092C0")]
		private float EJAFCJAHFCK(float KGCMOECKECJ, Vector3 FEEOBPGLHBJ, Vector3 IGMBPNOCPFO, float ENCKJPMILBA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7509450", Offset = "0x7507A50", VA = "0x187509450")]
		private float EJAFCJAHFCK(float KGCMOECKECJ, float JPPMAJCIJDK, float JFLMHPGELFI, float ENCKJPMILBA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x75091E0", Offset = "0x75077E0", VA = "0x1875091E0")]
		private Vector3 EILHHDPCOAE(Vector3 FJEENOHPFNA, Vector3 GIEDJFEABAC, Vector3 JFCINBHKCNC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x75095C0", Offset = "0x7507BC0", VA = "0x1875095C0")]
		private bool IHNLNIDNKGN(float FCOMLCEDOAO, float GIEDJFEABAC, float JFCINBHKCNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x75094E0", Offset = "0x7507AE0", VA = "0x1875094E0")]
		private Vector3 GMIDDPDFHJH(Quaternion JOLHFCINNMA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7508E60", Offset = "0x7507460", VA = "0x187508E60")]
		private bool BKCGGMBIIKD(Vector3 LEELMECKGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7508EF0", Offset = "0x75074F0", VA = "0x187508EF0")]
		private bool DKBKHIKECIO(Quaternion JOLHFCINNMA, bool CHEOBGIAEHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7508DB0", Offset = "0x75073B0", VA = "0x187508DB0")]
		private bool BFAADAKJMLI(Vector3 JDKMLCHPKLA, Vector3 AENKMLMFBAD, float LMAJKHMLMPD = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7508E00", Offset = "0x7507400", VA = "0x187508E00")]
		private bool BFAADAKJMLI(Quaternion JDKMLCHPKLA, Quaternion AENKMLMFBAD, float LMAJKHMLMPD = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7509900", Offset = "0x7507F00", VA = "0x187509900")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string NBJNJDNMEPM = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string ELCLJCLDKCF = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const float LKHOFLGINHM = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly List<UIAnchorFollower> KJDBEGHFKPC;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly GHNLMGKLHKE OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly GHNLMGKLHKE OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static DNKIPLLAFMB PAHCGBGMCCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
		[SerializeField]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		[SerializeField]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private UIAnchorFollowConstraint followConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private GLGPGBPNFLE KCKOCHDGDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 KPFMDBJDLCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Quaternion ICIGHDANKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Vector3 BHEFGLLJGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool CCDFBODPDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool FFNFNKCDDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool BCFIMKPOANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 HGFOBGGEIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Transform DPKFLOAEHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private UIAnchor OOBGGIOAMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private bool JHOEHGDECLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x750A510", Offset = "0x7508B10", VA = "0x18750A510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Transform FLDLBOHKNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7509AC0", Offset = "0x75080C0", VA = "0x187509AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public UIAnchor CIEKCAILOCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x930BD0", Offset = "0x92F1D0", VA = "0x180930BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool NACKFGKAJNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x750A4E0", Offset = "0x7508AE0", VA = "0x18750A4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x75099F0", Offset = "0x7507FF0", VA = "0x1875099F0")]
		[KMFBAGPNCPO]
		internal static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x750A900", Offset = "0x7508F00", VA = "0x18750A900")]
		[MGLPINNJGGC(CLPKIHJHCPA.ExitingPlayMode, 0)]
		private static void PEGLLNMGGIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x750AB50", Offset = "0x7509150", VA = "0x18750AB50")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7509B10", Offset = "0x7508110", VA = "0x187509B10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x750A740", Offset = "0x7508D40", VA = "0x18750A740", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x750A350", Offset = "0x7508950", VA = "0x18750A350")]
		public void Initialize(UIAnchor OOBGGIOAMGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x750A9D0", Offset = "0x7508FD0", VA = "0x18750A9D0")]
		public void SetAnchorObjectEnabled(bool GCKGFMHINMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x750AA20", Offset = "0x7509020", VA = "0x18750AA20")]
		public void SetCanvasRenderingEnabled(bool GCKGFMHINMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x750A160", Offset = "0x7508760", VA = "0x18750A160")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7509EB0", Offset = "0x75084B0", VA = "0x187509EB0")]
		private void CJBALPCNLBJ(bool GCKGFMHINMG, object FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x750A400", Offset = "0x7508A00", VA = "0x18750A400")]
		private void KMGBHPGODCH(bool GCKGFMHINMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x750ACB0", Offset = "0x75092B0", VA = "0x18750ACB0")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x750AAE0", Offset = "0x75090E0", VA = "0x18750AAE0")]
		public void SetConstraintEnabled(bool GCKGFMHINMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x750AA70", Offset = "0x7509070", VA = "0x18750AA70")]
		public void SetConstraintAllowed(bool PJBPMILMFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x750A020", Offset = "0x7508620", VA = "0x18750A020")]
		private bool EGNELJPBALA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x750A530", Offset = "0x7508B30", VA = "0x18750A530")]
		private void OKKACPJCDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x750B580", Offset = "0x7509B80", VA = "0x18750B580")]
		public UIAnchorFollower()
		{
		}
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class AGBCFCHPFAN : IEnumerator<GJDHNIMFMOA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private GJDHNIMFMOA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private GJDHNIMFMOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x88C3A0", Offset = "0x88A9A0", VA = "0x18088C3A0")]
			[DebuggerHidden]
			public AGBCFCHPFAN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x75052A0", Offset = "0x75038A0", VA = "0x1875052A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7505370", Offset = "0x7503970", VA = "0x187505370", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float FIDKKDDNCOA = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool CMMKPLBKCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int AHPICAJHOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private PointerEventData NPDPBCBDPFC;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public KHECJJJIFBB<PointerEventData> FLLKEINDODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public KHECJJJIFBB<PointerEventData> DAAKBPCFHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KHECJJJIFBB<PointerEventData> CLFFGFFOCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public KHECJJJIFBB<PointerEventData> JFCGHJALONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x887AA0", Offset = "0x8860A0", VA = "0x180887AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KHECJJJIFBB<PointerEventData> MKBAPJAKOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x887850", Offset = "0x885E50", VA = "0x180887850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public KHECJJJIFBB<PointerEventData> HDJNDLFBELI
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8868B0", Offset = "0x884EB0", VA = "0x1808868B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public KHECJJJIFBB<PointerEventData> EHFMGODPBPA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x886850", Offset = "0x884E50", VA = "0x180886850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7505AD0", Offset = "0x75040D0", VA = "0x187505AD0", Slot = "4")]
		public void OnPointerClick(PointerEventData GIEOAGIJFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7505E00", Offset = "0x7504400", VA = "0x187505E00", Slot = "5")]
		public void OnPointerUp(PointerEventData GIEOAGIJFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7505B30", Offset = "0x7504130", VA = "0x187505B30", Slot = "6")]
		public void OnPointerDown(PointerEventData GIEOAGIJFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7505930", Offset = "0x7503F30", VA = "0x187505930")]
		[IteratorStateMachine(typeof(AGBCFCHPFAN))]
		private IEnumerator<GJDHNIMFMOA> LEFJLNOMFNE(int AHPICAJHOLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7505CA0", Offset = "0x75042A0", VA = "0x187505CA0", Slot = "7")]
		public void OnPointerEnter(PointerEventData GIEOAGIJFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7505D40", Offset = "0x7504340", VA = "0x187505D40", Slot = "8")]
		public void OnPointerExit(PointerEventData GIEOAGIJFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x75059C0", Offset = "0x7503FC0", VA = "0x1875059C0")]
		private bool MPAIADMAJDK(GameObject MNKAGJEGJCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7505E70", Offset = "0x7504470", VA = "0x187505E70")]
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
