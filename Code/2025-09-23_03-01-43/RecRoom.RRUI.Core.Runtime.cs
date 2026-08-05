using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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
				[Cpp2IlInjected.Address(RVA = "0x8FA07C0", Offset = "0x8F9EDC0", VA = "0x188FA07C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8FA0820", Offset = "0x8F9EE20", VA = "0x188FA0820")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8FA0780", Offset = "0x8F9ED80", VA = "0x188FA0780")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8FA0630", Offset = "0x8F9EC30", VA = "0x188FA0630")]
			public void KPOHJEPCEGH(PointerEventData PBNHOEHCMFG, RectTransform BOBHFKOIBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8FA03A0", Offset = "0x8F9E9A0", VA = "0x188FA03A0")]
			public void JGGBKIOCBPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8FA02C0", Offset = "0x8F9E8C0", VA = "0x188FA02C0")]
			public void GKALBJODDBB(PointerEventData PBNHOEHCMFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8FA0730", Offset = "0x8F9ED30", VA = "0x188FA0730")]
			public void LFPLCDPPGMK(float KLHDGOEFPFJ, RectTransform BOBHFKOIBKI, Vector3 GDEKJEBPHAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly PKBDHHCMFJK<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly PKBDHHCMFJK<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly PKBDHHCMFJK<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly PKBDHHCMFJK<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly PKBDHHCMFJK<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HLLOFHFLNHG PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData DLHAMBEJGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool ENKHIHNBCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool DCIPAELAFHE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MMHFDEDFEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xAA5550", Offset = "0xAA3B50", VA = "0x180AA5550")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8F9FAD0", Offset = "0x8F9E0D0", VA = "0x188F9FAD0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BLOIJNAHCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA5630", Offset = "0xAA3C30", VA = "0x180AA5630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8F9FB00", Offset = "0x8F9E100", VA = "0x188F9FB00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FA50", Offset = "0x8F9E050", VA = "0x188F9FA50")]
		private bool DGAMKOCANNH(PointerEventData CBIMJBOHKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FF80", Offset = "0x8F9E580", VA = "0x188F9FF80", Slot = "5")]
		public void OnPointerDown(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0040", Offset = "0x8F9E640", VA = "0x188FA0040", Slot = "11")]
		public void OnPointerUp(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FDF0", Offset = "0x8F9E3F0", VA = "0x188F9FDF0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FB30", Offset = "0x8F9E130", VA = "0x188F9FB30", Slot = "7")]
		public void OnBeginDrag(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FC40", Offset = "0x8F9E240", VA = "0x188F9FC40", Slot = "4")]
		public void OnDrag(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FD20", Offset = "0x8F9E320", VA = "0x188F9FD20", Slot = "8")]
		public void OnEndDrag(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FFE0", Offset = "0x8F9E5E0", VA = "0x188F9FFE0", Slot = "9")]
		public void OnPointerEnter(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0010", Offset = "0x8F9E610", VA = "0x188FA0010", Slot = "10")]
		public void OnPointerExit(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FC00", Offset = "0x8F9E200", VA = "0x188F9FC00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA00A0", Offset = "0x8F9E6A0", VA = "0x188FA00A0")]
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
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BF60", Offset = "0x8F9A560", VA = "0x188F9BF60")]
		public void SetCanvasSortingOrder(short DPNBGBIGDNP, bool MMMCDFMBOOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData LHNEJLGKEFM;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C220", Offset = "0x8F9A820", VA = "0x188F9C220", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C100", Offset = "0x8F9A700", VA = "0x188F9C100", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C050", Offset = "0x8F9A650", VA = "0x188F9C050")]
		private void DHHMPBKGAEO(GameObject JEMAEEFPMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C500", Offset = "0x8F9AB00", VA = "0x188F9C500")]
		public void SetOptionsWithNoDefault(List<string> LGMBOCEBOMM, [Optional] string HMBIJGJBHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C410", Offset = "0x8F9AA10", VA = "0x188F9C410")]
		public void SetOptionsWithNoDefault(List<OptionData> PLMLGIGGGNL, [Optional] string HMBIJGJBHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C340", Offset = "0x8F9A940", VA = "0x188F9C340", Slot = "44")]
		public override void OnPointerClick(PointerEventData CBIMJBOHKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "47")]
		protected override GameObject CreateBlocker(Canvas JAIFNOFIODE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C730", Offset = "0x8F9AD30", VA = "0x188F9C730")]
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
		private sealed class LDPLAPHOLND : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private KAIBAKBEOHB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public LDPLAPHOLND(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D110", Offset = "0x8F9B710", VA = "0x188F9D110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D620", Offset = "0x8F9BC20", VA = "0x188F9D620", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[DECECLMOCEO(GJFENOMGFMJ.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly EPJEHNABAGB<object> NOMJPMPMIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool CKAICOFEODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? MMJCNPOGOGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? MNFFMKMDKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? IJCIENOOLNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool JFNHGGPDHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool PJFOJKPJALF;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GGAMLOGPICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8F9CE30", Offset = "0x8F9B430", VA = "0x188F9CE30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool BLBCILIDJFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8F9CDE0", Offset = "0x8F9B3E0", VA = "0x188F9CDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EKHODOBMIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAF3190", Offset = "0xAF1790", VA = "0x180AF3190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8F9CFF0", Offset = "0x8F9B5F0", VA = "0x188F9CFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FDGNFMHOHKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8F9CD40", Offset = "0x8F9B340", VA = "0x188F9CD40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8F9CF50", Offset = "0x8F9B550", VA = "0x188F9CF50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C780", Offset = "0x8F9AD80", VA = "0x188F9C780")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9CB20", Offset = "0x8F9B120", VA = "0x188F9CB20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9CAD0", Offset = "0x8F9B0D0", VA = "0x188F9CAD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C8C0", Offset = "0x8F9AEC0", VA = "0x188F9C8C0")]
		public void Hide(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9CCA0", Offset = "0x8F9B2A0", VA = "0x188F9CCA0")]
		public void Show(object INEEADCBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F9CBB0", Offset = "0x8F9B1B0", VA = "0x188F9CBB0")]
		public void Set(object INEEADCBMPK, bool GJIIKLOKJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C810", Offset = "0x8F9AE10", VA = "0x188F9C810")]
		public void Clear(bool PGFAIMJEOCC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C8D0", Offset = "0x8F9AED0", VA = "0x188F9C8D0")]
		private void JKKIBKHAPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8F9CA50", Offset = "0x8F9B050", VA = "0x188F9CA50")]
		[IteratorStateMachine(typeof(LDPLAPHOLND))]
		private IEnumerator<KAIBAKBEOHB> OPJPHKFMFCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C880", Offset = "0x8F9AE80", VA = "0x188F9C880", Slot = "5")]
		public virtual void DoHideOrShow(bool MIJEDDBGGPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8F9CCB0", Offset = "0x8F9B2B0", VA = "0x188F9CCB0")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NPAKDJEBJAK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum APCFGGODHHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static KBKAIDBHKPF DPHCKEHKLHP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static KBKAIDBHKPF IKJAPEJPIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9DB20", Offset = "0x8F9C120", VA = "0x188F9DB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static APCFGGODHHC FCEKIAFMHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9DC20", Offset = "0x8F9C220", VA = "0x188F9DC20")]
		get
		{
			return default(APCFGGODHHC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D8E0", Offset = "0x8F9BEE0", VA = "0x188F9D8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<APCFGGODHHC> LOOIAAPAFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9DA40", Offset = "0x8F9C040", VA = "0x188F9DA40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D800", Offset = "0x8F9BE00", VA = "0x188F9D800")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KIMEDNKLKCN : LALCONNEHLP, PEOINMBHGDK, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, MNOJDINNIFM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HLLOFHFLNHG PNHOJCNHIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKCNIKPNNOM Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject IKHBLDCGHAN);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PKCNIKPNNOM Spawn<T>(int EKOHOIBIPDP, IReadOnlyList<T> CDDIADBJAOB, GameObject IKHBLDCGHAN);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PKCNIKPNNOM Spawn<T>(int EKOHOIBIPDP, IReadOnlyList<T> CDDIADBJAOB, GameObject FPDGAEDKPGN, Func<int, GameObject> AMABGFGONDD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int PMIGBJGNLLP, float KFONAPDFKCD);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum ANAIDBBDDHI : byte
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
			Disabled = byte.MaxValue
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly int DJNBLJNFHFJ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<ANAIDBBDDHI, string> ONHJDKBNIDO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int DPBDEMHAMNL = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int FHBOEABMOPN;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int ONIKDELOFBL;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int NBMHPBNMCNC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int JCOMLAPNLKN;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int BLOBDDHJGGH;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int JMKIFKDJGMA;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int BCCHDDCPIPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool FPBBLGLMBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool GKKMOPEAFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] DKKOOBLCIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private ANAIDBBDDHI type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly ANAIDBBDDHI[] JLCEIOGFECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[IEEHBALBFJL("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly ANAIDBBDDHI[] NGJJFKIOAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[IEEHBALBFJL("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[IEEHBALBFJL("type", ANAIDBBDDHI.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[IEEHBALBFJL("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic AHBLKKNEAHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool GAFPILOIENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient DKCNBFHJEBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA55B0", Offset = "0xAA3BB0", VA = "0x180AA55B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8F9F8A0", Offset = "0x8F9DEA0", VA = "0x188F9F8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ANAIDBBDDHI HIKNDMJOAGH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xB2DC60", Offset = "0xB2C260", VA = "0x180B2DC60")]
			get
			{
				return default(ANAIDBBDDHI);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8F9FA20", Offset = "0x8F9E020", VA = "0x188F9FA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool KHBFEMKHPNO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8F9E220", Offset = "0x8F9C820", VA = "0x188F9E220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 NDCJNONEIGL
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8F9F810", Offset = "0x8F9DE10", VA = "0x188F9F810")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8F9F850", Offset = "0x8F9DE50", VA = "0x188F9F850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool HCMMOCKBBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8F9E420", Offset = "0x8F9CA20", VA = "0x188F9E420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 KHGBNADOONJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8F9F830", Offset = "0x8F9DE30", VA = "0x188F9F830")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8F9F9D0", Offset = "0x8F9DFD0", VA = "0x188F9F9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float MBAJBEEMFDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xE36840", Offset = "0xE34E40", VA = "0x180E36840")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x257CCA0", Offset = "0x257B2A0", VA = "0x18257CCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 AFMMACAKLHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8F9E490", Offset = "0x8F9CA90", VA = "0x188F9E490")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 NKCMFBJLHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8F9F2F0", Offset = "0x8F9D8F0", VA = "0x188F9F2F0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float PGGKFAIBDGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAC2220", Offset = "0xAC0820", VA = "0x180AC2220")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8F9FA30", Offset = "0x8F9E030", VA = "0x188F9FA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F150", Offset = "0x8F9D750", VA = "0x188F9F150", Slot = "12")]
		protected override void NBAJEKEEHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9E290", Offset = "0x8F9C890", VA = "0x188F9E290")]
		private void ANKEOJCCICD(Color[] IDACBLNBNBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9E4E0", Offset = "0x8F9CAE0", VA = "0x188F9E4E0", Slot = "13")]
		protected override void JMKKDIJHNDH(Material PFHPGDKJCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9EF30", Offset = "0x8F9D530", VA = "0x188F9EF30", Slot = "14")]
		protected override void KNPIKLDOCFM(Material PFHPGDKJCCC, bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F760", Offset = "0x8F9DD60", VA = "0x188F9F760")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly CNJGBNDPBJO DIMKNLKABBP;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite FNBAEDHGIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material NFPJMHJMLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material HAILDBLADDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool DDCIMIOFALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool CKAICOFEODJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool DGLKCMHLJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool FOOIBKHGHFB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic AHBLKKNEAHA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader LKMJPCHPPPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool GAFPILOIENJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool HLELIFEMBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform BOBHFKOIBKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8FA1220", Offset = "0x8F9F820", VA = "0x188FA1220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect JDMENLOHPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8FA1740", Offset = "0x8F9FD40", VA = "0x188FA1740")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite MNKLMAHDFIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8FA0B80", Offset = "0x8F9F180", VA = "0x188FA0B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0DC0", Offset = "0x8F9F3C0", VA = "0x188FA0DC0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8FA19F0", Offset = "0x8F9FFF0", VA = "0x188FA19F0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1CF0", Offset = "0x8FA02F0", VA = "0x188FA1CF0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1BA0", Offset = "0x8FA01A0", VA = "0x188FA1BA0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1860", Offset = "0x8F9FE60", VA = "0x188FA1860")]
		private void OPHAIBBIKGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1280", Offset = "0x8F9F880", VA = "0x188FA1280")]
		private void ECCLHMKFHJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0A10", Offset = "0x8F9F010", VA = "0x188FA0A10")]
		private void AKGNPOIBGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0D70", Offset = "0x8F9F370", VA = "0x188FA0D70")]
		private void APDCEBEMBJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0FB0", Offset = "0x8F9F5B0", VA = "0x188FA0FB0")]
		protected void BDNJPBOPGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0A40", Offset = "0x8F9F040", VA = "0x188FA0A40")]
		private void AMPCKEICDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "12")]
		protected virtual void NBAJEKEEHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "13")]
		protected virtual void JMKKDIJHNDH(Material PFHPGDKJCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "14")]
		protected virtual void KNPIKLDOCFM(Material PFHPGDKJCCC, bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8FA13F0", Offset = "0x8F9F9F0", VA = "0x188FA13F0")]
		private void FGGLDLMFBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		protected UIMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[AddComponentMenu("UI/Effects/Rings", 15)]
	[ExecuteAlways]
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
		private static readonly int BNGOMEJOBGJ;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int ILLNHPBDNCH;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int DANPCFOOJGA;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int PGDGONACOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Color[] DKKOOBLCIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] GNDJCMAPEDL;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic AHBLKKNEAHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool HLELIFEMBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> FMCDOJFJHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 NDCJNONEIGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF283A0", Offset = "0xF269A0", VA = "0x180F283A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8FA27C0", Offset = "0x8FA0DC0", VA = "0x188FA27C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2400", Offset = "0x8FA0A00", VA = "0x188FA2400")]
		public void SetRingLayers(IReadOnlyList<RingLayer> JCBHOONMPGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA21C0", Offset = "0x8FA07C0", VA = "0x188FA21C0")]
		public bool SetRingLayerColor(int MBOGBFPKKHM, Color FPHNLEHIJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2310", Offset = "0x8FA0910", VA = "0x188FA2310")]
		public bool SetRingLayerSize(int MBOGBFPKKHM, float KCJLCGFEBMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2080", Offset = "0x8FA0680", VA = "0x188FA2080", Slot = "12")]
		protected override void NBAJEKEEHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1EB0", Offset = "0x8FA04B0", VA = "0x188FA1EB0", Slot = "13")]
		protected override void JMKKDIJHNDH(Material PFHPGDKJCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2030", Offset = "0x8FA0630", VA = "0x188FA2030", Slot = "14")]
		protected override void KNPIKLDOCFM(Material PFHPGDKJCCC, bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2550", Offset = "0x8FA0B50", VA = "0x188FA2550")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[AddComponentMenu("UI/Effects/Tiler", 15)]
	[ExecuteAlways]
	public class UITiler : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum NOGOMEHMAHJ
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int EBDJKECNPGA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int CLAPADEDOLK;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int HBBEFBOGONA;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int IKBIMGKCMIJ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int FLNKPNHEMLB;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int ONFHBFMMKKC;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int FHPOHGAOHDD;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int OIGPPIMBOIE;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int NOIIMFNOENB;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int DAABDHOFMJA;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int HKICCLGPLPF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int FBEKOJOOAGP;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int BNPOJEHKOHN;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int IFFPNEJDOHF;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int BJJIOOCJNKB;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int GOANCPFEFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		[SerializeField]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("The distance between each tile.")]
		[SerializeField]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("The offset applied to each alternating row or column.")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private NOGOMEHMAHJ animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[IEEHBALBFJL("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[IEEHBALBFJL("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic AHBLKKNEAHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool HLELIFEMBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite AONFLKPCNCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8FA3610", Offset = "0x8FA1C10", VA = "0x188FA3610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8FA3830", Offset = "0x8FA1E30", VA = "0x188FA3830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color GJDCFIAOMCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1090920", Offset = "0x108EF20", VA = "0x181090920")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8FA38C0", Offset = "0x8FA1EC0", VA = "0x188FA38C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color PICOOLJGCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x12D5680", Offset = "0x12D3C80", VA = "0x1812D5680")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8FA3700", Offset = "0x8FA1D00", VA = "0x188FA3700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float ENFHCKIBJBC
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xE35B00", Offset = "0xE34100", VA = "0x180E35B00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8FA37C0", Offset = "0x8FA1DC0", VA = "0x188FA37C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 HLFJGIAOMNG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2A78CB0", Offset = "0x2A772B0", VA = "0x182A78CB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8FA37E0", Offset = "0x8FA1DE0", VA = "0x188FA37E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float CDOMHMKBDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E60", Offset = "0xAC0460", VA = "0x180AC1E60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8FA3780", Offset = "0x8FA1D80", VA = "0x188FA3780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 GGICIFPLLGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x18202D0", Offset = "0x181E8D0", VA = "0x1818202D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8FA3940", Offset = "0x8FA1F40", VA = "0x188FA3940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float AGDPKAPAJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x12C4530", Offset = "0x12C2B30", VA = "0x1812C4530")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8FA36D0", Offset = "0x8FA1CD0", VA = "0x188FA36D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 LCCGLBPGGDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8FA2AC0", Offset = "0x8FA10C0", VA = "0x188FA2AC0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public NOGOMEHMAHJ IMBEFDBBKLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB2DC90", Offset = "0xB2C290", VA = "0x180B2DC90")]
			get
			{
				return default(NOGOMEHMAHJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8FA36F0", Offset = "0x8FA1CF0", VA = "0x188FA36F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float PDCMDDEHFOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x19D4830", Offset = "0x19D2E30", VA = "0x1819D4830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8FA37A0", Offset = "0x8FA1DA0", VA = "0x188FA37A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float BJECLMEJJDH
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xF4BA20", Offset = "0xF4A020", VA = "0x180F4BA20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8FA36B0", Offset = "0x8FA1CB0", VA = "0x188FA36B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2B50", Offset = "0x8FA1150", VA = "0x188FA2B50", Slot = "13")]
		protected override void JMKKDIJHNDH(Material PFHPGDKJCCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2810", Offset = "0x8FA0E10", VA = "0x188FA2810")]
		private void HOEMHJHMMFP(Sprite BGDPMEMGGAC, [Out] Vector2 FBICJNMEOHE, [Out] Vector2 BEHBNJIJDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3250", Offset = "0x8FA1850", VA = "0x188FA3250", Slot = "14")]
		protected override void KNPIKLDOCFM(Material PFHPGDKJCCC, bool KBMMNNBFAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3580", Offset = "0x8FA1B80", VA = "0x188FA3580")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader JHBCBBKCJCN;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader LKMJPCHPPPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8FA39E0", Offset = "0x8FA1FE0", VA = "0x188FA39E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3990", Offset = "0x8FA1F90", VA = "0x188FA3990")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class RectTransformHideableAdapter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private SerializableRectTransform hiddenRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private SerializableRectTransform NBGBCBMKAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool KHNLJGCALJE;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8F9DD50", Offset = "0x8F9C350", VA = "0x188F9DD50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8F9E030", Offset = "0x8F9C630", VA = "0x188F9E030")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8F9DEE0", Offset = "0x8F9C4E0", VA = "0x188F9DEE0")]
		private void FKLIOCIFHOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8F9DF60", Offset = "0x8F9C560", VA = "0x188F9DF60")]
		private void JKKIBKHAPAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CNJGBNDPBJO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct NGHFHFOFPDM : IEquatable<NGHFHFOFPDM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component JIFPJFGEAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action LFGGCNOALDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int OKBGKBCABCG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component OALJMBCNDOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D790", Offset = "0x8F9BD90", VA = "0x188F9D790")]
		public NGHFHFOFPDM(Component JIFPJFGEAIK, Action LFGGCNOALDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D670", Offset = "0x8F9BC70", VA = "0x188F9D670")]
		public void ALBBNBAFAAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D6F0", Offset = "0x8F9BCF0", VA = "0x188F9D6F0", Slot = "4")]
		public bool Equals(NGHFHFOFPDM AAGCKLPFJME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D700", Offset = "0x8F9BD00", VA = "0x188F9D700", Slot = "0")]
		public override bool Equals(object MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAA5180", Offset = "0xAA3780", VA = "0x180AA5180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ANBLANJEALB : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public CNJGBNDPBJO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public ANBLANJEALB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B190", Offset = "0x8F99790", VA = "0x188F9B190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B550", Offset = "0x8F99B50", VA = "0x188F9B550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly MFJFPNHANBJ GIPLNPNDFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int BBBEMEJJCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int GPKECBEBEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> DEKMGBEMOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, NGHFHFOFPDM> EOCJEOIPOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<NGHFHFOFPDM> IGIJPILBEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<NGHFHFOFPDM> PAKLAJKEOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private FAKIPBKLGEB LENLIDPBFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JCCGKNMBLGM LOOKANJOADI;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private JCCGKNMBLGM FBFMDHGOFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BB40", Offset = "0x8F9A140", VA = "0x188F9BB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8F9BDE0", Offset = "0x8F9A3E0", VA = "0x188F9BDE0")]
	public CNJGBNDPBJO(MFJFPNHANBJ GIPLNPNDFAP, int BBBEMEJJCDB = -1, int GPKECBEBEDN = -1, [Optional] Func<Component, float> DEKMGBEMOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8F9B8C0", Offset = "0x8F99EC0", VA = "0x188F9B8C0")]
	public void IHBNMEFMEAB(Component JIFPJFGEAIK, Action ENKJLGJOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8F9BBD0", Offset = "0x8F9A1D0", VA = "0x188F9BBD0")]
	public void JJHCBIKPCMF(Component JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8F9B620", Offset = "0x8F99C20", VA = "0x188F9B620")]
	public bool DABDNANPCEJ(Component IDFKPPKNONO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8F9B680", Offset = "0x8F99C80", VA = "0x188F9B680")]
	private void GHIDMDILONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8F9B5A0", Offset = "0x8F99BA0", VA = "0x188F9B5A0")]
	[IteratorStateMachine(typeof(ANBLANJEALB))]
	private IEnumerator<KAIBAKBEOHB> CBPELJEFEKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xF91230", Offset = "0xF8F830", VA = "0x180F91230")]
	[CompilerGenerated]
	private void ODPNPJIBPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8F9BD60", Offset = "0x8F9A360", VA = "0x188F9BD60")]
	[CompilerGenerated]
	private float PFBKPLHFIFM(NGHFHFOFPDM ENKJLGJOKLD)
	{
		return default(float);
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
