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
				[Cpp2IlInjected.Address(RVA = "0x946A710", Offset = "0x9469310", VA = "0x18946A710")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x946A770", Offset = "0x9469370", VA = "0x18946A770")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x946A6D0", Offset = "0x94692D0", VA = "0x18946A6D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x946A210", Offset = "0x9468E10", VA = "0x18946A210")]
			public void BIPLIVPTSAJ(PointerEventData a, RectTransform b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x946A440", Offset = "0x9469040", VA = "0x18946A440")]
			public void YJJKVVYKQXU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x946A320", Offset = "0x9468F20", VA = "0x18946A320")]
			public void FWURUJCGGTA(PointerEventData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x946A3F0", Offset = "0x9468FF0", VA = "0x18946A3F0")]
			public void PXYOFCDGIWU(float a, RectTransform b, Vector3 c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
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
		public readonly HWNZTWGRXOC<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly HWNZTWGRXOC<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly HWNZTWGRXOC<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly HWNZTWGRXOC<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly HWNZTWGRXOC<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly AQWXMNIFQIV PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData GULNHDQWGPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool OQDCNHXSXHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool TSDUUTAVPRH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ZAFHFRBNAIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xB25ED0", Offset = "0xB24AD0", VA = "0x180B25ED0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9469A80", Offset = "0x9468680", VA = "0x189469A80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ATSDQGFBNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xE73FB0", Offset = "0xE72BB0", VA = "0x180E73FB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x94699D0", Offset = "0x94685D0", VA = "0x1894699D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9469A00", Offset = "0x9468600", VA = "0x189469A00")]
		private bool JNHSFRXPYEP(PointerEventData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9469F10", Offset = "0x9468B10", VA = "0x189469F10", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9469FD0", Offset = "0x9468BD0", VA = "0x189469FD0", Slot = "11")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9469D70", Offset = "0x9468970", VA = "0x189469D70", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9469AB0", Offset = "0x94686B0", VA = "0x189469AB0", Slot = "7")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9469BC0", Offset = "0x94687C0", VA = "0x189469BC0", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9469CA0", Offset = "0x94688A0", VA = "0x189469CA0", Slot = "8")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9469F70", Offset = "0x9468B70", VA = "0x189469F70", Slot = "9")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9469FA0", Offset = "0x9468BA0", VA = "0x189469FA0", Slot = "10")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9469B80", Offset = "0x9468780", VA = "0x189469B80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x946A030", Offset = "0x9468C30", VA = "0x18946A030")]
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
		[Cpp2IlInjected.Address(RVA = "0x9465220", Offset = "0x9463E20", VA = "0x189465220")]
		public void SetCanvasSortingOrder(short order, bool activateCanvasGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData GKWKZROVDNA;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9465DB0", Offset = "0x94649B0", VA = "0x189465DB0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9465C90", Offset = "0x9464890", VA = "0x189465C90", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9466290", Offset = "0x9464E90", VA = "0x189466290")]
		private void YTVVYCCOSNP(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9466080", Offset = "0x9464C80", VA = "0x189466080")]
		public void SetOptionsWithNoDefault(List<string> values, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9465FA0", Offset = "0x9464BA0", VA = "0x189465FA0")]
		public void SetOptionsWithNoDefault(List<OptionData> options, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9465ED0", Offset = "0x9464AD0", VA = "0x189465ED0", Slot = "43")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "46")]
		protected override GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9466340", Offset = "0x9464F40", VA = "0x189466340")]
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
		private sealed class SVNALMHZMUA : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public SVNALMHZMUA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9467BD0", Offset = "0x94667D0", VA = "0x189467BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x94680E0", Offset = "0x9466CE0", VA = "0x1894680E0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
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
		private readonly BGRHNWBEZAP<object> PQTZHBUEFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool ATIKBGEPEUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? GYZNXXKXHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? LADDWDLJNGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? PJITZOEVPZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool VEPEWORGFKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool BNYABAGILWF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ignoreLayout
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9467370", Offset = "0x9465F70", VA = "0x189467370", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool MHKZRMQBWYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9467320", Offset = "0x9465F20", VA = "0x189467320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BSYJZIMHBIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB60720", Offset = "0xB5F320", VA = "0x180B60720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9467550", Offset = "0x9466150", VA = "0x189467550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action SXJYXJALXRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9467280", Offset = "0x9465E80", VA = "0x189467280")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x94674B0", Offset = "0x94660B0", VA = "0x1894674B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9466CE0", Offset = "0x94658E0", VA = "0x189466CE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9466EF0", Offset = "0x9465AF0", VA = "0x189466EF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9466EA0", Offset = "0x9465AA0", VA = "0x189466EA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9466E90", Offset = "0x9465A90", VA = "0x189466E90")]
		public void Hide(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x94671F0", Offset = "0x9465DF0", VA = "0x1894671F0")]
		public void Show(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9467100", Offset = "0x9465D00", VA = "0x189467100")]
		public void Set(object token, bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9466D70", Offset = "0x9465970", VA = "0x189466D70")]
		public void Clear(bool refresh = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9466F80", Offset = "0x9465B80", VA = "0x189466F80")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9466E20", Offset = "0x9465A20", VA = "0x189466E20")]
		[IteratorStateMachine(typeof(SVNALMHZMUA))]
		private IEnumerator<UGECMBPSTCZ> GYNIJZHPJCB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9466DE0", Offset = "0x94659E0", VA = "0x189466DE0", Slot = "5")]
		public virtual void DoHideOrShow(bool shouldHide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9467200", Offset = "0x9465E00", VA = "0x189467200")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class EZSRMSLADIK
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
		private static PPDHWZWSJQC BHEFJZCJOBK;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static PPDHWZWSJQC KRIULRMFMYF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9466700", Offset = "0x9465300", VA = "0x189466700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static ThemeOptions WWQXLATKZTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x94664F0", Offset = "0x94650F0", VA = "0x1894664F0")]
			get
			{
				return default(ThemeOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9466390", Offset = "0x9464F90", VA = "0x189466390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event Action<ThemeOptions> VEVYGSKHLLA
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9466820", Offset = "0x9465420", VA = "0x189466820")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9466620", Offset = "0x9465220", VA = "0x189466620")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface AQPIWFVZNUS : YNIIMDFEWKJ, BAWBPRLGOAR, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, YVLKVCMDLVX
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		AQWXMNIFQIV RUCZRKYJSGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TVVSFJCWLRF Clear();

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SpawnLoadingPlaceholders(GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TVVSFJCWLRF Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TVVSFJCWLRF Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject defaultPrefab, Func<int, GameObject> getPrefabForIndexEvent);

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
		private static readonly int DQZMVIQJOAL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<GradientType, string> XXOWAWWLCIN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int EBHNZVHTHDM = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int UZJWREGUMKU;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int QNDKKIGDGXA;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int IASNHLMSEKV;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int ECAVVZDOENX;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int DATTGJMJFDE;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int BMHXFRTUJAE;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int XLNHZYVJEHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool ULWAMSGPQRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool PSFVYEXIDTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] XWSACBAERIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GradientType type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly GradientType[] IZPQPYJQDVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[ConditionalField("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly GradientType[] QRWBTJFDHOI;

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
		public override Graphic BWYFZUKRHYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool XGPPTGIRXWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient LOEALNGZAWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9469830", Offset = "0x9468430", VA = "0x189469830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public GradientType JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xE67560", Offset = "0xE66160", VA = "0x180E67560")]
			get
			{
				return default(GradientType);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x94699A0", Offset = "0x94685A0", VA = "0x1894699A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool VKPBZLASZXC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9468410", Offset = "0x9467010", VA = "0x189468410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 KLWNBIZPXOE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x94697A0", Offset = "0x94683A0", VA = "0x1894697A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x94697E0", Offset = "0x94683E0", VA = "0x1894697E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool IOOPUNZFJMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9468480", Offset = "0x9467080", VA = "0x189468480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 FNVHMWLXVDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x94697C0", Offset = "0x94683C0", VA = "0x1894697C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9469950", Offset = "0x9468550", VA = "0x189469950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float OKYBHVMMFLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xE8C410", Offset = "0xE8B010", VA = "0x180E8C410")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x28018B0", Offset = "0x28004B0", VA = "0x1828018B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 EYSEHSFGEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x94692A0", Offset = "0x9467EA0", VA = "0x1894692A0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 JGPAUNJXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9469230", Offset = "0x9467E30", VA = "0x189469230")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float DZXYPUDCGPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xB2EEA0", Offset = "0xB2DAA0", VA = "0x180B2EEA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x94699B0", Offset = "0x94685B0", VA = "0x1894699B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9468680", Offset = "0x9467280", VA = "0x189468680", Slot = "12")]
		protected override void NZHCERJQJYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x94684F0", Offset = "0x94670F0", VA = "0x1894684F0")]
		private void NJDYGKCKJPB(Color[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9468820", Offset = "0x9467420", VA = "0x189468820", Slot = "13")]
		protected override void PBSLHYLDMBF(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x94681F0", Offset = "0x9466DF0", VA = "0x1894681F0", Slot = "14")]
		protected override void CAFPXRXQKIO(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x94696F0", Offset = "0x94682F0", VA = "0x1894696F0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly DBKUNCYULQI TALQEAMBNVI;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite PMYXDWYRYWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material QCQFYWLZWYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material AXKIAZMAKRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool LKOXXZCQAHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool ATIKBGEPEUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool IGOYMBDEYIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool TYRRDAJZQOP;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic BWYFZUKRHYH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader YYOTVXOQIMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool XGPPTGIRXWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool KIGETHZJNWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform YJOQRYSHGIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x946AB40", Offset = "0x9469740", VA = "0x18946AB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect PPLJIZQYZKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x946B010", Offset = "0x9469C10", VA = "0x18946B010")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite KJFJASROMFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x946B130", Offset = "0x9469D30", VA = "0x18946B130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x946A960", Offset = "0x9469560", VA = "0x18946A960", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x946B330", Offset = "0x9469F30", VA = "0x18946B330", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x946B620", Offset = "0x946A220", VA = "0x18946B620", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x946B4D0", Offset = "0x946A0D0", VA = "0x18946B4D0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x946ACE0", Offset = "0x94698E0", VA = "0x18946ACE0")]
		private void HLZOZHLQGSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x946AEB0", Offset = "0x9469AB0", VA = "0x18946AEB0")]
		private void MFCMUAQPQPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x946B630", Offset = "0x946A230", VA = "0x18946B630")]
		private void QSEREJFROBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x946AE60", Offset = "0x9469A60", VA = "0x18946AE60")]
		private void HXWKSXSRQDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x946B9B0", Offset = "0x946A5B0", VA = "0x18946B9B0")]
		protected void ZOCQDPOYRUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x946ABA0", Offset = "0x94697A0", VA = "0x18946ABA0")]
		private void FCZVMGXBYOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
		protected virtual void NZHCERJQJYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "13")]
		protected virtual void PBSLHYLDMBF(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "14")]
		protected virtual void CAFPXRXQKIO(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x946B660", Offset = "0x946A260", VA = "0x18946B660")]
		private void TDVWKCSQNGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
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
		private static readonly int QUAXSOTRZKG;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int OALSXXGRGCM;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int SZDLXQDXVXB;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int TOBAHCNUXEI;

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
		private Color[] XWSACBAERIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] QBQRNMIHNJH;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic BWYFZUKRHYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool KIGETHZJNWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> PGLYSVQTSNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 KLWNBIZPXOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x946C690", Offset = "0x946B290", VA = "0x18946C690")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x946C6B0", Offset = "0x946B2B0", VA = "0x18946C6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x946C2D0", Offset = "0x946AED0", VA = "0x18946C2D0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> newLayers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x946C090", Offset = "0x946AC90", VA = "0x18946C090")]
		public bool SetRingLayerColor(int layer, Color color)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x946C1E0", Offset = "0x946ADE0", VA = "0x18946C1E0")]
		public bool SetRingLayerSize(int layer, float size)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x946BE00", Offset = "0x946AA00", VA = "0x18946BE00", Slot = "12")]
		protected override void NZHCERJQJYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x946BF40", Offset = "0x946AB40", VA = "0x18946BF40", Slot = "13")]
		protected override void PBSLHYLDMBF(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x946BDB0", Offset = "0x946A9B0", VA = "0x18946BDB0", Slot = "14")]
		protected override void CAFPXRXQKIO(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x946C420", Offset = "0x946B020", VA = "0x18946C420")]
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
		private static readonly int AQIHJXZRITX;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int BJDQFENINKC;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int NIUFYQFMIIQ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int XVCOBMSVKIK;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int TUMSUYAXDSB;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int JARZZLDAWJA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int UDVPWJFZXCM;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int SOIMAPGXIQB;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int ONNDRVRYCYW;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int ISYXLPKLUVK;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int YWRGJNRDVNX;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ZETSMEBGJCZ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int EUVZMUDOJXI;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int IVSWXCTTPUZ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int QWYSKACFVSU;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int ZJKXARAQFSR;

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
		public override Graphic BWYFZUKRHYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool KIGETHZJNWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite PKMCQZLVISA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x946D4D0", Offset = "0x946C0D0", VA = "0x18946D4D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x946D700", Offset = "0x946C300", VA = "0x18946D700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color PPSIUKQQOED
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xF343B0", Offset = "0xF32FB0", VA = "0x180F343B0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x946D790", Offset = "0x946C390", VA = "0x18946D790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color PYCYDLSOJBS
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xF343A0", Offset = "0xF32FA0", VA = "0x180F343A0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x946D5D0", Offset = "0x946C1D0", VA = "0x18946D5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float CDDCHXDMLBS
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xE8B190", Offset = "0xE89D90", VA = "0x180E8B190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x946D690", Offset = "0x946C290", VA = "0x18946D690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 KAMUUPXWFES
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x1371CF0", Offset = "0x13708F0", VA = "0x181371CF0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x946D6B0", Offset = "0x946C2B0", VA = "0x18946D6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float TIQLVDZUMDM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAE0", Offset = "0xB2D6E0", VA = "0x180B2EAE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x946D650", Offset = "0x946C250", VA = "0x18946D650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 PQXYHFIGDFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x18C9C90", Offset = "0x18C8890", VA = "0x1818C9C90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x946D810", Offset = "0x946C410", VA = "0x18946D810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float UUTYOZATVZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x1363810", Offset = "0x1362410", VA = "0x181363810")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x946D590", Offset = "0x946C190", VA = "0x18946D590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 DKYRSNADNWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x946C700", Offset = "0x946B300", VA = "0x18946C700")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AnimationType CNDDZQMOIRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1061E50", Offset = "0x1060A50", VA = "0x181061E50")]
			get
			{
				return default(AnimationType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x946D5B0", Offset = "0x946C1B0", VA = "0x18946D5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float YTCJYRMEYGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1371600", Offset = "0x1370200", VA = "0x181371600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x946D670", Offset = "0x946C270", VA = "0x18946D670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float TNKXNHYMJEB
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1371610", Offset = "0x1370210", VA = "0x181371610")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x946D570", Offset = "0x946C170", VA = "0x18946D570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x946C7E0", Offset = "0x946B3E0", VA = "0x18946C7E0", Slot = "13")]
		protected override void PBSLHYLDMBF(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x946CEB0", Offset = "0x946BAB0", VA = "0x18946CEB0")]
		private void QALSORRTZNV(Sprite a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x946C790", Offset = "0x946B390", VA = "0x18946C790", Slot = "14")]
		protected override void CAFPXRXQKIO(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x946D440", Offset = "0x946C040", VA = "0x18946D440")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader XDSXWFPSFZZ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader YYOTVXOQIMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x946D8B0", Offset = "0x946C4B0", VA = "0x18946D8B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x946D860", Offset = "0x946C460", VA = "0x18946D860")]
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
		private SerializableRectTransform ALGXEQSCEBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool EVOXDTACGNA;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9467800", Offset = "0x9466400", VA = "0x189467800")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9467980", Offset = "0x9466580", VA = "0x189467980")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9467A80", Offset = "0x9466680", VA = "0x189467A80")]
		private void QZPWREBTYBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9467B00", Offset = "0x9466700", VA = "0x189467B00")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
namespace RRUI.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class DBKUNCYULQI
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
			public Component VAVZNXDXCGA
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9467790", Offset = "0x9466390", VA = "0x189467790")]
			public QueuedOperation(Component context, Action refreshOperation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9467710", Offset = "0x9466310", VA = "0x189467710")]
			public void YMCZYPRTVWQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x9467700", Offset = "0x9466300", VA = "0x189467700", Slot = "4")]
			public bool Equals(QueuedOperation other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9467670", Offset = "0x9466270", VA = "0x189467670", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class FUMCJWVNTGB : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public DBKUNCYULQI VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public FUMCJWVNTGB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x9466900", Offset = "0x9465500", VA = "0x189466900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x9466CA0", Offset = "0x94658A0", VA = "0x189466CA0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly ScheduleQueueType IBRYPWEISMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly int NSVLYJYNCSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly int GNGKFASTDHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly Func<Component, float> XSUIKLMRDFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly Dictionary<Component, QueuedOperation> DJXVCCKPDCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly LinkedList<QueuedOperation> GAVUIRINDOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly List<QueuedOperation> SASOPYZHXRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private GEUHFRHGIWS XPWZSHLOZHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private ASVHLEOBLHF KBJNEFUJZUV;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ASVHLEOBLHF BZXEPCYGBRA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9465610", Offset = "0x9464210", VA = "0x189465610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9465B30", Offset = "0x9464730", VA = "0x189465B30")]
		public DBKUNCYULQI(ScheduleQueueType a, int b = -1, int c = -1, [Optional] Func<Component, float> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9465390", Offset = "0x9463F90", VA = "0x189465390")]
		public void EJMQZCHPBFD(Component a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9465700", Offset = "0x9464300", VA = "0x189465700")]
		public void LUTEILSEADB(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x94656A0", Offset = "0x94642A0", VA = "0x1894656A0")]
		public bool JXEGCWNMNRJ(Component a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9465890", Offset = "0x9464490", VA = "0x189465890")]
		private void NPLHKYOCUXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9465AC0", Offset = "0x94646C0", VA = "0x189465AC0")]
		[IteratorStateMachine(typeof(FUMCJWVNTGB))]
		private IEnumerator<UGECMBPSTCZ> QPRRRJETHKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x787E6B0", Offset = "0x787D2B0", VA = "0x18787E6B0")]
		[CompilerGenerated]
		private void RIVMJXUBFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9465310", Offset = "0x9463F10", VA = "0x189465310")]
		[CompilerGenerated]
		private float AHPEZHJQWKM(QueuedOperation a)
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
