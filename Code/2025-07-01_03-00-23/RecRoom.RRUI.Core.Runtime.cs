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
				[Cpp2IlInjected.Address(RVA = "0x8A0E560", Offset = "0x8A0CB60", VA = "0x188A0E560")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8A0E5C0", Offset = "0x8A0CBC0", VA = "0x188A0E5C0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8A0E520", Offset = "0x8A0CB20", VA = "0x188A0E520")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E190", Offset = "0x8A0C790", VA = "0x188A0E190")]
			public void LJEAPFKHIEN(PointerEventData GABKCKMHKFJ, RectTransform CGNFFJBEOFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E290", Offset = "0x8A0C890", VA = "0x188A0E290")]
			public void NCCJKLOBBOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E0B0", Offset = "0x8A0C6B0", VA = "0x188A0E0B0")]
			public void FKIPLJFGDHM(PointerEventData GABKCKMHKFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E060", Offset = "0x8A0C660", VA = "0x188A0E060")]
			public void DLPIILKHBNB(float ILMNEEANPFM, RectTransform CGNFFJBEOFP, Vector3 GCBLNLANCOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly IAJLDMLJHLB<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly IAJLDMLJHLB<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly IAJLDMLJHLB<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly IAJLDMLJHLB<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly IAJLDMLJHLB<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly LGEBFGGIOJB PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData PEPEECHOAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool CBIMIAIMCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool MFHLOGCFGKD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PPEJECFBDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA50DF0", Offset = "0xA4F3F0", VA = "0x180A50DF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D820", Offset = "0x8A0BE20", VA = "0x188A0D820")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DKKJBLFCCGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA50E60", Offset = "0xA4F460", VA = "0x180A50E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D7F0", Offset = "0x8A0BDF0", VA = "0x188A0D7F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A0D850", Offset = "0x8A0BE50", VA = "0x188A0D850")]
		private bool LCJBEAPCKIN(PointerEventData FLDOIECLDLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A0DD20", Offset = "0x8A0C320", VA = "0x188A0DD20", Slot = "5")]
		public void OnPointerDown(PointerEventData FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A0DDE0", Offset = "0x8A0C3E0", VA = "0x188A0DDE0", Slot = "11")]
		public void OnPointerUp(PointerEventData FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A0DB90", Offset = "0x8A0C190", VA = "0x188A0DB90", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A0D8D0", Offset = "0x8A0BED0", VA = "0x188A0D8D0", Slot = "7")]
		public void OnBeginDrag(PointerEventData FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A0D9E0", Offset = "0x8A0BFE0", VA = "0x188A0D9E0", Slot = "4")]
		public void OnDrag(PointerEventData FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A0DAC0", Offset = "0x8A0C0C0", VA = "0x188A0DAC0", Slot = "8")]
		public void OnEndDrag(PointerEventData FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A0DD80", Offset = "0x8A0C380", VA = "0x188A0DD80", Slot = "9")]
		public void OnPointerEnter(PointerEventData FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A0DDB0", Offset = "0x8A0C3B0", VA = "0x188A0DDB0", Slot = "10")]
		public void OnPointerExit(PointerEventData FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A0D9A0", Offset = "0x8A0BFA0", VA = "0x188A0D9A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8A0DE40", Offset = "0x8A0C440", VA = "0x188A0DE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A08F40", Offset = "0x8A07540", VA = "0x188A08F40")]
		public void SetCanvasSortingOrder(short JOKGMMAMPPN, bool FJDMEHBKIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData LKCKOAHKKHL;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A09200", Offset = "0x8A07800", VA = "0x188A09200", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A090E0", Offset = "0x8A076E0", VA = "0x188A090E0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A09030", Offset = "0x8A07630", VA = "0x188A09030")]
		private void HGCLGNGKPBI(GameObject GMCOENFOHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A094E0", Offset = "0x8A07AE0", VA = "0x188A094E0")]
		public void SetOptionsWithNoDefault(List<string> NIJLHKNCLKB, [Optional] string PLCOIJEMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A093F0", Offset = "0x8A079F0", VA = "0x188A093F0")]
		public void SetOptionsWithNoDefault(List<OptionData> PANLLLBJFBB, [Optional] string PLCOIJEMMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A09320", Offset = "0x8A07920", VA = "0x188A09320", Slot = "43")]
		public override void OnPointerClick(PointerEventData FLDOIECLDLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "46")]
		protected override GameObject CreateBlocker(Canvas NNLNLHCEEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A09710", Offset = "0x8A07D10", VA = "0x188A09710")]
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
		private sealed class IBAMAPBIOIM : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private HPILNDONOCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
			[DebuggerHidden]
			public IBAMAPBIOIM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8A0AC30", Offset = "0x8A09230", VA = "0x188A0AC30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8A0B140", Offset = "0x8A09740", VA = "0x188A0B140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[PPBMPHDDNEA(CNNBEEFOMHL.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly BCMOPEBHIIA<object> MLBNMEDNLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool BOANPALIDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? AMLLIIFKKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? JIEGILCJCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? FGOOMHLLMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool DAKHDEFHBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool HJFBHCOOAFI;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool OFJEIDCAGCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8A0A950", Offset = "0x8A08F50", VA = "0x188A0A950", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool PJOPLLLJECL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8A0A900", Offset = "0x8A08F00", VA = "0x188A0A900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MHLKBHDAMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA920F0", Offset = "0xA906F0", VA = "0x180A920F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8A0AB10", Offset = "0x8A09110", VA = "0x188A0AB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AGKLKJJLEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8A0A860", Offset = "0x8A08E60", VA = "0x188A0A860")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8A0AA70", Offset = "0x8A09070", VA = "0x188A0AA70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A2A0", Offset = "0x8A088A0", VA = "0x188A0A2A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A640", Offset = "0x8A08C40", VA = "0x188A0A640")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A5F0", Offset = "0x8A08BF0", VA = "0x188A0A5F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A560", Offset = "0x8A08B60", VA = "0x188A0A560")]
		public void Hide(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A7C0", Offset = "0x8A08DC0", VA = "0x188A0A7C0")]
		public void Show(object DKFMAIJGPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A6D0", Offset = "0x8A08CD0", VA = "0x188A0A6D0")]
		public void Set(object DKFMAIJGPFL, bool GBCONCGGALH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A4B0", Offset = "0x8A08AB0", VA = "0x188A0A4B0")]
		public void Clear(bool PMBEMNPMMFJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A330", Offset = "0x8A08930", VA = "0x188A0A330")]
		private void BNODIPNIJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A570", Offset = "0x8A08B70", VA = "0x188A0A570")]
		[IteratorStateMachine(typeof(IBAMAPBIOIM))]
		private IEnumerator<HPILNDONOCO> KMNCFDFAKIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A520", Offset = "0x8A08B20", VA = "0x188A0A520", Slot = "5")]
		public virtual void DoHideOrShow(bool JMBBLFCHPIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8A0A7D0", Offset = "0x8A08DD0", VA = "0x188A0A7D0")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PNOBKLLDPMC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum JAFFAINDAIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static EBGNLCHEEDD MFGDCOGELDI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static EBGNLCHEEDD MINDEHDPGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A0B9F0", Offset = "0x8A09FF0", VA = "0x188A0B9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static JAFFAINDAIO EPAJLCKAOBE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A0B7E0", Offset = "0x8A09DE0", VA = "0x188A0B7E0")]
		get
		{
			return default(JAFFAINDAIO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A0B680", Offset = "0x8A09C80", VA = "0x188A0B680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<JAFFAINDAIO> ACAKBILICNG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A0B5A0", Offset = "0x8A09BA0", VA = "0x188A0B5A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8A0B910", Offset = "0x8A09F10", VA = "0x188A0B910")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HDOBJIKMDNG : LDMJIKDMIDG, PIOCGINMHPE, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, NDBEINGHDEC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LGEBFGGIOJB BACCFBKABNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BKFKILCGELM Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject KFAEMGBGGCC);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BKFKILCGELM Spawn<T>(int MGCNBPMJJPM, IReadOnlyList<T> ACJFHCNBBBO, GameObject KFAEMGBGGCC);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BKFKILCGELM Spawn<T>(int MGCNBPMJJPM, IReadOnlyList<T> ACJFHCNBBBO, GameObject IJINPKJJJMG, Func<int, GameObject> FHDHFIOFGCO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int KHMHPNKMLMD, float LFEJKOPHFDC);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum JEHLECLADFO : byte
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
		private static readonly int ADPKNGMBOEF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<JEHLECLADFO, string> FEADPBONLIH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int PEOPOLDHMPE = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int KGMGMHFEOCO;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int LJNFLGKJMGG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int DKBANNIIICO;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int MPHHMABENIK;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int PMPFBNJCBHL;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int HDCBAMJKAAA;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int NIKHBKNPBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool CBJADELGHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool EEBGCOOMKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] NPJKHNBIJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private JEHLECLADFO type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly JEHLECLADFO[] MNIFIFAICOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[CEFLHEHDIBA("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly JEHLECLADFO[] KMJIHBMMEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[CEFLHEHDIBA("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[CEFLHEHDIBA("type", JEHLECLADFO.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[CEFLHEHDIBA("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic AMPDMILMDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool PEMILJHLNGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient FEHBMGMDBNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D640", Offset = "0x8A0BC40", VA = "0x188A0D640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public JEHLECLADFO AKEHBOGGIOP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD19390", Offset = "0xD17990", VA = "0x180D19390")]
			get
			{
				return default(JEHLECLADFO);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D7C0", Offset = "0x8A0BDC0", VA = "0x188A0D7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool GHLLDEHLIMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8A0CBB0", Offset = "0x8A0B1B0", VA = "0x188A0CBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 BIONDJAKKDK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D5B0", Offset = "0x8A0BBB0", VA = "0x188A0D5B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D5F0", Offset = "0x8A0BBF0", VA = "0x188A0D5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool AHMCJNFBIGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D090", Offset = "0x8A0B690", VA = "0x188A0D090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 KFMIJCGMFBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D5D0", Offset = "0x8A0BBD0", VA = "0x188A0D5D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D770", Offset = "0x8A0BD70", VA = "0x188A0D770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NCNCDCMBJKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD384E0", Offset = "0xD36AE0", VA = "0x180D384E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x23A3370", Offset = "0x23A1970", VA = "0x1823A3370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 NGKEMBOJKDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8A0CFD0", Offset = "0x8A0B5D0", VA = "0x188A0CFD0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 FNILOAPEEHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D020", Offset = "0x8A0B620", VA = "0x188A0D020")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float GOBDKMMAAKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA607C0", Offset = "0xA5EDC0", VA = "0x180A607C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8A0D7D0", Offset = "0x8A0BDD0", VA = "0x188A0D7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8A0BFC0", Offset = "0x8A0A5C0", VA = "0x188A0BFC0", Slot = "12")]
		protected override void AKKOOJFELLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8A0CC20", Offset = "0x8A0B220", VA = "0x188A0CC20")]
		private void BKIDLGPAPPP(Color[] FMNNDEBGEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8A0C160", Offset = "0x8A0A760", VA = "0x188A0C160", Slot = "13")]
		protected override void BFKPCAPNJFO(Material KKIOJDIOKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8A0CDB0", Offset = "0x8A0B3B0", VA = "0x188A0CDB0", Slot = "14")]
		protected override void IOPKFOEIICM(Material KKIOJDIOKCM, bool IOAJJAMFEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A0D500", Offset = "0x8A0BB00", VA = "0x188A0D500")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly HNCBDEHLALH PEFJMLFLHLG;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite GMPJHGANAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material CMDHJHFBFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material FILGAIHBEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool DIFMNPGFCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool BOANPALIDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool IGGPFNIGKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool JKFHAFBCOKC;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic AMPDMILMDOD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader HACLLENPEKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool PEMILJHLNGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool JKGCDJCJNDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform CGNFFJBEOFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8A0E9A0", Offset = "0x8A0CFA0", VA = "0x188A0E9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect KCFBBCNKIGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8A0F130", Offset = "0x8A0D730", VA = "0x188A0F130")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite GGNEIBJIELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8A0EEF0", Offset = "0x8A0D4F0", VA = "0x188A0EEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8A0E7B0", Offset = "0x8A0CDB0", VA = "0x188A0E7B0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F250", Offset = "0x8A0D850", VA = "0x188A0F250", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F550", Offset = "0x8A0DB50", VA = "0x188A0F550", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F400", Offset = "0x8A0DA00", VA = "0x188A0F400", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F7D0", Offset = "0x8A0DDD0", VA = "0x188A0F7D0")]
		private void PNKLCOFKMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8A0ED80", Offset = "0x8A0D380", VA = "0x188A0ED80")]
		private void IGEBJOHNFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8A0EA00", Offset = "0x8A0D000", VA = "0x188A0EA00")]
		private void DIDNOGFBEJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F0E0", Offset = "0x8A0D6E0", VA = "0x188A0F0E0")]
		private void KFJBCJFGIOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F560", Offset = "0x8A0DB60", VA = "0x188A0F560")]
		protected void PLAMGBNPFHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F960", Offset = "0x8A0DF60", VA = "0x188A0F960")]
		private void POBNGDCJLII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "12")]
		protected virtual void AKKOOJFELLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "13")]
		protected virtual void BFKPCAPNJFO(Material KKIOJDIOKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "14")]
		protected virtual void IOPKFOEIICM(Material KKIOJDIOKCM, bool IOAJJAMFEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A0EA30", Offset = "0x8A0D030", VA = "0x188A0EA30")]
		private void FPENIPAKAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
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
		private static readonly int NOBBAMKBEAC;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int GNLFKKIHPBM;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int BFCJDBNPJFI;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int JPKBBACHFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
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
		private Color[] NPJKHNBIJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] HKDEBCMCMOO;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic AMPDMILMDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool JKGCDJCJNDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> ICFADIOCOIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 BIONDJAKKDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x308B2F0", Offset = "0x30898F0", VA = "0x18308B2F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8A10560", Offset = "0x8A0EB60", VA = "0x188A10560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8A101A0", Offset = "0x8A0E7A0", VA = "0x188A101A0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> KJKJIHDNGCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8A0FF60", Offset = "0x8A0E560", VA = "0x188A0FF60")]
		public bool SetRingLayerColor(int GMLCBPDDIOI, Color HFIMNHFKOFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A100B0", Offset = "0x8A0E6B0", VA = "0x188A100B0")]
		public bool SetRingLayerSize(int GMLCBPDDIOI, float GPNBMIDFKMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A0FC50", Offset = "0x8A0E250", VA = "0x188A0FC50", Slot = "12")]
		protected override void AKKOOJFELLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8A0FD90", Offset = "0x8A0E390", VA = "0x188A0FD90", Slot = "13")]
		protected override void BFKPCAPNJFO(Material KKIOJDIOKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8A0FF10", Offset = "0x8A0E510", VA = "0x188A0FF10", Slot = "14")]
		protected override void IOPKFOEIICM(Material KKIOJDIOKCM, bool IOAJJAMFEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8A102F0", Offset = "0x8A0E8F0", VA = "0x188A102F0")]
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
		public enum HFIDNALDFAC
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int PMFEJFDCJDD;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int LKKFLCGEGMF;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int HPGGCAKMGEK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int LJGCDGHEACC;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int CEPAICJJNOJ;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int KJBIGLPAOHF;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int NJENMAADIDO;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int ADEDENEAEIC;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int EOICGLAJIJM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int CBDNLIIKGIH;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int HNJJEGBGINF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int FHCHNDPIKEE;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int BGDEKFHLPCD;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int LONMPBFENNG;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int JAHGCFIHKKO;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int LPFGGGMPMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
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
		private HFIDNALDFAC animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[CEFLHEHDIBA("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[CEFLHEHDIBA("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic AMPDMILMDOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool JKGCDJCJNDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite JGIJPIGFIMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8A113D0", Offset = "0x8A0F9D0", VA = "0x188A113D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8A115F0", Offset = "0x8A0FBF0", VA = "0x188A115F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color MMOGBBAFBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xFAE7A0", Offset = "0xFACDA0", VA = "0x180FAE7A0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8A11680", Offset = "0x8A0FC80", VA = "0x188A11680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color LIGLHOOLFDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x11B8200", Offset = "0x11B6800", VA = "0x1811B8200")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8A114C0", Offset = "0x8A0FAC0", VA = "0x188A114C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float KPOHOGLGBPD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD38510", Offset = "0xD36B10", VA = "0x180D38510")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8A11580", Offset = "0x8A0FB80", VA = "0x188A11580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 KMBMBENLNGB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8A113B0", Offset = "0x8A0F9B0", VA = "0x188A113B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8A115A0", Offset = "0x8A0FBA0", VA = "0x188A115A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float FKCGNHACNBO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA60400", Offset = "0xA5EA00", VA = "0x180A60400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8A11540", Offset = "0x8A0FB40", VA = "0x188A11540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 BAJDNAEDFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x169F860", Offset = "0x169DE60", VA = "0x18169F860")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8A11700", Offset = "0x8A0FD00", VA = "0x188A11700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float IMEDNGBJPLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x1184DB0", Offset = "0x11833B0", VA = "0x181184DB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8A11490", Offset = "0x8A0FA90", VA = "0x188A11490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 GJJKIANHJPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8A10D00", Offset = "0x8A0F300", VA = "0x188A10D00")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HFIDNALDFAC MFFIJBAFICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xF152B0", Offset = "0xF138B0", VA = "0x180F152B0")]
			get
			{
				return default(HFIDNALDFAC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8A114B0", Offset = "0x8A0FAB0", VA = "0x188A114B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float JMPCDDONBAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1831C90", Offset = "0x1830290", VA = "0x181831C90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8A11560", Offset = "0x8A0FB60", VA = "0x188A11560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float CFKCAOBBINE
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x17D6660", Offset = "0x17D4C60", VA = "0x1817D6660")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8A11470", Offset = "0x8A0FA70", VA = "0x188A11470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8A105B0", Offset = "0x8A0EBB0", VA = "0x188A105B0", Slot = "13")]
		protected override void BFKPCAPNJFO(Material KKIOJDIOKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A10D90", Offset = "0x8A0F390", VA = "0x188A10D90")]
		private void NNDKILEDPHL(Sprite HOHLFMGDEJG, [Out] Vector2 BINBJPECJLJ, [Out] Vector2 DGGNMCNKAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A10CB0", Offset = "0x8A0F2B0", VA = "0x188A10CB0", Slot = "14")]
		protected override void IOPKFOEIICM(Material KKIOJDIOKCM, bool IOAJJAMFEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8A11320", Offset = "0x8A0F920", VA = "0x188A11320")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader BKLLPMPLKJF;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader HACLLENPEKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8A117A0", Offset = "0x8A0FDA0", VA = "0x188A117A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A11750", Offset = "0x8A0FD50", VA = "0x188A11750")]
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
		private SerializableRectTransform GMEACEPLKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool AHGKBOJKOOP;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A0BAF0", Offset = "0x8A0A0F0", VA = "0x188A0BAF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A0BD50", Offset = "0x8A0A350", VA = "0x188A0BD50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A0BE60", Offset = "0x8A0A460", VA = "0x188A0BE60")]
		private void PACKNBGELHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A0BC80", Offset = "0x8A0A280", VA = "0x188A0BC80")]
		private void BNODIPNIJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HNCBDEHLALH
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct GHONMLEPKAL : IEquatable<GHONMLEPKAL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component HILCMKALFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action OKJCKCOIPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int JDLBIGJCDPL;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component FCCIBPJCEIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8A09880", Offset = "0x8A07E80", VA = "0x188A09880")]
		public GHONMLEPKAL(Component HILCMKALFIH, Action OKJCKCOIPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8A09800", Offset = "0x8A07E00", VA = "0x188A09800")]
		public void NJPLCABILLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A097F0", Offset = "0x8A07DF0", VA = "0x188A097F0", Slot = "4")]
		public bool Equals(GHONMLEPKAL HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8A09760", Offset = "0x8A07D60", VA = "0x188A09760", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LHIEMFDPJBI : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private HPILNDONOCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HNCBDEHLALH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
		[DebuggerHidden]
		public LHIEMFDPJBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8A0B190", Offset = "0x8A09790", VA = "0x188A0B190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8A0B550", Offset = "0x8A09B50", VA = "0x188A0B550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly DMJPLAHANAN KOJHBKBCLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int JALEPCOOEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int EEBICIEJFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> PMLLJPOBAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, GHONMLEPKAL> INBDJHDFOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<GHONMLEPKAL> EBNDCLJFICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<GHONMLEPKAL> PPPJNLBPILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private LLKKGNCPLNM CHIAJMBHHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private KHBNHBAPMGF DELIMKABMEA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private KHBNHBAPMGF BEJPJLCICGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A09BF0", Offset = "0x8A081F0", VA = "0x188A09BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8A0A120", Offset = "0x8A08720", VA = "0x188A0A120")]
	public HNCBDEHLALH(DMJPLAHANAN KOJHBKBCLJD, int JALEPCOOEBE = -1, int EEBICIEJFEC = -1, [Optional] Func<Component, float> PMLLJPOBAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8A09970", Offset = "0x8A07F70", VA = "0x188A09970")]
	public void CFOKGMMCION(Component HILCMKALFIH, Action GFCEGHONGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8A09F90", Offset = "0x8A08590", VA = "0x188A09F90")]
	public void PAOKJHCANDD(Component HILCMKALFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8A09F30", Offset = "0x8A08530", VA = "0x188A09F30")]
	public bool MDJCGMJAFDK(Component DNCHHBPCLHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8A09C80", Offset = "0x8A08280", VA = "0x188A09C80")]
	private void DOGPOJBFHPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8A09EB0", Offset = "0x8A084B0", VA = "0x188A09EB0")]
	[IteratorStateMachine(typeof(LHIEMFDPJBI))]
	private IEnumerator<HPILNDONOCO> HJCKBEMIGAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xE9A230", Offset = "0xE98830", VA = "0x180E9A230")]
	[CompilerGenerated]
	private void PMIBFNFHPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8A098F0", Offset = "0x8A07EF0", VA = "0x188A098F0")]
	[CompilerGenerated]
	private float CCJNNIHOHJB(GHONMLEPKAL GFCEGHONGDJ)
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
