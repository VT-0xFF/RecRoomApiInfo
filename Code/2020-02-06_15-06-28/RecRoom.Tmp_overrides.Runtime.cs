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
			[Cpp2IlInjected.Address(RVA = "0x25512B0", Offset = "0x25504B0", VA = "0x1825512B0")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2551190", Offset = "0x2550390", VA = "0x182551190")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2551270", Offset = "0x2550470", VA = "0x182551270")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x25512F0", Offset = "0x25504F0", VA = "0x1825512F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x336020", Offset = "0x335220", VA = "0x180336020", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x336020", Offset = "0x335220", VA = "0x180336020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x3574F0", Offset = "0x3566F0", VA = "0x1803574F0")]
			[DebuggerHidden]
			public <CaretBlink>d__249(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x335D00", Offset = "0x334F00", VA = "0x180335D00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x2551330", Offset = "0x2550530", VA = "0x182551330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x2551450", Offset = "0x2550650", VA = "0x182551450", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x336020", Offset = "0x335220", VA = "0x180336020", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x336020", Offset = "0x335220", VA = "0x180336020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x3574F0", Offset = "0x3566F0", VA = "0x1803574F0")]
			[DebuggerHidden]
			public <MouseDragOutsideRect>d__266(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x335D00", Offset = "0x334F00", VA = "0x180335D00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x25514A0", Offset = "0x25506A0", VA = "0x1825514A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2551700", Offset = "0x2550900", VA = "0x182551700", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x254FA20", Offset = "0x254EC20", VA = "0x18254FA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TouchScreenKeyboard.Status LastKeyboardStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9FD440", Offset = "0x9FC640", VA = "0x1809FD440")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x148E340", Offset = "0x148D540", VA = "0x18148E340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TouchScreenKeyboard LastTouchScreenKeyboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5B8710", Offset = "0x5B7910", VA = "0x1805B8710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected Mesh mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x254FB10", Offset = "0x254ED10", VA = "0x18254FB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool shouldHideMobileInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x254FBE0", Offset = "0x254EDE0", VA = "0x18254FBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string text
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x3BB6C0", Offset = "0x3BA8C0", VA = "0x1803BB6C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2550EB0", Offset = "0x25500B0", VA = "0x182550EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool isFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6AA6C0", Offset = "0x6A98C0", VA = "0x1806AA6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float caretBlinkRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x11E19E0", Offset = "0x11E0BE0", VA = "0x1811E19E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x254FC80", Offset = "0x254EE80", VA = "0x18254FC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int caretWidth
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x11E1AD0", Offset = "0x11E0CD0", VA = "0x1811E1AD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x254FE70", Offset = "0x254F070", VA = "0x18254FE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RectTransform textViewport
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x527530", Offset = "0x526730", VA = "0x180527530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2550E60", Offset = "0x2550060", VA = "0x182550E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TMP_Text textComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3E0F30", Offset = "0x3E0130", VA = "0x1803E0F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2550E10", Offset = "0x2550010", VA = "0x182550E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Graphic placeholder
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x394F70", Offset = "0x394170", VA = "0x180394F70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x25509B0", Offset = "0x254FBB0", VA = "0x1825509B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Scrollbar verticalScrollbar
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x394560", Offset = "0x393760", VA = "0x180394560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x2551000", Offset = "0x2550200", VA = "0x182551000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float scrollSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x254FBD0", Offset = "0x254EDD0", VA = "0x18254FBD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2550C00", Offset = "0x254FE00", VA = "0x182550C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Color caretColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x254FAA0", Offset = "0x254ECA0", VA = "0x18254FAA0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x254FCF0", Offset = "0x254EEF0", VA = "0x18254FCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool customCaretColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x11E1AF0", Offset = "0x11E0CF0", VA = "0x1811E1AF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x25502C0", Offset = "0x254F4C0", VA = "0x1825502C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color selectionColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x11E1C90", Offset = "0x11E0E90", VA = "0x1811E1C90")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2550D00", Offset = "0x254FF00", VA = "0x182550D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public SubmitEvent onEndEdit
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3BB020", Offset = "0x3BA220", VA = "0x1803BB020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2550780", Offset = "0x254F980", VA = "0x182550780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public SubmitEvent onSubmit
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3BB980", Offset = "0x3BAB80", VA = "0x1803BB980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2550870", Offset = "0x254FA70", VA = "0x182550870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public SelectionEvent onSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x64EED0", Offset = "0x64E0D0", VA = "0x18064EED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2550820", Offset = "0x254FA20", VA = "0x182550820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public SelectionEvent onDeselect
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x64F050", Offset = "0x64E250", VA = "0x18064F050")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2550730", Offset = "0x254F930", VA = "0x182550730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextSelectionEvent onTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x64EE70", Offset = "0x64E070", VA = "0x18064EE70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x25508C0", Offset = "0x254FAC0", VA = "0x1825508C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TextSelectionEvent onEndTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6AA6F0", Offset = "0x6A98F0", VA = "0x1806AA6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x25507D0", Offset = "0x254F9D0", VA = "0x1825507D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public OnChangeEvent onValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x394570", Offset = "0x393770", VA = "0x180394570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2550960", Offset = "0x254FB60", VA = "0x182550960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public OnValidateInput onValidateInput
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x3BB6B0", Offset = "0x3BA8B0", VA = "0x1803BB6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2550910", Offset = "0x254FB10", VA = "0x182550910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int characterLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1148A90", Offset = "0x1147C90", VA = "0x181148A90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x254FF10", Offset = "0x254F110", VA = "0x18254FF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float pointSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x11E1C50", Offset = "0x11E0E50", VA = "0x1811E1C50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2550A00", Offset = "0x254FC00", VA = "0x182550A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TMP_FontAsset fontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAC5CE0", Offset = "0xAC4EE0", VA = "0x180AC5CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2550330", Offset = "0x254F530", VA = "0x182550330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool onFocusSelectAll
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xFF86E0", Offset = "0xFF78E0", VA = "0x180FF86E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x11E2970", Offset = "0x11E1B70", VA = "0x1811E2970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool resetOnDeActivation
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x11E1C60", Offset = "0x11E0E60", VA = "0x1811E1C60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x11E2CE0", Offset = "0x11E1EE0", VA = "0x1811E2CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool restoreOriginalTextOnEscape
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x11E1C70", Offset = "0x11E0E70", VA = "0x1811E1C70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x11E2CF0", Offset = "0x11E1EF0", VA = "0x1811E2CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool isRichTextEditingAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x11E1B70", Offset = "0x11E0D70", VA = "0x1811E1B70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x11E2690", Offset = "0x11E1890", VA = "0x1811E2690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool updateMobileViewWhenKeyboardOpens
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x254FC10", Offset = "0x254EE10", VA = "0x18254FC10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2550FF0", Offset = "0x25501F0", VA = "0x182550FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ForceDisableScreenSpaceNotification
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x254FA10", Offset = "0x254EC10", VA = "0x18254FA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TMP_InputField.ContentType contentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xC6FDD0", Offset = "0xC6EFD0", VA = "0x180C6FDD0")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x2550010", Offset = "0x254F210", VA = "0x182550010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public TMP_InputField.LineType lineType
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7899C0", Offset = "0x788BC0", VA = "0x1807899C0")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x25505C0", Offset = "0x254F7C0", VA = "0x1825505C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TMP_InputField.InputType inputType
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xC6FDC0", Offset = "0xC6EFC0", VA = "0x180C6FDC0")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2550470", Offset = "0x254F670", VA = "0x182550470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TouchScreenKeyboardType keyboardType
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x254FB00", Offset = "0x254ED00", VA = "0x18254FB00")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2550550", Offset = "0x254F750", VA = "0x182550550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public TMP_InputField.CharacterValidation characterValidation
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7899D0", Offset = "0x788BD0", VA = "0x1807899D0")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x254FFA0", Offset = "0x254F1A0", VA = "0x18254FFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TMP_InputValidator inputValidator
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAC5ED0", Offset = "0xAC50D0", VA = "0x180AC5ED0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x25504E0", Offset = "0x254F6E0", VA = "0x1825504E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool readOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x64E510", Offset = "0x64D710", VA = "0x18064E510")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x11E2CD0", Offset = "0x11E1ED0", VA = "0x1811E2CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool richText
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x11E1C80", Offset = "0x11E0E80", VA = "0x1811E1C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2550B70", Offset = "0x254FD70", VA = "0x182550B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool multiLine
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x254FBB0", Offset = "0x254EDB0", VA = "0x18254FBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public char asteriskChar
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x254FA90", Offset = "0x254EC90", VA = "0x18254FA90")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x254FC20", Offset = "0x254EE20", VA = "0x18254FC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool wasCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3BACC0", Offset = "0x3B9EC0", VA = "0x1803BACC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected int caretPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x11E1A50", Offset = "0x11E0C50", VA = "0x1811E1A50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x254FDA0", Offset = "0x254EFA0", VA = "0x18254FDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		protected int stringPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x11E1CA0", Offset = "0x11E0EA0", VA = "0x1811E1CA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x11E3090", Offset = "0x11E2290", VA = "0x1811E3090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected int caretSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x11E1A90", Offset = "0x11E0C90", VA = "0x1811E1A90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x254FE50", Offset = "0x254F050", VA = "0x18254FE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected int stringSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x11E1CE0", Offset = "0x11E0EE0", VA = "0x1811E1CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x11E3130", Offset = "0x11E2330", VA = "0x1811E3130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool hasSelection
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x11E1B00", Offset = "0x11E0D00", VA = "0x1811E1B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int caretPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x11E1A90", Offset = "0x11E0C90", VA = "0x1811E1A90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x254FDC0", Offset = "0x254EFC0", VA = "0x18254FDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int selectionAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x11E1A50", Offset = "0x11E0C50", VA = "0x1811E1A50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2550CA0", Offset = "0x254FEA0", VA = "0x182550CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int selectionFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x11E1A90", Offset = "0x11E0C90", VA = "0x1811E1A90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2550DB0", Offset = "0x254FFB0", VA = "0x182550DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int stringPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x11E1CE0", Offset = "0x11E0EE0", VA = "0x1811E1CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x11E30B0", Offset = "0x11E22B0", VA = "0x1811E30B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int selectionStringAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x11E1CA0", Offset = "0x11E0EA0", VA = "0x1811E1CA0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x11E2FA0", Offset = "0x11E21A0", VA = "0x1811E2FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int selectionStringFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x11E1CE0", Offset = "0x11E0EE0", VA = "0x1811E1CE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x11E2FF0", Offset = "0x11E21F0", VA = "0x1811E2FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private static string clipboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x11E1AE0", Offset = "0x11E0CE0", VA = "0x1811E1AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x11E2140", Offset = "0x11E1340", VA = "0x1811E2140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x254F6A0", Offset = "0x254E8A0", VA = "0x18254F6A0")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x11D7EE0", Offset = "0x11D70E0", VA = "0x1811D7EE0")]
		protected void ClampStringPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2545E10", Offset = "0x2545010", VA = "0x182545E10")]
		protected void ClampCaretPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x254C110", Offset = "0x254B310", VA = "0x18254C110", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x254BB30", Offset = "0x254AD30", VA = "0x18254BB30", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x254B970", Offset = "0x254AB70", VA = "0x18254B970")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2545DB0", Offset = "0x2544FB0", VA = "0x182545DB0")]
		[IteratorStateMachine(typeof(<CaretBlink>d__249))]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x254E570", Offset = "0x254D770", VA = "0x18254E570")]
		private void SetCaretVisible()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x254E4C0", Offset = "0x254D6C0", VA = "0x18254E4C0")]
		private void SetCaretActive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x11DEB80", Offset = "0x11DDD80", VA = "0x1811DEB80")]
		protected void OnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x11E0180", Offset = "0x11DF380", VA = "0x1811E0180")]
		protected void SelectAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x254B190", Offset = "0x254A390", VA = "0x18254B190")]
		public void MoveTextEnd(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x254B2D0", Offset = "0x254A4D0", VA = "0x18254B2D0")]
		public void MoveTextStart(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x254B3C0", Offset = "0x254A5C0", VA = "0x18254B3C0")]
		public void MoveToEndOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x254B560", Offset = "0x254A760", VA = "0x18254B560")]
		public void MoveToStartOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x25489E0", Offset = "0x2547BE0", VA = "0x1825489E0")]
		private bool InPlaceEditing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2549080", Offset = "0x2548280", VA = "0x182549080", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2549CA0", Offset = "0x2548EA0", VA = "0x182549CA0")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x254BA90", Offset = "0x254AC90", VA = "0x18254BA90", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x254BE40", Offset = "0x254B040", VA = "0x18254BE40", Slot = "53")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2549D70", Offset = "0x2548F70", VA = "0x182549D70")]
		[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__266))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x254C7C0", Offset = "0x254B9C0", VA = "0x18254C7C0", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x254CB70", Offset = "0x254BD70", VA = "0x18254CB70", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2548C10", Offset = "0x2547E10", VA = "0x182548C10")]
		protected EditState KeyPressed(Event evt)
		{
			return default(EditState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2548BB0", Offset = "0x2547DB0", VA = "0x182548BB0")]
		private bool IsValidChar(char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x254E020", Offset = "0x254D220", VA = "0x18254E020")]
		public void ProcessEvent(Event e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x254D530", Offset = "0x254C730", VA = "0x18254D530", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x254D210", Offset = "0x254C410", VA = "0x18254D210", Slot = "56")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2548820", Offset = "0x2547A20", VA = "0x182548820")]
		private string GetSelectedString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2546C80", Offset = "0x2545E80", VA = "0x182546C80")]
		private int FindtNextWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x254ADC0", Offset = "0x2549FC0", VA = "0x18254ADC0")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2546DC0", Offset = "0x2545FC0", VA = "0x182546DC0")]
		private int FindtPrevWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x254A090", Offset = "0x2549290", VA = "0x18254A090")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x25498E0", Offset = "0x2548AE0", VA = "0x1825498E0")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2549540", Offset = "0x2548740", VA = "0x182549540")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x254DB90", Offset = "0x254CD90", VA = "0x18254DB90")]
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x254D690", Offset = "0x254C890", VA = "0x18254D690")]
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2549DE0", Offset = "0x2548FE0", VA = "0x182549DE0")]
		private void MoveDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2549DF0", Offset = "0x2548FF0", VA = "0x182549DF0")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x254B6E0", Offset = "0x254A8E0", VA = "0x18254B6E0")]
		private void MoveUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x254B6F0", Offset = "0x254A8F0", VA = "0x18254B6F0")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x254A900", Offset = "0x2549B00", VA = "0x18254A900")]
		private void MovePageUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x254A910", Offset = "0x2549B10", VA = "0x18254A910")]
		private void MovePageUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x254A8F0", Offset = "0x2549AF0", VA = "0x18254A8F0")]
		private void MovePageDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x254A420", Offset = "0x2549620", VA = "0x18254A420")]
		private void MovePageDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2546370", Offset = "0x2545570", VA = "0x182546370")]
		private void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2546ED0", Offset = "0x25460D0", VA = "0x182546ED0")]
		private void ForwardSpace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2545B30", Offset = "0x2544D30", VA = "0x182545B30")]
		private void Backspace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2545040", Offset = "0x2544240", VA = "0x182545040", Slot = "57")]
		protected virtual void Append(string input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x25450F0", Offset = "0x25442F0", VA = "0x1825450F0", Slot = "58")]
		protected virtual void Append(char input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2548A50", Offset = "0x2547C50", VA = "0x182548A50")]
		private void Insert(char c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x254E410", Offset = "0x254D610", VA = "0x18254E410")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x254E470", Offset = "0x254D670", VA = "0x18254E470")]
		private void SendOnValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x254E100", Offset = "0x254D300", VA = "0x18254E100")]
		protected void SendOnEndEdit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x254E2E0", Offset = "0x254D4E0", VA = "0x18254E2E0")]
		protected void SendOnSubmit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x254E290", Offset = "0x254D490", VA = "0x18254E290")]
		protected void SendOnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x254E240", Offset = "0x254D440", VA = "0x18254E240")]
		protected void SendOnFocusLost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x254E330", Offset = "0x254D530", VA = "0x18254E330")]
		protected void SendOnTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x254E150", Offset = "0x254D350", VA = "0x18254E150")]
		protected void SendOnEndTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x254EA30", Offset = "0x254DC30", VA = "0x18254EA30")]
		protected void UpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x254ECD0", Offset = "0x254DED0", VA = "0x18254ECD0")]
		private void UpdateScrollbar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x254D3E0", Offset = "0x254C5E0", VA = "0x18254D3E0")]
		private void OnScrollbarValueChange(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2544EC0", Offset = "0x25440C0", VA = "0x182544EC0")]
		private void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2548760", Offset = "0x2547960", VA = "0x182548760")]
		private int GetCaretPositionFromStringIndex(int stringIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2548930", Offset = "0x2547B30", VA = "0x182548930")]
		private int GetStringIndexFromCaretPosition(int caretPosition)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2546EC0", Offset = "0x25460C0", VA = "0x182546EC0")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2549C40", Offset = "0x2548E40", VA = "0x182549C40")]
		private void MarkGeometryAsDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x254E030", Offset = "0x254D230", VA = "0x18254E030", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x335D00", Offset = "0x334F00", VA = "0x180335D00", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x335D00", Offset = "0x334F00", VA = "0x180335D00", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x254E960", Offset = "0x254DB60", VA = "0x18254E960")]
		private void UpdateGeometry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2545390", Offset = "0x2544590", VA = "0x182545390")]
		private void AssignPositioningIfNeeded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x254C7F0", Offset = "0x254B9F0", VA = "0x18254C7F0")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x25470C0", Offset = "0x25462C0", VA = "0x1825470C0")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2545EA0", Offset = "0x25450A0", VA = "0x182545EA0")]
		private void CreateCursorVerts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2547B80", Offset = "0x2546D80", VA = "0x182547B80")]
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x25445A0", Offset = "0x25437A0", VA = "0x1825445A0")]
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x254EE90", Offset = "0x254E090", VA = "0x18254EE90")]
		protected char Validate(string text, int pos, char ch)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2544450", Offset = "0x2543650", VA = "0x182544450")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2544020", Offset = "0x2543220", VA = "0x182544020")]
		private void ActivateInputFieldInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x254D440", Offset = "0x254C640", VA = "0x18254D440", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x254CB30", Offset = "0x254BD30", VA = "0x18254CB30", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x335D00", Offset = "0x334F00", VA = "0x180335D00")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2546040", Offset = "0x2545240", VA = "0x182546040")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x254BAC0", Offset = "0x254ACC0", VA = "0x18254BAC0", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x254D4A0", Offset = "0x254C6A0", VA = "0x18254D4A0", Slot = "63")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2546A20", Offset = "0x2545C20", VA = "0x182546A20")]
		private void EnforceContentType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x254E820", Offset = "0x254DA20", VA = "0x18254E820")]
		private void SetTextComponentWrapMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x254E790", Offset = "0x254D990", VA = "0x18254E790")]
		private void SetTextComponentRichTextMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x254E8D0", Offset = "0x254DAD0", VA = "0x18254E8D0")]
		private void SetToCustomIfContentTypeIsNot(params TMP_InputField.ContentType[] allowedContentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x254E940", Offset = "0x254DB40", VA = "0x18254E940")]
		private void SetToCustom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x254E940", Offset = "0x254DB40", VA = "0x18254E940")]
		private void SetToCustom(TMP_InputField.CharacterValidation characterValidation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x11D8AE0", Offset = "0x11D7CE0", VA = "0x1811D8AE0", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x254E6A0", Offset = "0x254D8A0", VA = "0x18254E6A0")]
		public void SetGlobalPointSize(float pointSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x254E5B0", Offset = "0x254D7B0", VA = "0x18254E5B0")]
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4CF980", Offset = "0x4CEB80", VA = "0x1804CF980", Slot = "46")]
		Transform ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal static class SetPropertyUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x11CBBE0", Offset = "0x11CADE0", VA = "0x1811CBBE0")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD95890", Offset = "0xD94A90", VA = "0x180D95890")]
		public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xD95A00", Offset = "0xD94C00", VA = "0x180D95A00")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xD95840", Offset = "0xD94A40", VA = "0x180D95840")]
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
