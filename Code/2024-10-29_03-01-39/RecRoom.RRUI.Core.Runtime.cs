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
				[Cpp2IlInjected.Address(RVA = "0x7769630", Offset = "0x7768630", VA = "0x187769630")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x7769690", Offset = "0x7768690", VA = "0x187769690")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x77695F0", Offset = "0x77685F0", VA = "0x1877695F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7769210", Offset = "0x7768210", VA = "0x187769210")]
			public void MGHEGCGAIAL(PointerEventData BLNOAEHAKEI, RectTransform BOGKMILAFIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7769310", Offset = "0x7768310", VA = "0x187769310")]
			public void NACEJANKFPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7769130", Offset = "0x7768130", VA = "0x187769130")]
			public void FAIELIIGPBH(PointerEventData BLNOAEHAKEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x77695A0", Offset = "0x77685A0", VA = "0x1877695A0")]
			public void OADEHPPNHOJ(float AEDAAKHPBAM, RectTransform BOGKMILAFIJ, Vector3 OFOBLJHNFGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly JFMBBHOLPOC<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JFMBBHOLPOC<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly JFMBBHOLPOC<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly JFMBBHOLPOC<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly JFMBBHOLPOC<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly GDBINPMHEFP PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData HIAFDGAMIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool AIOBHPNCPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool LHAPGOOIIFL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NBHNHACFMAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E80", Offset = "0x8B8E80", VA = "0x1808B9E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7768970", Offset = "0x7767970", VA = "0x187768970")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MOCHBLBFCFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8BA090", Offset = "0x8B9090", VA = "0x1808BA090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7768940", Offset = "0x7767940", VA = "0x187768940")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77688C0", Offset = "0x77678C0", VA = "0x1877688C0")]
		private bool AHHLHIIFCLG(PointerEventData POADLBAMAOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7768DF0", Offset = "0x7767DF0", VA = "0x187768DF0", Slot = "5")]
		public void OnPointerDown(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7768EB0", Offset = "0x7767EB0", VA = "0x187768EB0", Slot = "11")]
		public void OnPointerUp(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7768C60", Offset = "0x7767C60", VA = "0x187768C60", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77689A0", Offset = "0x77679A0", VA = "0x1877689A0", Slot = "7")]
		public void OnBeginDrag(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7768AB0", Offset = "0x7767AB0", VA = "0x187768AB0", Slot = "4")]
		public void OnDrag(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7768B90", Offset = "0x7767B90", VA = "0x187768B90", Slot = "8")]
		public void OnEndDrag(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7768E50", Offset = "0x7767E50", VA = "0x187768E50", Slot = "9")]
		public void OnPointerEnter(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7768E80", Offset = "0x7767E80", VA = "0x187768E80", Slot = "10")]
		public void OnPointerExit(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7768A70", Offset = "0x7767A70", VA = "0x187768A70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7768F10", Offset = "0x7767F10", VA = "0x187768F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7763DB0", Offset = "0x7762DB0", VA = "0x187763DB0")]
		public void SetCanvasSortingOrder(short JODADLJGFIM, bool BGDCBIMLBNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData CLFHCCODADF;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7764070", Offset = "0x7763070", VA = "0x187764070", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7763F50", Offset = "0x7762F50", VA = "0x187763F50", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7763EA0", Offset = "0x7762EA0", VA = "0x187763EA0")]
		private void OFCENFLBKHP(GameObject HKHFJFBGPNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7764350", Offset = "0x7763350", VA = "0x187764350")]
		public void SetOptionsWithNoDefault(List<string> CMDOFHABOHN, [Optional] string PDLIGJBJIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7764260", Offset = "0x7763260", VA = "0x187764260")]
		public void SetOptionsWithNoDefault(List<OptionData> HKFJGLOCDGD, [Optional] string PDLIGJBJIFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7764190", Offset = "0x7763190", VA = "0x187764190", Slot = "42")]
		public override void OnPointerClick(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BB0", Offset = "0x8B4BB0", VA = "0x1808B5BB0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas BHKHIBHIAMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7764570", Offset = "0x7763570", VA = "0x187764570")]
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
		private sealed class LGBEECODIKF : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private MIAEKAOKMEH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
			[DebuggerHidden]
			public LGBEECODIKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7765D90", Offset = "0x7764D90", VA = "0x187765D90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x77662A0", Offset = "0x77652A0", VA = "0x1877662A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[MONCIELHEAI(CCPGINMHCCO.Self, false, false, false)]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly JOLPOJKDDFO<object> AANICKMMNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool FJGMEOFBBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? MBPGAONMMCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? DDPJCNMFEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? PDEFGGIOCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool GNEGCIMGFEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool BONAMCAOEAH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool AHAPOPOGFKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7764E00", Offset = "0x7763E00", VA = "0x187764E00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool JJOCNEOBBOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7764DB0", Offset = "0x7763DB0", VA = "0x187764DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DMCEHIANGEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x900780", Offset = "0x8FF780", VA = "0x180900780")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7764FC0", Offset = "0x7763FC0", VA = "0x187764FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DNKHEPDPIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7764D10", Offset = "0x7763D10", VA = "0x187764D10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7764F20", Offset = "0x7763F20", VA = "0x187764F20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7764750", Offset = "0x7763750", VA = "0x187764750")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7764AF0", Offset = "0x7763AF0", VA = "0x187764AF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7764AA0", Offset = "0x7763AA0", VA = "0x187764AA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7764A90", Offset = "0x7763A90", VA = "0x187764A90")]
		public void Hide(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7764C70", Offset = "0x7763C70", VA = "0x187764C70")]
		public void Show(object NANMDIJGGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7764B80", Offset = "0x7763B80", VA = "0x187764B80")]
		public void Set(object NANMDIJGGLP, bool LIMKJNMCHHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x77647E0", Offset = "0x77637E0", VA = "0x1877647E0")]
		public void Clear(bool BFINNLLCEAM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7764910", Offset = "0x7763910", VA = "0x187764910")]
		private void FLNPIMAKDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7764850", Offset = "0x7763850", VA = "0x187764850")]
		[IteratorStateMachine(typeof(LGBEECODIKF))]
		private IEnumerator<MIAEKAOKMEH> DBGIEDNFLPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x77648D0", Offset = "0x77638D0", VA = "0x1877648D0", Slot = "5")]
		public virtual void DoHideOrShow(bool BFHBFGAOGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7764C80", Offset = "0x7763C80", VA = "0x187764C80")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MGGLAAFMJIE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9A7620", Offset = "0x9A6620", VA = "0x1809A7620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8BC650", Offset = "0x8BB650", VA = "0x1808BC650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> JOAGNBJNING
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7765120", Offset = "0x7764120", VA = "0x187765120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7765280", Offset = "0x7764280", VA = "0x187765280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> KHNONGAEJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x77651D0", Offset = "0x77641D0", VA = "0x1877651D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7765330", Offset = "0x7764330", VA = "0x187765330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x77650E0", Offset = "0x77640E0", VA = "0x1877650E0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7765100", Offset = "0x7764100", VA = "0x187765100", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData POADLBAMAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x128EEA0", Offset = "0x128DEA0", VA = "0x18128EEA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x128EEA0", Offset = "0x128DEA0", VA = "0x18128EEA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MFLPEACPLNH
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum LLIFNHDCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static AANDAFLIKBC DMHPIDDMICP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static AANDAFLIKBC FNOIGJKFDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7766490", Offset = "0x7765490", VA = "0x187766490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static LLIFNHDCHLM JHFBEJOEBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77666F0", Offset = "0x77656F0", VA = "0x1877666F0")]
		get
		{
			return default(LLIFNHDCHLM);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7766590", Offset = "0x7765590", VA = "0x187766590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<LLIFNHDCHLM> CIDBDIKHGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x77663C0", Offset = "0x77653C0", VA = "0x1877663C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77662F0", Offset = "0x77652F0", VA = "0x1877662F0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BEDGFBLFAFH : HEKOPGFJLCA, JFPANBCFFPH, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, MBCKABAGOLO
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GDBINPMHEFP AICEOKJOMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EDMIDDLGGJL Clear();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject MBJCMFAMEBD);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EDMIDDLGGJL Spawn<T>(int KCFAKGJJFOM, IReadOnlyList<T> CONAFKKIHKL, GameObject MBJCMFAMEBD);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EDMIDDLGGJL Spawn<T>(int KCFAKGJJFOM, IReadOnlyList<T> CONAFKKIHKL, GameObject LOCKDPICFJA, Func<int, GameObject> CIJNAGOMJGC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int KHAIDMGPIED, float MAOHEBIAJOD);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum IAALEPOOIKK : byte
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
		private static readonly int CHGCAFGBFPN;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<IAALEPOOIKK, string> CLOEFBDDOOP;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int MGLMJBBAAHD = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int GBOIJOEGDGB;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int BHCOPLAFGLF;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int APJDAKLLAIH;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int BPNHNANOOMB;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int ALDOCLMLHGG;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int MJLBHCKLFOB;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int AEOJNKHFGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool DDEAFOOOFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool KOKMBIHMDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Color[] MGFNFPALPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private IAALEPOOIKK type;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly IAALEPOOIKK[] JHNAOCKMIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[EELAEKFBIFP("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly IAALEPOOIKK[] LENIMCBOPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[EELAEKFBIFP("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[EELAEKFBIFP("type", IAALEPOOIKK.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[EELAEKFBIFP("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic BAAFMEAIMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool HLCBLAGAOLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient BCMBDOJJIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7768710", Offset = "0x7767710", VA = "0x187768710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IAALEPOOIKK BFKMCKBKOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB19BA0", Offset = "0xB18BA0", VA = "0x180B19BA0")]
			get
			{
				return default(IAALEPOOIKK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7768890", Offset = "0x7767890", VA = "0x187768890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool FEEMMPGDGCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7768180", Offset = "0x7767180", VA = "0x187768180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 FAMPJPKNBNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7768680", Offset = "0x7767680", VA = "0x187768680")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x77686C0", Offset = "0x77676C0", VA = "0x1877686C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool CCJDMLHJGPO
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7768110", Offset = "0x7767110", VA = "0x187768110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 DJBGAGHAMNK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x77686A0", Offset = "0x77676A0", VA = "0x1877686A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7768840", Offset = "0x7767840", VA = "0x187768840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float EODPLNOPAAA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xC97D20", Offset = "0xC96D20", VA = "0x180C97D20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1B81CF0", Offset = "0x1B80CF0", VA = "0x181B81CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 BHNLHNHECJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7767D00", Offset = "0x7766D00", VA = "0x187767D00")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 NGIANCKIDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7767B00", Offset = "0x7766B00", VA = "0x187767B00")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float EIINABLLBLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8D0990", Offset = "0x8CF990", VA = "0x1808D0990")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x77688A0", Offset = "0x77678A0", VA = "0x1877688A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7767F70", Offset = "0x7766F70", VA = "0x187767F70", Slot = "12")]
		protected override void FNOLCJHMHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7767B70", Offset = "0x7766B70", VA = "0x187767B70")]
		private void EJAADMBJMOF(Color[] KEGLFIONCAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x77670F0", Offset = "0x77660F0", VA = "0x1877670F0", Slot = "13")]
		protected override void BBFOMNHNKGM(Material BIDMCIBAHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7767D50", Offset = "0x7766D50", VA = "0x187767D50", Slot = "14")]
		protected override void FFIIGGDNDBL(Material BIDMCIBAHOL, bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x77685D0", Offset = "0x77675D0", VA = "0x1877685D0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly JKKAMFDACEA ELIJKDLKGAN;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Sprite LFAEOEPDFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material FGGGIAENPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material KFJHJCKABEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool OPDFMJAMOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool FJGMEOFBBKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool MGIAPCMCFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool GHLBNMPENDN;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic BAAFMEAIMNH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader CHADAPBKFOP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool HLCBLAGAOLP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool HAAAKPCJHFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform BOGKMILAFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x776A300", Offset = "0x7769300", VA = "0x18776A300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect OHHGPBDJJFN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7769BE0", Offset = "0x7768BE0", VA = "0x187769BE0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite ICBGIAMECNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7769D00", Offset = "0x7768D00", VA = "0x187769D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7769880", Offset = "0x7768880", VA = "0x187769880", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x776A840", Offset = "0x7769840", VA = "0x18776A840", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x776AB40", Offset = "0x7769B40", VA = "0x18776AB40", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x776A9F0", Offset = "0x77699F0", VA = "0x18776A9F0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x776A360", Offset = "0x7769360", VA = "0x18776A360")]
		private void NDPBCNCPEHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x776A140", Offset = "0x7769140", VA = "0x18776A140")]
		private void IFKFJGKHMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7769A70", Offset = "0x7768A70", VA = "0x187769A70")]
		private void BCFLLOODHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x776A2B0", Offset = "0x77692B0", VA = "0x18776A2B0")]
		private void LGFBGEIOCBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7769EE0", Offset = "0x7768EE0", VA = "0x187769EE0")]
		protected void IDKKFIJHKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7769AA0", Offset = "0x7768AA0", VA = "0x187769AA0")]
		private void CEHDNLJFDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "12")]
		protected virtual void FNOLCJHMHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "13")]
		protected virtual void BBFOMNHNKGM(Material BIDMCIBAHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "14")]
		protected virtual void FFIIGGDNDBL(Material BIDMCIBAHOL, bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x776A4F0", Offset = "0x77694F0", VA = "0x18776A4F0")]
		private void OFJAFEBHOPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
		private static readonly int LAKGMEEBNFB;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int DKPOCACHNBP;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int NJGHGOHNPDC;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int IDEHLHCECLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
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
		private Color[] MGFNFPALPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private float[] BMLEGMPBFLM;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic BAAFMEAIMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool HAAAKPCJHFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> GPBMAHBECNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 FAMPJPKNBNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x776B570", Offset = "0x776A570", VA = "0x18776B570")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x776B590", Offset = "0x776A590", VA = "0x18776B590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x776B230", Offset = "0x776A230", VA = "0x18776B230")]
		public void SetRingLayers(IReadOnlyList<RingLayer> GHNJBACEGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x776AFF0", Offset = "0x7769FF0", VA = "0x18776AFF0")]
		public bool SetRingLayerColor(int BKMADAFHHHB, Color DANHKIEIFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x776B140", Offset = "0x776A140", VA = "0x18776B140")]
		public bool SetRingLayerSize(int BKMADAFHHHB, float MLDINGBBEHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x776AEB0", Offset = "0x7769EB0", VA = "0x18776AEB0", Slot = "12")]
		protected override void FNOLCJHMHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x776ACF0", Offset = "0x7769CF0", VA = "0x18776ACF0", Slot = "13")]
		protected override void BBFOMNHNKGM(Material BIDMCIBAHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x776AE60", Offset = "0x7769E60", VA = "0x18776AE60", Slot = "14")]
		protected override void FFIIGGDNDBL(Material BIDMCIBAHOL, bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x776B380", Offset = "0x776A380", VA = "0x18776B380")]
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
		public enum FOHMJJDHCGL
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int JEPMGKLOFAA;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int DAPFCOEGOEC;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int EFMIEIPOMKO;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int COBKEDHKFKB;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int LPBAJODGIPG;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int GNPDNDLJBNM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int PHILGJAKIBL;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int FFNBPDIDODG;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int GALGGMPDHLB;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int NGBKOKKGLIH;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int BEHHHDFNNDP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int JAGEGKJAFPH;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int HKFPGBDLJIM;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int HNDPEODBLMA;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int CEMCIBNHIPF;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int JLEDEBJPGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[DPAAGPNIBEP(CCPGINMHCCO.Self, false, false, false)]
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
		private FOHMJJDHCGL animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[EELAEKFBIFP("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[EELAEKFBIFP("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic BAAFMEAIMNH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool HAAAKPCJHFE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite DKDPFEGLPIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x776C390", Offset = "0x776B390", VA = "0x18776C390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x776C5B0", Offset = "0x776B5B0", VA = "0x18776C5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color MOGCBPEBKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB19D10", Offset = "0xB18D10", VA = "0x180B19D10")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x776C640", Offset = "0x776B640", VA = "0x18776C640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color IDCJMKDOKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xCB2AA0", Offset = "0xCB1AA0", VA = "0x180CB2AA0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x776C480", Offset = "0x776B480", VA = "0x18776C480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float HCCNHBONHLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xC97D30", Offset = "0xC96D30", VA = "0x180C97D30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x776C540", Offset = "0x776B540", VA = "0x18776C540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 NJDGBJKOBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x776C370", Offset = "0x776B370", VA = "0x18776C370")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x776C560", Offset = "0x776B560", VA = "0x18776C560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float NDBPJGICJHE
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8D05F0", Offset = "0x8CF5F0", VA = "0x1808D05F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x776C500", Offset = "0x776B500", VA = "0x18776C500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 MBBPOLODOCL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1081450", Offset = "0x1080450", VA = "0x181081450")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x776C6C0", Offset = "0x776B6C0", VA = "0x18776C6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float LOBKAPCDDLN
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC82050", Offset = "0xC81050", VA = "0x180C82050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x776C450", Offset = "0x776B450", VA = "0x18776C450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 LKNELOAHLFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x776BCA0", Offset = "0x776ACA0", VA = "0x18776BCA0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public FOHMJJDHCGL POKLGBMKPLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAAB570", Offset = "0xAAA570", VA = "0x180AAB570")]
			get
			{
				return default(FOHMJJDHCGL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x776C470", Offset = "0x776B470", VA = "0x18776C470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float NMEBEKINDIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x116D670", Offset = "0x116C670", VA = "0x18116D670")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x776C520", Offset = "0x776B520", VA = "0x18776C520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float AEKJDIDLEJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x116D7C0", Offset = "0x116C7C0", VA = "0x18116D7C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x776C430", Offset = "0x776B430", VA = "0x18776C430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x776B5E0", Offset = "0x776A5E0", VA = "0x18776B5E0", Slot = "13")]
		protected override void BBFOMNHNKGM(Material BIDMCIBAHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x776BD80", Offset = "0x776AD80", VA = "0x18776BD80")]
		private void MIKJBEKLFLB(Sprite KEAFEFCNPPD, [Out] Vector2 MOJCPHBMHEM, [Out] Vector2 CHINFIJFAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x776BD30", Offset = "0x776AD30", VA = "0x18776BD30", Slot = "14")]
		protected override void FFIIGGDNDBL(Material BIDMCIBAHOL, bool MBINENIOFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x776C2E0", Offset = "0x776B2E0", VA = "0x18776C2E0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Shader MDPKEHFDLBK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader CHADAPBKFOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x776C760", Offset = "0x776B760", VA = "0x18776C760", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x776C710", Offset = "0x776B710", VA = "0x18776C710")]
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
		private SerializableRectTransform BENFEDLOMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool OOIPAKPPMFF;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7766C30", Offset = "0x7765C30", VA = "0x187766C30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7766F10", Offset = "0x7765F10", VA = "0x187766F10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7766DC0", Offset = "0x7765DC0", VA = "0x187766DC0")]
		private void FLALJKMPAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7766E40", Offset = "0x7765E40", VA = "0x187766E40")]
		private void FLNPIMAKDCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JKKAMFDACEA
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct FADAPIBNAKN : IEquatable<FADAPIBNAKN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Component NDMMIOJEOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Action DNJLCEDCOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int JDLLDCAMKOM;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component ALFCFJMDLMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x997960", Offset = "0x996960", VA = "0x180997960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x77646E0", Offset = "0x77636E0", VA = "0x1877646E0")]
		public FADAPIBNAKN(Component NDMMIOJEOEB, Action DNJLCEDCOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7764660", Offset = "0x7763660", VA = "0x187764660")]
		public void IALMCJCIBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x77645C0", Offset = "0x77635C0", VA = "0x1877645C0", Slot = "4")]
		public bool Equals(FADAPIBNAKN DFABCHNPEEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x77645D0", Offset = "0x77635D0", VA = "0x1877645D0", Slot = "0")]
		public override bool Equals(object IFPBFCLBBDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PJFHIAGNFOB : IEnumerator<MIAEKAOKMEH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MIAEKAOKMEH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public JKKAMFDACEA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private MIAEKAOKMEH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD90", Offset = "0x8BAD90", VA = "0x1808BBD90")]
		[DebuggerHidden]
		public PJFHIAGNFOB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7766820", Offset = "0x7765820", VA = "0x187766820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7766BE0", Offset = "0x7765BE0", VA = "0x187766BE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly IGLJHPDFCLG CBDFNHFGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int MLEMNNEAFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int LCFNLAFNAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Func<Component, float> BIJFPKGDGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<Component, FADAPIBNAKN> NKFOBBKIGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<FADAPIBNAKN> LDLKHKHJBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly List<FADAPIBNAKN> NFADBBEEMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private DDGDFMBPLHP CCACPLCNLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private GPDKLGMMOKA DHNCGKNCPOG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private GPDKLGMMOKA KBFHKAAONMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x77653E0", Offset = "0x77643E0", VA = "0x1877653E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7765C10", Offset = "0x7764C10", VA = "0x187765C10")]
	public JKKAMFDACEA(IGLJHPDFCLG CBDFNHFGFAH, int MLEMNNEAFJC = -1, int LCFNLAFNAGK = -1, [Optional] Func<Component, float> BIJFPKGDGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7765550", Offset = "0x7764550", VA = "0x187765550")]
	public void HDAINAGHMLI(Component NDMMIOJEOEB, Action HBPGOBBKEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x77657D0", Offset = "0x77647D0", VA = "0x1877657D0")]
	public void KIOCFIEEJNC(Component NDMMIOJEOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7765470", Offset = "0x7764470", VA = "0x187765470")]
	public bool EDOFGDCIAOL(Component GEICOLLOJJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x77659E0", Offset = "0x77649E0", VA = "0x1877659E0")]
	private void NNIDINFHPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7765960", Offset = "0x7764960", VA = "0x187765960")]
	[IteratorStateMachine(typeof(PJFHIAGNFOB))]
	private IEnumerator<MIAEKAOKMEH> NLLOKBLNCDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x92EDE0", Offset = "0x92DDE0", VA = "0x18092EDE0")]
	[CompilerGenerated]
	private void PLGHMFBKAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x77654D0", Offset = "0x77644D0", VA = "0x1877654D0")]
	[CompilerGenerated]
	private float GANFBLHGMDL(FADAPIBNAKN HBPGOBBKEPK)
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
