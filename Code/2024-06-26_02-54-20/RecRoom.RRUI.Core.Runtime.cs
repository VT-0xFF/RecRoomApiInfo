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
				[Cpp2IlInjected.Address(RVA = "0x71BC4C0", Offset = "0x71BAAC0", VA = "0x1871BC4C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x71BC520", Offset = "0x71BAB20", VA = "0x1871BC520")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x71BC470", Offset = "0x71BAA70", VA = "0x1871BC470")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x71BC370", Offset = "0x71BA970", VA = "0x1871BC370")]
			public void NECPHLNNBOL(PointerEventData IJJDFNBCGLN, RectTransform DFAKJEJIPJG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x71BBFB0", Offset = "0x71BA5B0", VA = "0x1871BBFB0")]
			public void DBONPDDKANF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x71BC290", Offset = "0x71BA890", VA = "0x1871BC290")]
			public void EKEAFLBANGE(PointerEventData IJJDFNBCGLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x71BC240", Offset = "0x71BA840", VA = "0x1871BC240")]
			public void EBIJEILACLB(float OMDAJKAMDDO, RectTransform DFAKJEJIPJG, Vector3 DCBNBHMBGKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly GFLPBNMBKPD<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly GFLPBNMBKPD<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly GFLPBNMBKPD<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly GFLPBNMBKPD<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly GFLPBNMBKPD<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly BGECMLEGDCD PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData PGLFPOPIIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool OCANAKMABMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool FPBLPHLDCGO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BANLEJJMLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8711F0", Offset = "0x86F7F0", VA = "0x1808711F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x71BB740", Offset = "0x71B9D40", VA = "0x1871BB740")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JKKCCBOIPOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8711E0", Offset = "0x86F7E0", VA = "0x1808711E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x71BB7F0", Offset = "0x71B9DF0", VA = "0x1871BB7F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71BB770", Offset = "0x71B9D70", VA = "0x1871BB770")]
		private bool DLFOHOEHMDA(PointerEventData PHGGMGHAANF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71BBC70", Offset = "0x71BA270", VA = "0x1871BBC70", Slot = "5")]
		public void OnPointerDown(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71BBD30", Offset = "0x71BA330", VA = "0x1871BBD30", Slot = "11")]
		public void OnPointerUp(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71BBAE0", Offset = "0x71BA0E0", VA = "0x1871BBAE0", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71BB820", Offset = "0x71B9E20", VA = "0x1871BB820", Slot = "7")]
		public void OnBeginDrag(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71BB930", Offset = "0x71B9F30", VA = "0x1871BB930", Slot = "4")]
		public void OnDrag(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71BBA10", Offset = "0x71BA010", VA = "0x1871BBA10", Slot = "8")]
		public void OnEndDrag(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71BBCD0", Offset = "0x71BA2D0", VA = "0x1871BBCD0", Slot = "9")]
		public void OnPointerEnter(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71BBD00", Offset = "0x71BA300", VA = "0x1871BBD00", Slot = "10")]
		public void OnPointerExit(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71BB8F0", Offset = "0x71B9EF0", VA = "0x1871BB8F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71BBD90", Offset = "0x71BA390", VA = "0x1871BBD90")]
		public UIHandleDecorator()
		{
		}
	}
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private OptionData NCENBCNGPAF;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71B6E70", Offset = "0x71B5470", VA = "0x1871B6E70", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x71B6D70", Offset = "0x71B5370", VA = "0x1871B6D70", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71B6CC0", Offset = "0x71B52C0", VA = "0x1871B6CC0")]
		private void NBGBOPDLGKG(GameObject NDKAPFJJFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71B7130", Offset = "0x71B5730", VA = "0x1871B7130")]
		public void SetOptionsWithNoDefault(List<string> CNNODMDOLAC, [Optional] string BMHPIJPNOMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71B7040", Offset = "0x71B5640", VA = "0x1871B7040")]
		public void SetOptionsWithNoDefault(List<OptionData> HEBGDGGBJPN, [Optional] string BMHPIJPNOMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x71B6F70", Offset = "0x71B5570", VA = "0x1871B6F70", Slot = "42")]
		public override void OnPointerClick(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas LOFMAFCEKHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71B7360", Offset = "0x71B5960", VA = "0x1871B7360")]
		public Dropdown()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public class Hideable : MonoBehaviour, ILayoutIgnorer
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class EKAKHGICFHA : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private MBMMHILCGCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
			[DebuggerHidden]
			public EKAKHGICFHA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71B73B0", Offset = "0x71B59B0", VA = "0x1871B73B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x71B78C0", Offset = "0x71B5EC0", VA = "0x1871B78C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[NPPPEBEMIFD(CKKEEFADMDD.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly EDKHENFJMJA<object> MFMEMBPMCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool PGOCOOJDOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? BGPFOALIJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? PJJGGCAEECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? OMNFBOJCKCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool DMCDBDIKLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool BLJHEOIFIHK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FKNBMJPOMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x71B8420", Offset = "0x71B6A20", VA = "0x1871B8420", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool FMIEEPICGNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x71B83D0", Offset = "0x71B69D0", VA = "0x1871B83D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool NKLMIAFEAMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8ACBC0", Offset = "0x8AB1C0", VA = "0x1808ACBC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x71B85E0", Offset = "0x71B6BE0", VA = "0x1871B85E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HNIBBFFKAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x71B8330", Offset = "0x71B6930", VA = "0x1871B8330")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x71B8540", Offset = "0x71B6B40", VA = "0x1871B8540")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71B7D20", Offset = "0x71B6320", VA = "0x1871B7D20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x71B7F40", Offset = "0x71B6540", VA = "0x1871B7F40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x71B7EF0", Offset = "0x71B64F0", VA = "0x1871B7EF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x71B7EE0", Offset = "0x71B64E0", VA = "0x1871B7EE0")]
		public void Hide(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x71B8290", Offset = "0x71B6890", VA = "0x1871B8290")]
		public void Show(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x71B81A0", Offset = "0x71B67A0", VA = "0x1871B81A0")]
		public void Set(object OEDJKICDDGA, bool DGBMLNDECLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x71B7DB0", Offset = "0x71B63B0", VA = "0x1871B7DB0")]
		public void Clear(bool DNAKAOBAHOI = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x71B7FD0", Offset = "0x71B65D0", VA = "0x1871B7FD0")]
		private void PMBGKANLDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x71B7E60", Offset = "0x71B6460", VA = "0x1871B7E60")]
		[IteratorStateMachine(typeof(EKAKHGICFHA))]
		private IEnumerator<MBMMHILCGCA> GCGDJAFCMJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71B7E20", Offset = "0x71B6420", VA = "0x1871B7E20", Slot = "5")]
		public virtual void DoHideOrShow(bool HGKKLPJHMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71B82A0", Offset = "0x71B68A0", VA = "0x1871B82A0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MDPGAEKILEA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x92FCA0", Offset = "0x92E2A0", VA = "0x18092FCA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x870440", Offset = "0x86EA40", VA = "0x180870440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> ADFGMFELCGE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x71B8740", Offset = "0x71B6D40", VA = "0x1871B8740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x71B88A0", Offset = "0x71B6EA0", VA = "0x1871B88A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> OLIJCDGPJOA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x71B87F0", Offset = "0x71B6DF0", VA = "0x1871B87F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x71B8950", Offset = "0x71B6F50", VA = "0x1871B8950")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x71B8700", Offset = "0x71B6D00", VA = "0x1871B8700", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71B8720", Offset = "0x71B6D20", VA = "0x1871B8720", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData PHGGMGHAANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE37010", Offset = "0xE35610", VA = "0x180E37010")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE37010", Offset = "0xE35610", VA = "0x180E37010")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MMGCLIDOKGA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum IECPKFEHHHA
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static LCAGPDDFOEC DACDJJABFKA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static LCAGPDDFOEC OHLLLKFGDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x71B8B60", Offset = "0x71B7160", VA = "0x1871B8B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static IECPKFEHHHA BOMKJCJBNOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x71B8DF0", Offset = "0x71B73F0", VA = "0x1871B8DF0")]
		get
		{
			return default(IECPKFEHHHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x71B8A00", Offset = "0x71B7000", VA = "0x1871B8A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<IECPKFEHHHA> LKEKCIGOMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71B8D10", Offset = "0x71B7310", VA = "0x1871B8D10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x71B8C30", Offset = "0x71B7230", VA = "0x1871B8C30")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DHKJDAAHMNK : NACKIDCKNCC, MMILICBLDAE, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, ABNNIPGIEKK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	BGECMLEGDCD IGNLFDNBGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject FIFJHOIIJHB);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PGGFJFHOMCP Spawn<T>(int PNFJLMKJJBL, IReadOnlyList<T> FHNKDHIILBL, GameObject FIFJHOIIJHB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PGGFJFHOMCP Spawn<T>(int PNFJLMKJJBL, IReadOnlyList<T> FHNKDHIILBL, GameObject EOHOANMFADM, Func<int, GameObject> FIIEFHIHDLK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int LLPJHIPCNFD, float MLEBIJMNGCO);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum CLGPJCNEAEI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			LeftToRight = 0,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			RightToLeft = 1,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			TopToBottom = 2,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			BottomToTop = 3,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			CustomDirection = 4,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			RadialOut = 10,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			RadialIn = 11,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			VignetteOut = 20,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			VignetteIn = 21,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Disabled = byte.MaxValue
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int ICDLPMPAOOJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<CLGPJCNEAEI, string> BPEIJHBAECL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int KICBNEAKEDB = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int GNPLKIJBCIC;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int ODJJIFAHEJG;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int PIGPEEHGNEC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int DEAHGNFOLDL;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int NDBDMFFBMBM;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int MJEGLCILLLM;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int FNFDJANHFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool BHHMGMMKCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool FMOEKIMEMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Color[] KAGJIKPPBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private CLGPJCNEAEI type;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly CLGPJCNEAEI[] JLHPBJJBIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[MDFGNKLCKEN("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly CLGPJCNEAEI[] JIKHMGMJBFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[MDFGNKLCKEN("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[MDFGNKLCKEN("type", CLGPJCNEAEI.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Range(0f, 5f)]
		[MDFGNKLCKEN("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic ADKDFEGODPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool NNACENGEEML
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient FCNDJENNKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x71BB590", Offset = "0x71B9B90", VA = "0x1871BB590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CLGPJCNEAEI MDBCEFGBENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x92F0C0", Offset = "0x92D6C0", VA = "0x18092F0C0")]
			get
			{
				return default(CLGPJCNEAEI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x71BB710", Offset = "0x71B9D10", VA = "0x1871BB710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool JAHOFHHKHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x71BAD90", Offset = "0x71B9390", VA = "0x1871BAD90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 PGGBDIGHJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x71BB500", Offset = "0x71B9B00", VA = "0x1871BB500")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x71BB540", Offset = "0x71B9B40", VA = "0x1871BB540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool EPBFHOKONOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x71BAFE0", Offset = "0x71B95E0", VA = "0x1871BAFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 KHHMHIKNGEM
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x71BB520", Offset = "0x71B9B20", VA = "0x1871BB520")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x71BB6C0", Offset = "0x71B9CC0", VA = "0x1871BB6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float GLKIPFHMHAI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8CE540", Offset = "0x8CCB40", VA = "0x1808CE540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x15BB9C0", Offset = "0x15B9FC0", VA = "0x1815BB9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 HDDLCCCLOLL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x71BAF90", Offset = "0x71B9590", VA = "0x1871BAF90")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 EPOJBGNACEH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x71BA120", Offset = "0x71B8720", VA = "0x1871BA120")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float NEILBNPCPKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87BEF0", VA = "0x18087D8F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x71BB720", Offset = "0x71B9D20", VA = "0x1871BB720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x71BABF0", Offset = "0x71B91F0", VA = "0x1871BABF0", Slot = "12")]
		protected override void JBKDDOADCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x71BAE00", Offset = "0x71B9400", VA = "0x1871BAE00")]
		private void JGEDMJNKMGB(Color[] MFEGDGLHHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x71BA1B0", Offset = "0x71B87B0", VA = "0x1871BA1B0", Slot = "13")]
		protected override void INKCIEODBBN(Material EGLABJPOFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71B9F00", Offset = "0x71B8500", VA = "0x1871B9F00", Slot = "14")]
		protected override void AAIOAKCFJPI(Material EGLABJPOFKK, bool GFLBKNDOAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x71BB450", Offset = "0x71B9A50", VA = "0x1871BB450")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static readonly OKDHCCEJAPF GGALJKDNDOE;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Sprite IIBNPLLOFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material LLPPCHJBGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private Material NIDMFFJDBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool GLAECDCENHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool PGOCOOJDOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool EONECIOHBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool OBADDCGGPFL;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic ADKDFEGODPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader ACGHPFACAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool NNACENGEEML
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool NCHOOODECEM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform DFAKJEJIPJG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x71BCF30", Offset = "0x71BB530", VA = "0x1871BCF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect MAPHPPIEPOD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x71BC710", Offset = "0x71BAD10", VA = "0x1871BC710")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite OEFDKCFCMAK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x71BD120", Offset = "0x71BB720", VA = "0x1871BD120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x71BC830", Offset = "0x71BAE30", VA = "0x1871BC830", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x71BD5C0", Offset = "0x71BBBC0", VA = "0x1871BD5C0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x71BD8C0", Offset = "0x71BBEC0", VA = "0x1871BD8C0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x71BD770", Offset = "0x71BBD70", VA = "0x1871BD770", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x71BCF90", Offset = "0x71BB590", VA = "0x1871BCF90")]
		private void LDCONPFFBGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x71BCD70", Offset = "0x71BB370", VA = "0x1871BCD70")]
		private void EOGBLPNLJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71BD320", Offset = "0x71BB920", VA = "0x1871BD320")]
		private void NIGHEGHLIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x71BCEE0", Offset = "0x71BB4E0", VA = "0x1871BCEE0")]
		private void FOIKDFNJBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x71BD350", Offset = "0x71BB950", VA = "0x1871BD350")]
		protected void NJACEAANHBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x71BD8D0", Offset = "0x71BBED0", VA = "0x1871BD8D0")]
		private void PFEELBKJKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "12")]
		protected virtual void JBKDDOADCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "13")]
		protected virtual void INKCIEODBBN(Material EGLABJPOFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "14")]
		protected virtual void AAIOAKCFJPI(Material EGLABJPOFKK, bool GFLBKNDOAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x71BCA20", Offset = "0x71BB020", VA = "0x1871BCA20")]
		private void BEGPJAJDKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
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
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[SerializeField]
			public Color Color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[SerializeField]
			[Range(0f, 2f)]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int GPJHKKDCICP;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int LNCDCLFKABB;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int OPMFJOFNNHB;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int MMBAEDLNEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		[SerializeField]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private List<RingLayer> ringLayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Color[] KAGJIKPPBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private float[] POPMCKAMLJD;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic ADKDFEGODPI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool NCHOOODECEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> EOFIPIFHKLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 PGGBDIGHJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x71BE440", Offset = "0x71BCA40", VA = "0x1871BE440")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x71BE460", Offset = "0x71BCA60", VA = "0x1871BE460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x71BE110", Offset = "0x71BC710", VA = "0x1871BE110")]
		public void SetRingLayers(IReadOnlyList<RingLayer> EFPCJIJMKHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x71BDED0", Offset = "0x71BC4D0", VA = "0x1871BDED0")]
		public bool SetRingLayerColor(int AHFHOBDDPJH, Color MKAJENPGJDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x71BE020", Offset = "0x71BC620", VA = "0x1871BE020")]
		public bool SetRingLayerSize(int AHFHOBDDPJH, float ENCFHCJIMBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x71BDD90", Offset = "0x71BC390", VA = "0x1871BDD90", Slot = "12")]
		protected override void JBKDDOADCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x71BDC10", Offset = "0x71BC210", VA = "0x1871BDC10", Slot = "13")]
		protected override void INKCIEODBBN(Material EGLABJPOFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71BDBC0", Offset = "0x71BC1C0", VA = "0x1871BDBC0", Slot = "14")]
		protected override void AAIOAKCFJPI(Material EGLABJPOFKK, bool GFLBKNDOAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x71BE260", Offset = "0x71BC860", VA = "0x1871BE260")]
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
		public enum CMNIOBBDDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int NDGLKPADAJP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int JANJMKBKMIG;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int PLEBAKMNEGF;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int DFBCFPAJOOI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int EKPFPJAOCMK;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int PGLALLLGEFJ;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int BEGGAFLEEDB;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int JJDCJBEPDFP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int JCEJIGDGAAB;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int PDLAEAIBKEN;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int FIPIFGJBDBA;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int NKGEHKLCCDC;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int MAKPMDFCGCA;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int PLJIMMDNKLF;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int GJKKLJCGMMG;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int PGKEFDHLIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private Image image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private Sprite sprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private Color tintColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private Color backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
		private Vector2 spacing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("The offset applied to each alternating row or column.")]
		[SerializeField]
		private float offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private CMNIOBBDDBJ animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("The animation speed of the primary rows / columns.")]
		[SerializeField]
		[MDFGNKLCKEN("AnimationDirection", new object[] { 1, 0 })]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[MDFGNKLCKEN("AnimationDirection", new object[] { 1, 0 })]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic ADKDFEGODPI
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool NCHOOODECEM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite GEHPIIFKDJC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x71BF2D0", Offset = "0x71BD8D0", VA = "0x1871BF2D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x71BF4F0", Offset = "0x71BDAF0", VA = "0x1871BF4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color OFKOMFMKJDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8D47B0", Offset = "0x8D2DB0", VA = "0x1808D47B0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x71BF580", Offset = "0x71BDB80", VA = "0x1871BF580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color FLPDKMNKLKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8E8B60", Offset = "0x8E7160", VA = "0x1808E8B60")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x71BF3C0", Offset = "0x71BD9C0", VA = "0x1871BF3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float CCCGOMILHLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8CE560", Offset = "0x8CCB60", VA = "0x1808CE560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x71BF480", Offset = "0x71BDA80", VA = "0x1871BF480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 FDHBFKBLCLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x71BF2B0", Offset = "0x71BD8B0", VA = "0x1871BF2B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x71BF4A0", Offset = "0x71BDAA0", VA = "0x1871BF4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float IFJJLDMODPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x87D540", Offset = "0x87BB40", VA = "0x18087D540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x71BF440", Offset = "0x71BDA40", VA = "0x1871BF440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 MAGFBLPBJNK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xC8A8C0", Offset = "0xC88EC0", VA = "0x180C8A8C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x71BF600", Offset = "0x71BDC00", VA = "0x1871BF600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float IBPEFENOCLG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8E8A50", Offset = "0x8E7050", VA = "0x1808E8A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x71BF390", Offset = "0x71BD990", VA = "0x1871BF390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 AMHJIOPNKMD
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x71BE500", Offset = "0x71BCB00", VA = "0x1871BE500")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public CMNIOBBDDBJ JBBLDEBEFHG
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xC3DCE0", Offset = "0xC3C2E0", VA = "0x180C3DCE0")]
			get
			{
				return default(CMNIOBBDDBJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x71BF3B0", Offset = "0x71BD9B0", VA = "0x1871BF3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float CPJNHIFOPGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xD749F0", Offset = "0xD72FF0", VA = "0x180D749F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x71BF460", Offset = "0x71BDA60", VA = "0x1871BF460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float AILKODCNABA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD74B40", Offset = "0xD73140", VA = "0x180D74B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x71BF370", Offset = "0x71BD970", VA = "0x1871BF370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x71BE840", Offset = "0x71BCE40", VA = "0x1871BE840", Slot = "13")]
		protected override void INKCIEODBBN(Material EGLABJPOFKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x71BE590", Offset = "0x71BCB90", VA = "0x1871BE590")]
		private void BKFHKIMGPIM(Sprite MEEHIOKHAGJ, [Out] Vector2 DNDHLHOBPCB, [Out] Vector2 DPEHNOOEPPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x71BE4B0", Offset = "0x71BCAB0", VA = "0x1871BE4B0", Slot = "14")]
		protected override void AAIOAKCFJPI(Material EGLABJPOFKK, bool GFLBKNDOAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x71BF220", Offset = "0x71BD820", VA = "0x1871BF220")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static Shader LOPCCCCHJKP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader ACGHPFACAJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x71BF6A0", Offset = "0x71BDCA0", VA = "0x1871BF6A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x71BF650", Offset = "0x71BDC50", VA = "0x1871BF650")]
		protected UIUberMaterialOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class RectTransformHideableAdapter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private SerializableRectTransform hiddenRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private SerializableRectTransform LOOCNIELBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool ADOJGJCDCIF;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x71B9A30", Offset = "0x71B8030", VA = "0x1871B9A30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x71B9C40", Offset = "0x71B8240", VA = "0x1871B9C40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x71B9BC0", Offset = "0x71B81C0", VA = "0x1871B9BC0")]
		private void CEHHHHGNGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x71B9D50", Offset = "0x71B8350", VA = "0x1871B9D50")]
		private void PMBGKANLDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OKDHCCEJAPF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct OJOAICAEMKF : IEquatable<OJOAICAEMKF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Component FFHIJMOJNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Action EOGFLFHCGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly int KNHEFAAMGHC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component NMINIDOGFPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8D2180", Offset = "0x8D0780", VA = "0x1808D2180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x71B9040", Offset = "0x71B7640", VA = "0x1871B9040")]
		public OJOAICAEMKF(Component FFHIJMOJNAI, Action EOGFLFHCGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x71B8FC0", Offset = "0x71B75C0", VA = "0x1871B8FC0")]
		public void KBOIAJIAKAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x71B8FB0", Offset = "0x71B75B0", VA = "0x1871B8FB0", Slot = "4")]
		public bool Equals(OJOAICAEMKF LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x71B8F20", Offset = "0x71B7520", VA = "0x1871B8F20", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8621A0", Offset = "0x8607A0", VA = "0x1808621A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class ENKEIFLLBFA : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OKDHCCEJAPF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public ENKEIFLLBFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x71B7910", Offset = "0x71B5F10", VA = "0x1871B7910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x71B7CD0", Offset = "0x71B62D0", VA = "0x1871B7CD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly POIAJKHHOFJ ABGODCJAPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int FDLAGNADJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int NCEJJFOIEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Func<Component, float> JELLICAHGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly Dictionary<Component, OJOAICAEMKF> OHJLBCFJHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly LinkedList<OJOAICAEMKF> MCPADPACLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly List<OJOAICAEMKF> HPNBKCCNJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JMPIHICOHFM BIFCGADIIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private CNDOKOPMJPL MHKBKNOHMAH;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private CNDOKOPMJPL BHOHBJPMKAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x71B94E0", Offset = "0x71B7AE0", VA = "0x1871B94E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x71B98B0", Offset = "0x71B7EB0", VA = "0x1871B98B0")]
	public OKDHCCEJAPF(POIAJKHHOFJ ABGODCJAPHA, int FDLAGNADJMI = -1, int NCEJJFOIEII = -1, [Optional] Func<Component, float> JELLICAHGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x71B9650", Offset = "0x71B7C50", VA = "0x1871B9650")]
	public void KJIBHHJGHHO(Component FFHIJMOJNAI, Action DNEKMHCKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x71B9110", Offset = "0x71B7710", VA = "0x1871B9110")]
	public void CBNONNBLAFO(Component FFHIJMOJNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x71B90B0", Offset = "0x71B76B0", VA = "0x1871B90B0")]
	public bool CAIIEHLENOG(Component ADPKHCOJMDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x71B92A0", Offset = "0x71B78A0", VA = "0x1871B92A0")]
	private void IEAKDBPOBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x71B95D0", Offset = "0x71B7BD0", VA = "0x1871B95D0")]
	[IteratorStateMachine(typeof(ENKEIFLLBFA))]
	private IEnumerator<MBMMHILCGCA> KADNAGFPABO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0xAC5980", Offset = "0xAC3F80", VA = "0x180AC5980")]
	[CompilerGenerated]
	private void CJCFGIDPDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x71B9550", Offset = "0x71B7B50", VA = "0x1871B9550")]
	[CompilerGenerated]
	private float JNHGNICOFNM(OJOAICAEMKF DNEKMHCKHLJ)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CJLFGALMCKC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PBDKLFHOFGP CBLELCGNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool DDDGIMKKCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GFLPBNMBKPD<PBDKLFHOFGP> CNNOGEAPKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDBFMKGDCDN(PBDKLFHOFGP IFBHFPGKIPB, bool FKIAKKOBPID = false);
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
