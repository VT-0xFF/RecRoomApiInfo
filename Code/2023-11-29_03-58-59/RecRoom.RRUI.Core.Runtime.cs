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
				[Cpp2IlInjected.Address(RVA = "0x6461B30", Offset = "0x6460F30", VA = "0x186461B30")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6461B90", Offset = "0x6460F90", VA = "0x186461B90")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6461AE0", Offset = "0x6460EE0", VA = "0x186461AE0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6461750", Offset = "0x6460B50", VA = "0x186461750")]
			public void GBPAAOCOGGD(PointerEventData HBGFANECHIG, RectTransform FPNBOHJKKEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6461850", Offset = "0x6460C50", VA = "0x186461850")]
			public void GOGHFKBJEGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6461670", Offset = "0x6460A70", VA = "0x186461670")]
			public void GAPDHBHLOGJ(PointerEventData HBGFANECHIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6461620", Offset = "0x6460A20", VA = "0x186461620")]
			public void CMHIJOGJDLH(float IFECFFAPBGG, RectTransform FPNBOHJKKEK, Vector3 GOPGKDKAOFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly CFBCANLCDFG<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly CFBCANLCDFG<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly CFBCANLCDFG<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly CFBCANLCDFG<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly CFBCANLCDFG<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly FCJKIAIKOOM PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData BCPLALNDIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool MHPBPLMHBHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool CNFMJBCKHML;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IKFMCLKIMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x778430", Offset = "0x777830", VA = "0x180778430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6460E60", Offset = "0x6460260", VA = "0x186460E60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PMMDKHCFMJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x778460", Offset = "0x777860", VA = "0x180778460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6460DB0", Offset = "0x64601B0", VA = "0x186460DB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6460DE0", Offset = "0x64601E0", VA = "0x186460DE0")]
		private bool GOPENKIFABP(PointerEventData LHEBENHACBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x64612E0", Offset = "0x64606E0", VA = "0x1864612E0", Slot = "5")]
		public void OnPointerDown(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64613A0", Offset = "0x64607A0", VA = "0x1864613A0", Slot = "11")]
		public void OnPointerUp(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6461150", Offset = "0x6460550", VA = "0x186461150", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6460E90", Offset = "0x6460290", VA = "0x186460E90", Slot = "7")]
		public void OnBeginDrag(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6460FA0", Offset = "0x64603A0", VA = "0x186460FA0", Slot = "4")]
		public void OnDrag(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6461080", Offset = "0x6460480", VA = "0x186461080", Slot = "8")]
		public void OnEndDrag(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6461340", Offset = "0x6460740", VA = "0x186461340", Slot = "9")]
		public void OnPointerEnter(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6461370", Offset = "0x6460770", VA = "0x186461370", Slot = "10")]
		public void OnPointerExit(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6460F60", Offset = "0x6460360", VA = "0x186460F60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6461400", Offset = "0x6460800", VA = "0x186461400")]
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
		private OptionData EPDMPPAFKCL;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x645CD40", Offset = "0x645C140", VA = "0x18645CD40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x645CC40", Offset = "0x645C040", VA = "0x18645CC40", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x645CB90", Offset = "0x645BF90", VA = "0x18645CB90")]
		private void EIJAOKJMBHN(GameObject EBAMAEBPOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x645D000", Offset = "0x645C400", VA = "0x18645D000")]
		public void SetOptionsWithNoDefault(List<string> GDGKEEBHCBA, [Optional] string CHAIHJMMFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x645CF10", Offset = "0x645C310", VA = "0x18645CF10")]
		public void SetOptionsWithNoDefault(List<OptionData> AHMINIDFCHC, [Optional] string CHAIHJMMFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x645CE40", Offset = "0x645C240", VA = "0x18645CE40", Slot = "42")]
		public override void OnPointerClick(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x772DC0", Offset = "0x7721C0", VA = "0x180772DC0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas CCJIILBCAKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x645D230", Offset = "0x645C630", VA = "0x18645D230")]
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
		private sealed class NHIKPFGGAPE : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private EIIEDLICJGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
			[DebuggerHidden]
			public NHIKPFGGAPE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x645EF00", Offset = "0x645E300", VA = "0x18645EF00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x645F3F0", Offset = "0x645E7F0", VA = "0x18645F3F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[ABALMBEBCPA(BLCCKOBNIPN.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly EFHEONJKJKH GNECPDNKECH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool GFIOKBKIOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? LJADHMPDFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? INJFBPEOGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? KMIOPGHMNML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool CBOBIPIJGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool LMMGKBJINJF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GOGFHECODDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x645DA90", Offset = "0x645CE90", VA = "0x18645DA90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IFKOOPLIGHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x645DA70", Offset = "0x645CE70", VA = "0x18645DA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KLDLDPJNEFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xD278F0", Offset = "0xD26CF0", VA = "0x180D278F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x645DC40", Offset = "0x645D040", VA = "0x18645DC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EIPBCMCEHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x645D9D0", Offset = "0x645CDD0", VA = "0x18645D9D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x645DBA0", Offset = "0x645CFA0", VA = "0x18645DBA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x645D410", Offset = "0x645C810", VA = "0x18645D410")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x645D7A0", Offset = "0x645CBA0", VA = "0x18645D7A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x645D560", Offset = "0x645C960", VA = "0x18645D560")]
		public void Hide(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x645D8D0", Offset = "0x645CCD0", VA = "0x18645D8D0")]
		public void Show(object NOEAHPPKHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x645D830", Offset = "0x645CC30", VA = "0x18645D830")]
		public void Set(object NOEAHPPKHNC, bool ANLNHJHOEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x645D5E0", Offset = "0x645C9E0", VA = "0x18645D5E0")]
		private void KNJFPEJEGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x645D4A0", Offset = "0x645C8A0", VA = "0x18645D4A0")]
		[IteratorStateMachine(typeof(NHIKPFGGAPE))]
		private IEnumerator<EIIEDLICJGP> DGAJEICHJAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x645D520", Offset = "0x645C920", VA = "0x18645D520", Slot = "5")]
		public virtual void DoHideOrShow(bool NHJNEAPJEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x645D950", Offset = "0x645CD50", VA = "0x18645D950")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ACFKOBMINKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F2620", VA = "0x1807F3220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x77FF70", Offset = "0x77F370", VA = "0x18077FF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> OIGKFNKENJK
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x645DDA0", Offset = "0x645D1A0", VA = "0x18645DDA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x645DF00", Offset = "0x645D300", VA = "0x18645DF00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> APEMLPOHHNG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x645DE50", Offset = "0x645D250", VA = "0x18645DE50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x645DFB0", Offset = "0x645D3B0", VA = "0x18645DFB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x645DD60", Offset = "0x645D160", VA = "0x18645DD60", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x645DD80", Offset = "0x645D180", VA = "0x18645DD80", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData LHEBENHACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC408C0", Offset = "0xC3FCC0", VA = "0x180C408C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC408C0", Offset = "0xC3FCC0", VA = "0x180C408C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KPDFHKMMBEE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum CNGENODCMEN
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static OFEIPEOOHLH BFAHJHODKND;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static OFEIPEOOHLH GDLCHPNBBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x645E3D0", Offset = "0x645D7D0", VA = "0x18645E3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static CNGENODCMEN HLAELOLBEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x645E060", Offset = "0x645D460", VA = "0x18645E060")]
		get
		{
			return default(CNGENODCMEN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x645E270", Offset = "0x645D670", VA = "0x18645E270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<CNGENODCMEN> GLJDPOBDHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x645E4A0", Offset = "0x645D8A0", VA = "0x18645E4A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x645E190", Offset = "0x645D590", VA = "0x18645E190")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OLHCDFMLEAN : NNADGHNLDFK, MIKNNCKOFCD, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HHJEIKBAAJF<GameObject, int> KENPAHCKPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MKFPLDNDPJC<GameObject, int, bool> IDGKICOLPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CFBCANLCDFG<bool> JCPDCHMLODF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ENIDDAKGLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float JBICCINFCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	CFBCANLCDFG<float> EDIAGIKDGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FCJKIAIKOOM HIDIOFKFAFO
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
	void SpawnLoadingPlaceholders(GameObject EJNEOMHIMNM);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BLKLMCIOEEC Spawn<T>(int KGPNFPGACMA, IReadOnlyList<T> KKOACPFFAML, GameObject EJNEOMHIMNM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BLKLMCIOEEC Spawn<T>(int KGPNFPGACMA, IReadOnlyList<T> KKOACPFFAML, GameObject FCBHPBDKLNN, Func<int, GameObject> OGIEMMMNFIL);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int DIENMHDGFGP, float IHOADNDJPDH);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum FBKMFEFKNCO : byte
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
		private static readonly int DCMBFCCELCM;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<FBKMFEFKNCO, string> IHLPPCBHNLF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int PKFGHJNOALH = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int NPEBIKHDLDB;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int PMOEOOIDPAH;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int IDNKHLECNLI;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int FHCLAEGIMIF;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int GICBCFIHONP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int OCHOELLJMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool NPAODEGOALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool OFIEPPOKNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] PFHHHAGAGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private FBKMFEFKNCO type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly FBKMFEFKNCO[] CBFJLLFDAAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[EHJLCGPCADH("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly FBKMFEFKNCO[] NPLEOHNLAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[EHJLCGPCADH("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[EHJLCGPCADH("type", FBKMFEFKNCO.CustomDirection)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[EHJLCGPCADH("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic GECLOPONINL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool BGOKNLBMMFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient GFJEFGPOOCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x770B10", Offset = "0x76FF10", VA = "0x180770B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6460C00", Offset = "0x6460000", VA = "0x186460C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public FBKMFEFKNCO MELBEGGEDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAE65E0", Offset = "0xAE59E0", VA = "0x180AE65E0")]
			get
			{
				return default(FBKMFEFKNCO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6460D80", Offset = "0x6460180", VA = "0x186460D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool MGHDDAIFBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6460330", Offset = "0x645F730", VA = "0x186460330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 DFPMLNFPJBK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6460B90", Offset = "0x645FF90", VA = "0x186460B90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6460BB0", Offset = "0x645FFB0", VA = "0x186460BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool LPPNOODPCMO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x64602C0", Offset = "0x645F6C0", VA = "0x1864602C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 CMDODLFOPMG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1AD9A90", Offset = "0x1AD8E90", VA = "0x181AD9A90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6460D30", Offset = "0x6460130", VA = "0x186460D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float CJMKHAPDECM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x81A3B0", Offset = "0x8197B0", VA = "0x18081A3B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x12E81F0", Offset = "0x12E75F0", VA = "0x1812E81F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 AIDKDHGBIEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x645FFC0", Offset = "0x645F3C0", VA = "0x18645FFC0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 MONMKHLOHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6460010", Offset = "0x645F410", VA = "0x186460010")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float LOGKDCIJGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x78C6E0", Offset = "0x78BAE0", VA = "0x18078C6E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6460D90", Offset = "0x6460190", VA = "0x186460D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64603A0", Offset = "0x645F7A0", VA = "0x1864603A0", Slot = "12")]
		protected override void NIJDDJOCJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6460540", Offset = "0x645F940", VA = "0x186460540")]
		private void PGGAAJJNCFD(Color[] IEMDFKPJJOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x645F930", Offset = "0x645ED30", VA = "0x18645F930", Slot = "13")]
		protected override void ANPKKLJIHJN(Material OLONCOMGJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x64600A0", Offset = "0x645F4A0", VA = "0x1864600A0", Slot = "14")]
		protected override void IPKPPBBGBOB(Material OLONCOMGJHB, bool BFEPOIFAJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6460AE0", Offset = "0x645FEE0", VA = "0x186460AE0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly LJHFDNMMBDJ DGNOFOFNPEI;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite MIAODNHBPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material EKLNKAGFNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material NJHCJHNDDFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool PJABLFNDHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool GFIOKBKIOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool JHDBEOPHOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool FCKIIGIEEFD;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic GECLOPONINL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader NICCBAKCJDB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool BGOKNLBMMFC
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool BNLIIGOPNIM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7BA6E0", VA = "0x1807BB2E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform FPNBOHJKKEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6463020", Offset = "0x6462420", VA = "0x186463020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect MNKEFDEICGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x64629A0", Offset = "0x6461DA0", VA = "0x1864629A0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite LJKODDMAICF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6462AC0", Offset = "0x6461EC0", VA = "0x186462AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6461D80", Offset = "0x6461180", VA = "0x186461D80", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6462D10", Offset = "0x6462110", VA = "0x186462D10", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6463010", Offset = "0x6462410", VA = "0x186463010", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6462EC0", Offset = "0x64622C0", VA = "0x186462EC0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x64620B0", Offset = "0x64614B0", VA = "0x1864620B0")]
		private void FFKKPBCHPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6462590", Offset = "0x6461990", VA = "0x186462590")]
		private void HGFNMNCJGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6462970", Offset = "0x6461D70", VA = "0x186462970")]
		private void IDJPENPFFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6462CC0", Offset = "0x64620C0", VA = "0x186462CC0")]
		private void NDADFBDJCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6462700", Offset = "0x6461B00", VA = "0x186462700")]
		protected void HIEDJJKGHLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6461F70", Offset = "0x6461370", VA = "0x186461F70")]
		private void DODGNKGHGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "12")]
		protected virtual void NIJDDJOCJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "13")]
		protected virtual void ANPKKLJIHJN(Material OLONCOMGJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "14")]
		protected virtual void IPKPPBBGBOB(Material OLONCOMGJHB, bool BFEPOIFAJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6462240", Offset = "0x6461640", VA = "0x186462240")]
		private void FLKBAECMAGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
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
		private static readonly int OEHOENEOINC;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int LAFFABEOLDD;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int HAOLCJHHELP;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int NMADPKJMCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
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
		private Color[] PFHHHAGAGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] LEMKKCJMIAJ;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic GECLOPONINL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool BNLIIGOPNIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> FBAJBLFAHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x773AA0", Offset = "0x772EA0", VA = "0x180773AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 DFPMLNFPJBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6463B40", Offset = "0x6462F40", VA = "0x186463B40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6463B60", Offset = "0x6462F60", VA = "0x186463B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6463780", Offset = "0x6462B80", VA = "0x186463780")]
		public void SetRingLayers(IReadOnlyList<RingLayer> AOPAFIGKIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6463540", Offset = "0x6462940", VA = "0x186463540")]
		public bool SetRingLayerColor(int KLIMLCKINGF, Color DDJLPLIEHMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6463690", Offset = "0x6462A90", VA = "0x186463690")]
		public bool SetRingLayerSize(int KLIMLCKINGF, float PEGIIHFIAHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6463400", Offset = "0x6462800", VA = "0x186463400", Slot = "12")]
		protected override void NIJDDJOCJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6463230", Offset = "0x6462630", VA = "0x186463230", Slot = "13")]
		protected override void ANPKKLJIHJN(Material OLONCOMGJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x64633B0", Offset = "0x64627B0", VA = "0x1864633B0", Slot = "14")]
		protected override void IPKPPBBGBOB(Material OLONCOMGJHB, bool BFEPOIFAJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64638D0", Offset = "0x6462CD0", VA = "0x1864638D0")]
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
		public enum KEFOKPKHKPF
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int LJIFCKEFNFA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int LKJIFOGCFAC;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int DOGLLCOBHDC;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int ONJJBFAFDGD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int EBMCNAHCFAB;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int DCGHMLDCBKA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int BKHKDFMCMOD;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int BJCOJJEFOBC;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int FGDFOOCMGGE;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int OIDIIBNJIBK;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int MKLONPMCLMI;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int AHPCBAMGPJE;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int CHMBOLCPHGO;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int LFMBKPKPPFA;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int JECKOIDKCFI;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int LOEKKCDLJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[ECFGBFMBKFJ(BLCCKOBNIPN.Self, false, false, false)]
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
		private KEFOKPKHKPF animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[EHJLCGPCADH("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[EHJLCGPCADH("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic GECLOPONINL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool BNLIIGOPNIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite AGPNKMPINDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x64649B0", Offset = "0x6463DB0", VA = "0x1864649B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6464BD0", Offset = "0x6463FD0", VA = "0x186464BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color NCACOOLGDPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x949E20", Offset = "0x949220", VA = "0x180949E20")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6464C60", Offset = "0x6464060", VA = "0x186464C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color KFHPGBGDGCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1AE8E20", Offset = "0x1AE8220", VA = "0x181AE8E20")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6464AA0", Offset = "0x6463EA0", VA = "0x186464AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float OKHNOJEKFGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9B48F0", Offset = "0x9B3CF0", VA = "0x1809B48F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6464B60", Offset = "0x6463F60", VA = "0x186464B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 GDEDFAHFLDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1AD9AD0", Offset = "0x1AD8ED0", VA = "0x181AD9AD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6464B80", Offset = "0x6463F80", VA = "0x186464B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float ABGKMLNHNHP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x78C320", Offset = "0x78B720", VA = "0x18078C320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6464B20", Offset = "0x6463F20", VA = "0x186464B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 OAHHIKAGBMA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA488E0", Offset = "0xA47CE0", VA = "0x180A488E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6464CE0", Offset = "0x64640E0", VA = "0x186464CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float ODPJEDCPDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA50980", Offset = "0xA4FD80", VA = "0x180A50980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6464A70", Offset = "0x6463E70", VA = "0x186464A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 DEMMJMFMDHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6463BB0", Offset = "0x6462FB0", VA = "0x186463BB0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public KEFOKPKHKPF JLOLKLPICDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9FC970", Offset = "0x9FBD70", VA = "0x1809FC970")]
			get
			{
				return default(KEFOKPKHKPF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6464A90", Offset = "0x6463E90", VA = "0x186464A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float MPPMPHDMFJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xB381E0", Offset = "0xB375E0", VA = "0x180B381E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6464B40", Offset = "0x6463F40", VA = "0x186464B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float HKHBJPOIINL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB38330", Offset = "0xB37730", VA = "0x180B38330")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6464A50", Offset = "0x6463E50", VA = "0x186464A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6463C40", Offset = "0x6463040", VA = "0x186463C40", Slot = "13")]
		protected override void ANPKKLJIHJN(Material OLONCOMGJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6464340", Offset = "0x6463740", VA = "0x186464340")]
		private void FJHLIAJPMDJ(Sprite FFJJIKDMJKL, [Out] Vector2 KDBJOLLCIKJ, [Out] Vector2 JDKMLHLHMLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x64645F0", Offset = "0x64639F0", VA = "0x1864645F0", Slot = "14")]
		protected override void IPKPPBBGBOB(Material OLONCOMGJHB, bool BFEPOIFAJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6464920", Offset = "0x6463D20", VA = "0x186464920")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader GIEGNECILCK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader NICCBAKCJDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6464D80", Offset = "0x6464180", VA = "0x186464D80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6464D30", Offset = "0x6464130", VA = "0x186464D30")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LJHFDNMMBDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct EEONPLELFLC : IEquatable<EEONPLELFLC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component LAACBMJOJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action GBFDECNBKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int OGAKLKHFFCP;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component BDGEKLPBHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7DC940", Offset = "0x7DBD40", VA = "0x1807DC940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x645D3A0", Offset = "0x645C7A0", VA = "0x18645D3A0")]
		public EEONPLELFLC(Component LAACBMJOJOJ, Action GBFDECNBKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x645D320", Offset = "0x645C720", VA = "0x18645D320")]
		public void FHGLKLGOEFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x645D280", Offset = "0x645C680", VA = "0x18645D280", Slot = "4")]
		public bool Equals(EEONPLELFLC LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x645D290", Offset = "0x645C690", VA = "0x18645D290", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76F580", VA = "0x180770180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PMMPPNPEOIO : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public LJHFDNMMBDJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public PMMPPNPEOIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x645F440", Offset = "0x645E840", VA = "0x18645F440", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x645F800", Offset = "0x645EC00", VA = "0x18645F800", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CANKODDCPEJ KFALGGAKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int PGLBLHPFLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int FBDGPNFIOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> OEGIINGMJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, EEONPLELFLC> PJDABNMBKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<EEONPLELFLC> BDNLNNBDEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<EEONPLELFLC> EBHONMHAOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private BDOFDMHMNPK IDLNKKOIBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private MKEBMMDCPPL BDPOMOELBLP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private MKEBMMDCPPL HLDBBFIDHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x645EAB0", Offset = "0x645DEB0", VA = "0x18645EAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x645ED80", Offset = "0x645E180", VA = "0x18645ED80")]
	public LJHFDNMMBDJ(CANKODDCPEJ KFALGGAKOBE, int PGLBLHPFLMM = -1, int FBDGPNFIOOP = -1, [Optional] Func<Component, float> OEGIINGMJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x645EB20", Offset = "0x645DF20", VA = "0x18645EB20")]
	public void OBOBBFNADHM(Component LAACBMJOJOJ, Action NEDCHHMEEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x645E580", Offset = "0x645D980", VA = "0x18645E580")]
	public void AAFAHFKBBGI(Component LAACBMJOJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x645EA50", Offset = "0x645DE50", VA = "0x18645EA50")]
	public bool KKILNBCJKEF(Component AIKEEEBGAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x645E810", Offset = "0x645DC10", VA = "0x18645E810")]
	private void CKBNCAEOHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x645E790", Offset = "0x645DB90", VA = "0x18645E790")]
	[IteratorStateMachine(typeof(PMMPPNPEOIO))]
	private IEnumerator<EIIEDLICJGP> CDMBDABANEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8810B0", Offset = "0x8804B0", VA = "0x1808810B0")]
	[CompilerGenerated]
	private void CDGEGGCNDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x645E710", Offset = "0x645DB10", VA = "0x18645E710")]
	[CompilerGenerated]
	private float BOOKIKKOPBI(EEONPLELFLC NEDCHHMEEDK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IIOIEIINGDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	EHJCHDLGKEC MCFADODAOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool CPCKBNLDJCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	CFBCANLCDFG<EHJCHDLGKEC> ECJKIDJKIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGJPJIAPJJM(EHJCHDLGKEC PPONJFHAHMN, bool ICGKGIDFNCF = false);
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
