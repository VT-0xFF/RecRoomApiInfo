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
				[Cpp2IlInjected.Address(RVA = "0x71502A0", Offset = "0x714EEA0", VA = "0x1871502A0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x7150300", Offset = "0x714EF00", VA = "0x187150300")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7150250", Offset = "0x714EE50", VA = "0x187150250")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7150150", Offset = "0x714ED50", VA = "0x187150150")]
			public void NFOBFBBIFPH(PointerEventData CPAGEIFNBBO, RectTransform GLNJNALGJKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x714FE70", Offset = "0x714EA70", VA = "0x18714FE70")]
			public void HEKMHOMCHHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x714FD90", Offset = "0x714E990", VA = "0x18714FD90")]
			public void DFDFGLACOLF(PointerEventData CPAGEIFNBBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7150100", Offset = "0x714ED00", VA = "0x187150100")]
			public void KDDMMNCCOME(float BPODEKKILGO, RectTransform GLNJNALGJKM, Vector3 FKKCBKBCNEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly JFCBGCCGGGE<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JFCBGCCGGGE<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly JFCBGCCGGGE<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly JFCBGCCGGGE<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly JFCBGCCGGGE<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly DEHOLECDIJP PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData EFHLKHIOBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool GCDNOKAHDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool DFMEOECIBHP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NLDNGIKEOME
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x843200", Offset = "0x841E00", VA = "0x180843200")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x714F520", Offset = "0x714E120", VA = "0x18714F520")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NOCIHFNMHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8433C0", Offset = "0x841FC0", VA = "0x1808433C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x714F550", Offset = "0x714E150", VA = "0x18714F550")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x714F580", Offset = "0x714E180", VA = "0x18714F580")]
		private bool ILKMCDFAKAM(PointerEventData JFEELHKEMNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x714FA50", Offset = "0x714E650", VA = "0x18714FA50", Slot = "5")]
		public void OnPointerDown(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x714FB10", Offset = "0x714E710", VA = "0x18714FB10", Slot = "11")]
		public void OnPointerUp(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x714F8C0", Offset = "0x714E4C0", VA = "0x18714F8C0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x714F600", Offset = "0x714E200", VA = "0x18714F600", Slot = "7")]
		public void OnBeginDrag(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x714F710", Offset = "0x714E310", VA = "0x18714F710", Slot = "4")]
		public void OnDrag(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x714F7F0", Offset = "0x714E3F0", VA = "0x18714F7F0", Slot = "8")]
		public void OnEndDrag(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x714FAB0", Offset = "0x714E6B0", VA = "0x18714FAB0", Slot = "9")]
		public void OnPointerEnter(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x714FAE0", Offset = "0x714E6E0", VA = "0x18714FAE0", Slot = "10")]
		public void OnPointerExit(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x714F6D0", Offset = "0x714E2D0", VA = "0x18714F6D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x714FB70", Offset = "0x714E770", VA = "0x18714FB70")]
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
		private OptionData IAOGALJLFDH;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x714AC60", Offset = "0x7149860", VA = "0x18714AC60", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x714AB60", Offset = "0x7149760", VA = "0x18714AB60", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x714AAB0", Offset = "0x71496B0", VA = "0x18714AAB0")]
		private void KGBIPLBKOAD(GameObject CBACCKLAMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x714AF20", Offset = "0x7149B20", VA = "0x18714AF20")]
		public void SetOptionsWithNoDefault(List<string> DJGHJNNEKKN, [Optional] string JNHGGFBFLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x714AE30", Offset = "0x7149A30", VA = "0x18714AE30")]
		public void SetOptionsWithNoDefault(List<OptionData> MMOLNDGHCHC, [Optional] string JNHGGFBFLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x714AD60", Offset = "0x7149960", VA = "0x18714AD60", Slot = "42")]
		public override void OnPointerClick(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas DMHOAIBFIHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x714B150", Offset = "0x7149D50", VA = "0x18714B150")]
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
		private sealed class ELAGKHHPCJA : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private OGKGDFEHPGC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
			[DebuggerHidden]
			public ELAGKHHPCJA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x714B1A0", Offset = "0x7149DA0", VA = "0x18714B1A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x714B6B0", Offset = "0x714A2B0", VA = "0x18714B6B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[ENJEIGPOGID(LBBGAALIOCK.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly KHKCCGLBIJE<object> NLBMLHDMBEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool EAEJHGBMFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? BDMEKACCCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? JJLGCJPHMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? AGAKKFGMFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool FDHILBKOKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool OBPDIGECHBO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EPAHEFOFGGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x714C210", Offset = "0x714AE10", VA = "0x18714C210", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool CANDCFJGDJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x714C1C0", Offset = "0x714ADC0", VA = "0x18714C1C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DEGKHGIJNNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88E930", Offset = "0x88D530", VA = "0x18088E930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x714C3D0", Offset = "0x714AFD0", VA = "0x18714C3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PFHDNCEONNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x714C120", Offset = "0x714AD20", VA = "0x18714C120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x714C330", Offset = "0x714AF30", VA = "0x18714C330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x714BB10", Offset = "0x714A710", VA = "0x18714BB10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x714BF00", Offset = "0x714AB00", VA = "0x18714BF00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x714BEB0", Offset = "0x714AAB0", VA = "0x18714BEB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x714BE20", Offset = "0x714AA20", VA = "0x18714BE20")]
		public void Hide(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x714C080", Offset = "0x714AC80", VA = "0x18714C080")]
		public void Show(object FGIAGALCIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x714BF90", Offset = "0x714AB90", VA = "0x18714BF90")]
		public void Set(object FGIAGALCIAP, bool EFOOMJDEBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x714BD70", Offset = "0x714A970", VA = "0x18714BD70")]
		public void Clear(bool OJPMOKOPBKC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x714BBA0", Offset = "0x714A7A0", VA = "0x18714BBA0")]
		private void BMGHPIIJGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x714BE30", Offset = "0x714AA30", VA = "0x18714BE30")]
		[IteratorStateMachine(typeof(ELAGKHHPCJA))]
		private IEnumerator<OGKGDFEHPGC> IAEFLENIBBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x714BDE0", Offset = "0x714A9E0", VA = "0x18714BDE0", Slot = "5")]
		public virtual void DoHideOrShow(bool PGFHIOICKPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x714C090", Offset = "0x714AC90", VA = "0x18714C090")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EEIPADOICGF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x90BF40", Offset = "0x90AB40", VA = "0x18090BF40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x852F20", Offset = "0x851B20", VA = "0x180852F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> KLPPBKMEPLF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x714C530", Offset = "0x714B130", VA = "0x18714C530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x714C690", Offset = "0x714B290", VA = "0x18714C690")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> CCIGJEPKCCA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x714C5E0", Offset = "0x714B1E0", VA = "0x18714C5E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x714C740", Offset = "0x714B340", VA = "0x18714C740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x714C4F0", Offset = "0x714B0F0", VA = "0x18714C4F0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x714C510", Offset = "0x714B110", VA = "0x18714C510", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData JFEELHKEMNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE21A50", Offset = "0xE20650", VA = "0x180E21A50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE21A50", Offset = "0xE20650", VA = "0x180E21A50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NIIPHGLPLEK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum IHHFKHNJCFC
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static IAJFHEPFFKH BKIEOGFOOFH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static IAJFHEPFFKH JBAHJLHPMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x714D2F0", Offset = "0x714BEF0", VA = "0x18714D2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static IHHFKHNJCFC PPAPKPJFMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x714D3C0", Offset = "0x714BFC0", VA = "0x18714D3C0")]
		get
		{
			return default(IHHFKHNJCFC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x714D4F0", Offset = "0x714C0F0", VA = "0x18714D4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<IHHFKHNJCFC> DPALMCOKGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x714D730", Offset = "0x714C330", VA = "0x18714D730")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x714D650", Offset = "0x714C250", VA = "0x18714D650")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AFBOLMOPCIB : GDHGKPFFIDI, DKNKENMKCPN, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FFKNAOPGKON<GameObject, int> DPAPGLJENGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FLLHEFAEBCL<GameObject, int, bool> NFNPCHBEGLK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JFCBGCCGGGE<bool> OBGGMINFCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool FANLCLNLOID
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float LFOPCJDLHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JFCBGCCGGGE<float> BFFOFIIGFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DEHOLECDIJP PCFIPLNIGAL
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
	void SpawnLoadingPlaceholders(GameObject ICDGFAMNJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LKPPGGKMHON Spawn<T>(int HDEDIFHNKMA, IReadOnlyList<T> IMCLGJBJJKP, GameObject ICDGFAMNJCJ);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LKPPGGKMHON Spawn<T>(int HDEDIFHNKMA, IReadOnlyList<T> IMCLGJBJJKP, GameObject CLBLHHOEDAL, Func<int, GameObject> EOHNPJGKMLN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int OPDMGNJCACB, float DMAHENKLLEI);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum JGBJIPFONJD : byte
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
		private static readonly int NKDMLBLPMKM;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<JGBJIPFONJD, string> HADKBHPEAHB;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int EPALJBJGKAE = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int CGOLBGPJMBE;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int FBAKGCKNPGP;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int LBANAJJCAPM;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int PIACCLLMFEP;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int ABMENBOFOJA;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int FNGHBNIJIIL;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int HGCHJPMNAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool CEDKFLDAOOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool AACAKFFOIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Color[] IIPJPNCLJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private JGBJIPFONJD type;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly JGBJIPFONJD[] LDKPNADPNOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[GMAEJEFPPFN("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly JGBJIPFONJD[] CNCDKDOJNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[GMAEJEFPPFN("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[GMAEJEFPPFN("type", JGBJIPFONJD.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Range(0f, 5f)]
		[GMAEJEFPPFN("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic OFMCGIKKCBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KEDDPGACBEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient BADCGPDLDDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x714F370", Offset = "0x714DF70", VA = "0x18714F370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public JGBJIPFONJD AJCKJIKGPNK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x90B370", Offset = "0x909F70", VA = "0x18090B370")]
			get
			{
				return default(JGBJIPFONJD);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x714F4F0", Offset = "0x714E0F0", VA = "0x18714F4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool NJCEJLCIPMP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x714DCE0", Offset = "0x714C8E0", VA = "0x18714DCE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 JLBJEJBAMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x714F2E0", Offset = "0x714DEE0", VA = "0x18714F2E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x714F320", Offset = "0x714DF20", VA = "0x18714F320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool HIIEPPDAKLG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x714EBE0", Offset = "0x714D7E0", VA = "0x18714EBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 PCKIPKONONO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x714F300", Offset = "0x714DF00", VA = "0x18714F300")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x714F4A0", Offset = "0x714E0A0", VA = "0x18714F4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float JNFIHPEOHDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8B3960", Offset = "0x8B2560", VA = "0x1808B3960")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x159EA60", Offset = "0x159D660", VA = "0x18159EA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 JBBBCIJFKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x714EC50", Offset = "0x714D850", VA = "0x18714EC50")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 NIIHGBCNPFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x714E790", Offset = "0x714D390", VA = "0x18714E790")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float APIHOHJNFBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85E7D0", Offset = "0x85D3D0", VA = "0x18085E7D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x714F500", Offset = "0x714E100", VA = "0x18714F500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x714EA40", Offset = "0x714D640", VA = "0x18714EA40", Slot = "12")]
		protected override void IMEIHCIMFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x714ECA0", Offset = "0x714D8A0", VA = "0x18714ECA0")]
		private void OICIAJPKMDJ(Color[] GFHANHALMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x714DD50", Offset = "0x714C950", VA = "0x18714DD50", Slot = "13")]
		protected override void EMEBMGAECHM(Material MBCOMNNFJFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x714E820", Offset = "0x714D420", VA = "0x18714E820", Slot = "14")]
		protected override void IMCHENCEEOB(Material MBCOMNNFJFG, bool MPKDEMAOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x714F230", Offset = "0x714DE30", VA = "0x18714F230")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly NFLLPFDAMGC BMIFLJBDHMH;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Sprite APBICKMMHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material CBNENDPCGKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Material JGJJMCPJOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool HLAPMMHJPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool EAEJHGBMFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool LMABIPPFNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool ALMFECLIJFF;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic OFMCGIKKCBH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader BDJALCKHGNL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool KEDDPGACBEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool JMKOBPIPMGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform GLNJNALGJKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x7151790", Offset = "0x7150390", VA = "0x187151790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect PKDPPIHCICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7150C50", Offset = "0x714F850", VA = "0x187150C50")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite INHCLIPJCGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x71510F0", Offset = "0x714FCF0", VA = "0x1871510F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71504F0", Offset = "0x714F0F0", VA = "0x1871504F0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7151480", Offset = "0x7150080", VA = "0x187151480", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7151780", Offset = "0x7150380", VA = "0x187151780", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7151630", Offset = "0x7150230", VA = "0x187151630", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x71512F0", Offset = "0x714FEF0", VA = "0x1871512F0")]
		private void MLDKJIFJEKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7150820", Offset = "0x714F420", VA = "0x187150820")]
		private void CGLDIMELAPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x71510C0", Offset = "0x714FCC0", VA = "0x1871510C0")]
		private void HDMGGGCPJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7150C00", Offset = "0x714F800", VA = "0x187150C00")]
		private void GDFCCCIGGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7150990", Offset = "0x714F590", VA = "0x187150990")]
		protected void EGCAHFFIKBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x71506E0", Offset = "0x714F2E0", VA = "0x1871506E0")]
		private void BDGOJAJCOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "12")]
		protected virtual void IMEIHCIMFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "13")]
		protected virtual void EMEBMGAECHM(Material MBCOMNNFJFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "14")]
		protected virtual void IMCHENCEEOB(Material MBCOMNNFJFG, bool MPKDEMAOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7150D70", Offset = "0x714F970", VA = "0x187150D70")]
		private void HCJDKEOLKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
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
		private static readonly int LDJLABGECPO;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int DLAOONADADB;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int OFGNHGJMNNN;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int ALOMBEPCBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
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
		private Color[] IIPJPNCLJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private float[] BCCNJPGMFME;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic OFMCGIKKCBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool JMKOBPIPMGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> BBAABHJKGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 JLBJEJBAMPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x71522F0", Offset = "0x7150EF0", VA = "0x1871522F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x7152310", Offset = "0x7150F10", VA = "0x187152310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7151EF0", Offset = "0x7150AF0", VA = "0x187151EF0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> OPCHNBNGJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7151CB0", Offset = "0x71508B0", VA = "0x187151CB0")]
		public bool SetRingLayerColor(int IGOCEJPANBF, Color BFOBNFFGJIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7151E00", Offset = "0x7150A00", VA = "0x187151E00")]
		public bool SetRingLayerSize(int IGOCEJPANBF, float AEOJMEBJNPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7151B70", Offset = "0x7150770", VA = "0x187151B70", Slot = "12")]
		protected override void IMEIHCIMFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x71519A0", Offset = "0x71505A0", VA = "0x1871519A0", Slot = "13")]
		protected override void EMEBMGAECHM(Material MBCOMNNFJFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7151B20", Offset = "0x7150720", VA = "0x187151B20", Slot = "14")]
		protected override void IMCHENCEEOB(Material MBCOMNNFJFG, bool MPKDEMAOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7152040", Offset = "0x7150C40", VA = "0x187152040")]
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
		public enum DBGBNIDIOMA
		{
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int JBKEAMNFEFM;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int GDNHHIBFOBD;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int BBBJAAAKMHL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int JFMGDCLKGOI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int FABHJKJGPLB;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int PLIDGKOLPHN;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int CPLLPAGBPDC;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int MCOOMPLBBBL;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int JAFJLIMFHDL;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int JKOPGEHDECP;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int BAMCAJFGHOL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int IOEIOEOMEMN;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int NOFAGLFHLHI;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int OONCKDGEDJM;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int ABBICKMDJDG;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int EDPANKGLJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
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
		private DBGBNIDIOMA animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[Tooltip("The animation speed of the primary rows / columns.")]
		[GMAEJEFPPFN("AnimationDirection", new object[] { 1, 0 })]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[GMAEJEFPPFN("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic OFMCGIKKCBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool JMKOBPIPMGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite MMIHNFCOCBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7153180", Offset = "0x7151D80", VA = "0x187153180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x71533A0", Offset = "0x7151FA0", VA = "0x1871533A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color DKKNPPBDAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8B92F0", Offset = "0x8B7EF0", VA = "0x1808B92F0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7153430", Offset = "0x7152030", VA = "0x187153430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color HKPBABIILBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8CA8D0", Offset = "0x8C94D0", VA = "0x1808CA8D0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7153270", Offset = "0x7151E70", VA = "0x187153270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float MDGBPAELJPD
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8B3980", Offset = "0x8B2580", VA = "0x1808B3980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7153330", Offset = "0x7151F30", VA = "0x187153330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 AEJMINABEGK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7153160", Offset = "0x7151D60", VA = "0x187153160")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7153350", Offset = "0x7151F50", VA = "0x187153350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float OPIIJFJCLEC
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x85E430", Offset = "0x85D030", VA = "0x18085E430")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x71532F0", Offset = "0x7151EF0", VA = "0x1871532F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 GKJKJKAJCJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC6EE50", Offset = "0xC6DA50", VA = "0x180C6EE50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x71534B0", Offset = "0x71520B0", VA = "0x1871534B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float AFLKHAGILKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CA7C0", Offset = "0x8C93C0", VA = "0x1808CA7C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x7153240", Offset = "0x7151E40", VA = "0x187153240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 FLKBLMDKHOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7152D60", Offset = "0x7151960", VA = "0x187152D60")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public DBGBNIDIOMA DLAEILAGPBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xC225D0", Offset = "0xC211D0", VA = "0x180C225D0")]
			get
			{
				return default(DBGBNIDIOMA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7153260", Offset = "0x7151E60", VA = "0x187153260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float DPDNNKNEPGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD5FF10", Offset = "0xD5EB10", VA = "0x180D5FF10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7153310", Offset = "0x7151F10", VA = "0x187153310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float CEBAIBMODPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD60060", Offset = "0xD5EC60", VA = "0x180D60060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7153220", Offset = "0x7151E20", VA = "0x187153220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7152360", Offset = "0x7150F60", VA = "0x187152360", Slot = "13")]
		protected override void EMEBMGAECHM(Material MBCOMNNFJFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7152AB0", Offset = "0x71516B0", VA = "0x187152AB0")]
		private void OKDECBGGKIO(Sprite CDLBKMCBHGD, [Out] Vector2 BNGPJKMALFE, [Out] Vector2 LNMACFFFPLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7152A60", Offset = "0x7151660", VA = "0x187152A60", Slot = "14")]
		protected override void IMCHENCEEOB(Material MBCOMNNFJFG, bool MPKDEMAOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x71530D0", Offset = "0x7151CD0", VA = "0x1871530D0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static Shader GHKFBPIKPNI;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader BDJALCKHGNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x7153550", Offset = "0x7152150", VA = "0x187153550", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7153500", Offset = "0x7152100", VA = "0x187153500")]
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
		private SerializableRectTransform AOAOABPEDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool MNOMCKAKFPM;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x714D810", Offset = "0x714C410", VA = "0x18714D810")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x714DAF0", Offset = "0x714C6F0", VA = "0x18714DAF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x714DA70", Offset = "0x714C670", VA = "0x18714DA70")]
		private void JPAHJKJPLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x714D9A0", Offset = "0x714C5A0", VA = "0x18714D9A0")]
		private void BMGHPIIJGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NFLLPFDAMGC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct IDKHGBHCEHI : IEquatable<IDKHGBHCEHI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Component FBMKGECLCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Action DLNEFPHFKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly int HDMCPMGGLMK;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component HGBHIFLMBDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DB0", Offset = "0x8B39B0", VA = "0x1808B4DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x714C910", Offset = "0x714B510", VA = "0x18714C910")]
		public IDKHGBHCEHI(Component FBMKGECLCCA, Action DLNEFPHFKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x714C890", Offset = "0x714B490", VA = "0x18714C890")]
		public void FLADJOFCMKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x714C7F0", Offset = "0x714B3F0", VA = "0x18714C7F0", Slot = "4")]
		public bool Equals(IDKHGBHCEHI OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x714C800", Offset = "0x714B400", VA = "0x18714C800", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class GCEGAPPKNAE : IEnumerator<OGKGDFEHPGC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private OGKGDFEHPGC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public NFLLPFDAMGC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private OGKGDFEHPGC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
		[DebuggerHidden]
		public GCEGAPPKNAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x714B700", Offset = "0x714A300", VA = "0x18714B700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x714BAC0", Offset = "0x714A6C0", VA = "0x18714BAC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly HEAFJPMMKLL FHHHOJNINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int MHNBFOIDKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int HKDEAFOIFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Func<Component, float> LPKGOOIGLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<Component, IDKHGBHCEHI> CBPFPJAIIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly LinkedList<IDKHGBHCEHI> LOFHGFAMPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly List<IDKHGBHCEHI> GKLGIEECPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private GNHKJFLENJL PKHEEPGAOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private HMOKJHLIKIO EOHCCBHCGPD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private HMOKJHLIKIO IEABDLFPMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x714CDC0", Offset = "0x714B9C0", VA = "0x18714CDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x714D170", Offset = "0x714BD70", VA = "0x18714D170")]
	public NFLLPFDAMGC(HEAFJPMMKLL FHHHOJNINLN, int MHNBFOIDKEH = -1, int HKDEAFOIFGK = -1, [Optional] Func<Component, float> LPKGOOIGLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x714CE30", Offset = "0x714BA30", VA = "0x18714CE30")]
	public void FJAKJLJFHAC(Component FBMKGECLCCA, Action PIJDNDPDOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x714CC30", Offset = "0x714B830", VA = "0x18714CC30")]
	public void CHHMNPKLMPB(Component FBMKGECLCCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x714D110", Offset = "0x714BD10", VA = "0x18714D110")]
	public bool MILCDDEAILL(Component KDODEFMCLKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x714C980", Offset = "0x714B580", VA = "0x18714C980")]
	private void ABANMKPNGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x714CBB0", Offset = "0x714B7B0", VA = "0x18714CBB0")]
	[IteratorStateMachine(typeof(GCEGAPPKNAE))]
	private IEnumerator<OGKGDFEHPGC> BJEHBNJIJNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA9F230", Offset = "0xA9DE30", VA = "0x180A9F230")]
	[CompilerGenerated]
	private void KNIGJEFAPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x714D090", Offset = "0x714BC90", VA = "0x18714D090")]
	[CompilerGenerated]
	private float KEIMDENLOBG(IDKHGBHCEHI PIJDNDPDOCK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KAJHLCPAIBO
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KIJIKHGLHKA ALJPPEOHAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool KPLDFDMBCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	JFCBGCCGGGE<KIJIKHGLHKA> OAIGPDCGLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IDGHHGLFICC(KIJIKHGLHKA DMGLKDJCFFN, bool KKLOBNKMAJN = false);
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
