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
				[Cpp2IlInjected.Address(RVA = "0x7EA1C10", Offset = "0x7EA0210", VA = "0x187EA1C10")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x7EA1C70", Offset = "0x7EA0270", VA = "0x187EA1C70")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7EA1BD0", Offset = "0x7EA01D0", VA = "0x187EA1BD0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7EA1710", Offset = "0x7E9FD10", VA = "0x187EA1710")]
			public void CHHCJEGNFJH(PointerEventData BBDPEBODPBF, RectTransform MBGOJBHDKDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7EA1940", Offset = "0x7E9FF40", VA = "0x187EA1940")]
			public void KGABAJKHKBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7EA1810", Offset = "0x7E9FE10", VA = "0x187EA1810")]
			public void HMAGIOAPOIL(PointerEventData BBDPEBODPBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7EA18F0", Offset = "0x7E9FEF0", VA = "0x187EA18F0")]
			public void IDCPLEOOGIK(float MHHOACIGIJK, RectTransform MBGOJBHDKDF, Vector3 IJNCCGADGJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly JKOOBLENGDB<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly JKOOBLENGDB<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly JKOOBLENGDB<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly JKOOBLENGDB<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly JKOOBLENGDB<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly FKDOIPNGGAF PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData GFCDJPJODLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool GLGBIEBJFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool MELCEBHNAHM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KAFHNEDGEAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x956C70", Offset = "0x955270", VA = "0x180956C70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0EA0", Offset = "0x7E9F4A0", VA = "0x187EA0EA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MKANGDIIKOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x956D20", Offset = "0x955320", VA = "0x180956D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0ED0", Offset = "0x7E9F4D0", VA = "0x187EA0ED0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EA0F00", Offset = "0x7E9F500", VA = "0x187EA0F00")]
		private bool NBEHNJFIKME(PointerEventData NBGBHBICCPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7EA13D0", Offset = "0x7E9F9D0", VA = "0x187EA13D0", Slot = "5")]
		public void OnPointerDown(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1490", Offset = "0x7E9FA90", VA = "0x187EA1490", Slot = "11")]
		public void OnPointerUp(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1240", Offset = "0x7E9F840", VA = "0x187EA1240", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7EA0F80", Offset = "0x7E9F580", VA = "0x187EA0F80", Slot = "7")]
		public void OnBeginDrag(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1090", Offset = "0x7E9F690", VA = "0x187EA1090", Slot = "4")]
		public void OnDrag(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1170", Offset = "0x7E9F770", VA = "0x187EA1170", Slot = "8")]
		public void OnEndDrag(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1430", Offset = "0x7E9FA30", VA = "0x187EA1430", Slot = "9")]
		public void OnPointerEnter(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1460", Offset = "0x7E9FA60", VA = "0x187EA1460", Slot = "10")]
		public void OnPointerExit(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1050", Offset = "0x7E9F650", VA = "0x187EA1050")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA14F0", Offset = "0x7E9FAF0", VA = "0x187EA14F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E9CC50", Offset = "0x7E9B250", VA = "0x187E9CC50")]
		public void SetCanvasSortingOrder(short NKODNFLDPMM, bool AOCCDGBJOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData JCJAOGHNIAF;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7E9CF10", Offset = "0x7E9B510", VA = "0x187E9CF10", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7E9CDF0", Offset = "0x7E9B3F0", VA = "0x187E9CDF0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7E9CD40", Offset = "0x7E9B340", VA = "0x187E9CD40")]
		private void LKMPOABDIDJ(GameObject DIKELBEJPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D1F0", Offset = "0x7E9B7F0", VA = "0x187E9D1F0")]
		public void SetOptionsWithNoDefault(List<string> BMKDAHEBDHE, [Optional] string DHEMNAAIMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D100", Offset = "0x7E9B700", VA = "0x187E9D100")]
		public void SetOptionsWithNoDefault(List<OptionData> DCEHMKPFEJH, [Optional] string DHEMNAAIMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D030", Offset = "0x7E9B630", VA = "0x187E9D030", Slot = "42")]
		public override void OnPointerClick(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas DFDMBCMABCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D420", Offset = "0x7E9BA20", VA = "0x187E9D420")]
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
		private sealed class MKGFMBFBJHJ : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public MKGFMBFBJHJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7E9E290", Offset = "0x7E9C890", VA = "0x187E9E290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7E9E7A0", Offset = "0x7E9CDA0", VA = "0x187E9E7A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[AICMCMODPDA(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly GAHHCHCOBKJ<object> BADMKDOBAFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool JNBOIMABFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? IKGALFPHKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? KGAGOCCALFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? FBDDPLMKPHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool NPKAMDJBFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool KMEIFDBJEKP;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool JHHAIKHLEGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7E9DB20", Offset = "0x7E9C120", VA = "0x187E9DB20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool BBBBJNJAMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7E9DAD0", Offset = "0x7E9C0D0", VA = "0x187E9DAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BIKBIEKFIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x99D690", Offset = "0x99BC90", VA = "0x18099D690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7E9DCE0", Offset = "0x7E9C2E0", VA = "0x187E9DCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NJPLAENGAEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7E9DA30", Offset = "0x7E9C030", VA = "0x187E9DA30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7E9DC40", Offset = "0x7E9C240", VA = "0x187E9DC40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D470", Offset = "0x7E9BA70", VA = "0x187E9D470")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D810", Offset = "0x7E9BE10", VA = "0x187E9D810")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D7C0", Offset = "0x7E9BDC0", VA = "0x187E9D7C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D5B0", Offset = "0x7E9BBB0", VA = "0x187E9D5B0")]
		public void Hide(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D990", Offset = "0x7E9BF90", VA = "0x187E9D990")]
		public void Show(object LAAJFAFNFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D8A0", Offset = "0x7E9BEA0", VA = "0x187E9D8A0")]
		public void Set(object LAAJFAFNFCN, bool EIPKGMMOGAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D500", Offset = "0x7E9BB00", VA = "0x187E9D500")]
		public void Clear(bool CCHOIGEHABH = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D5C0", Offset = "0x7E9BBC0", VA = "0x187E9D5C0")]
		private void MKCIDOLIGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D740", Offset = "0x7E9BD40", VA = "0x187E9D740")]
		[IteratorStateMachine(typeof(MKGFMBFBJHJ))]
		private IEnumerator<FBLKJCIOKGP> NLAKMMIMPAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D570", Offset = "0x7E9BB70", VA = "0x187E9D570", Slot = "5")]
		public virtual void DoHideOrShow(bool KCDGNFENFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7E9D9A0", Offset = "0x7E9BFA0", VA = "0x187E9D9A0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OGEKNLJGAIG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xBB40B0", Offset = "0xBB26B0", VA = "0x180BB40B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x950420", Offset = "0x94EA20", VA = "0x180950420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> KAEIKMECHCK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7E9DE40", Offset = "0x7E9C440", VA = "0x187E9DE40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7E9DFA0", Offset = "0x7E9C5A0", VA = "0x187E9DFA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> OGMNHANOOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7E9DEF0", Offset = "0x7E9C4F0", VA = "0x187E9DEF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7E9E050", Offset = "0x7E9C650", VA = "0x187E9E050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E9DE00", Offset = "0x7E9C400", VA = "0x187E9DE00", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E9DE20", Offset = "0x7E9C420", VA = "0x187E9DE20", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData NBGBHBICCPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1530A40", Offset = "0x152F040", VA = "0x181530A40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1530A40", Offset = "0x152F040", VA = "0x181530A40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AMOLKPHMOLG
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum CHLALAKIKKP
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static CDIHIOEBGKL JINKIEJFOLF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static CDIHIOEBGKL COBMNPFDHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7E9C4B0", Offset = "0x7E9AAB0", VA = "0x187E9C4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static CHLALAKIKKP KLEBPGEJIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7E9C710", Offset = "0x7E9AD10", VA = "0x187E9C710")]
		get
		{
			return default(CHLALAKIKKP);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7E9C5B0", Offset = "0x7E9ABB0", VA = "0x187E9C5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<CHLALAKIKKP> IDMBJBJNMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7E9C3D0", Offset = "0x7E9A9D0", VA = "0x187E9C3D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7E9C2F0", Offset = "0x7E9A8F0", VA = "0x187E9C2F0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CLCEOCJFNLP : ACOOILMEBEN, JMDELBOFLAD, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, GJJMKPDIPEI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FKDOIPNGGAF CGFJLPLAIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEIHFJALFJE Clear();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject CFENBMBECBB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AEIHFJALFJE Spawn<T>(int NHDCGAPNBCD, IReadOnlyList<T> GIDGOODJFLJ, GameObject CFENBMBECBB);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AEIHFJALFJE Spawn<T>(int NHDCGAPNBCD, IReadOnlyList<T> GIDGOODJFLJ, GameObject GOBPHMJGIOH, Func<int, GameObject> OLDIHECCPOB);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int EAHKFAJBNDN, float JPAENGJFGOI);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum FFEPLDOEHPB : byte
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
		private static readonly int BNFBPLBIPIH;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<FFEPLDOEHPB, string> FEIPMJKPHJJ;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int CACFHPFGECO = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int NDNFFOFGLPI;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int HGMAFOEALCC;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int KCNJPEOHDPN;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int CNJAFBPKAAA;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int OHLIKDJAOHF;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int CNLBEMKGFJN;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int KOLFIBPOPAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool OKCHILEPJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool HOIHBBEAIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Color[] NGKLGKFMNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private FFEPLDOEHPB type;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly FFEPLDOEHPB[] MDFFBAJOBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[FKOECLOBFCN("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly FFEPLDOEHPB[] IMBAMGLLEBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[FKOECLOBFCN("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[FKOECLOBFCN("type", FFEPLDOEHPB.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[FKOECLOBFCN("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic HHAPEIMFECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool MAPLGMINLPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient HGNFLKMAJFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0CF0", Offset = "0x7E9F2F0", VA = "0x187EA0CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public FFEPLDOEHPB LNMDBHDAJAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAFC4F0", Offset = "0xAFAAF0", VA = "0x180AFC4F0")]
			get
			{
				return default(FFEPLDOEHPB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0E70", Offset = "0x7E9F470", VA = "0x187EA0E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool MCJCBNLOJCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7E9F670", Offset = "0x7E9DC70", VA = "0x187E9F670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 IOLANELHHKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0C60", Offset = "0x7E9F260", VA = "0x187EA0C60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0CA0", Offset = "0x7E9F2A0", VA = "0x187EA0CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool CNPJPBKBMEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0530", Offset = "0x7E9EB30", VA = "0x187EA0530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 PKJENICKIKL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0C80", Offset = "0x7E9F280", VA = "0x187EA0C80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0E20", Offset = "0x7E9F420", VA = "0x187EA0E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float LIAHHFLJBAN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB45930", Offset = "0xB43F30", VA = "0x180B45930")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1F321A0", Offset = "0x1F307A0", VA = "0x181F321A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 NOOEDJEGCOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7EA04E0", Offset = "0x7E9EAE0", VA = "0x187EA04E0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 LPIOBLPAMGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7EA05A0", Offset = "0x7E9EBA0", VA = "0x187EA05A0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float OOKDMLFCBIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x96C900", Offset = "0x96AF00", VA = "0x18096C900")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7EA0E80", Offset = "0x7E9F480", VA = "0x187EA0E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7EA0610", Offset = "0x7E9EC10", VA = "0x187EA0610", Slot = "12")]
		protected override void KEAAJDMEBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7EA0350", Offset = "0x7E9E950", VA = "0x187EA0350")]
		private void DFODIHPMJAF(Color[] OFGJFMEFBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F900", Offset = "0x7E9DF00", VA = "0x187E9F900", Slot = "13")]
		protected override void CPBJONAGHAA(Material HJCEHLILOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F6E0", Offset = "0x7E9DCE0", VA = "0x187E9F6E0", Slot = "14")]
		protected override void BMJNDHAEIKJ(Material HJCEHLILOIG, bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7EA0BB0", Offset = "0x7E9F1B0", VA = "0x187EA0BB0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly PNFJEJKDDGE AFDGAKFNMEG;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Sprite PIODGBAFPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material PFHIGKBMJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material PFHJOFPFGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool PDAFAHMIOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool JNBOIMABFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool ODGJLAONILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool HCAMMNGIHHP;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic HHAPEIMFECJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader JOLGIKEHAAN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool MAPLGMINLPF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool MOEPNMPKNPK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform MBGOJBHDKDF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7EA2C70", Offset = "0x7EA1270", VA = "0x187EA2C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect ICEAKJNMKEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7EA2B00", Offset = "0x7EA1100", VA = "0x187EA2B00")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite HIOLIFEFDNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7EA1E60", Offset = "0x7EA0460", VA = "0x187EA1E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7EA22C0", Offset = "0x7EA08C0", VA = "0x187EA22C0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2E10", Offset = "0x7EA1410", VA = "0x187EA2E10", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3110", Offset = "0x7EA1710", VA = "0x187EA3110", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2FC0", Offset = "0x7EA15C0", VA = "0x187EA2FC0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7EA24B0", Offset = "0x7EA0AB0", VA = "0x187EA24B0")]
		private void BJGEOFIEAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2640", Offset = "0x7EA0C40", VA = "0x187EA2640")]
		private void BNMHKNKILAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3120", Offset = "0x7EA1720", VA = "0x187EA3120")]
		private void PJLCBKDPDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2C20", Offset = "0x7EA1220", VA = "0x187EA2C20")]
		private void KAJAECNCILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2050", Offset = "0x7EA0650", VA = "0x187EA2050")]
		protected void AODAKGKIANN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA2CD0", Offset = "0x7EA12D0", VA = "0x187EA2CD0")]
		private void MJHHNBLECIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "12")]
		protected virtual void KEAAJDMEBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "13")]
		protected virtual void CPBJONAGHAA(Material HJCEHLILOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "14")]
		protected virtual void BMJNDHAEIKJ(Material HJCEHLILOIG, bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA27B0", Offset = "0x7EA0DB0", VA = "0x187EA27B0")]
		private void GEBEGJAMAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
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
		private static readonly int OADOMELEDHO;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int KMAPEBNHOIM;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int CAICDFPMAFF;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int AANGJAEDOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
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
		private Color[] NGKLGKFMNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private float[] APMNHLANECF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic HHAPEIMFECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool MOEPNMPKNPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> EEGLGKEMDDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 IOLANELHHKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7EA3C50", Offset = "0x7EA2250", VA = "0x187EA3C50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7EA3C70", Offset = "0x7EA2270", VA = "0x187EA3C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3850", Offset = "0x7EA1E50", VA = "0x187EA3850")]
		public void SetRingLayers(IReadOnlyList<RingLayer> IEAFBDEBBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3610", Offset = "0x7EA1C10", VA = "0x187EA3610")]
		public bool SetRingLayerColor(int GKKHJGBAALN, Color NHCBHMJDLHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3760", Offset = "0x7EA1D60", VA = "0x187EA3760")]
		public bool SetRingLayerSize(int GKKHJGBAALN, float IBMHAIHIDJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7EA34D0", Offset = "0x7EA1AD0", VA = "0x187EA34D0", Slot = "12")]
		protected override void KEAAJDMEBAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3350", Offset = "0x7EA1950", VA = "0x187EA3350", Slot = "13")]
		protected override void CPBJONAGHAA(Material HJCEHLILOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3300", Offset = "0x7EA1900", VA = "0x187EA3300", Slot = "14")]
		protected override void BMJNDHAEIKJ(Material HJCEHLILOIG, bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7EA39A0", Offset = "0x7EA1FA0", VA = "0x187EA39A0")]
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
		public enum PONGKBAFJCI
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int JKBCGLFCEOO;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int BMOBIIKHKMP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int NMMOCNIFBKL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int LMDFIHCLNAM;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int EDFOOMANIAA;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int PMDGMLFCKKP;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int AGEOJEKKPDI;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int PPEAFKAAPJF;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int BNONKFEGOHM;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int NINFODFIFMD;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int BOLDGNOEDCD;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int JPOGOAFMMHD;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int LFJFPOAIHOD;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int ELMDDHEKFKF;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int JAJBCCECDEH;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int APBGKPLEIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
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
		[SerializeField]
		[Tooltip("A constant local-space animation speed applied across the whole image.")]
		private Vector2 velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Range(0f, 360f)]
		[SerializeField]
		private float angle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private PONGKBAFJCI animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[FKOECLOBFCN("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[FKOECLOBFCN("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic HHAPEIMFECJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool MOEPNMPKNPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite BGGGNJOANDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4AE0", Offset = "0x7EA30E0", VA = "0x187EA4AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4D00", Offset = "0x7EA3300", VA = "0x187EA4D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color ANIIKPNPJKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD4E4C0", Offset = "0xD4CAC0", VA = "0x180D4E4C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4D90", Offset = "0x7EA3390", VA = "0x187EA4D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color LJGAHJCHKNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xEFA0D0", Offset = "0xEF86D0", VA = "0x180EFA0D0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4BD0", Offset = "0x7EA31D0", VA = "0x187EA4BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float NLHHLPGAAHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB450A0", Offset = "0xB436A0", VA = "0x180B450A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4C90", Offset = "0x7EA3290", VA = "0x187EA4C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 BCOCJKCMJII
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4AC0", Offset = "0x7EA30C0", VA = "0x187EA4AC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4CB0", Offset = "0x7EA32B0", VA = "0x187EA4CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float MBLKEEKGIMP
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x96C550", Offset = "0x96AB50", VA = "0x18096C550")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4C50", Offset = "0x7EA3250", VA = "0x187EA4C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 IMKEKDHANPL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x12E77C0", Offset = "0x12E5DC0", VA = "0x1812E77C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4E10", Offset = "0x7EA3410", VA = "0x187EA4E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float PCPFIFCFEOE
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xEE6790", Offset = "0xEE4D90", VA = "0x180EE6790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4BA0", Offset = "0x7EA31A0", VA = "0x187EA4BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 FMOLPGLIINA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7EA46C0", Offset = "0x7EA2CC0", VA = "0x187EA46C0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public PONGKBAFJCI EIOPDNIBCED
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xCE8AF0", Offset = "0xCE70F0", VA = "0x180CE8AF0")]
			get
			{
				return default(PONGKBAFJCI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4BC0", Offset = "0x7EA31C0", VA = "0x187EA4BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float DBKMLLIFBKD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1458B10", Offset = "0x1457110", VA = "0x181458B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4C70", Offset = "0x7EA3270", VA = "0x187EA4C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float LGLMOJFOKCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x140AD60", Offset = "0x1409360", VA = "0x18140AD60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4B80", Offset = "0x7EA3180", VA = "0x187EA4B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3D10", Offset = "0x7EA2310", VA = "0x187EA3D10", Slot = "13")]
		protected override void CPBJONAGHAA(Material HJCEHLILOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4410", Offset = "0x7EA2A10", VA = "0x187EA4410")]
		private void GGMFMEICOHD(Sprite HPPCDBBBHGH, [Out] Vector2 BNLPNHGNPBO, [Out] Vector2 CPDDFHJFHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EA3CC0", Offset = "0x7EA22C0", VA = "0x187EA3CC0", Slot = "14")]
		protected override void BMJNDHAEIKJ(Material HJCEHLILOIG, bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4A30", Offset = "0x7EA3030", VA = "0x187EA4A30")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Shader HAHCJDEDEDC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader JOLGIKEHAAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7EA4EB0", Offset = "0x7EA34B0", VA = "0x187EA4EB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7EA4E60", Offset = "0x7EA3460", VA = "0x187EA4E60")]
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
		private SerializableRectTransform BPNAJLIDGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool GINDDKPNFAK;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F1A0", Offset = "0x7E9D7A0", VA = "0x187E9F1A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F480", Offset = "0x7E9DA80", VA = "0x187E9F480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F330", Offset = "0x7E9D930", VA = "0x187E9F330")]
		private void FKDCNDNEPGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E9F3B0", Offset = "0x7E9D9B0", VA = "0x187E9F3B0")]
		private void MKCIDOLIGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PNFJEJKDDGE
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct KEGJBFIHIIO : IEquatable<KEGJBFIHIIO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Component BPPCEJGCMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Action HKAMBGDEKDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int FBAINLHFFBN;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component KKKLHABLMLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7E9E220", Offset = "0x7E9C820", VA = "0x187E9E220")]
		public KEGJBFIHIIO(Component BPPCEJGCMKA, Action HKAMBGDEKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7E9E1A0", Offset = "0x7E9C7A0", VA = "0x187E9E1A0")]
		public void JIBIDAAECFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7E9E100", Offset = "0x7E9C700", VA = "0x187E9E100", Slot = "4")]
		public bool Equals(KEGJBFIHIIO OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E9E110", Offset = "0x7E9C710", VA = "0x187E9E110", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class BGELEIICOKB : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public PNFJEJKDDGE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
		[DebuggerHidden]
		public BGELEIICOKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E9C840", Offset = "0x7E9AE40", VA = "0x187E9C840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7E9CC00", Offset = "0x7E9B200", VA = "0x187E9CC00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly OIMEBHOMAGD LFGBMCCIBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int ELGBFDNLFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int NLNFLKLCGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Func<Component, float> BFHJBANPPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<Component, KEGJBFIHIIO> JNBHMIGCAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<KEGJBFIHIIO> MJBFGLGLKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly List<KEGJBFIHIIO> OJJGHOPEJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private HPLGDNGCOKN BJKLLPEIMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private BPJLCHCNDMD LABPGDNJOEO;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private BPJLCHCNDMD MBDIGPMMHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EA80", Offset = "0x7E9D080", VA = "0x187E9EA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E9F020", Offset = "0x7E9D620", VA = "0x187E9F020")]
	public PNFJEJKDDGE(OIMEBHOMAGD LFGBMCCIBAB, int ELGBFDNLFOD = -1, int NLNFLKLCGDD = -1, [Optional] Func<Component, float> BFHJBANPPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E9EDA0", Offset = "0x7E9D3A0", VA = "0x187E9EDA0")]
	public void PHMKDIIFKPL(Component BPPCEJGCMKA, Action FFEBDLHFDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E9E7F0", Offset = "0x7E9CDF0", VA = "0x187E9E7F0")]
	public void ABDNJBGEGLB(Component BPPCEJGCMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E9ED40", Offset = "0x7E9D340", VA = "0x187E9ED40")]
	public bool PCKPFHHNFJG(Component MEFMJJOMDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E9EB10", Offset = "0x7E9D110", VA = "0x187E9EB10")]
	private void KJKOJCHGJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E9EA00", Offset = "0x7E9D000", VA = "0x187E9EA00")]
	[IteratorStateMachine(typeof(BGELEIICOKB))]
	private IEnumerator<FBLKJCIOKGP> IAINANFLALF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xB42E30", Offset = "0xB41430", VA = "0x180B42E30")]
	[CompilerGenerated]
	private void BDFDFNDHGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E9E980", Offset = "0x7E9CF80", VA = "0x187E9E980")]
	[CompilerGenerated]
	private float ADMNJBCKBLB(KEGJBFIHIIO FFEBDLHFDKK)
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
