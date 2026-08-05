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
		[Cpp2IlInjected.Address(RVA = "0xA51C650", Offset = "0xA51B050", VA = "0x18A51C650", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AGUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class RFYKMQGLBSD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA518660", Offset = "0xA517060", VA = "0x18A518660")]
		public static void HAIWUIKQXMC(Component a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA5188C0", Offset = "0xA5172C0", VA = "0x18A5188C0")]
		public static void XKVTVVUNPPZ(Text a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA518840", Offset = "0xA517240", VA = "0x18A518840")]
		public static void XKVTVVUNPPZ(TMP_Text a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA518770", Offset = "0xA517170", VA = "0x18A518770")]
		public static void QGJNUBGWHQB(Image a, Sprite b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5186F0", Offset = "0xA5170F0", VA = "0x18A5186F0")]
		public static void MHGYOSNGKKD(RawImage a, Texture2D b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA5185D0", Offset = "0xA516FD0", VA = "0x18A5185D0")]
		public static void EBDIQRUPUFR(Graphic a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA518940", Offset = "0xA517340", VA = "0x18A518940")]
		public static bool ZVCTLKBVMDP(GameObject a)
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
		public readonly ASNKAFBFVVA<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly ASNKAFBFVVA<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IQFCPDWXXYR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool WOBEXOFFXWP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF82510", Offset = "0xF80F10", VA = "0x180F82510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float NGTXULGFJEM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xDBC640", Offset = "0xDBB040", VA = "0x180DBC640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform RJLTCNNWMIP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA516630", Offset = "0xA515030", VA = "0x18A516630", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5166B0", Offset = "0xA5150B0", VA = "0x18A5166B0", Slot = "4")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA5165E0", Offset = "0xA514FE0", VA = "0x18A5165E0")]
		private Vector2 AWAHYTYPTJZ(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA516730", Offset = "0xA515130", VA = "0x18A516730")]
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
		private static readonly ProfilerMarker NZYCXZUGRUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly RTAJIPHILMW TBJEXAFXHTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool UKYMDAMYSUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Canvas XFUMZOEWXVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Camera DRBFYNFZUNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private FastGraphicRaycasterGroup GLCFVHUTHER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected bool NSTODTFPEQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JVUDDWUQNQX CDYCONMBODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool? ACYXEMQBVCC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<Graphic> CNTYNEVNXEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int TDXJBFKYLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<GraphicContainer> KKRKFUNUTQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Vector3[] HFBHNTNYVKF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<GraphicContainer> FDSACAKHLOR;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool OXOXATLROXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA518400", Offset = "0xA516E00", VA = "0x18A518400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool TULXQPYKEWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA5184F0", Offset = "0xA516EF0", VA = "0x18A5184F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool ITMNBBRUCBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA516BB0", Offset = "0xA5155B0", VA = "0x18A516BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera eventCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA5169B0", Offset = "0xA5153B0", VA = "0x18A5169B0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA518290", Offset = "0xA516C90", VA = "0x18A518290")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA516A90", Offset = "0xA515490", VA = "0x18A516A90", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA516B40", Offset = "0xA515540", VA = "0x18A516B40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA5181A0", Offset = "0xA516BA0", VA = "0x18A5181A0")]
		public void SetDisabledToken(bool value, Token token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA517940", Offset = "0xA516340", VA = "0x18A517940", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA516C40", Offset = "0xA515640", VA = "0x18A516C40")]
		protected void PULQFPGXCUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA516E50", Offset = "0xA515850", VA = "0x18A516E50")]
		private void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, Ray cameraRay, List<Graphic> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA516A70", Offset = "0xA515470", VA = "0x18A516A70", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA516820", Offset = "0xA515220", VA = "0x18A516820")]
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
		public bool DMZBRHFJFQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA5167F0", Offset = "0xA5151F0", VA = "0x18A5167F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public FullScreenModalUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface JVUDDWUQNQX
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
		public abstract bool VOAFGTCBURF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract DYNHRMPGIXT UNMIWWAJHDX
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
		[Cpp2IlInjected.Address(RVA = "0xA518580", Offset = "0xA516F80", VA = "0x18A518580")]
		protected IUIAnchorFollower()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface SGNBEDKTYRA
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Camera DFIALWLTUWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		DYNHRMPGIXT MRYVDPTIAZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		ASNKAFBFVVA<GameObject> WIUKRNGIAYN
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
		private bool XHDZVBRAXDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool COYGNIXJQQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool PVCQLBHIBZP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private bool LTWNXMBBJQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA51C090", Offset = "0xA51AA90", VA = "0x18A51C090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool YBQRZAXWIFK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA51C5C0", Offset = "0xA51AFC0", VA = "0x18A51C5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA51BF30", Offset = "0xA51A930", VA = "0x18A51BF30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA51C300", Offset = "0xA51AD00", VA = "0x18A51C300", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA51C2E0", Offset = "0xA51ACE0", VA = "0x18A51C2E0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA51C240", Offset = "0xA51AC40", VA = "0x18A51C240", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA51C430", Offset = "0xA51AE30", VA = "0x18A51C430", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA51C340", Offset = "0xA51AD40", VA = "0x18A51C340")]
		public void OverrideFollower(IUIAnchorFollower newFollower)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA51C220", Offset = "0xA51AC20", VA = "0x18A51C220", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA51C4E0", Offset = "0xA51AEE0", VA = "0x18A51C4E0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA51C390", Offset = "0xA51AD90", VA = "0x18A51C390")]
		public void SetFollowerConstraintEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA51BE80", Offset = "0xA51A880", VA = "0x18A51BE80")]
		private void ASOWLHQXNKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA51C120", Offset = "0xA51AB20", VA = "0x18A51C120")]
		private void GYHKDVGPAXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA51C0F0", Offset = "0xA51AAF0", VA = "0x18A51C0F0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA51C570", Offset = "0xA51AF70", VA = "0x18A51C570")]
		public UIAnchor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class SGGQRWZVVSN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA519540", Offset = "0xA517F40", VA = "0x18A519540")]
		public static bool RSFYOFYTZTD(this Transform a, Transform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3F48680", Offset = "0x3F47080", VA = "0x183F48680")]
		public static a RAUOIOSCCVI<a>(this Component a, bool b = false) where a : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class AGDXNLOXPHZ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private object OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public UIAnchorFollowConstraint XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private Vector3 INAPQIOERPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private Vector3 HBGJIIMJQEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private bool FDMEPSBCKSQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private bool TIBODQXRPVD;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object QSADFOSKZQW
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public AGDXNLOXPHZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA515CF0", Offset = "0xA5146F0", VA = "0x18A515CF0", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA515090", Offset = "0xA513A90", VA = "0x18A515090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA515DB0", Offset = "0xA5147B0", VA = "0x18A515DB0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA515D70", Offset = "0xA514770", VA = "0x18A515D70", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
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
		private Vector3 EDGKIPSHQCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion WHSQAFDDPNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Coroutine HZZHXIAKGCK;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float OIGIFFOXSGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD621A0", Offset = "0xD60BA0", VA = "0x180D621A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool LFVBGNVTLBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x88392A0", Offset = "0x8837CA0", VA = "0x1888392A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA519C20", Offset = "0xA518620", VA = "0x18A519C20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1352940", Offset = "0x1351340", VA = "0x181352940")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA519C90", Offset = "0xA518690", VA = "0x18A519C90")]
		public void SetTarget(Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA51A0C0", Offset = "0xA518AC0", VA = "0x18A51A0C0")]
		[IteratorStateMachine(typeof(AGDXNLOXPHZ))]
		private IEnumerator WEHUEQSUKZS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA519780", Offset = "0xA518180", VA = "0x18A519780")]
		private float FJWFMQQTRXU(float a, Vector3 b, Vector3 c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA5196F0", Offset = "0xA5180F0", VA = "0x18A5196F0")]
		private float FJWFMQQTRXU(float a, float b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA51A130", Offset = "0xA518B30", VA = "0x18A51A130")]
		private Vector3 WEWDDZKQZBF(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA519910", Offset = "0xA518310", VA = "0x18A519910")]
		private bool JOLMTUVPQGH(float a, float b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA519FE0", Offset = "0xA5189E0", VA = "0x18A519FE0")]
		private Vector3 VABJJLWRCPK(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA519F50", Offset = "0xA518950", VA = "0x18A519F50")]
		private bool UYFUHQYPSUQ(Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA519940", Offset = "0xA518340", VA = "0x18A519940")]
		private bool LDXQUFULASJ(Quaternion a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA519F00", Offset = "0xA518900", VA = "0x18A519F00")]
		private bool TFLNCDWNRWG(Vector3 a, Vector3 b, float c = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA519EA0", Offset = "0xA5188A0", VA = "0x18A519EA0")]
		private bool TFLNCDWNRWG(Quaternion a, Quaternion b, float c = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA51A210", Offset = "0xA518C10", VA = "0x18A51A210")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class RWGPBGPUMAN
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
		private static readonly List<IUIAnchorFollower> CMYLCMUVEHZ;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly DYNHRMPGIXT BBXOKOWTWNB;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static SGNBEDKTYRA NEVGGFRNNYR;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static int LZWFEJUSXWL;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA518ED0", Offset = "0xA5178D0", VA = "0x18A518ED0")]
		[RRRuntimeInitializeMethod]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA518DC0", Offset = "0xA5177C0", VA = "0x18A518DC0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		internal static void IGKASPCGHIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA518FE0", Offset = "0xA5179E0", VA = "0x18A518FE0")]
		public static void PSLHOIADJKM(SyncAllContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA518D70", Offset = "0xA517770", VA = "0x18A518D70")]
		private static void HKRBGZTESAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA5193F0", Offset = "0xA517DF0", VA = "0x18A5193F0")]
		private static void URVCQVDWSIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA518B40", Offset = "0xA517540", VA = "0x18A518B40")]
		public static void HGUOUDQMTAC(IUIAnchorFollower a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA519230", Offset = "0xA517C30", VA = "0x18A519230")]
		public static void REOXSYBDIXF(IUIAnchorFollower a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string JEAKJYOEWSQ = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string EDFANGCNWIV = "AnchorObjectDisabled";

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
		private CFODDVOSBJL KXPRWEECWZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 HUDOWESHUHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion UUQMADUALCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 RJWRVNMZCGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool SVVKVPAGKQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool GTMIHPFBEWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool HZYGGSOSQTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 PSFOSOECDQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Token WOFMOBUAHAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Transform GZAWWSQTFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private UIAnchor XNPEUMANRPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static ProfilerMarker CELDVIZQOMU;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override DYNHRMPGIXT UNMIWWAJHDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool GEEMDMUFVMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA51AB90", Offset = "0xA519590", VA = "0x18A51AB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Transform TKCNCOJLDNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA51AC60", Offset = "0xA519660", VA = "0x18A51AC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public UIAnchor BQOTTHGEGSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xDE3320", Offset = "0xDE1D20", VA = "0x180DE3320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool LLSMQPRSVYF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA51ADF0", Offset = "0xA5197F0", VA = "0x18A51ADF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool VOAFGTCBURF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x102F2D0", Offset = "0x102DCD0", VA = "0x18102F2D0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x102F090", Offset = "0x102DA90", VA = "0x18102F090", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA51A3F0", Offset = "0xA518DF0", VA = "0x18A51A3F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA51AE20", Offset = "0xA519820", VA = "0x18A51AE20", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA51ABB0", Offset = "0xA5195B0", VA = "0x18A51ABB0", Slot = "23")]
		public override void Initialize(UIAnchor anchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA51B060", Offset = "0xA519A60", VA = "0x18A51B060", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA51B0B0", Offset = "0xA519AB0", VA = "0x18A51B0B0", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA51A820", Offset = "0xA519220", VA = "0x18A51A820", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA51AA10", Offset = "0xA519410", VA = "0x18A51AA10")]
		private void GJXSONPJPWT(bool a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA51BB80", Offset = "0xA51A580", VA = "0x18A51BB80")]
		private void VEJKZQXJUAV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA51B220", Offset = "0xA519C20", VA = "0x18A51B220", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA51B190", Offset = "0xA519B90", VA = "0x18A51B190", Slot = "21")]
		public override void SetConstraintEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA51B100", Offset = "0xA519B00", VA = "0x18A51B100")]
		public void SetConstraintAllowed(bool allowed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA51ACB0", Offset = "0xA5196B0", VA = "0x18A51ACB0")]
		private bool LNCAUCPJTUD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA51A610", Offset = "0xA519010", VA = "0x18A51A610")]
		private void BJYMYVKGAHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA51BCE0", Offset = "0xA51A6E0", VA = "0x18A51BCE0")]
		public UIAnchorFollower()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class UIAnchorFollowerSimple : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool VOAFGTCBURF
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xDA36F0", Offset = "0xDA20F0", VA = "0x180DA36F0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override DYNHRMPGIXT UNMIWWAJHDX
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA51A310", Offset = "0xA518D10", VA = "0x18A51A310", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "21")]
		public override void SetConstraintEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "23")]
		public override void Initialize(UIAnchor anchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA51A340", Offset = "0xA518D40", VA = "0x18A51A340")]
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
		private sealed class DNDWZDPVBUI : IEnumerator<IUPNMORLIQV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private IUPNMORLIQV OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int LBBPAVHVKRE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Clickable XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private IUPNMORLIQV BIZXNLKFYPO
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public DNDWZDPVBUI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA5164D0", Offset = "0xA514ED0", VA = "0x18A5164D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA5165A0", Offset = "0xA514FA0", VA = "0x18A5165A0", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private const float PRTLRGWZHED = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool XOWCJJFZJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int LBBPAVHVKRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private PointerEventData BZTQQQLKMYK;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ASNKAFBFVVA<PointerEventData> EKEHKEXQNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public ASNKAFBFVVA<PointerEventData> DBWOKVQEJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ASNKAFBFVVA<PointerEventData> DBKMWTHGKNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ASNKAFBFVVA<PointerEventData> DCFVTMJGBQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public ASNKAFBFVVA<PointerEventData> XXJCYCHAHAC
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public ASNKAFBFVVA<PointerEventData> TDVMHDUBBSV
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public ASNKAFBFVVA<PointerEventData> LRWSNIEZPZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA515F00", Offset = "0xA514900", VA = "0x18A515F00", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA516230", Offset = "0xA514C30", VA = "0x18A516230", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA515F60", Offset = "0xA514960", VA = "0x18A515F60", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA5162A0", Offset = "0xA514CA0", VA = "0x18A5162A0")]
		[IteratorStateMachine(typeof(DNDWZDPVBUI))]
		private IEnumerator<IUPNMORLIQV> VAMXXIJBAVK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA5160D0", Offset = "0xA514AD0", VA = "0x18A5160D0", Slot = "7")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA516170", Offset = "0xA514B70", VA = "0x18A516170", Slot = "8")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA515DF0", Offset = "0xA5147F0", VA = "0x18A515DF0")]
		private bool GQVSXPZHDFL(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA516320", Offset = "0xA514D20", VA = "0x18A516320")]
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
