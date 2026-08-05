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
				[Cpp2IlInjected.Address(RVA = "0x714BE30", Offset = "0x714A830", VA = "0x18714BE30")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x714BE90", Offset = "0x714A890", VA = "0x18714BE90")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x714BDE0", Offset = "0x714A7E0", VA = "0x18714BDE0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x714BA00", Offset = "0x714A400", VA = "0x18714BA00")]
			public void MAHCLNIBDEK(PointerEventData KDADLOCMHHL, RectTransform NFAHIHMJDDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x714BB50", Offset = "0x714A550", VA = "0x18714BB50")]
			public void OGCAIBGLCKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x714B920", Offset = "0x714A320", VA = "0x18714B920")]
			public void CGJHCCHAMOL(PointerEventData KDADLOCMHHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x714BB00", Offset = "0x714A500", VA = "0x18714BB00")]
			public void MHEJHOHNBAJ(float EPKAKIINBCH, RectTransform NFAHIHMJDDH, Vector3 KHAKKIFNDKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly FCOLMBOCIND<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly FCOLMBOCIND<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly FCOLMBOCIND<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly FCOLMBOCIND<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly FCOLMBOCIND<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly MNIMPDIHNFL PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData CGHLLDOBOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool GHIBCKJJBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool PBCPEHHKKNB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LHEHGAJGNPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x84FDF0", Offset = "0x84E7F0", VA = "0x18084FDF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x714B0B0", Offset = "0x7149AB0", VA = "0x18714B0B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FJPFJKBAAHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x84FE70", Offset = "0x84E870", VA = "0x18084FE70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x714B0E0", Offset = "0x7149AE0", VA = "0x18714B0E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x714B110", Offset = "0x7149B10", VA = "0x18714B110")]
		private bool LFHOOJHMBNJ(PointerEventData ECOHBDCBECH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x714B5E0", Offset = "0x7149FE0", VA = "0x18714B5E0", Slot = "5")]
		public void OnPointerDown(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x714B6A0", Offset = "0x714A0A0", VA = "0x18714B6A0", Slot = "11")]
		public void OnPointerUp(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x714B450", Offset = "0x7149E50", VA = "0x18714B450", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x714B190", Offset = "0x7149B90", VA = "0x18714B190", Slot = "7")]
		public void OnBeginDrag(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x714B2A0", Offset = "0x7149CA0", VA = "0x18714B2A0", Slot = "4")]
		public void OnDrag(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x714B380", Offset = "0x7149D80", VA = "0x18714B380", Slot = "8")]
		public void OnEndDrag(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x714B640", Offset = "0x714A040", VA = "0x18714B640", Slot = "9")]
		public void OnPointerEnter(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x714B670", Offset = "0x714A070", VA = "0x18714B670", Slot = "10")]
		public void OnPointerExit(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x714B260", Offset = "0x7149C60", VA = "0x18714B260")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x714B700", Offset = "0x714A100", VA = "0x18714B700")]
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
		private OptionData FIMLMGFHADN;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71467F0", Offset = "0x71451F0", VA = "0x1871467F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71466F0", Offset = "0x71450F0", VA = "0x1871466F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7146640", Offset = "0x7145040", VA = "0x187146640")]
		private void HCBALCDHFJM(GameObject LIPFMHPMGIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7146AB0", Offset = "0x71454B0", VA = "0x187146AB0")]
		public void SetOptionsWithNoDefault(List<string> AHBFNFFEMPG, [Optional] string BICAKPNMODF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71469C0", Offset = "0x71453C0", VA = "0x1871469C0")]
		public void SetOptionsWithNoDefault(List<OptionData> FKJNBGBCACC, [Optional] string BICAKPNMODF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x71468F0", Offset = "0x71452F0", VA = "0x1871468F0", Slot = "42")]
		public override void OnPointerClick(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas AMKAIBBECHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7146CE0", Offset = "0x71456E0", VA = "0x187146CE0")]
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
		private sealed class KKNEPOMNCEM : IEnumerator<IHLELHJPJMK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private IHLELHJPJMK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private IHLELHJPJMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
			[DebuggerHidden]
			public KKNEPOMNCEM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7148380", Offset = "0x7146D80", VA = "0x187148380", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7148890", Offset = "0x7147290", VA = "0x187148890", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[GAAOMKKOEKA(MJDOLBEDPIO.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly EKJHOALCHAB<object> FHDINODELDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool JLAIECMONAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? CLLIIDLADLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? CJMDCIAIPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? EJIBKKIDOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool BALFICOMNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool CDPIPJHDKIL;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MBCLDEPIGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7147DA0", Offset = "0x71467A0", VA = "0x187147DA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IKGFPDLFHHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7147D50", Offset = "0x7146750", VA = "0x187147D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CHPCCCFGFCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x897870", Offset = "0x896270", VA = "0x180897870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7147F60", Offset = "0x7146960", VA = "0x187147F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GAIPCNBPNEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7147CB0", Offset = "0x71466B0", VA = "0x187147CB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7147EC0", Offset = "0x71468C0", VA = "0x187147EC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71476A0", Offset = "0x71460A0", VA = "0x1871476A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7147A90", Offset = "0x7146490", VA = "0x187147A90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7147A40", Offset = "0x7146440", VA = "0x187147A40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71479B0", Offset = "0x71463B0", VA = "0x1871479B0")]
		public void Hide(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7147C10", Offset = "0x7146610", VA = "0x187147C10")]
		public void Show(object JCIFCENKMKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7147B20", Offset = "0x7146520", VA = "0x187147B20")]
		public void Set(object JCIFCENKMKP, bool PLEOGDPFOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7147730", Offset = "0x7146130", VA = "0x187147730")]
		public void Clear(bool PHAKLLHGPHK = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71477E0", Offset = "0x71461E0", VA = "0x1871477E0")]
		private void EMCCOPJBKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71479C0", Offset = "0x71463C0", VA = "0x1871479C0")]
		[IteratorStateMachine(typeof(KKNEPOMNCEM))]
		private IEnumerator<IHLELHJPJMK> NIKAAIPEBJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71477A0", Offset = "0x71461A0", VA = "0x1871477A0", Slot = "5")]
		public virtual void DoHideOrShow(bool FIIELCNAFMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7147C20", Offset = "0x7146620", VA = "0x187147C20")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MMMCPPJKJOA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x915D70", Offset = "0x914770", VA = "0x180915D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x85AA60", Offset = "0x859460", VA = "0x18085AA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> DBOEGFKDKDF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x71480C0", Offset = "0x7146AC0", VA = "0x1871480C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7148220", Offset = "0x7146C20", VA = "0x187148220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> DMJJDIONKEE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7148170", Offset = "0x7146B70", VA = "0x187148170")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x71482D0", Offset = "0x7146CD0", VA = "0x1871482D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7148080", Offset = "0x7146A80", VA = "0x187148080", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71480A0", Offset = "0x7146AA0", VA = "0x1871480A0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData ECOHBDCBECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE37470", Offset = "0xE35E70", VA = "0x180E37470")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE37470", Offset = "0xE35E70", VA = "0x180E37470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PNAEIDMINBB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum KMPECOIADHK
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static EFAKPLKDOEA BBAMMKBMEKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static EFAKPLKDOEA HLLFCLLAMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7148F60", Offset = "0x7147960", VA = "0x187148F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static KMPECOIADHK LMHNDOJLJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7149030", Offset = "0x7147A30", VA = "0x187149030")]
		get
		{
			return default(KMPECOIADHK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7149240", Offset = "0x7147C40", VA = "0x187149240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<KMPECOIADHK> OKDNBLOKEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7149160", Offset = "0x7147B60", VA = "0x187149160")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7148E80", Offset = "0x7147880", VA = "0x187148E80")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FBCLBNNBMKJ : CCFDFKDHLMK, IPEFCNJDDKK, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	PFDDDEMFJMK<GameObject, int> NMBOEAPFDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FNKGBDBKDEI<GameObject, int, bool> ABGADJGJNPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FCOLMBOCIND<bool> HMNFDGIMGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GKCKDFCKMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float BLEHMKDPJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FCOLMBOCIND<float> OGFGJPLGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MNIMPDIHNFL PCLGCOFFKMH
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
	void SpawnLoadingPlaceholders(GameObject GJEJJJDCBIG);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BBADIINDDOJ Spawn<T>(int NDHHEIHPGEI, IReadOnlyList<T> EEOBDBMOHPL, GameObject GJEJJJDCBIG);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BBADIINDDOJ Spawn<T>(int NDHHEIHPGEI, IReadOnlyList<T> EEOBDBMOHPL, GameObject OBNGHHFDCKM, Func<int, GameObject> JEAMAMBKOCL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int ILOCEPPJPDO, float CFFNOIMIJKN);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum KLFJOBMMKPB : byte
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
		private static readonly int DECGOLHFPMM;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<KLFJOBMMKPB, string> ELAGJCMCPCJ;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int DOAPEGPAPEI = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int NHAAHKKBABF;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int KIFJAMGJPFJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int LEKCHGBEBKK;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int NFHEDKPGHKE;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int POOGBBCEHOB;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int MFDCDKEEGCP;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int LEIKOEEFANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool CAGIKNACKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool OHGEJHLHGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Color[] EOJKLBOCGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private KLFJOBMMKPB type;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly KLFJOBMMKPB[] LGBPDPPDPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[HJDMMFEIENC("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly KLFJOBMMKPB[] HNEJNHOHKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[HJDMMFEIENC("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[HJDMMFEIENC("type", KLFJOBMMKPB.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Range(0f, 5f)]
		[HJDMMFEIENC("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic PADCDNKMLDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool GAEKKJIIHOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient JEBFEBPLBJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x714AF00", Offset = "0x7149900", VA = "0x18714AF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KLFJOBMMKPB PNFBJLDEHGB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x913BA0", VA = "0x1809151A0")]
			get
			{
				return default(KLFJOBMMKPB);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x714B080", Offset = "0x7149A80", VA = "0x18714B080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool EOEFNMEKECE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x714A520", Offset = "0x7148F20", VA = "0x18714A520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 OHIGOIMIMDL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x714AE70", Offset = "0x7149870", VA = "0x18714AE70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x714AEB0", Offset = "0x71498B0", VA = "0x18714AEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool MENOIFABEME
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x714A590", Offset = "0x7148F90", VA = "0x18714A590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 CEICIFJLDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x714AE90", Offset = "0x7149890", VA = "0x18714AE90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x714B030", Offset = "0x7149A30", VA = "0x18714B030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KEFHGCHGEPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8BC2D0", Offset = "0x8BACD0", VA = "0x1808BC2D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x15A8F30", Offset = "0x15A7930", VA = "0x1815A8F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 JGAJNJODEBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x714A4D0", Offset = "0x7148ED0", VA = "0x18714A4D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 HDKBJNLKICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x714A930", Offset = "0x7149330", VA = "0x18714A930")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DMMGJPBKBNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x867C80", Offset = "0x866680", VA = "0x180867C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x714B090", Offset = "0x7149A90", VA = "0x18714B090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x714A790", Offset = "0x7149190", VA = "0x18714A790", Slot = "12")]
		protected override void HPAFCBBBNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x714A600", Offset = "0x7149000", VA = "0x18714A600")]
		private void HOEGOMFLJNC(Color[] JEILKDGBDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7149A90", Offset = "0x7148490", VA = "0x187149A90", Slot = "13")]
		protected override void BJNIBPAANBN(Material OKNIOBAOHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7149870", Offset = "0x7148270", VA = "0x187149870", Slot = "14")]
		protected override void BHEHKANHDHH(Material OKNIOBAOHHE, bool OPDIOPBPNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x714ADC0", Offset = "0x71497C0", VA = "0x18714ADC0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly EOIDCGLAKDK NDOEABOCGOB;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Sprite HOKCBJAJDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material KDADHJCDKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Material JMEENPEBGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool HLKJKMKFGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool JLAIECMONAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool IBDOFANPHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool CEJONDPBKLO;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic PADCDNKMLDF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader LFGOJNDOAEP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool GAEKKJIIHOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool IOOALEIAHAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform NFAHIHMJDDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x714CAC0", Offset = "0x714B4C0", VA = "0x18714CAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect ACPPOBENNNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x714C9A0", Offset = "0x714B3A0", VA = "0x18714C9A0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite POGDCFAKHOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x714CB50", Offset = "0x714B550", VA = "0x18714CB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x714C3D0", Offset = "0x714ADD0", VA = "0x18714C3D0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x714CD50", Offset = "0x714B750", VA = "0x18714CD50", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x714D050", Offset = "0x714BA50", VA = "0x18714D050", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x714CF00", Offset = "0x714B900", VA = "0x18714CF00", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x714D060", Offset = "0x714BA60", VA = "0x18714D060")]
		private void PGFBLONDMOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x714C5C0", Offset = "0x714AFC0", VA = "0x18714C5C0")]
		private void CAMMIGFFLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x714CB20", Offset = "0x714B520", VA = "0x18714CB20")]
		private void KPEMKDFODBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x714D1F0", Offset = "0x714BBF0", VA = "0x18714D1F0")]
		private void PKLIMBLEDPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x714C730", Offset = "0x714B130", VA = "0x18714C730")]
		protected void CDJBGKDJAOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x714D240", Offset = "0x714BC40", VA = "0x18714D240")]
		private void POEMNAOPPJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "12")]
		protected virtual void HPAFCBBBNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "13")]
		protected virtual void BJNIBPAANBN(Material OKNIOBAOHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "14")]
		protected virtual void BHEHKANHDHH(Material OKNIOBAOHHE, bool OPDIOPBPNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x714C080", Offset = "0x714AA80", VA = "0x18714C080")]
		private void AINJDBEOONE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
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
		private static readonly int DLPDCEKPHDE;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int ANBEJONNBPE;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int BJMFLDAFDBE;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int GOGBNNNANKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
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
		private Color[] EOJKLBOCGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private float[] BKEGGMPDFGD;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic PADCDNKMLDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool IOOALEIAHAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> HCCNEGHJMHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 OHIGOIMIMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x714DE80", Offset = "0x714C880", VA = "0x18714DE80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x714DEA0", Offset = "0x714C8A0", VA = "0x18714DEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x714DA80", Offset = "0x714C480", VA = "0x18714DA80")]
		public void SetRingLayers(IReadOnlyList<RingLayer> IMGHHALJMFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x714D840", Offset = "0x714C240", VA = "0x18714D840")]
		public bool SetRingLayerColor(int NDBFPELDACP, Color COGPPELINPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x714D990", Offset = "0x714C390", VA = "0x18714D990")]
		public bool SetRingLayerSize(int NDBFPELDACP, float BKEGNEKBPFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x714D700", Offset = "0x714C100", VA = "0x18714D700", Slot = "12")]
		protected override void HPAFCBBBNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x714D580", Offset = "0x714BF80", VA = "0x18714D580", Slot = "13")]
		protected override void BJNIBPAANBN(Material OKNIOBAOHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x714D530", Offset = "0x714BF30", VA = "0x18714D530", Slot = "14")]
		protected override void BHEHKANHDHH(Material OKNIOBAOHHE, bool OPDIOPBPNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x714DBD0", Offset = "0x714C5D0", VA = "0x18714DBD0")]
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
		public enum FKKANNCINON
		{
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int NDKCLBOIHGN;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int GKNBJHJMJMJ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int AIAMPJIIMLC;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int HDJOMKGJPMC;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int FOGMHCMCFKG;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int KMHAHHEKKAA;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int HCDHNDDIJAP;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int OMDIIBDIBCD;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int JKNAGOFBHOO;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int EJNPDPMJAOG;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int HFCGAHNGPPL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int FOOKFIBOLFI;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int FLALPKHLAOM;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int HELJMMLCLMD;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int AJMPIFFDGCF;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int KBKAOIAMCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
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
		private FKKANNCINON animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[Tooltip("The animation speed of the primary rows / columns.")]
		[HJDMMFEIENC("AnimationDirection", new object[] { 1, 0 })]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[HJDMMFEIENC("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic PADCDNKMLDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool IOOALEIAHAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite BKFOFPDCENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x714ED10", Offset = "0x714D710", VA = "0x18714ED10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x714EF30", Offset = "0x714D930", VA = "0x18714EF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color JBGBDBFEODD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8C0BD0", Offset = "0x8BF5D0", VA = "0x1808C0BD0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x714EFC0", Offset = "0x714D9C0", VA = "0x18714EFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color ONFPPCPGKFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8D39A0", Offset = "0x8D23A0", VA = "0x1808D39A0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x714EE00", Offset = "0x714D800", VA = "0x18714EE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float BOFLCLECAIA
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8BC2F0", Offset = "0x8BACF0", VA = "0x1808BC2F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x714EEC0", Offset = "0x714D8C0", VA = "0x18714EEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 EPLOKAGIEOM
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x714ECF0", Offset = "0x714D6F0", VA = "0x18714ECF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x714EEE0", Offset = "0x714D8E0", VA = "0x18714EEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float DMLMLBJLCEP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8678E0", Offset = "0x8662E0", VA = "0x1808678E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x714EE80", Offset = "0x714D880", VA = "0x18714EE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 MMMNEFDGDGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC76DC0", Offset = "0xC757C0", VA = "0x180C76DC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x714F040", Offset = "0x714DA40", VA = "0x18714F040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float MMBOBOOOKGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8D3890", Offset = "0x8D2290", VA = "0x1808D3890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x714EDD0", Offset = "0x714D7D0", VA = "0x18714EDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 BGOLOEMJFED
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x714E8F0", Offset = "0x714D2F0", VA = "0x18714E8F0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public FKKANNCINON CFDFIFOELMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xC2A020", Offset = "0xC28A20", VA = "0x180C2A020")]
			get
			{
				return default(FKKANNCINON);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x714EDF0", Offset = "0x714D7F0", VA = "0x18714EDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float DBPGFGNKLAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD64B10", Offset = "0xD63510", VA = "0x180D64B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x714EEA0", Offset = "0x714D8A0", VA = "0x18714EEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float MDLEFHNMHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD64C60", Offset = "0xD63660", VA = "0x180D64C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x714EDB0", Offset = "0x714D7B0", VA = "0x18714EDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x714DF40", Offset = "0x714C940", VA = "0x18714DF40", Slot = "13")]
		protected override void BJNIBPAANBN(Material OKNIOBAOHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x714E640", Offset = "0x714D040", VA = "0x18714E640")]
		private void FFBOHHKPDJE(Sprite LDGNGNBIKKK, [Out] Vector2 GJKCBPKDMKK, [Out] Vector2 PFMGNICNGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x714DEF0", Offset = "0x714C8F0", VA = "0x18714DEF0", Slot = "14")]
		protected override void BHEHKANHDHH(Material OKNIOBAOHHE, bool OPDIOPBPNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x714EC60", Offset = "0x714D660", VA = "0x18714EC60")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static Shader JADNFKHOAKD;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader LFGOJNDOAEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x714F0E0", Offset = "0x714DAE0", VA = "0x18714F0E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x714F090", Offset = "0x714DA90", VA = "0x18714F090")]
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
		private SerializableRectTransform JLOODPBBKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool KJFGCDICBNI;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x71493A0", Offset = "0x7147DA0", VA = "0x1871493A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7149680", Offset = "0x7148080", VA = "0x187149680")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7149600", Offset = "0x7148000", VA = "0x187149600")]
		private void MBLMDPCFEPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7149530", Offset = "0x7147F30", VA = "0x187149530")]
		private void EMCCOPJBKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EOIDCGLAKDK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct MPGBKNAGCEK : IEquatable<MPGBKNAGCEK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Component NIDJKNBFFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Action HEPBMANJJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly int GDCNEIHEDHO;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component BKACDBHCMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4C0", Offset = "0x8BDEC0", VA = "0x1808BF4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7148E10", Offset = "0x7147810", VA = "0x187148E10")]
		public MPGBKNAGCEK(Component NIDJKNBFFJH, Action HEPBMANJJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7148D90", Offset = "0x7147790", VA = "0x187148D90")]
		public void GGDEKLHCCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7148D80", Offset = "0x7147780", VA = "0x187148D80", Slot = "4")]
		public bool Equals(MPGBKNAGCEK HENLEJBGFIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7148CF0", Offset = "0x71476F0", VA = "0x187148CF0", Slot = "0")]
		public override bool Equals(object GKHPLGCJCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x84C1A0", Offset = "0x84ABA0", VA = "0x18084C1A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class KNGCIPPNJFE : IEnumerator<IHLELHJPJMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IHLELHJPJMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public EOIDCGLAKDK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private IHLELHJPJMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x852730", Offset = "0x851130", VA = "0x180852730")]
		[DebuggerHidden]
		public KNGCIPPNJFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x71488E0", Offset = "0x71472E0", VA = "0x1871488E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7148CA0", Offset = "0x71476A0", VA = "0x187148CA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly EIOBABCCOKI MKIJEAJBOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int HABNCFBGHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int GACOMLLDKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Func<Component, float> BPCPAHMJCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<Component, MPGBKNAGCEK> GFMGPKEIJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly LinkedList<MPGBKNAGCEK> DHKMLFHCENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly List<MPGBKNAGCEK> BAPPFHEAIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JLKEMPIKEGF IPNCFAKBDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private FNKLLMIGJOJ CNIEHKOPEFF;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private FNKLLMIGJOJ AFEPGIIAGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7147070", Offset = "0x7145A70", VA = "0x187147070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7147520", Offset = "0x7145F20", VA = "0x187147520")]
	public EOIDCGLAKDK(EIOBABCCOKI MKIJEAJBOBD, int HABNCFBGHEM = -1, int GACOMLLDKGC = -1, [Optional] Func<Component, float> BPCPAHMJCDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7146D30", Offset = "0x7145730", VA = "0x187146D30")]
	public void DCJDFNLPFGM(Component NIDJKNBFFJH, Action IOFDICGCDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7147390", Offset = "0x7145D90", VA = "0x187147390")]
	public void PJJBOBAAINL(Component NIDJKNBFFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7147010", Offset = "0x7145A10", VA = "0x187147010")]
	public bool FNMFLDNJFKK(Component BHOOAGJPBFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7147160", Offset = "0x7145B60", VA = "0x187147160")]
	private void KPMHPNMNFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7146F90", Offset = "0x7145990", VA = "0x187146F90")]
	[IteratorStateMachine(typeof(KNGCIPPNJFE))]
	private IEnumerator<IHLELHJPJMK> EPBDGABECHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xAB1060", Offset = "0xAAFA60", VA = "0x180AB1060")]
	[CompilerGenerated]
	private void ILJFCNDDDFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x71470E0", Offset = "0x7145AE0", VA = "0x1871470E0")]
	[CompilerGenerated]
	private float ICKMBDJPEBJ(MPGBKNAGCEK IOFDICGCDDA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HDDKKMDIJOG
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	NBGMALAJKGI ILLEOCANBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool GMKJLFDPIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	FCOLMBOCIND<NBGMALAJKGI> DMECLCJBIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLEGEOFFKJJ(NBGMALAJKGI DALJKEGFIAE, bool EJLOPMIGIFK = false);
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
