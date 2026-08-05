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
				[Cpp2IlInjected.Address(RVA = "0x8D43480", Offset = "0x8D42880", VA = "0x188D43480")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8D434E0", Offset = "0x8D428E0", VA = "0x188D434E0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8D43440", Offset = "0x8D42840", VA = "0x188D43440")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8D432F0", Offset = "0x8D426F0", VA = "0x188D432F0")]
			public void HALDMMKHOFL(PointerEventData BFHBNHNAMDP, RectTransform JJOOEDGEKCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8D42F80", Offset = "0x8D42380", VA = "0x188D42F80")]
			public void DAJDALPAPKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D43210", Offset = "0x8D42610", VA = "0x188D43210")]
			public void FIBJKIOEMEA(PointerEventData BFHBNHNAMDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D433F0", Offset = "0x8D427F0", VA = "0x188D433F0")]
			public void IPLNJIINBHB(float IPHLNJEKIDO, RectTransform JJOOEDGEKCA, Vector3 IPGNGMJBFOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly BBKKNBJGBDM<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BBKKNBJGBDM<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly BBKKNBJGBDM<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly BBKKNBJGBDM<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly BBKKNBJGBDM<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly OFFOKCJIMNI PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData LLELPFIGOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool OIMGDPBNPPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool GHHBFHFHCHG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PPLMCFGNANK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA703C0", Offset = "0xA6F7C0", VA = "0x180A703C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8D42740", Offset = "0x8D41B40", VA = "0x188D42740")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JEAHOLNPDLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA70160", Offset = "0xA6F560", VA = "0x180A70160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8D42710", Offset = "0x8D41B10", VA = "0x188D42710")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D42770", Offset = "0x8D41B70", VA = "0x188D42770")]
		private bool MFPNJMOLIAD(PointerEventData FCGKHKJBFED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D42C40", Offset = "0x8D42040", VA = "0x188D42C40", Slot = "5")]
		public void OnPointerDown(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D42D00", Offset = "0x8D42100", VA = "0x188D42D00", Slot = "11")]
		public void OnPointerUp(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D42AB0", Offset = "0x8D41EB0", VA = "0x188D42AB0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D427F0", Offset = "0x8D41BF0", VA = "0x188D427F0", Slot = "7")]
		public void OnBeginDrag(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D42900", Offset = "0x8D41D00", VA = "0x188D42900", Slot = "4")]
		public void OnDrag(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D429E0", Offset = "0x8D41DE0", VA = "0x188D429E0", Slot = "8")]
		public void OnEndDrag(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D42CA0", Offset = "0x8D420A0", VA = "0x188D42CA0", Slot = "9")]
		public void OnPointerEnter(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D42CD0", Offset = "0x8D420D0", VA = "0x188D42CD0", Slot = "10")]
		public void OnPointerExit(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8D428C0", Offset = "0x8D41CC0", VA = "0x188D428C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D42D60", Offset = "0x8D42160", VA = "0x188D42D60")]
		public UIHandleDecorator()
		{
		}
	}
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CanvasSortingOrder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E3C0", Offset = "0x8D3D7C0", VA = "0x188D3E3C0")]
		public void SetCanvasSortingOrder(short ANNGKNJEELJ, bool GKGICOPKOFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData KJKJNOGENPC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E680", Offset = "0x8D3DA80", VA = "0x188D3E680", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E560", Offset = "0x8D3D960", VA = "0x188D3E560", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E4B0", Offset = "0x8D3D8B0", VA = "0x188D3E4B0")]
		private void ECPMGHCGELF(GameObject KAIKBPNABFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E960", Offset = "0x8D3DD60", VA = "0x188D3E960")]
		public void SetOptionsWithNoDefault(List<string> EJCCOPPBIIG, [Optional] string OCCIJIMIDIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E870", Offset = "0x8D3DC70", VA = "0x188D3E870")]
		public void SetOptionsWithNoDefault(List<OptionData> LFFPIIDBFOJ, [Optional] string OCCIJIMIDIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E7A0", Offset = "0x8D3DBA0", VA = "0x188D3E7A0", Slot = "44")]
		public override void OnPointerClick(PointerEventData FCGKHKJBFED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "47")]
		protected override GameObject CreateBlocker(Canvas PPFFHKBGEFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EB90", Offset = "0x8D3DF90", VA = "0x188D3EB90")]
		public Dropdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleComponent]
	public class Hideable : MonoBehaviour, ILayoutIgnorer
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CLLICJLCCCM : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private KHJLACPAINM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public CLLICJLCCCM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D3DE60", Offset = "0x8D3D260", VA = "0x188D3DE60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8D3E370", Offset = "0x8D3D770", VA = "0x188D3E370", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[OCPKILIHCKA(FIPBCJPBODB.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly HELNKODHDJF<object> OBKILIDLHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool BKCMGKPBBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? BGBAPHKCHGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? CBNDPBDICGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? AOJNBKNILFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool KDBHIHOFACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool IJMNDNFMKDH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KFCKDFPEEIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8D3F290", Offset = "0x8D3E690", VA = "0x188D3F290", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool EFMJHNOBEMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8D3F240", Offset = "0x8D3E640", VA = "0x188D3F240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KIBLBENENKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xABB510", Offset = "0xABA910", VA = "0x180ABB510")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8D3F450", Offset = "0x8D3E850", VA = "0x188D3F450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JAEHOILEGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8D3F1A0", Offset = "0x8D3E5A0", VA = "0x188D3F1A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8D3F3B0", Offset = "0x8D3E7B0", VA = "0x188D3F3B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EBE0", Offset = "0x8D3DFE0", VA = "0x188D3EBE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EF80", Offset = "0x8D3E380", VA = "0x188D3EF80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EF30", Offset = "0x8D3E330", VA = "0x188D3EF30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EEA0", Offset = "0x8D3E2A0", VA = "0x188D3EEA0")]
		public void Hide(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F100", Offset = "0x8D3E500", VA = "0x188D3F100")]
		public void Show(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F010", Offset = "0x8D3E410", VA = "0x188D3F010")]
		public void Set(object MONGIMOHLAO, bool MBHBJCGIHOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EC70", Offset = "0x8D3E070", VA = "0x188D3EC70")]
		public void Clear(bool OAPLHGKAGOE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D3ED20", Offset = "0x8D3E120", VA = "0x188D3ED20")]
		private void HBIFLNIMJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EEB0", Offset = "0x8D3E2B0", VA = "0x188D3EEB0")]
		[IteratorStateMachine(typeof(CLLICJLCCCM))]
		private IEnumerator<KHJLACPAINM> NPKLINCJAGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D3ECE0", Offset = "0x8D3E0E0", VA = "0x188D3ECE0", Slot = "5")]
		public virtual void DoHideOrShow(bool LIPHAGOELDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F110", Offset = "0x8D3E510", VA = "0x188D3F110")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NBIDIGCPFIO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum HPHEPHPABPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static IPONJNHEOIB LGLGOJEGNFN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static IPONJNHEOIB CGLLJJFBOJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8D40290", Offset = "0x8D3F690", VA = "0x188D40290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static HPHEPHPABPG HCJBBHGLOLC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D40160", Offset = "0x8D3F560", VA = "0x188D40160")]
		get
		{
			return default(HPHEPHPABPG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FF20", Offset = "0x8D3F320", VA = "0x188D3FF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<HPHEPHPABPG> HPONHCLAJOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8D40390", Offset = "0x8D3F790", VA = "0x188D40390")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8D40080", Offset = "0x8D3F480", VA = "0x188D40080")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CIGMFNMKLOC : IDAMNHMBGIG, LKKEHMLNBON, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, LJILIPEHNOL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	OFFOKCJIMNI NBDFEPGANEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BENMIFMGNEN Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject MKFMLBCIMEB);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BENMIFMGNEN Spawn<T>(int AGLOABCPDIG, IReadOnlyList<T> NGIAGNLBILI, GameObject MKFMLBCIMEB);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BENMIFMGNEN Spawn<T>(int AGLOABCPDIG, IReadOnlyList<T> NGIAGNLBILI, GameObject NAIDACGNHKC, Func<int, GameObject> PMDIOOKPJIK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int NOEININIMIL, float KNPHIHFKEGF);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum CGAKAKAJICJ : byte
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

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int BDJFEFEBPLA;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<CGAKAKAJICJ, string> AMDJKKKJFNF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int OPDBHAOFGCB = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int FGGOHOKBAHJ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int NFIMDNCHNFO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int JJBCPOPMNGJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int JPIFOFOGGNC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int POGDBPECILP;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int OBLNIMCKPJF;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int IOKDIONIEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool FNIPNLJGMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool FMPHKGNGIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] CCICKBNNLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private CGAKAKAJICJ type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly CGAKAKAJICJ[] BNJGJMECDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[GKAGFGDDNKD("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly CGAKAKAJICJ[] DHBDFEPHEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[GKAGFGDDNKD("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[GKAGFGDDNKD("type", CGAKAKAJICJ.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[GKAGFGDDNKD("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic MPOHKCMGKMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool EEDDBDNDJKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient KKEMKGOKBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8D42560", Offset = "0x8D41960", VA = "0x188D42560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public CGAKAKAJICJ GBFFBDIJNIN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAD9120", Offset = "0xAD8520", VA = "0x180AD9120")]
			get
			{
				return default(CGAKAKAJICJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8D426E0", Offset = "0x8D41AE0", VA = "0x188D426E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool MBLKBBGMKCI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8D419F0", Offset = "0x8D40DF0", VA = "0x188D419F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 EBCOKCFFKFK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8D424D0", Offset = "0x8D418D0", VA = "0x188D424D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8D42510", Offset = "0x8D41910", VA = "0x188D42510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool BKOBMKDAPPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8D41FB0", Offset = "0x8D413B0", VA = "0x188D41FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 HNGFPHJMIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8D424F0", Offset = "0x8D418F0", VA = "0x188D424F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8D42690", Offset = "0x8D41A90", VA = "0x188D42690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float PAOMMCFKHCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xDD8DA0", Offset = "0xDD81A0", VA = "0x180DD8DA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x24CD7C0", Offset = "0x24CCBC0", VA = "0x1824CD7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 EKOJOAJBIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8D40EE0", Offset = "0x8D402E0", VA = "0x188D40EE0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 KHDDBNLKGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8D40F30", Offset = "0x8D40330", VA = "0x188D40F30")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float LODCPELAMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA89A50", Offset = "0xA88E50", VA = "0x180A89A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8D426F0", Offset = "0x8D41AF0", VA = "0x188D426F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D41C80", Offset = "0x8D41080", VA = "0x188D41C80", Slot = "12")]
		protected override void NLCEKFBCNBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8D41E20", Offset = "0x8D41220", VA = "0x188D41E20")]
		private void PBOELPOLIMG(Color[] HIGGHLLLHKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8D40FA0", Offset = "0x8D403A0", VA = "0x188D40FA0", Slot = "13")]
		protected override void HEIFHICNNBF(Material GMFBEMFEGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8D41A60", Offset = "0x8D40E60", VA = "0x188D41A60", Slot = "14")]
		protected override void NJNJALLDMJF(Material GMFBEMFEGJH, bool DGKJCLCLLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D42420", Offset = "0x8D41820", VA = "0x188D42420")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly MKLMCNOHHAB HKJNAHNCHIK;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite LEFJDKBGKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material ICIGNAECLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material LIIDNHAOGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool DGIFIKDMMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool BKCMGKPBBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool KELJNIJDKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool BNDKDEJCPNF;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic MPOHKCMGKMK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader HPCFFJACOED
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool EEDDBDNDJKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool EKJNIJMKAHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform JJOOEDGEKCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8D44090", Offset = "0x8D43490", VA = "0x188D44090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect LECNHHGDGHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8D43F70", Offset = "0x8D43370", VA = "0x188D43F70")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite PBCHJHFGAPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8D44170", Offset = "0x8D43570", VA = "0x188D44170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D436D0", Offset = "0x8D42AD0", VA = "0x188D436D0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D446B0", Offset = "0x8D43AB0", VA = "0x188D446B0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D449B0", Offset = "0x8D43DB0", VA = "0x188D449B0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D44860", Offset = "0x8D43C60", VA = "0x188D44860", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8D43DE0", Offset = "0x8D431E0", VA = "0x188D43DE0")]
		private void JKIAHNFOEJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8D43C70", Offset = "0x8D43070", VA = "0x188D43C70")]
		private void FKJNPMCDDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D440F0", Offset = "0x8D434F0", VA = "0x188D440F0")]
		private void NEJPBFKJFNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D44120", Offset = "0x8D43520", VA = "0x188D44120")]
		private void NGLMFENJIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8D438C0", Offset = "0x8D42CC0", VA = "0x188D438C0")]
		protected void BKKAFGCOLAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D43B30", Offset = "0x8D42F30", VA = "0x188D43B30")]
		private void EHNNONPJEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "12")]
		protected virtual void NLCEKFBCNBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "13")]
		protected virtual void HEIFHICNNBF(Material GMFBEMFEGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "14")]
		protected virtual void NJNJALLDMJF(Material GMFBEMFEGJH, bool DGKJCLCLLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8D44360", Offset = "0x8D43760", VA = "0x188D44360")]
		private void OEDBAGGLGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
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
			[SerializeField]
			[Range(0f, 2f)]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly int KEBJMCDIDNF;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int EDMCFMFEEIL;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int MPEKGAJHNHC;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int KDHAOFPJDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
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
		private Color[] CCICKBNNLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] PEGDGINMIJA;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic MPOHKCMGKMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool EKJNIJMKAHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> JIBEEAFGHMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 EBCOKCFFKFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x31C5E80", Offset = "0x31C5280", VA = "0x1831C5E80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8D45480", Offset = "0x8D44880", VA = "0x188D45480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D450C0", Offset = "0x8D444C0", VA = "0x188D450C0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> PDJEPIDGHDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D44E80", Offset = "0x8D44280", VA = "0x188D44E80")]
		public bool SetRingLayerColor(int DANOPCAPJEB, Color IFBOGFLAOGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D44FD0", Offset = "0x8D443D0", VA = "0x188D44FD0")]
		public bool SetRingLayerSize(int DANOPCAPJEB, float MPDDFCCPIOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D44D40", Offset = "0x8D44140", VA = "0x188D44D40", Slot = "12")]
		protected override void NLCEKFBCNBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D44B70", Offset = "0x8D43F70", VA = "0x188D44B70", Slot = "13")]
		protected override void HEIFHICNNBF(Material GMFBEMFEGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D44CF0", Offset = "0x8D440F0", VA = "0x188D44CF0", Slot = "14")]
		protected override void NJNJALLDMJF(Material GMFBEMFEGJH, bool DGKJCLCLLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D45210", Offset = "0x8D44610", VA = "0x188D45210")]
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
		public enum GKMEMIHLENM
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int DHCODGJHNKA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int MMJAEBIKLHE;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int ECDAPLAMNAP;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int FDCHIJLGMGB;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int JMMDACEACGH;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int JJEOPNNCKKD;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int HPIJPCFPPMF;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int ABDNMNNMLEB;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int NLDJHAOFBDF;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int KELCCNHKDGI;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int MLDPHMLIOEM;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int LHAABFIFEDE;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int ILMKGEPKEMJ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int ENOMMNKCGBK;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int GGNLNCMAEJJ;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int LFGLGHDGMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
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
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("The distance between each tile.")]
		[SerializeField]
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
		private GKMEMIHLENM animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[GKAGFGDDNKD("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[GKAGFGDDNKD("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic MPOHKCMGKMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool EKJNIJMKAHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite CFFPNHEMMOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8D462F0", Offset = "0x8D456F0", VA = "0x188D462F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8D46510", Offset = "0x8D45910", VA = "0x188D46510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color AIMPELMDGHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x102B400", Offset = "0x102A800", VA = "0x18102B400")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8D465A0", Offset = "0x8D459A0", VA = "0x188D465A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color IAFCNDNBALO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x125D0D0", Offset = "0x125C4D0", VA = "0x18125D0D0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8D463E0", Offset = "0x8D457E0", VA = "0x188D463E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float NKBMAMMCBCO
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xDD8C10", Offset = "0xDD8010", VA = "0x180DD8C10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8D464A0", Offset = "0x8D458A0", VA = "0x188D464A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 KCGFLFLOEKA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8D462D0", Offset = "0x8D456D0", VA = "0x188D462D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8D464C0", Offset = "0x8D458C0", VA = "0x188D464C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float JDOCBDPHMKD
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA896A0", Offset = "0xA88AA0", VA = "0x180A896A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8D46460", Offset = "0x8D45860", VA = "0x188D46460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 PNPNAIDPCCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x17849B0", Offset = "0x1783DB0", VA = "0x1817849B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8D46620", Offset = "0x8D45A20", VA = "0x188D46620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float FLEJLJJLJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x1234A70", Offset = "0x1233E70", VA = "0x181234A70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8D463B0", Offset = "0x8D457B0", VA = "0x188D463B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 DEHBODIDEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8D45E80", Offset = "0x8D45280", VA = "0x188D45E80")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public GKMEMIHLENM LPNENNNOPIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAD9090", Offset = "0xAD8490", VA = "0x180AD9090")]
			get
			{
				return default(GKMEMIHLENM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8D463D0", Offset = "0x8D457D0", VA = "0x188D463D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float HDAJHKOBCLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1934200", Offset = "0x1933600", VA = "0x181934200")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8D46480", Offset = "0x8D45880", VA = "0x188D46480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float FEBMCOLMJOG
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x18DAF20", Offset = "0x18DA320", VA = "0x1818DAF20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8D46390", Offset = "0x8D45790", VA = "0x188D46390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8D45780", Offset = "0x8D44B80", VA = "0x188D45780", Slot = "13")]
		protected override void HEIFHICNNBF(Material GMFBEMFEGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8D454D0", Offset = "0x8D448D0", VA = "0x188D454D0")]
		private void GCHNMKEOAEM(Sprite GJHLOEBOCLF, [Out] Vector2 LLJDMMMPMOD, [Out] Vector2 ENNPMGLJLOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8D45F10", Offset = "0x8D45310", VA = "0x188D45F10", Slot = "14")]
		protected override void NJNJALLDMJF(Material GMFBEMFEGJH, bool DGKJCLCLLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8D46240", Offset = "0x8D45640", VA = "0x188D46240")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader HPMJHDIKGEA;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader HPCFFJACOED
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8D466C0", Offset = "0x8D45AC0", VA = "0x188D466C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D46670", Offset = "0x8D45A70", VA = "0x188D46670")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class RectTransformHideableAdapter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private SerializableRectTransform hiddenRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private SerializableRectTransform FCAHKLLICCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool EHKIKJKJELJ;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D40A10", Offset = "0x8D3FE10", VA = "0x188D40A10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D40CF0", Offset = "0x8D400F0", VA = "0x188D40CF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D40BA0", Offset = "0x8D3FFA0", VA = "0x188D40BA0")]
		private void GEHIODDFHIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D40C20", Offset = "0x8D40020", VA = "0x188D40C20")]
		private void HBIFLNIMJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MKLMCNOHHAB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct NPGHIPOHBPA : IEquatable<NPGHIPOHBPA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component HFJHENFIDEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action CEIABPGBNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int MALLJIJHNOO;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component DDEDGOAKMIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D40590", Offset = "0x8D3F990", VA = "0x188D40590")]
		public NPGHIPOHBPA(Component HFJHENFIDEF, Action CEIABPGBNJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D40510", Offset = "0x8D3F910", VA = "0x188D40510")]
		public void KMBBCCKJAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D40470", Offset = "0x8D3F870", VA = "0x188D40470", Slot = "4")]
		public bool Equals(NPGHIPOHBPA LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D40480", Offset = "0x8D3F880", VA = "0x188D40480", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class PCKEFLPAEPB : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private KHJLACPAINM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public MKLMCNOHHAB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public PCKEFLPAEPB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D40600", Offset = "0x8D3FA00", VA = "0x188D40600", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D409C0", Offset = "0x8D3FDC0", VA = "0x188D409C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CANBKGNJDLB EHFANNMJKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int PFODNHECJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int LMFFFNMIHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> ANLIMJLGKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, NPGHIPOHBPA> GFDMBPIGMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<NPGHIPOHBPA> BOHKCFEMGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<NPGHIPOHBPA> GFPLFEHLCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private LDBPABGAEKE CGKIEFDOBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private APCKAFFCJDF NKJNCHELPGB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private APCKAFFCJDF NKBKOKPKBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F5F0", Offset = "0x8D3E9F0", VA = "0x188D3F5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FDA0", Offset = "0x8D3F1A0", VA = "0x188D3FDA0")]
	public MKLMCNOHHAB(CANBKGNJDLB EHFANNMJKPH, int PFODNHECJEG = -1, int LMFFFNMIHDG = -1, [Optional] Func<Component, float> ANLIMJLGKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8D3FB20", Offset = "0x8D3EF20", VA = "0x188D3FB20")]
	public void PCAFEJPOCFO(Component HFJHENFIDEF, Action GKJPEAFFBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F6E0", Offset = "0x8D3EAE0", VA = "0x188D3F6E0")]
	public void KPPCKCOGCIG(Component HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F680", Offset = "0x8D3EA80", VA = "0x188D3F680")]
	public bool KKGBKBCEJJK(Component FCIHIIPNCLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F8F0", Offset = "0x8D3ECF0", VA = "0x188D3F8F0")]
	private void ONHKMGJMLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F570", Offset = "0x8D3E970", VA = "0x188D3F570")]
	[IteratorStateMachine(typeof(PCKEFLPAEPB))]
	private IEnumerator<KHJLACPAINM> AFBADKNEIAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xF26590", Offset = "0xF25990", VA = "0x180F26590")]
	[CompilerGenerated]
	private void MGDFACINEIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8D3F870", Offset = "0x8D3EC70", VA = "0x188D3F870")]
	[CompilerGenerated]
	private float NKKAOKGJFGG(NPGHIPOHBPA GKJPEAFFBEP)
	{
		return default(float);
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
