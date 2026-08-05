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
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class UIHandleDecorator : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class UIHandleEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Vector2 cachedScreenPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public float cachedDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public Vector3 targetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Vector3 targetForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Vector3 previousTargetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public RectTransform cachedRectTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Vector3 pressLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public Quaternion pressRotationOffset;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Vector3 RemappedWorldPressPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x82B8B40", Offset = "0x82B7540", VA = "0x1882B8B40")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x82B8BA0", Offset = "0x82B75A0", VA = "0x1882B8BA0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x82B8B00", Offset = "0x82B7500", VA = "0x1882B8B00")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x82B88D0", Offset = "0x82B72D0", VA = "0x1882B88D0")]
			public void BCOOLEPAAEI(PointerEventData BBDAPPCIKBP, RectTransform GDEAKNDHENO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x82B8640", Offset = "0x82B7040", VA = "0x1882B8640")]
			public void AAOBCFOBPKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x82B8A20", Offset = "0x82B7420", VA = "0x1882B8A20")]
			public void HOEBDHOLMED(PointerEventData BBDAPPCIKBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x82B89D0", Offset = "0x82B73D0", VA = "0x1882B89D0")]
			public void EMHDEHBHDEM(float DOKNAMNGBNG, RectTransform GDEAKNDHENO, Vector3 GHOLIOPECPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly JEBDGPAIPLL<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JEBDGPAIPLL<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly JEBDGPAIPLL<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly JEBDGPAIPLL<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly JEBDGPAIPLL<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly COOFKGJALFM PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData JLEIGODJEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool MKDGEOGGJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool BMHMBIMEBNJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IEMICPGLEIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9B21A0", Offset = "0x9B0BA0", VA = "0x1809B21A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x82B7DD0", Offset = "0x82B67D0", VA = "0x1882B7DD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool OOGAECIMAKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9B2260", Offset = "0x9B0C60", VA = "0x1809B2260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x82B83F0", Offset = "0x82B6DF0", VA = "0x1882B83F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82B7E00", Offset = "0x82B6800", VA = "0x1882B7E00")]
		private bool OABJHEDFOAE(PointerEventData GLECKDJIKIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82B82D0", Offset = "0x82B6CD0", VA = "0x1882B82D0", Slot = "5")]
		public void OnPointerDown(PointerEventData GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82B8390", Offset = "0x82B6D90", VA = "0x1882B8390", Slot = "11")]
		public void OnPointerUp(PointerEventData GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82B8140", Offset = "0x82B6B40", VA = "0x1882B8140", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82B7E80", Offset = "0x82B6880", VA = "0x1882B7E80", Slot = "7")]
		public void OnBeginDrag(PointerEventData GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82B7F90", Offset = "0x82B6990", VA = "0x1882B7F90", Slot = "4")]
		public void OnDrag(PointerEventData GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82B8070", Offset = "0x82B6A70", VA = "0x1882B8070", Slot = "8")]
		public void OnEndDrag(PointerEventData GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82B8330", Offset = "0x82B6D30", VA = "0x1882B8330", Slot = "9")]
		public void OnPointerEnter(PointerEventData GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82B8360", Offset = "0x82B6D60", VA = "0x1882B8360", Slot = "10")]
		public void OnPointerExit(PointerEventData GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82B7F50", Offset = "0x82B6950", VA = "0x1882B7F50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82B8420", Offset = "0x82B6E20", VA = "0x1882B8420")]
		public UIHandleDecorator()
		{
		}
	}
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CanvasSortingOrder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82B3750", Offset = "0x82B2150", VA = "0x1882B3750")]
		public void SetCanvasSortingOrder(short PBMNHBFBCHO, bool LILEDCDAJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData EKFNCIKLIJB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82B3A10", Offset = "0x82B2410", VA = "0x1882B3A10", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82B38F0", Offset = "0x82B22F0", VA = "0x1882B38F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82B3840", Offset = "0x82B2240", VA = "0x1882B3840")]
		private void DEIIPIPLEJK(GameObject DLKGMCJEMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82B3CF0", Offset = "0x82B26F0", VA = "0x1882B3CF0")]
		public void SetOptionsWithNoDefault(List<string> IOMEFCNHNJN, [Optional] string GJEGBHPOKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82B3C00", Offset = "0x82B2600", VA = "0x1882B3C00")]
		public void SetOptionsWithNoDefault(List<OptionData> LPHHENIAGIG, [Optional] string GJEGBHPOKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82B3B30", Offset = "0x82B2530", VA = "0x1882B3B30", Slot = "42")]
		public override void OnPointerClick(PointerEventData GLECKDJIKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas JDCHJAGEOLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82B3F10", Offset = "0x82B2910", VA = "0x1882B3F10")]
		public Dropdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class Hideable : MonoBehaviour, ILayoutIgnorer
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LJFALIOFKNJ : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private HKMFJDMPEMN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
			[DebuggerHidden]
			public LJFALIOFKNJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x82B52A0", Offset = "0x82B3CA0", VA = "0x1882B52A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x82B57B0", Offset = "0x82B41B0", VA = "0x1882B57B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[IFFOMBOELJM(PLKNMOLBJIE.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly BMLDEAJOFHA<object> JCHMBNPMJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool OOLOIJGLFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? FDJHKMCILLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? OJFACFAEHGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? APADNOHLHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool OAKNOFANGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool MAGFFNGGIHE;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BDCPBENFKDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x82B4610", Offset = "0x82B3010", VA = "0x1882B4610", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool NDOHKOLGIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x82B45C0", Offset = "0x82B2FC0", VA = "0x1882B45C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool COILHOHLCCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9F9560", Offset = "0x9F7F60", VA = "0x1809F9560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x82B47D0", Offset = "0x82B31D0", VA = "0x1882B47D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action MAEGLJCGFNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x82B4520", Offset = "0x82B2F20", VA = "0x1882B4520")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x82B4730", Offset = "0x82B3130", VA = "0x1882B4730")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82B3F60", Offset = "0x82B2960", VA = "0x1882B3F60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82B4180", Offset = "0x82B2B80", VA = "0x1882B4180")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82B4130", Offset = "0x82B2B30", VA = "0x1882B4130")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82B4120", Offset = "0x82B2B20", VA = "0x1882B4120")]
		public void Hide(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82B4480", Offset = "0x82B2E80", VA = "0x1882B4480")]
		public void Show(object GNAAILLDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82B4390", Offset = "0x82B2D90", VA = "0x1882B4390")]
		public void Set(object GNAAILLDOKI, bool JKGAEGAPHHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82B3FF0", Offset = "0x82B29F0", VA = "0x1882B3FF0")]
		public void Clear(bool BNFNEODNHMJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82B4210", Offset = "0x82B2C10", VA = "0x1882B4210")]
		private void PCGIPHNHPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82B40A0", Offset = "0x82B2AA0", VA = "0x1882B40A0")]
		[IteratorStateMachine(typeof(LJFALIOFKNJ))]
		private IEnumerator<HKMFJDMPEMN> GCDNADCMOIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82B4060", Offset = "0x82B2A60", VA = "0x1882B4060", Slot = "5")]
		public virtual void DoHideOrShow(bool ICLMMPONPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82B4490", Offset = "0x82B2E90", VA = "0x1882B4490")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PHLNDCENHFN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum PPAEOLNHMHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static BEPPBPCKNFL KBFMFAPFKDL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static BEPPBPCKNFL NKBAMHFKKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82B5E40", Offset = "0x82B4840", VA = "0x1882B5E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static PPAEOLNHMHD ENCLOHILMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82B5F40", Offset = "0x82B4940", VA = "0x1882B5F40")]
		get
		{
			return default(PPAEOLNHMHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82B5C10", Offset = "0x82B4610", VA = "0x1882B5C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<PPAEOLNHMHD> FIOIHOAIMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82B6070", Offset = "0x82B4A70", VA = "0x1882B6070")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82B5D70", Offset = "0x82B4770", VA = "0x1882B5D70")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NJPKHPPOKME : OIKOJIFHLNG, CGFPCMEAOFN, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, KDPIAAINEJM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	COOFKGJALFM FMKEMKIDINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FDJPMDOFNPO Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject DEMHLIAEAHH);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FDJPMDOFNPO Spawn<T>(int MALKLBBAIMC, IReadOnlyList<T> DFPGGEDGGGN, GameObject DEMHLIAEAHH);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FDJPMDOFNPO Spawn<T>(int MALKLBBAIMC, IReadOnlyList<T> DFPGGEDGGGN, GameObject EIHIOKMEMNP, Func<int, GameObject> CKHPEFDGGGC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int DOAKEFBOPIA, float BPHHGLKKNBA);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum LABNEHHJOAG : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			LeftToRight = 0,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			RightToLeft = 1,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			TopToBottom = 2,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			BottomToTop = 3,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			CustomDirection = 4,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			RadialOut = 10,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			RadialIn = 11,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			VignetteOut = 20,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			VignetteIn = 21,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			Disabled = byte.MaxValue
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int NGHEBFADPBB;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<LABNEHHJOAG, string> ANDKPGDPBAI;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int ENGMJHAFNAE = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int OMIPJOMGHMK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int DPAFAGMDEBK;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int BMKPLBDMJOL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int EPJOGMNPNGG;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int FBJDFPOCMFF;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int PLLJHCFEDOP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int EDPNCEIFANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool DEOENLKFJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool CKMDBLFPAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] OHDPGKELPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private LABNEHHJOAG type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly LABNEHHJOAG[] GPBLNEEAABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[FGDKCCGIKGN("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly LABNEHHJOAG[] HPLKLEGMJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[FGDKCCGIKGN("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[FGDKCCGIKGN("type", LABNEHHJOAG.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[FGDKCCGIKGN("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic ONHLLBELPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool AFBHCEDKCAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient HHOONCGIKED
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9AD9F0", VA = "0x1809AEFF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x82B7C20", Offset = "0x82B6620", VA = "0x1882B7C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LABNEHHJOAG ABBLELNBDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xC02F10", Offset = "0xC01910", VA = "0x180C02F10")]
			get
			{
				return default(LABNEHHJOAG);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x82B7DA0", Offset = "0x82B67A0", VA = "0x1882B7DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool PEDNCKDNHON
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82B7690", Offset = "0x82B6090", VA = "0x1882B7690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 AAENOPNGINB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82B7B90", Offset = "0x82B6590", VA = "0x1882B7B90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82B7BD0", Offset = "0x82B65D0", VA = "0x1882B7BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool BOGNOCONBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x82B6A20", Offset = "0x82B5420", VA = "0x1882B6A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 MOGENFAMANI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x82B7BB0", Offset = "0x82B65B0", VA = "0x1882B7BB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x82B7D50", Offset = "0x82B6750", VA = "0x1882B7D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float BEIHINHNOFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xBFFBA0", Offset = "0xBFE5A0", VA = "0x180BFFBA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x209E070", Offset = "0x209CA70", VA = "0x18209E070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 GLJJDCDJHBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x82B7640", Offset = "0x82B6040", VA = "0x1882B7640")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 JFIAJGJBHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x82B6600", Offset = "0x82B5000", VA = "0x1882B6600")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float LDIHJGNOIMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9C87C0", Offset = "0x9C71C0", VA = "0x1809C87C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x82B7DB0", Offset = "0x82B67B0", VA = "0x1882B7DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82B6A90", Offset = "0x82B5490", VA = "0x1882B6A90", Slot = "12")]
		protected override void JHFCDGHOMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x82B6670", Offset = "0x82B5070", VA = "0x1882B6670")]
		private void BPEGLKDONBJ(Color[] GMCBGEMKJBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x82B6C30", Offset = "0x82B5630", VA = "0x1882B6C30", Slot = "13")]
		protected override void KBDELFINIAM(Material GMIALIBEKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82B6800", Offset = "0x82B5200", VA = "0x1882B6800", Slot = "14")]
		protected override void CPAJLKBDHEL(Material GMIALIBEKEC, bool PLGFLNLCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82B7AE0", Offset = "0x82B64E0", VA = "0x1882B7AE0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly IMMNOIGHCIO ENEPDCACFDB;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite CAAHGNJFPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material DJHMJGONAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material OBFGNDIHBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool LKFKNOHBKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool OOLOIJGLFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool HEINIOCFHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool DFOMPENGCGA;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic ONHLLBELPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader GFBDBPJJELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool AFBHCEDKCAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool DDKFBEONAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform GDEAKNDHENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x82B9CF0", Offset = "0x82B86F0", VA = "0x1882B9CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect DPJDILKNNAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x82B9500", Offset = "0x82B7F00", VA = "0x1882B9500")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite ELDCMLJHEBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x82B90C0", Offset = "0x82B7AC0", VA = "0x1882B90C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82B8ED0", Offset = "0x82B78D0", VA = "0x1882B8ED0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x82B9D50", Offset = "0x82B8750", VA = "0x1882B9D50", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x82BA050", Offset = "0x82B8A50", VA = "0x1882BA050", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82B9F00", Offset = "0x82B8900", VA = "0x1882B9F00", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x82B9B30", Offset = "0x82B8530", VA = "0x1882B9B30")]
		private void JPANHLKFCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82B99C0", Offset = "0x82B83C0", VA = "0x1882B99C0")]
		private void JJLHDBCLHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82B9CC0", Offset = "0x82B86C0", VA = "0x1882B9CC0")]
		private void JPHJHKFDNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82B9620", Offset = "0x82B8020", VA = "0x1882B9620")]
		private void EGMBGOEMADK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82B92A0", Offset = "0x82B7CA0", VA = "0x1882B92A0")]
		protected void BGBDJOAOJDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x82B8D90", Offset = "0x82B7790", VA = "0x1882B8D90")]
		private void AJHKGAOHAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "12")]
		protected virtual void JHFCDGHOMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "13")]
		protected virtual void KBDELFINIAM(Material GMIALIBEKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "14")]
		protected virtual void CPAJLKBDHEL(Material GMIALIBEKEC, bool PLGFLNLCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82B9670", Offset = "0x82B8070", VA = "0x1882B9670")]
		private void HJJAJNPMLNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		protected UIMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AddComponentMenu("UI/Effects/Rings", 15)]
	[ExecuteAlways]
	public class UIRings : UIUberMaterialOverride
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct RingLayer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[SerializeField]
			[Range(0f, 2f)]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly int CIHABBBMOHH;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int GNEFFJAPKLC;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int LCOPOPIBJAE;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int GNFMECLPNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Color[] OHDPGKELPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] OLCPECFPBHG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic ONHLLBELPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool DDKFBEONAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> HICCFAGFPMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 AAENOPNGINB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x82BAB40", Offset = "0x82B9540", VA = "0x1882BAB40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x82BAB60", Offset = "0x82B9560", VA = "0x1882BAB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82BA740", Offset = "0x82B9140", VA = "0x1882BA740")]
		public void SetRingLayers(IReadOnlyList<RingLayer> FAKINNNNANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82BA500", Offset = "0x82B8F00", VA = "0x1882BA500")]
		public bool SetRingLayerColor(int HKKKDLOOHLD, Color IFFOAMBAJEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x82BA650", Offset = "0x82B9050", VA = "0x1882BA650")]
		public bool SetRingLayerSize(int HKKKDLOOHLD, float PICLDLMFMMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x82BA250", Offset = "0x82B8C50", VA = "0x1882BA250", Slot = "12")]
		protected override void JHFCDGHOMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82BA390", Offset = "0x82B8D90", VA = "0x1882BA390", Slot = "13")]
		protected override void KBDELFINIAM(Material GMIALIBEKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82BA200", Offset = "0x82B8C00", VA = "0x1882BA200", Slot = "14")]
		protected override void CPAJLKBDHEL(Material GMIALIBEKEC, bool PLGFLNLCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x82BA890", Offset = "0x82B9290", VA = "0x1882BA890")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[AddComponentMenu("UI/Effects/Tiler", 15)]
	[ExecuteAlways]
	public class UITiler : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum HPBCBNLDPJI
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int DJCGEDPPFFC;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int MLJFHIDJLOB;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int CJFPMCBAAAF;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int NPDEOLKKIFB;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int PMBMDOOGMPI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int EPJNMLICACE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int GFIOPBAHMOI;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int MOPKMEEOJLI;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int HFMMCHPFDDL;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int FNCHEKENPED;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int NODILLEBCKG;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int BGOIFAINCIH;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int DOGFADFJPJN;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int NFLHIDIKAMP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int JIIMEKMAFHL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int ACDNCECIGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[JNJDEHPMCEK(PLKNMOLBJIE.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("The distance between each tile.")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("The offset applied to each alternating row or column.")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private HPBCBNLDPJI animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[FGDKCCGIKGN("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[FGDKCCGIKGN("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic ONHLLBELPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool DDKFBEONAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite AOEFHMKEEOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x82BB960", Offset = "0x82BA360", VA = "0x1882BB960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x82BBB80", Offset = "0x82BA580", VA = "0x1882BBB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color HIDCBJIODIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xE51830", Offset = "0xE50230", VA = "0x180E51830")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC10", Offset = "0x82BA610", VA = "0x1882BBC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color OMILLNBFIKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x101F310", Offset = "0x101DD10", VA = "0x18101F310")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x82BBA50", Offset = "0x82BA450", VA = "0x1882BBA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float AKBBCKKFLLG
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xBFF930", Offset = "0xBFE330", VA = "0x180BFF930")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x82BBB10", Offset = "0x82BA510", VA = "0x1882BBB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 NAJFHKHHADL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x82BB940", Offset = "0x82BA340", VA = "0x1882BB940")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x82BBB30", Offset = "0x82BA530", VA = "0x1882BBB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float KHMMHBDHIKP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9C8420", Offset = "0x9C6E20", VA = "0x1809C8420")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x82BBAD0", Offset = "0x82BA4D0", VA = "0x1882BBAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 OMBGOHLKNHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1426720", Offset = "0x1425120", VA = "0x181426720")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC90", Offset = "0x82BA690", VA = "0x1882BBC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float HDICNCEPAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xFD62B0", Offset = "0xFD4CB0", VA = "0x180FD62B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x82BBA20", Offset = "0x82BA420", VA = "0x1882BBA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 GLNFLHBBONF
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x82BAEB0", Offset = "0x82B98B0", VA = "0x1882BAEB0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HPBCBNLDPJI LPFNIEDCMNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xDC22B0", Offset = "0xDC0CB0", VA = "0x180DC22B0")]
			get
			{
				return default(HPBCBNLDPJI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x82BBA40", Offset = "0x82BA440", VA = "0x1882BBA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float NLFCGBHJDPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x15AEFE0", Offset = "0x15AD9E0", VA = "0x1815AEFE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x82BBAF0", Offset = "0x82BA4F0", VA = "0x1882BBAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float CPNECIBHGCK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x152A5D0", Offset = "0x1528FD0", VA = "0x18152A5D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x82BBA00", Offset = "0x82BA400", VA = "0x1882BBA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x82BAF40", Offset = "0x82B9940", VA = "0x1882BAF40", Slot = "13")]
		protected override void KBDELFINIAM(Material GMIALIBEKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x82BAC00", Offset = "0x82B9600", VA = "0x1882BAC00")]
		private void GNACIGLDEBN(Sprite DIODMKBHNEF, [Out] Vector2 CLFGGHOGMMO, [Out] Vector2 HBKFOOPGKLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x82BABB0", Offset = "0x82B95B0", VA = "0x1882BABB0", Slot = "14")]
		protected override void CPAJLKBDHEL(Material GMIALIBEKEC, bool PLGFLNLCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x82BB8B0", Offset = "0x82BA2B0", VA = "0x1882BB8B0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader POPLNHMGFHC;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader GFBDBPJJELG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x82BBD30", Offset = "0x82BA730", VA = "0x1882BBD30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x82BBCE0", Offset = "0x82BA6E0", VA = "0x1882BBCE0")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class RectTransformHideableAdapter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private SerializableRectTransform hiddenRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private SerializableRectTransform LPOLOIFAEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool LLBPPNENHFL;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x82B6140", Offset = "0x82B4B40", VA = "0x1882B6140")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x82B6350", Offset = "0x82B4D50", VA = "0x1882B6350")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x82B62D0", Offset = "0x82B4CD0", VA = "0x1882B62D0")]
		private void ELABKKMKBGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x82B6460", Offset = "0x82B4E60", VA = "0x1882B6460")]
		private void PCGIPHNHPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IMMNOIGHCIO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct BBALBMPFGBC : IEquatable<BBALBMPFGBC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component OJFCDDMGKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action MLEKGGMDACM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int OBGJPAKOHEE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component GPNDPHJOAKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x82B36E0", Offset = "0x82B20E0", VA = "0x1882B36E0")]
		public BBALBMPFGBC(Component OJFCDDMGKNP, Action MLEKGGMDACM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x82B35C0", Offset = "0x82B1FC0", VA = "0x1882B35C0")]
		public void BALGFNNJCDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x82B36D0", Offset = "0x82B20D0", VA = "0x1882B36D0", Slot = "4")]
		public bool Equals(BBALBMPFGBC OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x82B3640", Offset = "0x82B2040", VA = "0x1882B3640", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1A0", Offset = "0x9AABA0", VA = "0x1809AC1A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PENPODOGHPB : IEnumerator<HKMFJDMPEMN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private HKMFJDMPEMN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IMMNOIGHCIO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private HKMFJDMPEMN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
		[DebuggerHidden]
		public PENPODOGHPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x82B5800", Offset = "0x82B4200", VA = "0x1882B5800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x82B5BC0", Offset = "0x82B45C0", VA = "0x1882B5BC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly PDAPCALENKF LCBFLFDPPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int FDEJHJFDHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int HCALICHPBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> NGPKNOMDFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, BBALBMPFGBC> AEDIMACAOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<BBALBMPFGBC> NELLGEEPFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<BBALBMPFGBC> KDMPJCPHNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NBLJJLKPDOF OFJJOJONJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private IKHJMFHINFE ICGOMBHGOJC;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private IKHJMFHINFE NIIPMHPMMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x82B5090", Offset = "0x82B3A90", VA = "0x1882B5090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x82B5120", Offset = "0x82B3B20", VA = "0x1882B5120")]
	public IMMNOIGHCIO(PDAPCALENKF LCBFLFDPPON, int FDEJHJFDHEC = -1, int HCALICHPBOA = -1, [Optional] Func<Component, float> NGPKNOMDFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x82B4950", Offset = "0x82B3350", VA = "0x1882B4950")]
	public void EJKCCINOKFD(Component OJFCDDMGKNP, Action AJHDOLGFFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x82B4F00", Offset = "0x82B3900", VA = "0x1882B4F00")]
	public void IONGFIMMNAO(Component OJFCDDMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x82B48F0", Offset = "0x82B32F0", VA = "0x1882B48F0")]
	public bool DCKBAFGIBIO(Component ANAFMCCHAKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x82B4CD0", Offset = "0x82B36D0", VA = "0x1882B4CD0")]
	private void IMDLHJNHIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x82B4C50", Offset = "0x82B3650", VA = "0x1882B4C50")]
	[IteratorStateMachine(typeof(PENPODOGHPB))]
	private IEnumerator<HKMFJDMPEMN> HFPIKABGEII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xD620A0", Offset = "0xD60AA0", VA = "0x180D620A0")]
	[CompilerGenerated]
	private void DFGAJIPBAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x82B4BD0", Offset = "0x82B35D0", VA = "0x1882B4BD0")]
	[CompilerGenerated]
	private float GJLHPFAGDLI(BBALBMPFGBC AJHDOLGFFAB)
	{
		return default(float);
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
