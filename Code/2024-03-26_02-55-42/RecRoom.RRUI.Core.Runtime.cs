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
				[Cpp2IlInjected.Address(RVA = "0x6992CB0", Offset = "0x69920B0", VA = "0x186992CB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x6992D10", Offset = "0x6992110", VA = "0x186992D10")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6992C60", Offset = "0x6992060", VA = "0x186992C60")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6992A30", Offset = "0x6991E30", VA = "0x186992A30")]
			public void NOIPBINEIAK(PointerEventData HJHFBDGLPML, RectTransform KFHKGPADKMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x69927A0", Offset = "0x6991BA0", VA = "0x1869927A0")]
			public void EJEIKBGLJHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6992B80", Offset = "0x6991F80", VA = "0x186992B80")]
			public void PHHEEONFHMF(PointerEventData HJHFBDGLPML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6992B30", Offset = "0x6991F30", VA = "0x186992B30")]
			public void PEBENHKLLPN(float GIKBHOBAENO, RectTransform KFHKGPADKMF, Vector3 LNCPBJIHNOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[GIMHEFLPFNM(FMDIPNBCKBB.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly JGNHMIKEILN<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JGNHMIKEILN<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly JGNHMIKEILN<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly JGNHMIKEILN<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly JGNHMIKEILN<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly DGHHAMKHKGM PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData PPIGIEIJOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool BLKGCICIOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool OFDKIPIPCJE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OFJEJIGBIND
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C8B50", Offset = "0x7C7F50", VA = "0x1807C8B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6991F60", Offset = "0x6991360", VA = "0x186991F60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DLMJIMHBPEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C8D00", Offset = "0x7C8100", VA = "0x1807C8D00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6991F30", Offset = "0x6991330", VA = "0x186991F30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6992500", Offset = "0x6991900", VA = "0x186992500")]
		private bool PIOCLPHPNMK(PointerEventData LMBNCDMECGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69923E0", Offset = "0x69917E0", VA = "0x1869923E0", Slot = "5")]
		public void OnPointerDown(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69924A0", Offset = "0x69918A0", VA = "0x1869924A0", Slot = "11")]
		public void OnPointerUp(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6992250", Offset = "0x6991650", VA = "0x186992250", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6991F90", Offset = "0x6991390", VA = "0x186991F90", Slot = "7")]
		public void OnBeginDrag(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69920A0", Offset = "0x69914A0", VA = "0x1869920A0", Slot = "4")]
		public void OnDrag(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6992180", Offset = "0x6991580", VA = "0x186992180", Slot = "8")]
		public void OnEndDrag(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6992440", Offset = "0x6991840", VA = "0x186992440", Slot = "9")]
		public void OnPointerEnter(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6992470", Offset = "0x6991870", VA = "0x186992470", Slot = "10")]
		public void OnPointerExit(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6992060", Offset = "0x6991460", VA = "0x186992060")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6992580", Offset = "0x6991980", VA = "0x186992580")]
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
		private OptionData AOALPCNLJJP;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x698F150", Offset = "0x698E550", VA = "0x18698F150", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x698F050", Offset = "0x698E450", VA = "0x18698F050", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x698EFA0", Offset = "0x698E3A0", VA = "0x18698EFA0")]
		private void MJJJGGFCGJD(GameObject OAHJEMLAFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x698F410", Offset = "0x698E810", VA = "0x18698F410")]
		public void SetOptionsWithNoDefault(List<string> JFCBPFNIMNJ, [Optional] string AKMMJBKADJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x698F320", Offset = "0x698E720", VA = "0x18698F320")]
		public void SetOptionsWithNoDefault(List<OptionData> ABKDMFHFFCD, [Optional] string AKMMJBKADJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x698F250", Offset = "0x698E650", VA = "0x18698F250", Slot = "42")]
		public override void OnPointerClick(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas EJLLGGBOKLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x698F640", Offset = "0x698EA40", VA = "0x18698F640")]
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
		private sealed class FJMBKMKBHLH : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private KIBBKCLDIIA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
			[DebuggerHidden]
			public FJMBKMKBHLH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x698F690", Offset = "0x698EA90", VA = "0x18698F690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x698FB80", Offset = "0x698EF80", VA = "0x18698FB80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[GIMHEFLPFNM(FMDIPNBCKBB.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[APNJDFGDCGH(FMDIPNBCKBB.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly LEPMAMFFPJF DPDPCFGJBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool LHEFADEFBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? DLPIHOLIPOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? EGJCOKPEEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? GDIDIJDCCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool CKEEBHDKDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool IAIPMJFGGNC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool LKBCLNGLLLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6990250", Offset = "0x698F650", VA = "0x186990250", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool FPHGCPJMMJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6990230", Offset = "0x698F630", VA = "0x186990230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GGKIGFACJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x808680", Offset = "0x807A80", VA = "0x180808680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6990400", Offset = "0x698F800", VA = "0x186990400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OIADFKJNMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6990190", Offset = "0x698F590", VA = "0x186990190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6990360", Offset = "0x698F760", VA = "0x186990360")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x698FBD0", Offset = "0x698EFD0", VA = "0x18698FBD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x698FF60", Offset = "0x698F360", VA = "0x18698FF60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x698FE60", Offset = "0x698F260", VA = "0x18698FE60")]
		public void Hide(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6990090", Offset = "0x698F490", VA = "0x186990090")]
		public void Show(object ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x698FFF0", Offset = "0x698F3F0", VA = "0x18698FFF0")]
		public void Set(object ICNJFMMNIKL, bool OBEOAHEFKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x698FCA0", Offset = "0x698F0A0", VA = "0x18698FCA0")]
		private void FBJNDCAAACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x698FEE0", Offset = "0x698F2E0", VA = "0x18698FEE0")]
		[IteratorStateMachine(typeof(FJMBKMKBHLH))]
		private IEnumerator<KIBBKCLDIIA> LLANGCLPKOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x698FC60", Offset = "0x698F060", VA = "0x18698FC60", Slot = "5")]
		public virtual void DoHideOrShow(bool KJHIJJEMKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6990110", Offset = "0x698F510", VA = "0x186990110")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GKIJGGKDMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x827D00", Offset = "0x827100", VA = "0x180827D00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7CBD20", Offset = "0x7CB120", VA = "0x1807CBD20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> CCJNEAJGLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6990560", Offset = "0x698F960", VA = "0x186990560")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x69906C0", Offset = "0x698FAC0", VA = "0x1869906C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> IALPLDDNNAO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6990610", Offset = "0x698FA10", VA = "0x186990610")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6990770", Offset = "0x698FB70", VA = "0x186990770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6990520", Offset = "0x698F920", VA = "0x186990520", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6990540", Offset = "0x698F940", VA = "0x186990540", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData LMBNCDMECGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xCA3D90", Offset = "0xCA3190", VA = "0x180CA3D90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCA3D90", Offset = "0xCA3190", VA = "0x180CA3D90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BFKDDBNCCHH
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum GECAKJOJFPP
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static CBMBIENNKDO NFKKEPGNIBE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static CBMBIENNKDO CNBEMDBONHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x698E140", Offset = "0x698D540", VA = "0x18698E140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static GECAKJOJFPP PGOGFPLIDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x698DCF0", Offset = "0x698D0F0", VA = "0x18698DCF0")]
		get
		{
			return default(GECAKJOJFPP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x698DF00", Offset = "0x698D300", VA = "0x18698DF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<GECAKJOJFPP> BKNLJHNLNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x698E060", Offset = "0x698D460", VA = "0x18698E060")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x698DE20", Offset = "0x698D220", VA = "0x18698DE20")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HCHBFOBOPCA : BFGEMIAFEPL, ABAOANAADMA, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CNCBMPDPOAH<GameObject, int> BBLECOGBCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	APBODAALHDH<GameObject, int, bool> CLIDDEHGIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JGNHMIKEILN<bool> EHJCNKMHFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OIFPCAJLGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float MGLFDGHCDCO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JGNHMIKEILN<float> FONPNANOPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	DGHHAMKHKGM AOFFACGOFIA
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
	void SpawnLoadingPlaceholders(GameObject DFNIHHFOHGC);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PNIFBLNEOAP Spawn<T>(int CGCBDELECAD, IReadOnlyList<T> FLKOGFDGJDF, GameObject DFNIHHFOHGC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PNIFBLNEOAP Spawn<T>(int CGCBDELECAD, IReadOnlyList<T> FLKOGFDGJDF, GameObject MECGMFAJHBG, Func<int, GameObject> NFMFLAMOEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int PMLKPJNGBAD, float LGIBHDKBEDE);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum DHBIHMMGIJN : byte
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
		private static readonly int EDKNLMOHNMP;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<DHBIHMMGIJN, string> IHLJICAIAAF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int OOKFJNBOLBF = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int DGCDAGOICIG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int CEAMOKJNGBG;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int KKLFMJAHBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int FIJHFKBGKMG;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int JCPGLFBGEAL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int KGMMDODAOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[GIMHEFLPFNM(FMDIPNBCKBB.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool IDJIFMKINLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool ABNCEPGOCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] MGJFCDLBDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private DHBIHMMGIJN type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly DHBIHMMGIJN[] PEIONPENAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[AEDBOPBHPPO("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly DHBIHMMGIJN[] CIFOPCGHMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[AEDBOPBHPPO("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[AEDBOPBHPPO("type", DHBIHMMGIJN.CustomDirection)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[AEDBOPBHPPO("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic JKMKLCHOAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HILGGPKPAJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient EMPJBJLDPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6991D80", Offset = "0x6991180", VA = "0x186991D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DHBIHMMGIJN HCHJICPCOMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x1064620", Offset = "0x1063A20", VA = "0x181064620")]
			get
			{
				return default(DHBIHMMGIJN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6991F00", Offset = "0x6991300", VA = "0x186991F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool NADKOIJDLDO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6990FA0", Offset = "0x69903A0", VA = "0x186990FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 IFMMKKAIADP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6991CF0", Offset = "0x69910F0", VA = "0x186991CF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6991D30", Offset = "0x6991130", VA = "0x186991D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool IGKNMGDEOND
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6990A90", Offset = "0x698FE90", VA = "0x186990A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 LDOPBPLJKKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6991D10", Offset = "0x6991110", VA = "0x186991D10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6991EB0", Offset = "0x69912B0", VA = "0x186991EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float DBOKEFPONEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8C6110", Offset = "0x8C5510", VA = "0x1808C6110")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x13EF370", Offset = "0x13EE770", VA = "0x1813EF370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 DOODENCPMBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6990D30", Offset = "0x6990130", VA = "0x186990D30")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 FGBIDCOLGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6990B00", Offset = "0x698FF00", VA = "0x186990B00")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float LGILBAAENCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E50", Offset = "0x7D8250", VA = "0x1807D8E50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6991F10", Offset = "0x6991310", VA = "0x186991F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6990B90", Offset = "0x698FF90", VA = "0x186990B90", Slot = "12")]
		protected override void DHDMEBJLMFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69916A0", Offset = "0x6990AA0", VA = "0x1869916A0")]
		private void OHKDAPIFGCA(Color[] BMGLKCMBNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6991010", Offset = "0x6990410", VA = "0x186991010", Slot = "13")]
		protected override void OFLNCFODBNB(Material GDFHEJJFPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6990D80", Offset = "0x6990180", VA = "0x186990D80", Slot = "14")]
		protected override void JAPKHFKHLMH(Material GDFHEJJFPNA, bool IAGGBJHFOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6991C40", Offset = "0x6991040", VA = "0x186991C40")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly CHEGFEFOENP EOMCPKHJIJK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite MCHPFOPNNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material OAKBHPHLGFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material OKMJMFMELFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool FANCEPEAFKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool LHEFADEFBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool FHOOAOMBILK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool IEHICBNIJFA;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic JKMKLCHOAAM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader OFGNBJOGECE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool HILGGPKPAJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool LGOAAILHHLO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform KFHKGPADKMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x69939B0", Offset = "0x6992DB0", VA = "0x1869939B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect NAEMMHPPJDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6993640", Offset = "0x6992A40", VA = "0x186993640")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite JACEFMNPBIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6993760", Offset = "0x6992B60", VA = "0x186993760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6992F00", Offset = "0x6992300", VA = "0x186992F00", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6993BA0", Offset = "0x6992FA0", VA = "0x186993BA0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6993EA0", Offset = "0x69932A0", VA = "0x186993EA0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6993D50", Offset = "0x6993150", VA = "0x186993D50", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6993A10", Offset = "0x6992E10", VA = "0x186993A10")]
		private void KPIBNCBFELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69934A0", Offset = "0x69928A0", VA = "0x1869934A0")]
		private void FEPANFHGEJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6993610", Offset = "0x6992A10", VA = "0x186993610")]
		private void GGGAOIPGMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6993960", Offset = "0x6992D60", VA = "0x186993960")]
		private void IHEJBCLIOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69930F0", Offset = "0x69924F0", VA = "0x1869930F0")]
		protected void CFABEJLECAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6993360", Offset = "0x6992760", VA = "0x186993360")]
		private void CGDDAEFGEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "12")]
		protected virtual void DHDMEBJLMFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "13")]
		protected virtual void OFLNCFODBNB(Material GDFHEJJFPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "14")]
		protected virtual void JAPKHFKHLMH(Material GDFHEJJFPNA, bool IAGGBJHFOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6993EB0", Offset = "0x69932B0", VA = "0x186993EB0")]
		private void PPJGEFMICAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
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
		private static readonly int BMLGPPGMOBP;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int ACOFNEIIFGJ;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int EBMBIOMHFGF;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int PBDIFMBPPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[GIMHEFLPFNM(FMDIPNBCKBB.Self, false, false, false)]
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
		private Color[] MGJFCDLBDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] NNGJMOEFJDM;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic JKMKLCHOAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool LGOAAILHHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> FPKJDBBPHBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 IFMMKKAIADP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6994CC0", Offset = "0x69940C0", VA = "0x186994CC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6994CE0", Offset = "0x69940E0", VA = "0x186994CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6994900", Offset = "0x6993D00", VA = "0x186994900")]
		public void SetRingLayers(IReadOnlyList<RingLayer> EOADABPJNAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69946C0", Offset = "0x6993AC0", VA = "0x1869946C0")]
		public bool SetRingLayerColor(int DFNBKLDEMIL, Color MAOKDDLICOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6994810", Offset = "0x6993C10", VA = "0x186994810")]
		public bool SetRingLayerSize(int DFNBKLDEMIL, float HIAJHKACHMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69943B0", Offset = "0x69937B0", VA = "0x1869943B0", Slot = "12")]
		protected override void DHDMEBJLMFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6994540", Offset = "0x6993940", VA = "0x186994540", Slot = "13")]
		protected override void OFLNCFODBNB(Material GDFHEJJFPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x69944F0", Offset = "0x69938F0", VA = "0x1869944F0", Slot = "14")]
		protected override void JAPKHFKHLMH(Material GDFHEJJFPNA, bool IAGGBJHFOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6994A50", Offset = "0x6993E50", VA = "0x186994A50")]
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
		public enum NNOKCGPNLPM
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int GNJFJJHJOFB;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int NKPMGMMDJKK;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int GJKDBKIJACM;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int FOFHPKLEPLC;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int OPBKHBKCCAG;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int LGBEJEEJBJE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int ACLBHEGPDAP;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int BCENIKMFPOH;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int KEBOIGJJEFA;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int IGMGBLAOKGE;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int LBKOCJHLAAF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int MPEKHONLOHB;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int CDKMBIIHHOE;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int ENFGHEFIBHG;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int AJLCGNOLCGC;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int KIDCGFNKAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[GIMHEFLPFNM(FMDIPNBCKBB.Self, false, false, false)]
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
		private NNOKCGPNLPM animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[AEDBOPBHPPO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[AEDBOPBHPPO("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic JKMKLCHOAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool LGOAAILHHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A80", Offset = "0x7D7E80", VA = "0x1807D8A80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite CHBAEIPHLBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6995B50", Offset = "0x6994F50", VA = "0x186995B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6995D70", Offset = "0x6995170", VA = "0x186995D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color HBCFAGKEHIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA1C0E0", Offset = "0xA1B4E0", VA = "0x180A1C0E0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6995E00", Offset = "0x6995200", VA = "0x186995E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color AMNDMBEBDGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1C4DC30", Offset = "0x1C4D030", VA = "0x181C4DC30")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6995C40", Offset = "0x6995040", VA = "0x186995C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float HIHGIKCHAKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA7AF00", Offset = "0xA7A300", VA = "0x180A7AF00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6995D00", Offset = "0x6995100", VA = "0x186995D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 DKDLAGDJLDD
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x6995B30", Offset = "0x6994F30", VA = "0x186995B30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x6995D20", Offset = "0x6995120", VA = "0x186995D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float JDFFMJCEGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A90", Offset = "0x7D7E90", VA = "0x1807D8A90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6995CC0", Offset = "0x69950C0", VA = "0x186995CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 PKNJJHPMKDH
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xB2DEF0", Offset = "0xB2D2F0", VA = "0x180B2DEF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6995E80", Offset = "0x6995280", VA = "0x186995E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float DKDEJMJOJPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xB35AD0", Offset = "0xB34ED0", VA = "0x180B35AD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6995C10", Offset = "0x6995010", VA = "0x186995C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 EGNJLKEJGAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6994D30", Offset = "0x6994130", VA = "0x186994D30")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NNOKCGPNLPM IIBHEIPODHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAE2390", Offset = "0xAE1790", VA = "0x180AE2390")]
			get
			{
				return default(NNOKCGPNLPM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6995C30", Offset = "0x6995030", VA = "0x186995C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float FKOMLMPIAOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xBF3690", Offset = "0xBF2A90", VA = "0x180BF3690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6995CE0", Offset = "0x69950E0", VA = "0x186995CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float PJGBINEKDLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xBF37E0", Offset = "0xBF2BE0", VA = "0x180BF37E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6995BF0", Offset = "0x6994FF0", VA = "0x186995BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69950C0", Offset = "0x69944C0", VA = "0x1869950C0", Slot = "13")]
		protected override void OFLNCFODBNB(Material GDFHEJJFPNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6994E10", Offset = "0x6994210", VA = "0x186994E10")]
		private void OCAJNHKJIMD(Sprite JJNHOPOFAPP, [Out] Vector2 MJFKHHMFDLE, [Out] Vector2 AFEBGCFGKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6994DC0", Offset = "0x69941C0", VA = "0x186994DC0", Slot = "14")]
		protected override void JAPKHFKHLMH(Material GDFHEJJFPNA, bool IAGGBJHFOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6995AA0", Offset = "0x6994EA0", VA = "0x186995AA0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader NECFPEKPACK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader OFGNBJOGECE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6995F20", Offset = "0x6995320", VA = "0x186995F20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6995ED0", Offset = "0x69952D0", VA = "0x186995ED0")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CHEGFEFOENP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct IDNLMJNFPAK : IEquatable<IDNLMJNFPAK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component APOKKKDAFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action MIJDPIABAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int IHALHMDPAKM;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component NOIIGDPCIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6990940", Offset = "0x698FD40", VA = "0x186990940")]
		public IDNLMJNFPAK(Component APOKKKDAFKO, Action MIJDPIABAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69908C0", Offset = "0x698FCC0", VA = "0x1869908C0")]
		public void HCIKHOJIPGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69908B0", Offset = "0x698FCB0", VA = "0x1869908B0", Slot = "4")]
		public bool Equals(IDNLMJNFPAK MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6990820", Offset = "0x698FC20", VA = "0x186990820", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class DDGDIGKCIDF : IEnumerator<KIBBKCLDIIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KIBBKCLDIIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public CHEGFEFOENP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private KIBBKCLDIIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public DDGDIGKCIDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x698EB90", Offset = "0x698DF90", VA = "0x18698EB90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x698EF50", Offset = "0x698E350", VA = "0x18698EF50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IMBICBGFIPB PIOLGBHJEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int FJICMGOJLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int KLCELKLBNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> JCKCOLHKLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, IDNLMJNFPAK> CJDANEJOEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<IDNLMJNFPAK> KPDANJIJBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<IDNLMJNFPAK> CIBFCHGGBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private ELCBICMGPAO OCNMCNAPHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private JHBPANDKFFL IDCOJIPELIL;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private JHBPANDKFFL JOLHNFKIOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x698E9A0", Offset = "0x698DDA0", VA = "0x18698E9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x698EA10", Offset = "0x698DE10", VA = "0x18698EA10")]
	public CHEGFEFOENP(IMBICBGFIPB PIOLGBHJEID, int FJICMGOJLFJ = -1, int KLCELKLBNJN = -1, [Optional] Func<Component, float> JCKCOLHKLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x698E310", Offset = "0x698D710", VA = "0x18698E310")]
	public void DIDKKBKLBHH(Component APOKKKDAFKO, Action HOPLFLJKCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x698E810", Offset = "0x698DC10", VA = "0x18698E810")]
	public void LGCGLCBMHPK(Component APOKKKDAFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x698E570", Offset = "0x698D970", VA = "0x18698E570")]
	public bool GPFDNPIONIC(Component MGFEBOILECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x698E5D0", Offset = "0x698D9D0", VA = "0x18698E5D0")]
	private void IGOFABFNBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x698E210", Offset = "0x698D610", VA = "0x18698E210")]
	[IteratorStateMachine(typeof(DDGDIGKCIDF))]
	private IEnumerator<KIBBKCLDIIA> BLPMLOAEGOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x9534E0", Offset = "0x9528E0", VA = "0x1809534E0")]
	[CompilerGenerated]
	private void PBEMHIOEPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x698E290", Offset = "0x698D690", VA = "0x18698E290")]
	[CompilerGenerated]
	private float CKLGAEMEMMO(IDNLMJNFPAK HOPLFLJKCIJ)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LJKLCLLOILC
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	AFFHNCAPPHD NJFGPNPKHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool NAELLCAKOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	JGNHMIKEILN<AFFHNCAPPHD> PHLLDNOGAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LIPIHMFOKLN(AFFHNCAPPHD PCJFCBFCIKF, bool FFOCMFHOIME = false);
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
