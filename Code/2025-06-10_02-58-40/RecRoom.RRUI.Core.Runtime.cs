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
				[Cpp2IlInjected.Address(RVA = "0x8693750", Offset = "0x8692950", VA = "0x188693750")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x86937B0", Offset = "0x86929B0", VA = "0x1886937B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8693710", Offset = "0x8692910", VA = "0x188693710")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8693250", Offset = "0x8692450", VA = "0x188693250")]
			public void EOJDDMMGLPC(PointerEventData DBHAHFAPADE, RectTransform OKDAAIMPOPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8693350", Offset = "0x8692550", VA = "0x188693350")]
			public void HBNJNAEFKJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x86935E0", Offset = "0x86927E0", VA = "0x1886935E0")]
			public void KAEEGEFNBMO(PointerEventData DBHAHFAPADE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86936C0", Offset = "0x86928C0", VA = "0x1886936C0")]
			public void KLIBLPMNGNM(float NANNILJHLAE, RectTransform OKDAAIMPOPC, Vector3 JCHDHELBFIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly KFOHPPMEALH<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KFOHPPMEALH<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly KFOHPPMEALH<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly KFOHPPMEALH<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly KFOHPPMEALH<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly EPHHEFDKGKL PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData DPPJIBFBHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool GCLJBNKLOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool CFOAKOBNLAC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BKODIBDLEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA0FD10", Offset = "0xA0EF10", VA = "0x180A0FD10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x86929E0", Offset = "0x8691BE0", VA = "0x1886929E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HAGBIAHNPON
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA0FC00", Offset = "0xA0EE00", VA = "0x180A0FC00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8692A90", Offset = "0x8691C90", VA = "0x188692A90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8692A10", Offset = "0x8691C10", VA = "0x188692A10")]
		private bool CMEJKMMCIPF(PointerEventData ODLIDIMANGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8692F10", Offset = "0x8692110", VA = "0x188692F10", Slot = "5")]
		public void OnPointerDown(PointerEventData ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8692FD0", Offset = "0x86921D0", VA = "0x188692FD0", Slot = "11")]
		public void OnPointerUp(PointerEventData ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8692D80", Offset = "0x8691F80", VA = "0x188692D80", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8692AC0", Offset = "0x8691CC0", VA = "0x188692AC0", Slot = "7")]
		public void OnBeginDrag(PointerEventData ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8692BD0", Offset = "0x8691DD0", VA = "0x188692BD0", Slot = "4")]
		public void OnDrag(PointerEventData ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8692CB0", Offset = "0x8691EB0", VA = "0x188692CB0", Slot = "8")]
		public void OnEndDrag(PointerEventData ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F70", Offset = "0x8692170", VA = "0x188692F70", Slot = "9")]
		public void OnPointerEnter(PointerEventData ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8692FA0", Offset = "0x86921A0", VA = "0x188692FA0", Slot = "10")]
		public void OnPointerExit(PointerEventData ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8692B90", Offset = "0x8691D90", VA = "0x188692B90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8693030", Offset = "0x8692230", VA = "0x188693030")]
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
		[Cpp2IlInjected.Address(RVA = "0x868E1C0", Offset = "0x868D3C0", VA = "0x18868E1C0")]
		public void SetCanvasSortingOrder(short LKMCICBJFDA, bool POBIJKOBLMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData OMKMGKMIJFP;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x868E480", Offset = "0x868D680", VA = "0x18868E480", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x868E360", Offset = "0x868D560", VA = "0x18868E360", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x868E2B0", Offset = "0x868D4B0", VA = "0x18868E2B0")]
		private void JBCFCPPDOED(GameObject FCIPDGNDBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x868E760", Offset = "0x868D960", VA = "0x18868E760")]
		public void SetOptionsWithNoDefault(List<string> LMKJLPPFOFC, [Optional] string AIEKBEAOOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x868E670", Offset = "0x868D870", VA = "0x18868E670")]
		public void SetOptionsWithNoDefault(List<OptionData> AFJJJNJGALF, [Optional] string AIEKBEAOOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x868E5A0", Offset = "0x868D7A0", VA = "0x18868E5A0", Slot = "42")]
		public override void OnPointerClick(PointerEventData ODLIDIMANGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA02C70", Offset = "0xA01E70", VA = "0x180A02C70", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas MMHFMGICDEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x868E980", Offset = "0x868DB80", VA = "0x18868E980")]
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
		private sealed class MNELFJDPMPE : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private NOFGPJFCPHG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
			[DebuggerHidden]
			public MNELFJDPMPE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x86907F0", Offset = "0x868F9F0", VA = "0x1886907F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8690D00", Offset = "0x868FF00", VA = "0x188690D00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[GOJJDCGGJEB(CFJMFGLCHFI.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly PHHKPNCAPOP<object> HNNDMPACFDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool MLOPDFPPDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? PEJCFIKLIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? HLLOCBGONCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? EGNPAFFABFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool GGKPMOAHMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool DJNHHLEKMBF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KLKCNCEMAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x868FA40", Offset = "0x868EC40", VA = "0x18868FA40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool CGNOEHMCBIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x868F9F0", Offset = "0x868EBF0", VA = "0x18868F9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PINGBGPEIJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA4E470", Offset = "0xA4D670", VA = "0x180A4E470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x868FC00", Offset = "0x868EE00", VA = "0x18868FC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DOIAKHAOCKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x868F950", Offset = "0x868EB50", VA = "0x18868F950")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x868FB60", Offset = "0x868ED60", VA = "0x18868FB60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x868F390", Offset = "0x868E590", VA = "0x18868F390")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x868F730", Offset = "0x868E930", VA = "0x18868F730")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x868F6E0", Offset = "0x868E8E0", VA = "0x18868F6E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x868F650", Offset = "0x868E850", VA = "0x18868F650")]
		public void Hide(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x868F8B0", Offset = "0x868EAB0", VA = "0x18868F8B0")]
		public void Show(object CCLFNPCGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x868F7C0", Offset = "0x868E9C0", VA = "0x18868F7C0")]
		public void Set(object CCLFNPCGNED, bool CBDBIFFHEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x868F420", Offset = "0x868E620", VA = "0x18868F420")]
		public void Clear(bool JDILJNBMIAC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x868F4D0", Offset = "0x868E6D0", VA = "0x18868F4D0")]
		private void EEALFEEFDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x868F660", Offset = "0x868E860", VA = "0x18868F660")]
		[IteratorStateMachine(typeof(MNELFJDPMPE))]
		private IEnumerator<NOFGPJFCPHG> JNCNCDMMCBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x868F490", Offset = "0x868E690", VA = "0x18868F490", Slot = "5")]
		public virtual void DoHideOrShow(bool LAOIJGFKDJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x868F8C0", Offset = "0x868EAC0", VA = "0x18868F8C0")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IDMANFHPJIH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum DJIOINBHKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static PGCLBGKNLGG DJBLKPMGANI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static PGCLBGKNLGG KACFMNGNNKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x868FD20", Offset = "0x868EF20", VA = "0x18868FD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static DJIOINBHKFJ LDACKBBKFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x868FE20", Offset = "0x868F020", VA = "0x18868FE20")]
		get
		{
			return default(DJIOINBHKFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8690020", Offset = "0x868F220", VA = "0x188690020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<DJIOINBHKFJ> CNPCKOADKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8690180", Offset = "0x868F380", VA = "0x188690180")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x868FF50", Offset = "0x868F150", VA = "0x18868FF50")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EOELPIFFMGF : FCKAHBFEIHH, BEIHMMPGBAL, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, GGPPJIFOAEE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EPHHEFDKGKL JHDAFLCCKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ABAHHGGDFBO Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject IJDBKPEJDOI);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABAHHGGDFBO Spawn<T>(int MKDAJJAABAK, IReadOnlyList<T> CAIGHLKIDBF, GameObject IJDBKPEJDOI);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ABAHHGGDFBO Spawn<T>(int MKDAJJAABAK, IReadOnlyList<T> CAIGHLKIDBF, GameObject LEHEILEEABL, Func<int, GameObject> DHPABJONBHM);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int CMDFFDAPDIB, float LKEPBNCCAPK);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum LAMKPJILMOF : byte
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
		private static readonly int NCBKMLHPEMI;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<LAMKPJILMOF, string> GOFPKHCMDMH;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int GLAFJANLMHK = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int LEBMBCFCPPA;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int HODLFAFMJEG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int JEIJHPECLBN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int JINIBDIEAHH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int HKNDFJPKIOH;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int EFOGHCILJKE;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int KOFKJPKEPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool AOIBJLCPHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool AIEIOCNHIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] APKMGNHEJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private LAMKPJILMOF type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly LAMKPJILMOF[] GJGFBICCIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[DGHDPMNMPGC("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly LAMKPJILMOF[] CEPBNIKNGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DGHDPMNMPGC("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[DGHDPMNMPGC("type", LAMKPJILMOF.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[DGHDPMNMPGC("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic KEJJDMBCIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool NNGFJAKICAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient IABPLOPBOJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8692830", Offset = "0x8691A30", VA = "0x188692830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LAMKPJILMOF BGLOFMKFAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCCB610", Offset = "0xCCA810", VA = "0x180CCB610")]
			get
			{
				return default(LAMKPJILMOF);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x86929B0", Offset = "0x8691BB0", VA = "0x1886929B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool IABMGANCAKG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x86913A0", Offset = "0x86905A0", VA = "0x1886913A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 DOIJHAMJAFE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x86927A0", Offset = "0x86919A0", VA = "0x1886927A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x86927E0", Offset = "0x86919E0", VA = "0x1886927E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool PNMLPEBEHHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8691820", Offset = "0x8690A20", VA = "0x188691820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 NONFLPGEECD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x86927C0", Offset = "0x86919C0", VA = "0x1886927C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8692960", Offset = "0x8691B60", VA = "0x188692960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CPFLKHNKNDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCECA70", Offset = "0xCEBC70", VA = "0x180CECA70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x22C9AA0", Offset = "0x22C8CA0", VA = "0x1822C9AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 IELKBDIPFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8691630", Offset = "0x8690830", VA = "0x188691630")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 JJEPIMNCCAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8691890", Offset = "0x8690A90", VA = "0x188691890")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float HMNLKFNHEHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA1C920", Offset = "0xA1BB20", VA = "0x180A1C920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x86929C0", Offset = "0x8691BC0", VA = "0x1886929C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8691680", Offset = "0x8690880", VA = "0x188691680", Slot = "12")]
		protected override void KCGNEAIANIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8691210", Offset = "0x8690410", VA = "0x188691210")]
		private void BMIADJEPIBD(Color[] GKNPBKILJEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8691900", Offset = "0x8690B00", VA = "0x188691900", Slot = "13")]
		protected override void NGMPCFIFIEC(Material ADKDGJDNNAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8691410", Offset = "0x8690610", VA = "0x188691410", Slot = "14")]
		protected override void FBBKIAJLLKM(Material ADKDGJDNNAD, bool NPFLOGOKNBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86926F0", Offset = "0x86918F0", VA = "0x1886926F0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly GDEMNILKMCA EMDJACCELNE;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite MKMEGPCMCEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material LEGMMMOOLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material ILLMPLHNFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool DBOINDKLHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool MLOPDFPPDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool HHJKIKKCJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool HGCJKOCKDHP;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic KEJJDMBCIOC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader LPKOAFHEFCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool NNGFJAKICAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool MGMHEIFADIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform OKDAAIMPOPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8694090", Offset = "0x8693290", VA = "0x188694090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect EJMILLGKAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x86944F0", Offset = "0x86936F0", VA = "0x1886944F0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite FOAFIDPIMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8693B90", Offset = "0x8692D90", VA = "0x188693B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x86939A0", Offset = "0x8692BA0", VA = "0x1886939A0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8694960", Offset = "0x8693B60", VA = "0x188694960", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8694C60", Offset = "0x8693E60", VA = "0x188694C60", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8694B10", Offset = "0x8693D10", VA = "0x188694B10", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8693EB0", Offset = "0x86930B0", VA = "0x188693EB0")]
		private void EEPDBJHBHIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8694380", Offset = "0x8693580", VA = "0x188694380")]
		private void LILKKGDLPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8694350", Offset = "0x8693550", VA = "0x188694350")]
		private void LALJACMMKBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8694040", Offset = "0x8693240", VA = "0x188694040")]
		private void ENNJICKFAIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x86940F0", Offset = "0x86932F0", VA = "0x1886940F0")]
		protected void ICBNIKIHOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8693D70", Offset = "0x8692F70", VA = "0x188693D70")]
		private void EAAPLOAJFEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "12")]
		protected virtual void KCGNEAIANIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "13")]
		protected virtual void NGMPCFIFIEC(Material ADKDGJDNNAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "14")]
		protected virtual void FBBKIAJLLKM(Material ADKDGJDNNAD, bool NPFLOGOKNBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8694610", Offset = "0x8693810", VA = "0x188694610")]
		private void NCFKFCOBMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
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
		private static readonly int AIJMNIGDIGO;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int KIFIAPKKDLJ;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int GPABLJGOEEC;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int KIONBLBPDIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
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
		private Color[] APKMGNHEJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] JGJHPFIEPCI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic KEJJDMBCIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool MGMHEIFADIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> HLBPNDCNCIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 DOIJHAMJAFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2F73650", Offset = "0x2F72850", VA = "0x182F73650")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8695710", Offset = "0x8694910", VA = "0x188695710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8695350", Offset = "0x8694550", VA = "0x188695350")]
		public void SetRingLayers(IReadOnlyList<RingLayer> EPLNMELCEOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8695110", Offset = "0x8694310", VA = "0x188695110")]
		public bool SetRingLayerColor(int BMDFOPHBMNP, Color NEMIFEKMDAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8695260", Offset = "0x8694460", VA = "0x188695260")]
		public bool SetRingLayerSize(int BMDFOPHBMNP, float GCFCAGDGDIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8694E60", Offset = "0x8694060", VA = "0x188694E60", Slot = "12")]
		protected override void KCGNEAIANIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8694FA0", Offset = "0x86941A0", VA = "0x188694FA0", Slot = "13")]
		protected override void NGMPCFIFIEC(Material ADKDGJDNNAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8694E10", Offset = "0x8694010", VA = "0x188694E10", Slot = "14")]
		protected override void FBBKIAJLLKM(Material ADKDGJDNNAD, bool NPFLOGOKNBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86954A0", Offset = "0x86946A0", VA = "0x1886954A0")]
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
		public enum ICPJJPJNPIO
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int HPIICGIPDMC;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int CPIOMLNKPIP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int EPKAKHAGMFL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int FOLGHCPMECI;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int LPIPIIHPBEN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int BEJLEBIGOGN;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int GHPAJBLGHBP;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int BMGDBNCOOBH;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int CLIGGBPODBP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int DCFKBIONHEK;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int NHMDKBDOMJL;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int GHJDKKAOHPK;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int CFHPNBGGAHD;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int HGAPLPGIMFO;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int DDNKFCNCHFP;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int GLINFFCMKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[GBCGIPBAICF(CFJMFGLCHFI.Self, false, false, false)]
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
		private ICPJJPJNPIO animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[DGHDPMNMPGC("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[DGHDPMNMPGC("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic KEJJDMBCIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool MGMHEIFADIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA1C570", Offset = "0xA1B770", VA = "0x180A1C570", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite IAKOOPMDFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8696510", Offset = "0x8695710", VA = "0x188696510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8696730", Offset = "0x8695930", VA = "0x188696730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color NEAIOGPCPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF35C10", Offset = "0xF34E10", VA = "0x180F35C10")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x86967C0", Offset = "0x86959C0", VA = "0x1886967C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color HNGLIEGIGFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x111A760", Offset = "0x1119960", VA = "0x18111A760")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8696600", Offset = "0x8695800", VA = "0x188696600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float DFEBEIHPKFF
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCEC570", Offset = "0xCEB770", VA = "0x180CEC570")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x86966C0", Offset = "0x86958C0", VA = "0x1886966C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 OOCOKIJLHCN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x86964F0", Offset = "0x86956F0", VA = "0x1886964F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x86966E0", Offset = "0x86958E0", VA = "0x1886966E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float IJIKKLFMGBN
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA1C580", Offset = "0xA1B780", VA = "0x180A1C580")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8696680", Offset = "0x8695880", VA = "0x188696680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 JCPNDHLLKPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x15F1B00", Offset = "0x15F0D00", VA = "0x1815F1B00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8696840", Offset = "0x8695A40", VA = "0x188696840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float GLBDLGJKHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x10F0890", Offset = "0x10EFA90", VA = "0x1810F0890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x86965D0", Offset = "0x86957D0", VA = "0x1886965D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 BOFJICPPBIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8695760", Offset = "0x8694960", VA = "0x188695760")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public ICPJJPJNPIO DFAIIIDCILG
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xEB76E0", Offset = "0xEB68E0", VA = "0x180EB76E0")]
			get
			{
				return default(ICPJJPJNPIO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x86965F0", Offset = "0x86957F0", VA = "0x1886965F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float FNJFKDGEGGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1783310", Offset = "0x1782510", VA = "0x181783310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x86966A0", Offset = "0x86958A0", VA = "0x1886966A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float BAPEMMIOEOF
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1718980", Offset = "0x1717B80", VA = "0x181718980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x86965B0", Offset = "0x86957B0", VA = "0x1886965B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8695840", Offset = "0x8694A40", VA = "0x188695840", Slot = "13")]
		protected override void NGMPCFIFIEC(Material ADKDGJDNNAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8695F00", Offset = "0x8695100", VA = "0x188695F00")]
		private void OGOLBOFIGFP(Sprite OOCJFCAJFBO, [Out] Vector2 CELNMIMHGLF, [Out] Vector2 APGPIMPDGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86957F0", Offset = "0x86949F0", VA = "0x1886957F0", Slot = "14")]
		protected override void FBBKIAJLLKM(Material ADKDGJDNNAD, bool NPFLOGOKNBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8696460", Offset = "0x8695660", VA = "0x188696460")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader HCLANHDKJJN;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader LPKOAFHEFCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x86968E0", Offset = "0x8695AE0", VA = "0x1886968E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8696890", Offset = "0x8695A90", VA = "0x188696890")]
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
		private SerializableRectTransform KFLMBHJAEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool JHEBCAKKBMB;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8690D50", Offset = "0x868FF50", VA = "0x188690D50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8691030", Offset = "0x8690230", VA = "0x188691030")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8690FB0", Offset = "0x86901B0", VA = "0x188690FB0")]
		private void HCBBEIAENFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8690EE0", Offset = "0x86900E0", VA = "0x188690EE0")]
		private void EEALFEEFDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GDEMNILKMCA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct LDLHJENFFKF : IEquatable<LDLHJENFFKF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component BKDMJHGCDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action IPFCIDNOIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int DAIMGIMPEJL;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component ODILGJPAECC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xD919D0", Offset = "0xD90BD0", VA = "0x180D919D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8690370", Offset = "0x868F570", VA = "0x188690370")]
		public LDLHJENFFKF(Component BKDMJHGCDEA, Action IPFCIDNOIEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x86902F0", Offset = "0x868F4F0", VA = "0x1886902F0")]
		public void FAIPCIDKNKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x86902E0", Offset = "0x868F4E0", VA = "0x1886902E0", Slot = "4")]
		public bool Equals(LDLHJENFFKF CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8690250", Offset = "0x868F450", VA = "0x188690250", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class MGMDBMLFJDL : IEnumerator<NOFGPJFCPHG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private NOFGPJFCPHG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public GDEMNILKMCA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private NOFGPJFCPHG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA061B0", Offset = "0xA053B0", VA = "0x180A061B0")]
		[DebuggerHidden]
		public MGMDBMLFJDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86903E0", Offset = "0x868F5E0", VA = "0x1886903E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x86907A0", Offset = "0x868F9A0", VA = "0x1886907A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly BLKNIDPJAGC NBJKFEKGNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int OMMMHMADILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int JILAMNEPJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> PPAODKMJKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, LDLHJENFFKF> AGEMADDFDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<LDLHJENFFKF> KLIAANOOMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<LDLHJENFFKF> BGEAFJKAHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private AFABIGEDGFJ BIECJAMLFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private CDCCKKMKCIE OADIOMFHFDP;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private CDCCKKMKCIE OIIMMODDBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x868E9D0", Offset = "0x868DBD0", VA = "0x18868E9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x868F210", Offset = "0x868E410", VA = "0x18868F210")]
	public GDEMNILKMCA(BLKNIDPJAGC NBJKFEKGNPB, int OMMMHMADILD = -1, int JILAMNEPJCE = -1, [Optional] Func<Component, float> PPAODKMJKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x868EE30", Offset = "0x868E030", VA = "0x18868EE30")]
	public void GDBPOHKEPGO(Component BKDMJHGCDEA, Action LPBJFFLCJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x868ECA0", Offset = "0x868DEA0", VA = "0x18868ECA0")]
	public void DLCOONMOKPI(Component BKDMJHGCDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x868F1B0", Offset = "0x868E3B0", VA = "0x18868F1B0")]
	public bool OCFCPPGBJPG(Component JCAGDPHNPIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x868EA60", Offset = "0x868DC60", VA = "0x18868EA60")]
	private void APGCPKIGFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x868F130", Offset = "0x868E330", VA = "0x18868F130")]
	[IteratorStateMachine(typeof(MGMDBMLFJDL))]
	private IEnumerator<NOFGPJFCPHG> NLCPOCFNMMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xE3F0E0", Offset = "0xE3E2E0", VA = "0x180E3F0E0")]
	[CompilerGenerated]
	private void JHCIEFLFAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x868F0B0", Offset = "0x868E2B0", VA = "0x18868F0B0")]
	[CompilerGenerated]
	private float JDODIJMMHJO(LDLHJENFFKF LPBJFFLCJMN)
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
