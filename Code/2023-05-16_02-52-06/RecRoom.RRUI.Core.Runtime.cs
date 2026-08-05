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
				[Cpp2IlInjected.Address(RVA = "0x69C7E50", Offset = "0x69C6C50", VA = "0x1869C7E50")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x69C7EB0", Offset = "0x69C6CB0", VA = "0x1869C7EB0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x69C7DD0", Offset = "0x69C6BD0", VA = "0x1869C7DD0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x69C7A80", Offset = "0x69C6880", VA = "0x1869C7A80")]
			public void NMIJKHIKPBF(PointerEventData AJCLBGAGKAL, RectTransform JGKOMMFGHHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x69C7960", Offset = "0x69C6760", VA = "0x1869C7960")]
			public void LHDFHGLIOKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x69C7C90", Offset = "0x69C6A90", VA = "0x1869C7C90")]
			public void NNGDBJBDICH(PointerEventData AJCLBGAGKAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x69C7D80", Offset = "0x69C6B80", VA = "0x1869C7D80")]
			public void PAGMIPBNBEN(float FHCBPPAIIGA, RectTransform JGKOMMFGHHA, Vector3 LNLPNIDIPMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[LJGEGNIDGLA(DIBFHMICKPK.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly global::JDKDAIPFIPL<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly global::JDKDAIPFIPL<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::JDKDAIPFIPL<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly global::JDKDAIPFIPL<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly global::JDKDAIPFIPL<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly CJIPBGMKILF PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData FKPKPABFLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool AMOEJKGANDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool AADPOAEIFLF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EKOFHBIPKPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8F4B60", Offset = "0x8F3960", VA = "0x1808F4B60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x69C7010", Offset = "0x69C5E10", VA = "0x1869C7010")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ABKPDLHGHPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8F4BE0", Offset = "0x8F39E0", VA = "0x1808F4BE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x69C70C0", Offset = "0x69C5EC0", VA = "0x1869C70C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69C7040", Offset = "0x69C5E40", VA = "0x1869C7040")]
		private bool MKCFEDJDPDP(PointerEventData CANNGAMIHEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69C7670", Offset = "0x69C6470", VA = "0x1869C7670", Slot = "5")]
		public void OnPointerDown(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69C7730", Offset = "0x69C6530", VA = "0x1869C7730", Slot = "11")]
		public void OnPointerUp(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69C73E0", Offset = "0x69C61E0", VA = "0x1869C73E0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69C70F0", Offset = "0x69C5EF0", VA = "0x1869C70F0", Slot = "7")]
		public void OnBeginDrag(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69C7210", Offset = "0x69C6010", VA = "0x1869C7210", Slot = "4")]
		public void OnDrag(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69C7300", Offset = "0x69C6100", VA = "0x1869C7300", Slot = "8")]
		public void OnEndDrag(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x69C76D0", Offset = "0x69C64D0", VA = "0x1869C76D0", Slot = "9")]
		public void OnPointerEnter(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69C7700", Offset = "0x69C6500", VA = "0x1869C7700", Slot = "10")]
		public void OnPointerExit(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69C71D0", Offset = "0x69C5FD0", VA = "0x1869C71D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69C7790", Offset = "0x69C6590", VA = "0x1869C7790")]
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
		private OptionData PFCOOFOJDPI;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69C33C0", Offset = "0x69C21C0", VA = "0x1869C33C0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69C32B0", Offset = "0x69C20B0", VA = "0x1869C32B0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69C31F0", Offset = "0x69C1FF0", VA = "0x1869C31F0")]
		private void BKFOFIGGCLB(GameObject ALELBCBBPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69C35A0", Offset = "0x69C23A0", VA = "0x1869C35A0")]
		public void SetOptionsWithNoDefault(List<string> HEJNPPKNAND, [Optional] string JEBDCPCNGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69C37E0", Offset = "0x69C25E0", VA = "0x1869C37E0")]
		public void SetOptionsWithNoDefault(List<OptionData> IFLCOEMLDOM, [Optional] string JEBDCPCNGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69C34D0", Offset = "0x69C22D0", VA = "0x1869C34D0", Slot = "42")]
		public override void OnPointerClick(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7487A0", Offset = "0x7475A0", VA = "0x1807487A0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas EIFNBFPINLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69C38D0", Offset = "0x69C26D0", VA = "0x1869C38D0")]
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
		private sealed class CGHGHDKJKEO : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private OLKFKAFMJCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
			[DebuggerHidden]
			public CGHGHDKJKEO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69C2C90", Offset = "0x69C1A90", VA = "0x1869C2C90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x69C31B0", Offset = "0x69C1FB0", VA = "0x1869C31B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[LJGEGNIDGLA(DIBFHMICKPK.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[JHPLKCJIMPH(DIBFHMICKPK.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly BAHKENJLEMI NCEJKOOPOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool KMJOCPHHEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? MINBECEKFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? OCIPCDHINKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? ELPNFJKBCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool CAMLKPHPONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool FCIDFJANCDL;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GNFLPEDMAHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69C4CB0", Offset = "0x69C3AB0", VA = "0x1869C4CB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HCAGPEHOHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69C4C90", Offset = "0x69C3A90", VA = "0x1869C4C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JCKMNLEMGFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA21250", Offset = "0xA20050", VA = "0x180A21250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69C4E80", Offset = "0x69C3C80", VA = "0x1869C4E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GFOAJANADNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69C4BF0", Offset = "0x69C39F0", VA = "0x1869C4BF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x69C4DE0", Offset = "0x69C3BE0", VA = "0x1869C4DE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69C4630", Offset = "0x69C3430", VA = "0x1869C4630")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69C49C0", Offset = "0x69C37C0", VA = "0x1869C49C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69C4940", Offset = "0x69C3740", VA = "0x1869C4940")]
		public void Hide(object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69C4B00", Offset = "0x69C3900", VA = "0x1869C4B00")]
		public void Show(object AMBDKIOJFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69C4A60", Offset = "0x69C3860", VA = "0x1869C4A60")]
		public void Set(object AMBDKIOJFBL, bool HGLGFIODOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x69C4740", Offset = "0x69C3540", VA = "0x1869C4740")]
		private void DJECFLAAFPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69C46D0", Offset = "0x69C34D0", VA = "0x1869C46D0")]
		[IteratorStateMachine(typeof(CGHGHDKJKEO))]
		private IEnumerator<OLKFKAFMJCO> BANGCJBPBAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69C4900", Offset = "0x69C3700", VA = "0x1869C4900", Slot = "5")]
		public virtual void DoHideOrShow(bool ACNDBNAIFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69C4B80", Offset = "0x69C3980", VA = "0x1869C4B80")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NEADDPAOEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x75BA60", Offset = "0x75A860", VA = "0x18075BA60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x77D190", Offset = "0x77BF90", VA = "0x18077D190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> DDAAEHFIDOO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x69C5070", Offset = "0x69C3E70", VA = "0x1869C5070")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x69C51B0", Offset = "0x69C3FB0", VA = "0x1869C51B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> GCOAGLBMGLF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x69C5110", Offset = "0x69C3F10", VA = "0x1869C5110")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x69C5250", Offset = "0x69C4050", VA = "0x1869C5250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x69C4FB0", Offset = "0x69C3DB0", VA = "0x1869C4FB0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x69C5010", Offset = "0x69C3E10", VA = "0x1869C5010", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData CANNGAMIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x23C9510", Offset = "0x23C8310", VA = "0x1823C9510")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x23C9510", Offset = "0x23C8310", VA = "0x1823C9510")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ACECFHLOPIM
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MFALJKNOBLN
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const MFALJKNOBLN JEFDKKDAALO = MFALJKNOBLN.Light;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string BJMDJIDBIAJ = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static BBALOPFJECE PBINHDGPGHD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BBALOPFJECE GEBJBFIJHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x69C28A0", Offset = "0x69C16A0", VA = "0x1869C28A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static MFALJKNOBLN NOILNCOKDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x69C2700", Offset = "0x69C1500", VA = "0x1869C2700")]
		get
		{
			return default(MFALJKNOBLN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69C29E0", Offset = "0x69C17E0", VA = "0x1869C29E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<MFALJKNOBLN> LHKEMOELFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x69C2600", Offset = "0x69C1400", VA = "0x1869C2600")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69C2B90", Offset = "0x69C1990", VA = "0x1869C2B90")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface POPHGGHEHAJ : HADPDAGIDEE, ABFFFMGEFBB, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	global::LEPJFHFGLAL<GameObject, int> LJFCEDANLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	global::GPMIOKNMCFC<GameObject, int, bool> HBAACJCKDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	global::JDKDAIPFIPL<bool> DMOICGHAGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool DMEBPLIJOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float PLCPBEHAIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	global::JDKDAIPFIPL<float> MJEOGFMMMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CJIPBGMKILF IBNFHKGBKFG
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
	void SpawnLoadingPlaceholders(GameObject PEINAPABAGG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BMBBAPOFAOP Spawn<T>(int KCHGNLOGEIJ, IReadOnlyList<T> MMJOHADFCHO, GameObject PEINAPABAGG);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BMBBAPOFAOP Spawn<T>(int KCHGNLOGEIJ, IReadOnlyList<T> MMJOHADFCHO, GameObject DKJLGMBHFOI, ref Func<int, GameObject> GFINIKPPGND);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum NHOBLLLEKLF : byte
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
		private static readonly int BOBCDPDHFEC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<NHOBLLLEKLF, string> MNCFJMHGNLG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int LAKBBEJBEJK = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int ALNKIGEMPGN;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int AFOEBNJBGPI;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int HHFHILFNPHO;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int HPJBIIOBGGG;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int GDBKGEHAIAB;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int FFGCDIMEJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[LJGEGNIDGLA(DIBFHMICKPK.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool EBEJCJKJPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool PMGEBEPCHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Color[] INNLLFKEHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private NHOBLLLEKLF type;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly NHOBLLLEKLF[] CFBINKPGECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[JHKJJNMIAJO("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly NHOBLLLEKLF[] AIJEDEIBDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[JHKJJNMIAJO("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[Range(0f, 360f)]
		[JHKJJNMIAJO("type", (byte)4)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[JHKJJNMIAJO("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic OPKKGMPIHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool GNAMAHEFKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient LGKJOHBHEDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7400D0", Offset = "0x73EED0", VA = "0x1807400D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x69C6E60", Offset = "0x69C5C60", VA = "0x1869C6E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NHOBLLLEKLF FKLLKDBMLDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x12C06C0", Offset = "0x12BF4C0", VA = "0x1812C06C0")]
			get
			{
				return default(NHOBLLLEKLF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x69C6FE0", Offset = "0x69C5DE0", VA = "0x1869C6FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool KFDBAHDALFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x69C66D0", Offset = "0x69C54D0", VA = "0x1869C66D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 IOFBAHKAACB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x69C6DF0", Offset = "0x69C5BF0", VA = "0x1869C6DF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x69C6E10", Offset = "0x69C5C10", VA = "0x1869C6E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool LJIKNDODCBB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x69C5F50", Offset = "0x69C4D50", VA = "0x1869C5F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 OGAGLAIHCAA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6718650", Offset = "0x6717450", VA = "0x186718650")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x69C6F90", Offset = "0x69C5D90", VA = "0x1869C6F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float HANFJHJLBCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x17ACBF0", Offset = "0x17AB9F0", VA = "0x1817ACBF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1DBA680", Offset = "0x1DB9480", VA = "0x181DBA680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 OOIKDOCKELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x69C5F00", Offset = "0x69C4D00", VA = "0x1869C5F00")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 AMLECIFOPME
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x69C6750", Offset = "0x69C5550", VA = "0x1869C6750")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float GFBGOOLJCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x17ACC40", Offset = "0x17ABA40", VA = "0x1817ACC40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x69C6FF0", Offset = "0x69C5DF0", VA = "0x1869C6FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x69C5D80", Offset = "0x69C4B80", VA = "0x1869C5D80", Slot = "12")]
		protected override void CDPCPOJPBCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69C67E0", Offset = "0x69C55E0", VA = "0x1869C67E0")]
		private void NKOHMGOJGPM(Color[] OEPLGMGDKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69C5FD0", Offset = "0x69C4DD0", VA = "0x1869C5FD0", Slot = "13")]
		protected override void JDOHAOCCBME(Material ECFGNJLOODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69C5B60", Offset = "0x69C4960", VA = "0x1869C5B60", Slot = "14")]
		protected override void BGEODLKHBJI(Material ECFGNJLOODA, bool LJCKIACCBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69C6D30", Offset = "0x69C5B30", VA = "0x1869C6D30")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly FKOEBDPEJEL IDDBFKMLFDD;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static Sprite PNJMKGNGDDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Material IACOLEPEHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material DNNNDNGJBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool CONKAJCBHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool KMJOCPHHEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool MJBDAODIMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool OMIAGNOIFNH;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic OPKKGMPIHJK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader OJCDGHPGFKB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool GNAMAHEFKFH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool BKPCEOMFPFO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform JGKOMMFGHHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x69C82B0", Offset = "0x69C70B0", VA = "0x1869C82B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect IEOAECLDDHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x69C86F0", Offset = "0x69C74F0", VA = "0x1869C86F0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite LCEIFBFJLDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x69C8D80", Offset = "0x69C7B80", VA = "0x1869C8D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69C80C0", Offset = "0x69C6EC0", VA = "0x1869C80C0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69C8F50", Offset = "0x69C7D50", VA = "0x1869C8F50", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x69C9270", Offset = "0x69C8070", VA = "0x1869C9270", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69C9100", Offset = "0x69C7F00", VA = "0x1869C9100", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69C8850", Offset = "0x69C7650", VA = "0x1869C8850")]
		private void LOOCABHDBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69C7F60", Offset = "0x69C6D60", VA = "0x1869C7F60")]
		private void AMNKDILLGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x69C8820", Offset = "0x69C7620", VA = "0x1869C8820")]
		private void KJKAKOPBKOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69C8310", Offset = "0x69C7110", VA = "0x1869C8310")]
		private void GNBPFPGFMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69C89D0", Offset = "0x69C77D0", VA = "0x1869C89D0")]
		protected void NNBLKIDBPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69C8C40", Offset = "0x69C7A40", VA = "0x1869C8C40")]
		private void NOKGAEEBLEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "12")]
		protected virtual void CDPCPOJPBCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "13")]
		protected virtual void JDOHAOCCBME(Material ECFGNJLOODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "14")]
		protected virtual void BGEODLKHBJI(Material ECFGNJLOODA, bool LJCKIACCBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69C8360", Offset = "0x69C7160", VA = "0x1869C8360")]
		private void HFDEMAFEAOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		[Conditional("RRUI_PROFILING")]
		protected void GEIFDKKOALM(string FPIGGFIFINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040")]
		[Conditional("RRUI_PROFILING")]
		protected void BOALNJEBDFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xE704D0", Offset = "0xE6F2D0", VA = "0x180E704D0")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x2195E0", Offset = "0x2189E0")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int LLIIDCIHGBE;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int MONLNAHAMGK;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int BDIGNAJOOPH;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int GPNNMEAPLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[LJGEGNIDGLA(DIBFHMICKPK.Self, false, false, false)]
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
		private Color[] INNLLFKEHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private float[] MCDPDNMKPAH;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic OPKKGMPIHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool BKPCEOMFPFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> IAFMPHHCPID
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x748BA0", Offset = "0x7479A0", VA = "0x180748BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 IOFBAHKAACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x483CB40", Offset = "0x483B940", VA = "0x18483CB40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x69C9C50", Offset = "0x69C8A50", VA = "0x1869C9C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69C9950", Offset = "0x69C8750", VA = "0x1869C9950")]
		public void SetRingLayers(IReadOnlyList<RingLayer> JLGAKFJOMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69C9730", Offset = "0x69C8530", VA = "0x1869C9730")]
		public bool SetRingLayerColor(int KGICKJHBDLE, Color MHCJBLNNNKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69C9840", Offset = "0x69C8640", VA = "0x1869C9840")]
		public bool SetRingLayerSize(int KGICKJHBDLE, float MKGODNJCKOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x69C9440", Offset = "0x69C8240", VA = "0x1869C9440", Slot = "12")]
		protected override void CDPCPOJPBCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x69C95B0", Offset = "0x69C83B0", VA = "0x1869C95B0", Slot = "13")]
		protected override void JDOHAOCCBME(Material ECFGNJLOODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69C93F0", Offset = "0x69C81F0", VA = "0x1869C93F0", Slot = "14")]
		protected override void BGEODLKHBJI(Material ECFGNJLOODA, bool LJCKIACCBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69C9AA0", Offset = "0x69C88A0", VA = "0x1869C9AA0")]
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
		public enum OGIFKMMOIIM
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int IHDBBMDDGDP;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int GBDKPGBAPGH;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int DDJLFMHOGPA;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int MJDINAOAPDO;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int IBMMOFMHHBC;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int NOBFIODJGCC;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int JPCDDAFMIHE;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int NIMNOAJAPCI;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int HAIAKPJGPKP;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int IGHIIBDLABP;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int JGKPLIDOKDK;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int EALOJPFHBEA;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int LAEEMFILMFA;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int KOADKNKIIOA;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int MMJJMAGBFHO;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int JOGJIPJGKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		[LJGEGNIDGLA(DIBFHMICKPK.Self, false, false, false)]
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
		private OGIFKMMOIIM animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[JHKJJNMIAJO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[JHKJJNMIAJO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic OPKKGMPIHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x757880", Offset = "0x756680", VA = "0x180757880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool BKPCEOMFPFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite LIGMBNICLCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x69CAA20", Offset = "0x69C9820", VA = "0x1869CAA20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x69CAC30", Offset = "0x69C9A30", VA = "0x1869CAC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color PJAMHKHMIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x11EE620", Offset = "0x11ED420", VA = "0x1811EE620")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x69CACD0", Offset = "0x69C9AD0", VA = "0x1869CACD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color EFMEKECCANO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA953C0", Offset = "0xA941C0", VA = "0x180A953C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x69CAB20", Offset = "0x69C9920", VA = "0x1869CAB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float CCJLKGBAPCM
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1A31C60", Offset = "0x1A30A60", VA = "0x181A31C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x69CABC0", Offset = "0x69C99C0", VA = "0x1869CABC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 ABHFJJKEJMD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x171C790", Offset = "0x171B590", VA = "0x18171C790")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x69CABE0", Offset = "0x69C99E0", VA = "0x1869CABE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float HGFOBPAJBEK
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x17ACC50", Offset = "0x17ABA50", VA = "0x1817ACC50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x69CAB80", Offset = "0x69C9980", VA = "0x1869CAB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 GPMIDGDGJKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x264D7C0", Offset = "0x264C5C0", VA = "0x18264D7C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x69CAD30", Offset = "0x69C9B30", VA = "0x1869CAD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float GAHLOCPJDGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x19D8590", Offset = "0x19D7390", VA = "0x1819D8590")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x69CAAF0", Offset = "0x69C98F0", VA = "0x1869CAAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 KOHFKKMEHKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x69C9F70", Offset = "0x69C8D70", VA = "0x1869C9F70")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public OGIFKMMOIIM FGCECBDFION
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x96B690", Offset = "0x96A490", VA = "0x18096B690")]
			get
			{
				return default(OGIFKMMOIIM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x69CAB10", Offset = "0x69C9910", VA = "0x1869CAB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float FPMJAPMJFON
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1D82560", Offset = "0x1D81360", VA = "0x181D82560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x69CABA0", Offset = "0x69C99A0", VA = "0x1869CABA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float BONCBOHGFLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x171C740", Offset = "0x171B540", VA = "0x18171C740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x69CAAD0", Offset = "0x69C98D0", VA = "0x1869CAAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69C9FE0", Offset = "0x69C8DE0", VA = "0x1869C9FE0", Slot = "13")]
		protected override void JDOHAOCCBME(Material ECFGNJLOODA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x69C9CA0", Offset = "0x69C8AA0", VA = "0x1869C9CA0")]
		private void AGGEDOIFLAF(Sprite KBJBDICLDHC, out Vector2 BNFFDHLDOPD, out Vector2 PHDODCMKBKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x69C9F20", Offset = "0x69C8D20", VA = "0x1869C9F20", Slot = "14")]
		protected override void BGEODLKHBJI(Material ECFGNJLOODA, bool LJCKIACCBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69CA980", Offset = "0x69C9780", VA = "0x1869CA980")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static Shader HMLDFPHAFNN;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader OJCDGHPGFKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x69CADE0", Offset = "0x69C9BE0", VA = "0x1869CADE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x69CAD80", Offset = "0x69C9B80", VA = "0x1869CAD80")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FKOEBDPEJEL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct NKHEGKCAJPA : IEquatable<NKHEGKCAJPA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly Component IJBJKIBEJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly Action GJLMGJLEHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly int KOOOHAFGOPP;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component BLDCJNPEBNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x740000", Offset = "0x73EE00", VA = "0x180740000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69C5A40", Offset = "0x69C4840", VA = "0x1869C5A40")]
		public NKHEGKCAJPA(Component IJBJKIBEJLN, Action GJLMGJLEHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x69C59C0", Offset = "0x69C47C0", VA = "0x1869C59C0")]
		public void JBLEBGFLKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x69C5920", Offset = "0x69C4720", VA = "0x1869C5920", Slot = "4")]
		public bool Equals(NKHEGKCAJPA IDBPJJAKCBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x69C5930", Offset = "0x69C4730", VA = "0x1869C5930", Slot = "0")]
		public override bool Equals(object OJGAEOFIMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x740040", Offset = "0x73EE40", VA = "0x180740040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class FLLLGFEJIMD : IEnumerator<OLKFKAFMJCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private OLKFKAFMJCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public FKOEBDPEJEL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private OLKFKAFMJCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x745830", Offset = "0x744630", VA = "0x180745830")]
		[DebuggerHidden]
		public FLLLGFEJIMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x75B040", Offset = "0x759E40", VA = "0x18075B040", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69C42C0", Offset = "0x69C30C0", VA = "0x1869C42C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x69C45F0", Offset = "0x69C33F0", VA = "0x1869C45F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int EALBIJDFAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly int AHAIKBNEGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Func<Component, float> IJFIHLOJNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<Component, NKHEGKCAJPA> JFADANPOBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LinkedList<NKHEGKCAJPA> OBMFNOMDCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<NKHEGKCAJPA> EDPDEEHENHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private LGJHLMJKIJM GEHOBKDAMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private KFNFMAPDDCC NNFNMIPMPHH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private KFNFMAPDDCC MMAOGCFAEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69C3C10", Offset = "0x69C2A10", VA = "0x1869C3C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x69C4160", Offset = "0x69C2F60", VA = "0x1869C4160")]
	public FKOEBDPEJEL(HNIOIOPPNAO.MPMODPADNDL NJMMDDDIGKP, int EALBIJDFAOJ = -1, int AHAIKBNEGGE = -1, [Optional] Func<Component, float> IJFIHLOJNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x69C3930", Offset = "0x69C2730", VA = "0x1869C3930")]
	public void DEGDMJEGOBF(Component IJBJKIBEJLN, Action DMPEOFAJLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x69C3FD0", Offset = "0x69C2DD0", VA = "0x1869C3FD0")]
	public void NKGFCADOBNO(Component IJBJKIBEJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x69C3EB0", Offset = "0x69C2CB0", VA = "0x1869C3EB0")]
	public bool KMOKIEDLOGB(Component KHJAOGDHEIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x69C3C80", Offset = "0x69C2A80", VA = "0x1869C3C80")]
	private void HAGFKAHDJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x69C3BA0", Offset = "0x69C29A0", VA = "0x1869C3BA0")]
	[IteratorStateMachine(typeof(FLLLGFEJIMD))]
	private IEnumerator<OLKFKAFMJCO> EAOIMLBCPKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x19A6C80", Offset = "0x19A5A80", VA = "0x1819A6C80")]
	[CompilerGenerated]
	private void BMPLEEMEFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x69C3F10", Offset = "0x69C2D10", VA = "0x1869C3F10")]
	[CompilerGenerated]
	private float NHNBOBBCNCF(NKHEGKCAJPA DMPEOFAJLOH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HJBDMBPNGFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OCFEBKBBAKK
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	OEACCPKELLP CLAKNHAGAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool CLCCFFNLFPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	global::JDKDAIPFIPL<OEACCPKELLP> ICGLLBHIDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHHFADEFHCM(OEACCPKELLP JDNOMEDAEMF, bool HBNMLHAAMLL = false);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KBGNMEAALAF
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static byte[] JDPEKMLOAPL;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int KHIOPMNKDNJ;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int FJCGIOGMELC;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static BigInteger BOMEHIKGKLG;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
	public KBGNMEAALAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x69C5640", Offset = "0x69C4440", VA = "0x1869C5640")]
	private static string PKFOMDHOGCM(byte[] EJKHFJILHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x69C52F0", Offset = "0x69C40F0", VA = "0x1869C52F0")]
	public static string GMEGIIKFFNC(byte[] EMGPHLLIACG, bool PHHFDNEANIF)
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
		[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
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
