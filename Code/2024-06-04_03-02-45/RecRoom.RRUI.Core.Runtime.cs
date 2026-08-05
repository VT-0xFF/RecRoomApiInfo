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
				[Cpp2IlInjected.Address(RVA = "0x70C2580", Offset = "0x70C0D80", VA = "0x1870C2580")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x70C25E0", Offset = "0x70C0DE0", VA = "0x1870C25E0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x70C2530", Offset = "0x70C0D30", VA = "0x1870C2530")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x70C2430", Offset = "0x70C0C30", VA = "0x1870C2430")]
			public void NFHMPDOIPPP(PointerEventData ELNGCNCHFGL, RectTransform OEEBLIJBAFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x70C21A0", Offset = "0x70C09A0", VA = "0x1870C21A0")]
			public void JPJFHMDMBBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x70C2070", Offset = "0x70C0870", VA = "0x1870C2070")]
			public void AMAHDMGGKJL(PointerEventData ELNGCNCHFGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x70C2150", Offset = "0x70C0950", VA = "0x1870C2150")]
			public void GKLDKDODCNJ(float HCCLCEBKNCO, RectTransform OEEBLIJBAFK, Vector3 KKDCNJKFOII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly EPMNOCMNENI<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly EPMNOCMNENI<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly EPMNOCMNENI<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly EPMNOCMNENI<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly EPMNOCMNENI<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly LFHDLKLNBFG PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData BCILDLKCOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool MDEOMMLBDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool MPFFGDFABCK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HIHMGHMAKCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8472E0", Offset = "0x845AE0", VA = "0x1808472E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x70C1830", Offset = "0x70C0030", VA = "0x1870C1830")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GKDDJLIADIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8474F0", Offset = "0x845CF0", VA = "0x1808474F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x70C1800", Offset = "0x70C0000", VA = "0x1870C1800")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70C1860", Offset = "0x70C0060", VA = "0x1870C1860")]
		private bool MKFNEJOAOAC(PointerEventData BNEKFHGOPID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70C1D30", Offset = "0x70C0530", VA = "0x1870C1D30", Slot = "5")]
		public void OnPointerDown(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70C1DF0", Offset = "0x70C05F0", VA = "0x1870C1DF0", Slot = "11")]
		public void OnPointerUp(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70C1BA0", Offset = "0x70C03A0", VA = "0x1870C1BA0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70C18E0", Offset = "0x70C00E0", VA = "0x1870C18E0", Slot = "7")]
		public void OnBeginDrag(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x70C19F0", Offset = "0x70C01F0", VA = "0x1870C19F0", Slot = "4")]
		public void OnDrag(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70C1AD0", Offset = "0x70C02D0", VA = "0x1870C1AD0", Slot = "8")]
		public void OnEndDrag(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x70C1D90", Offset = "0x70C0590", VA = "0x1870C1D90", Slot = "9")]
		public void OnPointerEnter(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x70C1DC0", Offset = "0x70C05C0", VA = "0x1870C1DC0", Slot = "10")]
		public void OnPointerExit(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x70C19B0", Offset = "0x70C01B0", VA = "0x1870C19B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70C1E50", Offset = "0x70C0650", VA = "0x1870C1E50")]
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
		private OptionData APEJBPBNEOG;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x70BCFE0", Offset = "0x70BB7E0", VA = "0x1870BCFE0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70BCEE0", Offset = "0x70BB6E0", VA = "0x1870BCEE0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x70BCE30", Offset = "0x70BB630", VA = "0x1870BCE30")]
		private void BJNEPEOOEHJ(GameObject JNEPJDMFDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x70BD2A0", Offset = "0x70BBAA0", VA = "0x1870BD2A0")]
		public void SetOptionsWithNoDefault(List<string> AHHBLMGMEGC, [Optional] string GPLMNKPDPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x70BD1B0", Offset = "0x70BB9B0", VA = "0x1870BD1B0")]
		public void SetOptionsWithNoDefault(List<OptionData> KBIBKNJKDBF, [Optional] string GPLMNKPDPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x70BD0E0", Offset = "0x70BB8E0", VA = "0x1870BD0E0", Slot = "42")]
		public override void OnPointerClick(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x843540", Offset = "0x841D40", VA = "0x180843540", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas MBMHMKLMJNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70BD4C0", Offset = "0x70BBCC0", VA = "0x1870BD4C0")]
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
		private sealed class EHFFIJKFHOH : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private PENLHNEFADH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
			[DebuggerHidden]
			public EHFFIJKFHOH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70BD510", Offset = "0x70BBD10", VA = "0x1870BD510", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x70BDA20", Offset = "0x70BC220", VA = "0x1870BDA20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[NOCFGPDPMKL(EEKFPEEGEKF.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly FLPNPIPMMNE<object> JAICNKKFFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool JOBCOIIAJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? GLMCIGJEEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? IOPFEMOGGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? BAJFHDLNGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool JLPODEGJLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool DGLCAHOKGMK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HNIDMKBPPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x70BE580", Offset = "0x70BCD80", VA = "0x1870BE580", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool PEJCAMGCHIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x70BE530", Offset = "0x70BCD30", VA = "0x1870BE530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HAOKJGIPFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88DDE0", Offset = "0x88C5E0", VA = "0x18088DDE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x70BE740", Offset = "0x70BCF40", VA = "0x1870BE740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GFOEDDGFHNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x70BE490", Offset = "0x70BCC90", VA = "0x1870BE490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x70BE6A0", Offset = "0x70BCEA0", VA = "0x1870BE6A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x70BE050", Offset = "0x70BC850", VA = "0x1870BE050")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x70BE270", Offset = "0x70BCA70", VA = "0x1870BE270")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70BE220", Offset = "0x70BCA20", VA = "0x1870BE220")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70BE210", Offset = "0x70BCA10", VA = "0x1870BE210")]
		public void Hide(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x70BE3F0", Offset = "0x70BCBF0", VA = "0x1870BE3F0")]
		public void Show(object OECMOOGGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x70BE300", Offset = "0x70BCB00", VA = "0x1870BE300")]
		public void Set(object OECMOOGGOOF, bool GDMOGAPIAPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x70BE0E0", Offset = "0x70BC8E0", VA = "0x1870BE0E0")]
		public void Clear(bool BDMBGKODJJO = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x70BDE80", Offset = "0x70BC680", VA = "0x1870BDE80")]
		private void APFCBHEHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x70BE150", Offset = "0x70BC950", VA = "0x1870BE150")]
		[IteratorStateMachine(typeof(EHFFIJKFHOH))]
		private IEnumerator<PENLHNEFADH> DLHELNEFHLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x70BE1D0", Offset = "0x70BC9D0", VA = "0x1870BE1D0", Slot = "5")]
		public virtual void DoHideOrShow(bool CNHEKNEPPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x70BE400", Offset = "0x70BCC00", VA = "0x1870BE400")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AJJCEPMKLEG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8E2F40", Offset = "0x8E1740", VA = "0x1808E2F40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84DAC0", Offset = "0x84C2C0", VA = "0x18084DAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> NIOLEDHNPCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x70BE8A0", Offset = "0x70BD0A0", VA = "0x1870BE8A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x70BEA00", Offset = "0x70BD200", VA = "0x1870BEA00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> OIAKIILACKL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x70BE950", Offset = "0x70BD150", VA = "0x1870BE950")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x70BEAB0", Offset = "0x70BD2B0", VA = "0x1870BEAB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70BE860", Offset = "0x70BD060", VA = "0x1870BE860", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x70BE880", Offset = "0x70BD080", VA = "0x1870BE880", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData BNEKFHGOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xDC5B80", Offset = "0xDC4380", VA = "0x180DC5B80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xDC5B80", Offset = "0xDC4380", VA = "0x180DC5B80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MLOHNMNDENH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MLPNLLJAFJP
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static BACPELMAHOD FIELGLHBMBI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BACPELMAHOD LCJJLFIGJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x70BEB60", Offset = "0x70BD360", VA = "0x1870BEB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static MLPNLLJAFJP KDNMOECIHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x70BEF20", Offset = "0x70BD720", VA = "0x1870BEF20")]
		get
		{
			return default(MLPNLLJAFJP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70BECF0", Offset = "0x70BD4F0", VA = "0x1870BECF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<MLPNLLJAFJP> BJKHHFDJMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x70BEE50", Offset = "0x70BD650", VA = "0x1870BEE50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x70BEC20", Offset = "0x70BD420", VA = "0x1870BEC20")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ACGBLNDJLOI : NOOHHNOFEEC, EMLMPPHEHPO, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FIPPODCNHJE<GameObject, int> EDCGMALBJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	NIICELDHKHK<GameObject, int, bool> DIDKKHAGBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	EPMNOCMNENI<bool> PNCIDCJOLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool NDEPCOFJNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float MPEFMIJJJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EPMNOCMNENI<float> HLJNBFNIIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LFHDLKLNBFG GCHMHLMGKKJ
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
	void SpawnLoadingPlaceholders(GameObject OFMCNHNFFAE);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PEJDBLFKJJN Spawn<T>(int BLIPMJJDBMC, IReadOnlyList<T> MLKNGAFFKGE, GameObject OFMCNHNFFAE);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PEJDBLFKJJN Spawn<T>(int BLIPMJJDBMC, IReadOnlyList<T> MLKNGAFFKGE, GameObject ILEGLBGENCP, Func<int, GameObject> ACKJMANPBON);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int JBDLDJOINOF, float GEBFAKJEBMP);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum LBPFPNPOFNH : byte
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
		private static readonly int KKAKFPGEILG;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<LBPFPNPOFNH, string> IOMHCGHCKKC;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int MJFLBPJFGKB = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int HEAOCCJFAOE;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int JNCHHEILIKM;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int HLBFJHPIFOH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int AJNFNCODMPE;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int IMPHLCOAOAE;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int LDBDIGMMDLF;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int HMJACAPIFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool LMNLAGIGICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool MAFNOFKLDEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Color[] PEFPJDFPINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private LBPFPNPOFNH type;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly LBPFPNPOFNH[] BAMNLPBJDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[BLIABGLLHHC("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly LBPFPNPOFNH[] NGFNHBDKPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[BLIABGLLHHC("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[BLIABGLLHHC("type", LBPFPNPOFNH.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Range(0f, 5f)]
		[BLIABGLLHHC("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic IFPMNGKIHMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool EPEPLGIJDKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient OKPMHIHAKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8473D0", Offset = "0x845BD0", VA = "0x1808473D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x70C1650", Offset = "0x70BFE50", VA = "0x1870C1650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public LBPFPNPOFNH LBCGEBEPPGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8E2370", Offset = "0x8E0B70", VA = "0x1808E2370")]
			get
			{
				return default(LBPFPNPOFNH);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x70C17D0", Offset = "0x70BFFD0", VA = "0x1870C17D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool FFBKLGCCMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x70C1000", Offset = "0x70BF800", VA = "0x1870C1000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 HMDCNOODKPO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x70C15C0", Offset = "0x70BFDC0", VA = "0x1870C15C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x70C1600", Offset = "0x70BFE00", VA = "0x1870C1600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool KDFKCAKLKJH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x70C10C0", Offset = "0x70BF8C0", VA = "0x1870C10C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 HIIKKDBGJAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x70C15E0", Offset = "0x70BFDE0", VA = "0x1870C15E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x70C1780", Offset = "0x70BFF80", VA = "0x1870C1780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float HEBHKPBCNKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8B2090", Offset = "0x8B0890", VA = "0x1808B2090")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x15669B0", Offset = "0x15651B0", VA = "0x1815669B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 DACLAOJPBFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x70C1070", Offset = "0x70BF870", VA = "0x1870C1070")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 AFOIEOHKBDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x70C0240", Offset = "0x70BEA40", VA = "0x1870C0240")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float AKEIFKKGJFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85DD10", Offset = "0x85C510", VA = "0x18085DD10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x70C17E0", Offset = "0x70BFFE0", VA = "0x1870C17E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70C0460", Offset = "0x70BEC60", VA = "0x1870C0460", Slot = "12")]
		protected override void FBINMNIFFFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70C02D0", Offset = "0x70BEAD0", VA = "0x1870C02D0")]
		private void EKHJDABDLLN(Color[] ELBFKCLDIFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x70C0600", Offset = "0x70BEE00", VA = "0x1870C0600", Slot = "13")]
		protected override void GLNCNFCNEFA(Material CLECAFFDEAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x70C0020", Offset = "0x70BE820", VA = "0x1870C0020", Slot = "14")]
		protected override void CJCBAGDPAAD(Material CLECAFFDEAA, bool JKFJGFGHFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x70C1510", Offset = "0x70BFD10", VA = "0x1870C1510")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly MNJMOMAFDFA KJPDBKDBKKI;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Sprite GIFJCGMEADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material HEDHDGKIECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Material PBIFKLGLNNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool GNFCLPMNPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool JOBCOIIAJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool ONMNAJLEKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool BHDMGJCFIFI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic IFPMNGKIHMF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader MNOOHBFFGHO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool EPEPLGIJDKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool CAKBEOMDPLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform OEEBLIJBAFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x70C2DC0", Offset = "0x70C15C0", VA = "0x1870C2DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect PLADGNCGEBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x70C2C20", Offset = "0x70C1420", VA = "0x1870C2C20")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite FIPNEABMBBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x70C32E0", Offset = "0x70C1AE0", VA = "0x1870C32E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x70C27D0", Offset = "0x70C0FD0", VA = "0x1870C27D0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x70C3610", Offset = "0x70C1E10", VA = "0x1870C3610", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x70C3910", Offset = "0x70C2110", VA = "0x1870C3910", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x70C37C0", Offset = "0x70C1FC0", VA = "0x1870C37C0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x70C3920", Offset = "0x70C2120", VA = "0x1870C3920")]
		private void PGGOGDAOCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x70C3170", Offset = "0x70C1970", VA = "0x1870C3170")]
		private void LBAELPLJOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x70C2D90", Offset = "0x70C1590", VA = "0x1870C2D90")]
		private void HPNEHIJINMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x70C2D40", Offset = "0x70C1540", VA = "0x1870C2D40")]
		private void HGIOGKLGMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x70C29C0", Offset = "0x70C11C0", VA = "0x1870C29C0")]
		protected void BFAGOHBONJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x70C34D0", Offset = "0x70C1CD0", VA = "0x1870C34D0")]
		private void NPIIABHICEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "12")]
		protected virtual void FBINMNIFFFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "13")]
		protected virtual void GLNCNFCNEFA(Material CLECAFFDEAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "14")]
		protected virtual void CJCBAGDPAAD(Material CLECAFFDEAA, bool JKFJGFGHFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x70C2E20", Offset = "0x70C1620", VA = "0x1870C2E20")]
		private void KIJKFDCDDGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
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
		private static readonly int GPGMEBOHIGO;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int AJCPFPBMCLI;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int IDIHBDGPKFK;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int PNJENGBGMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
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
		private Color[] PEFPJDFPINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private float[] BMJNKMAKEMK;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic IFPMNGKIHMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool CAKBEOMDPLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> LJFNLFKFLPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8474A0", Offset = "0x845CA0", VA = "0x1808474A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 HMDCNOODKPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x70C44C0", Offset = "0x70C2CC0", VA = "0x1870C44C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x70C44E0", Offset = "0x70C2CE0", VA = "0x1870C44E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x70C4190", Offset = "0x70C2990", VA = "0x1870C4190")]
		public void SetRingLayers(IReadOnlyList<RingLayer> LIJCNJOIANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x70C3F50", Offset = "0x70C2750", VA = "0x1870C3F50")]
		public bool SetRingLayerColor(int CKKMCLHJEBN, Color NLKAPPNAHLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x70C40A0", Offset = "0x70C28A0", VA = "0x1870C40A0")]
		public bool SetRingLayerSize(int CKKMCLHJEBN, float GGKCGCGFHKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x70C3CA0", Offset = "0x70C24A0", VA = "0x1870C3CA0", Slot = "12")]
		protected override void FBINMNIFFFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x70C3DE0", Offset = "0x70C25E0", VA = "0x1870C3DE0", Slot = "13")]
		protected override void GLNCNFCNEFA(Material CLECAFFDEAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x70C3C50", Offset = "0x70C2450", VA = "0x1870C3C50", Slot = "14")]
		protected override void CJCBAGDPAAD(Material CLECAFFDEAA, bool JKFJGFGHFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x70C42E0", Offset = "0x70C2AE0", VA = "0x1870C42E0")]
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
		public enum KHDFNHCDHKE
		{
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int PANIBMHDAFM;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int CNDNENEMNKE;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int DGLHEDNJEMJ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int KGIEMEHLAPC;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int MNFCKMENILJ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int PDCGKBNPFGO;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int PEEBFEJOEAF;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int LEODGCPPIGO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int DIAJLKIBOMM;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int KPKNFBFGFKB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int DMANGODGELH;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int OLDEEAHMODC;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int ECJENGCPJPP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int OAJFDHBCOBJ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int BPAIEBIINEH;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int DJKFJMPBJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
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
		private KHDFNHCDHKE animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[Tooltip("The animation speed of the primary rows / columns.")]
		[BLIABGLLHHC("AnimationDirection", new object[] { 1, 0 })]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[BLIABGLLHHC("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic IFPMNGKIHMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool CAKBEOMDPLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite CCKKAPLEMAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x70C52E0", Offset = "0x70C3AE0", VA = "0x1870C52E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x70C5500", Offset = "0x70C3D00", VA = "0x1870C5500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color LDDAGAEJKEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB00", Offset = "0x8B9300", VA = "0x1808BAB00")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x70C5590", Offset = "0x70C3D90", VA = "0x1870C5590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color IHGKCHNJOGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8C98C0", Offset = "0x8C80C0", VA = "0x1808C98C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x70C53D0", Offset = "0x70C3BD0", VA = "0x1870C53D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float HLDPJICFBGA
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8B20B0", Offset = "0x8B08B0", VA = "0x1808B20B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x70C5490", Offset = "0x70C3C90", VA = "0x1870C5490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 DFAOBNJGLMI
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x70C52C0", Offset = "0x70C3AC0", VA = "0x1870C52C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x70C54B0", Offset = "0x70C3CB0", VA = "0x1870C54B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float FHAALGCKALP
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x85D970", Offset = "0x85C170", VA = "0x18085D970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x70C5450", Offset = "0x70C3C50", VA = "0x1870C5450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 MEKKJOGKMHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC40CA0", Offset = "0xC3F4A0", VA = "0x180C40CA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x70C5610", Offset = "0x70C3E10", VA = "0x1870C5610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float BDDNENKDDJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8C97B0", Offset = "0x8C7FB0", VA = "0x1808C97B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x70C53A0", Offset = "0x70C3BA0", VA = "0x1870C53A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 ALDEBOLPMAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x70C4580", Offset = "0x70C2D80", VA = "0x1870C4580")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public KHDFNHCDHKE MNAILDDPLEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xBF3DD0", Offset = "0xBF25D0", VA = "0x180BF3DD0")]
			get
			{
				return default(KHDFNHCDHKE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x70C53C0", Offset = "0x70C3BC0", VA = "0x1870C53C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float MJFBBIJBEJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xD30E80", Offset = "0xD2F680", VA = "0x180D30E80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x70C5470", Offset = "0x70C3C70", VA = "0x1870C5470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float GLJACLGLMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xD30FD0", Offset = "0xD2F7D0", VA = "0x180D30FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x70C5380", Offset = "0x70C3B80", VA = "0x1870C5380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x70C4610", Offset = "0x70C2E10", VA = "0x1870C4610", Slot = "13")]
		protected override void GLNCNFCNEFA(Material CLECAFFDEAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x70C4CD0", Offset = "0x70C34D0", VA = "0x1870C4CD0")]
		private void GLNOHKHFHMD(Sprite BLGEHGKIFJN, [Out] Vector2 EBMJNKNKIPB, [Out] Vector2 COCGKGNBEIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x70C4530", Offset = "0x70C2D30", VA = "0x1870C4530", Slot = "14")]
		protected override void CJCBAGDPAAD(Material CLECAFFDEAA, bool JKFJGFGHFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x70C5230", Offset = "0x70C3A30", VA = "0x1870C5230")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static Shader HBPBGHAGFPK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader MNOOHBFFGHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x70C56B0", Offset = "0x70C3EB0", VA = "0x1870C56B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x70C5660", Offset = "0x70C3E60", VA = "0x1870C5660")]
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
		private SerializableRectTransform HMKJGOFAIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool FJKJPFMJPGN;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x70BFC30", Offset = "0x70BE430", VA = "0x1870BFC30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x70BFDC0", Offset = "0x70BE5C0", VA = "0x1870BFDC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x70BFED0", Offset = "0x70BE6D0", VA = "0x1870BFED0")]
		private void PGHPNDIFPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x70BFB60", Offset = "0x70BE360", VA = "0x1870BFB60")]
		private void APFCBHEHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MNJMOMAFDFA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct OIIJEHMLPBC : IEquatable<OIIJEHMLPBC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Component BHFMOMNKABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Action MPDFHNDLNLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly int KBGNAGJNPEL;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component DPNNEMHDGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B78D0", VA = "0x1808B90D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x70BFAF0", Offset = "0x70BE2F0", VA = "0x1870BFAF0")]
		public OIIJEHMLPBC(Component BHFMOMNKABO, Action MPDFHNDLNLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x70BFA70", Offset = "0x70BE270", VA = "0x1870BFA70")]
		public void HHNAPLDDAPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x70BF9D0", Offset = "0x70BE1D0", VA = "0x1870BF9D0", Slot = "4")]
		public bool Equals(OIIJEHMLPBC OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x70BF9E0", Offset = "0x70BE1E0", VA = "0x1870BF9E0", Slot = "0")]
		public override bool Equals(object GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class HHAOELHCFOP : IEnumerator<PENLHNEFADH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private PENLHNEFADH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public MNJMOMAFDFA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private PENLHNEFADH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public HHAOELHCFOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x70BDA70", Offset = "0x70BC270", VA = "0x1870BDA70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x70BDE30", Offset = "0x70BC630", VA = "0x1870BDE30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly FINOBCNAJBC LALGNGECBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int NAEPACJDODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int EKFJNAEODGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Func<Component, float> AHNPMOBNBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<Component, OIIJEHMLPBC> ABCHMMFAOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly LinkedList<OIIJEHMLPBC> NMJDDPPPNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly List<OIIJEHMLPBC> KCBHOFDBPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JLAFAKOGFMB MJOGBMAHDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private ALCFACDALIF FHKHHPKEMLE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private ALCFACDALIF JOEIFOCKFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x70BF550", Offset = "0x70BDD50", VA = "0x1870BF550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x70BF850", Offset = "0x70BE050", VA = "0x1870BF850")]
	public MNJMOMAFDFA(FINOBCNAJBC LALGNGECBIM, int NAEPACJDODN = -1, int EKFJNAEODGP = -1, [Optional] Func<Component, float> AHNPMOBNBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x70BF050", Offset = "0x70BD850", VA = "0x1870BF050")]
	public void DDLCAGGHNJH(Component BHFMOMNKABO, Action HPMMBJCHINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x70BF5C0", Offset = "0x70BDDC0", VA = "0x1870BF5C0")]
	public void NAFCNNPNPMN(Component BHFMOMNKABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x70BF4F0", Offset = "0x70BDCF0", VA = "0x1870BF4F0")]
	public bool KIJEIEMNDBB(Component KFMACDKHBNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x70BF2B0", Offset = "0x70BDAB0", VA = "0x1870BF2B0")]
	private void EGKIGPGNFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x70BF7D0", Offset = "0x70BDFD0", VA = "0x1870BF7D0")]
	[IteratorStateMachine(typeof(HHAOELHCFOP))]
	private IEnumerator<PENLHNEFADH> PDEOFFMDNFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA753F0", Offset = "0xA73BF0", VA = "0x180A753F0")]
	[CompilerGenerated]
	private void DHHODHHBKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x70BF750", Offset = "0x70BDF50", VA = "0x1870BF750")]
	[CompilerGenerated]
	private float PCJOELKBDFE(OIIJEHMLPBC HPMMBJCHINM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KILDCHCFPFK
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JJKHHALDDNJ AMIHCDLDDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool NBIODHNPKKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	EPMNOCMNENI<JJKHHALDDNJ> LIPFNBJJJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PIMOIHPOHNM(JJKHHALDDNJ IPMKONEFAMB, bool CGNJEEOLDDL = false);
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
