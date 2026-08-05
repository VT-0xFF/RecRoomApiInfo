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
			[Cpp2IlInjected.Address(RVA = "0x2691360", Offset = "0x268F960", VA = "0x182691360")]
			public SubmitEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public class OnChangeEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2691240", Offset = "0x268F840", VA = "0x182691240")]
			public OnChangeEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public class SelectionEvent : UnityEvent<string>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2691320", Offset = "0x268F920", VA = "0x182691320")]
			public SelectionEvent()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x26913A0", Offset = "0x268F9A0", VA = "0x1826913A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x34A760", Offset = "0x348D60", VA = "0x18034A760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x34A760", Offset = "0x348D60", VA = "0x18034A760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x34A830", Offset = "0x348E30", VA = "0x18034A830")]
			[DebuggerHidden]
			public <CaretBlink>d__249(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x34AEE0", Offset = "0x3494E0", VA = "0x18034AEE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x26913E0", Offset = "0x268F9E0", VA = "0x1826913E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x2691500", Offset = "0x268FB00", VA = "0x182691500", Slot = "8")]
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
				[Cpp2IlInjected.Address(RVA = "0x34A760", Offset = "0x348D60", VA = "0x18034A760", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x34A760", Offset = "0x348D60", VA = "0x18034A760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x34A830", Offset = "0x348E30", VA = "0x18034A830")]
			[DebuggerHidden]
			public <MouseDragOutsideRect>d__266(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x34AEE0", Offset = "0x3494E0", VA = "0x18034AEE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x2691550", Offset = "0x268FB50", VA = "0x182691550", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x26917B0", Offset = "0x268FDB0", VA = "0x1826917B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x268FAF0", Offset = "0x268E0F0", VA = "0x18268FAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TouchScreenKeyboard.Status LastKeyboardStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x810500", Offset = "0x80EB00", VA = "0x180810500")]
			[CompilerGenerated]
			get
			{
				return default(TouchScreenKeyboard.Status);
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x80EB80", Offset = "0x80D180", VA = "0x18080EB80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TouchScreenKeyboard LastTouchScreenKeyboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4788B0", Offset = "0x476EB0", VA = "0x1804788B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected Mesh mesh
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x268FBD0", Offset = "0x268E1D0", VA = "0x18268FBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool shouldHideMobileInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x268FC90", Offset = "0x268E290", VA = "0x18268FC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string text
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x403D10", Offset = "0x402310", VA = "0x180403D10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x2690F60", Offset = "0x268F560", VA = "0x182690F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool isFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA74CD0", Offset = "0xA732D0", VA = "0x180A74CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float caretBlinkRate
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x12E9710", Offset = "0x12E7D10", VA = "0x1812E9710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x268FD30", Offset = "0x268E330", VA = "0x18268FD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int caretWidth
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x847C40", Offset = "0x846240", VA = "0x180847C40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x268FF20", Offset = "0x268E520", VA = "0x18268FF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RectTransform textViewport
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x847410", Offset = "0x845A10", VA = "0x180847410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2690F10", Offset = "0x268F510", VA = "0x182690F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public TMP_Text textComponent
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5D2EA0", Offset = "0x5D14A0", VA = "0x1805D2EA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2690EC0", Offset = "0x268F4C0", VA = "0x182690EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Graphic placeholder
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4E4F10", Offset = "0x4E3510", VA = "0x1804E4F10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2690A60", Offset = "0x268F060", VA = "0x182690A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Scrollbar verticalScrollbar
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x68FA80", Offset = "0x68E080", VA = "0x18068FA80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x26910B0", Offset = "0x268F6B0", VA = "0x1826910B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public float scrollSensitivity
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA21F60", Offset = "0xA20560", VA = "0x180A21F60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x2690CB0", Offset = "0x268F2B0", VA = "0x182690CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Color caretColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x268FB70", Offset = "0x268E170", VA = "0x18268FB70")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x268FDA0", Offset = "0x268E3A0", VA = "0x18268FDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool customCaretColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x12E9820", Offset = "0x12E7E20", VA = "0x1812E9820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2690370", Offset = "0x268E970", VA = "0x182690370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Color selectionColor
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x12E99C0", Offset = "0x12E7FC0", VA = "0x1812E99C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2690DB0", Offset = "0x268F3B0", VA = "0x182690DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public SubmitEvent onEndEdit
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x478720", Offset = "0x476D20", VA = "0x180478720")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2690830", Offset = "0x268EE30", VA = "0x182690830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public SubmitEvent onSubmit
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x478A40", Offset = "0x477040", VA = "0x180478A40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2690920", Offset = "0x268EF20", VA = "0x182690920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public SelectionEvent onSelect
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4036B0", Offset = "0x401CB0", VA = "0x1804036B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x26908D0", Offset = "0x268EED0", VA = "0x1826908D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public SelectionEvent onDeselect
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x404040", Offset = "0x402640", VA = "0x180404040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x26907E0", Offset = "0x268EDE0", VA = "0x1826907E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public TextSelectionEvent onTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x70F250", Offset = "0x70D850", VA = "0x18070F250")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2690970", Offset = "0x268EF70", VA = "0x182690970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TextSelectionEvent onEndTextSelection
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x70F3D0", Offset = "0x70D9D0", VA = "0x18070F3D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2690880", Offset = "0x268EE80", VA = "0x182690880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public OnChangeEvent onValueChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x70F1F0", Offset = "0x70D7F0", VA = "0x18070F1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2690A10", Offset = "0x268F010", VA = "0x182690A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public OnValidateInput onValidateInput
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA74C50", Offset = "0xA73250", VA = "0x180A74C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x26909C0", Offset = "0x268EFC0", VA = "0x1826909C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int characterLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x12E9800", Offset = "0x12E7E00", VA = "0x1812E9800")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x268FFC0", Offset = "0x268E5C0", VA = "0x18268FFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float pointSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x12E9970", Offset = "0x12E7F70", VA = "0x1812E9970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2690AB0", Offset = "0x268F0B0", VA = "0x182690AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public TMP_FontAsset fontAsset
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x403B70", Offset = "0x402170", VA = "0x180403B70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x26903E0", Offset = "0x268E9E0", VA = "0x1826903E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool onFocusSelectAll
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x11082E0", Offset = "0x11068E0", VA = "0x1811082E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x12EA6A0", Offset = "0x12E8CA0", VA = "0x1812EA6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool resetOnDeActivation
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x12E9990", Offset = "0x12E7F90", VA = "0x1812E9990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x12EAA10", Offset = "0x12E9010", VA = "0x1812EAA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool restoreOriginalTextOnEscape
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x12E99A0", Offset = "0x12E7FA0", VA = "0x1812E99A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x12EAA20", Offset = "0x12E9020", VA = "0x1812EAA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool isRichTextEditingAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x12E98A0", Offset = "0x12E7EA0", VA = "0x1812E98A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x12EA3C0", Offset = "0x12E89C0", VA = "0x1812EA3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool updateMobileViewWhenKeyboardOpens
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x268FCC0", Offset = "0x268E2C0", VA = "0x18268FCC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x26910A0", Offset = "0x268F6A0", VA = "0x1826910A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ForceDisableScreenSpaceNotification
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x268FAE0", Offset = "0x268E0E0", VA = "0x18268FAE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TMP_InputField.ContentType contentType
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6D42A0", Offset = "0x6D28A0", VA = "0x1806D42A0")]
			get
			{
				return default(TMP_InputField.ContentType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x26900C0", Offset = "0x268E6C0", VA = "0x1826900C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public TMP_InputField.LineType lineType
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xE5D460", Offset = "0xE5BA60", VA = "0x180E5D460")]
			get
			{
				return default(TMP_InputField.LineType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2690670", Offset = "0x268EC70", VA = "0x182690670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TMP_InputField.InputType inputType
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xAE7A10", Offset = "0xAE6010", VA = "0x180AE7A10")]
			get
			{
				return default(TMP_InputField.InputType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2690520", Offset = "0x268EB20", VA = "0x182690520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public TouchScreenKeyboardType keyboardType
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xE5D470", Offset = "0xE5BA70", VA = "0x180E5D470")]
			get
			{
				return default(TouchScreenKeyboardType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2690600", Offset = "0x268EC00", VA = "0x182690600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public TMP_InputField.CharacterValidation characterValidation
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xC761C0", Offset = "0xC747C0", VA = "0x180C761C0")]
			get
			{
				return default(TMP_InputField.CharacterValidation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2690050", Offset = "0x268E650", VA = "0x182690050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TMP_InputValidator inputValidator
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xCFF0B0", Offset = "0xCFD6B0", VA = "0x180CFF0B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2690590", Offset = "0x268EB90", VA = "0x182690590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool readOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x12E9980", Offset = "0x12E7F80", VA = "0x1812E9980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x12EAA00", Offset = "0x12E9000", VA = "0x1812EAA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool richText
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x12E99B0", Offset = "0x12E7FB0", VA = "0x1812E99B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2690C20", Offset = "0x268F220", VA = "0x182690C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool multiLine
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x268FC70", Offset = "0x268E270", VA = "0x18268FC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public char asteriskChar
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x268FB60", Offset = "0x268E160", VA = "0x18268FB60")]
			get
			{
				return default(char);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x268FCD0", Offset = "0x268E2D0", VA = "0x18268FCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool wasCanceled
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x12E9A80", Offset = "0x12E8080", VA = "0x1812E9A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected int caretPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x12E9780", Offset = "0x12E7D80", VA = "0x1812E9780")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x268FE50", Offset = "0x268E450", VA = "0x18268FE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		protected int stringPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x12E99D0", Offset = "0x12E7FD0", VA = "0x1812E99D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x12EADC0", Offset = "0x12E93C0", VA = "0x1812EADC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected int caretSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x12E97C0", Offset = "0x12E7DC0", VA = "0x1812E97C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x268FF00", Offset = "0x268E500", VA = "0x18268FF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected int stringSelectPositionInternal
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x12E9A10", Offset = "0x12E8010", VA = "0x1812E9A10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x12EAE60", Offset = "0x12E9460", VA = "0x1812EAE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool hasSelection
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x12E9830", Offset = "0x12E7E30", VA = "0x1812E9830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int caretPosition
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x12E97C0", Offset = "0x12E7DC0", VA = "0x1812E97C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x268FE70", Offset = "0x268E470", VA = "0x18268FE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int selectionAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x12E9780", Offset = "0x12E7D80", VA = "0x1812E9780")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2690D50", Offset = "0x268F350", VA = "0x182690D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int selectionFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x12E97C0", Offset = "0x12E7DC0", VA = "0x1812E97C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2690E60", Offset = "0x268F460", VA = "0x182690E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int stringPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x12E9A10", Offset = "0x12E8010", VA = "0x1812E9A10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x12EADE0", Offset = "0x12E93E0", VA = "0x1812EADE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public int selectionStringAnchorPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x12E99D0", Offset = "0x12E7FD0", VA = "0x1812E99D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x12EACD0", Offset = "0x12E92D0", VA = "0x1812EACD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int selectionStringFocusPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x12E9A10", Offset = "0x12E8010", VA = "0x1812E9A10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x12EAD20", Offset = "0x12E9320", VA = "0x1812EAD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private static string clipboard
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x12E9810", Offset = "0x12E7E10", VA = "0x1812E9810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x351A40", Offset = "0x350040", VA = "0x180351A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x268F770", Offset = "0x268DD70", VA = "0x18268F770")]
		protected AG_TMP_InputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x12DFC10", Offset = "0x12DE210", VA = "0x1812DFC10")]
		protected void ClampStringPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2685EE0", Offset = "0x26844E0", VA = "0x182685EE0")]
		protected void ClampCaretPos(ref int pos)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x268C1E0", Offset = "0x268A7E0", VA = "0x18268C1E0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x268BC00", Offset = "0x268A200", VA = "0x18268BC00", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x268BA40", Offset = "0x268A040", VA = "0x18268BA40")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2685E80", Offset = "0x2684480", VA = "0x182685E80")]
		[IteratorStateMachine(typeof(<CaretBlink>d__249))]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x268E640", Offset = "0x268CC40", VA = "0x18268E640")]
		private void SetCaretVisible()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x268E590", Offset = "0x268CB90", VA = "0x18268E590")]
		private void SetCaretActive()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x12E68B0", Offset = "0x12E4EB0", VA = "0x1812E68B0")]
		protected void OnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x12E7EB0", Offset = "0x12E64B0", VA = "0x1812E7EB0")]
		protected void SelectAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x268B260", Offset = "0x2689860", VA = "0x18268B260")]
		public void MoveTextEnd(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x268B3A0", Offset = "0x26899A0", VA = "0x18268B3A0")]
		public void MoveTextStart(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x268B490", Offset = "0x2689A90", VA = "0x18268B490")]
		public void MoveToEndOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x268B630", Offset = "0x2689C30", VA = "0x18268B630")]
		public void MoveToStartOfLine(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2688AB0", Offset = "0x26870B0", VA = "0x182688AB0")]
		private bool InPlaceEditing()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2689150", Offset = "0x2687750", VA = "0x182689150", Slot = "51")]
		protected virtual void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2689D70", Offset = "0x2688370", VA = "0x182689D70")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x268BB60", Offset = "0x268A160", VA = "0x18268BB60", Slot = "52")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x268BF10", Offset = "0x268A510", VA = "0x18268BF10", Slot = "53")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2689E40", Offset = "0x2688440", VA = "0x182689E40")]
		[IteratorStateMachine(typeof(<MouseDragOutsideRect>d__266))]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x268C890", Offset = "0x268AE90", VA = "0x18268C890", Slot = "54")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x268CC40", Offset = "0x268B240", VA = "0x18268CC40", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2688CE0", Offset = "0x26872E0", VA = "0x182688CE0")]
		protected EditState KeyPressed(Event evt)
		{
			return default(EditState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2688C80", Offset = "0x2687280", VA = "0x182688C80")]
		private bool IsValidChar(char c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x268E0F0", Offset = "0x268C6F0", VA = "0x18268E0F0")]
		public void ProcessEvent(Event e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x268D600", Offset = "0x268BC00", VA = "0x18268D600", Slot = "55")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x268D2E0", Offset = "0x268B8E0", VA = "0x18268D2E0", Slot = "56")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x26888F0", Offset = "0x2686EF0", VA = "0x1826888F0")]
		private string GetSelectedString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2686D50", Offset = "0x2685350", VA = "0x182686D50")]
		private int FindtNextWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x268AE90", Offset = "0x2689490", VA = "0x18268AE90")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2686E90", Offset = "0x2685490", VA = "0x182686E90")]
		private int FindtPrevWordBegin()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x268A160", Offset = "0x2688760", VA = "0x18268A160")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x26899B0", Offset = "0x2687FB0", VA = "0x1826899B0")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2689610", Offset = "0x2687C10", VA = "0x182689610")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x268DC60", Offset = "0x268C260", VA = "0x18268DC60")]
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x268D760", Offset = "0x268BD60", VA = "0x18268D760")]
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2689EB0", Offset = "0x26884B0", VA = "0x182689EB0")]
		private void MoveDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2689EC0", Offset = "0x26884C0", VA = "0x182689EC0")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x268B7B0", Offset = "0x2689DB0", VA = "0x18268B7B0")]
		private void MoveUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x268B7C0", Offset = "0x2689DC0", VA = "0x18268B7C0")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x268A9D0", Offset = "0x2688FD0", VA = "0x18268A9D0")]
		private void MovePageUp(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x268A9E0", Offset = "0x2688FE0", VA = "0x18268A9E0")]
		private void MovePageUp(bool shift, bool goToFirstChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x268A9C0", Offset = "0x2688FC0", VA = "0x18268A9C0")]
		private void MovePageDown(bool shift)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x268A4F0", Offset = "0x2688AF0", VA = "0x18268A4F0")]
		private void MovePageDown(bool shift, bool goToLastChar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2686440", Offset = "0x2684A40", VA = "0x182686440")]
		private void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2686FA0", Offset = "0x26855A0", VA = "0x182686FA0")]
		private void ForwardSpace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2685C00", Offset = "0x2684200", VA = "0x182685C00")]
		private void Backspace()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2685110", Offset = "0x2683710", VA = "0x182685110", Slot = "57")]
		protected virtual void Append(string input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x26851C0", Offset = "0x26837C0", VA = "0x1826851C0", Slot = "58")]
		protected virtual void Append(char input)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2688B20", Offset = "0x2687120", VA = "0x182688B20")]
		private void Insert(char c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x268E4E0", Offset = "0x268CAE0", VA = "0x18268E4E0")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x268E540", Offset = "0x268CB40", VA = "0x18268E540")]
		private void SendOnValueChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x268E1D0", Offset = "0x268C7D0", VA = "0x18268E1D0")]
		protected void SendOnEndEdit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x268E3B0", Offset = "0x268C9B0", VA = "0x18268E3B0")]
		protected void SendOnSubmit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x268E360", Offset = "0x268C960", VA = "0x18268E360")]
		protected void SendOnFocus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x268E310", Offset = "0x268C910", VA = "0x18268E310")]
		protected void SendOnFocusLost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x268E400", Offset = "0x268CA00", VA = "0x18268E400")]
		protected void SendOnTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x268E220", Offset = "0x268C820", VA = "0x18268E220")]
		protected void SendOnEndTextSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x268EB00", Offset = "0x268D100", VA = "0x18268EB00")]
		protected void UpdateLabel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x268EDA0", Offset = "0x268D3A0", VA = "0x18268EDA0")]
		private void UpdateScrollbar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x268D4B0", Offset = "0x268BAB0", VA = "0x18268D4B0")]
		private void OnScrollbarValueChange(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2684F90", Offset = "0x2683590", VA = "0x182684F90")]
		private void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x2688830", Offset = "0x2686E30", VA = "0x182688830")]
		private int GetCaretPositionFromStringIndex(int stringIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x2688A00", Offset = "0x2687000", VA = "0x182688A00")]
		private int GetStringIndexFromCaretPosition(int caretPosition)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2686F90", Offset = "0x2685590", VA = "0x182686F90")]
		public void ForceLabelUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x2689D10", Offset = "0x2688310", VA = "0x182689D10")]
		private void MarkGeometryAsDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x268E100", Offset = "0x268C700", VA = "0x18268E100", Slot = "59")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x34AEE0", Offset = "0x3494E0", VA = "0x18034AEE0", Slot = "60")]
		public virtual void LayoutComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x34AEE0", Offset = "0x3494E0", VA = "0x18034AEE0", Slot = "61")]
		public virtual void GraphicUpdateComplete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x268EA30", Offset = "0x268D030", VA = "0x18268EA30")]
		private void UpdateGeometry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2685460", Offset = "0x2683A60", VA = "0x182685460")]
		private void AssignPositioningIfNeeded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x268C8C0", Offset = "0x268AEC0", VA = "0x18268C8C0")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2687190", Offset = "0x2685790", VA = "0x182687190")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2685F70", Offset = "0x2684570", VA = "0x182685F70")]
		private void CreateCursorVerts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2687C50", Offset = "0x2686250", VA = "0x182687C50")]
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x2684670", Offset = "0x2682C70", VA = "0x182684670")]
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x268EF60", Offset = "0x268D560", VA = "0x18268EF60")]
		protected char Validate(string text, int pos, char ch)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x2684520", Offset = "0x2682B20", VA = "0x182684520")]
		public void ActivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x26840F0", Offset = "0x26826F0", VA = "0x1826840F0")]
		private void ActivateInputFieldInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x268D510", Offset = "0x268BB10", VA = "0x18268D510", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x268CC00", Offset = "0x268B200", VA = "0x18268CC00", Slot = "62")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x34AEE0", Offset = "0x3494E0", VA = "0x18034AEE0")]
		public void OnControlClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2686110", Offset = "0x2684710", VA = "0x182686110")]
		public void DeactivateInputField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x268BB90", Offset = "0x268A190", VA = "0x18268BB90", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x268D570", Offset = "0x268BB70", VA = "0x18268D570", Slot = "63")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x2686AF0", Offset = "0x26850F0", VA = "0x182686AF0")]
		private void EnforceContentType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x268E8F0", Offset = "0x268CEF0", VA = "0x18268E8F0")]
		private void SetTextComponentWrapMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x268E860", Offset = "0x268CE60", VA = "0x18268E860")]
		private void SetTextComponentRichTextMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x268E9A0", Offset = "0x268CFA0", VA = "0x18268E9A0")]
		private void SetToCustomIfContentTypeIsNot(params TMP_InputField.ContentType[] allowedContentTypes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x268EA10", Offset = "0x268D010", VA = "0x18268EA10")]
		private void SetToCustom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x268EA10", Offset = "0x268D010", VA = "0x18268EA10")]
		private void SetToCustom(TMP_InputField.CharacterValidation characterValidation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x12E0810", Offset = "0x12DEE10", VA = "0x1812E0810", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x268E770", Offset = "0x268CD70", VA = "0x18268E770")]
		public void SetGlobalPointSize(float pointSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x268E680", Offset = "0x268CC80", VA = "0x18268E680")]
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE40", Offset = "0x4BE440", VA = "0x1804BFE40", Slot = "46")]
		Transform ICanvasElement.get_transform()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	internal static class SetPropertyUtility
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x12D3910", Offset = "0x12D1F10", VA = "0x1812D3910")]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xED37F0", Offset = "0xED1DF0", VA = "0x180ED37F0")]
		public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) where T : IEquatable<T>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xED3960", Offset = "0xED1F60", VA = "0x180ED3960")]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xED37A0", Offset = "0xED1DA0", VA = "0x180ED37A0")]
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
