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
			[Cpp2IlInjected.Address(RVA = "0x24099E0", Offset = "0x24087E0", VA = "0x1824099E0")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x24098C0", Offset = "0x24086C0", VA = "0x1824098C0")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x24099A0", Offset = "0x24087A0", VA = "0x1824099A0")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2409A20", Offset = "0x2408820", VA = "0x182409A20")]
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
				[Cpp2IlInjected.Address(RVA = "0x3284C0", Offset = "0x3272C0", VA = "0x1803284C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3284C0", Offset = "0x3272C0", VA = "0x1803284C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x351D00", Offset = "0x350B00", VA = "0x180351D00")]
			[DebuggerHidden]
			public <CaretBlink>d__249(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x318930", Offset = "0x317730", VA = "0x180318930", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x2409A60", Offset = "0x2408860", VA = "0x182409A60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x2409B80", Offset = "0x2408980", VA = "0x182409B80", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x3284C0", Offset = "0x3272C0", VA = "0x1803284C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3284C0", Offset = "0x3272C0", VA = "0x1803284C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x351D00", Offset = "0x350B00", VA = "0x180351D00")]
			[DebuggerHidden]
			public <MouseDragOutsideRect>d__266(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x318930", Offset = "0x317730", VA = "0x180318930", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x2409BD0", Offset = "0x24089D0", VA = "0x182409BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2409E30", Offset = "0x2408C30", VA = "0x182409E30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static ActionEvent<TouchScreenKeyboard, AG_TMP_InputField> ShouldUpdateViewEvent;

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
			[Cpp2IlInjected.Address(RVA = "0x2408140", Offset = "0x2406F40", VA = "0x182408140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TouchScreenKeyboard.Status LastKeyboardStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x94EE60", Offset = "0x94DC60", VA = "0x18094EE60")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x14796E0", Offset = "0x14784E0", VA = "0x1814796E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TouchScreenKeyboard LastTouchScreenKeyboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x36FFB0", Offset = "0x36EDB0", VA = "0x18036FFB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected Mesh mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x2408240", Offset = "0x2407040", VA = "0x182408240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool shouldHideMobileInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x2408310", Offset = "0x2407110", VA = "0x182408310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string text
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x38F560", Offset = "0x38E360", VA = "0x18038F560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x24095E0", Offset = "0x24083E0", VA = "0x1824095E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool isFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB20", Offset = "0x5C9920", VA = "0x1805CAB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float caretBlinkRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x10D1340", Offset = "0x10D0140", VA = "0x1810D1340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x24083B0", Offset = "0x24071B0", VA = "0x1824083B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int caretWidth
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x10D1430", Offset = "0x10D0230", VA = "0x1810D1430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x24085A0", Offset = "0x24073A0", VA = "0x1824085A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RectTransform textViewport
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x4BE5F0", Offset = "0x4BD3F0", VA = "0x1804BE5F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2409590", Offset = "0x2408390", VA = "0x182409590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TMP_Text textComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3957B0", Offset = "0x3945B0", VA = "0x1803957B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2409540", Offset = "0x2408340", VA = "0x182409540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Graphic placeholder
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x38EB40", Offset = "0x38D940", VA = "0x18038EB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x24090E0", Offset = "0x2407EE0", VA = "0x1824090E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Scrollbar verticalScrollbar
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x38EF00", Offset = "0x38DD00", VA = "0x18038EF00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2409730", Offset = "0x2408530", VA = "0x182409730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float scrollSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x2408300", Offset = "0x2407100", VA = "0x182408300")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2409330", Offset = "0x2408130", VA = "0x182409330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Color caretColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x24081C0", Offset = "0x2406FC0", VA = "0x1824081C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2408420", Offset = "0x2407220", VA = "0x182408420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool customCaretColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x88E8D0", Offset = "0x88D6D0", VA = "0x18088E8D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x24089F0", Offset = "0x24077F0", VA = "0x1824089F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color selectionColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x10D15F0", Offset = "0x10D03F0", VA = "0x1810D15F0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2409430", Offset = "0x2408230", VA = "0x182409430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public SubmitEvent onEndEdit
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x51A6D0", Offset = "0x5194D0", VA = "0x18051A6D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2408EB0", Offset = "0x2407CB0", VA = "0x182408EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public SubmitEvent onSubmit
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB50", Offset = "0x5C9950", VA = "0x1805CAB50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2408FA0", Offset = "0x2407DA0", VA = "0x182408FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public SelectionEvent onSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB70", Offset = "0x5C9970", VA = "0x1805CAB70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2408F50", Offset = "0x2407D50", VA = "0x182408F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public SelectionEvent onDeselect
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB60", Offset = "0x5C9960", VA = "0x1805CAB60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2408E60", Offset = "0x2407C60", VA = "0x182408E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextSelectionEvent onTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x38EB50", Offset = "0x38D950", VA = "0x18038EB50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TextSelectionEvent onEndTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x51A430", Offset = "0x519230", VA = "0x18051A430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2408F00", Offset = "0x2407D00", VA = "0x182408F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public OnChangeEvent onValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x38F040", Offset = "0x38DE40", VA = "0x18038F040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2409090", Offset = "0x2407E90", VA = "0x182409090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public OnValidateInput onValidateInput
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x51A420", Offset = "0x519220", VA = "0x18051A420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2409040", Offset = "0x2407E40", VA = "0x182409040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int characterLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1060C80", Offset = "0x105FA80", VA = "0x181060C80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2408640", Offset = "0x2407440", VA = "0x182408640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float pointSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x38ED80", Offset = "0x38DB80", VA = "0x18038ED80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2409130", Offset = "0x2407F30", VA = "0x182409130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TMP_FontAsset fontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA4AD20", Offset = "0xA49B20", VA = "0x180A4AD20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2408A60", Offset = "0x2407860", VA = "0x182408A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool onFocusSelectAll
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xF43EF0", Offset = "0xF42CF0", VA = "0x180F43EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x10D22D0", Offset = "0x10D10D0", VA = "0x1810D22D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool resetOnDeActivation
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x10D15C0", Offset = "0x10D03C0", VA = "0x1810D15C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x10D2640", Offset = "0x10D1440", VA = "0x1810D2640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool restoreOriginalTextOnEscape
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x10D15D0", Offset = "0x10D03D0", VA = "0x1810D15D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x10D2650", Offset = "0x10D1450", VA = "0x1810D2650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool isRichTextEditingAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x10D14D0", Offset = "0x10D02D0", VA = "0x1810D14D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x10D1FF0", Offset = "0x10D0DF0", VA = "0x1810D1FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool updateMobileViewWhenKeyboardOpens
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2408340", Offset = "0x2407140", VA = "0x182408340")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2409720", Offset = "0x2408520", VA = "0x182409720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ForceDisableScreenSpaceNotification
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2408130", Offset = "0x2406F30", VA = "0x182408130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TMP_InputField.ContentType contentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x716300", Offset = "0x715100", VA = "0x180716300")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x2408740", Offset = "0x2407540", VA = "0x182408740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public TMP_InputField.LineType lineType
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x10D1440", Offset = "0x10D0240", VA = "0x1810D1440")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2408CF0", Offset = "0x2407AF0", VA = "0x182408CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TMP_InputField.InputType inputType
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x716310", Offset = "0x715110", VA = "0x180716310")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2408BA0", Offset = "0x24079A0", VA = "0x182408BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TouchScreenKeyboardType keyboardType
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2408230", Offset = "0x2407030", VA = "0x182408230")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2408C80", Offset = "0x2407A80", VA = "0x182408C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public TMP_InputField.CharacterValidation characterValidation
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2408220", Offset = "0x2407020", VA = "0x182408220")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x24086D0", Offset = "0x24074D0", VA = "0x1824086D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TMP_InputValidator inputValidator
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA4AF10", Offset = "0xA49D10", VA = "0x180A4AF10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2408C10", Offset = "0x2407A10", VA = "0x182408C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool readOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x10D15B0", Offset = "0x10D03B0", VA = "0x1810D15B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x10D2630", Offset = "0x10D1430", VA = "0x1810D2630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool richText
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x10D15E0", Offset = "0x10D03E0", VA = "0x1810D15E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x24092A0", Offset = "0x24080A0", VA = "0x1824092A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool multiLine
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x24082E0", Offset = "0x24070E0", VA = "0x1824082E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public char asteriskChar
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x24081B0", Offset = "0x2406FB0", VA = "0x1824081B0")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2408350", Offset = "0x2407150", VA = "0x182408350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool wasCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7BBA60", Offset = "0x7BA860", VA = "0x1807BBA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected int caretPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x10D13B0", Offset = "0x10D01B0", VA = "0x1810D13B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x24084D0", Offset = "0x24072D0", VA = "0x1824084D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		protected int stringPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x10D1600", Offset = "0x10D0400", VA = "0x1810D1600")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x10D29F0", Offset = "0x10D17F0", VA = "0x1810D29F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected int caretSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x10D13F0", Offset = "0x10D01F0", VA = "0x1810D13F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2408580", Offset = "0x2407380", VA = "0x182408580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected int stringSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x10D1640", Offset = "0x10D0440", VA = "0x1810D1640")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A90", Offset = "0x10D1890", VA = "0x1810D2A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool hasSelection
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x10D1460", Offset = "0x10D0260", VA = "0x1810D1460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int caretPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x10D13F0", Offset = "0x10D01F0", VA = "0x1810D13F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x24084F0", Offset = "0x24072F0", VA = "0x1824084F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int selectionAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x10D13B0", Offset = "0x10D01B0", VA = "0x1810D13B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x24093D0", Offset = "0x24081D0", VA = "0x1824093D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int selectionFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x10D13F0", Offset = "0x10D01F0", VA = "0x1810D13F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x24094E0", Offset = "0x24082E0", VA = "0x1824094E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int stringPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x10D1640", Offset = "0x10D0440", VA = "0x1810D1640")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x10D2A10", Offset = "0x10D1810", VA = "0x1810D2A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int selectionStringAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x10D1600", Offset = "0x10D0400", VA = "0x1810D1600")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x10D2900", Offset = "0x10D1700", VA = "0x1810D2900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int selectionStringFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x10D1640", Offset = "0x10D0440", VA = "0x1810D1640")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x10D2950", Offset = "0x10D1750", VA = "0x1810D2950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private static string clipboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x10D1450", Offset = "0x10D0250", VA = "0x1810D1450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x10D1AA0", Offset = "0x10D08A0", VA = "0x1810D1AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2407DC0", Offset = "0x2406BC0", VA = "0x182407DC0")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x10C7840", Offset = "0x10C6640", VA = "0x1810C7840")]
		protected void ClampStringPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x23FE530", Offset = "0x23FD330", VA = "0x1823FE530")]
		protected void ClampCaretPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2404830", Offset = "0x2403630", VA = "0x182404830", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2404250", Offset = "0x2403050", VA = "0x182404250", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2404090", Offset = "0x2402E90", VA = "0x182404090")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x23FE4D0", Offset = "0x23FD2D0", VA = "0x1823FE4D0")]
		[IteratorStateMachine(typeof(<CaretBlink>d__249))]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2406C90", Offset = "0x2405A90", VA = "0x182406C90")]
		private void SetCaretVisible()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2406BE0", Offset = "0x24059E0", VA = "0x182406BE0")]
		private void SetCaretActive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x10CE4E0", Offset = "0x10CD2E0", VA = "0x1810CE4E0")]
		protected void OnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x10CFAE0", Offset = "0x10CE8E0", VA = "0x1810CFAE0")]
		protected void SelectAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x24038B0", Offset = "0x24026B0", VA = "0x1824038B0")]
		public void MoveTextEnd(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x24039F0", Offset = "0x24027F0", VA = "0x1824039F0")]
		public void MoveTextStart(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2403AE0", Offset = "0x24028E0", VA = "0x182403AE0")]
		public void MoveToEndOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2403C80", Offset = "0x2402A80", VA = "0x182403C80")]
		public void MoveToStartOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2401100", Offset = "0x23FFF00", VA = "0x182401100")]
		private bool InPlaceEditing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x24017A0", Offset = "0x24005A0", VA = "0x1824017A0", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x24023C0", Offset = "0x24011C0", VA = "0x1824023C0")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x24041B0", Offset = "0x2402FB0", VA = "0x1824041B0", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2404560", Offset = "0x2403360", VA = "0x182404560", Slot = "53")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2402490", Offset = "0x2401290", VA = "0x182402490")]
		[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__266))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2404EE0", Offset = "0x2403CE0", VA = "0x182404EE0", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2405290", Offset = "0x2404090", VA = "0x182405290", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2401330", Offset = "0x2400130", VA = "0x182401330")]
		protected EditState KeyPressed(Event evt)
		{
			return default(EditState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x24012D0", Offset = "0x24000D0", VA = "0x1824012D0")]
		private bool IsValidChar(char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2406740", Offset = "0x2405540", VA = "0x182406740")]
		public void ProcessEvent(Event e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2405C50", Offset = "0x2404A50", VA = "0x182405C50", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2405930", Offset = "0x2404730", VA = "0x182405930", Slot = "56")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2400F40", Offset = "0x23FFD40", VA = "0x182400F40")]
		private string GetSelectedString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x23FF3A0", Offset = "0x23FE1A0", VA = "0x1823FF3A0")]
		private int FindtNextWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x24034E0", Offset = "0x24022E0", VA = "0x1824034E0")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x23FF4E0", Offset = "0x23FE2E0", VA = "0x1823FF4E0")]
		private int FindtPrevWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x24027B0", Offset = "0x24015B0", VA = "0x1824027B0")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2402000", Offset = "0x2400E00", VA = "0x182402000")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2401C60", Offset = "0x2400A60", VA = "0x182401C60")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x24062B0", Offset = "0x24050B0", VA = "0x1824062B0")]
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2405DB0", Offset = "0x2404BB0", VA = "0x182405DB0")]
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2402500", Offset = "0x2401300", VA = "0x182402500")]
		private void MoveDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2402510", Offset = "0x2401310", VA = "0x182402510")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2403E00", Offset = "0x2402C00", VA = "0x182403E00")]
		private void MoveUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2403E10", Offset = "0x2402C10", VA = "0x182403E10")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2403020", Offset = "0x2401E20", VA = "0x182403020")]
		private void MovePageUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2403030", Offset = "0x2401E30", VA = "0x182403030")]
		private void MovePageUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2403010", Offset = "0x2401E10", VA = "0x182403010")]
		private void MovePageDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2402B40", Offset = "0x2401940", VA = "0x182402B40")]
		private void MovePageDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x23FEA90", Offset = "0x23FD890", VA = "0x1823FEA90")]
		private void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x23FF5F0", Offset = "0x23FE3F0", VA = "0x1823FF5F0")]
		private void ForwardSpace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x23FE250", Offset = "0x23FD050", VA = "0x1823FE250")]
		private void Backspace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x23FD760", Offset = "0x23FC560", VA = "0x1823FD760", Slot = "57")]
		protected virtual void Append(string input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x23FD810", Offset = "0x23FC610", VA = "0x1823FD810", Slot = "58")]
		protected virtual void Append(char input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2401170", Offset = "0x23FFF70", VA = "0x182401170")]
		private void Insert(char c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2406B30", Offset = "0x2405930", VA = "0x182406B30")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2406B90", Offset = "0x2405990", VA = "0x182406B90")]
		private void SendOnValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2406820", Offset = "0x2405620", VA = "0x182406820")]
		protected void SendOnEndEdit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x2406A00", Offset = "0x2405800", VA = "0x182406A00")]
		protected void SendOnSubmit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x24069B0", Offset = "0x24057B0", VA = "0x1824069B0")]
		protected void SendOnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x2406960", Offset = "0x2405760", VA = "0x182406960")]
		protected void SendOnFocusLost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2406A50", Offset = "0x2405850", VA = "0x182406A50")]
		protected void SendOnTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2406870", Offset = "0x2405670", VA = "0x182406870")]
		protected void SendOnEndTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2407150", Offset = "0x2405F50", VA = "0x182407150")]
		protected void UpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x24073F0", Offset = "0x24061F0", VA = "0x1824073F0")]
		private void UpdateScrollbar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2405B00", Offset = "0x2404900", VA = "0x182405B00")]
		private void OnScrollbarValueChange(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x23FD5E0", Offset = "0x23FC3E0", VA = "0x1823FD5E0")]
		private void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2400E80", Offset = "0x23FFC80", VA = "0x182400E80")]
		private int GetCaretPositionFromStringIndex(int stringIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2401050", Offset = "0x23FFE50", VA = "0x182401050")]
		private int GetStringIndexFromCaretPosition(int caretPosition)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x23FF5E0", Offset = "0x23FE3E0", VA = "0x1823FF5E0")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2402360", Offset = "0x2401160", VA = "0x182402360")]
		private void MarkGeometryAsDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2406750", Offset = "0x2405550", VA = "0x182406750", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x318930", Offset = "0x317730", VA = "0x180318930", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x318930", Offset = "0x317730", VA = "0x180318930", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2407080", Offset = "0x2405E80", VA = "0x182407080")]
		private void UpdateGeometry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x23FDAB0", Offset = "0x23FC8B0", VA = "0x1823FDAB0")]
		private void AssignPositioningIfNeeded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2404F10", Offset = "0x2403D10", VA = "0x182404F10")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x23FF7E0", Offset = "0x23FE5E0", VA = "0x1823FF7E0")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x23FE5C0", Offset = "0x23FD3C0", VA = "0x1823FE5C0")]
		private void CreateCursorVerts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x24002A0", Offset = "0x23FF0A0", VA = "0x1824002A0")]
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x23FCCC0", Offset = "0x23FBAC0", VA = "0x1823FCCC0")]
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x24075B0", Offset = "0x24063B0", VA = "0x1824075B0")]
		protected char Validate(string text, int pos, char ch)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x23FCB70", Offset = "0x23FB970", VA = "0x1823FCB70")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x23FC740", Offset = "0x23FB540", VA = "0x1823FC740")]
		private void ActivateInputFieldInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2405B60", Offset = "0x2404960", VA = "0x182405B60", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2405250", Offset = "0x2404050", VA = "0x182405250", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x318930", Offset = "0x317730", VA = "0x180318930")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x23FE760", Offset = "0x23FD560", VA = "0x1823FE760")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x24041E0", Offset = "0x2402FE0", VA = "0x1824041E0", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x2405BC0", Offset = "0x24049C0", VA = "0x182405BC0", Slot = "63")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x23FF140", Offset = "0x23FDF40", VA = "0x1823FF140")]
		private void EnforceContentType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x2406F40", Offset = "0x2405D40", VA = "0x182406F40")]
		private void SetTextComponentWrapMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2406EB0", Offset = "0x2405CB0", VA = "0x182406EB0")]
		private void SetTextComponentRichTextMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x2406FF0", Offset = "0x2405DF0", VA = "0x182406FF0")]
		private void SetToCustomIfContentTypeIsNot(params TMP_InputField.ContentType[] allowedContentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2407060", Offset = "0x2405E60", VA = "0x182407060")]
		private void SetToCustom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2407060", Offset = "0x2405E60", VA = "0x182407060")]
		private void SetToCustom(TMP_InputField.CharacterValidation characterValidation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x10C8440", Offset = "0x10C7240", VA = "0x1810C8440", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2406DC0", Offset = "0x2405BC0", VA = "0x182406DC0")]
		public void SetGlobalPointSize(float pointSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2406CD0", Offset = "0x2405AD0", VA = "0x182406CD0")]
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x484480", Offset = "0x483280", VA = "0x180484480", Slot = "46")]
		Transform ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal static class SetPropertyUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x10BB550", Offset = "0x10BA350", VA = "0x1810BB550")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xE7AFD0", Offset = "0xE79DD0", VA = "0x180E7AFD0")]
		public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xE7B140", Offset = "0xE79F40", VA = "0x180E7B140")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xE7AF80", Offset = "0xE79D80", VA = "0x180E7AF80")]
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
