using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace TMPro
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[AddComponentMenu("UI/AG TextMeshPro - Input Field", 105)]
	public class AG_TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, IScrollHandler
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public class SubmitEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x26BCB80", Offset = "0x26BBB80", VA = "0x1826BCB80")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x26BCA60", Offset = "0x26BBA60", VA = "0x1826BCA60")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x26BCB40", Offset = "0x26BBB40", VA = "0x1826BCB40")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x26BCBC0", Offset = "0x26BBBC0", VA = "0x1826BCBC0")]
			public TextSelectionEvent()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		protected enum EditState
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			Continue,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			Finish
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class <CaretBlink>d__249 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public AG_TMP_InputField <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x349CE0", Offset = "0x348CE0", VA = "0x180349CE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000DC")]
				[Cpp2IlInjected.Address(RVA = "0x349CE0", Offset = "0x348CE0", VA = "0x180349CE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x364620", Offset = "0x363620", VA = "0x180364620")]
			[DebuggerHidden]
			public <CaretBlink>d__249(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x34A7A0", Offset = "0x3497A0", VA = "0x18034A7A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x26BCC00", Offset = "0x26BBC00", VA = "0x1826BCC00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x26BCD20", Offset = "0x26BBD20", VA = "0x1826BCD20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class <MouseDragOutsideRect>d__266 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AG_TMP_InputField <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public PointerEventData eventData;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0x349CE0", Offset = "0x348CE0", VA = "0x180349CE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x349CE0", Offset = "0x348CE0", VA = "0x180349CE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x364620", Offset = "0x363620", VA = "0x180364620")]
			[DebuggerHidden]
			public <MouseDragOutsideRect>d__266(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x34A7A0", Offset = "0x3497A0", VA = "0x18034A7A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x26BCD70", Offset = "0x26BBD70", VA = "0x1826BCD70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x26BCFD0", Offset = "0x26BBFD0", VA = "0x1826BCFD0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static ActionEvent<TouchScreenKeyboard, AG_TMP_InputField> UpdateViewForMobileKeyboardEvent;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public static bool ForceTouchKeyboardDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected TouchScreenKeyboard m_Keyboard;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly char[] kSeparators;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		protected RectTransform m_TextViewport;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		protected TMP_Text m_TextComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected RectTransform m_TextComponentRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		protected Graphic m_Placeholder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		protected Scrollbar m_VerticalScrollbar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float m_ScrollPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		protected float m_ScrollSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private TMP_InputField.ContentType m_ContentType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private TMP_InputField.InputType m_InputType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private char m_AsteriskChar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private TMP_InputField.LineType m_LineType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private TMP_InputField.CharacterValidation m_CharacterValidation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private string m_RegexValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private float m_GlobalPointSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private int m_CharacterLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private SubmitEvent m_OnEndEdit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private SubmitEvent m_OnSubmit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private SelectionEvent m_OnSelect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private SelectionEvent m_OnDeselect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private TextSelectionEvent m_OnTextSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private TextSelectionEvent m_OnEndTextSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private OnChangeEvent m_OnValueChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private OnValidateInput m_OnValidateInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private Color m_CaretColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private bool m_CustomCaretColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private Color m_SelectionColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		[TextArea]
		protected string m_Text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		[Range(0f, 4f)]
		private float m_CaretBlinkRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[Range(1f, 5f)]
		private int m_CaretWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private bool m_ReadOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C1")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private bool m_RichText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		protected int m_StringPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected int m_StringSelectPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected int m_CaretPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected int m_CaretSelectPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private RectTransform caretRectTrans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		protected UIVertex[] m_CursorVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private CanvasRenderer m_CachedInputRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector2 m_DefaultTransformPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private Vector2 m_LastPosition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected Mesh m_Mesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private bool m_AllowInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x209")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool m_ShouldActivateNextUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20A")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private bool m_UpdateDrag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20B")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private bool m_DragPositionOutOfBounds;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const float kHScrollSpeed = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const float kVScrollSpeed = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected bool m_CaretVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Coroutine m_BlinkCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float m_BlinkStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Coroutine m_DragCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private string m_OriginalText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool m_WasCanceled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x231")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool m_HasDoneFocusTransition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x232")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool m_IsScrollbarUpdateRequired;

		[Cpp2IlInjected.FieldOffset(Offset = "0x233")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool m_IsUpdatingScrollbarValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool m_isLastKeyBackspace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float m_ClickStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private float m_DoubleClickDelay;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		protected TMP_FontAsset m_GlobalFontAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		protected bool m_OnFocusSelectAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x249")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		protected bool m_isSelectAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24A")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		protected bool m_ResetOnDeActivation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24B")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		protected bool m_isRichTextEditingAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24D")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		protected bool m_updateMobileViewWhenKeyboardOpens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24E")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		protected bool m_ForceDisableScreenSpaceNotification;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		protected TMP_InputValidator m_InputValidator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private bool m_isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x259")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private bool isStringPositionDirty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25A")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool m_forceRectTransformAdjustment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Event m_ProcessingEvent;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsTouchKeyboardSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x26BB310", Offset = "0x26BA310", VA = "0x1826BB310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TouchScreenKeyboard.Status LastKeyboardStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7EBD30", Offset = "0x7EAD30", VA = "0x1807EBD30")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8ACF20", Offset = "0x8ABF20", VA = "0x1808ACF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TouchScreenKeyboard LastTouchScreenKeyboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x381260", Offset = "0x380260", VA = "0x180381260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected Mesh mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x26BB3F0", Offset = "0x26BA3F0", VA = "0x1826BB3F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool shouldHideMobileInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x26BB4B0", Offset = "0x26BA4B0", VA = "0x1826BB4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string text
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3A7E40", Offset = "0x3A6E40", VA = "0x1803A7E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x26BC780", Offset = "0x26BB780", VA = "0x1826BC780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool isFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x483EF0", Offset = "0x482EF0", VA = "0x180483EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float caretBlinkRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1262980", Offset = "0x1261980", VA = "0x181262980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x26BB550", Offset = "0x26BA550", VA = "0x1826BB550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int caretWidth
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1262A70", Offset = "0x1261A70", VA = "0x181262A70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x26BB740", Offset = "0x26BA740", VA = "0x1826BB740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RectTransform textViewport
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x483F00", Offset = "0x482F00", VA = "0x180483F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x26BC730", Offset = "0x26BB730", VA = "0x1826BC730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TMP_Text textComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x407E60", Offset = "0x406E60", VA = "0x180407E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x26BC6E0", Offset = "0x26BB6E0", VA = "0x1826BC6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Graphic placeholder
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3C9BE0", Offset = "0x3C8BE0", VA = "0x1803C9BE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x26BC280", Offset = "0x26BB280", VA = "0x1826BC280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Scrollbar verticalScrollbar
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x409140", Offset = "0x408140", VA = "0x180409140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x26BC8D0", Offset = "0x26BB8D0", VA = "0x1826BC8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float scrollSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x77BF80", Offset = "0x77AF80", VA = "0x18077BF80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x26BC4D0", Offset = "0x26BB4D0", VA = "0x1826BC4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Color caretColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x26BB390", Offset = "0x26BA390", VA = "0x1826BB390")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x26BB5C0", Offset = "0x26BA5C0", VA = "0x1826BB5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool customCaretColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1262AA0", Offset = "0x1261AA0", VA = "0x181262AA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x26BBB90", Offset = "0x26BAB90", VA = "0x1826BBB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color selectionColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1262C40", Offset = "0x1261C40", VA = "0x181262C40")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x26BC5D0", Offset = "0x26BB5D0", VA = "0x1826BC5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public SubmitEvent onEndEdit
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3810D0", Offset = "0x3800D0", VA = "0x1803810D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x26BC050", Offset = "0x26BB050", VA = "0x1826BC050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public SubmitEvent onSubmit
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x381410", Offset = "0x380410", VA = "0x180381410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x26BC140", Offset = "0x26BB140", VA = "0x1826BC140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public SelectionEvent onSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3A77C0", Offset = "0x3A67C0", VA = "0x1803A77C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x26BC0F0", Offset = "0x26BB0F0", VA = "0x1826BC0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public SelectionEvent onDeselect
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3A81B0", Offset = "0x3A71B0", VA = "0x1803A81B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x26BC000", Offset = "0x26BB000", VA = "0x1826BC000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextSelectionEvent onTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x408FB0", Offset = "0x407FB0", VA = "0x180408FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x26BC190", Offset = "0x26BB190", VA = "0x1826BC190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TextSelectionEvent onEndTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x409130", Offset = "0x408130", VA = "0x180409130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x26BC0A0", Offset = "0x26BB0A0", VA = "0x1826BC0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public OnChangeEvent onValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x408F40", Offset = "0x407F40", VA = "0x180408F40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x26BC230", Offset = "0x26BB230", VA = "0x1826BC230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public OnValidateInput onValidateInput
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x483E60", Offset = "0x482E60", VA = "0x180483E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x26BC1E0", Offset = "0x26BB1E0", VA = "0x1826BC1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int characterLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1262A80", Offset = "0x1261A80", VA = "0x181262A80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x26BB7E0", Offset = "0x26BA7E0", VA = "0x1826BB7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float pointSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1262BF0", Offset = "0x1261BF0", VA = "0x181262BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x26BC2D0", Offset = "0x26BB2D0", VA = "0x1826BC2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TMP_FontAsset fontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x3A7C80", Offset = "0x3A6C80", VA = "0x1803A7C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x26BBC00", Offset = "0x26BAC00", VA = "0x1826BBC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool onFocusSelectAll
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x10AE750", Offset = "0x10AD750", VA = "0x1810AE750")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1263930", Offset = "0x1262930", VA = "0x181263930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool resetOnDeActivation
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1262C10", Offset = "0x1261C10", VA = "0x181262C10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1263CA0", Offset = "0x1262CA0", VA = "0x181263CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool restoreOriginalTextOnEscape
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1262C20", Offset = "0x1261C20", VA = "0x181262C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1263CB0", Offset = "0x1262CB0", VA = "0x181263CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool isRichTextEditingAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1262B20", Offset = "0x1261B20", VA = "0x181262B20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1263650", Offset = "0x1262650", VA = "0x181263650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool updateMobileViewWhenKeyboardOpens
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x26BB4E0", Offset = "0x26BA4E0", VA = "0x1826BB4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x26BC8C0", Offset = "0x26BB8C0", VA = "0x1826BC8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ForceDisableScreenSpaceNotification
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x26BB300", Offset = "0x26BA300", VA = "0x1826BB300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TMP_InputField.ContentType contentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x77C140", Offset = "0x77B140", VA = "0x18077C140")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x26BB8E0", Offset = "0x26BA8E0", VA = "0x1826BB8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public TMP_InputField.LineType lineType
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xCCF120", Offset = "0xCCE120", VA = "0x180CCF120")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x26BBE90", Offset = "0x26BAE90", VA = "0x1826BBE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TMP_InputField.InputType inputType
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD2CA90", Offset = "0xD2BA90", VA = "0x180D2CA90")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x26BBD40", Offset = "0x26BAD40", VA = "0x1826BBD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TouchScreenKeyboardType keyboardType
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xCCF130", Offset = "0xCCE130", VA = "0x180CCF130")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x26BBE20", Offset = "0x26BAE20", VA = "0x1826BBE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public TMP_InputField.CharacterValidation characterValidation
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA37D30", Offset = "0xA36D30", VA = "0x180A37D30")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x26BB870", Offset = "0x26BA870", VA = "0x1826BB870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TMP_InputValidator inputValidator
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB158C0", Offset = "0xB148C0", VA = "0x180B158C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x26BBDB0", Offset = "0x26BADB0", VA = "0x1826BBDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool readOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1262C00", Offset = "0x1261C00", VA = "0x181262C00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1263C90", Offset = "0x1262C90", VA = "0x181263C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool richText
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1262C30", Offset = "0x1261C30", VA = "0x181262C30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x26BC440", Offset = "0x26BB440", VA = "0x1826BC440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool multiLine
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x26BB490", Offset = "0x26BA490", VA = "0x1826BB490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public char asteriskChar
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x26BB380", Offset = "0x26BA380", VA = "0x1826BB380")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x26BB4F0", Offset = "0x26BA4F0", VA = "0x1826BB4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool wasCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1262D00", Offset = "0x1261D00", VA = "0x181262D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected int caretPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x12629F0", Offset = "0x12619F0", VA = "0x1812629F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x26BB670", Offset = "0x26BA670", VA = "0x1826BB670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		protected int stringPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x1262C50", Offset = "0x1261C50", VA = "0x181262C50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1264050", Offset = "0x1263050", VA = "0x181264050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected int caretSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1262A30", Offset = "0x1261A30", VA = "0x181262A30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x26BB720", Offset = "0x26BA720", VA = "0x1826BB720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected int stringSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1262C90", Offset = "0x1261C90", VA = "0x181262C90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x12640F0", Offset = "0x12630F0", VA = "0x1812640F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool hasSelection
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1262AB0", Offset = "0x1261AB0", VA = "0x181262AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int caretPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1262A30", Offset = "0x1261A30", VA = "0x181262A30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x26BB690", Offset = "0x26BA690", VA = "0x1826BB690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int selectionAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x12629F0", Offset = "0x12619F0", VA = "0x1812629F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x26BC570", Offset = "0x26BB570", VA = "0x1826BC570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int selectionFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1262A30", Offset = "0x1261A30", VA = "0x181262A30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x26BC680", Offset = "0x26BB680", VA = "0x1826BC680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int stringPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1262C90", Offset = "0x1261C90", VA = "0x181262C90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1264070", Offset = "0x1263070", VA = "0x181264070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int selectionStringAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1262C50", Offset = "0x1261C50", VA = "0x181262C50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1263F60", Offset = "0x1262F60", VA = "0x181263F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int selectionStringFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1262C90", Offset = "0x1261C90", VA = "0x181262C90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1263FB0", Offset = "0x1262FB0", VA = "0x181263FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private static string clipboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1262A90", Offset = "0x1261A90", VA = "0x181262A90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1263100", Offset = "0x1262100", VA = "0x181263100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x26BAF90", Offset = "0x26B9F90", VA = "0x1826BAF90")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1258E80", Offset = "0x1257E80", VA = "0x181258E80")]
		protected void ClampStringPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x26B1700", Offset = "0x26B0700", VA = "0x1826B1700")]
		protected void ClampCaretPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x26B7A00", Offset = "0x26B6A00", VA = "0x1826B7A00", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x26B7420", Offset = "0x26B6420", VA = "0x1826B7420", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x26B7260", Offset = "0x26B6260", VA = "0x1826B7260")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x26B16A0", Offset = "0x26B06A0", VA = "0x1826B16A0")]
		[IteratorStateMachine(typeof(<CaretBlink>d__249))]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x26B9E60", Offset = "0x26B8E60", VA = "0x1826B9E60")]
		private void SetCaretVisible()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x26B9DB0", Offset = "0x26B8DB0", VA = "0x1826B9DB0")]
		private void SetCaretActive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x125FB20", Offset = "0x125EB20", VA = "0x18125FB20")]
		protected void OnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1261120", Offset = "0x1260120", VA = "0x181261120")]
		protected void SelectAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x26B6A80", Offset = "0x26B5A80", VA = "0x1826B6A80")]
		public void MoveTextEnd(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x26B6BC0", Offset = "0x26B5BC0", VA = "0x1826B6BC0")]
		public void MoveTextStart(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x26B6CB0", Offset = "0x26B5CB0", VA = "0x1826B6CB0")]
		public void MoveToEndOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x26B6E50", Offset = "0x26B5E50", VA = "0x1826B6E50")]
		public void MoveToStartOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x26B42D0", Offset = "0x26B32D0", VA = "0x1826B42D0")]
		private bool InPlaceEditing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x26B4970", Offset = "0x26B3970", VA = "0x1826B4970", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x26B5590", Offset = "0x26B4590", VA = "0x1826B5590")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x26B7380", Offset = "0x26B6380", VA = "0x1826B7380", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x26B7730", Offset = "0x26B6730", VA = "0x1826B7730", Slot = "53")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x26B5660", Offset = "0x26B4660", VA = "0x1826B5660")]
		[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__266))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x26B80B0", Offset = "0x26B70B0", VA = "0x1826B80B0", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x26B8460", Offset = "0x26B7460", VA = "0x1826B8460", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x26B4500", Offset = "0x26B3500", VA = "0x1826B4500")]
		protected EditState KeyPressed(Event evt)
		{
			return default(EditState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x26B44A0", Offset = "0x26B34A0", VA = "0x1826B44A0")]
		private bool IsValidChar(char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x26B9910", Offset = "0x26B8910", VA = "0x1826B9910")]
		public void ProcessEvent(Event e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x26B8E20", Offset = "0x26B7E20", VA = "0x1826B8E20", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x26B8B00", Offset = "0x26B7B00", VA = "0x1826B8B00", Slot = "56")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x26B4110", Offset = "0x26B3110", VA = "0x1826B4110")]
		private string GetSelectedString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x26B2570", Offset = "0x26B1570", VA = "0x1826B2570")]
		private int FindtNextWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x26B66B0", Offset = "0x26B56B0", VA = "0x1826B66B0")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x26B26B0", Offset = "0x26B16B0", VA = "0x1826B26B0")]
		private int FindtPrevWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x26B5980", Offset = "0x26B4980", VA = "0x1826B5980")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x26B51D0", Offset = "0x26B41D0", VA = "0x1826B51D0")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x26B4E30", Offset = "0x26B3E30", VA = "0x1826B4E30")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x26B9480", Offset = "0x26B8480", VA = "0x1826B9480")]
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x26B8F80", Offset = "0x26B7F80", VA = "0x1826B8F80")]
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x26B56D0", Offset = "0x26B46D0", VA = "0x1826B56D0")]
		private void MoveDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x26B56E0", Offset = "0x26B46E0", VA = "0x1826B56E0")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x26B6FD0", Offset = "0x26B5FD0", VA = "0x1826B6FD0")]
		private void MoveUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x26B6FE0", Offset = "0x26B5FE0", VA = "0x1826B6FE0")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x26B61F0", Offset = "0x26B51F0", VA = "0x1826B61F0")]
		private void MovePageUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x26B6200", Offset = "0x26B5200", VA = "0x1826B6200")]
		private void MovePageUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x26B61E0", Offset = "0x26B51E0", VA = "0x1826B61E0")]
		private void MovePageDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x26B5D10", Offset = "0x26B4D10", VA = "0x1826B5D10")]
		private void MovePageDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x26B1C60", Offset = "0x26B0C60", VA = "0x1826B1C60")]
		private void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x26B27C0", Offset = "0x26B17C0", VA = "0x1826B27C0")]
		private void ForwardSpace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x26B1420", Offset = "0x26B0420", VA = "0x1826B1420")]
		private void Backspace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x26B0930", Offset = "0x26AF930", VA = "0x1826B0930", Slot = "57")]
		protected virtual void Append(string input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x26B09E0", Offset = "0x26AF9E0", VA = "0x1826B09E0", Slot = "58")]
		protected virtual void Append(char input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x26B4340", Offset = "0x26B3340", VA = "0x1826B4340")]
		private void Insert(char c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x26B9D00", Offset = "0x26B8D00", VA = "0x1826B9D00")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x26B9D60", Offset = "0x26B8D60", VA = "0x1826B9D60")]
		private void SendOnValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x26B99F0", Offset = "0x26B89F0", VA = "0x1826B99F0")]
		protected void SendOnEndEdit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x26B9BD0", Offset = "0x26B8BD0", VA = "0x1826B9BD0")]
		protected void SendOnSubmit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x26B9B80", Offset = "0x26B8B80", VA = "0x1826B9B80")]
		protected void SendOnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x26B9B30", Offset = "0x26B8B30", VA = "0x1826B9B30")]
		protected void SendOnFocusLost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x26B9C20", Offset = "0x26B8C20", VA = "0x1826B9C20")]
		protected void SendOnTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x26B9A40", Offset = "0x26B8A40", VA = "0x1826B9A40")]
		protected void SendOnEndTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x26BA320", Offset = "0x26B9320", VA = "0x1826BA320")]
		protected void UpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x26BA5C0", Offset = "0x26B95C0", VA = "0x1826BA5C0")]
		private void UpdateScrollbar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x26B8CD0", Offset = "0x26B7CD0", VA = "0x1826B8CD0")]
		private void OnScrollbarValueChange(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x26B07B0", Offset = "0x26AF7B0", VA = "0x1826B07B0")]
		private void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x26B4050", Offset = "0x26B3050", VA = "0x1826B4050")]
		private int GetCaretPositionFromStringIndex(int stringIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x26B4220", Offset = "0x26B3220", VA = "0x1826B4220")]
		private int GetStringIndexFromCaretPosition(int caretPosition)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x26B27B0", Offset = "0x26B17B0", VA = "0x1826B27B0")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x26B5530", Offset = "0x26B4530", VA = "0x1826B5530")]
		private void MarkGeometryAsDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x26B9920", Offset = "0x26B8920", VA = "0x1826B9920", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x34A7A0", Offset = "0x3497A0", VA = "0x18034A7A0", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x34A7A0", Offset = "0x3497A0", VA = "0x18034A7A0", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x26BA250", Offset = "0x26B9250", VA = "0x1826BA250")]
		private void UpdateGeometry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x26B0C80", Offset = "0x26AFC80", VA = "0x1826B0C80")]
		private void AssignPositioningIfNeeded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x26B80E0", Offset = "0x26B70E0", VA = "0x1826B80E0")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x26B29B0", Offset = "0x26B19B0", VA = "0x1826B29B0")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x26B1790", Offset = "0x26B0790", VA = "0x1826B1790")]
		private void CreateCursorVerts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x26B3470", Offset = "0x26B2470", VA = "0x1826B3470")]
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x26AFE90", Offset = "0x26AEE90", VA = "0x1826AFE90")]
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x26BA780", Offset = "0x26B9780", VA = "0x1826BA780")]
		protected char Validate(string text, int pos, char ch)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x26AFD40", Offset = "0x26AED40", VA = "0x1826AFD40")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x26AF910", Offset = "0x26AE910", VA = "0x1826AF910")]
		private void ActivateInputFieldInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x26B8D30", Offset = "0x26B7D30", VA = "0x1826B8D30", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x26B8420", Offset = "0x26B7420", VA = "0x1826B8420", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x34A7A0", Offset = "0x3497A0", VA = "0x18034A7A0")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x26B1930", Offset = "0x26B0930", VA = "0x1826B1930")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x26B73B0", Offset = "0x26B63B0", VA = "0x1826B73B0", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x26B8D90", Offset = "0x26B7D90", VA = "0x1826B8D90", Slot = "63")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x26B2310", Offset = "0x26B1310", VA = "0x1826B2310")]
		private void EnforceContentType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x26BA110", Offset = "0x26B9110", VA = "0x1826BA110")]
		private void SetTextComponentWrapMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x26BA080", Offset = "0x26B9080", VA = "0x1826BA080")]
		private void SetTextComponentRichTextMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x26BA1C0", Offset = "0x26B91C0", VA = "0x1826BA1C0")]
		private void SetToCustomIfContentTypeIsNot(params TMP_InputField.ContentType[] allowedContentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x26BA230", Offset = "0x26B9230", VA = "0x1826BA230")]
		private void SetToCustom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x26BA230", Offset = "0x26B9230", VA = "0x1826BA230")]
		private void SetToCustom(TMP_InputField.CharacterValidation characterValidation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1259A80", Offset = "0x1258A80", VA = "0x181259A80", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x26B9F90", Offset = "0x26B8F90", VA = "0x1826B9F90")]
		public void SetGlobalPointSize(float pointSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x26B9EA0", Offset = "0x26B8EA0", VA = "0x1826B9EA0")]
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4E5440", Offset = "0x4E4440", VA = "0x1804E5440", Slot = "46")]
		Transform ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal static class SetPropertyUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x124CB80", Offset = "0x124BB80", VA = "0x18124CB80")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xDC0D20", Offset = "0xDBFD20", VA = "0x180DC0D20")]
		public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xDC0E90", Offset = "0xDBFE90", VA = "0x180DC0E90")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xDC0CD0", Offset = "0xDBFCD0", VA = "0x180DC0CD0")]
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default(bool);
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
