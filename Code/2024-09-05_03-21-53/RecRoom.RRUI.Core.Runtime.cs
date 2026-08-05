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
				[Cpp2IlInjected.Address(RVA = "0x744FA70", Offset = "0x744E470", VA = "0x18744FA70")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x744FAD0", Offset = "0x744E4D0", VA = "0x18744FAD0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x744FA20", Offset = "0x744E420", VA = "0x18744FA20")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x744F690", Offset = "0x744E090", VA = "0x18744F690")]
			public void HFBFGHHCAJK(PointerEventData CMILJPEFAGB, RectTransform LEOENONCMBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x744F790", Offset = "0x744E190", VA = "0x18744F790")]
			public void MAFFGJLENEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x744F5B0", Offset = "0x744DFB0", VA = "0x18744F5B0")]
			public void HCBAHCIEPBK(PointerEventData CMILJPEFAGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x744F560", Offset = "0x744DF60", VA = "0x18744F560")]
			public void GJLMBIMDMMJ(float FDHBMDMMJDD, RectTransform LEOENONCMBN, Vector3 IFAKEDNBGGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly HLIGJNPKABP<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly HLIGJNPKABP<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly HLIGJNPKABP<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly HLIGJNPKABP<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly HLIGJNPKABP<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly PLAJPLAPENK PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData IDEIDDAMJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool NKBCMFCIHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool KMPFNCCKNLD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HDBFIOBMILJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x891440", Offset = "0x88FE40", VA = "0x180891440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x744ECF0", Offset = "0x744D6F0", VA = "0x18744ECF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool EGCAICLOHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x891480", Offset = "0x88FE80", VA = "0x180891480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x744ED20", Offset = "0x744D720", VA = "0x18744ED20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x744ED50", Offset = "0x744D750", VA = "0x18744ED50")]
		private bool LFHFKEMKFJP(PointerEventData NIMOEMOGMIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x744F220", Offset = "0x744DC20", VA = "0x18744F220", Slot = "5")]
		public void OnPointerDown(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x744F2E0", Offset = "0x744DCE0", VA = "0x18744F2E0", Slot = "11")]
		public void OnPointerUp(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x744F090", Offset = "0x744DA90", VA = "0x18744F090", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x744EDD0", Offset = "0x744D7D0", VA = "0x18744EDD0", Slot = "7")]
		public void OnBeginDrag(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x744EEE0", Offset = "0x744D8E0", VA = "0x18744EEE0", Slot = "4")]
		public void OnDrag(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x744EFC0", Offset = "0x744D9C0", VA = "0x18744EFC0", Slot = "8")]
		public void OnEndDrag(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x744F280", Offset = "0x744DC80", VA = "0x18744F280", Slot = "9")]
		public void OnPointerEnter(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x744F2B0", Offset = "0x744DCB0", VA = "0x18744F2B0", Slot = "10")]
		public void OnPointerExit(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x744EEA0", Offset = "0x744D8A0", VA = "0x18744EEA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x744F340", Offset = "0x744DD40", VA = "0x18744F340")]
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
		[Cpp2IlInjected.Address(RVA = "0x744A1D0", Offset = "0x7448BD0", VA = "0x18744A1D0")]
		public void SetCanvasSortingOrder(short MGKFBHNKJGE, bool KJGJMKODKIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData PCNOPHNHICJ;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x744A490", Offset = "0x7448E90", VA = "0x18744A490", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x744A370", Offset = "0x7448D70", VA = "0x18744A370", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x744A2C0", Offset = "0x7448CC0", VA = "0x18744A2C0")]
		private void MDOMBPCJPKO(GameObject AINKNMJGJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x744A770", Offset = "0x7449170", VA = "0x18744A770")]
		public void SetOptionsWithNoDefault(List<string> ACOKCANBLGD, [Optional] string ENNHPAAKMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x744A680", Offset = "0x7449080", VA = "0x18744A680")]
		public void SetOptionsWithNoDefault(List<OptionData> IIPNOBBMFOE, [Optional] string ENNHPAAKMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x744A5B0", Offset = "0x7448FB0", VA = "0x18744A5B0", Slot = "42")]
		public override void OnPointerClick(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas LGCMDNCIONB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x744A990", Offset = "0x7449390", VA = "0x18744A990")]
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
		private sealed class JMNGPOKODDF : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private IHLHBLBKNMF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
			[DebuggerHidden]
			public JMNGPOKODDF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x744C430", Offset = "0x744AE30", VA = "0x18744C430", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x744C940", Offset = "0x744B340", VA = "0x18744C940", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[HIPIAIBDPPP(BILCJMODHFE.Self, false, false, false)]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly DMAPBIDKHOP<object> GFHIGBEOPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool HMPCHPKMIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? JEHDMPJJDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? HKEODEKAIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? EAMJKBPAACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool IMCOMPHHPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool HEFJOACHFLG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool AEIPDMOKBNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x744B090", Offset = "0x7449A90", VA = "0x18744B090", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KKOGEJHMMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x744B040", Offset = "0x7449A40", VA = "0x18744B040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IGKNPFGNIFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8CEDD0", Offset = "0x8CD7D0", VA = "0x1808CEDD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x744B250", Offset = "0x7449C50", VA = "0x18744B250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KJPKKNJMGGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x744AFA0", Offset = "0x74499A0", VA = "0x18744AFA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x744B1B0", Offset = "0x7449BB0", VA = "0x18744B1B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x744AB60", Offset = "0x7449560", VA = "0x18744AB60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x744AD80", Offset = "0x7449780", VA = "0x18744AD80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x744AD30", Offset = "0x7449730", VA = "0x18744AD30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x744ACA0", Offset = "0x74496A0", VA = "0x18744ACA0")]
		public void Hide(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x744AF00", Offset = "0x7449900", VA = "0x18744AF00")]
		public void Show(object KLGLJKMNAIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x744AE10", Offset = "0x7449810", VA = "0x18744AE10")]
		public void Set(object KLGLJKMNAIM, bool PJCHCFBMNCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x744ABF0", Offset = "0x74495F0", VA = "0x18744ABF0")]
		public void Clear(bool OJGOIOAKDJB = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x744A9E0", Offset = "0x74493E0", VA = "0x18744A9E0")]
		private void AMHEMPPILKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x744ACB0", Offset = "0x74496B0", VA = "0x18744ACB0")]
		[IteratorStateMachine(typeof(JMNGPOKODDF))]
		private IEnumerator<IHLHBLBKNMF> KCEMDMBBONO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x744AC60", Offset = "0x7449660", VA = "0x18744AC60", Slot = "5")]
		public virtual void DoHideOrShow(bool PGNKDHLIGPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x744AF10", Offset = "0x7449910", VA = "0x18744AF10")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IAILBPKOIMM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9ECD20", Offset = "0x9EB720", VA = "0x1809ECD20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x888E70", Offset = "0x887870", VA = "0x180888E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> OIEKMMBJBFG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x744B3B0", Offset = "0x7449DB0", VA = "0x18744B3B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x744B510", Offset = "0x7449F10", VA = "0x18744B510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> IJONCBPMFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x744B460", Offset = "0x7449E60", VA = "0x18744B460")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x744B5C0", Offset = "0x7449FC0", VA = "0x18744B5C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x744B370", Offset = "0x7449D70", VA = "0x18744B370", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x744B390", Offset = "0x7449D90", VA = "0x18744B390", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData NIMOEMOGMIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1038700", Offset = "0x1037100", VA = "0x181038700")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1038700", Offset = "0x1037100", VA = "0x181038700")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NLPBONJBAHG
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum COMPFIELOHH
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static HGJBNCNJFDG CFNCIIONANO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static HGJBNCNJFDG JNKFGHNDAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x744CB20", Offset = "0x744B520", VA = "0x18744CB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static COMPFIELOHH KNODNKGDKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x744CF20", Offset = "0x744B920", VA = "0x18744CF20")]
		get
		{
			return default(COMPFIELOHH);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x744CCF0", Offset = "0x744B6F0", VA = "0x18744CCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<COMPFIELOHH> AHCDNPMOEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x744CC20", Offset = "0x744B620", VA = "0x18744CC20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x744CE50", Offset = "0x744B850", VA = "0x18744CE50")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HMOFPPMAOJE : KKDAKBCHJAA, AEDJGGBAMPN, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, NKNIPNMDMMK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	PLAJPLAPENK PLNIGNACAOH
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
	void SpawnLoadingPlaceholders(GameObject FNDDMGMPCAM);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EOKLDMPJAPL Spawn<T>(int CDJLINGDNCA, IReadOnlyList<T> OIGMDCDEKEG, GameObject FNDDMGMPCAM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EOKLDMPJAPL Spawn<T>(int CDJLINGDNCA, IReadOnlyList<T> OIGMDCDEKEG, GameObject FABEKNGIHHG, Func<int, GameObject> BMDBKMCOHGA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int EBDDHAPIAHH, float NBIEDMFBDKF);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum MLCCIDAPBFP : byte
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
		private static readonly int AEPCGKEIADC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<MLCCIDAPBFP, string> GEGJCLANECG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int LIGECAKHGIG = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int BIFKFFHKBKD;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int MOOBMHHFJBM;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int HHKAMACODKL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int NJLEEGPCKDB;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int ADMOAAIIOOA;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int HOBAAKKKMAD;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int GPLLCKBCJEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool NMNLEIGGLCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool PLCKCGEIIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Color[] MNEKPBGGPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private MLCCIDAPBFP type;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly MLCCIDAPBFP[] JPEKCLCIHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[BENIALBDKBI("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly MLCCIDAPBFP[] LLCCMGGDHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[BENIALBDKBI("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[BENIALBDKBI("type", MLCCIDAPBFP.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[BENIALBDKBI("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic DHHLKALGEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool MLAFLAPCAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient EMAMBINGOGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x88C8B0", Offset = "0x88B2B0", VA = "0x18088C8B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x744EB40", Offset = "0x744D540", VA = "0x18744EB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MLCCIDAPBFP HMGDADDECHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x907950", Offset = "0x906350", VA = "0x180907950")]
			get
			{
				return default(MLCCIDAPBFP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x744ECC0", Offset = "0x744D6C0", VA = "0x18744ECC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool BNNPENMPFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x744E3A0", Offset = "0x744CDA0", VA = "0x18744E3A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 OKDOINDOEEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x744EAB0", Offset = "0x744D4B0", VA = "0x18744EAB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x744EAF0", Offset = "0x744D4F0", VA = "0x18744EAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool FABDKCIIPEB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x744E5B0", Offset = "0x744CFB0", VA = "0x18744E5B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 FMENFDJFDDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x744EAD0", Offset = "0x744D4D0", VA = "0x18744EAD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x744EC70", Offset = "0x744D670", VA = "0x18744EC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float CBCALDKABCN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA3E350", Offset = "0xA3CD50", VA = "0x180A3E350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x17E6610", Offset = "0x17E5010", VA = "0x1817E6610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 KCINKDACNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x744D6A0", Offset = "0x744C0A0", VA = "0x18744D6A0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 PCIFLJLKBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x744E310", Offset = "0x744CD10", VA = "0x18744E310")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float EHGPDBNPHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x89F7B0", Offset = "0x89E1B0", VA = "0x18089F7B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x744ECD0", Offset = "0x744D6D0", VA = "0x18744ECD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x744E410", Offset = "0x744CE10", VA = "0x18744E410", Slot = "12")]
		protected override void ILPLFDNMFIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x744D510", Offset = "0x744BF10", VA = "0x18744D510")]
		private void AMCODOGDPJA(Color[] ONPANKAMIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x744D6F0", Offset = "0x744C0F0", VA = "0x18744D6F0", Slot = "13")]
		protected override void DCCEGFIIKFG(Material MLMFHAHBCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x744E0F0", Offset = "0x744CAF0", VA = "0x18744E0F0", Slot = "14")]
		protected override void GEILDLBKLIC(Material MLMFHAHBCEC, bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x744EA00", Offset = "0x744D400", VA = "0x18744EA00")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly JKEFDBFMIPK FJGEKALCHHH;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Sprite BDKNCMKJNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material JBMHAFKGLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material JGPGIBHCNNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool HNJPMNIGCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool HMPCHPKMIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool IDIBHKNCHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool BEDJBLGMABB;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic DHHLKALGEPK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader DMEJECJGOCL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool MLAFLAPCAGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool NBOFKCGNFGO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform LEOENONCMBN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x74500A0", Offset = "0x744EAA0", VA = "0x1874500A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect OCJKAPFODBA
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7450270", Offset = "0x744EC70", VA = "0x187450270")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite NFMDPLGDLEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x744FEB0", Offset = "0x744E8B0", VA = "0x18744FEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x744FCC0", Offset = "0x744E6C0", VA = "0x18744FCC0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7450C90", Offset = "0x744F690", VA = "0x187450C90", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7450F90", Offset = "0x744F990", VA = "0x187450F90", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7450E40", Offset = "0x744F840", VA = "0x187450E40", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7450390", Offset = "0x744ED90", VA = "0x187450390")]
		private void IHFOKCADNMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7450100", Offset = "0x744EB00", VA = "0x187450100")]
		private void FMBKDMLPBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7450A00", Offset = "0x744F400", VA = "0x187450A00")]
		private void MMJONEACGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7450660", Offset = "0x744F060", VA = "0x187450660")]
		private void LFMNAKJJCOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7450A30", Offset = "0x744F430", VA = "0x187450A30")]
		protected void NONKKGIFGHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7450520", Offset = "0x744EF20", VA = "0x187450520")]
		private void IOJNDBFHHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "12")]
		protected virtual void ILPLFDNMFIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "13")]
		protected virtual void DCCEGFIIKFG(Material MLMFHAHBCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "14")]
		protected virtual void GEILDLBKLIC(Material MLMFHAHBCEC, bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x74506B0", Offset = "0x744F0B0", VA = "0x1874506B0")]
		private void MDFEEOOBCJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
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
		private static readonly int DKKBOABPHLI;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int KJBGLMCMOKP;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int KCDFKFPCMMF;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int GAEBBIHNNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
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
		private Color[] MNEKPBGGPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private float[] HBIAOENNDJB;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic DHHLKALGEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool NBOFKCGNFGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> PHGLFJMNFJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 OKDOINDOEEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x74519B0", Offset = "0x74503B0", VA = "0x1874519B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x74519D0", Offset = "0x74503D0", VA = "0x1874519D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7451680", Offset = "0x7450080", VA = "0x187451680")]
		public void SetRingLayers(IReadOnlyList<RingLayer> HHPDJICJBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7451440", Offset = "0x744FE40", VA = "0x187451440")]
		public bool SetRingLayerColor(int MMOIPMHDPJP, Color BLBBBKOLGJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7451590", Offset = "0x744FF90", VA = "0x187451590")]
		public bool SetRingLayerSize(int MMOIPMHDPJP, float MPLHLKNKHIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7451300", Offset = "0x744FD00", VA = "0x187451300", Slot = "12")]
		protected override void ILPLFDNMFIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7451140", Offset = "0x744FB40", VA = "0x187451140", Slot = "13")]
		protected override void DCCEGFIIKFG(Material MLMFHAHBCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74512B0", Offset = "0x744FCB0", VA = "0x1874512B0", Slot = "14")]
		protected override void GEILDLBKLIC(Material MLMFHAHBCEC, bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x74517D0", Offset = "0x74501D0", VA = "0x1874517D0")]
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
		public enum FLNMDBGIBMK
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int EMHAAJIOCJD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int LLBNPJFHFMO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int LHNMHOEJNNK;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int MLOGBDHLMMF;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int GMAODBILEHF;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int BOHKEJGJNGE;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int NDFIBFGLCKI;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int JCDLHJIBLMH;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int HNDDKPOGABH;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int CCANLHEHNKB;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int KHFNBGHAIJD;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int PMLEPBBAHPA;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int DAAMHJLEAOO;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int EEBONEFEFFI;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int BBOEKJJDKGH;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int MJHGAJCIKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
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
		private FLNMDBGIBMK animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[BENIALBDKBI("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[BENIALBDKBI("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic DHHLKALGEPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool NBOFKCGNFGO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite HOOJDLNNOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x74527D0", Offset = "0x74511D0", VA = "0x1874527D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x74529F0", Offset = "0x74513F0", VA = "0x1874529F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color DGOGCADMHOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x907980", Offset = "0x906380", VA = "0x180907980")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7452A80", Offset = "0x7451480", VA = "0x187452A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color MEAKHFLKHLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA47380", Offset = "0xA45D80", VA = "0x180A47380")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x74528C0", Offset = "0x74512C0", VA = "0x1874528C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float MCEDCLAOKJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA3E360", Offset = "0xA3CD60", VA = "0x180A3E360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7452980", Offset = "0x7451380", VA = "0x187452980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 ONFNJDMHIJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x74527B0", Offset = "0x74511B0", VA = "0x1874527B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x74529A0", Offset = "0x74513A0", VA = "0x1874529A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float JGJBOLABHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x89F400", Offset = "0x89DE00", VA = "0x18089F400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7452940", Offset = "0x7451340", VA = "0x187452940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 FIPOKMEDLKP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xE13F30", Offset = "0xE12930", VA = "0x180E13F30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7452B00", Offset = "0x7451500", VA = "0x187452B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float BAJJAJJMNOL
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA38CC0", Offset = "0xA376C0", VA = "0x180A38CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7452890", Offset = "0x7451290", VA = "0x187452890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 MIKDGIOKDMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7452390", Offset = "0x7450D90", VA = "0x187452390")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public FLNMDBGIBMK JLKNDAHNFAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xDCD6F0", Offset = "0xDCC0F0", VA = "0x180DCD6F0")]
			get
			{
				return default(FLNMDBGIBMK);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x74528B0", Offset = "0x74512B0", VA = "0x1874528B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float GEAGDMMKMPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xF1ED70", Offset = "0xF1D770", VA = "0x180F1ED70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7452960", Offset = "0x7451360", VA = "0x187452960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float EEGGBLLFPNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xF1EEC0", Offset = "0xF1D8C0", VA = "0x180F1EEC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7452870", Offset = "0x7451270", VA = "0x187452870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7451CD0", Offset = "0x74506D0", VA = "0x187451CD0", Slot = "13")]
		protected override void DCCEGFIIKFG(Material MLMFHAHBCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7451A20", Offset = "0x7450420", VA = "0x187451A20")]
		private void BNIFFOIABDJ(Sprite DCJCDJHGFMA, [Out] Vector2 NDJOBELPKAH, [Out] Vector2 HIGKBFIICJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7452420", Offset = "0x7450E20", VA = "0x187452420", Slot = "14")]
		protected override void GEILDLBKLIC(Material MLMFHAHBCEC, bool CEAFCCPFHNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7452720", Offset = "0x7451120", VA = "0x187452720")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Shader POCKLHECFCN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader DMEJECJGOCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7452BA0", Offset = "0x74515A0", VA = "0x187452BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7452B50", Offset = "0x7451550", VA = "0x187452B50")]
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
		private SerializableRectTransform OEJEMPCKFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool OICFILIFDJF;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x744D120", Offset = "0x744BB20", VA = "0x18744D120")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x744D330", Offset = "0x744BD30", VA = "0x18744D330")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x744D2B0", Offset = "0x744BCB0", VA = "0x18744D2B0")]
		private void KLHGFMMACBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x744D050", Offset = "0x744BA50", VA = "0x18744D050")]
		private void AMHEMPPILKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JKEFDBFMIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct MMOKBLALELB : IEquatable<MMOKBLALELB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Component GJGBLLHIOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Action DNDJELLKEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int NLMPFJCKNBE;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component EFOALAMNFGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x744CAB0", Offset = "0x744B4B0", VA = "0x18744CAB0")]
		public MMOKBLALELB(Component GJGBLLHIOAC, Action DNDJELLKEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x744C990", Offset = "0x744B390", VA = "0x18744C990")]
		public void AAPMEMGCMFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x744CAA0", Offset = "0x744B4A0", VA = "0x18744CAA0", Slot = "4")]
		public bool Equals(MMOKBLALELB AIPFCMFLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x744CA10", Offset = "0x744B410", VA = "0x18744CA10", Slot = "0")]
		public override bool Equals(object GIGIFGONEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class JGKGLDLGOFP : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public JKEFDBFMIPK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public JGKGLDLGOFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x744B670", Offset = "0x744A070", VA = "0x18744B670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x744BA30", Offset = "0x744A430", VA = "0x18744BA30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BFMEILOFOGD CEODDBLCABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int OOFIDEHPMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int DFIDLFFONCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Func<Component, float> HBHEOHAJBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<Component, MMOKBLALELB> HEOKMONCIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<MMOKBLALELB> FDCIKFGCAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly List<MMOKBLALELB> DIPLKKFJCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private DABMKCAGAIA IGFOBKIGNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private BJLBEEMGDKC IOCJLKFEJMF;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private BJLBEEMGDKC ICNPKGOEKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x744BD00", Offset = "0x744A700", VA = "0x18744BD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x744C2B0", Offset = "0x744ACB0", VA = "0x18744C2B0")]
	public JKEFDBFMIPK(BFMEILOFOGD CEODDBLCABL, int OOFIDEHPMLM = -1, int DFIDLFFONCE = -1, [Optional] Func<Component, float> HBHEOHAJBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x744BA80", Offset = "0x744A480", VA = "0x18744BA80")]
	public void BCGLDEHCPBH(Component GJGBLLHIOAC, Action NENCBCPOFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x744C0C0", Offset = "0x744AAC0", VA = "0x18744C0C0")]
	public void HBOBBNPLEFC(Component GJGBLLHIOAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x744C250", Offset = "0x744AC50", VA = "0x18744C250")]
	public bool HONDPCMCCPM(Component PHMJIJLHMJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x744BE90", Offset = "0x744A890", VA = "0x18744BE90")]
	private void FGMOGPOPAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x744BD90", Offset = "0x744A790", VA = "0x18744BD90")]
	[IteratorStateMachine(typeof(JGKGLDLGOFP))]
	private IEnumerator<IHLHBLBKNMF> BOFEFJHDMJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xC5BAB0", Offset = "0xC5A4B0", VA = "0x180C5BAB0")]
	[CompilerGenerated]
	private void ODBGILPFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x744BE10", Offset = "0x744A810", VA = "0x18744BE10")]
	[CompilerGenerated]
	private float CMELEOLLGMH(MMOKBLALELB NENCBCPOFCI)
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
