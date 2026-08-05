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
				[Cpp2IlInjected.Address(RVA = "0x715F8C0", Offset = "0x715E0C0", VA = "0x18715F8C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x715F920", Offset = "0x715E120", VA = "0x18715F920")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x715F870", Offset = "0x715E070", VA = "0x18715F870")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x715F770", Offset = "0x715DF70", VA = "0x18715F770")]
			public void KKNHGEEMDOK(PointerEventData FMHPKOMEHLC, RectTransform KEGKGMOPPED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x715F3B0", Offset = "0x715DBB0", VA = "0x18715F3B0")]
			public void CFMIELHBNKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x715F690", Offset = "0x715DE90", VA = "0x18715F690")]
			public void JPCLBOJEBGA(PointerEventData FMHPKOMEHLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x715F640", Offset = "0x715DE40", VA = "0x18715F640")]
			public void FBLCLHHMNEH(float JHAOHGBAJEO, RectTransform KEGKGMOPPED, Vector3 NJGBBMKGAPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x856900", Offset = "0x855100", VA = "0x180856900")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x715EB40", Offset = "0x715D340", VA = "0x18715EB40")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PNEKPNJDBHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x856930", Offset = "0x855130", VA = "0x180856930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x715EBF0", Offset = "0x715D3F0", VA = "0x18715EBF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x715EB70", Offset = "0x715D370", VA = "0x18715EB70")]
		private bool ECIEIJFDGMH(PointerEventData BGEDEFLEFII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x715F070", Offset = "0x715D870", VA = "0x18715F070", Slot = "5")]
		public void OnPointerDown(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x715F130", Offset = "0x715D930", VA = "0x18715F130", Slot = "11")]
		public void OnPointerUp(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x715EEE0", Offset = "0x715D6E0", VA = "0x18715EEE0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x715EC20", Offset = "0x715D420", VA = "0x18715EC20", Slot = "7")]
		public void OnBeginDrag(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x715ED30", Offset = "0x715D530", VA = "0x18715ED30", Slot = "4")]
		public void OnDrag(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x715EE10", Offset = "0x715D610", VA = "0x18715EE10", Slot = "8")]
		public void OnEndDrag(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x715F0D0", Offset = "0x715D8D0", VA = "0x18715F0D0", Slot = "9")]
		public void OnPointerEnter(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x715F100", Offset = "0x715D900", VA = "0x18715F100", Slot = "10")]
		public void OnPointerExit(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x715ECF0", Offset = "0x715D4F0", VA = "0x18715ECF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x715F190", Offset = "0x715D990", VA = "0x18715F190")]
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
		[Cpp2IlInjected.Address(RVA = "0x715A3F0", Offset = "0x7158BF0", VA = "0x18715A3F0")]
		public void SetCanvasSortingOrder(short EHNNGENIEKG, bool PONKNJLLNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
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
		[Cpp2IlInjected.Address(RVA = "0x715B000", Offset = "0x7159800", VA = "0x18715B000", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x715AF00", Offset = "0x7159700", VA = "0x18715AF00", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x715AE50", Offset = "0x7159650", VA = "0x18715AE50")]
		private void CPCGLONDDGO(GameObject PEGEOIPEPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x715B2C0", Offset = "0x7159AC0", VA = "0x18715B2C0")]
		public void SetOptionsWithNoDefault(List<string> MNHECFLLMJH, [Optional] string CKGJMNDOGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x715B1D0", Offset = "0x71599D0", VA = "0x18715B1D0")]
		public void SetOptionsWithNoDefault(List<OptionData> FDGBBGJEJMA, [Optional] string CKGJMNDOGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x715B100", Offset = "0x7159900", VA = "0x18715B100", Slot = "42")]
		public override void OnPointerClick(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas NKBDIEAINED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x715B4F0", Offset = "0x7159CF0", VA = "0x18715B4F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
			[DebuggerHidden]
			public IPCPNBMFEDB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x715C3B0", Offset = "0x715ABB0", VA = "0x18715C3B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x715C8C0", Offset = "0x715B0C0", VA = "0x18715C8C0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x715BC40", Offset = "0x715A440", VA = "0x18715BC40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool OLNFIIPJEHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x715BBF0", Offset = "0x715A3F0", VA = "0x18715BBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ELFCPNAGHBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x89CDE0", Offset = "0x89B5E0", VA = "0x18089CDE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x715BE00", Offset = "0x715A600", VA = "0x18715BE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FNELPFJIHOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x715BB50", Offset = "0x715A350", VA = "0x18715BB50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x715BD60", Offset = "0x715A560", VA = "0x18715BD60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x715B540", Offset = "0x7159D40", VA = "0x18715B540")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x715B930", Offset = "0x715A130", VA = "0x18715B930")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x715B8E0", Offset = "0x715A0E0", VA = "0x18715B8E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x715B850", Offset = "0x715A050", VA = "0x18715B850")]
		public void Hide(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x715BAB0", Offset = "0x715A2B0", VA = "0x18715BAB0")]
		public void Show(object EOCJCEFCOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x715B9C0", Offset = "0x715A1C0", VA = "0x18715B9C0")]
		public void Set(object EOCJCEFCOOA, bool NFFHHODDOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x715B5D0", Offset = "0x7159DD0", VA = "0x18715B5D0")]
		public void Clear(bool FJCKBDKGALA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x715B680", Offset = "0x7159E80", VA = "0x18715B680")]
		private void EKBFOMDGHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x715B860", Offset = "0x715A060", VA = "0x18715B860")]
		[IteratorStateMachine(typeof(IPCPNBMFEDB))]
		private IEnumerator<JMPDKMJKKGA> LCAGEKBJAFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x715B640", Offset = "0x7159E40", VA = "0x18715B640", Slot = "5")]
		public virtual void DoHideOrShow(bool NKAGDBODKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x715BAC0", Offset = "0x715A2C0", VA = "0x18715BAC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E5A0", VA = "0x18091FDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x854CE0", Offset = "0x8534E0", VA = "0x180854CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> BFPMOJILDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x715BF60", Offset = "0x715A760", VA = "0x18715BF60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x715C0C0", Offset = "0x715A8C0", VA = "0x18715C0C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> KLKEAIENKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x715C010", Offset = "0x715A810", VA = "0x18715C010")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x715C170", Offset = "0x715A970", VA = "0x18715C170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x715BF20", Offset = "0x715A720", VA = "0x18715BF20", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x715BF40", Offset = "0x715A740", VA = "0x18715BF40", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData BGEDEFLEFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xE44770", Offset = "0xE42F70", VA = "0x180E44770")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xE44770", Offset = "0xE42F70", VA = "0x180E44770")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
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
		[Cpp2IlInjected.Address(RVA = "0x715CA70", Offset = "0x715B270", VA = "0x18715CA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static MPAFMOFAEHJ OLIGKMJLCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x715CD00", Offset = "0x715B500", VA = "0x18715CD00")]
		get
		{
			return default(MPAFMOFAEHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x715C910", Offset = "0x715B110", VA = "0x18715C910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<MPAFMOFAEHJ> NGOBGJPJLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x715CB40", Offset = "0x715B340", VA = "0x18715CB40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x715CC20", Offset = "0x715B420", VA = "0x18715CC20")]
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
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool CDFBNOHCOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient NLDFPMKJDMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8551D0", VA = "0x1808569D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x715E990", Offset = "0x715D190", VA = "0x18715E990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JCOEAFOEOLO EPCABOEGHGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x91F1C0", Offset = "0x91D9C0", VA = "0x18091F1C0")]
			get
			{
				return default(JCOEAFOEOLO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x715EB10", Offset = "0x715D310", VA = "0x18715EB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool PCOIJLLELLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x715DFE0", Offset = "0x715C7E0", VA = "0x18715DFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 KNFHACNBEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x715E900", Offset = "0x715D100", VA = "0x18715E900")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x715E940", Offset = "0x715D140", VA = "0x18715E940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool PBDJPNAFNBN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x715D300", Offset = "0x715BB00", VA = "0x18715D300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 KCBPOPNLEFI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x715E920", Offset = "0x715D120", VA = "0x18715E920")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x715EAC0", Offset = "0x715D2C0", VA = "0x18715EAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float ONJJPBDDNAF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8BF1F0", Offset = "0x8BD9F0", VA = "0x1808BF1F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x15B7770", Offset = "0x15B5F70", VA = "0x1815B7770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 HOOBKLJLFPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x715E270", Offset = "0x715CA70", VA = "0x18715E270")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 EPGGMKJLEDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x715D370", Offset = "0x715BB70", VA = "0x18715D370")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float CPFGBHGDPPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x86D960", Offset = "0x86C160", VA = "0x18086D960")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x715EB20", Offset = "0x715D320", VA = "0x18715EB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x715DE40", Offset = "0x715C640", VA = "0x18715DE40", Slot = "12")]
		protected override void CAFFBAAFKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x715E2C0", Offset = "0x715CAC0", VA = "0x18715E2C0")]
		private void NCDMBONLNGH(Color[] LELAJPCGINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x715D400", Offset = "0x715BC00", VA = "0x18715D400", Slot = "13")]
		protected override void BNJAHOOOJNC(Material GIIKGEKINDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x715E050", Offset = "0x715C850", VA = "0x18715E050", Slot = "14")]
		protected override void IHGBDLNMCDJ(Material GIIKGEKINDH, bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x715E850", Offset = "0x715D050", VA = "0x18715E850")]
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
			[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool JIJJGOANEAC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x8999F0", VA = "0x18089B1F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform KEGKGMOPPED
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x71604C0", Offset = "0x715ECC0", VA = "0x1871604C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect BHICCPJKGBK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x71606C0", Offset = "0x715EEC0", VA = "0x1871606C0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite GACCGNPEPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x71602C0", Offset = "0x715EAC0", VA = "0x1871602C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x715FD80", Offset = "0x715E580", VA = "0x18715FD80", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7160970", Offset = "0x715F170", VA = "0x187160970", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7160C70", Offset = "0x715F470", VA = "0x187160C70", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7160B20", Offset = "0x715F320", VA = "0x187160B20", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7160C80", Offset = "0x715F480", VA = "0x187160C80")]
		private void POHJGCNNACG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7160550", Offset = "0x715ED50", VA = "0x187160550")]
		private void FLNFDPGDEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7160520", Offset = "0x715ED20", VA = "0x187160520")]
		private void EOOGEEDHNAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x71607E0", Offset = "0x715EFE0", VA = "0x1871607E0")]
		private void GOAGNPMGJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x715FB10", Offset = "0x715E310", VA = "0x18715FB10")]
		protected void ANODAMDMEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7160830", Offset = "0x715F030", VA = "0x187160830")]
		private void KHFEECPMNMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "12")]
		protected virtual void CAFFBAAFKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "13")]
		protected virtual void BNJAHOOOJNC(Material GIIKGEKINDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "14")]
		protected virtual void IHGBDLNMCDJ(Material GIIKGEKINDH, bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x715FF70", Offset = "0x715E770", VA = "0x18715FF70")]
		private void BLFCPCFLCIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
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
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool JIJJGOANEAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> LOCNGAKKPIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 KNFHACNBEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7161900", Offset = "0x7160100", VA = "0x187161900")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7161920", Offset = "0x7160120", VA = "0x187161920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7161510", Offset = "0x715FD10", VA = "0x187161510")]
		public void SetRingLayers(IReadOnlyList<RingLayer> IGILPAHHIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x71612D0", Offset = "0x715FAD0", VA = "0x1871612D0")]
		public bool SetRingLayerColor(int JLMHPKHAOHJ, Color KIJNHGNFMMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7161420", Offset = "0x715FC20", VA = "0x187161420")]
		public bool SetRingLayerSize(int JLMHPKHAOHJ, float ECGAAJFODGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7161140", Offset = "0x715F940", VA = "0x187161140", Slot = "12")]
		protected override void CAFFBAAFKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7160FC0", Offset = "0x715F7C0", VA = "0x187160FC0", Slot = "13")]
		protected override void BNJAHOOOJNC(Material GIIKGEKINDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7161280", Offset = "0x715FA80", VA = "0x187161280", Slot = "14")]
		protected override void IHGBDLNMCDJ(Material GIIKGEKINDH, bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7161660", Offset = "0x715FE60", VA = "0x187161660")]
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
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool JIJJGOANEAC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x86D5A0", Offset = "0x86BDA0", VA = "0x18086D5A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite EMCEMABIBPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7162790", Offset = "0x7160F90", VA = "0x187162790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x71629B0", Offset = "0x71611B0", VA = "0x1871629B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color OPFMLCHIECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8C9DD0", Offset = "0x8C85D0", VA = "0x1808C9DD0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7162A40", Offset = "0x7161240", VA = "0x187162A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color GLMEFDFEFOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8D8A80", Offset = "0x8D7280", VA = "0x1808D8A80")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7162880", Offset = "0x7161080", VA = "0x187162880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float GELIEBHEJJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8BF210", Offset = "0x8BDA10", VA = "0x1808BF210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7162940", Offset = "0x7161140", VA = "0x187162940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 LIMMKBLFNGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7162770", Offset = "0x7160F70", VA = "0x187162770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7162960", Offset = "0x7161160", VA = "0x187162960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float FGGMJJKKBCO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x86D5B0", Offset = "0x86BDB0", VA = "0x18086D5B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7162900", Offset = "0x7161100", VA = "0x187162900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 FOKHHNGDAJF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xC82570", Offset = "0xC80D70", VA = "0x180C82570")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7162AC0", Offset = "0x71612C0", VA = "0x187162AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float LHFNFCMPLDG
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8D8970", Offset = "0x8D7170", VA = "0x1808D8970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7162850", Offset = "0x7161050", VA = "0x187162850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 OPDAHJEIIEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7162070", Offset = "0x7160870", VA = "0x187162070")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IMGDPFKBMLG HLCHBOAOHPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xC35870", Offset = "0xC34070", VA = "0x180C35870")]
			get
			{
				return default(IMGDPFKBMLG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7162870", Offset = "0x7161070", VA = "0x187162870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float ELKEMCBBLIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD73E50", Offset = "0xD72650", VA = "0x180D73E50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7162920", Offset = "0x7161120", VA = "0x187162920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float CMIEAHADNJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD73FA0", Offset = "0xD727A0", VA = "0x180D73FA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7162830", Offset = "0x7161030", VA = "0x187162830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7161970", Offset = "0x7160170", VA = "0x187161970", Slot = "13")]
		protected override void BNJAHOOOJNC(Material GIIKGEKINDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7162150", Offset = "0x7160950", VA = "0x187162150")]
		private void KKGKCMBHJHH(Sprite BJJLOPILCOF, [Out] Vector2 OFDLMFJNPPF, [Out] Vector2 MIGNBMACPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7162100", Offset = "0x7160900", VA = "0x187162100", Slot = "14")]
		protected override void IHGBDLNMCDJ(Material GIIKGEKINDH, bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x71626E0", Offset = "0x7160EE0", VA = "0x1871626E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7162B60", Offset = "0x7161360", VA = "0x187162B60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7162B10", Offset = "0x7161310", VA = "0x187162B10")]
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
		[Cpp2IlInjected.Address(RVA = "0x715CE30", Offset = "0x715B630", VA = "0x18715CE30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x715D090", Offset = "0x715B890", VA = "0x18715D090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x715D1A0", Offset = "0x715B9A0", VA = "0x18715D1A0")]
		private void PJOFDHIMEOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x715CFC0", Offset = "0x715B7C0", VA = "0x18715CFC0")]
		private void EKBFOMDGHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C4110", Offset = "0x8C2910", VA = "0x1808C4110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x715C340", Offset = "0x715AB40", VA = "0x18715C340")]
		public IJLEOOKACJK(Component CNBJCJOALNK, Action HEHIBOLJAEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x715C2C0", Offset = "0x715AAC0", VA = "0x18715C2C0")]
		public void MHMACPKANBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x715C220", Offset = "0x715AA20", VA = "0x18715C220", Slot = "4")]
		public bool Equals(IJLEOOKACJK OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x715C230", Offset = "0x715AA30", VA = "0x18715C230", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8509A0", VA = "0x1808521A0", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public BPONAGDPAJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7159FE0", Offset = "0x71587E0", VA = "0x187159FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x715A3A0", Offset = "0x7158BA0", VA = "0x18715A3A0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x715A740", Offset = "0x7158F40", VA = "0x18715A740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x715ACD0", Offset = "0x71594D0", VA = "0x18715ACD0")]
	public DMIMLOGKLLM(NKLOKPDBJDH EHKPGKAHKKL, int EAFDABEEFPJ = -1, int PNECJPEOHME = -1, [Optional] Func<Component, float> BIDOCCDEIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x715A4E0", Offset = "0x7158CE0", VA = "0x18715A4E0")]
	public void CGJALDJBKAL(Component CNBJCJOALNK, Action PADMFCNKGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x715A7B0", Offset = "0x7158FB0", VA = "0x18715A7B0")]
	public void HNBOFGHLGPD(Component CNBJCJOALNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x715AA40", Offset = "0x7159240", VA = "0x18715AA40")]
	public bool MKEIEOIFMBA(Component INPAFGCEBHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x715AAA0", Offset = "0x71592A0", VA = "0x18715AAA0")]
	private void PICFCHJKLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x715A9C0", Offset = "0x71591C0", VA = "0x18715A9C0")]
	[IteratorStateMachine(typeof(BPONAGDPAJL))]
	private IEnumerator<JMPDKMJKKGA> KPNOOKEAAGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xABBA80", Offset = "0xABA280", VA = "0x180ABBA80")]
	[CompilerGenerated]
	private void PFBCIKJDGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x715A940", Offset = "0x7159140", VA = "0x18715A940")]
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
