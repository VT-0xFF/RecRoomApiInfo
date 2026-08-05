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
				[Cpp2IlInjected.Address(RVA = "0x1CEB8C0", Offset = "0x1CEA2C0", VA = "0x181CEB8C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x1CEB920", Offset = "0x1CEA320", VA = "0x181CEB920")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x1CEB840", Offset = "0x1CEA240", VA = "0x181CEB840")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1CEB4F0", Offset = "0x1CE9EF0", VA = "0x181CEB4F0")]
			public void GLFMAMNCIPF(PointerEventData CKODACGGCMH, RectTransform MILKBLBPFAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1CEB3D0", Offset = "0x1CE9DD0", VA = "0x181CEB3D0")]
			public void BIGGGPGIAAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1CEB750", Offset = "0x1CEA150", VA = "0x181CEB750")]
			public void OEDMNDOMICF(PointerEventData CKODACGGCMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1CEB700", Offset = "0x1CEA100", VA = "0x181CEB700")]
			public void NBJBEHLDIBE(float FGKFKEAJDME, RectTransform MILKBLBPFAP, Vector3 OPILFLDGFGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly global::DMMLEDLKPJG<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly global::DMMLEDLKPJG<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::DMMLEDLKPJG<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly global::DMMLEDLKPJG<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly global::DMMLEDLKPJG<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly JAENCPCNABI PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData AJMAMLABGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool EPCNNODMNAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool HBICIEEPGEB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OPIGLGGEPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x877E80", Offset = "0x876880", VA = "0x180877E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x1CEAB30", Offset = "0x1CE9530", VA = "0x181CEAB30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool OIEIMCGHGPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCA7930", Offset = "0xCA6330", VA = "0x180CA7930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1CEAA80", Offset = "0x1CE9480", VA = "0x181CEAA80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1CEAAB0", Offset = "0x1CE94B0", VA = "0x181CEAAB0")]
		private bool LMEMOGJMOGJ(PointerEventData JBCBBGBMKAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB0E0", Offset = "0x1CE9AE0", VA = "0x181CEB0E0", Slot = "5")]
		public void OnPointerDown(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB1A0", Offset = "0x1CE9BA0", VA = "0x181CEB1A0", Slot = "11")]
		public void OnPointerUp(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1CEAE50", Offset = "0x1CE9850", VA = "0x181CEAE50", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1CEAB60", Offset = "0x1CE9560", VA = "0x181CEAB60", Slot = "7")]
		public void OnBeginDrag(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1CEAC80", Offset = "0x1CE9680", VA = "0x181CEAC80", Slot = "4")]
		public void OnDrag(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1CEAD70", Offset = "0x1CE9770", VA = "0x181CEAD70", Slot = "8")]
		public void OnEndDrag(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB140", Offset = "0x1CE9B40", VA = "0x181CEB140", Slot = "9")]
		public void OnPointerEnter(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB170", Offset = "0x1CE9B70", VA = "0x181CEB170", Slot = "10")]
		public void OnPointerExit(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1CEAC40", Offset = "0x1CE9640", VA = "0x181CEAC40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB200", Offset = "0x1CE9C00", VA = "0x181CEB200")]
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
		private OptionData DAJDPLHNAAO;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6D80", Offset = "0x1CE5780", VA = "0x181CE6D80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6C70", Offset = "0x1CE5670", VA = "0x181CE6C70", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6BB0", Offset = "0x1CE55B0", VA = "0x181CE6BB0")]
		private void ELLPAGMMJND(GameObject GGHPNGMJGIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6F60", Offset = "0x1CE5960", VA = "0x181CE6F60")]
		public void SetOptionsWithNoDefault(List<string> IBILAOBJNIO, [Optional] string JGCLLNNCNMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE71A0", Offset = "0x1CE5BA0", VA = "0x181CE71A0")]
		public void SetOptionsWithNoDefault(List<OptionData> GFLJMAGGCPJ, [Optional] string JGCLLNNCNMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6E90", Offset = "0x1CE5890", VA = "0x181CE6E90", Slot = "42")]
		public override void OnPointerClick(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas NOECPCDGKJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7290", Offset = "0x1CE5C90", VA = "0x181CE7290")]
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
		private sealed class LLINDDENMKC : IEnumerator<FJMKJDOKGFB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private FJMKJDOKGFB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private FJMKJDOKGFB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
			[DebuggerHidden]
			public LLINDDENMKC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7FB0", Offset = "0x1CE69B0", VA = "0x181CE7FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1CE84D0", Offset = "0x1CE6ED0", VA = "0x181CE84D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[CCLDAICIAJB(MAMLNCPNJJC.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly MLJMKOJHCLB JNCDEMPAOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool KOHDICKJADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? BGDCLHIEJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? FACEOHFOFML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? GCLBJMKJHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool FKNIOHHIFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool EBGBILFKKEK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool LKOPJLECLBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7970", Offset = "0x1CE6370", VA = "0x181CE7970", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ANIFJHGCBLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7950", Offset = "0x1CE6350", VA = "0x181CE7950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LIEEBPMDIBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x10E8B10", Offset = "0x10E7510", VA = "0x1810E8B10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7B40", Offset = "0x1CE6540", VA = "0x181CE7B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KPEGMBFBDFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1CE78B0", Offset = "0x1CE62B0", VA = "0x181CE78B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7AA0", Offset = "0x1CE64A0", VA = "0x181CE7AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1CE72F0", Offset = "0x1CE5CF0", VA = "0x181CE72F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7680", Offset = "0x1CE6080", VA = "0x181CE7680")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7590", Offset = "0x1CE5F90", VA = "0x181CE7590")]
		public void Hide(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE77C0", Offset = "0x1CE61C0", VA = "0x181CE77C0")]
		public void Show(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7720", Offset = "0x1CE6120", VA = "0x181CE7720")]
		public void Set(object HMAOAMDKNDD, bool CGOAADACJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7390", Offset = "0x1CE5D90", VA = "0x181CE7390")]
		private void CJNMOENLGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7610", Offset = "0x1CE6010", VA = "0x181CE7610")]
		[IteratorStateMachine(typeof(LLINDDENMKC))]
		private IEnumerator<FJMKJDOKGFB> IMIAMIECJAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7550", Offset = "0x1CE5F50", VA = "0x181CE7550", Slot = "5")]
		public virtual void DoHideOrShow(bool CEHNPECECKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7840", Offset = "0x1CE6240", VA = "0x181CE7840")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EJFABJHMFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x80A4B0", Offset = "0x808EB0", VA = "0x18080A4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> FJCAJJHLJAN
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7D30", Offset = "0x1CE6730", VA = "0x181CE7D30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7E70", Offset = "0x1CE6870", VA = "0x181CE7E70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> DNHOPNIEEJE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7DD0", Offset = "0x1CE67D0", VA = "0x181CE7DD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1CE7F10", Offset = "0x1CE6910", VA = "0x181CE7F10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7C70", Offset = "0x1CE6670", VA = "0x181CE7C70", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1CE7CD0", Offset = "0x1CE66D0", VA = "0x181CE7CD0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData JBCBBGBMKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xDB9650", Offset = "0xDB8050", VA = "0x180DB9650")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xDB9650", Offset = "0xDB8050", VA = "0x180DB9650")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DMMDMOHNMMN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum CILIFFLAFNI
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const CILIFFLAFNI LOGLEMNHDNE = CILIFFLAFNI.Light;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const string IHGLOCHHPFJ = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static BFKALAACKIL DJLFLJLDKDC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BFKALAACKIL BOCLNNMINBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6A70", Offset = "0x1CE5470", VA = "0x181CE6A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static CILIFFLAFNI BLJGOPGCDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1CE68D0", Offset = "0x1CE52D0", VA = "0x181CE68D0")]
		get
		{
			return default(CILIFFLAFNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6520", Offset = "0x1CE4F20", VA = "0x181CE6520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<CILIFFLAFNI> BOIHEOINOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1CE66D0", Offset = "0x1CE50D0", VA = "0x181CE66D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1CE67D0", Offset = "0x1CE51D0", VA = "0x181CE67D0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FLKIHLFOKFL : LMEEBHCKGHL, KPMHMLGLHBF, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	global::HGIFLDAHCKA<GameObject, int> MALKNBHFFOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	global::IINGBGFGMKE<GameObject, int, bool> AHILBADHNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	global::DMMLEDLKPJG<bool> JLDNJLGODPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool MHNCOLNPPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float PBNPIIACCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	global::DMMLEDLKPJG<float> BAGIHAMMGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JAENCPCNABI OLMICFILFJO
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
	void SpawnLoadingPlaceholders(GameObject INOMEBNKFPO);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FNGFMMGLOOC Spawn<T>(int OJBKEOGCFLH, IReadOnlyList<T> MNILNHMNKJK, GameObject INOMEBNKFPO);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FNGFMMGLOOC Spawn<T>(int OJBKEOGCFLH, IReadOnlyList<T> MNILNHMNKJK, GameObject KIPIFNBAHPN, ref Func<int, GameObject> AGDKDMMIDAP);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum IMEELBHIDLI : byte
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
		private static readonly int KHMGJJPKNHL;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<IMEELBHIDLI, string> IMEHLKOMGHK;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int AGCJBJDJCGO = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int BBLPNIIPGDA;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int OAGOPFEFJFM;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int PFEGMKJBCPK;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int DINEJJIFPNG;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int MNKFNDDDEDO;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int DIFJGCDNMFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool JAPHPLKDIJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool BBPPIMABCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Color[] OADIOMDDPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private IMEELBHIDLI type;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly IMEELBHIDLI[] AFDGPCECHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[EAIPBFEGLOF("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly IMEELBHIDLI[] FOCECGJDOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[EAIPBFEGLOF("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[Range(0f, 360f)]
		[EAIPBFEGLOF("type", (byte)4)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		[EAIPBFEGLOF("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic HGILEKFMDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool BGBPCDJALKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient OIKNHKIDEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1CEA8D0", Offset = "0x1CE92D0", VA = "0x181CEA8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IMEELBHIDLI EFFMKCNPJPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8F20E0", Offset = "0x8F0AE0", VA = "0x1808F20E0")]
			get
			{
				return default(IMEELBHIDLI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1CEAA50", Offset = "0x1CE9450", VA = "0x181CEAA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool EAJMDNMONKE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1CE9590", Offset = "0x1CE7F90", VA = "0x181CE9590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 LIMAKKEBHIL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1CEA820", Offset = "0x1CE9220", VA = "0x181CEA820")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1CEA860", Offset = "0x1CE9260", VA = "0x181CEA860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool KPBPNPJBFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1CEA300", Offset = "0x1CE8D00", VA = "0x181CEA300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 PEMIOODAJKI
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1CEA840", Offset = "0x1CE9240", VA = "0x181CEA840")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1CEAA00", Offset = "0x1CE9400", VA = "0x181CEAA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KADFNIIDBPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xDEECC0", Offset = "0xDED6C0", VA = "0x180DEECC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1CEA8B0", Offset = "0x1CE92B0", VA = "0x181CEA8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 ODDCALCKHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1CE9610", Offset = "0x1CE8010", VA = "0x181CE9610")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 NJKENIOFDNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1CEA050", Offset = "0x1CE8A50", VA = "0x181CEA050")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float FHAMNFBBONM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x140E2E0", Offset = "0x140CCE0", VA = "0x18140E2E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1CEAA60", Offset = "0x1CE9460", VA = "0x181CEAA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1CE9ED0", Offset = "0x1CE88D0", VA = "0x181CE9ED0", Slot = "12")]
		protected override void KBJPFMHEJKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1CE9660", Offset = "0x1CE8060", VA = "0x181CE9660")]
		private void FDJDIFOHNMC(Color[] OAOMOGDBDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1CE97D0", Offset = "0x1CE81D0", VA = "0x181CE97D0", Slot = "13")]
		protected override void JHPOCDKLHFJ(Material NCNMCMAJCOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1CEA0E0", Offset = "0x1CE8AE0", VA = "0x181CEA0E0", Slot = "14")]
		protected override void KKJJNAADMMF(Material NCNMCMAJCOL, bool CABHIPNEIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1CEA760", Offset = "0x1CE9160", VA = "0x181CEA760")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static readonly PKPFPJLABFK FOEAONCDNNI;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static Sprite PKCNCFLKIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Material PFMLMFJLNAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material GFJENFOEENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool MADDNOKJJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool KOHDICKJADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool EPAHDEKLEPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool KODDMMNMCDL;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic HGILEKFMDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader EMFEPGOBDCD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool BGBPCDJALKP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool NLOLMEDKBPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform MILKBLBPFAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1CEBB60", Offset = "0x1CEA560", VA = "0x181CEBB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect PLFJLKHPPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1CEBDE0", Offset = "0x1CEA7E0", VA = "0x181CEBDE0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite JABAFFGLKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1CEC2A0", Offset = "0x1CEACA0", VA = "0x181CEC2A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1CEBBC0", Offset = "0x1CEA5C0", VA = "0x181CEBBC0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC9C0", Offset = "0x1CEB3C0", VA = "0x181CEC9C0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1CECCE0", Offset = "0x1CEB6E0", VA = "0x181CECCE0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1CECB70", Offset = "0x1CEB570", VA = "0x181CECB70", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC470", Offset = "0x1CEAE70", VA = "0x181CEC470")]
		private void HPJJCLMHPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC860", Offset = "0x1CEB260", VA = "0x181CEC860")]
		private void OPFMHPPJNCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1CEBDB0", Offset = "0x1CEA7B0", VA = "0x181CEBDB0")]
		private void DDMHAJHOBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1CEBB10", Offset = "0x1CEA510", VA = "0x181CEBB10")]
		private void AGHFOBPPJLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1CEC5F0", Offset = "0x1CEAFF0", VA = "0x181CEC5F0")]
		protected void KAAGDHMJIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CEB9D0", Offset = "0x1CEA3D0", VA = "0x181CEB9D0")]
		private void AAHAMHFMCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "12")]
		protected virtual void KBJPFMHEJKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "13")]
		protected virtual void JHPOCDKLHFJ(Material NCNMCMAJCOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "14")]
		protected virtual void KKJJNAADMMF(Material NCNMCMAJCOL, bool CABHIPNEIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1CEBF10", Offset = "0x1CEA910", VA = "0x181CEBF10")]
		private void FCPEJHOKPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		[Conditional("RRUI_PROFILING")]
		protected void PDJFAGFFCDI(string FJMCJNMPNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		[Conditional("RRUI_PROFILING")]
		protected void NIAKJPLPJGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x1069F0", Offset = "0x105DF0")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int DLJBBLCEMID;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int GJPCNNPFHLA;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int NMNJLFEOHKM;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int MECJCPABLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
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
		private Color[] OADIOMDDPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private float[] DDLFIPPNJKI;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic HGILEKFMDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool NLOLMEDKBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> LCLJMCIAKIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 LIMAKKEBHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x1CED6C0", Offset = "0x1CEC0C0", VA = "0x181CED6C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1CED6E0", Offset = "0x1CEC0E0", VA = "0x181CED6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1CED3C0", Offset = "0x1CEBDC0", VA = "0x181CED3C0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> LEENLABAJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1CED1A0", Offset = "0x1CEBBA0", VA = "0x181CED1A0")]
		public bool SetRingLayerColor(int OIKAECPDLCM, Color CPPINAHFMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1CED2B0", Offset = "0x1CEBCB0", VA = "0x181CED2B0")]
		public bool SetRingLayerSize(int OIKAECPDLCM, float IMMPKDAEONJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1CECFE0", Offset = "0x1CEB9E0", VA = "0x181CECFE0", Slot = "12")]
		protected override void KBJPFMHEJKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1CECE60", Offset = "0x1CEB860", VA = "0x181CECE60", Slot = "13")]
		protected override void JHPOCDKLHFJ(Material NCNMCMAJCOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1CED150", Offset = "0x1CEBB50", VA = "0x181CED150", Slot = "14")]
		protected override void KKJJNAADMMF(Material NCNMCMAJCOL, bool CABHIPNEIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1CED510", Offset = "0x1CEBF10", VA = "0x181CED510")]
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
		public enum FLLNHCPKMOO
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int PLLIBPOCMPE;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int PHCCMFGJMCK;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int MOOPCLGNCLE;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int MHNBMDNHEKB;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int DJNGGOBDGFP;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int ALLCICEHEIM;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int PLAMPEAHIFD;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int DFNJNPIDLOL;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int NCAGDNDDOCI;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int CEIEKENAAJB;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int LCHMDINHLDE;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int DKEKBHNFJHK;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int KNJAGLDLOLO;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int AKEPJKEACMP;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int NLHNJGEDNGG;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int DIDICLPDINH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		[ADNNDKFKEGG(MAMLNCPNJJC.Self, false, false, false)]
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
		private FLLNHCPKMOO animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[EAIPBFEGLOF("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[EAIPBFEGLOF("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic HGILEKFMDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool NLOLMEDKBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite AAPMMGMGPEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE4D0", Offset = "0x1CECED0", VA = "0x181CEE4D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE700", Offset = "0x1CED100", VA = "0x181CEE700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color LMCEBDKFCJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA14000", Offset = "0xA12A00", VA = "0x180A14000")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE7A0", Offset = "0x1CED1A0", VA = "0x181CEE7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color KFMMJMPKNAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xEEF820", Offset = "0xEEE220", VA = "0x180EEF820")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE5F0", Offset = "0x1CECFF0", VA = "0x181CEE5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float IPFMIFKFJEK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD53700", Offset = "0xD52100", VA = "0x180D53700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE690", Offset = "0x1CED090", VA = "0x181CEE690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 PCPFBNOHPAP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE4B0", Offset = "0x1CECEB0", VA = "0x181CEE4B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE6B0", Offset = "0x1CED0B0", VA = "0x181CEE6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float AOAOIBFPEKK
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xB5FC40", Offset = "0xB5E640", VA = "0x180B5FC40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE650", Offset = "0x1CED050", VA = "0x181CEE650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 KCBBAENBLON
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE580", Offset = "0x1CECF80", VA = "0x181CEE580")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE800", Offset = "0x1CED200", VA = "0x181CEE800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float CEHAKEDJPIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xCE66D0", Offset = "0xCE50D0", VA = "0x180CE66D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE5C0", Offset = "0x1CECFC0", VA = "0x181CEE5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 LIDMJCNODHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE0C0", Offset = "0x1CECAC0", VA = "0x181CEE0C0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public FLLNHCPKMOO GKGLKGGJPPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD7D710", Offset = "0xD7C110", VA = "0x180D7D710")]
			get
			{
				return default(FLLNHCPKMOO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE5E0", Offset = "0x1CECFE0", VA = "0x181CEE5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float BIOACPBFIKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1302910", Offset = "0x1301310", VA = "0x181302910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE670", Offset = "0x1CED070", VA = "0x181CEE670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float NHCLEOEEPBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x12CA900", Offset = "0x12C9300", VA = "0x1812CA900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE5A0", Offset = "0x1CECFA0", VA = "0x181CEE5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1CED730", Offset = "0x1CEC130", VA = "0x181CED730", Slot = "13")]
		protected override void JHPOCDKLHFJ(Material NCNMCMAJCOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1CEDE40", Offset = "0x1CEC840", VA = "0x181CEDE40")]
		private void MFDEMMLBFFN(Sprite GNFCMLMPPEL, out Vector2 EMPAPMMICFC, out Vector2 KKGDJBAABGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1CEDDF0", Offset = "0x1CEC7F0", VA = "0x181CEDDF0", Slot = "14")]
		protected override void KKJJNAADMMF(Material NCNMCMAJCOL, bool CABHIPNEIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1CEE410", Offset = "0x1CECE10", VA = "0x181CEE410")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static Shader JNLJHGOGEFE;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader EMFEPGOBDCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE8B0", Offset = "0x1CED2B0", VA = "0x181CEE8B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1CEE850", Offset = "0x1CED250", VA = "0x181CEE850")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PKPFPJLABFK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct CEHCIMJFIPK : IEquatable<CEHCIMJFIPK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly Component BKJKDPLKCNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly Action NFKKAEMAJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly int GNODCKBEKEJ;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component CCPLFDBIPHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x875BB0", Offset = "0x8745B0", VA = "0x180875BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6150", Offset = "0x1CE4B50", VA = "0x181CE6150")]
		public CEHCIMJFIPK(Component BKJKDPLKCNE, Action NFKKAEMAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1CE60D0", Offset = "0x1CE4AD0", VA = "0x181CE60D0")]
		public void JJCDHEEDCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6030", Offset = "0x1CE4A30", VA = "0x181CE6030", Slot = "4")]
		public bool Equals(CEHCIMJFIPK EHBPAFKHADK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1CE6040", Offset = "0x1CE4A40", VA = "0x181CE6040", Slot = "0")]
		public override bool Equals(object OMHIFHKMIMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DBHAELLMPFN : IEnumerator<FJMKJDOKGFB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private FJMKJDOKGFB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PKPFPJLABFK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private FJMKJDOKGFB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
		[DebuggerHidden]
		public DBHAELLMPFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1CE61B0", Offset = "0x1CE4BB0", VA = "0x181CE61B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1CE64E0", Offset = "0x1CE4EE0", VA = "0x181CE64E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CBLODFENING.BNAPEOFIEGJ NKKAIJKMCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly int PBDCKHNJGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly int ODLFLFJPFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Func<Component, float> HNGBIIOJKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly Dictionary<Component, CEHCIMJFIPK> BBMKIEJIDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LinkedList<CEHCIMJFIPK> DCAACKDIGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly List<CEHCIMJFIPK> IHCOIOBEJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private LLDNPBCCADD ALJLNMKJBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private PKJMDBGKCOM CEGCICJCOPO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private PKJMDBGKCOM BKPMAHAEEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1CE92A0", Offset = "0x1CE7CA0", VA = "0x181CE92A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9370", Offset = "0x1CE7D70", VA = "0x181CE9370")]
	public PKPFPJLABFK(CBLODFENING.BNAPEOFIEGJ NKKAIJKMCDB, int PBDCKHNJGBG = -1, int ODLFLFJPFHJ = -1, [Optional] Func<Component, float> HNGBIIOJKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8B40", Offset = "0x1CE7540", VA = "0x181CE8B40")]
	public void ABOJBMCEGDH(Component BKJKDPLKCNE, Action EFBMHMFMEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8DB0", Offset = "0x1CE77B0", VA = "0x181CE8DB0")]
	public void BJHOCAIJMLC(Component BKJKDPLKCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9310", Offset = "0x1CE7D10", VA = "0x181CE9310")]
	public bool OJOKNLJKOBA(Component DHGNJCDIFDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1CE9070", Offset = "0x1CE7A70", VA = "0x181CE9070")]
	private void IAIOCMJCDPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8F40", Offset = "0x1CE7940", VA = "0x181CE8F40")]
	[IteratorStateMachine(typeof(DBHAELLMPFN))]
	private IEnumerator<FJMKJDOKGFB> CHLHCBAFGLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x18ED370", Offset = "0x18EBD70", VA = "0x1818ED370")]
	[CompilerGenerated]
	private void JFMGHKJJHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8FB0", Offset = "0x1CE79B0", VA = "0x181CE8FB0")]
	[CompilerGenerated]
	private float CLHDGNHKOME(CEHCIMJFIPK EFBMHMFMEGG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HJHGMHGIBPH
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NIOKIGDAOIK
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FFJACNDLLBP GFALPLPIPPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool BNLOMIGBNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	global::DMMLEDLKPJG<FFJACNDLLBP> FHBCEIJMMON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MEHNDGPDKGM(FFJACNDLLBP AEHHGMIEOGM, bool EGIHCAOLHFJ = false);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8510", Offset = "0x1CE6F10", VA = "0x181CE8510")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1CE8620", Offset = "0x1CE7020", VA = "0x181CE8620")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
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
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
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
