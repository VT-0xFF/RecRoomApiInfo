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
				[Cpp2IlInjected.Address(RVA = "0x7293040", Offset = "0x7291640", VA = "0x187293040")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x72930A0", Offset = "0x72916A0", VA = "0x1872930A0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7292FF0", Offset = "0x72915F0", VA = "0x187292FF0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7292EF0", Offset = "0x72914F0", VA = "0x187292EF0")]
			public void OHHKIKAKDKC(PointerEventData NKDFHPNCPOB, RectTransform APEGCMDFJJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7292C60", Offset = "0x7291260", VA = "0x187292C60")]
			public void MCHJKNDFFJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7292B80", Offset = "0x7291180", VA = "0x187292B80")]
			public void FKAECGEAGKM(PointerEventData NKDFHPNCPOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7292B30", Offset = "0x7291130", VA = "0x187292B30")]
			public void BBIKJHIOALK(float IIJDEOCIIIM, RectTransform APEGCMDFJJO, Vector3 DJCNMBEIKME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly OIPILJJBCKA<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly OIPILJJBCKA<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly OIPILJJBCKA<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly OIPILJJBCKA<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly OIPILJJBCKA<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly AOBPFOPEJNG PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData BAOIIPGAHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool HBPHLPOJIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool FKIHLHOOFFB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DLJIKHDKCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x873610", Offset = "0x871C10", VA = "0x180873610")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x72922C0", Offset = "0x72908C0", VA = "0x1872922C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BGHFHLKBKKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8736E0", Offset = "0x871CE0", VA = "0x1808736E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x72922F0", Offset = "0x72908F0", VA = "0x1872922F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7292320", Offset = "0x7290920", VA = "0x187292320")]
		private bool LGOODEINMNG(PointerEventData JICPEOGMFIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72927F0", Offset = "0x7290DF0", VA = "0x1872927F0", Slot = "5")]
		public void OnPointerDown(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72928B0", Offset = "0x7290EB0", VA = "0x1872928B0", Slot = "11")]
		public void OnPointerUp(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7292660", Offset = "0x7290C60", VA = "0x187292660", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72923A0", Offset = "0x72909A0", VA = "0x1872923A0", Slot = "7")]
		public void OnBeginDrag(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72924B0", Offset = "0x7290AB0", VA = "0x1872924B0", Slot = "4")]
		public void OnDrag(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7292590", Offset = "0x7290B90", VA = "0x187292590", Slot = "8")]
		public void OnEndDrag(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7292850", Offset = "0x7290E50", VA = "0x187292850", Slot = "9")]
		public void OnPointerEnter(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7292880", Offset = "0x7290E80", VA = "0x187292880", Slot = "10")]
		public void OnPointerExit(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7292470", Offset = "0x7290A70", VA = "0x187292470")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7292910", Offset = "0x7290F10", VA = "0x187292910")]
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
		[Cpp2IlInjected.Address(RVA = "0x728D750", Offset = "0x728BD50", VA = "0x18728D750")]
		public void SetCanvasSortingOrder(short LPBJOLNKPAA, bool DHKIEDDGNJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData OHBNHKBLADH;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x728D9F0", Offset = "0x728BFF0", VA = "0x18728D9F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x728D8F0", Offset = "0x728BEF0", VA = "0x18728D8F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x728D840", Offset = "0x728BE40", VA = "0x18728D840")]
		private void BOLENNJGAEM(GameObject PCFBLHMBIKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x728DCB0", Offset = "0x728C2B0", VA = "0x18728DCB0")]
		public void SetOptionsWithNoDefault(List<string> EJHPODPBOEP, [Optional] string HOJHOIAAMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x728DBC0", Offset = "0x728C1C0", VA = "0x18728DBC0")]
		public void SetOptionsWithNoDefault(List<OptionData> EFDCDFNAODA, [Optional] string HOJHOIAAMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x728DAF0", Offset = "0x728C0F0", VA = "0x18728DAF0", Slot = "42")]
		public override void OnPointerClick(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas KGNDLDHLDJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x728DEE0", Offset = "0x728C4E0", VA = "0x18728DEE0")]
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
		private sealed class LCGEJKCHFKM : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private FEEHCBLGINO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
			[DebuggerHidden]
			public LCGEJKCHFKM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x728F130", Offset = "0x728D730", VA = "0x18728F130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x728F640", Offset = "0x728DC40", VA = "0x18728F640", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[EOFOOIANCED(MLFOJBPNDOB.Self, false, false, false)]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly GNOKBMKHHKC<object> IJIPIBEPAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool HPDEAAADNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? HECJENJIJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? DGPKCMCBEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? DMLNCBLOIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool EKCIPHDPBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool DDFKGHGMHAL;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BHOCAIJMFLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x728EB50", Offset = "0x728D150", VA = "0x18728EB50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KNAKNFBDPBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x728EB00", Offset = "0x728D100", VA = "0x18728EB00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DFOKHBJDGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C60", Offset = "0x8AF260", VA = "0x1808B0C60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x728ED10", Offset = "0x728D310", VA = "0x18728ED10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action CHCDEECKJAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x728EA60", Offset = "0x728D060", VA = "0x18728EA60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x728EC70", Offset = "0x728D270", VA = "0x18728EC70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x728E450", Offset = "0x728CA50", VA = "0x18728E450")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x728E840", Offset = "0x728CE40", VA = "0x18728E840")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x728E7F0", Offset = "0x728CDF0", VA = "0x18728E7F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x728E610", Offset = "0x728CC10", VA = "0x18728E610")]
		public void Hide(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x728E9C0", Offset = "0x728CFC0", VA = "0x18728E9C0")]
		public void Show(object NJLOKHEKBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x728E8D0", Offset = "0x728CED0", VA = "0x18728E8D0")]
		public void Set(object NJLOKHEKBBE, bool JBBJBKHFFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x728E560", Offset = "0x728CB60", VA = "0x18728E560")]
		public void Clear(bool HECNNIILAEE = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x728E620", Offset = "0x728CC20", VA = "0x18728E620")]
		private void KBHPGFGKAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x728E4E0", Offset = "0x728CAE0", VA = "0x18728E4E0")]
		[IteratorStateMachine(typeof(LCGEJKCHFKM))]
		private IEnumerator<FEEHCBLGINO> CJBNEAFPFIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x728E5D0", Offset = "0x728CBD0", VA = "0x18728E5D0", Slot = "5")]
		public virtual void DoHideOrShow(bool NPHJJFJDPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x728E9D0", Offset = "0x728CFD0", VA = "0x18728E9D0")]
		public Hideable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DisallowMultipleComponent]
	public class Hoverable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LCGIHPBPFLI
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8E74D0", Offset = "0x8E5AD0", VA = "0x1808E74D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x869EA0", Offset = "0x8684A0", VA = "0x180869EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<PointerEventData> NKADPOPOHIF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x728EE70", Offset = "0x728D470", VA = "0x18728EE70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x728EFD0", Offset = "0x728D5D0", VA = "0x18728EFD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PointerEventData> LHJDMJHKCPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x728EF20", Offset = "0x728D520", VA = "0x18728EF20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x728F080", Offset = "0x728D680", VA = "0x18728F080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x728EE30", Offset = "0x728D430", VA = "0x18728EE30", Slot = "6")]
		public virtual void OnPointerEnter(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x728EE50", Offset = "0x728D450", VA = "0x18728EE50", Slot = "7")]
		public virtual void OnPointerExit(PointerEventData JICPEOGMFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xE789F0", Offset = "0xE76FF0", VA = "0x180E789F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xE789F0", Offset = "0xE76FF0", VA = "0x180E789F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public Hoverable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class FDNDJLCNGJA
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DOMFPBKOOKE
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static AFMGBHDOKHL GGJKKBMBFIH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static AFMGBHDOKHL JKBAFBIAJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x728E380", Offset = "0x728C980", VA = "0x18728E380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static DOMFPBKOOKE LFACMAHAFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x728E010", Offset = "0x728C610", VA = "0x18728E010")]
		get
		{
			return default(DOMFPBKOOKE);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x728E140", Offset = "0x728C740", VA = "0x18728E140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public static event Action<DOMFPBKOOKE> LPNKPIFJCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x728E2A0", Offset = "0x728C8A0", VA = "0x18728E2A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x728DF30", Offset = "0x728C530", VA = "0x18728DF30")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HPCIIGIKCHC : MDMAEEAKKJG, KOIOGDLPLOM, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, PFJHADLDFFF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	AOBPFOPEJNG ILLMNMNMKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject KBOBDAFPJFJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EFOPDINOAPF Spawn<T>(int LKKNIFBLDOL, IReadOnlyList<T> MMDLBEBNCGC, GameObject KBOBDAFPJFJ);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EFOPDINOAPF Spawn<T>(int LKKNIFBLDOL, IReadOnlyList<T> MMDLBEBNCGC, GameObject IBOFGOLCMCP, Func<int, GameObject> MPECMLFPADI);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int PDMMEDBMFPP, float BCFKKAMJDAN);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	[ExecuteAlways]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public enum OIKLMILDPFL : byte
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
		private static readonly int BIAACCNNPHK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Dictionary<OIKLMILDPFL, string> LDCHPPKJOGP;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int CILPBGOEFGO = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int HNCMJIMAPDG;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int DEEMLIKDGLM;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int FIFPCFBGJBL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int DECBFNCGJAB;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly int KEIKGBOPBII;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly int GCHBOKKKGGG;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly int BHBBNFPPFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool LIFCKDHKDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool IBEFGDBBDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Color[] NLKLMJKLIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private OIKLMILDPFL type;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static readonly OIKLMILDPFL[] KKBPPAJCLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[EHLKLBCDNAM("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly OIKLMILDPFL[] OLFIKFMBFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[EHLKLBCDNAM("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[EHLKLBCDNAM("type", OIKLMILDPFL.CustomDirection)]
		[SerializeField]
		[Range(0f, 360f)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		[EHLKLBCDNAM("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override Graphic PKKDEHMPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool MMHFPBFJOGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Gradient BPBIADIKFOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x868CC0", Offset = "0x8672C0", VA = "0x180868CC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7292110", Offset = "0x7290710", VA = "0x187292110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public OIKLMILDPFL LADEKBPIHJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x950160", Offset = "0x94E760", VA = "0x180950160")]
			get
			{
				return default(OIKLMILDPFL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7292290", Offset = "0x7290890", VA = "0x187292290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private bool AEIJICKDNGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7291B10", Offset = "0x7290110", VA = "0x187291B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Vector2 AKJBDIOFCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7292080", Offset = "0x7290680", VA = "0x187292080")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x72920C0", Offset = "0x72906C0", VA = "0x1872920C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private bool HKIHNCEHIDF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x72917F0", Offset = "0x728FDF0", VA = "0x1872917F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Vector2 ELBJGPEEFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x72920A0", Offset = "0x72906A0", VA = "0x1872920A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7292240", Offset = "0x7290840", VA = "0x187292240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float IODHHCBOFGN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8F7E30", Offset = "0x8F6430", VA = "0x1808F7E30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x15FF460", Offset = "0x15FDA60", VA = "0x1815FF460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 CLPFEJOFFHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7291B80", Offset = "0x7290180", VA = "0x187291B80")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector2 IEBNJHNKMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7291860", Offset = "0x728FE60", VA = "0x187291860")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float BANAEJFBOFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x881AD0", Offset = "0x8800D0", VA = "0x180881AD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72922A0", Offset = "0x72908A0", VA = "0x1872922A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7291650", Offset = "0x728FC50", VA = "0x187291650", Slot = "12")]
		protected override void DHHHJABILEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7290A80", Offset = "0x728F080", VA = "0x187290A80")]
		private void CEBLJOAFKDC(Color[] EEJDMDOMDOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7290C10", Offset = "0x728F210", VA = "0x187290C10", Slot = "13")]
		protected override void CKDFKENKIKC(Material OLKLLNJBJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x72918F0", Offset = "0x728FEF0", VA = "0x1872918F0", Slot = "14")]
		protected override void IAOHBECIKDP(Material OLKLLNJBJND, bool PCJPKCENFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7291FD0", Offset = "0x72905D0", VA = "0x187291FD0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly MHBEOHJOFMJ AJHJLGNJPDH;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static Sprite MCJFGMNGKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private Material IAGEFGEAFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private Material NJILJHGPBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool APFICNHEPNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private bool HPDEAAADNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private bool CIBAEJAIKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool CMPMDEOIGGJ;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Graphic PKKDEHMPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public abstract Shader ELGFCFLCBDA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual bool MMHFPBFJOGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected virtual bool KBPGNEAFANB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected RectTransform APEGCMDFJJO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x72941F0", Offset = "0x72927F0", VA = "0x1872941F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected Rect IPLKNNKPFCB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x72936F0", Offset = "0x7291CF0", VA = "0x1872936F0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected static Sprite BGMBJBPLOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7293810", Offset = "0x7291E10", VA = "0x187293810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7293290", Offset = "0x7291890", VA = "0x187293290", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7294280", Offset = "0x7292880", VA = "0x187294280", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7294580", Offset = "0x7292B80", VA = "0x187294580", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7294430", Offset = "0x7292A30", VA = "0x187294430", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7293ED0", Offset = "0x72924D0", VA = "0x187293ED0")]
		private void MDINOKDGNMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7293D60", Offset = "0x7292360", VA = "0x187293D60")]
		private void MBPCLNBNPII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7294250", Offset = "0x7292850", VA = "0x187294250")]
		private void NPBNCBILOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72941A0", Offset = "0x72927A0", VA = "0x1872941A0")]
		private void NHFCNEPEILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7293480", Offset = "0x7291A80", VA = "0x187293480")]
		protected void DFPBIPEOJHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7294060", Offset = "0x7292660", VA = "0x187294060")]
		private void MLNHGEIDAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "12")]
		protected virtual void DHHHJABILEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "13")]
		protected virtual void CKDFKENKIKC(Material OLKLLNJBJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "14")]
		protected virtual void IAOHBECIKDP(Material OLKLLNJBJND, bool PCJPKCENFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7293A10", Offset = "0x7292010", VA = "0x187293A10")]
		private void LJBCEDDIMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
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
		private static readonly int JFMKJMNBEFN;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly int MBMEEDAPCMI;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly int EHKIPAKKKIP;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly int OEMNIOIJDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
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
		private Color[] NLKLMJKLIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private float[] CONIKHLKANO;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override Graphic PKKDEHMPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected override bool KBPGNEAFANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<RingLayer> NDJALOEPFAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x868EE0", Offset = "0x8674E0", VA = "0x180868EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 AKJBDIOFCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7294FC0", Offset = "0x72935C0", VA = "0x187294FC0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7294FE0", Offset = "0x72935E0", VA = "0x187294FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7294C90", Offset = "0x7293290", VA = "0x187294C90")]
		public void SetRingLayers(IReadOnlyList<RingLayer> FKPBHHLJBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7294A50", Offset = "0x7293050", VA = "0x187294A50")]
		public bool SetRingLayerColor(int ABCPPKFGKJO, Color PHHAMGLLFIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7294BA0", Offset = "0x72931A0", VA = "0x187294BA0")]
		public bool SetRingLayerSize(int ABCPPKFGKJO, float LPKLLJKOBNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x72948C0", Offset = "0x7292EC0", VA = "0x1872948C0", Slot = "12")]
		protected override void DHHHJABILEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7294740", Offset = "0x7292D40", VA = "0x187294740", Slot = "13")]
		protected override void CKDFKENKIKC(Material OLKLLNJBJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7294A00", Offset = "0x7293000", VA = "0x187294A00", Slot = "14")]
		protected override void IAOHBECIKDP(Material OLKLLNJBJND, bool PCJPKCENFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7294DE0", Offset = "0x72933E0", VA = "0x187294DE0")]
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
		public enum EGGMFJMGFMF
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int HJNDCKPNGJG;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int PMOBFBMGMNI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int ACGABMBIPJL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int DBCIEBOOBNF;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int LMEGFHJOADD;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int OMGMFLAPPPN;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int ANPOKJGJJJK;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int CAGBNFOLKBK;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int ELHDBOIENAF;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int HCEHAKFAIJG;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int CBBIHKACALL;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int PBFNIAGPBEE;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int JCEKGLHLJNE;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static readonly int FGFOBLNGBMA;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly int DAGCGICKHAG;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly int JDLNKBMBFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[HOJLKKKFAJH(MLFOJBPNDOB.Self, false, false, false)]
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
		private EGGMFJMGFMF animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		[EHLKLBCDNAM("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[EHLKLBCDNAM("AnimationDirection", new object[] { 1, 0 })]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override Graphic PKKDEHMPPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected override bool KBPGNEAFANB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite FGPJPLBPFMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7295E50", Offset = "0x7294450", VA = "0x187295E50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7296070", Offset = "0x7294670", VA = "0x187296070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color MMLDDFKGJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8FBA80", Offset = "0x8FA080", VA = "0x1808FBA80")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7296100", Offset = "0x7294700", VA = "0x187296100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color CBAMONLNOCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x90C190", Offset = "0x90A790", VA = "0x18090C190")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7295F40", Offset = "0x7294540", VA = "0x187295F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float HADGDHACCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8F7E50", Offset = "0x8F6450", VA = "0x1808F7E50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7296000", Offset = "0x7294600", VA = "0x187296000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 GMJEOMHDAOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7295E30", Offset = "0x7294430", VA = "0x187295E30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7296020", Offset = "0x7294620", VA = "0x187296020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float MLKNMOMOHBP
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x881720", Offset = "0x87FD20", VA = "0x180881720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7295FC0", Offset = "0x72945C0", VA = "0x187295FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 DJDLNMCPKGC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCBD2D0", Offset = "0xCBB8D0", VA = "0x180CBD2D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7296180", Offset = "0x7294780", VA = "0x187296180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float EBMOFHGLOAB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8DE270", Offset = "0x8DC870", VA = "0x1808DE270")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7295F10", Offset = "0x7294510", VA = "0x187295F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private Matrix4x4 NLBEMFGMEKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7295030", Offset = "0x7293630", VA = "0x187295030")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public EGGMFJMGFMF EPBIKKGIFIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xC70630", Offset = "0xC6EC30", VA = "0x180C70630")]
			get
			{
				return default(EGGMFJMGFMF);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7295F30", Offset = "0x7294530", VA = "0x187295F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float GJPGDNPPPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xDAEF60", Offset = "0xDAD560", VA = "0x180DAEF60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7295FE0", Offset = "0x72945E0", VA = "0x187295FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float POMIHGEDEEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xDAF0B0", Offset = "0xDAD6B0", VA = "0x180DAF0B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7295EF0", Offset = "0x72944F0", VA = "0x187295EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x72950C0", Offset = "0x72936C0", VA = "0x1872950C0", Slot = "13")]
		protected override void CKDFKENKIKC(Material OLKLLNJBJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x72957C0", Offset = "0x7293DC0", VA = "0x1872957C0")]
		private void GKGICOFJOOH(Sprite MODEJOLHIFC, [Out] Vector2 LHFIHJIBBOF, [Out] Vector2 LJCFCOCHBLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7295A70", Offset = "0x7294070", VA = "0x187295A70", Slot = "14")]
		protected override void IAOHBECIKDP(Material OLKLLNJBJND, bool PCJPKCENFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7295DA0", Offset = "0x72943A0", VA = "0x187295DA0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Shader MPECAGLGNNI;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public sealed override Shader ELGFCFLCBDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7296220", Offset = "0x7294820", VA = "0x187296220", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72961D0", Offset = "0x72947D0", VA = "0x1872961D0")]
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
		private SerializableRectTransform KCAGHGAHFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private bool GJBIKFFDLCI;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72905B0", Offset = "0x728EBB0", VA = "0x1872905B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7290890", Offset = "0x728EE90", VA = "0x187290890")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7290810", Offset = "0x728EE10", VA = "0x187290810")]
		private void NIFOCECNNAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7290740", Offset = "0x728ED40", VA = "0x187290740")]
		private void KBHPGFGKAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MHBEOHJOFMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct OJOMBAOCODI : IEquatable<OJOMBAOCODI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Component CAMDIODFJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Action MBJGEGLEODC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly int CKLBJALBJBI;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Component GEIKFMAHLOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7290130", Offset = "0x728E730", VA = "0x187290130")]
		public OJOMBAOCODI(Component CAMDIODFJJE, Action MBJGEGLEODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72900B0", Offset = "0x728E6B0", VA = "0x1872900B0")]
		public void PAIJEEONJHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72900A0", Offset = "0x728E6A0", VA = "0x1872900A0", Slot = "4")]
		public bool Equals(OJOMBAOCODI BHFGHGMPKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7290010", Offset = "0x728E610", VA = "0x187290010", Slot = "0")]
		public override bool Equals(object NJKKPOFFNNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8661A0", Offset = "0x8647A0", VA = "0x1808661A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OOJHIMNGBON : IEnumerator<FEEHCBLGINO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private FEEHCBLGINO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public MHBEOHJOFMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private FEEHCBLGINO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public OOJHIMNGBON(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x72901A0", Offset = "0x728E7A0", VA = "0x1872901A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7290560", Offset = "0x728EB60", VA = "0x187290560", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JLPIFGMKEPF IEIDKHEINJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly int GECPGDECHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly int JBCENPCMIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Func<Component, float> ADAOAIDLHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly Dictionary<Component, OJOMBAOCODI> KJLBLJFMNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly LinkedList<OJOMBAOCODI> CNIKHFGGJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly List<OJOMBAOCODI> BKKLODIGPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private EKNCDBKDOPI OLICFGEMDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private BLLMDHJDMNE ONBBLJIOEJD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private BLLMDHJDMNE IDOMPNNAKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x728FE20", Offset = "0x728E420", VA = "0x18728FE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x728FE90", Offset = "0x728E490", VA = "0x18728FE90")]
	public MHBEOHJOFMJ(JLPIFGMKEPF IEIDKHEINJL, int GECPGDECHEN = -1, int JBCENPCMIIF = -1, [Optional] Func<Component, float> ADAOAIDLHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x728FAC0", Offset = "0x728E0C0", VA = "0x18728FAC0")]
	public void ICCKFJPBMFM(Component CAMDIODFJJE, Action LFEAOPIJFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x728F8D0", Offset = "0x728DED0", VA = "0x18728F8D0")]
	public void EGCJHFHKIGG(Component CAMDIODFJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x728FA60", Offset = "0x728E060", VA = "0x18728FA60")]
	public bool FCNLHHAKMPM(Component JLFHFDLINDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x728F690", Offset = "0x728DC90", VA = "0x18728F690")]
	private void CIGGEIMKAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x728FD20", Offset = "0x728E320", VA = "0x18728FD20")]
	[IteratorStateMachine(typeof(OOJHIMNGBON))]
	private IEnumerator<FEEHCBLGINO> JBMCDKABNLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xAF64C0", Offset = "0xAF4AC0", VA = "0x180AF64C0")]
	[CompilerGenerated]
	private void GEJMOMBIIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x728FDA0", Offset = "0x728E3A0", VA = "0x18728FDA0")]
	[CompilerGenerated]
	private float PCLNGBIFHAJ(OJOMBAOCODI LFEAOPIJFOD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FFABDBNLJPB
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	EDBDBIFMJOB JKNMKPDHLOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool LHCLGHBMNOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OIPILJJBCKA<EDBDBIFMJOB> NADLCHCLEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCCHFOPNOBK(EDBDBIFMJOB LCHHDDEGGDF, bool HEADLJDPPMG = false);
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
