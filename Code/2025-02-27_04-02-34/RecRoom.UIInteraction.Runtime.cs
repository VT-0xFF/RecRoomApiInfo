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
		[Cpp2IlInjected.Address(RVA = "0x7F0D8A0", Offset = "0x7F0CCA0", VA = "0x187F0D8A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MANPPPKKCLL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F09DC0", Offset = "0x7F091C0", VA = "0x187F09DC0")]
	public static void LKOGNFNMCFO(Component MEFMJJOMDFE, bool IMLBMCFLIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F09ED0", Offset = "0x7F092D0", VA = "0x187F09ED0")]
	public static void NHIBNHAHNGK(Text ACCDAFABOAH, string JGKKKNKIGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F09E50", Offset = "0x7F09250", VA = "0x187F09E50")]
	public static void NHIBNHAHNGK(TMP_Text ACCDAFABOAH, string JGKKKNKIGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F09C70", Offset = "0x7F09070", VA = "0x187F09C70")]
	public static void CEACGIEBKAE(Image GCEIHFIEBPG, Sprite HPPCDBBBHGH, bool LCIDKBKMBOE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F09D40", Offset = "0x7F09140", VA = "0x187F09D40")]
	public static void HGANJNBCLFA(RawImage GCEIHFIEBPG, Texture2D IHOMIJNFMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F09BE0", Offset = "0x7F08FE0", VA = "0x187F09BE0")]
	public static void CBEBOFBIIPI(Graphic IDGGJNLDAAM, Color NHCBHMJDLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F099E0", Offset = "0x7F08DE0", VA = "0x187F099E0")]
	public static bool BPIPPPNLCCG(GameObject HHDLNMHBJJD)
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
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
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
		public readonly JKOOBLENGDB<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly JKOOBLENGDB<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MBAMCFEDCMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x94FCE0", Offset = "0x94F0E0", VA = "0x18094FCE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ECDNLLEJGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x10E0BE0", Offset = "0x10DFFE0", VA = "0x1810E0BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float KEJMGJCOFAE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA430", Offset = "0xAA9830", VA = "0x180AAA430")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform MPGGMOLBFEG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F06CE0", Offset = "0x7F060E0", VA = "0x187F06CE0", Slot = "5")]
		public void OnDrag(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F06D60", Offset = "0x7F06160", VA = "0x187F06D60", Slot = "4")]
		public void OnScroll(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F06C90", Offset = "0x7F06090", VA = "0x187F06C90")]
		private Vector2 DBBALAAOOPJ(Vector2 GNKBPAECFCD)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F06DE0", Offset = "0x7F061E0", VA = "0x187F06DE0")]
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
		private struct KPEPNNLMPAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public Graphic HHAPEIMFECJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int HOKCNAGMHGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public Bounds LIBDMDDENIF;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker EFKPOGBOJBI;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static bool DoOptimizedEarlyOutOfRaycast;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly BOGJHKLDLEM MFOELOJONIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool ACCCNOOJJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Canvas BPBLCNOMEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		protected Camera LMPAJEKFDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FastGraphicRaycasterGroup EGMGHDNFNCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool PEOHEEIFJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PLPFKLCLPBE GCMFMLCEIBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool? JLOBPCEHKAJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<Graphic> DFLCPECIFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private int AGINGDBGECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<KPEPNNLMPAO> GDBOPPFKDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Vector3[] PKOFOIGMCBE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<KPEPNNLMPAO> HGNPHHDCHKP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HKEPHPEKOKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7F08AF0", Offset = "0x7F07EF0", VA = "0x187F08AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PHEOIGFMEGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7F08BE0", Offset = "0x7F07FE0", VA = "0x187F08BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool HIKPGMMAFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F07070", Offset = "0x7F06470", VA = "0x187F07070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera GPHOBLAHJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F07100", Offset = "0x7F06500", VA = "0x187F07100", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F08960", Offset = "0x7F07D60", VA = "0x187F08960")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F07EA0", Offset = "0x7F072A0", VA = "0x187F07EA0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F07F50", Offset = "0x7F07350", VA = "0x187F07F50", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F08870", Offset = "0x7F07C70", VA = "0x187F08870")]
		public void SetDisabledToken(bool KBGCCIOIGBD, FDINGGDGHDL LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F07FC0", Offset = "0x7F073C0", VA = "0x187F07FC0", Slot = "17")]
		public override void Raycast(PointerEventData NBGBHBICCPM, List<RaycastResult> ONFBAAFJCED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F071C0", Offset = "0x7F065C0", VA = "0x187F071C0")]
		protected void KDGOPCDEMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F073D0", Offset = "0x7F067D0", VA = "0x187F073D0")]
		private void KFBIJDJKACF(Canvas PHPLAJLIOLJ, Camera GPHOBLAHJHC, Vector2 FCDMCAGAHBP, Ray JGONECHAKPN, List<Graphic> JCAJHFICHIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F07E80", Offset = "0x7F07280", VA = "0x187F07E80", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F06EB0", Offset = "0x7F062B0", VA = "0x187F06EB0")]
		public static Bounds GetBounds(Graphic CJLJJENJCHE, Vector3[] JJANNDGFDAJ)
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
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool PKFLGBGJCDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x64B1B70", Offset = "0x64B0F70", VA = "0x1864B1B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public FullScreenModalUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PLPFKLCLPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BlocksRay(Ray AIOBEFAAPNG, [Out] Graphic FPFLHBODKME);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CanInteractWith(Selectable OOMMOCJOMNN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BDELDMPLFJC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera PBBLELKPLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FKDOIPNGGAF GJNGLCBFFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JKOOBLENGDB<GameObject> BLOMDHGJJFE
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
		[ALEFAIIJNEI(KCNGGJNCENB.Children, false, false, false)]
		private UIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool PNIJNNIPLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool MKMLILKNMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool DFBBCNGJKIF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private bool KFLMCEJOOAC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7F0D2A0", Offset = "0x7F0C6A0", VA = "0x187F0D2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JEDIKJEAGOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7F0D810", Offset = "0x7F0CC10", VA = "0x187F0D810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CE80", Offset = "0x7F0C280", VA = "0x187F0CE80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D500", Offset = "0x7F0C900", VA = "0x187F0D500", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D4E0", Offset = "0x7F0C8E0", VA = "0x187F0D4E0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D440", Offset = "0x7F0C840", VA = "0x187F0D440", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D620", Offset = "0x7F0CA20", VA = "0x187F0D620", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D420", Offset = "0x7F0C820", VA = "0x187F0D420", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D740", Offset = "0x7F0CB40", VA = "0x187F0D740")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D540", Offset = "0x7F0C940", VA = "0x187F0D540")]
		public void SetFollowerConstraintEnabled(bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CFE0", Offset = "0x7F0C3E0", VA = "0x187F0CFE0")]
		private void CHLLMFCLAMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D300", Offset = "0x7F0C700", VA = "0x187F0D300")]
		private void LMABPFNGPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D0B0", Offset = "0x7F0C4B0", VA = "0x187F0D0B0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D7C0", Offset = "0x7F0CBC0", VA = "0x187F0D7C0")]
		public UIAnchor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DIFPCAMAFLB
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F06B50", Offset = "0x7F05F50", VA = "0x187F06B50")]
	public static bool MNDONKPDJDK(this Transform DJHFBAMKFNI, Transform LDIAONMHHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3206450", Offset = "0x3205850", VA = "0x183206450")]
	public static T DPJJAJBPAPB<T>(this Component MOCLCNOAHKF, bool CBEDACPCFBF = false) where T : class
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
		private sealed class LDPHCCFPFAH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public LDPHCCFPFAH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7F09960", Offset = "0x7F08D60", VA = "0x187F09960", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F08CB0", Offset = "0x7F080B0", VA = "0x187F08CB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F08C70", Offset = "0x7F08070", VA = "0x187F08C70")]
			private void ACIHHJJLKBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7F09910", Offset = "0x7F08D10", VA = "0x187F09910", Slot = "8")]
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
		private Vector3 JAMGPAENPJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Quaternion ELHCBGJDCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Coroutine OCHKHMCPMCC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float PHNABBOFFFG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA928F0", Offset = "0xA91CF0", VA = "0x180A928F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GJIJGECBEOC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6419410", Offset = "0x6418810", VA = "0x186419410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A7A0", Offset = "0x7F09BA0", VA = "0x187F0A7A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x13F58B0", Offset = "0x13F4CB0", VA = "0x1813F58B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A8F0", Offset = "0x7F09CF0", VA = "0x187F0A8F0")]
		public void SetTarget(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A6F0", Offset = "0x7F09AF0", VA = "0x187F0A6F0")]
		[IteratorStateMachine(typeof(LDPHCCFPFAH))]
		private IEnumerator KLMFCIDBAHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A060", Offset = "0x7F09460", VA = "0x187F0A060")]
		private float CAGACOGOEBJ(float JBENEDBDCLJ, Vector3 NIOCBDBBCPL, Vector3 DNIGAMBFGCP, float BEEDEPCIDNA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F09FD0", Offset = "0x7F093D0", VA = "0x187F09FD0")]
		private float CAGACOGOEBJ(float JBENEDBDCLJ, float HIKNIEFBAAD, float NHECHGIPMAN, float BEEDEPCIDNA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A810", Offset = "0x7F09C10", VA = "0x187F0A810")]
		private Vector3 PIBMIIEEHBO(Vector3 PAEIDOAFBAO, Vector3 MLMIGGIAIGA, Vector3 BNCGOADGBEC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A770", Offset = "0x7F09B70", VA = "0x187F0A770")]
		private bool LPIBAODGNEP(float PCGMGDLNIGD, float MLMIGGIAIGA, float BNCGOADGBEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A4D0", Offset = "0x7F098D0", VA = "0x187F0A4D0")]
		private Vector3 CPMLPMIJILD(Quaternion MLMNPOCKAAE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A5B0", Offset = "0x7F099B0", VA = "0x187F0A5B0")]
		private bool DEFGEEAJAPE(Vector3 NDADPNJPMFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A1F0", Offset = "0x7F095F0", VA = "0x187F0A1F0")]
		private bool CHIBJOKKJMO(Quaternion MLMNPOCKAAE, bool AGBFNLKOKIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A640", Offset = "0x7F09A40", VA = "0x187F0A640")]
		private bool DMPLBJHAIDI(Vector3 CLHNCHKFPON, Vector3 KMNANLEEDKO, float ILIFBFIOLHM = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A690", Offset = "0x7F09A90", VA = "0x187F0A690")]
		private bool DMPLBJHAIDI(Quaternion CLHNCHKFPON, Quaternion KMNANLEEDKO, float ILIFBFIOLHM = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0AB10", Offset = "0x7F09F10", VA = "0x187F0AB10")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum CLLMHIDDDDL
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
		private const string DEFOIMKEDNP = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string IFEAOAEPIHK = "AnchorObjectDisabled";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static readonly List<UIAnchorFollower> EBFEMNBDPOD;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly FKDOIPNGGAF OnUIAnchorsUpdated;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static BDELDMPLFJC MHIBAPONDIA;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int OKNAEHCMBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly FKDOIPNGGAF OnSyncTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
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
		private IFFCOANOBGF NKGDLAFBFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 HGFIJPBEICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion BPEMBGMDEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 AJGKNHNDIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool HEDHGGKGPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool EJCEMEHLHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool DADCNICOPIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 JHHAKKJDJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly FDINGGDGHDL LAAJFAFNFCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private PGOINNKIDBD LICKCKPMCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Transform JFBBGIKFOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private UIAnchor FNAOLJNDJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public bool DoCanvasRenderSync;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static ProfilerMarker NBPGGEKECAD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool GMIMEAFBMCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7F0BA20", Offset = "0x7F0AE20", VA = "0x187F0BA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private Transform EJNLPEDOMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1BEAB70", Offset = "0x1BE9F70", VA = "0x181BEAB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public UIAnchor GMICPANPMNH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB83C50", Offset = "0xB83050", VA = "0x180B83C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool DJJPPJGFFGG
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7F0B850", Offset = "0x7F0AC50", VA = "0x187F0B850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B560", Offset = "0x7F0A960", VA = "0x187F0B560")]
		[ONDAMKAMKDB]
		internal static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BA40", Offset = "0x7F0AE40", VA = "0x187F0BA40")]
		[JBPLEELDMPC(GALPNODIPPP.ExitingPlayMode, 0)]
		private static void ONKGPPOKPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BEB0", Offset = "0x7F0B2B0", VA = "0x187F0BEB0")]
		public static void SyncAllFollowers(CLLMHIDDDDL BPPCEJGCMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B010", Offset = "0x7F0A410", VA = "0x187F0B010")]
		private static void BJJAPGBGEEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B510", Offset = "0x7F0A910", VA = "0x187F0B510")]
		private static void GHKILAGBEKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0AC10", Offset = "0x7F0A010", VA = "0x187F0AC10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BB20", Offset = "0x7F0AF20", VA = "0x187F0BB20", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B880", Offset = "0x7F0AC80", VA = "0x187F0B880")]
		public void Initialize(UIAnchor FNAOLJNDJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BD30", Offset = "0x7F0B130", VA = "0x187F0BD30")]
		public void SetAnchorObjectEnabled(bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BD80", Offset = "0x7F0B180", VA = "0x187F0BD80")]
		public void SetCanvasRenderingEnabled(bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B320", Offset = "0x7F0A720", VA = "0x187F0B320")]
		public void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B060", Offset = "0x7F0A460", VA = "0x187F0B060")]
		private void BOLFCIAKKPD(bool GCDMKJKGKMA, object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B930", Offset = "0x7F0AD30", VA = "0x187F0B930")]
		private void KINEEFFNODB(bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C220", Offset = "0x7F0B620", VA = "0x187F0C220")]
		public bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BE40", Offset = "0x7F0B240", VA = "0x187F0BE40")]
		public void SetConstraintEnabled(bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BDD0", Offset = "0x7F0B1D0", VA = "0x187F0BDD0")]
		public void SetConstraintAllowed(bool DCHOPOCLKNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B1E0", Offset = "0x7F0A5E0", VA = "0x187F0B1E0")]
		private bool FJMEFINKGNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F0B640", Offset = "0x7F0AA40", VA = "0x187F0B640")]
		private void IHLGJAKCNKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CCE0", Offset = "0x7F0C0E0", VA = "0x187F0CCE0")]
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
		private sealed class DDFDMMFPMNI : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int pointerDownCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Clickable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public DDFDMMFPMNI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7F06A30", Offset = "0x7F05E30", VA = "0x187F06A30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x7F06B00", Offset = "0x7F05F00", VA = "0x187F06B00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private const float CCDNKIOBHNL = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool OKHCHEBEJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int POLIKCCHKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private PointerEventData LHCALMDBKMG;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JKOOBLENGDB<PointerEventData> DCHLNILACHD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JKOOBLENGDB<PointerEventData> CJNOMDHMGKE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JKOOBLENGDB<PointerEventData> KNBNBEOBKGE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public JKOOBLENGDB<PointerEventData> KGLIDOEPKHM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public JKOOBLENGDB<PointerEventData> HMFDDHFKOJL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public JKOOBLENGDB<PointerEventData> KMHAPEPDACM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x94FD70", Offset = "0x94F170", VA = "0x18094FD70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public JKOOBLENGDB<PointerEventData> BNHLKCIFIHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x94FCC0", Offset = "0x94F0C0", VA = "0x18094FCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F064A0", Offset = "0x7F058A0", VA = "0x187F064A0", Slot = "4")]
		public void OnPointerClick(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F067D0", Offset = "0x7F05BD0", VA = "0x187F067D0", Slot = "5")]
		public void OnPointerUp(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F06500", Offset = "0x7F05900", VA = "0x187F06500", Slot = "6")]
		public void OnPointerDown(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F06300", Offset = "0x7F05700", VA = "0x187F06300")]
		[IteratorStateMachine(typeof(DDFDMMFPMNI))]
		private IEnumerator<FBLKJCIOKGP> NDODOEFAHOH(int POLIKCCHKGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F06670", Offset = "0x7F05A70", VA = "0x187F06670", Slot = "7")]
		public void OnPointerEnter(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F06710", Offset = "0x7F05B10", VA = "0x187F06710", Slot = "8")]
		public void OnPointerExit(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7F06390", Offset = "0x7F05790", VA = "0x187F06390")]
		private bool OHBNFEFFPAN(GameObject HHDLNMHBJJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7F06840", Offset = "0x7F05C40", VA = "0x187F06840")]
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
