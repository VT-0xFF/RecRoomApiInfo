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
				[Cpp2IlInjected.Address(RVA = "0x87C7C60", Offset = "0x87C6A60", VA = "0x1887C7C60")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x87C7CC0", Offset = "0x87C6AC0", VA = "0x1887C7CC0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x87C7C20", Offset = "0x87C6A20", VA = "0x1887C7C20")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x87C7840", Offset = "0x87C6640", VA = "0x1887C7840")]
			public void IHLBEAFLGIM(PointerEventData BDIFPKCBEMI, RectTransform OFPAKLKCNKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87C7940", Offset = "0x87C6740", VA = "0x1887C7940")]
			public void NDOACJLNPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x87C7760", Offset = "0x87C6560", VA = "0x1887C7760")]
			public void HCCIOBCPIAL(PointerEventData BDIFPKCBEMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x87C7BD0", Offset = "0x87C69D0", VA = "0x1887C7BD0")]
			public void OPGKHCFLNOA(float INKIEPNKPHE, RectTransform OFPAKLKCNKF, Vector3 IMPLDPKOJAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly IMAAKJGDPMH<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly IMAAKJGDPMH<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly IMAAKJGDPMH<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly IMAAKJGDPMH<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly IMAAKJGDPMH<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly LLEAAEBCCKF PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData FGJDHBOEFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool IDCKLHBBKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool KAAFGKGINGA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HCDBCCKLIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED40", Offset = "0xA0DB40", VA = "0x180A0ED40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x87C6F20", Offset = "0x87C5D20", VA = "0x1887C6F20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool KDPCBGOOBKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAB0", Offset = "0xA0D8B0", VA = "0x180A0EAB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x87C6EF0", Offset = "0x87C5CF0", VA = "0x1887C6EF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87C6F50", Offset = "0x87C5D50", VA = "0x1887C6F50")]
		private bool LIHDKIMBHHG(PointerEventData FELHJOMEEAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87C7420", Offset = "0x87C6220", VA = "0x1887C7420", Slot = "5")]
		public void OnPointerDown(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87C74E0", Offset = "0x87C62E0", VA = "0x1887C74E0", Slot = "11")]
		public void OnPointerUp(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87C7290", Offset = "0x87C6090", VA = "0x1887C7290", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87C6FD0", Offset = "0x87C5DD0", VA = "0x1887C6FD0", Slot = "7")]
		public void OnBeginDrag(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87C70E0", Offset = "0x87C5EE0", VA = "0x1887C70E0", Slot = "4")]
		public void OnDrag(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87C71C0", Offset = "0x87C5FC0", VA = "0x1887C71C0", Slot = "8")]
		public void OnEndDrag(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87C7480", Offset = "0x87C6280", VA = "0x1887C7480", Slot = "9")]
		public void OnPointerEnter(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x87C74B0", Offset = "0x87C62B0", VA = "0x1887C74B0", Slot = "10")]
		public void OnPointerExit(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x87C70A0", Offset = "0x87C5EA0", VA = "0x1887C70A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x87C7540", Offset = "0x87C6340", VA = "0x1887C7540")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C30E0", Offset = "0x87C1EE0", VA = "0x1887C30E0")]
		public void SetCanvasSortingOrder(short NPHMDGDNHJJ, bool NJLPDFDACNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData OLAMJDMKPCC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x87C33A0", Offset = "0x87C21A0", VA = "0x1887C33A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x87C3280", Offset = "0x87C2080", VA = "0x1887C3280", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x87C31D0", Offset = "0x87C1FD0", VA = "0x1887C31D0")]
		private void ILJJACMONBA(GameObject EJFCFHHJIPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x87C3680", Offset = "0x87C2480", VA = "0x1887C3680")]
		public void SetOptionsWithNoDefault(List<string> BGBLHEHBHCD, [Optional] string OKBHHHFIDIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x87C3590", Offset = "0x87C2390", VA = "0x1887C3590")]
		public void SetOptionsWithNoDefault(List<OptionData> FMKKHOLMGDF, [Optional] string OKBHHHFIDIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87C34C0", Offset = "0x87C22C0", VA = "0x1887C34C0", Slot = "42")]
		public override void OnPointerClick(PointerEventData FELHJOMEEAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas MMECIANFCCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87C38B0", Offset = "0x87C26B0", VA = "0x1887C38B0")]
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
		private sealed class BPKPALGEFPJ : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private GCOFLMDGPIM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
			[DebuggerHidden]
			public BPKPALGEFPJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x87C2630", Offset = "0x87C1430", VA = "0x1887C2630", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x87C2B40", Offset = "0x87C1940", VA = "0x1887C2B40", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[HIEDJMGIPME(CBEHFHOOABN.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly PPPCEKHNJDN<object> BIAONEBFKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool LKNCLGOOEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? MNILHNDKFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? DONBBPPPAOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? CMENNOCEDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool OLBPJOLKDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool FKFAEICMOMG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DMPJDCFONNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x87C4B00", Offset = "0x87C3900", VA = "0x1887C4B00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool EKPIANNIKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x87C4AB0", Offset = "0x87C38B0", VA = "0x1887C4AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OKNEMCOLBNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA55A50", Offset = "0xA54850", VA = "0x180A55A50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x87C4CC0", Offset = "0x87C3AC0", VA = "0x1887C4CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action COBHEJKAPLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x87C4A10", Offset = "0x87C3810", VA = "0x1887C4A10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x87C4C20", Offset = "0x87C3A20", VA = "0x1887C4C20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87C4450", Offset = "0x87C3250", VA = "0x1887C4450")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x87C47F0", Offset = "0x87C35F0", VA = "0x1887C47F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87C47A0", Offset = "0x87C35A0", VA = "0x1887C47A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x87C4610", Offset = "0x87C3410", VA = "0x1887C4610")]
		public void Hide(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x87C4970", Offset = "0x87C3770", VA = "0x1887C4970")]
		public void Show(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x87C4880", Offset = "0x87C3680", VA = "0x1887C4880")]
		public void Set(object JLFLGDNCANL, bool FICAMNABAOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x87C4560", Offset = "0x87C3360", VA = "0x1887C4560")]
		public void Clear(bool LEKAEEKPCOG = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x87C4620", Offset = "0x87C3420", VA = "0x1887C4620")]
		private void NHKKIIAGFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x87C44E0", Offset = "0x87C32E0", VA = "0x1887C44E0")]
		[IteratorStateMachine(typeof(BPKPALGEFPJ))]
		private IEnumerator<GCOFLMDGPIM> BJOBFBBJIMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x87C45D0", Offset = "0x87C33D0", VA = "0x1887C45D0", Slot = "5")]
		public virtual void DoHideOrShow(bool JMFJIMNKOFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x87C4980", Offset = "0x87C3780", VA = "0x1887C4980")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CBPOCKDPOIO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum JNKIMFMIFGA
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static GLGKNJAKNPE BJJEAGJHGGA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static GLGKNJAKNPE NPPBOOEHCDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x87C2FE0", Offset = "0x87C1DE0", VA = "0x1887C2FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static JNKIMFMIFGA HHMBCKBNMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87C2C70", Offset = "0x87C1A70", VA = "0x1887C2C70")]
		get
		{
			return default(JNKIMFMIFGA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87C2DA0", Offset = "0x87C1BA0", VA = "0x1887C2DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<JNKIMFMIFGA> KALLBLECCND
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87C2B90", Offset = "0x87C1990", VA = "0x1887C2B90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x87C2F00", Offset = "0x87C1D00", VA = "0x1887C2F00")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BNEOHGIOLDJ : ALEHFMAHCOJ, OODELOOFGJM, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, AKPPMCMFEOB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LLEAAEBCCKF ODBHLALGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJJOHCMLHDB Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject OHJAGGPLIGB);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OJJOHCMLHDB Spawn<T>(int HEBPIPMGCHC, IReadOnlyList<T> FFEMKICJPKP, GameObject OHJAGGPLIGB);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OJJOHCMLHDB Spawn<T>(int HEBPIPMGCHC, IReadOnlyList<T> FFEMKICJPKP, GameObject DOJOLAOGLGI, Func<int, GameObject> PPLGGHAKOAK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int GLAOLHCPLLG, float IEDOFACIFJF);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum LPJBNBADHNG : byte
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
		private static readonly int PEEKCONBIID;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<LPJBNBADHNG, string> HHNLNKHAHGN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int AIBLJIKDOPK = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int GNAEHAOFDNN;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int LIJEBEADHAE;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int PCOHAHBBOGL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int NDKJOEEJIEN;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int KDIODEEPFHL;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int NBCKKNNDICP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int AEPHKEMKEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool CKOAHDNFAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool KKFGCBENABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] HIOLHJKCALP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private LPJBNBADHNG type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly LPJBNBADHNG[] EFKJOHCFDCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[KJBPBAHEFKJ("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly LPJBNBADHNG[] JFIDLDOLMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[KJBPBAHEFKJ("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[KJBPBAHEFKJ("type", LPJBNBADHNG.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[KJBPBAHEFKJ("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic AIBEHPPEJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool JMLKJOFBOLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient JGHNGILPMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x87C6D40", Offset = "0x87C5B40", VA = "0x1887C6D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LPJBNBADHNG KDNIOMEAELB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xC904C0", Offset = "0xC8F2C0", VA = "0x180C904C0")]
			get
			{
				return default(LPJBNBADHNG);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x87C6EC0", Offset = "0x87C5CC0", VA = "0x1887C6EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool AOHIFOPPEGM
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x87C6790", Offset = "0x87C5590", VA = "0x1887C6790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 GAICJEHBFLN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x87C6CB0", Offset = "0x87C5AB0", VA = "0x1887C6CB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x87C6CF0", Offset = "0x87C5AF0", VA = "0x1887C6CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool PKPJCCNGCPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x87C6720", Offset = "0x87C5520", VA = "0x1887C6720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 JFDFJOEOLGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x87C6CD0", Offset = "0x87C5AD0", VA = "0x1887C6CD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x87C6E70", Offset = "0x87C5C70", VA = "0x1887C6E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float OBEHOHEIMMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCA82A0", Offset = "0xCA70A0", VA = "0x180CA82A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x221D0C0", Offset = "0x221BEC0", VA = "0x18221D0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 JIKIBNGFBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x87C5A60", Offset = "0x87C4860", VA = "0x1887C5A60")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 EENOOHMKMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x87C59F0", Offset = "0x87C47F0", VA = "0x1887C59F0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float DEIKDLNEFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA249E0", Offset = "0xA237E0", VA = "0x180A249E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x87C6ED0", Offset = "0x87C5CD0", VA = "0x1887C6ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x87C5850", Offset = "0x87C4650", VA = "0x1887C5850", Slot = "12")]
		protected override void ALFGGKCLAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x87C56C0", Offset = "0x87C44C0", VA = "0x1887C56C0")]
		private void ADOFEOOOEDN(Color[] CJNONEFKKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x87C5CD0", Offset = "0x87C4AD0", VA = "0x1887C5CD0", Slot = "13")]
		protected override void INOBHCLHPDM(Material EFCBJICGDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x87C5AB0", Offset = "0x87C48B0", VA = "0x1887C5AB0", Slot = "14")]
		protected override void HJHJLNPGMHL(Material EFCBJICGDPB, bool MAFNDJNJAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C00", Offset = "0x87C5A00", VA = "0x1887C6C00")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly GJKIJHDOGLH CCCOLBHCLCB;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite KJFHCIBPOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material JEBDFDBEJLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material LECCGKLMLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool AEFLCGGBKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool LKNCLGOOEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool LMFBEMMFAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool DMIIMFHJKPD;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic AIBEHPPEJII
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader JPIDCPAGFIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool JMLKJOFBOLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool JLPCJNJHHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform OFPAKLKCNKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x87C8B80", Offset = "0x87C7980", VA = "0x1887C8B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect MDOENPABBDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x87C8D70", Offset = "0x87C7B70", VA = "0x1887C8D70")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite POGLNBCGIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x87C7EB0", Offset = "0x87C6CB0", VA = "0x1887C7EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x87C81E0", Offset = "0x87C6FE0", VA = "0x1887C81E0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x87C8E90", Offset = "0x87C7C90", VA = "0x1887C8E90", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x87C9190", Offset = "0x87C7F90", VA = "0x1887C9190", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x87C9040", Offset = "0x87C7E40", VA = "0x1887C9040", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x87C8BE0", Offset = "0x87C79E0", VA = "0x1887C8BE0")]
		private void KOBANLAILGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x87C8A10", Offset = "0x87C7810", VA = "0x1887C8A10")]
		private void FOKAIMLDGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x87C83D0", Offset = "0x87C71D0", VA = "0x1887C83D0")]
		private void BHBIPGOPACF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x87C8400", Offset = "0x87C7200", VA = "0x1887C8400")]
		private void CAHGKAFLMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x87C87A0", Offset = "0x87C75A0", VA = "0x1887C87A0")]
		protected void EPDOGAHMKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x87C80A0", Offset = "0x87C6EA0", VA = "0x1887C80A0")]
		private void AMJDKDLLGAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "12")]
		protected virtual void ALFGGKCLAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "13")]
		protected virtual void INOBHCLHPDM(Material EFCBJICGDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "14")]
		protected virtual void HJHJLNPGMHL(Material EFCBJICGDPB, bool MAFNDJNJAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x87C8450", Offset = "0x87C7250", VA = "0x1887C8450")]
		private void DBJLBCFADOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
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
		private static readonly int HFFBNAIJEMK;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int APJFPOGGDIP;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int KKIJFKIFANF;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int DHOCDFAEFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
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
		private Color[] HIOLHJKCALP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] FNHEJFGOLDP;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic AIBEHPPEJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool JLPCJNJHHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> DIOGEFNAIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 GAICJEHBFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2ECB990", Offset = "0x2ECA790", VA = "0x182ECB990")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x87C9CA0", Offset = "0x87C8AA0", VA = "0x1887C9CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x87C98A0", Offset = "0x87C86A0", VA = "0x1887C98A0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> CLCJOMMPNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x87C9660", Offset = "0x87C8460", VA = "0x1887C9660")]
		public bool SetRingLayerColor(int PBGGPJCBAMP, Color DEJLIDMJHPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x87C97B0", Offset = "0x87C85B0", VA = "0x1887C97B0")]
		public bool SetRingLayerSize(int PBGGPJCBAMP, float ACINDEOBNPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x87C9350", Offset = "0x87C8150", VA = "0x1887C9350", Slot = "12")]
		protected override void ALFGGKCLAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x87C94E0", Offset = "0x87C82E0", VA = "0x1887C94E0", Slot = "13")]
		protected override void INOBHCLHPDM(Material EFCBJICGDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x87C9490", Offset = "0x87C8290", VA = "0x1887C9490", Slot = "14")]
		protected override void HJHJLNPGMHL(Material EFCBJICGDPB, bool MAFNDJNJAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x87C99F0", Offset = "0x87C87F0", VA = "0x1887C99F0")]
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
		public enum MKJJDIBOGFO
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int KMGNFEMEJJH;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int JHONIGPDCNP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int DHDKBINLBEF;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int BEGLFCOFOPL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int IKKKNBLNKNP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int LDNIPGKDHEG;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int CLMHNBEPKJO;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int NPAOJKJBIBF;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int JABEAEKIONB;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int KADLKJDLBIM;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int IJBONHPHLIH;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int EPOAFFINEKG;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int CDJLEMICBLH;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int DDLGMBBJJMH;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int CFHDLIBBGGL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int OAJCAMFAMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[DBPOJNFABNN(CBEHFHOOABN.Self, false, false, false)]
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
		private MKJJDIBOGFO animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[KJBPBAHEFKJ("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[KJBPBAHEFKJ("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic AIBEHPPEJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool JLPCJNJHHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite PKJIFMPKEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x87CAB10", Offset = "0x87C9910", VA = "0x1887CAB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x87CAD30", Offset = "0x87C9B30", VA = "0x1887CAD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color HFBEKBFGDBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xEE56F0", Offset = "0xEE44F0", VA = "0x180EE56F0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x87CADC0", Offset = "0x87C9BC0", VA = "0x1887CADC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color JNLJCKHLLPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x11288A0", Offset = "0x11276A0", VA = "0x1811288A0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x87CAC00", Offset = "0x87C9A00", VA = "0x1887CAC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float FIJOGGIPKEL
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCA8620", Offset = "0xCA7420", VA = "0x180CA8620")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x87CACC0", Offset = "0x87C9AC0", VA = "0x1887CACC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 GBEGCANKIPP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x87CAAF0", Offset = "0x87C98F0", VA = "0x1887CAAF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x87CACE0", Offset = "0x87C9AE0", VA = "0x1887CACE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float KJACMEPEAID
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA24640", Offset = "0xA23440", VA = "0x180A24640")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x87CAC80", Offset = "0x87C9A80", VA = "0x1887CAC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 KBCFBOLFBIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x154A7E0", Offset = "0x15495E0", VA = "0x18154A7E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x87CAE40", Offset = "0x87C9C40", VA = "0x1887CAE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float PHGDKKPBPOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x10FE6F0", Offset = "0x10FD4F0", VA = "0x1810FE6F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x87CABD0", Offset = "0x87C99D0", VA = "0x1887CABD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 EIFPPPNAAGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x87C9FF0", Offset = "0x87C8DF0", VA = "0x1887C9FF0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public MKJJDIBOGFO NIHGFBAELHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xE64600", Offset = "0xE63400", VA = "0x180E64600")]
			get
			{
				return default(MKJJDIBOGFO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x87CABF0", Offset = "0x87C99F0", VA = "0x1887CABF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float BAMCKJENGJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x16E08B0", Offset = "0x16DF6B0", VA = "0x1816E08B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x87CACA0", Offset = "0x87C9AA0", VA = "0x1887CACA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float CGAFMJPJGCD
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1676790", Offset = "0x1675590", VA = "0x181676790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x87CABB0", Offset = "0x87C99B0", VA = "0x1887CABB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x87CA080", Offset = "0x87C8E80", VA = "0x1887CA080", Slot = "13")]
		protected override void INOBHCLHPDM(Material EFCBJICGDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x87C9CF0", Offset = "0x87C8AF0", VA = "0x1887C9CF0")]
		private void FEBIJIMEJEO(Sprite ANBFKCCECPF, [Out] Vector2 MDGEIKJEMBJ, [Out] Vector2 GBLMNKLJNHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x87C9FA0", Offset = "0x87C8DA0", VA = "0x1887C9FA0", Slot = "14")]
		protected override void HJHJLNPGMHL(Material EFCBJICGDPB, bool MAFNDJNJAOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x87CAA60", Offset = "0x87C9860", VA = "0x1887CAA60")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader KMIKFKIJBKG;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader JPIDCPAGFIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x87CAEE0", Offset = "0x87C9CE0", VA = "0x1887CAEE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x87CAE90", Offset = "0x87C9C90", VA = "0x1887CAE90")]
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
		private SerializableRectTransform BNGADNBIAPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool DOPKIHHNFNJ;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x87C51F0", Offset = "0x87C3FF0", VA = "0x1887C51F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x87C54D0", Offset = "0x87C42D0", VA = "0x1887C54D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x87C5380", Offset = "0x87C4180", VA = "0x1887C5380")]
		private void DGINAHLMEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x87C5400", Offset = "0x87C4200", VA = "0x1887C5400")]
		private void NHKKIIAGFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GJKIJHDOGLH
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FMCHBCNOBOJ : IEquatable<FMCHBCNOBOJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component JAPGNGDBBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action HBJHDLCFPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int OFEOPFGDJNG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component MPMBGDDFGKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x87C3A20", Offset = "0x87C2820", VA = "0x1887C3A20")]
		public FMCHBCNOBOJ(Component JAPGNGDBBIF, Action HBJHDLCFPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x87C39A0", Offset = "0x87C27A0", VA = "0x1887C39A0")]
		public void FNJHBOGPDPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x87C3900", Offset = "0x87C2700", VA = "0x1887C3900", Slot = "4")]
		public bool Equals(FMCHBCNOBOJ HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x87C3910", Offset = "0x87C2710", VA = "0x1887C3910", Slot = "0")]
		public override bool Equals(object GLEBGNJJOHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KNGIHELGBEH : IEnumerator<GCOFLMDGPIM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private GCOFLMDGPIM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public GJKIJHDOGLH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private GCOFLMDGPIM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA10020", Offset = "0xA0EE20", VA = "0x180A10020")]
		[DebuggerHidden]
		public KNGIHELGBEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x87C4DE0", Offset = "0x87C3BE0", VA = "0x1887C4DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x87C51A0", Offset = "0x87C3FA0", VA = "0x1887C51A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MIMOCNKNDNH HAIPPAABHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int AFMCFPLOOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int GMABDLMHDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> BCEBCKENHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, FMCHBCNOBOJ> HCOHEHAMFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<FMCHBCNOBOJ> KBCBALFFDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<FMCHBCNOBOJ> NBDNMFEEIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private BGLABEGMMJM ALBODPCBHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private IKDBDMPLEPB KNJINGABFCG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private IKDBDMPLEPB LIMNPEHOIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x87C3F80", Offset = "0x87C2D80", VA = "0x1887C3F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x87C42D0", Offset = "0x87C30D0", VA = "0x1887C42D0")]
	public GJKIJHDOGLH(MIMOCNKNDNH HAIPPAABHJL, int AFMCFPLOOJF = -1, int GMABDLMHDML = -1, [Optional] Func<Component, float> BCEBCKENHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x87C3D00", Offset = "0x87C2B00", VA = "0x1887C3D00")]
	public void NGIMJEOBOFG(Component JAPGNGDBBIF, Action GGHOJGJBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x87C3A90", Offset = "0x87C2890", VA = "0x1887C3A90")]
	public void FCAOCEJLMPE(Component JAPGNGDBBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x87C3C20", Offset = "0x87C2A20", VA = "0x1887C3C20")]
	public bool FFJMKPEMMMP(Component OFNOAHMACNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x87C4090", Offset = "0x87C2E90", VA = "0x1887C4090")]
	private void PFKICGIBCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x87C4010", Offset = "0x87C2E10", VA = "0x1887C4010")]
	[IteratorStateMachine(typeof(KNGIHELGBEH))]
	private IEnumerator<GCOFLMDGPIM> PBIPIKLOELN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xE01BF0", Offset = "0xE009F0", VA = "0x180E01BF0")]
	[CompilerGenerated]
	private void DCBFDOPMIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x87C3C80", Offset = "0x87C2A80", VA = "0x1887C3C80")]
	[CompilerGenerated]
	private float IHGACEEIMEE(FMCHBCNOBOJ GGHOJGJBMPF)
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
