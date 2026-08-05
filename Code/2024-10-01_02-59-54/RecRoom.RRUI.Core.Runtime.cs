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
				[Cpp2IlInjected.Address(RVA = "0x76A8530", Offset = "0x76A7930", VA = "0x1876A8530")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x76A8590", Offset = "0x76A7990", VA = "0x1876A8590")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x76A84F0", Offset = "0x76A78F0", VA = "0x1876A84F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x76A83F0", Offset = "0x76A77F0", VA = "0x1876A83F0")]
			public void JHFDOIODGAB(PointerEventData AOLKIBOGGHJ, RectTransform IMPEIMBHGAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x76A8080", Offset = "0x76A7480", VA = "0x1876A8080")]
			public void DOPHPLFODGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x76A8310", Offset = "0x76A7710", VA = "0x1876A8310")]
			public void FFNNPPJJDMK(PointerEventData AOLKIBOGGHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76A8030", Offset = "0x76A7430", VA = "0x1876A8030")]
			public void AIJPEKIIJPP(float CIFOCOAAKBA, RectTransform IMPEIMBHGAL, Vector3 MIPHEMMOPOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly JEIAMONHOFF<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JEIAMONHOFF<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly JEIAMONHOFF<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly JEIAMONHOFF<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly JEIAMONHOFF<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly LKILNMKOKHH PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData LFINIIOOPAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool LHGPDHMKAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool OOLLGNICEFN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PIOGOLPKFKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8B8290", Offset = "0x8B7690", VA = "0x1808B8290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x76A77C0", Offset = "0x76A6BC0", VA = "0x1876A77C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool INLHCODJMBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8B81B0", Offset = "0x8B75B0", VA = "0x1808B81B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x76A77F0", Offset = "0x76A6BF0", VA = "0x1876A77F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76A7820", Offset = "0x76A6C20", VA = "0x1876A7820")]
		private bool JNPHPKIJGLI(PointerEventData PGKBONDNINN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76A7CF0", Offset = "0x76A70F0", VA = "0x1876A7CF0", Slot = "5")]
		public void OnPointerDown(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76A7DB0", Offset = "0x76A71B0", VA = "0x1876A7DB0", Slot = "11")]
		public void OnPointerUp(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76A7B60", Offset = "0x76A6F60", VA = "0x1876A7B60", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76A78A0", Offset = "0x76A6CA0", VA = "0x1876A78A0", Slot = "7")]
		public void OnBeginDrag(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76A79B0", Offset = "0x76A6DB0", VA = "0x1876A79B0", Slot = "4")]
		public void OnDrag(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76A7A90", Offset = "0x76A6E90", VA = "0x1876A7A90", Slot = "8")]
		public void OnEndDrag(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76A7D50", Offset = "0x76A7150", VA = "0x1876A7D50", Slot = "9")]
		public void OnPointerEnter(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x76A7D80", Offset = "0x76A7180", VA = "0x1876A7D80", Slot = "10")]
		public void OnPointerExit(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x76A7970", Offset = "0x76A6D70", VA = "0x1876A7970")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x76A7E10", Offset = "0x76A7210", VA = "0x1876A7E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x76A3620", Offset = "0x76A2A20", VA = "0x1876A3620")]
		public void SetCanvasSortingOrder(short DBKHBGPGICE, bool ODFCKIFBFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData HHBHJKCNIFM;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x76A38E0", Offset = "0x76A2CE0", VA = "0x1876A38E0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x76A37C0", Offset = "0x76A2BC0", VA = "0x1876A37C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76A3710", Offset = "0x76A2B10", VA = "0x1876A3710")]
		private void NLFDFOOCIAE(GameObject ODPFEJLOMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x76A3BC0", Offset = "0x76A2FC0", VA = "0x1876A3BC0")]
		public void SetOptionsWithNoDefault(List<string> BIHDACIMKFK, [Optional] string JHNDBODOHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76A3AD0", Offset = "0x76A2ED0", VA = "0x1876A3AD0")]
		public void SetOptionsWithNoDefault(List<OptionData> AHOANCKGKEN, [Optional] string JHNDBODOHEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x76A3A00", Offset = "0x76A2E00", VA = "0x1876A3A00", Slot = "42")]
		public override void OnPointerClick(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas JJLIPNONJAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76A3DE0", Offset = "0x76A31E0", VA = "0x1876A3DE0")]
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
		private sealed class AGHACKKEJLD : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private BGFGBHFIDBJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
			[DebuggerHidden]
			public AGHACKKEJLD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x76A2CB0", Offset = "0x76A20B0", VA = "0x1876A2CB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x76A31C0", Offset = "0x76A25C0", VA = "0x1876A31C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[KKFPOGPNFEA(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly MDOHCEHHCAF<object> MCBKJEJPBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool CACNKDGMABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? MLGHGFLDGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? DKPODNOKNBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? ACCEGMPFCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool EPGNKGHNDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool DKFPHMOADCB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PFKGKEFNEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76A4E90", Offset = "0x76A4290", VA = "0x1876A4E90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool GPNLCCIJANL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x76A4E40", Offset = "0x76A4240", VA = "0x1876A4E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool PBMOOKGHNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8F5AF0", Offset = "0x8F4EF0", VA = "0x1808F5AF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x76A5050", Offset = "0x76A4450", VA = "0x1876A5050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KNNAECMCLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x76A4DA0", Offset = "0x76A41A0", VA = "0x1876A4DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x76A4FB0", Offset = "0x76A43B0", VA = "0x1876A4FB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x76A47E0", Offset = "0x76A3BE0", VA = "0x1876A47E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76A4B80", Offset = "0x76A3F80", VA = "0x1876A4B80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76A4B30", Offset = "0x76A3F30", VA = "0x1876A4B30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x76A4920", Offset = "0x76A3D20", VA = "0x1876A4920")]
		public void Hide(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x76A4D00", Offset = "0x76A4100", VA = "0x1876A4D00")]
		public void Show(object FDAIGOGAKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76A4C10", Offset = "0x76A4010", VA = "0x1876A4C10")]
		public void Set(object FDAIGOGAKMH, bool IONDDNLFDMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x76A4870", Offset = "0x76A3C70", VA = "0x1876A4870")]
		public void Clear(bool MKECCFGFCPL = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x76A49B0", Offset = "0x76A3DB0", VA = "0x1876A49B0")]
		private void LOAEKADIODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x76A4930", Offset = "0x76A3D30", VA = "0x1876A4930")]
		[IteratorStateMachine(typeof(AGHACKKEJLD))]
		private IEnumerator<BGFGBHFIDBJ> KECMMFKGKKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x76A48E0", Offset = "0x76A3CE0", VA = "0x1876A48E0", Slot = "5")]
		public virtual void DoHideOrShow(bool CCLKDEBBNFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76A4D10", Offset = "0x76A4110", VA = "0x1876A4D10")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DBCIKEKCACL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xB81E30", Offset = "0xB81230", VA = "0x180B81E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8B60D0", Offset = "0x8B54D0", VA = "0x1808B60D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> FEDMCKBJDMD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x76A51B0", Offset = "0x76A45B0", VA = "0x1876A51B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x76A5310", Offset = "0x76A4710", VA = "0x1876A5310")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> GPJKFBIOIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x76A5260", Offset = "0x76A4660", VA = "0x1876A5260")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x76A53C0", Offset = "0x76A47C0", VA = "0x1876A53C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x76A5170", Offset = "0x76A4570", VA = "0x1876A5170", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x76A5190", Offset = "0x76A4590", VA = "0x1876A5190", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData PGKBONDNINN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x11C4190", Offset = "0x11C3590", VA = "0x1811C4190")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x11C4190", Offset = "0x11C3590", VA = "0x1811C4190")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JAIIDNMHBPL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum ECNIBNKALMH
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static JAJELMFJLBA FLGIMPKJAHK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static JAJELMFJLBA DEIJGEFDEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x76A55D0", Offset = "0x76A49D0", VA = "0x1876A55D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static ECNIBNKALMH MGJAAEJEOFC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x76A5870", Offset = "0x76A4C70", VA = "0x1876A5870")]
		get
		{
			return default(ECNIBNKALMH);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76A5470", Offset = "0x76A4870", VA = "0x1876A5470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<ECNIBNKALMH> AKAIGNOJFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x76A57A0", Offset = "0x76A4BA0", VA = "0x1876A57A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x76A56D0", Offset = "0x76A4AD0", VA = "0x1876A56D0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AFPKDADPCPG : CDDLJBJNBGL, MPADKGNDIDA, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, LCKLMMFKGOP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LKILNMKOKHH BIDCLICPPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryInit();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LMEMMAHKEDK Clear();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SpawnLoadingPlaceholders(GameObject PJJHJGOPMNC);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LMEMMAHKEDK Spawn<T>(int OPJOCOMPAKF, IReadOnlyList<T> MPMEGOKIEPF, GameObject PJJHJGOPMNC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LMEMMAHKEDK Spawn<T>(int OPJOCOMPAKF, IReadOnlyList<T> MPMEGOKIEPF, GameObject MKNOMNOJOHP, Func<int, GameObject> NJOFBNKNPJK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SmoothScrollTo(int AEAHMAMPNLO, float IGHENHNKMBA);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum JKBKCKLFMCI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			LeftToRight = 0,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			RightToLeft = 1,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			TopToBottom = 2,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			BottomToTop = 3,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			CustomDirection = 4,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			RadialOut = 10,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			RadialIn = 11,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			VignetteOut = 20,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			VignetteIn = 21,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Disabled = byte.MaxValue
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int OEPMJJOOPGK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<JKBKCKLFMCI, string> FHCIDOKAPKI;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int OOAFPEIMDBB = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int OCOACABBLDL;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int ELDAIAMNACN;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int CMHEGHJJODN;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int AIAJOLDCNMF;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int HBAKFLDNCCL;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int DHAMGOMBOCE;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int BBCGIKOOHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool LLMAMFCCNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool BNHHOCFOPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Color[] LNAHILHPFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private JKBKCKLFMCI type;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly JKBKCKLFMCI[] MLJKBCLBKLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[DAFFMLLPHJC("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly JKBKCKLFMCI[] BIABEALAIFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[DAFFMLLPHJC("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[DAFFMLLPHJC("type", JKBKCKLFMCI.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[DAFFMLLPHJC("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic JOHBMODBAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool BDNEPAIHEAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient NDIDCHCIKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8AFB10", Offset = "0x8AEF10", VA = "0x1808AFB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x76A7610", Offset = "0x76A6A10", VA = "0x1876A7610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JKBKCKLFMCI MKIIDBFDPBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA4C600", Offset = "0xA4BA00", VA = "0x180A4C600")]
			get
			{
				return default(JKBKCKLFMCI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x76A7790", Offset = "0x76A6B90", VA = "0x1876A7790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool NHFKGOMPKPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x76A7080", Offset = "0x76A6480", VA = "0x1876A7080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 OIBFFBMBJGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x76A7580", Offset = "0x76A6980", VA = "0x1876A7580")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x76A75C0", Offset = "0x76A69C0", VA = "0x1876A75C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool FNNKKBLALJI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x76A6A50", Offset = "0x76A5E50", VA = "0x1876A6A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 FNLFNIHOPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x76A75A0", Offset = "0x76A69A0", VA = "0x1876A75A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x76A7740", Offset = "0x76A6B40", VA = "0x1876A7740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float HDABJNEBHOB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xBBFE70", Offset = "0xBBF270", VA = "0x180BBFE70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1AA6300", Offset = "0x1AA5700", VA = "0x181AA6300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 NJIDJJJCJNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x76A6A00", Offset = "0x76A5E00", VA = "0x1876A6A00")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 AIDFGNOBONL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x76A6E70", Offset = "0x76A6270", VA = "0x1876A6E70")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float AEBFFEMNAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8C5D20", Offset = "0x8C5120", VA = "0x1808C5D20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x76A77A0", Offset = "0x76A6BA0", VA = "0x1876A77A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76A6EE0", Offset = "0x76A62E0", VA = "0x1876A6EE0", Slot = "12")]
		protected override void IJEFJIGEBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x76A6AC0", Offset = "0x76A5EC0", VA = "0x1876A6AC0")]
		private void EOEPODGGHDK(Color[] NBKFOKGKGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x76A5FF0", Offset = "0x76A53F0", VA = "0x1876A5FF0", Slot = "13")]
		protected override void BAKEPHNMAJI(Material LBOPCEJDNFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x76A6C50", Offset = "0x76A6050", VA = "0x1876A6C50", Slot = "14")]
		protected override void GOOKFPLDDCH(Material LBOPCEJDNFN, bool PNHMPKNFDBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x76A74D0", Offset = "0x76A68D0", VA = "0x1876A74D0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly FMIBBAEMPBG DIKACCAHGJM;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Sprite GDMCOHDNIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material INCGCIILLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material OMOMEKPGALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool EDFFIPEHBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool CACNKDGMABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool MIMHNDDCMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool FHMBLCHLKGL;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic JOHBMODBAJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader CAEADJIGGFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool BDNEPAIHEAK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool NHDNBCAFNGN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform IMPEIMBHGAL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x76A93C0", Offset = "0x76A87C0", VA = "0x1876A93C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect GCADPLJOECB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x76A92A0", Offset = "0x76A86A0", VA = "0x1876A92A0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite JCPMKEJIOCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x76A9730", Offset = "0x76A8B30", VA = "0x1876A9730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x76A8780", Offset = "0x76A7B80", VA = "0x1876A8780", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x76A9420", Offset = "0x76A8820", VA = "0x1876A9420", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x76A9720", Offset = "0x76A8B20", VA = "0x1876A9720", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x76A95D0", Offset = "0x76A89D0", VA = "0x1876A95D0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x76A89A0", Offset = "0x76A7DA0", VA = "0x1876A89A0")]
		private void CGOONBBBNKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x76A8D90", Offset = "0x76A8190", VA = "0x1876A8D90")]
		private void EHJIGEHNMDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x76A8970", Offset = "0x76A7D70", VA = "0x1876A8970")]
		private void CBLLMDAHNLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x76A9250", Offset = "0x76A8650", VA = "0x1876A9250")]
		private void GDMLMAOJNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76A8B30", Offset = "0x76A7F30", VA = "0x1876A8B30")]
		protected void DIAHKLMFBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x76A9910", Offset = "0x76A8D10", VA = "0x1876A9910")]
		private void POMPAJJMLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "12")]
		protected virtual void IJEFJIGEBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "13")]
		protected virtual void BAKEPHNMAJI(Material LBOPCEJDNFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "14")]
		protected virtual void GOOKFPLDDCH(Material LBOPCEJDNFN, bool PNHMPKNFDBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x76A8F00", Offset = "0x76A8300", VA = "0x1876A8F00")]
		private void FOLEJBIECOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		protected UIMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[AddComponentMenu("UI/Effects/Rings", 15)]
	[ExecuteAlways]
	public class UIRings : UIUberMaterialOverride
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct RingLayer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Range(0f, 2f)]
			[SerializeField]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int GLBLFECDMMC;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int PMKIMNMOPHE;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int FPEFGLBBGNO;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int JNBGLEGEHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private Color[] LNAHILHPFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private float[] IDHJNKDKKPD;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic JOHBMODBAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool NHDNBCAFNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> OFOAFAGBGDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 OIBFFBMBJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x76AA470", Offset = "0x76A9870", VA = "0x1876AA470")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x76AA490", Offset = "0x76A9890", VA = "0x1876AA490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76AA130", Offset = "0x76A9530", VA = "0x1876AA130")]
		public void SetRingLayers(IReadOnlyList<RingLayer> MEMAFGILCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x76A9EF0", Offset = "0x76A92F0", VA = "0x1876A9EF0")]
		public bool SetRingLayerColor(int NHDCAJADCDM, Color DFKHKPKCOFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x76AA040", Offset = "0x76A9440", VA = "0x1876AA040")]
		public bool SetRingLayerSize(int NHDCAJADCDM, float MFKKELONDCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76A9DB0", Offset = "0x76A91B0", VA = "0x1876A9DB0", Slot = "12")]
		protected override void IJEFJIGEBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x76A9BF0", Offset = "0x76A8FF0", VA = "0x1876A9BF0", Slot = "13")]
		protected override void BAKEPHNMAJI(Material LBOPCEJDNFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x76A9D60", Offset = "0x76A9160", VA = "0x1876A9D60", Slot = "14")]
		protected override void GOOKFPLDDCH(Material LBOPCEJDNFN, bool PNHMPKNFDBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x76AA280", Offset = "0x76A9680", VA = "0x1876AA280")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Tiler", 15)]
	public class UITiler : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public enum HJPLHHFHKHL
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int LLJPMLBPFJI;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int NJDBHKMLFLL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int LAOKLMOBNIJ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int GGPBCHBOLKI;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int GIGCDNKJAJF;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int JKFDICMACKK;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int APGKEJKDKMM;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int KKGGJAOIKNI;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int OEJIPMKMDON;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int BIKKIDPMLCG;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int JJKJMLOPEHE;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int MHHLLMODIHK;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int CMJGEFIGLJJ;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int EOJAPOJLKNK;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int EBCIDKIBCDM;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int MDGEFKHBAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("The offset applied to each alternating row or column.")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		[SerializeField]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private HJPLHHFHKHL animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[DAFFMLLPHJC("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[DAFFMLLPHJC("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic JOHBMODBAJM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool NHDNBCAFNGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite ONNGMGAHMMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x76AB290", Offset = "0x76AA690", VA = "0x1876AB290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x76AB4B0", Offset = "0x76AA8B0", VA = "0x1876AB4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color GJMCEJCOPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA4C630", Offset = "0xA4BA30", VA = "0x180A4C630")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x76AB540", Offset = "0x76AA940", VA = "0x1876AB540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color IGDMINODCBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xBD9C50", Offset = "0xBD9050", VA = "0x180BD9C50")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x76AB380", Offset = "0x76AA780", VA = "0x1876AB380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float JLDJKDEMJOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xBBFE80", Offset = "0xBBF280", VA = "0x180BBFE80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x76AB440", Offset = "0x76AA840", VA = "0x1876AB440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 PBBCJNILMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x76AB270", Offset = "0x76AA670", VA = "0x1876AB270")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x76AB460", Offset = "0x76AA860", VA = "0x1876AB460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float BLOODECNJKF
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8C5970", Offset = "0x8C4D70", VA = "0x1808C5970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x76AB400", Offset = "0x76AA800", VA = "0x1876AB400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 BDJBHOFIHEA
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xF985D0", Offset = "0xF979D0", VA = "0x180F985D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x76AB5C0", Offset = "0x76AA9C0", VA = "0x1876AB5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float ELIKJFCEGGN
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xBA9E90", Offset = "0xBA9290", VA = "0x180BA9E90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x76AB350", Offset = "0x76AA750", VA = "0x1876AB350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 EGEJGHCGNMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x76AABA0", Offset = "0x76A9FA0", VA = "0x1876AABA0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HJPLHHFHKHL EGNEGOFKKLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9D8000", Offset = "0x9D7400", VA = "0x1809D8000")]
			get
			{
				return default(HJPLHHFHKHL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x76AB370", Offset = "0x76AA770", VA = "0x1876AB370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float EKOIMPELHCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1099BE0", Offset = "0x1098FE0", VA = "0x181099BE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x76AB420", Offset = "0x76AA820", VA = "0x1876AB420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float JIEDPFBNHEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1099D30", Offset = "0x1099130", VA = "0x181099D30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x76AB330", Offset = "0x76AA730", VA = "0x1876AB330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x76AA4E0", Offset = "0x76A98E0", VA = "0x1876AA4E0", Slot = "13")]
		protected override void BAKEPHNMAJI(Material LBOPCEJDNFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x76AAC80", Offset = "0x76AA080", VA = "0x1876AAC80")]
		private void NCIFEFNEBIJ(Sprite PIFHNBDMPLN, [Out] Vector2 EIMMLKAKEAN, [Out] Vector2 KFCOIAAPFEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x76AAC30", Offset = "0x76AA030", VA = "0x1876AAC30", Slot = "14")]
		protected override void GOOKFPLDDCH(Material LBOPCEJDNFN, bool PNHMPKNFDBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x76AB1E0", Offset = "0x76AA5E0", VA = "0x1876AB1E0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Shader EOLMOILAGKF;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader CAEADJIGGFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x76AB660", Offset = "0x76AAA60", VA = "0x1876AB660", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76AB610", Offset = "0x76AAA10", VA = "0x1876AB610")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class RectTransformHideableAdapter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private SerializableRectTransform hiddenRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private SerializableRectTransform KMCKMCJNBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool FLMHKEBIBMN;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x76A5B30", Offset = "0x76A4F30", VA = "0x1876A5B30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x76A5E10", Offset = "0x76A5210", VA = "0x1876A5E10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x76A5CC0", Offset = "0x76A50C0", VA = "0x1876A5CC0")]
		private void GBPDNKMLGLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x76A5D40", Offset = "0x76A5140", VA = "0x1876A5D40")]
		private void LOAEKADIODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FMIBBAEMPBG
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct KCCPFMBFBLL : IEquatable<KCCPFMBFBLL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Component JCPOMHNJOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Action BOAHAEHNNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int LFCIGKGFBNG;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component PKLKHEINCJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x93EED0", Offset = "0x93E2D0", VA = "0x18093EED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x76A5AC0", Offset = "0x76A4EC0", VA = "0x1876A5AC0")]
		public KCCPFMBFBLL(Component JCPOMHNJOIE, Action BOAHAEHNNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76A59A0", Offset = "0x76A4DA0", VA = "0x1876A59A0")]
		public void DOPLNLJCLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x76A5A20", Offset = "0x76A4E20", VA = "0x1876A5A20", Slot = "4")]
		public bool Equals(KCCPFMBFBLL OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x76A5A30", Offset = "0x76A4E30", VA = "0x1876A5A30", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A91A0", Offset = "0x8A85A0", VA = "0x1808A91A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BHIGNIIPCMI : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FMIBBAEMPBG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public BHIGNIIPCMI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x76A3210", Offset = "0x76A2610", VA = "0x1876A3210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x76A35D0", Offset = "0x76A29D0", VA = "0x1876A35D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly BEGIGAMJKID IKCILLPFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int GMILJACEGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int PLOACJKMLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Func<Component, float> KCBJAEBOHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<Component, KCCPFMBFBLL> JDDKPDEKOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<KCCPFMBFBLL> OLDCCPBJOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly List<KCCPFMBFBLL> PCPLKJDPMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private GJOIDBBGEPO MOHHHCPMFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private OLDAHMACOMH JNMEFFLEILL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private OLDAHMACOMH PPMPIHEKIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x76A40A0", Offset = "0x76A34A0", VA = "0x1876A40A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x76A4660", Offset = "0x76A3A60", VA = "0x1876A4660")]
	public FMIBBAEMPBG(BEGIGAMJKID IKCILLPFALO, int GMILJACEGHL = -1, int PLOACJKMLAB = -1, [Optional] Func<Component, float> KCBJAEBOHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x76A43E0", Offset = "0x76A37E0", VA = "0x1876A43E0")]
	public void NDAIDFFOGLL(Component JCPOMHNJOIE, Action KFMKOKFLOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x76A3EB0", Offset = "0x76A32B0", VA = "0x1876A3EB0")]
	public void DKEIHIAIGFI(Component JCPOMHNJOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x76A4040", Offset = "0x76A3440", VA = "0x1876A4040")]
	public bool JLGJDBDHDOD(Component FCNHHPDOLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x76A41B0", Offset = "0x76A35B0", VA = "0x1876A41B0")]
	private void NCGJMCMLIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x76A3E30", Offset = "0x76A3230", VA = "0x1876A3E30")]
	[IteratorStateMachine(typeof(BHIGNIIPCMI))]
	private IEnumerator<BGFGBHFIDBJ> CDLFEPBMJDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x96D8A0", Offset = "0x96CCA0", VA = "0x18096D8A0")]
	[CompilerGenerated]
	private void DGHCOKFPPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x76A4130", Offset = "0x76A3530", VA = "0x1876A4130")]
	[CompilerGenerated]
	private float KNDOPCPJEAK(KCCPFMBFBLL KFMKOKFLOBK)
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
