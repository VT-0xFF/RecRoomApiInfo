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
				[Cpp2IlInjected.Address(RVA = "0x62D0F60", Offset = "0x62CF760", VA = "0x1862D0F60")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x62D0FC0", Offset = "0x62CF7C0", VA = "0x1862D0FC0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x62D0F10", Offset = "0x62CF710", VA = "0x1862D0F10")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x62D0DC0", Offset = "0x62CF5C0", VA = "0x1862D0DC0")]
			public void MCCGEACALNC(PointerEventData LBGJOEEAKOK, RectTransform LDMBINLCOEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x62D0A50", Offset = "0x62CF250", VA = "0x1862D0A50")]
			public void DODAPJBFMCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x62D0CE0", Offset = "0x62CF4E0", VA = "0x1862D0CE0")]
			public void GCNEFPEEEOE(PointerEventData LBGJOEEAKOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x62D0EC0", Offset = "0x62CF6C0", VA = "0x1862D0EC0")]
			public void PIPOFNMKCDC(float BDJIALBPOPM, RectTransform LDMBINLCOEK, Vector3 ALAOAMBMFBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly MBOBMBMLJPH<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly MBOBMBMLJPH<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly MBOBMBMLJPH<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly MBOBMBMLJPH<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly MBOBMBMLJPH<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly BJPMGBAMGNN PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData EMGIPFLMKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool GEIIGAHIBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool HKLKCNJDPIO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PJICNHBMALA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x76F4F0", Offset = "0x76DCF0", VA = "0x18076F4F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x62D0800", Offset = "0x62CF000", VA = "0x1862D0800")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NIEIINFDGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x76F4A0", Offset = "0x76DCA0", VA = "0x18076F4A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x62D0260", Offset = "0x62CEA60", VA = "0x1862D0260")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62D01E0", Offset = "0x62CE9E0", VA = "0x1862D01E0")]
		private bool CBPJPMAIJDI(PointerEventData HOCFILEOKMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62D06E0", Offset = "0x62CEEE0", VA = "0x1862D06E0", Slot = "5")]
		public void OnPointerDown(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62D07A0", Offset = "0x62CEFA0", VA = "0x1862D07A0", Slot = "11")]
		public void OnPointerUp(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62D0550", Offset = "0x62CED50", VA = "0x1862D0550", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62D0290", Offset = "0x62CEA90", VA = "0x1862D0290", Slot = "7")]
		public void OnBeginDrag(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62D03A0", Offset = "0x62CEBA0", VA = "0x1862D03A0", Slot = "4")]
		public void OnDrag(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62D0480", Offset = "0x62CEC80", VA = "0x1862D0480", Slot = "8")]
		public void OnEndDrag(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62D0740", Offset = "0x62CEF40", VA = "0x1862D0740", Slot = "9")]
		public void OnPointerEnter(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62D0770", Offset = "0x62CEF70", VA = "0x1862D0770", Slot = "10")]
		public void OnPointerExit(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62D0360", Offset = "0x62CEB60", VA = "0x1862D0360")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62D0830", Offset = "0x62CF030", VA = "0x1862D0830")]
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
		private OptionData JGDHABIDIFI;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x62CC150", Offset = "0x62CA950", VA = "0x1862CC150", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x62CC050", Offset = "0x62CA850", VA = "0x1862CC050", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x62CBFA0", Offset = "0x62CA7A0", VA = "0x1862CBFA0")]
		private void JPPDJFHAPLH(GameObject HMCLAECNPDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62CC410", Offset = "0x62CAC10", VA = "0x1862CC410")]
		public void SetOptionsWithNoDefault(List<string> OLDAAMHBNMC, [Optional] string PLGDEODPLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62CC320", Offset = "0x62CAB20", VA = "0x1862CC320")]
		public void SetOptionsWithNoDefault(List<OptionData> KFCJCCKINNH, [Optional] string PLGDEODPLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62CC250", Offset = "0x62CAA50", VA = "0x1862CC250", Slot = "42")]
		public override void OnPointerClick(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas DJIMFMONHMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62CC640", Offset = "0x62CAE40", VA = "0x1862CC640")]
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
		private sealed class LEPPGHKEBGM : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private DENFKKKFFPI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
			[DebuggerHidden]
			public LEPPGHKEBGM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x62CE720", Offset = "0x62CCF20", VA = "0x1862CE720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x62CEC10", Offset = "0x62CD410", VA = "0x1862CEC10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[PDDJFAPJMON(LFNBNCHIJGL.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly BOKOFNDFGJO ICCFLNGMANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool EIKLEJINBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? FOBDOICJDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? OLNPJIEIMNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? OEBAMFKIOPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool KOGGPAJDCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool OBLEAFNHBOB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EPPHHOLKNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x62CD2B0", Offset = "0x62CBAB0", VA = "0x1862CD2B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IKJGKCPCLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x62CD290", Offset = "0x62CBA90", VA = "0x1862CD290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EGAHKDKALGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xC96580", Offset = "0xC94D80", VA = "0x180C96580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x62CD460", Offset = "0x62CBC60", VA = "0x1862CD460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OKNMHPGDKMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x62CD1F0", Offset = "0x62CB9F0", VA = "0x1862CD1F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x62CD3C0", Offset = "0x62CBBC0", VA = "0x1862CD3C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62CCC30", Offset = "0x62CB430", VA = "0x1862CCC30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62CCFC0", Offset = "0x62CB7C0", VA = "0x1862CCFC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62CCEC0", Offset = "0x62CB6C0", VA = "0x1862CCEC0")]
		public void Hide(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62CD0F0", Offset = "0x62CB8F0", VA = "0x1862CD0F0")]
		public void Show(object KIAKEGJPMAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62CD050", Offset = "0x62CB850", VA = "0x1862CD050")]
		public void Set(object KIAKEGJPMAL, bool ILBNDBFCMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62CCCC0", Offset = "0x62CB4C0", VA = "0x1862CCCC0")]
		private void BKFNACLDHJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62CCF40", Offset = "0x62CB740", VA = "0x1862CCF40")]
		[IteratorStateMachine(typeof(LEPPGHKEBGM))]
		private IEnumerator<DENFKKKFFPI> OJOKODHDFJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62CCE80", Offset = "0x62CB680", VA = "0x1862CCE80", Slot = "5")]
		public virtual void DoHideOrShow(bool LFDEBLNHEHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62CD170", Offset = "0x62CB970", VA = "0x1862CD170")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KDDODABKDHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7D07D0", Offset = "0x7CEFD0", VA = "0x1807D07D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x770F70", Offset = "0x76F770", VA = "0x180770F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> HFHPDFMBLML
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x62CD5C0", Offset = "0x62CBDC0", VA = "0x1862CD5C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x62CD720", Offset = "0x62CBF20", VA = "0x1862CD720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> FCPEBGBFCAN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x62CD670", Offset = "0x62CBE70", VA = "0x1862CD670")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x62CD7D0", Offset = "0x62CBFD0", VA = "0x1862CD7D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62CD580", Offset = "0x62CBD80", VA = "0x1862CD580", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x62CD5A0", Offset = "0x62CBDA0", VA = "0x1862CD5A0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData HOCFILEOKMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xB831C0", Offset = "0xB819C0", VA = "0x180B831C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB831C0", Offset = "0xB819C0", VA = "0x180B831C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ILMJBJIIGJG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum PDDLMCMGJGK
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static POMIFCOBDBE CPJLKANJIGC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static POMIFCOBDBE CIGIBIHHOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62CD9B0", Offset = "0x62CC1B0", VA = "0x1862CD9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static PDDLMCMGJGK BBNDGJCOOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62CD880", Offset = "0x62CC080", VA = "0x1862CD880")]
		get
		{
			return default(PDDLMCMGJGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62CDA80", Offset = "0x62CC280", VA = "0x1862CDA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<PDDLMCMGJGK> HODICFHKMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62CDBE0", Offset = "0x62CC3E0", VA = "0x1862CDBE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62CDCC0", Offset = "0x62CC4C0", VA = "0x1862CDCC0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KHJPBOOLFKE : FJHJKEANKFO, MGJPBNJJPDA, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JEAOGCMOGDE<GameObject, int> EHOFMALODPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MHLFPCNBIHM<GameObject, int, bool> GECDLHKODGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MBOBMBMLJPH<bool> KMOKCEHCEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OEAGBDDNMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float DACJDAIAOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MBOBMBMLJPH<float> FIPCJMMPLFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BJPMGBAMGNN CNCKOIOCOFC
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
	void SpawnLoadingPlaceholders(GameObject ABPIJCGDOPA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IFNBCJFCEDL Spawn<T>(int FADFIDNMCJL, IReadOnlyList<T> AELCABDCBDD, GameObject ABPIJCGDOPA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IFNBCJFCEDL Spawn<T>(int FADFIDNMCJL, IReadOnlyList<T> AELCABDCBDD, GameObject KGNEJKFNHNE, Func<int, GameObject> CCHILNDPMBK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int LFEFGCGCIAG, float CJPGGJMEHHJ);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum BBJPLCNNKNH : byte
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
		private static readonly int PMHPJHNHKDN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<BBJPLCNNKNH, string> IODMFOOCEAO;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int LHPIMHKKLJF = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int PENKGJLHPHC;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int HLLEBANNGPB;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int BDHCDBAACOC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int MPJDJHEGADH;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int KBNCOFIHCJI;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int FLAKMMHPFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool PPFOJOMBGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool AGKLLKJOEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] BLIIOFNPCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private BBJPLCNNKNH type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly BBJPLCNNKNH[] EKHCIBEBJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[IJNIOHAIOOA("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly BBJPLCNNKNH[] IAFDCBCDGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[IJNIOHAIOOA("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[IJNIOHAIOOA("type", BBJPLCNNKNH.CustomDirection)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[IJNIOHAIOOA("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic KLNPLMNHLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KPFGJNEDGJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient JNKJJEEHOCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x768D80", Offset = "0x767580", VA = "0x180768D80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x62D0030", Offset = "0x62CE830", VA = "0x1862D0030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BBJPLCNNKNH DAKFPFPAGLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA3DC70", Offset = "0xA3C470", VA = "0x180A3DC70")]
			get
			{
				return default(BBJPLCNNKNH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x62D01B0", Offset = "0x62CE9B0", VA = "0x1862D01B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool OBDNGGADMEL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x62CED40", Offset = "0x62CD540", VA = "0x1862CED40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 MMJNAKEJIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x62CFFA0", Offset = "0x62CE7A0", VA = "0x1862CFFA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x62CFFE0", Offset = "0x62CE7E0", VA = "0x1862CFFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool PFFBDPJMGJG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x62CEDB0", Offset = "0x62CD5B0", VA = "0x1862CEDB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 NBKHJBIAPOE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x62CFFC0", Offset = "0x62CE7C0", VA = "0x1862CFFC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x62D0160", Offset = "0x62CE960", VA = "0x1862D0160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ABENINGMNNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1210680", Offset = "0x120EE80", VA = "0x181210680")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x121C810", Offset = "0x121B010", VA = "0x18121C810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 KNEANOKCJAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x62CFA90", Offset = "0x62CE290", VA = "0x1862CFA90")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 DCLMGBIEAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x62CFA00", Offset = "0x62CE200", VA = "0x1862CFA00")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NHJGCPBABDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x77D4C0", Offset = "0x77BCC0", VA = "0x18077D4C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x62D01C0", Offset = "0x62CE9C0", VA = "0x1862D01C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62CF6D0", Offset = "0x62CDED0", VA = "0x1862CF6D0", Slot = "12")]
		protected override void JLLPLPFKKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62CF870", Offset = "0x62CE070", VA = "0x1862CF870")]
		private void KFMIOGMGECH(Color[] DEIPNFLMCDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62CEE20", Offset = "0x62CD620", VA = "0x1862CEE20", Slot = "13")]
		protected override void FPHNBHGCOIC(Material JGLFCCBLACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62CF4B0", Offset = "0x62CDCB0", VA = "0x1862CF4B0", Slot = "14")]
		protected override void HLCAENCMCAE(Material JGLFCCBLACF, bool PLMDMDMKAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62CFEF0", Offset = "0x62CE6F0", VA = "0x1862CFEF0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly INEFPLKBOCD NINCMJNBNGD;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite LABJBIKHADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material AGNOIHFCIFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material OIJKJOOCEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool NGADBDJAJNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool EIKLEJINBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool DOCKEJJCFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool JAOHPIPKAEM;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic KLNPLMNHLID
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader DHACOAILCIE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool KPFGJNEDGJA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool NANAOIHCBGH
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform LDMBINLCOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x62D1EC0", Offset = "0x62D06C0", VA = "0x1862D1EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect OLFOPJMKHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x62D11B0", Offset = "0x62CF9B0", VA = "0x1862D11B0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite OIOGNPOKEAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x62D1F20", Offset = "0x62D0720", VA = "0x1862D1F20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62D12D0", Offset = "0x62CFAD0", VA = "0x1862D12D0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62D21A0", Offset = "0x62D09A0", VA = "0x1862D21A0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62D24A0", Offset = "0x62D0CA0", VA = "0x1862D24A0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62D2350", Offset = "0x62D0B50", VA = "0x1862D2350", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62D14C0", Offset = "0x62CFCC0", VA = "0x1862D14C0")]
		private void DHONOJBJLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62D19A0", Offset = "0x62D01A0", VA = "0x1862D19A0")]
		private void FHKCOOCKHBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62D2170", Offset = "0x62D0970", VA = "0x1862D2170")]
		private void OILCKHLJCGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62D2120", Offset = "0x62D0920", VA = "0x1862D2120")]
		private void OHNFBIEOHBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62D1B10", Offset = "0x62D0310", VA = "0x1862D1B10")]
		protected void IBCDPNAGHGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62D1D80", Offset = "0x62D0580", VA = "0x1862D1D80")]
		private void IEGDPCCCCEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "12")]
		protected virtual void JLLPLPFKKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "13")]
		protected virtual void FPHNBHGCOIC(Material JGLFCCBLACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "14")]
		protected virtual void HLCAENCMCAE(Material JGLFCCBLACF, bool PLMDMDMKAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62D1650", Offset = "0x62CFE50", VA = "0x1862D1650")]
		private void FCLLNDKKIEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
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
		private static readonly int BBEBPBKLACG;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int DONJJODLDFM;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int CLKEIELFFIG;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int OAFIECBLBGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
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
		private Color[] BLIIOFNPCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] LENOAMMPECJ;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic KLNPLMNHLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool NANAOIHCBGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> KKJCIJIKCGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 MMJNAKEJIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x62D2F70", Offset = "0x62D1770", VA = "0x1862D2F70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x62D2F90", Offset = "0x62D1790", VA = "0x1862D2F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62D2BB0", Offset = "0x62D13B0", VA = "0x1862D2BB0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> ACKEAFCOEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62D2970", Offset = "0x62D1170", VA = "0x1862D2970")]
		public bool SetRingLayerColor(int FIIIJAPNPGF, Color MOJKBHCPNEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62D2AC0", Offset = "0x62D12C0", VA = "0x1862D2AC0")]
		public bool SetRingLayerSize(int FIIIJAPNPGF, float ALCHALOFNIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62D2830", Offset = "0x62D1030", VA = "0x1862D2830", Slot = "12")]
		protected override void JLLPLPFKKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62D2660", Offset = "0x62D0E60", VA = "0x1862D2660", Slot = "13")]
		protected override void FPHNBHGCOIC(Material JGLFCCBLACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62D27E0", Offset = "0x62D0FE0", VA = "0x1862D27E0", Slot = "14")]
		protected override void HLCAENCMCAE(Material JGLFCCBLACF, bool PLMDMDMKAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62D2D00", Offset = "0x62D1500", VA = "0x1862D2D00")]
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
		public enum OPEGEOCFPMF
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int MGCHFLBMLGK;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int DFMJHHLIAJJ;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int JEKEJIKBFJL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int HGPEHFCGMKN;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int NODJBJFGFFL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int GBFIJACKOKM;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int BHAEIMKJCIC;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int HFJPGOKDELI;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int HCMEMOKBFDN;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int GCOOKKBIKBH;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int KMLBPEPDDMJ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int CAJPNPMPINK;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int CJGHGLAPONP;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int NCCBBMHHLLM;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int JBPJIPJDHHN;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int JNJMOPEEOGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[MPCIHJNAEHG(LFNBNCHIJGL.Self, false, false, false)]
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
		private OPEGEOCFPMF animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[IJNIOHAIOOA("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[IJNIOHAIOOA("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic KLNPLMNHLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool NANAOIHCBGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite PMJBNKJCJMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x62D3DE0", Offset = "0x62D25E0", VA = "0x1862D3DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x62D4000", Offset = "0x62D2800", VA = "0x1862D4000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color NFOENGJGPDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8A8A60", Offset = "0x8A7260", VA = "0x1808A8A60")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x62D4090", Offset = "0x62D2890", VA = "0x1862D4090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color KOGAIAGCHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x19E84B0", Offset = "0x19E6CB0", VA = "0x1819E84B0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x62D3ED0", Offset = "0x62D26D0", VA = "0x1862D3ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float KAADGBFIPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9254A0", Offset = "0x923CA0", VA = "0x1809254A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x62D3F90", Offset = "0x62D2790", VA = "0x1862D3F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 NFAGCKNAKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x19DCC30", Offset = "0x19DB430", VA = "0x1819DCC30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x62D3FB0", Offset = "0x62D27B0", VA = "0x1862D3FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float DICPGLIBNDC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x77D100", Offset = "0x77B900", VA = "0x18077D100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x62D3F50", Offset = "0x62D2750", VA = "0x1862D3F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 BLIPGJMOPEP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x99C9A0", Offset = "0x99B1A0", VA = "0x18099C9A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x62D4110", Offset = "0x62D2910", VA = "0x1862D4110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float EOPNMPHACKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9A4BC0", Offset = "0x9A33C0", VA = "0x1809A4BC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x62D3EA0", Offset = "0x62D26A0", VA = "0x1862D3EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 PAOOALOEMKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x62D39E0", Offset = "0x62D21E0", VA = "0x1862D39E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public OPEGEOCFPMF CDCLDDJMOHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x955E10", Offset = "0x954610", VA = "0x180955E10")]
			get
			{
				return default(OPEGEOCFPMF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x62D3EC0", Offset = "0x62D26C0", VA = "0x1862D3EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float FMMJIJKCIII
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA97B50", Offset = "0xA96350", VA = "0x180A97B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x62D3F70", Offset = "0x62D2770", VA = "0x1862D3F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float GANPBLKNMPN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA97CA0", Offset = "0xA964A0", VA = "0x180A97CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x62D3E80", Offset = "0x62D2680", VA = "0x1862D3E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62D2FE0", Offset = "0x62D17E0", VA = "0x1862D2FE0", Slot = "13")]
		protected override void FPHNBHGCOIC(Material JGLFCCBLACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62D36E0", Offset = "0x62D1EE0", VA = "0x1862D36E0")]
		private void HGJNPCLEBKB(Sprite EHGBNLFJMHE, [Out] Vector2 FAPFLCKOPOE, [Out] Vector2 EJKDHLFLCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62D3990", Offset = "0x62D2190", VA = "0x1862D3990", Slot = "14")]
		protected override void HLCAENCMCAE(Material JGLFCCBLACF, bool PLMDMDMKAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62D3D50", Offset = "0x62D2550", VA = "0x1862D3D50")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader BCDDHJLPMAD;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader DHACOAILCIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x62D41B0", Offset = "0x62D29B0", VA = "0x1862D41B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62D4160", Offset = "0x62D2960", VA = "0x1862D4160")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class INEFPLKBOCD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct GBNJIPAOBDB : IEquatable<GBNJIPAOBDB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component FJNGJOFLBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action NNMJJLHFOEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int KNAFOANJMHO;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component HJDKGHCJLAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x62CCBC0", Offset = "0x62CB3C0", VA = "0x1862CCBC0")]
		public GBNJIPAOBDB(Component FJNGJOFLBMD, Action NNMJJLHFOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x62CCB40", Offset = "0x62CB340", VA = "0x1862CCB40")]
		public void HPKKAMDMNCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x62CCB30", Offset = "0x62CB330", VA = "0x1862CCB30", Slot = "4")]
		public bool Equals(GBNJIPAOBDB IFHFGCDLDEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x62CCAA0", Offset = "0x62CB2A0", VA = "0x1862CCAA0", Slot = "0")]
		public override bool Equals(object CBBCDNDPNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class FOANCPDEHLF : IEnumerator<DENFKKKFFPI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private DENFKKKFFPI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public INEFPLKBOCD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private DENFKKKFFPI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public FOANCPDEHLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x62CC690", Offset = "0x62CAE90", VA = "0x1862CC690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62CCA50", Offset = "0x62CB250", VA = "0x1862CCA50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly JGKDNNHAPDI KEKEKOGBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int DDIEHMKOFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int IAKPIDDKPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> KHHMBLHLMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, GBNJIPAOBDB> JMPMOOHINPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<GBNJIPAOBDB> ELNDCALLHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<GBNJIPAOBDB> OKBNCFBBHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private GCEJIALBLON HDNICDGLNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NBDDNHBFDLH MFMNKAHFBMG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private NBDDNHBFDLH IKKDEMGCHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62CE430", Offset = "0x62CCC30", VA = "0x1862CE430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x62CE5A0", Offset = "0x62CCDA0", VA = "0x1862CE5A0")]
	public INEFPLKBOCD(JGKDNNHAPDI KEKEKOGBDLA, int DDIEHMKOFEK = -1, int IAKPIDDKPGO = -1, [Optional] Func<Component, float> KHHMBLHLMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62CDF30", Offset = "0x62CC730", VA = "0x1862CDF30")]
	public void DFPKGNAEPAD(Component FJNGJOFLBMD, Action NFBNNCDBMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x62CDDA0", Offset = "0x62CC5A0", VA = "0x1862CDDA0")]
	public void CAJCLNJAPJH(Component FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62CE3D0", Offset = "0x62CCBD0", VA = "0x1862CE3D0")]
	public bool LBIBFKCIGFK(Component FMGHNFLOPOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x62CE190", Offset = "0x62CC990", VA = "0x1862CE190")]
	private void DJCICJMJEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x62CE4A0", Offset = "0x62CCCA0", VA = "0x1862CE4A0")]
	[IteratorStateMachine(typeof(FOANCPDEHLF))]
	private IEnumerator<DENFKKKFFPI> NNPPNDADHMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7FB950", Offset = "0x7FA150", VA = "0x1807FB950")]
	[CompilerGenerated]
	private void MFMONLJMALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x62CE520", Offset = "0x62CCD20", VA = "0x1862CE520")]
	[CompilerGenerated]
	private float PACOJEDONGM(GBNJIPAOBDB NFBNNCDBMIA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OLFBDNEMOKC
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	AGLMONDDIKG JFLAEBJAJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool OOAOKLKBOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	MBOBMBMLJPH<AGLMONDDIKG> NBDCOOKLPIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BGKBEGLDCND(AGLMONDDIKG CIMDOJJJKPP, bool PMBIOINBFOO = false);
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
