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
				[Cpp2IlInjected.Address(RVA = "0x67065E0", Offset = "0x67059E0", VA = "0x1867065E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6706640", Offset = "0x6705A40", VA = "0x186706640")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6706590", Offset = "0x6705990", VA = "0x186706590")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x67061B0", Offset = "0x67055B0", VA = "0x1867061B0")]
			public void CANHODLLMLO(PointerEventData AHLOLGPEMMG, RectTransform JEDIEGONOGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6706300", Offset = "0x6705700", VA = "0x186706300")]
			public void JIMIOCKOHGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x67060D0", Offset = "0x67054D0", VA = "0x1867060D0")]
			public void BNPGFJGCKHP(PointerEventData AHLOLGPEMMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x67062B0", Offset = "0x67056B0", VA = "0x1867062B0")]
			public void DJODHJLNLAA(float AGBHLNNLIIF, RectTransform JEDIEGONOGH, Vector3 IPLJDJCHMDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly EPDOKNAGJLN<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly EPDOKNAGJLN<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly EPDOKNAGJLN<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly EPDOKNAGJLN<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly EPDOKNAGJLN<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly DICJLHNIKOO PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData IIPDBHBIAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool EGDHHIBLNMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool DIMHPPFIPDH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CAFJGJKJOEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7A7D60", Offset = "0x7A7160", VA = "0x1807A7D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6705860", Offset = "0x6704C60", VA = "0x186705860")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool AJMPENGDIFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7A7C80", Offset = "0x7A7080", VA = "0x1807A7C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6705E80", Offset = "0x6705280", VA = "0x186705E80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6705890", Offset = "0x6704C90", VA = "0x186705890")]
		private bool EECKLNJAOHC(PointerEventData AAHHIKMPPAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6705D60", Offset = "0x6705160", VA = "0x186705D60", Slot = "5")]
		public void OnPointerDown(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6705E20", Offset = "0x6705220", VA = "0x186705E20", Slot = "11")]
		public void OnPointerUp(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6705BD0", Offset = "0x6704FD0", VA = "0x186705BD0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6705910", Offset = "0x6704D10", VA = "0x186705910", Slot = "7")]
		public void OnBeginDrag(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6705A20", Offset = "0x6704E20", VA = "0x186705A20", Slot = "4")]
		public void OnDrag(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6705B00", Offset = "0x6704F00", VA = "0x186705B00", Slot = "8")]
		public void OnEndDrag(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6705DC0", Offset = "0x67051C0", VA = "0x186705DC0", Slot = "9")]
		public void OnPointerEnter(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6705DF0", Offset = "0x67051F0", VA = "0x186705DF0", Slot = "10")]
		public void OnPointerExit(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67059E0", Offset = "0x6704DE0", VA = "0x1867059E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6705EB0", Offset = "0x67052B0", VA = "0x186705EB0")]
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
		private OptionData CPPBBONPOKE;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x67017F0", Offset = "0x6700BF0", VA = "0x1867017F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67016F0", Offset = "0x6700AF0", VA = "0x1867016F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6701640", Offset = "0x6700A40", VA = "0x186701640")]
		private void KECHELJOBAO(GameObject DAONFDGLLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6701AB0", Offset = "0x6700EB0", VA = "0x186701AB0")]
		public void SetOptionsWithNoDefault(List<string> KOOGKOFEACD, [Optional] string LMDKCKACCDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67019C0", Offset = "0x6700DC0", VA = "0x1867019C0")]
		public void SetOptionsWithNoDefault(List<OptionData> GGBINCNBHKJ, [Optional] string LMDKCKACCDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67018F0", Offset = "0x6700CF0", VA = "0x1867018F0", Slot = "42")]
		public override void OnPointerClick(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A0910", Offset = "0x79FD10", VA = "0x1807A0910", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas ALNJDCMILOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6701CE0", Offset = "0x67010E0", VA = "0x186701CE0")]
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
		private sealed class NLDHEHKHFJH : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private ALCMBHLDKFG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
			[DebuggerHidden]
			public NLDHEHKHFJH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6703DC0", Offset = "0x67031C0", VA = "0x186703DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x67042B0", Offset = "0x67036B0", VA = "0x1867042B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[DGHLDFIAAAN(PBLEKPGDGOG.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly JLFBFMMGKPJ ELPJFOLPEHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool KJJEFOJDOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? DEAEAHDAMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? NCFKKKPBGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? DGLJIANBKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool ENBHOONJJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool CHPMCKCMKDB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DGKIILPIAFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x67023B0", Offset = "0x67017B0", VA = "0x1867023B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KCHPFBCGFIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6702390", Offset = "0x6701790", VA = "0x186702390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ADMKELNOBNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7EA290", Offset = "0x7E9690", VA = "0x1807EA290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6702560", Offset = "0x6701960", VA = "0x186702560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KNHKKLPMMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x67022F0", Offset = "0x67016F0", VA = "0x1867022F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x67024C0", Offset = "0x67018C0", VA = "0x1867024C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6701D30", Offset = "0x6701130", VA = "0x186701D30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67020C0", Offset = "0x67014C0", VA = "0x1867020C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6702040", Offset = "0x6701440", VA = "0x186702040")]
		public void Hide(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67021F0", Offset = "0x67015F0", VA = "0x1867021F0")]
		public void Show(object BDHKJODLPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6702150", Offset = "0x6701550", VA = "0x186702150")]
		public void Set(object BDHKJODLPCL, bool HADFMLMKACB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6701DC0", Offset = "0x67011C0", VA = "0x186701DC0")]
		private void CJDIOEGOMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6701F80", Offset = "0x6701380", VA = "0x186701F80")]
		[IteratorStateMachine(typeof(NLDHEHKHFJH))]
		private IEnumerator<ALCMBHLDKFG> DGGHKEEGGHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6702000", Offset = "0x6701400", VA = "0x186702000", Slot = "5")]
		public virtual void DoHideOrShow(bool DHDKDBMKPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6702270", Offset = "0x6701670", VA = "0x186702270")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MPOBGIIKPBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x817E40", Offset = "0x817240", VA = "0x180817E40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7ACF80", Offset = "0x7AC380", VA = "0x1807ACF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> LEPEEGNLIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x67026C0", Offset = "0x6701AC0", VA = "0x1867026C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6702820", Offset = "0x6701C20", VA = "0x186702820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> IHMJJAHOFGN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6702770", Offset = "0x6701B70", VA = "0x186702770")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x67028D0", Offset = "0x6701CD0", VA = "0x1867028D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6702680", Offset = "0x6701A80", VA = "0x186702680", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x67026A0", Offset = "0x6701AA0", VA = "0x1867026A0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData AAHHIKMPPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC48AD0", Offset = "0xC47ED0", VA = "0x180C48AD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC48AD0", Offset = "0xC47ED0", VA = "0x180C48AD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KAMEIPGHPNB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum FABKBLPNDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static BBHDEBBJEDM OAEFHKAAGFG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BBHDEBBJEDM AGLOGELJDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6702DD0", Offset = "0x67021D0", VA = "0x186702DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static FABKBLPNDFJ KFACOJPPHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6702B40", Offset = "0x6701F40", VA = "0x186702B40")]
		get
		{
			return default(FABKBLPNDFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6702C70", Offset = "0x6702070", VA = "0x186702C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<FABKBLPNDFJ> DLOLGOJGGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6702980", Offset = "0x6701D80", VA = "0x186702980")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6702A60", Offset = "0x6701E60", VA = "0x186702A60")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FFMDGLHDJKK : EGOFFCKKGCE, DGOJJKLANGJ, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	BDNCPNIGOBB<GameObject, int> CLAJOONIAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	LJHNLLLDHAJ<GameObject, int, bool> IANCNKEIBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EPDOKNAGJLN<bool> CHCHOLPNLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool GAKHIFPDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float AGKAECJKIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EPDOKNAGJLN<float> LKPJFAJEEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DICJLHNIKOO OLKJODFEOKL
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
	void SpawnLoadingPlaceholders(GameObject GIMBJDMJFNN);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JJJCAKKGAHC Spawn<T>(int FPMDCCANDCP, IReadOnlyList<T> ALPLHOOHPEL, GameObject GIMBJDMJFNN);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JJJCAKKGAHC Spawn<T>(int FPMDCCANDCP, IReadOnlyList<T> ALPLHOOHPEL, GameObject CNPJPFDLHIG, Func<int, GameObject> LFGHHGPEOCC);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int AHDNEIKOMIB, float PKCMJLNKKEP);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum EAFLKEMNONF : byte
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
		private static readonly int LDIJDMDOHOA;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<EAFLKEMNONF, string> JKNFAHOEKKN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int AFANMCIOFPN = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int ICEBFOEJGEE;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int HDIKBOHPPFE;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int MFCMPAKIIHI;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int IKJGDACLDMB;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int HLJBEIDACMC;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int DCAAJACPDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool CAONKPOHDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool IIKEEFNLBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] MAEJHNDHAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private EAFLKEMNONF type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly EAFLKEMNONF[] CLEDFGEJBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[GBGGFNDIJGJ("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly EAFLKEMNONF[] GOMGECOJMFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[GBGGFNDIJGJ("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[GBGGFNDIJGJ("type", EAFLKEMNONF.CustomDirection)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[GBGGFNDIJGJ("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic JOCJHOPGEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KDDIJCIBOPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient LKCKMFGPCNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x79E7C0", Offset = "0x79DBC0", VA = "0x18079E7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x67056B0", Offset = "0x6704AB0", VA = "0x1867056B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public EAFLKEMNONF KEFOPLEGHIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCD3950", Offset = "0xCD2D50", VA = "0x180CD3950")]
			get
			{
				return default(EAFLKEMNONF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6705830", Offset = "0x6704C30", VA = "0x186705830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool JJIPAHJFMFC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x67043E0", Offset = "0x67037E0", VA = "0x1867043E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 OOKHHOCIIJK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6705640", Offset = "0x6704A40", VA = "0x186705640")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6705660", Offset = "0x6704A60", VA = "0x186705660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool LHCKMFKPIOE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6705110", Offset = "0x6704510", VA = "0x186705110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 LKFKAADKILH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1B48D10", Offset = "0x1B48110", VA = "0x181B48D10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x67057E0", Offset = "0x6704BE0", VA = "0x1867057E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float NGDHOKMAIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83E720", Offset = "0x83DB20", VA = "0x18083E720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x131E610", Offset = "0x131DA10", VA = "0x18131E610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 BIIENNHIILM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6704D10", Offset = "0x6704110", VA = "0x186704D10")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 ABDNBEBHIDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6704450", Offset = "0x6703850", VA = "0x186704450")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float EJANDMNHCCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7BA670", Offset = "0x7B9A70", VA = "0x1807BA670")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6705840", Offset = "0x6704C40", VA = "0x186705840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x67044E0", Offset = "0x67038E0", VA = "0x1867044E0", Slot = "12")]
		protected override void FCMKCGEIDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6704F80", Offset = "0x6704380", VA = "0x186704F80")]
		private void OJLKPMPFFMD(Color[] GFAPLNFBOKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6704680", Offset = "0x6703A80", VA = "0x186704680", Slot = "13")]
		protected override void GFFFAFENENH(Material LNKFECCMIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6704D60", Offset = "0x6704160", VA = "0x186704D60", Slot = "14")]
		protected override void KLKGKMPEBLF(Material LNKFECCMIIP, bool FAEFLPADKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6705590", Offset = "0x6704990", VA = "0x186705590")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly NCOGCDDGAGJ JGBDMLNAELI;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite GCIGGBHADLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material FOEHAFILGFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material KJGDDJKMEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool BPEJBMEMABG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool KJJEFOJDOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool GPMBKPJPNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool AHJOBABOEPF;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic JOCJHOPGEFL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader MINGLJALDBH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool KDDIJCIBOPP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool EIOOFMMKPDN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform JEDIEGONOGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6707080", Offset = "0x6706480", VA = "0x186707080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect HBCCCOEONGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6706B90", Offset = "0x6705F90", VA = "0x186706B90")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite PACJMKJLJLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x67077F0", Offset = "0x6706BF0", VA = "0x1867077F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6706830", Offset = "0x6705C30", VA = "0x186706830", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x67074E0", Offset = "0x67068E0", VA = "0x1867074E0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67077E0", Offset = "0x6706BE0", VA = "0x1867077E0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6707690", Offset = "0x6706A90", VA = "0x186707690", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x67070E0", Offset = "0x67064E0", VA = "0x1867070E0")]
		private void MPFNDMKGMJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6706A20", Offset = "0x6705E20", VA = "0x186706A20")]
		private void BIDBHPPAKPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6706D00", Offset = "0x6706100", VA = "0x186706D00")]
		private void GDPAEIKKLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6706CB0", Offset = "0x67060B0", VA = "0x186706CB0")]
		private void FAOGHMAEAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6707270", Offset = "0x6706670", VA = "0x186707270")]
		protected void NNKGBEOKLAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67079F0", Offset = "0x6706DF0", VA = "0x1867079F0")]
		private void PKEIONOFEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "12")]
		protected virtual void FCMKCGEIDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "13")]
		protected virtual void GFFFAFENENH(Material LNKFECCMIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "14")]
		protected virtual void KLKGKMPEBLF(Material LNKFECCMIIP, bool FAEFLPADKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6706D30", Offset = "0x6706130", VA = "0x186706D30")]
		private void IDEONCGIKJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
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
		private static readonly int EOGACOOHMIO;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int FAMIIBHBAIB;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int BIPCEDBLPNA;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int DBCFNKDONBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
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
		private Color[] MAEJHNDHAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] OOHDEFDMLPG;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic JOCJHOPGEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool EIOOFMMKPDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> FFICCBHAMFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 OOKHHOCIIJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x67085F0", Offset = "0x67079F0", VA = "0x1867085F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6708610", Offset = "0x6707A10", VA = "0x186708610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6708230", Offset = "0x6707630", VA = "0x186708230")]
		public void SetRingLayers(IReadOnlyList<RingLayer> KGFAHEJMFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6707FF0", Offset = "0x67073F0", VA = "0x186707FF0")]
		public bool SetRingLayerColor(int EDCBCPMMAFP, Color MNHFMCFPMMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6708140", Offset = "0x6707540", VA = "0x186708140")]
		public bool SetRingLayerSize(int EDCBCPMMAFP, float HFPFBPPBALK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6707CE0", Offset = "0x67070E0", VA = "0x186707CE0", Slot = "12")]
		protected override void FCMKCGEIDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6707E20", Offset = "0x6707220", VA = "0x186707E20", Slot = "13")]
		protected override void GFFFAFENENH(Material LNKFECCMIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6707FA0", Offset = "0x67073A0", VA = "0x186707FA0", Slot = "14")]
		protected override void KLKGKMPEBLF(Material LNKFECCMIIP, bool FAEFLPADKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6708380", Offset = "0x6707780", VA = "0x186708380")]
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
		public enum HKEMIADOPIO
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int CJLDEMIOAGG;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int MOGODOKLOMM;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int INFHADOMNNF;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int OOFNDFJLANA;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int GMBABCMMDOO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int ANGECPLEFNL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int HENLPELEDFE;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int IFBJOOKFCEE;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int FCEFDIOBLJP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int KHHJNICPHGM;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int INGLKKOJAMD;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int AGMEGNCLDHD;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int JHNCGPOACCB;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int KNNDHLOJKJP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int CNKNKDPJHOK;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int FGGCPHEKINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[CKNMEKOIECA(PBLEKPGDGOG.Self, false, false, false)]
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
		private HKEMIADOPIO animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[GBGGFNDIJGJ("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[GBGGFNDIJGJ("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic JOCJHOPGEFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool EIOOFMMKPDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite MGGGNHFNPPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6709460", Offset = "0x6708860", VA = "0x186709460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6709680", Offset = "0x6708A80", VA = "0x186709680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color FBCHCMJHDAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x988C00", Offset = "0x988000", VA = "0x180988C00")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6709710", Offset = "0x6708B10", VA = "0x186709710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color CKBGAGGGDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1B56830", Offset = "0x1B55C30", VA = "0x181B56830")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6709550", Offset = "0x6708950", VA = "0x186709550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float PEPPBCJOOAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9EEE60", Offset = "0x9EE260", VA = "0x1809EEE60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6709610", Offset = "0x6708A10", VA = "0x186709610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 NBGNBCEKLDB
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1B48D70", Offset = "0x1B48170", VA = "0x181B48D70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6709630", Offset = "0x6708A30", VA = "0x186709630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float NEINPBOIFAF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2B0", Offset = "0x7B96B0", VA = "0x1807BA2B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x67095D0", Offset = "0x67089D0", VA = "0x1867095D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 EMHPPLIOGNA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA672E0", Offset = "0xA666E0", VA = "0x180A672E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6709790", Offset = "0x6708B90", VA = "0x186709790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float PLEEJHGMFFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA6E820", Offset = "0xA6DC20", VA = "0x180A6E820")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6709520", Offset = "0x6708920", VA = "0x186709520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 CKHLGFFNEAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6708D60", Offset = "0x6708160", VA = "0x186708D60")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public HKEMIADOPIO NHAOFHLDOPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA1FB80", Offset = "0xA1EF80", VA = "0x180A1FB80")]
			get
			{
				return default(HKEMIADOPIO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6709540", Offset = "0x6708940", VA = "0x186709540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float FEDCANCFHJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xB57F90", Offset = "0xB57390", VA = "0x180B57F90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x67095F0", Offset = "0x67089F0", VA = "0x1867095F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float CLCJKIIJFCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB580E0", Offset = "0xB574E0", VA = "0x180B580E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6709500", Offset = "0x6708900", VA = "0x186709500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6708660", Offset = "0x6707A60", VA = "0x186708660", Slot = "13")]
		protected override void GFFFAFENENH(Material LNKFECCMIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6708E40", Offset = "0x6708240", VA = "0x186708E40")]
		private void PCJKGNGLJEP(Sprite NEPEFEKKEKG, [Out] Vector2 MEEPLIHPJHM, [Out] Vector2 KPAALHPAONH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6708DF0", Offset = "0x67081F0", VA = "0x186708DF0", Slot = "14")]
		protected override void KLKGKMPEBLF(Material LNKFECCMIIP, bool FAEFLPADKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x67093D0", Offset = "0x67087D0", VA = "0x1867093D0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader CMDGMFBEADI;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader MINGLJALDBH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6709830", Offset = "0x6708C30", VA = "0x186709830", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x67097E0", Offset = "0x6708BE0", VA = "0x1867097E0")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class NCOGCDDGAGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MIHCPKEILLE : IEquatable<MIHCPKEILLE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component HFPPGLCONIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action CDGBBEBMBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int MHEGOHBDKAC;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component MGADIJGPGDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x80C6F0", Offset = "0x80BAF0", VA = "0x18080C6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6702FC0", Offset = "0x67023C0", VA = "0x186702FC0")]
		public MIHCPKEILLE(Component HFPPGLCONIA, Action CDGBBEBMBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6702F40", Offset = "0x6702340", VA = "0x186702F40")]
		public void GPHODLAFDGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6702F30", Offset = "0x6702330", VA = "0x186702F30", Slot = "4")]
		public bool Equals(MIHCPKEILLE KMJGEHGGFFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6702EA0", Offset = "0x67022A0", VA = "0x186702EA0", Slot = "0")]
		public override bool Equals(object BHPOPDOKECN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x79E180", Offset = "0x79D580", VA = "0x18079E180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NIFJELNKCCP : IEnumerator<ALCMBHLDKFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ALCMBHLDKFG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NCOGCDDGAGJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private ALCMBHLDKFG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7AA540", Offset = "0x7A9940", VA = "0x1807AA540")]
		[DebuggerHidden]
		public NIFJELNKCCP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x67039B0", Offset = "0x6702DB0", VA = "0x1867039B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6703D70", Offset = "0x6703170", VA = "0x186703D70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly BBBNCPMDOIF FFNIICBEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int NGFHHDHGDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int OJHFHGHCBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> KECNLPEGIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, MIHCPKEILLE> BBEHGJLCNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<MIHCPKEILLE> GNAEOBOCIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<MIHCPKEILLE> MOOBODDCKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private ICANAFEODIJ KMGCIKDEGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private GEIJHFMNCJJ FEPHHDLKDDN;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private GEIJHFMNCJJ APGADBDOMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6703500", Offset = "0x6702900", VA = "0x186703500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6703830", Offset = "0x6702C30", VA = "0x186703830")]
	public NCOGCDDGAGJ(BBBNCPMDOIF FFNIICBEDFM, int NGFHHDHGDOL = -1, int OJHFHGHCBJO = -1, [Optional] Func<Component, float> KECNLPEGIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x67035D0", Offset = "0x67029D0", VA = "0x1867035D0")]
	public void MAHJGGOJPKO(Component HFPPGLCONIA, Action IFBJBEIJMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6703030", Offset = "0x6702430", VA = "0x186703030")]
	public void BCPOCHAFFIH(Component HFPPGLCONIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6703570", Offset = "0x6702970", VA = "0x186703570")]
	public bool KBFKPMPBLLE(Component LHKDOCKFFOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x67032C0", Offset = "0x67026C0", VA = "0x1867032C0")]
	private void EAAGMDNJIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x67031C0", Offset = "0x67025C0", VA = "0x1867031C0")]
	[IteratorStateMachine(typeof(NIFJELNKCCP))]
	private IEnumerator<ALCMBHLDKFG> CBKJICIJCPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8CB0E0", Offset = "0x8CA4E0", VA = "0x1808CB0E0")]
	[CompilerGenerated]
	private void FOOGBDGFAGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6703240", Offset = "0x6702640", VA = "0x186703240")]
	[CompilerGenerated]
	private float CIMOEKMAFAP(MIHCPKEILLE IFBJBEIJMMM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EHEKOLFFOEN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	ADDFECKMMHA ANJJCHCFGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool DMIJPFOFCMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	EPDOKNAGJLN<ADDFECKMMHA> NCELJFDGKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIJCBEODPFN(ADDFECKMMHA KOFDHMMEEOF, bool MHKPDNBIMIC = false);
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
