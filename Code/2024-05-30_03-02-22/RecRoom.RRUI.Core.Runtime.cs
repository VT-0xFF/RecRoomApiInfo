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
				[Cpp2IlInjected.Address(RVA = "0x6C13110", Offset = "0x6C12310", VA = "0x186C13110")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6C13170", Offset = "0x6C12370", VA = "0x186C13170")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6C130C0", Offset = "0x6C122C0", VA = "0x186C130C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6C12EE0", Offset = "0x6C120E0", VA = "0x186C12EE0")]
			public void DJKMDIDGBPM(PointerEventData AIGFIPIMAAF, RectTransform DLHNPPFGMJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6C12C50", Offset = "0x6C11E50", VA = "0x186C12C50")]
			public void BPJCEHCDLGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6C12FE0", Offset = "0x6C121E0", VA = "0x186C12FE0")]
			public void PENPHNIIKHD(PointerEventData AIGFIPIMAAF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6C12C00", Offset = "0x6C11E00", VA = "0x186C12C00")]
			public void AJAJHKANLCE(float CLNMBPCDIGI, RectTransform DLHNPPFGMJK, Vector3 HNNAMHMDPNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly HKGPCDCMJHO<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly HKGPCDCMJHO<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly HKGPCDCMJHO<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly HKGPCDCMJHO<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly HKGPCDCMJHO<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly OJHEJHCKNBB PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData GJEFJHIGIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool MEOAAICLOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool KIDMMBNHNLB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MPFNKOHNIOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7CE860", Offset = "0x7CDA60", VA = "0x1807CE860")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6C12390", Offset = "0x6C11590", VA = "0x186C12390")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CFBFHPNMCLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7CE980", Offset = "0x7CDB80", VA = "0x1807CE980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6C12440", Offset = "0x6C11640", VA = "0x186C12440")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C123C0", Offset = "0x6C115C0", VA = "0x186C123C0")]
		private bool EFEPAKAMLNC(PointerEventData IECLDFDHFNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C128C0", Offset = "0x6C11AC0", VA = "0x186C128C0", Slot = "5")]
		public void OnPointerDown(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C12980", Offset = "0x6C11B80", VA = "0x186C12980", Slot = "11")]
		public void OnPointerUp(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C12730", Offset = "0x6C11930", VA = "0x186C12730", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C12470", Offset = "0x6C11670", VA = "0x186C12470", Slot = "7")]
		public void OnBeginDrag(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C12580", Offset = "0x6C11780", VA = "0x186C12580", Slot = "4")]
		public void OnDrag(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C12660", Offset = "0x6C11860", VA = "0x186C12660", Slot = "8")]
		public void OnEndDrag(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C12920", Offset = "0x6C11B20", VA = "0x186C12920", Slot = "9")]
		public void OnPointerEnter(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C12950", Offset = "0x6C11B50", VA = "0x186C12950", Slot = "10")]
		public void OnPointerExit(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C12540", Offset = "0x6C11740", VA = "0x186C12540")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C129E0", Offset = "0x6C11BE0", VA = "0x186C129E0")]
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
		private OptionData MBNKNFAHLGI;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E960", Offset = "0x6C0DB60", VA = "0x186C0E960", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E860", Offset = "0x6C0DA60", VA = "0x186C0E860", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E7B0", Offset = "0x6C0D9B0", VA = "0x186C0E7B0")]
		private void FALIIOGKDEK(GameObject DPPLJDMBCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EC20", Offset = "0x6C0DE20", VA = "0x186C0EC20")]
		public void SetOptionsWithNoDefault(List<string> IJMHBFBFIEM, [Optional] string ICKPIPOAPFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EB30", Offset = "0x6C0DD30", VA = "0x186C0EB30")]
		public void SetOptionsWithNoDefault(List<OptionData> PPBCABJPHLO, [Optional] string ICKPIPOAPFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EA60", Offset = "0x6C0DC60", VA = "0x186C0EA60", Slot = "42")]
		public override void OnPointerClick(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas BCILKEGKMKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EE50", Offset = "0x6C0E050", VA = "0x186C0EE50")]
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
		private sealed class IPPGNHAHBFP : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private AEBIBAEBDOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
			[DebuggerHidden]
			public IPPGNHAHBFP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6C10120", Offset = "0x6C0F320", VA = "0x186C10120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6C10630", Offset = "0x6C0F830", VA = "0x186C10630", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[MIIJAPCLEGN(LIEGAMPPNDC.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ABMNNNDAPKN<object> BNBPAIMLJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool JEEEJCBKLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? HKIJNMFMKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? DGGCHHOMNKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? NLBJNNMKNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool FOENBOFBOJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool BFIJOKABMCL;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JFPMALDAPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6C0FB40", Offset = "0x6C0ED40", VA = "0x186C0FB40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool EHMOACNBAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C0FAF0", Offset = "0x6C0ECF0", VA = "0x186C0FAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CDCPIJLMFEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x813F10", Offset = "0x813110", VA = "0x180813F10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6C0FD00", Offset = "0x6C0EF00", VA = "0x186C0FD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DNNHODLNGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6C0FA50", Offset = "0x6C0EC50", VA = "0x186C0FA50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6C0FC60", Offset = "0x6C0EE60", VA = "0x186C0FC60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F610", Offset = "0x6C0E810", VA = "0x186C0F610")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F830", Offset = "0x6C0EA30", VA = "0x186C0F830")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F7E0", Offset = "0x6C0E9E0", VA = "0x186C0F7E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F7D0", Offset = "0x6C0E9D0", VA = "0x186C0F7D0")]
		public void Hide(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F9B0", Offset = "0x6C0EBB0", VA = "0x186C0F9B0")]
		public void Show(object CEFPPEHCFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F8C0", Offset = "0x6C0EAC0", VA = "0x186C0F8C0")]
		public void Set(object CEFPPEHCFCF, bool ONPGOGHDJIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F6A0", Offset = "0x6C0E8A0", VA = "0x186C0F6A0")]
		public void Clear(bool ECNDPHPLIGF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F440", Offset = "0x6C0E640", VA = "0x186C0F440")]
		private void AINKKFLBLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F750", Offset = "0x6C0E950", VA = "0x186C0F750")]
		[IteratorStateMachine(typeof(IPPGNHAHBFP))]
		private IEnumerator<AEBIBAEBDOJ> GEGJLOPIFME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F710", Offset = "0x6C0E910", VA = "0x186C0F710", Slot = "5")]
		public virtual void DoHideOrShow(bool OFDAAOMLCAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F9C0", Offset = "0x6C0EBC0", VA = "0x186C0F9C0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NDHBBAMDJJA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x865B90", Offset = "0x864D90", VA = "0x180865B90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7CC960", Offset = "0x7CBB60", VA = "0x1807CC960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> OBOKGNIIGLB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6C0FE60", Offset = "0x6C0F060", VA = "0x186C0FE60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6C0FFC0", Offset = "0x6C0F1C0", VA = "0x186C0FFC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> INDHJKOGING
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6C0FF10", Offset = "0x6C0F110", VA = "0x186C0FF10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6C10070", Offset = "0x6C0F270", VA = "0x186C10070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6C0FE20", Offset = "0x6C0F020", VA = "0x186C0FE20", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6C0FE40", Offset = "0x6C0F040", VA = "0x186C0FE40", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData IECLDFDHFNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD50030", Offset = "0xD4F230", VA = "0x180D50030")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xD50030", Offset = "0xD4F230", VA = "0x180D50030")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DKHDCJHNBKC
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum NEFIPDJKNLE
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static JFGFBDBIPIN MIIOABBBJDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static JFGFBDBIPIN AKAHKJCAILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E5B0", Offset = "0x6C0D7B0", VA = "0x186C0E5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NEFIPDJKNLE CCBPGJANPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E680", Offset = "0x6C0D880", VA = "0x186C0E680")]
		get
		{
			return default(NEFIPDJKNLE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E450", Offset = "0x6C0D650", VA = "0x186C0E450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<NEFIPDJKNLE> BENOJAINJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E370", Offset = "0x6C0D570", VA = "0x186C0E370")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E290", Offset = "0x6C0D490", VA = "0x186C0E290")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IICFLKCBINI : JBOBHJINAJJ, GBBLFEBPEFF, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LKAEANPNDGO<GameObject, int> AFPCHEPPFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KDOKJMBKLDA<GameObject, int, bool> NEFIIJKPMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HKGPCDCMJHO<bool> IEAPGGKNKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool EPJHIGALHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float LAMLJMFFHME
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HKGPCDCMJHO<float> BGBFOLOKNBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OJHEJHCKNBB ODNLCJBHJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SpawnLoadingPlaceholders(GameObject PFEBHHJNIAE);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GJCJPABGAJD Spawn<T>(int IOAHLMABBAN, IReadOnlyList<T> JLJKEBMIIPF, GameObject PFEBHHJNIAE);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GJCJPABGAJD Spawn<T>(int IOAHLMABBAN, IReadOnlyList<T> JLJKEBMIIPF, GameObject CFNHOGKOKBL, Func<int, GameObject> HKPOJLOOAHF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int PMNHOLIPOMJ, float IHHKKMMEKIJ);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum CBGGJHJPFHE : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			LeftToRight = 0,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			RightToLeft = 1,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			TopToBottom = 2,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			BottomToTop = 3,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			CustomDirection = 4,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			RadialOut = 10,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			RadialIn = 11,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			VignetteOut = 20,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			VignetteIn = 21,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Disabled = byte.MaxValue
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int CDNGCOKHDNN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<CBGGJHJPFHE, string> DFNBAAJKMNF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int PEADKLLIGFC = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int AHKIGFBIFAD;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int FKJMAIHEGKA;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int FPBFDBIAECG;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int BNMHLAEPMKA;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int ANOJLKMPNPI;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int EEICDKCLAII;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int FNAOELANMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool HDAIMMGAKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool LIJJBHFGNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Color[] MKLJLDIFDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private CBGGJHJPFHE type;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly CBGGJHJPFHE[] OLCNLGNLBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[DIPOKMHEBPI("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly CBGGJHJPFHE[] PAPBCDGJCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[DIPOKMHEBPI("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[DIPOKMHEBPI("type", CBGGJHJPFHE.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Range(0f, 5f)]
		[DIPOKMHEBPI("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic FDLDBNFHCGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool AMJOFPKIJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient OLBOEHOLLJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7CEA70", Offset = "0x7CDC70", VA = "0x1807CEA70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6C121E0", Offset = "0x6C113E0", VA = "0x186C121E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public CBGGJHJPFHE GADMEDLKBAN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x864FC0", Offset = "0x8641C0", VA = "0x180864FC0")]
			get
			{
				return default(CBGGJHJPFHE);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6C12360", Offset = "0x6C11560", VA = "0x186C12360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool AHPKPGEHOIK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6C11900", Offset = "0x6C10B00", VA = "0x186C11900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 EPIBGOODDAB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6C12150", Offset = "0x6C11350", VA = "0x186C12150")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6C12190", Offset = "0x6C11390", VA = "0x186C12190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool MHAJMBJEKJO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6C10D70", Offset = "0x6C0FF70", VA = "0x186C10D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 JKDBLJBGINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6C12170", Offset = "0x6C11370", VA = "0x186C12170")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6C12310", Offset = "0x6C11510", VA = "0x186C12310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MMEILGADMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x834E70", Offset = "0x834070", VA = "0x180834E70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x14EC5B0", Offset = "0x14EB7B0", VA = "0x1814EC5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 NCHFDKJLKAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6C118B0", Offset = "0x6C10AB0", VA = "0x186C118B0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 IEJGPHOGMJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6C10DE0", Offset = "0x6C0FFE0", VA = "0x186C10DE0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float KIBNOFJIKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7E3B80", Offset = "0x7E2D80", VA = "0x1807E3B80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6C12370", Offset = "0x6C11570", VA = "0x186C12370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C11B00", Offset = "0x6C10D00", VA = "0x186C11B00", Slot = "12")]
		protected override void OGCGHKBHBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C11970", Offset = "0x6C10B70", VA = "0x186C11970")]
		private void NNAMDAGJPCC(Color[] CJHEFAHJJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C10E70", Offset = "0x6C10070", VA = "0x186C10E70", Slot = "13")]
		protected override void GGFNDDLOPGM(Material OOHAKCENEJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C10B50", Offset = "0x6C0FD50", VA = "0x186C10B50", Slot = "14")]
		protected override void BGEEPMNNHOA(Material OOHAKCENEJE, bool IJMGAKGNGDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C120A0", Offset = "0x6C112A0", VA = "0x186C120A0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly BGBIKCMIPCL ILOOFGABKLN;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Sprite BFLIFMKEJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material IECNPBNNGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Material CCGMDNGDKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool MAPPDPODEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool JEEEJCBKLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool DNDNIDOCAHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool OELNNFHCHOA;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic FDLDBNFHCGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader KCDPCEHAHDP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool AMJOFPKIJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool EEGKAEIJPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform DLHNPPFGMJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6C142F0", Offset = "0x6C134F0", VA = "0x186C142F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect OMGNPFLJFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6C141D0", Offset = "0x6C133D0", VA = "0x186C141D0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite BGOAHOJNHLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6C13BD0", Offset = "0x6C12DD0", VA = "0x186C13BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6C13360", Offset = "0x6C12560", VA = "0x186C13360", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C14350", Offset = "0x6C13550", VA = "0x186C14350", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6C14650", Offset = "0x6C13850", VA = "0x186C14650", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C14500", Offset = "0x6C13700", VA = "0x186C14500", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6C13DD0", Offset = "0x6C12FD0", VA = "0x186C13DD0")]
		private void IBFFEEADFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C13A30", Offset = "0x6C12C30", VA = "0x186C13A30")]
		private void GNMHKBKMLBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C13BA0", Offset = "0x6C12DA0", VA = "0x186C13BA0")]
		private void HALEAGFEJMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6C139E0", Offset = "0x6C12BE0", VA = "0x186C139E0")]
		private void FOPKMPBLEFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C13F60", Offset = "0x6C13160", VA = "0x186C13F60")]
		protected void IPBHGLGMJDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C13550", Offset = "0x6C12750", VA = "0x186C13550")]
		private void CLCINJCCIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "12")]
		protected virtual void OGCGHKBHBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "13")]
		protected virtual void GGFNDDLOPGM(Material OOHAKCENEJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "14")]
		protected virtual void BGEEPMNNHOA(Material OOHAKCENEJE, bool IJMGAKGNGDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C13690", Offset = "0x6C12890", VA = "0x186C13690")]
		private void EDBAOIPBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
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
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[SerializeField]
			[Range(0f, 2f)]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int MMCNGDHEFOL;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int DHGLMPEAFHL;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int HCPMHNIMGBO;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int MBLLMLMMDHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		[SerializeField]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Color[] MKLJLDIFDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private float[] HLGLGMACFPH;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic FDLDBNFHCGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool EEGKAEIJPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> OMADCMENLMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7CEA40", Offset = "0x7CDC40", VA = "0x1807CEA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 EPIBGOODDAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6C15120", Offset = "0x6C14320", VA = "0x186C15120")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x6C15140", Offset = "0x6C14340", VA = "0x186C15140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6C14D60", Offset = "0x6C13F60", VA = "0x186C14D60")]
		public void SetRingLayers(IReadOnlyList<RingLayer> AGFBDIMDHBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C14B20", Offset = "0x6C13D20", VA = "0x186C14B20")]
		public bool SetRingLayerColor(int HEJPMNEGHKB, Color LHAAJEOMGEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6C14C70", Offset = "0x6C13E70", VA = "0x186C14C70")]
		public bool SetRingLayerSize(int HEJPMNEGHKB, float AGHIAPEPFJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C149E0", Offset = "0x6C13BE0", VA = "0x186C149E0", Slot = "12")]
		protected override void OGCGHKBHBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C14860", Offset = "0x6C13A60", VA = "0x186C14860", Slot = "13")]
		protected override void GGFNDDLOPGM(Material OOHAKCENEJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6C14810", Offset = "0x6C13A10", VA = "0x186C14810", Slot = "14")]
		protected override void BGEEPMNNHOA(Material OOHAKCENEJE, bool IJMGAKGNGDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C14EB0", Offset = "0x6C140B0", VA = "0x186C14EB0")]
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
		public enum DOGHEONFKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int DPIHINMMDOA;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int DPOGLIDLGHK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int OOCOANMANAK;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int PHJJNHCNMOB;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int IKLNHDIELPJ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int DPOJFCABFCK;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int MGEMIHKGMAB;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int BKAHJEOEDHM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int CONDOHLHEHE;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int OGHNCNGMNKP;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int NODLNFCIHAG;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int NDGCICFJGFJ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int JGCEFGOHEFI;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int GJEPBLPFILE;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int BGEEEDNCNFK;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int GOLEJGHLDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("The offset applied to each alternating row or column.")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private DOGHEONFKGJ animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[Tooltip("The animation speed of the primary rows / columns.")]
		[DIPOKMHEBPI("AnimationDirection", new object[] { 1, 0 })]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[DIPOKMHEBPI("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic FDLDBNFHCGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool EEGKAEIJPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite OCIGOCNOKEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6C15FB0", Offset = "0x6C151B0", VA = "0x186C15FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6C161D0", Offset = "0x6C153D0", VA = "0x186C161D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color NILKCMEIGIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x83B470", Offset = "0x83A670", VA = "0x18083B470")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6C16260", Offset = "0x6C15460", VA = "0x186C16260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color EEHHJPBBHEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x84E940", Offset = "0x84DB40", VA = "0x18084E940")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6C160A0", Offset = "0x6C152A0", VA = "0x186C160A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float NFOBMPBCINA
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x834E90", Offset = "0x834090", VA = "0x180834E90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6C16160", Offset = "0x6C15360", VA = "0x186C16160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 DEMFDHCGMOP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6C15F90", Offset = "0x6C15190", VA = "0x186C15F90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6C16180", Offset = "0x6C15380", VA = "0x186C16180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float DJNLHOOGNFK
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7E37D0", Offset = "0x7E29D0", VA = "0x1807E37D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6C16120", Offset = "0x6C15320", VA = "0x186C16120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 JLLEEDLBBMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xBCD1F0", Offset = "0xBCC3F0", VA = "0x180BCD1F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6C162E0", Offset = "0x6C154E0", VA = "0x186C162E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float PIMODDGPGDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x84E830", Offset = "0x84DA30", VA = "0x18084E830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x6C16070", Offset = "0x6C15270", VA = "0x186C16070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 MFCMMJIMKOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6C15490", Offset = "0x6C14690", VA = "0x186C15490")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public DOGHEONFKGJ JDBFHEPBEEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xB7FD20", Offset = "0xB7EF20", VA = "0x180B7FD20")]
			get
			{
				return default(DOGHEONFKGJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6C16090", Offset = "0x6C15290", VA = "0x186C16090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float DPKGIGKIJDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCB9F90", Offset = "0xCB9190", VA = "0x180CB9F90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6C16140", Offset = "0x6C15340", VA = "0x186C16140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float HMOKCPMNNHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCBA0E0", Offset = "0xCB92E0", VA = "0x180CBA0E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6C16050", Offset = "0x6C15250", VA = "0x186C16050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C15520", Offset = "0x6C14720", VA = "0x186C15520", Slot = "13")]
		protected override void GGFNDDLOPGM(Material OOHAKCENEJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6C15190", Offset = "0x6C14390", VA = "0x186C15190")]
		private void ACCHLIDBEMI(Sprite ODKDIDDOPLC, [Out] Vector2 MJMLOIFNNPN, [Out] Vector2 HNJGOJKJBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C15440", Offset = "0x6C14640", VA = "0x186C15440", Slot = "14")]
		protected override void BGEEPMNNHOA(Material OOHAKCENEJE, bool IJMGAKGNGDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C15F00", Offset = "0x6C15100", VA = "0x186C15F00")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static Shader GJGPKNCNNDC;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader KCDPCEHAHDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6C16380", Offset = "0x6C15580", VA = "0x186C16380", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C16330", Offset = "0x6C15530", VA = "0x186C16330")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class RectTransformHideableAdapter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private SerializableRectTransform hiddenRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private SerializableRectTransform PIJHGEBNFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool CMOGCIDMCJE;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6C10750", Offset = "0x6C0F950", VA = "0x186C10750")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6C10960", Offset = "0x6C0FB60", VA = "0x186C10960")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6C108E0", Offset = "0x6C0FAE0", VA = "0x186C108E0")]
		private void MKKNNBHLLKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C10680", Offset = "0x6C0F880", VA = "0x186C10680")]
		private void AINKKFLBLGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BGBIKCMIPCL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct EGDGKMEPAJM : IEquatable<EGDGKMEPAJM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Component EOIJJPCMNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Action FHPFCPNONBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly int NJLBHCPBBDF;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component LHGEDCJBIII
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F3D0", Offset = "0x6C0E5D0", VA = "0x186C0F3D0")]
		public EGDGKMEPAJM(Component EOIJJPCMNGA, Action FHPFCPNONBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F2B0", Offset = "0x6C0E4B0", VA = "0x186C0F2B0")]
		public void DMDKHAOOBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F330", Offset = "0x6C0E530", VA = "0x186C0F330", Slot = "4")]
		public bool Equals(EGDGKMEPAJM JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F340", Offset = "0x6C0E540", VA = "0x186C0F340", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class EFFBMIALBHO : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public BGBIKCMIPCL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public EFFBMIALBHO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EEA0", Offset = "0x6C0E0A0", VA = "0x186C0EEA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F260", Offset = "0x6C0E460", VA = "0x186C0F260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly ADPKHEFCKGP BGOAJDAJJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int OHAOEEAJANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int PLJGBNJEJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Func<Component, float> GCHPJCHCFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<Component, EGDGKMEPAJM> OJMDFOLJJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly LinkedList<EGDGKMEPAJM> CEJACJOPEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly List<EGDGKMEPAJM> AJNKNFEMOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private MGBJAGNHOEE HLEEIIIAPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private DMJCADGACAC CAILBODPKAB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private DMJCADGACAC NLBCCFMHGNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E0A0", Offset = "0x6C0D2A0", VA = "0x186C0E0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E110", Offset = "0x6C0D310", VA = "0x186C0E110")]
	public BGBIKCMIPCL(ADPKHEFCKGP BGOAJDAJJJJ, int OHAOEEAJANH = -1, int PLJGBNJEJJN = -1, [Optional] Func<Component, float> GCHPJCHCFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DD40", Offset = "0x6C0CF40", VA = "0x186C0DD40")]
	public void OPHMKCAFLFK(Component EOIJJPCMNGA, Action FDBBAOGMKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D980", Offset = "0x6C0CB80", VA = "0x186C0D980")]
	public void ICHNAHOBGFE(Component EOIJJPCMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D920", Offset = "0x6C0CB20", VA = "0x186C0D920")]
	public bool DFMAMGJHPFC(Component NPBKACHANBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DB10", Offset = "0x6C0CD10", VA = "0x186C0DB10")]
	private void MKBCMLAOHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DFA0", Offset = "0x6C0D1A0", VA = "0x186C0DFA0")]
	[IteratorStateMachine(typeof(EFFBMIALBHO))]
	private IEnumerator<AEBIBAEBDOJ> PGMGIAOEDHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA04550", Offset = "0xA03750", VA = "0x180A04550")]
	[CompilerGenerated]
	private void PIDBBIOBGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E020", Offset = "0x6C0D220", VA = "0x186C0E020")]
	[CompilerGenerated]
	private float PJNNPCINIAC(EGDGKMEPAJM FDBBAOGMKLC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JDALELDKDNI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	BJBBLFAIMDA JPDBPPIJFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool IFKDKGKGAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	HKGPCDCMJHO<BJBBLFAIMDA> GMCEDPKLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMKJNEOGHAE(BJBBLFAIMDA PNIGLGBMIIO, bool FMBCIDCHEAM = false);
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
