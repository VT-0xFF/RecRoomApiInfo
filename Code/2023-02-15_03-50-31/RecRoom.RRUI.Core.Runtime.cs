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
				[Cpp2IlInjected.Address(RVA = "0x63B7D10", Offset = "0x63B7110", VA = "0x1863B7D10")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x63B7D70", Offset = "0x63B7170", VA = "0x1863B7D70")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x63B7C90", Offset = "0x63B7090", VA = "0x1863B7C90")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x63B7A80", Offset = "0x63B6E80", VA = "0x1863B7A80")]
			public void OMNIHIIBGJA(PointerEventData MGOBHPHEJNM, RectTransform CIGIADBIHPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x63B7910", Offset = "0x63B6D10", VA = "0x1863B7910")]
			public void EOCOODOCDOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x63B7820", Offset = "0x63B6C20", VA = "0x1863B7820")]
			public void BCOBDPGGPKD(PointerEventData MGOBHPHEJNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x63B7A30", Offset = "0x63B6E30", VA = "0x1863B7A30")]
			public void LPCCKEHGHBL(float JAMDNKEGIEK, RectTransform CIGIADBIHPO, Vector3 HHJBJKMLAEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly global::KOEHNDLKDFN<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly global::KOEHNDLKDFN<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly global::KOEHNDLKDFN<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly CBKLEJNNKJH PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly UIHandleEventData NMJNDAKLFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool CIIOOINJIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool LLNEGPCLLEB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IPAIJEJJLAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7BE830", Offset = "0x7BDC30", VA = "0x1807BE830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x63B7080", Offset = "0x63B6480", VA = "0x1863B7080")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CGNAMIEKMKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x1081BE0", Offset = "0x1080FE0", VA = "0x181081BE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x63B70B0", Offset = "0x63B64B0", VA = "0x1863B70B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x63B7000", Offset = "0x63B6400", VA = "0x1863B7000")]
		private bool AIFFJBKPMJP(PointerEventData FFEKEOCBAFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		public void OnPointerDown(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x63B73D0", Offset = "0x63B67D0", VA = "0x1863B73D0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x63B70E0", Offset = "0x63B64E0", VA = "0x1863B70E0", Slot = "7")]
		public void OnBeginDrag(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63B7200", Offset = "0x63B6600", VA = "0x1863B7200", Slot = "4")]
		public void OnDrag(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x63B72F0", Offset = "0x63B66F0", VA = "0x1863B72F0", Slot = "8")]
		public void OnEndDrag(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x63B7660", Offset = "0x63B6A60", VA = "0x1863B7660", Slot = "9")]
		public void OnPointerEnter(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x63B7690", Offset = "0x63B6A90", VA = "0x1863B7690", Slot = "10")]
		public void OnPointerExit(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63B71C0", Offset = "0x63B65C0", VA = "0x1863B71C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63B76C0", Offset = "0x63B6AC0", VA = "0x1863B76C0")]
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
		private OptionData NNIICHCPLDP;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63B27C0", Offset = "0x63B1BC0", VA = "0x1863B27C0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x63B26B0", Offset = "0x63B1AB0", VA = "0x1863B26B0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x63B25F0", Offset = "0x63B19F0", VA = "0x1863B25F0")]
		private void IDKIIMFFBJI(GameObject AIFEKKCKEAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63B29A0", Offset = "0x63B1DA0", VA = "0x1863B29A0")]
		public void SetOptionsWithNoDefault(List<string> NEAFDAHPCEI, [Optional] string JFECLGKDKOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x63B2BE0", Offset = "0x63B1FE0", VA = "0x1863B2BE0")]
		public void SetOptionsWithNoDefault(List<OptionData> OCHMMOCEMAN, [Optional] string JFECLGKDKOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x63B28D0", Offset = "0x63B1CD0", VA = "0x1863B28D0", Slot = "42")]
		public override void OnPointerClick(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F8CD0", VA = "0x1806F98D0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas GPNJJAIPODK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x63B2CD0", Offset = "0x63B20D0", VA = "0x1863B2CD0")]
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
		private sealed class POLNEMDJFMA : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private MOELIBACAGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
			[DebuggerHidden]
			public POLNEMDJFMA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63B5530", Offset = "0x63B4930", VA = "0x1863B5530", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x63B5A50", Offset = "0x63B4E50", VA = "0x1863B5A50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[LNFKCGBKKAE(BCMNNOMINIG.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly JMMOMAJEGFM MMEACLCCGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool HPCEEDFJCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Vector3? ININICOCHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool? EEEACEHLLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? OAHDOOALINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool AJGDFNBIAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool BNMKFAAOBKH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ICHODEMLICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x63B39E0", Offset = "0x63B2DE0", VA = "0x1863B39E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool GBGGDFBKCLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x63B39C0", Offset = "0x63B2DC0", VA = "0x1863B39C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FBFALGNFLBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xC75110", Offset = "0xC74510", VA = "0x180C75110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x63B3BB0", Offset = "0x63B2FB0", VA = "0x1863B3BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FIGBPLAEHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63B3920", Offset = "0x63B2D20", VA = "0x1863B3920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63B3B10", Offset = "0x63B2F10", VA = "0x1863B3B10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x63B33D0", Offset = "0x63B27D0", VA = "0x1863B33D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x63B36F0", Offset = "0x63B2AF0", VA = "0x1863B36F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x63B34B0", Offset = "0x63B28B0", VA = "0x1863B34B0")]
		public void Hide(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x63B3830", Offset = "0x63B2C30", VA = "0x1863B3830")]
		public void Show(object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x63B3790", Offset = "0x63B2B90", VA = "0x1863B3790")]
		public void Set(object AJDBKDIMOHA, bool FIKMIBIJLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x63B3530", Offset = "0x63B2930", VA = "0x1863B3530")]
		private void IIPALCLEFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x63B3360", Offset = "0x63B2760", VA = "0x1863B3360")]
		[IteratorStateMachine(typeof(POLNEMDJFMA))]
		private IEnumerator<MOELIBACAGH> AMHEICKAGJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x63B3470", Offset = "0x63B2870", VA = "0x1863B3470", Slot = "5")]
		public virtual void DoHideOrShow(bool MCJHCIKBDJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x63B38B0", Offset = "0x63B2CB0", VA = "0x1863B38B0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IHIFMAHDNOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7B85D0", Offset = "0x7B79D0", VA = "0x1807B85D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8180E0", Offset = "0x8174E0", VA = "0x1808180E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> OBPNKBEKNFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x63B3DA0", Offset = "0x63B31A0", VA = "0x1863B3DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63B3EE0", Offset = "0x63B32E0", VA = "0x1863B3EE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> MHKNMBMCEAK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x63B3E40", Offset = "0x63B3240", VA = "0x1863B3E40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63B3F80", Offset = "0x63B3380", VA = "0x1863B3F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x63B3CE0", Offset = "0x63B30E0", VA = "0x1863B3CE0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63B3D40", Offset = "0x63B3140", VA = "0x1863B3D40", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData FFEKEOCBAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA8BCD0", Offset = "0xA8B0D0", VA = "0x180A8BCD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA8BCD0", Offset = "0xA8B0D0", VA = "0x180A8BCD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KHLKHCFEEMF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum BKCHICLCPOK
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private const BKCHICLCPOK IJHGEFHPAPG = BKCHICLCPOK.Light;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const string HNDCNCDHFBA = "RRUI_Theme";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static MKBBBKJBKGN MBKPCKHLGEL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static MKBBBKJBKGN JFBMNFHLIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x63B43A0", Offset = "0x63B37A0", VA = "0x1863B43A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static BKCHICLCPOK DCKENIBJDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x63B4690", Offset = "0x63B3A90", VA = "0x1863B4690")]
		get
		{
			return default(BKCHICLCPOK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x63B44E0", Offset = "0x63B38E0", VA = "0x1863B44E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<BKCHICLCPOK> BLKJHMOJJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x63B42A0", Offset = "0x63B36A0", VA = "0x1863B42A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x63B41A0", Offset = "0x63B35A0", VA = "0x1863B41A0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IEGLAMIDIOP : CFIOLFMIPKO, BOKPAJAAJCD, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	global::NKKFEABOGLC<GameObject, int> AHMBKLLMPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	global::FKFOHAFACOF<GameObject, int, bool> FLIFJCNAKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	global::KOEHNDLKDFN<bool> BJPABNLBJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool JHCCPMEBMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float OLOGHGHJOID
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	global::KOEHNDLKDFN<float> DKFCCAFEEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CBKLEJNNKJH MKELFFHOKBE
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
	void SpawnLoadingPlaceholders(GameObject NMEDHGOIPNG);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MONKECHCONN Spawn<T>(int PLLLJJEKBMI, IReadOnlyList<T> ONIBEFDCPGD, GameObject NMEDHGOIPNG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MONKECHCONN Spawn<T>(int PLLLJJEKBMI, IReadOnlyList<T> ONIBEFDCPGD, GameObject FCJIDFGFPDO, ref Func<int, GameObject> EIFIFGMHDGN);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum PDCOCHPOIMM : byte
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
		private static readonly int IDCIFPPLMIJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<PDCOCHPOIMM, string> IAFMJFKDMGG;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int OAMMFIFEAPC = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int CFONGLJNPDI;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int PGFEKCDOAKK;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int HKDCNKFIMMC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int JBFGBELHMBF;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int CEFEIPBBFJK;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int MLPEGCNKICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool OHLPPBPFALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool ILOCOIFCHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] HICLEPGKBHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private PDCOCHPOIMM type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly PDCOCHPOIMM[] JEEPOJPONDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		[JLJIECADMGK("ShouldUseCenter")]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly PDCOCHPOIMM[] NJPEDCKNGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[JLJIECADMGK("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[Range(0f, 360f)]
		[JLJIECADMGK("type", (byte)4)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		[JLJIECADMGK("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic AIBALLAMOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HLANKNFCBBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient ALNNJMCBEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6E79C0", Offset = "0x6E6DC0", VA = "0x1806E79C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63B6E50", Offset = "0x63B6250", VA = "0x1863B6E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public PDCOCHPOIMM MGHFMIGMODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7BE830", Offset = "0x7BDC30", VA = "0x1807BE830")]
			get
			{
				return default(PDCOCHPOIMM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x63B6FD0", Offset = "0x63B63D0", VA = "0x1863B6FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool GNBIHCDJMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x63B5E80", Offset = "0x63B5280", VA = "0x1863B5E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 AMANMAOICGD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x63B6DE0", Offset = "0x63B61E0", VA = "0x1863B6DE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x63B6E00", Offset = "0x63B6200", VA = "0x1863B6E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool LHMOMEPFDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x63B5E00", Offset = "0x63B5200", VA = "0x1863B5E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 JEECLGDGEGL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2093E60", Offset = "0x2093260", VA = "0x182093E60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x63B6F80", Offset = "0x63B6380", VA = "0x1863B6F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float IBMHMMIMHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1AB7050", Offset = "0x1AB6450", VA = "0x181AB7050")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x208B930", Offset = "0x208AD30", VA = "0x18208B930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 KIHDBABHBNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x63B61F0", Offset = "0x63B55F0", VA = "0x1863B61F0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 ODEDMIGCDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x63B5D70", Offset = "0x63B5170", VA = "0x1863B5D70")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float AJBMFMCNJOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1AB7060", Offset = "0x1AB6460", VA = "0x181AB7060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x63B6FE0", Offset = "0x63B63E0", VA = "0x1863B6FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x63B6070", Offset = "0x63B5470", VA = "0x1863B6070", Slot = "12")]
		protected override void KDPEPDEMIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x63B5F00", Offset = "0x63B5300", VA = "0x1863B5F00")]
		private void HEFOCDDAGAB(Color[] MEEICLPGBKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x63B6240", Offset = "0x63B5640", VA = "0x1863B6240", Slot = "13")]
		protected override void NFGJGNGEFOE(Material OMOMAJDOPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63B5B50", Offset = "0x63B4F50", VA = "0x1863B5B50", Slot = "14")]
		protected override void EBCJGADKAHF(Material OMOMAJDOPDE, bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x63B6D20", Offset = "0x63B6120", VA = "0x1863B6D20")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly PMOJLBOABOM LMPLIMLFAKN;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite HPDLEFHCAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material EIEBAODJBJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material BFPBEPGFOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool BIDCIINOLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool HPCEEDFJCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool CAMCHJANCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool NNLJFLLLDKP;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic AIBALLAMOFN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader DGAFHLIPPFL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool HLANKNFCBBO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool AFBABOJHPIK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F8CE0", VA = "0x1806F98E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform CIGIADBIHPO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x63B7E20", Offset = "0x63B7220", VA = "0x1863B7E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect HDBMFCIDDJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x63B80C0", Offset = "0x63B74C0", VA = "0x1863B80C0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite OCGCIJIEENB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x63B8730", Offset = "0x63B7B30", VA = "0x1863B8730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63B7E80", Offset = "0x63B7280", VA = "0x1863B7E80", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63B8E10", Offset = "0x63B8210", VA = "0x1863B8E10", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63B9130", Offset = "0x63B8530", VA = "0x1863B9130", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63B8FC0", Offset = "0x63B83C0", VA = "0x1863B8FC0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x63B8C90", Offset = "0x63B8090", VA = "0x1863B8C90")]
		private void LBPLDKGDJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63B81F0", Offset = "0x63B75F0", VA = "0x1863B81F0")]
		private void EOFAADHCNNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63B8700", Offset = "0x63B7B00", VA = "0x1863B8700")]
		private void IFFHOKOPLOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x63B8070", Offset = "0x63B7470", VA = "0x1863B8070")]
		private void CMILIEGHBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63B8490", Offset = "0x63B7890", VA = "0x1863B8490")]
		protected void FNCDJGJFMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63B8350", Offset = "0x63B7750", VA = "0x1863B8350")]
		private void FDNODKNEDPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "12")]
		protected virtual void KDPEPDEMIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "13")]
		protected virtual void NFGJGNGEFOE(Material OMOMAJDOPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "14")]
		protected virtual void EBCJGADKAHF(Material OMOMAJDOPDE, bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x63B8900", Offset = "0x63B7D00", VA = "0x1863B8900")]
		private void KPEKNELFAKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		[Conditional("RRUI_PROFILING")]
		protected void GEHLOPCPGLH(string LJFJPGNDKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320")]
		[Conditional("RRUI_PROFILING")]
		protected void JIKHKNIKCBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E4110", Offset = "0x6E3510", VA = "0x1806E4110")]
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
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x2CFB80", Offset = "0x2CEF80")]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly int NKGMKGBNAHK;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int IEOIIDDDALO;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int MHPBGENBGIK;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int OFFLDNNJLAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
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
		private Color[] HICLEPGKBHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] OLHIBJKLFNJ;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic AIBALLAMOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool AFBABOJHPIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> HCIGGOMGIEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6E0E70", Offset = "0x6E0270", VA = "0x1806E0E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 AMANMAOICGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1B8D430", Offset = "0x1B8C830", VA = "0x181B8D430")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x63B9B10", Offset = "0x63B8F10", VA = "0x1863B9B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63B9810", Offset = "0x63B8C10", VA = "0x1863B9810")]
		public void SetRingLayers(IReadOnlyList<RingLayer> AEIAPIOECFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63B95F0", Offset = "0x63B89F0", VA = "0x1863B95F0")]
		public bool SetRingLayerColor(int ABCMMMCGCAA, Color GEDOLEMBLCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63B9700", Offset = "0x63B8B00", VA = "0x1863B9700")]
		public bool SetRingLayerSize(int ABCMMMCGCAA, float PCAHMJECHKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63B9300", Offset = "0x63B8700", VA = "0x1863B9300", Slot = "12")]
		protected override void KDPEPDEMIPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x63B9470", Offset = "0x63B8870", VA = "0x1863B9470", Slot = "13")]
		protected override void NFGJGNGEFOE(Material OMOMAJDOPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x63B92B0", Offset = "0x63B86B0", VA = "0x1863B92B0", Slot = "14")]
		protected override void EBCJGADKAHF(Material OMOMAJDOPDE, bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x63B9960", Offset = "0x63B8D60", VA = "0x1863B9960")]
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
		public enum FFAMMPDBCBC
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int EJFACDKBJAE;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int NGPGLAKADFL;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int EBJJPGBOMDO;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int BAKGAKHOFKL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int PGBKOIAMDGL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int OABBCJOGBPA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int NAALFDHAFGK;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int KJNLDPDKIGE;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int EFHMDGCIHEN;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int FDDEADMONOH;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int DBCGCDJJLFA;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ILOJGAFJCGM;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int PFDCPAHLECP;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int LILDCHPLJLF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int OEBMCGMOHED;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int GJPIHBCGKIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
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
		private FFAMMPDBCBC animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[JLJIECADMGK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[JLJIECADMGK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic AIBALLAMOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x702560", Offset = "0x701960", VA = "0x180702560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool AFBABOJHPIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite IHAANBOLHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x63BA8E0", Offset = "0x63B9CE0", VA = "0x1863BA8E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x63BAAF0", Offset = "0x63B9EF0", VA = "0x1863BAAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color BHLDEJJBAHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x846A80", Offset = "0x845E80", VA = "0x180846A80")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x63BAB90", Offset = "0x63B9F90", VA = "0x1863BAB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color ANNEJPKBDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD7B370", Offset = "0xD7A770", VA = "0x180D7B370")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x63BA9E0", Offset = "0x63B9DE0", VA = "0x1863BA9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float HPLKPOEEDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x16A6C50", Offset = "0x16A6050", VA = "0x1816A6C50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x63BAA80", Offset = "0x63B9E80", VA = "0x1863BAA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 HDIEHOFKKHL
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x20E3030", Offset = "0x20E2430", VA = "0x1820E3030")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x63BAAA0", Offset = "0x63B9EA0", VA = "0x1863BAAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float OHFGBAEJNAC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8FDA70", Offset = "0x8FCE70", VA = "0x1808FDA70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x63BAA40", Offset = "0x63B9E40", VA = "0x1863BAA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 NDLNIGIKENH
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xD5BFB0", Offset = "0xD5B3B0", VA = "0x180D5BFB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x63BABF0", Offset = "0x63B9FF0", VA = "0x1863BABF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float DIEFBLMCBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xF69130", Offset = "0xF68530", VA = "0x180F69130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x63BA9B0", Offset = "0x63B9DB0", VA = "0x1863BA9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 PNMFGNHFAFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x63B9E30", Offset = "0x63B9230", VA = "0x1863B9E30")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public FFAMMPDBCBC EMDJBCOBJPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xB146A0", Offset = "0xB13AA0", VA = "0x180B146A0")]
			get
			{
				return default(FFAMMPDBCBC);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x63BA9D0", Offset = "0x63B9DD0", VA = "0x1863BA9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float MPMLKLBJGIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xF5B9A0", Offset = "0xF5ADA0", VA = "0x180F5B9A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x63BAA60", Offset = "0x63B9E60", VA = "0x1863BAA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float BDKPJMLILKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1C883B0", Offset = "0x1C877B0", VA = "0x181C883B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x63BA990", Offset = "0x63B9D90", VA = "0x1863BA990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x63B9EA0", Offset = "0x63B92A0", VA = "0x1863B9EA0", Slot = "13")]
		protected override void NFGJGNGEFOE(Material OMOMAJDOPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x63B9B60", Offset = "0x63B8F60", VA = "0x1863B9B60")]
		private void ADMAKJIBGHD(Sprite FDCBBALCAMG, out Vector2 AKAKHALMPPO, out Vector2 OOEJAKCILMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x63B9DE0", Offset = "0x63B91E0", VA = "0x1863B9DE0", Slot = "14")]
		protected override void EBCJGADKAHF(Material OMOMAJDOPDE, bool LNJLGDKOFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x63BA840", Offset = "0x63B9C40", VA = "0x1863BA840")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader MLNGCFIICKA;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader DGAFHLIPPFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x63BACA0", Offset = "0x63BA0A0", VA = "0x1863BACA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x63BAC40", Offset = "0x63BA040", VA = "0x1863BAC40")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PMOJLBOABOM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KCGABAEMCED : IEquatable<KCGABAEMCED>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component MAFDHEKFLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action BKBHGEHNNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int OIBDDLFFICI;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component PPMGBDEINDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6E1E30", Offset = "0x6E1230", VA = "0x1806E1E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x63B4140", Offset = "0x63B3540", VA = "0x1863B4140")]
		public KCGABAEMCED(Component MAFDHEKFLMG, Action BKBHGEHNNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x63B40C0", Offset = "0x63B34C0", VA = "0x1863B40C0")]
		public void GIOENJDGHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x63B4020", Offset = "0x63B3420", VA = "0x1863B4020", Slot = "4")]
		public bool Equals(KCGABAEMCED IHIJPIJNLJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x63B4030", Offset = "0x63B3430", VA = "0x1863B4030", Slot = "0")]
		public override bool Equals(object ADHHHFDPAPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C4060", Offset = "0x6C3460", VA = "0x1806C4060", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class OKEFPGDEJBE : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MOELIBACAGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public PMOJLBOABOM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E4140", Offset = "0x6E3540", VA = "0x1806E4140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x783640", Offset = "0x782A40", VA = "0x180783640")]
		[DebuggerHidden]
		public OKEFPGDEJBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D7320", Offset = "0x6D6720", VA = "0x1806D7320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x63B4830", Offset = "0x63B3C30", VA = "0x1863B4830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x63B4B60", Offset = "0x63B3F60", VA = "0x1863B4B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int MPELFJGLABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int OHDMOPHNKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> MFBFPLACPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, KCGABAEMCED> ENECGOHHAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<KCGABAEMCED> OOEEIGKOKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<KCGABAEMCED> MPNIEOLGNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EJCEALCEAGN GKCAJPLOICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private KAMKJOOJPCM BGCICFHGKJI;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private KAMKJOOJPCM HPFKAEFIJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x63B4CD0", Offset = "0x63B40D0", VA = "0x1863B4CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x63B53D0", Offset = "0x63B47D0", VA = "0x1863B53D0")]
	public PMOJLBOABOM(LIBKFAKJMIH.DBLADPAIJMN MFFNAGENGLI, int MPELFJGLABJ = -1, int OHDMOPHNKFN = -1, [Optional] Func<Component, float> MFBFPLACPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x63B4FD0", Offset = "0x63B43D0", VA = "0x1863B4FD0")]
	public void LPMJPBKIKFM(Component MAFDHEKFLMG, Action GMFDMCMDPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63B5240", Offset = "0x63B4640", VA = "0x1863B5240")]
	public void NHBMDAJOPPN(Component MAFDHEKFLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63B4F70", Offset = "0x63B4370", VA = "0x1863B4F70")]
	public bool KAKDLMJCLFI(Component BGHFDNDJKMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x63B4D40", Offset = "0x63B4140", VA = "0x1863B4D40")]
	private void FCCGKNABIPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x63B4C60", Offset = "0x63B4060", VA = "0x1863B4C60")]
	[IteratorStateMachine(typeof(OKEFPGDEJBE))]
	private IEnumerator<MOELIBACAGH> DDKLENMFOJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1E5DA00", Offset = "0x1E5CE00", VA = "0x181E5DA00")]
	[CompilerGenerated]
	private void JPPLIODLAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x63B4BA0", Offset = "0x63B3FA0", VA = "0x1863B4BA0")]
	[CompilerGenerated]
	private float BBACGOCBPFA(KCGABAEMCED GMFDMCMDPFN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FHAPPNCNDFJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EOBMKHKHMNH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	DIBIMNIJNHH EEKADKKIBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool ENGDANMPILC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	global::KOEHNDLKDFN<DIBIMNIJNHH> AGFEJEEDECM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJJNIIBIDJP(DIBIMNIJNHH FAFKAGNNDCN, bool GILPIOFGNOG = false);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x63B2D30", Offset = "0x63B2130", VA = "0x1863B2D30")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x63B2E40", Offset = "0x63B2240", VA = "0x1863B2E40")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
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
		[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
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
