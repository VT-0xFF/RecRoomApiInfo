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
	public class UIHandleDecorator : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public class UIHandleEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public Vector2 cachedScreenPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public float cachedDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public Vector3 targetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Vector3 targetForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public Vector3 previousTargetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public RectTransform cachedRectTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Vector3 pressLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public Quaternion pressRotationOffset;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Vector3 RemappedWorldPressPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x6564140", Offset = "0x6563140", VA = "0x186564140")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x65641A0", Offset = "0x65631A0", VA = "0x1865641A0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x65640C0", Offset = "0x65630C0", VA = "0x1865640C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6563C50", Offset = "0x6562C50", VA = "0x186563C50")]
			public void GDOFLMIHAHD(PointerEventData IHGMKKEPBHG, RectTransform DGJOMIPCCPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6563E60", Offset = "0x6562E60", VA = "0x186563E60")]
			public void HKFKPEACGEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6563FD0", Offset = "0x6562FD0", VA = "0x186563FD0")]
			public void OOJKMHCJAFD(PointerEventData IHGMKKEPBHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6563F80", Offset = "0x6562F80", VA = "0x186563F80")]
			public void NHHBPNMLMGP(float CJIFPBOMFHF, RectTransform DGJOMIPCCPN, Vector3 MBFNFKBJPCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly global::OKNKFJGELPL<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly global::OKNKFJGELPL<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::OKNKFJGELPL<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly AMNHKKJOBOK PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly UIHandleEventData BEJKOKDALCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool FILOLJFECPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool ANEPBCOMAHL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LPLFENEHHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xF10FD0", Offset = "0xF0FFD0", VA = "0x180F10FD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x65634B0", Offset = "0x65624B0", VA = "0x1865634B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BKFIMEHBOIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x1202C80", Offset = "0x1201C80", VA = "0x181202C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x65634E0", Offset = "0x65624E0", VA = "0x1865634E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6563430", Offset = "0x6562430", VA = "0x186563430")]
		private bool AEHPPLPACFL(PointerEventData KOMNBMOHOIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		public void OnPointerDown(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6563800", Offset = "0x6562800", VA = "0x186563800", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6563510", Offset = "0x6562510", VA = "0x186563510", Slot = "7")]
		public void OnBeginDrag(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6563630", Offset = "0x6562630", VA = "0x186563630", Slot = "4")]
		public void OnDrag(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6563720", Offset = "0x6562720", VA = "0x186563720", Slot = "8")]
		public void OnEndDrag(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6563A90", Offset = "0x6562A90", VA = "0x186563A90", Slot = "9")]
		public void OnPointerEnter(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6563AC0", Offset = "0x6562AC0", VA = "0x186563AC0", Slot = "10")]
		public void OnPointerExit(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65635F0", Offset = "0x65625F0", VA = "0x1865635F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6563AF0", Offset = "0x6562AF0", VA = "0x186563AF0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OptionData PJCFKLBEMMI;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x655EBF0", Offset = "0x655DBF0", VA = "0x18655EBF0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x655EAE0", Offset = "0x655DAE0", VA = "0x18655EAE0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x655EA20", Offset = "0x655DA20", VA = "0x18655EA20")]
		private void EKNPENGIGKD(GameObject PDCKCOENGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x655EDD0", Offset = "0x655DDD0", VA = "0x18655EDD0")]
		public void SetOptionsWithNoDefault(List<string> GBCINMGHOME, [Optional] string ALPPHBECBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x655F010", Offset = "0x655E010", VA = "0x18655F010")]
		public void SetOptionsWithNoDefault(List<OptionData> PPHOLEMBGPL, [Optional] string ALPPHBECBFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x655ED00", Offset = "0x655DD00", VA = "0x18655ED00", Slot = "42")]
		public override void OnPointerClick(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas IJHOLBGGJHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x655F100", Offset = "0x655E100", VA = "0x18655F100")]
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
		private sealed class PNPPLIFCMFB : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private FEEMOJCDGJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
			[DebuggerHidden]
			public PNPPLIFCMFB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6561960", Offset = "0x6560960", VA = "0x186561960", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6561E80", Offset = "0x6560E80", VA = "0x186561E80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[IKGEDHPILMJ(LNNFGJICGEC.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly JLNNFJHBOML BDCIBECMLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool APMHAGMEOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Vector3? BKOIBLIFGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool? LBJDKFHCMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? DCLPOGBKOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool CLHOCIBMOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool GPGDGHKNMBF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NEPMCAMOOBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x65604A0", Offset = "0x655F4A0", VA = "0x1865604A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool FHCCDEDLDHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6560480", Offset = "0x655F480", VA = "0x186560480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KMJBBGHCLDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9B94D0", Offset = "0x9B84D0", VA = "0x1809B94D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6560670", Offset = "0x655F670", VA = "0x186560670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ALKCOCAJMIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x65603E0", Offset = "0x655F3E0", VA = "0x1865603E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x65605D0", Offset = "0x655F5D0", VA = "0x1865605D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x655FE20", Offset = "0x655EE20", VA = "0x18655FE20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x65601B0", Offset = "0x655F1B0", VA = "0x1865601B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x655FF00", Offset = "0x655EF00", VA = "0x18655FF00")]
		public void Hide(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x65602F0", Offset = "0x655F2F0", VA = "0x1865602F0")]
		public void Show(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6560250", Offset = "0x655F250", VA = "0x186560250")]
		public void Set(object JAKCBCDLMLB, bool EHLBBKIKNFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x655FF80", Offset = "0x655EF80", VA = "0x18655FF80")]
		private void JFDFLICPNAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6560140", Offset = "0x655F140", VA = "0x186560140")]
		[IteratorStateMachine(typeof(PNPPLIFCMFB))]
		private IEnumerator<FEEMOJCDGJP> KKDANHIJENB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x655FEC0", Offset = "0x655EEC0", VA = "0x18655FEC0", Slot = "5")]
		public virtual void DoHideOrShow(bool HFLNFPCOIPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6560370", Offset = "0x655F370", VA = "0x186560370")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JFIHAJOBPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x71B000", Offset = "0x71A000", VA = "0x18071B000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> HIPJIAINLCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6560860", Offset = "0x655F860", VA = "0x186560860")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x65609A0", Offset = "0x655F9A0", VA = "0x1865609A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> IDBGJLPCNEP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6560900", Offset = "0x655F900", VA = "0x186560900")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6560A40", Offset = "0x655FA40", VA = "0x186560A40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x65607A0", Offset = "0x655F7A0", VA = "0x1865607A0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6560800", Offset = "0x655F800", VA = "0x186560800", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData KOMNBMOHOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x245F3D0", Offset = "0x245E3D0", VA = "0x18245F3D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x245F3D0", Offset = "0x245E3D0", VA = "0x18245F3D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GFJEBLFAMOF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum FDADCBLBALL
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const FDADCBLBALL PDLKLFAIPDI = FDADCBLBALL.Light;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string JFGMFLCKBPC = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static JNBJAPHOFAJ ACKNCBIFCOM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static JNBJAPHOFAJ BAGJGBDEJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x655F160", Offset = "0x655E160", VA = "0x18655F160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static FDADCBLBALL CIKONHGBPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x655F3A0", Offset = "0x655E3A0", VA = "0x18655F3A0")]
		get
		{
			return default(FDADCBLBALL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x655F640", Offset = "0x655E640", VA = "0x18655F640")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<FDADCBLBALL> FKPLBFJKOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x655F540", Offset = "0x655E540", VA = "0x18655F540")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x655F2A0", Offset = "0x655E2A0", VA = "0x18655F2A0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface POPKNMFOEHA : PHNLGGEPFBP, DLFIMIPLFPI, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	global::BJDCJLPDAMP<GameObject, int> JBHJNNKAPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	global::MHKIEOOGPNK<GameObject, int, bool> GMHHKNDBEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	global::OKNKFJGELPL<bool> KGCKNNEINPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool EDJKEGNLNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float KCDOKHDEDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	global::OKNKFJGELPL<float> AMGLPCCIPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	AMNHKKJOBOK PODBLJACOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SpawnLoadingPlaceholders(GameObject IJBPCAELLON);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GKOIHBKMELE Spawn<T>(int KAGLPNEEOIE, IReadOnlyList<T> FNIHENPLJHK, GameObject IJBPCAELLON);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GKOIHBKMELE Spawn<T>(int KAGLPNEEOIE, IReadOnlyList<T> FNIHENPLJHK, GameObject MPCGKNOJICM, ref Func<int, GameObject> AAMDBDFOHHD);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum DKOJAFBKDBP : byte
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
		private static readonly int HJEMAOHKKHB;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<DKOJAFBKDBP, string> APJOAECJAOK;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int LMMBCFBHBNJ = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int NBNOONJNOCE;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int KFCAECEFLPL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int CINHHBCFEND;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int NODOEPOPBJB;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int BCMFNLJHMJD;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int KHEMJEBDLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool JJGAAIAAGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool GJAKEEKEIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] IIKAHMNGMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private DKOJAFBKDBP type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly DKOJAFBKDBP[] JJHOGPMMCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[ACPPGJHOAFH("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly DKOJAFBKDBP[] AJEENFJKMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[ACPPGJHOAFH("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[Range(0f, 360f)]
		[ACPPGJHOAFH("type", (byte)4)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[ACPPGJHOAFH("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic JDOJFOBHNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool OEIHNOJFDML
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient PKBFPIDMNHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0D0", Offset = "0x6DE0D0", VA = "0x1806DF0D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6563280", Offset = "0x6562280", VA = "0x186563280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DKOJAFBKDBP DBLKLNHCEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xF10FD0", Offset = "0xF0FFD0", VA = "0x180F10FD0")]
			get
			{
				return default(DKOJAFBKDBP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6563400", Offset = "0x6562400", VA = "0x186563400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool LODAGGJFOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x65621A0", Offset = "0x65611A0", VA = "0x1865621A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 ODOBJGCHMDD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6563210", Offset = "0x6562210", VA = "0x186563210")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6563230", Offset = "0x6562230", VA = "0x186563230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool FEPBMKMBOLL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6562B80", Offset = "0x6561B80", VA = "0x186562B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 PMDLMCAOIJA
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x62D3920", Offset = "0x62D2920", VA = "0x1862D3920")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x65633B0", Offset = "0x65623B0", VA = "0x1865633B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MAAFOCMLMEL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1CA7700", Offset = "0x1CA6700", VA = "0x181CA7700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1CA7850", Offset = "0x1CA6850", VA = "0x181CA7850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 ADPBONJLDLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6562220", Offset = "0x6561220", VA = "0x186562220")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 IHPONPGBJAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6562AF0", Offset = "0x6561AF0", VA = "0x186562AF0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NMJNNLEIJDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x15AEE70", Offset = "0x15ADE70", VA = "0x1815AEE70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6563410", Offset = "0x6562410", VA = "0x186563410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6562270", Offset = "0x6561270", VA = "0x186562270", Slot = "12")]
		protected override void HPKCINCPMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6562C00", Offset = "0x6561C00", VA = "0x186562C00")]
		private void OPELDGFBMOP(Color[] HKLJNJGPIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x65623F0", Offset = "0x65613F0", VA = "0x1865623F0", Slot = "13")]
		protected override void KNMPJNCONFO(Material HNKAKNCAJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6561F80", Offset = "0x6560F80", VA = "0x186561F80", Slot = "14")]
		protected override void APEGIIIGOPG(Material HNKAKNCAJGB, bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6563150", Offset = "0x6562150", VA = "0x186563150")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly MDFNJCEEMDB GGGPBHEEACA;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite IFNJGPIPKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material KKJONJMOFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material NBLCEAOCLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool BBMNMKIDJKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool APMHAGMEOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool FLEOIILBOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool HGEEHFMKAHK;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic JDOJFOBHNID
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader KJGFBDBDLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool OEIHNOJFDML
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool DOCIGOEJDPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform DGJOMIPCCPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6564830", Offset = "0x6563830", VA = "0x186564830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect GLBDPCPEEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6564490", Offset = "0x6563490", VA = "0x186564490")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite GPELFFIHDGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x65649D0", Offset = "0x65639D0", VA = "0x1865649D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x65642A0", Offset = "0x65632A0", VA = "0x1865642A0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6564E80", Offset = "0x6563E80", VA = "0x186564E80", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x65651A0", Offset = "0x65641A0", VA = "0x1865651A0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6565030", Offset = "0x6564030", VA = "0x186565030", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6564BA0", Offset = "0x6563BA0", VA = "0x186564BA0")]
		private void LIIOJCBHOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6564D20", Offset = "0x6563D20", VA = "0x186564D20")]
		private void NCKGEJKBPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65651B0", Offset = "0x65641B0", VA = "0x1865651B0")]
		private void PAIGHCIEHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6564250", Offset = "0x6563250", VA = "0x186564250")]
		private void APLKIAIDODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x65645C0", Offset = "0x65635C0", VA = "0x1865645C0")]
		protected void CLDHEFLKCOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6564890", Offset = "0x6563890", VA = "0x186564890")]
		private void ICFADJJNAOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "12")]
		protected virtual void HPKCINCPMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "13")]
		protected virtual void KNMPJNCONFO(Material HNKAKNCAJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "14")]
		protected virtual void APEGIIIGOPG(Material HNKAKNCAJGB, bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x65651E0", Offset = "0x65641E0", VA = "0x1865651E0")]
		private void POINFGJKPHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		[Conditional("RRUI_PROFILING")]
		protected void DKEBOFNKLCJ(string HBCALMLKPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		[Conditional("RRUI_PROFILING")]
		protected void AKCNOFBFDEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xE08F70", Offset = "0xE07F70", VA = "0x180E08F70")]
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
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[SerializeField]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x21CA60", Offset = "0x21BE60")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly int KFPOPCDJCLJ;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int MDJLANHLDBB;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int AFOHPJOKJEA;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int JLMHEAMPEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
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
		private Color[] IIKAHMNGMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] NGJLPPFDBII;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic JDOJFOBHNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool DOCIGOEJDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> GONGIODJBLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 ODOBJGCHMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4652C50", Offset = "0x4651C50", VA = "0x184652C50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6565F40", Offset = "0x6564F40", VA = "0x186565F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6565C40", Offset = "0x6564C40", VA = "0x186565C40")]
		public void SetRingLayers(IReadOnlyList<RingLayer> MBPKGLBDGEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6565A20", Offset = "0x6564A20", VA = "0x186565A20")]
		public bool SetRingLayerColor(int EEBBPKANDKH, Color LDFNLMPJEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6565B30", Offset = "0x6564B30", VA = "0x186565B30")]
		public bool SetRingLayerSize(int EEBBPKANDKH, float MKMGHJFMNMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6565730", Offset = "0x6564730", VA = "0x186565730", Slot = "12")]
		protected override void HPKCINCPMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x65658A0", Offset = "0x65648A0", VA = "0x1865658A0", Slot = "13")]
		protected override void KNMPJNCONFO(Material HNKAKNCAJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x65656E0", Offset = "0x65646E0", VA = "0x1865656E0", Slot = "14")]
		protected override void APEGIIIGOPG(Material HNKAKNCAJGB, bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6565D90", Offset = "0x6564D90", VA = "0x186565D90")]
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
		public enum OBOJNJPPGLF
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int OHLNMFGKMED;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int JOJFODIFHMA;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int EEEOLEELGCM;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int MKLAMIIOMGD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int IMGBPMOELEG;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int PCCNNBKKNAD;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int EGKKPFJOIHJ;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int HOIOKAFFGHI;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int LIBAGCJLKHE;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int LDKPPIICJCE;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int JCDEKJOFCAD;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int GJNLHMPAJID;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int LJJPHPJNBNO;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int PMEEMGDIPCN;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int BLEGMHJKLHD;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int FLGCEBLCBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[CBBPHEOMBGL(LNNFGJICGEC.Self, false, false, false)]
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
		[SerializeField]
		[Tooltip("The offset applied to each alternating row or column.")]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private OBOJNJPPGLF animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[ACPPGJHOAFH("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[ACPPGJHOAFH("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic JDOJFOBHNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool DOCIGOEJDPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite ELEOCKEILDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6566D10", Offset = "0x6565D10", VA = "0x186566D10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6566F20", Offset = "0x6565F20", VA = "0x186566F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color HHMMPDCCLOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xFF85E0", Offset = "0xFF75E0", VA = "0x180FF85E0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x6566FC0", Offset = "0x6565FC0", VA = "0x186566FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color NCODCMFENBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA49D20", Offset = "0xA48D20", VA = "0x180A49D20")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6566E10", Offset = "0x6565E10", VA = "0x186566E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float NLDAHIABNEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x168C3B0", Offset = "0x168B3B0", VA = "0x18168C3B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6566EB0", Offset = "0x6565EB0", VA = "0x186566EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 JBGJFPKKPLC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x15ED8D0", Offset = "0x15EC8D0", VA = "0x1815ED8D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6566ED0", Offset = "0x6565ED0", VA = "0x186566ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float FBBBKLCCDDL
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x259A540", Offset = "0x2599540", VA = "0x18259A540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6566E70", Offset = "0x6565E70", VA = "0x186566E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 BJNPJNMHPCB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x25062A0", Offset = "0x25052A0", VA = "0x1825062A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6567020", Offset = "0x6566020", VA = "0x186567020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float KGOPJGIMIHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1817000", Offset = "0x1816000", VA = "0x181817000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6566DE0", Offset = "0x6565DE0", VA = "0x186566DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 MKPPMCAPOEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6565FE0", Offset = "0x6564FE0", VA = "0x186565FE0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public OBOJNJPPGLF GEFIMAOOGEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x9085C0", Offset = "0x9075C0", VA = "0x1809085C0")]
			get
			{
				return default(OBOJNJPPGLF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6566E00", Offset = "0x6565E00", VA = "0x186566E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float EGIMLDKGMJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1302440", Offset = "0x1301440", VA = "0x181302440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6566E90", Offset = "0x6565E90", VA = "0x186566E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float FJHMPIFHFNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x15ED890", Offset = "0x15EC890", VA = "0x1815ED890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6566DC0", Offset = "0x6565DC0", VA = "0x186566DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6566050", Offset = "0x6565050", VA = "0x186566050", Slot = "13")]
		protected override void KNMPJNCONFO(Material HNKAKNCAJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6566710", Offset = "0x6565710", VA = "0x186566710")]
		private void PBFKCCPKCFK(Sprite PMOFICFJAIE, out Vector2 FOOANMGBNDD, out Vector2 HCGMEBINBMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6565F90", Offset = "0x6564F90", VA = "0x186565F90", Slot = "14")]
		protected override void APEGIIIGOPG(Material HNKAKNCAJGB, bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6566C70", Offset = "0x6565C70", VA = "0x186566C70")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader KEGICCGAHIL;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader KJGFBDBDLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x65670D0", Offset = "0x65660D0", VA = "0x1865670D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6567070", Offset = "0x6566070", VA = "0x186567070")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MDFNJCEEMDB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MMCEPEKFOLL : IEquatable<MMCEPEKFOLL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component MFEOJPNCOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action HJPPMKEOIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int FALLHOPKOOJ;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component IGIFCKBDGJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6DF000", Offset = "0x6DE000", VA = "0x1806DF000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6561900", Offset = "0x6560900", VA = "0x186561900")]
		public MMCEPEKFOLL(Component MFEOJPNCOBA, Action HJPPMKEOIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x65617E0", Offset = "0x65607E0", VA = "0x1865617E0")]
		public void EALHBJADKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x65618F0", Offset = "0x65608F0", VA = "0x1865618F0", Slot = "4")]
		public bool Equals(MMCEPEKFOLL JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6561860", Offset = "0x6560860", VA = "0x186561860", Slot = "0")]
		public override bool Equals(object AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class LIJKBJHMDKL : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public MDFNJCEEMDB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public LIJKBJHMDKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6560AE0", Offset = "0x655FAE0", VA = "0x186560AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6560E10", Offset = "0x655FE10", VA = "0x186560E10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int CBCDADICLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int DAKIOHINNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> EJLGIDAKMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, MMCEPEKFOLL> JOIDGMIMJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<MMCEPEKFOLL> NGMECECMIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<MMCEPEKFOLL> BKDKDNOOAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private ALMNDBMKBBN IABFMLNEHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private GGGBKGFCIFD APBKBIBAJDC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GGGBKGFCIFD JPBFKFFENKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6561130", Offset = "0x6560130", VA = "0x186561130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6561680", Offset = "0x6560680", VA = "0x186561680")]
	public MDFNJCEEMDB(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, int CBCDADICLGD = -1, int DAKIOHINNAC = -1, [Optional] Func<Component, float> EJLGIDAKMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6560E50", Offset = "0x655FE50", VA = "0x186560E50")]
	public void BIMCIGDEPAC(Component MFEOJPNCOBA, Action PMKKOJBMNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6561430", Offset = "0x6560430", VA = "0x186561430")]
	public void JENANIKCMHE(Component MFEOJPNCOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x65613D0", Offset = "0x65603D0", VA = "0x1865613D0")]
	public bool HIAFOLDEHEL(Component NANIPOPDLDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x65611A0", Offset = "0x65601A0", VA = "0x1865611A0")]
	private void GNAJNKJLILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x65610C0", Offset = "0x65600C0", VA = "0x1865610C0")]
	[IteratorStateMachine(typeof(LIJKBJHMDKL))]
	private IEnumerator<FEEMOJCDGJP> CCLGLEAFDAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x136CA70", Offset = "0x136BA70", VA = "0x18136CA70")]
	[CompilerGenerated]
	private void GJPJADNFNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x65615C0", Offset = "0x65605C0", VA = "0x1865615C0")]
	[CompilerGenerated]
	private float OPJBMCKFGKL(MMCEPEKFOLL PMKKOJBMNDG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KLNODBOPODF
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IPNMIHJPCNI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	BBAJHCNPMJF AOMDKNNHFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool FIJONCAFJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	global::OKNKFJGELPL<BBAJHCNPMJF> GEJDPIGLFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGGIFDOGPLL(BBAJHCNPMJF PBLGAHJBFKJ, bool JCJGHLKKMDJ = false);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x655F7F0", Offset = "0x655E7F0", VA = "0x18655F7F0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x655F900", Offset = "0x655E900", VA = "0x18655F900")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
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

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
