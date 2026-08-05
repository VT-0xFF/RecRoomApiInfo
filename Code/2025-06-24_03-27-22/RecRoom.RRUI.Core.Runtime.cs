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
				[Cpp2IlInjected.Address(RVA = "0x8818050", Offset = "0x8816C50", VA = "0x188818050")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x88180B0", Offset = "0x8816CB0", VA = "0x1888180B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8818010", Offset = "0x8816C10", VA = "0x188818010")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8817F10", Offset = "0x8816B10", VA = "0x188817F10")]
			public void PBCBMECHDJB(PointerEventData PNPPDDMJOHK, RectTransform ACKLJFLAOJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8817C80", Offset = "0x8816880", VA = "0x188817C80")]
			public void MIFBEEDAHJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8817BA0", Offset = "0x88167A0", VA = "0x188817BA0")]
			public void IFMJNDLJJAK(PointerEventData PNPPDDMJOHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8817B50", Offset = "0x8816750", VA = "0x188817B50")]
			public void EBHBHONNJED(float OPHAEDMLONH, RectTransform ACKLJFLAOJB, Vector3 MICNLECKIBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly PJAJEBBNNBK<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly PJAJEBBNNBK<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly PJAJEBBNNBK<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly PJAJEBBNNBK<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly PJAJEBBNNBK<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HBAAEHCBNNO PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData IDGEDEJIMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool AIBLENIBOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool BLPJBPMIPCF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GOLBDKLPLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA24790", Offset = "0xA23390", VA = "0x180A24790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8817390", Offset = "0x8815F90", VA = "0x188817390")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool COMHHILNDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA247D0", Offset = "0xA233D0", VA = "0x180A247D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x88172E0", Offset = "0x8815EE0", VA = "0x1888172E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8817310", Offset = "0x8815F10", VA = "0x188817310")]
		private bool JJDLCGIJOLF(PointerEventData AGFKEDPOHKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8817810", Offset = "0x8816410", VA = "0x188817810", Slot = "5")]
		public void OnPointerDown(PointerEventData AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88178D0", Offset = "0x88164D0", VA = "0x1888178D0", Slot = "11")]
		public void OnPointerUp(PointerEventData AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8817680", Offset = "0x8816280", VA = "0x188817680", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88173C0", Offset = "0x8815FC0", VA = "0x1888173C0", Slot = "7")]
		public void OnBeginDrag(PointerEventData AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88174D0", Offset = "0x88160D0", VA = "0x1888174D0", Slot = "4")]
		public void OnDrag(PointerEventData AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88175B0", Offset = "0x88161B0", VA = "0x1888175B0", Slot = "8")]
		public void OnEndDrag(PointerEventData AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8817870", Offset = "0x8816470", VA = "0x188817870", Slot = "9")]
		public void OnPointerEnter(PointerEventData AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88178A0", Offset = "0x88164A0", VA = "0x1888178A0", Slot = "10")]
		public void OnPointerExit(PointerEventData AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8817490", Offset = "0x8816090", VA = "0x188817490")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8817930", Offset = "0x8816530", VA = "0x188817930")]
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
		[Cpp2IlInjected.Address(RVA = "0x8812C60", Offset = "0x8811860", VA = "0x188812C60")]
		public void SetCanvasSortingOrder(short LNLOAEDHFEO, bool LOFHNIBAFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData JKJIEHCFGNF;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8813820", Offset = "0x8812420", VA = "0x188813820", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8813700", Offset = "0x8812300", VA = "0x188813700", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8813A10", Offset = "0x8812610", VA = "0x188813A10")]
		private void PKJGLOGMAGP(GameObject APMFNJIBPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8813BB0", Offset = "0x88127B0", VA = "0x188813BB0")]
		public void SetOptionsWithNoDefault(List<string> AIPJHMCGMIB, [Optional] string KGALAAIMDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8813AC0", Offset = "0x88126C0", VA = "0x188813AC0")]
		public void SetOptionsWithNoDefault(List<OptionData> LEKHKJDBHCI, [Optional] string KGALAAIMDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8813940", Offset = "0x8812540", VA = "0x188813940", Slot = "43")]
		public override void OnPointerClick(PointerEventData AGFKEDPOHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "46")]
		protected override GameObject CreateBlocker(Canvas LBLPECJLMAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8813DD0", Offset = "0x88129D0", VA = "0x188813DD0")]
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
		private sealed class JLIJKHMFMHI : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private FCPCPCAPDCM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
			[DebuggerHidden]
			public JLIJKHMFMHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x88147B0", Offset = "0x88133B0", VA = "0x1888147B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8814CC0", Offset = "0x88138C0", VA = "0x188814CC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[MHLPBMEFLGC(EBAHNMNBCJP.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly OOMLIBALPOA<object> KGBGPIKAGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool FFFHHLLDIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? BCPIEKNNODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? BCLJBJLKPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? LKNIMMPKBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool AJHICOAMFCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool ENDGNGKNFLM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NLGFAKMCCOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88144D0", Offset = "0x88130D0", VA = "0x1888144D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool DIPPHFAHFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8814480", Offset = "0x8813080", VA = "0x188814480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PNGJDFGLHFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA6A640", Offset = "0xA69240", VA = "0x180A6A640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8814690", Offset = "0x8813290", VA = "0x188814690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AMLPKLFDFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x88143E0", Offset = "0x8812FE0", VA = "0x1888143E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x88145F0", Offset = "0x88131F0", VA = "0x1888145F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8813E20", Offset = "0x8812A20", VA = "0x188813E20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8814040", Offset = "0x8812C40", VA = "0x188814040")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8813FF0", Offset = "0x8812BF0", VA = "0x188813FF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8813F60", Offset = "0x8812B60", VA = "0x188813F60")]
		public void Hide(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8814340", Offset = "0x8812F40", VA = "0x188814340")]
		public void Show(object HEDGIMBCGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8814250", Offset = "0x8812E50", VA = "0x188814250")]
		public void Set(object HEDGIMBCGHA, bool HGEJEFJPBML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8813EB0", Offset = "0x8812AB0", VA = "0x188813EB0")]
		public void Clear(bool OOODEBHGMIA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88140D0", Offset = "0x8812CD0", VA = "0x1888140D0")]
		private void PPGCGLMIMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8813F70", Offset = "0x8812B70", VA = "0x188813F70")]
		[IteratorStateMachine(typeof(JLIJKHMFMHI))]
		private IEnumerator<FCPCPCAPDCM> NANEFNGCCBB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8813F20", Offset = "0x8812B20", VA = "0x188813F20", Slot = "5")]
		public virtual void DoHideOrShow(bool BOHJJGIMCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8814350", Offset = "0x8812F50", VA = "0x188814350")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OJMHLMFKBHO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum JBBNBMEIJHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static HOCDMBIPNHL FMLBIMALGCM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static HOCDMBIPNHL CNLLMNNCGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88151F0", Offset = "0x8813DF0", VA = "0x1888151F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static JBBNBMEIJHK CGCAKIDHKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88152F0", Offset = "0x8813EF0", VA = "0x1888152F0")]
		get
		{
			return default(JBBNBMEIJHK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88154F0", Offset = "0x88140F0", VA = "0x1888154F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<JBBNBMEIJHK> JIKPPNMKHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8815120", Offset = "0x8813D20", VA = "0x188815120")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8815420", Offset = "0x8814020", VA = "0x188815420")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PHPOBKHPMBG : OKPCAEFAJNM, HNDMBFHAHFI, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, CCLIBCOHECA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HBAAEHCBNNO EIEKCJPAPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LKEMGHMAMLP Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject DNPJNJCBEBE);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LKEMGHMAMLP Spawn<T>(int BDOMDKIDLPA, IReadOnlyList<T> PEDMEJIDLNB, GameObject DNPJNJCBEBE);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LKEMGHMAMLP Spawn<T>(int BDOMDKIDLPA, IReadOnlyList<T> PEDMEJIDLNB, GameObject PACGOELFJJN, Func<int, GameObject> BPHPDDGMPAE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int EMMACFPOKFB, float IPDLCOLDJGI);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum ACEILCGOCAK : byte
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
		private static readonly int CENFLBOLBMK;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<ACEILCGOCAK, string> OKKEENAHLHK;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int GBNLHMJHIEC = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int CCPNJHGNKDI;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int LAICJFENHGF;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int DOIKIBGPANM;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int LKBNMELDLLM;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int ONELDCAGPAD;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int EFLKHOAJEMC;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int EFNIOLDJILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool KPDOBAIKFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool OFNGIHFACJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] IGLPMNIHNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private ACEILCGOCAK type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly ACEILCGOCAK[] GJLFLEEBPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[IGPOEKCGNGE("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly ACEILCGOCAK[] IFIDOLBEDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[IGPOEKCGNGE("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[IGPOEKCGNGE("type", ACEILCGOCAK.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[IGPOEKCGNGE("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic BPCMBPBAADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool PBPPOLDOIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient DBIOLHABBAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8817130", Offset = "0x8815D30", VA = "0x188817130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ACEILCGOCAK JKOHHHGJLLP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD0ED10", Offset = "0xD0D910", VA = "0x180D0ED10")]
			get
			{
				return default(ACEILCGOCAK);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x88172B0", Offset = "0x8815EB0", VA = "0x1888172B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool FPOPIOCKLGK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8815D90", Offset = "0x8814990", VA = "0x188815D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 BDADCNMGKGC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88170A0", Offset = "0x8815CA0", VA = "0x1888170A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x88170E0", Offset = "0x8815CE0", VA = "0x1888170E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool JLEDBGNKMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8815CB0", Offset = "0x88148B0", VA = "0x188815CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 KFBJOMJJKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x88170C0", Offset = "0x8815CC0", VA = "0x1888170C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8817260", Offset = "0x8815E60", VA = "0x188817260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GLAHLGAKKDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD26CA0", Offset = "0xD258A0", VA = "0x180D26CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x235D840", Offset = "0x235C440", VA = "0x18235D840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 NMKLHECNMHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8815F90", Offset = "0x8814B90", VA = "0x188815F90")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 HENDGLJMNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8815D20", Offset = "0x8814920", VA = "0x188815D20")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float KCLNDOLGBEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA38740", Offset = "0xA37340", VA = "0x180A38740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x88172C0", Offset = "0x8815EC0", VA = "0x1888172C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8815B10", Offset = "0x8814710", VA = "0x188815B10", Slot = "12")]
		protected override void CGPAOONMKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8815E00", Offset = "0x8814A00", VA = "0x188815E00")]
		private void IHMMFMOKGCJ(Color[] GNEJLECEADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8815FE0", Offset = "0x8814BE0", VA = "0x188815FE0", Slot = "13")]
		protected override void KIGMKCBILHP(Material IMKAMKEPJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88169F0", Offset = "0x88155F0", VA = "0x1888169F0", Slot = "14")]
		protected override void ODFKHDDELLI(Material IMKAMKEPJBL, bool DAMJJNFLPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8816FF0", Offset = "0x8815BF0", VA = "0x188816FF0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly DJBPCGGGCEN HOALDMDODLJ;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite JNFBLDJNCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material MPHEHHEJGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material EKIHHOIIIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool AAJIFFAICKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool FFFHHLLDIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool BPFDOIPLHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool DMKGJCCOPCC;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic BPCMBPBAADI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader MHFLMLOMNFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool PBPPOLDOIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool AKKAFAKLBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform ACKLJFLAOJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8818EB0", Offset = "0x8817AB0", VA = "0x188818EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect GEPNECMGELI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8819450", Offset = "0x8818050", VA = "0x188819450")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite NKHJNJAIPMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8818F10", Offset = "0x8817B10", VA = "0x188818F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8818430", Offset = "0x8817030", VA = "0x188818430", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8819140", Offset = "0x8817D40", VA = "0x188819140", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8819440", Offset = "0x8818040", VA = "0x188819440", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x88192F0", Offset = "0x8817EF0", VA = "0x1888192F0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x88182A0", Offset = "0x8816EA0", VA = "0x1888182A0")]
		private void AAPPBIKOKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8818620", Offset = "0x8817220", VA = "0x188818620")]
		private void BKEHOFFLLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8818E80", Offset = "0x8817A80", VA = "0x188818E80")]
		private void JMEBNKGNAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x88190F0", Offset = "0x8817CF0", VA = "0x1888190F0")]
		private void ONDPLONNCJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8818C20", Offset = "0x8817820", VA = "0x188818C20")]
		protected void JLGMCFCKFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8818AE0", Offset = "0x88176E0", VA = "0x188818AE0")]
		private void HEGKBOIEDCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "12")]
		protected virtual void CGPAOONMKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "13")]
		protected virtual void KIGMKCBILHP(Material IMKAMKEPJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "14")]
		protected virtual void ODFKHDDELLI(Material IMKAMKEPJBL, bool DAMJJNFLPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8818790", Offset = "0x8817390", VA = "0x188818790")]
		private void CMCINJPHJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
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
		private static readonly int GNLCLOHEFCE;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int KPECLIPDMDN;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int GEMADBOOAHM;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int IPMOCBMILKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
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
		private Color[] IGLPMNIHNNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] HNNFCOIBPNI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic BPCMBPBAADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool AKKAFAKLBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> FJKFIAIOGPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 BDADCNMGKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3003220", Offset = "0x3001E20", VA = "0x183003220")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x881A010", Offset = "0x8818C10", VA = "0x18881A010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8819C50", Offset = "0x8818850", VA = "0x188819C50")]
		public void SetRingLayers(IReadOnlyList<RingLayer> BGCNGHBCDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8819A10", Offset = "0x8818610", VA = "0x188819A10")]
		public bool SetRingLayerColor(int EFIHPJLECIH, Color GCKOLKABAJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8819B60", Offset = "0x8818760", VA = "0x188819B60")]
		public bool SetRingLayerSize(int EFIHPJLECIH, float DKFJGBGJGBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8819710", Offset = "0x8818310", VA = "0x188819710", Slot = "12")]
		protected override void CGPAOONMKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8819850", Offset = "0x8818450", VA = "0x188819850", Slot = "13")]
		protected override void KIGMKCBILHP(Material IMKAMKEPJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x88199C0", Offset = "0x88185C0", VA = "0x1888199C0", Slot = "14")]
		protected override void ODFKHDDELLI(Material IMKAMKEPJBL, bool DAMJJNFLPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8819DA0", Offset = "0x88189A0", VA = "0x188819DA0")]
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
		public enum DJKMHBDEPNC
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int GGMNDBAILKJ;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int JJGFAJNAANF;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int LLPPMNLECEP;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int KJFPDDEEAPB;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int PKEAAMCKJLN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int FNIMNEIHOIF;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int FPGALLLADLI;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int LNONJMDCMFL;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int MKBLEEJHJFH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int HDAKLPEEKBF;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int LLEHBNKBELF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int HIFOEFBEEAL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int FAKECCJCCOK;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int JABPOCEFJBH;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int IBKPNHFGAHG;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int OFGBAGJEHFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
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
		private DJKMHBDEPNC animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[IGPOEKCGNGE("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[IGPOEKCGNGE("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic BPCMBPBAADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool AKKAFAKLBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite IDCONBMOEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x881AE10", Offset = "0x8819A10", VA = "0x18881AE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x881B030", Offset = "0x8819C30", VA = "0x18881B030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color BEMFABNKJOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF7EB20", Offset = "0xF7D720", VA = "0x180F7EB20")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x881B0C0", Offset = "0x8819CC0", VA = "0x18881B0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color IGMKEODHLEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1161220", Offset = "0x115FE20", VA = "0x181161220")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x881AF00", Offset = "0x8819B00", VA = "0x18881AF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float MKGEHMPJMKO
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD26E20", Offset = "0xD25A20", VA = "0x180D26E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x881AFC0", Offset = "0x8819BC0", VA = "0x18881AFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 EJCOLDCJKPD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x881ADF0", Offset = "0x88199F0", VA = "0x18881ADF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x881AFE0", Offset = "0x8819BE0", VA = "0x18881AFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float DMBCPOGLMHC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA383A0", Offset = "0xA36FA0", VA = "0x180A383A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x881AF80", Offset = "0x8819B80", VA = "0x18881AF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 CEJMFOHBDMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x165C3E0", Offset = "0x165AFE0", VA = "0x18165C3E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x881B140", Offset = "0x8819D40", VA = "0x18881B140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float IAGBGKBHAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x114D1E0", Offset = "0x114BDE0", VA = "0x18114D1E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x881AED0", Offset = "0x8819AD0", VA = "0x18881AED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 BEALDDOCOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x881A310", Offset = "0x8818F10", VA = "0x18881A310")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public DJKMHBDEPNC OOAALADCMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xEFAC20", Offset = "0xEF9820", VA = "0x180EFAC20")]
			get
			{
				return default(DJKMHBDEPNC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x881AEF0", Offset = "0x8819AF0", VA = "0x18881AEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float MOJCNBHNFBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x17F8FF0", Offset = "0x17F7BF0", VA = "0x1817F8FF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x881AFA0", Offset = "0x8819BA0", VA = "0x18881AFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float ENDPBEOPGIB
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1798A00", Offset = "0x1797600", VA = "0x181798A00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x881AEB0", Offset = "0x8819AB0", VA = "0x18881AEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x881A3A0", Offset = "0x8818FA0", VA = "0x18881A3A0", Slot = "13")]
		protected override void KIGMKCBILHP(Material IMKAMKEPJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x881A060", Offset = "0x8818C60", VA = "0x18881A060")]
		private void CGKCCCPJECI(Sprite GDMMNKKLCOJ, [Out] Vector2 PAEKGNOHNED, [Out] Vector2 NAIOPLGENPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x881AA60", Offset = "0x8819660", VA = "0x18881AA60", Slot = "14")]
		protected override void ODFKHDDELLI(Material IMKAMKEPJBL, bool DAMJJNFLPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x881AD60", Offset = "0x8819960", VA = "0x18881AD60")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader GFMNFNDFIBF;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader MHFLMLOMNFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x881B1E0", Offset = "0x8819DE0", VA = "0x18881B1E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x881B190", Offset = "0x8819D90", VA = "0x18881B190")]
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
		private SerializableRectTransform JHHPBFHDMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool GPFBIGABBBI;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8815650", Offset = "0x8814250", VA = "0x188815650")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8815860", Offset = "0x8814460", VA = "0x188815860")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x88157E0", Offset = "0x88143E0", VA = "0x1888157E0")]
		private void NINLPGNKFJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8815970", Offset = "0x8814570", VA = "0x188815970")]
		private void PPGCGLMIMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DJBPCGGGCEN
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct AKAAHEGIMBL : IEquatable<AKAAHEGIMBL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component CBLPKFIJGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action NPOFGMFNGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int MONPHMAIPDJ;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component AKIOFALGPCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8812BF0", Offset = "0x88117F0", VA = "0x188812BF0")]
		public AKAAHEGIMBL(Component CBLPKFIJGLH, Action NPOFGMFNGLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8812B70", Offset = "0x8811770", VA = "0x188812B70")]
		public void LGHBMANLFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8812AD0", Offset = "0x88116D0", VA = "0x188812AD0", Slot = "4")]
		public bool Equals(AKAAHEGIMBL GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8812AE0", Offset = "0x88116E0", VA = "0x188812AE0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LLMFIFAMLEJ : IEnumerator<FCPCPCAPDCM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private FCPCPCAPDCM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DJBPCGGGCEN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private FCPCPCAPDCM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA1FD90", Offset = "0xA1E990", VA = "0x180A1FD90")]
		[DebuggerHidden]
		public LLMFIFAMLEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8814D10", Offset = "0x8813910", VA = "0x188814D10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x88150D0", Offset = "0x8813CD0", VA = "0x1888150D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GEPHJDONOHJ OBNGFOLADNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int MGHFDPMBHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int IIKDKABDOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> PFOPLNDBMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, AKAAHEGIMBL> IIDDELOBAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<AKAAHEGIMBL> JCGCEJMOKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<AKAAHEGIMBL> JEHGCIACIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private GCBFJNEKOIO DCEONGPPDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NFGJHGBPOHN EJJJBFCMDIO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private NFGJHGBPOHN BMNBJLFOKLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8812FC0", Offset = "0x8811BC0", VA = "0x188812FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8813580", Offset = "0x8812180", VA = "0x188813580")]
	public DJBPCGGGCEN(GEPHJDONOHJ OBNGFOLADNN, int MGHFDPMBHKD = -1, int IIKDKABDOIP = -1, [Optional] Func<Component, float> PFOPLNDBMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8813300", Offset = "0x8811F00", VA = "0x188813300")]
	public void OPMGKAEAFIH(Component CBLPKFIJGLH, Action JLJMNCGIOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8812DD0", Offset = "0x88119D0", VA = "0x188812DD0")]
	public void DGGCJHHFHBI(Component CBLPKFIJGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8812F60", Offset = "0x8811B60", VA = "0x188812F60")]
	public bool DJBANDAEFNO(Component LBEOEMMCAFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x88130D0", Offset = "0x8811CD0", VA = "0x1888130D0")]
	private void NACLFFCFFKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8813050", Offset = "0x8811C50", VA = "0x188813050")]
	[IteratorStateMachine(typeof(LLMFIFAMLEJ))]
	private IEnumerator<FCPCPCAPDCM> GDHMAOFEFGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xE7C8C0", Offset = "0xE7B4C0", VA = "0x180E7C8C0")]
	[CompilerGenerated]
	private void GLPIFGFPBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8812D50", Offset = "0x8811950", VA = "0x188812D50")]
	[CompilerGenerated]
	private float BPODMPFCLJJ(AKAAHEGIMBL JLJMNCGIOCA)
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
