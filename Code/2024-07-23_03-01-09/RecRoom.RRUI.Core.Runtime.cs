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
				[Cpp2IlInjected.Address(RVA = "0x717F120", Offset = "0x717E320", VA = "0x18717F120")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x717F180", Offset = "0x717E380", VA = "0x18717F180")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x717F0D0", Offset = "0x717E2D0", VA = "0x18717F0D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x717EFD0", Offset = "0x717E1D0", VA = "0x18717EFD0")]
			public void KKNHGEEMDOK(PointerEventData FMHPKOMEHLC, RectTransform KEGKGMOPPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x717EC10", Offset = "0x717DE10", VA = "0x18717EC10")]
			public void CFMIELHBNKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x717EEF0", Offset = "0x717E0F0", VA = "0x18717EEF0")]
			public void JPCLBOJEBGA(PointerEventData FMHPKOMEHLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x717EEA0", Offset = "0x717E0A0", VA = "0x18717EEA0")]
			public void FBLCLHHMNEH(float JHAOHGBAJEO, RectTransform KEGKGMOPPED, Vector3 NJGBBMKGAPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly ODIOBOMGOFD<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ODIOBOMGOFD<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly ODIOBOMGOFD<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly ODIOBOMGOFD<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly ODIOBOMGOFD<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly EHODCIMNDCH PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData OBINCOHCKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool JLKMGEKBCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool OGJHILDKIIE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CBKOPJPPJAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x856900", Offset = "0x855B00", VA = "0x180856900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x717E3A0", Offset = "0x717D5A0", VA = "0x18717E3A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PNEKPNJDBHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x856930", Offset = "0x855B30", VA = "0x180856930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x717E450", Offset = "0x717D650", VA = "0x18717E450")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x717E3D0", Offset = "0x717D5D0", VA = "0x18717E3D0")]
		private bool ECIEIJFDGMH(PointerEventData BGEDEFLEFII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x717E8D0", Offset = "0x717DAD0", VA = "0x18717E8D0", Slot = "5")]
		public void OnPointerDown(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x717E990", Offset = "0x717DB90", VA = "0x18717E990", Slot = "11")]
		public void OnPointerUp(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x717E740", Offset = "0x717D940", VA = "0x18717E740", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x717E480", Offset = "0x717D680", VA = "0x18717E480", Slot = "7")]
		public void OnBeginDrag(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x717E590", Offset = "0x717D790", VA = "0x18717E590", Slot = "4")]
		public void OnDrag(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x717E670", Offset = "0x717D870", VA = "0x18717E670", Slot = "8")]
		public void OnEndDrag(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x717E930", Offset = "0x717DB30", VA = "0x18717E930", Slot = "9")]
		public void OnPointerEnter(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x717E960", Offset = "0x717DB60", VA = "0x18717E960", Slot = "10")]
		public void OnPointerExit(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x717E550", Offset = "0x717D750", VA = "0x18717E550")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x717E9F0", Offset = "0x717DBF0", VA = "0x18717E9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7179C50", Offset = "0x7178E50", VA = "0x187179C50")]
		public void SetCanvasSortingOrder(short EHNNGENIEKG, bool PONKNJLLNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData LEAOCACPDFM;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x717A860", Offset = "0x7179A60", VA = "0x18717A860", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x717A760", Offset = "0x7179960", VA = "0x18717A760", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x717A6B0", Offset = "0x71798B0", VA = "0x18717A6B0")]
		private void CPCGLONDDGO(GameObject PEGEOIPEPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x717AB20", Offset = "0x7179D20", VA = "0x18717AB20")]
		public void SetOptionsWithNoDefault(List<string> MNHECFLLMJH, [Optional] string CKGJMNDOGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x717AA30", Offset = "0x7179C30", VA = "0x18717AA30")]
		public void SetOptionsWithNoDefault(List<OptionData> FDGBBGJEJMA, [Optional] string CKGJMNDOGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x717A960", Offset = "0x7179B60", VA = "0x18717A960", Slot = "42")]
		public override void OnPointerClick(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas NKBDIEAINED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x717AD50", Offset = "0x7179F50", VA = "0x18717AD50")]
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
		private sealed class IPCPNBMFEDB : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private JMPDKMJKKGA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public IPCPNBMFEDB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x717BC10", Offset = "0x717AE10", VA = "0x18717BC10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x717C120", Offset = "0x717B320", VA = "0x18717C120", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[GEDHJJPMAGH(LEHCEJJDOON.Self, false, false, false)]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly MLLDOOHJPFF<object> CJMPECJKOEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool JMOEEJLIJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? KEPCOPHNMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? GNMHOHEIEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? GNCGOEHCOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool ONKOFECMPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool ENNAHCKJDLB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JPDIELOKGAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x717B4A0", Offset = "0x717A6A0", VA = "0x18717B4A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool OLNFIIPJEHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x717B450", Offset = "0x717A650", VA = "0x18717B450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ELFCPNAGHBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x89CC20", Offset = "0x89BE20", VA = "0x18089CC20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x717B660", Offset = "0x717A860", VA = "0x18717B660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FNELPFJIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x717B3B0", Offset = "0x717A5B0", VA = "0x18717B3B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x717B5C0", Offset = "0x717A7C0", VA = "0x18717B5C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x717ADA0", Offset = "0x7179FA0", VA = "0x18717ADA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x717B190", Offset = "0x717A390", VA = "0x18717B190")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x717B140", Offset = "0x717A340", VA = "0x18717B140")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x717B0B0", Offset = "0x717A2B0", VA = "0x18717B0B0")]
		public void Hide(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x717B310", Offset = "0x717A510", VA = "0x18717B310")]
		public void Show(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x717B220", Offset = "0x717A420", VA = "0x18717B220")]
		public void Set(object EOCJCEFCOOA, bool NFFHHODDOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x717AE30", Offset = "0x717A030", VA = "0x18717AE30")]
		public void Clear(bool FJCKBDKGALA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x717AEE0", Offset = "0x717A0E0", VA = "0x18717AEE0")]
		private void EKBFOMDGHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x717B0C0", Offset = "0x717A2C0", VA = "0x18717B0C0")]
		[IteratorStateMachine(typeof(IPCPNBMFEDB))]
		private IEnumerator<JMPDKMJKKGA> LCAGEKBJAFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x717AEA0", Offset = "0x717A0A0", VA = "0x18717AEA0", Slot = "5")]
		public virtual void DoHideOrShow(bool NKAGDBODKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x717B320", Offset = "0x717A520", VA = "0x18717B320")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CCOGHOHMNNF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x920B50", Offset = "0x91FD50", VA = "0x180920B50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x854CE0", Offset = "0x853EE0", VA = "0x180854CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> BFPMOJILDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x717B7C0", Offset = "0x717A9C0", VA = "0x18717B7C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x717B920", Offset = "0x717AB20", VA = "0x18717B920")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> KLKEAIENKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x717B870", Offset = "0x717AA70", VA = "0x18717B870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x717B9D0", Offset = "0x717ABD0", VA = "0x18717B9D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x717B780", Offset = "0x717A980", VA = "0x18717B780", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x717B7A0", Offset = "0x717A9A0", VA = "0x18717B7A0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xE460A0", Offset = "0xE452A0", VA = "0x180E460A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xE460A0", Offset = "0xE452A0", VA = "0x180E460A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JBGMGDDGHGN
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum MPAFMOFAEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static ACFAMDNJIMF DOHNBJJGHMK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static ACFAMDNJIMF DPPGMNKBJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x717C2D0", Offset = "0x717B4D0", VA = "0x18717C2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static MPAFMOFAEHJ OLIGKMJLCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x717C560", Offset = "0x717B760", VA = "0x18717C560")]
		get
		{
			return default(MPAFMOFAEHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x717C170", Offset = "0x717B370", VA = "0x18717C170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<MPAFMOFAEHJ> NGOBGJPJLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x717C3A0", Offset = "0x717B5A0", VA = "0x18717C3A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x717C480", Offset = "0x717B680", VA = "0x18717C480")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FLINFGHNDPB : DFIDAFDCABL, BGOOCJAGFJN, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, EDJJKFOMGJM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EHODCIMNDCH JBCKEDNHDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject OGCFILPLNFJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HBGKBCMOMOE Spawn<T>(int CGIEGLLOJFE, IReadOnlyList<T> LINJEFIAFHO, GameObject OGCFILPLNFJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HBGKBCMOMOE Spawn<T>(int CGIEGLLOJFE, IReadOnlyList<T> LINJEFIAFHO, GameObject FMDLIFCPPIF, Func<int, GameObject> ELLPAAALBMI);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int DHNLEFJCEAH, float NHOPIPNCBNF);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum JCOEAFOEOLO : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			LeftToRight = 0,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			RightToLeft = 1,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			TopToBottom = 2,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			BottomToTop = 3,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			CustomDirection = 4,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			RadialOut = 10,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			RadialIn = 11,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			VignetteOut = 20,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			VignetteIn = 21,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Disabled = byte.MaxValue
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int LLPOAKDADAP;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<JCOEAFOEOLO, string> NHNFINCNOAN;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int NPJAEBEGCJN = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int IHMLHEKIFJB;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int OJLDIOPICAG;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int FLOFHLKGOIO;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int MEBEKDICBOA;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int PFHJGIPJGBG;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int JKJGMAPJHPC;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int HHLEPMPEOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool OIEAJJNJFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool ONBPCCAFDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Color[] KKIIIKMAOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private JCOEAFOEOLO type;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly JCOEAFOEOLO[] OBMGBMJMLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[AHAGJGNEDIE("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly JCOEAFOEOLO[] BHHGLIPLJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[AHAGJGNEDIE("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[AHAGJGNEDIE("type", JCOEAFOEOLO.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[AHAGJGNEDIE("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic EAOPENCEFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool CDFBNOHCOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient NLDFPMKJDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x855BD0", VA = "0x1808569D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x717E1F0", Offset = "0x717D3F0", VA = "0x18717E1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JCOEAFOEOLO EPCABOEGHGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x91FF70", Offset = "0x91F170", VA = "0x18091FF70")]
			get
			{
				return default(JCOEAFOEOLO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x717E370", Offset = "0x717D570", VA = "0x18717E370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool PCOIJLLELLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x717D840", Offset = "0x717CA40", VA = "0x18717D840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 KNFHACNBEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x717E160", Offset = "0x717D360", VA = "0x18717E160")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x717E1A0", Offset = "0x717D3A0", VA = "0x18717E1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool PBDJPNAFNBN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x717CB60", Offset = "0x717BD60", VA = "0x18717CB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 KCBPOPNLEFI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x717E180", Offset = "0x717D380", VA = "0x18717E180")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x717E320", Offset = "0x717D520", VA = "0x18717E320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float ONJJPBDDNAF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF030", Offset = "0x8BE230", VA = "0x1808BF030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x15BEB30", Offset = "0x15BDD30", VA = "0x1815BEB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 HOOBKLJLFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x717DAD0", Offset = "0x717CCD0", VA = "0x18717DAD0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 EPGGMKJLEDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x717CBD0", Offset = "0x717BDD0", VA = "0x18717CBD0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float CPFGBHGDPPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x86D8E0", Offset = "0x86CAE0", VA = "0x18086D8E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x717E380", Offset = "0x717D580", VA = "0x18717E380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x717D6A0", Offset = "0x717C8A0", VA = "0x18717D6A0", Slot = "12")]
		protected override void CAFFBAAFKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x717DB20", Offset = "0x717CD20", VA = "0x18717DB20")]
		private void NCDMBONLNGH(Color[] LELAJPCGINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x717CC60", Offset = "0x717BE60", VA = "0x18717CC60", Slot = "13")]
		protected override void BNJAHOOOJNC(Material GIIKGEKINDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x717D8B0", Offset = "0x717CAB0", VA = "0x18717D8B0", Slot = "14")]
		protected override void IHGBDLNMCDJ(Material GIIKGEKINDH, bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x717E0B0", Offset = "0x717D2B0", VA = "0x18717E0B0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly DMIMLOGKLLM KMAOJCGGMJA;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Sprite KFLANIGCGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material OOCKGGLCJJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material IIKGHMJJEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool JHLBFECBPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool JMOEEJLIJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool PIDCFLOAPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool FDADMLGDCED;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic EAOPENCEFGG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader DNDIDOEFHDH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool CDFBNOHCOBM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool JIJJGOANEAC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform KEGKGMOPPED
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x717FD20", Offset = "0x717EF20", VA = "0x18717FD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect BHICCPJKGBK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x717FF20", Offset = "0x717F120", VA = "0x18717FF20")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite GACCGNPEPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x717FB20", Offset = "0x717ED20", VA = "0x18717FB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x717F5E0", Offset = "0x717E7E0", VA = "0x18717F5E0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x71801D0", Offset = "0x717F3D0", VA = "0x1871801D0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x71804D0", Offset = "0x717F6D0", VA = "0x1871804D0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7180380", Offset = "0x717F580", VA = "0x187180380", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71804E0", Offset = "0x717F6E0", VA = "0x1871804E0")]
		private void POHJGCNNACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x717FDB0", Offset = "0x717EFB0", VA = "0x18717FDB0")]
		private void FLNFDPGDEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x717FD80", Offset = "0x717EF80", VA = "0x18717FD80")]
		private void EOOGEEDHNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7180040", Offset = "0x717F240", VA = "0x187180040")]
		private void GOAGNPMGJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x717F370", Offset = "0x717E570", VA = "0x18717F370")]
		protected void ANODAMDMEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7180090", Offset = "0x717F290", VA = "0x187180090")]
		private void KHFEECPMNMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "12")]
		protected virtual void CAFFBAAFKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "13")]
		protected virtual void BNJAHOOOJNC(Material GIIKGEKINDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "14")]
		protected virtual void IHGBDLNMCDJ(Material GIIKGEKINDH, bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x717F7D0", Offset = "0x717E9D0", VA = "0x18717F7D0")]
		private void BLFCPCFLCIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
		protected UIMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("UI/Effects/Rings", 15)]
	[ExecuteAlways]
	public class UIRings : UIUberMaterialOverride
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct RingLayer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Range(0f, 2f)]
			[SerializeField]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int DDGGLEAKEGD;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int ANICBHHFFMA;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int BLOMLAPCCNE;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int EIMKOEMFNNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Color[] KKIIIKMAOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private float[] IGEAGKBLDGO;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic EAOPENCEFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool JIJJGOANEAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> LOCNGAKKPIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855B60", VA = "0x180856960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 KNFHACNBEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7181160", Offset = "0x7180360", VA = "0x187181160")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7181180", Offset = "0x7180380", VA = "0x187181180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7180D70", Offset = "0x717FF70", VA = "0x187180D70")]
		public void SetRingLayers(IReadOnlyList<RingLayer> IGILPAHHIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7180B30", Offset = "0x717FD30", VA = "0x187180B30")]
		public bool SetRingLayerColor(int JLMHPKHAOHJ, Color KIJNHGNFMMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7180C80", Offset = "0x717FE80", VA = "0x187180C80")]
		public bool SetRingLayerSize(int JLMHPKHAOHJ, float ECGAAJFODGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71809A0", Offset = "0x717FBA0", VA = "0x1871809A0", Slot = "12")]
		protected override void CAFFBAAFKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7180820", Offset = "0x717FA20", VA = "0x187180820", Slot = "13")]
		protected override void BNJAHOOOJNC(Material GIIKGEKINDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7180AE0", Offset = "0x717FCE0", VA = "0x187180AE0", Slot = "14")]
		protected override void IHGBDLNMCDJ(Material GIIKGEKINDH, bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7180EC0", Offset = "0x71800C0", VA = "0x187180EC0")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Tiler", 15)]
	public class UITiler : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public enum IMGDPFKBMLG
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int BJAFIDFANFB;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int PLJAPJODIHK;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int IKBILBNHNPD;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int MKMOHHDGOKC;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int KILOCJLGBBI;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int NONGMOOCLMB;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int GELNKECGBKK;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int EDMNOCBEEAG;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int IHDGIEJHHOD;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int FMDCNPKBECL;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int PCFMNHDIPED;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int GGOMCMGGJCN;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int EEOMLIMHNNL;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int MOIOLJGLOJA;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int PIKBAMANCPA;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int MKFOJALOLHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		[SerializeField]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("The offset applied to each alternating row or column.")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Range(0f, 360f)]
		[SerializeField]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private IMGDPFKBMLG animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[AHAGJGNEDIE("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[AHAGJGNEDIE("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic EAOPENCEFGG
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool JIJJGOANEAC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite EMCEMABIBPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7181FF0", Offset = "0x71811F0", VA = "0x187181FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7182210", Offset = "0x7181410", VA = "0x187182210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color OPFMLCHIECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8C9C10", Offset = "0x8C8E10", VA = "0x1808C9C10")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x71822A0", Offset = "0x71814A0", VA = "0x1871822A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color GLMEFDFEFOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8D8DD0", Offset = "0x8D7FD0", VA = "0x1808D8DD0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x71820E0", Offset = "0x71812E0", VA = "0x1871820E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float GELIEBHEJJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8BF050", Offset = "0x8BE250", VA = "0x1808BF050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x71821A0", Offset = "0x71813A0", VA = "0x1871821A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 LIMMKBLFNGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7181FD0", Offset = "0x71811D0", VA = "0x187181FD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x71821C0", Offset = "0x71813C0", VA = "0x1871821C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float FGGMJJKKBCO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x86D530", Offset = "0x86C730", VA = "0x18086D530")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7182160", Offset = "0x7181360", VA = "0x187182160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 FOKHHNGDAJF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xC83830", Offset = "0xC82A30", VA = "0x180C83830")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7182320", Offset = "0x7181520", VA = "0x187182320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float LHFNFCMPLDG
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8D8CC0", Offset = "0x8D7EC0", VA = "0x1808D8CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x71820B0", Offset = "0x71812B0", VA = "0x1871820B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 OPDAHJEIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x71818D0", Offset = "0x7180AD0", VA = "0x1871818D0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IMGDPFKBMLG HLCHBOAOHPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xC36B00", Offset = "0xC35D00", VA = "0x180C36B00")]
			get
			{
				return default(IMGDPFKBMLG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x71820D0", Offset = "0x71812D0", VA = "0x1871820D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float ELKEMCBBLIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD75700", Offset = "0xD74900", VA = "0x180D75700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7182180", Offset = "0x7181380", VA = "0x187182180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float CMIEAHADNJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD75850", Offset = "0xD74A50", VA = "0x180D75850")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7182090", Offset = "0x7181290", VA = "0x187182090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x71811D0", Offset = "0x71803D0", VA = "0x1871811D0", Slot = "13")]
		protected override void BNJAHOOOJNC(Material GIIKGEKINDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x71819B0", Offset = "0x7180BB0", VA = "0x1871819B0")]
		private void KKGKCMBHJHH(Sprite BJJLOPILCOF, [Out] Vector2 OFDLMFJNPPF, [Out] Vector2 MIGNBMACPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7181960", Offset = "0x7180B60", VA = "0x187181960", Slot = "14")]
		protected override void IHGBDLNMCDJ(Material GIIKGEKINDH, bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7181F40", Offset = "0x7181140", VA = "0x187181F40")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Shader AEMBHCEIJCE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader DNDIDOEFHDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x71823C0", Offset = "0x71815C0", VA = "0x1871823C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7182370", Offset = "0x7181570", VA = "0x187182370")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class RectTransformHideableAdapter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private SerializableRectTransform hiddenRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private SerializableRectTransform GJFOKIAAFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool IMBEHEMPGEL;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x717C690", Offset = "0x717B890", VA = "0x18717C690")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x717C8F0", Offset = "0x717BAF0", VA = "0x18717C8F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x717CA00", Offset = "0x717BC00", VA = "0x18717CA00")]
		private void PJOFDHIMEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x717C820", Offset = "0x717BA20", VA = "0x18717C820")]
		private void EKBFOMDGHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DMIMLOGKLLM
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct IJLEOOKACJK : IEquatable<IJLEOOKACJK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Component CNBJCJOALNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Action HEHIBOLJAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int ADACLEMKDBJ;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component KGKMKOPPMNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F50", Offset = "0x8C3150", VA = "0x1808C3F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x717BBA0", Offset = "0x717ADA0", VA = "0x18717BBA0")]
		public IJLEOOKACJK(Component CNBJCJOALNK, Action HEHIBOLJAEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x717BB20", Offset = "0x717AD20", VA = "0x18717BB20")]
		public void MHMACPKANBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x717BA80", Offset = "0x717AC80", VA = "0x18717BA80", Slot = "4")]
		public bool Equals(IJLEOOKACJK OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x717BA90", Offset = "0x717AC90", VA = "0x18717BA90", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8513A0", VA = "0x1808521A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BPONAGDPAJL : IEnumerator<JMPDKMJKKGA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private JMPDKMJKKGA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DMIMLOGKLLM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private JMPDKMJKKGA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public BPONAGDPAJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7179840", Offset = "0x7178A40", VA = "0x187179840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7179C00", Offset = "0x7178E00", VA = "0x187179C00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly NKLOKPDBJDH EHKPGKAHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int EAFDABEEFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int PNECJPEOHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Func<Component, float> BIDOCCDEIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<Component, IJLEOOKACJK> CGDLIBIIEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<IJLEOOKACJK> ACJHAKPNJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly List<IJLEOOKACJK> LGMPOJFFOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private GOOHGCNPLOF POADLDBADPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private ADBNOEBBGNC LIGFPLIBLLH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private ADBNOEBBGNC NNMMDENOCLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7179FA0", Offset = "0x71791A0", VA = "0x187179FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x717A530", Offset = "0x7179730", VA = "0x18717A530")]
	public DMIMLOGKLLM(NKLOKPDBJDH EHKPGKAHKKL, int EAFDABEEFPJ = -1, int PNECJPEOHME = -1, [Optional] Func<Component, float> BIDOCCDEIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7179D40", Offset = "0x7178F40", VA = "0x187179D40")]
	public void CGJALDJBKAL(Component CNBJCJOALNK, Action PADMFCNKGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x717A010", Offset = "0x7179210", VA = "0x18717A010")]
	public void HNBOFGHLGPD(Component CNBJCJOALNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x717A2A0", Offset = "0x71794A0", VA = "0x18717A2A0")]
	public bool MKEIEOIFMBA(Component INPAFGCEBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x717A300", Offset = "0x7179500", VA = "0x18717A300")]
	private void PICFCHJKLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x717A220", Offset = "0x7179420", VA = "0x18717A220")]
	[IteratorStateMachine(typeof(BPONAGDPAJL))]
	private IEnumerator<JMPDKMJKKGA> KPNOOKEAAGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xABCB30", Offset = "0xABBD30", VA = "0x180ABCB30")]
	[CompilerGenerated]
	private void PFBCIKJDGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x717A1A0", Offset = "0x71793A0", VA = "0x18717A1A0")]
	[CompilerGenerated]
	private float JJKOBNPLJHP(IJLEOOKACJK PADMFCNKGOL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BPDJHLJGNGP
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IAMPBNMBECG ODPFDFBDDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool MBIKGFEMBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	ODIOBOMGOFD<IAMPBNMBECG> BEBAGLIPPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDKNCBGJCOH(IAMPBNMBECG GAAGKBEFKKH, bool EHFBALFOOAC = false);
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
