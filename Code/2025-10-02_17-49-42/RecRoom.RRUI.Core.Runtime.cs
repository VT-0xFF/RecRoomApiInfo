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
				[Cpp2IlInjected.Address(RVA = "0x8F9A250", Offset = "0x8F98C50", VA = "0x188F9A250")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x8F9A2B0", Offset = "0x8F98CB0", VA = "0x188F9A2B0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8F9A210", Offset = "0x8F98C10", VA = "0x188F9A210")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8F9A110", Offset = "0x8F98B10", VA = "0x188F9A110")]
			public void PCBBJDMJPOD(PointerEventData DPNACPGBHNH, RectTransform HKHBMCLJCBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8F99E80", Offset = "0x8F98880", VA = "0x188F99E80")]
			public void KECGOPBBEBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8F99D50", Offset = "0x8F98750", VA = "0x188F99D50")]
			public void CNMPCAPMJBK(PointerEventData DPNACPGBHNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8F99E30", Offset = "0x8F98830", VA = "0x188F99E30")]
			public void HMAHCIGAINI(float EJFALGEAMAA, RectTransform HKHBMCLJCBO, Vector3 AIOBIOOBAEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly AHDLCNFLGGK<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly AHDLCNFLGGK<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly AHDLCNFLGGK<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly AHDLCNFLGGK<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly AHDLCNFLGGK<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly EBDGCEEEFPM PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData KFBEAPCHEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool GGNLHOBCLIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool FOJIHFHIEGN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ODJAGLEKFNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8F99590", Offset = "0x8F97F90", VA = "0x188F99590")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LCMIJDGEIBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xABA910", Offset = "0xAB9310", VA = "0x180ABA910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8F99560", Offset = "0x8F97F60", VA = "0x188F99560")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8F994E0", Offset = "0x8F97EE0", VA = "0x188F994E0")]
		private bool AAHHFMMGLOP(PointerEventData PPGGMEFFGDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F99A10", Offset = "0x8F98410", VA = "0x188F99A10", Slot = "5")]
		public void OnPointerDown(PointerEventData PPGGMEFFGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F99AD0", Offset = "0x8F984D0", VA = "0x188F99AD0", Slot = "11")]
		public void OnPointerUp(PointerEventData PPGGMEFFGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F99880", Offset = "0x8F98280", VA = "0x188F99880", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData PPGGMEFFGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F995C0", Offset = "0x8F97FC0", VA = "0x188F995C0", Slot = "7")]
		public void OnBeginDrag(PointerEventData PPGGMEFFGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8F996D0", Offset = "0x8F980D0", VA = "0x188F996D0", Slot = "4")]
		public void OnDrag(PointerEventData PPGGMEFFGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F997B0", Offset = "0x8F981B0", VA = "0x188F997B0", Slot = "8")]
		public void OnEndDrag(PointerEventData PPGGMEFFGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8F99A70", Offset = "0x8F98470", VA = "0x188F99A70", Slot = "9")]
		public void OnPointerEnter(PointerEventData PPGGMEFFGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F99AA0", Offset = "0x8F984A0", VA = "0x188F99AA0", Slot = "10")]
		public void OnPointerExit(PointerEventData PPGGMEFFGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8F99690", Offset = "0x8F98090", VA = "0x188F99690")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F99B30", Offset = "0x8F98530", VA = "0x188F99B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F95B30", Offset = "0x8F94530", VA = "0x188F95B30")]
		public void SetCanvasSortingOrder(short MOKDONKKJGG, bool DBFLLJAILJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData FOBAMEMEDNK;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F95D40", Offset = "0x8F94740", VA = "0x188F95D40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8F95C20", Offset = "0x8F94620", VA = "0x188F95C20", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8F95F30", Offset = "0x8F94930", VA = "0x188F95F30")]
		private void PPEOKMICNED(GameObject JIPFNEPPLIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F960D0", Offset = "0x8F94AD0", VA = "0x188F960D0")]
		public void SetOptionsWithNoDefault(List<string> FDOLNIMJMJM, [Optional] string PLCCGMOINAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8F95FE0", Offset = "0x8F949E0", VA = "0x188F95FE0")]
		public void SetOptionsWithNoDefault(List<OptionData> ALFCEIKBPNG, [Optional] string PLCCGMOINAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F95E60", Offset = "0x8F94860", VA = "0x188F95E60", Slot = "44")]
		public override void OnPointerClick(PointerEventData PPGGMEFFGDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "47")]
		protected override GameObject CreateBlocker(Canvas BAHNMNPIIKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F96300", Offset = "0x8F94D00", VA = "0x188F96300")]
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
		private sealed class IDHKPDOIAFG : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private JFFMJDIOLAN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public IDHKPDOIAFG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8F96CE0", Offset = "0x8F956E0", VA = "0x188F96CE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8F971F0", Offset = "0x8F95BF0", VA = "0x188F971F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[JOGPDLJFLHG(EAHEBLGAGFP.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly FGPFCPIHEJA<object> FJCHODNLOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool DCNLDKEFIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? LNPBHOAFAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? ACLPGGPMCKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? BPJNIOHLDCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool OACGAOIGJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool KGFIHFJMBGC;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JAKPEOLGOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8F96A00", Offset = "0x8F95400", VA = "0x188F96A00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool JGEFMHJCKEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8F969B0", Offset = "0x8F953B0", VA = "0x188F969B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CAICEDCLPDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAF9EF0", Offset = "0xAF88F0", VA = "0x180AF9EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8F96BC0", Offset = "0x8F955C0", VA = "0x188F96BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action GOHIIMAEOBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8F96910", Offset = "0x8F95310", VA = "0x188F96910")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8F96B20", Offset = "0x8F95520", VA = "0x188F96B20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F96350", Offset = "0x8F94D50", VA = "0x188F96350")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8F966F0", Offset = "0x8F950F0", VA = "0x188F966F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F966A0", Offset = "0x8F950A0", VA = "0x188F966A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F96490", Offset = "0x8F94E90", VA = "0x188F96490")]
		public void Hide(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F96870", Offset = "0x8F95270", VA = "0x188F96870")]
		public void Show(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F96780", Offset = "0x8F95180", VA = "0x188F96780")]
		public void Set(object MFKHKDDANII, bool HALBENDLPGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F963E0", Offset = "0x8F94DE0", VA = "0x188F963E0")]
		public void Clear(bool NOBCFLAOFPJ = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F96520", Offset = "0x8F94F20", VA = "0x188F96520")]
		private void OLGKJIKJDDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8F964A0", Offset = "0x8F94EA0", VA = "0x188F964A0")]
		[IteratorStateMachine(typeof(IDHKPDOIAFG))]
		private IEnumerator<JFFMJDIOLAN> OGKENHPBKFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8F96450", Offset = "0x8F94E50", VA = "0x188F96450", Slot = "5")]
		public virtual void DoHideOrShow(bool FLPAFPEINEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8F96880", Offset = "0x8F95280", VA = "0x188F96880")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AJPGBIHDMAF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum CKCEHBCEKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static CNGDCLJNIFB OKHCIAIJHED;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static CNGDCLJNIFB GPGKFNNHKEO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8F94FA0", Offset = "0x8F939A0", VA = "0x188F94FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static CKCEHBCEKFJ GCBLMILONMK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8F94E70", Offset = "0x8F93870", VA = "0x188F94E70")]
		get
		{
			return default(CKCEHBCEKFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F94D10", Offset = "0x8F93710", VA = "0x188F94D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<CKCEHBCEKFJ> CJPOGIDMJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8F950A0", Offset = "0x8F93AA0", VA = "0x188F950A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8F94C30", Offset = "0x8F93630", VA = "0x188F94C30")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NJMNCFKJDMP : PKGEBJLCDMG, NMGALNCMICJ, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, DLAMGFJFMEA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EBDGCEEEFPM LGABEDGKOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKHGEDPOIHB Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject IGAKMAMDNNB);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PKHGEDPOIHB Spawn<T>(int JMHBLBFOLPF, IReadOnlyList<T> BLPDDGCLNPE, GameObject IGAKMAMDNNB);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PKHGEDPOIHB Spawn<T>(int JMHBLBFOLPF, IReadOnlyList<T> BLPDDGCLNPE, GameObject HIBDIPIENMO, Func<int, GameObject> NLJOIFDDCMK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int KABGMIEBEFC, float MNBGDKACFCF);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum IDENCNPEMFO : byte
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
		private static readonly int AOFFBCJPMDJ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<IDENCNPEMFO, string> JMELOBPLINL;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int HMLANJFACJP = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int GCGBPAJJNDK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int IHFKJDJGDBL;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int OHPOCHIFICD;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int KPBNCGGKDDP;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int EGGKALGKFEH;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int FANNKCHBOAK;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int OLBFDNOAPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool KDBENBINGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool OFADDOPFCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] IBPFOAGCHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private IDENCNPEMFO type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly IDENCNPEMFO[] NIDMPEOFCMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[FFBOEEGEIOD("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly IDENCNPEMFO[] IDBKBHFFNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[FFBOEEGEIOD("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[FFBOEEGEIOD("type", IDENCNPEMFO.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[FFBOEEGEIOD("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic JLAAEADOBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool HLAOFLHDJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient PKOPBKLKPOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8F99330", Offset = "0x8F97D30", VA = "0x188F99330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IDENCNPEMFO EMHLKEMKMPE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7F0", Offset = "0xB2E1F0", VA = "0x180B2F7F0")]
			get
			{
				return default(IDENCNPEMFO);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8F994B0", Offset = "0x8F97EB0", VA = "0x188F994B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool IDIJBCEFJJC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8F989D0", Offset = "0x8F973D0", VA = "0x188F989D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 IKFPNNKLDCD
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8F992A0", Offset = "0x8F97CA0", VA = "0x188F992A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8F992E0", Offset = "0x8F97CE0", VA = "0x188F992E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool IJBMCPGMKAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8F97F10", Offset = "0x8F96910", VA = "0x188F97F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 JHKBPPBGAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8F992C0", Offset = "0x8F97CC0", VA = "0x188F992C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8F99460", Offset = "0x8F97E60", VA = "0x188F99460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NFOFILDNIAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xE33CF0", Offset = "0xE326F0", VA = "0x180E33CF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x25807E0", Offset = "0x257F1E0", VA = "0x1825807E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 FEHGLJCOIIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8F97EC0", Offset = "0x8F968C0", VA = "0x188F97EC0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 BNJNBKBNDAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8F97E50", Offset = "0x8F96850", VA = "0x188F97E50")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float NBMMMOHHODD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAC8600", Offset = "0xAC7000", VA = "0x180AC8600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8F994C0", Offset = "0x8F97EC0", VA = "0x188F994C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F97CB0", Offset = "0x8F966B0", VA = "0x188F97CB0", Slot = "12")]
		protected override void BCNPDPJNPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F98C60", Offset = "0x8F97660", VA = "0x188F98C60")]
		private void NAFJEICLBEF(Color[] PMGDAAKKEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8F97F80", Offset = "0x8F96980", VA = "0x188F97F80", Slot = "13")]
		protected override void IMHKFENJPFK(Material PJPBFBIEGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8F98A40", Offset = "0x8F97440", VA = "0x188F98A40", Slot = "14")]
		protected override void JKCFHKPALLL(Material PJPBFBIEGMK, bool LEFHPHFNFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8F991F0", Offset = "0x8F97BF0", VA = "0x188F991F0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly BPNIEAPIDPE GDEODGKPGDB;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite AGHDLJKDCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material IOFMKOCEOIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material DJPAPGPCBDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool PEKMEGDKNCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool DCNLDKEFIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool OHELHMIIHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool GLJEDGJOLIL;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic JLAAEADOBDG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader EGAMCEBPOGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool HLAOFLHDJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool HLFJHJFABOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform HKHBMCLJCBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8F9ACE0", Offset = "0x8F996E0", VA = "0x188F9ACE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect KKBNNNEICMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8F9AD40", Offset = "0x8F99740", VA = "0x188F9AD40")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite LIAEGENAMDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8F9A900", Offset = "0x8F99300", VA = "0x188F9A900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A4A0", Offset = "0x8F98EA0", VA = "0x188F9A4A0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B480", Offset = "0x8F99E80", VA = "0x188F9B480", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B780", Offset = "0x8F9A180", VA = "0x188F9B780", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B630", Offset = "0x8F9A030", VA = "0x188F9B630", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B1B0", Offset = "0x8F99BB0", VA = "0x188F9B1B0")]
		private void JKKCBLEDOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AAF0", Offset = "0x8F994F0", VA = "0x188F9AAF0")]
		private void CBPPOHLGEJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9ACB0", Offset = "0x8F996B0", VA = "0x188F9ACB0")]
		private void FIJHOANBAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AC60", Offset = "0x8F99660", VA = "0x188F9AC60")]
		private void DAGGIEBFFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9A690", Offset = "0x8F99090", VA = "0x188F9A690")]
		protected void BBBIHOPMMDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B340", Offset = "0x8F99D40", VA = "0x188F9B340")]
		private void LEPECCAJNMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "12")]
		protected virtual void BCNPDPJNPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "13")]
		protected virtual void IMHKFENJPFK(Material PJPBFBIEGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "14")]
		protected virtual void JKCFHKPALLL(Material PJPBFBIEGMK, bool LEFHPHFNFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AE60", Offset = "0x8F99860", VA = "0x188F9AE60")]
		private void JILIJALGLKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
		private static readonly int DOCFAPDIALG;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int FAOEADBFIEP;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int IDMPEGPEJDN;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int IJMIAOKNDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
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
		private Color[] IBPFOAGCHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] OOEJHHJLALL;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic JLAAEADOBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool HLFJHJFABOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> JJPMPCGAEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 IKFPNNKLDCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xF2BD50", Offset = "0xF2A750", VA = "0x180F2BD50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8F9C250", Offset = "0x8F9AC50", VA = "0x188F9C250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BE90", Offset = "0x8F9A890", VA = "0x188F9BE90")]
		public void SetRingLayers(IReadOnlyList<RingLayer> CLAKPOOFEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BC50", Offset = "0x8F9A650", VA = "0x188F9BC50")]
		public bool SetRingLayerColor(int LBOHPGJILDA, Color EOGEFFOIIOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BDA0", Offset = "0x8F9A7A0", VA = "0x188F9BDA0")]
		public bool SetRingLayerSize(int LBOHPGJILDA, float BCAJFCGHDKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B940", Offset = "0x8F9A340", VA = "0x188F9B940", Slot = "12")]
		protected override void BCNPDPJNPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BA80", Offset = "0x8F9A480", VA = "0x188F9BA80", Slot = "13")]
		protected override void IMHKFENJPFK(Material PJPBFBIEGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BC00", Offset = "0x8F9A600", VA = "0x188F9BC00", Slot = "14")]
		protected override void JKCFHKPALLL(Material PJPBFBIEGMK, bool LEFHPHFNFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BFE0", Offset = "0x8F9A9E0", VA = "0x188F9BFE0")]
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
		public enum CIIEBODGOAI
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int GDLGJIJOAEJ;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int FKKOPNDGPAG;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int GLKLCKHPMFG;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int BLAKCHEOKLB;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int DHDGNDENACA;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int JIHAPNDPIPD;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int JJGBFPPELJG;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int HCNIJBEIDHN;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int GOEKGLKCFNM;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int NKBADOOJKKD;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int JAHNBIEIDCD;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ANGPGGEGAMA;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int JAKJGIJJBOD;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int ONGIBDNGIOO;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int IAPDALOPOJK;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int GOFKAHHKHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
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
		private CIIEBODGOAI animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[FFBOEEGEIOD("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[FFBOEEGEIOD("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic JLAAEADOBDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool HLFJHJFABOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite DAAIGPHIEIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D0A0", Offset = "0x8F9BAA0", VA = "0x188F9D0A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D2C0", Offset = "0x8F9BCC0", VA = "0x188F9D2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color LLPLMEBIPKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x109DC80", Offset = "0x109C680", VA = "0x18109DC80")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D350", Offset = "0x8F9BD50", VA = "0x188F9D350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color MPLFIBHEHPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x12DB4D0", Offset = "0x12D9ED0", VA = "0x1812DB4D0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D190", Offset = "0x8F9BB90", VA = "0x188F9D190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float MIOJILMIMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xE32FD0", Offset = "0xE319D0", VA = "0x180E32FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D250", Offset = "0x8F9BC50", VA = "0x188F9D250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 PMFFPMLGNNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2A7BC10", Offset = "0x2A7A610", VA = "0x182A7BC10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D270", Offset = "0x8F9BC70", VA = "0x188F9D270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float MMNMLIHNLBN
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAC8250", Offset = "0xAC6C50", VA = "0x180AC8250")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D210", Offset = "0x8F9BC10", VA = "0x188F9D210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 EMMOJEOIKGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1825990", Offset = "0x1824390", VA = "0x181825990")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D3D0", Offset = "0x8F9BDD0", VA = "0x188F9D3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float CDLNHICFMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x12C7C20", Offset = "0x12C6620", VA = "0x1812C7C20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D160", Offset = "0x8F9BB60", VA = "0x188F9D160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 EJDENGABCGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8F9C9F0", Offset = "0x8F9B3F0", VA = "0x188F9C9F0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public CIIEBODGOAI CCLLAKIILMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7B0", Offset = "0xB2E1B0", VA = "0x180B2F7B0")]
			get
			{
				return default(CIIEBODGOAI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D180", Offset = "0x8F9BB80", VA = "0x188F9D180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float GANPADDDKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x19D98E0", Offset = "0x19D82E0", VA = "0x1819D98E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D230", Offset = "0x8F9BC30", VA = "0x188F9D230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float NGPHBKAFEPE
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xF523E0", Offset = "0xF50DE0", VA = "0x180F523E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D140", Offset = "0x8F9BB40", VA = "0x188F9D140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C2A0", Offset = "0x8F9ACA0", VA = "0x188F9C2A0", Slot = "13")]
		protected override void IMHKFENJPFK(Material PJPBFBIEGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9CA80", Offset = "0x8F9B480", VA = "0x188F9CA80")]
		private void LLOOGMEJOGH(Sprite DGCMKKGIIIC, [Out] Vector2 IAKPLJEOKMD, [Out] Vector2 BALJJALDKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C9A0", Offset = "0x8F9B3A0", VA = "0x188F9C9A0", Slot = "14")]
		protected override void JKCFHKPALLL(Material PJPBFBIEGMK, bool LEFHPHFNFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D010", Offset = "0x8F9BA10", VA = "0x188F9D010")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader NAHODIOCNEP;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader EGAMCEBPOGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8F9D470", Offset = "0x8F9BE70", VA = "0x188F9D470", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D420", Offset = "0x8F9BE20", VA = "0x188F9D420")]
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
		private SerializableRectTransform JBJEBKHMNLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool OCJJHKLAMNA;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8F977E0", Offset = "0x8F961E0", VA = "0x188F977E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8F97AC0", Offset = "0x8F964C0", VA = "0x188F97AC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8F97970", Offset = "0x8F96370", VA = "0x188F97970")]
		private void NGIGFHIPFBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8F979F0", Offset = "0x8F963F0", VA = "0x188F979F0")]
		private void OLGKJIKJDDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BPNIEAPIDPE
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct KCMEAPODBHB : IEquatable<KCMEAPODBHB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component IJNPIDPIBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action NOAEHNMBEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int EENABMIONCD;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component NGIJKNBMGDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xB51460", Offset = "0xB4FE60", VA = "0x180B51460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8F97360", Offset = "0x8F95D60", VA = "0x188F97360")]
		public KCMEAPODBHB(Component IJNPIDPIBFP, Action NOAEHNMBEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8F97240", Offset = "0x8F95C40", VA = "0x188F97240")]
		public void EHJPGICEMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8F972C0", Offset = "0x8F95CC0", VA = "0x188F972C0", Slot = "4")]
		public bool Equals(KCMEAPODBHB GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F972D0", Offset = "0x8F95CD0", VA = "0x188F972D0", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class NNPLKJKIGIL : IEnumerator<JFFMJDIOLAN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private JFFMJDIOLAN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public BPNIEAPIDPE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private JFFMJDIOLAN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public NNPLKJKIGIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8F973D0", Offset = "0x8F95DD0", VA = "0x188F973D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8F97790", Offset = "0x8F96190", VA = "0x188F97790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly JHJLCHFAIBB PFJPKKCCFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int KIKIJJFOPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int JHGCNBIAKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> HLFLKELOFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, KCMEAPODBHB> FAABCEHCOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<KCMEAPODBHB> MPBHMGFBDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<KCMEAPODBHB> ONPPLCLEJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private LCOHCCBKPLJ GEAFCBODNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NAKKFAFPINH KMHIDJGFAAF;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private NAKKFAFPINH HGHGBBLOHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8F95180", Offset = "0x8F93B80", VA = "0x188F95180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8F959B0", Offset = "0x8F943B0", VA = "0x188F959B0")]
	public BPNIEAPIDPE(JHJLCHFAIBB PFJPKKCCFAK, int KIKIJJFOPNK = -1, int JHGCNBIAKNB = -1, [Optional] Func<Component, float> HLFLKELOFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8F956D0", Offset = "0x8F940D0", VA = "0x188F956D0")]
	public void JILBFAOIJIK(Component IJNPIDPIBFP, Action BEINHMMJKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8F95440", Offset = "0x8F93E40", VA = "0x188F95440")]
	public void EBOCFIIFAGN(Component IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8F95950", Offset = "0x8F94350", VA = "0x188F95950")]
	public bool NAEIBNEAFFO(Component ADKKEOFFDMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8F95210", Offset = "0x8F93C10", VA = "0x188F95210")]
	private void DDBLJDBGPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8F95650", Offset = "0x8F94050", VA = "0x188F95650")]
	[IteratorStateMachine(typeof(NNPLKJKIGIL))]
	private IEnumerator<JFFMJDIOLAN> IANMLCJKMCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xF95990", Offset = "0xF94390", VA = "0x180F95990")]
	[CompilerGenerated]
	private void AAJLAFACNHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8F955D0", Offset = "0x8F93FD0", VA = "0x188F955D0")]
	[CompilerGenerated]
	private float GIEOOGEPIHI(KCMEAPODBHB BEINHMMJKLL)
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
