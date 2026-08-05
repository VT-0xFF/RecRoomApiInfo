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
				[Cpp2IlInjected.Address(RVA = "0x6642460", Offset = "0x6640E60", VA = "0x186642460")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x66424C0", Offset = "0x6640EC0", VA = "0x1866424C0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x6642410", Offset = "0x6640E10", VA = "0x186642410")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6641F50", Offset = "0x6640950", VA = "0x186641F50")]
			public void GLAOJNGFDBF(PointerEventData CDNGKICIDFN, RectTransform BEBAEACIFND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6642050", Offset = "0x6640A50", VA = "0x186642050")]
			public void KCKOLFDDNPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6642330", Offset = "0x6640D30", VA = "0x186642330")]
			public void PODNLKBCDKP(PointerEventData CDNGKICIDFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x66422E0", Offset = "0x6640CE0", VA = "0x1866422E0")]
			public void KEIDKFEEGCH(float DPOBDCAHHAM, RectTransform BEBAEACIFND, Vector3 LAKIBICOBFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly BFONFBJGKIG<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BFONFBJGKIG<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly BFONFBJGKIG<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly BFONFBJGKIG<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly BFONFBJGKIG<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly BCNLEBGHOIF PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData LIIFCONHHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool KKLNNDNPPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool OMNJGNMBNFJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IFLMKJJMENH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x799130", Offset = "0x797B30", VA = "0x180799130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6641760", Offset = "0x6640160", VA = "0x186641760")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GMOHCOHPJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7990E0", Offset = "0x797AE0", VA = "0x1807990E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6641790", Offset = "0x6640190", VA = "0x186641790")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66416E0", Offset = "0x66400E0", VA = "0x1866416E0")]
		private bool BIPAMPBDGNP(PointerEventData KMDMCPBDECK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6641C10", Offset = "0x6640610", VA = "0x186641C10", Slot = "5")]
		public void OnPointerDown(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6641CD0", Offset = "0x66406D0", VA = "0x186641CD0", Slot = "11")]
		public void OnPointerUp(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6641A80", Offset = "0x6640480", VA = "0x186641A80", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66417C0", Offset = "0x66401C0", VA = "0x1866417C0", Slot = "7")]
		public void OnBeginDrag(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66418D0", Offset = "0x66402D0", VA = "0x1866418D0", Slot = "4")]
		public void OnDrag(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x66419B0", Offset = "0x66403B0", VA = "0x1866419B0", Slot = "8")]
		public void OnEndDrag(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6641C70", Offset = "0x6640670", VA = "0x186641C70", Slot = "9")]
		public void OnPointerEnter(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6641CA0", Offset = "0x66406A0", VA = "0x186641CA0", Slot = "10")]
		public void OnPointerExit(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6641890", Offset = "0x6640290", VA = "0x186641890")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6641D30", Offset = "0x6640730", VA = "0x186641D30")]
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
		private OptionData POKFKKHEFBA;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x663DA80", Offset = "0x663C480", VA = "0x18663DA80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x663D980", Offset = "0x663C380", VA = "0x18663D980", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x663D8D0", Offset = "0x663C2D0", VA = "0x18663D8D0")]
		private void FAKEGCLPNKP(GameObject HHMCLKIHCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x663DD40", Offset = "0x663C740", VA = "0x18663DD40")]
		public void SetOptionsWithNoDefault(List<string> AKMHBKNPLFM, [Optional] string MECGPIJAJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x663DC50", Offset = "0x663C650", VA = "0x18663DC50")]
		public void SetOptionsWithNoDefault(List<OptionData> BFKMPGOIOPI, [Optional] string MECGPIJAJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x663DB80", Offset = "0x663C580", VA = "0x18663DB80", Slot = "42")]
		public override void OnPointerClick(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas KOJGHCCKDIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x663DF70", Offset = "0x663C970", VA = "0x18663DF70")]
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
		private sealed class HGEDEMKDBMJ : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private KMDFFEOBLOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
			[DebuggerHidden]
			public HGEDEMKDBMJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x663E940", Offset = "0x663D340", VA = "0x18663E940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x663EE30", Offset = "0x663D830", VA = "0x18663EE30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[HAPNNLGHBBJ(EEBNILOIPCE.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly NFHAIGOLJDB PNEHOBDOIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool KEBMNNCOPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? OMNKANFAKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? DNPBJMBLOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? OLBNGGDFOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool OJGJCJDPILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool KFFMEMCGIKM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool IMEBJPFIMCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x663F500", Offset = "0x663DF00", VA = "0x18663F500", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KFNDKNPNKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x663F4E0", Offset = "0x663DEE0", VA = "0x18663F4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LKIBILGFECD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7D9EC0", Offset = "0x7D88C0", VA = "0x1807D9EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x663F6B0", Offset = "0x663E0B0", VA = "0x18663F6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JBBFOGJGHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x663F440", Offset = "0x663DE40", VA = "0x18663F440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x663F610", Offset = "0x663E010", VA = "0x18663F610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x663EE80", Offset = "0x663D880", VA = "0x18663EE80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x663F210", Offset = "0x663DC10", VA = "0x18663F210")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x663F110", Offset = "0x663DB10", VA = "0x18663F110")]
		public void Hide(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x663F340", Offset = "0x663DD40", VA = "0x18663F340")]
		public void Show(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x663F2A0", Offset = "0x663DCA0", VA = "0x18663F2A0")]
		public void Set(object BDAPLOBBPIE, bool KALAMGGEKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x663EF50", Offset = "0x663D950", VA = "0x18663EF50")]
		private void FHJIPDLGKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x663F190", Offset = "0x663DB90", VA = "0x18663F190")]
		[IteratorStateMachine(typeof(HGEDEMKDBMJ))]
		private IEnumerator<KMDFFEOBLOI> IDLIGDFANOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x663EF10", Offset = "0x663D910", VA = "0x18663EF10", Slot = "5")]
		public virtual void DoHideOrShow(bool LPDKODDBGAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x663F3C0", Offset = "0x663DDC0", VA = "0x18663F3C0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AALJPNKEDCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x792750", Offset = "0x791150", VA = "0x180792750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> MLKPPBGNCLB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x663F810", Offset = "0x663E210", VA = "0x18663F810")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x663F970", Offset = "0x663E370", VA = "0x18663F970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> IOOMCMBBAHG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x663F8C0", Offset = "0x663E2C0", VA = "0x18663F8C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x663FA20", Offset = "0x663E420", VA = "0x18663FA20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x663F7D0", Offset = "0x663E1D0", VA = "0x18663F7D0", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x663F7F0", Offset = "0x663E1F0", VA = "0x18663F7F0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData KMDMCPBDECK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC70820", Offset = "0xC6F220", VA = "0x180C70820")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC70820", Offset = "0xC6F220", VA = "0x180C70820")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NLAKGHDALJE
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum HGOMLGLDLPF
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static BHHNAJCLLBA MIDNHFEEGLB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static BHHNAJCLLBA EMGDAGNJOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x66400B0", Offset = "0x663EAB0", VA = "0x1866400B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static HGOMLGLDLPF HBAJBDOAKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x663FD40", Offset = "0x663E740", VA = "0x18663FD40")]
		get
		{
			return default(HGOMLGLDLPF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x663FF50", Offset = "0x663E950", VA = "0x18663FF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<HGOMLGLDLPF> AENBHJBNHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x663FE70", Offset = "0x663E870", VA = "0x18663FE70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x663FC60", Offset = "0x663E660", VA = "0x18663FC60")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JHGKJEGHPKA : PMPMPHFPKMA, DCADMHDFIGP, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	AJPBOEJFMGB<GameObject, int> IBBLPELDJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FMCPAMIJMNN<GameObject, int, bool> DFOKEDOAMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BFONFBJGKIG<bool> OHFAGHPCIPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool IBCMBDGICNM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float CBAGHHMIFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BFONFBJGKIG<float> LBLIMFLMIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BCNLEBGHOIF BKFHJPIGJMJ
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
	void SpawnLoadingPlaceholders(GameObject OPENNMAGMAF);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MDCIDBDKHAG Spawn<T>(int GOALFDJEPJG, IReadOnlyList<T> OBAHLGOPPIK, GameObject OPENNMAGMAF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MDCIDBDKHAG Spawn<T>(int GOALFDJEPJG, IReadOnlyList<T> OBAHLGOPPIK, GameObject CDPFELJCIIE, Func<int, GameObject> DAAJOGNDIPH);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int BNALCEABILL, float ENOHGBEJNKB);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum NLMKPKDINMO : byte
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
		private static readonly int CHHBALDIKCI;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<NLMKPKDINMO, string> EEDNBBKMCNL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int DLNIJIFBBAE = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int MLHEEPBLDEA;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int BAAPNPBMDGN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int DILLFCLFKMF;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int OJHPHEEFDGC;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int JEAINJDNCKA;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int IILKALIJDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool FCLOBBLPMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool MFDJJMPFPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] CPPGBMOMOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private NLMKPKDINMO type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly NLMKPKDINMO[] JBPAMDGDLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[FDMPAGPHLNK("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly NLMKPKDINMO[] LGNCAFACJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[FDMPAGPHLNK("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[FDMPAGPHLNK("type", NLMKPKDINMO.CustomDirection)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[FDMPAGPHLNK("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic KBKILJMONHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool LBICFJLEBIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient HKLHLLBIIOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7976F0", Offset = "0x7960F0", VA = "0x1807976F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6641530", Offset = "0x663FF30", VA = "0x186641530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public NLMKPKDINMO KBCPOJJINMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCC0CD0", Offset = "0xCBF6D0", VA = "0x180CC0CD0")]
			get
			{
				return default(NLMKPKDINMO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x66416B0", Offset = "0x66400B0", VA = "0x1866416B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool MJKFOADMBKG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6640260", Offset = "0x663EC60", VA = "0x186640260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 JBPEFCMIKOD
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x66414C0", Offset = "0x663FEC0", VA = "0x1866414C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x66414E0", Offset = "0x663FEE0", VA = "0x1866414E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool CHGFONNFKJG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6640F90", Offset = "0x663F990", VA = "0x186640F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 NJJFPNKONPI
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1B2A410", Offset = "0x1B28E10", VA = "0x181B2A410")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6641660", Offset = "0x6640060", VA = "0x186641660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float LLJFODLPKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x822370", Offset = "0x820D70", VA = "0x180822370")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1330A10", Offset = "0x132F410", VA = "0x181330A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 PPPLANMJLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6640F40", Offset = "0x663F940", VA = "0x186640F40")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 GPLPMHNJGJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6640600", Offset = "0x663F000", VA = "0x186640600")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float BEEBNJHFPAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7AAD00", Offset = "0x7A9700", VA = "0x1807AAD00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x66416C0", Offset = "0x66400C0", VA = "0x1866416C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x66402D0", Offset = "0x663ECD0", VA = "0x1866402D0", Slot = "12")]
		protected override void AFKLELOLCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6640470", Offset = "0x663EE70", VA = "0x186640470")]
		private void BEAFJPGKLJB(Color[] AFAGHOJHHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6640690", Offset = "0x663F090", VA = "0x186640690", Slot = "13")]
		protected override void ILCFGHIIMAO(Material HEPAJJIBPIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6640D20", Offset = "0x663F720", VA = "0x186640D20", Slot = "14")]
		protected override void JELMNOKPHCC(Material HEPAJJIBPIF, bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6641410", Offset = "0x663FE10", VA = "0x186641410")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly EOOAEJLHHDN FAEFJAGIOPO;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite FKDKOCIFFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material BJMMBLNLFKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material PENLDKLBAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool KHBMFNMGPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool KEBMNNCOPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool ENBALMOKAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool NLHDAHKAIKJ;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic KBKILJMONHD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader CPEKNNLEBJD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool LBICFJLEBIO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool EKEIAJHACIE
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform BEBAEACIFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6642DC0", Offset = "0x66417C0", VA = "0x186642DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect LNGBEOOMCKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6642B60", Offset = "0x6641560", VA = "0x186642B60")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite DEMGKPKDFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x66437B0", Offset = "0x66421B0", VA = "0x1866437B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x66426B0", Offset = "0x66410B0", VA = "0x1866426B0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x66434A0", Offset = "0x6641EA0", VA = "0x1866434A0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x66437A0", Offset = "0x66421A0", VA = "0x1866437A0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6643650", Offset = "0x6642050", VA = "0x186643650", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6643310", Offset = "0x6641D10", VA = "0x186643310")]
		private void LGBCCLNPDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x66431A0", Offset = "0x6641BA0", VA = "0x1866431A0")]
		private void IICPKLELLIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6642E20", Offset = "0x6641820", VA = "0x186642E20")]
		private void HNJIHFBIHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6642B10", Offset = "0x6641510", VA = "0x186642B10")]
		private void DDLOAPGCGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x66428A0", Offset = "0x66412A0", VA = "0x1866428A0")]
		protected void CBPJBNHJJKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6642C80", Offset = "0x6641680", VA = "0x186642C80")]
		private void GEMBPCMIFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "12")]
		protected virtual void AFKLELOLCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "13")]
		protected virtual void ILCFGHIIMAO(Material HEPAJJIBPIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "14")]
		protected virtual void JELMNOKPHCC(Material HEPAJJIBPIF, bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6642E50", Offset = "0x6641850", VA = "0x186642E50")]
		private void HPGJFPEADNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
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
		private static readonly int GKNIOICDBNF;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int ABJHDIGFHNA;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int EHPBPFJBLEK;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int IGHMKJDDLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
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
		private Color[] CPPGBMOMOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] MHDEMPBDCDE;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic KBKILJMONHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool EKEIAJHACIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> OGKACBIAFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 JBPEFCMIKOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6644470", Offset = "0x6642E70", VA = "0x186644470")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6644490", Offset = "0x6642E90", VA = "0x186644490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x66440B0", Offset = "0x6642AB0", VA = "0x1866440B0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> IKHDNDIHCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6643E70", Offset = "0x6642870", VA = "0x186643E70")]
		public bool SetRingLayerColor(int KBMDALJGEFL, Color GJNHDHNOICC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6643FC0", Offset = "0x66429C0", VA = "0x186643FC0")]
		public bool SetRingLayerSize(int KBMDALJGEFL, float DDIMFHFNGHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6643B60", Offset = "0x6642560", VA = "0x186643B60", Slot = "12")]
		protected override void AFKLELOLCKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6643CA0", Offset = "0x66426A0", VA = "0x186643CA0", Slot = "13")]
		protected override void ILCFGHIIMAO(Material HEPAJJIBPIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6643E20", Offset = "0x6642820", VA = "0x186643E20", Slot = "14")]
		protected override void JELMNOKPHCC(Material HEPAJJIBPIF, bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6644200", Offset = "0x6642C00", VA = "0x186644200")]
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
		public enum HNJDMFCLMPB
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int EMAAAONCDDO;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int MJDOHFNEGJP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int PLGLNENJCOH;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int OKJBEMAEBMF;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int MEHJKNLNHME;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int GLCGABPLEPK;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int AODAJMNGGFL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int NOFJOKHANAN;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int IOIFODBHDMO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int KIFGGDAAMEN;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int FBAMCMDFKCP;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int IEAPJICIBAH;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int EIICFDHLBPP;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int KNDIACOIHBO;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int IJGDDOAGCJD;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int KKOKKDMPNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
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
		private HNJDMFCLMPB animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[FDMPAGPHLNK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[FDMPAGPHLNK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic KBKILJMONHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool EKEIAJHACIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite OJMFNAMFFOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x66452E0", Offset = "0x6643CE0", VA = "0x1866452E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6645500", Offset = "0x6643F00", VA = "0x186645500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color BHHHLEPCHOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x97BBC0", Offset = "0x97A5C0", VA = "0x18097BBC0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6645590", Offset = "0x6643F90", VA = "0x186645590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color EJHFMJCEIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1B33690", Offset = "0x1B32090", VA = "0x181B33690")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x66453D0", Offset = "0x6643DD0", VA = "0x1866453D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float IJHFJMGCBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9E5140", Offset = "0x9E3B40", VA = "0x1809E5140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6645490", Offset = "0x6643E90", VA = "0x186645490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 JKBICNBDAKK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1B2A470", Offset = "0x1B28E70", VA = "0x181B2A470")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x66454B0", Offset = "0x6643EB0", VA = "0x1866454B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float EJGBKLGCLBD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7AA940", Offset = "0x7A9340", VA = "0x1807AA940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6645450", Offset = "0x6643E50", VA = "0x186645450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 BPDGNBOCPGA
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA63430", Offset = "0xA61E30", VA = "0x180A63430")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6645610", Offset = "0x6644010", VA = "0x186645610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float OFLJIBGOEFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA6B150", Offset = "0xA69B50", VA = "0x180A6B150")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x66453A0", Offset = "0x6643DA0", VA = "0x1866453A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 GOFGNBFFDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x66444E0", Offset = "0x6642EE0", VA = "0x1866444E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public HNJDMFCLMPB LCDCHALONAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA30D30", Offset = "0xA2F730", VA = "0x180A30D30")]
			get
			{
				return default(HNJDMFCLMPB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x66453C0", Offset = "0x6643DC0", VA = "0x1866453C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float CBNOAJDENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xB59710", Offset = "0xB58110", VA = "0x180B59710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6645470", Offset = "0x6643E70", VA = "0x186645470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float OMLAKFHJNPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB59860", Offset = "0xB58260", VA = "0x180B59860")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6645380", Offset = "0x6643D80", VA = "0x186645380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6644820", Offset = "0x6643220", VA = "0x186644820", Slot = "13")]
		protected override void ILCFGHIIMAO(Material HEPAJJIBPIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6644570", Offset = "0x6642F70", VA = "0x186644570")]
		private void DJBELLICHPP(Sprite LEPFBFACFNP, [Out] Vector2 OKKPOHGKEEE, [Out] Vector2 GOJHBDPFHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6644F20", Offset = "0x6643920", VA = "0x186644F20", Slot = "14")]
		protected override void JELMNOKPHCC(Material HEPAJJIBPIF, bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6645250", Offset = "0x6643C50", VA = "0x186645250")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader ABFDHKKCKCI;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader CPEKNNLEBJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x66456B0", Offset = "0x66440B0", VA = "0x1866456B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6645660", Offset = "0x6644060", VA = "0x186645660")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EOOAEJLHHDN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MCLNILPAMOE : IEquatable<MCLNILPAMOE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component AGHGCGMHDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action OMGBHLDAOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int MGFPJBNLNOG;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component MPEFAFCBBNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7F9270", Offset = "0x7F7C70", VA = "0x1807F9270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x663FBF0", Offset = "0x663E5F0", VA = "0x18663FBF0")]
		public MCLNILPAMOE(Component AGHGCGMHDAO, Action OMGBHLDAOOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x663FB70", Offset = "0x663E570", VA = "0x18663FB70")]
		public void MFAECAIDCEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x663FB60", Offset = "0x663E560", VA = "0x18663FB60", Slot = "4")]
		public bool Equals(MCLNILPAMOE CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x663FAD0", Offset = "0x663E4D0", VA = "0x18663FAD0", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x78E180", Offset = "0x78CB80", VA = "0x18078E180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class CPEGGHEAJAA : IEnumerator<KMDFFEOBLOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private KMDFFEOBLOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public EOOAEJLHHDN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private KMDFFEOBLOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
		[DebuggerHidden]
		public CPEGGHEAJAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x663D4C0", Offset = "0x663BEC0", VA = "0x18663D4C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x663D880", Offset = "0x663C280", VA = "0x18663D880", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly ELKCHGKMAGP IACBJAAGGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int ADPLIDBPDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int FNNJMDACGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> FOLMPOJEAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, MCLNILPAMOE> MKJLPNGPNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<MCLNILPAMOE> PEGPAENPNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<MCLNILPAMOE> LOJLKOFJKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private NEMGCHFJFIH ICENDPCFMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private HIGGGEACLOF ELIBOHDFEPG;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private HIGGGEACLOF EENDCEEACID
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x663E280", Offset = "0x663CC80", VA = "0x18663E280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x663E7C0", Offset = "0x663D1C0", VA = "0x18663E7C0")]
	public EOOAEJLHHDN(ELKCHGKMAGP IACBJAAGGMH, int ADPLIDBPDCB = -1, int FNNJMDACGPO = -1, [Optional] Func<Component, float> FOLMPOJEAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x663E480", Offset = "0x663CE80", VA = "0x18663E480")]
	public void FEMBAPNFLKB(Component AGHGCGMHDAO, Action HBIKEMGMPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x663E2F0", Offset = "0x663CCF0", VA = "0x18663E2F0")]
	public void EPFNKGGNCOO(Component AGHGCGMHDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x663E760", Offset = "0x663D160", VA = "0x18663E760")]
	public bool MHKKICBNJLK(Component BBNHMANAAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x663DFC0", Offset = "0x663C9C0", VA = "0x18663DFC0")]
	private void BJNHJCAOEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x663E200", Offset = "0x663CC00", VA = "0x18663E200")]
	[IteratorStateMachine(typeof(CPEGGHEAJAA))]
	private IEnumerator<KMDFFEOBLOI> CDDGOBBKJDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8CD620", Offset = "0x8CC020", VA = "0x1808CD620")]
	[CompilerGenerated]
	private void HAKILDCALPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x663E6E0", Offset = "0x663D0E0", VA = "0x18663E6E0")]
	[CompilerGenerated]
	private float JGAFNGBBAGO(MCLNILPAMOE HBIKEMGMPOM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EAJPAOJKPDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	GOGAIBIEHDJ CIFJJOMEJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool BBJMLBOOEHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	BFONFBJGKIG<GOGAIBIEHDJ> JKPKFNAHMOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOLELGCDGLG(GOGAIBIEHDJ ENKHGGGKAPH, bool BCELMONIDGP = false);
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
