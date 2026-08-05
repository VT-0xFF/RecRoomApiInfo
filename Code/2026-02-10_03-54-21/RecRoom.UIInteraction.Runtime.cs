using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Attributes;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.DataStructures.Tokens;
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
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8F6C090", Offset = "0x8F6B290", VA = "0x188F6C090", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AGUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class MPSFWPPYRJU
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F67490", Offset = "0x8F66690", VA = "0x188F67490")]
		public static void JDGOAAHMIGF(Component a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F67520", Offset = "0x8F66720", VA = "0x188F67520")]
		public static void LSQTRRSEZKQ(Text a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8F675A0", Offset = "0x8F667A0", VA = "0x188F675A0")]
		public static void LSQTRRSEZKQ(TMP_Text a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F67620", Offset = "0x8F66820", VA = "0x188F67620")]
		public static void QDZKYMTCQBM(Image a, Sprite b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F67410", Offset = "0x8F66610", VA = "0x188F67410")]
		public static void FZMRGENFRUK(RawImage a, Texture2D b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F676F0", Offset = "0x8F668F0", VA = "0x188F676F0")]
		public static void THZKDRGWGTI(Graphic a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F67210", Offset = "0x8F66410", VA = "0x188F67210")]
		public static bool DZLZYKRNXFG(GameObject a)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class DragScrollDecorator : MonoBehaviour, IScrollHandler, IEventSystemHandler, IDragHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private bool supportsHorizontalScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool supportsVerticalScrolling;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KIWRGVAWRAJ<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly KIWRGVAWRAJ<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BUBKOVFCBNW
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xB2D260", Offset = "0xB2C460", VA = "0x180B2D260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool YBHHZPVFQWK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB40", Offset = "0xCEAD40", VA = "0x180CEBB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float ZDJHATRTSUX
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB421E0", Offset = "0xB413E0", VA = "0x180B421E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform JEBGUTFTQKK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F65280", Offset = "0x8F64480", VA = "0x188F65280", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F65300", Offset = "0x8F64500", VA = "0x188F65300", Slot = "4")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F65230", Offset = "0x8F64430", VA = "0x188F65230")]
		private Vector2 NTVKULHRPZA(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F65380", Offset = "0x8F64580", VA = "0x188F65380")]
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
		private struct GraphicContainer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Graphic Graphic;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int Depth;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public Bounds Bounds;
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ProfilerMarker EFNSVDAYIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly RJTJYJPEQVT IVUTMCMAOQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool CQXVZEQDVBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Canvas HIFJKJJYVXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Camera MUNUIJIVOMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private FastGraphicRaycasterGroup YLMHPOUNTKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected bool PRXZEUNYRCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private QQAFGKJISRQ DOHUUZTPYRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool? ZQGODPDTSPR;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<Graphic> RUQKXEOMAIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int PJLMVHZRAOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<GraphicContainer> QTPJGIFLEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Vector3[] MBHAONFNHXK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<GraphicContainer> EEYQRFLLBJG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool VIQLEOGSNUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8F67040", Offset = "0x8F66240", VA = "0x188F67040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PIPTMBKULVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8F67130", Offset = "0x8F66330", VA = "0x188F67130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool GMGWPKUAZBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8F66DE0", Offset = "0x8F65FE0", VA = "0x188F66DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera eventCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xABC9A0", Offset = "0xABBBA0", VA = "0x180ABC9A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8F65600", Offset = "0x8F64800", VA = "0x188F65600", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8F66ED0", Offset = "0x8F660D0", VA = "0x188F66ED0")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8F658F0", Offset = "0x8F64AF0", VA = "0x188F658F0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F659A0", Offset = "0x8F64BA0", VA = "0x188F659A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F66D50", Offset = "0x8F65F50", VA = "0x188F66D50")]
		public void SetDisabledToken(bool value, Token token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8F664F0", Offset = "0x8F656F0", VA = "0x188F664F0", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8F656C0", Offset = "0x8F648C0", VA = "0x188F656C0")]
		protected void KAIWODXIVXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F65A10", Offset = "0x8F64C10", VA = "0x188F65A10")]
		private void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, Ray cameraRay, List<Graphic> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8F658D0", Offset = "0x8F64AD0", VA = "0x188F658D0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F65470", Offset = "0x8F64670", VA = "0x188F65470")]
		public static Bounds GetBounds(Graphic graph, Vector3[] tmpWorldCorners)
		{
			return default(Bounds);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FastGraphicRaycasterGroup : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool CGRHZRHJHOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8F65440", Offset = "0x8F64640", VA = "0x188F65440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
		public FullScreenModalUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface QQAFGKJISRQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BlocksRay(Ray ray, [Out] Graphic blockerGraphics);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CanInteractWith(Selectable selectable);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class IUIAnchorFollower : UIBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public abstract bool DDQSQZVUJMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract CVEDYLCEYBQ HJFBFGNADQW
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract bool SyncTransform();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract void SetConstraintEnabled(bool value);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract void SetAnchorObjectEnabled(bool value);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		public abstract void Initialize(UIAnchor anchor);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract void ForceSyncScale();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "25")]
		public abstract void SetCanvasRenderingEnabled(bool value);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F671C0", Offset = "0x8F663C0", VA = "0x188F671C0")]
		protected IUIAnchorFollower()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface FDFXQOJBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Camera SZDFFTTCMMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		CVEDYLCEYBQ XBULKIKEJWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		KIWRGVAWRAJ<GameObject> VWEKSMPHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	public class UIAnchor : UIBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[Autofill(AutofillType.Children, false, false, false)]
		private IUIAnchorFollower follower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool LGKROISBRVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool ATXHCAMOIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool ETXPQYAFUFM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private bool EEVAMAMXQGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8F6BC00", Offset = "0x8F6AE00", VA = "0x188F6BC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CDSSAGHNIDD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8F6C000", Offset = "0x8F6B200", VA = "0x188F6C000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8F6B8C0", Offset = "0x8F6AAC0", VA = "0x188F6B8C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BD40", Offset = "0x8F6AF40", VA = "0x188F6BD40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BD20", Offset = "0x8F6AF20", VA = "0x188F6BD20", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BC80", Offset = "0x8F6AE80", VA = "0x188F6BC80", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BE70", Offset = "0x8F6B070", VA = "0x188F6BE70", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BD80", Offset = "0x8F6AF80", VA = "0x188F6BD80")]
		public void OverrideFollower(IUIAnchorFollower newFollower)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BC60", Offset = "0x8F6AE60", VA = "0x188F6BC60", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BF20", Offset = "0x8F6B120", VA = "0x188F6BF20")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BDD0", Offset = "0x8F6AFD0", VA = "0x188F6BDD0")]
		public void SetFollowerConstraintEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BA20", Offset = "0x8F6AC20", VA = "0x188F6BA20")]
		private void BACNIEHCVMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BAD0", Offset = "0x8F6ACD0", VA = "0x188F6BAD0")]
		private void CYGFUBYMPWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BBD0", Offset = "0x8F6ADD0", VA = "0x188F6BBD0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8F6BFB0", Offset = "0x8F6B1B0", VA = "0x188F6BFB0")]
		public UIAnchor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class OXRUNIRMRVE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F67780", Offset = "0x8F66980", VA = "0x188F67780")]
		public static bool FIINIVZNSAK(this Transform a, Transform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x39501F0", Offset = "0x394F3F0", VA = "0x1839501F0")]
		public static a JJUHYIHLBTV<a>(this Component a, bool b = false) where a : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class UATBRECXBUA : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private object HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public UIAnchorFollowConstraint LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private Vector3 PSPEERMFQXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private Vector3 DYPVTNDBDYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private bool SQQTICMCFQB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private bool YZSQAHBTGUQ;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object MWTCMLUXNGJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
			[DebuggerHidden]
			public UATBRECXBUA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8F68410", Offset = "0x8F67610", VA = "0x188F68410", Slot = "5")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8F68490", Offset = "0x8F67690", VA = "0x188F68490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8F690F0", Offset = "0x8F682F0", VA = "0x188F690F0")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8F69130", Offset = "0x8F68330", VA = "0x188F69130", Slot = "8")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		[Tooltip("Curve that describes the rate of follow motion at different points in the follow (e.g.- ease in and out when starting or stopping the motion).")]
		private AnimationCurve easingCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Tooltip("How much can the UI anchor move (in meters) before this object starts following it.")]
		private float followPositionThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("How much can the UI anchor rotate (in degrees) before this object starts following it.")]
		private float followRotationThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[Tooltip("The maximum speed (in meters/second) that the UI anchor follower move when following the anchor.")]
		private float moveSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Tooltip("The maximum speed (in degrees/second) that the UI anchor follower rotate when following the anchor.")]
		private float rotationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[Tooltip("The position delta (in meters) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float easingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		[Tooltip("The rotation delta (in degrees) within which the Easing Curve is applied when starting and stopping follow behavior.")]
		private float rotationEasingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the X-axis.")]
		private bool allowXRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Y-axis.")]
		private bool allowYRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Tooltip("Whether this object should match any rotation along the Z-axis.")]
		private bool allowZRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private float maxAllowedVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Vector3 IHTAGXIZZAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion ADBNYSUCIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Coroutine FCDLHRAICDT;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float PIJWWWIBRON
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xB08BA0", Offset = "0xB07DA0", VA = "0x180B08BA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool OLEWOSSBTGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7301E90", Offset = "0x7301090", VA = "0x187301E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8F69510", Offset = "0x8F68710", VA = "0x188F69510")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x10FAE70", Offset = "0x10FA070", VA = "0x1810FAE70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8F699D0", Offset = "0x8F68BD0", VA = "0x188F699D0")]
		public void SetTarget(Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8F69470", Offset = "0x8F68670", VA = "0x188F69470")]
		[IteratorStateMachine(typeof(UATBRECXBUA))]
		private IEnumerator IOBNFCSUTMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8F69170", Offset = "0x8F68370", VA = "0x188F69170")]
		private float APZTOHLEDYH(float a, Vector3 b, Vector3 c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8F69300", Offset = "0x8F68500", VA = "0x188F69300")]
		private float APZTOHLEDYH(float a, float b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8F69860", Offset = "0x8F68A60", VA = "0x188F69860")]
		private Vector3 QFRAMOEKHZO(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8F694E0", Offset = "0x8F686E0", VA = "0x188F694E0")]
		private bool IVARICGHGRE(float a, float b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8F69390", Offset = "0x8F68590", VA = "0x188F69390")]
		private Vector3 GHWKNQNUPBT(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8F69940", Offset = "0x8F68B40", VA = "0x188F69940")]
		private bool RWBWQATBBLL(Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8F69580", Offset = "0x8F68780", VA = "0x188F69580")]
		private bool PMQJKBIODSY(Quaternion a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8F69C40", Offset = "0x8F68E40", VA = "0x188F69C40")]
		private bool YGFYWWSXILX(Vector3 a, Vector3 b, float c = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F69BE0", Offset = "0x8F68DE0", VA = "0x188F69BE0")]
		private bool YGFYWWSXILX(Quaternion a, Quaternion b, float c = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F69C90", Offset = "0x8F68E90", VA = "0x188F69C90")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class PQECVJJCWIY
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum SyncAllContext
		{
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			UIRaycast,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			CanvasRender
		}

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly List<IUIAnchorFollower> YCMLPRNOZAW;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly CVEDYLCEYBQ CTVJFJJSCJQ;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static FDFXQOJBJJB CDYKYBPCRTE;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static int RMEZMKXCCEI;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8F67B30", Offset = "0x8F66D30", VA = "0x188F67B30")]
		[RRRuntimeInitializeMethod]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8F67C40", Offset = "0x8F66E40", VA = "0x188F67C40")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		internal static void JXUWADLHVLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8F67DA0", Offset = "0x8F66FA0", VA = "0x188F67DA0")]
		public static void PNXCPRIMMQN(SyncAllContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8F678C0", Offset = "0x8F66AC0", VA = "0x188F678C0")]
		private static void CICAZUBVZZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8F67D50", Offset = "0x8F66F50", VA = "0x188F67D50")]
		private static void LIFZHZHEJVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8F67910", Offset = "0x8F66B10", VA = "0x188F67910")]
		public static void GCDEEWFSWKR(IUIAnchorFollower a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8F67FF0", Offset = "0x8F671F0", VA = "0x188F67FF0")]
		public static void ZHFQMQSUCLM(IUIAnchorFollower a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string BQLUYCUUGJZ = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string XKHXINCIVXO = "AnchorObjectDisabled";

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private FastGraphicRaycaster fastGraphicRaycaster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[Tooltip("If true, we will only disable the canvas and raycaster when the base anchor gets disabled. If false, we will disabling the entire GameObject hierarchy.")]
		private bool useOptimizedEnableDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private UIAnchorFollowConstraint followConstraint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private EWUFIVAODUW YLFKRSDHEVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 RLKQVYGNROQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion DJGUICRPNYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 WNNWTBIBJVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool ABROTURMSYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool YCCRKCJMTLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool IITHKWRDDWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 UAIAXOTGJSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Token WBHQTGJIBDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Transform YNCFVFIVAQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private UIAnchor UQYQWDJTIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static ProfilerMarker GWTJJIVCYWX;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override CVEDYLCEYBQ HJFBFGNADQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool SFXNEZADOPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8F6A420", Offset = "0x8F69620", VA = "0x188F6A420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Transform GCCZVOFBKEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8F6A440", Offset = "0x8F69640", VA = "0x188F6A440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public UIAnchor RBNMAWIYVWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB7B0F0", Offset = "0xB7A2F0", VA = "0x180B7B0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool TYWJGENDLIC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8F6A6C0", Offset = "0x8F698C0", VA = "0x188F6A6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool DDQSQZVUJMK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD89FE0", Offset = "0xD891E0", VA = "0x180D89FE0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xD89FD0", Offset = "0xD891D0", VA = "0x180D89FD0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8F69E60", Offset = "0x8F69060", VA = "0x188F69E60", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A490", Offset = "0x8F69690", VA = "0x188F6A490", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A370", Offset = "0x8F69570", VA = "0x188F6A370", Slot = "23")]
		public override void Initialize(UIAnchor anchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A830", Offset = "0x8F69A30", VA = "0x188F6A830", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A880", Offset = "0x8F69A80", VA = "0x188F6A880", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A180", Offset = "0x8F69380", VA = "0x188F6A180", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8F6B550", Offset = "0x8F6A750", VA = "0x188F6B550")]
		private void ZDYZFKJPDVY(bool a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A080", Offset = "0x8F69280", VA = "0x188F6A080")]
		private void BVFHAUOZZQU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A9F0", Offset = "0x8F69BF0", VA = "0x188F6A9F0", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A960", Offset = "0x8F69B60", VA = "0x188F6A960", Slot = "21")]
		public override void SetConstraintEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A8D0", Offset = "0x8F69AD0", VA = "0x188F6A8D0")]
		public void SetConstraintAllowed(bool allowed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8F6A6F0", Offset = "0x8F698F0", VA = "0x188F6A6F0")]
		private bool SAAAJUFMFXI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8F6B340", Offset = "0x8F6A540", VA = "0x188F6B340")]
		private void VZIWQEGNLJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8F6B730", Offset = "0x8F6A930", VA = "0x188F6B730")]
		public UIAnchorFollower()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class UIAnchorFollowerSimple : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool DDQSQZVUJMK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xB2D260", Offset = "0xB2C460", VA = "0x180B2D260", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB2D270", Offset = "0xB2C470", VA = "0x180B2D270", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override CVEDYLCEYBQ HJFBFGNADQW
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8F69D80", Offset = "0x8F68F80", VA = "0x188F69D80", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "21")]
		public override void SetConstraintEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "23")]
		public override void Initialize(UIAnchor anchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8F69DB0", Offset = "0x8F68FB0", VA = "0x188F69DB0")]
		public UIAnchorFollowerSimple()
		{
		}
	}
}
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class Clickable : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class SQIHIPPKOYD : IEnumerator<GVXKGQILIBM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private GVXKGQILIBM HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int KPSUYLIJCWX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Clickable LQBDIDDTHZG;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private GVXKGQILIBM FMWFFBPUHSV
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
			[DebuggerHidden]
			public SQIHIPPKOYD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8F68290", Offset = "0x8F67490", VA = "0x188F68290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8F68360", Offset = "0x8F67560", VA = "0x188F68360", Slot = "8")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private const float BZZRFVAFQUK = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool HTJUNQLRQGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int KPSUYLIJCWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private PointerEventData YZGSIRYDCKR;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public KIWRGVAWRAJ<PointerEventData> BUIKNSYUUJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public KIWRGVAWRAJ<PointerEventData> BHDBWBQJAQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public KIWRGVAWRAJ<PointerEventData> IJKHLNOAUZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public KIWRGVAWRAJ<PointerEventData> LNEPXPEOCVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public KIWRGVAWRAJ<PointerEventData> CGJNLWZGPMB
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xABC9A0", Offset = "0xABBBA0", VA = "0x180ABC9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public KIWRGVAWRAJ<PointerEventData> WRCBIEVVGSY
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xABCB70", Offset = "0xABBD70", VA = "0x180ABCB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public KIWRGVAWRAJ<PointerEventData> AFTYEEXHJWR
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xABC970", Offset = "0xABBB70", VA = "0x180ABC970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8F64CF0", Offset = "0x8F63EF0", VA = "0x188F64CF0", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8F65010", Offset = "0x8F64210", VA = "0x188F65010", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F64D50", Offset = "0x8F63F50", VA = "0x188F64D50", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8F64C70", Offset = "0x8F63E70", VA = "0x188F64C70")]
		[IteratorStateMachine(typeof(SQIHIPPKOYD))]
		private IEnumerator<GVXKGQILIBM> HJCUUJHTQMF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8F64EB0", Offset = "0x8F640B0", VA = "0x188F64EB0", Slot = "7")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8F64F50", Offset = "0x8F64150", VA = "0x188F64F50", Slot = "8")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8F64B60", Offset = "0x8F63D60", VA = "0x188F64B60")]
		private bool BULHKXPTFEQ(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8F65080", Offset = "0x8F64280", VA = "0x188F65080")]
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
