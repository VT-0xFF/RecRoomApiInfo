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
				[Cpp2IlInjected.Address(RVA = "0x68DDE10", Offset = "0x68DD210", VA = "0x1868DDE10")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x68DDE70", Offset = "0x68DD270", VA = "0x1868DDE70")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x68DDD90", Offset = "0x68DD190", VA = "0x1868DDD90")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x68DDA90", Offset = "0x68DCE90", VA = "0x1868DDA90")]
			public void PENLEPODFGJ(PointerEventData MIKIHGGJNJM, RectTransform MJNPDNAJJNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x68DD970", Offset = "0x68DCD70", VA = "0x1868DD970")]
			public void HMFJBNMNJHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x68DDCA0", Offset = "0x68DD0A0", VA = "0x1868DDCA0")]
			public void PPHEOAMLBLN(PointerEventData MIKIHGGJNJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x68DD920", Offset = "0x68DCD20", VA = "0x1868DD920")]
			public void BPPCDEPABAC(float JCOFBEDBPBJ, RectTransform MJNPDNAJJNF, Vector3 KPEIOCLIHAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
			[Cpp2IlInjected.Address(RVA = "0x8833A0", Offset = "0x8827A0", VA = "0x1808833A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x68DD050", Offset = "0x68DC450", VA = "0x1868DD050")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JFLGCIINFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x883420", Offset = "0x882820", VA = "0x180883420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x68DD080", Offset = "0x68DC480", VA = "0x1868DD080")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68DCFD0", Offset = "0x68DC3D0", VA = "0x1868DCFD0")]
		private bool EKINDECMCLB(PointerEventData MNNEHHHEKKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68DD630", Offset = "0x68DCA30", VA = "0x1868DD630", Slot = "5")]
		public void OnPointerDown(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68DD6F0", Offset = "0x68DCAF0", VA = "0x1868DD6F0", Slot = "11")]
		public void OnPointerUp(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x68DD3A0", Offset = "0x68DC7A0", VA = "0x1868DD3A0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68DD0B0", Offset = "0x68DC4B0", VA = "0x1868DD0B0", Slot = "7")]
		public void OnBeginDrag(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68DD1D0", Offset = "0x68DC5D0", VA = "0x1868DD1D0", Slot = "4")]
		public void OnDrag(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68DD2C0", Offset = "0x68DC6C0", VA = "0x1868DD2C0", Slot = "8")]
		public void OnEndDrag(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68DD690", Offset = "0x68DCA90", VA = "0x1868DD690", Slot = "9")]
		public void OnPointerEnter(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68DD6C0", Offset = "0x68DCAC0", VA = "0x1868DD6C0", Slot = "10")]
		public void OnPointerExit(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68DD190", Offset = "0x68DC590", VA = "0x1868DD190")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68DD750", Offset = "0x68DCB50", VA = "0x1868DD750")]
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
		[Cpp2IlInjected.Address(RVA = "0x68D9120", Offset = "0x68D8520", VA = "0x1868D9120", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68D9010", Offset = "0x68D8410", VA = "0x1868D9010", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x68D8F50", Offset = "0x68D8350", VA = "0x1868D8F50")]
		private void GFNBPCGJJND(GameObject BNNFCOPEFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68D9300", Offset = "0x68D8700", VA = "0x1868D9300")]
		public void SetOptionsWithNoDefault(List<string> FMHMDECCGKB, [Optional] string HCJENPBNEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x68D9540", Offset = "0x68D8940", VA = "0x1868D9540")]
		public void SetOptionsWithNoDefault(List<OptionData> MIBGOGGBLGL, [Optional] string HCJENPBNEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x68D9230", Offset = "0x68D8630", VA = "0x1868D9230", Slot = "42")]
		public override void OnPointerClick(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A0", Offset = "0x72E9A0", VA = "0x18072F5A0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas FMBCEEEIEML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68D9630", Offset = "0x68D8A30", VA = "0x1868D9630")]
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
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
			[DebuggerHidden]
			public EKDHAPGNNBN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x68D9690", Offset = "0x68D8A90", VA = "0x1868D9690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x68D9BB0", Offset = "0x68D8FB0", VA = "0x1868D9BB0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x68DAC70", Offset = "0x68DA070", VA = "0x1868DAC70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KNFBHBMPIEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x68DAC50", Offset = "0x68DA050", VA = "0x1868DAC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PFIDDCMDFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1218550", Offset = "0x1217950", VA = "0x181218550")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68DAE40", Offset = "0x68DA240", VA = "0x1868DAE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NKCBCBPGPAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x68DABB0", Offset = "0x68D9FB0", VA = "0x1868DABB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x68DADA0", Offset = "0x68DA1A0", VA = "0x1868DADA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68DA5F0", Offset = "0x68D99F0", VA = "0x1868DA5F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68DA980", Offset = "0x68D9D80", VA = "0x1868DA980")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68DA6D0", Offset = "0x68D9AD0", VA = "0x1868DA6D0")]
		public void Hide(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68DAAC0", Offset = "0x68D9EC0", VA = "0x1868DAAC0")]
		public void Show(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68DAA20", Offset = "0x68D9E20", VA = "0x1868DAA20")]
		public void Set(object MIFCLBEAOPM, bool POHHJPMBGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68DA7C0", Offset = "0x68D9BC0", VA = "0x1868DA7C0")]
		private void KFAMBFAIBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x68DA750", Offset = "0x68D9B50", VA = "0x1868DA750")]
		[IteratorStateMachine(typeof(EKDHAPGNNBN))]
		private IEnumerator<MEOADLJIECK> JOMKNDHBMPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68DA690", Offset = "0x68D9A90", VA = "0x1868DA690", Slot = "5")]
		public virtual void DoHideOrShow(bool MJAJOLGGFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68DAB40", Offset = "0x68D9F40", VA = "0x1868DAB40")]
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
			[Cpp2IlInjected.Address(RVA = "0x72F260", Offset = "0x72E660", VA = "0x18072F260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x754190", Offset = "0x753590", VA = "0x180754190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> PKOFAKNJCHN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x68DB030", Offset = "0x68DA430", VA = "0x1868DB030")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x68DB170", Offset = "0x68DA570", VA = "0x1868DB170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> HKKBOHNDJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x68DB0D0", Offset = "0x68DA4D0", VA = "0x1868DB0D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x68DB210", Offset = "0x68DA610", VA = "0x1868DB210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68DAF70", Offset = "0x68DA370", VA = "0x1868DAF70", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68DAFD0", Offset = "0x68DA3D0", VA = "0x1868DAFD0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData MNNEHHHEKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DACFD0", Offset = "0x1DAC3D0", VA = "0x181DACFD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DACFD0", Offset = "0x1DAC3D0", VA = "0x181DACFD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
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
		[Cpp2IlInjected.Address(RVA = "0x68D9FA0", Offset = "0x68D93A0", VA = "0x1868D9FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ENKONAKAPLD BGHLCOKOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68DA0E0", Offset = "0x68D94E0", VA = "0x1868DA0E0")]
		get
		{
			return default(ENKONAKAPLD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68D9BF0", Offset = "0x68D8FF0", VA = "0x1868D9BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<ENKONAKAPLD> LCDNONAGLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68D9EA0", Offset = "0x68D92A0", VA = "0x1868D9EA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x68D9DA0", Offset = "0x68D91A0", VA = "0x1868D9DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool NFMKJKIEANG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient HIHAAKOAHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x72B0F0", Offset = "0x72A4F0", VA = "0x18072B0F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x68DCE20", Offset = "0x68DC220", VA = "0x1868DCE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MFHNIFCLOME BELDJPAAHJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x13E3880", Offset = "0x13E2C80", VA = "0x1813E3880")]
			get
			{
				return default(MFHNIFCLOME);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x68DCFA0", Offset = "0x68DC3A0", VA = "0x1868DCFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool MEJHDOIIIKH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x68DC890", Offset = "0x68DBC90", VA = "0x1868DC890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 EJKEKPKBIPK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x68DCDB0", Offset = "0x68DC1B0", VA = "0x1868DCDB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x68DCDD0", Offset = "0x68DC1D0", VA = "0x1868DCDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool EGJNNKHNPKG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x68DBB20", Offset = "0x68DAF20", VA = "0x1868DBB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 GIDKIJHPLDC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x663ABF0", Offset = "0x6639FF0", VA = "0x18663ABF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x68DCF50", Offset = "0x68DC350", VA = "0x1868DCF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float HLPHPEAMDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1C659D0", Offset = "0x1C64DD0", VA = "0x181C659D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1C65B20", Offset = "0x1C64F20", VA = "0x181C65B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 JCDMIAAFHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x68DBD20", Offset = "0x68DB120", VA = "0x1868DBD20")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 ABLPCDJFEIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x68DC470", Offset = "0x68DB870", VA = "0x1868DC470")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MMGHFIILFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x15F6300", Offset = "0x15F5700", VA = "0x1815F6300")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x68DCFB0", Offset = "0x68DC3B0", VA = "0x1868DCFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68DBBA0", Offset = "0x68DAFA0", VA = "0x1868DBBA0", Slot = "12")]
		protected override void BFNLGEBNFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x68DC500", Offset = "0x68DB900", VA = "0x1868DC500")]
		private void HNOBBLCCNJM(Color[] BFHCCIPGFAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68DBD70", Offset = "0x68DB170", VA = "0x1868DBD70", Slot = "13")]
		protected override void CHKAAFNODND(Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68DC670", Offset = "0x68DBA70", VA = "0x1868DC670", Slot = "14")]
		protected override void LBKGCHIHEPG(Material NIFEJPCAIBK, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x68DCCF0", Offset = "0x68DC0F0", VA = "0x1868DCCF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool PJJANGBBPLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x72E820", Offset = "0x72DC20", VA = "0x18072E820", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform MJNPDNAJJNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x68DF080", Offset = "0x68DE480", VA = "0x1868DF080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect HLFNIMKLADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x68DE520", Offset = "0x68DD920", VA = "0x1868DE520")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite JLACLEJNCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x68DE7D0", Offset = "0x68DDBD0", VA = "0x1868DE7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68DDF20", Offset = "0x68DD320", VA = "0x1868DDF20", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68DED50", Offset = "0x68DE150", VA = "0x1868DED50", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68DF070", Offset = "0x68DE470", VA = "0x1868DF070", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68DEF00", Offset = "0x68DE300", VA = "0x1868DEF00", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68DE650", Offset = "0x68DDA50", VA = "0x1868DE650")]
		private void JGLMOCFHIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x68DF0E0", Offset = "0x68DE4E0", VA = "0x1868DF0E0")]
		private void PIICLHBGFKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68DE110", Offset = "0x68DD510", VA = "0x1868DE110")]
		private void BOOEOBNICAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68DE140", Offset = "0x68DD540", VA = "0x1868DE140")]
		private void FIGBBEFBGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68DEAE0", Offset = "0x68DDEE0", VA = "0x1868DEAE0")]
		protected void OOPIHCGHGEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68DE9A0", Offset = "0x68DDDA0", VA = "0x1868DE9A0")]
		private void NKFMNPOHABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "12")]
		protected virtual void BFNLGEBNFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "13")]
		protected virtual void CHKAAFNODND(Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "14")]
		protected virtual void LBKGCHIHEPG(Material NIFEJPCAIBK, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68DE190", Offset = "0x68DD590", VA = "0x1868DE190")]
		private void ICHHLFJMPGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		[Conditional("RRUI_PROFILING")]
		protected void DJFBPGDIIFK(string IFCELFAKOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830")]
		[Conditional("RRUI_PROFILING")]
		protected void BMEKCCMAGJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x22C630", Offset = "0x22BA30")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool PJJANGBBPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> FKDBBAHJPDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x735A10", Offset = "0x734E10", VA = "0x180735A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 EJKEKPKBIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x46BA7D0", Offset = "0x46B9BD0", VA = "0x1846BA7D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x68DFC10", Offset = "0x68DF010", VA = "0x1868DFC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68DF910", Offset = "0x68DED10", VA = "0x1868DF910")]
		public void SetRingLayers(IReadOnlyList<RingLayer> MDIDMACPFFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x68DF6F0", Offset = "0x68DEAF0", VA = "0x1868DF6F0")]
		public bool SetRingLayerColor(int MHMKDHJAPNM, Color HAFGGBNGKBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x68DF800", Offset = "0x68DEC00", VA = "0x1868DF800")]
		public bool SetRingLayerSize(int MHMKDHJAPNM, float GBNBGNMHGLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x68DF3B0", Offset = "0x68DE7B0", VA = "0x1868DF3B0", Slot = "12")]
		protected override void BFNLGEBNFIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x68DF520", Offset = "0x68DE920", VA = "0x1868DF520", Slot = "13")]
		protected override void CHKAAFNODND(Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x68DF6A0", Offset = "0x68DEAA0", VA = "0x1868DF6A0", Slot = "14")]
		protected override void LBKGCHIHEPG(Material NIFEJPCAIBK, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x68DFA60", Offset = "0x68DEE60", VA = "0x1868DFA60")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool PJJANGBBPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite CEFJAOHOMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x68E09E0", Offset = "0x68DFDE0", VA = "0x1868E09E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x68E0BF0", Offset = "0x68DFFF0", VA = "0x1868E0BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color AINPEJMFNGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xDD7710", Offset = "0xDD6B10", VA = "0x180DD7710")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x68E0C90", Offset = "0x68E0090", VA = "0x1868E0C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color PKIBCMHLOGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x18E8AB0", Offset = "0x18E7EB0", VA = "0x1818E8AB0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x68E0AE0", Offset = "0x68DFEE0", VA = "0x1868E0AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float HDCJHLKPPBC
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1474AF0", Offset = "0x1473EF0", VA = "0x181474AF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x68E0B80", Offset = "0x68DFF80", VA = "0x1868E0B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 JHFCDKEEFNB
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xF19A10", Offset = "0xF18E10", VA = "0x180F19A10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x68E0BA0", Offset = "0x68DFFA0", VA = "0x1868E0BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float JHMJCAFAEBB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x2780080", Offset = "0x277F480", VA = "0x182780080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x68E0B40", Offset = "0x68DFF40", VA = "0x1868E0B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 IOPOCJKJEGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x2410EC0", Offset = "0x24102C0", VA = "0x182410EC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x68E0CF0", Offset = "0x68E00F0", VA = "0x1868E0CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float HEGIPIFFHKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x1625AA0", Offset = "0x1624EA0", VA = "0x181625AA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x68E0AB0", Offset = "0x68DFEB0", VA = "0x1868E0AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 IBNJMGKMPIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x68E0320", Offset = "0x68DF720", VA = "0x1868E0320")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public AFFJAHCPBKP FFHFDKEJEBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xDCE700", Offset = "0xDCDB00", VA = "0x180DCE700")]
			get
			{
				return default(AFFJAHCPBKP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x68E0AD0", Offset = "0x68DFED0", VA = "0x1868E0AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float HCHLBNICNJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1625B00", Offset = "0x1624F00", VA = "0x181625B00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x68E0B60", Offset = "0x68DFF60", VA = "0x1868E0B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float EOMBOOAEELN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xF199C0", Offset = "0xF18DC0", VA = "0x180F199C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x68E0A90", Offset = "0x68DFE90", VA = "0x1868E0A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68DFC60", Offset = "0x68DF060", VA = "0x1868DFC60", Slot = "13")]
		protected override void CHKAAFNODND(Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68E0390", Offset = "0x68DF790", VA = "0x1868E0390")]
		private void JDINIDJFIDG(Sprite CBBEKKLCOBK, out Vector2 FKNOIJFLJCL, out Vector2 NFHHKJIIAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68E0610", Offset = "0x68DFA10", VA = "0x1868E0610", Slot = "14")]
		protected override void LBKGCHIHEPG(Material NIFEJPCAIBK, bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x68E0940", Offset = "0x68DFD40", VA = "0x1868E0940")]
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
			[Cpp2IlInjected.Address(RVA = "0x68E0DA0", Offset = "0x68E01A0", VA = "0x1868E0DA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68E0D40", Offset = "0x68E0140", VA = "0x1868E0D40")]
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
			[Cpp2IlInjected.Address(RVA = "0x74C840", Offset = "0x74BC40", VA = "0x18074C840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x68DBA00", Offset = "0x68DAE00", VA = "0x1868DBA00")]
		public PJJIHJGOPID(Component PKDAKJPDDGD, Action KOEAMGEFJNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x68DB980", Offset = "0x68DAD80", VA = "0x1868DB980")]
		public void JIPFIFODDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x68DB970", Offset = "0x68DAD70", VA = "0x1868DB970", Slot = "4")]
		public bool Equals(PJJIHJGOPID MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x68DB8E0", Offset = "0x68DACE0", VA = "0x1868DB8E0", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x72B020", Offset = "0x72A420", VA = "0x18072B020", Slot = "2")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
		[DebuggerHidden]
		public GKHBCLDOPFP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68DA280", Offset = "0x68D9680", VA = "0x1868DA280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x68DA5B0", Offset = "0x68D99B0", VA = "0x1868DA5B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x68D87F0", Offset = "0x68D7BF0", VA = "0x1868D87F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x68D8DF0", Offset = "0x68D81F0", VA = "0x1868D8DF0")]
	public CDBELLKJENP(GLMLDOMIGMH.NMMGBICHGHP LOFJJNACGFI, int MELJJINAEEE = -1, int GLJIBIMMNLK = -1, [Optional] Func<Component, float> LIGIGBKGDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x68D8AC0", Offset = "0x68D7EC0", VA = "0x1868D8AC0")]
	public void OMJIGLLBDMJ(Component PKDAKJPDDGD, Action FFDDMJBLHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x68D88D0", Offset = "0x68D7CD0", VA = "0x1868D88D0")]
	public void FLPNBHIFPAD(Component PKDAKJPDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x68D8A60", Offset = "0x68D7E60", VA = "0x1868D8A60")]
	public bool LMCAGAEFJGG(Component AFCHMEJMNBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x68D85C0", Offset = "0x68D79C0", VA = "0x1868D85C0")]
	private void DCDMHJGONKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x68D8860", Offset = "0x68D7C60", VA = "0x1868D8860")]
	[IteratorStateMachine(typeof(GKHBCLDOPFP))]
	private IEnumerator<MEOADLJIECK> FCKMHMAMFIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1416840", Offset = "0x1415C40", VA = "0x181416840")]
	[CompilerGenerated]
	private void EEBOGFCNOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x68D8D30", Offset = "0x68D8130", VA = "0x1868D8D30")]
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
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x68DB600", Offset = "0x68DAA00", VA = "0x1868DB600")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68DB2B0", Offset = "0x68DA6B0", VA = "0x1868DB2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
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
