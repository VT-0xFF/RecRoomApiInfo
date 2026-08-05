using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Com.TheFallenGames.OSA.Core;
using Cpp2IlInjected;
using RRUI.Audio;
using RRUI.Data;
using RecRoom;
using RecRoom.Async;
using RecRoom.Attributes;
using RecRoom.Core;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.Preferences;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using frame8.Logic.Misc.Visual.UI;

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
				[Cpp2IlInjected.Address(RVA = "0x8FB0A20", Offset = "0x8FAF820", VA = "0x188FB0A20")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8FB0A80", Offset = "0x8FAF880", VA = "0x188FB0A80")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8FB09E0", Offset = "0x8FAF7E0", VA = "0x188FB09E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8FB08D0", Offset = "0x8FAF6D0", VA = "0x188FB08D0")]
			public void TMOSIYLAKOX(PointerEventData a, RectTransform b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0640", Offset = "0x8FAF440", VA = "0x188FB0640")]
			public void PRKSXGPUBZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0570", Offset = "0x8FAF370", VA = "0x188FB0570")]
			public void NGIXZAJXHME(PointerEventData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0520", Offset = "0x8FAF320", VA = "0x188FB0520")]
			public void LJYQVBMQUPE(float a, RectTransform b, Vector3 c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly OZAYXQWBYWY<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly OZAYXQWBYWY<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly OZAYXQWBYWY<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly OZAYXQWBYWY<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly OZAYXQWBYWY<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly DQHMEXLDKHB PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData GSNZHKMHPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool BQVSAOEPHXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool ALOZDZHEJZV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KHMVVFOARFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xACFCF0", Offset = "0xACEAF0", VA = "0x180ACFCF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFCE0", Offset = "0x8FAEAE0", VA = "0x188FAFCE0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HYAMFSMMDOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xE16FE0", Offset = "0xE15DE0", VA = "0x180E16FE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFD90", Offset = "0x8FAEB90", VA = "0x188FAFD90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFD10", Offset = "0x8FAEB10", VA = "0x188FAFD10")]
		private bool ASRFFINGXGV(PointerEventData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0220", Offset = "0x8FAF020", VA = "0x188FB0220", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8FB02E0", Offset = "0x8FAF0E0", VA = "0x188FB02E0", Slot = "11")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0080", Offset = "0x8FAEE80", VA = "0x188FB0080", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFDC0", Offset = "0x8FAEBC0", VA = "0x188FAFDC0", Slot = "7")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFED0", Offset = "0x8FAECD0", VA = "0x188FAFED0", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFFB0", Offset = "0x8FAEDB0", VA = "0x188FAFFB0", Slot = "8")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0280", Offset = "0x8FAF080", VA = "0x188FB0280", Slot = "9")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB02B0", Offset = "0x8FAF0B0", VA = "0x188FB02B0", Slot = "10")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFE90", Offset = "0x8FAEC90", VA = "0x188FAFE90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0340", Offset = "0x8FAF140", VA = "0x188FB0340")]
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
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8FABB10", Offset = "0x8FAA910", VA = "0x188FABB10")]
		public void SetCanvasSortingOrder(short order, bool activateCanvasGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData FEMWNJXTKMQ;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FABDD0", Offset = "0x8FAABD0", VA = "0x188FABDD0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8FABCB0", Offset = "0x8FAAAB0", VA = "0x188FABCB0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8FABC00", Offset = "0x8FAAA00", VA = "0x188FABC00")]
		private void KSTDNXRPJDN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC0A0", Offset = "0x8FAAEA0", VA = "0x188FAC0A0")]
		public void SetOptionsWithNoDefault(List<string> values, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8FABFC0", Offset = "0x8FAADC0", VA = "0x188FABFC0")]
		public void SetOptionsWithNoDefault(List<OptionData> options, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8FABEF0", Offset = "0x8FAACF0", VA = "0x188FABEF0", Slot = "44")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "47")]
		protected override GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC2A0", Offset = "0x8FAB0A0", VA = "0x188FAC2A0")]
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
		private sealed class RDBWWLCDPDU : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public RDBWWLCDPDU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8FADBB0", Offset = "0x8FAC9B0", VA = "0x188FADBB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8FADB70", Offset = "0x8FAC970", VA = "0x188FADB70", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly LCYODOXSSEV<object> OAXGEHAQRWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool SDBNOMKCCYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? ACBFCAGTSVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? LVUDAPCCQBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? RBMTYQBRYMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool DFXJHYMSLZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool YGYEJHDKWRF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ignoreLayout
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD300", Offset = "0x8FAC100", VA = "0x188FAD300", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool YSKYZZGACZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD2B0", Offset = "0x8FAC0B0", VA = "0x188FAD2B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EGYLHVVXVFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB09E60", Offset = "0xB08C60", VA = "0x180B09E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD4E0", Offset = "0x8FAC2E0", VA = "0x188FAD4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KSJCDPUJWRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD210", Offset = "0x8FAC010", VA = "0x188FAD210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD440", Offset = "0x8FAC240", VA = "0x188FAD440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8FACC70", Offset = "0x8FABA70", VA = "0x188FACC70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8FACE80", Offset = "0x8FABC80", VA = "0x188FACE80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8FACE30", Offset = "0x8FABC30", VA = "0x188FACE30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8FACE20", Offset = "0x8FABC20", VA = "0x188FACE20")]
		public void Hide(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD180", Offset = "0x8FABF80", VA = "0x188FAD180")]
		public void Show(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD090", Offset = "0x8FABE90", VA = "0x188FAD090")]
		public void Set(object token, bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8FACD00", Offset = "0x8FABB00", VA = "0x188FACD00")]
		public void Clear(bool refresh = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8FACF10", Offset = "0x8FABD10", VA = "0x188FACF10")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8FACDB0", Offset = "0x8FABBB0", VA = "0x188FACDB0")]
		[IteratorStateMachine(typeof(RDBWWLCDPDU))]
		private IEnumerator<IMKAVQMVTAL> FHNUSQWIUDZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8FACD70", Offset = "0x8FABB70", VA = "0x188FACD70", Slot = "5")]
		public virtual void DoHideOrShow(bool shouldHide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD190", Offset = "0x8FABF90", VA = "0x188FAD190")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class VQDPCCOUOEA
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum ThemeOptions
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Light,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			Dark
		}

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static AWJSQTHCCJW UIVKJOGTTKK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static AWJSQTHCCJW FYDCOBBFGDN
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3F30", Offset = "0x8FB2D30", VA = "0x188FB3F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static ThemeOptions XIFWJCJJUFO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3E00", Offset = "0x8FB2C00", VA = "0x188FB3E00")]
			get
			{
				return default(ThemeOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3BD0", Offset = "0x8FB29D0", VA = "0x188FB3BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event Action<ThemeOptions> LHBYPUTUAYU
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8FB4050", Offset = "0x8FB2E50", VA = "0x188FB4050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3D30", Offset = "0x8FB2B30", VA = "0x188FB3D30")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface GKDWBRBSWFO : IOZNYZIYTFB, BUBSAJMBFVN, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, OVOQKHAXHFN
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		DQHMEXLDKHB LMXSKUKKERS
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SGMUANPBQKN Clear();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SpawnLoadingPlaceholders(GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		SGMUANPBQKN Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SGMUANPBQKN Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject defaultPrefab, Func<int, GameObject> getPrefabForIndexEvent);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SmoothScrollTo(int index, float scrollDuration);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum GradientType : byte
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
			Disabled = 255
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int PORKFETZAFD;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<GradientType, string> OPGPCMDFJBN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int XZNDSJYVGGU = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int PKHUOMAWZZQ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int CFNAJAFRGAM;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int CVMFGNIVSYT;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int QHNMTIXOBWD;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int VVXBOIPVGCY;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int PXHRLGXAVZY;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int ITGVXIKYCGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool EGCHZQBDXRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool JJTDYXCJAXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] OOBJUTXWZZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GradientType type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly GradientType[] GCWDPVUTBUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[ConditionalField("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly GradientType[] JOAHITWFIXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[ConditionalField("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[ConditionalField("type", GradientType.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ConditionalField("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic JPIDOPVGLSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool OZECQHGFVQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient OUQBWIPBJTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFB40", Offset = "0x8FAE940", VA = "0x188FAFB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public GradientType QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xE16FB0", Offset = "0xE15DB0", VA = "0x180E16FB0")]
			get
			{
				return default(GradientType);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFCB0", Offset = "0x8FAEAB0", VA = "0x188FAFCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool URFFZKDDFVU
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF4F0", Offset = "0x8FAE2F0", VA = "0x188FAF4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 MYVIYGGFQZI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFAB0", Offset = "0x8FAE8B0", VA = "0x188FAFAB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFAF0", Offset = "0x8FAE8F0", VA = "0x188FAFAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool ZBYVLRPBBHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF560", Offset = "0x8FAE360", VA = "0x188FAF560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 GLTCDKGXFXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFAD0", Offset = "0x8FAE8D0", VA = "0x188FAFAD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFC60", Offset = "0x8FAEA60", VA = "0x188FAFC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float XSFSKLXKSJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xE32F20", Offset = "0xE31D20", VA = "0x180E32F20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2523030", Offset = "0x2521E30", VA = "0x182523030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 HHTXCRTOKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF5D0", Offset = "0x8FAE3D0", VA = "0x188FAF5D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 FIZIYOHUVXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF480", Offset = "0x8FAE280", VA = "0x188FAF480")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float PFSJBQRGGKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAD9060", Offset = "0xAD7E60", VA = "0x180AD9060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8FAFCC0", Offset = "0x8FAEAC0", VA = "0x188FAFCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE560", Offset = "0x8FAD360", VA = "0x188FAE560", Slot = "12")]
		protected override void DIOJEZJCKGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE700", Offset = "0x8FAD500", VA = "0x188FAE700")]
		private void FOAOUDNTISJ(Color[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEAB0", Offset = "0x8FAD8B0", VA = "0x188FAEAB0", Slot = "13")]
		protected override void KKPNWJWCBIZ(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE890", Offset = "0x8FAD690", VA = "0x188FAE890", Slot = "14")]
		protected override void GNLSCAVPXSQ(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFA00", Offset = "0x8FAE800", VA = "0x188FAFA00")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly FIOQYLAMCUO BCITNMXFBOA;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite QUIJQDWFXMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material ANLTHJLYALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material OWUJRTDHWVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool OTBYTFMHYUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool SDBNOMKCCYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool OEEQLQXVDYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool UZNUTBIRRUB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic JPIDOPVGLSF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader QMWHAZYPGOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool OZECQHGFVQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool TEVPOQMSCTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform WTUSBTMSLWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8FB1EC0", Offset = "0x8FB0CC0", VA = "0x188FB1EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect YXWBKWNNUHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8FB13E0", Offset = "0x8FB01E0", VA = "0x188FB13E0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite OXIOLIFLWTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0C70", Offset = "0x8FAFA70", VA = "0x188FB0C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E60", Offset = "0x8FAFC60", VA = "0x188FB0E60", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1BC0", Offset = "0x8FB09C0", VA = "0x188FB1BC0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1EB0", Offset = "0x8FB0CB0", VA = "0x188FB1EB0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1D60", Offset = "0x8FB0B60", VA = "0x188FB1D60", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1A40", Offset = "0x8FB0840", VA = "0x188FB1A40")]
		private void LWWPQQBAKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB18E0", Offset = "0x8FB06E0", VA = "0x188FB18E0")]
		private void KWWELWLEKSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB18B0", Offset = "0x8FB06B0", VA = "0x188FB18B0")]
		private void KOIHXBRARRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1390", Offset = "0x8FB0190", VA = "0x188FB1390")]
		private void EHQWYLPZJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1640", Offset = "0x8FB0440", VA = "0x188FB1640")]
		protected void KKNRNMXPXNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1500", Offset = "0x8FB0300", VA = "0x188FB1500")]
		private void KBWTUEQIPFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "12")]
		protected virtual void DIOJEZJCKGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "13")]
		protected virtual void KKPNWJWCBIZ(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "14")]
		protected virtual void GNLSCAVPXSQ(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1040", Offset = "0x8FAFE40", VA = "0x188FB1040")]
		private void DZHANLPLEPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
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
			[Range(0f, 2f)]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly int HIVKHZFAIJO;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int BTSHHSCKJLA;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int TNEETDAHNCF;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int GILYZGHHATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Color[] OOBJUTXWZZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] LPTHVYRDMKP;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic JPIDOPVGLSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool TEVPOQMSCTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> GZMFXJVRZLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 MYVIYGGFQZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF20200", Offset = "0xF1F000", VA = "0x180F20200")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8FB2970", Offset = "0x8FB1770", VA = "0x188FB2970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8FB25B0", Offset = "0x8FB13B0", VA = "0x188FB25B0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> newLayers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2370", Offset = "0x8FB1170", VA = "0x188FB2370")]
		public bool SetRingLayerColor(int layer, Color color)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB24C0", Offset = "0x8FB12C0", VA = "0x188FB24C0")]
		public bool SetRingLayerSize(int layer, float size)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB20A0", Offset = "0x8FB0EA0", VA = "0x188FB20A0", Slot = "12")]
		protected override void DIOJEZJCKGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2230", Offset = "0x8FB1030", VA = "0x188FB2230", Slot = "13")]
		protected override void KKPNWJWCBIZ(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8FB21E0", Offset = "0x8FB0FE0", VA = "0x188FB21E0", Slot = "14")]
		protected override void GNLSCAVPXSQ(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2700", Offset = "0x8FB1500", VA = "0x188FB2700")]
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
		public enum AnimationType
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int BQOSMLIYKIH;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int LOCQOCJHSNW;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int PAZIWFIRWWW;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int BRLGHOLQRYA;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int MGEEWSTTMYL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int YRRMLRGZSQE;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int TFPTFIXGLSC;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int WDINOUXUWKH;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int RNGDYBDRNUU;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int MGCKRWJBUJU;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int HPANNJSBGUT;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int MQEMQGMTFYT;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int BMESPBKYEQA;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int XWBZVHBERVV;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int CKJMQPZHQWC;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int HHIYTBNLNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[Tooltip("The offset applied to each alternating row or column.")]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private AnimationType animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[ConditionalField("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[ConditionalField("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic JPIDOPVGLSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool TEVPOQMSCTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CA0", Offset = "0xAD7AA0", VA = "0x180AD8CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite XIOFWYJYSRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3730", Offset = "0x8FB2530", VA = "0x188FB3730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3960", Offset = "0x8FB2760", VA = "0x188FB3960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color HZCPAGQGDRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xED04D0", Offset = "0xECF2D0", VA = "0x180ED04D0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8FB39F0", Offset = "0x8FB27F0", VA = "0x188FB39F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color VQBQVJHVVDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xED0500", Offset = "0xECF300", VA = "0x180ED0500")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3830", Offset = "0x8FB2630", VA = "0x188FB3830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float FVGQJNNAVUW
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xE32F10", Offset = "0xE31D10", VA = "0x180E32F10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8FB38F0", Offset = "0x8FB26F0", VA = "0x188FB38F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 PSBYBLAEKJC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x12B3590", Offset = "0x12B2390", VA = "0x1812B3590")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3910", Offset = "0x8FB2710", VA = "0x188FB3910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float APVUGZXIKWY
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAD8CB0", Offset = "0xAD7AB0", VA = "0x180AD8CB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8FB38B0", Offset = "0x8FB26B0", VA = "0x188FB38B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 CFIBKJQGMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x17FB660", Offset = "0x17FA460", VA = "0x1817FB660")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3A70", Offset = "0x8FB2870", VA = "0x188FB3A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float MJQLEBVSLBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x12ADBA0", Offset = "0x12AC9A0", VA = "0x1812ADBA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8FB37F0", Offset = "0x8FB25F0", VA = "0x188FB37F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 IIYBEFNGZHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3360", Offset = "0x8FB2160", VA = "0x188FB3360")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AnimationType ZJIYPUWVMZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1003D70", Offset = "0x1002B70", VA = "0x181003D70")]
			get
			{
				return default(AnimationType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3810", Offset = "0x8FB2610", VA = "0x188FB3810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float QSGVQXLIMVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x12AA0D0", Offset = "0x12A8ED0", VA = "0x1812AA0D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8FB38D0", Offset = "0x8FB26D0", VA = "0x188FB38D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float XNVFPGSLQKX
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xF49850", Offset = "0xF48650", VA = "0x180F49850")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8FB37D0", Offset = "0x8FB25D0", VA = "0x188FB37D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2CC0", Offset = "0x8FB1AC0", VA = "0x188FB2CC0", Slot = "13")]
		protected override void KKPNWJWCBIZ(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB29C0", Offset = "0x8FB17C0", VA = "0x188FB29C0")]
		private void ARHBNFTWBVH(Sprite a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB2C70", Offset = "0x8FB1A70", VA = "0x188FB2C70", Slot = "14")]
		protected override void GNLSCAVPXSQ(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB36A0", Offset = "0x8FB24A0", VA = "0x188FB36A0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader UFJITGWAMXD;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader QMWHAZYPGOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3B10", Offset = "0x8FB2910", VA = "0x188FB3B10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3AC0", Offset = "0x8FB28C0", VA = "0x188FB3AC0")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class RectTransformHideableAdapter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private SerializableRectTransform hiddenRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private SerializableRectTransform WBOSTAHYOPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool AAPYOPQGALG;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE0C0", Offset = "0x8FACEC0", VA = "0x188FAE0C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE2C0", Offset = "0x8FAD0C0", VA = "0x188FAE2C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE240", Offset = "0x8FAD040", VA = "0x188FAE240")]
		private void FZEDNLDYUHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE3C0", Offset = "0x8FAD1C0", VA = "0x188FAE3C0")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
namespace RRUI.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FIOQYLAMCUO
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private struct QueuedOperation : IEquatable<QueuedOperation>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private readonly Component context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private readonly Action refreshOperation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private readonly int hashCode;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Component IGKASUHZGUG
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8FADB00", Offset = "0x8FAC900", VA = "0x188FADB00")]
			public QueuedOperation(Component context, Action refreshOperation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8FADA80", Offset = "0x8FAC880", VA = "0x188FADA80")]
			public void QAHVXBBHYNQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD9E0", Offset = "0x8FAC7E0", VA = "0x188FAD9E0", Slot = "4")]
			public bool Equals(QueuedOperation other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD9F0", Offset = "0x8FAC7F0", VA = "0x188FAD9F0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class OKRZZFDUPZR : IEnumerator<IMKAVQMVTAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private IMKAVQMVTAL QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public FIOQYLAMCUO WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private IMKAVQMVTAL TBVNXHVEJNY
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public OKRZZFDUPZR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD640", Offset = "0x8FAC440", VA = "0x188FAD640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD600", Offset = "0x8FAC400", VA = "0x188FAD600", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly ScheduleQueueType CALTPJHTDPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly int VMNQKWDYLRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly int FVVQIKQJYJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly Func<Component, float> ULWMYTWEFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly Dictionary<Component, QueuedOperation> UNSKKDHLJZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly LinkedList<QueuedOperation> EMIYXFOTQLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly List<QueuedOperation> UWCWVTUTEEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private DLHIAPQRHVO VZCJTNMKILQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private XRHBEMYGAXH FZDAXGLHLXR;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private XRHBEMYGAXH TMNKLGDJEFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8FAC7A0", Offset = "0x8FAB5A0", VA = "0x188FAC7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8FACB10", Offset = "0x8FAB910", VA = "0x188FACB10")]
		public FIOQYLAMCUO(ScheduleQueueType a, int b = -1, int c = -1, [Optional] Func<Component, float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC520", Offset = "0x8FAB320", VA = "0x188FAC520")]
		public void GYFCWFQXZJN(Component a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC980", Offset = "0x8FAB780", VA = "0x188FAC980")]
		public void ZBLFMWXAKAZ(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC830", Offset = "0x8FAB630", VA = "0x188FAC830")]
		public bool UCGEZXQYLDD(Component a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC2F0", Offset = "0x8FAB0F0", VA = "0x188FAC2F0")]
		private void BZBZVXIKPUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC890", Offset = "0x8FAB690", VA = "0x188FAC890")]
		[IteratorStateMachine(typeof(OKRZZFDUPZR))]
		private IEnumerator<IMKAVQMVTAL> UICHZFURBDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7422BC0", Offset = "0x74219C0", VA = "0x187422BC0")]
		[CompilerGenerated]
		private void FPMCGTTVVBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC900", Offset = "0x8FAB700", VA = "0x188FAC900")]
		[CompilerGenerated]
		private float UQYJGUZEXEG(QueuedOperation a)
		{
			return default(float);
		}
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
