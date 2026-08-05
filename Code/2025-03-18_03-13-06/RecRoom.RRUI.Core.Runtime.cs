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
				[Cpp2IlInjected.Address(RVA = "0x7F97140", Offset = "0x7F96340", VA = "0x187F97140")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Quaternion TargetRectRotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000011")]
				[Cpp2IlInjected.Address(RVA = "0x7F971A0", Offset = "0x7F963A0", VA = "0x187F971A0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 DeltaTargetPosition
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x7F97100", Offset = "0x7F96300", VA = "0x187F97100")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7F96C40", Offset = "0x7F95E40", VA = "0x187F96C40")]
			public void CHNCJNLBCJA(PointerEventData GGNFICACEKO, RectTransform OJKNMNGPPNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7F96D40", Offset = "0x7F95F40", VA = "0x187F96D40")]
			public void DJMCPDGFBKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F97020", Offset = "0x7F96220", VA = "0x187F97020")]
			public void PAJHNPDAAFJ(PointerEventData GGNFICACEKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7F96FD0", Offset = "0x7F961D0", VA = "0x187F96FD0")]
			public void IANHDOLDGJE(float FDAFDNDMBOA, RectTransform OJKNMNGPPNB, Vector3 CHBIEDJMOLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public UIHandleEventData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		[Tooltip("Start dragging immediately when pressed (handle only), vs wait for a drag threshold (for dual-purpose button-handles)")]
		private bool startDragImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly CHAOMIGHCFG<PointerEventData> HandlePointerDownEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly CHAOMIGHCFG<PointerEventData> HandlePointerUpEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly CHAOMIGHCFG<UIHandleEventData> HandleDragStartedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly CHAOMIGHCFG<UIHandleEventData> HandleDragEndedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly CHAOMIGHCFG<UIHandleEventData> HandleDragMovedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly MIOEGIOIKAG PointerStateChangedEvent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly UIHandleEventData AAEKLBOOGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool LKLCKACKMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private bool MKPLNHPEKMM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MKEJAOGLCFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x96A740", Offset = "0x969940", VA = "0x18096A740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7F96480", Offset = "0x7F95680", VA = "0x187F96480")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JNDHFHDLLFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x96A6C0", Offset = "0x9698C0", VA = "0x18096A6C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7F96450", Offset = "0x7F95650", VA = "0x187F96450")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F963D0", Offset = "0x7F955D0", VA = "0x187F963D0")]
		private bool FKOOGAGNDOE(PointerEventData ELLEMLBGHOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F96900", Offset = "0x7F95B00", VA = "0x187F96900", Slot = "5")]
		public void OnPointerDown(PointerEventData ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F969C0", Offset = "0x7F95BC0", VA = "0x187F969C0", Slot = "11")]
		public void OnPointerUp(PointerEventData ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F96770", Offset = "0x7F95970", VA = "0x187F96770", Slot = "6")]
		public void OnInitializePotentialDrag(PointerEventData ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F964B0", Offset = "0x7F956B0", VA = "0x187F964B0", Slot = "7")]
		public void OnBeginDrag(PointerEventData ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F965C0", Offset = "0x7F957C0", VA = "0x187F965C0", Slot = "4")]
		public void OnDrag(PointerEventData ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F966A0", Offset = "0x7F958A0", VA = "0x187F966A0", Slot = "8")]
		public void OnEndDrag(PointerEventData ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F96960", Offset = "0x7F95B60", VA = "0x187F96960", Slot = "9")]
		public void OnPointerEnter(PointerEventData ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F96990", Offset = "0x7F95B90", VA = "0x187F96990", Slot = "10")]
		public void OnPointerExit(PointerEventData ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F96580", Offset = "0x7F95780", VA = "0x187F96580")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F96A20", Offset = "0x7F95C20", VA = "0x187F96A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F92500", Offset = "0x7F91700", VA = "0x187F92500")]
		public void SetCanvasSortingOrder(short JBPJDLDIMEB, bool DNDBGBILNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public CanvasSortingOrder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class Dropdown : TMP_Dropdown
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OptionData ONMNEOMDCGG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F93170", Offset = "0x7F92370", VA = "0x187F93170", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F93050", Offset = "0x7F92250", VA = "0x187F93050", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F92FA0", Offset = "0x7F921A0", VA = "0x187F92FA0")]
		private void DDFABOLPPBF(GameObject DNBCOIHBKDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F93450", Offset = "0x7F92650", VA = "0x187F93450")]
		public void SetOptionsWithNoDefault(List<string> ALKPNNHBNLO, [Optional] string FDMBEPDFAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F93360", Offset = "0x7F92560", VA = "0x187F93360")]
		public void SetOptionsWithNoDefault(List<OptionData> ONCKKBCCJPH, [Optional] string FDMBEPDFAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F93290", Offset = "0x7F92490", VA = "0x187F93290", Slot = "42")]
		public override void OnPointerClick(PointerEventData ELLEMLBGHOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "45")]
		protected override GameObject CreateBlocker(Canvas ODLNKIJEGFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F93670", Offset = "0x7F92870", VA = "0x187F93670")]
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
		private sealed class MBGBLDLLMKO : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private DEPLMKJKOMK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Hideable <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
			[DebuggerHidden]
			public MBGBLDLLMKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7F941E0", Offset = "0x7F933E0", VA = "0x187F941E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7F946F0", Offset = "0x7F938F0", VA = "0x187F946F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		[SerializeField]
		protected RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[CLMHABBIPJG(ADOEJJMOABO.Self, false, false, false)]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly FMFGKDIPDJB<object> NFHMDMLEFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool OOCEJIEFOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Vector3? GOKIMKDELFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private bool? POBHACNOGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool? JIBCDOCJKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool MEALBDCBLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool CECOPPOGKLO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NKGIBNPODMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7F93F00", Offset = "0x7F93100", VA = "0x187F93F00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool CGBNGFABGEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7F93EB0", Offset = "0x7F930B0", VA = "0x187F93EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DCINIGPDKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9AE7F0", Offset = "0x9AD9F0", VA = "0x1809AE7F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7F940C0", Offset = "0x7F932C0", VA = "0x187F940C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ACHDBHPEEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7F93E10", Offset = "0x7F93010", VA = "0x187F93E10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7F94020", Offset = "0x7F93220", VA = "0x187F94020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F93850", Offset = "0x7F92A50", VA = "0x187F93850")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F93BF0", Offset = "0x7F92DF0", VA = "0x187F93BF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F93BA0", Offset = "0x7F92DA0", VA = "0x187F93BA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F93B90", Offset = "0x7F92D90", VA = "0x187F93B90")]
		public void Hide(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F93D70", Offset = "0x7F92F70", VA = "0x187F93D70")]
		public void Show(object GIIKHLJPAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F93C80", Offset = "0x7F92E80", VA = "0x187F93C80")]
		public void Set(object GIIKHLJPAKH, bool CHLHCEJCDMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F938E0", Offset = "0x7F92AE0", VA = "0x187F938E0")]
		public void Clear(bool AOPPFJGGIPP = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F93A10", Offset = "0x7F92C10", VA = "0x187F93A10")]
		private void HPKMOJCOHPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F93950", Offset = "0x7F92B50", VA = "0x187F93950")]
		[IteratorStateMachine(typeof(MBGBLDLLMKO))]
		private IEnumerator<DEPLMKJKOMK> DHPCBOJDMMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F939D0", Offset = "0x7F92BD0", VA = "0x187F939D0", Slot = "5")]
		public virtual void DoHideOrShow(bool OCIOMEJOPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F93D80", Offset = "0x7F92F80", VA = "0x187F93D80")]
		public Hideable()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CELBLJDFECG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum NOOMPPMLPAC
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Dark
	}

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static ECHOGNCJJEK ILAONJJKAGH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static ECHOGNCJJEK OIIEALKPNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7F92130", Offset = "0x7F91330", VA = "0x187F92130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static NOOMPPMLPAC MFAKEEDCGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F92300", Offset = "0x7F91500", VA = "0x187F92300")]
		get
		{
			return default(NOOMPPMLPAC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F91FD0", Offset = "0x7F911D0", VA = "0x187F91FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event Action<NOOMPPMLPAC> KJDKOPEEMIA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F92430", Offset = "0x7F91630", VA = "0x187F92430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F92230", Offset = "0x7F91430", VA = "0x187F92230")]
		[CompilerGenerated]
		remove
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DOPPCJBIMBD : CNCJOENNKAB, FAKBPNCMDAA, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler, LKICNMJJJAK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MIOEGIOIKAG KBAFIBBPAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMKGHLOECBM Clear();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SpawnLoadingPlaceholders(GameObject NMLMOMLHFNF);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMKGHLOECBM Spawn<T>(int JPMMOKBLHGF, IReadOnlyList<T> LJELDKAOCJM, GameObject NMLMOMLHFNF);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EMKGHLOECBM Spawn<T>(int JPMMOKBLHGF, IReadOnlyList<T> LJELDKAOCJM, GameObject BICECOHBKFO, Func<int, GameObject> JMNMIDILGMD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void SmoothScrollTo(int KOOLKCPAFBB, float EJLDFJLHPLA);
}
namespace RRUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[ExecuteAlways]
	[AddComponentMenu("UI/Effects/Gradient", 15)]
	public class UIGradient : UIUberMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum HKPMCHMHIKJ : byte
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
		private static readonly int DEAIJJNJIOG;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Dictionary<HKPMCHMHIKJ, string> BEEMAAIFPAL;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const int MMFKDJPGGPL = 32;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly int FDGCBAKHEML;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly int LKGNBEDNCFH;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly int CLDNHLOPMEF;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly int EOOKEGMOKNN;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly int NNHJFKNCPJK;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly int BAEHMIOCOBM;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly int AFAJEAEHFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		[SerializeField]
		private Graphic graphic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private bool DEOOMPHBBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool FGPHHLNODOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Color[] DKNGKPMKJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Gradient gradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private HKPMCHMHIKJ type;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly HKPMCHMHIKJ[] CENMGJDPCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[NNIBNKKKMAE("ShouldUseCenter")]
		[SerializeField]
		private Vector2 center;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static readonly HKPMCHMHIKJ[] GHICKEOGGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[NNIBNKKKMAE("ShouldUseScale")]
		[SerializeField]
		private Vector2 scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Range(0f, 360f)]
		[SerializeField]
		[NNIBNKKKMAE("type", HKPMCHMHIKJ.CustomDirection)]
		private float customAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[NNIBNKKKMAE("type", new object[]
		{
			(byte)21,
			(byte)20
		})]
		[SerializeField]
		[Range(0f, 5f)]
		private float vignettePower;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override Graphic PGMHAEGHIKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool FJBKNKJPCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Gradient ONBKAFJFFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7F96220", Offset = "0x7F95420", VA = "0x187F96220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HKPMCHMHIKJ FCLHHMOEMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xB62A00", Offset = "0xB61C00", VA = "0x180B62A00")]
			get
			{
				return default(HKPMCHMHIKJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7F963A0", Offset = "0x7F955A0", VA = "0x187F963A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private bool JCHKDIHJNMH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7F94C00", Offset = "0x7F93E00", VA = "0x187F94C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Vector2 EJPEHBNOFFM
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F96190", Offset = "0x7F95390", VA = "0x187F96190")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F961D0", Offset = "0x7F953D0", VA = "0x187F961D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool GGEIKHDKDCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7F94C70", Offset = "0x7F93E70", VA = "0x187F94C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Vector2 KEDFJDMFMBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7F961B0", Offset = "0x7F953B0", VA = "0x187F961B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7F96350", Offset = "0x7F95550", VA = "0x187F96350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float IPBNMLJPCGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xB97500", Offset = "0xB96700", VA = "0x180B97500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1F9C8B0", Offset = "0x1F9BAB0", VA = "0x181F9C8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Vector2 JGADJFFIIPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7F95100", Offset = "0x7F94300", VA = "0x187F95100")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Vector2 NFCMPKGCCNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F94CE0", Offset = "0x7F93EE0", VA = "0x187F94CE0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float AGFOMLKCLNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x97DAA0", Offset = "0x97CCA0", VA = "0x18097DAA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7F963B0", Offset = "0x7F955B0", VA = "0x187F963B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F95B60", Offset = "0x7F94D60", VA = "0x187F95B60", Slot = "12")]
		protected override void NNEAMAKOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7F94D50", Offset = "0x7F93F50", VA = "0x187F94D50")]
		private void EAFKOIFOJCC(Color[] DNMLFCEFJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7F95150", Offset = "0x7F94350", VA = "0x187F95150", Slot = "13")]
		protected override void LLNKEIALPII(Material MDMIJJAMBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7F94EE0", Offset = "0x7F940E0", VA = "0x187F94EE0", Slot = "14")]
		protected override void EJFDKMGCMDC(Material MDMIJJAMBMD, bool DOAMCAICJBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F960E0", Offset = "0x7F952E0", VA = "0x187F960E0")]
		public UIGradient()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ExecuteAlways]
	public abstract class UIMaterialOverride : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static readonly DAJNKCFGNMK FJBPEEDINJL;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Sprite EHAKCLAFNPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Material JHKIAIGGLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Material BGBKGHHFFCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool HNECAEMNFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private bool OOCEJIEFOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private bool FCANDAMNCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private bool OFPFIFCAMKN;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public abstract Graphic PGMHAEGHIKP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public abstract Shader LOKLEHLICJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public virtual bool FJBKNKJPCKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected virtual bool DEODKEEJDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected RectTransform OJKNMNGPPNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7F97D10", Offset = "0x7F96F10", VA = "0x187F97D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected Rect HMBHIGFJJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7F976C0", Offset = "0x7F968C0", VA = "0x187F976C0")]
			get
			{
				return default(Rect);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected static Sprite NMDGAJBCMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7F97B30", Offset = "0x7F96D30", VA = "0x187F97B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F974D0", Offset = "0x7F966D0", VA = "0x187F974D0", Slot = "8")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7F98000", Offset = "0x7F97200", VA = "0x187F98000", Slot = "9")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F98300", Offset = "0x7F97500", VA = "0x187F98300", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F981B0", Offset = "0x7F973B0", VA = "0x187F981B0", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7F977E0", Offset = "0x7F969E0", VA = "0x187F977E0")]
		private void EEOPKKOFKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7F97970", Offset = "0x7F96B70", VA = "0x187F97970")]
		private void IHBCMDNOACI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F97FD0", Offset = "0x7F971D0", VA = "0x187F97FD0")]
		private void OLNJHFHNEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F97AE0", Offset = "0x7F96CE0", VA = "0x187F97AE0")]
		private void JNNNHKJHJJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F97D70", Offset = "0x7F96F70", VA = "0x187F97D70")]
		protected void MPLKNAMAAGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F97390", Offset = "0x7F96590", VA = "0x187F97390")]
		private void APBLFHIMHDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "12")]
		protected virtual void NNEAMAKOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "13")]
		protected virtual void LLNKEIALPII(Material MDMIJJAMBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "14")]
		protected virtual void EJFDKMGCMDC(Material MDMIJJAMBMD, bool DOAMCAICJBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7F98310", Offset = "0x7F97510", VA = "0x187F98310")]
		private void PFMLEDCPHEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
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
		private static readonly int EKNKAMIHGNN;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly int BLEHBINGBHK;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly int DONDHEOJBJH;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly int HIIOOPBJCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
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
		private Color[] DKNGKPMKJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private float[] LHBJEIEOKKO;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override Graphic PGMHAEGHIKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected override bool DEODKEEJDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RingLayer> HOOGNFFELPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 EJPEHBNOFFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7F99130", Offset = "0x7F98330", VA = "0x187F99130")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7F99150", Offset = "0x7F98350", VA = "0x187F99150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F98D40", Offset = "0x7F97F40", VA = "0x187F98D40")]
		public void SetRingLayers(IReadOnlyList<RingLayer> BFDGEGMCFFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7F98B00", Offset = "0x7F97D00", VA = "0x187F98B00")]
		public bool SetRingLayerColor(int HBBGNKHGPFB, Color JLNFDAODDKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7F98C50", Offset = "0x7F97E50", VA = "0x187F98C50")]
		public bool SetRingLayerSize(int HBBGNKHGPFB, float IAGJHPFNLHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7F989C0", Offset = "0x7F97BC0", VA = "0x187F989C0", Slot = "12")]
		protected override void NNEAMAKOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7F98850", Offset = "0x7F97A50", VA = "0x187F98850", Slot = "13")]
		protected override void LLNKEIALPII(Material MDMIJJAMBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F98800", Offset = "0x7F97A00", VA = "0x187F98800", Slot = "14")]
		protected override void EJFDKMGCMDC(Material MDMIJJAMBMD, bool DOAMCAICJBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7F98E90", Offset = "0x7F98090", VA = "0x187F98E90")]
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
		public enum DINGIDAAEJJ
		{
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			None = -1,
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			Rows,
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			Columns
		}

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly int OFGKPNDDGKG;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly int AELEHMPHAPP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly int OILNFANEDDJ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly int LJJACJOHCHM;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly int EHIFPBEINCH;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static readonly int OEBKPKAMPFH;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly int DLMFFOAHDCH;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static readonly int HPFMFMJHMPM;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly int DCFIKFDCDGK;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly int BKFCCCJBALK;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly int FHKDDOANHJJ;

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static readonly int PGCGPKHLCFJ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly int GIPONGELIEB;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly int MGMMECFKBOP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static readonly int BOAPFENCFBO;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int FNBEJIENNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
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
		private DINGIDAAEJJ animationDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[NNIBNKKKMAE("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the primary rows / columns.")]
		private float primaryAnimationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[NNIBNKKKMAE("AnimationDirection", new object[] { 1, 0 })]
		[Tooltip("The animation speed of the alternating rows / columns.")]
		[SerializeField]
		private float altAnimationSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override Graphic PGMHAEGHIKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected override bool DEODKEEJDEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Sprite BGECAPGJPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7F99F50", Offset = "0x7F99150", VA = "0x187F99F50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A170", Offset = "0x7F99370", VA = "0x187F9A170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color KOPILOMOOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xDB1CB0", Offset = "0xDB0EB0", VA = "0x180DB1CB0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A200", Offset = "0x7F99400", VA = "0x187F9A200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color PMECEGKENNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xF4EF50", Offset = "0xF4E150", VA = "0x180F4EF50")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A040", Offset = "0x7F99240", VA = "0x187F9A040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float LOAOELBIDNF
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xB974F0", Offset = "0xB966F0", VA = "0x180B974F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A100", Offset = "0x7F99300", VA = "0x187F9A100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 FLCNAEALPIK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x7F99F30", Offset = "0x7F99130", VA = "0x187F99F30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A120", Offset = "0x7F99320", VA = "0x187F9A120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public float CAGALMNONCE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x97D700", Offset = "0x97C900", VA = "0x18097D700")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A0C0", Offset = "0x7F992C0", VA = "0x187F9A0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 CBPKHCFLGME
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1347CB0", Offset = "0x1346EB0", VA = "0x181347CB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A280", Offset = "0x7F99480", VA = "0x187F9A280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float ALPJELKNLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xF39340", Offset = "0xF38540", VA = "0x180F39340")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A010", Offset = "0x7F99210", VA = "0x187F9A010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private Matrix4x4 DALHEMJCPLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x7F991F0", Offset = "0x7F983F0", VA = "0x187F991F0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public DINGIDAAEJJ FDAMONCFDMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xD44F30", Offset = "0xD44130", VA = "0x180D44F30")]
			get
			{
				return default(DINGIDAAEJJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A030", Offset = "0x7F99230", VA = "0x187F9A030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float ANOBLAAEJKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x14C4DE0", Offset = "0x14C3FE0", VA = "0x1814C4DE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A0E0", Offset = "0x7F992E0", VA = "0x187F9A0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float KAMIOEHIKKI
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x1461CF0", Offset = "0x1460EF0", VA = "0x181461CF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7F99FF0", Offset = "0x7F991F0", VA = "0x187F99FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F99530", Offset = "0x7F98730", VA = "0x187F99530", Slot = "13")]
		protected override void LLNKEIALPII(Material MDMIJJAMBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F99280", Offset = "0x7F98480", VA = "0x187F99280")]
		private void GKICIGJAJLK(Sprite PNLKGKNICPC, [Out] Vector2 PIIJALNFNBL, [Out] Vector2 OHLGINEOBIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F991A0", Offset = "0x7F983A0", VA = "0x187F991A0", Slot = "14")]
		protected override void EJFDKMGCMDC(Material MDMIJJAMBMD, bool DOAMCAICJBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7F99EA0", Offset = "0x7F990A0", VA = "0x187F99EA0")]
		public UITiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class UIUberMaterialOverride : UIMaterialOverride
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static Shader OJMFMMIBHLH;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public sealed override Shader LOKLEHLICJC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7F9A320", Offset = "0x7F99520", VA = "0x187F9A320", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F9A2D0", Offset = "0x7F994D0", VA = "0x187F9A2D0")]
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
		private SerializableRectTransform KEEKBHLCAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool PKJJIKBJIPN;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F94740", Offset = "0x7F93940", VA = "0x187F94740")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F94A20", Offset = "0x7F93C20", VA = "0x187F94A20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F948D0", Offset = "0x7F93AD0", VA = "0x187F948D0")]
		private void DNPDDEHFECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F94950", Offset = "0x7F93B50", VA = "0x187F94950")]
		private void HPKMOJCOHPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public RectTransformHideableAdapter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DAJNKCFGNMK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct GLBBIGMPIOB : IEquatable<GLBBIGMPIOB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly Component IBLIOEFMDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Action EFNDILLJGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly int KMHABEJGJHE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Component ADOPBHOJDCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F937E0", Offset = "0x7F929E0", VA = "0x187F937E0")]
		public GLBBIGMPIOB(Component IBLIOEFMDMM, Action EFNDILLJGIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F93760", Offset = "0x7F92960", VA = "0x187F93760")]
		public void HEELOGLJLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7F93750", Offset = "0x7F92950", VA = "0x187F93750", Slot = "4")]
		public bool Equals(GLBBIGMPIOB LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F936C0", Offset = "0x7F928C0", VA = "0x187F936C0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BMCABMPOGJA : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public DAJNKCFGNMK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public BMCABMPOGJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F91BC0", Offset = "0x7F90DC0", VA = "0x187F91BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F91F80", Offset = "0x7F91180", VA = "0x187F91F80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly ENANHDDEDLG PONIMGFCIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly int MFDIDACPKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int KKMEBACHDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly Func<Component, float> MPCFKGEHABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Dictionary<Component, GLBBIGMPIOB> HEKENFIADKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly LinkedList<GLBBIGMPIOB> KNFKILCOLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly List<GLBBIGMPIOB> PPHCHCJADMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private PHFJKNHMAKK DKDIDNHDFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private KDCKECJKIIM LDGMIIBJGLH;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private KDCKECJKIIM HNAPEDABKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F929D0", Offset = "0x7F91BD0", VA = "0x187F929D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F92E20", Offset = "0x7F92020", VA = "0x187F92E20")]
	public DAJNKCFGNMK(ENANHDDEDLG PONIMGFCIDF, int MFDIDACPKCC = -1, int KKMEBACHDCA = -1, [Optional] Func<Component, float> MPCFKGEHABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F926F0", Offset = "0x7F918F0", VA = "0x187F926F0")]
	public void FECMPOMLDIL(Component IBLIOEFMDMM, Action BHEFDPAMAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F92C90", Offset = "0x7F91E90", VA = "0x187F92C90")]
	public void PNFNJELMILP(Component IBLIOEFMDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F92970", Offset = "0x7F91B70", VA = "0x187F92970")]
	public bool FOLFOHAIEKJ(Component BNCELPABAGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F92A60", Offset = "0x7F91C60", VA = "0x187F92A60")]
	private void MLLAPOOAPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F92670", Offset = "0x7F91870", VA = "0x187F92670")]
	[IteratorStateMachine(typeof(BMCABMPOGJA))]
	private IEnumerator<DEPLMKJKOMK> EICEGLMMJNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xB86400", Offset = "0xB85600", VA = "0x180B86400")]
	[CompilerGenerated]
	private void JIDGIBJHIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F925F0", Offset = "0x7F917F0", VA = "0x187F925F0")]
	[CompilerGenerated]
	private float BNOEJFHLKPF(GLBBIGMPIOB BHEFDPAMAKP)
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
