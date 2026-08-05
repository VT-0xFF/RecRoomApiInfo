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
				[Cpp2IlInjected.Address(RVA = "0x76CAE70", Offset = "0x76C9870", VA = "0x1876CAE70")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x76CAED0", Offset = "0x76C98D0", VA = "0x1876CAED0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x76CAE30", Offset = "0x76C9830", VA = "0x1876CAE30")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x76CAD30", Offset = "0x76C9730", VA = "0x1876CAD30")]
			public void IAIDHDDJANN(PointerEventData IEMEFAINCFK, RectTransform LEFNNOGKKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x76CA970", Offset = "0x76C9370", VA = "0x1876CA970")]
			public void CIKFMIMEHEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x76CAC00", Offset = "0x76C9600", VA = "0x1876CAC00")]
			public void DDFDDBKEKLD(PointerEventData IEMEFAINCFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76CACE0", Offset = "0x76C96E0", VA = "0x1876CACE0")]
			public void FLIIBKNDNHP(float GDOGNBAOLGI, RectTransform LEFNNOGKKCD, Vector3 MBNCLINCGNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly ABIBNEMCANM<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ABIBNEMCANM<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly ABIBNEMCANM<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly ABIBNEMCANM<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly ABIBNEMCANM<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly APNHDGDPKOI PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData FLBECPEMBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool KPFFFCFODOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool CCPPHODKGAF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JCFLBJCNPGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8B0230", Offset = "0x8AEC30", VA = "0x1808B0230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x76CA720", Offset = "0x76C9120", VA = "0x1876CA720")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool ECBALEMALBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8B0100", Offset = "0x8AEB00", VA = "0x1808B0100")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x76CA180", Offset = "0x76C8B80", VA = "0x1876CA180")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76CA100", Offset = "0x76C8B00", VA = "0x1876CA100")]
		private bool MKMCCPKJJKE(PointerEventData JEAABFEJJGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76CA600", Offset = "0x76C9000", VA = "0x1876CA600", Slot = "5")]
		public void OnPointerDown(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76CA6C0", Offset = "0x76C90C0", VA = "0x1876CA6C0", Slot = "11")]
		public void OnPointerUp(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76CA470", Offset = "0x76C8E70", VA = "0x1876CA470", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76CA1B0", Offset = "0x76C8BB0", VA = "0x1876CA1B0", Slot = "7")]
		public void OnBeginDrag(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76CA2C0", Offset = "0x76C8CC0", VA = "0x1876CA2C0", Slot = "4")]
		public void OnDrag(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76CA3A0", Offset = "0x76C8DA0", VA = "0x1876CA3A0", Slot = "8")]
		public void OnEndDrag(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76CA660", Offset = "0x76C9060", VA = "0x1876CA660", Slot = "9")]
		public void OnPointerEnter(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x76CA690", Offset = "0x76C9090", VA = "0x1876CA690", Slot = "10")]
		public void OnPointerExit(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x76CA280", Offset = "0x76C8C80", VA = "0x1876CA280")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x76CA750", Offset = "0x76C9150", VA = "0x1876CA750")]
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
		[Cpp2IlInjected.Address(RVA = "0x76C5FA0", Offset = "0x76C49A0", VA = "0x1876C5FA0")]
		public void SetCanvasSortingOrder(short MPPODDJPBCD, bool AAHKGAPGODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData MKPGCDCIGKI;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x76C6260", Offset = "0x76C4C60", VA = "0x1876C6260", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x76C6140", Offset = "0x76C4B40", VA = "0x1876C6140", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x76C6090", Offset = "0x76C4A90", VA = "0x1876C6090")]
		private void BMIDCDKHCBC(GameObject IKIMGCFGOIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x76C6540", Offset = "0x76C4F40", VA = "0x1876C6540")]
		public void SetOptionsWithNoDefault(List<string> KJCKFFGBDON, [Optional] string OPBGFGIKCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x76C6450", Offset = "0x76C4E50", VA = "0x1876C6450")]
		public void SetOptionsWithNoDefault(List<OptionData> JKPMAFPDDOK, [Optional] string OPBGFGIKCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x76C6380", Offset = "0x76C4D80", VA = "0x1876C6380", Slot = "42")]
		public override void OnPointerClick(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas MCNGGLLMMBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76C6760", Offset = "0x76C5160", VA = "0x1876C6760")]
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
		private sealed class IAMNIDEGLDC : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private BGFOJNANPKN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
			[DebuggerHidden]
			public IAMNIDEGLDC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x76C7D80", Offset = "0x76C6780", VA = "0x1876C7D80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x76C8290", Offset = "0x76C6C90", VA = "0x1876C8290", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[HBLGLBJJBJP(CAHCDFDGNOL.Self, false, false, false)]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly COBNIIGNPJH<object> KNIAGFLHOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool DGBPBPIABDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? HAPOCAEAHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? EPEMBOFDFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? OGPKEGEPMPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool PPIBAJOCCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool NCIABHNOHMG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool DIEAHBBBLNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76C77A0", Offset = "0x76C61A0", VA = "0x1876C77A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HFMOMFEMCPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x76C7750", Offset = "0x76C6150", VA = "0x1876C7750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DFPCACOMEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8F77F0", Offset = "0x8F61F0", VA = "0x1808F77F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x76C7960", Offset = "0x76C6360", VA = "0x1876C7960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DGFFNLENIMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x76C76B0", Offset = "0x76C60B0", VA = "0x1876C76B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x76C78C0", Offset = "0x76C62C0", VA = "0x1876C78C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x76C70F0", Offset = "0x76C5AF0", VA = "0x1876C70F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76C7490", Offset = "0x76C5E90", VA = "0x1876C7490")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76C7440", Offset = "0x76C5E40", VA = "0x1876C7440")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x76C7230", Offset = "0x76C5C30", VA = "0x1876C7230")]
		public void Hide(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x76C7610", Offset = "0x76C6010", VA = "0x1876C7610")]
		public void Show(object AICEIDIHFDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x76C7520", Offset = "0x76C5F20", VA = "0x1876C7520")]
		public void Set(object AICEIDIHFDO, bool KOEMNFMEOLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x76C7180", Offset = "0x76C5B80", VA = "0x1876C7180")]
		public void Clear(bool GLJIPPCHLDH = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x76C72C0", Offset = "0x76C5CC0", VA = "0x1876C72C0")]
		private void NOMFBABEPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x76C7240", Offset = "0x76C5C40", VA = "0x1876C7240")]
		[IteratorStateMachine(typeof(IAMNIDEGLDC))]
		private IEnumerator<BGFOJNANPKN> NIEDBJJOFCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x76C71F0", Offset = "0x76C5BF0", VA = "0x1876C71F0", Slot = "5")]
		public virtual void DoHideOrShow(bool AHDOKAGNCPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76C7620", Offset = "0x76C6020", VA = "0x1876C7620")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DMJPGINLMBC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xBB0080", Offset = "0xBAEA80", VA = "0x180BB0080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B6BA0", VA = "0x1808B81A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> KJKNAODFOOA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x76C7AC0", Offset = "0x76C64C0", VA = "0x1876C7AC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x76C7C20", Offset = "0x76C6620", VA = "0x1876C7C20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> IDEJFOKPLMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x76C7B70", Offset = "0x76C6570", VA = "0x1876C7B70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x76C7CD0", Offset = "0x76C66D0", VA = "0x1876C7CD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x76C7A80", Offset = "0x76C6480", VA = "0x1876C7A80", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x76C7AA0", Offset = "0x76C64A0", VA = "0x1876C7AA0", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData JEAABFEJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x11F7050", Offset = "0x11F5A50", VA = "0x1811F7050")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x11F7050", Offset = "0x11F5A50", VA = "0x1811F7050")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GCOHHOBGDCO
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum MLCCBMMAPMO
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static PGAINGHNNBN GMGMNOILJCM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static PGAINGHNNBN LLOFFCBHLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x76C69B0", Offset = "0x76C53B0", VA = "0x1876C69B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static MLCCBMMAPMO POBKLBMGGOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x76C6880", Offset = "0x76C5280", VA = "0x1876C6880")]
		get
		{
			return default(MLCCBMMAPMO);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x76C6AB0", Offset = "0x76C54B0", VA = "0x1876C6AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<MLCCBMMAPMO> MCJMEBGDCMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x76C6C10", Offset = "0x76C5610", VA = "0x1876C6C10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x76C67B0", Offset = "0x76C51B0", VA = "0x1876C67B0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IIGEEKAEHNJ : BPCCANNNECH, OBPOOMOBJNO, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, IBLLJAJIGLP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	APNHDGDPKOI FFNOCHFJNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OLPMMAHKODD Clear();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject BBIOBOHHGAF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OLPMMAHKODD Spawn<T>(int OOLAGDHIBMA, IReadOnlyList<T> GGEMPJLCHFC, GameObject BBIOBOHHGAF);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OLPMMAHKODD Spawn<T>(int OOLAGDHIBMA, IReadOnlyList<T> GGEMPJLCHFC, GameObject CNAAGLAOEJP, Func<int, GameObject> CLENBNHFELB);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int GCBONJOGHCD, float NAJFKFOCIMG);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum KLONJHPCAIM : byte
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
		private static readonly int NGLFPJMKEIC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<KLONJHPCAIM, string> KJIOGGGAGBC;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int PFHIDOINCJG = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int NAMCCIJOJCH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int ONNPPJHFPPN;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int CAADLHKABMO;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int COBMNLEOKCB;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int DACEKBIMKGE;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int PJEHCNEFONI;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int KAMGBLPHLCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool LJMJEBEEGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool DGNJBICPJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Color[] PFBGMMADNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private KLONJHPCAIM type;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly KLONJHPCAIM[] AGFABFHFKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[AGHNKJDJPHK("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly KLONJHPCAIM[] JIALHACKCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[AGHNKJDJPHK("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[AGHNKJDJPHK("type", KLONJHPCAIM.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[AGHNKJDJPHK("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic EALEKJFAOAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool KKDJCCJCMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient ECFEACPGCIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x76C9F50", Offset = "0x76C8950", VA = "0x1876C9F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public KLONJHPCAIM DLLABFENMHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA895D0", Offset = "0xA87FD0", VA = "0x180A895D0")]
			get
			{
				return default(KLONJHPCAIM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x76CA0D0", Offset = "0x76C8AD0", VA = "0x1876CA0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool DCJGBMCHBDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x76C9900", Offset = "0x76C8300", VA = "0x1876C9900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 DAEGAMLNCEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x76C9EC0", Offset = "0x76C88C0", VA = "0x1876C9EC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x76C9F00", Offset = "0x76C8900", VA = "0x1876C9F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool IJNHABAIDEB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x76C9970", Offset = "0x76C8370", VA = "0x1876C9970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 LNDKEGEMBFL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x76C9EE0", Offset = "0x76C88E0", VA = "0x1876C9EE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x76CA080", Offset = "0x76C8A80", VA = "0x1876CA080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float ECGPGEGHJEP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xBF0910", Offset = "0xBEF310", VA = "0x180BF0910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1A4A320", Offset = "0x1A48D20", VA = "0x181A4A320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 PILDPFKGGBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x76C99E0", Offset = "0x76C83E0", VA = "0x1876C99E0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 FEBLMGBLGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x76C8AC0", Offset = "0x76C74C0", VA = "0x1876C8AC0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float BBDHEPGPHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8C79D0", Offset = "0x8C63D0", VA = "0x1808C79D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x76CA0E0", Offset = "0x76C8AE0", VA = "0x1876CA0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x76C9540", Offset = "0x76C7F40", VA = "0x1876C9540", Slot = "12")]
		protected override void IAJJKKPPHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76C8930", Offset = "0x76C7330", VA = "0x1876C8930")]
		private void CEOHFKGLNAK(Color[] CKLFJMEEBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x76C8B30", Offset = "0x76C7530", VA = "0x1876C8B30", Slot = "13")]
		protected override void GLADFPOEDFP(Material FLBCMGELMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x76C96E0", Offset = "0x76C80E0", VA = "0x1876C96E0", Slot = "14")]
		protected override void JPKNEAFBLOK(Material FLBCMGELMBF, bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x76C9E10", Offset = "0x76C8810", VA = "0x1876C9E10")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly ADLGDNMPDHB ELBFOGNCFGD;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Sprite MBGMDGODAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material CCLFMLEKGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material OJDHFLBABNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool NKAMMFLGMBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool DGBPBPIABDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool BABKMPMMOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool MAJHAHKPBLG;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic EALEKJFAOAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader NIBHJEAKIDB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool KKDJCCJCMPE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool GNONCBFAKJI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform LEFNNOGKKCD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x76CB7E0", Offset = "0x76CA1E0", VA = "0x1876CB7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect MPMCGHFNEBB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x76CBCD0", Offset = "0x76CA6D0", VA = "0x1876CBCD0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite DMPEJFBFGAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x76CB5B0", Offset = "0x76C9FB0", VA = "0x1876CB5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x76CB3C0", Offset = "0x76C9DC0", VA = "0x1876CB3C0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x76CC080", Offset = "0x76CAA80", VA = "0x1876CC080", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x76CC380", Offset = "0x76CAD80", VA = "0x1876CC380", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x76CC230", Offset = "0x76CAC30", VA = "0x1876CC230", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x76CB0C0", Offset = "0x76C9AC0", VA = "0x1876CB0C0")]
		private void AAJLBCPPHKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x76CB250", Offset = "0x76C9C50", VA = "0x1876CB250")]
		private void AALKAEPKLFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x76CC050", Offset = "0x76CAA50", VA = "0x1876CC050")]
		private void MNDMJDBDMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x76CB790", Offset = "0x76CA190", VA = "0x1876CB790")]
		private void CJHBIDJMBCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x76CBDF0", Offset = "0x76CA7F0", VA = "0x1876CBDF0")]
		protected void LGGPBKPAOPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76CB840", Offset = "0x76CA240", VA = "0x1876CB840")]
		private void HPPCNCPGHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "12")]
		protected virtual void IAJJKKPPHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "13")]
		protected virtual void GLADFPOEDFP(Material FLBCMGELMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "14")]
		protected virtual void JPKNEAFBLOK(Material FLBCMGELMBF, bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x76CB980", Offset = "0x76CA380", VA = "0x1876CB980")]
		private void JAJIIELPHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
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
		private static readonly int APHGHIBLLIN;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int PCKAPGFEGCO;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int HJODKOLMOJA;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int BBBIELAAJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
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
		private Color[] PFBGMMADNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private float[] JJJDDHEIDLH;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic EALEKJFAOAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool GNONCBFAKJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> AHKLPCJNFLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 DAEGAMLNCEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x76CCDB0", Offset = "0x76CB7B0", VA = "0x1876CCDB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x76CCDD0", Offset = "0x76CB7D0", VA = "0x1876CCDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x76CCA70", Offset = "0x76CB470", VA = "0x1876CCA70")]
		public void SetRingLayers(IReadOnlyList<RingLayer> IPOGDIBBIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76CC830", Offset = "0x76CB230", VA = "0x1876CC830")]
		public bool SetRingLayerColor(int FLMAECPLNCE, Color GNADFIPFMAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x76CC980", Offset = "0x76CB380", VA = "0x1876CC980")]
		public bool SetRingLayerSize(int FLMAECPLNCE, float LEGDMNLNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x76CC6A0", Offset = "0x76CB0A0", VA = "0x1876CC6A0", Slot = "12")]
		protected override void IAJJKKPPHLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x76CC530", Offset = "0x76CAF30", VA = "0x1876CC530", Slot = "13")]
		protected override void GLADFPOEDFP(Material FLBCMGELMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x76CC7E0", Offset = "0x76CB1E0", VA = "0x1876CC7E0", Slot = "14")]
		protected override void JPKNEAFBLOK(Material FLBCMGELMBF, bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x76CCBC0", Offset = "0x76CB5C0", VA = "0x1876CCBC0")]
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
		public enum KBMOKLGHJGN
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int ODMJFHPEMIL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int AFEAACLCJMI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int IPGDGMHFAHJ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int DMONFLBOKHJ;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int INCIHJOFEIB;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int LOJDELPONAN;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int JCMMOHLKGII;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int KLJGPDHNFPJ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ONFEKENIBNE;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int KMHACMOIGCF;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int DNENGGFGBAJ;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int EMGHNCCCOFL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int LHJEJHPGMCB;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int IHMMHINDOIL;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int MAKEKODICCE;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int BOMKGDGBALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
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
		private KBMOKLGHJGN animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[AGHNKJDJPHK("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[AGHNKJDJPHK("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic EALEKJFAOAB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool GNONCBFAKJI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite GNBPGBGAONJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x76CDBD0", Offset = "0x76CC5D0", VA = "0x1876CDBD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x76CDDF0", Offset = "0x76CC7F0", VA = "0x1876CDDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color DHEIGFLJIKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA895C0", Offset = "0xA87FC0", VA = "0x180A895C0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x76CDE80", Offset = "0x76CC880", VA = "0x1876CDE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color IMMDGFLGAJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xC09D30", Offset = "0xC08730", VA = "0x180C09D30")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x76CDCC0", Offset = "0x76CC6C0", VA = "0x1876CDCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float OLBDKENNGAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xBF0920", Offset = "0xBEF320", VA = "0x180BF0920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x76CDD80", Offset = "0x76CC780", VA = "0x1876CDD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 IGMABENDMAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x76CDBB0", Offset = "0x76CC5B0", VA = "0x1876CDBB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x76CDDA0", Offset = "0x76CC7A0", VA = "0x1876CDDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float FOEJOECEJIL
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8C7630", Offset = "0x8C6030", VA = "0x1808C7630")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x76CDD40", Offset = "0x76CC740", VA = "0x1876CDD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 CHGHINDIDJD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xFC8570", Offset = "0xFC6F70", VA = "0x180FC8570")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x76CDF00", Offset = "0x76CC900", VA = "0x1876CDF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float IHBFLFOOLPC
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xBD92A0", Offset = "0xBD7CA0", VA = "0x180BD92A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x76CDC90", Offset = "0x76CC690", VA = "0x1876CDC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 KHLJHJNDFMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x76CD4E0", Offset = "0x76CBEE0", VA = "0x1876CD4E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public KBMOKLGHJGN GIGAKPHFNAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9F8770", Offset = "0x9F7170", VA = "0x1809F8770")]
			get
			{
				return default(KBMOKLGHJGN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x76CDCB0", Offset = "0x76CC6B0", VA = "0x1876CDCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float HJJGOJDBFJK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x10CFE00", Offset = "0x10CE800", VA = "0x1810CFE00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x76CDD60", Offset = "0x76CC760", VA = "0x1876CDD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float LGHNEPGBKFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x10CFF50", Offset = "0x10CE950", VA = "0x1810CFF50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x76CDC70", Offset = "0x76CC670", VA = "0x1876CDC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x76CCE20", Offset = "0x76CB820", VA = "0x1876CCE20", Slot = "13")]
		protected override void GLADFPOEDFP(Material FLBCMGELMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x76CD570", Offset = "0x76CBF70", VA = "0x1876CD570")]
		private void IPPLKCGBJII(Sprite IFHBKNHOMCG, [Out] Vector2 AEFOGBGOCCF, [Out] Vector2 PHBHDODMMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x76CD820", Offset = "0x76CC220", VA = "0x1876CD820", Slot = "14")]
		protected override void JPKNEAFBLOK(Material FLBCMGELMBF, bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x76CDB20", Offset = "0x76CC520", VA = "0x1876CDB20")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Shader FNPNEGJONJA;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader NIBHJEAKIDB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x76CDFA0", Offset = "0x76CC9A0", VA = "0x1876CDFA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x76CDF50", Offset = "0x76CC950", VA = "0x1876CDF50")]
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
		private SerializableRectTransform KCPFNNBIPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool AAENLFBKGGG;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76C8470", Offset = "0x76C6E70", VA = "0x1876C8470")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x76C8750", Offset = "0x76C7150", VA = "0x1876C8750")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x76C8600", Offset = "0x76C7000", VA = "0x1876C8600")]
		private void CACPNGIGPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x76C8680", Offset = "0x76C7080", VA = "0x1876C8680")]
		private void NOMFBABEPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ADLGDNMPDHB
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct NDNMJDOFEDH : IEquatable<NDNMJDOFEDH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Component KMDNOIPDFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Action GMONNFJMKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int LIBPLIKNGPH;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component AAECKAINFLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x957780", Offset = "0x956180", VA = "0x180957780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x76C8400", Offset = "0x76C6E00", VA = "0x1876C8400")]
		public NDNMJDOFEDH(Component KMDNOIPDFGB, Action GMONNFJMKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x76C82E0", Offset = "0x76C6CE0", VA = "0x1876C82E0")]
		public void EJNOFFABAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x76C83F0", Offset = "0x76C6DF0", VA = "0x1876C83F0", Slot = "4")]
		public bool Equals(NDNMJDOFEDH GDOGPMPJPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x76C8360", Offset = "0x76C6D60", VA = "0x1876C8360", Slot = "0")]
		public override bool Equals(object BBNKFKDCOLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8AB1A0", Offset = "0x8A9BA0", VA = "0x1808AB1A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GEABOHJCMMG : IEnumerator<BGFOJNANPKN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private BGFOJNANPKN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public ADLGDNMPDHB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private BGFOJNANPKN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B2330", Offset = "0x8B0D30", VA = "0x1808B2330")]
		[DebuggerHidden]
		public GEABOHJCMMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x76C6CE0", Offset = "0x76C56E0", VA = "0x1876C6CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x76C70A0", Offset = "0x76C5AA0", VA = "0x1876C70A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly LICPEHAGMGN FDFLGBPAPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int DPNOBBIEGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int BPPFDJKKBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Func<Component, float> KOKHGMHEJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<Component, NDNMJDOFEDH> DANKCHAFJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<NDNMJDOFEDH> HEGHMLFGINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly List<NDNMJDOFEDH> OENEMJCPOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private OIMBFIPCENK BJKDIIKIPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private CPFOEKFFEAJ PEEJPKKMIJB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private CPFOEKFFEAJ NBGOLGMDODN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x76C5900", Offset = "0x76C4300", VA = "0x1876C5900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x76C5E20", Offset = "0x76C4820", VA = "0x1876C5E20")]
	public ADLGDNMPDHB(LICPEHAGMGN FDFLGBPAPAA, int DPNOBBIEGMA = -1, int BPPFDJKKBBH = -1, [Optional] Func<Component, float> KOKHGMHEJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x76C5A10", Offset = "0x76C4410", VA = "0x1876C5A10")]
	public void LLFGEBKDFMC(Component KMDNOIPDFGB, Action FAGENEAKFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x76C5C90", Offset = "0x76C4690", VA = "0x1876C5C90")]
	public void PKAIPGMKDAF(Component KMDNOIPDFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x76C55E0", Offset = "0x76C3FE0", VA = "0x1876C55E0")]
	public bool CIEOPEIAKJP(Component LHCHHCODKCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x76C5640", Offset = "0x76C4040", VA = "0x1876C5640")]
	private void EHABIPPLEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x76C5880", Offset = "0x76C4280", VA = "0x1876C5880")]
	[IteratorStateMachine(typeof(GEABOHJCMMG))]
	private IEnumerator<BGFOJNANPKN> FPPNBJDJAPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x98E640", Offset = "0x98D040", VA = "0x18098E640")]
	[CompilerGenerated]
	private void BKGHJNHKKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x76C5990", Offset = "0x76C4390", VA = "0x1876C5990")]
	[CompilerGenerated]
	private float ILKHEGPJHLD(NDNMJDOFEDH FAGENEAKFKC)
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
