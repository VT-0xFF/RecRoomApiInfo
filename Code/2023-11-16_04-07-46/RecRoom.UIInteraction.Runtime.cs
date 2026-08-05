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
public static class HJJNFFINKKB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6529810", Offset = "0x6528810", VA = "0x186529810")]
	public static void FHPECGCLOBG(Component NDABCGGAOCM, bool GFHFKCIIDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6529790", Offset = "0x6528790", VA = "0x186529790")]
	public static void EDLIIGOIFGG(Text CDBCMDMBHMF, string EJDEHHPOEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6529710", Offset = "0x6528710", VA = "0x186529710")]
	public static void EDLIIGOIFGG(TMP_Text CDBCMDMBHMF, string EJDEHHPOEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x65298A0", Offset = "0x65288A0", VA = "0x1865298A0")]
	public static void HAFKECNBCMK(Image BFBEJMLGJCM, Sprite BFJLBMGMFAJ, bool NOLJJNOADDL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6529970", Offset = "0x6528970", VA = "0x186529970")]
	public static void OHKNNJFGJIC(RawImage BFBEJMLGJCM, Texture2D ALGCGDPDEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6529680", Offset = "0x6528680", VA = "0x186529680")]
	public static void ABCAJKMBELH(Graphic MIFLECBLIAI, Color NGFEKFKHCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65299F0", Offset = "0x65289F0", VA = "0x1865299F0")]
	public static bool OJMDCHPMKAE(GameObject GFBHJHHLEFD)
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
		[APIEEPBMFLD(CDNIJDNCOPP.Self, false, false, false)]
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
		public readonly JEHDIEPKPPJ<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly JEHDIEPKPPJ<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EDIKLAKOPON
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x774F30", Offset = "0x773F30", VA = "0x180774F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NBEHPNMLKIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84F320", Offset = "0x84E320", VA = "0x18084F320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float JNLKAAMGBLP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8F8FF0", Offset = "0x8F7FF0", VA = "0x1808F8FF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform EOBJEFNOGJD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6527A90", Offset = "0x6526A90", VA = "0x186527A90", Slot = "5")]
		public void OnDrag(PointerEventData MFCMLHEKFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6527B10", Offset = "0x6526B10", VA = "0x186527B10", Slot = "4")]
		public void OnScroll(PointerEventData MFCMLHEKFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6527A40", Offset = "0x6526A40", VA = "0x186527A40")]
		private Vector2 GNMAHOCGFHF(Vector2 FGHNKDLJLAM)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6527B90", Offset = "0x6526B90", VA = "0x186527B90")]
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
		private struct OGEFIHFFKFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Graphic LCCNPOFPHML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public int DOIHPAPAEFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Bounds OPMJJFKLOPJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool DJNPBHCLBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected Canvas CHJLOFKKJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected Camera DKDAIEDIEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FastGraphicRaycasterGroup HGKMMHNFIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool ILLHMOHDAEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private CCHLJBLJPFH BOMHLJJHMIB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private List<Graphic> EHINCLKHHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int HFMKNOIBGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private List<OGEFIHFFKFO> OCDMJMKJIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Vector3[] DGPCOLBKCHH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<OGEFIHFFKFO> MAEEDLACKNC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NIBMABDMGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x65294D0", Offset = "0x65284D0", VA = "0x1865294D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool OOOLLEBFMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x65280F0", Offset = "0x65270F0", VA = "0x1865280F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override Camera PLGCHFFILKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6527E20", Offset = "0x6526E20", VA = "0x186527E20", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6529390", Offset = "0x6528390", VA = "0x186529390")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6528C00", Offset = "0x6527C00", VA = "0x186528C00", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6528C70", Offset = "0x6527C70", VA = "0x186528C70", Slot = "17")]
		public override void Raycast(PointerEventData MFCMLHEKFHP, List<RaycastResult> BPEKIKLMCAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6527EE0", Offset = "0x6526EE0", VA = "0x186527EE0")]
		protected void MGJBDDLKLKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6528180", Offset = "0x6527180", VA = "0x186528180")]
		private void OPKMIHCADGL(Canvas KDCNLCNKDGG, Camera PLGCHFFILKI, Vector2 DIOMBNNDEFE, Ray FLAAJFOBHEE, List<Graphic> JIIFGIEPNEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6528BE0", Offset = "0x6527BE0", VA = "0x186528BE0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6527C60", Offset = "0x6526C60", VA = "0x186527C60")]
		public static Bounds GetBounds(Graphic AEKBFOOKJCC, Vector3[] EADLOMFAFIA)
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
		[APIEEPBMFLD(CDNIJDNCOPP.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JFINHHLMGII
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA81ED0", Offset = "0xA80ED0", VA = "0x180A81ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CCHLJBLJPFH
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray GFJHEBAKFNO, [Out] Graphic PJANEHOLJEI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable IMODINCDJHG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HOIGEJGHKOP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera JMJJDOJMMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DNHICBJBOMM FHLMEIAAKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JEHDIEPKPPJ<GameObject> NKJIAKPCHPC
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
		[APIEEPBMFLD(CDNIJDNCOPP.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool PAKLFIGDHMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool LLCBBJOKKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool JNHMGEFCLCP;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private bool COOCHHBEDPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x652D320", Offset = "0x652C320", VA = "0x18652D320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x652D1E0", Offset = "0x652C1E0", VA = "0x18652D1E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x652D820", Offset = "0x652C820", VA = "0x18652D820", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x652D800", Offset = "0x652C800", VA = "0x18652D800", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x652D760", Offset = "0x652C760", VA = "0x18652D760", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x652D940", Offset = "0x652C940", VA = "0x18652D940", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x652D740", Offset = "0x652C740", VA = "0x18652D740", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x652DA40", Offset = "0x652CA40", VA = "0x18652DA40")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x652D860", Offset = "0x652C860", VA = "0x18652D860")]
		public void SetFollowerConstraintEnabled(bool NHIMOAGIDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x652D670", Offset = "0x652C670", VA = "0x18652D670")]
		private void JKHDLOFMEDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x652D380", Offset = "0x652C380", VA = "0x18652D380")]
		private void CNHLMCEJLNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x652D4A0", Offset = "0x652C4A0", VA = "0x18652D4A0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x652DAC0", Offset = "0x652CAC0", VA = "0x18652DAC0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HPOKLNOGDCA
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6529BD0", Offset = "0x6528BD0", VA = "0x186529BD0")]
	public static bool CPMDCAEAMKN(this Transform DNNMPMAOGBP, Transform IGPIMCJILMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2504650", Offset = "0x2503650", VA = "0x182504650")]
	public static T GECDKBIMODP<T>(this Component MNNJBJHGADP, bool FBGGJINMGFH = false) where T : class
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
		private sealed class LGEKEEAIPFI : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public LGEKEEAIPFI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x652AA00", Offset = "0x6529A00", VA = "0x18652AA00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6529D50", Offset = "0x6528D50", VA = "0x186529D50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6529D10", Offset = "0x6528D10", VA = "0x186529D10")]
			private void GDOLLNLODDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x652A9B0", Offset = "0x65299B0", VA = "0x18652A9B0", Slot = "8")]
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
		private Vector3 AMLBKMFOEOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private Quaternion DEEPDBFJCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Coroutine PLNDIIGFCDA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public float DILPLIJFAEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x652B3C0", Offset = "0x652A3C0", VA = "0x18652B3C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB01170", Offset = "0xB00170", VA = "0x180B01170")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x652B430", Offset = "0x652A430", VA = "0x18652B430")]
		public void SetTarget(Vector3 LPGLCEHEHMC, Quaternion LGOFCBEILGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x652AB00", Offset = "0x6529B00", VA = "0x18652AB00")]
		[IteratorStateMachine(typeof(LGEKEEAIPFI))]
		private IEnumerator ALOBHEDPNBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x652B070", Offset = "0x652A070", VA = "0x18652B070")]
		private float KPAMBDGEEAN(float KDEPACOHPJH, Vector3 OOAEMBNCJME, Vector3 DIPOMAEEFOM, float MBMNPDOMCEP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x652AFE0", Offset = "0x6529FE0", VA = "0x18652AFE0")]
		private float KPAMBDGEEAN(float KDEPACOHPJH, float OHJMJGAOHOM, float FLIJACKEONL, float MBMNPDOMCEP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x652B200", Offset = "0x652A200", VA = "0x18652B200")]
		private Vector3 LOCMPBGHLLD(Vector3 HMLGJGIJJOB, Vector3 HOMOINJNHMK, Vector3 AKNDOLIKNGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x652B390", Offset = "0x652A390", VA = "0x18652B390")]
		private bool OBDFNNPOOMO(float APFFGFDJGLJ, float HOMOINJNHMK, float AKNDOLIKNGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x652AB80", Offset = "0x6529B80", VA = "0x18652AB80")]
		private Vector3 CNKNFEEHOJH(Quaternion LGOFCBEILGM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x652AF50", Offset = "0x6529F50", VA = "0x18652AF50")]
		private bool GBNEJKNBPPJ(Vector3 LPGLCEHEHMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x652AC60", Offset = "0x6529C60", VA = "0x18652AC60")]
		private bool EJFPGMKCCJI(Quaternion LGOFCBEILGM, bool BJECAOFMGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x652B340", Offset = "0x652A340", VA = "0x18652B340")]
		private bool MFKBOOEKOCH(Vector3 LJNLOLDLJAJ, Vector3 AHGDCNHHAHG, float NENPBHHKANE = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x652B2E0", Offset = "0x652A2E0", VA = "0x18652B2E0")]
		private bool MFKBOOEKOCH(Quaternion LJNLOLDLJAJ, Quaternion AHGDCNHHAHG, float NENPBHHKANE = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x652B650", Offset = "0x652A650", VA = "0x18652B650")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string EMEGIGEODEH = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string HMCEINJOJKI = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const float CCLEDEOFNLN = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly List<UIAnchorFollower> PNPFCEBOGGI;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly DNHICBJBOMM OnUIAnchorsUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly DNHICBJBOMM OnSyncTransform;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static HOIGEJGHKOP NGGGCGFGHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[APIEEPBMFLD(CDNIJDNCOPP.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[APIEEPBMFLD(CDNIJDNCOPP.Self, false, false, false)]
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
		private KFKHIDKOEKA JFOLAHANKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Vector3 KHIKPBFPOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Quaternion MEMEDNIMNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 KGOIJILOOCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool LNGOOACHIED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private bool FAOLMCIFFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool OCHBBDBCJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 EPFGEEKHGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private UIAnchor MDAEEFMMLIA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private bool IIKKHDJAOPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x652BEE0", Offset = "0x652AEE0", VA = "0x18652BEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public UIAnchor HHGOBAHGLKP
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x775DE0", Offset = "0x774DE0", VA = "0x180775DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool NDLMPHDBPEH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x652C0C0", Offset = "0x652B0C0", VA = "0x18652C0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x652BA40", Offset = "0x652AA40", VA = "0x18652BA40")]
		[GABBFJBHOKF(HMIDDPKLECI.Unity_AfterSceneLoad)]
		private static void EMCBFDNIFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x652C1D0", Offset = "0x652B1D0", VA = "0x18652C1D0")]
		[NBFFNNAJFGL(NAPENKJMHBJ.ExitingPlayMode, 0)]
		private static void OJJIFMENIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x652C740", Offset = "0x652B740", VA = "0x18652C740")]
		public static void SyncAllFollowers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x652B750", Offset = "0x652A750", VA = "0x18652B750", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x652C2B0", Offset = "0x652B2B0", VA = "0x18652C2B0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x652BE50", Offset = "0x652AE50", VA = "0x18652BE50")]
		public void Initialize(UIAnchor MDAEEFMMLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x652C5C0", Offset = "0x652B5C0", VA = "0x18652C5C0")]
		public void SetAnchorObjectEnabled(bool NHIMOAGIDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x652C610", Offset = "0x652B610", VA = "0x18652C610")]
		public void SetCanvasRenderingEnabled(bool NHIMOAGIDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x652BC90", Offset = "0x652AC90", VA = "0x18652BC90")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x652BB20", Offset = "0x652AB20", VA = "0x18652BB20")]
		private void FGGCANMCKGP(bool NHIMOAGIDEG, object PDIBILKHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x652C0F0", Offset = "0x652B0F0", VA = "0x18652C0F0")]
		private void MFAKBHGCACJ(bool NHIMOAGIDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x652C8B0", Offset = "0x652B8B0", VA = "0x18652C8B0")]
		public void SyncTransform()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x652C6D0", Offset = "0x652B6D0", VA = "0x18652C6D0")]
		public void SetConstraintEnabled(bool NHIMOAGIDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x652C660", Offset = "0x652B660", VA = "0x18652C660")]
		public void SetConstraintAllowed(bool PIBMDNEBOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x652C480", Offset = "0x652B480", VA = "0x18652C480")]
		private bool PCGNNEDMDNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x652BF00", Offset = "0x652AF00", VA = "0x18652BF00")]
		private void KGFJIEFFMFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x652D0C0", Offset = "0x652C0C0", VA = "0x18652D0C0")]
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
		private sealed class HIPHBEPLBEA : IEnumerator<DNLJHOFEIAO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private DNLJHOFEIAO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private DNLJHOFEIAO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
			[DebuggerHidden]
			public HIPHBEPLBEA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6529560", Offset = "0x6528560", VA = "0x186529560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6529630", Offset = "0x6528630", VA = "0x186529630", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float BBFKBIDMAFB = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool ELCKPNINGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int GFPEPMIIBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PointerEventData KILBGJGODAA;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public JEHDIEPKPPJ<PointerEventData> JPIAIIMDEEK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x76F1C0", Offset = "0x76E1C0", VA = "0x18076F1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public JEHDIEPKPPJ<PointerEventData> CJKAMJENNMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JEHDIEPKPPJ<PointerEventData> IFMFJBJGOIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x774F60", Offset = "0x773F60", VA = "0x180774F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JEHDIEPKPPJ<PointerEventData> PHNEFGKOKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x779C40", Offset = "0x778C40", VA = "0x180779C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JEHDIEPKPPJ<PointerEventData> MIMHDLGCFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x774F20", Offset = "0x773F20", VA = "0x180774F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JEHDIEPKPPJ<PointerEventData> GICEJGIFJDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7738C0", Offset = "0x7728C0", VA = "0x1807738C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JEHDIEPKPPJ<PointerEventData> PMNKLKGBINK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7738E0", Offset = "0x7728E0", VA = "0x1807738E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x65274B0", Offset = "0x65264B0", VA = "0x1865274B0", Slot = "4")]
		public void OnPointerClick(PointerEventData MFCMLHEKFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x65277E0", Offset = "0x65267E0", VA = "0x1865277E0", Slot = "5")]
		public void OnPointerUp(PointerEventData MFCMLHEKFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6527510", Offset = "0x6526510", VA = "0x186527510", Slot = "6")]
		public void OnPointerDown(PointerEventData MFCMLHEKFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6527420", Offset = "0x6526420", VA = "0x186527420")]
		[IteratorStateMachine(typeof(HIPHBEPLBEA))]
		private IEnumerator<DNLJHOFEIAO> EGMPKHGKLDM(int GFPEPMIIBBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6527680", Offset = "0x6526680", VA = "0x186527680", Slot = "7")]
		public void OnPointerEnter(PointerEventData MFCMLHEKFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6527720", Offset = "0x6526720", VA = "0x186527720", Slot = "8")]
		public void OnPointerExit(PointerEventData MFCMLHEKFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6527310", Offset = "0x6526310", VA = "0x186527310")]
		private bool BGDDMGHGGLI(GameObject GFBHJHHLEFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6527850", Offset = "0x6526850", VA = "0x186527850")]
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
