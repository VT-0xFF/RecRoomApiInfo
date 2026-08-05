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
				[Cpp2IlInjected.Address(RVA = "0x8BFB5C0", Offset = "0x8BFA5C0", VA = "0x188BFB5C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8BFB620", Offset = "0x8BFA620", VA = "0x188BFB620")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8BFB580", Offset = "0x8BFA580", VA = "0x188BFB580")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB0C0", Offset = "0x8BFA0C0", VA = "0x188BFB0C0")]
			public void AIGIDAOHHIP(PointerEventData JMPOCLOJDDB, RectTransform DFNAKPBDAOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB1C0", Offset = "0x8BFA1C0", VA = "0x188BFB1C0")]
			public void GJCMAFNGODB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB4A0", Offset = "0x8BFA4A0", VA = "0x188BFB4A0")]
			public void KBDPDCCOHEN(PointerEventData JMPOCLOJDDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8BFB450", Offset = "0x8BFA450", VA = "0x188BFB450")]
			public void HEOBICEGNFK(float CDOKJOOOLFF, RectTransform DFNAKPBDAOA, Vector3 GKANPAILENO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly FHLIAIDPCMK<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly FHLIAIDPCMK<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly FHLIAIDPCMK<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly FHLIAIDPCMK<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly FHLIAIDPCMK<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly LELKCPPPMEI PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData MEECIMMOJNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool GHCIHDPPHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool PHBPGFFGLNP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BDMDJHHNAHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA683F0", Offset = "0xA673F0", VA = "0x180A683F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA850", Offset = "0x8BF9850", VA = "0x188BFA850")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FHNKKOKABDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA68460", Offset = "0xA67460", VA = "0x180A68460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8BFAE70", Offset = "0x8BF9E70", VA = "0x188BFAE70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA880", Offset = "0x8BF9880", VA = "0x188BFA880")]
		private bool FMMIDNBCCNC(PointerEventData PHDJPEOAFMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAD50", Offset = "0x8BF9D50", VA = "0x188BFAD50", Slot = "5")]
		public void OnPointerDown(PointerEventData PHDJPEOAFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAE10", Offset = "0x8BF9E10", VA = "0x188BFAE10", Slot = "11")]
		public void OnPointerUp(PointerEventData PHDJPEOAFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BFABC0", Offset = "0x8BF9BC0", VA = "0x188BFABC0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData PHDJPEOAFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA900", Offset = "0x8BF9900", VA = "0x188BFA900", Slot = "7")]
		public void OnBeginDrag(PointerEventData PHDJPEOAFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAA10", Offset = "0x8BF9A10", VA = "0x188BFAA10", Slot = "4")]
		public void OnDrag(PointerEventData PHDJPEOAFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAAF0", Offset = "0x8BF9AF0", VA = "0x188BFAAF0", Slot = "8")]
		public void OnEndDrag(PointerEventData PHDJPEOAFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BFADB0", Offset = "0x8BF9DB0", VA = "0x188BFADB0", Slot = "9")]
		public void OnPointerEnter(PointerEventData PHDJPEOAFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BFADE0", Offset = "0x8BF9DE0", VA = "0x188BFADE0", Slot = "10")]
		public void OnPointerExit(PointerEventData PHDJPEOAFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA9D0", Offset = "0x8BF99D0", VA = "0x188BFA9D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFAEA0", Offset = "0x8BF9EA0", VA = "0x188BFAEA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BF5FA0", Offset = "0x8BF4FA0", VA = "0x188BF5FA0")]
		public void SetCanvasSortingOrder(short CNKAFBFIBMF, bool OKMLNBGDPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData FDAGNEJJKIA;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6260", Offset = "0x8BF5260", VA = "0x188BF6260", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6140", Offset = "0x8BF5140", VA = "0x188BF6140", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6090", Offset = "0x8BF5090", VA = "0x188BF6090")]
		private void AHGPKIIMJDL(GameObject OHGEJNLIIFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6540", Offset = "0x8BF5540", VA = "0x188BF6540")]
		public void SetOptionsWithNoDefault(List<string> NCIPNLHDHEI, [Optional] string MPOEFCMKCDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6450", Offset = "0x8BF5450", VA = "0x188BF6450")]
		public void SetOptionsWithNoDefault(List<OptionData> EGBMNBJEHHO, [Optional] string MPOEFCMKCDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6380", Offset = "0x8BF5380", VA = "0x188BF6380", Slot = "43")]
		public override void OnPointerClick(PointerEventData PHDJPEOAFMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "46")]
		protected override GameObject CreateBlocker(Canvas IKOIMIOLPOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6770", Offset = "0x8BF5770", VA = "0x188BF6770")]
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
		private sealed class MBAMIKBDNMM : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private CMMCHACHDBH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
			[DebuggerHidden]
			public MBAMIKBDNMM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8BF81E0", Offset = "0x8BF71E0", VA = "0x188BF81E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF86F0", Offset = "0x8BF76F0", VA = "0x188BF86F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[ELFKDNHKCIP(KDIHEPCABNF.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly FIBCAEDDJIJ<object> LGOOEADIHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool FDDOHMBBNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? CNJNBOBJLGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? OHFEAFFMDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? BFNJAPLJPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool CBEAFENANPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool LEOLAMCLNKF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JOHANNOEOIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7D70", Offset = "0x8BF6D70", VA = "0x188BF7D70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool FNINIHKONAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7D20", Offset = "0x8BF6D20", VA = "0x188BF7D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LGCDCGDBCGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAAD3C0", Offset = "0xAAC3C0", VA = "0x180AAD3C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7F30", Offset = "0x8BF6F30", VA = "0x188BF7F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GEGKIOCCBEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7C80", Offset = "0x8BF6C80", VA = "0x188BF7C80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8BF7E90", Offset = "0x8BF6E90", VA = "0x188BF7E90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF76C0", Offset = "0x8BF66C0", VA = "0x188BF76C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7A60", Offset = "0x8BF6A60", VA = "0x188BF7A60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7A10", Offset = "0x8BF6A10", VA = "0x188BF7A10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7880", Offset = "0x8BF6880", VA = "0x188BF7880")]
		public void Hide(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7BE0", Offset = "0x8BF6BE0", VA = "0x188BF7BE0")]
		public void Show(object GFDDDAIMFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7AF0", Offset = "0x8BF6AF0", VA = "0x188BF7AF0")]
		public void Set(object GFDDDAIMFOH, bool LJIKPFDOGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7750", Offset = "0x8BF6750", VA = "0x188BF7750")]
		public void Clear(bool BODJGCFDAAC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7890", Offset = "0x8BF6890", VA = "0x188BF7890")]
		private void OGLLJECKMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7800", Offset = "0x8BF6800", VA = "0x188BF7800")]
		[IteratorStateMachine(typeof(MBAMIKBDNMM))]
		private IEnumerator<CMMCHACHDBH> GPIOJBCFJIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8BF77C0", Offset = "0x8BF67C0", VA = "0x188BF77C0", Slot = "5")]
		public virtual void DoHideOrShow(bool FDJOPAMPPOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8BF7BF0", Offset = "0x8BF6BF0", VA = "0x188BF7BF0")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HJIIOFDDPJO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum IGJCMDMIFNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static CPIHOGHLCHC EDBEEGPFJIL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static CPIHOGHLCHC PNADIIDKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6C10", Offset = "0x8BF5C10", VA = "0x188BF6C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static IGJCMDMIFNC KHBPBFGGGHC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6AE0", Offset = "0x8BF5AE0", VA = "0x188BF6AE0")]
		get
		{
			return default(IGJCMDMIFNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BF68A0", Offset = "0x8BF58A0", VA = "0x188BF68A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<IGJCMDMIFNC> COAAHHHAEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF6A00", Offset = "0x8BF5A00", VA = "0x188BF6A00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8BF67C0", Offset = "0x8BF57C0", VA = "0x188BF67C0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CGAJMHHFOEJ : JPAJLPDACJG, GEDGMBFDJLE, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, NMFNLCHDBJK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LELKCPPPMEI CIBBDJOGJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GKMAAPKKHOG Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject OCKHDKNFOGO);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKMAAPKKHOG Spawn<T>(int FPFMPJEOOGC, IReadOnlyList<T> INCJDDLACNP, GameObject OCKHDKNFOGO);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GKMAAPKKHOG Spawn<T>(int FPFMPJEOOGC, IReadOnlyList<T> INCJDDLACNP, GameObject KGIBDIANANC, Func<int, GameObject> NGPMAJBJHPO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int HLGKMAPOEBE, float LCMFFPHJNKA);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum DPLIBINLALB : byte
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
		private static readonly int JNPCDABLBHE;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<DPLIBINLALB, string> PEHEJLAOBIJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int JCPGNIBHMEM = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int OJAFDFGLODJ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int IMBCGKFMLMD;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int CEIHNCEDGPA;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int MEEHOECBJFG;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int OIKJBCNKADD;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int GFKKJIFAFOD;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int OMIHBPNPLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool PLDAKDKDCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool PEFKOEMDEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] FGPFKCDCIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private DPLIBINLALB type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly DPLIBINLALB[] JIALIKDGGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[HLLDDOOCNDF("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly DPLIBINLALB[] CHCLCEIFCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[HLLDDOOCNDF("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[HLLDDOOCNDF("type", DPLIBINLALB.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[HLLDDOOCNDF("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic KBHJCJMOFPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool NDDJAPFDLKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient PMAELADJCHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA6A0", Offset = "0x8BF96A0", VA = "0x188BFA6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DPLIBINLALB HHDOJPCILPE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAD32A0", Offset = "0xAD22A0", VA = "0x180AD32A0")]
			get
			{
				return default(DPLIBINLALB);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA820", Offset = "0x8BF9820", VA = "0x188BFA820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool IMAOCPNCENK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9AC0", Offset = "0x8BF8AC0", VA = "0x188BF9AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 MBGAKKKDBNK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA610", Offset = "0x8BF9610", VA = "0x188BFA610")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA650", Offset = "0x8BF9650", VA = "0x188BFA650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool GIIEGLBPKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9CD0", Offset = "0x8BF8CD0", VA = "0x188BF9CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 FOANFLBGIHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA630", Offset = "0x8BF9630", VA = "0x188BFA630")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA7D0", Offset = "0x8BF97D0", VA = "0x188BFA7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float DGALLPPMCOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xDB0980", Offset = "0xDAF980", VA = "0x180DB0980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2477ED0", Offset = "0x2476ED0", VA = "0x182477ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 HAJEPIHAEKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9A70", Offset = "0x8BF8A70", VA = "0x188BF9A70")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 HGIAGFHILDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8BF9F60", Offset = "0x8BF8F60", VA = "0x188BF9F60")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float ABGHGIMHJCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA7B750", Offset = "0xA7A750", VA = "0x180A7B750")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8BFA830", Offset = "0x8BF9830", VA = "0x188BFA830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9B30", Offset = "0x8BF8B30", VA = "0x188BF9B30", Slot = "12")]
		protected override void KDOKJLAGOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9FD0", Offset = "0x8BF8FD0", VA = "0x188BF9FD0")]
		private void PNBANAKDBEO(Color[] GBKGCENHJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9020", Offset = "0x8BF8020", VA = "0x188BF9020", Slot = "13")]
		protected override void BCPFLOODBGM(Material JNBIMACAHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8BF9D40", Offset = "0x8BF8D40", VA = "0x188BF9D40", Slot = "14")]
		protected override void MBIIAMCHPGM(Material JNBIMACAHOC, bool OPEAEGJENDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8BFA560", Offset = "0x8BF9560", VA = "0x188BFA560")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly HJNGMFHELJL FDNMFPAMGPD;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite HOABFLBKCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material MOPDMKJCCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material NPGBFHGOJBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool NPHMBNICELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool FDDOHMBBNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool NFLCMHPHHMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool NPBAINCADOL;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic KBHJCJMOFPE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader MMJCJIMIEIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool NDDJAPFDLKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool OHJOPJJNECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform DFNAKPBDAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8BFBA00", Offset = "0x8BFAA00", VA = "0x188BFBA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect NDFNFAHHJJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8BFC9E0", Offset = "0x8BFB9E0", VA = "0x188BFC9E0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite PNFEALCFALP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8BFBA60", Offset = "0x8BFAA60", VA = "0x188BFBA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8BFB810", Offset = "0x8BFA810", VA = "0x188BFB810", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC6D0", Offset = "0x8BFB6D0", VA = "0x188BFC6D0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC9D0", Offset = "0x8BFB9D0", VA = "0x188BFC9D0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC880", Offset = "0x8BFB880", VA = "0x188BFC880", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBF80", Offset = "0x8BFAF80", VA = "0x188BFBF80")]
		private void OFBPHLHPAFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBC50", Offset = "0x8BFAC50", VA = "0x188BFBC50")]
		private void EDHMCGOBHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBE10", Offset = "0x8BFAE10", VA = "0x188BFBE10")]
		private void GJLKIGBPNLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBDC0", Offset = "0x8BFADC0", VA = "0x188BFBDC0")]
		private void EHJCDJLAFGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC110", Offset = "0x8BFB110", VA = "0x188BFC110")]
		protected void OPBENKAMFAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFBE40", Offset = "0x8BFAE40", VA = "0x188BFBE40")]
		private void NMKOGMNPHEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "12")]
		protected virtual void KDOKJLAGOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "13")]
		protected virtual void BCPFLOODBGM(Material JNBIMACAHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "14")]
		protected virtual void MBIIAMCHPGM(Material JNBIMACAHOC, bool OPEAEGJENDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BFC380", Offset = "0x8BFB380", VA = "0x188BFC380")]
		private void OPGNKEPGBJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
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
		private static readonly int MKANONMFKFB;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int IIMEJHIIALJ;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int BOKHBIAEGDK;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int EMMDCIAPKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
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
		private Color[] FGPFKCDCIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] LAKLFLHFCEJ;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic KBHJCJMOFPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool OHJOPJJNECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> BDCJFBMEFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 MBGAKKKDBNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x315DBF0", Offset = "0x315CBF0", VA = "0x18315DBF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8BFD5C0", Offset = "0x8BFC5C0", VA = "0x188BFD5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD200", Offset = "0x8BFC200", VA = "0x188BFD200")]
		public void SetRingLayers(IReadOnlyList<RingLayer> GHFMENCHLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCFC0", Offset = "0x8BFBFC0", VA = "0x188BFCFC0")]
		public bool SetRingLayerColor(int CHOCDIANLNI, Color AHIICABHHJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD110", Offset = "0x8BFC110", VA = "0x188BFD110")]
		public bool SetRingLayerSize(int CHOCDIANLNI, float BKLOHAHJLKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCE30", Offset = "0x8BFBE30", VA = "0x188BFCE30", Slot = "12")]
		protected override void KDOKJLAGOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCCB0", Offset = "0x8BFBCB0", VA = "0x188BFCCB0", Slot = "13")]
		protected override void BCPFLOODBGM(Material JNBIMACAHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BFCF70", Offset = "0x8BFBF70", VA = "0x188BFCF70", Slot = "14")]
		protected override void MBIIAMCHPGM(Material JNBIMACAHOC, bool OPEAEGJENDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD350", Offset = "0x8BFC350", VA = "0x188BFD350")]
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
		public enum NKBKLHGGAMO
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int CJAGDMCNINH;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int MDIGBOLFGDO;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int CPMOKLBICLL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int FINIBGHLJJM;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int FIGLIDCFPPO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int KCJGDBCKJDE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int FFJHEFHGDNL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int NCPHLEJDDCJ;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int CHGCPLGNAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int FKKDFNLIOIJ;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int KFGOIINFEPG;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int CAMAEBGJBGN;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int KFGGAMEEGON;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int KGIODNBPBFF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int DFJCLPDIFOK;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int CFKGLBNNKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[COPMMNAHICH(KDIHEPCABNF.Self, false, false, false)]
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
		private NKBKLHGGAMO animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[HLLDDOOCNDF("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[HLLDDOOCNDF("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic KBHJCJMOFPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool OHJOPJJNECO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite EFGAAEDOBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE430", Offset = "0x8BFD430", VA = "0x188BFE430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE650", Offset = "0x8BFD650", VA = "0x188BFE650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color BDGGHGDHGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x10064E0", Offset = "0x10054E0", VA = "0x1810064E0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE6E0", Offset = "0x8BFD6E0", VA = "0x188BFE6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color KKLEHKFGKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1245FE0", Offset = "0x1244FE0", VA = "0x181245FE0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE520", Offset = "0x8BFD520", VA = "0x188BFE520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float BOHJEIMHJMM
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xDB0B00", Offset = "0xDAFB00", VA = "0x180DB0B00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE5E0", Offset = "0x8BFD5E0", VA = "0x188BFE5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 KFJLPGNNJBH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE410", Offset = "0x8BFD410", VA = "0x188BFE410")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE600", Offset = "0x8BFD600", VA = "0x188BFE600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float CNDJAMFAIMP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA7B3B0", Offset = "0xA7A3B0", VA = "0x180A7B3B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE5A0", Offset = "0x8BFD5A0", VA = "0x188BFE5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 LIKCCBPNLAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1727CD0", Offset = "0x1726CD0", VA = "0x181727CD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE760", Offset = "0x8BFD760", VA = "0x188BFE760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float OANDCGEOAMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x11F6630", Offset = "0x11F5630", VA = "0x1811F6630")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE4F0", Offset = "0x8BFD4F0", VA = "0x188BFE4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 DPAMFDLDBAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE010", Offset = "0x8BFD010", VA = "0x188BFE010")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public NKBKLHGGAMO LDCJIDPPAFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAD3220", Offset = "0xAD2220", VA = "0x180AD3220")]
			get
			{
				return default(NKBKLHGGAMO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE510", Offset = "0x8BFD510", VA = "0x188BFE510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float BMKBNIODKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x18C67F0", Offset = "0x18C57F0", VA = "0x1818C67F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE5C0", Offset = "0x8BFD5C0", VA = "0x188BFE5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float MPDOPFAGKFH
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x186C2C0", Offset = "0x186B2C0", VA = "0x18186C2C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE4D0", Offset = "0x8BFD4D0", VA = "0x188BFE4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8BFD610", Offset = "0x8BFC610", VA = "0x188BFD610", Slot = "13")]
		protected override void BCPFLOODBGM(Material JNBIMACAHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8BFDD10", Offset = "0x8BFCD10", VA = "0x188BFDD10")]
		private void IOBELJAPCAJ(Sprite HMILKDLMBAG, [Out] Vector2 EEPCHCGJKIE, [Out] Vector2 ABMIMEHKEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8BFDFC0", Offset = "0x8BFCFC0", VA = "0x188BFDFC0", Slot = "14")]
		protected override void MBIIAMCHPGM(Material JNBIMACAHOC, bool OPEAEGJENDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE380", Offset = "0x8BFD380", VA = "0x188BFE380")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader JOOEKKEPOGB;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader MMJCJIMIEIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8BFE800", Offset = "0x8BFD800", VA = "0x188BFE800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BFE7B0", Offset = "0x8BFD7B0", VA = "0x188BFE7B0")]
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
		private SerializableRectTransform FOHMPJMEBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool ENCHILHJDDK;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8B50", Offset = "0x8BF7B50", VA = "0x188BF8B50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8E30", Offset = "0x8BF7E30", VA = "0x188BF8E30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8CE0", Offset = "0x8BF7CE0", VA = "0x188BF8CE0")]
		private void FDGBJMGOAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8D60", Offset = "0x8BF7D60", VA = "0x188BF8D60")]
		private void OGLLJECKMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HJNGMFHELJL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct IGOENJKGDFL : IEquatable<IGOENJKGDFL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component IEGLIFIOOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action HNMPOLILIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int OCPLKKBPCDB;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component MPMOIJDOBLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8170", Offset = "0x8BF7170", VA = "0x188BF8170")]
		public IGOENJKGDFL(Component IEGLIFIOOBM, Action HNMPOLILIAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8BF80F0", Offset = "0x8BF70F0", VA = "0x188BF80F0")]
		public void JOCGPOALKCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF80E0", Offset = "0x8BF70E0", VA = "0x188BF80E0", Slot = "4")]
		public bool Equals(IGOENJKGDFL EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8050", Offset = "0x8BF7050", VA = "0x188BF8050", Slot = "0")]
		public override bool Equals(object PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NBEFCIGPCIJ : IEnumerator<CMMCHACHDBH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private CMMCHACHDBH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public HJNGMFHELJL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private CMMCHACHDBH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public NBEFCIGPCIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8740", Offset = "0x8BF7740", VA = "0x188BF8740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8B00", Offset = "0x8BF7B00", VA = "0x188BF8B00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly JEOMOPBOGJJ MLDMEEICCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int GGGGMAJGNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int NHHFJPIAONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> MKDEKFKNPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, IGOENJKGDFL> DJFNJBNBBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<IGOENJKGDFL> OIBFBCLGELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<IGOENJKGDFL> CNNDEOKBMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private HHGNPNNJJPG HNPEMBLNINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private AGHCEHMADPK ENKKANPJKMF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private AGHCEHMADPK NHMBDDKMJJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF74B0", Offset = "0x8BF64B0", VA = "0x188BF74B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8BF7540", Offset = "0x8BF6540", VA = "0x188BF7540")]
	public HJNGMFHELJL(JEOMOPBOGJJ MLDMEEICCMO, int GGGGMAJGNCJ = -1, int NHHFJPIAONK = -1, [Optional] Func<Component, float> MKDEKFKNPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8BF6F80", Offset = "0x8BF5F80", VA = "0x188BF6F80")]
	public void KBFFKAEFNFH(Component IEGLIFIOOBM, Action JPJEPABDFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8BF6D10", Offset = "0x8BF5D10", VA = "0x188BF6D10")]
	public void BKPJJADBKKI(Component IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8BF6F20", Offset = "0x8BF5F20", VA = "0x188BF6F20")]
	public bool HHINLPEPCHP(Component LDEFIHHDIJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8BF7280", Offset = "0x8BF6280", VA = "0x188BF7280")]
	private void MLBLIFKNAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8BF7200", Offset = "0x8BF6200", VA = "0x188BF7200")]
	[IteratorStateMachine(typeof(NBEFCIGPCIJ))]
	private IEnumerator<CMMCHACHDBH> LEHEEHJJJHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xF15540", Offset = "0xF14540", VA = "0x180F15540")]
	[CompilerGenerated]
	private void ADFPOLINIKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8BF6EA0", Offset = "0x8BF5EA0", VA = "0x188BF6EA0")]
	[CompilerGenerated]
	private float EAEAPNOCIKP(IGOENJKGDFL JPJEPABDFKF)
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
