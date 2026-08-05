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
		[Cpp2IlInjected.Address(RVA = "0xA510150", Offset = "0xA50F150", VA = "0x18A510150", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace AGUI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class XJDGEPZXSCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA50FBE0", Offset = "0xA50EBE0", VA = "0x18A50FBE0")]
		public static void EVAHGGRNJQP(Component a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA50FDC0", Offset = "0xA50EDC0", VA = "0x18A50FDC0")]
		public static void JDXRJHMOMEC(Text a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA50FD40", Offset = "0xA50ED40", VA = "0x18A50FD40")]
		public static void JDXRJHMOMEC(TMP_Text a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA50FC70", Offset = "0xA50EC70", VA = "0x18A50FC70")]
		public static void EWOZSCLVUQI(Image a, Sprite b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA5100D0", Offset = "0xA50F0D0", VA = "0x18A5100D0")]
		public static void ZGMWMXKCHUE(RawImage a, Texture2D b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA510040", Offset = "0xA50F040", VA = "0x18A510040")]
		public static void QHGDWIMMUOQ(Graphic a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA50FE40", Offset = "0xA50EE40", VA = "0x18A50FE40")]
		public static bool NQRYAVCBKEO(GameObject a)
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
		public readonly BQFVKUSIMFN<Vector2> DragEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly BQFVKUSIMFN<Vector2> ScrollEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool AMFUNQSVEZM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD8C020", Offset = "0xD8B020", VA = "0x180D8C020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BAYTEDMNNAM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF56C20", Offset = "0xF55C20", VA = "0x180F56C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float GUEINOEXGZL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xDA1580", Offset = "0xDA0580", VA = "0x180DA1580")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RectTransform ULCIEXBADGA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA5092C0", Offset = "0xA5082C0", VA = "0x18A5092C0", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA509340", Offset = "0xA508340", VA = "0x18A509340", Slot = "4")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA509270", Offset = "0xA508270", VA = "0x18A509270")]
		private Vector2 JXTKHIHJVUM(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5093C0", Offset = "0xA5083C0", VA = "0x18A5093C0")]
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
		private static readonly ProfilerMarker NCXALGYXDLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool ignoreFastGraphicRaycasterGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly UFAHANQWLGT ABRIJYMXMAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool VXHXADOUAVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected Canvas LCBZBQWEZKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		protected Camera WGWISPVWGQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private FastGraphicRaycasterGroup FGGGIKFOTNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		protected bool EUQVQUVBDBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PTXFTCSKLYU HXFLUQGJSUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool? TNAQPTPFRIV;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private List<Graphic> FREVPRYUTQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int EZRYAPNVLXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private List<GraphicContainer> FNDMTZFNBHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Vector3[] MSFNQXCLPZE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<GraphicContainer> CVRCSMYXCGK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool RRTRRUVYTUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA50B090", Offset = "0xA50A090", VA = "0x18A50B090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool CGVWZHHGNTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA50B180", Offset = "0xA50A180", VA = "0x18A50B180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool ULFSLJFOXIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA509640", Offset = "0xA508640", VA = "0x18A509640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override Camera eventCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA5096D0", Offset = "0xA5086D0", VA = "0x18A5096D0", Slot = "9")]
		public override bool IsActive()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA50AF20", Offset = "0xA509F20", VA = "0x18A50AF20")]
		protected FastGraphicRaycaster()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA5097B0", Offset = "0xA5087B0", VA = "0x18A5097B0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA509860", Offset = "0xA508860", VA = "0x18A509860", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA50AC20", Offset = "0xA509C20", VA = "0x18A50AC20")]
		public void SetDisabledToken(bool value, Token token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA50A3C0", Offset = "0xA5093C0", VA = "0x18A50A3C0", Slot = "17")]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA50ACB0", Offset = "0xA509CB0", VA = "0x18A50ACB0")]
		protected void VTCOPJJLMDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA5098D0", Offset = "0xA5088D0", VA = "0x18A5098D0")]
		private void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, Ray cameraRay, List<Graphic> results)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA509790", Offset = "0xA508790", VA = "0x18A509790", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA5094B0", Offset = "0xA5084B0", VA = "0x18A5094B0")]
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
		public bool KAZRFVIYBRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA509480", Offset = "0xA508480", VA = "0x18A509480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
		public FastGraphicRaycasterGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RequireComponent(typeof(Canvas))]
	public class FullScreenModalUI : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
		public FullScreenModalUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PTXFTCSKLYU
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
		public abstract bool TEYXUIGMHTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "18")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract FYRDCSIKYKI JCXKFIAPFGE
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
		[Cpp2IlInjected.Address(RVA = "0xA50B350", Offset = "0xA50A350", VA = "0x18A50B350")]
		protected IUIAnchorFollower()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface MJFEZUQWDVT
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Camera HRVJKPRTFTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		FYRDCSIKYKI LZIGPTMCZFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		BQFVKUSIMFN<GameObject> FUNKQKKIBMO
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
		private bool MOSNKAHGMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool CQZDIOCXEKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool CGZJCDYRILO;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private bool UBXIEKBTMFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA50FAA0", Offset = "0xA50EAA0", VA = "0x18A50FAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PTGBCZIXDRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA50FB50", Offset = "0xA50EB50", VA = "0x18A50FB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA50F410", Offset = "0xA50E410", VA = "0x18A50F410", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA50F780", Offset = "0xA50E780", VA = "0x18A50F780", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA50F760", Offset = "0xA50E760", VA = "0x18A50F760", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA50F6C0", Offset = "0xA50E6C0", VA = "0x18A50F6C0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA50F8B0", Offset = "0xA50E8B0", VA = "0x18A50F8B0", Slot = "6")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA50F7C0", Offset = "0xA50E7C0", VA = "0x18A50F7C0")]
		public void OverrideFollower(IUIAnchorFollower newFollower)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA50F6A0", Offset = "0xA50E6A0", VA = "0x18A50F6A0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA50F960", Offset = "0xA50E960", VA = "0x18A50F960")]
		public void SyncFollower()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA50F810", Offset = "0xA50E810", VA = "0x18A50F810")]
		public void SetFollowerConstraintEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA50F9F0", Offset = "0xA50E9F0", VA = "0x18A50F9F0")]
		private void VBWQDYMWSLQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA50F570", Offset = "0xA50E570", VA = "0x18A50F570")]
		private void CRTGGWAMYGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA50F670", Offset = "0xA50E670", VA = "0x18A50F670")]
		public void ForceSyncFollowerScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA50FB00", Offset = "0xA50EB00", VA = "0x18A50FB00")]
		public UIAnchor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class GCWOJUFZRZK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA50B210", Offset = "0xA50A210", VA = "0x18A50B210")]
		public static bool CDPUSHUNQJS(this Transform a, Transform b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3AE17A0", Offset = "0x3AE07A0", VA = "0x183AE17A0")]
		public static a QQDXQEFLTQN<a>(this Component a, bool b = false) where a : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class UIAnchorFollowConstraint : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class SEIZXJIHEHI : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private object NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public UIAnchorFollowConstraint NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private Vector3 ECDGQFLQMII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private Vector3 TNMGBDKDQUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private bool LHUHIJHZMMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private bool SRJBRNPUTBM;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object FFSOTYELWYP
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public SEIZXJIHEHI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA50CB50", Offset = "0xA50BB50", VA = "0x18A50CB50", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA50BEF0", Offset = "0xA50AEF0", VA = "0x18A50BEF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA50BEB0", Offset = "0xA50AEB0", VA = "0x18A50BEB0")]
			private void LZWZIAQZAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA50CBD0", Offset = "0xA50BBD0", VA = "0x18A50CBD0", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
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
		private Vector3 OJJFBNWGVCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Quaternion WUCQXEQEMOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Coroutine BPJEKGQTXID;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public float AYZWPJRQDHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD47610", Offset = "0xD46610", VA = "0x180D47610")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool QDWMJIWDWRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x882E040", Offset = "0x882D040", VA = "0x18882E040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA50D3D0", Offset = "0xA50C3D0", VA = "0x18A50D3D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x133FF60", Offset = "0x133EF60", VA = "0x18133FF60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA50D440", Offset = "0xA50C440", VA = "0x18A50D440")]
		public void SetTarget(Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA50D730", Offset = "0xA50C730", VA = "0x18A50D730")]
		[IteratorStateMachine(typeof(SEIZXJIHEHI))]
		private IEnumerator XKJUDNZHSUP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA50D1B0", Offset = "0xA50C1B0", VA = "0x18A50D1B0")]
		private float LVOZADBINER(float a, Vector3 b, Vector3 c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA50D340", Offset = "0xA50C340", VA = "0x18A50D340")]
		private float LVOZADBINER(float a, float b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA50CDF0", Offset = "0xA50BDF0", VA = "0x18A50CDF0")]
		private Vector3 EKREMYEFKUS(Vector3 a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA50CDC0", Offset = "0xA50BDC0", VA = "0x18A50CDC0")]
		private bool EGYZSHBYXQE(float a, float b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA50D650", Offset = "0xA50C650", VA = "0x18A50D650")]
		private Vector3 TRVWHRTEJCT(Quaternion a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA50CD30", Offset = "0xA50BD30", VA = "0x18A50CD30")]
		private bool EGKKGYUWIVN(Vector3 a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA50CED0", Offset = "0xA50BED0", VA = "0x18A50CED0")]
		private bool FOJLWQOGDRE(Quaternion a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA50CCE0", Offset = "0xA50BCE0", VA = "0x18A50CCE0")]
		private bool AXWGQYSYLUL(Vector3 a, Vector3 b, float c = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA50CC80", Offset = "0xA50BC80", VA = "0x18A50CC80")]
		private bool AXWGQYSYLUL(Quaternion a, Quaternion b, float c = 0.01f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA50D7A0", Offset = "0xA50C7A0", VA = "0x18A50D7A0")]
		public UIAnchorFollowConstraint()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class PHGEMLHRQSC
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
		private static readonly List<IUIAnchorFollower> ATZWZPQIJWE;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly FYRDCSIKYKI LAAMGLQVGBO;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static MJFEZUQWDVT EBNSEUXTIDO;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static int TKRBIYOSNAK;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA50B6E0", Offset = "0xA50A6E0", VA = "0x18A50B6E0")]
		[RRRuntimeInitializeMethod]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA50B5D0", Offset = "0xA50A5D0", VA = "0x18A50B5D0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		internal static void CQWSBSHHZVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA50BA00", Offset = "0xA50AA00", VA = "0x18A50BA00")]
		public static void RKWUJBECZUX(SyncAllContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA50B9B0", Offset = "0xA50A9B0", VA = "0x18A50B9B0")]
		private static void RFNOMQWHSMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA50BC50", Offset = "0xA50AC50", VA = "0x18A50BC50")]
		private static void TFCVWZPNFTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA50B3A0", Offset = "0xA50A3A0", VA = "0x18A50B3A0")]
		public static void AYDNSFIHNVB(IUIAnchorFollower a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA50B7F0", Offset = "0xA50A7F0", VA = "0x18A50B7F0")]
		public static void OWHIFWDPFKM(IUIAnchorFollower a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[DisallowMultipleComponent]
	public class UIAnchorFollower : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private const string IJEKGWNCTTL = "CanvasHierarchyDisabled";

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private const string WMPXKWOEDUG = "AnchorObjectDisabled";

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
		private XIHSQHDZBEQ KDHMHDZYZSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 XWLJLGEMCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Quaternion GDKXWHENICX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Vector3 AUSSKSMBXHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool YWPTFRPNYJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private bool JVHKTOWRTLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool BWSKAQYRHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Vector3 TVEEIQYXUYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Token BLVBIZXGAKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Transform TIOYRJIMVEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private UIAnchor VZMJKSJSKKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private float epsilon;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static ProfilerMarker WBBQNZXBOOF;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override FYRDCSIKYKI JCXKFIAPFGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private bool VQCJTEZWDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA50DBA0", Offset = "0xA50CBA0", VA = "0x18A50DBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Transform HMYJRBLVWEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA50E1F0", Offset = "0xA50D1F0", VA = "0x18A50E1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public UIAnchor NLVSAWJUUJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xDD3B70", Offset = "0xDD2B70", VA = "0x180DD3B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool JUQGMEBOAWI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA50F0E0", Offset = "0xA50E0E0", VA = "0x18A50F0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool TEYXUIGMHTK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1000CE0", Offset = "0xFFFCE0", VA = "0x181000CE0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1000CD0", Offset = "0xFFFCD0", VA = "0x181000CD0", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA50D980", Offset = "0xA50C980", VA = "0x18A50D980", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA50E240", Offset = "0xA50D240", VA = "0x18A50E240", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA50DFC0", Offset = "0xA50CFC0", VA = "0x18A50DFC0", Slot = "23")]
		public override void Initialize(UIAnchor anchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA50E5C0", Offset = "0xA50D5C0", VA = "0x18A50E5C0", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA50E610", Offset = "0xA50D610", VA = "0x18A50E610", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA50DBC0", Offset = "0xA50CBC0", VA = "0x18A50DBC0", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA50E070", Offset = "0xA50D070", VA = "0x18A50E070")]
		private void MUJRUFARUUI(bool a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA50F110", Offset = "0xA50E110", VA = "0x18A50F110")]
		private void WZHIHKPVODU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA50E780", Offset = "0xA50D780", VA = "0x18A50E780", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA50E6F0", Offset = "0xA50D6F0", VA = "0x18A50E6F0", Slot = "21")]
		public override void SetConstraintEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA50E660", Offset = "0xA50D660", VA = "0x18A50E660")]
		public void SetConstraintAllowed(bool allowed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA50E480", Offset = "0xA50D480", VA = "0x18A50E480")]
		private bool PAFTEGPMUKQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA50DDB0", Offset = "0xA50CDB0", VA = "0x18A50DDB0")]
		private void GBBIAGZCWPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA50F270", Offset = "0xA50E270", VA = "0x18A50F270")]
		public UIAnchorFollower()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class UIAnchorFollowerSimple : IUIAnchorFollower
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool TEYXUIGMHTK
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD8C020", Offset = "0xD8B020", VA = "0x180D8C020", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD8C030", Offset = "0xD8B030", VA = "0x180D8C030", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override FYRDCSIKYKI JCXKFIAPFGE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA50D8A0", Offset = "0xA50C8A0", VA = "0x18A50D8A0", Slot = "20")]
		public override bool SyncTransform()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "21")]
		public override void SetConstraintEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "22")]
		public override void SetAnchorObjectEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "23")]
		public override void Initialize(UIAnchor anchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "24")]
		public override void ForceSyncScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "25")]
		public override void SetCanvasRenderingEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA50D8D0", Offset = "0xA50C8D0", VA = "0x18A50D8D0")]
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
		private sealed class RGGIVMMKHXP : IEnumerator<BFNVKIYRTEQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private BFNVKIYRTEQ NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public int AOWGFRJQDXD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Clickable NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private BFNVKIYRTEQ NHKNBMQLZLJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public RGGIVMMKHXP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA50BDA0", Offset = "0xA50ADA0", VA = "0x18A50BDA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA50BE70", Offset = "0xA50AE70", VA = "0x18A50BE70", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private const float YCUUMEIMTAI = 2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool AVKRDCCKIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int AOWGFRJQDXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private PointerEventData UHPTSJOHXLV;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BQFVKUSIMFN<PointerEventData> YEXJPTTVXVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public BQFVKUSIMFN<PointerEventData> UVTJMZISKMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public BQFVKUSIMFN<PointerEventData> ETMZGSUQNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public BQFVKUSIMFN<PointerEventData> RLNMJUXEWXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public BQFVKUSIMFN<PointerEventData> MZGTEBRTJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public BQFVKUSIMFN<PointerEventData> CCERTRQPYRM
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public BQFVKUSIMFN<PointerEventData> TICLULRVQYH
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B90", Offset = "0xCF6B90", VA = "0x180CF7B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA508C20", Offset = "0xA507C20", VA = "0x18A508C20", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA508F40", Offset = "0xA507F40", VA = "0x18A508F40", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA508C80", Offset = "0xA507C80", VA = "0x18A508C80", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA508BA0", Offset = "0xA507BA0", VA = "0x18A508BA0")]
		[IteratorStateMachine(typeof(RGGIVMMKHXP))]
		private IEnumerator<BFNVKIYRTEQ> NJOFQIYKOSL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA508DE0", Offset = "0xA507DE0", VA = "0x18A508DE0", Slot = "7")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA508E80", Offset = "0xA507E80", VA = "0x18A508E80", Slot = "8")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA508FB0", Offset = "0xA507FB0", VA = "0x18A508FB0")]
		private bool SDUQHFQAXHA(GameObject a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA5090C0", Offset = "0xA5080C0", VA = "0x18A5090C0")]
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
