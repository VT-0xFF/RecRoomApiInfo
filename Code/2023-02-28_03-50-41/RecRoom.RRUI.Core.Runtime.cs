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
				[Cpp2IlInjected.Address(RVA = "0x638C720", Offset = "0x638B120", VA = "0x18638C720")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x638C780", Offset = "0x638B180", VA = "0x18638C780")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x638C6A0", Offset = "0x638B0A0", VA = "0x18638C6A0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x638C230", Offset = "0x638AC30", VA = "0x18638C230")]
			public void GIHGKKKABGA(PointerEventData KDANHEPAJDD, RectTransform CEGJPKCBBCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x638C440", Offset = "0x638AE40", VA = "0x18638C440")]
			public void JKIOBKGKOGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x638C560", Offset = "0x638AF60", VA = "0x18638C560")]
			public void PGKLAICELAN(PointerEventData KDANHEPAJDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x638C650", Offset = "0x638B050", VA = "0x18638C650")]
			public void PNHGHJAFINB(float EJMLCIOKNCP, RectTransform CEGJPKCBBCB, Vector3 GBGEGEKJOFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[KJPINCGBMNI(BPOBPCLEAHD.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly global::CHNCEGIAGIM<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly global::CHNCEGIAGIM<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::CHNCEGIAGIM<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly JCAAIAKPOCC PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly UIHandleEventData JPHBJBCKEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool KBJCHPHGBLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool KKNDJOHCODG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MKPGCANOBBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x1068E10", Offset = "0x1067810", VA = "0x181068E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x638BA90", Offset = "0x638A490", VA = "0x18638BA90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool EGKLHKHOJDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x111B340", Offset = "0x1119D40", VA = "0x18111B340")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x638BAC0", Offset = "0x638A4C0", VA = "0x18638BAC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x638BA10", Offset = "0x638A410", VA = "0x18638BA10")]
		private bool ECEEONALAIA(PointerEventData PHDLBHDMOFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		public void OnPointerDown(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x638BDE0", Offset = "0x638A7E0", VA = "0x18638BDE0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x638BAF0", Offset = "0x638A4F0", VA = "0x18638BAF0", Slot = "7")]
		public void OnBeginDrag(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x638BC10", Offset = "0x638A610", VA = "0x18638BC10", Slot = "4")]
		public void OnDrag(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x638BD00", Offset = "0x638A700", VA = "0x18638BD00", Slot = "8")]
		public void OnEndDrag(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x638C070", Offset = "0x638AA70", VA = "0x18638C070", Slot = "9")]
		public void OnPointerEnter(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x638C0A0", Offset = "0x638AAA0", VA = "0x18638C0A0", Slot = "10")]
		public void OnPointerExit(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x638BBD0", Offset = "0x638A5D0", VA = "0x18638BBD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x638C0D0", Offset = "0x638AAD0", VA = "0x18638C0D0")]
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
		private OptionData DCGAICJNPAL;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6387860", Offset = "0x6386260", VA = "0x186387860", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6387750", Offset = "0x6386150", VA = "0x186387750", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6387690", Offset = "0x6386090", VA = "0x186387690")]
		private void KCFFDBNFHAF(GameObject PBFLAMAAMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6387A40", Offset = "0x6386440", VA = "0x186387A40")]
		public void SetOptionsWithNoDefault(List<string> ONNHMDKNLHH, [Optional] string EDCPPPDJNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6387C80", Offset = "0x6386680", VA = "0x186387C80")]
		public void SetOptionsWithNoDefault(List<OptionData> KNNPANGLJLF, [Optional] string EDCPPPDJNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6387970", Offset = "0x6386370", VA = "0x186387970", Slot = "42")]
		public override void OnPointerClick(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas MEFOGCBHLAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6387D70", Offset = "0x6386770", VA = "0x186387D70")]
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
		private sealed class HCPNBKBGKNF : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private MJOGGKCIPED <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public HCPNBKBGKNF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6388760", Offset = "0x6387160", VA = "0x186388760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6388C80", Offset = "0x6387680", VA = "0x186388C80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[KJPINCGBMNI(BPOBPCLEAHD.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[NKNFGAPPAGL(BPOBPCLEAHD.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly AJDDIJFCKOM JGGDDOGNEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool LJHCAMLGNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Vector3? BADEJEPBNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool? NCMHMANEMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? LOHOHBMLLIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool JFIIBGANMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool JCMMNIHLGDC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BKPMHKBCCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6389340", Offset = "0x6387D40", VA = "0x186389340", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool PNLMHPIDAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6389320", Offset = "0x6387D20", VA = "0x186389320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BHFOEPBJPAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99B510", Offset = "0x999F10", VA = "0x18099B510")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6389510", Offset = "0x6387F10", VA = "0x186389510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CPBHBFOLLHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6389280", Offset = "0x6387C80", VA = "0x186389280")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6389470", Offset = "0x6387E70", VA = "0x186389470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6388CC0", Offset = "0x63876C0", VA = "0x186388CC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6389050", Offset = "0x6387A50", VA = "0x186389050")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6388DA0", Offset = "0x63877A0", VA = "0x186388DA0")]
		public void Hide(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6389190", Offset = "0x6387B90", VA = "0x186389190")]
		public void Show(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x63890F0", Offset = "0x6387AF0", VA = "0x1863890F0")]
		public void Set(object DEGCIHEAIBD, bool BBLDLKLEFEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6388E90", Offset = "0x6387890", VA = "0x186388E90")]
		private void NPGHMBMFFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6388E20", Offset = "0x6387820", VA = "0x186388E20")]
		[IteratorStateMachine(typeof(HCPNBKBGKNF))]
		private IEnumerator<MJOGGKCIPED> MDHPFIHPDJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6388D60", Offset = "0x6387760", VA = "0x186388D60", Slot = "5")]
		public virtual void DoHideOrShow(bool JCNMMLBKKPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6389210", Offset = "0x6387C10", VA = "0x186389210")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NJFEOIKJDID
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8D0", Offset = "0x6DA2D0", VA = "0x1806DB8D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6FD000", Offset = "0x6FBA00", VA = "0x1806FD000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> MODBMIFDIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6389700", Offset = "0x6388100", VA = "0x186389700")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6389840", Offset = "0x6388240", VA = "0x186389840")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> HNAPKNIJGBP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x63897A0", Offset = "0x63881A0", VA = "0x1863897A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63898E0", Offset = "0x63882E0", VA = "0x1863898E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6389640", Offset = "0x6388040", VA = "0x186389640", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63896A0", Offset = "0x63880A0", VA = "0x1863896A0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData PHDLBHDMOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x21A9490", Offset = "0x21A7E90", VA = "0x1821A9490")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21A9490", Offset = "0x21A7E90", VA = "0x1821A9490")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AGBCOCJLKCN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum AOLNDKNJLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const AOLNDKNJLNJ ADGFMDOIDEN = AOLNDKNJLNJ.Light;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string LCHDCHPGFKJ = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static DOAIHBCLGLJ NJENCKLKPBF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static DOAIHBCLGLJ AEDIOINMMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6387100", Offset = "0x6385B00", VA = "0x186387100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static AOLNDKNJLNJ ADIGKDFJBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6387240", Offset = "0x6385C40", VA = "0x186387240")]
		get
		{
			return default(AOLNDKNJLNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63873E0", Offset = "0x6385DE0", VA = "0x1863873E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<AOLNDKNJLNJ> KAMKCLJPIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6387000", Offset = "0x6385A00", VA = "0x186387000")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6387590", Offset = "0x6385F90", VA = "0x186387590")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IOFEANKJGHJ : JLBLOCANICI, ANPHJGDNNOA, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	global::OMHDGNNJAPI<GameObject, int> KELBBEIKOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	global::BIKJMNNNOIL<GameObject, int, bool> KMFPDNHLMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	global::CHNCEGIAGIM<bool> GKJAILPLBCE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool PMAIELKLCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float PONCNMNONPD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	global::CHNCEGIAGIM<float> COIJMBAKNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JCAAIAKPOCC IBJDPKLBFLH
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
	void SpawnLoadingPlaceholders(GameObject JFEEEILBEOO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NPKEGPKMBCL Spawn<T>(int IAAHMDBEEOA, IReadOnlyList<T> NIPBPKPBPPP, GameObject JFEEEILBEOO);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NPKEGPKMBCL Spawn<T>(int IAAHMDBEEOA, IReadOnlyList<T> NIPBPKPBPPP, GameObject GKJOMHABIJH, ref Func<int, GameObject> HFKHMBHDGOP);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum DDJKMBAOHOL : byte
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
		private static readonly int PDIEGGMEGMP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<DDJKMBAOHOL, string> EBIANHIDANN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int NJOMIFABEMP = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int JKLMODMDEDG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int LABOFJGPNEN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int CEACJIBMAKM;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int KIBAKMEMNFP;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int AKHPFJNBMPI;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int KHPDLJLJHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[KJPINCGBMNI(BPOBPCLEAHD.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool FGGJBJGHAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool HIPEIPNBOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] IDBCAGIJFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private DDJKMBAOHOL type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly DDJKMBAOHOL[] IHJJLHNNBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[PKBFELCOBFJ("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly DDJKMBAOHOL[] ANLEFMFOFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[PKBFELCOBFJ("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[Range(0f, 360f)]
		[PKBFELCOBFJ("type", (byte)4)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[PKBFELCOBFJ("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic KBGOLHCCOPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool BNNNJGKFLAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient OOJOCIANOCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6C10D0", Offset = "0x6BFAD0", VA = "0x1806C10D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x638B860", Offset = "0x638A260", VA = "0x18638B860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DDJKMBAOHOL LMEMDFLMCLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1068E10", Offset = "0x1067810", VA = "0x181068E10")]
			get
			{
				return default(DDJKMBAOHOL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x638B9E0", Offset = "0x638A3E0", VA = "0x18638B9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool EBKONHOCCIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x638A560", Offset = "0x6388F60", VA = "0x18638A560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 AEJCFIHENMD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x638B7F0", Offset = "0x638A1F0", VA = "0x18638B7F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x638B810", Offset = "0x638A210", VA = "0x18638B810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool FJIOKCKJINI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x638A750", Offset = "0x6389150", VA = "0x18638A750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 BIGHCNHKHOC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x184D030", Offset = "0x184BA30", VA = "0x18184D030")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x638B990", Offset = "0x638A390", VA = "0x18638B990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float HICNEKIDIFD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x11DE640", Offset = "0x11DD040", VA = "0x1811DE640")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x15858F0", Offset = "0x15842F0", VA = "0x1815858F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 PODKCNGLIGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x638AA80", Offset = "0x6389480", VA = "0x18638AA80")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 KIKFGICBBMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x638A7D0", Offset = "0x63891D0", VA = "0x18638A7D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PKECIPJIEJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x11DE650", Offset = "0x11DD050", VA = "0x1811DE650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x638B9F0", Offset = "0x638A3F0", VA = "0x18638B9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x638AAD0", Offset = "0x63894D0", VA = "0x18638AAD0", Slot = "12")]
		protected override void JKJDJFEGHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x638A5E0", Offset = "0x6388FE0", VA = "0x18638A5E0")]
		private void CNLIDKLOMPK(Color[] FDJHABOAMJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x638AC50", Offset = "0x6389650", VA = "0x18638AC50", Slot = "13")]
		protected override void NCPKEHAEPKC(Material JLAFBAMDDLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x638A860", Offset = "0x6389260", VA = "0x18638A860", Slot = "14")]
		protected override void GBPGCPKAIFE(Material JLAFBAMDDLI, bool JECBMIHPMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x638B730", Offset = "0x638A130", VA = "0x18638B730")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly FEEDOALFDJG ALNAICOJLKE;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite ENDDNBGHAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material DGDHACJJNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material BKEJAJFLJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool JCAPKEOGFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool LJHCAMLGNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool EGMCPLBLPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool EJEMEMJGKND;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic KBGOLHCCOPF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader DFHBPKCIAEM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool BNNNJGKFLAH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool GCMEEDDHGCN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform CEGJPKCBBCB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x638D030", Offset = "0x638BA30", VA = "0x18638D030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect LGANJGKIJHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x638D0C0", Offset = "0x638BAC0", VA = "0x18638D0C0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite ODGEIKOMCED
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x638CE60", Offset = "0x638B860", VA = "0x18638CE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x638C830", Offset = "0x638B230", VA = "0x18638C830", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x638D820", Offset = "0x638C220", VA = "0x18638D820", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x638DB40", Offset = "0x638C540", VA = "0x18638DB40", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x638D9D0", Offset = "0x638C3D0", VA = "0x18638D9D0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x638CA20", Offset = "0x638B420", VA = "0x18638CA20")]
		private void BNJKMACAOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x638D580", Offset = "0x638BF80", VA = "0x18638D580")]
		private void MPEHJBKLDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x638D090", Offset = "0x638BA90", VA = "0x18638D090")]
		private void HDLKNMCJOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x638CE10", Offset = "0x638B810", VA = "0x18638CE10")]
		private void DMLBFHGCNPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x638CBA0", Offset = "0x638B5A0", VA = "0x18638CBA0")]
		protected void CDGENLJBLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x638D6E0", Offset = "0x638C0E0", VA = "0x18638D6E0")]
		private void ONFJDFEFFAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "12")]
		protected virtual void JKJDJFEGHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "13")]
		protected virtual void NCPKEHAEPKC(Material JLAFBAMDDLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "14")]
		protected virtual void GBPGCPKAIFE(Material JLAFBAMDDLI, bool JECBMIHPMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x638D1F0", Offset = "0x638BBF0", VA = "0x18638D1F0")]
		private void MNBPOCABAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		[Conditional("RRUI_PROFILING")]
		protected void DCLIFJMPFAH(string JBGIOGBCJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		[Conditional("RRUI_PROFILING")]
		protected void MIKCJIICKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x213580", Offset = "0x212980")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly int AMHBPAFKKHP;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int KMIEJGLNOPH;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int NGDHKNDKJHH;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int NJNJMBAMIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[KJPINCGBMNI(BPOBPCLEAHD.Self, false, false, false)]
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
		private Color[] IDBCAGIJFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] GBONNPALEOM;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic KBGOLHCCOPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool GCMEEDDHGCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> EGBMNMKJJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 AEJCFIHENMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x17D5290", Offset = "0x17D3C90", VA = "0x1817D5290")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x638E520", Offset = "0x638CF20", VA = "0x18638E520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x638E220", Offset = "0x638CC20", VA = "0x18638E220")]
		public void SetRingLayers(IReadOnlyList<RingLayer> NBBKBIOIFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x638E000", Offset = "0x638CA00", VA = "0x18638E000")]
		public bool SetRingLayerColor(int ICKIKFECOGI, Color HAAENNGJIPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x638E110", Offset = "0x638CB10", VA = "0x18638E110")]
		public bool SetRingLayerSize(int ICKIKFECOGI, float HGBOOPNCHBL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x638DD10", Offset = "0x638C710", VA = "0x18638DD10", Slot = "12")]
		protected override void JKJDJFEGHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x638DE80", Offset = "0x638C880", VA = "0x18638DE80", Slot = "13")]
		protected override void NCPKEHAEPKC(Material JLAFBAMDDLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x638DCC0", Offset = "0x638C6C0", VA = "0x18638DCC0", Slot = "14")]
		protected override void GBPGCPKAIFE(Material JLAFBAMDDLI, bool JECBMIHPMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x638E370", Offset = "0x638CD70", VA = "0x18638E370")]
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
		public enum EKKMHCEIIHF
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int NFGMJBCOLGP;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int EPPBLFKDEPB;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int NMAJIMCOGML;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int MFLMCCBGCFM;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int CGFACGHLPMM;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int KOFGJHDAHMB;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int OLLMLLANADF;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int IAKMDFGFEOE;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int DPNBEJAJNNM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int INOEAKFCPEN;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int IGBMDPEDHMB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int IPIGKJFCBLJ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int AHGHCMLGGAF;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int KPINADMLHCE;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int LCCFGCJGIDB;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int OKCPJPJFEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[KJPINCGBMNI(BPOBPCLEAHD.Self, false, false, false)]
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
		private EKKMHCEIIHF animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[PKBFELCOBFJ("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[PKBFELCOBFJ("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic KBGOLHCCOPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool GCMEEDDHGCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite AGFFKOLAJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x638F2F0", Offset = "0x638DCF0", VA = "0x18638F2F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x638F500", Offset = "0x638DF00", VA = "0x18638F500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color KDOKMFLHFLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x133F010", Offset = "0x133DA10", VA = "0x18133F010")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x638F5A0", Offset = "0x638DFA0", VA = "0x18638F5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color CLIIOJHPPBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA2BD60", Offset = "0xA2A760", VA = "0x180A2BD60")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x638F3F0", Offset = "0x638DDF0", VA = "0x18638F3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float HPMEPPCDKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x11DE840", Offset = "0x11DD240", VA = "0x1811DE840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x638F490", Offset = "0x638DE90", VA = "0x18638F490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 BANLOMFAJJB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1612240", Offset = "0x1610C40", VA = "0x181612240")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x638F4B0", Offset = "0x638DEB0", VA = "0x18638F4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float NLCNHBLGDIA
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x2577820", Offset = "0x2576220", VA = "0x182577820")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x638F450", Offset = "0x638DE50", VA = "0x18638F450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 DAOGCGCKKMH
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2883EE0", Offset = "0x28828E0", VA = "0x182883EE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x638F600", Offset = "0x638E000", VA = "0x18638F600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float GMKBPDGDJEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x184EB90", Offset = "0x184D590", VA = "0x18184EB90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x638F3C0", Offset = "0x638DDC0", VA = "0x18638F3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 LMBIKIHBEKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x638E7F0", Offset = "0x638D1F0", VA = "0x18638E7F0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public EKKMHCEIIHF CKKBBJODDIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8EA600", Offset = "0x8E9000", VA = "0x1808EA600")]
			get
			{
				return default(EKKMHCEIIHF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x638F3E0", Offset = "0x638DDE0", VA = "0x18638F3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float DEAOMIIBKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1379910", Offset = "0x1378310", VA = "0x181379910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x638F470", Offset = "0x638DE70", VA = "0x18638F470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float DAFBKHPPAAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1379920", Offset = "0x1378320", VA = "0x181379920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x638F3A0", Offset = "0x638DDA0", VA = "0x18638F3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x638E8B0", Offset = "0x638D2B0", VA = "0x18638E8B0", Slot = "13")]
		protected override void NCPKEHAEPKC(Material JLAFBAMDDLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x638E570", Offset = "0x638CF70", VA = "0x18638E570")]
		private void BLLJBHJIKAM(Sprite AGEMKKPJEAI, out Vector2 LLJJKNAJGOP, out Vector2 BCKDOMOGJNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x638E860", Offset = "0x638D260", VA = "0x18638E860", Slot = "14")]
		protected override void GBPGCPKAIFE(Material JLAFBAMDDLI, bool JECBMIHPMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x638F250", Offset = "0x638DC50", VA = "0x18638F250")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader KOFCOJJINOK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader DFHBPKCIAEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x638F6B0", Offset = "0x638E0B0", VA = "0x18638F6B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x638F650", Offset = "0x638E050", VA = "0x18638F650")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FEEDOALFDJG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct NINOLHFLBJG : IEquatable<NINOLHFLBJG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component CGFEOLDGFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action MEJNAPMBEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int IPCGKAPNFEA;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component OMALEDNDHGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x638A440", Offset = "0x6388E40", VA = "0x18638A440")]
		public NINOLHFLBJG(Component CGFEOLDGFLJ, Action MEJNAPMBEKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x638A3C0", Offset = "0x6388DC0", VA = "0x18638A3C0")]
		public void PBEMIBMPEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x638A320", Offset = "0x6388D20", VA = "0x18638A320", Slot = "4")]
		public bool Equals(NINOLHFLBJG DFHJPOKNFFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x638A330", Offset = "0x6388D30", VA = "0x18638A330", Slot = "0")]
		public override bool Equals(object LAFPICAOEAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class IGDPKPFAFJG : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public FEEDOALFDJG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public IGDPKPFAFJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6389980", Offset = "0x6388380", VA = "0x186389980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6389CB0", Offset = "0x63886B0", VA = "0x186389CB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int NFIMBKALHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int GOBFIKKGPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> AAIELHCCBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, NINOLHFLBJG> HOHPHMIBNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<NINOLHFLBJG> IKCMMJPBMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<NINOLHFLBJG> MLFBPFHDPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private KLOMPNKHCCP FNJPKBHGDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private GINOANOLNGJ MCJFIPGMCJM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GINOANOLNGJ NFKKNFDKHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6388100", Offset = "0x6386B00", VA = "0x186388100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6388600", Offset = "0x6387000", VA = "0x186388600")]
	public FEEDOALFDJG(BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, int NFIMBKALHHF = -1, int GOBFIKKGPDF = -1, [Optional] Func<Component, float> AAIELHCCBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6387E90", Offset = "0x6386890", VA = "0x186387E90")]
	public void HICDCODDKNE(Component CGFEOLDGFLJ, Action LDDMJCCAAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6388400", Offset = "0x6386E00", VA = "0x186388400")]
	public void NLCNCLJHKCJ(Component CGFEOLDGFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63883A0", Offset = "0x6386DA0", VA = "0x1863883A0")]
	public bool NFJOPPEBLFP(Component DCIOCIFFEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6388170", Offset = "0x6386B70", VA = "0x186388170")]
	private void MPHMJPJAELJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6388590", Offset = "0x6386F90", VA = "0x186388590")]
	[IteratorStateMachine(typeof(IGDPKPFAFJG))]
	private IEnumerator<MJOGGKCIPED> OKBHAOPAJOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x15F5A90", Offset = "0x15F4490", VA = "0x1815F5A90")]
	[CompilerGenerated]
	private void CNONAJNPGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6387DD0", Offset = "0x63867D0", VA = "0x186387DD0")]
	[CompilerGenerated]
	private float CCOLBAIBJBM(NINOLHFLBJG LDDMJCCAAEJ)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CBNNBKIABBO
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NHKENBOANAN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	MJBJGJPPBIP EGNAFPFFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool JDDABGILPME
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	global::CHNCEGIAGIM<MJBJGJPPBIP> AHELMHNFMLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNCLKCAGHHK(MJBJGJPPBIP KLCFOIIMHKF, bool FBDAIAAFLLN = false);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x638A040", Offset = "0x6388A40", VA = "0x18638A040")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6389CF0", Offset = "0x63886F0", VA = "0x186389CF0")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
