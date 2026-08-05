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
				[Cpp2IlInjected.Address(RVA = "0x661A100", Offset = "0x6619300", VA = "0x18661A100")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x661A160", Offset = "0x6619360", VA = "0x18661A160")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x661A080", Offset = "0x6619280", VA = "0x18661A080")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6619D80", Offset = "0x6618F80", VA = "0x186619D80")]
			public void BGIKMPBJMAH(PointerEventData HLMEKEJJPIN, RectTransform ICDPEOIGBCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6619C10", Offset = "0x6618E10", VA = "0x186619C10")]
			public void ACEGFNDFHIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6619F90", Offset = "0x6619190", VA = "0x186619F90")]
			public void NKAGJHPLOGN(PointerEventData HLMEKEJJPIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6619D30", Offset = "0x6618F30", VA = "0x186619D30")]
			public void ACJAOLOOOBE(float PNJHHGDHBEC, RectTransform ICDPEOIGBCO, Vector3 EGJKEDKNNAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly global::HHOBPMOCKMJ<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly global::HHOBPMOCKMJ<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::HHOBPMOCKMJ<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly global::HHOBPMOCKMJ<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly global::HHOBPMOCKMJ<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly EEANDDJEMJC PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData MKFFAHFIAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool EIPCIOCFAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool OGPKCBAHGEJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ANKLAJLDCOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x75D690", Offset = "0x75C890", VA = "0x18075D690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6619370", Offset = "0x6618570", VA = "0x186619370")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GBIDGCFLLMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x11EF510", Offset = "0x11EE710", VA = "0x1811EF510")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6619340", Offset = "0x6618540", VA = "0x186619340")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66192C0", Offset = "0x66184C0", VA = "0x1866192C0")]
		private bool AHMANMMFAAB(PointerEventData OEPDOIOJPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6619920", Offset = "0x6618B20", VA = "0x186619920", Slot = "5")]
		public void OnPointerDown(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66199E0", Offset = "0x6618BE0", VA = "0x1866199E0", Slot = "11")]
		public void OnPointerUp(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6619690", Offset = "0x6618890", VA = "0x186619690", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66193A0", Offset = "0x66185A0", VA = "0x1866193A0", Slot = "7")]
		public void OnBeginDrag(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66194C0", Offset = "0x66186C0", VA = "0x1866194C0", Slot = "4")]
		public void OnDrag(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66195B0", Offset = "0x66187B0", VA = "0x1866195B0", Slot = "8")]
		public void OnEndDrag(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6619980", Offset = "0x6618B80", VA = "0x186619980", Slot = "9")]
		public void OnPointerEnter(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x66199B0", Offset = "0x6618BB0", VA = "0x1866199B0", Slot = "10")]
		public void OnPointerExit(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6619480", Offset = "0x6618680", VA = "0x186619480")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6619A40", Offset = "0x6618C40", VA = "0x186619A40")]
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
		private OptionData GKJMMCILKHK;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6614A80", Offset = "0x6613C80", VA = "0x186614A80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6614970", Offset = "0x6613B70", VA = "0x186614970", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x66148B0", Offset = "0x6613AB0", VA = "0x1866148B0")]
		private void IBNHHPIJFMG(GameObject EPEOJKHOBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6614C60", Offset = "0x6613E60", VA = "0x186614C60")]
		public void SetOptionsWithNoDefault(List<string> MKPAEINNGNE, [Optional] string ONBNNKIGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6614EA0", Offset = "0x66140A0", VA = "0x186614EA0")]
		public void SetOptionsWithNoDefault(List<OptionData> DMMDPMFCBHN, [Optional] string ONBNNKIGOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6614B90", Offset = "0x6613D90", VA = "0x186614B90", Slot = "42")]
		public override void OnPointerClick(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas OHPHAOJKCEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6614F90", Offset = "0x6614190", VA = "0x186614F90")]
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
		private sealed class ILELOBHPMKJ : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private EGGPGCCKPCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public ILELOBHPMKJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x66166B0", Offset = "0x66158B0", VA = "0x1866166B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6616BD0", Offset = "0x6615DD0", VA = "0x186616BD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[MKPBLGADCLO(MFGBMPAPHGB.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly FIHGBEHGLGB BMOEKOGBMNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool EHOGFPHKLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? DFFIJFNCFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? MMLOMNBLJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? KJFFBCOKCEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool PONMMBLOMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool NNJJEPCPDKB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GALOKPNIJNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6615D00", Offset = "0x6614F00", VA = "0x186615D00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool EEMDLKALAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6615CE0", Offset = "0x6614EE0", VA = "0x186615CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OFBDOGEHMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD10800", Offset = "0xD0FA00", VA = "0x180D10800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6615ED0", Offset = "0x66150D0", VA = "0x186615ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PCGCLBGJIMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6615C40", Offset = "0x6614E40", VA = "0x186615C40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6615E30", Offset = "0x6615030", VA = "0x186615E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6615680", Offset = "0x6614880", VA = "0x186615680")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6615A10", Offset = "0x6614C10", VA = "0x186615A10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6615990", Offset = "0x6614B90", VA = "0x186615990")]
		public void Hide(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6615B50", Offset = "0x6614D50", VA = "0x186615B50")]
		public void Show(object IALNODEHBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6615AB0", Offset = "0x6614CB0", VA = "0x186615AB0")]
		public void Set(object IALNODEHBNN, bool GMJGLPNAENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x66157D0", Offset = "0x66149D0", VA = "0x1866157D0")]
		private void GODLBKDFPDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6615720", Offset = "0x6614920", VA = "0x186615720")]
		[IteratorStateMachine(typeof(ILELOBHPMKJ))]
		private IEnumerator<EGGPGCCKPCO> CHJCNNGALMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6615790", Offset = "0x6614990", VA = "0x186615790", Slot = "5")]
		public virtual void DoHideOrShow(bool IMGEJEOIKBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6615BD0", Offset = "0x6614DD0", VA = "0x186615BD0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FLJOLHACIOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7E47C0", Offset = "0x7E39C0", VA = "0x1807E47C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> GKEHKCPMEMF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x66160C0", Offset = "0x66152C0", VA = "0x1866160C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6616200", Offset = "0x6615400", VA = "0x186616200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> PBDNJINOMKL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6616160", Offset = "0x6615360", VA = "0x186616160")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x66162A0", Offset = "0x66154A0", VA = "0x1866162A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6616000", Offset = "0x6615200", VA = "0x186616000", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6616060", Offset = "0x6615260", VA = "0x186616060", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData OEPDOIOJPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1C21AF0", Offset = "0x1C20CF0", VA = "0x181C21AF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1C21AF0", Offset = "0x1C20CF0", VA = "0x181C21AF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ENNMDECGGLP
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum AIOBJLFJIMF
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const AIOBJLFJIMF OIEKNNLIIFN = AIOBJLFJIMF.Light;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string KLGBMBOLMLB = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static BHNJIBDJFAL GNKBICIIAPM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BHNJIBDJFAL PGHHCPJJBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x66151A0", Offset = "0x66143A0", VA = "0x1866151A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static AIOBJLFJIMF IEAKFNMKJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x66152E0", Offset = "0x66144E0", VA = "0x1866152E0")]
		get
		{
			return default(AIOBJLFJIMF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6614FF0", Offset = "0x66141F0", VA = "0x186614FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<AIOBJLFJIMF> HCHAKBIHMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6615480", Offset = "0x6614680", VA = "0x186615480")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6615580", Offset = "0x6614780", VA = "0x186615580")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GOFDGPEDOMB : BBJMJGEGLDN, IMDHGOIPBPP, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	global::BPEPJJDICII<GameObject, int> BOFBLMJFMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	global::CBEFDECGNBJ<GameObject, int, bool> BDIIFHAAJII
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	global::HHOBPMOCKMJ<bool> EMDNCMAAIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool CHHJJENLIBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float HJLMKAGKCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	global::HHOBPMOCKMJ<float> FLGDDMICPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EEANDDJEMJC PDEPCHFNDMF
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
	void SpawnLoadingPlaceholders(GameObject GDEKLMNKJBC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JKHCJAJHGAO Spawn<T>(int PCOLPKMLLNA, IReadOnlyList<T> PCPEJHIMHJJ, GameObject GDEKLMNKJBC);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JKHCJAJHGAO Spawn<T>(int PCOLPKMLLNA, IReadOnlyList<T> PCPEJHIMHJJ, GameObject JGLHNBGOOAM, ref Func<int, GameObject> MMOMAGNKIJJ);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum CCJNIFFJKCG : byte
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
		private static readonly int NCOCEDCDJBB;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<CCJNIFFJKCG, string> BAHHLNJEKPJ;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int JJDJLIEAAJE = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int CPGNKJOOEFG;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int DCBMJDFHNGI;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int DOGGIOJCIGA;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int LDDNIBBBEJC;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int JDHMFAGHHBL;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int ADNHGEFHKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool DHGLFCOJKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool FBEMNLIKMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Color[] CIOJHDMPBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private CCJNIFFJKCG type;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly CCJNIFFJKCG[] CNKLHHEFNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[OBHHMAKEOMB("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly CCJNIFFJKCG[] KEBFIFECDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[OBHHMAKEOMB("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[Range(0f, 360f)]
		[OBHHMAKEOMB("type", (byte)4)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[OBHHMAKEOMB("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic NNFJPHFHBCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool DIJJLAGMFPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient MAHABBPDEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x75F110", Offset = "0x75E310", VA = "0x18075F110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6619110", Offset = "0x6618310", VA = "0x186619110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public CCJNIFFJKCG MMMENNAAGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6FD200", Offset = "0x6FC400", VA = "0x1806FD200")]
			get
			{
				return default(CCJNIFFJKCG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6619290", Offset = "0x6618490", VA = "0x186619290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool KJLJNOKNCJD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6618030", Offset = "0x6617230", VA = "0x186618030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 PJGJPKCAGBN
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x66190A0", Offset = "0x66182A0", VA = "0x1866190A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x66190C0", Offset = "0x66182C0", VA = "0x1866190C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool IDLIGOMJLMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6618AF0", Offset = "0x6617CF0", VA = "0x186618AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 EAFCCNDHBHA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x631EAB0", Offset = "0x631DCB0", VA = "0x18631EAB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6619240", Offset = "0x6618440", VA = "0x186619240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KLECOKAKELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x15B09E0", Offset = "0x15AFBE0", VA = "0x1815B09E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x15B0B40", Offset = "0x15AFD40", VA = "0x1815B0B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 FDGLGCEMCGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6618AA0", Offset = "0x6617CA0", VA = "0x186618AA0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 PBINOMKLADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6618B70", Offset = "0x6617D70", VA = "0x186618B70")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float OMBFAMLJBCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE5D200", Offset = "0xE5C400", VA = "0x180E5D200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x66192A0", Offset = "0x66184A0", VA = "0x1866192A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6618220", Offset = "0x6617420", VA = "0x186618220", Slot = "12")]
		protected override void FALCNIOLFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x66180B0", Offset = "0x66172B0", VA = "0x1866180B0")]
		private void BPMJKHGKEIG(Color[] FOIHMCAGNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x66183A0", Offset = "0x66175A0", VA = "0x1866183A0", Slot = "13")]
		protected override void FGAONLCMEDL(Material PMPDPBDKGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6617E10", Offset = "0x6617010", VA = "0x186617E10", Slot = "14")]
		protected override void ADNDKMHEDAN(Material PMPDPBDKGPF, bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6618FE0", Offset = "0x66181E0", VA = "0x186618FE0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly KJHMHEKDNED GLKIEFCMBDN;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static Sprite KPPFKEPNIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Material HGKFDAPHMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material PGEBOJFFOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool PLHDNDIGNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool EHOGFPHKLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool BNCBMLAFABF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool ABFFCJOFLNM;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic NNFJPHFHBCO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader MFKNCGPFMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool DIJJLAGMFPO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool CGKIPGDKJMM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform ICDPEOIGBCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x661A580", Offset = "0x6619780", VA = "0x18661A580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect NBDKOBOHOEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x661A400", Offset = "0x6619600", VA = "0x18661A400")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite KBFKEGMJCGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x661A5E0", Offset = "0x66197E0", VA = "0x18661A5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x661A210", Offset = "0x6619410", VA = "0x18661A210", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x661B200", Offset = "0x661A400", VA = "0x18661B200", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x661B520", Offset = "0x661A720", VA = "0x18661B520", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x661B3B0", Offset = "0x661A5B0", VA = "0x18661B3B0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x661A7E0", Offset = "0x66199E0", VA = "0x18661A7E0")]
		private void GGEKDLHKGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x661AE30", Offset = "0x661A030", VA = "0x18661AE30")]
		private void MHJOIBPPBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x661A7B0", Offset = "0x66199B0", VA = "0x18661A7B0")]
		private void FBDBKMFNHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x661A530", Offset = "0x6619730", VA = "0x18661A530")]
		private void DPLFHHICFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x661AF90", Offset = "0x661A190", VA = "0x18661AF90")]
		protected void OJOCAKGHBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x661ACF0", Offset = "0x6619EF0", VA = "0x18661ACF0")]
		private void MCENCJOEPIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "12")]
		protected virtual void FALCNIOLFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "13")]
		protected virtual void FGAONLCMEDL(Material PMPDPBDKGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "14")]
		protected virtual void ADNDKMHEDAN(Material PMPDPBDKGPF, bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x661A960", Offset = "0x6619B60", VA = "0x18661A960")]
		private void MBPGJGNHFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		[Conditional("RRUI_PROFILING")]
		protected void CMEHHLINEPE(string IEACNHGAIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
		[Conditional("RRUI_PROFILING")]
		protected void GMJNADOCBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x12B950", Offset = "0x12AD50")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int FNNLNLLFJHP;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int GMCIIMJIKLN;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int ODIPDJJFGJC;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int MENOMHDBIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
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
		private Color[] CIOJHDMPBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private float[] PAIFKMJAGPA;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic NNFJPHFHBCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool CGKIPGDKJMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> MDOFEHNHANA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 PJGJPKCAGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x4175360", Offset = "0x4174560", VA = "0x184175360")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x661BF00", Offset = "0x661B100", VA = "0x18661BF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x661BC00", Offset = "0x661AE00", VA = "0x18661BC00")]
		public void SetRingLayers(IReadOnlyList<RingLayer> PMOPJFGNKGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x661B9E0", Offset = "0x661ABE0", VA = "0x18661B9E0")]
		public bool SetRingLayerColor(int KOADGMIKBAB, Color HMCAFGCGFJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x661BAF0", Offset = "0x661ACF0", VA = "0x18661BAF0")]
		public bool SetRingLayerSize(int KOADGMIKBAB, float CAPKFCHDLFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x661B6F0", Offset = "0x661A8F0", VA = "0x18661B6F0", Slot = "12")]
		protected override void FALCNIOLFBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x661B860", Offset = "0x661AA60", VA = "0x18661B860", Slot = "13")]
		protected override void FGAONLCMEDL(Material PMPDPBDKGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x661B6A0", Offset = "0x661A8A0", VA = "0x18661B6A0", Slot = "14")]
		protected override void ADNDKMHEDAN(Material PMPDPBDKGPF, bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x661BD50", Offset = "0x661AF50", VA = "0x18661BD50")]
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
		public enum PNMBGEJMLJH
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int JHMKPCOOAFK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int GIIJDAOIOOB;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int LMKKMMDLNNC;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int BABFDOLIGDP;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int FHALBCKOENN;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int OBKKCGIIJKD;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int NKNDPHJBJEM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int GKLJDCILIPN;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int FJHBPCNNIEO;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int KNGFAMOOGPD;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int FJLOCDFJKGA;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int AMGELAMGOEJ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int PAAAGNLOLND;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int AOIIGINMJGP;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int NJDPMNIICFL;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int KEOLHOAPIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
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
		private PNMBGEJMLJH animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[OBHHMAKEOMB("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[OBHHMAKEOMB("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic NNFJPHFHBCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool CGKIPGDKJMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite BIGKLGIADJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x661CCD0", Offset = "0x661BED0", VA = "0x18661CCD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x661CEE0", Offset = "0x661C0E0", VA = "0x18661CEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color DNOFEBMFOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x908EE0", Offset = "0x9080E0", VA = "0x180908EE0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x661CF80", Offset = "0x661C180", VA = "0x18661CF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color JGBBFOAFLHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x13FDC80", Offset = "0x13FCE80", VA = "0x1813FDC80")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x661CDD0", Offset = "0x661BFD0", VA = "0x18661CDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float IANJGNNBCKD
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x945C60", Offset = "0x944E60", VA = "0x180945C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x661CE70", Offset = "0x661C070", VA = "0x18661CE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 KOLLEJCLNIF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xD4D6E0", Offset = "0xD4C8E0", VA = "0x180D4D6E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x661CE90", Offset = "0x661C090", VA = "0x18661CE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float DPPCOOILPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1E2C450", Offset = "0x1E2B650", VA = "0x181E2C450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x661CE30", Offset = "0x661C030", VA = "0x18661CE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 NIOCADENHED
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1DF2550", Offset = "0x1DF1750", VA = "0x181DF2550")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x661CFE0", Offset = "0x661C1E0", VA = "0x18661CFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float BHEHOHBPFEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCEC000", Offset = "0xCEB200", VA = "0x180CEC000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x661CDA0", Offset = "0x661BFA0", VA = "0x18661CDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 NMCHJCNHDON
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x661C8E0", Offset = "0x661BAE0", VA = "0x18661C8E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public PNMBGEJMLJH BJEJFNAJHFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xB4ADA0", Offset = "0xB49FA0", VA = "0x180B4ADA0")]
			get
			{
				return default(PNMBGEJMLJH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x661CDC0", Offset = "0x661BFC0", VA = "0x18661CDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float KOHEPEMJFAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1665220", Offset = "0x1664420", VA = "0x181665220")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x661CE50", Offset = "0x661C050", VA = "0x18661CE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float IOEEBFBGMDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD4D690", Offset = "0xD4C890", VA = "0x180D4D690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x661CD80", Offset = "0x661BF80", VA = "0x18661CD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x661BFA0", Offset = "0x661B1A0", VA = "0x18661BFA0", Slot = "13")]
		protected override void FGAONLCMEDL(Material PMPDPBDKGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x661C660", Offset = "0x661B860", VA = "0x18661C660")]
		private void ICCEDLOGJHK(Sprite DLADPCHJMME, out Vector2 KBBLLKLIEEN, out Vector2 HDLGENBDACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x661BF50", Offset = "0x661B150", VA = "0x18661BF50", Slot = "14")]
		protected override void ADNDKMHEDAN(Material PMPDPBDKGPF, bool BFDBCMGIOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x661CC30", Offset = "0x661BE30", VA = "0x18661CC30")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static Shader IKKHKMPKEMA;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader MFKNCGPFMKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x661D090", Offset = "0x661C290", VA = "0x18661D090", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x661D030", Offset = "0x661C230", VA = "0x18661D030")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KJHMHEKDNED
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct PCFDKHJIKGH : IEquatable<PCFDKHJIKGH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly Component DELCOFCGDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly Action CPEPPFGGGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly int LBOAHBOIDKK;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component DLFKMDFDAFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6617CF0", Offset = "0x6616EF0", VA = "0x186617CF0")]
		public PCFDKHJIKGH(Component DELCOFCGDFF, Action CPEPPFGGGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6617BD0", Offset = "0x6616DD0", VA = "0x186617BD0")]
		public void EJFONCHDJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6617C50", Offset = "0x6616E50", VA = "0x186617C50", Slot = "4")]
		public bool Equals(PCFDKHJIKGH HNPEBINPOBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6617C60", Offset = "0x6616E60", VA = "0x186617C60", Slot = "0")]
		public override bool Equals(object ICHBECDKHOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F6400", Offset = "0x6F5600", VA = "0x1806F6400", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IBMKIAFCHJG : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private EGGPGCCKPCO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public KJHMHEKDNED <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
		[DebuggerHidden]
		public IBMKIAFCHJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6616340", Offset = "0x6615540", VA = "0x186616340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6616670", Offset = "0x6615870", VA = "0x186616670", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly BCMGJKLABJG.JLNFNLIFHIN IBKPKCDHGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int OLHFBNMELAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly int LHFPKEPKCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Func<Component, float> PJIGFLJFHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<Component, PCFDKHJIKGH> KOBLJGKFHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LinkedList<PCFDKHJIKGH> IDFNJLFDFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<PCFDKHJIKGH> MPDBCGGCBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private LKGILLBEJEK FANHAEPNAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private ABLBCPBEONM FAPBHCBDCFF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private ABLBCPBEONM JGEOGMFPMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6617310", Offset = "0x6616510", VA = "0x186617310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6617440", Offset = "0x6616640", VA = "0x186617440")]
	public KJHMHEKDNED(BCMGJKLABJG.JLNFNLIFHIN IBKPKCDHGOL, int OLHFBNMELAB = -1, int LHFPKEPKCPK = -1, [Optional] Func<Component, float> PJIGFLJFHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6617040", Offset = "0x6616240", VA = "0x186617040")]
	public void HOEAIIFHKPN(Component DELCOFCGDFF, Action MCDNLHIFOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6616C10", Offset = "0x6615E10", VA = "0x186616C10")]
	public void EGFMELPELNH(Component DELCOFCGDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x66172B0", Offset = "0x66164B0", VA = "0x1866172B0")]
	public bool MLNBBLEDAHI(Component KLEOIMLJIAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6616E10", Offset = "0x6616010", VA = "0x186616E10")]
	private void FOAPBMIPAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6616DA0", Offset = "0x6615FA0", VA = "0x186616DA0")]
	[IteratorStateMachine(typeof(IBMKIAFCHJG))]
	private IEnumerator<EGGPGCCKPCO> FEFKHELIPOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xDBB580", Offset = "0xDBA780", VA = "0x180DBB580")]
	[CompilerGenerated]
	private void NCEFGCKDHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6617380", Offset = "0x6616580", VA = "0x186617380")]
	[CompilerGenerated]
	private float PGBJNNFHILN(PCFDKHJIKGH MCDNLHIFOLF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EBHFGBFDGJM
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DCCDAPLPICN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	HGMGOPODGJN NEHNMJKEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool NKJEAPHAJML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	global::HHOBPMOCKMJ<HGMGOPODGJN> MENDECICLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEODHBOENKA(HGMGOPODGJN EHNMJKJBBBE, bool JCKJPDHHFPO = false);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x66175A0", Offset = "0x66167A0", VA = "0x1866175A0")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x66176B0", Offset = "0x66168B0", VA = "0x1866176B0")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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
