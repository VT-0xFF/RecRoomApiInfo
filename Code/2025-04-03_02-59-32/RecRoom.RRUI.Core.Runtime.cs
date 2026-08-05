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
				[Cpp2IlInjected.Address(RVA = "0x82324B0", Offset = "0x82318B0", VA = "0x1882324B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8232510", Offset = "0x8231910", VA = "0x188232510")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8232470", Offset = "0x8231870", VA = "0x188232470")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8232290", Offset = "0x8231690", VA = "0x188232290")]
			public void MCNEKFLHCLJ(PointerEventData DKMCIBPKHKI, RectTransform NNFJNDMJJFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8231FB0", Offset = "0x82313B0", VA = "0x188231FB0")]
			public void HGINGMDPIFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8232390", Offset = "0x8231790", VA = "0x188232390")]
			public void MGOOKLPGNLH(PointerEventData DKMCIBPKHKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8232240", Offset = "0x8231640", VA = "0x188232240")]
			public void KPAJLJMDBBJ(float LECPBPKMNCJ, RectTransform NNFJNDMJJFG, Vector3 MABKBAPDDLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly GLDBGNIANKN<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly GLDBGNIANKN<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly GLDBGNIANKN<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly GLDBGNIANKN<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly GLDBGNIANKN<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly OPNNLJDPBAB PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData ILOOGFKEMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool OFHHLNHNJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool IIBFLOKCHJJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool NNBPOOMDMOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x994380", Offset = "0x993780", VA = "0x180994380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x82317F0", Offset = "0x8230BF0", VA = "0x1882317F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MNGDAAFIACK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x994350", Offset = "0x993750", VA = "0x180994350")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8231740", Offset = "0x8230B40", VA = "0x188231740")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8231770", Offset = "0x8230B70", VA = "0x188231770")]
		private bool HPKMEFCEAOI(PointerEventData JOKKIDPHPDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8231C70", Offset = "0x8231070", VA = "0x188231C70", Slot = "5")]
		public void OnPointerDown(PointerEventData JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8231D30", Offset = "0x8231130", VA = "0x188231D30", Slot = "11")]
		public void OnPointerUp(PointerEventData JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8231AE0", Offset = "0x8230EE0", VA = "0x188231AE0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8231820", Offset = "0x8230C20", VA = "0x188231820", Slot = "7")]
		public void OnBeginDrag(PointerEventData JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8231930", Offset = "0x8230D30", VA = "0x188231930", Slot = "4")]
		public void OnDrag(PointerEventData JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8231A10", Offset = "0x8230E10", VA = "0x188231A10", Slot = "8")]
		public void OnEndDrag(PointerEventData JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8231CD0", Offset = "0x82310D0", VA = "0x188231CD0", Slot = "9")]
		public void OnPointerEnter(PointerEventData JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8231D00", Offset = "0x8231100", VA = "0x188231D00", Slot = "10")]
		public void OnPointerExit(PointerEventData JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82318F0", Offset = "0x8230CF0", VA = "0x1882318F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8231D90", Offset = "0x8231190", VA = "0x188231D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x822D3E0", Offset = "0x822C7E0", VA = "0x18822D3E0")]
		public void SetCanvasSortingOrder(short FOLNLGICJKH, bool IALABOJGAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData HAGEJIKLLFE;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x822D6A0", Offset = "0x822CAA0", VA = "0x18822D6A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x822D580", Offset = "0x822C980", VA = "0x18822D580", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x822D4D0", Offset = "0x822C8D0", VA = "0x18822D4D0")]
		private void EGOGDPNMDEE(GameObject HICEHEJMMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x822D980", Offset = "0x822CD80", VA = "0x18822D980")]
		public void SetOptionsWithNoDefault(List<string> JGMAGBDHLIF, [Optional] string HKKELFFMCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x822D890", Offset = "0x822CC90", VA = "0x18822D890")]
		public void SetOptionsWithNoDefault(List<OptionData> FBCMGOKFCPJ, [Optional] string HKKELFFMCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x822D7C0", Offset = "0x822CBC0", VA = "0x18822D7C0", Slot = "42")]
		public override void OnPointerClick(PointerEventData JOKKIDPHPDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x996AF0", Offset = "0x995EF0", VA = "0x180996AF0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas IHLFANPLLAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x822DBB0", Offset = "0x822CFB0", VA = "0x18822DBB0")]
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
		private sealed class BBGGNJIEMKE : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private CIKDDGFOAFI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
			[DebuggerHidden]
			public BBGGNJIEMKE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x822CE80", Offset = "0x822C280", VA = "0x18822CE80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x822D390", Offset = "0x822C790", VA = "0x18822D390", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[IDNFDPCBAID(GKKLJNPNNON.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly JLKGKCGBFEF<object> LAFLLFFPLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool EKJHAGBNPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? NDLDGKJCADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? KADGELKGJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? JHFBMNDIGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool JDFFCNFPMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool CFOKPLPHGMM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool MMALPGJLJAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x822EE00", Offset = "0x822E200", VA = "0x18822EE00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IEEGJBNBHKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x822EDB0", Offset = "0x822E1B0", VA = "0x18822EDB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool NNHJBEHPOPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9E03C0", Offset = "0x9DF7C0", VA = "0x1809E03C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x822EFC0", Offset = "0x822E3C0", VA = "0x18822EFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action KKINKLIOBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x822ED10", Offset = "0x822E110", VA = "0x18822ED10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x822EF20", Offset = "0x822E320", VA = "0x18822EF20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x822E750", Offset = "0x822DB50", VA = "0x18822E750")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x822EAF0", Offset = "0x822DEF0", VA = "0x18822EAF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x822EAA0", Offset = "0x822DEA0", VA = "0x18822EAA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x822E890", Offset = "0x822DC90", VA = "0x18822E890")]
		public void Hide(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x822EC70", Offset = "0x822E070", VA = "0x18822EC70")]
		public void Show(object HHGPJKKLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x822EB80", Offset = "0x822DF80", VA = "0x18822EB80")]
		public void Set(object HHGPJKKLNIG, bool DMOKELENHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x822E7E0", Offset = "0x822DBE0", VA = "0x18822E7E0")]
		public void Clear(bool DIOPEOPCDON = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x822E8A0", Offset = "0x822DCA0", VA = "0x18822E8A0")]
		private void JMFBBFMHGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x822EA20", Offset = "0x822DE20", VA = "0x18822EA20")]
		[IteratorStateMachine(typeof(BBGGNJIEMKE))]
		private IEnumerator<CIKDDGFOAFI> LLILHBLCHDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x822E850", Offset = "0x822DC50", VA = "0x18822E850", Slot = "5")]
		public virtual void DoHideOrShow(bool KDLOAMNAMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x822EC80", Offset = "0x822E080", VA = "0x18822EC80")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OAIGPMCIJND
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum OCINNDMFEGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static IFCCBFAGEOA EKGONNDJFLP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static IFCCBFAGEOA PAGCFMDAEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x822F620", Offset = "0x822EA20", VA = "0x18822F620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static OCINNDMFEGI CBPKDEIMBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x822F4F0", Offset = "0x822E8F0", VA = "0x18822F4F0")]
		get
		{
			return default(OCINNDMFEGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x822F800", Offset = "0x822EC00", VA = "0x18822F800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<OCINNDMFEGI> HKBMICGKLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x822F960", Offset = "0x822ED60", VA = "0x18822F960")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x822F720", Offset = "0x822EB20", VA = "0x18822F720")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JNJHEIEMMCN : KEEKMGCJJIH, JAFEBBPCMMF, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, DALLDODCIBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	OPNNLJDPBAB JMEOFADIBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NAHOFKDLLJE Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject BKMONPLIHMM);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NAHOFKDLLJE Spawn<T>(int CPNBBLADMLB, IReadOnlyList<T> HPMNBNLACCC, GameObject BKMONPLIHMM);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NAHOFKDLLJE Spawn<T>(int CPNBBLADMLB, IReadOnlyList<T> HPMNBNLACCC, GameObject FJNNFGJMDMC, Func<int, GameObject> KBGIKELKIMK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int CJFNAFNJJLB, float OGAKGILIPNO);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum ACMGCFBGENB : byte
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
		private static readonly int NPIFKFAAPEI;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<ACMGCFBGENB, string> LLBIBBBJAMK;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int OIGALMOKBCM = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int IILFMADNMPK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int PAPLBOICOAK;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int JAKIELMGGNN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int DEJPAJMJDJB;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int GACDKMNDGCL;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int JGHBJGKLHAH;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int HIOIHCCPPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool LMKOGJBEHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool FDPINNOMPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] CNEILJCNDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private ACMGCFBGENB type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly ACMGCFBGENB[] FFKHOGGFJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[GEDEHNCPDHB("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly ACMGCFBGENB[] JANIJHBCAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[GEDEHNCPDHB("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[GEDEHNCPDHB("type", ACMGCFBGENB.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[GEDEHNCPDHB("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic EDGBLPHAMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool CANABJPEJFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient KOKDKEJOGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9943C0", Offset = "0x9937C0", VA = "0x1809943C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8231590", Offset = "0x8230990", VA = "0x188231590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ACMGCFBGENB KAFGKIIBACB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xBBC590", Offset = "0xBBB990", VA = "0x180BBC590")]
			get
			{
				return default(ACMGCFBGENB);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8231710", Offset = "0x8230B10", VA = "0x188231710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool NGNKMIKKHAN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8230D90", Offset = "0x8230190", VA = "0x188230D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 MOBLDDDLJAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8231500", Offset = "0x8230900", VA = "0x188231500")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8231540", Offset = "0x8230940", VA = "0x188231540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool GFJELGOCFFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8230D20", Offset = "0x8230120", VA = "0x188230D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 KLLLKPKKICE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8231520", Offset = "0x8230920", VA = "0x188231520")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x82316C0", Offset = "0x8230AC0", VA = "0x1882316C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NCGIGJOKOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xBE35E0", Offset = "0xBE29E0", VA = "0x180BE35E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2061FB0", Offset = "0x20613B0", VA = "0x182061FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 FGDFILPOFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8231000", Offset = "0x8230400", VA = "0x188231000")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 PJHOJGAOILI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8230E00", Offset = "0x8230200", VA = "0x188230E00")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float MCJHOABNIDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9AFA50", Offset = "0x9AEE50", VA = "0x1809AFA50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8231720", Offset = "0x8230B20", VA = "0x188231720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8230960", Offset = "0x822FD60", VA = "0x188230960", Slot = "12")]
		protected override void HBPFLFECGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8230E70", Offset = "0x8230270", VA = "0x188230E70")]
		private void ODACDOIOLAH(Color[] HJBAPDAJDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x822FF10", Offset = "0x822F310", VA = "0x18822FF10", Slot = "13")]
		protected override void GOGNGFKEFLO(Material ANOGJJADLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8230B00", Offset = "0x822FF00", VA = "0x188230B00", Slot = "14")]
		protected override void HGEGNKDNCHG(Material ANOGJJADLNE, bool CGAPLHFOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8231450", Offset = "0x8230850", VA = "0x188231450")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly GNABPNCFKDO HJDHADLBODD;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite HJKFGIMCNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material ALBJIGAABED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material DILEJOPAIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool LJKJMKEEDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool EKJHAGBNPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool OAKKEAIHLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool MIHFKJDBOJL;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic EDGBLPHAMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader DNFPLNCINND
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool CANABJPEJFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool PPGNLEOICOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform NNFJNDMJJFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8232A80", Offset = "0x8231E80", VA = "0x188232A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect GJEPFGHDPCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8233420", Offset = "0x8232820", VA = "0x188233420")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite BEAPOMKJKOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8232C70", Offset = "0x8232070", VA = "0x188232C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8232750", Offset = "0x8231B50", VA = "0x188232750", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x82336E0", Offset = "0x8232AE0", VA = "0x1882336E0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x82339E0", Offset = "0x8232DE0", VA = "0x1882339E0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8233890", Offset = "0x8232C90", VA = "0x188233890", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8232AE0", Offset = "0x8231EE0", VA = "0x188232AE0")]
		private void DIDCEFPPJKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8233570", Offset = "0x8232970", VA = "0x188233570")]
		private void NEPIKKNADID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8233540", Offset = "0x8232940", VA = "0x188233540")]
		private void KIIFCGKJFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8232700", Offset = "0x8231B00", VA = "0x188232700")]
		private void AOAFKFGNGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82331B0", Offset = "0x82325B0", VA = "0x1882331B0")]
		protected void IFCAGEOBMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8232940", Offset = "0x8231D40", VA = "0x188232940")]
		private void BGEBPFEJJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "12")]
		protected virtual void HBPFLFECGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "13")]
		protected virtual void GOGNGFKEFLO(Material ANOGJJADLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "14")]
		protected virtual void HGEGNKDNCHG(Material ANOGJJADLNE, bool CGAPLHFOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8232E60", Offset = "0x8232260", VA = "0x188232E60")]
		private void HDLJAANKNKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
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
		private static readonly int EOPNDMEMJFC;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int ADLCHIGNFGB;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int EEICFLDOKIA;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int EFMEJOGNGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
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
		private Color[] CNEILJCNDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] PHHGNJKONNP;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic EDGBLPHAMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool PPGNLEOICOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> ECCCGGJLMIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 MOBLDDDLJAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x82344F0", Offset = "0x82338F0", VA = "0x1882344F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8234510", Offset = "0x8233910", VA = "0x188234510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x82340F0", Offset = "0x82334F0", VA = "0x1882340F0")]
		public void SetRingLayers(IReadOnlyList<RingLayer> BLPEOKAMLDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8233EB0", Offset = "0x82332B0", VA = "0x188233EB0")]
		public bool SetRingLayerColor(int DMGLPHIJGLL, Color ODFBFMBMBOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8234000", Offset = "0x8233400", VA = "0x188234000")]
		public bool SetRingLayerSize(int DMGLPHIJGLL, float MNDMOIHIBEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8233D20", Offset = "0x8233120", VA = "0x188233D20", Slot = "12")]
		protected override void HBPFLFECGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8233BA0", Offset = "0x8232FA0", VA = "0x188233BA0", Slot = "13")]
		protected override void GOGNGFKEFLO(Material ANOGJJADLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8233E60", Offset = "0x8233260", VA = "0x188233E60", Slot = "14")]
		protected override void HGEGNKDNCHG(Material ANOGJJADLNE, bool CGAPLHFOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8234240", Offset = "0x8233640", VA = "0x188234240")]
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
		public enum DODPFPFNHPN
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int PEELGIKGIPO;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int AMIKLPIHHOA;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int LMOJBJNDDKJ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int NLGAMLJNOIC;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int OCFFFOKHCFP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int EMJIIIMFLMG;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int GNJJMLFDMBF;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int BHIIOLJBMHD;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int OGGHKIHFHNH;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int OENGDNECJLO;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int KCLBBDLDJOB;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ABCICNFEIBC;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int KLPDNANHJIM;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int PDGDELGHFIE;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int BGBOCOIGJEI;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int DIGLKPKHCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[HCOGNCHHAAD(GKKLJNPNNON.Self, false, false, false)]
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
		private DODPFPFNHPN animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[GEDEHNCPDHB("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[GEDEHNCPDHB("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic EDGBLPHAMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool PPGNLEOICOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite MLACAIGJION
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8235380", Offset = "0x8234780", VA = "0x188235380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x82355A0", Offset = "0x82349A0", VA = "0x1882355A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color AMHBDLFJNLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xE0D840", Offset = "0xE0CC40", VA = "0x180E0D840")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8235630", Offset = "0x8234A30", VA = "0x188235630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color DAPDBMOAHFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xFC20A0", Offset = "0xFC14A0", VA = "0x180FC20A0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8235470", Offset = "0x8234870", VA = "0x188235470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float FMEPMBDKHPD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xBE45C0", Offset = "0xBE39C0", VA = "0x180BE45C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8235530", Offset = "0x8234930", VA = "0x188235530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 NHOPABPADJB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x8235360", Offset = "0x8234760", VA = "0x188235360")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8235550", Offset = "0x8234950", VA = "0x188235550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float MPKJDDCJPBL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9AF6A0", Offset = "0x9AEAA0", VA = "0x1809AF6A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x82354F0", Offset = "0x82348F0", VA = "0x1882354F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 JIBOIOMKOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x13EC360", Offset = "0x13EB760", VA = "0x1813EC360")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x82356B0", Offset = "0x8234AB0", VA = "0x1882356B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float HACCOHLENFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xFAEB70", Offset = "0xFADF70", VA = "0x180FAEB70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8235440", Offset = "0x8234840", VA = "0x188235440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 AOIJLCBBKIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8234560", Offset = "0x8233960", VA = "0x188234560")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public DODPFPFNHPN JIJPIEHHBHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD94870", Offset = "0xD93C70", VA = "0x180D94870")]
			get
			{
				return default(DODPFPFNHPN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8235460", Offset = "0x8234860", VA = "0x188235460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float LEJAJFPLKGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x156D2C0", Offset = "0x156C6C0", VA = "0x18156D2C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8235510", Offset = "0x8234910", VA = "0x188235510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float CLNFOLFKMLE
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x14F5E30", Offset = "0x14F5230", VA = "0x1814F5E30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8235420", Offset = "0x8234820", VA = "0x188235420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x82345F0", Offset = "0x82339F0", VA = "0x1882345F0", Slot = "13")]
		protected override void GOGNGFKEFLO(Material ANOGJJADLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8234D40", Offset = "0x8234140", VA = "0x188234D40")]
		private void LDGCECBDDPD(Sprite HBDDFMMEFDC, [Out] Vector2 MKOHPHIGCJC, [Out] Vector2 JKGDBJJIGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8234CF0", Offset = "0x82340F0", VA = "0x188234CF0", Slot = "14")]
		protected override void HGEGNKDNCHG(Material ANOGJJADLNE, bool CGAPLHFOGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x82352D0", Offset = "0x82346D0", VA = "0x1882352D0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader MCDDJKPCCEE;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader DNFPLNCINND
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8235750", Offset = "0x8234B50", VA = "0x188235750", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8235700", Offset = "0x8234B00", VA = "0x188235700")]
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
		private SerializableRectTransform LIMBAHFJIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool CBCLCLOBBKE;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x822FA40", Offset = "0x822EE40", VA = "0x18822FA40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x822FD20", Offset = "0x822F120", VA = "0x18822FD20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x822FCA0", Offset = "0x822F0A0", VA = "0x18822FCA0")]
		private void NFAODJKFPNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x822FBD0", Offset = "0x822EFD0", VA = "0x18822FBD0")]
		private void JMFBBFMHGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GNABPNCFKDO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FEIFBCLOIBP : IEquatable<FEIFBCLOIBP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component PCJJKLDOJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action KGFFKCOJFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int IGMALKGDOGK;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component CLJDABMONFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xC6E710", Offset = "0xC6DB10", VA = "0x180C6E710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x822DD20", Offset = "0x822D120", VA = "0x18822DD20")]
		public FEIFBCLOIBP(Component PCJJKLDOJMD, Action KGFFKCOJFOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x822DC00", Offset = "0x822D000", VA = "0x18822DC00")]
		public void ADOFNKOFPAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x822DC80", Offset = "0x822D080", VA = "0x18822DC80", Slot = "4")]
		public bool Equals(FEIFBCLOIBP KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x822DC90", Offset = "0x822D090", VA = "0x18822DC90", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9931A0", Offset = "0x9925A0", VA = "0x1809931A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LNANDOHHFPA : IEnumerator<CIKDDGFOAFI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private CIKDDGFOAFI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public GNABPNCFKDO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private CIKDDGFOAFI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x999C60", Offset = "0x999060", VA = "0x180999C60")]
		[DebuggerHidden]
		public LNANDOHHFPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x822F0E0", Offset = "0x822E4E0", VA = "0x18822F0E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x822F4A0", Offset = "0x822E8A0", VA = "0x18822F4A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GAMKDKPALGP BIENFMKKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int KAAPJAFDKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int DIFDOBIIMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> MGNPNLPLDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, FEIFBCLOIBP> EELOAHFHCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<FEIFBCLOIBP> NADFHGJMFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<FEIFBCLOIBP> EEOBKHDJEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private LBKCJDEOHAA HKKCDJNBPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ILOCEHNBACN HFCPEKKIIIO;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private ILOCEHNBACN CEFPPPFKAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x822DE10", Offset = "0x822D210", VA = "0x18822DE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x822E5D0", Offset = "0x822D9D0", VA = "0x18822E5D0")]
	public GNABPNCFKDO(GAMKDKPALGP BIENFMKKIBH, int KAAPJAFDKKD = -1, int DIFDOBIIMJP = -1, [Optional] Func<Component, float> MGNPNLPLDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x822DF00", Offset = "0x822D300", VA = "0x18822DF00")]
	public void IGCKNJNNFLP(Component PCJJKLDOJMD, Action EKJBIEIFIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x822E200", Offset = "0x822D600", VA = "0x18822E200")]
	public void LAIDBOMHBFI(Component PCJJKLDOJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x822DEA0", Offset = "0x822D2A0", VA = "0x18822DEA0")]
	public bool HFAMNNLNCPA(Component DMJKAPFLGHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x822E390", Offset = "0x822D790", VA = "0x18822E390")]
	private void PMLPOIHNKCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x822DD90", Offset = "0x822D190", VA = "0x18822DD90")]
	[IteratorStateMachine(typeof(LNANDOHHFPA))]
	private IEnumerator<CIKDDGFOAFI> DEPABDMLIFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xBE1EF0", Offset = "0xBE12F0", VA = "0x180BE1EF0")]
	[CompilerGenerated]
	private void COHANEDPFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x822E180", Offset = "0x822D580", VA = "0x18822E180")]
	[CompilerGenerated]
	private float LAGNJBBPEDN(FEIFBCLOIBP EKJBIEIFIHC)
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
