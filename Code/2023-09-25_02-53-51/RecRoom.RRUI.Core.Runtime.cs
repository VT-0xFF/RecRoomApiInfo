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
				[Cpp2IlInjected.Address(RVA = "0x62C68E0", Offset = "0x62C5CE0", VA = "0x1862C68E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x62C6940", Offset = "0x62C5D40", VA = "0x1862C6940")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x62C6890", Offset = "0x62C5C90", VA = "0x1862C6890")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x62C64B0", Offset = "0x62C58B0", VA = "0x1862C64B0")]
			public void GLEFHIFCAOK(PointerEventData KMGBIDPLFEB, RectTransform EECOKCNFIHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x62C65B0", Offset = "0x62C59B0", VA = "0x1862C65B0")]
			public void MCHIIEGGFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x62C63D0", Offset = "0x62C57D0", VA = "0x1862C63D0")]
			public void BCMCGMKGFPK(PointerEventData KMGBIDPLFEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x62C6840", Offset = "0x62C5C40", VA = "0x1862C6840")]
			public void MNPGNFJLKDJ(float FBEFCEJLPOM, RectTransform EECOKCNFIHI, Vector3 EDOEDBAJLGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[BEGIBHGLGBK(OECFEFOEJFL.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly KNCNJDFAHCK<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly KNCNJDFAHCK<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly KNCNJDFAHCK<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly KNCNJDFAHCK<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly KNCNJDFAHCK<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HJKDHGFMLBJ PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData CECCPKGOKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool BLLENHEEMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool PMDIFMCHGHM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BLFMFIGDLJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x76A330", Offset = "0x769730", VA = "0x18076A330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x62C5B90", Offset = "0x62C4F90", VA = "0x1862C5B90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FLKICIGOFBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x76A440", Offset = "0x769840", VA = "0x18076A440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x62C5B60", Offset = "0x62C4F60", VA = "0x1862C5B60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62C5BC0", Offset = "0x62C4FC0", VA = "0x1862C5BC0")]
		private bool NHKAPLOKBBC(PointerEventData NBKAJLKMOGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62C6090", Offset = "0x62C5490", VA = "0x1862C6090", Slot = "5")]
		public void OnPointerDown(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62C6150", Offset = "0x62C5550", VA = "0x1862C6150", Slot = "11")]
		public void OnPointerUp(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62C5F00", Offset = "0x62C5300", VA = "0x1862C5F00", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62C5C40", Offset = "0x62C5040", VA = "0x1862C5C40", Slot = "7")]
		public void OnBeginDrag(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62C5D50", Offset = "0x62C5150", VA = "0x1862C5D50", Slot = "4")]
		public void OnDrag(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62C5E30", Offset = "0x62C5230", VA = "0x1862C5E30", Slot = "8")]
		public void OnEndDrag(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x62C60F0", Offset = "0x62C54F0", VA = "0x1862C60F0", Slot = "9")]
		public void OnPointerEnter(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62C6120", Offset = "0x62C5520", VA = "0x1862C6120", Slot = "10")]
		public void OnPointerExit(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62C5D10", Offset = "0x62C5110", VA = "0x1862C5D10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x62C61B0", Offset = "0x62C55B0", VA = "0x1862C61B0")]
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
		private OptionData ECJGLFDIDFE;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x62C2D80", Offset = "0x62C2180", VA = "0x1862C2D80", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x62C2C80", Offset = "0x62C2080", VA = "0x1862C2C80", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x62C2BD0", Offset = "0x62C1FD0", VA = "0x1862C2BD0")]
		private void IBCJGIGOPFO(GameObject KHEDDDIEAHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x62C3040", Offset = "0x62C2440", VA = "0x1862C3040")]
		public void SetOptionsWithNoDefault(List<string> FDELOOBEEJI, [Optional] string JCDCMNLKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62C2F50", Offset = "0x62C2350", VA = "0x1862C2F50")]
		public void SetOptionsWithNoDefault(List<OptionData> MJHKFBFAIOB, [Optional] string JCDCMNLKJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x62C2E80", Offset = "0x62C2280", VA = "0x1862C2E80", Slot = "42")]
		public override void OnPointerClick(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x763220", Offset = "0x762620", VA = "0x180763220", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas NFOFEHCBNMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62C3270", Offset = "0x62C2670", VA = "0x1862C3270")]
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
		private sealed class GMFDEOFNOEE : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private AOAPPGOKEOI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
			[DebuggerHidden]
			public GMFDEOFNOEE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x62C32C0", Offset = "0x62C26C0", VA = "0x1862C32C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x62C37B0", Offset = "0x62C2BB0", VA = "0x1862C37B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[BEGIBHGLGBK(OECFEFOEJFL.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[NPINIMCHPKM(OECFEFOEJFL.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly ILIODHAIMDL POBNNHJANJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool NGIGEPLDNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3? NOCMPDIPONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool? KFGOCLFPHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool? CEGHFEBLEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool JPFNMLIEKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool DDIMJKLHLPB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HGKKFBFMOBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x62C3E80", Offset = "0x62C3280", VA = "0x1862C3E80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KBLGDDDCKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x62C3E60", Offset = "0x62C3260", VA = "0x1862C3E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HCODCCAIFIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xC74220", Offset = "0xC73620", VA = "0x180C74220")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x62C4030", Offset = "0x62C3430", VA = "0x1862C4030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action LELLKJKDKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x62C3DC0", Offset = "0x62C31C0", VA = "0x1862C3DC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x62C3F90", Offset = "0x62C3390", VA = "0x1862C3F90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62C3800", Offset = "0x62C2C00", VA = "0x1862C3800")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62C3B90", Offset = "0x62C2F90", VA = "0x1862C3B90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x62C38D0", Offset = "0x62C2CD0", VA = "0x1862C38D0")]
		public void Hide(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62C3CC0", Offset = "0x62C30C0", VA = "0x1862C3CC0")]
		public void Show(object IBLOMPOENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62C3C20", Offset = "0x62C3020", VA = "0x1862C3C20")]
		public void Set(object IBLOMPOENGH, bool GIFCDEDEPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62C39D0", Offset = "0x62C2DD0", VA = "0x1862C39D0")]
		private void KDNDILMGOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62C3950", Offset = "0x62C2D50", VA = "0x1862C3950")]
		[IteratorStateMachine(typeof(GMFDEOFNOEE))]
		private IEnumerator<AOAPPGOKEOI> JJJPNGBDHHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62C3890", Offset = "0x62C2C90", VA = "0x1862C3890", Slot = "5")]
		public virtual void DoHideOrShow(bool LIIPLBIOGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62C3D40", Offset = "0x62C3140", VA = "0x1862C3D40")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MJPFCMDMHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x804D90", Offset = "0x804190", VA = "0x180804D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x764440", Offset = "0x763840", VA = "0x180764440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> IGMBKFBDOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x62C4190", Offset = "0x62C3590", VA = "0x1862C4190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x62C42F0", Offset = "0x62C36F0", VA = "0x1862C42F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> HJBHMBLBMON
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x62C4240", Offset = "0x62C3640", VA = "0x1862C4240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x62C43A0", Offset = "0x62C37A0", VA = "0x1862C43A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62C4150", Offset = "0x62C3550", VA = "0x1862C4150", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x62C4170", Offset = "0x62C3570", VA = "0x1862C4170", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData NBKAJLKMOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xB67990", Offset = "0xB66D90", VA = "0x180B67990")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB67990", Offset = "0xB66D90", VA = "0x180B67990")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DCANMPIALFN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MBNAOEOBOKE
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static EGHCFFGENEP BHCMPNCPIDI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static EGHCFFGENEP JPLOFOKPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x62C2A20", Offset = "0x62C1E20", VA = "0x1862C2A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static MBNAOEOBOKE BBMIMAJKBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62C2790", Offset = "0x62C1B90", VA = "0x1862C2790")]
		get
		{
			return default(MBNAOEOBOKE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x62C28C0", Offset = "0x62C1CC0", VA = "0x1862C28C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<MBNAOEOBOKE> HOMEGCGPMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62C26B0", Offset = "0x62C1AB0", VA = "0x1862C26B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62C2AF0", Offset = "0x62C1EF0", VA = "0x1862C2AF0")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GHGEEBHCPNK : FKABLLNAFLC, NNEAMIPIMPD, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LINIMCFGJKE<GameObject, int> MFLJJDKGHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JPKJNFPNANM<GameObject, int, bool> KOPMPJIGJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	KNCNJDFAHCK<bool> JKNAODFBNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ECIFIEJPJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float BMKJOCBIACO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KNCNJDFAHCK<float> LANEOOGMBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HJKDHGFMLBJ AONFDLLMAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SpawnLoadingPlaceholders(GameObject BDNIDEKLIGD);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KBDGBPHCLNK Spawn<T>(int MFPNLBCMKOC, IReadOnlyList<T> OOIBMCBCEPD, GameObject BDNIDEKLIGD);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KBDGBPHCLNK Spawn<T>(int MFPNLBCMKOC, IReadOnlyList<T> OOIBMCBCEPD, GameObject FMPOABBPMCD, Func<int, GameObject> BPHJHIOFFPG);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void SmoothScrollTo(int JPEMHHILGGG, float AGBBKBPHOJA);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum DHNPOJJKHLI : byte
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

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly int JICNBOAPEJB;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Dictionary<DHNPOJJKHLI, string> BELODCGJLAH;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const int BLJIPBAJKPO = 32;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int IOAMAPIHBOC;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int BLLDGOMONMG;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int HKDNCNNDICH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int MNNGPLHKGCP;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int CMLCKHNDIME;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int MKOLJOANJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[BEGIBHGLGBK(OECFEFOEJFL.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool KNLMFKKLGGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool GONFJAFNGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] FLLJEHJFHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private DHNPOJJKHLI type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly DHNPOJJKHLI[] GNPDFEDJJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[PPLPIHAJNHD("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly DHNPOJJKHLI[] HKBCMHHPCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[PPLPIHAJNHD("ShouldUseScale")]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[PPLPIHAJNHD("type", DHNPOJJKHLI.CustomDirection)]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[PPLPIHAJNHD("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override Graphic NKOOCKHKKJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool BFDFBCCAEPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Gradient DHMBGIOEFIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7653E0", Offset = "0x7647E0", VA = "0x1807653E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x62C59B0", Offset = "0x62C4DB0", VA = "0x1862C59B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DHNPOJJKHLI EMLIJIGFNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA1F5E0", Offset = "0xA1E9E0", VA = "0x180A1F5E0")]
			get
			{
				return default(DHNPOJJKHLI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x62C5B30", Offset = "0x62C4F30", VA = "0x1862C5B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private bool NMNGIPIBPFL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x62C48D0", Offset = "0x62C3CD0", VA = "0x1862C48D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 ENEDKFDILDC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x62C5920", Offset = "0x62C4D20", VA = "0x1862C5920")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x62C5960", Offset = "0x62C4D60", VA = "0x1862C5960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private bool IHDDBEADEKE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x62C4860", Offset = "0x62C3C60", VA = "0x1862C4860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 AIHDEOGABIC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x62C5940", Offset = "0x62C4D40", VA = "0x1862C5940")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x62C5AE0", Offset = "0x62C4EE0", VA = "0x1862C5AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float OMLIIBJNFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x11F2F30", Offset = "0x11F2330", VA = "0x1811F2F30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x11FD270", Offset = "0x11FC670", VA = "0x1811FD270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Vector2 CGIHNMABJHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x62C5410", Offset = "0x62C4810", VA = "0x1862C5410")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Vector2 ALOHJGEBHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x62C4AD0", Offset = "0x62C3ED0", VA = "0x1862C4AD0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float KCDLDEIFBDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x77E7B0", Offset = "0x77DBB0", VA = "0x18077E7B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x62C5B40", Offset = "0x62C4F40", VA = "0x1862C5B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62C46C0", Offset = "0x62C3AC0", VA = "0x1862C46C0", Slot = "12")]
		protected override void AEJPHDHMDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x62C4940", Offset = "0x62C3D40", VA = "0x1862C4940")]
		private void JJEFBDFIBLO(Color[] LLAHPCKKCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62C4D80", Offset = "0x62C4180", VA = "0x1862C4D80", Slot = "13")]
		protected override void LBMFPAMMKCL(Material CFMOAHBPGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x62C4B60", Offset = "0x62C3F60", VA = "0x1862C4B60", Slot = "14")]
		protected override void LACKDLKHDJD(Material CFMOAHBPGNP, bool GGJLDJABGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62C5870", Offset = "0x62C4C70", VA = "0x1862C5870")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly AMDPBAEPBGK IAONEGMKCJC;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite EJMGCEOCBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material MAIPAOOHKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material NMMEALNFBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool OHHGIMLBOCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool NGIGEPLDNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool OOKGPNBHIMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool OLOFCGPMJAE;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public abstract Graphic NKOOCKHKKJL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public abstract Shader IDCDJHLBOKG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool BFDFBCCAEPA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected virtual bool OHBNGCOHOAK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7AD280", Offset = "0x7AC680", VA = "0x1807AD280", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected RectTransform EECOKCNFIHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x62C7040", Offset = "0x62C6440", VA = "0x1862C7040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected Rect MIFCBGDOODH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x62C7890", Offset = "0x62C6C90", VA = "0x1862C7890")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected static Sprite NLLKODEDNLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x62C70A0", Offset = "0x62C64A0", VA = "0x1862C70A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62C6C70", Offset = "0x62C6070", VA = "0x1862C6C70", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62C79B0", Offset = "0x62C6DB0", VA = "0x1862C79B0", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62C7CB0", Offset = "0x62C70B0", VA = "0x1862C7CB0", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62C7B60", Offset = "0x62C6F60", VA = "0x1862C7B60", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62C6EB0", Offset = "0x62C62B0", VA = "0x1862C6EB0")]
		private void CBHPOCHHPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62C7CC0", Offset = "0x62C70C0", VA = "0x1862C7CC0")]
		private void PNOAICLJKIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62C72A0", Offset = "0x62C66A0", VA = "0x1862C72A0")]
		private void HEMOBFCPJNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62C6E60", Offset = "0x62C6260", VA = "0x1862C6E60")]
		private void BANMALLCKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62C7620", Offset = "0x62C6A20", VA = "0x1862C7620")]
		protected void JJKNEIDDLII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62C6B30", Offset = "0x62C5F30", VA = "0x1862C6B30")]
		private void AFOIIGIHLNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "12")]
		protected virtual void AEJPHDHMDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "13")]
		protected virtual void LBMFPAMMKCL(Material CFMOAHBPGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "14")]
		protected virtual void LACKDLKHDJD(Material CFMOAHBPGNP, bool GGJLDJABGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62C72D0", Offset = "0x62C66D0", VA = "0x1862C72D0")]
		private void IPDJINMCJDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x763200", Offset = "0x762600", VA = "0x180763200")]
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
			[Range(0f, 2f)]
			[SerializeField]
			public float Size;
		}

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const int MaxRings = 4;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly int JAMPKAMOKNK;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int IFFCPJLHOKE;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int KKJIKGIPGCB;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int BGPCDJGKGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[BEGIBHGLGBK(OECFEFOEJFL.Self, false, false, false)]
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
		private Color[] FLLJEHJFHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] MKLOCFCCMBJ;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override Graphic NKOOCKHKKJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected override bool OHBNGCOHOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IReadOnlyList<RingLayer> IKJLNGDHMEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766D70", VA = "0x180767970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 ENEDKFDILDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x62C88F0", Offset = "0x62C7CF0", VA = "0x1862C88F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x62C8910", Offset = "0x62C7D10", VA = "0x1862C8910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62C8530", Offset = "0x62C7930", VA = "0x1862C8530")]
		public void SetRingLayers(IReadOnlyList<RingLayer> HLNMKFJNJNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62C82F0", Offset = "0x62C76F0", VA = "0x1862C82F0")]
		public bool SetRingLayerColor(int GCJEHMDFLNP, Color KKBAHNFNJMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62C8440", Offset = "0x62C7840", VA = "0x1862C8440")]
		public bool SetRingLayerSize(int GCJEHMDFLNP, float JGDHMDLNCOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62C7FE0", Offset = "0x62C73E0", VA = "0x1862C7FE0", Slot = "12")]
		protected override void AEJPHDHMDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x62C8170", Offset = "0x62C7570", VA = "0x1862C8170", Slot = "13")]
		protected override void LBMFPAMMKCL(Material CFMOAHBPGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62C8120", Offset = "0x62C7520", VA = "0x1862C8120", Slot = "14")]
		protected override void LACKDLKHDJD(Material CFMOAHBPGNP, bool GGJLDJABGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x62C8680", Offset = "0x62C7A80", VA = "0x1862C8680")]
		public UIRings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Tiler", 15)]
	public class UITiler : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum IHEIAKHDHCP
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int ADECFIGKJEC;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int CNEMBJNHGPG;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int OOJAIABHCGD;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int BJAKFHIIAND;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int LFLLFBPPKGN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int CCNGDMEPHJD;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int MCDLOOJKDFN;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int NLHMLLMEAIH;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int LNODCIDBHLD;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int NDIFCIGJPAA;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int MMNFFOJHIFO;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int FPFHJGDDGKO;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int OMHEAECMOJD;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int HNOHJCGDJMC;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int APLMHAKBHEL;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int IBMBADJAFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[BEGIBHGLGBK(OECFEFOEJFL.Self, false, false, false)]
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
		[SerializeField]
		[Tooltip("How many rows of tiles to fit within the object's rect.")]
		private float rows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		[Tooltip("The distance between each tile.")]
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
		private IHEIAKHDHCP animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[PPLPIHAJNHD("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[PPLPIHAJNHD("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override Graphic NKOOCKHKKJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x767750", Offset = "0x766B50", VA = "0x180767750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected override bool OHBNGCOHOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x77E3E0", Offset = "0x77D7E0", VA = "0x18077E3E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Sprite OIBBCACPCGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x62C9760", Offset = "0x62C8B60", VA = "0x1862C9760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x62C9980", Offset = "0x62C8D80", VA = "0x1862C9980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Color PMFELPDMJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x88A1D0", Offset = "0x8895D0", VA = "0x18088A1D0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x62C9A10", Offset = "0x62C8E10", VA = "0x1862C9A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color DKICDNEOCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x19D8220", Offset = "0x19D7620", VA = "0x1819D8220")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x62C9850", Offset = "0x62C8C50", VA = "0x1862C9850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float CEPGPMANJIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8EC080", Offset = "0x8EB480", VA = "0x1808EC080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x62C9910", Offset = "0x62C8D10", VA = "0x1862C9910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 BKIHFJBNLCG
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x19BFB00", Offset = "0x19BEF00", VA = "0x1819BFB00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x62C9930", Offset = "0x62C8D30", VA = "0x1862C9930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float MICBGPINKFK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x77E3F0", Offset = "0x77D7F0", VA = "0x18077E3F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x62C98D0", Offset = "0x62C8CD0", VA = "0x1862C98D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 PEDKAKGGDDF
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x984700", Offset = "0x983B00", VA = "0x180984700")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x62C9A90", Offset = "0x62C8E90", VA = "0x1862C9A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float JJBOMGHFGGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x98CBB0", Offset = "0x98BFB0", VA = "0x18098CBB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x62C9820", Offset = "0x62C8C20", VA = "0x1862C9820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Matrix4x4 HKALFLMLKOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x62C90B0", Offset = "0x62C84B0", VA = "0x1862C90B0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IHEIAKHDHCP BMDKJHJNCEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x93E0C0", Offset = "0x93D4C0", VA = "0x18093E0C0")]
			get
			{
				return default(IHEIAKHDHCP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x62C9840", Offset = "0x62C8C40", VA = "0x1862C9840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float GMIFIGGLMDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA785F0", Offset = "0xA779F0", VA = "0x180A785F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x62C98F0", Offset = "0x62C8CF0", VA = "0x1862C98F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float EPGFJDNDNNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xA78740", Offset = "0xA77B40", VA = "0x180A78740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x62C9800", Offset = "0x62C8C00", VA = "0x1862C9800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62C89B0", Offset = "0x62C7DB0", VA = "0x1862C89B0", Slot = "13")]
		protected override void LBMFPAMMKCL(Material CFMOAHBPGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62C9140", Offset = "0x62C8540", VA = "0x1862C9140")]
		private void MMKHPAPFECE(Sprite JMNIMFKILNB, [Out] Vector2 BCFFHDLOIIE, [Out] Vector2 BGGMNFGLMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62C8960", Offset = "0x62C7D60", VA = "0x1862C8960", Slot = "14")]
		protected override void LACKDLKHDJD(Material CFMOAHBPGNP, bool GGJLDJABGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62C96D0", Offset = "0x62C8AD0", VA = "0x1862C96D0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader CFAGIGFLAOC;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public sealed override Shader IDCDJHLBOKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x62C9B30", Offset = "0x62C8F30", VA = "0x1862C9B30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62C9AE0", Offset = "0x62C8EE0", VA = "0x1862C9AE0")]
		protected UIUberMaterialOverride()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AMDPBAEPBGK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct NJILACHGDCN : IEquatable<NJILACHGDCN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Component CNKGFJIJGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Action OINELJKIGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly int NAHNLKEBJAA;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Component KICFLDPKIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA95A00", Offset = "0xA94E00", VA = "0x180A95A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x62C4570", Offset = "0x62C3970", VA = "0x1862C4570")]
		public NJILACHGDCN(Component CNKGFJIJGPA, Action OINELJKIGAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x62C44F0", Offset = "0x62C38F0", VA = "0x1862C44F0")]
		public void HPOJNLGPELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x62C4450", Offset = "0x62C3850", VA = "0x1862C4450", Slot = "4")]
		public bool Equals(NJILACHGDCN KEEHOGPOIFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x62C4460", Offset = "0x62C3860", VA = "0x1862C4460", Slot = "0")]
		public override bool Equals(object IBBNLILJNEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x762180", Offset = "0x761580", VA = "0x180762180", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class APKFJLAHAGK : IEnumerator<AOAPPGOKEOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private AOAPPGOKEOI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AMDPBAEPBGK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private AOAPPGOKEOI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x767320", Offset = "0x766720", VA = "0x180767320")]
		[DebuggerHidden]
		public APKFJLAHAGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x763210", Offset = "0x762610", VA = "0x180763210", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x62C22A0", Offset = "0x62C16A0", VA = "0x1862C22A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62C2660", Offset = "0x62C1A60", VA = "0x1862C2660", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly BKEELODPLGM NPEICFPFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int PPEAKIEIFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly int GLINGHLJFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Func<Component, float> FBLLNMDCJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<Component, NJILACHGDCN> GHAPHHIFIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly LinkedList<NJILACHGDCN> IGCMMPEOENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly List<NJILACHGDCN> IMFGAEMEBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private GKKBBPDHGPP EDCCBMPINIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private CNPEPFCFPHF LOHECKEPFGK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private CNPEPFCFPHF LDCLGAJBLKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62C1C00", Offset = "0x62C1000", VA = "0x1862C1C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x62C2120", Offset = "0x62C1520", VA = "0x1862C2120")]
	public AMDPBAEPBGK(BKEELODPLGM NPEICFPFAEG, int PPEAKIEIFFG = -1, int GLINGHLJFMF = -1, [Optional] Func<Component, float> FBLLNMDCJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62C1920", Offset = "0x62C0D20", VA = "0x1862C1920")]
	public void BMBKCDAGMGI(Component CNKGFJIJGPA, Action PLBKMELAPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x62C1C70", Offset = "0x62C1070", VA = "0x1862C1C70")]
	public void GLLLAOFAKOC(Component CNKGFJIJGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62C1E00", Offset = "0x62C1200", VA = "0x1862C1E00")]
	public bool GNOFHOMGIKF(Component FNPIKAPNGBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x62C1EE0", Offset = "0x62C12E0", VA = "0x1862C1EE0")]
	private void OLIIFNCDEOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x62C1E60", Offset = "0x62C1260", VA = "0x1862C1E60")]
	[IteratorStateMachine(typeof(APKFJLAHAGK))]
	private IEnumerator<AOAPPGOKEOI> ILOAKCNNJGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7DF310", Offset = "0x7DE710", VA = "0x1807DF310")]
	[CompilerGenerated]
	private void GNDOHGFGCHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x62C1B80", Offset = "0x62C0F80", VA = "0x1862C1B80")]
	[CompilerGenerated]
	private float CDGOLKEJKOL(NJILACHGDCN PLBKMELAPOA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GOLBACLPDPL
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	JKKPPONCMFJ KFHLPEBMHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool BAJAEPHHEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	KNCNJDFAHCK<JKKPPONCMFJ> BKMKNPKKDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNIEGEDLDKG(JKKPPONCMFJ KFNNKAIBPFG, bool KBIMAOADOIE = false);
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
