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
				[Cpp2IlInjected.Address(RVA = "0x8EFC750", Offset = "0x8EFAD50", VA = "0x188EFC750")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8EFC7B0", Offset = "0x8EFADB0", VA = "0x188EFC7B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8EFC710", Offset = "0x8EFAD10", VA = "0x188EFC710")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC4E0", Offset = "0x8EFAAE0", VA = "0x188EFC4E0")]
			public void FKIJEEDFFDO(PointerEventData PPBEIMKEPLL, RectTransform GCEGDHOOKBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC250", Offset = "0x8EFA850", VA = "0x188EFC250")]
			public void DJOBAKFJCKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC5E0", Offset = "0x8EFABE0", VA = "0x188EFC5E0")]
			public void IHNIFPNDAKO(PointerEventData PPBEIMKEPLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8EFC6C0", Offset = "0x8EFACC0", VA = "0x188EFC6C0")]
			public void KFOHFGEMIII(float DBPJIAHHEKM, RectTransform GCEGDHOOKBO, Vector3 AEDFHMKGLON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly GJIKMKGBNOL<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly GJIKMKGBNOL<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly GJIKMKGBNOL<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly GJIKMKGBNOL<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly GJIKMKGBNOL<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HBPNKKOKOOA PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData ABMEGOPLHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool EDJDCKJFCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool FJPDNIKCFPB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OGHNONPGPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA99370", Offset = "0xA97970", VA = "0x180A99370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8EFBA60", Offset = "0x8EFA060", VA = "0x188EFBA60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool GLFAJNPNHLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA99430", Offset = "0xA97A30", VA = "0x180A99430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8EFBA90", Offset = "0x8EFA090", VA = "0x188EFBA90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB9E0", Offset = "0x8EF9FE0", VA = "0x188EFB9E0")]
		private bool GLLJDLGFFJM(PointerEventData KJOIOABMAMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBF10", Offset = "0x8EFA510", VA = "0x188EFBF10", Slot = "5")]
		public void OnPointerDown(PointerEventData KJOIOABMAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBFD0", Offset = "0x8EFA5D0", VA = "0x188EFBFD0", Slot = "11")]
		public void OnPointerUp(PointerEventData KJOIOABMAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBD80", Offset = "0x8EFA380", VA = "0x188EFBD80", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData KJOIOABMAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBAC0", Offset = "0x8EFA0C0", VA = "0x188EFBAC0", Slot = "7")]
		public void OnBeginDrag(PointerEventData KJOIOABMAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBBD0", Offset = "0x8EFA1D0", VA = "0x188EFBBD0", Slot = "4")]
		public void OnDrag(PointerEventData KJOIOABMAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBCB0", Offset = "0x8EFA2B0", VA = "0x188EFBCB0", Slot = "8")]
		public void OnEndDrag(PointerEventData KJOIOABMAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBF70", Offset = "0x8EFA570", VA = "0x188EFBF70", Slot = "9")]
		public void OnPointerEnter(PointerEventData KJOIOABMAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBFA0", Offset = "0x8EFA5A0", VA = "0x188EFBFA0", Slot = "10")]
		public void OnPointerExit(PointerEventData KJOIOABMAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFBB90", Offset = "0x8EFA190", VA = "0x188EFBB90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC030", Offset = "0x8EFA630", VA = "0x188EFC030")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EF7130", Offset = "0x8EF5730", VA = "0x188EF7130")]
		public void SetCanvasSortingOrder(short OGFNFILHJOI, bool BEECAIMBLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData EOGIGBMHICA;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8EF73F0", Offset = "0x8EF59F0", VA = "0x188EF73F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8EF72D0", Offset = "0x8EF58D0", VA = "0x188EF72D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7220", Offset = "0x8EF5820", VA = "0x188EF7220")]
		private void NCILMAJCBOF(GameObject CCIBKGLDHBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8EF76D0", Offset = "0x8EF5CD0", VA = "0x188EF76D0")]
		public void SetOptionsWithNoDefault(List<string> DMJEPOICLBJ, [Optional] string GKCJMEDCDME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF75E0", Offset = "0x8EF5BE0", VA = "0x188EF75E0")]
		public void SetOptionsWithNoDefault(List<OptionData> EEPOAHLOJPI, [Optional] string GKCJMEDCDME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7510", Offset = "0x8EF5B10", VA = "0x188EF7510", Slot = "44")]
		public override void OnPointerClick(PointerEventData KJOIOABMAMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "47")]
		protected override GameObject CreateBlocker(Canvas IPNFFPNACBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7900", Offset = "0x8EF5F00", VA = "0x188EF7900")]
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
		private sealed class MLFHOKCLHLJ : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private BJJPNELKDDJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
			[DebuggerHidden]
			public MLFHOKCLHLJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9780", Offset = "0x8EF7D80", VA = "0x188EF9780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8EF9C90", Offset = "0x8EF8290", VA = "0x188EF9C90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[MKKFIBEOMHP(BMGFACECMPD.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly JNGCNCIAPNN<object> KMNDPGOLBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool MBPFDIEDEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? AKDCDDEJCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? GIGFLECGPFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? BAOAGLDCIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool LNKLGMODDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool ENMGFPMOOED;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MCIOLEPOCMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8AF0", Offset = "0x8EF70F0", VA = "0x188EF8AF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ADGPBDFKEMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8AA0", Offset = "0x8EF70A0", VA = "0x188EF8AA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ILADMCEOMKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAE2340", Offset = "0xAE0940", VA = "0x180AE2340")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8CB0", Offset = "0x8EF72B0", VA = "0x188EF8CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LIICHIEHDOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8A00", Offset = "0x8EF7000", VA = "0x188EF8A00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8EF8C10", Offset = "0x8EF7210", VA = "0x188EF8C10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8440", Offset = "0x8EF6A40", VA = "0x188EF8440")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF87E0", Offset = "0x8EF6DE0", VA = "0x188EF87E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8790", Offset = "0x8EF6D90", VA = "0x188EF8790")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8780", Offset = "0x8EF6D80", VA = "0x188EF8780")]
		public void Hide(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8960", Offset = "0x8EF6F60", VA = "0x188EF8960")]
		public void Show(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8870", Offset = "0x8EF6E70", VA = "0x188EF8870")]
		public void Set(object HNGIMMGBLII, bool EGHPHHOMKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8EF84D0", Offset = "0x8EF6AD0", VA = "0x188EF84D0")]
		public void Clear(bool MBMDAJJAEPC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8580", Offset = "0x8EF6B80", VA = "0x188EF8580")]
		private void FOFIENKJBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8700", Offset = "0x8EF6D00", VA = "0x188EF8700")]
		[IteratorStateMachine(typeof(MLFHOKCLHLJ))]
		private IEnumerator<BJJPNELKDDJ> GHBKLPLODNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8540", Offset = "0x8EF6B40", VA = "0x188EF8540", Slot = "5")]
		public virtual void DoHideOrShow(bool ECDBJCDCKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8970", Offset = "0x8EF6F70", VA = "0x188EF8970")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GAENIIMMICK
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum DOGCEILCEIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static DPBIGCAOGIB PNIGMJDGOJO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static DPBIGCAOGIB ABFNBJMMDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7A80", Offset = "0x8EF6080", VA = "0x188EF7A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static DOGCEILCEIH CKPGJPNKBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7950", Offset = "0x8EF5F50", VA = "0x188EF7950")]
		get
		{
			return default(DOGCEILCEIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7C60", Offset = "0x8EF6260", VA = "0x188EF7C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<DOGCEILCEIH> PPOAHEGMIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7B80", Offset = "0x8EF6180", VA = "0x188EF7B80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7DC0", Offset = "0x8EF63C0", VA = "0x188EF7DC0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LDBHDHMBJHO : NIBGPIIHHEB, BFJHBKLHGAO, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, ICCEDHKANLE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HBPNKKOKOOA AMFOEIMIJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BCEMNDENGIG Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject EEGMKGNBEOE);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BCEMNDENGIG Spawn<T>(int IJHMFMGBDAK, IReadOnlyList<T> DAJAOHIJHHL, GameObject EEGMKGNBEOE);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BCEMNDENGIG Spawn<T>(int IJHMFMGBDAK, IReadOnlyList<T> DAJAOHIJHHL, GameObject JEPOPKBDELI, Func<int, GameObject> NEDDMENGFOF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int LEPAEEGOBDO, float IEGAKHALIML);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum DOEAMEOEDOH : byte
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
		private static readonly int LPCIGJJHKHM;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<DOEAMEOEDOH, string> ANJHMDAMDOO;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int PDIPICDJLHL = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int DLINKAGPGDO;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int OEHACDEJEEG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int BOAGFOKBJPD;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int CFENOFMBIEF;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int NCHEOILHPCM;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int IOIIHNAAKPE;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int BJKAKMBGICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool CDNBPJGBFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool GLOIGLABPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] JEHHGJDNCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private DOEAMEOEDOH type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly DOEAMEOEDOH[] FPHKEPOFFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[EDABEGGGMLM("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly DOEAMEOEDOH[] OKFCLNIKGAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[EDABEGGGMLM("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[EDABEGGGMLM("type", DOEAMEOEDOH.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[EDABEGGGMLM("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic LKNGJMCKPIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool NLECFFDEIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient OGMJLFCFFNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB830", Offset = "0x8EF9E30", VA = "0x188EFB830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DOEAMEOEDOH MONFNOPPPGA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xB19EF0", Offset = "0xB184F0", VA = "0x180B19EF0")]
			get
			{
				return default(DOEAMEOEDOH);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB9B0", Offset = "0x8EF9FB0", VA = "0x188EFB9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool HBNBMPPMLIN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB010", Offset = "0x8EF9610", VA = "0x188EFB010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 LLIBJLCEILF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB7A0", Offset = "0x8EF9DA0", VA = "0x188EFB7A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB7E0", Offset = "0x8EF9DE0", VA = "0x188EFB7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool GDAFJIBIAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8EFAC70", Offset = "0x8EF9270", VA = "0x188EFAC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 PFMPFEHANLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB7C0", Offset = "0x8EF9DC0", VA = "0x188EFB7C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB960", Offset = "0x8EF9F60", VA = "0x188EFB960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KKKOGEHFCDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xE14FE0", Offset = "0xE135E0", VA = "0x180E14FE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x252DE40", Offset = "0x252C440", VA = "0x18252DE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 IGHGOADEOBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB2A0", Offset = "0x8EF98A0", VA = "0x188EFB2A0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 MMGGLDKDIMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8EFA1B0", Offset = "0x8EF87B0", VA = "0x188EFA1B0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float CEBNBKGGGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB0990", Offset = "0xAAEF90", VA = "0x180AB0990")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8EFB9C0", Offset = "0x8EF9FC0", VA = "0x188EFB9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8EFACE0", Offset = "0x8EF92E0", VA = "0x188EFACE0", Slot = "12")]
		protected override void JMLGBKKAFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8EFAE80", Offset = "0x8EF9480", VA = "0x188EFAE80")]
		private void KDMKFJCBAIA(Color[] IEHJJOOMFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFA220", Offset = "0x8EF8820", VA = "0x188EFA220", Slot = "13")]
		protected override void DLJNLDCJCOJ(Material JKDFAJLFBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB080", Offset = "0x8EF9680", VA = "0x188EFB080", Slot = "14")]
		protected override void NNAMPIKIAMO(Material JKDFAJLFBEL, bool ANBCINBEIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFB6F0", Offset = "0x8EF9CF0", VA = "0x188EFB6F0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly KMHDMGNDLPO CGJCBHLGGKN;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite APANJDIKLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material FNOMJBKOGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material BHCKBGCCDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool KCPHKMGELAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool MBPFDIEDEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool DBIPOLJKNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool GFIFHOGLNDE;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic LKNGJMCKPIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader MJMGFIOKHBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool NLECFFDEIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool ELOCHFCJHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform GCEGDHOOKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8EFD740", Offset = "0x8EFBD40", VA = "0x188EFD740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect OLAHLHOFLOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8EFD4E0", Offset = "0x8EFBAE0", VA = "0x188EFD4E0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite DPCFCFMHKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8EFCF10", Offset = "0x8EFB510", VA = "0x188EFCF10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8EFC9A0", Offset = "0x8EFAFA0", VA = "0x188EFC9A0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD930", Offset = "0x8EFBF30", VA = "0x188EFD930", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDC30", Offset = "0x8EFC230", VA = "0x188EFDC30", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDAE0", Offset = "0x8EFC0E0", VA = "0x188EFDAE0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD7A0", Offset = "0x8EFBDA0", VA = "0x188EFD7A0")]
		private void OACCIJFAMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD370", Offset = "0x8EFB970", VA = "0x188EFD370")]
		private void MCFFKINCONL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCB90", Offset = "0x8EFB190", VA = "0x188EFCB90")]
		private void BLHCBKNCLOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDC40", Offset = "0x8EFC240", VA = "0x188EFDC40")]
		private void PDACBJAGFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD100", Offset = "0x8EFB700", VA = "0x188EFD100")]
		protected void GMOHCMKCFDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFD600", Offset = "0x8EFBC00", VA = "0x188EFD600")]
		private void NDOBHFKHHNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "12")]
		protected virtual void JMLGBKKAFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "13")]
		protected virtual void DLJNLDCJCOJ(Material JKDFAJLFBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "14")]
		protected virtual void NNAMPIKIAMO(Material JKDFAJLFBEL, bool ANBCINBEIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8EFCBC0", Offset = "0x8EFB1C0", VA = "0x188EFCBC0")]
		private void FFHDPIIACIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
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
		private static readonly int PIPGGIPOIPI;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int KEDFBHIMHHK;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int LPGILLBBLEN;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int CKOLBDEEIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
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
		private Color[] JEHHGJDNCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] CIPFKDDLADI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic LKNGJMCKPIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool ELOCHFCJHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> AOPNMBBCFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA95060", Offset = "0xA93660", VA = "0x180A95060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 LLIBJLCEILF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF049A0", Offset = "0xF02FA0", VA = "0x180F049A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8EFE750", Offset = "0x8EFCD50", VA = "0x188EFE750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE390", Offset = "0x8EFC990", VA = "0x188EFE390")]
		public void SetRingLayers(IReadOnlyList<RingLayer> PIDMFBHCLGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE150", Offset = "0x8EFC750", VA = "0x188EFE150")]
		public bool SetRingLayerColor(int CGCOAIEEKKE, Color ONDGBPEOGJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE2A0", Offset = "0x8EFC8A0", VA = "0x188EFE2A0")]
		public bool SetRingLayerSize(int CGCOAIEEKKE, float MLMBLBFOLPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDFC0", Offset = "0x8EFC5C0", VA = "0x188EFDFC0", Slot = "12")]
		protected override void JMLGBKKAFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFDE40", Offset = "0x8EFC440", VA = "0x188EFDE40", Slot = "13")]
		protected override void DLJNLDCJCOJ(Material JKDFAJLFBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE100", Offset = "0x8EFC700", VA = "0x188EFE100", Slot = "14")]
		protected override void NNAMPIKIAMO(Material JKDFAJLFBEL, bool ANBCINBEIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE4E0", Offset = "0x8EFCAE0", VA = "0x188EFE4E0")]
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
		public enum CGCCCCNBNPL
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int EONCFJOEFPK;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int OJMNIFBHLKJ;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int LEEHPJGEEMN;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int MFKLGHHANDO;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int MACNHOIFKMI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int GOIEEEGPOCA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int NPHOJAEGKNB;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int BPBOBNLHFBE;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int BNIFPOJGAFB;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int IAKMBEGBDPK;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int ACAOICGLBOB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ICCBLAOJCCB;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int GCFPKGFENII;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int ELDJLCPODMI;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int KHNDLALJIGP;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int GHMCKIMNLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[HPOJEGADLAJ(BMGFACECMPD.Self, false, false, false)]
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
		private CGCCCCNBNPL animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[EDABEGGGMLM("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[EDABEGGGMLM("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic LKNGJMCKPIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool ELOCHFCJHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite GNIBBDANPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF5A0", Offset = "0x8EFDBA0", VA = "0x188EFF5A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF7C0", Offset = "0x8EFDDC0", VA = "0x188EFF7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color DNALIMPPANO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x106F980", Offset = "0x106DF80", VA = "0x18106F980")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF850", Offset = "0x8EFDE50", VA = "0x188EFF850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color MDHDJFFDKGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x129FD30", Offset = "0x129E330", VA = "0x18129FD30")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF690", Offset = "0x8EFDC90", VA = "0x188EFF690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float BAMMBELBEAE
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xE15B30", Offset = "0xE14130", VA = "0x180E15B30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF750", Offset = "0x8EFDD50", VA = "0x188EFF750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 MGJBCLGKEKL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2A0E0A0", Offset = "0x2A0C6A0", VA = "0x182A0E0A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF770", Offset = "0x8EFDD70", VA = "0x188EFF770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float IDBKJPJKELN
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAB05D0", Offset = "0xAAEBD0", VA = "0x180AB05D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF710", Offset = "0x8EFDD10", VA = "0x188EFF710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 NMGPFPNENEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x17D2F70", Offset = "0x17D1570", VA = "0x1817D2F70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF8D0", Offset = "0x8EFDED0", VA = "0x188EFF8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float IKBMLMHJCNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x12783F0", Offset = "0x12769F0", VA = "0x1812783F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF660", Offset = "0x8EFDC60", VA = "0x188EFF660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 IDCHDLDPIJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8EFE7A0", Offset = "0x8EFCDA0", VA = "0x188EFE7A0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public CGCCCCNBNPL GPGAALKKBDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB19E70", Offset = "0xB18470", VA = "0x180B19E70")]
			get
			{
				return default(CGCCCCNBNPL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF680", Offset = "0x8EFDC80", VA = "0x188EFF680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float OMADLILJIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x19825E0", Offset = "0x1980BE0", VA = "0x1819825E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF730", Offset = "0x8EFDD30", VA = "0x188EFF730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float PKJIEGGONNG
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xF28460", Offset = "0xF26A60", VA = "0x180F28460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF640", Offset = "0x8EFDC40", VA = "0x188EFF640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8EFE830", Offset = "0x8EFCE30", VA = "0x188EFE830", Slot = "13")]
		protected override void DLJNLDCJCOJ(Material JKDFAJLFBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8EFEF30", Offset = "0x8EFD530", VA = "0x188EFEF30")]
		private void HDONGNFMLBE(Sprite LEKCEIIOPND, [Out] Vector2 IMNBEMGEFEA, [Out] Vector2 JBBHCMNKHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF1E0", Offset = "0x8EFD7E0", VA = "0x188EFF1E0", Slot = "14")]
		protected override void NNAMPIKIAMO(Material JKDFAJLFBEL, bool ANBCINBEIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF510", Offset = "0x8EFDB10", VA = "0x188EFF510")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader COFOJJMJIFN;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader MJMGFIOKHBN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8EFF970", Offset = "0x8EFDF70", VA = "0x188EFF970", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8EFF920", Offset = "0x8EFDF20", VA = "0x188EFF920")]
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
		private SerializableRectTransform HOEOGOIPMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool PIBINMDOIIB;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9CE0", Offset = "0x8EF82E0", VA = "0x188EF9CE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9FC0", Offset = "0x8EF85C0", VA = "0x188EF9FC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9F40", Offset = "0x8EF8540", VA = "0x188EF9F40")]
		private void OIPFPOAEDND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9E70", Offset = "0x8EF8470", VA = "0x188EF9E70")]
		private void FOFIENKJBAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KMHDMGNDLPO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct GOKFFGGNLNE : IEquatable<GOKFFGGNLNE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component HHPFOCCGJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action BPPHMBOBPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int FPDHJECJHPE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component AEJAJAHGPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8EF83D0", Offset = "0x8EF69D0", VA = "0x188EF83D0")]
		public GOKFFGGNLNE(Component HHPFOCCGJIF, Action BPPHMBOBPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8350", Offset = "0x8EF6950", VA = "0x188EF8350")]
		public void MGDMFNNFPNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8340", Offset = "0x8EF6940", VA = "0x188EF8340", Slot = "4")]
		public bool Equals(GOKFFGGNLNE IBCMCOKAJEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8EF82B0", Offset = "0x8EF68B0", VA = "0x188EF82B0", Slot = "0")]
		public override bool Equals(object NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA94180", Offset = "0xA92780", VA = "0x180A94180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class GEDOENJPJGE : IEnumerator<BJJPNELKDDJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private BJJPNELKDDJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KMHDMGNDLPO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private BJJPNELKDDJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA94480", Offset = "0xA92A80", VA = "0x180A94480")]
		[DebuggerHidden]
		public GEDOENJPJGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8EF7EA0", Offset = "0x8EF64A0", VA = "0x188EF7EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8EF8260", Offset = "0x8EF6860", VA = "0x188EF8260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FBGHAEGJECI PMIIIDHPIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int JCIBLJHILEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int INFGMCNDMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> GGLEHPDBDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, GOKFFGGNLNE> PBFKPJHFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<GOKFFGGNLNE> FMMLGCOECOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<GOKFFGGNLNE> LBIBOBDIDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private APLPOCKIJEJ LLAOEMKKADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private PPFLMJMMFMJ BFIAAGCICAO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private PPFLMJMMFMJ LFNFIBOPBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8EF9190", Offset = "0x8EF7790", VA = "0x188EF9190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8EF9600", Offset = "0x8EF7C00", VA = "0x188EF9600")]
	public KMHDMGNDLPO(FBGHAEGJECI PMIIIDHPIAD, int JCIBLJHILEF = -1, int INFGMCNDMHF = -1, [Optional] Func<Component, float> GGLEHPDBDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8EF92A0", Offset = "0x8EF78A0", VA = "0x188EF92A0")]
	public void MPNPFOJADMJ(Component HHPFOCCGJIF, Action DCPFGDLGCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8EF8DD0", Offset = "0x8EF73D0", VA = "0x188EF8DD0")]
	public void GDHJPJCHDNJ(Component HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8EF9520", Offset = "0x8EF7B20", VA = "0x188EF9520")]
	public bool NGACMINEPNI(Component OFJDOOOKCLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8EF8F60", Offset = "0x8EF7560", VA = "0x188EF8F60")]
	private void GHIPIGDIJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8EF9580", Offset = "0x8EF7B80", VA = "0x188EF9580")]
	[IteratorStateMachine(typeof(GEDOENJPJGE))]
	private IEnumerator<BJJPNELKDDJ> NHICCEFFELG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xF6AD60", Offset = "0xF69360", VA = "0x180F6AD60")]
	[CompilerGenerated]
	private void BBNKLPAIHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8EF9220", Offset = "0x8EF7820", VA = "0x188EF9220")]
	[CompilerGenerated]
	private float MDCAPLHFIJB(GOKFFGGNLNE DCPFGDLGCCM)
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
