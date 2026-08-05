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
				[Cpp2IlInjected.Address(RVA = "0x6ABBF70", Offset = "0x6ABAF70", VA = "0x186ABBF70")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6ABBFD0", Offset = "0x6ABAFD0", VA = "0x186ABBFD0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6ABBF20", Offset = "0x6ABAF20", VA = "0x186ABBF20")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6ABBA60", Offset = "0x6ABAA60", VA = "0x186ABBA60")]
			public void DNPDFFFDLOO(PointerEventData ALGLMFKMMIE, RectTransform HHKCOJALMFM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6ABBB60", Offset = "0x6ABAB60", VA = "0x186ABBB60")]
			public void KJIOBOPOEHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6ABBE40", Offset = "0x6ABAE40", VA = "0x186ABBE40")]
			public void OCKFIOINGLH(PointerEventData ALGLMFKMMIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6ABBDF0", Offset = "0x6ABADF0", VA = "0x186ABBDF0")]
			public void MLGJMBIGFLH(float AHFFBELPMLA, RectTransform HHKCOJALMFM, Vector3 CMCMKLBCKPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[KDKBJHCHPNA(PHHCCEMPGEN.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly MIADACEFMCK<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly MIADACEFMCK<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly MIADACEFMCK<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly MIADACEFMCK<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly MIADACEFMCK<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly ONDMBBPPJJI PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData PIBGOICDEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool DGNPMNALONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool EDMPDPNDMJE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NHEEMNPPCDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C8640", Offset = "0x7C7640", VA = "0x1807C8640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6ABB2A0", Offset = "0x6ABA2A0", VA = "0x186ABB2A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IMJDNHLCHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C8680", Offset = "0x7C7680", VA = "0x1807C8680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6ABB1F0", Offset = "0x6ABA1F0", VA = "0x186ABB1F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB220", Offset = "0x6ABA220", VA = "0x186ABB220")]
		private bool FNJKEHMLGCD(PointerEventData LPDEFAPJANH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB720", Offset = "0x6ABA720", VA = "0x186ABB720", Slot = "5")]
		public void OnPointerDown(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB7E0", Offset = "0x6ABA7E0", VA = "0x186ABB7E0", Slot = "11")]
		public void OnPointerUp(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB590", Offset = "0x6ABA590", VA = "0x186ABB590", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB2D0", Offset = "0x6ABA2D0", VA = "0x186ABB2D0", Slot = "7")]
		public void OnBeginDrag(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB3E0", Offset = "0x6ABA3E0", VA = "0x186ABB3E0", Slot = "4")]
		public void OnDrag(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB4C0", Offset = "0x6ABA4C0", VA = "0x186ABB4C0", Slot = "8")]
		public void OnEndDrag(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB780", Offset = "0x6ABA780", VA = "0x186ABB780", Slot = "9")]
		public void OnPointerEnter(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB7B0", Offset = "0x6ABA7B0", VA = "0x186ABB7B0", Slot = "10")]
		public void OnPointerExit(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB3A0", Offset = "0x6ABA3A0", VA = "0x186ABB3A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB840", Offset = "0x6ABA840", VA = "0x186ABB840")]
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
		private OptionData KPJGOCLJOHP;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AB72F0", Offset = "0x6AB62F0", VA = "0x186AB72F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AB71F0", Offset = "0x6AB61F0", VA = "0x186AB71F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7140", Offset = "0x6AB6140", VA = "0x186AB7140")]
		private void KLILBMFGBDP(GameObject IHKPPOCBBIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB75B0", Offset = "0x6AB65B0", VA = "0x186AB75B0")]
		public void SetOptionsWithNoDefault(List<string> AGKDCPLPFCM, [Optional] string NCELABLJEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB74C0", Offset = "0x6AB64C0", VA = "0x186AB74C0")]
		public void SetOptionsWithNoDefault(List<OptionData> CACELMJJEFC, [Optional] string NCELABLJEAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB73F0", Offset = "0x6AB63F0", VA = "0x186AB73F0", Slot = "42")]
		public override void OnPointerClick(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas KHANPPIANPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AB77E0", Offset = "0x6AB67E0", VA = "0x186AB77E0")]
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
		private sealed class OONFGOKIFOM : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private JHIBCIKJMBL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
			[DebuggerHidden]
			public OONFGOKIFOM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6AB9730", Offset = "0x6AB8730", VA = "0x186AB9730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6AB9C20", Offset = "0x6AB8C20", VA = "0x186AB9C20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[KDKBJHCHPNA(PHHCCEMPGEN.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[IELENNDBCLM(PHHCCEMPGEN.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly EEABDCAPAGK NIIGKDDGDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool IBAHMCNCIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? BGLILCMACHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? ADCNEPNAPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? JPGJDKECOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool ANCEFFOPFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool BIOCAPDLGAG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool COLAHKEBEHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6AB82C0", Offset = "0x6AB72C0", VA = "0x186AB82C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ENPGNPHBPDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6AB82A0", Offset = "0x6AB72A0", VA = "0x186AB82A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EHPLKACAPJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x80B770", Offset = "0x80A770", VA = "0x18080B770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6AB8470", Offset = "0x6AB7470", VA = "0x186AB8470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KIMJJNEIJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6AB8200", Offset = "0x6AB7200", VA = "0x186AB8200")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6AB83D0", Offset = "0x6AB73D0", VA = "0x186AB83D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7C40", Offset = "0x6AB6C40", VA = "0x186AB7C40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7FD0", Offset = "0x6AB6FD0", VA = "0x186AB7FD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7D90", Offset = "0x6AB6D90", VA = "0x186AB7D90")]
		public void Hide(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8100", Offset = "0x6AB7100", VA = "0x186AB8100")]
		public void Show(object KONODCHOCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8060", Offset = "0x6AB7060", VA = "0x186AB8060")]
		public void Set(object KONODCHOCOG, bool JGAIOHIEBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7E10", Offset = "0x6AB6E10", VA = "0x186AB7E10")]
		private void KLCNGFGJMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7D10", Offset = "0x6AB6D10", VA = "0x186AB7D10")]
		[IteratorStateMachine(typeof(OONFGOKIFOM))]
		private IEnumerator<JHIBCIKJMBL> HODPHPIPBOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7CD0", Offset = "0x6AB6CD0", VA = "0x186AB7CD0", Slot = "5")]
		public virtual void DoHideOrShow(bool HLDIIPKIGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8180", Offset = "0x6AB7180", VA = "0x186AB8180")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KCIJPMLOFJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x82BFE0", Offset = "0x82AFE0", VA = "0x18082BFE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7C35C0", Offset = "0x7C25C0", VA = "0x1807C35C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> BLBOELHHKNL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6AB85D0", Offset = "0x6AB75D0", VA = "0x186AB85D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6AB8730", Offset = "0x6AB7730", VA = "0x186AB8730")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> ANIFKONNMNB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6AB8680", Offset = "0x6AB7680", VA = "0x186AB8680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6AB87E0", Offset = "0x6AB77E0", VA = "0x186AB87E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6AB8590", Offset = "0x6AB7590", VA = "0x186AB8590", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6AB85B0", Offset = "0x6AB75B0", VA = "0x186AB85B0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData LPDEFAPJANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xCBCCF0", Offset = "0xCBBCF0", VA = "0x180CBCCF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCBCCF0", Offset = "0xCBBCF0", VA = "0x180CBCCF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OJNOHPIBICH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum ANBBHJJGLBC
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static KFNDCNMDHMI LJEAKEDNPDA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static KFNDCNMDHMI OOHBFKOMPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9450", Offset = "0x6AB8450", VA = "0x186AB9450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ANBBHJJGLBC BIOAPMHNJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9600", Offset = "0x6AB8600", VA = "0x186AB9600")]
		get
		{
			return default(ANBBHJJGLBC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9210", Offset = "0x6AB8210", VA = "0x186AB9210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<ANBBHJJGLBC> HPGBICCBOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9520", Offset = "0x6AB8520", VA = "0x186AB9520")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9370", Offset = "0x6AB8370", VA = "0x186AB9370")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NLALEPODHEG : HOHMEMFLGAD, PPBGPHJMMFP, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EFKALDPIAIL<GameObject, int> PCOLOIMIEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FBOECCOHABO<GameObject, int, bool> BGFMNFGLBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MIADACEFMCK<bool> GMOGGIHBJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool HNIDOIMJFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float EGCPIAEIBDH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MIADACEFMCK<float> BAGNEBNJMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ONDMBBPPJJI NJBKLOPOIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SpawnLoadingPlaceholders(GameObject CFIHBPMHFDG);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HNENBNAEPGI Spawn<T>(int KOBNNCDGLNP, IReadOnlyList<T> GPKMLHOONCL, GameObject CFIHBPMHFDG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HNENBNAEPGI Spawn<T>(int KOBNNCDGLNP, IReadOnlyList<T> GPKMLHOONCL, GameObject GGJLIAPINCN, Func<int, GameObject> MJKEGEKPKKF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int GPEHCABDGEJ, float GDGOKMFAOBE);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum OLHNJGFPHPH : byte
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

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int CDIIKADIINH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<OLHNJGFPHPH, string> PKEEAOPEKPG;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int AJPFAIFALHC = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int CPBIKAJIEHI;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int IMFNJFHBNDJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int PCJOCGBJCEF;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int FLHGNDFIJNE;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int ICNEOJFEIPI;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int ANEEEENMOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[KDKBJHCHPNA(PHHCCEMPGEN.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool KGJJKMDANJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool ENBKKBFJGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] DLNDPMFBMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private OLHNJGFPHPH type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly OLHNJGFPHPH[] MMMHCHIDHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[CPAPECLLIGO("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly OLHNJGFPHPH[] DKEJELBIJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[CPAPECLLIGO("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[CPAPECLLIGO("type", OLHNJGFPHPH.CustomDirection)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[CPAPECLLIGO("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic EENJBDBALLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool ABBGCMLJKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient KEKJNMHKHDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7C6560", Offset = "0x7C5560", VA = "0x1807C6560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6ABB040", Offset = "0x6ABA040", VA = "0x186ABB040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public OLHNJGFPHPH PFOKGBDCIEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x1099780", Offset = "0x1098780", VA = "0x181099780")]
			get
			{
				return default(OLHNJGFPHPH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6ABB1C0", Offset = "0x6ABA1C0", VA = "0x186ABB1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool BBGDALOKLPB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6ABA680", Offset = "0x6AB9680", VA = "0x186ABA680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 MMJFEJFPKPP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6ABAFB0", Offset = "0x6AB9FB0", VA = "0x186ABAFB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6ABAFF0", Offset = "0x6AB9FF0", VA = "0x186ABAFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool NIOALIMGENA
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6AB9D50", Offset = "0x6AB8D50", VA = "0x186AB9D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 LPLKHMLMMNO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6ABAFD0", Offset = "0x6AB9FD0", VA = "0x186ABAFD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6ABB170", Offset = "0x6ABA170", VA = "0x186ABB170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ENAJAAABAAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8CB6E0", Offset = "0x8CA6E0", VA = "0x1808CB6E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x141DF40", Offset = "0x141CF40", VA = "0x18141DF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 FEALEMFHDBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6ABA910", Offset = "0x6AB9910", VA = "0x186ABA910")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 PBPAEBCCKPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6AB9DC0", Offset = "0x6AB8DC0", VA = "0x186AB9DC0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float ECBFGEGOKCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7DB7E0", Offset = "0x7DA7E0", VA = "0x1807DB7E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6ABB1D0", Offset = "0x6ABA1D0", VA = "0x186ABB1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9E50", Offset = "0x6AB8E50", VA = "0x186AB9E50", Slot = "12")]
		protected override void GEHHPCPLFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6ABA960", Offset = "0x6AB9960", VA = "0x186ABA960")]
		private void KICMLMFEFID(Color[] MHEELGDFONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9FF0", Offset = "0x6AB8FF0", VA = "0x186AB9FF0", Slot = "13")]
		protected override void HFLKDNOAALK(Material JANOPPPMNPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6ABA6F0", Offset = "0x6AB96F0", VA = "0x186ABA6F0", Slot = "14")]
		protected override void JDCODMHFPIM(Material JANOPPPMNPE, bool IEEBLFDNOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABAF00", Offset = "0x6AB9F00", VA = "0x186ABAF00")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly LLLHOOPIFNP MPNKFIDBDDC;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite DGJEEOPODIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material BPHOJPNJFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material MOICJJDOOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool NMCJHGFBCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool IBAHMCNCIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool FHHNKKICECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool EOFKEOIGKMG;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic EENJBDBALLF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader FHILKCECOLK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool ABBGCMLJKMI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool GJJJHKILBGB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform HHKCOJALMFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6ABC7D0", Offset = "0x6ABB7D0", VA = "0x186ABC7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect BCBGPBPNEOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6ABC6B0", Offset = "0x6ABB6B0", VA = "0x186ABC6B0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite FFFAAHCKJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6ABC9C0", Offset = "0x6ABB9C0", VA = "0x186ABC9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC350", Offset = "0x6ABB350", VA = "0x186ABC350", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD1B0", Offset = "0x6ABC1B0", VA = "0x186ABD1B0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD4B0", Offset = "0x6ABC4B0", VA = "0x186ABD4B0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD360", Offset = "0x6ABC360", VA = "0x186ABD360", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC1C0", Offset = "0x6ABB1C0", VA = "0x186ABC1C0")]
		private void AIMHLLDHGLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC540", Offset = "0x6ABB540", VA = "0x186ABC540")]
		private void ECEJKLHPLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCBC0", Offset = "0x6ABBBC0", VA = "0x186ABCBC0")]
		private void LKBOGGOOENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC830", Offset = "0x6ABB830", VA = "0x186ABC830")]
		private void FDFPGFJODJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCF40", Offset = "0x6ABBF40", VA = "0x186ABCF40")]
		protected void OOMPCLLMCOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6ABC880", Offset = "0x6ABB880", VA = "0x186ABC880")]
		private void GHHONMJPGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "12")]
		protected virtual void GEHHPCPLFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "13")]
		protected virtual void HFLKDNOAALK(Material JANOPPPMNPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "14")]
		protected virtual void JDCODMHFPIM(Material JANOPPPMNPE, bool IEEBLFDNOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6ABCBF0", Offset = "0x6ABBBF0", VA = "0x186ABCBF0")]
		private void OECLECIHMAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
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
			[Range(0f, 2f)]
			[SerializeField]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly int PGDIGHAMPIE;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int PCKKICAJIPE;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int OGKIJENHHEM;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int IKHKLFAMIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[KDKBJHCHPNA(PHHCCEMPGEN.Self, false, false, false)]
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
		private Color[] DLNDPMFBMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] LAIBHBGCGCG;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic EENJBDBALLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool GJJJHKILBGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> BJLOFALOABO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3120", VA = "0x1807C4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 MMJFEJFPKPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6ABDF80", Offset = "0x6ABCF80", VA = "0x186ABDF80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6ABDFA0", Offset = "0x6ABCFA0", VA = "0x186ABDFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDBC0", Offset = "0x6ABCBC0", VA = "0x186ABDBC0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> IMDJBGJKDKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD980", Offset = "0x6ABC980", VA = "0x186ABD980")]
		public bool SetRingLayerColor(int AHMOKAPAGAF, Color IODHIPGGADP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDAD0", Offset = "0x6ABCAD0", VA = "0x186ABDAD0")]
		public bool SetRingLayerSize(int AHMOKAPAGAF, float GFFAGBDKDAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD670", Offset = "0x6ABC670", VA = "0x186ABD670", Slot = "12")]
		protected override void GEHHPCPLFDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD7B0", Offset = "0x6ABC7B0", VA = "0x186ABD7B0", Slot = "13")]
		protected override void HFLKDNOAALK(Material JANOPPPMNPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6ABD930", Offset = "0x6ABC930", VA = "0x186ABD930", Slot = "14")]
		protected override void JDCODMHFPIM(Material JANOPPPMNPE, bool IEEBLFDNOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDD10", Offset = "0x6ABCD10", VA = "0x186ABDD10")]
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
		public enum OGMAFKBFMOF
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int EHNNJHPOCDD;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int ADJJIMOLOOK;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int FBDOJLCNHLA;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int HODHDPGDHEL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int IMFHFKMCHEN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int OPBFEPEONGI;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int MIBLBEOMPFL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int IJHGKKKJPHN;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int BOFBNNJPDAB;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int HNIPFDDKFMK;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int ACIMKEBMHCB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int AKAHODBMKFO;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int DCNMOENMHAB;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int NLJNAEFJABH;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int FEIKICMFLFL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int IFDFPHOGCFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[KDKBJHCHPNA(PHHCCEMPGEN.Self, false, false, false)]
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
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
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
		private OGMAFKBFMOF animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[CPAPECLLIGO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[CPAPECLLIGO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic EENJBDBALLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool GJJJHKILBGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite NOJIKLPOGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEE10", Offset = "0x6ABDE10", VA = "0x186ABEE10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6ABF030", Offset = "0x6ABE030", VA = "0x186ABF030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color OPILDKADEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA15810", Offset = "0xA14810", VA = "0x180A15810")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6ABF0C0", Offset = "0x6ABE0C0", VA = "0x186ABF0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color NBFONABBJLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1CAA7C0", Offset = "0x1CA97C0", VA = "0x181CAA7C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEF00", Offset = "0x6ABDF00", VA = "0x186ABEF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float BPELLOPLCMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA7B860", Offset = "0xA7A860", VA = "0x180A7B860")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEFC0", Offset = "0x6ABDFC0", VA = "0x186ABEFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 GKNIPNMNFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEDF0", Offset = "0x6ABDDF0", VA = "0x186ABEDF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEFE0", Offset = "0x6ABDFE0", VA = "0x186ABEFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float KDFBEAEDFDN
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB430", Offset = "0x7DA430", VA = "0x1807DB430")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEF80", Offset = "0x6ABDF80", VA = "0x186ABEF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 ILJBIJGPODH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xB33A50", Offset = "0xB32A50", VA = "0x180B33A50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6ABF140", Offset = "0x6ABE140", VA = "0x186ABF140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float IAPNABOCIDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xB3BDA0", Offset = "0xB3ADA0", VA = "0x180B3BDA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEED0", Offset = "0x6ABDED0", VA = "0x186ABEED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 JAEFDKEMHOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6ABE740", Offset = "0x6ABD740", VA = "0x186ABE740")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public OGMAFKBFMOF LIALMLIJAAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAE6AC0", Offset = "0xAE5AC0", VA = "0x180AE6AC0")]
			get
			{
				return default(OGMAFKBFMOF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEEF0", Offset = "0x6ABDEF0", VA = "0x186ABEEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float GLPFMFBGEGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xC02900", Offset = "0xC01900", VA = "0x180C02900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEFA0", Offset = "0x6ABDFA0", VA = "0x186ABEFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float IEIOBAAJAFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xC02A50", Offset = "0xC01A50", VA = "0x180C02A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEEB0", Offset = "0x6ABDEB0", VA = "0x186ABEEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6ABDFF0", Offset = "0x6ABCFF0", VA = "0x186ABDFF0", Slot = "13")]
		protected override void HFLKDNOAALK(Material JANOPPPMNPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE7D0", Offset = "0x6ABD7D0", VA = "0x186ABE7D0")]
		private void PJMNGNNKGPF(Sprite FEJHBCPDPDB, [Out] Vector2 BCADFGANBCL, [Out] Vector2 JALBNDKOMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6ABE6F0", Offset = "0x6ABD6F0", VA = "0x186ABE6F0", Slot = "14")]
		protected override void JDCODMHFPIM(Material JANOPPPMNPE, bool IEEBLFDNOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6ABED60", Offset = "0x6ABDD60", VA = "0x186ABED60")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader FMHJOOPKJFH;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader FHILKCECOLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6ABF1E0", Offset = "0x6ABE1E0", VA = "0x186ABF1E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6ABF190", Offset = "0x6ABE190", VA = "0x186ABF190")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LLLHOOPIFNP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct DNBNOAAJCPG : IEquatable<DNBNOAAJCPG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component DFKOHNJAKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action MEPBOJEOIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int LLOPMMDOOEH;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component MBAHPDBNFPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x890FA0", Offset = "0x88FFA0", VA = "0x180890FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AB70D0", Offset = "0x6AB60D0", VA = "0x186AB70D0")]
		public DNBNOAAJCPG(Component DFKOHNJAKHM, Action MEPBOJEOIBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6FB0", Offset = "0x6AB5FB0", VA = "0x186AB6FB0")]
		public void EEKCMCCINIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6AB70C0", Offset = "0x6AB60C0", VA = "0x186AB70C0", Slot = "4")]
		public bool Equals(DNBNOAAJCPG JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7030", Offset = "0x6AB6030", VA = "0x186AB7030", Slot = "0")]
		public override bool Equals(object KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BF180", Offset = "0x7BE180", VA = "0x1807BF180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class GEFKNELJJND : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public LLLHOOPIFNP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public GEFKNELJJND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7830", Offset = "0x6AB6830", VA = "0x186AB7830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7BF0", Offset = "0x6AB6BF0", VA = "0x186AB7BF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly DLJPFICMPDE KGCOFKKMBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int FGBDGBBAGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int MPOOCOGHOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> JHGPGBBCBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, DNBNOAAJCPG> OFDNMHPBHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<DNBNOAAJCPG> PMAAEBKNPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<DNBNOAAJCPG> JPNIOJCLAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EOCGEKKEBMP HMMDMDFHICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private MNAMPNMBDHD DMDKNOOKNGO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private MNAMPNMBDHD GFKNEPPHDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6AB9020", Offset = "0x6AB8020", VA = "0x186AB9020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AB9090", Offset = "0x6AB8090", VA = "0x186AB9090")]
	public LLLHOOPIFNP(DLJPFICMPDE KGCOFKKMBML, int FGBDGBBAGOG = -1, int MPOOCOGHOOE = -1, [Optional] Func<Component, float> JHGPGBBCBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8D40", Offset = "0x6AB7D40", VA = "0x186AB8D40")]
	public void MDELBKCCIHP(Component DFKOHNJAKHM, Action LNPIDFLJKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8890", Offset = "0x6AB7890", VA = "0x186AB8890")]
	public void ALCGCLPBOPL(Component DFKOHNJAKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8C60", Offset = "0x6AB7C60", VA = "0x186AB8C60")]
	public bool CNGEPCGNOJF(Component MPHIHJDJBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8A20", Offset = "0x6AB7A20", VA = "0x186AB8A20")]
	private void CHBFIOMHCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8CC0", Offset = "0x6AB7CC0", VA = "0x186AB8CC0")]
	[IteratorStateMachine(typeof(GEFKNELJJND))]
	private IEnumerator<JHIBCIKJMBL> LPKNIAJNDDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x955390", Offset = "0x954390", VA = "0x180955390")]
	[CompilerGenerated]
	private void ABPABBELMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6AB8FA0", Offset = "0x6AB7FA0", VA = "0x186AB8FA0")]
	[CompilerGenerated]
	private float OJINODOFLEO(DNBNOAAJCPG LNPIDFLJKCD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HAHHLKLMFLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	MCLBDKCCDMO IJNBOHGAFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool EOKDILKNCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	MIADACEFMCK<MCLBDKCCDMO> BKKDJCGPNND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MMKNFHEAGFE(MCLBDKCCDMO HLCMCCNPKII, bool BGDBPJDGGNL = false);
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
