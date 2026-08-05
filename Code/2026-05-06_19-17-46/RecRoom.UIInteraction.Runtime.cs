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
		[Cpp2IlInjected.Address(RVA = "0xA3BE6A0", Offset = "0xA3BD0A0", VA = "0x18A3BE6A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AGUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class BOLXOYJHQMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3B80E0", Offset = "0xA3B6AE0", VA = "0x18A3B80E0")]
		public static void HIZRBJXVIOP(Component a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA3B82C0", Offset = "0xA3B6CC0", VA = "0x18A3B82C0")]
		public static void QAKELIOEOPU(Text a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8240", Offset = "0xA3B6C40", VA = "0x18A3B8240")]
		public static void QAKELIOEOPU(TMP_Text a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8170", Offset = "0xA3B6B70", VA = "0x18A3B8170")]
		public static void LHVZBKKLHKA(Image a, Sprite b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8060", Offset = "0xA3B6A60", VA = "0x18A3B8060")]
		public static void CWUKAEYPJUM(RawImage a, Texture2D b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8340", Offset = "0xA3B6D40", VA = "0x18A3B8340")]
		public static void TJLQPNOFFVG(Graphic a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA3B7E60", Offset = "0xA3B6860", VA = "0x18A3B7E60")]
		public static bool CUGKHSNEBUS(GameObject a)
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
		public readonly PCNXPJVUXFJ<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly PCNXPJVUXFJ<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ZBEQIWRLLQC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD69260", Offset = "0xD67C60", VA = "0x180D69260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BEDQPSWQGCU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF4FA70", Offset = "0xF4E470", VA = "0x180F4FA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float LAELGYHEUAN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD81890", Offset = "0xD80290", VA = "0x180D81890")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform GRVQUGOAZPW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8AF0", Offset = "0xA3B74F0", VA = "0x18A3B8AF0", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8B70", Offset = "0xA3B7570", VA = "0x18A3B8B70", Slot = "4")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8AA0", Offset = "0xA3B74A0", VA = "0x18A3B8AA0")]
		private Vector2 ETQEQHMUMPS(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8BF0", Offset = "0xA3B75F0", VA = "0x18A3B8BF0")]
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
		private static readonly ProfilerMarker UWEUCFRPLVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XRYICDRHQRR TGVCCWRCPAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool XLGKRYXWTNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Canvas XFSFMWIVYYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Camera EPVPDILXOSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private FastGraphicRaycasterGroup VTFHPQAVLLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected bool IMNVEEZSMTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ESNZISDECDC BCJLURVWQKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool? EQKMTHUXAJH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<Graphic> MLDDQJASSDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int HZEMAWKANIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<GraphicContainer> FDQCQMHZNVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Vector3[] PNJLTJBTUHM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<GraphicContainer> THIKHGZMYXY;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LBVQDMDLGEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA3BA8B0", Offset = "0xA3B92B0", VA = "0x18A3BA8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BMNYGZRRUNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA3BA9A0", Offset = "0xA3B93A0", VA = "0x18A3BA9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool FWRCGRHVJLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA3BA650", Offset = "0xA3B9050", VA = "0x18A3BA650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera eventCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8E70", Offset = "0xA3B7870", VA = "0x18A3B8E70", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA3BA740", Offset = "0xA3B9140", VA = "0x18A3BA740")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8F50", Offset = "0xA3B7950", VA = "0x18A3B8F50", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9000", Offset = "0xA3B7A00", VA = "0x18A3B9000", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA3BA3B0", Offset = "0xA3B8DB0", VA = "0x18A3BA3B0")]
		public void SetDisabledToken(bool value, Token token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9B50", Offset = "0xA3B8550", VA = "0x18A3B9B50", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA3BA440", Offset = "0xA3B8E40", VA = "0x18A3BA440")]
		protected void TZCIZGFTQCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9070", Offset = "0xA3B7A70", VA = "0x18A3B9070")]
		private void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, Ray cameraRay, List<Graphic> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8F30", Offset = "0xA3B7930", VA = "0x18A3B8F30", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8CE0", Offset = "0xA3B76E0", VA = "0x18A3B8CE0")]
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
		public bool PDOLUVAGPUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA3B8CB0", Offset = "0xA3B76B0", VA = "0x18A3B8CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		public FullScreenModalUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ESNZISDECDC
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
		public abstract bool XQCGVAKYFKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract PZVGSBFXRHS APOALPDBNNW
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
		[Cpp2IlInjected.Address(RVA = "0xA3BAA30", Offset = "0xA3B9430", VA = "0x18A3BAA30")]
		protected IUIAnchorFollower()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface MFRCMJUMZFD
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Camera PAXCLEUDMKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PZVGSBFXRHS KYNCGVFUHPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		PCNXPJVUXFJ<GameObject> PLYZBSIPZFE
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
		private bool GVEAURPQOAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool DSEQJMUADDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool AVKPEAAVSJC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private bool ZDAMGLNIBPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA3BE140", Offset = "0xA3BCB40", VA = "0x18A3BE140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KFRBTLNNJQD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA3BE4D0", Offset = "0xA3BCED0", VA = "0x18A3BE4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDE40", Offset = "0xA3BC840", VA = "0x18A3BDE40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE0B0", Offset = "0xA3BCAB0", VA = "0x18A3BE0B0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE090", Offset = "0xA3BCA90", VA = "0x18A3BE090", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDFF0", Offset = "0xA3BC9F0", VA = "0x18A3BDFF0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE340", Offset = "0xA3BCD40", VA = "0x18A3BE340", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE0F0", Offset = "0xA3BCAF0", VA = "0x18A3BE0F0")]
		public void OverrideFollower(IUIAnchorFollower newFollower)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDFD0", Offset = "0xA3BC9D0", VA = "0x18A3BDFD0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE3F0", Offset = "0xA3BCDF0", VA = "0x18A3BE3F0")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE2A0", Offset = "0xA3BCCA0", VA = "0x18A3BE2A0")]
		public void SetFollowerConstraintEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDD90", Offset = "0xA3BC790", VA = "0x18A3BDD90")]
		private void AOWUNDZMHJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE1A0", Offset = "0xA3BCBA0", VA = "0x18A3BE1A0")]
		private void RTSVGLOHQGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDFA0", Offset = "0xA3BC9A0", VA = "0x18A3BDFA0")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE480", Offset = "0xA3BCE80", VA = "0x18A3BE480")]
		public UIAnchor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class ZYRJAELXCSU
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE560", Offset = "0xA3BCF60", VA = "0x18A3BE560")]
		public static bool SUUOEHSRYAE(this Transform a, Transform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4144820", Offset = "0x4143220", VA = "0x184144820")]
		public static a URWMDJRZXFD<a>(this Component a, bool b = false) where a : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class AXSESKXXZCO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private object BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public UIAnchorFollowConstraint IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private Vector3 GVTWGJKUEUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private Vector3 ATBJDDCIDSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private bool RUBGGBWCAKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private bool SWCMXMJSKLE;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object BIQZSYBZPAT
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public AXSESKXXZCO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7DA0", Offset = "0xA3B67A0", VA = "0x18A3B7DA0", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7140", Offset = "0xA3B5B40", VA = "0x18A3B7140", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7100", Offset = "0xA3B5B00", VA = "0x18A3B7100")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7E20", Offset = "0xA3B6820", VA = "0x18A3B7E20", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
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
		private Vector3 FSHRPVIFDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion JKNJTITRJVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Coroutine LCMREXDLUCD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float GDAQUWSJBNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD27D20", Offset = "0xD26720", VA = "0x180D27D20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JIPVWCLDMFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x86DA4B0", Offset = "0x86D8EB0", VA = "0x1886DA4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA3BBE30", Offset = "0xA3BA830", VA = "0x18A3BBE30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x131CAF0", Offset = "0x131B4F0", VA = "0x18131CAF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA3BBEA0", Offset = "0xA3BA8A0", VA = "0x18A3BBEA0")]
		public void SetTarget(Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC0B0", Offset = "0xA3BAAB0", VA = "0x18A3BC0B0")]
		[IteratorStateMachine(typeof(AXSESKXXZCO))]
		private IEnumerator XHKDGKYEOPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB6E0", Offset = "0xA3BA0E0", VA = "0x18A3BB6E0")]
		private float MRRJAFSTJWN(float a, Vector3 b, Vector3 c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB870", Offset = "0xA3BA270", VA = "0x18A3BB870")]
		private float MRRJAFSTJWN(float a, float b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3BBC70", Offset = "0xA3BA670", VA = "0x18A3BBC70")]
		private Vector3 OFRPBVLGEFA(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB600", Offset = "0xA3BA000", VA = "0x18A3BB600")]
		private bool ABRLSDVRHKA(float a, float b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA3BBD50", Offset = "0xA3BA750", VA = "0x18A3BBD50")]
		private Vector3 OJZQUWCMXPR(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA3BBBE0", Offset = "0xA3BA5E0", VA = "0x18A3BBBE0")]
		private bool OCXIUVBBYXZ(Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB900", Offset = "0xA3BA300", VA = "0x18A3BB900")]
		private bool NSTQBBGLBVU(Quaternion a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB690", Offset = "0xA3BA090", VA = "0x18A3BB690")]
		private bool HNYUKSMECBF(Vector3 a, Vector3 b, float c = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB630", Offset = "0xA3BA030", VA = "0x18A3BB630")]
		private bool HNYUKSMECBF(Quaternion a, Quaternion b, float c = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC120", Offset = "0xA3BAB20", VA = "0x18A3BC120")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class RTYFCGEYHGO
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
		private static readonly List<IUIAnchorFollower> MQSAQQXVGDO;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly PZVGSBFXRHS UGYYPHKIFHG;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static MFRCMJUMZFD DUPSCNJOEUE;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static int DHUHOJRCSKK;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BAFA0", Offset = "0xA3B99A0", VA = "0x18A3BAFA0")]
		[RRRuntimeInitializeMethod]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB150", Offset = "0xA3B9B50", VA = "0x18A3BB150")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		internal static void XOHJUZUXNFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA3BAB90", Offset = "0xA3B9590", VA = "0x18A3BAB90")]
		public static void BGSJFEOPVUH(SyncAllContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB100", Offset = "0xA3B9B00", VA = "0x18A3BB100")]
		private static void WNOBDZXCNGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB0B0", Offset = "0xA3B9AB0", VA = "0x18A3BB0B0")]
		private static void JSXVRLSICGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB260", Offset = "0xA3B9C60", VA = "0x18A3BB260")]
		public static void ZTLXDRHPOTZ(IUIAnchorFollower a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA3BADE0", Offset = "0xA3B97E0", VA = "0x18A3BADE0")]
		public static void GRPQKXNOAVS(IUIAnchorFollower a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string OGVMCNALSXX = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string KIDUWDQLHJU = "AnchorObjectDisabled";

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
		private WFSYYVMEPOE LGWNFEPTWWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 YIIRZLATLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion JODJDLFLTLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 SPDNDVFNGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool TMOWHDJKTRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool KQQGQMTXIFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool ICONEUQHHKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 SQUMCIHGFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Token XJYKVZDWVDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Transform TDHCJORHWXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private UIAnchor SEPLUOHSLNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static ProfilerMarker HZJIHSIUKXL;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override PZVGSBFXRHS APOALPDBNNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool YRPTLSUCAJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA3BCA80", Offset = "0xA3BB480", VA = "0x18A3BCA80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Transform YMEIVUOXKZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA3BDA40", Offset = "0xA3BC440", VA = "0x18A3BDA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public UIAnchor CUGTOHFBBUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xDB03C0", Offset = "0xDAEDC0", VA = "0x180DB03C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool XTRAYOYZDII
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA3BCEF0", Offset = "0xA3BB8F0", VA = "0x18A3BCEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool XQCGVAKYFKU
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xFF69E0", Offset = "0xFF53E0", VA = "0x180FF69E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xFF69D0", Offset = "0xFF53D0", VA = "0x180FF69D0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC300", Offset = "0xA3BAD00", VA = "0x18A3BC300", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BCAA0", Offset = "0xA3BB4A0", VA = "0x18A3BCAA0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC9D0", Offset = "0xA3BB3D0", VA = "0x18A3BC9D0", Slot = "23")]
		public override void Initialize(UIAnchor anchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA3BCF20", Offset = "0xA3BB920", VA = "0x18A3BCF20", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA3BCF70", Offset = "0xA3BB970", VA = "0x18A3BCF70", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC7E0", Offset = "0xA3BB1E0", VA = "0x18A3BC7E0", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC660", Offset = "0xA3BB060", VA = "0x18A3BC660")]
		private void EKMATLTSCDK(bool a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDA90", Offset = "0xA3BC490", VA = "0x18A3BDA90")]
		private void WVJLFITFBJU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD0E0", Offset = "0xA3BBAE0", VA = "0x18A3BD0E0", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD050", Offset = "0xA3BBA50", VA = "0x18A3BD050", Slot = "21")]
		public override void SetConstraintEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA3BCFC0", Offset = "0xA3BB9C0", VA = "0x18A3BCFC0")]
		public void SetConstraintAllowed(bool allowed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC520", Offset = "0xA3BAF20", VA = "0x18A3BC520")]
		private bool ECXFZLSNFRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA3BCCE0", Offset = "0xA3BB6E0", VA = "0x18A3BCCE0")]
		private void PBNTWSYXDKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDBF0", Offset = "0xA3BC5F0", VA = "0x18A3BDBF0")]
		public UIAnchorFollower()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class UIAnchorFollowerSimple : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool XQCGVAKYFKU
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD69260", Offset = "0xD67C60", VA = "0x180D69260", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD69270", Offset = "0xD67C70", VA = "0x180D69270", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override PZVGSBFXRHS APOALPDBNNW
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC220", Offset = "0xA3BAC20", VA = "0x18A3BC220", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "21")]
		public override void SetConstraintEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "23")]
		public override void Initialize(UIAnchor anchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC250", Offset = "0xA3BAC50", VA = "0x18A3BC250")]
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
		private sealed class NSFLAXIMGAR : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int SKRUDYCSAKZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Clickable IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public NSFLAXIMGAR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA3BAA80", Offset = "0xA3B9480", VA = "0x18A3BAA80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA3BAB50", Offset = "0xA3B9550", VA = "0x18A3BAB50", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private const float WUKSXZKBILG = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool AJPDQBGSFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int SKRUDYCSAKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private PointerEventData REBNTCHQHUL;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public PCNXPJVUXFJ<PointerEventData> EEHGAORYNTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public PCNXPJVUXFJ<PointerEventData> RBCSIUDZIKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public PCNXPJVUXFJ<PointerEventData> OIKZOLAAOQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public PCNXPJVUXFJ<PointerEventData> SSDGRQWTCMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public PCNXPJVUXFJ<PointerEventData> BVEZQRORFVB
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public PCNXPJVUXFJ<PointerEventData> VQGBWWEVWIG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C10", Offset = "0xCD5610", VA = "0x180CD6C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public PCNXPJVUXFJ<PointerEventData> EUCWBOIIURN
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCDAC20", Offset = "0xCD9620", VA = "0x180CDAC20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8450", Offset = "0xA3B6E50", VA = "0x18A3B8450", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8770", Offset = "0xA3B7170", VA = "0x18A3B8770", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B84B0", Offset = "0xA3B6EB0", VA = "0x18A3B84B0", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA3B83D0", Offset = "0xA3B6DD0", VA = "0x18A3B83D0")]
		[IteratorStateMachine(typeof(NSFLAXIMGAR))]
		private IEnumerator<KHZACSYKHRO> BCNMKRFXTWP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8610", Offset = "0xA3B7010", VA = "0x18A3B8610", Slot = "7")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA3B86B0", Offset = "0xA3B70B0", VA = "0x18A3B86B0", Slot = "8")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA3B87E0", Offset = "0xA3B71E0", VA = "0x18A3B87E0")]
		private bool XJLDWZFUWOW(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA3B88F0", Offset = "0xA3B72F0", VA = "0x18A3B88F0")]
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
