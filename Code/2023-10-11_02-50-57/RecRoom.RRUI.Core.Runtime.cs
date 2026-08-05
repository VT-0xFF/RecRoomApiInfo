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
				[Cpp2IlInjected.Address(RVA = "0x62D0BF0", Offset = "0x62CF9F0", VA = "0x1862D0BF0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x62D0C50", Offset = "0x62CFA50", VA = "0x1862D0C50")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x62D0BA0", Offset = "0x62CF9A0", VA = "0x1862D0BA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x62D0970", Offset = "0x62CF770", VA = "0x1862D0970")]
			public void GMCBMOEEHJE(PointerEventData MGBCKBHOACK, RectTransform KBCCIAJPKAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x62D06E0", Offset = "0x62CF4E0", VA = "0x1862D06E0")]
			public void FAOOGLBCHBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x62D0A70", Offset = "0x62CF870", VA = "0x1862D0A70")]
			public void KNBFBGJOEEF(PointerEventData MGBCKBHOACK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x62D0B50", Offset = "0x62CF950", VA = "0x1862D0B50")]
			public void PHMKIPBJCCA(float IPDBMLPBOBA, RectTransform KBCCIAJPKAH, Vector3 ELHIODNHAHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[IJAALANNOJP(PPPBLHJADIM.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly HEBNGJMIMPC<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly HEBNGJMIMPC<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly HEBNGJMIMPC<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly HEBNGJMIMPC<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly HEBNGJMIMPC<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly ECJBBEDPNJE PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData AEIELMBOABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool KDIFILGPEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool PNHGGJMFHDL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OPCPFCNPDBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x76EAB0", Offset = "0x76D8B0", VA = "0x18076EAB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x62CFEA0", Offset = "0x62CECA0", VA = "0x1862CFEA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LBJBDFGEBHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x76E9E0", Offset = "0x76D7E0", VA = "0x18076E9E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x62CFE70", Offset = "0x62CEC70", VA = "0x1862CFE70")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62CFED0", Offset = "0x62CECD0", VA = "0x1862CFED0")]
		private bool NHEHDCDKBMH(PointerEventData EMJLGCDONIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62D03A0", Offset = "0x62CF1A0", VA = "0x1862D03A0", Slot = "5")]
		public void OnPointerDown(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62D0460", Offset = "0x62CF260", VA = "0x1862D0460", Slot = "11")]
		public void OnPointerUp(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62D0210", Offset = "0x62CF010", VA = "0x1862D0210", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62CFF50", Offset = "0x62CED50", VA = "0x1862CFF50", Slot = "7")]
		public void OnBeginDrag(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62D0060", Offset = "0x62CEE60", VA = "0x1862D0060", Slot = "4")]
		public void OnDrag(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62D0140", Offset = "0x62CEF40", VA = "0x1862D0140", Slot = "8")]
		public void OnEndDrag(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62D0400", Offset = "0x62CF200", VA = "0x1862D0400", Slot = "9")]
		public void OnPointerEnter(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62D0430", Offset = "0x62CF230", VA = "0x1862D0430", Slot = "10")]
		public void OnPointerExit(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62D0020", Offset = "0x62CEE20", VA = "0x1862D0020")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62D04C0", Offset = "0x62CF2C0", VA = "0x1862D04C0")]
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
		private OptionData GCFEHEJFKNE;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x62CC760", Offset = "0x62CB560", VA = "0x1862CC760", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x62CC660", Offset = "0x62CB460", VA = "0x1862CC660", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x62CC5B0", Offset = "0x62CB3B0", VA = "0x1862CC5B0")]
		private void LFAALEIMPAI(GameObject OMNDLPFMNGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62CCA20", Offset = "0x62CB820", VA = "0x1862CCA20")]
		public void SetOptionsWithNoDefault(List<string> HJOJMOBKMOL, [Optional] string JKCJNNFOIAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62CC930", Offset = "0x62CB730", VA = "0x1862CC930")]
		public void SetOptionsWithNoDefault(List<OptionData> DJBANEJKJAN, [Optional] string JKCJNNFOIAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62CC860", Offset = "0x62CB660", VA = "0x1862CC860", Slot = "42")]
		public override void OnPointerClick(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas AHPALLGLKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62CCC50", Offset = "0x62CBA50", VA = "0x1862CCC50")]
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
		private sealed class NJICCBAGPPC : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private CCMEGKBIKJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
			[DebuggerHidden]
			public NJICCBAGPPC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x62CE3B0", Offset = "0x62CD1B0", VA = "0x1862CE3B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x62CE8A0", Offset = "0x62CD6A0", VA = "0x1862CE8A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[IJAALANNOJP(PPPBLHJADIM.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[JOILJIPACIH(PPPBLHJADIM.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IBKPFCNCMON DEMJDDMPDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool FKCADBJILCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? PFHOLMCGPOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? NABHALIBPFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? NBIDHABBJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool BPIDDIPOIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool LMBJGPJHLPD;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BMNJIHJFKJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x62CD840", Offset = "0x62CC640", VA = "0x1862CD840", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool CMEEPFAHENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x62CD820", Offset = "0x62CC620", VA = "0x1862CD820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MCCBIHMFDNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xC93A70", Offset = "0xC92870", VA = "0x180C93A70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x62CD9F0", Offset = "0x62CC7F0", VA = "0x1862CD9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HODDBMPMCGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x62CD780", Offset = "0x62CC580", VA = "0x1862CD780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x62CD950", Offset = "0x62CC750", VA = "0x1862CD950")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62CD1C0", Offset = "0x62CBFC0", VA = "0x1862CD1C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62CD550", Offset = "0x62CC350", VA = "0x1862CD550")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62CD4D0", Offset = "0x62CC2D0", VA = "0x1862CD4D0")]
		public void Hide(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62CD680", Offset = "0x62CC480", VA = "0x1862CD680")]
		public void Show(object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62CD5E0", Offset = "0x62CC3E0", VA = "0x1862CD5E0")]
		public void Set(object PFKLELGAJPH, bool JCLAPIPENOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62CD310", Offset = "0x62CC110", VA = "0x1862CD310")]
		private void GLOAFBCLGBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62CD250", Offset = "0x62CC050", VA = "0x1862CD250")]
		[IteratorStateMachine(typeof(NJICCBAGPPC))]
		private IEnumerator<CCMEGKBIKJP> DEJCOMPIAKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62CD2D0", Offset = "0x62CC0D0", VA = "0x1862CD2D0", Slot = "5")]
		public virtual void DoHideOrShow(bool AEPPGCIFKFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62CD700", Offset = "0x62CC500", VA = "0x1862CD700")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HPNOGMMIAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x764430", Offset = "0x763230", VA = "0x180764430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> JNCCPCBJOBE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x62CDB50", Offset = "0x62CC950", VA = "0x1862CDB50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x62CDCB0", Offset = "0x62CCAB0", VA = "0x1862CDCB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> GGOODIAMCKM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x62CDC00", Offset = "0x62CCA00", VA = "0x1862CDC00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x62CDD60", Offset = "0x62CCB60", VA = "0x1862CDD60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62CDB10", Offset = "0x62CC910", VA = "0x1862CDB10", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x62CDB30", Offset = "0x62CC930", VA = "0x1862CDB30", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData EMJLGCDONIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xB81DE0", Offset = "0xB80BE0", VA = "0x180B81DE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB81DE0", Offset = "0xB80BE0", VA = "0x180B81DE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HIFCLMJPBNI
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum IAMONEJEHAD
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static AABBEAPGIEF DPGJAGINNKD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static AABBEAPGIEF BDHBHNOPDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62CCDD0", Offset = "0x62CBBD0", VA = "0x1862CCDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static IAMONEJEHAD MKKBENGDHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62CCCA0", Offset = "0x62CBAA0", VA = "0x1862CCCA0")]
		get
		{
			return default(IAMONEJEHAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62CCEA0", Offset = "0x62CBCA0", VA = "0x1862CCEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<IAMONEJEHAD> NBJEBFDHCBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62CD000", Offset = "0x62CBE00", VA = "0x1862CD000")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62CD0E0", Offset = "0x62CBEE0", VA = "0x1862CD0E0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DODFCEKPKIB : BLJJKGKNCGP, MKEMNJCHMLB, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GNIKJMLLIOJ<GameObject, int> DIANGEKCJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	GGFMHBMHBCG<GameObject, int, bool> JADMIDPOLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HEBNGJMIMPC<bool> POOBBOCMLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool BPMMEJAMPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float GAPMFPJKCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HEBNGJMIMPC<float> NCOHIAOLJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ECJBBEDPNJE HBGMFPLJOBO
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
	void SpawnLoadingPlaceholders(GameObject MCMNAIINBFO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BJEHAIIHJME Spawn<T>(int JAGGBOCKDJO, IReadOnlyList<T> PFDMLBFKIAP, GameObject MCMNAIINBFO);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BJEHAIIHJME Spawn<T>(int JAGGBOCKDJO, IReadOnlyList<T> PFDMLBFKIAP, GameObject MNAOAOAPGKI, Func<int, GameObject> FOPGBDFBCHI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int DOJILIOCHKM, float GDHLEFOEPPA);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum ILKPNDLHOBL : byte
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
		private static readonly int GEOOFHIENKJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<ILKPNDLHOBL, string> DMDPOIJBMLM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int BANILLFIAKM = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int MCIICBEMEBA;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int PFMLEADPLDG;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int NPFOMONLNKP;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int PIJOAMKFLKJ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int HOAJJCOHBNF;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int FCKLHKAJIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[IJAALANNOJP(PPPBLHJADIM.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool LKDBOOPHKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool JDDGAKDKFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] BPPABJPMMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private ILKPNDLHOBL type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly ILKPNDLHOBL[] PPHPHMMCCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[ELGPBFENPIK("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly ILKPNDLHOBL[] KAALLJKFGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[ELGPBFENPIK("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[ELGPBFENPIK("type", ILKPNDLHOBL.CustomDirection)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ELGPBFENPIK("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic GJNCOMFAJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool DGDHPBOCIFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient MHPHCLCGLHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x76B160", Offset = "0x769F60", VA = "0x18076B160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x62CFCC0", Offset = "0x62CEAC0", VA = "0x1862CFCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public ILKPNDLHOBL DNFOEPJPNMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7C0", Offset = "0xA3A5C0", VA = "0x180A3B7C0")]
			get
			{
				return default(ILKPNDLHOBL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x62CFE40", Offset = "0x62CEC40", VA = "0x1862CFE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool ANAPFIKCJOI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x62CF490", Offset = "0x62CE290", VA = "0x1862CF490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 CBNGOLEICDK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x62CFC30", Offset = "0x62CEA30", VA = "0x1862CFC30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x62CFC70", Offset = "0x62CEA70", VA = "0x1862CFC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool DCNFEIGLIGE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x62CE9D0", Offset = "0x62CD7D0", VA = "0x1862CE9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 LCMNAFCGPFN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x62CFC50", Offset = "0x62CEA50", VA = "0x1862CFC50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x62CFDF0", Offset = "0x62CEBF0", VA = "0x1862CFDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float PMKCJDNBIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1210680", Offset = "0x120F480", VA = "0x181210680")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x121C810", Offset = "0x121B610", VA = "0x18121C810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 GDNHPNMCOFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x62CF720", Offset = "0x62CE520", VA = "0x1862CF720")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 KADIDMIGFAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x62CF690", Offset = "0x62CE490", VA = "0x1862CF690")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float OICGGNHGCAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x77D6C0", Offset = "0x77C4C0", VA = "0x18077D6C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x62CFE50", Offset = "0x62CEC50", VA = "0x1862CFE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62CF2F0", Offset = "0x62CE0F0", VA = "0x1862CF2F0", Slot = "12")]
		protected override void EJNONGILLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62CF500", Offset = "0x62CE300", VA = "0x1862CF500")]
		private void LNONIKDJAIP(Color[] JEILKOEMCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62CEA40", Offset = "0x62CD840", VA = "0x1862CEA40", Slot = "13")]
		protected override void DIJKKNNGEBF(Material DDNJBDIAIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62CF0D0", Offset = "0x62CDED0", VA = "0x1862CF0D0", Slot = "14")]
		protected override void DNPPAPEMCFC(Material DDNJBDIAIEB, bool HNEIOJHCMIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62CFB80", Offset = "0x62CE980", VA = "0x1862CFB80")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly DOGIADMOAEG BAJFKMBPHNK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite ODKMANACBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material AHDJDOJANDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material CCFOHLCIPKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool AMIBEBMIGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool FKCADBJILCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool NMELNGNGPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool OGENLGFIOON;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic GJNCOMFAJFD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader OCLJBFOAELF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool DGDHPBOCIFM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool BLEDANOAELM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform KBCCIAJPKAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x62D1740", Offset = "0x62D0540", VA = "0x1862D1740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect NGJCIFBJECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x62D12D0", Offset = "0x62D00D0", VA = "0x1862D12D0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite NIFKPMABCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x62D17A0", Offset = "0x62D05A0", VA = "0x1862D17A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62D0E40", Offset = "0x62CFC40", VA = "0x1862D0E40", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62D1AE0", Offset = "0x62D08E0", VA = "0x1862D1AE0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62D1DE0", Offset = "0x62D0BE0", VA = "0x1862D1DE0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62D1C90", Offset = "0x62D0A90", VA = "0x1862D1C90", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62D15B0", Offset = "0x62D03B0", VA = "0x1862D15B0")]
		private void LJNMGIEIOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62D1440", Offset = "0x62D0240", VA = "0x1862D1440")]
		private void JOAMDDKDDLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62D1030", Offset = "0x62CFE30", VA = "0x1862D1030")]
		private void DMICNACEFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62D13F0", Offset = "0x62D01F0", VA = "0x1862D13F0")]
		private void JJNNCCDMJAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62D1060", Offset = "0x62CFE60", VA = "0x1862D1060")]
		protected void FKEKGJCMBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62D19A0", Offset = "0x62D07A0", VA = "0x1862D19A0")]
		private void OIHIAGGHOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "12")]
		protected virtual void EJNONGILLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "13")]
		protected virtual void DIJKKNNGEBF(Material DDNJBDIAIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "14")]
		protected virtual void DNPPAPEMCFC(Material DDNJBDIAIEB, bool HNEIOJHCMIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62D1DF0", Offset = "0x62D0BF0", VA = "0x1862D1DF0")]
		private void PLHHJECCDEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
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
		private static readonly int NMNPCFHPFHL;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int EMDJIOFGNEH;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int OCNICAKPBNN;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int LJLLFDLIDML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[IJAALANNOJP(PPPBLHJADIM.Self, false, false, false)]
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
		private Color[] BPPABJPMMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] JHMMLHOKNIF;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic GJNCOMFAJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool BLEDANOAELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> KKPEPPKFAMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 CBNGOLEICDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x62D2C00", Offset = "0x62D1A00", VA = "0x1862D2C00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x62D2C20", Offset = "0x62D1A20", VA = "0x1862D2C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62D2840", Offset = "0x62D1640", VA = "0x1862D2840")]
		public void SetRingLayers(IReadOnlyList<RingLayer> MALIFHHJAJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62D2600", Offset = "0x62D1400", VA = "0x1862D2600")]
		public bool SetRingLayerColor(int OJIFKCMJFIG, Color BJLKCDOCMJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62D2750", Offset = "0x62D1550", VA = "0x1862D2750")]
		public bool SetRingLayerSize(int OJIFKCMJFIG, float MEDHPDICIDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62D24C0", Offset = "0x62D12C0", VA = "0x1862D24C0", Slot = "12")]
		protected override void EJNONGILLKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62D22F0", Offset = "0x62D10F0", VA = "0x1862D22F0", Slot = "13")]
		protected override void DIJKKNNGEBF(Material DDNJBDIAIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62D2470", Offset = "0x62D1270", VA = "0x1862D2470", Slot = "14")]
		protected override void DNPPAPEMCFC(Material DDNJBDIAIEB, bool HNEIOJHCMIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62D2990", Offset = "0x62D1790", VA = "0x1862D2990")]
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
		public enum IKNDLNNGOJI
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int ICHFADKANIF;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int PNNKCGKFGCP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int AMKOIDOHDEA;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int LAGEBGFCIDD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int JDEEMODKAMA;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int DBOONAMHDNF;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int EGPHJDKCHOA;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int HAKHCKHNOCG;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int MANGOMIILMB;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int KAIPGPIAADE;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int IBLCCBGGLLF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int FMIKADFJCNE;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int DJKMKHILJMM;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int JBHHIIBKGEI;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int FLMGHEIIPMF;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int EOKNJFALDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[IJAALANNOJP(PPPBLHJADIM.Self, false, false, false)]
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
		private IKNDLNNGOJI animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[ELGPBFENPIK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[ELGPBFENPIK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic GJNCOMFAJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool BLEDANOAELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite BAKFODOBAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x62D3A70", Offset = "0x62D2870", VA = "0x1862D3A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x62D3C90", Offset = "0x62D2A90", VA = "0x1862D3C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color KCCPJOLIAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x89C9C0", Offset = "0x89B7C0", VA = "0x18089C9C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x62D3D20", Offset = "0x62D2B20", VA = "0x1862D3D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color NCBMKONLMPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x19E84B0", Offset = "0x19E72B0", VA = "0x1819E84B0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x62D3B60", Offset = "0x62D2960", VA = "0x1862D3B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float AAMCDAFMEHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x924F80", Offset = "0x923D80", VA = "0x180924F80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x62D3C20", Offset = "0x62D2A20", VA = "0x1862D3C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 DMDPGCMDAOK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x19D9C00", Offset = "0x19D8A00", VA = "0x1819D9C00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x62D3C40", Offset = "0x62D2A40", VA = "0x1862D3C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float FLEHAKPGOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x77D300", Offset = "0x77C100", VA = "0x18077D300")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x62D3BE0", Offset = "0x62D29E0", VA = "0x1862D3BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 MAPKMPCJNLP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x99CC60", Offset = "0x99BA60", VA = "0x18099CC60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x62D3DA0", Offset = "0x62D2BA0", VA = "0x1862D3DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float HNOGHKLCELE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9A4BC0", Offset = "0x9A39C0", VA = "0x1809A4BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x62D3B30", Offset = "0x62D2930", VA = "0x1862D3B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 BAAHKLAJEAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x62D3670", Offset = "0x62D2470", VA = "0x1862D3670")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IKNDLNNGOJI LBNIAMEDEJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x955D20", Offset = "0x954B20", VA = "0x180955D20")]
			get
			{
				return default(IKNDLNNGOJI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x62D3B50", Offset = "0x62D2950", VA = "0x1862D3B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float ENLGPMCGHMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA93C30", Offset = "0xA92A30", VA = "0x180A93C30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x62D3C00", Offset = "0x62D2A00", VA = "0x1862D3C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float OPKMOAOCNMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA93D80", Offset = "0xA92B80", VA = "0x180A93D80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x62D3B10", Offset = "0x62D2910", VA = "0x1862D3B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62D2F20", Offset = "0x62D1D20", VA = "0x1862D2F20", Slot = "13")]
		protected override void DIJKKNNGEBF(Material DDNJBDIAIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62D2C70", Offset = "0x62D1A70", VA = "0x1862D2C70")]
		private void BPACJFOBJAA(Sprite NLMBAPNPDBD, [Out] Vector2 EBNNEAIOEAD, [Out] Vector2 FCPEOMDLCGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62D3620", Offset = "0x62D2420", VA = "0x1862D3620", Slot = "14")]
		protected override void DNPPAPEMCFC(Material DDNJBDIAIEB, bool HNEIOJHCMIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62D39E0", Offset = "0x62D27E0", VA = "0x1862D39E0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader HNHIIGMABDJ;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader OCLJBFOAELF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x62D3E40", Offset = "0x62D2C40", VA = "0x1862D3E40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62D3DF0", Offset = "0x62D2BF0", VA = "0x1862D3DF0")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DOGIADMOAEG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct JJOOLOANLLP : IEquatable<JJOOLOANLLP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component GMNCNEPJHHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action JDDPKGAAJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int OPJHILKNJBG;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component JFJFFBOHGCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x62CDF30", Offset = "0x62CCD30", VA = "0x1862CDF30")]
		public JJOOLOANLLP(Component GMNCNEPJHHN, Action JDDPKGAAJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x62CDEB0", Offset = "0x62CCCB0", VA = "0x1862CDEB0")]
		public void FEFPMOEDJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x62CDEA0", Offset = "0x62CCCA0", VA = "0x1862CDEA0", Slot = "4")]
		public bool Equals(JJOOLOANLLP MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x62CDE10", Offset = "0x62CCC10", VA = "0x1862CDE10", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75FF80", VA = "0x180761180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KCHFHEJAIOF : IEnumerator<CCMEGKBIKJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private CCMEGKBIKJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DOGIADMOAEG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private CCMEGKBIKJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public KCHFHEJAIOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x62CDFA0", Offset = "0x62CCDA0", VA = "0x1862CDFA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62CE360", Offset = "0x62CD160", VA = "0x1862CE360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly MIJAHBFLJPH LIPJGLJHEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int KKBBACANAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int LBOLFMFICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> JMPJFLCCOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, JJOOLOANLLP> HPONHDPAADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<JJOOLOANLLP> FGGMIAEIGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<JJOOLOANLLP> GLMFGMJADCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private FFHNDEGIGAM FNFPHGIHPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private KJMCMCNBAMJ NGHDIAKKNHI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private KJMCMCNBAMJ NLCBGCPFPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62CC3C0", Offset = "0x62CB1C0", VA = "0x1862CC3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x62CC430", Offset = "0x62CB230", VA = "0x1862CC430")]
	public DOGIADMOAEG(MIJAHBFLJPH LIPJGLJHEFE, int KKBBACANAPE = -1, int LBOLFMFICOD = -1, [Optional] Func<Component, float> JMPJFLCCOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62CC160", Offset = "0x62CAF60", VA = "0x1862CC160")]
	public void HALPLGEILHP(Component GMNCNEPJHHN, Action ALJMPBCMDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x62CBCB0", Offset = "0x62CAAB0", VA = "0x1862CBCB0")]
	public void FCLBKEKDJBI(Component GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62CBEC0", Offset = "0x62CACC0", VA = "0x1862CBEC0")]
	public bool FJKFKAAHKDN(Component PMEJDDFHMDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x62CBF20", Offset = "0x62CAD20", VA = "0x1862CBF20")]
	private void GBKCFEGCEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x62CBC30", Offset = "0x62CAA30", VA = "0x1862CBC30")]
	[IteratorStateMachine(typeof(KCHFHEJAIOF))]
	private IEnumerator<CCMEGKBIKJP> ADNAAINDAFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7FBA20", Offset = "0x7FA820", VA = "0x1807FBA20")]
	[CompilerGenerated]
	private void GODNANJOILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x62CBE40", Offset = "0x62CAC40", VA = "0x1862CBE40")]
	[CompilerGenerated]
	private float FDKKHAHDODG(JJOOLOANLLP ALJMPBCMDJC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CJIAAHNHBAM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	DDCNEEFIPGG CANOMKBBMFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool MDLNNHHODJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HEBNGJMIMPC<DDCNEEFIPGG> GDGABENDGML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PIBJPHIIIFP(DDCNEEFIPGG KJNLGOJCKLD, bool ABPMKFOFENF = false);
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
