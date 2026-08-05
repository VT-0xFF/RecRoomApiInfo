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
				[Cpp2IlInjected.Address(RVA = "0x8F2E1F0", Offset = "0x8F2C7F0", VA = "0x188F2E1F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8F2E250", Offset = "0x8F2C850", VA = "0x188F2E250")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8F2E1B0", Offset = "0x8F2C7B0", VA = "0x188F2E1B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8F2E0A0", Offset = "0x8F2C6A0", VA = "0x188F2E0A0")]
			public void WRVYBUGVABW(PointerEventData a, RectTransform b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8F2DD40", Offset = "0x8F2C340", VA = "0x188F2DD40")]
			public void UQBVTICHTNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8F2DFD0", Offset = "0x8F2C5D0", VA = "0x188F2DFD0")]
			public void VOIVSKTZSDZ(PointerEventData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8F2DCF0", Offset = "0x8F2C2F0", VA = "0x188F2DCF0")]
			public void AEVZTNLZZCX(float a, RectTransform b, Vector3 c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
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
		public readonly YQBTYEHUFCJ<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly YQBTYEHUFCJ<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly YQBTYEHUFCJ<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly YQBTYEHUFCJ<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly YQBTYEHUFCJ<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly ENIVEIKFIDY PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData MZFXJIYNBXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool FYLVLKXIOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool PEMFXMUABVO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HKLGVMDQKLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xAB7E90", Offset = "0xAB6490", VA = "0x180AB7E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8F2D4B0", Offset = "0x8F2BAB0", VA = "0x188F2D4B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PBFUABLIEVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xE57680", Offset = "0xE55C80", VA = "0x180E57680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8F2DA60", Offset = "0x8F2C060", VA = "0x188F2DA60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8F2DA90", Offset = "0x8F2C090", VA = "0x188F2DA90")]
		private bool SDTKGLTVAPC(PointerEventData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D940", Offset = "0x8F2BF40", VA = "0x188F2D940", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F2DA00", Offset = "0x8F2C000", VA = "0x188F2DA00", Slot = "11")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D7A0", Offset = "0x8F2BDA0", VA = "0x188F2D7A0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D4E0", Offset = "0x8F2BAE0", VA = "0x188F2D4E0", Slot = "7")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D5F0", Offset = "0x8F2BBF0", VA = "0x188F2D5F0", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D6D0", Offset = "0x8F2BCD0", VA = "0x188F2D6D0", Slot = "8")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D9A0", Offset = "0x8F2BFA0", VA = "0x188F2D9A0", Slot = "9")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D9D0", Offset = "0x8F2BFD0", VA = "0x188F2D9D0", Slot = "10")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D5B0", Offset = "0x8F2BBB0", VA = "0x188F2D5B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F2DB10", Offset = "0x8F2C110", VA = "0x188F2DB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F28DA0", Offset = "0x8F273A0", VA = "0x188F28DA0")]
		public void SetCanvasSortingOrder(short order, bool activateCanvasGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData YBUVNWGNQTH;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F29060", Offset = "0x8F27660", VA = "0x188F29060", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8F28F40", Offset = "0x8F27540", VA = "0x188F28F40", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8F28E90", Offset = "0x8F27490", VA = "0x188F28E90")]
		private void MAJORPXHTZC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F29330", Offset = "0x8F27930", VA = "0x188F29330")]
		public void SetOptionsWithNoDefault(List<string> values, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8F29250", Offset = "0x8F27850", VA = "0x188F29250")]
		public void SetOptionsWithNoDefault(List<OptionData> options, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F29180", Offset = "0x8F27780", VA = "0x188F29180", Slot = "44")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "47")]
		protected override GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F29530", Offset = "0x8F27B30", VA = "0x188F29530")]
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
		private sealed class HYTPSSXAXYN : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public HYTPSSXAXYN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8F29580", Offset = "0x8F27B80", VA = "0x188F29580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8F29A90", Offset = "0x8F28090", VA = "0x188F29A90", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
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
		private readonly URYAHYSGPMI<object> GEDHIUMFCXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool UDKNVIJCDZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? CGLTVBGUHYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? VUPVUVYKKQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? XCNAVBECDYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool JSDXGDNKSUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool CEIWYABNTBK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ignoreLayout
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A150", Offset = "0x8F28750", VA = "0x188F2A150", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HRURTDLDKCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A100", Offset = "0x8F28700", VA = "0x188F2A100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BATSEAHNJZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAF2330", Offset = "0xAF0930", VA = "0x180AF2330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A330", Offset = "0x8F28930", VA = "0x188F2A330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action MSYELKIGXDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A060", Offset = "0x8F28660", VA = "0x188F2A060")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A290", Offset = "0x8F28890", VA = "0x188F2A290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F29AD0", Offset = "0x8F280D0", VA = "0x188F29AD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8F29C70", Offset = "0x8F28270", VA = "0x188F29C70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F29C20", Offset = "0x8F28220", VA = "0x188F29C20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F29C10", Offset = "0x8F28210", VA = "0x188F29C10")]
		public void Hide(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F29F60", Offset = "0x8F28560", VA = "0x188F29F60")]
		public void Show(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F29E70", Offset = "0x8F28470", VA = "0x188F29E70")]
		public void Set(object token, bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F29B60", Offset = "0x8F28160", VA = "0x188F29B60")]
		public void Clear(bool refresh = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F29D00", Offset = "0x8F28300", VA = "0x188F29D00")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8F29F70", Offset = "0x8F28570", VA = "0x188F29F70")]
		[IteratorStateMachine(typeof(HYTPSSXAXYN))]
		private IEnumerator<SGCTHXNJFVM> WEJAKVAQGVM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8F29BD0", Offset = "0x8F281D0", VA = "0x188F29BD0", Slot = "5")]
		public virtual void DoHideOrShow(bool shouldHide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8F29FE0", Offset = "0x8F285E0", VA = "0x188F29FE0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class LGFMQIHHXUP
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
		private static WQEISMLFQPB NOVIAZXCEEV;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static WQEISMLFQPB JZFKDAUMBDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A520", Offset = "0x8F28B20", VA = "0x188F2A520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static ThemeOptions ECQANZPTYJL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A870", Offset = "0x8F28E70", VA = "0x188F2A870")]
			get
			{
				return default(ThemeOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A640", Offset = "0x8F28C40", VA = "0x188F2A640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event Action<ThemeOptions> ZCCMEKLGGON
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A450", Offset = "0x8F28A50", VA = "0x188F2A450")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2A7A0", Offset = "0x8F28DA0", VA = "0x188F2A7A0")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface GDLEYXDAKPX : OTWKPLRFCCY, BDQMSQUCFYU, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, PWJMHXMFJWU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		ENIVEIKFIDY PXZBSZPQKIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FOIFKSVRRKC Clear();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SpawnLoadingPlaceholders(GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FOIFKSVRRKC Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		FOIFKSVRRKC Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject defaultPrefab, Func<int, GameObject> getPrefabForIndexEvent);

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
		private static readonly int DHXQKWAQFXQ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<GradientType, string> BYXJVTUMEJG;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int ZUUAMFGJIFV = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int YDWHKCYUHWZ;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int ROCQAMUOPPB;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int CDZNGKMRFTK;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int BOBQHEDNEUG;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int YNMKLCFTHQN;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int AIYBLMHDMDV;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int NCGMMKKJZDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool FQCSHZZRETK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool ELLJPLCOQMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] IOGFJLLZEYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GradientType type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly GradientType[] BUUYAJYWKVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[ConditionalField("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly GradientType[] PNXKVMFYVMD;

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
		public override Graphic GDCQBFITHUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool LULDJRRCTSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient EVTHWTIWJNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8F2D310", Offset = "0x8F2B910", VA = "0x188F2D310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public GradientType BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xE57650", Offset = "0xE55C50", VA = "0x180E57650")]
			get
			{
				return default(GradientType);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8F2D480", Offset = "0x8F2BA80", VA = "0x188F2D480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool NVMUAKHPUXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BD30", Offset = "0x8F2A330", VA = "0x188F2BD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 CDXVREKCEOF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8F2D280", Offset = "0x8F2B880", VA = "0x188F2D280")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8F2D2C0", Offset = "0x8F2B8C0", VA = "0x188F2D2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool ZIXJRJZCGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8F2C220", Offset = "0x8F2A820", VA = "0x188F2C220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 ZZGGBTRPGMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8F2D2A0", Offset = "0x8F2B8A0", VA = "0x188F2D2A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8F2D430", Offset = "0x8F2BA30", VA = "0x188F2D430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float QMPRFQSMHCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xE7D6C0", Offset = "0xE7BCC0", VA = "0x180E7D6C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x25B41F0", Offset = "0x25B27F0", VA = "0x1825B41F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 GWWLEOLENHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8F2C1D0", Offset = "0x8F2A7D0", VA = "0x188F2C1D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 VPJUHSIYSQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8F2C160", Offset = "0x8F2A760", VA = "0x188F2C160")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float AMEQEUFYNKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAC1710", Offset = "0xABFD10", VA = "0x180AC1710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8F2D490", Offset = "0x8F2BA90", VA = "0x188F2D490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BFC0", Offset = "0x8F2A5C0", VA = "0x188F2BFC0", Slot = "12")]
		protected override void MNIESVRJCCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CC60", Offset = "0x8F2B260", VA = "0x188F2CC60")]
		private void ZVTNTRLXQYG(Color[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8F2C290", Offset = "0x8F2A890", VA = "0x188F2C290", Slot = "13")]
		protected override void YRDZLWKBFHG(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BDA0", Offset = "0x8F2A3A0", VA = "0x188F2BDA0", Slot = "14")]
		protected override void LLIVSZVMROR(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2D1D0", Offset = "0x8F2B7D0", VA = "0x188F2D1D0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly OUCYLUIXGOR BCLFMCTFQFF;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite HKDQTLHMGPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material JQKRFYIEENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material BXEWFWCVOUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool IDYBIUFTFSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool UDKNVIJCDZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool MYEAZDUISOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool UDUJXTGJWIY;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic GDCQBFITHUY
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader MBKVDDXXLWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool LULDJRRCTSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool AIOPYNSMIFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform RMVHGRLYSVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8F2E440", Offset = "0x8F2CA40", VA = "0x188F2E440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect EKHVQRVCKKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8F2F0C0", Offset = "0x8F2D6C0", VA = "0x188F2F0C0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite TKLSBMCBBGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8F2EA50", Offset = "0x8F2D050", VA = "0x188F2EA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8F2E710", Offset = "0x8F2CD10", VA = "0x188F2E710", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EDC0", Offset = "0x8F2D3C0", VA = "0x188F2EDC0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F0B0", Offset = "0x8F2D6B0", VA = "0x188F2F0B0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EF60", Offset = "0x8F2D560", VA = "0x188F2EF60", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EC40", Offset = "0x8F2D240", VA = "0x188F2EC40")]
		private void OOATQAHTWML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8F2E8F0", Offset = "0x8F2CEF0", VA = "0x188F2E8F0")]
		private void INXALMZFTWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F1E0", Offset = "0x8F2D7E0", VA = "0x188F2F1E0")]
		private void TTMYMKLJOBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F210", Offset = "0x8F2D810", VA = "0x188F2F210")]
		private void YILMEDWLEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8F2E4A0", Offset = "0x8F2CAA0", VA = "0x188F2E4A0")]
		protected void AFWNDUUOGDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F260", Offset = "0x8F2D860", VA = "0x188F2F260")]
		private void ZPRSQFZCVYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "12")]
		protected virtual void MNIESVRJCCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "13")]
		protected virtual void YRDZLWKBFHG(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "14")]
		protected virtual void LLIVSZVMROR(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F3A0", Offset = "0x8F2D9A0", VA = "0x188F2F3A0")]
		private void ZTHJWTYDTDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
		private static readonly int YUQDYHWKPOH;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int KDMHMWEWGFJ;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int EIHHPBFSQHU;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int AXIBMZGHZRH;

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
		private Color[] IOGFJLLZEYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] FYFBVEWJJEK;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic GDCQBFITHUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool AIOPYNSMIFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> CNGRKEBBKLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 CDXVREKCEOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF74940", Offset = "0xF72F40", VA = "0x180F74940")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8F30140", Offset = "0x8F2E740", VA = "0x188F30140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8F2FC40", Offset = "0x8F2E240", VA = "0x188F2FC40")]
		public void SetRingLayers(IReadOnlyList<RingLayer> newLayers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8F2FA00", Offset = "0x8F2E000", VA = "0x188F2FA00")]
		public bool SetRingLayerColor(int layer, Color color)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2FB50", Offset = "0x8F2E150", VA = "0x188F2FB50")]
		public bool SetRingLayerSize(int layer, float size)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F8C0", Offset = "0x8F2DEC0", VA = "0x188F2F8C0", Slot = "12")]
		protected override void MNIESVRJCCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8F2FCC0", Offset = "0x8F2E2C0", VA = "0x188F2FCC0", Slot = "13")]
		protected override void YRDZLWKBFHG(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F870", Offset = "0x8F2DE70", VA = "0x188F2F870", Slot = "14")]
		protected override void LLIVSZVMROR(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8F2FED0", Offset = "0x8F2E4D0", VA = "0x188F2FED0")]
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
		private static readonly int BHTYJOIQHPG;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int LWBILJGLXMJ;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int RSTLLOUBPJV;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int SGSJYWVRFOX;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int VRRIQKDWOZG;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int TVBMFYOZPLT;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int KUBBTPSQDRH;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int ONANUERVPXI;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int VCTAFMBEFEZ;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int CRGLCBNZOJV;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int PVZEFGHNIUM;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int WSTBZQZXAYU;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int VAPCWLBPQCP;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int DSBHONBQGDY;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int PKXRNNCZOHH;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int UTGMYEWJPZW;

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
		public override Graphic GDCQBFITHUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool AIOPYNSMIFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite QABAIDPHXMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8F30F00", Offset = "0x8F2F500", VA = "0x188F30F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8F31130", Offset = "0x8F2F730", VA = "0x188F31130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color RQGJTWAYZOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF33210", Offset = "0xF31810", VA = "0x180F33210")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8F311C0", Offset = "0x8F2F7C0", VA = "0x188F311C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color LUEEDHDYCQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xF33220", Offset = "0xF31820", VA = "0x180F33220")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8F31000", Offset = "0x8F2F600", VA = "0x188F31000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float DPEDHEUMUIN
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xE7DD70", Offset = "0xE7C370", VA = "0x180E7DD70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8F310C0", Offset = "0x8F2F6C0", VA = "0x188F310C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 JVOGZHFQUIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x1317940", Offset = "0x1315F40", VA = "0x181317940")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8F310E0", Offset = "0x8F2F6E0", VA = "0x188F310E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float YKTGULEOTLB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xABF960", VA = "0x180AC1360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8F31080", Offset = "0x8F2F680", VA = "0x188F31080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 HJKSFESWGRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x184BD90", Offset = "0x184A390", VA = "0x18184BD90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8F31240", Offset = "0x8F2F840", VA = "0x188F31240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float OTTCZPDEDUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x13016E0", Offset = "0x12FFCE0", VA = "0x1813016E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8F30FC0", Offset = "0x8F2F5C0", VA = "0x188F30FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 BATIHPUHOED
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8F30490", Offset = "0x8F2EA90", VA = "0x188F30490")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AnimationType LUMSZBZZSDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x106E320", Offset = "0x106C920", VA = "0x18106E320")]
			get
			{
				return default(AnimationType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8F30FE0", Offset = "0x8F2F5E0", VA = "0x188F30FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float TADWJIVZWRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1317280", Offset = "0x1315880", VA = "0x181317280")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8F310A0", Offset = "0x8F2F6A0", VA = "0x188F310A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float JZSGAMDAHDM
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xFA04A0", Offset = "0xF9EAA0", VA = "0x180FA04A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8F30FA0", Offset = "0x8F2F5A0", VA = "0x188F30FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8F30520", Offset = "0x8F2EB20", VA = "0x188F30520", Slot = "13")]
		protected override void YRDZLWKBFHG(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8F30190", Offset = "0x8F2E790", VA = "0x188F30190")]
		private void DUQZHJUNNOS(Sprite a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8F30440", Offset = "0x8F2EA40", VA = "0x188F30440", Slot = "14")]
		protected override void LLIVSZVMROR(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8F30E70", Offset = "0x8F2F470", VA = "0x188F30E70")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader OHTWAYMDZZS;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader MBKVDDXXLWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8F312E0", Offset = "0x8F2F8E0", VA = "0x188F312E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8F31290", Offset = "0x8F2F890", VA = "0x188F31290")]
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
		private SerializableRectTransform VGFMUMJMOTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool MINEAXQWQPD;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8F2B890", Offset = "0x8F29E90", VA = "0x188F2B890")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BA10", Offset = "0x8F2A010", VA = "0x188F2BA10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BBE0", Offset = "0x8F2A1E0", VA = "0x188F2BBE0")]
		private void WQWMZMOQKWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BB10", Offset = "0x8F2A110", VA = "0x188F2BB10")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
namespace RRUI.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class OUCYLUIXGOR
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
			public Component SLFOLBZCRNF
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8F2B820", Offset = "0x8F29E20", VA = "0x188F2B820")]
			public QueuedOperation(Component context, Action refreshOperation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8F2B7A0", Offset = "0x8F29DA0", VA = "0x188F2B7A0")]
			public void LAIGNUUQHPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8F2B790", Offset = "0x8F29D90", VA = "0x188F2B790", Slot = "4")]
			public bool Equals(QueuedOperation other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8F2B700", Offset = "0x8F29D00", VA = "0x188F2B700", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAA5110", Offset = "0xAA3710", VA = "0x180AA5110", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class PZSQRWPTIRA : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public OUCYLUIXGOR CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public PZSQRWPTIRA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8F2B320", Offset = "0x8F29920", VA = "0x188F2B320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8F2B6C0", Offset = "0x8F29CC0", VA = "0x188F2B6C0", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly ScheduleQueueType TLIHQHUTFFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly int NIYCWOTUIZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly int YSCDQDDIFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly Func<Component, float> XSTKRZBMMPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly Dictionary<Component, QueuedOperation> ISGXMRUABNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly LinkedList<QueuedOperation> VMDWKOVQUBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly List<QueuedOperation> ZOQGTKRFRDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private RBEAVUYSDOZ TNGOPKNGHAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private JATKMQNWILW PMOAAHDYJVY;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private JATKMQNWILW RMQOBZLDIXN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8F2AF00", Offset = "0x8F29500", VA = "0x188F2AF00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F2B1C0", Offset = "0x8F297C0", VA = "0x188F2B1C0")]
		public OUCYLUIXGOR(ScheduleQueueType a, int b = -1, int c = -1, [Optional] Func<Component, float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8F2AC80", Offset = "0x8F29280", VA = "0x188F2AC80")]
		public void TZUGKZNTNHC(Component a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8F2A9A0", Offset = "0x8F28FA0", VA = "0x188F2A9A0")]
		public void AOYXCMSJTPW(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8F2AB30", Offset = "0x8F29130", VA = "0x188F2AB30")]
		public bool IYLGMWDCBPI(Component a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8F2AF90", Offset = "0x8F29590", VA = "0x188F2AF90")]
		private void YBMYWMQLBEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8F2AB90", Offset = "0x8F29190", VA = "0x188F2AB90")]
		[IteratorStateMachine(typeof(PZSQRWPTIRA))]
		private IEnumerator<SGCTHXNJFVM> NGBIXCSJMMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x738B290", Offset = "0x7389890", VA = "0x18738B290")]
		[CompilerGenerated]
		private void GYFNNZOJEVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8F2AC00", Offset = "0x8F29200", VA = "0x188F2AC00")]
		[CompilerGenerated]
		private float QZPRMCDFHVH(QueuedOperation a)
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
