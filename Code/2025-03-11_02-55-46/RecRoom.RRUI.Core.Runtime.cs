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
				[Cpp2IlInjected.Address(RVA = "0x7F81550", Offset = "0x7F80950", VA = "0x187F81550")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x7F815B0", Offset = "0x7F809B0", VA = "0x187F815B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7F81510", Offset = "0x7F80910", VA = "0x187F81510")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7F81410", Offset = "0x7F80810", VA = "0x187F81410")]
			public void JNCMKEIDHDE(PointerEventData AGAKCEIGPMF, RectTransform DEDAHKMFHPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7F81130", Offset = "0x7F80530", VA = "0x187F81130")]
			public void GKIPBEGCOKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F81050", Offset = "0x7F80450", VA = "0x187F81050")]
			public void BEHNHMFOCML(PointerEventData AGAKCEIGPMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7F813C0", Offset = "0x7F807C0", VA = "0x187F813C0")]
			public void IGGPIPIBMME(float AOPNOGCPBDD, RectTransform DEDAHKMFHPB, Vector3 ODMGDEIMGFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly CLNABAPAGFB<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly CLNABAPAGFB<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly CLNABAPAGFB<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly CLNABAPAGFB<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly CLNABAPAGFB<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly EBGLFEEDNOA PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData OGCABMCJPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool OGLENFBKMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool IDLJEBKHFDL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PHMOENDIKLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x96E0B0", Offset = "0x96D4B0", VA = "0x18096E0B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7F807E0", Offset = "0x7F7FBE0", VA = "0x187F807E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KCHLLNGNBDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x96E0D0", Offset = "0x96D4D0", VA = "0x18096E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7F80890", Offset = "0x7F7FC90", VA = "0x187F80890")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F80810", Offset = "0x7F7FC10", VA = "0x187F80810")]
		private bool MLMNFIOGAPC(PointerEventData CDDCIHICHEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F80D10", Offset = "0x7F80110", VA = "0x187F80D10", Slot = "5")]
		public void OnPointerDown(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F80DD0", Offset = "0x7F801D0", VA = "0x187F80DD0", Slot = "11")]
		public void OnPointerUp(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F80B80", Offset = "0x7F7FF80", VA = "0x187F80B80", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F808C0", Offset = "0x7F7FCC0", VA = "0x187F808C0", Slot = "7")]
		public void OnBeginDrag(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F809D0", Offset = "0x7F7FDD0", VA = "0x187F809D0", Slot = "4")]
		public void OnDrag(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F80AB0", Offset = "0x7F7FEB0", VA = "0x187F80AB0", Slot = "8")]
		public void OnEndDrag(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F80D70", Offset = "0x7F80170", VA = "0x187F80D70", Slot = "9")]
		public void OnPointerEnter(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F80DA0", Offset = "0x7F801A0", VA = "0x187F80DA0", Slot = "10")]
		public void OnPointerExit(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F80990", Offset = "0x7F7FD90", VA = "0x187F80990")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F80E30", Offset = "0x7F80230", VA = "0x187F80E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F7C680", Offset = "0x7F7BA80", VA = "0x187F7C680")]
		public void SetCanvasSortingOrder(short MHJEDCLFCIL, bool JLKBCNNCHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData CBNIBAPBHNH;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F7C940", Offset = "0x7F7BD40", VA = "0x187F7C940", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7C820", Offset = "0x7F7BC20", VA = "0x187F7C820", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F7C770", Offset = "0x7F7BB70", VA = "0x187F7C770")]
		private void ECMCHJPGKDP(GameObject CNLPOMCANCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F7CC20", Offset = "0x7F7C020", VA = "0x187F7CC20")]
		public void SetOptionsWithNoDefault(List<string> JPGIMCGBJEJ, [Optional] string DANMMIEOGML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F7CB30", Offset = "0x7F7BF30", VA = "0x187F7CB30")]
		public void SetOptionsWithNoDefault(List<OptionData> OMCEIGOCOKM, [Optional] string DANMMIEOGML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F7CA60", Offset = "0x7F7BE60", VA = "0x187F7CA60", Slot = "42")]
		public override void OnPointerClick(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas DIEINJNHFIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F7CE40", Offset = "0x7F7C240", VA = "0x187F7CE40")]
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
		private sealed class GMNFGMBNJHI : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private MOLDBMJPKNN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
			[DebuggerHidden]
			public GMNFGMBNJHI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7F7D7D0", Offset = "0x7F7CBD0", VA = "0x187F7D7D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7F7DCE0", Offset = "0x7F7D0E0", VA = "0x187F7DCE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[NMHMDFOPAOE(MFMOBKOPAIF.Self, false, false, false)]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly NHILLDJBJNG<object> JBDLCGAGEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool DOJCLEBHGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? HAKGIIOEILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? AMMBPODJPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? FBAAOJNNINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool KBELJLELFCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool APNJKPGGFCO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool OJAJEPKOEKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E3E0", Offset = "0x7F7D7E0", VA = "0x187F7E3E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IGPLJBHPNAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E390", Offset = "0x7F7D790", VA = "0x187F7E390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IAJNEENDNHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9B1790", Offset = "0x9B0B90", VA = "0x1809B1790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E5A0", Offset = "0x7F7D9A0", VA = "0x187F7E5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GNJNDMPDJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E2F0", Offset = "0x7F7D6F0", VA = "0x187F7E2F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E500", Offset = "0x7F7D900", VA = "0x187F7E500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7DD30", Offset = "0x7F7D130", VA = "0x187F7DD30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E0D0", Offset = "0x7F7D4D0", VA = "0x187F7E0D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E080", Offset = "0x7F7D480", VA = "0x187F7E080")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F7DE70", Offset = "0x7F7D270", VA = "0x187F7DE70")]
		public void Hide(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E250", Offset = "0x7F7D650", VA = "0x187F7E250")]
		public void Show(object OCDOGNMJENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E160", Offset = "0x7F7D560", VA = "0x187F7E160")]
		public void Set(object OCDOGNMJENC, bool GCFILMOGIIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F7DDC0", Offset = "0x7F7D1C0", VA = "0x187F7DDC0")]
		public void Clear(bool HBFDMDDGGHG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F7DE80", Offset = "0x7F7D280", VA = "0x187F7DE80")]
		private void JEACPNAFHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E000", Offset = "0x7F7D400", VA = "0x187F7E000")]
		[IteratorStateMachine(typeof(GMNFGMBNJHI))]
		private IEnumerator<MOLDBMJPKNN> JJIDECKOIDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F7DE30", Offset = "0x7F7D230", VA = "0x187F7DE30", Slot = "5")]
		public virtual void DoHideOrShow(bool LJIGBPCCEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E260", Offset = "0x7F7D660", VA = "0x187F7E260")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FAFJCHIPAGN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xC02DE0", Offset = "0xC021E0", VA = "0x180C02DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x970B00", Offset = "0x96FF00", VA = "0x180970B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> CDAPHAHKFAO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E700", Offset = "0x7F7DB00", VA = "0x187F7E700")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E860", Offset = "0x7F7DC60", VA = "0x187F7E860")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> BODGAOKBDOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E7B0", Offset = "0x7F7DBB0", VA = "0x187F7E7B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7F7E910", Offset = "0x7F7DD10", VA = "0x187F7E910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E6C0", Offset = "0x7F7DAC0", VA = "0x187F7E6C0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E6E0", Offset = "0x7F7DAE0", VA = "0x187F7E6E0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData CDDCIHICHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x158BB30", Offset = "0x158AF30", VA = "0x18158BB30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x158BB30", Offset = "0x158AF30", VA = "0x18158BB30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GFHHMJFMJAI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum HNMPNMPINEL
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static MPOANHNJNCL IPNEPCJFAGH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static MPOANHNJNCL KDFHOPFBABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F7D2A0", Offset = "0x7F7C6A0", VA = "0x187F7D2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static HNMPNMPINEL LKEKCPMHBAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F7D3A0", Offset = "0x7F7C7A0", VA = "0x187F7D3A0")]
		get
		{
			return default(HNMPNMPINEL);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7D670", Offset = "0x7F7CA70", VA = "0x187F7D670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<HNMPNMPINEL> BICMBNDFJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7F7D4D0", Offset = "0x7F7C8D0", VA = "0x187F7D4D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F7D5A0", Offset = "0x7F7C9A0", VA = "0x187F7D5A0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NCHKPKBMENI : IIKIAJLFCKP, ACPFPNAHMGL, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, EKPOJKFMBNO
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EBGLFEEDNOA OAIOOLKDNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NFJKMPPPDKA Clear();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject EPNPEBHIEBC);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NFJKMPPPDKA Spawn<T>(int IMFFGHJBIEO, IReadOnlyList<T> MJFOKKFMONL, GameObject EPNPEBHIEBC);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NFJKMPPPDKA Spawn<T>(int IMFFGHJBIEO, IReadOnlyList<T> MJFOKKFMONL, GameObject GJOGFIIOJNE, Func<int, GameObject> ELMPJAHBAJK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int FFCBHHABFJN, float BAPBFMKLGHN);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum EMFNCHOFCFD : byte
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
		private static readonly int FNPCJMNFFPF;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<EMFNCHOFCFD, string> APOPCCLLOPN;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int CHJNCACCFIG = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int MHBFNAKLKCD;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int NPHDNONKNHD;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int JEBHIJLHFNP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int LLLEEKNKDFD;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int AFFMGKJCCNP;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int LEJBFHFKOLK;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int EAKMIHDILCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool AMNHPCCLEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool DDFLCAHOEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Color[] LNEBFJGBNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private EMFNCHOFCFD type;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly EMFNCHOFCFD[] HFMNLGEFHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[OLNOPNKGMIO("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly EMFNCHOFCFD[] MMLBAKPJPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[OLNOPNKGMIO("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[OLNOPNKGMIO("type", EMFNCHOFCFD.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[OLNOPNKGMIO("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic NOJPFECDDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool NAPHBLPNINA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient FNNOGNALENC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7F80630", Offset = "0x7F7FA30", VA = "0x187F80630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public EMFNCHOFCFD ELLKCGJJEKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69C00", VA = "0x180B6A800")]
			get
			{
				return default(EMFNCHOFCFD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7F807B0", Offset = "0x7F7FBB0", VA = "0x187F807B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool LBLKCLHGIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7F7F010", Offset = "0x7F7E410", VA = "0x187F7F010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 AKBPDHFGDOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7F805A0", Offset = "0x7F7F9A0", VA = "0x187F805A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7F805E0", Offset = "0x7F7F9E0", VA = "0x187F805E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool NHBGILOHOHM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7F800A0", Offset = "0x7F7F4A0", VA = "0x187F800A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 OJKGCKCDMHD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7F805C0", Offset = "0x7F7F9C0", VA = "0x187F805C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7F80760", Offset = "0x7F7FB60", VA = "0x187F80760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float OKCBCMAOFGF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB8D090", Offset = "0xB8C490", VA = "0x180B8D090")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1F9B220", Offset = "0x1F9A620", VA = "0x181F9B220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 AJGAAMJNBKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7F7FFE0", Offset = "0x7F7F3E0", VA = "0x187F7FFE0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 KGJHFMEFDIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7F80030", Offset = "0x7F7F430", VA = "0x187F80030")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float OFFMKMGKMOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x980F60", Offset = "0x980360", VA = "0x180980F60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7F807C0", Offset = "0x7F7FBC0", VA = "0x187F807C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7F7F210", Offset = "0x7F7E610", VA = "0x187F7F210", Slot = "12")]
		protected override void CKCFDCLKBEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7F7F080", Offset = "0x7F7E480", VA = "0x187F7F080")]
		private void BHEOGBCAMOL(Color[] MPHEILABLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F7F3B0", Offset = "0x7F7E7B0", VA = "0x187F7F3B0", Slot = "13")]
		protected override void FBCCEKDOBMJ(Material GIEDFKFHBFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F7FDC0", Offset = "0x7F7F1C0", VA = "0x187F7FDC0", Slot = "14")]
		protected override void FNNFKADIPFI(Material GIEDFKFHBFF, bool KFMEJIELJKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F804F0", Offset = "0x7F7F8F0", VA = "0x187F804F0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly AHDJAPBKEBL GBBBPGEHLHI;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Sprite DMIPEMFFOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material CNAIGKNJOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material MMCBMDPFDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool LAFHBJNDBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool DOJCLEBHGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool CJICLCFEKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool OPIAJCAOICH;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic NOJPFECDDKE
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader BNNFOBGDEFN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool NAPHBLPNINA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool PKANDLBHGFF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform DEDAHKMFHPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7F82A10", Offset = "0x7F81E10", VA = "0x187F82A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect CHEHLBPEMOL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7F825E0", Offset = "0x7F819E0", VA = "0x187F825E0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite JAADDMOGCFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7F823D0", Offset = "0x7F817D0", VA = "0x187F823D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F81A00", Offset = "0x7F80E00", VA = "0x187F81A00", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7F82700", Offset = "0x7F81B00", VA = "0x187F82700", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F82A00", Offset = "0x7F81E00", VA = "0x187F82A00", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F828B0", Offset = "0x7F81CB0", VA = "0x187F828B0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F82080", Offset = "0x7F81480", VA = "0x187F82080")]
		private void DKJMPFGEGPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F82210", Offset = "0x7F81610", VA = "0x187F82210")]
		private void EOIMMKKKDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F825B0", Offset = "0x7F819B0", VA = "0x187F825B0")]
		private void KLAGHEMLGMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7F82380", Offset = "0x7F81780", VA = "0x187F82380")]
		private void GBMPMFNJAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7F817A0", Offset = "0x7F80BA0", VA = "0x187F817A0")]
		protected void ANHFINADCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F81BF0", Offset = "0x7F80FF0", VA = "0x187F81BF0")]
		private void COKJOLMACIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "12")]
		protected virtual void CKCFDCLKBEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "13")]
		protected virtual void FBCCEKDOBMJ(Material GIEDFKFHBFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "14")]
		protected virtual void FNNFKADIPFI(Material GIEDFKFHBFF, bool KFMEJIELJKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F81D30", Offset = "0x7F81130", VA = "0x187F81D30")]
		private void DBABKBMGPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
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
		private static readonly int CFEEELCDAJM;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int PBAKJOJEJPF;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int ADKJEHIMIJJ;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int GODNOIMPEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
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
		private Color[] LNEBFJGBNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private float[] IEJMILOADFH;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic NOJPFECDDKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool PKANDLBHGFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> HLKFLJPHKOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 AKBPDHFGDOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7F83550", Offset = "0x7F82950", VA = "0x187F83550")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7F83570", Offset = "0x7F82970", VA = "0x187F83570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F83150", Offset = "0x7F82550", VA = "0x187F83150")]
		public void SetRingLayers(IReadOnlyList<RingLayer> KBNICALDAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7F82F10", Offset = "0x7F82310", VA = "0x187F82F10")]
		public bool SetRingLayerColor(int AEPPPPJLFAJ, Color MLLLJKFOPGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7F83060", Offset = "0x7F82460", VA = "0x187F83060")]
		public bool SetRingLayerSize(int AEPPPPJLFAJ, float NBPEDBIONNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F82C10", Offset = "0x7F82010", VA = "0x187F82C10", Slot = "12")]
		protected override void CKCFDCLKBEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7F82D50", Offset = "0x7F82150", VA = "0x187F82D50", Slot = "13")]
		protected override void FBCCEKDOBMJ(Material GIEDFKFHBFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F82EC0", Offset = "0x7F822C0", VA = "0x187F82EC0", Slot = "14")]
		protected override void FNNFKADIPFI(Material GIEDFKFHBFF, bool KFMEJIELJKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7F832A0", Offset = "0x7F826A0", VA = "0x187F832A0")]
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
		public enum APEBIIDICIC
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int IJKDLNOMHGN;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int DJJAIBFCJND;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int LFMOFADDGKA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int ILOOJCOIJJP;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int ADGCHFAJEME;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int OADOKAOCMPF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int LIIKAPAAIGP;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int DHCEKPAOLBF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int LCBJJGMNABI;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int IOMCBDJGPAJ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int KCDBNPGGBNB;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int MMHNFCBDAAF;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int MMELLNLKMFJ;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int BKFMIPNBPDA;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int HOIPKFNBBNG;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int CAELEFOKHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
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
		private APEBIIDICIC animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[OLNOPNKGMIO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[OLNOPNKGMIO("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic NOJPFECDDKE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool PKANDLBHGFF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite PKMMNENHBMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7F84370", Offset = "0x7F83770", VA = "0x187F84370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7F84590", Offset = "0x7F83990", VA = "0x187F84590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color DCPHDMJALFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xDAD2F0", Offset = "0xDAC6F0", VA = "0x180DAD2F0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7F84620", Offset = "0x7F83A20", VA = "0x187F84620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color AFDAPMFACOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xF4DC60", Offset = "0xF4D060", VA = "0x180F4DC60")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7F84460", Offset = "0x7F83860", VA = "0x187F84460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float NHBHMFBKIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB8DA90", Offset = "0xB8CE90", VA = "0x180B8DA90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7F84520", Offset = "0x7F83920", VA = "0x187F84520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 GLENMENBKMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7F84350", Offset = "0x7F83750", VA = "0x187F84350")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7F84540", Offset = "0x7F83940", VA = "0x187F84540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float CDNMPCJCEBO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x980BC0", Offset = "0x97FFC0", VA = "0x180980BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7F844E0", Offset = "0x7F838E0", VA = "0x187F844E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 IPEIEGLFJCP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x133ED00", Offset = "0x133E100", VA = "0x18133ED00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7F846A0", Offset = "0x7F83AA0", VA = "0x187F846A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float CDBKKMNNKEO
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xF394A0", Offset = "0xF388A0", VA = "0x180F394A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7F84430", Offset = "0x7F83830", VA = "0x187F84430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 COHJAFDOGJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7F83F80", Offset = "0x7F83380", VA = "0x187F83F80")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public APEBIIDICIC LPPBAICJFNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xD446D0", Offset = "0xD43AD0", VA = "0x180D446D0")]
			get
			{
				return default(APEBIIDICIC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7F84450", Offset = "0x7F83850", VA = "0x187F84450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float JHKGAPANKCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x14C3750", Offset = "0x14C2B50", VA = "0x1814C3750")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7F84500", Offset = "0x7F83900", VA = "0x187F84500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float LNDOJLEAAHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1450DD0", Offset = "0x14501D0", VA = "0x181450DD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7F84410", Offset = "0x7F83810", VA = "0x187F84410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F83870", Offset = "0x7F82C70", VA = "0x187F83870", Slot = "13")]
		protected override void FBCCEKDOBMJ(Material GIEDFKFHBFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F835C0", Offset = "0x7F829C0", VA = "0x187F835C0")]
		private void BEMFCLDLFKI(Sprite AMOKLCAMJCD, [Out] Vector2 IILEJKPOOED, [Out] Vector2 NHOAMBHKLCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F83F30", Offset = "0x7F83330", VA = "0x187F83F30", Slot = "14")]
		protected override void FNNFKADIPFI(Material GIEDFKFHBFF, bool KFMEJIELJKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F842C0", Offset = "0x7F836C0", VA = "0x187F842C0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Shader EPMFNOPJPLB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader BNNFOBGDEFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7F84740", Offset = "0x7F83B40", VA = "0x187F84740", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F846F0", Offset = "0x7F83AF0", VA = "0x187F846F0")]
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
		private SerializableRectTransform HJPGLFCFBBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool NKIFIFPPAIH;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F7EB50", Offset = "0x7F7DF50", VA = "0x187F7EB50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F7EE30", Offset = "0x7F7E230", VA = "0x187F7EE30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F7EDB0", Offset = "0x7F7E1B0", VA = "0x187F7EDB0")]
		private void ONIAPFLJENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F7ECE0", Offset = "0x7F7E0E0", VA = "0x187F7ECE0")]
		private void JEACPNAFHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AHDJAPBKEBL
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct NLBIGPELAGM : IEquatable<NLBIGPELAGM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Component MEBLJIBNLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Action DGLFFHNJMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int HJCEBMFGMGN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component LMHKBJEFPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F7EAE0", Offset = "0x7F7DEE0", VA = "0x187F7EAE0")]
		public NLBIGPELAGM(Component MEBLJIBNLCL, Action DGLFFHNJMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F7EA60", Offset = "0x7F7DE60", VA = "0x187F7EA60")]
		public void HPGKBBIDPFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F7EA50", Offset = "0x7F7DE50", VA = "0x187F7EA50", Slot = "4")]
		public bool Equals(NLBIGPELAGM MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E9C0", Offset = "0x7F7DDC0", VA = "0x187F7E9C0", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class FGAFIIBCMPE : IEnumerator<MOLDBMJPKNN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private MOLDBMJPKNN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AHDJAPBKEBL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private MOLDBMJPKNN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x968E30", Offset = "0x968230", VA = "0x180968E30")]
		[DebuggerHidden]
		public FGAFIIBCMPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F7CE90", Offset = "0x7F7C290", VA = "0x187F7CE90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F7D250", Offset = "0x7F7C650", VA = "0x187F7D250", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JEDLKJBGEAA LPAKMFJLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int NPGFGFEPGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int KMMNAAGJGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Func<Component, float> BGJBMKBIIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<Component, NLBIGPELAGM> EKAHHHIGHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<NLBIGPELAGM> BPBDMNMOFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly List<NLBIGPELAGM> JHNFDOPMHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private DCOKPPOHOJG ENBJPKFAAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private EHMJCCEKJHN EKKPBAMFNGK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private EHMJCCEKJHN CIBOJIKFCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BD50", Offset = "0x7F7B150", VA = "0x187F7BD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F7C500", Offset = "0x7F7B900", VA = "0x187F7C500")]
	public AHDJAPBKEBL(JEDLKJBGEAA LPAKMFJLCDO, int NPGFGFEPGEN = -1, int KMMNAAGJGEK = -1, [Optional] Func<Component, float> BGJBMKBIIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BDE0", Offset = "0x7F7B1E0", VA = "0x187F7BDE0")]
	public void JJHEGCCIACM(Component MEBLJIBNLCL, Action IFKMLHMDOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F7C370", Offset = "0x7F7B770", VA = "0x187F7C370")]
	public void PFPNOODCNNA(Component MEBLJIBNLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F7C060", Offset = "0x7F7B460", VA = "0x187F7C060")]
	public bool KMACJKJJFDC(Component LENGNFMPCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F7C0C0", Offset = "0x7F7B4C0", VA = "0x187F7C0C0")]
	private void LDNEAJNFANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BCD0", Offset = "0x7F7B0D0", VA = "0x187F7BCD0")]
	[IteratorStateMachine(typeof(FGAFIIBCMPE))]
	private IEnumerator<MOLDBMJPKNN> FLFGDMKFIJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xB88720", Offset = "0xB87B20", VA = "0x180B88720")]
	[CompilerGenerated]
	private void NBNAHPJKMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F7C2F0", Offset = "0x7F7B6F0", VA = "0x187F7C2F0")]
	[CompilerGenerated]
	private float NBKBALJAIAN(NLBIGPELAGM IFKMLHMDOLM)
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
