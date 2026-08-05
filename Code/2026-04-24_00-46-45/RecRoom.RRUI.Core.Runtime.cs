using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Com.TheFallenGames.OSA.Core;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
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
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA402E80", Offset = "0xA401880", VA = "0x18A402E80")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Core.UI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class UIHandleDecorator : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public class UIHandleEventData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public Vector2 cachedScreenPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public float cachedDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public Vector3 targetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public Vector3 targetForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Vector3 previousTargetPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public RectTransform cachedRectTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Vector3 pressLocalPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Quaternion pressRotationOffset;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Vector3 RemappedWorldPressPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0xA4067B0", Offset = "0xA4051B0", VA = "0x18A4067B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xA406810", Offset = "0xA405210", VA = "0x18A406810")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0xA406770", Offset = "0xA405170", VA = "0x18A406770")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA406610", Offset = "0xA405010", VA = "0x18A406610")]
			public void OLBLUQOXXZY(PointerEventData a, RectTransform b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA4062B0", Offset = "0xA404CB0", VA = "0x18A4062B0")]
			public void BWUYTVDCUIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA406540", Offset = "0xA404F40", VA = "0x18A406540")]
			public void DGQVHLQIGCZ(PointerEventData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA406720", Offset = "0xA405120", VA = "0x18A406720")]
			public void QQQAYYMIKBL(float a, RectTransform b, Vector3 c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly VEFRPOSZNGH<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly VEFRPOSZNGH<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly VEFRPOSZNGH<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly VEFRPOSZNGH<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly VEFRPOSZNGH<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly JOLHGBMRDLK PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly UIHandleEventData SGAWGREVUWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool DVYIWWYFCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private bool ODFHIDOPJZA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ZBVJANZUDXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD22D10", Offset = "0xD21710", VA = "0x180D22D10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA4060A0", Offset = "0xA404AA0", VA = "0x18A4060A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BRUJQMMRMOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE21210", Offset = "0xE1FC10", VA = "0x180E21210")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA405AF0", Offset = "0xA4044F0", VA = "0x18A405AF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA405A70", Offset = "0xA404470", VA = "0x18A405A70")]
		private bool KLPAFAYENPQ(PointerEventData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA405F80", Offset = "0xA404980", VA = "0x18A405F80", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA406040", Offset = "0xA404A40", VA = "0x18A406040", Slot = "11")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA405DE0", Offset = "0xA4047E0", VA = "0x18A405DE0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA405B20", Offset = "0xA404520", VA = "0x18A405B20", Slot = "7")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA405C30", Offset = "0xA404630", VA = "0x18A405C30", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA405D10", Offset = "0xA404710", VA = "0x18A405D10", Slot = "8")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA405FE0", Offset = "0xA4049E0", VA = "0x18A405FE0", Slot = "9")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA406010", Offset = "0xA404A10", VA = "0x18A406010", Slot = "10")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA405BF0", Offset = "0xA4045F0", VA = "0x18A405BF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA4060D0", Offset = "0xA404AD0", VA = "0x18A4060D0")]
		public UIHandleDecorator()
		{
		}
	}
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CanvasSortingOrder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA401550", Offset = "0xA3FFF50", VA = "0x18A401550")]
		public void SetCanvasSortingOrder(short order, bool activateCanvasGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private OptionData DPDJXZPPEOP;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA401810", Offset = "0xA400210", VA = "0x18A401810", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA4016F0", Offset = "0xA4000F0", VA = "0x18A4016F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA401640", Offset = "0xA400040", VA = "0x18A401640")]
		private void BGIYKFYQPMG(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA401AE0", Offset = "0xA4004E0", VA = "0x18A401AE0")]
		public void SetOptionsWithNoDefault(List<string> values, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA401A00", Offset = "0xA400400", VA = "0x18A401A00")]
		public void SetOptionsWithNoDefault(List<OptionData> options, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA401930", Offset = "0xA400330", VA = "0x18A401930", Slot = "44")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "47")]
		protected override GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA401CF0", Offset = "0xA4006F0", VA = "0x18A401CF0")]
		public Dropdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	public class Hideable : MonoBehaviour, ILayoutIgnorer
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class VQOKIQINBRN : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private OSEXMMYDSBS RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Hideable TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private OSEXMMYDSBS XMCHSAEGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public VQOKIQINBRN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA409A30", Offset = "0xA408430", VA = "0x18A409A30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA4099F0", Offset = "0xA4083F0", VA = "0x18A4099F0", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly JZCSSFMESCO<object> NWSTQHCBUGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool SNBNRIXTHXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Vector3? GMDMXPIZMUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool? ADJGXXSFBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool? XNPWTVWAXFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool IIEXWNGYWXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool CXZRCCDPCPY;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ignoreLayout
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA402940", Offset = "0xA401340", VA = "0x18A402940", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool XPKVTSGTBNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA4028F0", Offset = "0xA4012F0", VA = "0x18A4028F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BVXDSWDFHZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD5E450", Offset = "0xD5CE50", VA = "0x180D5E450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA402B20", Offset = "0xA401520", VA = "0x18A402B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OGCVYMMLRWE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA402850", Offset = "0xA401250", VA = "0x18A402850")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA402A80", Offset = "0xA401480", VA = "0x18A402A80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA4022B0", Offset = "0xA400CB0", VA = "0x18A4022B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA4024C0", Offset = "0xA400EC0", VA = "0x18A4024C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA402470", Offset = "0xA400E70", VA = "0x18A402470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA402460", Offset = "0xA400E60", VA = "0x18A402460")]
		public void Hide(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA4027C0", Offset = "0xA4011C0", VA = "0x18A4027C0")]
		public void Show(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA4026D0", Offset = "0xA4010D0", VA = "0x18A4026D0")]
		public void Set(object token, bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA402340", Offset = "0xA400D40", VA = "0x18A402340")]
		public void Clear(bool refresh = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA402550", Offset = "0xA400F50", VA = "0x18A402550")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA4023F0", Offset = "0xA400DF0", VA = "0x18A4023F0")]
		[IteratorStateMachine(typeof(VQOKIQINBRN))]
		private IEnumerator<OSEXMMYDSBS> GKQOBHNKVQU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA4023B0", Offset = "0xA400DB0", VA = "0x18A4023B0", Slot = "5")]
		public virtual void DoHideOrShow(bool shouldHide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA4027D0", Offset = "0xA4011D0", VA = "0x18A4027D0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[DisallowMultipleComponent]
	public class Interactable : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, true, false)]
		private Selectable? selectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly NJGJNQQHDGL YWBYKCYHTVP;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA402D10", Offset = "0xA401710", VA = "0x18A402D10")]
		public void Set(Token token, bool isInteractable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA402C40", Offset = "0xA401640", VA = "0x18A402C40")]
		public void RemoveToken(Token token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA402E10", Offset = "0xA401810", VA = "0x18A402E10")]
		public Interactable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class GAMJROLZGER
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum ThemeOptions
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			Light,
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			Dark
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static QGJARWQTXXT ECZEPMBERVZ;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static QGJARWQTXXT GZKPPIUMAFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA401D40", Offset = "0xA400740", VA = "0x18A401D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static ThemeOptions DPLHVSACGHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA401E60", Offset = "0xA400860", VA = "0x18A401E60")]
			get
			{
				return default(ThemeOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA402070", Offset = "0xA400A70", VA = "0x18A402070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event Action<ThemeOptions> TPPBYTSWTFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA401F90", Offset = "0xA400990", VA = "0x18A401F90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA4021D0", Offset = "0xA400BD0", VA = "0x18A4021D0")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KASYIKOSIOP : UTEXWCNDPBE, HSRMFVQUPDM, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, GWEYJEXMCDQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		JOLHGBMRDLK GTNEJRLJQRV
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PGLTTIWTYKI Clear();

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SpawnLoadingPlaceholders(GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PGLTTIWTYKI Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PGLTTIWTYKI Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject defaultPrefab, Func<int, GameObject> getPrefabForIndexEvent);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SmoothScrollTo(int index, float scrollDuration);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum GradientType : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			LeftToRight = 0,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			RightToLeft = 1,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			TopToBottom = 2,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			BottomToTop = 3,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			CustomDirection = 4,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			RadialOut = 10,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			RadialIn = 11,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			VignetteOut = 20,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			VignetteIn = 21,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			Disabled = 255
		}

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int BLLITBIZWVO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Dictionary<GradientType, string> SRWAAIKQPUW;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int TYYSGVMMLIB = 32;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int TYQVYMAYCIT;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int DWMXAJCRERT;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int IVSEKBLNEJA;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int SUGCSPUTWWY;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int JYVDRYSXEBZ;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int FPRSAKQVLON;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly int SMOCAOHNHZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool YTCJJQFKOWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool XSMMIMPCXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Color[] FZWEOBZABEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private GradientType type;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly GradientType[] IOYJPIKHCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ConditionalField("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly GradientType[] SRJSXCSVUUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[ConditionalField("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[ConditionalField("type", GradientType.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[ConditionalField("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic BIGJTCGWBCC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool PLXGDQIAOMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient OPCIXIKAQPE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA4058D0", Offset = "0xA4042D0", VA = "0x18A4058D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public GradientType AFHKRTOWHTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xE211E0", Offset = "0xE1FBE0", VA = "0x180E211E0")]
			get
			{
				return default(GradientType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA405A40", Offset = "0xA404440", VA = "0x18A405A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool ZENDSGIXDRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA404300", Offset = "0xA402D00", VA = "0x18A404300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 RRXYUOOQTQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA405840", Offset = "0xA404240", VA = "0x18A405840")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA405880", Offset = "0xA404280", VA = "0x18A405880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool KXTDAPOESNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA404290", Offset = "0xA402C90", VA = "0x18A404290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 OHFXQNDZZMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA405860", Offset = "0xA404260", VA = "0x18A405860")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA4059F0", Offset = "0xA4043F0", VA = "0x18A4059F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LTZPQSRNLSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xE27890", Offset = "0xE26290", VA = "0x180E27890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2413420", Offset = "0x2411E20", VA = "0x182413420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 LYPUPPBIFTY
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA404720", Offset = "0xA403120", VA = "0x18A404720")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 KTBOXLQCAIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA405320", Offset = "0xA403D20", VA = "0x18A405320")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float MHVNLJTIUWR
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD2BF40", Offset = "0xD2A940", VA = "0x180D2BF40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA405A50", Offset = "0xA404450", VA = "0x18A405A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA405180", Offset = "0xA403B80", VA = "0x18A405180", Slot = "12")]
		protected override void VOKLJQXSBBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA404370", Offset = "0xA402D70", VA = "0x18A404370")]
		private void HVDWCMFBMXG(Color[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA404770", Offset = "0xA403170", VA = "0x18A404770", Slot = "13")]
		protected override void SPFFVTZPOSO(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA404500", Offset = "0xA402F00", VA = "0x18A404500", Slot = "14")]
		protected override void KEFLJERNWIP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA405790", Offset = "0xA404190", VA = "0x18A405790")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly RRUIEventQueue MJDLEHEIKBL;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static Sprite XTSTLDDYQFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material XJYQMWDIICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Material CKAJBYUGHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool SCEFHQDXHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool SNBNRIXTHXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool WPBEQXBNCUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool GVTBTGUSTDM;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic BIGJTCGWBCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader SSVVMIVTIMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool PLXGDQIAOMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool NVSCDHCTIVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform PRQWWBMRJGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA407A20", Offset = "0xA406420", VA = "0x18A407A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect VAFJZLWLQXK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA407130", Offset = "0xA405B30", VA = "0x18A407130")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite OHEHJKUFINI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA407AD0", Offset = "0xA4064D0", VA = "0x18A407AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA406B60", Offset = "0xA405560", VA = "0x18A406B60", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA4073D0", Offset = "0xA405DD0", VA = "0x18A4073D0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA4076C0", Offset = "0xA4060C0", VA = "0x18A4076C0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA407570", Offset = "0xA405F70", VA = "0x18A407570", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA407250", Offset = "0xA405C50", VA = "0x18A407250")]
		private void OKACDWUHPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA406A00", Offset = "0xA405400", VA = "0x18A406A00")]
		private void ASDWXCCGIBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA406E80", Offset = "0xA405880", VA = "0x18A406E80")]
		private void FEVIHDZPUIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA407A80", Offset = "0xA406480", VA = "0x18A407A80")]
		private void TBSJVUHWTDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA406EB0", Offset = "0xA4058B0", VA = "0x18A406EB0")]
		protected void HXBQOFAGAVW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA406D40", Offset = "0xA405740", VA = "0x18A406D40")]
		private void DJURXVFCMDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "12")]
		protected virtual void VOKLJQXSBBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "13")]
		protected virtual void SPFFVTZPOSO(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "14")]
		protected virtual void KEFLJERNWIP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA4076D0", Offset = "0xA4060D0", VA = "0x18A4076D0")]
		private void RQKFBFGKDSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		protected UIMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Rings", 15)]
	public class UIRings : UIUberMaterialOverride
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct RingLayer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[SerializeField]
			[Range(0f, 2f)]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int KODYFYSAQAV;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int XGJDHEZVUGV;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int ZDBYJKTCIZO;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly int IAGUTPSZABV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Color[] FZWEOBZABEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private float[] QXSDWATIEZW;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic BIGJTCGWBCC
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool NVSCDHCTIVL
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> AMCMJWJCEZM
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 RRXYUOOQTQX
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xF2EB00", Offset = "0xF2D500", VA = "0x180F2EB00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA408730", Offset = "0xA407130", VA = "0x18A408730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA408230", Offset = "0xA406C30", VA = "0x18A408230")]
		public void SetRingLayers(IReadOnlyList<RingLayer> newLayers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA407FF0", Offset = "0xA4069F0", VA = "0x18A407FF0")]
		public bool SetRingLayerColor(int layer, Color color)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA408140", Offset = "0xA406B40", VA = "0x18A408140")]
		public bool SetRingLayerSize(int layer, float size)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA4082B0", Offset = "0xA406CB0", VA = "0x18A4082B0", Slot = "12")]
		protected override void VOKLJQXSBBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA407EA0", Offset = "0xA4068A0", VA = "0x18A407EA0", Slot = "13")]
		protected override void SPFFVTZPOSO(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA407E50", Offset = "0xA406850", VA = "0x18A407E50", Slot = "14")]
		protected override void KEFLJERNWIP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA4084C0", Offset = "0xA406EC0", VA = "0x18A4084C0")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Tiler", 15)]
	public class UITiler : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum AnimationType
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int FIWVTLYWKLY;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int HZDDLHOMSFF;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int GUFSQLYYDNL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int RYDRQWHNZRH;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int MXVBYPYQRWO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int FHPFJCPLKBZ;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int HXLTQBTDNGX;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int BFZBLCXTLBK;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int DHRLDELFYET;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int IWYISZRKBUZ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int CFHJSQHBVNY;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int TMBVZLAKTCW;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int VGXKUGZZBPD;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int HHKOZHYFFSI;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int HHJDENVJNGD;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int BJLWOTICFLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[Tooltip("The offset applied to each alternating row or column.")]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private AnimationType animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[ConditionalField("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		[ConditionalField("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic BIGJTCGWBCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool NVSCDHCTIVL
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite BVEOTMFXEKT
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA409550", Offset = "0xA407F50", VA = "0x18A409550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA409780", Offset = "0xA408180", VA = "0x18A409780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color ZCGRMLRBIKS
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xEF3340", Offset = "0xEF1D40", VA = "0x180EF3340")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA409810", Offset = "0xA408210", VA = "0x18A409810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color SCEMVEIMGVP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xEF3320", Offset = "0xEF1D20", VA = "0x180EF3320")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA409650", Offset = "0xA408050", VA = "0x18A409650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float FNBXZDMZCNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xE27870", Offset = "0xE26270", VA = "0x180E27870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA409710", Offset = "0xA408110", VA = "0x18A409710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 KVPNSKAFLLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x12EC710", Offset = "0x12EB110", VA = "0x1812EC710")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA409730", Offset = "0xA408130", VA = "0x18A409730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float UGICJWZXTTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB80", Offset = "0xD2A580", VA = "0x180D2BB80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA4096D0", Offset = "0xA4080D0", VA = "0x18A4096D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 KLNTUOVXDGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x184CD10", Offset = "0x184B710", VA = "0x18184CD10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA409890", Offset = "0xA408290", VA = "0x18A409890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float SLFZAITPNPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x12D6F50", Offset = "0x12D5950", VA = "0x1812D6F50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA409610", Offset = "0xA408010", VA = "0x18A409610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 IMVDKSCSISJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA408EA0", Offset = "0xA4078A0", VA = "0x18A408EA0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AnimationType YVLJPZKEHPL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x18BB350", Offset = "0x18B9D50", VA = "0x1818BB350")]
			get
			{
				return default(AnimationType);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA409630", Offset = "0xA408030", VA = "0x18A409630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float ERIIOCEZWLT
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x12E7110", Offset = "0x12E5B10", VA = "0x1812E7110")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA4096F0", Offset = "0xA4080F0", VA = "0x18A4096F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float EZVSECVUUQY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xF58180", Offset = "0xF56B80", VA = "0x180F58180")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA4095F0", Offset = "0xA407FF0", VA = "0x18A4095F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA4087D0", Offset = "0xA4071D0", VA = "0x18A4087D0", Slot = "13")]
		protected override void SPFFVTZPOSO(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA408F30", Offset = "0xA407930", VA = "0x18A408F30")]
		private void UHQZZRQNPGI(Sprite a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA408780", Offset = "0xA407180", VA = "0x18A408780", Slot = "14")]
		protected override void KEFLJERNWIP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA4094C0", Offset = "0xA407EC0", VA = "0x18A4094C0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static Shader AAXOVJETCLQ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader SSVVMIVTIMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA409930", Offset = "0xA408330", VA = "0x18A409930", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA4098E0", Offset = "0xA4082E0", VA = "0x18A4098E0")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class RectTransformHideableAdapter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private SerializableRectTransform hiddenRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private SerializableRectTransform XVYGTWFOLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool UJIXIMTLAJF;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA403A10", Offset = "0xA402410", VA = "0x18A403A10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA403C10", Offset = "0xA402610", VA = "0x18A403C10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA403B90", Offset = "0xA402590", VA = "0x18A403B90")]
		private void INLEXVDQAFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA403D10", Offset = "0xA402710", VA = "0x18A403D10")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
namespace RRUI.Data
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class RRUIEventQueue
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		private struct QueuedOperation : IEquatable<QueuedOperation>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private readonly Component context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private readonly Action refreshOperation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private readonly int hashCode;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public Component Context
			{
				[Cpp2IlInjected.Token(Token = "0x60000B7")]
				[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA403020", Offset = "0xA401A20", VA = "0x18A403020")]
			public QueuedOperation(Component context, Action refreshOperation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA402FA0", Offset = "0xA4019A0", VA = "0x18A402FA0")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA402F00", Offset = "0xA401900", VA = "0x18A402F00", Slot = "4")]
			public bool Equals(QueuedOperation other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA402F10", Offset = "0xA401910", VA = "0x18A402F10", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class <DelayedProcessQueueRoutine>d__17 : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private OSEXMMYDSBS <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public RRUIEventQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private OSEXMMYDSBS System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public <DelayedProcessQueueRoutine>d__17(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA403DE0", Offset = "0xA4027E0", VA = "0x18A403DE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA404180", Offset = "0xA402B80", VA = "0x18A404180", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ScheduleQueueType queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly int maximumPerFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly int framesSkippedBetweenUpdates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly Func<Component, float> priorityFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly Dictionary<Component, QueuedOperation> operationMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly LinkedList<QueuedOperation> operationQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly List<QueuedOperation> sortingList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private OVUANEJXOET scheduleRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private LLJMTCLFWDA _sessionManager;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private LLJMTCLFWDA sessionManager
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA403980", Offset = "0xA402380", VA = "0x18A403980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA403820", Offset = "0xA402220", VA = "0x18A403820")]
		public RRUIEventQueue(ScheduleQueueType queueType, int maximumPerFrame = -1, int framesSkippedBetweenUpdates = -1, [Optional] Func<Component, float> priorityFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA4032F0", Offset = "0xA401CF0", VA = "0x18A4032F0")]
		public void QueueOperation(Component context, Action operation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA403090", Offset = "0xA401A90", VA = "0x18A403090")]
		public void CancelQueuedOperation(Component context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA403290", Offset = "0xA401C90", VA = "0x18A403290")]
		public bool HasQueuedOperation(Component component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA403570", Offset = "0xA401F70", VA = "0x18A403570")]
		private void ScheduleUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA403220", Offset = "0xA401C20", VA = "0x18A403220")]
		[IteratorStateMachine(typeof(<DelayedProcessQueueRoutine>d__17))]
		private IEnumerator<OSEXMMYDSBS> DelayedProcessQueueRoutine()
		{
			return null;
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
