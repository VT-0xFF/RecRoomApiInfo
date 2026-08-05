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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xA432840", Offset = "0xA431840", VA = "0x18A432840")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
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
				[Cpp2IlInjected.Address(RVA = "0xA4366C0", Offset = "0xA4356C0", VA = "0x18A4366C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0xA436720", Offset = "0xA435720", VA = "0x18A436720")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0xA436680", Offset = "0xA435680", VA = "0x18A436680")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA4362E0", Offset = "0xA4352E0", VA = "0x18A4362E0")]
			public void TIPXZZLIFXG(PointerEventData a, RectTransform b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA4363F0", Offset = "0xA4353F0", VA = "0x18A4363F0")]
			public void ZSMFDIXOYOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA436210", Offset = "0xA435210", VA = "0x18A436210")]
			public void QFAUMSJIZSX(PointerEventData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA4361C0", Offset = "0xA4351C0", VA = "0x18A4361C0")]
			public void EOESBRFTODB(float a, RectTransform b, Vector3 c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		public readonly DRWWZAXJWQZ<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly DRWWZAXJWQZ<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly DRWWZAXJWQZ<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly DRWWZAXJWQZ<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly DRWWZAXJWQZ<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly YZDETVQVLVA PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly UIHandleEventData PKWVHUQXKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool ANDHRKZFHSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private bool SXLHHRTMNGM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool RNFLFBTAKTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD1C050", Offset = "0xD1B050", VA = "0x180D1C050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA435980", Offset = "0xA434980", VA = "0x18A435980")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool YKJWXSYTKDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xE01CE0", Offset = "0xE00CE0", VA = "0x180E01CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA435FB0", Offset = "0xA434FB0", VA = "0x18A435FB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA435F30", Offset = "0xA434F30", VA = "0x18A435F30")]
		private bool PVXYAJWHILS(PointerEventData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA435E10", Offset = "0xA434E10", VA = "0x18A435E10", Slot = "5")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA435ED0", Offset = "0xA434ED0", VA = "0x18A435ED0", Slot = "11")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA435C70", Offset = "0xA434C70", VA = "0x18A435C70", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA4359B0", Offset = "0xA4349B0", VA = "0x18A4359B0", Slot = "7")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA435AC0", Offset = "0xA434AC0", VA = "0x18A435AC0", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA435BA0", Offset = "0xA434BA0", VA = "0x18A435BA0", Slot = "8")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA435E70", Offset = "0xA434E70", VA = "0x18A435E70", Slot = "9")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA435EA0", Offset = "0xA434EA0", VA = "0x18A435EA0", Slot = "10")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA435A80", Offset = "0xA434A80", VA = "0x18A435A80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA435FE0", Offset = "0xA434FE0", VA = "0x18A435FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA431490", Offset = "0xA430490", VA = "0x18A431490")]
		public void SetCanvasSortingOrder(short order, bool activateCanvasGroup)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private OptionData MWVFSOOMJZH;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA431750", Offset = "0xA430750", VA = "0x18A431750", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA431630", Offset = "0xA430630", VA = "0x18A431630", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA431580", Offset = "0xA430580", VA = "0x18A431580")]
		private void CKKOUCSNTFC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA431A20", Offset = "0xA430A20", VA = "0x18A431A20")]
		public void SetOptionsWithNoDefault(List<string> values, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA431940", Offset = "0xA430940", VA = "0x18A431940")]
		public void SetOptionsWithNoDefault(List<OptionData> options, [Optional] string placeholder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA431870", Offset = "0xA430870", VA = "0x18A431870", Slot = "44")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "47")]
		protected override GameObject CreateBlocker(Canvas rootCanvas)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA431C30", Offset = "0xA430C30", VA = "0x18A431C30")]
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
		private sealed class OODVJHJPNHP : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Hideable DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public OODVJHJPNHP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA432900", Offset = "0xA431900", VA = "0x18A432900", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA4328C0", Offset = "0xA4318C0", VA = "0x18A4328C0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
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
		private readonly LOBXPPNZCCQ<object> IJRZWEHAWYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool UCZAYLYSWBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Vector3? CERZLUKCNQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool? TSBSHKRCZWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool? FTVPGTUBSIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool GGNJGKHTHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool LGQPNLXSHXO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ignoreLayout
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA432300", Offset = "0xA431300", VA = "0x18A432300", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool UNCLICKNVYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA4322B0", Offset = "0xA4312B0", VA = "0x18A4322B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OQFYNWBZCBG
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD57800", Offset = "0xD56800", VA = "0x180D57800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA4324E0", Offset = "0xA4314E0", VA = "0x18A4324E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EDHVNHOTMIS
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA432210", Offset = "0xA431210", VA = "0x18A432210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA432440", Offset = "0xA431440", VA = "0x18A432440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA431C80", Offset = "0xA430C80", VA = "0x18A431C80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA431E20", Offset = "0xA430E20", VA = "0x18A431E20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA431DD0", Offset = "0xA430DD0", VA = "0x18A431DD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA431DC0", Offset = "0xA430DC0", VA = "0x18A431DC0")]
		public void Hide(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA432180", Offset = "0xA431180", VA = "0x18A432180")]
		public void Show(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA432090", Offset = "0xA431090", VA = "0x18A432090")]
		public void Set(object token, bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA431D10", Offset = "0xA430D10", VA = "0x18A431D10")]
		public void Clear(bool refresh = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA431EB0", Offset = "0xA430EB0", VA = "0x18A431EB0")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA432020", Offset = "0xA431020", VA = "0x18A432020")]
		[IteratorStateMachine(typeof(OODVJHJPNHP))]
		private IEnumerator<NVIJVYVFXPY> SIWBFIVPEZM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA431D80", Offset = "0xA430D80", VA = "0x18A431D80", Slot = "5")]
		public virtual void DoHideOrShow(bool shouldHide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA432190", Offset = "0xA431190", VA = "0x18A432190")]
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
		private readonly QZWQEOPVQWN ZXEWOKMRPVF;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA4326D0", Offset = "0xA4316D0", VA = "0x18A4326D0")]
		public void Set(Token token, bool isInteractable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA432600", Offset = "0xA431600", VA = "0x18A432600")]
		public void RemoveToken(Token token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA4327D0", Offset = "0xA4317D0", VA = "0x18A4327D0")]
		public Interactable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class WEZQGZFLSOH
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
		private static LLJFKJJXSMP ABXRXSBMYLX;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static LLJFKJJXSMP WTVTJAYNZRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA439C70", Offset = "0xA438C70", VA = "0x18A439C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static ThemeOptions CPKJHHWBCKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA439B40", Offset = "0xA438B40", VA = "0x18A439B40")]
			get
			{
				return default(ThemeOptions);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA4399E0", Offset = "0xA4389E0", VA = "0x18A4399E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event Action<ThemeOptions> WPFUQOPCFPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA439D90", Offset = "0xA438D90", VA = "0x18A439D90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA439900", Offset = "0xA438900", VA = "0x18A439900")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface TRBOSUBGCLH : SUNWYOKISRC, NXANNCRSEUY, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, TYBKZUSRJMQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		YZDETVQVLVA CFOEFQQNLKB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZSWOFHRQHTQ Clear();

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SpawnLoadingPlaceholders(GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ZSWOFHRQHTQ Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject prefab);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ZSWOFHRQHTQ Spawn<T>(int totalItemCount, IReadOnlyList<T> data, GameObject defaultPrefab, Func<int, GameObject> getPrefabForIndexEvent);

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
		private static readonly int GWNXUFNEJVM;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Dictionary<GradientType, string> AJTNVZFBSUQ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int TMPACIEKVBJ = 32;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int RHFTZZLWXUV;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int KBCQDIXIARB;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int CLXHABQQFEQ;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int GBANUBWWLSO;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int DFGTHFMTUWF;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int DDDCQHPQVJF;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly int ASPZMSTFSVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool WNMIJKLMXBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool TMJFCRSSZLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Color[] PDSDRAFRZIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private GradientType type;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly GradientType[] ALKGAEXKNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[ConditionalField("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly GradientType[] FLGPETJLNRR;

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
		public override Graphic JBDQETXHLXS
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool PTWFCLGOZUE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient XBDLINHQWEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA4357E0", Offset = "0xA4347E0", VA = "0x18A4357E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public GradientType XYUHIEMAMOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xE01CB0", Offset = "0xE00CB0", VA = "0x180E01CB0")]
			get
			{
				return default(GradientType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA435950", Offset = "0xA434950", VA = "0x18A435950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool BTZEIAGNQOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA434550", Offset = "0xA433550", VA = "0x18A434550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 WUCBXIRUSRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA435750", Offset = "0xA434750", VA = "0x18A435750")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA435790", Offset = "0xA434790", VA = "0x18A435790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool TJSABERNAIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA434760", Offset = "0xA433760", VA = "0x18A434760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 JBTKORXHGDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA435770", Offset = "0xA434770", VA = "0x18A435770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA435900", Offset = "0xA434900", VA = "0x18A435900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float HLSULOZOKTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xE27CA0", Offset = "0xE26CA0", VA = "0x180E27CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x23F1960", Offset = "0x23F0960", VA = "0x1823F1960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 XJPJTLNRPDS
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA434840", Offset = "0xA433840", VA = "0x18A434840")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 COOHGQKPILI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA4347D0", Offset = "0xA4337D0", VA = "0x18A4347D0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float ABWXIOCRKTF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD25180", Offset = "0xD24180", VA = "0x180D25180")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA435960", Offset = "0xA434960", VA = "0x18A435960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA4345C0", Offset = "0xA4335C0", VA = "0x18A4345C0", Slot = "12")]
		protected override void HQMVEMJVPZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA4343C0", Offset = "0xA4333C0", VA = "0x18A4343C0")]
		private void FMSVCSWGLVY(Color[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA434890", Offset = "0xA433890", VA = "0x18A434890", Slot = "13")]
		protected override void YWAMDJGCPYU(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4341A0", Offset = "0xA4331A0", VA = "0x18A4341A0", Slot = "14")]
		protected override void FFZUYZRSUBP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA4356A0", Offset = "0xA4346A0", VA = "0x18A4356A0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly RRUIEventQueue GORVYIEATUT;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static Sprite BNVFVLHTOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material UCYMTECGZAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Material NGRZVMGTAOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool WLUCZMHFWMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool UCZAYLYSWBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool ONXKCWVZTRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool MRXSFDCIQFO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic JBDQETXHLXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader SUCOUWSXPGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool PTWFCLGOZUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool XZQMUSYOQCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform KGWSUFTPYUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA437B80", Offset = "0xA436B80", VA = "0x18A437B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect FNAJVUAFTJY
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA436E40", Offset = "0xA435E40", VA = "0x18A436E40")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite LHBMOLIDSAU
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA437120", Offset = "0xA436120", VA = "0x18A437120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA436C60", Offset = "0xA435C60", VA = "0x18A436C60", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA437700", Offset = "0xA436700", VA = "0x18A437700", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA4379F0", Offset = "0xA4369F0", VA = "0x18A4379F0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA4378A0", Offset = "0xA4368A0", VA = "0x18A4378A0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA437A00", Offset = "0xA436A00", VA = "0x18A437A00")]
		private void UWSRBNOWCLV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA437320", Offset = "0xA436320", VA = "0x18A437320")]
		private void KIMCGBQZIJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA4370F0", Offset = "0xA4360F0", VA = "0x18A4370F0")]
		private void ERTGHCMKXZW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA4370A0", Offset = "0xA4360A0", VA = "0x18A4370A0")]
		private void CVHADPUZPFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA437480", Offset = "0xA436480", VA = "0x18A437480")]
		protected void LKUDONQIYOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA436F60", Offset = "0xA435F60", VA = "0x18A436F60")]
		private void COPWQSRMCWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "12")]
		protected virtual void HQMVEMJVPZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "13")]
		protected virtual void YWAMDJGCPYU(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "14")]
		protected virtual void FFZUYZRSUBP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA436910", Offset = "0xA435910", VA = "0x18A436910")]
		private void AIYRNDITJGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
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
		private static readonly int ITITSINUQGL;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int XMZLKCXZKWP;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int LXBRBYKBRUO;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static readonly int GPKSVCIFSCB;

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
		private Color[] PDSDRAFRZIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private float[] PDSEYMKKBIS;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic JBDQETXHLXS
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool XZQMUSYOQCX
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> EZDGEMYTXHC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 WUCBXIRUSRH
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xF2C2F0", Offset = "0xF2B2F0", VA = "0x180F2C2F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA438640", Offset = "0xA437640", VA = "0x18A438640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA438130", Offset = "0xA437130", VA = "0x18A438130")]
		public void SetRingLayers(IReadOnlyList<RingLayer> newLayers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA437EF0", Offset = "0xA436EF0", VA = "0x18A437EF0")]
		public bool SetRingLayerColor(int layer, Color color)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA438040", Offset = "0xA437040", VA = "0x18A438040")]
		public bool SetRingLayerSize(int layer, float size)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA437DB0", Offset = "0xA436DB0", VA = "0x18A437DB0", Slot = "12")]
		protected override void HQMVEMJVPZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA4381B0", Offset = "0xA4371B0", VA = "0x18A4381B0", Slot = "13")]
		protected override void YWAMDJGCPYU(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA437D60", Offset = "0xA436D60", VA = "0x18A437D60", Slot = "14")]
		protected override void FFZUYZRSUBP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA4383D0", Offset = "0xA4373D0", VA = "0x18A4383D0")]
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
		private static readonly int ADKYMGJYWAY;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int MQSEEHDIXNP;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int XFDUUVJMJUP;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int EGZGMMNVBVJ;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int OEJDKLHRBAU;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int UDFKUJXHOWR;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int KRWKMQOCRQR;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int GAOESPIPLXA;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int PBWCVTYTMOJ;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int YXDIUUKBIRV;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int IRLRXYMLHSM;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int DIJSPTGFSXO;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int TUJDRSZXCFB;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int LTYAHACYCTQ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int PNRLCXYGCQN;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static readonly int OXLQDPGKWAE;

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
		public override Graphic JBDQETXHLXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool XZQMUSYOQCX
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite CDJZDTWHXOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xA439460", Offset = "0xA438460", VA = "0x18A439460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA439690", Offset = "0xA438690", VA = "0x18A439690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color GUVUJOOGVYE
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xEEF540", Offset = "0xEEE540", VA = "0x180EEF540")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA439720", Offset = "0xA438720", VA = "0x18A439720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color XZPBYVIVNJF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xEEF510", Offset = "0xEEE510", VA = "0x180EEF510")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA439560", Offset = "0xA438560", VA = "0x18A439560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float MHTXRTKMPZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xE27C90", Offset = "0xE26C90", VA = "0x180E27C90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA439620", Offset = "0xA438620", VA = "0x18A439620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 QOBWSJTQPWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x12D4640", Offset = "0x12D3640", VA = "0x1812D4640")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA439640", Offset = "0xA438640", VA = "0x18A439640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float RFBIZEQGAWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xD24DC0", Offset = "0xD23DC0", VA = "0x180D24DC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA4395E0", Offset = "0xA4385E0", VA = "0x18A4395E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 PINXZFPKDDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x18366D0", Offset = "0x18356D0", VA = "0x1818366D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA4397A0", Offset = "0xA4387A0", VA = "0x18A4397A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float JUKWLBIAJOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x12CED90", Offset = "0x12CDD90", VA = "0x1812CED90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA439520", Offset = "0xA438520", VA = "0x18A439520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 LJZRFZHEGET
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA438690", Offset = "0xA437690", VA = "0x18A438690")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public AnimationType YOZFGEANODF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x18A5F70", Offset = "0x18A4F70", VA = "0x1818A5F70")]
			get
			{
				return default(AnimationType);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA439540", Offset = "0xA438540", VA = "0x18A439540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float DIRXGROWPVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x12CB360", Offset = "0x12CA360", VA = "0x1812CB360")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA439600", Offset = "0xA438600", VA = "0x18A439600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float JFZWMGPUDDU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xF3D920", Offset = "0xF3C920", VA = "0x180F3D920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA439500", Offset = "0xA438500", VA = "0x18A439500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA438A20", Offset = "0xA437A20", VA = "0x18A438A20", Slot = "13")]
		protected override void YWAMDJGCPYU(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA438770", Offset = "0xA437770", VA = "0x18A438770")]
		private void RRLPPZBZOZI(Sprite a, [Out] Vector2 b, [Out] Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA438720", Offset = "0xA437720", VA = "0x18A438720", Slot = "14")]
		protected override void FFZUYZRSUBP(Material a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA4393D0", Offset = "0xA4383D0", VA = "0x18A4393D0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static Shader CFNYQRDNBOY;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader SUCOUWSXPGR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA439840", Offset = "0xA438840", VA = "0x18A439840", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA4397F0", Offset = "0xA4387F0", VA = "0x18A4397F0")]
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
		private SerializableRectTransform RXFNEBBVVFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private bool RGGNSFSYOXD;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA433920", Offset = "0xA432920", VA = "0x18A433920")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA433B20", Offset = "0xA432B20", VA = "0x18A433B20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA433AA0", Offset = "0xA432AA0", VA = "0x18A433AA0")]
		private void GIGZJESCJUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA433C20", Offset = "0xA432C20", VA = "0x18A433C20")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
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
				[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA432F30", Offset = "0xA431F30", VA = "0x18A432F30")]
			public QueuedOperation(Component context, Action refreshOperation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA432EB0", Offset = "0xA431EB0", VA = "0x18A432EB0")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA432E10", Offset = "0xA431E10", VA = "0x18A432E10", Slot = "4")]
			public bool Equals(QueuedOperation other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA432E20", Offset = "0xA431E20", VA = "0x18A432E20", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xD09110", Offset = "0xD08110", VA = "0x180D09110", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class <DelayedProcessQueueRoutine>d__17 : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private NVIJVYVFXPY <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public RRUIEventQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private NVIJVYVFXPY System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public <DelayedProcessQueueRoutine>d__17(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA433CF0", Offset = "0xA432CF0", VA = "0x18A433CF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA434090", Offset = "0xA433090", VA = "0x18A434090", Slot = "8")]
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
		private YDHSMJLFZLP scheduleRoutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private QYSQQYIIHGE _sessionManager;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private QYSQQYIIHGE sessionManager
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA433890", Offset = "0xA432890", VA = "0x18A433890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA433730", Offset = "0xA432730", VA = "0x18A433730")]
		public RRUIEventQueue(ScheduleQueueType queueType, int maximumPerFrame = -1, int framesSkippedBetweenUpdates = -1, [Optional] Func<Component, float> priorityFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA433200", Offset = "0xA432200", VA = "0x18A433200")]
		public void QueueOperation(Component context, Action operation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA432FA0", Offset = "0xA431FA0", VA = "0x18A432FA0")]
		public void CancelQueuedOperation(Component context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA4331A0", Offset = "0xA4321A0", VA = "0x18A4331A0")]
		public bool HasQueuedOperation(Component component)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA433480", Offset = "0xA432480", VA = "0x18A433480")]
		private void ScheduleUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA433130", Offset = "0xA432130", VA = "0x18A433130")]
		[IteratorStateMachine(typeof(<DelayedProcessQueueRoutine>d__17))]
		private IEnumerator<NVIJVYVFXPY> DelayedProcessQueueRoutine()
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
