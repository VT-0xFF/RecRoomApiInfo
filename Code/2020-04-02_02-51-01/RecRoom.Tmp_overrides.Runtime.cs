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
			[Cpp2IlInjected.Address(RVA = "0x270EBC0", Offset = "0x270DBC0", VA = "0x18270EBC0")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x270EAA0", Offset = "0x270DAA0", VA = "0x18270EAA0")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x270EB80", Offset = "0x270DB80", VA = "0x18270EB80")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x270EC00", Offset = "0x270DC00", VA = "0x18270EC00")]
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
				[Cpp2IlInjected.Address(RVA = "0x34B420", Offset = "0x34A420", VA = "0x18034B420", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x34B420", Offset = "0x34A420", VA = "0x18034B420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x376220", Offset = "0x375220", VA = "0x180376220")]
			[DebuggerHidden]
			public <CaretBlink>d__249(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x35F0A0", Offset = "0x35E0A0", VA = "0x18035F0A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x270EC40", Offset = "0x270DC40", VA = "0x18270EC40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x270ED60", Offset = "0x270DD60", VA = "0x18270ED60", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x34B420", Offset = "0x34A420", VA = "0x18034B420", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x34B420", Offset = "0x34A420", VA = "0x18034B420", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x376220", Offset = "0x375220", VA = "0x180376220")]
			[DebuggerHidden]
			public <MouseDragOutsideRect>d__266(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x35F0A0", Offset = "0x35E0A0", VA = "0x18035F0A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x270EDB0", Offset = "0x270DDB0", VA = "0x18270EDB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x270F010", Offset = "0x270E010", VA = "0x18270F010", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x270D350", Offset = "0x270C350", VA = "0x18270D350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TouchScreenKeyboard.Status LastKeyboardStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x94B610", Offset = "0x94A610", VA = "0x18094B610")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA27640", Offset = "0xA26640", VA = "0x180A27640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TouchScreenKeyboard LastTouchScreenKeyboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4E2700", Offset = "0x4E1700", VA = "0x1804E2700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected Mesh mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x270D430", Offset = "0x270C430", VA = "0x18270D430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool shouldHideMobileInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x270D4F0", Offset = "0x270C4F0", VA = "0x18270D4F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string text
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x424860", Offset = "0x423860", VA = "0x180424860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x270E7C0", Offset = "0x270D7C0", VA = "0x18270E7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool isFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E31D0", VA = "0x1805E41D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float caretBlinkRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x13C0FF0", Offset = "0x13BFFF0", VA = "0x1813C0FF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x270D590", Offset = "0x270C590", VA = "0x18270D590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int caretWidth
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x13C10E0", Offset = "0x13C00E0", VA = "0x1813C10E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x270D780", Offset = "0x270C780", VA = "0x18270D780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RectTransform textViewport
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5E41E0", Offset = "0x5E31E0", VA = "0x1805E41E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x270E770", Offset = "0x270D770", VA = "0x18270E770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TMP_Text textComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5688F0", Offset = "0x5678F0", VA = "0x1805688F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x270E720", Offset = "0x270D720", VA = "0x18270E720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Graphic placeholder
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x52AC20", Offset = "0x529C20", VA = "0x18052AC20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x270E2C0", Offset = "0x270D2C0", VA = "0x18270E2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Scrollbar verticalScrollbar
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x569BC0", Offset = "0x568BC0", VA = "0x180569BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x270E910", Offset = "0x270D910", VA = "0x18270E910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float scrollSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8DBB60", Offset = "0x8DAB60", VA = "0x1808DBB60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x270E510", Offset = "0x270D510", VA = "0x18270E510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Color caretColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x270D3D0", Offset = "0x270C3D0", VA = "0x18270D3D0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x270D600", Offset = "0x270C600", VA = "0x18270D600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool customCaretColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x13C1110", Offset = "0x13C0110", VA = "0x1813C1110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x270DBD0", Offset = "0x270CBD0", VA = "0x18270DBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color selectionColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x13C12B0", Offset = "0x13C02B0", VA = "0x1813C12B0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x270E610", Offset = "0x270D610", VA = "0x18270E610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public SubmitEvent onEndEdit
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x4E2570", Offset = "0x4E1570", VA = "0x1804E2570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x270E090", Offset = "0x270D090", VA = "0x18270E090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public SubmitEvent onSubmit
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x4E2890", Offset = "0x4E1890", VA = "0x1804E2890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x270E180", Offset = "0x270D180", VA = "0x18270E180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public SelectionEvent onSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4246E0", Offset = "0x4236E0", VA = "0x1804246E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x270E130", Offset = "0x270D130", VA = "0x18270E130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public SelectionEvent onDeselect
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5092B0", Offset = "0x5082B0", VA = "0x1805092B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x270E040", Offset = "0x270D040", VA = "0x18270E040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextSelectionEvent onTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4246F0", Offset = "0x4236F0", VA = "0x1804246F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x270E1D0", Offset = "0x270D1D0", VA = "0x18270E1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TextSelectionEvent onEndTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x569BB0", Offset = "0x568BB0", VA = "0x180569BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x270E0E0", Offset = "0x270D0E0", VA = "0x18270E0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public OnChangeEvent onValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5699D0", Offset = "0x5689D0", VA = "0x1805699D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x270E270", Offset = "0x270D270", VA = "0x18270E270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public OnValidateInput onValidateInput
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5E4140", Offset = "0x5E3140", VA = "0x1805E4140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x270E220", Offset = "0x270D220", VA = "0x18270E220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int characterLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x13C10F0", Offset = "0x13C00F0", VA = "0x1813C10F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x270D820", Offset = "0x270C820", VA = "0x18270D820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float pointSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x13C1260", Offset = "0x13C0260", VA = "0x1813C1260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x270E310", Offset = "0x270D310", VA = "0x18270E310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TMP_FontAsset fontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x508D90", Offset = "0x507D90", VA = "0x180508D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x270DC40", Offset = "0x270CC40", VA = "0x18270DC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool onFocusSelectAll
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x120D0A0", Offset = "0x120C0A0", VA = "0x18120D0A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x13C1F90", Offset = "0x13C0F90", VA = "0x1813C1F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool resetOnDeActivation
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x13C1280", Offset = "0x13C0280", VA = "0x1813C1280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x13C2300", Offset = "0x13C1300", VA = "0x1813C2300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool restoreOriginalTextOnEscape
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x13C1290", Offset = "0x13C0290", VA = "0x1813C1290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x13C2310", Offset = "0x13C1310", VA = "0x1813C2310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool isRichTextEditingAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x13C1190", Offset = "0x13C0190", VA = "0x1813C1190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x13C1CB0", Offset = "0x13C0CB0", VA = "0x1813C1CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool updateMobileViewWhenKeyboardOpens
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x270D520", Offset = "0x270C520", VA = "0x18270D520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x270E900", Offset = "0x270D900", VA = "0x18270E900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ForceDisableScreenSpaceNotification
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x270D340", Offset = "0x270C340", VA = "0x18270D340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TMP_InputField.ContentType contentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8DBD20", Offset = "0x8DAD20", VA = "0x1808DBD20")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x270D920", Offset = "0x270C920", VA = "0x18270D920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public TMP_InputField.LineType lineType
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xE2E700", Offset = "0xE2D700", VA = "0x180E2E700")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x270DED0", Offset = "0x270CED0", VA = "0x18270DED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TMP_InputField.InputType inputType
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xE8C030", Offset = "0xE8B030", VA = "0x180E8C030")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x270DD80", Offset = "0x270CD80", VA = "0x18270DD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TouchScreenKeyboardType keyboardType
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xE2E710", Offset = "0xE2D710", VA = "0x180E2E710")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x270DE60", Offset = "0x270CE60", VA = "0x18270DE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public TMP_InputField.CharacterValidation characterValidation
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB97520", Offset = "0xB96520", VA = "0x180B97520")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x270D8B0", Offset = "0x270C8B0", VA = "0x18270D8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TMP_InputValidator inputValidator
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xC74F30", Offset = "0xC73F30", VA = "0x180C74F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x270DDF0", Offset = "0x270CDF0", VA = "0x18270DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool readOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x13C1270", Offset = "0x13C0270", VA = "0x1813C1270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x13C22F0", Offset = "0x13C12F0", VA = "0x1813C22F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool richText
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x13C12A0", Offset = "0x13C02A0", VA = "0x1813C12A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x270E480", Offset = "0x270D480", VA = "0x18270E480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool multiLine
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x270D4D0", Offset = "0x270C4D0", VA = "0x18270D4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public char asteriskChar
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x270D3C0", Offset = "0x270C3C0", VA = "0x18270D3C0")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x270D530", Offset = "0x270C530", VA = "0x18270D530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool wasCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x13C1370", Offset = "0x13C0370", VA = "0x1813C1370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected int caretPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x13C1060", Offset = "0x13C0060", VA = "0x1813C1060")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x270D6B0", Offset = "0x270C6B0", VA = "0x18270D6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		protected int stringPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x13C12C0", Offset = "0x13C02C0", VA = "0x1813C12C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x13C26B0", Offset = "0x13C16B0", VA = "0x1813C26B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected int caretSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x13C10A0", Offset = "0x13C00A0", VA = "0x1813C10A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x270D760", Offset = "0x270C760", VA = "0x18270D760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected int stringSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x13C1300", Offset = "0x13C0300", VA = "0x1813C1300")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x13C2750", Offset = "0x13C1750", VA = "0x1813C2750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool hasSelection
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x13C1120", Offset = "0x13C0120", VA = "0x1813C1120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int caretPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x13C10A0", Offset = "0x13C00A0", VA = "0x1813C10A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x270D6D0", Offset = "0x270C6D0", VA = "0x18270D6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int selectionAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x13C1060", Offset = "0x13C0060", VA = "0x1813C1060")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x270E5B0", Offset = "0x270D5B0", VA = "0x18270E5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int selectionFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x13C10A0", Offset = "0x13C00A0", VA = "0x1813C10A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x270E6C0", Offset = "0x270D6C0", VA = "0x18270E6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int stringPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x13C1300", Offset = "0x13C0300", VA = "0x1813C1300")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x13C26D0", Offset = "0x13C16D0", VA = "0x1813C26D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int selectionStringAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x13C12C0", Offset = "0x13C02C0", VA = "0x1813C12C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x13C25C0", Offset = "0x13C15C0", VA = "0x1813C25C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int selectionStringFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x13C1300", Offset = "0x13C0300", VA = "0x1813C1300")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x13C2610", Offset = "0x13C1610", VA = "0x1813C2610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private static string clipboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x13C1100", Offset = "0x13C0100", VA = "0x1813C1100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3BB820", Offset = "0x3BA820", VA = "0x1803BB820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x270CFD0", Offset = "0x270BFD0", VA = "0x18270CFD0")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x13B7510", Offset = "0x13B6510", VA = "0x1813B7510")]
		protected void ClampStringPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2703740", Offset = "0x2702740", VA = "0x182703740")]
		protected void ClampCaretPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2709A40", Offset = "0x2708A40", VA = "0x182709A40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2709460", Offset = "0x2708460", VA = "0x182709460", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x27092A0", Offset = "0x27082A0", VA = "0x1827092A0")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x27036E0", Offset = "0x27026E0", VA = "0x1827036E0")]
		[IteratorStateMachine(typeof(<CaretBlink>d__249))]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x270BEA0", Offset = "0x270AEA0", VA = "0x18270BEA0")]
		private void SetCaretVisible()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x270BDF0", Offset = "0x270ADF0", VA = "0x18270BDF0")]
		private void SetCaretActive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x13BE190", Offset = "0x13BD190", VA = "0x1813BE190")]
		protected void OnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x13BF790", Offset = "0x13BE790", VA = "0x1813BF790")]
		protected void SelectAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2708AC0", Offset = "0x2707AC0", VA = "0x182708AC0")]
		public void MoveTextEnd(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2708C00", Offset = "0x2707C00", VA = "0x182708C00")]
		public void MoveTextStart(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2708CF0", Offset = "0x2707CF0", VA = "0x182708CF0")]
		public void MoveToEndOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2708E90", Offset = "0x2707E90", VA = "0x182708E90")]
		public void MoveToStartOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2706310", Offset = "0x2705310", VA = "0x182706310")]
		private bool InPlaceEditing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x27069B0", Offset = "0x27059B0", VA = "0x1827069B0", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x27075D0", Offset = "0x27065D0", VA = "0x1827075D0")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x27093C0", Offset = "0x27083C0", VA = "0x1827093C0", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2709770", Offset = "0x2708770", VA = "0x182709770", Slot = "53")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x27076A0", Offset = "0x27066A0", VA = "0x1827076A0")]
		[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__266))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x270A0F0", Offset = "0x27090F0", VA = "0x18270A0F0", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x270A4A0", Offset = "0x27094A0", VA = "0x18270A4A0", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2706540", Offset = "0x2705540", VA = "0x182706540")]
		protected EditState KeyPressed(Event evt)
		{
			return default(EditState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x27064E0", Offset = "0x27054E0", VA = "0x1827064E0")]
		private bool IsValidChar(char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x270B950", Offset = "0x270A950", VA = "0x18270B950")]
		public void ProcessEvent(Event e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x270AE60", Offset = "0x2709E60", VA = "0x18270AE60", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x270AB40", Offset = "0x2709B40", VA = "0x18270AB40", Slot = "56")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2706150", Offset = "0x2705150", VA = "0x182706150")]
		private string GetSelectedString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x27045B0", Offset = "0x27035B0", VA = "0x1827045B0")]
		private int FindtNextWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x27086F0", Offset = "0x27076F0", VA = "0x1827086F0")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x27046F0", Offset = "0x27036F0", VA = "0x1827046F0")]
		private int FindtPrevWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x27079C0", Offset = "0x27069C0", VA = "0x1827079C0")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2707210", Offset = "0x2706210", VA = "0x182707210")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2706E70", Offset = "0x2705E70", VA = "0x182706E70")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x270B4C0", Offset = "0x270A4C0", VA = "0x18270B4C0")]
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x270AFC0", Offset = "0x2709FC0", VA = "0x18270AFC0")]
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2707710", Offset = "0x2706710", VA = "0x182707710")]
		private void MoveDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2707720", Offset = "0x2706720", VA = "0x182707720")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2709010", Offset = "0x2708010", VA = "0x182709010")]
		private void MoveUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2709020", Offset = "0x2708020", VA = "0x182709020")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2708230", Offset = "0x2707230", VA = "0x182708230")]
		private void MovePageUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2708240", Offset = "0x2707240", VA = "0x182708240")]
		private void MovePageUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2708220", Offset = "0x2707220", VA = "0x182708220")]
		private void MovePageDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2707D50", Offset = "0x2706D50", VA = "0x182707D50")]
		private void MovePageDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2703CA0", Offset = "0x2702CA0", VA = "0x182703CA0")]
		private void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2704800", Offset = "0x2703800", VA = "0x182704800")]
		private void ForwardSpace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2703460", Offset = "0x2702460", VA = "0x182703460")]
		private void Backspace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2702970", Offset = "0x2701970", VA = "0x182702970", Slot = "57")]
		protected virtual void Append(string input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2702A20", Offset = "0x2701A20", VA = "0x182702A20", Slot = "58")]
		protected virtual void Append(char input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2706380", Offset = "0x2705380", VA = "0x182706380")]
		private void Insert(char c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x270BD40", Offset = "0x270AD40", VA = "0x18270BD40")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x270BDA0", Offset = "0x270ADA0", VA = "0x18270BDA0")]
		private void SendOnValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x270BA30", Offset = "0x270AA30", VA = "0x18270BA30")]
		protected void SendOnEndEdit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x270BC10", Offset = "0x270AC10", VA = "0x18270BC10")]
		protected void SendOnSubmit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x270BBC0", Offset = "0x270ABC0", VA = "0x18270BBC0")]
		protected void SendOnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x270BB70", Offset = "0x270AB70", VA = "0x18270BB70")]
		protected void SendOnFocusLost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x270BC60", Offset = "0x270AC60", VA = "0x18270BC60")]
		protected void SendOnTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x270BA80", Offset = "0x270AA80", VA = "0x18270BA80")]
		protected void SendOnEndTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x270C360", Offset = "0x270B360", VA = "0x18270C360")]
		protected void UpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x270C600", Offset = "0x270B600", VA = "0x18270C600")]
		private void UpdateScrollbar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x270AD10", Offset = "0x2709D10", VA = "0x18270AD10")]
		private void OnScrollbarValueChange(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x27027F0", Offset = "0x27017F0", VA = "0x1827027F0")]
		private void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2706090", Offset = "0x2705090", VA = "0x182706090")]
		private int GetCaretPositionFromStringIndex(int stringIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2706260", Offset = "0x2705260", VA = "0x182706260")]
		private int GetStringIndexFromCaretPosition(int caretPosition)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x27047F0", Offset = "0x27037F0", VA = "0x1827047F0")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2707570", Offset = "0x2706570", VA = "0x182707570")]
		private void MarkGeometryAsDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x270B960", Offset = "0x270A960", VA = "0x18270B960", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x35F0A0", Offset = "0x35E0A0", VA = "0x18035F0A0", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x35F0A0", Offset = "0x35E0A0", VA = "0x18035F0A0", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x270C290", Offset = "0x270B290", VA = "0x18270C290")]
		private void UpdateGeometry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2702CC0", Offset = "0x2701CC0", VA = "0x182702CC0")]
		private void AssignPositioningIfNeeded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x270A120", Offset = "0x2709120", VA = "0x18270A120")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x27049F0", Offset = "0x27039F0", VA = "0x1827049F0")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x27037D0", Offset = "0x27027D0", VA = "0x1827037D0")]
		private void CreateCursorVerts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x27054B0", Offset = "0x27044B0", VA = "0x1827054B0")]
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2701ED0", Offset = "0x2700ED0", VA = "0x182701ED0")]
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x270C7C0", Offset = "0x270B7C0", VA = "0x18270C7C0")]
		protected char Validate(string text, int pos, char ch)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2701D80", Offset = "0x2700D80", VA = "0x182701D80")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2701950", Offset = "0x2700950", VA = "0x182701950")]
		private void ActivateInputFieldInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x270AD70", Offset = "0x2709D70", VA = "0x18270AD70", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x270A460", Offset = "0x2709460", VA = "0x18270A460", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x35F0A0", Offset = "0x35E0A0", VA = "0x18035F0A0")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2703970", Offset = "0x2702970", VA = "0x182703970")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x27093F0", Offset = "0x27083F0", VA = "0x1827093F0", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x270ADD0", Offset = "0x2709DD0", VA = "0x18270ADD0", Slot = "63")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2704350", Offset = "0x2703350", VA = "0x182704350")]
		private void EnforceContentType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x270C150", Offset = "0x270B150", VA = "0x18270C150")]
		private void SetTextComponentWrapMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x270C0C0", Offset = "0x270B0C0", VA = "0x18270C0C0")]
		private void SetTextComponentRichTextMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x270C200", Offset = "0x270B200", VA = "0x18270C200")]
		private void SetToCustomIfContentTypeIsNot(params TMP_InputField.ContentType[] allowedContentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x270C270", Offset = "0x270B270", VA = "0x18270C270")]
		private void SetToCustom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x270C270", Offset = "0x270B270", VA = "0x18270C270")]
		private void SetToCustom(TMP_InputField.CharacterValidation characterValidation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x13B8110", Offset = "0x13B7110", VA = "0x1813B8110", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x270BFD0", Offset = "0x270AFD0", VA = "0x18270BFD0")]
		public void SetGlobalPointSize(float pointSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x270BEE0", Offset = "0x270AEE0", VA = "0x18270BEE0")]
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A6840", Offset = "0x3A5840", VA = "0x1803A6840", Slot = "46")]
		Transform ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal static class SetPropertyUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x13AB210", Offset = "0x13AA210", VA = "0x1813AB210")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xF20240", Offset = "0xF1F240", VA = "0x180F20240")]
		public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xF203B0", Offset = "0xF1F3B0", VA = "0x180F203B0")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xF201F0", Offset = "0xF1F1F0", VA = "0x180F201F0")]
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
