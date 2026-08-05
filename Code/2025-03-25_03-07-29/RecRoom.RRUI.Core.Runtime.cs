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
				[Cpp2IlInjected.Address(RVA = "0x81B7B40", Offset = "0x81B6F40", VA = "0x1881B7B40")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x81B7BA0", Offset = "0x81B6FA0", VA = "0x1881B7BA0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x81B7B00", Offset = "0x81B6F00", VA = "0x1881B7B00")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x81B7690", Offset = "0x81B6A90", VA = "0x1881B7690")]
			public void GMEHICGGCLA(PointerEventData EEHGANNMJLP, RectTransform JJAGEEPCCDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x81B7870", Offset = "0x81B6C70", VA = "0x1881B7870")]
			public void PDPJIMDFDAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x81B7790", Offset = "0x81B6B90", VA = "0x1881B7790")]
			public void MNNNDLNGEJP(PointerEventData EEHGANNMJLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x81B7640", Offset = "0x81B6A40", VA = "0x1881B7640")]
			public void ALFODINFPIH(float PKJAGOMENAC, RectTransform JJAGEEPCCDD, Vector3 PFOFJFECKOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly OHMOKFGANBG<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly OHMOKFGANBG<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly OHMOKFGANBG<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly OHMOKFGANBG<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly OHMOKFGANBG<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly OLDENIALAEA PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData OOHJFFFBCGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool ADNGEEOMMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool NOKNEKIKAOA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HAFJKDJHDJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9933C0", Offset = "0x9927C0", VA = "0x1809933C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x81B6E50", Offset = "0x81B6250", VA = "0x1881B6E50")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JAEEIEOFGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x993470", Offset = "0x992870", VA = "0x180993470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x81B6E80", Offset = "0x81B6280", VA = "0x1881B6E80")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81B6DD0", Offset = "0x81B61D0", VA = "0x1881B6DD0")]
		private bool DKLFDCDGNNN(PointerEventData JNDPCNNCNMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81B7300", Offset = "0x81B6700", VA = "0x1881B7300", Slot = "5")]
		public void OnPointerDown(PointerEventData JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81B73C0", Offset = "0x81B67C0", VA = "0x1881B73C0", Slot = "11")]
		public void OnPointerUp(PointerEventData JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81B7170", Offset = "0x81B6570", VA = "0x1881B7170", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81B6EB0", Offset = "0x81B62B0", VA = "0x1881B6EB0", Slot = "7")]
		public void OnBeginDrag(PointerEventData JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81B6FC0", Offset = "0x81B63C0", VA = "0x1881B6FC0", Slot = "4")]
		public void OnDrag(PointerEventData JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81B70A0", Offset = "0x81B64A0", VA = "0x1881B70A0", Slot = "8")]
		public void OnEndDrag(PointerEventData JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81B7360", Offset = "0x81B6760", VA = "0x1881B7360", Slot = "9")]
		public void OnPointerEnter(PointerEventData JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81B7390", Offset = "0x81B6790", VA = "0x1881B7390", Slot = "10")]
		public void OnPointerExit(PointerEventData JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81B6F80", Offset = "0x81B6380", VA = "0x1881B6F80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81B7420", Offset = "0x81B6820", VA = "0x1881B7420")]
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
		[Cpp2IlInjected.Address(RVA = "0x81B25B0", Offset = "0x81B19B0", VA = "0x1881B25B0")]
		public void SetCanvasSortingOrder(short OEEMFPJJMLD, bool LICDKCLIJGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData JLNJOGMJGKO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81B2870", Offset = "0x81B1C70", VA = "0x1881B2870", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81B2750", Offset = "0x81B1B50", VA = "0x1881B2750", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81B26A0", Offset = "0x81B1AA0", VA = "0x1881B26A0")]
		private void DDMHDNIAFJP(GameObject AGHFDPLAFPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81B2B50", Offset = "0x81B1F50", VA = "0x1881B2B50")]
		public void SetOptionsWithNoDefault(List<string> EDJBENPLFOA, [Optional] string EKHPJGAKJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81B2A60", Offset = "0x81B1E60", VA = "0x1881B2A60")]
		public void SetOptionsWithNoDefault(List<OptionData> PJIJGMDDLKH, [Optional] string EKHPJGAKJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81B2990", Offset = "0x81B1D90", VA = "0x1881B2990", Slot = "42")]
		public override void OnPointerClick(PointerEventData JNDPCNNCNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas DHPOCLBGOOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81B2D70", Offset = "0x81B2170", VA = "0x1881B2D70")]
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
		private sealed class GKPPPCNBEFN : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private OAGIBKDGOAG <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public GKPPPCNBEFN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x81B31D0", Offset = "0x81B25D0", VA = "0x1881B31D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x81B36E0", Offset = "0x81B2AE0", VA = "0x1881B36E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[HBPAIPBJNDJ(FPABMOGJDEH.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly LLCILPEOAFD<object> EGDEBLMFJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool ANGFBIOAIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? DKHPKKPGPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? GMLPMAKHDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? BBODHJFMGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool BDIEJPMFHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool ICIPEMKAOJO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JLPMPJGIJPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x81B3F70", Offset = "0x81B3370", VA = "0x1881B3F70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool FLHLIEAOJFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x81B3F20", Offset = "0x81B3320", VA = "0x1881B3F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CGEFBOFJHLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9DD850", Offset = "0x9DCC50", VA = "0x1809DD850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x81B4130", Offset = "0x81B3530", VA = "0x1881B4130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HHDIAKNDBKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x81B3E80", Offset = "0x81B3280", VA = "0x1881B3E80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x81B4090", Offset = "0x81B3490", VA = "0x1881B4090")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81B3A40", Offset = "0x81B2E40", VA = "0x1881B3A40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81B3C60", Offset = "0x81B3060", VA = "0x1881B3C60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81B3C10", Offset = "0x81B3010", VA = "0x1881B3C10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81B3B80", Offset = "0x81B2F80", VA = "0x1881B3B80")]
		public void Hide(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81B3DE0", Offset = "0x81B31E0", VA = "0x1881B3DE0")]
		public void Show(object HEJFDMJNIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81B3CF0", Offset = "0x81B30F0", VA = "0x1881B3CF0")]
		public void Set(object HEJFDMJNIGB, bool CFCGPOMHAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81B3AD0", Offset = "0x81B2ED0", VA = "0x1881B3AD0")]
		public void Clear(bool MOIEGLFMEOD = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81B38C0", Offset = "0x81B2CC0", VA = "0x1881B38C0")]
		private void AKGOFJAKECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81B3B90", Offset = "0x81B2F90", VA = "0x1881B3B90")]
		[IteratorStateMachine(typeof(GKPPPCNBEFN))]
		private IEnumerator<OAGIBKDGOAG> MCPPGNKNNDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81B3B40", Offset = "0x81B2F40", VA = "0x1881B3B40", Slot = "5")]
		public virtual void DoHideOrShow(bool ONCKJAHOIPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81B3DF0", Offset = "0x81B31F0", VA = "0x1881B3DF0")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LCBACPLJJOK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum JPGNLDJDMMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static MDABFMCKPEE OKMCOAKNCEL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static MDABFMCKPEE AGBIEGPLCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81B45B0", Offset = "0x81B39B0", VA = "0x1881B45B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static JPGNLDJDMMF LCCKPDPFIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81B4480", Offset = "0x81B3880", VA = "0x1881B4480")]
		get
		{
			return default(JPGNLDJDMMF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81B4320", Offset = "0x81B3720", VA = "0x1881B4320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<JPGNLDJDMMF> JJLKIGKELPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81B4250", Offset = "0x81B3650", VA = "0x1881B4250")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81B46B0", Offset = "0x81B3AB0", VA = "0x1881B46B0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NGMHEHEDLMP : OBIPFJNMDCE, EJGPGHBPLHP, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, JNCJDJGGKFH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	OLDENIALAEA FNPOGFAOHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPNDCLGPJDN Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject FAHGNPJKBFP);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KPNDCLGPJDN Spawn<T>(int CDDFDHBFIFM, IReadOnlyList<T> AMHCLKHIFKH, GameObject FAHGNPJKBFP);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KPNDCLGPJDN Spawn<T>(int CDDFDHBFIFM, IReadOnlyList<T> AMHCLKHIFKH, GameObject FLJHOHOJCKG, Func<int, GameObject> GFFKGPHAFPO);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int KDCAMOIGIMA, float OBNMFLFOJIA);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum MJLCLFJEDAH : byte
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
		private static readonly int FDMPEIIIPFL;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<MJLCLFJEDAH, string> LCAKGGDLEOM;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int NNLNOKIMCHI = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int IFCOLNICHAI;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int FFFCAJFIONO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int MLAIODDOILN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int DHFAINBDJBC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int JFJIFOGKEHL;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int BDFMENEFABF;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int NCIAKLGBEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool FHFCCJNBJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool HANJOFJBHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] LBHLFGGHLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private MJLCLFJEDAH type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly MJLCLFJEDAH[] NLLIEFMPDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[GOMCBKCIINJ("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly MJLCLFJEDAH[] KFOFECKDPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[GOMCBKCIINJ("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[GOMCBKCIINJ("type", MJLCLFJEDAH.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[GOMCBKCIINJ("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic OMDJCIGFNLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool ENACMIKHDAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient HBDEFAHHGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x81B6C20", Offset = "0x81B6020", VA = "0x1881B6C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MJLCLFJEDAH PONMJFHCNDE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xBACB90", Offset = "0xBABF90", VA = "0x180BACB90")]
			get
			{
				return default(MJLCLFJEDAH);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x81B6DA0", Offset = "0x81B61A0", VA = "0x1881B6DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool CPLDKHGHAHN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x81B5600", Offset = "0x81B4A00", VA = "0x1881B5600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 PACPNDLKHBM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x81B6B90", Offset = "0x81B5F90", VA = "0x1881B6B90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x81B6BD0", Offset = "0x81B5FD0", VA = "0x1881B6BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool ALEPPCHGPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x81B6270", Offset = "0x81B5670", VA = "0x1881B6270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 OIHEBFGIBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x81B6BB0", Offset = "0x81B5FB0", VA = "0x1881B6BB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x81B6D50", Offset = "0x81B6150", VA = "0x1881B6D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float IJPMLJPFGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xBD2F80", Offset = "0xBD2380", VA = "0x180BD2F80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x204A400", Offset = "0x2049800", VA = "0x18204A400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 ODCOCJAHNDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x81B6080", Offset = "0x81B5480", VA = "0x1881B6080")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 FPJEPBDEAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x81B62E0", Offset = "0x81B56E0", VA = "0x1881B62E0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float CPPFKHOALGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x81B6DB0", Offset = "0x81B61B0", VA = "0x1881B6DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81B60D0", Offset = "0x81B54D0", VA = "0x1881B60D0", Slot = "12")]
		protected override void GGAKIGEHHAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81B6350", Offset = "0x81B5750", VA = "0x1881B6350")]
		private void PFBLDEPFLAF(Color[] GMBJEHONJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81B5670", Offset = "0x81B4A70", VA = "0x1881B5670", Slot = "13")]
		protected override void ACNGNCPFIJN(Material KIEAKCEGOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x81B64E0", Offset = "0x81B58E0", VA = "0x1881B64E0", Slot = "14")]
		protected override void PNAAFFFICPC(Material KIEAKCEGOFO, bool EJBJKNOIGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81B6AE0", Offset = "0x81B5EE0", VA = "0x1881B6AE0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly PNCPDNLHCNF DAMGKDOILHF;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite KGNOPKBPFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material MIKGJPIHPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material FFKOMFFNKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool GPMEIMBJCMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool ANGFBIOAIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool CPGDJFCBABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool JCIBDBHDCIK;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic OMDJCIGFNLO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader OKGNKPJKFPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool ENACMIKHDAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool AEEOLJHDHHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform JJAGEEPCCDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x81B7FB0", Offset = "0x81B73B0", VA = "0x1881B7FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect FCAKCECOINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x81B8180", Offset = "0x81B7580", VA = "0x1881B8180")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite ICDNMPLGODI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x81B87D0", Offset = "0x81B7BD0", VA = "0x1881B87D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x81B7D90", Offset = "0x81B7190", VA = "0x1881B7D90", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x81B89B0", Offset = "0x81B7DB0", VA = "0x1881B89B0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x81B8CB0", Offset = "0x81B80B0", VA = "0x1881B8CB0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x81B8B60", Offset = "0x81B7F60", VA = "0x1881B8B60", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x81B8640", Offset = "0x81B7A40", VA = "0x1881B8640")]
		private void MHHBBFLMDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x81B8010", Offset = "0x81B7410", VA = "0x1881B8010")]
		private void FLADFELJOAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81B7F80", Offset = "0x81B7380", VA = "0x1881B7F80")]
		private void FCANCOGFIPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81B82A0", Offset = "0x81B76A0", VA = "0x1881B82A0")]
		private void JADLPKAKHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81B8E00", Offset = "0x81B8200", VA = "0x1881B8E00")]
		protected void PPLNEIGAMCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x81B8CC0", Offset = "0x81B80C0", VA = "0x1881B8CC0")]
		private void PIMKGJBKPAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "12")]
		protected virtual void GGAKIGEHHAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "13")]
		protected virtual void ACNGNCPFIJN(Material KIEAKCEGOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "14")]
		protected virtual void PNAAFFFICPC(Material KIEAKCEGOFO, bool EJBJKNOIGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x81B82F0", Offset = "0x81B76F0", VA = "0x1881B82F0")]
		private void MBGCHBIOHMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
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
		private static readonly int FFOIAKBDNPO;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int FGHLLCKANAD;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int IMMPDPJOFGG;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int LJGFCOPPAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
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
		private Color[] LBHLFGGHLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] JOPNKDBCOCP;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic OMDJCIGFNLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool AEEOLJHDHHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> DGNODDDDBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 PACPNDLKHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x81B9B40", Offset = "0x81B8F40", VA = "0x1881B9B40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x81B9B60", Offset = "0x81B8F60", VA = "0x1881B9B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x81B9740", Offset = "0x81B8B40", VA = "0x1881B9740")]
		public void SetRingLayers(IReadOnlyList<RingLayer> HELIEIJEHLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x81B9500", Offset = "0x81B8900", VA = "0x1881B9500")]
		public bool SetRingLayerColor(int JBHMHOMJPDO, Color CKANMCILFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x81B9650", Offset = "0x81B8A50", VA = "0x1881B9650")]
		public bool SetRingLayerSize(int JBHMHOMJPDO, float EOKAMHLPIFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x81B9370", Offset = "0x81B8770", VA = "0x1881B9370", Slot = "12")]
		protected override void GGAKIGEHHAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81B9200", Offset = "0x81B8600", VA = "0x1881B9200", Slot = "13")]
		protected override void ACNGNCPFIJN(Material KIEAKCEGOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81B94B0", Offset = "0x81B88B0", VA = "0x1881B94B0", Slot = "14")]
		protected override void PNAAFFFICPC(Material KIEAKCEGOFO, bool EJBJKNOIGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x81B9890", Offset = "0x81B8C90", VA = "0x1881B9890")]
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
		public enum IFKINKCKDPP
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int MABKEEEIICN;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int ILMKMKDHLNG;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int OINOCHKLEEN;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int HKOJPKGAOID;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int KCONPJINBDC;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int OJNACOAFFDF;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int AFNLAAHIFPC;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int OICMMHGCFHE;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int CINMINPAFCM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int HEJFPJHPJLA;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int OJCGFLIKCLJ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int BHPHFFMFNAM;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int JBDLNFKKPIL;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int BALGGCDHKFJ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int DHMBMDEODEC;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int LMOJJFCAMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[IJJGDJMELDG(FPABMOGJDEH.Self, false, false, false)]
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
		private IFKINKCKDPP animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[GOMCBKCIINJ("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[GOMCBKCIINJ("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic OMDJCIGFNLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool AEEOLJHDHHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite GCKGBICABAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x81BA960", Offset = "0x81B9D60", VA = "0x1881BA960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x81BAB80", Offset = "0x81B9F80", VA = "0x1881BAB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color BJALNEOPFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xE1F7E0", Offset = "0xE1EBE0", VA = "0x180E1F7E0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x81BAC10", Offset = "0x81BA010", VA = "0x1881BAC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color DHIBKJOJNNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xFB9E40", Offset = "0xFB9240", VA = "0x180FB9E40")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x81BAA50", Offset = "0x81B9E50", VA = "0x1881BAA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float FDPLOOILHAI
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xBD2B70", Offset = "0xBD1F70", VA = "0x180BD2B70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x81BAB10", Offset = "0x81B9F10", VA = "0x1881BAB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 NNJCGOGHMAO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x81BA940", Offset = "0x81B9D40", VA = "0x1881BA940")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x81BAB30", Offset = "0x81B9F30", VA = "0x1881BAB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float MCKFPDMFILD
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6F0", Offset = "0x9ABAF0", VA = "0x1809AC6F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x81BAAD0", Offset = "0x81B9ED0", VA = "0x1881BAAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 IAAGHFCPHGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x13E08E0", Offset = "0x13DFCE0", VA = "0x1813E08E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x81BAC90", Offset = "0x81BA090", VA = "0x1881BAC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float LLNBGDEIHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xFA5BA0", Offset = "0xFA4FA0", VA = "0x180FA5BA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x81BAA20", Offset = "0x81B9E20", VA = "0x1881BAA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 NLLDFLEENHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x81BA520", Offset = "0x81B9920", VA = "0x1881BA520")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IFKINKCKDPP DMDIJOFGJFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD8DCA0", Offset = "0xD8D0A0", VA = "0x180D8DCA0")]
			get
			{
				return default(IFKINKCKDPP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x81BAA40", Offset = "0x81B9E40", VA = "0x1881BAA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float IOMOAHDPIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x155F7D0", Offset = "0x155EBD0", VA = "0x18155F7D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x81BAAF0", Offset = "0x81B9EF0", VA = "0x1881BAAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float OOKEHHGAMII
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x14E87A0", Offset = "0x14E7BA0", VA = "0x1814E87A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x81BAA00", Offset = "0x81B9E00", VA = "0x1881BAA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x81B9BB0", Offset = "0x81B8FB0", VA = "0x1881B9BB0", Slot = "13")]
		protected override void ACNGNCPFIJN(Material KIEAKCEGOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x81BA270", Offset = "0x81B9670", VA = "0x1881BA270")]
		private void AGCJGEGGLME(Sprite ENNHGOHGNBC, [Out] Vector2 HHBECMGIBLH, [Out] Vector2 LPEEGGIPOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x81BA5B0", Offset = "0x81B99B0", VA = "0x1881BA5B0", Slot = "14")]
		protected override void PNAAFFFICPC(Material KIEAKCEGOFO, bool EJBJKNOIGIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x81BA8B0", Offset = "0x81B9CB0", VA = "0x1881BA8B0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader IMDIJKDFOFL;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader OKGNKPJKFPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x81BAD30", Offset = "0x81BA130", VA = "0x1881BAD30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x81BACE0", Offset = "0x81BA0E0", VA = "0x1881BACE0")]
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
		private SerializableRectTransform LODMMNHHDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool FDEPLCAJLHM;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x81B5210", Offset = "0x81B4610", VA = "0x1881B5210")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81B5420", Offset = "0x81B4820", VA = "0x1881B5420")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x81B53A0", Offset = "0x81B47A0", VA = "0x1881B53A0")]
		private void BHBPPBHJCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81B5140", Offset = "0x81B4540", VA = "0x1881B5140")]
		private void AKGOFJAKECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PNCPDNLHCNF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HJMIKIIGGFK : IEquatable<HJMIKIIGGFK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component PFPNPMCGHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action OBFILMMEBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int JDCPFLDPKOF;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component OKKFDMCBBIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xC67BB0", Offset = "0xC66FB0", VA = "0x180C67BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x81B3850", Offset = "0x81B2C50", VA = "0x1881B3850")]
		public HJMIKIIGGFK(Component PFPNPMCGHHC, Action OBFILMMEBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x81B37D0", Offset = "0x81B2BD0", VA = "0x1881B37D0")]
		public void MKBKFOOCCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81B37C0", Offset = "0x81B2BC0", VA = "0x1881B37C0", Slot = "4")]
		public bool Equals(HJMIKIIGGFK JAPIEEBOJEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x81B3730", Offset = "0x81B2B30", VA = "0x1881B3730", Slot = "0")]
		public override bool Equals(object HAPOBHMBDHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FNNKOHKGFCJ : IEnumerator<OAGIBKDGOAG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private OAGIBKDGOAG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PNCPDNLHCNF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private OAGIBKDGOAG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
		[DebuggerHidden]
		public FNNKOHKGFCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x81B2DC0", Offset = "0x81B21C0", VA = "0x1881B2DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x81B3180", Offset = "0x81B2580", VA = "0x1881B3180", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly OIKDKHDKGAI FJEPJKOEMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int IGNGADBKBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int CJBDJBKLEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> BEDKLBDKFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, HJMIKIIGGFK> COOFEFLKLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<HJMIKIIGGFK> MOINIMOHLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<HJMIKIIGGFK> BMEBGDHNKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private INGHODAMJIF NMBKNMDNAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private KHKCCPNIAAP GNOEKMFHAKN;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private KHKCCPNIAAP FPPOAHLPNDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x81B4A80", Offset = "0x81B3E80", VA = "0x1881B4A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x81B4FC0", Offset = "0x81B43C0", VA = "0x1881B4FC0")]
	public PNCPDNLHCNF(OIKDKHDKGAI FJEPJKOEMOI, int IGNGADBKBAN = -1, int CJBDJBKLEMF = -1, [Optional] Func<Component, float> BEDKLBDKFDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x81B4800", Offset = "0x81B3C00", VA = "0x1881B4800")]
	public void DCBHGNPIDCF(Component PFPNPMCGHHC, Action MEOMIMDGMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x81B4B10", Offset = "0x81B3F10", VA = "0x1881B4B10")]
	public void GBOALPMMFIP(Component PFPNPMCGHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x81B4CA0", Offset = "0x81B40A0", VA = "0x1881B4CA0")]
	public bool IMGGKOLMPEF(Component EJFPPCHJOBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x81B4D00", Offset = "0x81B4100", VA = "0x1881B4D00")]
	private void JBIFGCHOJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x81B4F40", Offset = "0x81B4340", VA = "0x1881B4F40")]
	[IteratorStateMachine(typeof(FNNKOHKGFCJ))]
	private IEnumerator<OAGIBKDGOAG> OEGCCBHIKAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xBDA850", Offset = "0xBD9C50", VA = "0x180BDA850")]
	[CompilerGenerated]
	private void HBPNGEHEDOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x81B4780", Offset = "0x81B3B80", VA = "0x1881B4780")]
	[CompilerGenerated]
	private float APENLOCBLOP(HJMIKIIGGFK MEOMIMDGMJF)
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
