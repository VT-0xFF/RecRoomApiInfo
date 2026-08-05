using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
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
				[Cpp2IlInjected.Address(RVA = "0x68AF280", Offset = "0x68ADC80", VA = "0x1868AF280")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x68AF2E0", Offset = "0x68ADCE0", VA = "0x1868AF2E0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x68AF200", Offset = "0x68ADC00", VA = "0x1868AF200")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x68AEF00", Offset = "0x68AD900", VA = "0x1868AEF00")]
			public void PENLEPODFGJ(PointerEventData MIKIHGGJNJM, RectTransform MJNPDNAJJNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x68AEDE0", Offset = "0x68AD7E0", VA = "0x1868AEDE0")]
			public void HMFJBNMNJHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x68AF110", Offset = "0x68ADB10", VA = "0x1868AF110")]
			public void PPHEOAMLBLN(PointerEventData MIKIHGGJNJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x68AED90", Offset = "0x68AD790", VA = "0x1868AED90")]
			public void BPPCDEPABAC(float JCOFBEDBPBJ, RectTransform MJNPDNAJJNF, Vector3 KPEIOCLIHAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly global::PCAPMAFAHIC<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly global::PCAPMAFAHIC<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::PCAPMAFAHIC<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly global::PCAPMAFAHIC<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly global::PCAPMAFAHIC<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly FNCKCCFNKKK PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData NDHHCBIPGPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool HHJMOFKDFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool GEGEHPDPPAL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool FEGDEFGALFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8AD5B0", Offset = "0x8ABFB0", VA = "0x1808AD5B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x68AE4C0", Offset = "0x68ACEC0", VA = "0x1868AE4C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JFLGCIINFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8AD630", Offset = "0x8AC030", VA = "0x1808AD630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x68AE4F0", Offset = "0x68ACEF0", VA = "0x1868AE4F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68AE440", Offset = "0x68ACE40", VA = "0x1868AE440")]
		private bool EKINDECMCLB(PointerEventData MNNEHHHEKKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68AEAA0", Offset = "0x68AD4A0", VA = "0x1868AEAA0", Slot = "5")]
		public void OnPointerDown(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68AEB60", Offset = "0x68AD560", VA = "0x1868AEB60", Slot = "11")]
		public void OnPointerUp(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x68AE810", Offset = "0x68AD210", VA = "0x1868AE810", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68AE520", Offset = "0x68ACF20", VA = "0x1868AE520", Slot = "7")]
		public void OnBeginDrag(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68AE640", Offset = "0x68AD040", VA = "0x1868AE640", Slot = "4")]
		public void OnDrag(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68AE730", Offset = "0x68AD130", VA = "0x1868AE730", Slot = "8")]
		public void OnEndDrag(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68AEB00", Offset = "0x68AD500", VA = "0x1868AEB00", Slot = "9")]
		public void OnPointerEnter(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68AEB30", Offset = "0x68AD530", VA = "0x1868AEB30", Slot = "10")]
		public void OnPointerExit(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68AE600", Offset = "0x68AD000", VA = "0x1868AE600")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68AEBC0", Offset = "0x68AD5C0", VA = "0x1868AEBC0")]
		public UIHandleDecorator()
		{
		}
	}
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private OptionData AHKIJOKOBPC;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x68AA590", Offset = "0x68A8F90", VA = "0x1868AA590", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68AA480", Offset = "0x68A8E80", VA = "0x1868AA480", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68AA3C0", Offset = "0x68A8DC0", VA = "0x1868AA3C0")]
		private void GFNBPCGJJND(GameObject BNNFCOPEFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68AA770", Offset = "0x68A9170", VA = "0x1868AA770")]
		public void SetOptionsWithNoDefault(List<string> FMHMDECCGKB, [Optional] string HCJENPBNEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68AA9B0", Offset = "0x68A93B0", VA = "0x1868AA9B0")]
		public void SetOptionsWithNoDefault(List<OptionData> MIBGOGGBLGL, [Optional] string HCJENPBNEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68AA6A0", Offset = "0x68A90A0", VA = "0x1868AA6A0", Slot = "42")]
		public override void OnPointerClick(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas FMBCEEEIEML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68AAAA0", Offset = "0x68A94A0", VA = "0x1868AAAA0")]
		public Dropdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public class Hideable : MonoBehaviour, ILayoutIgnorer
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class EKDHAPGNNBN : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public EKDHAPGNNBN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x68AAB00", Offset = "0x68A9500", VA = "0x1868AAB00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x68AB020", Offset = "0x68A9A20", VA = "0x1868AB020", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[DOHNIIAADJA(DIMAPHHKBON.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly BHECNCBBLMC MMGKOIMEKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool AFKPHOMKCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? ECEJLKBNBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? FIKBAGENDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? DAPBOICHOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool IOELMJAAAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool FIKGBAEIMKE;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PHHGNHPAAMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x68AC0E0", Offset = "0x68AAAE0", VA = "0x1868AC0E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KNFBHBMPIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x68AC0C0", Offset = "0x68AAAC0", VA = "0x1868AC0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PFIDDCMDFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9D9F70", Offset = "0x9D8970", VA = "0x1809D9F70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68AC2B0", Offset = "0x68AACB0", VA = "0x1868AC2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NKCBCBPGPAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x68AC020", Offset = "0x68AAA20", VA = "0x1868AC020")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x68AC210", Offset = "0x68AAC10", VA = "0x1868AC210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68ABA60", Offset = "0x68AA460", VA = "0x1868ABA60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68ABDF0", Offset = "0x68AA7F0", VA = "0x1868ABDF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68ABB40", Offset = "0x68AA540", VA = "0x1868ABB40")]
		public void Hide(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68ABF30", Offset = "0x68AA930", VA = "0x1868ABF30")]
		public void Show(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68ABE90", Offset = "0x68AA890", VA = "0x1868ABE90")]
		public void Set(object MIFCLBEAOPM, bool POHHJPMBGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68ABC30", Offset = "0x68AA630", VA = "0x1868ABC30")]
		private void KFAMBFAIBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68ABBC0", Offset = "0x68AA5C0", VA = "0x1868ABBC0")]
		[IteratorStateMachine(typeof(EKDHAPGNNBN))]
		private IEnumerator<MEOADLJIECK> JOMKNDHBMPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68ABB00", Offset = "0x68AA500", VA = "0x1868ABB00", Slot = "5")]
		public virtual void DoHideOrShow(bool MJAJOLGGFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68ABFB0", Offset = "0x68AA9B0", VA = "0x1868ABFB0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OGNIIKCDBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72B260", Offset = "0x729C60", VA = "0x18072B260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x74CAD0", Offset = "0x74B4D0", VA = "0x18074CAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> PKOFAKNJCHN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x68AC4A0", Offset = "0x68AAEA0", VA = "0x1868AC4A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x68AC5E0", Offset = "0x68AAFE0", VA = "0x1868AC5E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> HKKBOHNDJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x68AC540", Offset = "0x68AAF40", VA = "0x1868AC540")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x68AC680", Offset = "0x68AB080", VA = "0x1868AC680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68AC3E0", Offset = "0x68AADE0", VA = "0x1868AC3E0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68AC440", Offset = "0x68AAE40", VA = "0x1868AC440", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7D10", Offset = "0x1DF6710", VA = "0x181DF7D10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DF7D10", Offset = "0x1DF6710", VA = "0x181DF7D10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GHKCGNCKINA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum ENKONAKAPLD
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const ENKONAKAPLD GMLNAGJPDCL = ENKONAKAPLD.Light;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string BCEHMMMNEIG = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static ENIMFIBLMKI PJODJDOMJBM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static ENIMFIBLMKI MFKJGOHOLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68AB410", Offset = "0x68A9E10", VA = "0x1868AB410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ENKONAKAPLD BGHLCOKOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68AB550", Offset = "0x68A9F50", VA = "0x1868AB550")]
		get
		{
			return default(ENKONAKAPLD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68AB060", Offset = "0x68A9A60", VA = "0x1868AB060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<ENKONAKAPLD> LCDNONAGLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68AB310", Offset = "0x68A9D10", VA = "0x1868AB310")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68AB210", Offset = "0x68A9C10", VA = "0x1868AB210")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ACGAAGOBMEE : HAIENFHIOAL, AMOHMCNGMID, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	global::NPPEIHJBHGM<GameObject, int> LMANFCPDJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	global::AGNJNOILJEP<GameObject, int, bool> ABGHBLCCDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	global::PCAPMAFAHIC<bool> IKJJFBFIBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool IDDNEMKFIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float FIFAABNGIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	global::PCAPMAFAHIC<float> HIJJGEGGDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FNCKCCFNKKK EOOAPCIIMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SpawnLoadingPlaceholders(GameObject OPBBFNOFOIK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PLALJAJNMKE Spawn<T>(int KGENPAEBDHA, IReadOnlyList<T> HIDEHJGLNHO, GameObject OPBBFNOFOIK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PLALJAJNMKE Spawn<T>(int KGENPAEBDHA, IReadOnlyList<T> HIDEHJGLNHO, GameObject DIKNAMKDKPA, ref Func<int, GameObject> PCKJBJENJLA);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum MFHNIFCLOME : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			LeftToRight = 0,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			RightToLeft = 1,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			TopToBottom = 2,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			BottomToTop = 3,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			CustomDirection = 4,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			RadialOut = 10,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			RadialIn = 11,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			VignetteOut = 20,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			VignetteIn = 21,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Disabled = byte.MaxValue
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int FBGECEENCCJ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<MFHNIFCLOME, string> JKBHHINNOIB;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int CHOGIPDFCNP = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int BAFACFGNPHD;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int IACNFPLBAPF;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int JHLLPLGLHFB;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int EDKMKMJFCJH;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int FLLEKPLEAIA;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int EABOKKEAFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool MNADCCEFKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool EEKJFLCBHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Color[] OANAMDCKKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private MFHNIFCLOME type;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly MFHNIFCLOME[] EGPEOIKDMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[MNCHKJFLKIP("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly MFHNIFCLOME[] HAHHNODNNGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[MNCHKJFLKIP("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[Range(0f, 360f)]
		[MNCHKJFLKIP("type", (byte)4)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[MNCHKJFLKIP("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic OEIKLABGGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool NFMKJKIEANG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient HIHAAKOAHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7270F0", Offset = "0x725AF0", VA = "0x1807270F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x68AE290", Offset = "0x68ACC90", VA = "0x1868AE290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MFHNIFCLOME BELDJPAAHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x13FB6E0", Offset = "0x13FA0E0", VA = "0x1813FB6E0")]
			get
			{
				return default(MFHNIFCLOME);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x68AE410", Offset = "0x68ACE10", VA = "0x1868AE410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool MEJHDOIIIKH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x68ADD00", Offset = "0x68AC700", VA = "0x1868ADD00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 EJKEKPKBIPK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x68AE220", Offset = "0x68ACC20", VA = "0x1868AE220")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x68AE240", Offset = "0x68ACC40", VA = "0x1868AE240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool EGJNNKHNPKG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x68ACF90", Offset = "0x68AB990", VA = "0x1868ACF90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 GIDKIJHPLDC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6634120", Offset = "0x6632B20", VA = "0x186634120")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x68AE3C0", Offset = "0x68ACDC0", VA = "0x1868AE3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float HLPHPEAMDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1DCA150", Offset = "0x1DC8B50", VA = "0x181DCA150")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1DCA2A0", Offset = "0x1DC8CA0", VA = "0x181DCA2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 JCDMIAAFHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x68AD190", Offset = "0x68ABB90", VA = "0x1868AD190")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 ABLPCDJFEIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x68AD8E0", Offset = "0x68AC2E0", VA = "0x1868AD8E0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MMGHFIILFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x16C43F0", Offset = "0x16C2DF0", VA = "0x1816C43F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x68AE420", Offset = "0x68ACE20", VA = "0x1868AE420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68AD010", Offset = "0x68ABA10", VA = "0x1868AD010", Slot = "12")]
		protected override void BFNLGEBNFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x68AD970", Offset = "0x68AC370", VA = "0x1868AD970")]
		private void HNOBBLCCNJM(Color[] BFHCCIPGFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68AD1E0", Offset = "0x68ABBE0", VA = "0x1868AD1E0", Slot = "13")]
		protected override void CHKAAFNODND(Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68ADAE0", Offset = "0x68AC4E0", VA = "0x1868ADAE0", Slot = "14")]
		protected override void LBKGCHIHEPG(Material NIFEJPCAIBK, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68AE160", Offset = "0x68ACB60", VA = "0x1868AE160")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly CDBELLKJENP EEMDOKPHGOC;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static Sprite BECGKBHGMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Material PMGKPGOGDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material MDBALCJOILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool PNCAMOHCCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool AFKPHOMKCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool JGGDBCFIMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool HGBDLJEEOMI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic OEIKLABGGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader KBFMOLHPELJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool NFMKJKIEANG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool PJJANGBBPLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform MJNPDNAJJNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x68B04F0", Offset = "0x68AEEF0", VA = "0x1868B04F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect HLFNIMKLADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x68AF990", Offset = "0x68AE390", VA = "0x1868AF990")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite JLACLEJNCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x68AFC40", Offset = "0x68AE640", VA = "0x1868AFC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68AF390", Offset = "0x68ADD90", VA = "0x1868AF390", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68B01C0", Offset = "0x68AEBC0", VA = "0x1868B01C0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68B04E0", Offset = "0x68AEEE0", VA = "0x1868B04E0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68B0370", Offset = "0x68AED70", VA = "0x1868B0370", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68AFAC0", Offset = "0x68AE4C0", VA = "0x1868AFAC0")]
		private void JGLMOCFHIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68B0550", Offset = "0x68AEF50", VA = "0x1868B0550")]
		private void PIICLHBGFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68AF580", Offset = "0x68ADF80", VA = "0x1868AF580")]
		private void BOOEOBNICAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68AF5B0", Offset = "0x68ADFB0", VA = "0x1868AF5B0")]
		private void FIGBBEFBGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68AFF50", Offset = "0x68AE950", VA = "0x1868AFF50")]
		protected void OOPIHCGHGEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68AFE10", Offset = "0x68AE810", VA = "0x1868AFE10")]
		private void NKFMNPOHABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "12")]
		protected virtual void BFNLGEBNFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "13")]
		protected virtual void CHKAAFNODND(Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "14")]
		protected virtual void LBKGCHIHEPG(Material NIFEJPCAIBK, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68AF600", Offset = "0x68AE000", VA = "0x1868AF600")]
		private void ICHHLFJMPGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		[Conditional("RRUI_PROFILING")]
		protected void DJFBPGDIIFK(string IFCELFAKOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		[Conditional("RRUI_PROFILING")]
		protected void BMEKCCMAGJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		protected UIMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Rings", 15)]
	public class UIRings : UIUberMaterialOverride
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct RingLayer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[SerializeField]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x2247B0", Offset = "0x223BB0")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int HOLLNLEAGKL;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int IKKEAOELKNB;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int HNHKMOHKONL;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int AOGLDCCALLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private Color[] OANAMDCKKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private float[] FDPBAKEINIE;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic OEIKLABGGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool PJJANGBBPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> FKDBBAHJPDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 EJKEKPKBIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x47EE360", Offset = "0x47ECD60", VA = "0x1847EE360")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x68B1080", Offset = "0x68AFA80", VA = "0x1868B1080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68B0D80", Offset = "0x68AF780", VA = "0x1868B0D80")]
		public void SetRingLayers(IReadOnlyList<RingLayer> MDIDMACPFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x68B0B60", Offset = "0x68AF560", VA = "0x1868B0B60")]
		public bool SetRingLayerColor(int MHMKDHJAPNM, Color HAFGGBNGKBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x68B0C70", Offset = "0x68AF670", VA = "0x1868B0C70")]
		public bool SetRingLayerSize(int MHMKDHJAPNM, float GBNBGNMHGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x68B0820", Offset = "0x68AF220", VA = "0x1868B0820", Slot = "12")]
		protected override void BFNLGEBNFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x68B0990", Offset = "0x68AF390", VA = "0x1868B0990", Slot = "13")]
		protected override void CHKAAFNODND(Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x68B0B10", Offset = "0x68AF510", VA = "0x1868B0B10", Slot = "14")]
		protected override void LBKGCHIHEPG(Material NIFEJPCAIBK, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x68B0ED0", Offset = "0x68AF8D0", VA = "0x1868B0ED0")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Tiler", 15)]
	public class UITiler : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum AFFJAHCPBKP
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int GCDHHIBFHOO;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int EDPAJMNCGPH;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int CFKFGFHOBCF;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int LIPANDCJPPM;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int CDIAFMHKJCO;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int BCGJHGGFPAN;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int IOOAHDAEIFF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int AOGNFKBKPFI;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int PFJLDGOPLBB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int NGMAHHLPNDO;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int IPKIMKOAMNI;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int HMJOPHBHEHK;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int FGACAMMHCGD;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int GHLKCDACAKI;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int KIGINMAPMFG;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int GDFJEJJMAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Tooltip("The offset applied to each alternating row or column.")]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private AFFJAHCPBKP animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[MNCHKJFLKIP("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[MNCHKJFLKIP("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic OEIKLABGGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool PJJANGBBPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite CEFJAOHOMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x68B1E50", Offset = "0x68B0850", VA = "0x1868B1E50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x68B2060", Offset = "0x68B0A60", VA = "0x1868B2060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color AINPEJMFNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xEF89E0", Offset = "0xEF73E0", VA = "0x180EF89E0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x68B2100", Offset = "0x68B0B00", VA = "0x1868B2100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color PKIBCMHLOGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA4E110", Offset = "0xA4CB10", VA = "0x180A4E110")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x68B1F50", Offset = "0x68B0950", VA = "0x1868B1F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float HDCJHLKPPBC
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x153E1C0", Offset = "0x153CBC0", VA = "0x18153E1C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x68B1FF0", Offset = "0x68B09F0", VA = "0x1868B1FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 JHFCDKEEFNB
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1459F80", Offset = "0x1458980", VA = "0x181459F80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x68B2010", Offset = "0x68B0A10", VA = "0x1868B2010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float JHMJCAFAEBB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x290D8D0", Offset = "0x290C2D0", VA = "0x18290D8D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x68B1FB0", Offset = "0x68B09B0", VA = "0x1868B1FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 IOPOCJKJEGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x255AE00", Offset = "0x2559800", VA = "0x18255AE00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x68B2160", Offset = "0x68B0B60", VA = "0x1868B2160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float HEGIPIFFHKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x184A410", Offset = "0x1848E10", VA = "0x18184A410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x68B1F20", Offset = "0x68B0920", VA = "0x1868B1F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 IBNJMGKMPIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x68B1790", Offset = "0x68B0190", VA = "0x1868B1790")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AFFJAHCPBKP FFHFDKEJEBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x924280", Offset = "0x922C80", VA = "0x180924280")]
			get
			{
				return default(AFFJAHCPBKP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x68B1F40", Offset = "0x68B0940", VA = "0x1868B1F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float HCHLBNICNJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x17EFFB0", Offset = "0x17EE9B0", VA = "0x1817EFFB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x68B1FD0", Offset = "0x68B09D0", VA = "0x1868B1FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float EOMBOOAEELN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1459F30", Offset = "0x1458930", VA = "0x181459F30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x68B1F00", Offset = "0x68B0900", VA = "0x1868B1F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68B10D0", Offset = "0x68AFAD0", VA = "0x1868B10D0", Slot = "13")]
		protected override void CHKAAFNODND(Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68B1800", Offset = "0x68B0200", VA = "0x1868B1800")]
		private void JDINIDJFIDG(Sprite CBBEKKLCOBK, out Vector2 FKNOIJFLJCL, out Vector2 NFHHKJIIAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68B1A80", Offset = "0x68B0480", VA = "0x1868B1A80", Slot = "14")]
		protected override void LBKGCHIHEPG(Material NIFEJPCAIBK, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x68B1DB0", Offset = "0x68B07B0", VA = "0x1868B1DB0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static Shader FCAOKAEMBIB;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader KBFMOLHPELJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x68B2210", Offset = "0x68B0C10", VA = "0x1868B2210", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68B21B0", Offset = "0x68B0BB0", VA = "0x1868B21B0")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CDBELLKJENP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct PJJIHJGOPID : IEquatable<PJJIHJGOPID>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly Component PKDAKJPDDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly Action KOEAMGEFJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly int LHDMIKPLGFA;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component FDIDBDKBNDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7519F0", Offset = "0x7503F0", VA = "0x1807519F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x68ACE70", Offset = "0x68AB870", VA = "0x1868ACE70")]
		public PJJIHJGOPID(Component PKDAKJPDDGD, Action KOEAMGEFJNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x68ACDF0", Offset = "0x68AB7F0", VA = "0x1868ACDF0")]
		public void JIPFIFODDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x68ACDE0", Offset = "0x68AB7E0", VA = "0x1868ACDE0", Slot = "4")]
		public bool Equals(PJJIHJGOPID MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD50", Offset = "0x68AB750", VA = "0x1868ACD50", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class GKHBCLDOPFP : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private MEOADLJIECK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CDBELLKJENP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
		[DebuggerHidden]
		public GKHBCLDOPFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68AB6F0", Offset = "0x68AA0F0", VA = "0x1868AB6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x68ABA20", Offset = "0x68AA420", VA = "0x1868ABA20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int MELJJINAEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly int GLJIBIMMNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Func<Component, float> LIGIGBKGDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<Component, PJJIHJGOPID> OLCGGILNINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LinkedList<PJJIHJGOPID> EEODGEJLKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<PJJIHJGOPID> AGLAPIJEDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private GNGMNANCADP EONPPNNLLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private IENDINBAIFO ONHCDMKPJMD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private IENDINBAIFO GADIGCKIJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x68A9C60", Offset = "0x68A8660", VA = "0x1868A9C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x68AA260", Offset = "0x68A8C60", VA = "0x1868AA260")]
	public CDBELLKJENP(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, int MELJJINAEEE = -1, int GLJIBIMMNLK = -1, [Optional] Func<Component, float> LIGIGBKGDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x68A9F30", Offset = "0x68A8930", VA = "0x1868A9F30")]
	public void OMJIGLLBDMJ(Component PKDAKJPDDGD, Action FFDDMJBLHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x68A9D40", Offset = "0x68A8740", VA = "0x1868A9D40")]
	public void FLPNBHIFPAD(Component PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x68A9ED0", Offset = "0x68A88D0", VA = "0x1868A9ED0")]
	public bool LMCAGAEFJGG(Component AFCHMEJMNBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x68A9A30", Offset = "0x68A8430", VA = "0x1868A9A30")]
	private void DCDMHJGONKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x68A9CD0", Offset = "0x68A86D0", VA = "0x1868A9CD0")]
	[IteratorStateMachine(typeof(GKHBCLDOPFP))]
	private IEnumerator<MEOADLJIECK> FCKMHMAMFIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x14DBB50", Offset = "0x14DA550", VA = "0x1814DBB50")]
	[CompilerGenerated]
	private void EEBOGFCNOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x68AA1A0", Offset = "0x68A8BA0", VA = "0x1868AA1A0")]
	[CompilerGenerated]
	private float PPMPALIPOKJ(PJJIHJGOPID FFDDMJBLHEA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DBEOLCKJMAF
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BNOOOCAMEBF
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JLFFIPNNCIP BBFBHGDDGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool MGDJLIIMLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	global::PCAPMAFAHIC<JLFFIPNNCIP> NKAFHONBJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLDOEPLNJHK(JLFFIPNNCIP LHJIKONPIFJ, bool DLFDOCDGGDI = false);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x68ACA70", Offset = "0x68AB470", VA = "0x1868ACA70")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68AC720", Offset = "0x68AB120", VA = "0x1868AC720")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
