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
				[Cpp2IlInjected.Address(RVA = "0x64ADB70", Offset = "0x64AC370", VA = "0x1864ADB70")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x64ADBD0", Offset = "0x64AC3D0", VA = "0x1864ADBD0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x64ADAF0", Offset = "0x64AC2F0", VA = "0x1864ADAF0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x64AD8E0", Offset = "0x64AC0E0", VA = "0x1864AD8E0")]
			public void NNKBFDCNGJL(PointerEventData OENHJDLFBBB, RectTransform OCBPBELDGAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x64AD680", Offset = "0x64ABE80", VA = "0x1864AD680")]
			public void CBCIFBPLODG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x64AD7A0", Offset = "0x64ABFA0", VA = "0x1864AD7A0")]
			public void FDECJDKKGLA(PointerEventData OENHJDLFBBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x64AD890", Offset = "0x64AC090", VA = "0x1864AD890")]
			public void HKMBJLMLGJN(float HMNGICJCNCC, RectTransform OCBPBELDGAM, Vector3 GFAGIPAOELL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly global::CNOGLFLGNKP<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly global::CNOGLFLGNKP<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::CNOGLFLGNKP<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly IFEOEDLAFMF PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly UIHandleEventData LMMEHJFCPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool KBGKLFBJEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool GLKPBHDEHAF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OFPMDHEFIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xFBF0D0", Offset = "0xFBD8D0", VA = "0x180FBF0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x64ACE60", Offset = "0x64AB660", VA = "0x1864ACE60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CALAGOIIHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xFF9200", Offset = "0xFF7A00", VA = "0x180FF9200")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x64ACE90", Offset = "0x64AB690", VA = "0x1864ACE90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64ACEC0", Offset = "0x64AB6C0", VA = "0x1864ACEC0")]
		private bool OEJKEPHNGKC(PointerEventData HIGIGMBKOED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		public void OnPointerDown(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64AD230", Offset = "0x64ABA30", VA = "0x1864AD230", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64ACF40", Offset = "0x64AB740", VA = "0x1864ACF40", Slot = "7")]
		public void OnBeginDrag(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64AD060", Offset = "0x64AB860", VA = "0x1864AD060", Slot = "4")]
		public void OnDrag(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64AD150", Offset = "0x64AB950", VA = "0x1864AD150", Slot = "8")]
		public void OnEndDrag(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64AD4C0", Offset = "0x64ABCC0", VA = "0x1864AD4C0", Slot = "9")]
		public void OnPointerEnter(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64AD4F0", Offset = "0x64ABCF0", VA = "0x1864AD4F0", Slot = "10")]
		public void OnPointerExit(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64AD020", Offset = "0x64AB820", VA = "0x1864AD020")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64AD520", Offset = "0x64ABD20", VA = "0x1864AD520")]
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
		private OptionData EHFLMJJJNJE;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64A9210", Offset = "0x64A7A10", VA = "0x1864A9210", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x64A9100", Offset = "0x64A7900", VA = "0x1864A9100", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x64A9040", Offset = "0x64A7840", VA = "0x1864A9040")]
		private void FFCFNLCOJBN(GameObject FLDOIEGOEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x64A93F0", Offset = "0x64A7BF0", VA = "0x1864A93F0")]
		public void SetOptionsWithNoDefault(List<string> HIFHKLOJLMP, [Optional] string BCEBEAGNMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x64A9630", Offset = "0x64A7E30", VA = "0x1864A9630")]
		public void SetOptionsWithNoDefault(List<OptionData> LBOENCNHHLB, [Optional] string BCEBEAGNMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x64A9320", Offset = "0x64A7B20", VA = "0x1864A9320", Slot = "42")]
		public override void OnPointerClick(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC170", Offset = "0x6DA970", VA = "0x1806DC170", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas DMGDCPJCDGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x64A9720", Offset = "0x64A7F20", VA = "0x1864A9720")]
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
		private sealed class CAJOEKCJEID : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private MBIPJOOACNE <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
			[DebuggerHidden]
			public CAJOEKCJEID(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x64A8AE0", Offset = "0x64A72E0", VA = "0x1864A8AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x64A9000", Offset = "0x64A7800", VA = "0x1864A9000", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[PHJFDGPKCBM(OLIJGBPJKMJ.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly BGPIKFBGOJB GJBGAEANDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool JNDCHFCCHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Vector3? DJMKOOJGECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool? ELJIKAFNJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? LAODLFCOIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool MMPFLFHKHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool FNBONBOAIKG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HHJNJKNJMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x64A9F80", Offset = "0x64A8780", VA = "0x1864A9F80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ECMNEDMJIMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x64A9F60", Offset = "0x64A8760", VA = "0x1864A9F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool INHNIBPBOGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4D0", Offset = "0x9ADCD0", VA = "0x1809AF4D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x64AA150", Offset = "0x64A8950", VA = "0x1864AA150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NDILNEJMINC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x64A9EC0", Offset = "0x64A86C0", VA = "0x1864A9EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x64AA0B0", Offset = "0x64A88B0", VA = "0x1864AA0B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x64A9900", Offset = "0x64A8100", VA = "0x1864A9900")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x64A9C90", Offset = "0x64A8490", VA = "0x1864A9C90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x64A99E0", Offset = "0x64A81E0", VA = "0x1864A99E0")]
		public void Hide(object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x64A9DD0", Offset = "0x64A85D0", VA = "0x1864A9DD0")]
		public void Show(object JPCLKLIDFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x64A9D30", Offset = "0x64A8530", VA = "0x1864A9D30")]
		public void Set(object JPCLKLIDFBB, bool JAAEDJAPADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x64A9AD0", Offset = "0x64A82D0", VA = "0x1864A9AD0")]
		private void LNPEMMMGCPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x64A9A60", Offset = "0x64A8260", VA = "0x1864A9A60")]
		[IteratorStateMachine(typeof(CAJOEKCJEID))]
		private IEnumerator<MBIPJOOACNE> IMMHNOAHJEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x64A99A0", Offset = "0x64A81A0", VA = "0x1864A99A0", Slot = "5")]
		public virtual void DoHideOrShow(bool DENIPDEIHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x64A9E50", Offset = "0x64A8650", VA = "0x1864A9E50")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BJBMBIFLLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8D0", Offset = "0x6EE0D0", VA = "0x1806EF8D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x711000", Offset = "0x70F800", VA = "0x180711000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> OLEMHPFEJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x64AA340", Offset = "0x64A8B40", VA = "0x1864AA340")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x64AA480", Offset = "0x64A8C80", VA = "0x1864AA480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> GIKIAOAGFJI
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x64AA3E0", Offset = "0x64A8BE0", VA = "0x1864AA3E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x64AA520", Offset = "0x64A8D20", VA = "0x1864AA520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x64AA280", Offset = "0x64A8A80", VA = "0x1864AA280", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x64AA2E0", Offset = "0x64A8AE0", VA = "0x1864AA2E0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData HIGIGMBKOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D860", Offset = "0x1D8C060", VA = "0x181D8D860")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D860", Offset = "0x1D8C060", VA = "0x181D8D860")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BPBNFJELBCA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum HFBAIDBDHAB
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const HFBAIDBDHAB DADNMCILDOE = HFBAIDBDHAB.Light;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string MCOOPHIIKLN = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static GCIJEEDBMMC MOCCECHDEKM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static GCIJEEDBMMC BHIGNKJFEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x64A8700", Offset = "0x64A6F00", VA = "0x1864A8700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static HFBAIDBDHAB NOJPFBLAFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x64A8840", Offset = "0x64A7040", VA = "0x1864A8840")]
		get
		{
			return default(HFBAIDBDHAB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x64A8450", Offset = "0x64A6C50", VA = "0x1864A8450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<HFBAIDBDHAB> AOFNCMEGNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x64A8600", Offset = "0x64A6E00", VA = "0x1864A8600")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x64A89E0", Offset = "0x64A71E0", VA = "0x1864A89E0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FOGGGPOOAMO : LOIHPEADBOF, MAHJEPIJPLD, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	global::KPNCHACHCHE<GameObject, int> MEALDAMDAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	global::NLJCKAEHOJE<GameObject, int, bool> NIJPJOJAJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	global::CNOGLFLGNKP<bool> KHCNLKMGEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ECGDCKGCADF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float AHABPDODEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	global::CNOGLFLGNKP<float> GPKBJHKDJJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IFEOEDLAFMF ODCAADHLIHP
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
	void SpawnLoadingPlaceholders(GameObject ONIHIIPCKEF);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KKCOJBHLCCF Spawn<T>(int CKPAAAIJBKA, IReadOnlyList<T> LBEMEOBAAJI, GameObject ONIHIIPCKEF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KKCOJBHLCCF Spawn<T>(int CKPAAAIJBKA, IReadOnlyList<T> LBEMEOBAAJI, GameObject DHLFDIMDHOA, ref Func<int, GameObject> PFCJGNAGLFJ);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum KDPPEKFPCGM : byte
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
		private static readonly int GHMPMLBOOAE;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<KDPPEKFPCGM, string> PGPCFFHFBDA;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int BCGJBJBNLLM = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int KDDBJGMDJEN;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int JKMKBILEOMG;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int MAAANKBGHNG;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int BAAJHOAAIGI;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int LMNHJKBKGJJ;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int IBOPNGMHMBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool PPFMJKFDMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool LJDPLJBMHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] KEPINEHIKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private KDPPEKFPCGM type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly KDPPEKFPCGM[] IEBDMBGAICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[CPILAAFLPDK("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly KDPPEKFPCGM[] HAAAMDOINGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[CPILAAFLPDK("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[Range(0f, 360f)]
		[CPILAAFLPDK("type", (byte)4)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[CPILAAFLPDK("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic NGIDHEJMBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool MHIDJALPIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient IFILHCDKLDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6D50D0", Offset = "0x6D38D0", VA = "0x1806D50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x64ACCB0", Offset = "0x64AB4B0", VA = "0x1864ACCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KDPPEKFPCGM ECHKLFAEIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xFBF0D0", Offset = "0xFBD8D0", VA = "0x180FBF0D0")]
			get
			{
				return default(KDPPEKFPCGM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x64ACE30", Offset = "0x64AB630", VA = "0x1864ACE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool ACPJGIJPGFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x64AC720", Offset = "0x64AAF20", VA = "0x1864AC720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 ELHKBFLEJPF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x64ACC40", Offset = "0x64AB440", VA = "0x1864ACC40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x64ACC60", Offset = "0x64AB460", VA = "0x1864ACC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool LDBOAMIICOP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x64ABE30", Offset = "0x64AA630", VA = "0x1864ABE30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 DDNHBOFCIDM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x61FCFA0", Offset = "0x61FB7A0", VA = "0x1861FCFA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x64ACDE0", Offset = "0x64AB5E0", VA = "0x1864ACDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float HDPKMHJOJAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1714FD0", Offset = "0x17137D0", VA = "0x181714FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1715140", Offset = "0x1713940", VA = "0x181715140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 DMHJKAJNKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x64AB9B0", Offset = "0x64AA1B0", VA = "0x1864AB9B0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 JLAFCNPHJPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x64ABA00", Offset = "0x64AA200", VA = "0x1864ABA00")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float CKAJGKLNJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1652230", Offset = "0x1650A30", VA = "0x181652230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x64ACE40", Offset = "0x64AB640", VA = "0x1864ACE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x64ABA90", Offset = "0x64AA290", VA = "0x1864ABA90", Slot = "12")]
		protected override void CINEBLPFINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64AC5B0", Offset = "0x64AADB0", VA = "0x1864AC5B0")]
		private void MGDFLLCEGDN(Color[] COHDDIKPNJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64ABEB0", Offset = "0x64AA6B0", VA = "0x1864ABEB0", Slot = "13")]
		protected override void KKLBMELCHAC(Material IOFAEFNPIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64ABC10", Offset = "0x64AA410", VA = "0x1864ABC10", Slot = "14")]
		protected override void CJGFBHKFENH(Material IOFAEFNPIJK, bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x64ACB80", Offset = "0x64AB380", VA = "0x1864ACB80")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly KMKPCJANJPP BFDIJPPLBIP;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite JNFKAAINHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material HIDECLMOGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material PGCGJDKNDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool GNIENPMNICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool JNDCHFCCHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool INMOIJOLAJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool LAEJHGGCCAO;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic NGIDHEJMBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader LLLKODAOHHN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool MHIDJALPIBA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool BPDIOMEKKCM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform OCBPBELDGAM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x64AE560", Offset = "0x64ACD60", VA = "0x1864AE560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect DBGNFOLOAEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x64AE750", Offset = "0x64ACF50", VA = "0x1864AE750")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite ICNCNPPJKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x64AE000", Offset = "0x64AC800", VA = "0x1864AE000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x64ADCB0", Offset = "0x64AC4B0", VA = "0x1864ADCB0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x64AEC70", Offset = "0x64AD470", VA = "0x1864AEC70", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x64AEF90", Offset = "0x64AD790", VA = "0x1864AEF90", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64AEE20", Offset = "0x64AD620", VA = "0x1864AEE20", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x64AE880", Offset = "0x64AD080", VA = "0x1864AE880")]
		private void JPNGMDCPKIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x64ADEA0", Offset = "0x64AC6A0", VA = "0x1864ADEA0")]
		private void BICNMJKHONB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x64ADC80", Offset = "0x64AC480", VA = "0x1864ADC80")]
		private void AJMPFHKJBCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x64AE5C0", Offset = "0x64ACDC0", VA = "0x1864AE5C0")]
		private void GLFCNHMLJJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64AEA00", Offset = "0x64AD200", VA = "0x1864AEA00")]
		protected void JPOGMDABBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x64AE610", Offset = "0x64ACE10", VA = "0x1864AE610")]
		private void JBCNEMMGKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "12")]
		protected virtual void CINEBLPFINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "13")]
		protected virtual void KKLBMELCHAC(Material IOFAEFNPIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "14")]
		protected virtual void CJGFBHKFENH(Material IOFAEFNPIJK, bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x64AE1D0", Offset = "0x64AC9D0", VA = "0x1864AE1D0")]
		private void CDBMMKDNBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		[Conditional("RRUI_PROFILING")]
		protected void HFMMNFIJHLB(string MNPEFBDEFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0")]
		[Conditional("RRUI_PROFILING")]
		protected void CHCOADABEIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xE06850", Offset = "0xE05050", VA = "0x180E06850")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x213AA0", Offset = "0x212EA0")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly int IICGBELPJNK;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int CLJOGJIHBHN;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int MBCKLCFLFCI;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int ONOPJGIBAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
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
		private Color[] KEPINEHIKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] PDLPFMMGJMG;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic NGIDHEJMBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool BPDIOMEKKCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> OJBNKNMBNNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6DC570", Offset = "0x6DAD70", VA = "0x1806DC570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 ELHKBFLEJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x45C5750", Offset = "0x45C3F50", VA = "0x1845C5750")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x64AF970", Offset = "0x64AE170", VA = "0x1864AF970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x64AF670", Offset = "0x64ADE70", VA = "0x1864AF670")]
		public void SetRingLayers(IReadOnlyList<RingLayer> JCIAMAHJMPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64AF450", Offset = "0x64ADC50", VA = "0x1864AF450")]
		public bool SetRingLayerColor(int PHKNKFJOEKK, Color LCCPJBCAOGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x64AF560", Offset = "0x64ADD60", VA = "0x1864AF560")]
		public bool SetRingLayerSize(int PHKNKFJOEKK, float GIGKIGNPJAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x64AF110", Offset = "0x64AD910", VA = "0x1864AF110", Slot = "12")]
		protected override void CINEBLPFINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x64AF2D0", Offset = "0x64ADAD0", VA = "0x1864AF2D0", Slot = "13")]
		protected override void KKLBMELCHAC(Material IOFAEFNPIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64AF280", Offset = "0x64ADA80", VA = "0x1864AF280", Slot = "14")]
		protected override void CJGFBHKFENH(Material IOFAEFNPIJK, bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x64AF7C0", Offset = "0x64ADFC0", VA = "0x1864AF7C0")]
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
		public enum LLMNOICIDII
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int IENOPGOLPIB;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int FLAAJMCNLFP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int DEBMHFJLBPA;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int PLJICGOFDML;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int LFLPHHGECAN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int NPOALMDJIBJ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int EEDLKPOGPJK;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int BHHCEMJHOLH;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int CCKFELIAIPD;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int IEDFFDDOEEN;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int LPJDJPMKDJE;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int BIHEHEDHNED;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int EOFBOLNNKNB;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int PPPDNPLBJIB;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int KOHEMMGFDHC;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int HFFMKBPELDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[PMFJBMBMCHD(OLIJGBPJKMJ.Self, false, false, false)]
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
		private LLMNOICIDII animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[CPILAAFLPDK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[CPILAAFLPDK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic NGIDHEJMBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6EB6F0", Offset = "0x6E9EF0", VA = "0x1806EB6F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool BPDIOMEKKCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite GNBHIHLANKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x64B0740", Offset = "0x64AEF40", VA = "0x1864B0740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x64B0950", Offset = "0x64AF150", VA = "0x1864B0950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color KHHCGFBENNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x118F390", Offset = "0x118DB90", VA = "0x18118F390")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x64B09F0", Offset = "0x64AF1F0", VA = "0x1864B09F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color EOPDFIIDGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA3FD20", Offset = "0xA3E520", VA = "0x180A3FD20")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x64B0840", Offset = "0x64AF040", VA = "0x1864B0840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float GLLHKBABMHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xFE5310", Offset = "0xFE3B10", VA = "0x180FE5310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x64B08E0", Offset = "0x64AF0E0", VA = "0x1864B08E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 HHLJEIAPGCF
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1296700", Offset = "0x1294F00", VA = "0x181296700")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x64B0900", Offset = "0x64AF100", VA = "0x1864B0900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float HLAHIPMNHDH
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x243A1E0", Offset = "0x24389E0", VA = "0x18243A1E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x64B08A0", Offset = "0x64AF0A0", VA = "0x1864B08A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 BCGJLBPIPNI
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x2812800", Offset = "0x2811000", VA = "0x182812800")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x64B0A50", Offset = "0x64AF250", VA = "0x1864B0A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float MIIKCNAGAAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x18F4B00", Offset = "0x18F3300", VA = "0x1818F4B00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x64B0810", Offset = "0x64AF010", VA = "0x1864B0810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 KDCGGLNNIDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x64AFA10", Offset = "0x64AE210", VA = "0x1864AFA10")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public LLMNOICIDII JDAEFDGPEGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8FE5C0", Offset = "0x8FCDC0", VA = "0x1808FE5C0")]
			get
			{
				return default(LLMNOICIDII);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x64B0830", Offset = "0x64AF030", VA = "0x1864B0830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float EAMJCAIBGFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1316000", Offset = "0x1314800", VA = "0x181316000")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x64B08C0", Offset = "0x64AF0C0", VA = "0x1864B08C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float LAFLENKCDGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x12966B0", Offset = "0x1294EB0", VA = "0x1812966B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x64B07F0", Offset = "0x64AEFF0", VA = "0x1864B07F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x64AFD00", Offset = "0x64AE500", VA = "0x1864AFD00", Slot = "13")]
		protected override void KKLBMELCHAC(Material IOFAEFNPIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x64AFA80", Offset = "0x64AE280", VA = "0x1864AFA80")]
		private void HMPCLBOEJDA(Sprite IHDGAKGGNKB, out Vector2 FJAFHKDOBMN, out Vector2 MBKNJMDDMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x64AF9C0", Offset = "0x64AE1C0", VA = "0x1864AF9C0", Slot = "14")]
		protected override void CJGFBHKFENH(Material IOFAEFNPIJK, bool KEBPJDOCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64B06A0", Offset = "0x64AEEA0", VA = "0x1864B06A0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader EJCBHAMKHNB;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader LLLKODAOHHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x64B0B00", Offset = "0x64AF300", VA = "0x1864B0B00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x64B0AA0", Offset = "0x64AF2A0", VA = "0x1864B0AA0")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KMKPCJANJPP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct FAOPNDKIAFN : IEquatable<FAOPNDKIAFN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component CDBJCAAPIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action GKCCEPEDOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int MPFPFEAEIGI;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component EFNNBMNPNGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6D5000", Offset = "0x6D3800", VA = "0x1806D5000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64A98A0", Offset = "0x64A80A0", VA = "0x1864A98A0")]
		public FAOPNDKIAFN(Component CDBJCAAPIOD, Action GKCCEPEDOKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x64A9820", Offset = "0x64A8020", VA = "0x1864A9820")]
		public void JHECMGPLBMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x64A9780", Offset = "0x64A7F80", VA = "0x1864A9780", Slot = "4")]
		public bool Equals(FAOPNDKIAFN HAKPJJGEGOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x64A9790", Offset = "0x64A7F90", VA = "0x1864A9790", Slot = "0")]
		public override bool Equals(object BFHAMCLNCKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D5040", Offset = "0x6D3840", VA = "0x1806D5040", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class JICOLPFHLJB : IEnumerator<MBIPJOOACNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MBIPJOOACNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public KMKPCJANJPP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private MBIPJOOACNE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D9200", Offset = "0x6D7A00", VA = "0x1806D9200")]
		[DebuggerHidden]
		public JICOLPFHLJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6EEEB0", Offset = "0x6ED6B0", VA = "0x1806EEEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x64AA5C0", Offset = "0x64A8DC0", VA = "0x1864AA5C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x64AA8F0", Offset = "0x64A90F0", VA = "0x1864AA8F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int MKKEDHMKKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int EAICOCIFNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> PAGGOGIBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, FAOPNDKIAFN> PGBIHCPIBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<FAOPNDKIAFN> EIBNJDJJJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<FAOPNDKIAFN> MOOIDDBPHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private BGFJNOHFIGD PHFNOAHFBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private FCJLMEMHFPP JELMHIPBKMP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private FCJLMEMHFPP ILNBGLEPMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x64AA930", Offset = "0x64A9130", VA = "0x1864AA930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x64AB160", Offset = "0x64A9960", VA = "0x1864AB160")]
	public KMKPCJANJPP(BHIELCKBJMH.DEBLDMONPBH OLMBMIMFNAN, int MKKEDHMKKDF = -1, int EAICOCIFNPO = -1, [Optional] Func<Component, float> PAGGOGIBJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x64AAA10", Offset = "0x64A9210", VA = "0x1864AAA10")]
	public void FCODFMFCAKG(Component CDBJCAAPIOD, Action OGOLPAHMPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x64AAFD0", Offset = "0x64A97D0", VA = "0x1864AAFD0")]
	public void OOJEOBKJPOF(Component CDBJCAAPIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x64AAC80", Offset = "0x64A9480", VA = "0x1864AAC80")]
	public bool HKONPGLNHIP(Component DMKJFEIEPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x64AACE0", Offset = "0x64A94E0", VA = "0x1864AACE0")]
	private void JGJDPDPJDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x64AA9A0", Offset = "0x64A91A0", VA = "0x1864AA9A0")]
	[IteratorStateMachine(typeof(JICOLPFHLJB))]
	private IEnumerator<MBIPJOOACNE> ELLILBAGEHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x16E52F0", Offset = "0x16E3AF0", VA = "0x1816E52F0")]
	[CompilerGenerated]
	private void IJKLJHPFEEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x64AAF10", Offset = "0x64A9710", VA = "0x1864AAF10")]
	[CompilerGenerated]
	private float MJNNIMHJFJI(FAOPNDKIAFN OGOLPAHMPOE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface APCHAHBAKHI
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PFGPLINFOJE
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	LPMDOGDGCFP KCBIEBDACLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool LIDKLNHGMND
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	global::CNOGLFLGNKP<LPMDOGDGCFP> LHDCBHEEGII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANDLFFKOMPB(LPMDOGDGCFP KBMMIJHCAAE, bool PJMMBGIJIPA = false);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class PDJLMBMEBDL
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static byte[] MEBJOHCMOJE;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static int JLNKJPMHNDA;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static int JMCMMIDKHCA;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static BigInteger PCHDNPNKOJB;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public PDJLMBMEBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x64AB610", Offset = "0x64A9E10", VA = "0x1864AB610")]
	private static string FEOGEGMPIMJ(byte[] JBKIIGINOKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x64AB2C0", Offset = "0x64A9AC0", VA = "0x1864AB2C0")]
	public static string CIDKAEMCDOH(byte[] EBBNNMNMLOE, bool IGCCOAIPDPG)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
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
